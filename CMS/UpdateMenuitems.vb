Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO

Public Class UpdateMenuitems
    ' Database connection string
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("CMS.My.MySettings.CMSConnectionString").ConnectionString

    ' Track which DateTimePicker control is active
    Private activeDatePicker As DateTimePicker = Nothing

    ' Store the menu_id after search
    Private currentMenuId As Integer

    ' Form Load Event
    Private Sub UpdateMenuitems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm()
        ModernClockControl.Visible = False

        ' Add event handler for the custom clock control
        AddHandler ModernClockControl.TimeSet, AddressOf ModernClockControl_TimeSet
    End Sub

    ' Center the form on the screen
    Private Sub CenterForm()
        Dim x As Integer = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Dim y As Integer = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(x, y)
    End Sub

    ' Handle Search button click
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchText As String = rtxtSearch.Text.Trim()

        ' Ensure search input is not empty
        If String.IsNullOrEmpty(searchText) Then
            MessageBox.Show("Please enter a MenuItem ID or Product Name to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Search based on selected radio button
        If rbtnMenuitemsID.Checked Then
            SearchProduct("menu_id", searchText)
        ElseIf rbtnMenuitemsName.Checked Then
            SearchProduct("product_name", searchText)
        Else
            MessageBox.Show("Please select a search criteria (ID or Name).", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Perform search for product by specified column and value
    Private Sub SearchProduct(column As String, value As String)
        ' SQL query to fetch product and menu details
        Dim query As String = $"SELECT p.product_name, p.image_url, m.menu_id, m.available_from, m.available_to FROM Menu m JOIN Products p ON m.product_id = p.product_id WHERE {column} = @value"

        ' Use a SqlConnection to query the database
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@value", value)

                Try
                    connection.Open()

                    ' Execute query and read data
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Populate fields with fetched data
                            rtxtboxProductName.Text = reader("product_name").ToString()
                            rtxtboxProductName.ReadOnly = True
                            dtpAvailableFrom.Value = DateTime.Parse(reader("available_from").ToString())
                            dtpAvailableTo.Value = DateTime.Parse(reader("available_to").ToString())

                            ' Store menu_id for future updates
                            currentMenuId = CInt(reader("menu_id"))

                            ' Load product image if available
                            Dim imagePath As String = reader("image_url").ToString()
                            If File.Exists(imagePath) Then
                                picboxProduct.Image = Image.FromFile(imagePath)
                            Else
                                picboxProduct.Image = Nothing
                                MessageBox.Show("Product image not found.", "Image Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If
                        Else
                            MessageBox.Show("No product found with the provided details.", "Product Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                Catch ex As SqlException
                    MessageBox.Show("Error fetching product details: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Catch ex As Exception
                    MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' Handle Update button click to update menu item availability times
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Ensure product name is filled
        If String.IsNullOrEmpty(rtxtboxProductName.Text.Trim()) Then
            MessageBox.Show("Please search for a product before updating.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Format times for database update
        Dim availableFrom As String = dtpAvailableFrom.Value.ToString("HH:mm:ss")
        Dim availableTo As String = dtpAvailableTo.Value.ToString("HH:mm:ss")

        ' SQL query to update menu availability times
        Dim query As String = "UPDATE Menu SET available_from = @availableFrom, available_to = @availableTo WHERE menu_id = @menuId"

        ' Use a SqlConnection to perform the update
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@availableFrom", availableFrom)
                command.Parameters.AddWithValue("@availableTo", availableTo)
                command.Parameters.AddWithValue("@menuId", currentMenuId)

                Try
                    connection.Open()

                    ' Execute the update and check rows affected
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Menu item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    Else
                        MessageBox.Show("Failed to update menu item.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Catch ex As SqlException
                    MessageBox.Show("Error updating menu item: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Catch ex As Exception
                    MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' Event handler for DateTimePicker availableFrom mouse down event
    Private Sub dtpAvailableFrom_MouseDown(sender As Object, e As MouseEventArgs) Handles dtpAvailableFrom.MouseDown
        ' Activate clock control for availableFrom
        activeDatePicker = dtpAvailableFrom
        ModernClockControl.Visible = True
        ModernClockControl.BringToFront()
    End Sub

    ' Event handler for DateTimePicker availableTo mouse down event
    Private Sub dtpAvailableTo_MouseDown(sender As Object, e As MouseEventArgs) Handles dtpAvailableTo.MouseDown
        ' Activate clock control for availableTo
        activeDatePicker = dtpAvailableTo
        ModernClockControl.Visible = True
        ModernClockControl.BringToFront()
    End Sub

    ' Handle time set event from ModernClockControl
    Private Sub ModernClockControl_TimeSet(selectedHour As Integer, selectedMinute As Integer, isPM As Boolean) Handles ModernClockControl.TimeSet
        ' Adjust selected hour for AM/PM
        If isPM AndAlso selectedHour < 12 Then
            selectedHour += 12
        ElseIf Not isPM AndAlso selectedHour = 12 Then
            selectedHour = 0
        End If

        ' Set time in active DateTimePicker
        If activeDatePicker IsNot Nothing Then
            activeDatePicker.Value = New DateTime(activeDatePicker.Value.Year, activeDatePicker.Value.Month, activeDatePicker.Value.Day, selectedHour, selectedMinute, 0)
        End If

        ' Hide the clock control after setting the time
        ModernClockControl.Visible = False
    End Sub

    ' Handle Cancel button click to close the form
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    ' Mouse hover effect for Update button (Change color on hover)
    Private Sub btnUpdate_MouseEnter(sender As Object, e As EventArgs) Handles btnUpdate.MouseEnter
        btnUpdate.BackColor = Color.FromArgb(0, 175, 99) ' Darker green on hover
    End Sub

    Private Sub btnUpdate_MouseLeave(sender As Object, e As EventArgs) Handles btnUpdate.MouseLeave
        btnUpdate.BackColor = Color.FromArgb(0, 191, 99) ' Revert to original color
    End Sub

    ' Mouse hover effect for Cancel button (Change color and text color on hover)
    Private Sub btnCancel_MouseEnter(sender As Object, e As EventArgs) Handles btncancel.MouseEnter
        btncancel.BackColor = Color.FromArgb(0, 191, 99) ' Highlight on hover
        btncancel.ForeColor = Color.White
    End Sub

    Private Sub btnCancel_MouseLeave(sender As Object, e As EventArgs) Handles btncancel.MouseLeave
        btncancel.BackColor = Color.White ' Revert to original background
        btncancel.ForeColor = Color.FromArgb(0, 191, 99) ' Revert to original text color
    End Sub

End Class
