Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class ForgetPasswordChange

    ' Database connection string (Update this with your connection details)
    Private connectionString As String = ConfigurationManager.ConnectionStrings("CMS.My.MySettings.CMSConnectionString").ConnectionString
    Private originalPassword As String = ""
    Private originalConfirmPassword As String = ""
    Private userEmail As String

    ' Constructor that accepts email as a parameter
    Public Sub New(email As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Assign email to class-level variable
        Me.userEmail = email
    End Sub

    ' Load event handler for ForgetPasswordChange UserControl
    Private Sub ForgetPasswordChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mask passwords on load
        txtboxpassword.PasswordChar = "●"c
        txtboxconfirmpassword.PasswordChar = "●"c

    End Sub

    ' Event handler for the Update Password button click
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Retrieve the new password and confirmation password from input fields
        Dim newPassword As String = txtboxpassword.Text.Trim()
        Dim confirmPassword As String = txtboxconfirmpassword.Text.Trim()

        ' Validate the password and confirm password inputs
        If Not IsPasswordValid(newPassword) Then
            MessageBox.Show("Password does not meet the required criteria.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If newPassword <> confirmPassword Then
            MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Update the password in the database (provide user ID or email to update the correct user)
        Try
            UpdatePassword(newPassword) ' Pass the correct user identifier (email or user_id)
            MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ParentForm.Close()
        Catch ex As Exception
            MessageBox.Show($"An error occurred while updating the password: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Function to update the user's password in the database
    Private Sub UpdatePassword(newPassword As String)
        ' SQL query to update the password for the specified email in the Users table
        Dim updateQuery As String = "UPDATE Users SET password = HASHBYTES('SHA2_512', @Password) WHERE email = @Email"

        ' Perform the database update inside a try-catch block for better error handling
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Using command As New SqlCommand(updateQuery, connection)
                    ' Add parameters to avoid SQL injection
                    command.Parameters.AddWithValue("@Password", newPassword)
                    command.Parameters.AddWithValue("@Email", userEmail)

                    ' Execute the update command
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    ' Ensure the update was successful
                    If rowsAffected = 0 Then
                        Throw New Exception("Unable to update the Password.")
                    End If
                End Using
            End Using
        Catch ex As SqlException
            ' Handle SQL-specific exceptions
            Throw New Exception("A database error occurred: " & ex.Message)
        Catch ex As Exception
            ' Handle general exceptions
            Throw New Exception("An unexpected error occurred: " & ex.Message)
        End Try
    End Sub

    ' Function to validate password criteria
    Private Function IsPasswordValid(password As String) As Boolean
        Dim specialChars As String = "@#$!%*?&"
        ' Check if the password meets all criteria:
        Return password.Length >= 8 AndAlso password.Length <= 16 AndAlso
               password.Any(Function(c) Char.IsUpper(c)) AndAlso
               password.Any(Function(c) Char.IsLower(c)) AndAlso
               password.Any(Function(c) Char.IsDigit(c)) AndAlso
               password.Any(Function(c) specialChars.Contains(c))
    End Function

    ' Event handler to validate password in real-time as the user types
    Private Sub txtboxpassword_TextChanged(sender As Object, e As EventArgs) Handles txtboxpassword.TextChanged
        Dim password As String = txtboxpassword.Text

        ' Validate password length
        lblLength.ForeColor = If(password.Length >= 8 AndAlso password.Length <= 16, Color.Green, Color.Red)

        ' Validate at least one uppercase letter
        lblUppercase.ForeColor = If(password.Any(Function(c) Char.IsUpper(c)), Color.Green, Color.Red)

        ' Validate at least one lowercase letter
        lblLowercase.ForeColor = If(password.Any(Function(c) Char.IsLower(c)), Color.Green, Color.Red)

        ' Validate at least one digit
        lblNumber.ForeColor = If(password.Any(Function(c) Char.IsDigit(c)), Color.Green, Color.Red)

        ' Validate at least one special character
        Dim specialChars As String = "@#$!%*?&"
        lblSpecialChar.ForeColor = If(password.Any(Function(c) specialChars.Contains(c)), Color.Green, Color.Red)
    End Sub

    ' Toggle password visibility for password field
    Private Sub btntogglepassword_Click(sender As Object, e As EventArgs) Handles btntogglepassword.Click
        TogglePasswordVisibility(txtboxpassword, btntogglepassword, originalPassword)
    End Sub

    ' Toggle password visibility for confirm password field
    Private Sub btntogglecpassword_Click(sender As Object, e As EventArgs) Handles btntogglecpassword.Click
        TogglePasswordVisibility(txtboxconfirmpassword, btntogglecpassword, originalConfirmPassword)
    End Sub

    ' Function to toggle password visibility for TextBox
    Private Sub TogglePasswordVisibility(passwordBox As TextBox, toggleButton As Button, ByRef originalText As String)
        ' Store the current text in originalText if it's the first time toggling
        If String.IsNullOrEmpty(originalText) Then
            originalText = passwordBox.Text
        End If

        ' Check if the password is currently visible (not masked)
        If passwordBox.PasswordChar = ControlChars.NullChar Then
            ' Mask the password
            passwordBox.PasswordChar = "●"c
            toggleButton.BackgroundImage = My.Resources.eye_open
        Else
            ' Unmask the password
            passwordBox.PasswordChar = ControlChars.NullChar
            toggleButton.BackgroundImage = My.Resources.eye_close
        End If
    End Sub

End Class
