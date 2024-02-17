Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Configuration

Public Class AddSupplier
    ' Database connection string
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("CMS.My.MySettings.CMSConnectionString").ConnectionString

    ' Form Load event
    Private Sub AddSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm() ' Center the form on the screen
    End Sub

    ' Center the form on the screen
    Private Sub CenterForm()
        Dim x As Integer
        Dim y As Integer
        Dim r As Rectangle

        ' Check if the form has a parent; otherwise, center on the screen
        If Not Parent Is Nothing Then
            r = Parent.ClientRectangle
            x = r.Width - Me.Width + Parent.Left
            y = r.Height - Me.Height + Parent.Top
        Else
            r = Screen.PrimaryScreen.WorkingArea
            x = r.Width - Me.Width
            y = r.Height - Me.Height
        End If

        ' Center the form
        x = CInt(x / 2)
        y = CInt(y / 2)

        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(x, y)
    End Sub

    ' Event handler for the Add button click
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Get user input from the form fields
        Dim supplierName As String = rtxtboxSupplierName.Text.Trim()
        Dim contactName As String = rtxtboxContactName.Text.Trim()
        Dim phoneNo As String = rtxtboxContactPhoneno.Text.Trim()
        Dim email As String = rtxtboxContactEmail.Text.Trim()
        Dim status As Integer = If(rbtnWorking.Checked, 1, 0) ' 1 for Working, 0 for Not Working

        ' Validate required fields
        If Not ValidateInputs(supplierName, contactName, phoneNo, email) Then
            Return
        End If

        ' Insert supplier data into the database
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                ' SQL query to insert a new supplier record
                Dim query As String = "INSERT INTO Suppliers (supplier_name, contact_name, contact_phone, contact_email, status) " &
                                      "VALUES (@supplierName, @contactName, @phoneNo, @Email, @status)"
                Using cmd As New SqlCommand(query, conn)
                    ' Add parameters to avoid SQL injection
                    cmd.Parameters.AddWithValue("@supplierName", supplierName)
                    cmd.Parameters.AddWithValue("@contactName", contactName)
                    cmd.Parameters.AddWithValue("@phoneNo", phoneNo)
                    cmd.Parameters.AddWithValue("@Email", email)
                    cmd.Parameters.AddWithValue("@status", status)

                    ' Execute the query and check for success
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Supplier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ClearForm() ' Reset form fields after successful insert
                        Me.Close()
                    Else
                        MessageBox.Show("Failed to add supplier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using
        Catch ex As Exception
            ShowError("An error occurred while adding the supplier", ex)
        End Try
    End Sub

    ' Method to clear the form fields after insertion
    Private Sub ClearForm()
        rtxtboxSupplierName.Text = ""
        rtxtboxContactName.Text = ""
        rtxtboxContactPhoneno.Text = ""
        rtxtboxContactEmail.Text = ""
        rbtnWorking.Checked = False
        rbtnNotWorking.Checked = False
    End Sub

    ' Function to validate input fields
    Private Function ValidateInputs(supplierName As String, contactName As String, phoneNo As String, email As String) As Boolean
        Dim isValid As Boolean = True

        ' Validate Supplier Name
        If String.IsNullOrWhiteSpace(supplierName) Then
            HighlightField(rtxtboxSupplierName, True)
            isValid = False
        Else
            HighlightField(rtxtboxSupplierName, False)
        End If

        ' Validate Contact Name
        If String.IsNullOrWhiteSpace(contactName) Then
            HighlightField(rtxtboxContactName, True)
            isValid = False
        Else
            HighlightField(rtxtboxContactName, False)
        End If

        ' Validate Phone Number
        If String.IsNullOrWhiteSpace(phoneNo) Then
            HighlightField(rtxtboxContactPhoneno, True)
            isValid = False
        ElseIf Not Regex.IsMatch(phoneNo, "^[0-9]{10}$") Then
            MessageBox.Show("Please enter a valid phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            HighlightField(rtxtboxContactPhoneno, True)
            isValid = False
        Else
            HighlightField(rtxtboxContactPhoneno, False)
        End If

        ' Validate Email
        If String.IsNullOrWhiteSpace(email) OrElse Not Regex.IsMatch(email, "^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$") Then
            MessageBox.Show("Please enter a valid email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            HighlightField(rtxtboxContactEmail, True)
            isValid = False
        Else
            HighlightField(rtxtboxContactEmail, False)
        End If

        ' Show error message if validation fails
        If Not isValid Then
            MessageBox.Show("Please correct the highlighted fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return isValid
    End Function

    ' Function to highlight invalid fields
    Private Sub HighlightField(field As Control, highlight As Boolean)
        If highlight Then
            field.BackColor = Color.FromArgb(252, 73, 73) ' Red color for invalid fields
        Else
            field.BackColor = Color.White
        End If
    End Sub

    ' Event handler for the Cancel button to close the form
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
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

    ' Event: Mouse hover effect for Cancel button
    Private Sub btnCancel_MouseEnter(sender As Object, e As EventArgs) Handles btncancel.MouseEnter
        btncancel.BackColor = Color.FromArgb(0, 191, 99) ' Highlight on hover
        btncancel.ForeColor = Color.White
    End Sub

    Private Sub btnCancel_MouseLeave(sender As Object, e As EventArgs) Handles btncancel.MouseLeave
        btncancel.BackColor = Color.White ' Revert to original background
        btncancel.ForeColor = Color.FromArgb(0, 191, 99) ' Revert to original text color
    End Sub

End Class
