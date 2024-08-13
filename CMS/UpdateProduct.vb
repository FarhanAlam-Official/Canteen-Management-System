Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Configuration
Imports System.IO

Public Class UpdateProduct
    ' Database connection string
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("CMS.My.MySettings.CMSConnectionString").ConnectionString

    ' Store the current product ID
    Private productId As Integer

    ' Fixed folder for storing product images
    Private ReadOnly fixedImageFolder As String = Path.Combine(Application.StartupPath, "Images")

    ' Default image path for products without images
    Private ReadOnly defaultImagePath As String = Path.Combine(Application.StartupPath, "Images", "DefaultProductImage.jpg")

    ' Load event to center the form
    Private Sub UpdateProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm()
    End Sub

    ' Centers the form on the screen or parent control
    Private Sub CenterForm()
        Dim x As Integer
        Dim y As Integer
        Dim r As Rectangle

        If Parent IsNot Nothing Then
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

    ' Search button click event
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchValue As String = rtxtSearch.Text.Trim()

        ' Validate input based on selected search criteria
        If rbtnProductID.Checked Then
            If String.IsNullOrWhiteSpace(searchValue) OrElse Not IsNumeric(searchValue) Then
                MessageBox.Show("Please enter a valid Product ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            SearchProduct("product_id", Convert.ToInt32(searchValue)) ' Search by Product ID
        ElseIf rbtnProductName.Checked Then
            If String.IsNullOrWhiteSpace(searchValue) Then
                MessageBox.Show("Please enter a valid Product Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            SearchProduct("product_name", searchValue) ' Search by Product Name
        Else
            MessageBox.Show("Please select either 'Product ID' or 'Product Name' to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Searches for product by given column and value
    Private Sub SearchProduct(searchBy As String, searchValue As Object)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT product_id, product_name, description, price, image_url, category_id, status FROM Products WHERE " & searchBy & " = @SearchValue"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@SearchValue", searchValue)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Populate fields with current product data
                            productId = Convert.ToInt32(reader("product_id"))
                            rtxtboxfirstname.Text = reader("product_name").ToString()
                            rtxtboxDescription.Text = reader("description").ToString()
                            rtxtboxPrice.Text = reader("price").ToString()
                            picboxProductImage.ImageLocation = reader("image_url").ToString()
                            cmbCategory.SelectedIndex = Convert.ToInt32(reader("category_id")) - 1
                            rbtnActive.Checked = Convert.ToBoolean(reader("status"))
                            rbtnInactive.Checked = Not rbtnActive.Checked
                        Else
                            MessageBox.Show("No product found with the given search criteria.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As SqlException
            MessageBox.Show($"Database error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Update button click event to update product details
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim productName As String = rtxtboxfirstname.Text.Trim()
        Dim description As String = rtxtboxDescription.Text.Trim()
        Dim price As Decimal = CInt(rtxtboxPrice.Text.Trim())
        Dim categoryId As Integer = cmbCategory.SelectedIndex + 1
        Dim status As Integer = If(rbtnActive.Checked, 1, 0)
        Dim imageUrl As String = picboxProductImage.ImageLocation

        ' Validate user inputs
        If Not ValidateInputs(productName, description, price, categoryId) Then
            Return
        End If

        ' Use default image if no image is selected
        If String.IsNullOrEmpty(imageUrl) Then
            imageUrl = defaultImagePath
        Else
            ' Copy the selected image to the fixed image folder
            imageUrl = SaveImageToFixedFolder(imageUrl, productName)
        End If

        ' Update product in the database
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "UPDATE Products SET product_name = @ProductName, description = @Description, price = @Price, image_url = @ImageUrl, category_id = @CategoryId, status = @Status WHERE product_id = @ProductId"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@ProductId", productId)
                    command.Parameters.AddWithValue("@ProductName", productName)
                    command.Parameters.AddWithValue("@Description", description)
                    command.Parameters.AddWithValue("@Price", price)
                    command.Parameters.AddWithValue("@ImageUrl", imageUrl)
                    command.Parameters.AddWithValue("@CategoryId", categoryId)
                    command.Parameters.AddWithValue("@Status", status)

                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Product updated successfully.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As SqlException
            MessageBox.Show($"Database error occurred while updating: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Validates the product input fields
    Private Function ValidateInputs(productName As String, description As String, ByRef price As Decimal, categoryId As Integer) As Boolean
        Dim isValid As Boolean = True

        ' Validate product name
        If String.IsNullOrWhiteSpace(productName) Then
            HighlightField(rtxtboxfirstname, True)
            isValid = False
        Else
            HighlightField(rtxtboxfirstname, False)
        End If

        ' Validate description
        If String.IsNullOrWhiteSpace(description) Then
            HighlightField(rtxtboxDescription, True)
            isValid = False
        Else
            HighlightField(rtxtboxDescription, False)
        End If

        ' Validate price (must be numeric and greater than zero)
        If Not Decimal.TryParse(rtxtboxPrice.Text, price) OrElse price <= 0 Then
            MessageBox.Show("Please enter a valid price greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            HighlightField(rtxtboxPrice, True)
            isValid = False
        Else
            HighlightField(rtxtboxPrice, False)
        End If

        ' Validate category selection
        If categoryId <= 0 Then
            MessageBox.Show("Please select a valid category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            HighlightField(cmbCategory, True)
            isValid = False
        Else
            HighlightField(cmbCategory, False)
        End If

        ' Validate status selection
        If Not rbtnActive.Checked AndAlso Not rbtnInactive.Checked Then
            MessageBox.Show("Please select a status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            isValid = False
        End If

        Return isValid
    End Function

    ' Saves the selected image to the fixed folder
    Private Function SaveImageToFixedFolder(selectedImagePath As String, productName As String) As String
        Try
            ' Ensure the fixed image folder exists
            If Not Directory.Exists(fixedImageFolder) Then
                Directory.CreateDirectory(fixedImageFolder)
            End If

            ' Sanitize product name for the image file
            Dim sanitizedProductName As String = Regex.Replace(productName.Trim().ToLower(), "[^a-z0-9]", "")
            Dim fileExtension As String = Path.GetExtension(selectedImagePath)
            Dim newImagePath As String = Path.Combine(fixedImageFolder, sanitizedProductName & fileExtension)

            ' Verify the selected image exists
            If Not File.Exists(selectedImagePath) Then
                MessageBox.Show($"The selected image file does not exist: {selectedImagePath}", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return String.Empty
            End If

            ' Copy the image to the new path
            Try
                Using fs As New FileStream(selectedImagePath, FileMode.Open, FileAccess.Read, FileShare.Read)
                    Using ms As New MemoryStream()
                        fs.CopyTo(ms)
                        ms.Position = 0

                        ' Save the image to the fixed folder
                        Using image As Image = Image.FromStream(ms)
                            image.Save(newImagePath)
                        End Using
                    End Using
                End Using
            Catch ex As IOException
                MessageBox.Show($"Error copying the image: {ex.Message}", "IO Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return String.Empty
            Catch ex As UnauthorizedAccessException
                MessageBox.Show($"Access denied while copying the image: {ex.Message}", "Access Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return String.Empty
            Catch ex As Exception
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return String.Empty
            End Try

            Return newImagePath
        Catch ex As Exception
            MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return String.Empty
        End Try
    End Function

    ' Highlights invalid input fields
    Private Sub HighlightField(field As Control, highlight As Boolean)
        field.BackColor = If(highlight, Color.FromArgb(252, 73, 73), Color.White)
    End Sub

    ' Browse button click event to select an image
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            openFileDialog.Title = "Select a Product Image"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                picboxProductImage.ImageLocation = openFileDialog.FileName
            End If
        End Using
    End Sub

    ' Cancel button click event to close the form
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    ' Mouse hover effect for Update button (Change color on hover)
    Private Sub btnUpdate_MouseEnter(sender As Object, e As EventArgs) Handles btnUpdate.MouseEnter
        btnUpdate.BackColor = Color.FromArgb(0, 175, 99) ' Darker green on hover
    End Sub

    Private Sub btnUpdate_MouseLeave(sender As Object, e As EventArgs) Handles btnUpdate.MouseLeave
        btnUpdate.BackColor = Color.FromArgb(0, 191, 99) ' Original color
    End Sub

    ' Mouse hover effect for Browse button (Change color on hover)
    Private Sub btnBrowse_MouseEnter(sender As Object, e As EventArgs) Handles btnBrowse.MouseEnter
        btnBrowse.BackColor = Color.FromArgb(0, 175, 99) ' Darker green on hover
    End Sub

    Private Sub btnBrowse_MouseLeave(sender As Object, e As EventArgs) Handles btnBrowse.MouseLeave
        btnBrowse.BackColor = Color.FromArgb(0, 191, 99) ' Original color
    End Sub

    ' Mouse hover effect for Cancel button (Change color and text color on hover)
    Private Sub btnCancel_MouseEnter(sender As Object, e As EventArgs) Handles btnCancel.MouseEnter
        btnCancel.BackColor = Color.FromArgb(0, 191, 99) ' Highlight on hover
        btnCancel.ForeColor = Color.White
    End Sub

    Private Sub btnCancel_MouseLeave(sender As Object, e As EventArgs) Handles btnCancel.MouseLeave
        btnCancel.BackColor = Color.White ' Revert background
        btnCancel.ForeColor = Color.FromArgb(0, 191, 99) ' Revert text color
    End Sub

End Class
