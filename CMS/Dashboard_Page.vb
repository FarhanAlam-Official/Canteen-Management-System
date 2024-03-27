Imports System.Data.SqlClient
Imports System.Configuration ' Add a reference to System.Configuration

Public Class Dashboard_Page

    ' Connection string to connect to the CMS database 
    Private ReadOnly connectionString As String = ConfigurationManager.ConnectionStrings("CMS.My.MySettings.CMSConnectionString").ConnectionString

    ' On form load, fetch all necessary data and start the timer
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initial data load
        RefreshDashboardData()

        ' Configure the timer
        TimerRefresh.Interval = 300000 ' 5 minutes in milliseconds
        TimerRefresh.Start() ' Start the timer
    End Sub

    ' This method will fetch and refresh all dashboard data
    Private Sub RefreshDashboardData()
        Try
            ' Fetch various data for the dashboard
            FetchTotalOrdersToday()
            FetchTotalRevenueMonth()
            FetchTotalPendingOrders()
            FetchPendingPayments()
            FetchTopInventoryItems()
            FetchBestSellingItemsToday()
            FetchHighestOrderToday()
            FetchOrdersInProgress()

            ' Call the ChartHelper class for daily revenue (if applicable)
            Dim chartHelper As New ChartHelper()
            chartHelper.FetchDailyRevenue(cartesianChartDailyRevenue, connectionString, lblTotalRevenue, lblRevenueChange)
        Catch ex As Exception
            MessageBox.Show("Error refreshing dashboard data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Timer Tick event handler - called every 5 minutes
    Private Sub TimerRefresh_Tick(sender As Object, e As EventArgs) Handles TimerRefresh.Tick
        ' Refresh the dashboard data
        RefreshDashboardData()
    End Sub

    ' Reusable function to execute scalar SQL queries
    Private Function ExecuteScalarQuery(query As String) As Object
        Dim result As Object = Nothing
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    result = command.ExecuteScalar()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error executing query: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return result
    End Function

    ' Function to fetch and display total orders of today
    Private Sub FetchTotalOrdersToday()
        Try
            Dim query As String = "SELECT COUNT(*) FROM Orders WHERE CAST(order_date AS DATE) = CAST(GETDATE() AS DATE)"
            Dim result = ExecuteScalarQuery(query)
            Dim totalOrdersToday As Integer = If(IsDBNull(result), 0, Convert.ToInt32(result))
            lblTotalOrdersToday.Text = totalOrdersToday.ToString()
        Catch ex As Exception
            MessageBox.Show("Error fetching total orders for today: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Function to fetch and display total revenue for the current month
    Private Sub FetchTotalRevenueMonth()
        Try
            Dim query As String = "SELECT SUM(total_amount) FROM Orders WHERE status = 'completed' or status ='Completed' AND MONTH(order_date) = MONTH(GETDATE()) AND YEAR(order_date) = YEAR(GETDATE())"
            Dim result = ExecuteScalarQuery(query)
            Dim totalRevenueMonth As Decimal = If(IsDBNull(result), 0D, Convert.ToDecimal(result))
            lblTotalRevenueMonth.Text = $"Rs. {totalRevenueMonth:F2}"
        Catch ex As Exception
            MessageBox.Show("Error fetching total revenue for the month: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Function to fetch and display total pending orders
    Private Sub FetchTotalPendingOrders()
        Try
            Dim query As String = "SELECT COUNT(*) FROM Orders WHERE (status = 'pending' OR status = 'Pending') AND CAST(order_date AS DATE) = CAST(GETDATE() AS DATE)"
            Dim result = ExecuteScalarQuery(query)
            Dim totalPendingOrders As Integer = If(IsDBNull(result), 0, Convert.ToInt32(result))
            lblPendingOrders.Text = totalPendingOrders.ToString()
        Catch ex As Exception
            MessageBox.Show("Error fetching pending orders: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Function to fetch and display total pending payments
    Private Sub FetchPendingPayments()
        Try
            Dim query As String = "SELECT SUM(amount) FROM Payments WHERE (status = 'pending' OR status = 'Pending') AND CAST(payment_date AS DATE) = CAST(GETDATE() AS DATE)"
            Dim result = ExecuteScalarQuery(query)
            Dim totalPendingPayments As Decimal = If(IsDBNull(result), 0D, Convert.ToDecimal(result))
            lblPendingPayments.Text = $"Rs. {totalPendingPayments:F2}"
        Catch ex As Exception
            MessageBox.Show("Error fetching pending payments: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Function to fetch and display top 5 items with the highest quantity in inventory
    Private Sub FetchTopInventoryItems()
        Dim query As String = "SELECT P.product_name, I.quantity_in_stock " &
                              "FROM Inventory I " &
                              "JOIN Products P ON I.product_id = P.product_id " &
                              "ORDER BY I.quantity_in_stock DESC"
        Dim dt As New DataTable()

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using adapter As New SqlDataAdapter(query, connection)
                    adapter.Fill(dt)
                End Using

                ' Add a Status column to the DataTable based on quantity
                dt.Columns.Add("Status", GetType(String))
                For Each row As DataRow In dt.Rows
                    Dim quantity As Integer = Convert.ToInt32(row("quantity_in_stock"))
                    row("Status") = If(quantity <= 5, "Deficit", If(quantity > 50, "Surplus", "Normal"))
                Next

                ' Bind the DataTable to the DataGridView
                dgvTopInventoryItems.DataSource = dt

                ' Customize the appearance of the DataGridView
                CustomizeDataGridView(dgvTopInventoryItems)
            Catch ex As Exception
                MessageBox.Show("Error fetching top inventory items: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Customize the appearance of DataGridView
    Private Sub CustomizeDataGridView(dgv As DataGridView)
        With dgv
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .RowTemplate.Height = 35
            .ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 191, 99)
            .ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Trebuchet MS", 11, FontStyle.Bold)
            .EnableHeadersVisualStyles = False
            .DefaultCellStyle.Font = New Font("Trebuchet MS", 10)
            .DefaultCellStyle.ForeColor = System.Drawing.Color.Black
            .DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(191, 255, 213)
            .DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .DefaultCellStyle.Padding = New Padding(5)
            .ReadOnly = True
            .AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .GridColor = System.Drawing.Color.Black
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        End With
    End Sub

    ' Cell formatting for DataGridView to color based on stock status
    Private Sub dgvTopInventoryItems_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvTopInventoryItems.CellFormatting
        If e.ColumnIndex = dgvTopInventoryItems.Columns("Status").Index Then
            If e.Value IsNot Nothing Then
                Dim status As String = e.Value.ToString()
                Select Case status
                    Case "Surplus"
                        e.CellStyle.ForeColor = Color.FromArgb(0, 191, 99)
                    Case "Deficit"
                        e.CellStyle.ForeColor = Color.Red
                    Case "Normal"
                        e.CellStyle.ForeColor = Color.Black
                End Select
            End If
        End If
    End Sub

    ' Function to fetch and display best-selling items of today
    Private Sub FetchBestSellingItemsToday()
        Dim query As String = "SELECT TOP 3 P.product_name, SUM(OD.quantity) AS total_quantity, P.price, P.image_url " &
                              "FROM Order_Details OD " &
                              "JOIN Orders O ON OD.order_id = O.order_id " &
                              "JOIN Products P ON OD.product_id = P.product_id " &
                              "WHERE CAST(O.order_date AS DATE) = CAST(GETDATE() AS DATE) " &
                              "GROUP BY P.product_name, P.price, P.image_url " &
                              "ORDER BY total_quantity DESC"
        Dim dt As New DataTable()

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using adapter As New SqlDataAdapter(query, connection)
                    adapter.Fill(dt)
                End Using

                ' Handle no sales today
                If dt.Rows.Count = 0 Then
                    ClearBestSeller()
                Else
                    ' Update the top 3 best-selling items
                    For i As Integer = 0 To dt.Rows.Count - 1
                        Dim row As DataRow = dt.Rows(i)
                        UpdateBestSellerGroupBox(i + 1, row("product_name").ToString(), Convert.ToDecimal(row("price")), row("image_url").ToString())
                    Next
                End If
            Catch ex As Exception
                MessageBox.Show("Error fetching best-selling items: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Clear best seller information when no data is available
    Private Sub ClearBestSeller()
        lblmsg.Visible = True
        groupBox1.Visible = False
        groupBox2.Visible = False
        groupBox3.Visible = False
        picBox1.Visible = False
        picBox2.Visible = False
        picBox3.Visible = False
    End Sub

    ' Update the GroupBox for a best-selling item
    Private Sub UpdateBestSellerGroupBox(groupBoxIndex As Integer, itemName As String, itemPrice As Decimal, imageUrl As String)
        Select Case groupBoxIndex
            Case 1
                SetGroupBoxData(lblitemName1, lblPrice1, picBox1, lblStatus1, itemName, itemPrice, imageUrl, "#1")
            Case 2
                SetGroupBoxData(lblitemName2, lblPrice2, picBox2, lblStatus2, itemName, itemPrice, imageUrl, "#2")
            Case 3
                SetGroupBoxData(lblitemName3, lblPrice3, picBox3, lblStatus3, itemName, itemPrice, imageUrl, "#3")
        End Select
    End Sub

    ' Reusable method to set the data for a specific GroupBox and its associated controls
    Private Sub SetGroupBoxData(lblItemName As Label, lblPrice As Label, picBox As PictureBox, lblStatus As Label, itemName As String, itemPrice As Decimal, imageUrl As String, rank As String)
        lblItemName.Text = itemName
        lblPrice.Text = $"Rs. {itemPrice:F2}"
        lblStatus.Text = rank
        lblStatus.ForeColor = Color.FromArgb(0, 191, 99)

        ' Try loading the product image
        Try
            picBox.Image = Image.FromFile(imageUrl)
        Catch ex As Exception
            picBox.Image = My.Resources.DefaultProductImage ' Default image
        End Try

        picBox.Visible = True
    End Sub

    ' Fetch and display today's highest order amount and customer
    Private Sub FetchHighestOrderToday()
        Dim query As String = "SELECT TOP 1 U.first_name + ' ' + U.last_name AS customer_name, O.total_amount " &
                              "FROM Orders O " &
                              "JOIN User_Details U ON O.customer_id = U.user_id " &
                              "WHERE CAST(O.order_date AS DATE) = CAST(GETDATE() AS DATE) " &
                              "ORDER BY O.total_amount DESC"
        Dim dt As New DataTable()

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using adapter As New SqlDataAdapter(query, connection)
                    adapter.Fill(dt)
                End Using

                If dt.Rows.Count > 0 Then
                    Dim row As DataRow = dt.Rows(0)
                    lblCustomerName.Text = row("customer_name").ToString()
                    lblOrderAmount.Text = $"Rs. {Convert.ToDecimal(row("total_amount")):F2}"
                Else
                    lblCustomerName.Text = "No orders today yet"
                    lblCustomerName.ForeColor = Color.Red
                    lblOrderAmount.Text = "Rs. 0.00"
                    lblOrderAmount.ForeColor = Color.Red
                End If
            Catch ex As Exception
                MessageBox.Show("Error fetching today's highest order: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Function to fetch and display orders in progress (only today's orders)
    Private Sub FetchOrdersInProgress()
        ' Corrected SQL query to get only today's in-progress orders
        Dim query As String = "SELECT O.order_id, U.first_name + ' ' + U.last_name AS customer_name, " &
                              "DATEDIFF(MINUTE, O.order_date, GETDATE()) AS time_since_order " &
                              "FROM Orders O " &
                              "JOIN User_Details U ON O.customer_id = U.user_id " &
                              "WHERE (O.status = 'pending' OR O.status = 'Pending') " &
                              "AND CAST(O.order_date AS DATE) = CAST(GETDATE() AS DATE) " &
                              "ORDER BY O.order_date DESC"

        Dim dt As New DataTable()

        ' Execute query and bind data to DataGridView
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using adapter As New SqlDataAdapter(query, connection)
                    adapter.Fill(dt)
                End Using

                ' Bind data to DataGridView
                dgvOrdersInProgress.DataSource = dt

                ' Set column headers for clarity
                dgvOrdersInProgress.Columns("order_id").HeaderText = "Order ID"
                dgvOrdersInProgress.Columns("customer_name").HeaderText = "Customer Name"
                dgvOrdersInProgress.Columns("time_since_order").HeaderText = "Waiting Time (Min)"

                ' Customize the DataGridView appearance
                CustomizeDataGridView(dgvOrdersInProgress)
            Catch ex As Exception
                MessageBox.Show("Error fetching orders in progress: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

End Class
