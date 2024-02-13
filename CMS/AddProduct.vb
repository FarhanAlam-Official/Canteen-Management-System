Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Configuration
Imports System.IO ' Required for file operations

Public Class AddProduct
    ' Database connection string
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("CMS.My.MySettings.CMSConnectionString").ConnectionString

    ' Folder to store product images
    Private ReadOnly fixedImageFolder As String = Path.Combine(Application.StartupPath, "Images")

    ' Default image path in case no image is provided
    Private ReadOnly defaultImagePath As String = Path.Combine(Application.StartupPath, "Images", "DefaultProductImage.jpg")

    ' Form Load event
    Private Sub AddProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm() ' Center the form on the screen

        ' Ensure the fixed image folder exists
        If Not Directory.Exists(fixedImageFolder) Then
            Directory.CreateDirectory(fixedImageFolder)
        End If
    End Sub

    ' Center the form on the screen
    Private Sub CenterForm()
        Dim x As Integer
        Dim y As Integer
        Dim r As Rectangle

        If Not Parent Is Nothing Then
            r = Parent.ClientRectangle
            x = r.Width - Me.Width + Parent.Left
            y = r.Height - Me.Height + Parent.Top
        Else
            r = Screen.PrimaryScreen.WorkingArea
            x = r.Width - Me.Width
            y = r.Height - Me.Height
        End If

        x = CInt(x / 2)
        y = CInt(y / 2)

        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(x, y)
    End Sub

    ' Event handler for the Add button click
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Get user input from the form fields
        Dim productName As String = rtxtboxfirstname.Text.Trim()
        Dim description As String = rtxtboxDescription.Text.Trim()
        Dim categoryId As Integer = cmbCategory.SelectedIndex + 1 ' ComboBox is 0-indexed
        Dim status As Integer = If(rbtnActive.Checked, 1, 0) ' 1 for Active, 0 for Inactive
        Dim price As Decimal
        Dim imageUrl As String = picboxProductImage.ImageLocation ' Path to selected image

        ' If no image is selected, set the default image path
        If String.IsNullOrEmpty(imageUrl) Then
            imageUrl = defaultImagePath
        Else
            ' Save the selected image to the fixed folder
            imageUrl = SaveImageToFixedFolder(imageUrl, productName)
        End If

        ' Validate price input
        If Not Decimal.TryParse(rtxtboxPrice.Text, price) Then
            MessageBox.Show("Please enter a valid price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validate required fields
        If Not ValidateInputs(productName, description, price, categoryId) Then
            Return
        End If

        ' Insert product data into the database
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "INSERT INTO Products (product_name, description, price, image_url, category_id, status) " &
                                      "VALUES (@productName, @description, @price, @imageUrl, @categoryId, @status)"
                Using cmd As New SqlCommand(query, conn)
                    ' Add parameters to avoid SQL injection
                    cmd.Parameters.AddWithValue("@productName", productName)
                    cmd.Parameters.AddWithValue("@description", description)
                    cmd.Parameters.AddWithValue("@price", price)
                    cmd.Parameters.AddWithValue("@imageUrl", imageUrl)
                    cmd.Parameters.AddWithValue("@categoryId", categoryId)
                    cmd.Parameters.AddWithValue("@status", status)

                    ' Execute the query and check for success
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ClearForm() ' Reset the form fields
                        Me.Close()
                    Else
                        MessageBox.Show("Failed to add product.", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using
        Catch ex As Exception
            ShowError("An error occurred while adding the product", ex)
        End Try
    End Sub

    ' Save the selected image to the fixed folder and return the new path with the product name
    Private Function SaveImageToFixedFolder(selectedImagePath As String, productName As String) As String
        ' Ensure the fixed image folder exists
        If Not Directory.Exists(fixedImageFolder) Then
            Directory.CreateDirectory(fixedImageFolder)
        End If

        ' Sanitize product name: Convert to lowercase, remove spaces, and special characters
        Dim sanitizedProductName As String = Regex.Replace(productName.Trim().ToLower(), "[^a-z0-9]", "")

        ' Get the file extension of the selected image (e.g., .jpg, .png)
        Dim fileExtension As String = Path.GetExtension(selectedImagePath)

        ' Construct new image path in the fixed folder with the sanitized product name
        Dim newImagePath As String = Path.Combine(fixedImageFolder, sanitizedProductName & fileExtension)

        ' Copy the image file to the fixed folder, overwrite if it exists
        Try
            File.Copy(selectedImagePath, newImagePath, True)
        Catch ex As Exception
            ShowError("An error occurred while copying the image", ex)
        End Try

        ' Return the new image path
        Return newImagePath
    End Function

    ' Clear the form fields after successful insertion
    Private Sub ClearForm()
        rtxtboxfirstname.Text = ""
        rtxtboxPrice.Text = ""
        rtxtboxDescription.Text = ""
        picboxProductImage.ImageLocation = ""
        cmbCategory.SelectedIndex = -1
        rbtnActive.Checked = False
        rbtnInactive.Checked = False
    End Sub

    ' Validate the required input fields
    Private Function ValidateInputs(productName As String, description As String, price As Decimal, categoryId As Integer) As Boolean
        Dim isValid As Boolean = True

        ' Validate Product Name
        If String.IsNullOrWhiteSpace(productName) Then
            HighlightField(rtxtboxfirstname, True)
            isValid = False
        Else
            HighlightField(rtxtboxfirstname, False)
        End If

        ' Validate Price (must be greater than zero)
        If price <= 0 Then
            HighlightField(rtxtboxPrice, True)
            MessageBox.Show("Price must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            isValid = False
        Else
            HighlightField(rtxtboxPrice, False)
        End If

        ' Validate Category
        If categoryId <= 0 Then
            HighlightField(cmbCategory, True)
            MessageBox.Show("Please select a valid category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            isValid = False
        Else
            HighlightField(cmbCategory, False)
        End If

        ' Validate Status selection
        If Not rbtnActive.Checked AndAlso Not rbtnInactive.Checked Then
            MessageBox.Show("Please select a status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            isValid = False
        End If

        ' Show an error message if validation fails
        If Not isValid Then
            MessageBox.Show("Please correct the highlighted fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return isValid
    End Function

    ' Highlight fields in red for invalid input and revert to white for valid input
    Private Sub HighlightField(field As Control, highlight As Boolean)
        If highlight Then
            field.BackColor = Color.FromArgb(252, 73, 73) ' Red color for invalid fields
        Else
            field.BackColor = Color.White
        End If
    End Sub

    ' Event handler for the Browse button click to select an image
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            openFileDialog.Title = "Select a Product Image"

            ' If the user selects an image, display it in the PictureBox
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                picboxProductImage.ImageLocation = openFileDialog.FileName
            End If
        End Using
    End Sub

    ' Event handler for the Cancel button to close the form
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    ' Centralized error handling method for consistent error messaging
    Private Sub ShowError(message As String, ex As Exception)
        MessageBox.Show($"{message}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    ' Event: Mouse hover effect for Add button
    Private Sub btnAdd_MouseEnter(sender As Object, e As EventArgs) Handles btnAdd.MouseEnter
        btnAdd.BackColor = Color.FromArgb(0, 175, 99) ' Darker green for hover effect
    End Sub

    Private Sub btnAdd_MouseLeave(sender As Object, e As EventArgs) Handles btnAdd.MouseLeave
        btnAdd.BackColor = Color.FromArgb(0, 191, 99) ' Revert to original color
    End Sub

    ' Event: Mouse hover effect for Browse button
    Private Sub btnBrowsed_MouseEnter(sender As Object, e As EventArgs) Handles btnBrowse.MouseEnter
        btnBrowse.BackColor = Color.FromArgb(0, 175, 99) ' Darker green for hover effect
    End Sub

    Private Sub btnBrowse_MouseLeave(sender As Object, e As EventArgs) Handles btnBrowse.MouseLeave
        btnBrowse.BackColor = Color.FromArgb(0, 191, 99) ' Revert to original color
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

End Class
