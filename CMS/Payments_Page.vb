Imports LiveCharts
Imports LiveCharts.WinForms
Imports LiveCharts.Wpf
Imports System.Data.SqlClient
Imports System.Windows.Media ' Used for colors in PieChart
Imports System.Configuration ' Used for app.config

Public Class Payments_Page

    ' Connection string will later be moved to app.config for better security and configurability.
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("CMS.My.MySettings.CMSConnectionString").ConnectionString

    Private datefilter As String

    ' Load event for PaymentsControl
    Private Sub PaymentsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set placeholder text for the search box
        rtxtSearch.Text = "Enter Customer ID or Order ID"
        rtxtSearch.ForeColor = System.Drawing.Color.LightGray

        Try
            ' Ensure all buttons and UI elements are properly initialized
            If btnRefresh Is Nothing OrElse btnToday Is Nothing OrElse btnWeekly Is Nothing Then
                MessageBox.Show("Error: One or more buttons or controls are not initialized properly.", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Load initial data (Today as the default filter)
            FetchPaymentData("today")
            LoadPaymentSummary("today")
            LoadTransactionDetails("today")

            ' Add event handlers for the buttons
            AddHandler btnRefresh.Click, AddressOf RefreshPayments
            AddHandler btnToday.Click, AddressOf FilterTodayPayments
            AddHandler btnWeekly.Click, AddressOf FilterWeeklyPayments
            AddHandler btnMonthly.Click, AddressOf FilterMonthlyPayments
            AddHandler dtpMonthly.ValueChanged, AddressOf FilterMonthlyPayments ' When month changes
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading payment data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Event handlers for the "Today", "Weekly", and "Monthly" filters
    Private Sub FilterTodayPayments(sender As Object, e As EventArgs)
        datefilter = "today"
        Try
            FetchPaymentData("today")
            LoadPaymentSummary("today")
            LoadTransactionDetails("today")
        Catch ex As Exception
            MessageBox.Show("Error filtering today's payments: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FilterWeeklyPayments(sender As Object, e As EventArgs)
        datefilter = "weekly"
        Try
            FetchPaymentData("weekly")
            LoadPaymentSummary("weekly")
            LoadTransactionDetails("weekly")
        Catch ex As Exception
            MessageBox.Show("Error filtering weekly payments: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FilterMonthlyPayments(sender As Object, e As EventArgs)
        datefilter = "monthly"
        Try
            dtpMonthly.Visible = True ' Show the date picker when monthly is selected

            ' Calculate the start and end dates for the selected month
            Dim startDate As New DateTime(dtpMonthly.Value.Year, dtpMonthly.Value.Month, 1)
            Dim endDate As DateTime = startDate.AddMonths(1).AddDays(-1)

            FetchPaymentData("monthly", startDate, endDate)
            LoadPaymentSummary("monthly", startDate, endDate)
            LoadTransactionDetails("monthly", startDate, endDate)
        Catch ex As Exception
            MessageBox.Show("Error filtering monthly payments: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Fetch payment data based on the provided filter
    Private Sub FetchPaymentData(filterType As String, Optional startDate As DateTime? = Nothing, Optional endDate As DateTime? = Nothing)
        Dim query As String = "SELECT COUNT(payment_id) AS payment_count, SUM(amount) AS total_amount FROM Payments WHERE status = @status"

        ' Modify the query based on the filter type
        Select Case filterType
            Case "today"
                query &= " AND CAST(payment_date AS DATE) = CAST(GETDATE() AS DATE)"
            Case "weekly"
                query &= " AND payment_date >= DATEADD(DAY, -7, GETDATE()) AND payment_date <= GETDATE()"
            Case "monthly"
                If startDate.HasValue Then
                    query &= " AND payment_date >= @startDate AND payment_date <= @endDate"
                End If
        End Select

        ' Fetch data for each status: Completed, Pending, and Cancelled
        FetchPaymentsForStatus("completed", query, startDate, endDate)
        FetchPaymentsForStatus("pending", query, startDate, endDate)
        FetchPaymentsForStatus("cancelled", query, startDate, endDate)
    End Sub

    ' Fetch and update payment data for a specific status
    Private Sub FetchPaymentsForStatus(status As String, query As String, startDate As DateTime?, endDate As DateTime?)
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@status", status)
                    If startDate.HasValue Then
                        command.Parameters.AddWithValue("@startDate", startDate)
                        command.Parameters.AddWithValue("@endDate", endDate)
                    End If

                    Dim adapter As New SqlDataAdapter(command)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    If dt.Rows.Count > 0 Then
                        Dim row As DataRow = dt.Rows(0)
                        Dim paymentCount As Integer = If(IsDBNull(row("payment_count")), 0, Convert.ToInt32(row("payment_count")))
                        Dim totalAmount As Decimal = If(IsDBNull(row("total_amount")), 0D, Convert.ToDecimal(row("total_amount")))

                        ' Update UI labels based on the status
                        Select Case status
                            Case "completed"
                                lblCompletedCount.Text = paymentCount.ToString() & " payments"
                                lblCompletedAmount.Text = "Rs. " & totalAmount.ToString("N2")
                            Case "pending"
                                lblPendingCount.Text = paymentCount.ToString() & " payments"
                                lblPendingAmount.Text = "Rs. " & totalAmount.ToString("N2")
                            Case "cancelled"
                                lblCancelledCount.Text = paymentCount.ToString() & " payments"
                                lblCancelledAmount.Text = "Rs. " & totalAmount.ToString("N2")
                        End Select
                    Else
                        ' If no data is found, display "No data"
                        Select Case status
                            Case "completed"
                                lblCompletedCount.Text = "No data"
                                lblCompletedAmount.Text = "Rs. 0.00"
                            Case "pending"
                                lblPendingCount.Text = "No data"
                                lblPendingAmount.Text = "Rs. 0.00"
                            Case "cancelled"
                                lblCancelledCount.Text = "No data"
                                lblCancelledAmount.Text = "Rs. 0.00"
                        End Select
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error fetching payment data for " & status & ": " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Refresh the payment data with today's filter
    Private Sub RefreshPayments(sender As Object, e As EventArgs)
        Try
            FetchPaymentData("today")
            LoadPaymentSummary("today")
            LoadTransactionDetails("today")
        Catch ex As Exception
            MessageBox.Show("An error occurred while refreshing payment data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Load payment summary data from the database
    Private Sub LoadPaymentSummary(filterType As String, Optional startDate As DateTime? = Nothing, Optional endDate As DateTime? = Nothing)
        Dim query As String = "
            SELECT 
                COUNT(CASE WHEN status = 'completed' THEN 1 END) AS completed,
                COUNT(CASE WHEN status = 'pending' THEN 1 END) AS pending,
                COUNT(CASE WHEN status = 'cancelled' THEN 1 END) AS cancelled
            FROM Payments"

        ' Apply date filters based on the selected filter type
        Select Case filterType
            Case "today"
                query &= " WHERE CAST(payment_date AS DATE) = CAST(GETDATE() AS DATE)"
            Case "weekly"
                query &= " WHERE payment_date >= DATEADD(DAY, -7, GETDATE()) AND payment_date <= GETDATE()"
            Case "monthly"
                If startDate.HasValue Then
                    query &= " WHERE payment_date >= @startDate AND payment_date <= @endDate"
                End If
        End Select

        Dim completedCount As Integer = 0
        Dim pendingCount As Integer = 0
        Dim canceledCount As Integer = 0

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                If startDate.HasValue Then
                    command.Parameters.AddWithValue("@startDate", startDate)
                    command.Parameters.AddWithValue("@endDate", endDate)
                End If
                Try
                    connection.Open()
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            completedCount = If(IsDBNull(reader("completed")), 0, Convert.ToInt32(reader("completed")))
                            pendingCount = If(IsDBNull(reader("pending")), 0, Convert.ToInt32(reader("pending")))
                            canceledCount = If(IsDBNull(reader("cancelled")), 0, Convert.ToInt32(reader("cancelled")))
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error fetching payment summary: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using

        ' Update the PieChart with the payment summary
        UpdatePieChart(completedCount, pendingCount, canceledCount)
    End Sub

    ' Load transaction details and populate the DataGridView based on filters
    Public Sub LoadTransactionDetails(Optional filterType As String = Nothing, Optional startDate As DateTime? = Nothing, Optional endDate As DateTime? = Nothing, Optional searchQuery As String = Nothing, Optional searchBy As String = Nothing)
        Dim query As String = "
            SELECT 
                p.payment_id AS 'Payment ID',
                u.user_id AS 'Customer ID', 
                ud.first_name + ' ' + ud.last_name AS 'Customer Name',
                p.order_id AS 'Order ID',
                p.amount AS 'Amount',
                p.payment_mode AS 'Payment Mode',
                p.status AS 'Payment Status',
                p.payment_date AS 'Payment Date',
                o.order_date AS 'Order Date',
                o.total_amount AS 'Order Total'
            FROM Payments p
            INNER JOIN Users u ON p.customer_id = u.user_id
            INNER JOIN User_Details ud ON u.user_id = ud.user_id
            INNER JOIN Orders o ON p.order_id = o.order_id"

        ' Apply filters based on the filter type
        Select Case filterType
            Case "today"
                query &= " WHERE CAST(p.payment_date AS DATE) = CAST(GETDATE() AS DATE)"
            Case "weekly"
                query &= " WHERE p.payment_date >= DATEADD(DAY, -7, GETDATE()) AND p.payment_date <= GETDATE()"
            Case "monthly"
                If startDate.HasValue Then
                    query &= " WHERE p.payment_date >= @startDate AND p.payment_date <= @endDate"
                End If
        End Select

        ' Apply search filter
        If Not String.IsNullOrEmpty(searchQuery) Then
            If searchBy = "CustomerID" Then
                query &= " AND p.customer_id = @searchQuery"
            ElseIf searchBy = "OrderID" Then
                query &= " AND p.order_id = @searchQuery"
            End If
        End If

        query &= " ORDER BY p.payment_date DESC"

        ' Execute the query and populate the DataGridView
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    If startDate.HasValue Then
                        command.Parameters.AddWithValue("@startDate", startDate)
                        command.Parameters.AddWithValue("@endDate", endDate)
                    End If
                    If Not String.IsNullOrEmpty(searchQuery) Then
                        command.Parameters.AddWithValue("@searchQuery", searchQuery)
                    End If

                    Dim adapter As New SqlDataAdapter(command)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvTransactionsDetails.DataSource = dt
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading transaction details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        ' Customize the appearance of the DataGridView
        CustomizeDataGridView()
    End Sub

    ' Update PieChart with payment data for Completed, Pending, and Cancelled statuses
    Public Sub UpdatePieChart(completed As Integer, pending As Integer, canceled As Integer)
        Dim seriesCollection As New SeriesCollection()

        ' Customize "Completed" pie slice
        seriesCollection.Add(New PieSeries() With {
            .Title = "Completed",
            .Values = New ChartValues(Of Integer)({completed}),
            .Fill = New SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 191, 99)), ' Green color for completed
            .DataLabels = True,
            .LabelPoint = Function(point) String.Format("{0} ({1:P0})", point.Y, point.Participation)
        })

        ' Customize "Pending" pie slice
        seriesCollection.Add(New PieSeries() With {
            .Title = "Pending",
            .Values = New ChartValues(Of Integer)({pending}),
            .Fill = New SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 165, 0)), ' Orange for pending
            .DataLabels = True,
            .LabelPoint = Function(point) String.Format("{0} ({1:P0})", point.Y, point.Participation)
        })

        ' Customize "Canceled" pie slice
        seriesCollection.Add(New PieSeries() With {
            .Title = "Canceled",
            .Values = New ChartValues(Of Integer)({canceled}),
            .Fill = New SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 69, 0)), ' Red-Orange for canceled
            .DataLabels = True,
            .LabelPoint = Function(point) String.Format("{0} ({1:P0})", point.Y, point.Participation)
        })

        ' Apply the series to the PieChart and set its properties
        If pieChartPayments1 IsNot Nothing Then
            pieChartPayments1.Series = seriesCollection
            pieChartPayments1.AnimationsSpeed = TimeSpan.FromMilliseconds(500)
            pieChartPayments1.LegendLocation = LegendLocation.Right
            pieChartPayments1.Font = New Font("Trebuchet MS", 10)
            pieChartPayments1.BackColor = System.Drawing.Color.White
        Else
            MessageBox.Show("Pie chart is not initialized properly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Customize the appearance of the DataGridView
    Private Sub CustomizeDataGridView()
        dgvTransactionsDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTransactionsDetails.RowTemplate.Height = 40
        dgvTransactionsDetails.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 191, 99)
        dgvTransactionsDetails.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        dgvTransactionsDetails.ColumnHeadersDefaultCellStyle.Font = New Font("Trebuchet MS", 12, FontStyle.Bold)
        dgvTransactionsDetails.EnableHeadersVisualStyles = False
        dgvTransactionsDetails.DefaultCellStyle.Font = New Font("Trebuchet MS", 10)
        dgvTransactionsDetails.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGreen
        dgvTransactionsDetails.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        dgvTransactionsDetails.DefaultCellStyle.Padding = New Padding(5)
        dgvTransactionsDetails.ReadOnly = True
        dgvTransactionsDetails.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray
        dgvTransactionsDetails.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgvTransactionsDetails.GridColor = System.Drawing.Color.Black
    End Sub

    ' Handle cell formatting for DataGridView based on payment status
    Private Sub dgvTransactionsDetails_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvTransactionsDetails.CellFormatting
        If e.ColumnIndex = dgvTransactionsDetails.Columns("Payment Status").Index Then
            If e.Value IsNot Nothing Then
                Dim status As String = e.Value.ToString()
                Select Case status.ToLower()
                    Case "completed"
                        e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(0, 191, 99)
                    Case "pending"
                        e.CellStyle.ForeColor = System.Drawing.Color.Orange
                    Case "cancelled"
                        e.CellStyle.ForeColor = System.Drawing.Color.Red
                End Select
            End If
        End If
    End Sub

    ' Event handler to update payment status from the context menu
    Private Sub StatusMenuItem_Click(sender As Object, e As EventArgs) Handles completedItem.Click, PendingItem.Click, CancelledItem.Click
        Try
            Dim newStatus As String = DirectCast(sender, ToolStripMenuItem).Text
            Dim rowIndex As Integer = dgvTransactionsDetails.CurrentCell.RowIndex
            Dim paymentId As Integer = Convert.ToInt32(dgvTransactionsDetails.Rows(rowIndex).Cells("Payment ID").Value)
            Dim paymentDate As Date = Convert.ToDateTime(dgvTransactionsDetails.Rows(rowIndex).Cells("Payment Date").Value)

            ' Only allow status changes for today's payments
            If paymentDate.Date = DateTime.Today Then
                UpdatePaymentStatus(paymentId, newStatus)
                LoadTransactionDetails("today") ' Refresh today's transactions
            Else
                MessageBox.Show("Status updates are only permitted for payments made today.", "Update Restriction", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating payment status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Handle right-click event to show context menu and select appropriate options
    Private Sub dgvTransactionsDetails_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvTransactionsDetails.CellMouseDown
        Try
            If e.Button = MouseButtons.Right AndAlso e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                dgvTransactionsDetails.CurrentCell = dgvTransactionsDetails.Rows(e.RowIndex).Cells(e.ColumnIndex)

                ' Hide all items initially
                For Each item As ToolStripMenuItem In cmenustripTransaction.Items
                    item.Visible = False
                Next

                ' Show the correct items based on the clicked column
                If e.ColumnIndex = dgvTransactionsDetails.Columns("Payment Status").Index Then
                    cmenustripTransaction.Items(0).Visible = True
                    cmenustripTransaction.Items(1).Visible = True
                    cmenustripTransaction.Items(2).Visible = True
                End If

                ' Show the context menu at the clicked location
                cmenustripTransaction.Show()
            End If
        Catch ex As Exception
            MessageBox.Show("Error handling context menu: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Update payment status in the database
    Private Sub UpdatePaymentStatus(paymentId As Integer, newStatus As String)
        Dim query As String = "UPDATE Payments SET status = @status WHERE payment_id = @paymentId"

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@status", newStatus)
                    command.Parameters.AddWithValue("@paymentId", paymentId)
                    command.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error updating payment status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Search functionality for payments based on Customer ID or Order ID
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchQuery As String = rtxtSearch.Text.Trim()

        ' Validate search input
        If String.IsNullOrEmpty(searchQuery) Then
            MessageBox.Show("Please enter a Customer ID or Order ID to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Ensure the search input is numeric
        If Not Integer.TryParse(searchQuery, New Integer()) Then
            MessageBox.Show("Please enter a valid numeric Customer ID or Order ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Ensure one of the radio buttons is selected
        If Not rbtnCustomerID.Checked AndAlso Not rbtnOrderID.Checked Then
            MessageBox.Show("Please select whether to search by Customer ID or Order ID.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Perform the search based on the selected option
        If rbtnCustomerID.Checked Then
            LoadTransactionDetails(datefilter, searchQuery:=searchQuery, searchBy:="CustomerID")
        ElseIf rbtnOrderID.Checked Then
            LoadTransactionDetails(datefilter, searchQuery:=searchQuery, searchBy:="OrderID")
        End If
    End Sub

    ' Event handler for viewing all records without date filtering
    Private Sub btnAllRecord_Click(sender As Object, e As EventArgs) Handles btnAllRecord.Click
        Dim searchQuery As String = rtxtSearch.Text.Trim()

        ' Validate search input
        If String.IsNullOrEmpty(searchQuery) Then
            MessageBox.Show("Please enter a Customer ID or Order ID to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Ensure the search input is numeric
        If Not Integer.TryParse(searchQuery, New Integer()) Then
            MessageBox.Show("Please enter a valid numeric Customer ID or Order ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Perform the search based on the selected option without date filter
        If rbtnCustomerID.Checked Then
            LoadTransactionDetails(searchQuery:=searchQuery, searchBy:="CustomerID")
        ElseIf rbtnOrderID.Checked Then
            LoadTransactionDetails(searchQuery:=searchQuery, searchBy:="OrderID")
        End If
    End Sub

    Dim selectedButton As New Button
    ' MouseEnter event for button hover effect
    Private Sub btn_MouseEnter(sender As Object, e As EventArgs) Handles btnToday.MouseEnter, btnWeekly.MouseEnter, btnMonthly.MouseEnter
        If Not sender.Equals(selectedButton) Then
            DirectCast(sender, Button).BackColor = System.Drawing.Color.FromArgb(0, 191, 99)
        End If
    End Sub

    ' MouseLeave event for button hover effect
    Private Sub btn_MouseLeave(sender As Object, e As EventArgs) Handles btnToday.MouseLeave, btnWeekly.MouseLeave, btnMonthly.MouseLeave
        If Not sender.Equals(selectedButton) Then
            DirectCast(sender, Button).BackColor = System.Drawing.Color.White
        End If
    End Sub

    ' Placeholder text handling for the search box
    Private Sub rtxtSearch_Enter(sender As Object, e As EventArgs) Handles rtxtSearch.Enter
        If rtxtSearch.Text = "Enter Customer ID or Order ID" Then
            rtxtSearch.Text = ""
            rtxtSearch.ForeColor = System.Drawing.Color.Black
        End If
    End Sub

    Private Sub rtxtSearch_Leave(sender As Object, e As EventArgs) Handles rtxtSearch.Leave
        If String.IsNullOrWhiteSpace(rtxtSearch.Text) Then
            rtxtSearch.Text = "Enter Customer ID or Order ID"
            rtxtSearch.ForeColor = System.Drawing.Color.Gray
        End If
    End Sub

    'Mouse enter and Mouse leave events to handle Hover effect for refresh button
    Private Sub btnRefresh_MouseEnter(sender As Object, e As EventArgs) Handles btnRefresh.MouseEnter
        btnRefresh.BackColor = System.Drawing.Color.FromArgb(0, 175, 99) ' Darker shade for hover
    End Sub

    Private Sub btnRefresh_MouseLeave(sender As Object, e As EventArgs) Handles btnRefresh.MouseLeave
        btnRefresh.BackColor = System.Drawing.Color.FromArgb(0, 191, 99) ' Original color
    End Sub

End Class
