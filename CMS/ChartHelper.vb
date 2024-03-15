Imports LiveCharts
Imports LiveCharts.WinForms ' Use WinForms version of CartesianChart
Imports System.Windows.Media ' For SolidColorBrush (LiveCharts styling)
Imports System.Data.SqlClient
Imports LiveCharts.Wpf
Imports System.Windows

Public Class ChartHelper

    ' Function to fetch daily revenue and display it in a line chart using LiveCharts
    Public Sub FetchDailyRevenue(ByRef cartesianChartDailyRevenue As LiveCharts.WinForms.CartesianChart, connectionString As String, ByRef lblTotalRevenue As Label, ByRef lblRevenueChange As Label)
        ' Modified SQL query to include today up to midnight
        Dim query As String = "SELECT CAST(order_date AS DATE) AS order_day, SUM(total_amount) AS total_revenue " &
                              "FROM Orders " &
                              "WHERE order_date >= CONVERT(DATE, DATEADD(DAY, -6, GETDATE())) " &
                              "AND order_date <= CONVERT(DATE, GETDATE()) " &
                              "AND status = 'completed' " &
                              "GROUP BY CAST(order_date AS DATE) " &
                              "ORDER BY order_day"

        Dim dt As New DataTable()

        ' Using SqlConnection to fetch data
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using adapter As New SqlDataAdapter(query, connection)
                    adapter.Fill(dt)
                End Using

                ' Prepare the chart data
                Dim values As New ChartValues(Of Decimal)
                Dim labels As New List(Of String)
                Dim totalRevenueForWeek As Decimal = 0

                ' Generate the last 7 days, even if no data exists for those days
                Dim last7Days As List(Of Date) = Enumerable.Range(0, 7).
                                              Select(Function(i) DateTime.Now.AddDays(-6 + i).Date).
                                              ToList()

                For Each day As Date In last7Days
                    ' Check if the current day exists in the dataset
                    Dim row = dt.AsEnumerable().FirstOrDefault(Function(r) Convert.ToDateTime(r("order_day")) = day)

                    If row IsNot Nothing Then
                        Dim totalRevenue As Decimal = Convert.ToDecimal(row("total_revenue"))
                        values.Add(totalRevenue)
                        totalRevenueForWeek += totalRevenue
                    Else
                        ' If there's no data for the day, add 0
                        values.Add(0)
                    End If

                    ' Add the formatted day label regardless of data availability
                    labels.Add($"{day.ToString("dddd")} ({day.ToString("d MMM")})")  ' e.g., Monday (6th Sep)
                Next

                ' Clear previous data from the chart
                cartesianChartDailyRevenue.Series.Clear()

                ' Create a new series for daily revenue
                Dim lineSeries As New LineSeries() With {
                    .FontFamily = New FontFamily("Trebuchet MS"),
                    .FontSize = 10,
                    .Values = values,
                    .Title = "Revenue",
                    .LineSmoothness = 0.6,
                    .StrokeThickness = 4,
                    .PointGeometry = DefaultGeometries.Circle,
                    .PointGeometrySize = 10,
                    .Stroke = New SolidColorBrush(System.Windows.Media.Color.FromRgb(99, 233, 155)),
                    .Fill = New SolidColorBrush(System.Windows.Media.Color.FromRgb(240, 255, 245))
                }

                ' Add the series to the chart
                cartesianChartDailyRevenue.Series.Add(lineSeries)

                ' Set chart axis labels
                cartesianChartDailyRevenue.AxisX.Clear()
                cartesianChartDailyRevenue.AxisX.Add(New Axis() With {
                    .Title = "Day of Week",
                    .Labels = labels,
                    .Separator = New Separator With {.Step = 1, .IsEnabled = False},
                    .Margin = New Thickness(20)
                })

                cartesianChartDailyRevenue.AxisY.Clear()
                cartesianChartDailyRevenue.AxisY.Add(New Axis() With {
                    .Title = "Revenue (Rs.)",
                    .LabelFormatter = Function(value) "Rs. " & value.ToString("N2"),
                    .Margin = New Thickness(20)
                })

                cartesianChartDailyRevenue.AnimationsSpeed = TimeSpan.FromMilliseconds(500)
                cartesianChartDailyRevenue.BackColor = System.Drawing.Color.White
                cartesianChartDailyRevenue.LegendLocation = LegendLocation.Right

                ' Format the total revenue
                lblTotalRevenue.Text = " Rs. " & FormatNumberAbbreviation(totalRevenueForWeek).ToString()

                ' Calculate and display revenue change
                Dim previousWeekRevenue As Decimal = FetchPreviousWeekRevenue(connectionString)
                If previousWeekRevenue > 0 Then
                    Dim revenueChange As Decimal = totalRevenueForWeek - previousWeekRevenue
                    Dim percentageChange As Decimal = (revenueChange / previousWeekRevenue) * 100
                    lblRevenueChange.Text = If(revenueChange > 0, $"▲ {FormatNumberAbbreviation(revenueChange)} ({percentageChange:F2}%)", $"▼ {FormatNumberAbbreviation(revenueChange)} ({Math.Abs(percentageChange):F2}%)")
                    lblRevenueChange.ForeColor = If(revenueChange > 0, System.Drawing.Color.FromArgb(0, 191, 99), System.Drawing.Color.Red)
                Else
                    lblRevenueChange.Text = " NA "
                End If

            Catch ex As Exception
                MessageBox.Show("Error fetching daily revenue: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    ' Function to fetch the total revenue for the previous week
    Private Function FetchPreviousWeekRevenue(connectionString As String) As Decimal
        Dim previousWeekRevenue As Decimal = 0
        ' SQL query to fetch total revenue from completed orders for the previous week
        Dim query As String = "SELECT SUM(total_amount) AS total_revenue " &
                              "FROM Orders " &
                              "WHERE order_date >= DATEADD(DAY, -14, GETDATE()) " &
                              "AND order_date < DATEADD(DAY, -7, GETDATE()) " &
                              "AND status = 'completed' or status ='Completed'"

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    Dim result = command.ExecuteScalar()
                    previousWeekRevenue = If(IsDBNull(result), 0D, Convert.ToDecimal(result))
                End Using
            Catch ex As Exception
                MessageBox.Show("Error fetching previous week's revenue: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using

        Return previousWeekRevenue
    End Function

    ' Helper function to format large numbers as 1K, 2M, etc.
    Private Function FormatNumberAbbreviation(value As Decimal) As String
        Dim isNegative As Boolean = value < 0
        Dim absValue As Decimal = Math.Abs(value)

        If absValue >= 1000000 Then
            Return (If(isNegative, "-", "") & (absValue / 1000000).ToString("F2") & "M")
        ElseIf absValue >= 1000 Then
            Return (If(isNegative, "-", "") & (absValue / 1000).ToString("F2") & "K")
        Else
            Return (If(isNegative, "-", "") & absValue.ToString("F2"))
        End If
    End Function
End Class
