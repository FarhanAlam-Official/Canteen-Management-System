Imports LiveCharts
Imports LiveCharts.WinForms
Imports LiveCharts.Wpf
Imports System.Data.SqlClient
Imports System.Windows.Media ' Used for colors in PieChart
Imports System.Configuration ' Used for app.config
Public Class Orders_Page

    'Connection string to connect to database
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("CMS.My.MySettings.CMSConnectionString").ConnectionString
    Private datefilter As String

    Private Sub OrderManageControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rtxtSearch.Text = "Enter Customer ID or Order ID"
        rtxtSearch.ForeColor = System.Drawing.Color.LightGray

        Try
            If btnRefresh Is Nothing OrElse btnToday Is Nothing OrElse btnWeekly Is Nothing Then
                MessageBox.Show("Error: One or more buttons or controls are not initialized properly.", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            FetchOrderData("today")
            LoadOrderSummary("today")
            LoadOrderDetails("today")

            AddHandler btnRefresh.Click, AddressOf RefreshOrders
            AddHandler btnToday.Click, AddressOf FilterTodayOrders
            AddHandler btnWeekly.Click, AddressOf FilterWeeklyOrders
            AddHandler btnMonthly.Click, AddressOf FilterMonthlyOrders
            AddHandler dtpMonthly.ValueChanged, AddressOf FilterMonthlyOrders
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading order data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub FilterTodayOrders(sender As Object, e As EventArgs)
        datefilter = "today"
        Try
            FetchOrderData("today")
            LoadOrderSummary("today")
            LoadOrderDetails("today")
        Catch ex As Exception
            MessageBox.Show("Error filtering today's orders: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub FilterWeeklyOrders(sender As Object, e As EventArgs)
        datefilter = "weekly"
        Try
            FetchOrderData("weekly")
            LoadOrderSummary("weekly")
            LoadOrderDetails("weekly")
        Catch ex As Exception
            MessageBox.Show("Error filtering weekly orders: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub FilterMonthlyOrders(sender As Object, e As EventArgs)
        datefilter = "monthly"
        Try
            dtpMonthly.Visible = True
            Dim startDate As New DateTime(dtpMonthly.Value.Year, dtpMonthly.Value.Month, 1)
            Dim endDate As DateTime = startDate.AddMonths(1).AddDays(-1)

            FetchOrderData("monthly", startDate, endDate)
            LoadOrderSummary("monthly", startDate, endDate)
            LoadOrderDetails("monthly", startDate, endDate)
        Catch ex As Exception
            MessageBox.Show("Error filtering monthly orders: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub FetchOrderData(filterType As String, Optional startDate As DateTime? = Nothing, Optional endDate As DateTime? = Nothing)
        Dim query As String = "SELECT COUNT(order_id) AS order_count, SUM(total_amount) AS total_amount FROM Orders WHERE status = @status"

        Select Case filterType
            Case "today"
                query &= " AND CAST(order_date AS DATE) = CAST(GETDATE() AS DATE)"
            Case "weekly"
                query &= " AND order_date >= DATEADD(DAY, -7, GETDATE()) AND order_date <= GETDATE()"
            Case "monthly"
                If startDate.HasValue Then
                    query &= " AND order_date >= @startDate AND order_date <= @endDate"
                End If
        End Select

        FetchOrdersForStatus("completed", query, startDate, endDate)
        FetchOrdersForStatus("pending", query, startDate, endDate)
        FetchOrdersForStatus("cancelled", query, startDate, endDate)
    End Sub
    Private Sub FetchOrdersForStatus(status As String, query As String, startDate As DateTime?, endDate As DateTime?)
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
                        Dim orderCount As Integer = If(IsDBNull(row("order_count")), 0, Convert.ToInt32(row("order_count")))
                        Dim totalAmount As Decimal = If(IsDBNull(row("total_amount")), 0D, Convert.ToDecimal(row("total_amount")))

                        Select Case status
                            Case "completed", "Completed"
                                lblCompletedCount.Text = orderCount.ToString() & " orders"
                                lblCompletedAmount.Text = "Rs. " & totalAmount.ToString("N2")
                            Case "pending", "Pending"
                                lblPendingCount.Text = orderCount.ToString() & " orders"
                                lblPendingAmount.Text = "Rs. " & totalAmount.ToString("N2")
                            Case "cancelled", "Cancelled"
                                lblCancelledCount.Text = orderCount.ToString() & " orders"
                                lblCancelledAmount.Text = "Rs. " & totalAmount.ToString("N2")
                        End Select
                    Else
                        Select Case status
                            Case "completed", "Completed"
                                lblCompletedCount.Text = "No data"
                                lblCompletedAmount.Text = "Rs. 0.00"
                            Case "pending", "Pending"
                                lblPendingCount.Text = "No data"
                                lblPendingAmount.Text = "Rs. 0.00"
                            Case "cancelled", "Cancelled"
                                lblCancelledCount.Text = "No data"
                                lblCancelledAmount.Text = "Rs. 0.00"
                        End Select
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error fetching order data for " & status & ": " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub RefreshOrders(sender As Object, e As EventArgs)
        Try
            FetchOrderData("today")
            LoadOrderSummary("today")
            LoadOrderDetails("today")
        Catch ex As Exception
            MessageBox.Show("An error occurred while refreshing order data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadOrderSummary(filterType As String, Optional startDate As DateTime? = Nothing, Optional endDate As DateTime? = Nothing)
        Dim query As String = "
            SELECT 
                COUNT(CASE WHEN status = 'completed' or status='Completed' THEN 1 END) AS completed,
                COUNT(CASE WHEN status = 'pending' or status='Pending' THEN 1 END) AS pending,
                COUNT(CASE WHEN status = 'cancelled' or status='Cancelled' THEN 1 END) AS cancelled
            FROM Orders"

        Select Case filterType
            Case "today"
                query &= " WHERE CAST(order_date AS DATE) = CAST(GETDATE() AS DATE)"
            Case "weekly"
                query &= " WHERE order_date >= DATEADD(DAY, -7, GETDATE()) AND order_date <= GETDATE()"
            Case "monthly"
                If startDate.HasValue Then
                    query &= " WHERE order_date >= @startDate AND order_date <= @endDate"
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
                    MessageBox.Show("Error fetching order summary: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using

        UpdatePieChart(completedCount, pendingCount, canceledCount)
    End Sub

    Public Sub LoadOrderDetails(Optional filterType As String = Nothing, Optional startDate As DateTime? = Nothing, Optional endDate As DateTime? = Nothing, Optional searchQuery As String = Nothing, Optional searchBy As String = Nothing)
        Dim query As String = "
            SELECT 
                o.order_id AS 'Order ID',
                u.user_id AS 'Customer ID', 
                ud.first_name + ' ' + ud.last_name AS 'Customer Name',
                o.total_amount AS 'Order Total',
                o.status AS 'Order Status',
                o.order_date AS 'Order Date'
            FROM Orders o
            INNER JOIN Users u ON o.customer_id = u.user_id
            INNER JOIN User_Details ud ON u.user_id = ud.user_id"

        Select Case filterType
            Case "today"
                query &= " WHERE CAST(o.order_date AS DATE) = CAST(GETDATE() AS DATE)"
            Case "weekly"
                query &= " WHERE o.order_date >= DATEADD(DAY, -7, GETDATE()) AND o.order_date <= GETDATE()"
            Case "monthly"
                If startDate.HasValue Then
                    query &= " WHERE o.order_date >= @startDate AND o.order_date <= @endDate"
                End If
        End Select

        If Not String.IsNullOrEmpty(searchQuery) Then
            If searchBy = "CustomerID" Then
                query &= " AND o.customer_id = @searchQuery"
            ElseIf searchBy = "OrderID" Then
                query &= " AND o.order_id = @searchQuery"
            End If
        End If

        query &= " ORDER BY o.order_date DESC"

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
                    dgvOrdersDetails.DataSource = dt
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading order details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        CustomizeDataGridView()
    End Sub

    Public Sub UpdatePieChart(completed As Integer, pending As Integer, canceled As Integer)
        Dim seriesCollection As New SeriesCollection()

        seriesCollection.Add(New PieSeries() With {
            .Title = "Completed",
            .Values = New ChartValues(Of Integer)({completed}),
            .Fill = New SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 191, 99)),
            .DataLabels = True,
            .LabelPoint = Function(point) String.Format("{0} ({1:P0})", point.Y, point.Participation)
        })

        seriesCollection.Add(New PieSeries() With {
            .Title = "Pending",
            .Values = New ChartValues(Of Integer)({pending}),
            .Fill = New SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 165, 0)),
            .DataLabels = True,
            .LabelPoint = Function(point) String.Format("{0} ({1:P0})", point.Y, point.Participation)
        })

        seriesCollection.Add(New PieSeries() With {
            .Title = "Canceled",
            .Values = New ChartValues(Of Integer)({canceled}),
            .Fill = New SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 69, 0)),
            .DataLabels = True,
            .LabelPoint = Function(point) String.Format("{0} ({1:P0})", point.Y, point.Participation)
        })

        If pieChartOrders IsNot Nothing Then
            pieChartOrders.Series = seriesCollection
            pieChartOrders.AnimationsSpeed = TimeSpan.FromMilliseconds(500)
            pieChartOrders.LegendLocation = LegendLocation.Right
            pieChartOrders.Font = New Font("Trebuchet MS", 10)
            pieChartOrders.BackColor = System.Drawing.Color.White
        Else
            MessageBox.Show("Pie chart is not initialized properly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CustomizeDataGridView()
        dgvOrdersDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvOrdersDetails.RowTemplate.Height = 40
        dgvOrdersDetails.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 191, 99)
        dgvOrdersDetails.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        dgvOrdersDetails.ColumnHeadersDefaultCellStyle.Font = New Font("Trebuchet MS", 12, FontStyle.Bold)
        dgvOrdersDetails.EnableHeadersVisualStyles = False
        dgvOrdersDetails.DefaultCellStyle.Font = New Font("Trebuchet MS", 10)
        dgvOrdersDetails.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGreen
        dgvOrdersDetails.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        dgvOrdersDetails.DefaultCellStyle.Padding = New Padding(5)
        dgvOrdersDetails.ReadOnly = True
        dgvOrdersDetails.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray
        dgvOrdersDetails.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgvOrdersDetails.GridColor = System.Drawing.Color.Black
    End Sub

    Private Sub dgvOrdersDetails_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvOrdersDetails.CellFormatting
        If e.ColumnIndex = dgvOrdersDetails.Columns("Order Status").Index Then
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
    ' Event handler to update order status from the context menu
    Private Sub StatusMenuItem_Click(sender As Object, e As EventArgs) Handles completedItem.Click, PendingItem.Click, CancelledItem.Click
        Try
            Dim newStatus As String = DirectCast(sender, ToolStripMenuItem).Text
            Dim rowIndex As Integer = dgvOrdersDetails.CurrentCell.RowIndex
            Dim orderId As Integer = Convert.ToInt32(dgvOrdersDetails.Rows(rowIndex).Cells("Order ID").Value)
            Dim orderDate As Date = Convert.ToDateTime(dgvOrdersDetails.Rows(rowIndex).Cells("Order Date").Value)

            ' Only allow status changes for today's orders
            If orderDate.Date = DateTime.Today Then
                UpdateOrderStatus(orderId, newStatus)
                LoadOrderDetails("today") ' Refresh today's orders
            Else
                MessageBox.Show("Status updates are only permitted for orders made today.", "Update Restriction", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating order status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Add this event handler to the OrdersPage form
    Private Sub dgvOrders_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrdersDetails.CellDoubleClick
        ' Ensure a valid row is clicked (ignore header clicks)
        If e.RowIndex >= 0 Then
            ' Get the OrderID from the selected row (assuming it's in the first column)
            Dim selectedOrderID As Integer = Convert.ToInt32(dgvOrdersDetails.Rows(e.RowIndex).Cells("Order ID").Value)

            ' Open the OrderDetails_Page form, passing the selected OrderID
            Dim detailsForm As New OrderDetails_Page(selectedOrderID)
            detailsForm.ShowDialog()
        End If
    End Sub

    ' Handle right-click event to show context menu and select appropriate options
    Private Sub dgvOrdersDetails_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvOrdersDetails.CellMouseDown
        Try
            If e.Button = MouseButtons.Right AndAlso e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                dgvOrdersDetails.CurrentCell = dgvOrdersDetails.Rows(e.RowIndex).Cells(e.ColumnIndex)

                ' Hide all items initially
                For Each item As ToolStripMenuItem In ctxmenuOrders.Items
                    item.Visible = False
                Next

                ' Show the correct items based on the clicked column
                If e.ColumnIndex = dgvOrdersDetails.Columns("Order Status").Index Then
                    ctxmenuOrders.Items(0).Visible = True
                    ctxmenuOrders.Items(1).Visible = True
                    ctxmenuOrders.Items(2).Visible = True
                End If

                ' Show the context menu at the clicked location
                ctxmenuOrders.Show()
            End If
        Catch ex As Exception
            MessageBox.Show("Error handling context menu: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Update order status in the database
    Private Sub UpdateOrderStatus(orderId As Integer, newStatus As String)
        Dim query As String = "UPDATE Orders SET status = @status WHERE order_id = @orderId"

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@status", newStatus)
                    command.Parameters.AddWithValue("@orderId", orderId)
                    command.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error updating order status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchQuery As String = rtxtSearch.Text.Trim()

        If String.IsNullOrEmpty(searchQuery) Then
            MessageBox.Show("Please enter a Customer ID or Order ID to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not Integer.TryParse(searchQuery, New Integer()) Then
            MessageBox.Show("Please enter a valid numeric Customer ID or Order ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not rbtnCustomerID.Checked AndAlso Not rbtnOrderID.Checked Then
            MessageBox.Show("Please select whether to search by Customer ID or Order ID.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If rbtnCustomerID.Checked Then
            LoadOrderDetails(datefilter, searchQuery:=searchQuery, searchBy:="CustomerID")
        ElseIf rbtnOrderID.Checked Then
            LoadOrderDetails(datefilter, searchQuery:=searchQuery, searchBy:="OrderID")
        End If
    End Sub

    Private Sub btnAllRecord_Click(sender As Object, e As EventArgs) Handles btnAllRecord.Click
        Dim searchQuery As String = rtxtSearch.Text.Trim()

        If String.IsNullOrEmpty(searchQuery) Then
            MessageBox.Show("Please enter a Customer ID or Order ID to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not Integer.TryParse(searchQuery, New Integer()) Then
            MessageBox.Show("Please enter a valid numeric Customer ID or Order ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If rbtnCustomerID.Checked Then
            LoadOrderDetails(searchQuery:=searchQuery, searchBy:="CustomerID")
        ElseIf rbtnOrderID.Checked Then
            LoadOrderDetails(searchQuery:=searchQuery, searchBy:="OrderID")
        End If
    End Sub

    Dim selectedButton As New Button
    Private Sub btn_MouseEnter(sender As Object, e As EventArgs) Handles btnToday.MouseEnter, btnWeekly.MouseEnter, btnMonthly.MouseEnter
        If Not sender.Equals(selectedButton) Then
            DirectCast(sender, Button).BackColor = System.Drawing.Color.FromArgb(0, 191, 99)
        End If
    End Sub

    Private Sub btn_MouseLeave(sender As Object, e As EventArgs) Handles btnToday.MouseLeave, btnWeekly.MouseLeave, btnMonthly.MouseLeave
        If Not sender.Equals(selectedButton) Then
            DirectCast(sender, Button).BackColor = System.Drawing.Color.White
        End If
    End Sub

    Private Sub rtxtSearch_Enter(sender As Object, e As EventArgs) Handles rtxtSearch.Enter
        If rtxtSearch.Text = "Enter Customer ID or Order ID" Then
            rtxtSearch.Text = ""
            rtxtSearch.ForeColor = System.Drawing.Color.Black
        End If
    End Sub

    Private Sub rtxtSearch_Leave(sender As Object, e As EventArgs) Handles rtxtSearch.Leave
        If String.IsNullOrWhiteSpace(rtxtSearch.Text) Then
            rtxtSearch.Text = "Enter Customer ID or Order ID"
            rtxtSearch.Font = New Font("Trebuchet MS", 12)
            rtxtSearch.ForeColor = System.Drawing.Color.LightGray
        End If
    End Sub

    Private Sub btnRefresh_MouseEnter(sender As Object, e As EventArgs) Handles btnRefresh.MouseEnter
        btnRefresh.BackColor = System.Drawing.Color.FromArgb(0, 175, 99) ' Darker shade for hover
    End Sub

    Private Sub btnRefresh_MouseLeave(sender As Object, e As EventArgs) Handles btnRefresh.MouseLeave
        btnRefresh.BackColor = System.Drawing.Color.FromArgb(0, 191, 99) ' Original color
    End Sub
End Class
