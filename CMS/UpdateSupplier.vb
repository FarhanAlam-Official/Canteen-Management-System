Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Configuration

Public Class UpdateSupplier

    ' Database connection string from configuration settings
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("CMS.My.MySettings.CMSConnectionString").ConnectionString
    Private supplierId As Integer ' Stores the supplier ID for updates

    ' Form Load event - centers the form on the screen
    Private Sub UpdateSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm()
    End Sub

    ' Event handler for the Search button click
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchValue As String = rtxtSearch.Text.Trim()

        ' Validate and perform search based on selected option
        If rbtnSupplierID.Checked Then
            If IsValidSupplierID(searchValue) Then
                SearchSupplier("supplier_id", Convert.ToInt32(searchValue))
            End If
        ElseIf rbtnSupplierEmail.Checked Then
            If IsValidEmail(searchValue) Then
                SearchSupplier("contact_email", searchValue)
            End If
        Else
            MessageBox.Show("Please select either 'Supplier ID' or 'Email' to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Event handler for the Update button click
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Retrieve the data from input fields
        Dim supplierName As String = rtxtboxSupplierName.Text.Trim()
        Dim contactName As String = rtxtboxContactName.Text.Trim()
        Dim phoneNo As String = rtxtboxContactPhoneno.Text.Trim()
        Dim email As String = rtxtboxContactEmail.Text.Trim()
        Dim status As Integer = If(rbtnWorking.Checked, 1, 0) ' 1 for Working, 0 for Not Working

        ' Validate input fields and update the supplier details
        If ValidateInputs(supplierName, contactName, phoneNo, email) Then
            UpdateSupplierDetails(supplierName, contactName, phoneNo, email, status)
        End If
    End Sub

    ' Event handler for the Cancel button click event - closes the form
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    ' Centers the form in the middle of the parent form or screen
    Private Sub CenterForm()
        Dim x, y As Integer
        Dim r As Rectangle

        If Not Parent Is Nothing Then
            r = Parent.ClientRectangle
            x = (r.Width - Me.Width) \ 2 + Parent.Left
            y = (r.Height - Me.Height) \ 2 + Parent.Top
        Else
            r = Screen.PrimaryScreen.WorkingArea
            x = (r.Width - Me.Width) \ 2
            y = (r.Height - Me.Height) \ 2
        End If

        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(x, y)
    End Sub

    ' Validates the supplier ID input
    Private Function IsValidSupplierID(supplierID As String) As Boolean
        If String.IsNullOrWhiteSpace(supplierID) OrElse Not IsNumeric(supplierID) Then
            MessageBox.Show("Please enter a valid Supplier ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    ' Validates the email format using regex
    Private Function IsValidEmail(email As String) As Boolean
        Dim emailPattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        If String.IsNullOrWhiteSpace(email) OrElse Not Regex.IsMatch(email, emailPattern) Then
            MessageBox.Show("Please enter a valid Email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    ' Function to search supplier by Supplier ID or Email and populate the fields if found
    Private Sub SearchSupplier(searchBy As String, searchValue As Object)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT supplier_id, supplier_name, contact_name, contact_phone, contact_email, status 
                                       FROM Suppliers 
                                       WHERE " & searchBy & " = @SearchValue"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@SearchValue", searchValue)

                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Populate fields with supplier data
                            supplierId = Convert.ToInt32(reader("supplier_id"))
                            rtxtboxSupplierName.Text = reader("supplier_name").ToString()
                            rtxtboxContactName.Text = reader("contact_name").ToString()
                            rtxtboxContactPhoneno.Text = reader("contact_phone").ToString()
                            rtxtboxContactEmail.Text = reader("contact_email").ToString()

                            ' Set status radio buttons
                            If Convert.ToInt32(reader("status")) = 1 Then
                                rbtnWorking.Checked = True
                            Else
                                rbtnNotWorking.Checked = True
                            End If
                        Else
                            MessageBox.Show("No supplier found with the given search criteria.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Validates the input fields before updating the supplier details
    Private Function ValidateInputs(supplierName As String, contactName As String, phoneNo As String, email As String) As Boolean
        Dim isValid As Boolean = True

        If String.IsNullOrWhiteSpace(supplierName) Then
            HighlightField(rtxtboxSupplierName, True)
            isValid = False
        Else
            HighlightField(rtxtboxSupplierName, False)
        End If

        If String.IsNullOrWhiteSpace(contactName) Then
            HighlightField(rtxtboxContactName, True)
            isValid = False
        Else
            HighlightField(rtxtboxContactName, False)
        End If

        If Not IsValidPhoneNo(phoneNo) Then
            isValid = False
        End If

        If Not IsValidEmail(email) Then
            HighlightField(rtxtboxContactEmail, True)
            isValid = False
        Else
            HighlightField(rtxtboxContactEmail, False)
        End If

        If Not isValid Then
            MessageBox.Show("Please correct the highlighted fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return isValid
    End Function

    ' Validates the phone number
    Private Function IsValidPhoneNo(phoneNo As String) As Boolean
        If String.IsNullOrWhiteSpace(phoneNo) Then
            HighlightField(rtxtboxContactPhoneno, True)
            MessageBox.Show("Phone number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf phoneNo.Length <> 10 Then
            HighlightField(rtxtboxContactPhoneno, True)
            MessageBox.Show("Phone number must be 10 digits long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            HighlightField(rtxtboxContactPhoneno, False)
            Return True
        End If
    End Function

    ' Highlights a specific field if it contains invalid data
    Private Sub HighlightField(field As Control, highlight As Boolean)
        field.BackColor = If(highlight, Color.FromArgb(252, 73, 73), Color.White) ' Red for invalid, white for valid
    End Sub

    ' Updates the supplier details in the database
    Private Sub UpdateSupplierDetails(supplierName As String, contactName As String, phoneNo As String, email As String, status As Integer)
        ' Ensure the supplierId is valid
        If supplierId = 0 Then
            MessageBox.Show("Please search for a supplier first before updating.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "UPDATE Suppliers 
                                       SET supplier_name = @SupplierName, contact_name = @ContactName, contact_phone = @PhoneNo, contact_email = @Email, status = @Status 
                                       WHERE supplier_id = @SupplierId"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@SupplierId", supplierId)
                    command.Parameters.AddWithValue("@SupplierName", supplierName)
                    command.Parameters.AddWithValue("@ContactName", contactName)
                    command.Parameters.AddWithValue("@PhoneNo", phoneNo)
                    command.Parameters.AddWithValue("@Email", email)
                    command.Parameters.AddWithValue("@Status", status)

                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Supplier details updated successfully.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show($"An error occurred while updating: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Ensures that only numeric values are allowed in the phone number field
    Private Sub rtxtboxPhoneNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rtxtboxContactPhoneno.KeyPress
        ' Allow control keys (backspace, delete) and only numeric input
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) OrElse rtxtboxContactPhoneno.Text.Length >= 10 Then
            e.Handled = True
        End If
    End Sub

    ' Mouse hover effect for Update button (changes color on hover)
    Private Sub btnUpdate_MouseEnter(sender As Object, e As EventArgs) Handles btnUpdate.MouseEnter
        btnUpdate.BackColor = Color.FromArgb(0, 175, 99) ' Darker green on hover
    End Sub

    Private Sub btnUpdate_MouseLeave(sender As Object, e As EventArgs) Handles btnUpdate.MouseLeave
        btnUpdate.BackColor = Color.FromArgb(0, 191, 99) ' Reverts to original color
    End Sub

    ' Mouse hover effect for Cancel button (changes color and text color on hover)
    Private Sub btnCancel_MouseEnter(sender As Object, e As EventArgs) Handles btncancel.MouseEnter
        btncancel.BackColor = Color.FromArgb(0, 191, 99) ' Highlight on hover
        btncancel.ForeColor = Color.White
    End Sub

    Private Sub btnCancel_MouseLeave(sender As Object, e As EventArgs) Handles btncancel.MouseLeave
        btncancel.BackColor = Color.White ' Reverts background
        btncancel.ForeColor = Color.FromArgb(0, 191, 99) ' Reverts text color
    End Sub

End Class
