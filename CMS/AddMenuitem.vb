Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO

Public Class AddMenuitem
    ' Connection string to connect to the database
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("CMS.My.MySettings.CMSConnectionString").ConnectionString

    ' Variable to store the active DateTimePicker when using the clock control
    Private activeDatePicker As DateTimePicker

    ' Event: Form Load
    Private Sub AddMenuitem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm() ' Center the form on the screen
        ModernClockControl.Visible = False ' Hide the clock control initially
        PopulateProducts() ' Populate the ComboBox with products from the database
        AddHandler ModernClockControl.TimeSet, AddressOf ModernClockControl_TimeSet ' Handle the clock time selection event
    End Sub

    ' Center the form on the screen
    Private Sub CenterForm()
        Dim x As Integer = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Dim y As Integer = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(x, y)
    End Sub

    ' Populate the ComboBox with products from the database
    Private Sub PopulateProducts()
        Dim query As String = "SELECT product_id, product_name, image_url FROM Products"
        Try
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    connection.Open()
                    Using reader As SqlDataReader = command.ExecuteReader()
                        cmbProducts.Items.Clear()
                        While reader.Read()
                            ' Populate ComboBox with product name, ID, and image URL
                            Dim productId As Integer = Convert.ToInt32(reader("product_id"))
                            Dim productName As String = reader("product_name").ToString()
                            Dim imageUrl As String = reader("image_url").ToString()
                            cmbProducts.Items.Add(New ComboBoxItem(productName, productId, imageUrl))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As SqlException
            ShowError("Error fetching products", ex)
        End Try
    End Sub

    ' Event: Handle Add button click to insert a new menu item
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Validate if a product is selected
        If cmbProducts.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a product.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get selected product details
        Dim selectedProduct As ComboBoxItem = CType(cmbProducts.SelectedItem, ComboBoxItem)
        Dim productId As Integer = selectedProduct.Value
        Dim availableFrom As String = dtpAvailableFrom.Value.ToString("HH:mm:ss")
        Dim availableTo As String = dtpAvailableTo.Value.ToString("HH:mm:ss")
        Dim status As Integer = If(rbtnAvailable.Checked, 1, 0)

        ' Check for duplicate product in the menu
        If MenuItemExists(productId) Then
            MessageBox.Show("This product is already in the menu.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' SQL to insert the new menu item
        Dim query As String = "INSERT INTO Menu (product_id, available_from, available_to, status) VALUES (@productId, @availableFrom, @availableTo, @status)"
        Try
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@productId", productId)
                    command.Parameters.AddWithValue("@availableFrom", availableFrom)
                    command.Parameters.AddWithValue("@availableTo", availableTo)
                    command.Parameters.AddWithValue("@status", status)

                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    ' Check if the insertion was successful
                    If rowsAffected > 0 Then
                        MessageBox.Show("Menu item added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close() ' Close the form after success
                    Else
                        MessageBox.Show("Failed to add menu item.", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using
        Catch ex As SqlException
            ShowError("Error adding menu item", ex)
        End Try
    End Sub

    ' Check if the product already exists in the menu
    Private Function MenuItemExists(productId As Integer) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM Menu WHERE product_id = @productId"
        Try
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@productId", productId)

                    connection.Open()
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    Return count > 0 ' Return true if the product already exists
                End Using
            End Using
        Catch ex As SqlException
            ShowError("Error checking for existing menu item", ex)
            Return False
        End Try
    End Function

    ' Event: Display the clock control for available time selection
    Private Sub dtpAvailableFrom_MouseDown(sender As Object, e As MouseEventArgs) Handles dtpAvailableFrom.MouseDown
        activeDatePicker = dtpAvailableFrom
        ModernClockControl.Visible = True ' Show clock control
        ModernClockControl.BringToFront() ' Bring clock control to the front
    End Sub

    Private Sub dtpAvailableTo_MouseDown(sender As Object, e As MouseEventArgs) Handles dtpAvailableTo.MouseDown
        activeDatePicker = dtpAvailableTo
        ModernClockControl.Visible = True ' Show clock control
        ModernClockControl.BringToFront() ' Bring clock control to the front
    End Sub

    ' Event: Handle time set event from ModernClockControl
    Private Sub ModernClockControl_TimeSet(selectedHour As Integer, selectedMinute As Integer, isPM As Boolean)
        ' Convert the hour based on AM/PM selection
        If isPM AndAlso selectedHour < 12 Then
            selectedHour += 12 ' Convert to 24-hour format
        ElseIf Not isPM AndAlso selectedHour = 12 Then
            selectedHour = 0 ' Handle midnight case
        End If

        ' Set the time in the appropriate DateTimePicker
        If activeDatePicker IsNot Nothing Then
            activeDatePicker.Value = New DateTime(activeDatePicker.Value.Year, activeDatePicker.Value.Month, activeDatePicker.Value.Day, selectedHour, selectedMinute, 0)
        End If

        ModernClockControl.Visible = False ' Hide the clock after setting the time
    End Sub

    ' Event: Load the image for the selected product into the PictureBox
    Private Sub cmbProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProducts.SelectedIndexChanged
        Dim selectedProduct As ComboBoxItem = CType(cmbProducts.SelectedItem, ComboBoxItem)
        If selectedProduct IsNot Nothing Then
            LoadProductImage(selectedProduct.ImageUrl)
        End If
    End Sub

    ' Load the product image into the PictureBox
    Private Sub LoadProductImage(imageUrl As String)
        ' Check if image URL is valid and the file exists
        If Not String.IsNullOrEmpty(imageUrl) AndAlso File.Exists(imageUrl) Then
            picboxProduct.Image = Image.FromFile(imageUrl)
        Else
            picboxProduct.Image = Nothing ' Clear the image if file is not found
        End If
    End Sub

    ' Cancel button to close the login page
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    ' Event: Mouse hover effect for Add button
    Private Sub btnAdd_MouseEnter(sender As Object, e As EventArgs) Handles btnAdd.MouseEnter
        btnAdd.BackColor = Color.FromArgb(0, 175, 99) ' Darker green for hover effect
    End Sub

    Private Sub btnAdd_MouseLeave(sender As Object, e As EventArgs) Handles btnAdd.MouseLeave
        btnAdd.BackColor = Color.FromArgb(0, 191, 99) ' Revert to original color
    End Sub

    ' Event: Mouse hover effect for Cancel button
    Private Sub btnCancel_MouseEnter(sender As Object, e As EventArgs) Handles btnCancel.MouseEnter
        btnCancel.BackColor = Color.FromArgb(0, 191, 99) ' Highlight on hover
        btnCancel.ForeColor = Color.White
    End Sub

    Private Sub btnCancel_MouseLeave(sender As Object, e As EventArgs) Handles btnCancel.MouseLeave
        btnCancel.BackColor = Color.White ' Revert to original background
        btnCancel.ForeColor = Color.FromArgb(0, 191, 99) ' Revert to original text color
    End Sub

    ' Utility: Centralized error display
    Private Sub ShowError(message As String, ex As Exception)
        MessageBox.Show($"{message}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    ' ComboBox item class to hold product name, ID, and image URL
    Private Class ComboBoxItem
        Public Property Text As String
        Public Property Value As Integer
        Public Property ImageUrl As String

        ' Constructor to initialize ComboBoxItem
        Public Sub New(text As String, value As Integer, imageUrl As String)
            Me.Text = text
            Me.Value = value
            Me.ImageUrl = imageUrl
        End Sub

        ' Override ToString method to display product name in ComboBox
        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Class
End Class
