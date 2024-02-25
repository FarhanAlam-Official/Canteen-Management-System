Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows
Imports System.Windows.Media
Imports LiveCharts
Imports LiveCharts.WinForms
Imports LiveCharts.Wpf

Public Class Analytics_Page
    ' Connection string to connect to the CMS database (you will later move it to app.config)
    Private ReadOnly connectionString As String = ConfigurationManager.ConnectionStrings("CMS.My.MySettings.CMSConnectionString").ConnectionString

    ' This method is executed when the AnalyticsControl form is loaded
    Private Sub AnalyticsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Initially Load the data 
        RefreshPage()

        ' Configure the timer
        TimerRefresh.Interval = 300000 ' 5 minutes in milliseconds
        TimerRefresh.Start() ' Start the timer
    End Sub

    Private Sub RefreshPage()
        Try
            ' Start the refresh timer to update data periodically
            TimerRefresh.Start()

            ' Load Sales by Category Chart with default filter ("Weekly") on form load
            LoadSalesByCategoryChart("Weekly")

            ' Load the Monthly Sales Growth Chart on form load
            LoadMonthlySalesGrowthChart()

            ' Load the Order Summary Chart on form load
            LoadOrderSummaryChart()

            ' Load the Payment Summary with default filter ("Today") on form load
            LoadPaymentSummary("Today")

            ' Load the User Summary with default filter ("Status") on form load
            LoadUserSummary("Status")

            'Load Orders Chunk Rate
            FetchOrdersByLoginStatus()

        Catch ex As Exception
            MessageBox.Show("Error refreshing Analytics data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadSalesByCategoryChart(timeRange As String)
        Dim values As New ChartValues(Of Decimal)
        Dim labels As New List(Of String)

        ' SQL query to fetch sales by category
        Dim query As String = "SELECT c.category_name, SUM(od.quantity * od.price) AS total_sales " &
                          "FROM Order_Details od " &
                          "JOIN Categories c ON od.category_id = c.category_id " &
                          "JOIN Orders o ON od.order_id = o.order_id " &
                          "WHERE o.status = 'completed' "

        ' Modify the query based on the selected time range
        Select Case timeRange
            Case "Today"
                query &= "AND CAST(o.order_date AS DATE) = CAST(GETDATE() AS DATE) "
            Case "Weekly"
                query &= "AND o.order_date >= DATEADD(DAY, -7, GETDATE()) "
            Case "Monthly"
                ' Use the specific month from the DatePicker control
                Dim selectedMonth As Date = dtpSalesCategoryDate.Value
                query &= "AND YEAR(o.order_date) = " & selectedMonth.Year & " AND MONTH(o.order_date) = " & selectedMonth.Month
        End Select

        query &= "GROUP BY c.category_name"

        Using connection As New SqlConnection(connectionString)
            Try
                Dim dt As New DataTable()
                connection.Open()

                ' Fill the data into DataTable
                Using adapter As New SqlDataAdapter(query, connection)
                    adapter.Fill(dt)
                End Using

                ' Clear any existing series in the chart
                chartSalesByCategory.Series.Clear()

                ' Check if there's no data
                If dt.Rows.Count = 0 Then
                    ' Add a placeholder label and empty value when no data is available
                    labels.Add("No Data")
                    values.Add(0)
                Else
                    ' Process data and fill chart values and labels
                    For Each row As DataRow In dt.Rows
                        Dim categoryName As String = row("category_name").ToString()
                        Dim totalSales As Decimal = Convert.ToDecimal(row("total_sales"))
                        values.Add(totalSales)
                        labels.Add(categoryName)
                    Next
                End If

                ' Create and configure the ColumnSeries for displaying sales
                Dim columnSeries As New ColumnSeries With {
                .Values = values,
                .Title = "Sales",
                .DataLabels = True, ' Display the value on top of each bar
                .Fill = New SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 191, 99)) ' Green bar color
            }

                ' Add the series to the chart
                chartSalesByCategory.Series.Add(columnSeries)

                ' Set chart background color
                chartSalesByCategory.Background = New SolidColorBrush(System.Windows.Media.Colors.White)

                ' Trigger the animation by updating the chart
                chartSalesByCategory.AnimationsSpeed = TimeSpan.FromMilliseconds(500)
                chartSalesByCategory.Update(True, True) ' This will cause a smooth animation effect

                ' Configure the X-axis (Category Names)
                chartSalesByCategory.AxisX.Clear()
                chartSalesByCategory.AxisX.Add(New Axis With {
                .Title = "Category",
                .Labels = labels,
                .Separator = New Separator With {.Step = 1, .IsEnabled = False}, ' No separator lines
                .Foreground = New SolidColorBrush(System.Windows.Media.Colors.Black),
                .FontSize = 14 ' Increase font size for better readability
            })

                ' Configure the Y-axis (Sales Amounts)
                chartSalesByCategory.AxisY.Clear()
                chartSalesByCategory.AxisY.Add(New Axis With {
                .Title = "Sales (Rs.)",
                .LabelFormatter = Function(value) FormatNumberAbbreviation(CDec(value)),
                .Foreground = New SolidColorBrush(System.Windows.Media.Colors.Black),
                .FontSize = 14 ' Increase font size for better readability
            })

            Catch ex As Exception
                ' Show an error message if the data loading fails
                MessageBox.Show("Error loading sales by category chart: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub LoadMonthlySalesGrowthChart()
        Dim seriesCollection As New SeriesCollection()
        Dim labels As New List(Of String) ' X-axis labels for months

        ' Color List: Customize colors for better visibility
        Dim colors As List(Of System.Windows.Media.Color) = New List(Of System.Windows.Media.Color) From {
        System.Windows.Media.Colors.Blue
    }

        ' SQL query to get sales grouped by year and month
        Dim query As String = "SELECT YEAR(o.order_date) AS [Year], 
                          MONTH(o.order_date) AS [Month], 
                          SUM(od.quantity * od.price) AS total_sales
                   FROM Orders o
                   JOIN Order_Details od ON o.order_id = od.order_id
                   JOIN Categories c ON od.category_id = c.category_id
                   WHERE o.status = 'completed'
                   AND YEAR(o.order_date) = YEAR(GETDATE())
                   GROUP BY YEAR(o.order_date), MONTH(o.order_date)
                   ORDER BY MONTH(o.order_date)"

        Using connection As New SqlConnection(connectionString)
            Try
                Dim dt As New DataTable()
                connection.Open()

                Using adapter As New SqlDataAdapter(query, connection)
                    adapter.Fill(dt)
                End Using

                ' Get the current year
                Dim currentYear As Integer = DateTime.Now.Year

                ' Create a series for the current year's sales
                Dim currentYearValues As New ChartValues(Of Decimal)

                ' Process each month and determine sales for the current year
                For month As Integer = 1 To 12
                    ' Use local variables to avoid lambda expression warnings
                    Dim localMonth As Integer = month
                    Dim localCurrentYear As Integer = currentYear

                    Dim currentYearSales As Decimal = 0

                    ' Find the row for the current year and current month
                    Dim currentYearRow = dt.AsEnumerable().FirstOrDefault(Function(r) r.Field(Of Integer)("Year") = localCurrentYear AndAlso r.Field(Of Integer)("Month") = localMonth)

                    If currentYearRow IsNot Nothing Then
                        currentYearSales = Convert.ToDecimal(currentYearRow("total_sales"))
                    End If

                    currentYearValues.Add(currentYearSales)

                    ' Add month labels
                    labels.Add(MonthName(month, True))  ' Use abbreviated month names (Jan, Feb, etc.)
                Next

                ' Add line series for the current year
                seriesCollection.Add(New LineSeries() With {
                .Title = $"{currentYear} Sales",
                .Values = currentYearValues,
                .Stroke = New SolidColorBrush(System.Windows.Media.Color.FromRgb(99, 233, 155)),
                .Fill = New SolidColorBrush(System.Windows.Media.Color.FromRgb(240, 255, 245)),
                .PointGeometry = DefaultGeometries.Circle,
                .PointGeometrySize = 10,
                .StrokeThickness = 3,
                .LabelPoint = Function(point) point.Y.ToString("N2"),
                .FontFamily = New System.Windows.Media.FontFamily("Trebuchet MS"),
                .FontSize = 8,
                .LineSmoothness = 0.3
            })

                ' Clear existing series and axes
                chartMonthlySales.Series.Clear()
                chartMonthlySales.AxisX.Clear()
                chartMonthlySales.AxisY.Clear()

                ' Set chart background color
                chartMonthlySales.Background = New SolidColorBrush(System.Windows.Media.Colors.White)

                ' Add the new series collection to the chart
                chartMonthlySales.Series = seriesCollection

                ' Configure X-axis (Months)
                chartMonthlySales.AxisX.Add(New Axis With {
                .Title = "Month",
                .Labels = labels,
                .Separator = New Separator With {.Step = 1, .IsEnabled = False},
                .Foreground = New SolidColorBrush(System.Windows.Media.Colors.Black),
                .FontSize = 14,
                .Margin = New Thickness(20)
            })

                ' Configure Y-axis (Sales)
                chartMonthlySales.AxisY.Add(New Axis With {
                .Title = "Sales (Rs.)",
                .LabelFormatter = Function(value) FormatNumberAbbreviation(CDec(value)),
                .Foreground = New SolidColorBrush(System.Windows.Media.Colors.Black),
                .FontSize = 14
            })


                ' Tooltips can be enabled by setting DataLabels to True in each series
                ' If a separate tooltip control is needed, configure it accordingly

                ' Update chart with smooth animation
                chartMonthlySales.AnimationsSpeed = TimeSpan.FromMilliseconds(500)
                chartMonthlySales.Update(True, True)

            Catch ex As SqlException
                MessageBox.Show("Database error: " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("Error loading monthly sales growth chart: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub LoadOrderSummaryChart()
        Dim seriesCollection As New SeriesCollection()
        Dim labels As New List(Of String) ' X-axis labels for months

        ' SQL query to get order counts grouped by status and month
        Dim query As String = "SELECT YEAR(o.order_date) AS [Year], 
                                  MONTH(o.order_date) AS [Month], 
                                  o.status, 
                                  COUNT(*) AS order_count
                           FROM Orders o
                           WHERE YEAR(o.order_date) = YEAR(GETDATE())
                           GROUP BY YEAR(o.order_date), MONTH(o.order_date), o.status
                           ORDER BY MONTH(o.order_date), o.status"

        Using connection As New SqlConnection(connectionString)
            Try
                Dim dt As New DataTable()
                connection.Open()

                Using adapter As New SqlDataAdapter(query, connection)
                    adapter.Fill(dt)
                End Using

                ' Create series for each order status
                Dim completedOrders As New ChartValues(Of Integer)()
                Dim pendingOrders As New ChartValues(Of Integer)()
                Dim canceledOrders As New ChartValues(Of Integer)()

                ' Process data and fill series
                For month As Integer = 1 To 12
                    Dim localMonth As Integer = month
                    ' Default values if no data for the month
                    Dim completedCount As Integer = 0
                    Dim pendingCount As Integer = 0
                    Dim canceledCount As Integer = 0

                    ' Find rows for the current month
                    Dim monthRows = dt.AsEnumerable().Where(Function(r) r.Field(Of Integer)("Month") = localMonth)

                    For Each row In monthRows
                        Select Case row.Field(Of String)("status")
                            Case "completed", "Completed"
                                completedCount = Convert.ToInt32(row("order_count"))
                            Case "pending", "Pending"
                                pendingCount = Convert.ToInt32(row("order_count"))
                            Case "canceled", "Canceled"
                                canceledCount = Convert.ToInt32(row("order_count"))
                        End Select
                    Next

                    completedOrders.Add(completedCount)
                    pendingOrders.Add(pendingCount)
                    canceledOrders.Add(canceledCount)

                    ' Add month labels
                    labels.Add(MonthName(month, True)) ' Use abbreviated month names (Jan, Feb, etc.)
                Next

                ' Add line series for each order status
                seriesCollection.Add(New LineSeries() With {
                .Title = "Completed Orders",
                .Values = completedOrders,
                .Stroke = New SolidColorBrush(System.Windows.Media.Color.FromRgb(99, 233, 155)),  ' Green
                .Fill = New SolidColorBrush(System.Windows.Media.Color.FromRgb(240, 255, 245)), ' Light green gradient
                .PointGeometry = DefaultGeometries.Circle,
                .PointGeometrySize = 8,
                .StrokeThickness = 3,
                .LineSmoothness = 0.3
            })

                seriesCollection.Add(New LineSeries() With {
                .Title = "Pending Orders",
                .Values = pendingOrders,
                .Stroke = New SolidColorBrush(System.Windows.Media.Color.FromRgb(247, 247, 89)), ' Yellow
                .Fill = New SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 204)), ' Light yellow gradient
                .PointGeometry = DefaultGeometries.Circle,
                .PointGeometrySize = 8,
                .StrokeThickness = 3,
                .LineSmoothness = 0.3
            })

                seriesCollection.Add(New LineSeries() With {
                .Title = "Canceled Orders",
                .Values = canceledOrders,
                .Stroke = New SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 82, 82)), ' Red
                .Fill = New SolidColorBrush(System.Windows.Media.Color.FromRgb(250, 217, 217)), ' Light red gradient
                .PointGeometry = DefaultGeometries.Circle,
                .PointGeometrySize = 8,
                .StrokeThickness = 3,
                .LineSmoothness = 0.3
            })

                ' Clear existing series and axes
                chartOrderSummary.Series.Clear()
                chartOrderSummary.AxisX.Clear()
                chartOrderSummary.AxisY.Clear()

                ' Set chart background color
                chartOrderSummary.Background = New SolidColorBrush(System.Windows.Media.Colors.White)

                ' Add the new series collection to the chart
                chartOrderSummary.Series = seriesCollection

                ' Configure X-axis (Months)
                chartOrderSummary.AxisX.Add(New Axis With {
                .Title = "Month",
                .Labels = labels,
                .Separator = New Separator With {.Step = 1, .IsEnabled = False},
                .Foreground = New SolidColorBrush(System.Windows.Media.Colors.Black),
                .FontSize = 14,
                .Margin = New Thickness(20)
            })

                ' Configure Y-axis (Order Counts)
                chartOrderSummary.AxisY.Add(New Axis With {
                .Title = "Order Count",
                .LabelFormatter = Function(value) value.ToString("N0"),
                .Foreground = New SolidColorBrush(System.Windows.Media.Colors.Black),
                .FontSize = 14
            })

                ' Update chart with smooth animation
                chartOrderSummary.AnimationsSpeed = TimeSpan.FromMilliseconds(500)
                chartOrderSummary.Update(True, True)

            Catch ex As SqlException
                MessageBox.Show("Database error: " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("Error loading order summary chart: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadPaymentSummary(filterType As String, Optional startDate As DateTime? = Nothing, Optional endDate As DateTime? = Nothing)
        Dim completedPayments As Integer = 0
        Dim pendingPayments As Integer = 0
        Dim canceledPayments As Integer = 0

        ' SQL query to get payment status data from the database
        Dim query As String = "SELECT status, COUNT(*) AS count FROM Payments WHERE 1=1 "

        ' Modify the query based on the selected time range
        Select Case filterType
            Case "Today"
                query &= "AND CAST(payment_date AS DATE) = CAST(GETDATE() AS DATE) "
            Case "Weekly"
                query &= "AND payment_date >= DATEADD(DAY, -7, GETDATE()) "
            Case "Monthly"
                Dim selectedMonth As Date = dtpPaymentDate.Value
                query &= "AND YEAR(payment_date) = " & selectedMonth.Year & " AND MONTH(payment_date) = " & selectedMonth.Month
            Case "Yearly"
                Dim selectedYear As Date = dtpPaymentDate.Value
                query &= "AND YEAR(payment_date) = " & selectedYear.Year
        End Select

        query &= "GROUP BY (status)"

        ' Execute the query and process the data
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Select Case reader("status").ToString().ToLower()
                                Case "completed"
                                    completedPayments = Convert.ToInt32(reader("count"))
                                Case "pending"
                                    pendingPayments = Convert.ToInt32(reader("count"))
                                Case "cancelled"
                                    canceledPayments = Convert.ToInt32(reader("count"))
                            End Select
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading payment summary: " & ex.Message)
            End Try
        End Using

        ' Initialize and customize the pie chart series
        Dim seriesCollection As New SeriesCollection()

        ' Customize "Completed" pie slice
        seriesCollection.Add(New PieSeries() With {
        .Title = "Completed",
        .Values = New ChartValues(Of Integer)({completedPayments}),
        .Fill = New SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 191, 99)), ' Green color for completed
        .DataLabels = True,
        .LabelPoint = Function(point) String.Format("{0} ({1:P0})", point.Y, point.Participation)
    })

        ' Customize "Pending" pie slice
        seriesCollection.Add(New PieSeries() With {
        .Title = "Pending",
        .Values = New ChartValues(Of Integer)({pendingPayments}),
        .Fill = New SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 165, 0)), ' Orange color for pending
        .DataLabels = True,
        .LabelPoint = Function(point) String.Format("{0} ({1:P0})", point.Y, point.Participation)
    })

        ' Customize "Cancelled" pie slice
        seriesCollection.Add(New PieSeries() With {
        .Title = "Cancelled",
        .Values = New ChartValues(Of Integer)({canceledPayments}),
        .Fill = New SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 0, 0)), ' Red-Orange color for canceled
        .DataLabels = True,
        .LabelPoint = Function(point) String.Format("{0} ({1:P0})", point.Y, point.Participation)
    })

        ' Apply series collection to the PieChart
        If pieChartPaymentSummary IsNot Nothing Then ' Ensure the pie chart control exists
            pieChartPaymentSummary.Series = seriesCollection
            pieChartPaymentSummary.AnimationsSpeed = TimeSpan.FromMilliseconds(500) ' Animation speed
            pieChartPaymentSummary.LegendLocation = LegendLocation.Right ' Place legend on the right
            pieChartPaymentSummary.Font = New Font("Trebuchet MS", 10) ' Set font
            pieChartPaymentSummary.BackColor = System.Drawing.Color.White ' Set background color
        Else
            MessageBox.Show("Pie chart is not initialized properly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub cmbPaymentModeFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPaymentModeFilter.SelectedIndexChanged
        Dim selectedFilter As String = cmbPaymentModeFilter.SelectedItem.ToString()

        ' Show or hide the DatePicker based on the selected filter
        If selectedFilter = "Monthly" Then
            dtpPaymentDate.Visible = True
            dtpPaymentDate.Format = DateTimePickerFormat.Custom
            dtpPaymentDate.CustomFormat = "MMMM" ' Display format
        ElseIf selectedFilter = "Yearly" Then
            dtpPaymentDate.Visible = True
            dtpPaymentDate.Format = DateTimePickerFormat.Custom
            dtpPaymentDate.CustomFormat = "YYYY" ' Display format
        Else
            dtpPaymentDate.Visible = False
        End If

        ' Load the payment summary based on the selected filter
        If selectedFilter = "Monthly" OrElse selectedFilter = "Yearly" Then
            ' Get the start and end dates for the selected month
            Dim startDate As New DateTime(dtpPaymentDate.Value.Year, dtpSalesCategoryDate.Value.Month, 1)
            Dim endDate As DateTime = startDate.AddMonths(1).AddDays(-1)
            LoadPaymentSummary(selectedFilter, startDate, endDate)
        Else
            LoadPaymentSummary(selectedFilter)

        End If
    End Sub

    Private Sub dtppayment_ValueChanged(sender As Object, e As EventArgs) Handles dtpPaymentDate.ValueChanged
        Dim selectedFilter As String = cmbPaymentModeFilter.SelectedItem.ToString()

        ' Load the payment summary based on the selected filter
        If selectedFilter = "Monthly" OrElse selectedFilter = "Yearly" Then
            ' Get the start and end dates for the selected month
            Dim startDate As New DateTime(dtpPaymentDate.Value.Year, dtpSalesCategoryDate.Value.Month, 1)
            Dim endDate As DateTime = startDate.AddMonths(1).AddDays(-1)
            LoadPaymentSummary(selectedFilter, startDate, endDate)
        End If
    End Sub


    Private Sub LoadUserSummary(filterType As String)
        Dim query As String = ""
        Dim seriesCollection As New SeriesCollection()

        ' SQL Query construction based on the selected filter
        Select Case filterType
            Case "Status"
                query = "SELECT CASE WHEN status = 1 THEN 'Active' ELSE 'Inactive' END AS user_status, COUNT(*) AS count " &
                "FROM Users " &
                "GROUP BY status " &
                "ORDER BY CASE WHEN status = 1 THEN 0 ELSE 1 END"


            Case "Age_Group"
                query = "SELECT CASE " &
                    "WHEN age BETWEEN 18 AND 25 THEN '18-25' " &
                    "WHEN age BETWEEN 26 AND 35 THEN '26-35' " &
                    "WHEN age BETWEEN 36 AND 45 THEN '36-45' " &
                    "ELSE '46+' END AS age_group, COUNT(*) AS count " &
                    "FROM User_Details GROUP BY CASE " &
                    "WHEN age BETWEEN 18 AND 25 THEN '18-25' " &
                    "WHEN age BETWEEN 26 AND 35 THEN '26-35' " &
                    "WHEN age BETWEEN 36 AND 45 THEN '36-45' " &
                    "ELSE '46+' END"

            Case "Gender"
                query = "SELECT gender, COUNT(*) AS count FROM User_Details GROUP BY gender"

            Case "User_Type"
                query = "SELECT user_type, COUNT(*) AS count FROM Users GROUP BY user_type"

            Case "Creation_Period"
                query = "SELECT CASE " &
                    "WHEN created_date >= DATEADD(MONTH, -1, GETDATE()) THEN 'Last Month' " &
                    "WHEN created_date >= DATEADD(YEAR, -1, GETDATE()) THEN 'Last Year' " &
                    "ELSE 'Older' END AS period, COUNT(*) AS count " &
                    "FROM User_Details GROUP BY CASE " &
                    "WHEN created_date >= DATEADD(MONTH, -1, GETDATE()) THEN 'Last Month' " &
                    "WHEN created_date >= DATEADD(YEAR, -1, GETDATE()) THEN 'Last Year' " &
                    "ELSE 'Older' END"
        End Select

        ' Execute the query and process the data
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        Dim sliceIndex As Integer = 0
                        While reader.Read()
                            ' Define the default fill color for the pie slices
                            Dim fillColor As New SolidColorBrush(Colors.Gray) ' Default color for other slices

                            ' Apply different colors for the first, second, and third slices
                            Select Case sliceIndex
                                Case 0 'First slice - Green
                                    fillColor = New SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 191, 99)) ' Green color (0, 191, 99)
                                Case 1 ' Second slice - Red
                                    fillColor = New SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 0, 0)) ' Red color (255, 0, 0)
                                Case 2 ' Third slice - Orange
                                    fillColor = New SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 165, 0)) ' Orange color (255, 165, 0)
                                Case 3 ' Fourth slice - Yellow
                                    fillColor = New SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 0)) ' Yellow color (255, 255, 0)
                                Case Else ' Default color for other slices
                                    fillColor = New SolidColorBrush(Colors.Gray) ' Gray for remaining slices
                            End Select


                            ' Add PieSeries based on the result
                            seriesCollection.Add(New PieSeries() With {
                            .Title = reader(0).ToString(), ' Title will be either status, age group, etc.
                            .Values = New ChartValues(Of Integer)({Convert.ToInt32(reader("count"))}),
                            .DataLabels = True,
                            .Fill = fillColor, ' Set the color of the pie slice
                            .LabelPoint = Function(point) String.Format("{0} ({1:P0})", point.Y, point.Participation)
                        })

                            sliceIndex += 1 ' Increment the index to track each slice
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading user summary: " & ex.Message)
            End Try
        End Using

        ' Apply series collection to the PieChart
        If PieChartUserSummary IsNot Nothing Then ' Ensure the pie chart control exists
            PieChartUserSummary.Series = seriesCollection
            PieChartUserSummary.AnimationsSpeed = TimeSpan.FromMilliseconds(500) ' Animation speed
            PieChartUserSummary.LegendLocation = LegendLocation.Right ' Place legend on the right
            PieChartUserSummary.Font = New Font("Trebuchet MS", 10) ' Set font
            PieChartUserSummary.BackColor = System.Drawing.Color.White ' Set background color
        Else
            MessageBox.Show("Pie chart is not initialized properly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub FetchOrdersByLoginStatus()
        Dim query As String = "SELECT " &
                          "SUM(CASE WHEN customer_id IN (1011, 1013) THEN 1 ELSE 0 END) AS guest_orders, " &
                          "SUM(CASE WHEN customer_id NOT IN (1011, 1013) THEN 1 ELSE 0 END) AS logged_in_orders " &
                          "FROM Orders"

        Dim seriesCollection As New SeriesCollection()

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        Dim sliceIndex As Integer = 0
                        If reader.Read() Then
                            Dim guestOrders As Integer = If(IsDBNull(reader("guest_orders")), 0, Convert.ToInt32(reader("guest_orders")))
                            Dim loggedInOrders As Integer = If(IsDBNull(reader("logged_in_orders")), 0, Convert.ToInt32(reader("logged_in_orders")))

                            ' Add PieSeries based on the result
                            Dim ordersData As Integer() = {guestOrders, loggedInOrders}
                            Dim orderTitles As String() = {"Guest Orders", "Logged-in Orders"}

                            For Each orderValue In ordersData.Select(Function(x, i) New With {Key .Value = x, Key .Title = orderTitles(i)})
                                Dim fillColor As New SolidColorBrush(Colors.Gray) ' Default color for other slices

                                ' Apply different colors for each slice
                                Select Case sliceIndex
                                    Case 0 ' First slice - Red
                                        fillColor = New SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 0, 0)) ' Red color
                                    Case 1 ' Second slice - Green
                                        fillColor = New SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 191, 99)) ' Green color
                                    Case Else ' Default color for other slices
                                        fillColor = New SolidColorBrush(Colors.Blue) ' Blue for remaining slices
                                End Select

                                seriesCollection.Add(New PieSeries() With {
                                .Title = orderValue.Title, ' Title will be either "Guest Orders" or "Logged-in Orders"
                                .Values = New ChartValues(Of Integer)({orderValue.Value}),
                                .DataLabels = True,
                                .Fill = fillColor, ' Set the color of the pie slice
                                .LabelPoint = Function(point) String.Format("{0} ({1:P0})", point.Y, point.Participation)
                            })

                                sliceIndex += 1 ' Increment the index to track each slice
                            Next
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error fetching order data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ' Optionally log the exception here
            End Try
        End Using

        ' Apply series collection to the OrdersPieChart
        If PieChartOrderChunRate IsNot Nothing Then ' Ensure the pie chart control exists
            PieChartOrderChunRate.Series = seriesCollection
            PieChartOrderChunRate.AnimationsSpeed = TimeSpan.FromMilliseconds(500) ' Animation speed
            PieChartOrderChunRate.LegendLocation = LegendLocation.Right ' Place legend on the right
            PieChartOrderChunRate.Font = New Font("Trebuchet MS", 10) ' Set font
            PieChartOrderChunRate.BackColor = System.Drawing.Color.White ' Set background color
        Else
            MessageBox.Show("Orders pie chart is not initialized properly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub cmbUserFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUserFilter.SelectedIndexChanged
        Dim selectedFilter As String = cmbUserFilter.SelectedItem.ToString()

        ' Call LoadUserSummary with the selected filter
        LoadUserSummary(selectedFilter)
    End Sub

    ' Event handler for ComboBox selection change
    Private Sub cmbTimeFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTimeFilter.SelectedIndexChanged
        Dim selectedFilter As String = cmbTimeFilter.SelectedItem.ToString()

        Select Case selectedFilter
            Case "Today"
                dtpSalesCategoryDate.Visible = False ' Ensure the DatePicker is invisible
                LoadSalesByCategoryChart("Today")

            Case "Weekly"
                dtpSalesCategoryDate.Visible = False ' Ensure the DatePicker is invisible
                LoadSalesByCategoryChart("Weekly")

            Case "Monthly"
                ' Show DatePicker for month selection
                dtpSalesCategoryDate.Visible = True ' Ensure the DatePicker is visible
                dtpSalesCategoryDate.Format = DateTimePickerFormat.Custom
                dtpSalesCategoryDate.CustomFormat = "MMMM yyyy" ' Format to show "Month Year"
                LoadSalesByCategoryChart("Monthly")

        End Select
    End Sub

    Private Sub dtpMonthly_ValueChanged(sender As Object, e As EventArgs) Handles dtpSalesCategoryDate.ValueChanged
        ' Load data for the selected month
        LoadSalesByCategoryChart("Monthly")
    End Sub

    Private Sub OnRefreshTimerTick(sender As Object, e As EventArgs) Handles TimerRefresh.Tick
        ' Reload all charts and data when the Refresh button is clicked
        RefreshPage()
    End Sub

    Private Function FormatNumberAbbreviation(value As Decimal) As String
        Dim absoluteValue As Decimal = Math.Abs(value)
        Dim formattedValue As String

        If absoluteValue >= 1000000 Then
            formattedValue = (absoluteValue / 1000000).ToString("F2") & "M"
        ElseIf absoluteValue >= 1000 Then
            formattedValue = (absoluteValue / 1000).ToString("F2") & "K"
        Else
            formattedValue = absoluteValue.ToString("F2")
        End If

        ' Include the negative sign if the original value was negative
        If value < 0 Then
            Return "-" & formattedValue
        Else
            Return formattedValue
        End If
    End Function
End Class
