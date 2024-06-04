Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Register

    Private isAdminMode As Boolean

    ' Modify the constructor to accept the "isAdminMode" flag
    Public Sub New(Optional isAdminMode As Boolean = False)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.isAdminMode = isAdminMode
    End Sub
    ' Database connection string
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("CMS.My.MySettings.CMSConnectionString").ConnectionString
    Private originalPassword As String = ""
    Private originalConfirmPassword As String = ""

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Check if the form is opened in "admin mode"
        If isAdminMode Then
            ' Disable or hide the Login button
            btnLogin.Visible = False ' Or you could set Enabled = False to just disable it
            lblfootermsg.Visible = False
        Else
            ' Ensure the Login button is visible when opened normally
            btnLogin.Visible = True
            lblfootermsg.Visible = True
        End If

        ' Centering the form in the middle of the parent form
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

        ' Mask passwords on load
        txtboxpassword.PasswordChar = "●"c
        txtboxconfirmpassword.PasswordChar = "●"c
    End Sub

    ' Event handler for the Register button click event
    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        ' Retrieve form input values
        Dim email As String = rtxtboxemail.Text.Trim()
        Dim password As String = txtboxpassword.Text.Trim()
        Dim confirmPassword As String = txtboxconfirmpassword.Text.Trim()
        Dim firstName As String = rtxtboxfirstname.Text.Trim()
        Dim lastName As String = rtxtboxlastname.Text.Trim()
        Dim age As String = rtxtboxage.Text.Trim()
        Dim gender As String = If(radiobtnmale.Checked, "Male", If(radiobtnfemale.Checked, "Female", "Other"))
        Dim phoneNo As String = rtxtboxphoneno.Text.Trim()

        ' Input validation
        If Not ValidateInputs(email, password, confirmPassword, firstName, lastName, age, phoneNo) Then
            Exit Sub
        End If

        ' Insert new user data into the database
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Check if email already exists
                Dim emailQuery As String = "SELECT COUNT(*) FROM Users WHERE email = @Email"
                Using emailCommand As New SqlCommand(emailQuery, connection)
                    emailCommand.Parameters.AddWithValue("@Email", email)
                    Dim emailExists As Integer = Convert.ToInt32(emailCommand.ExecuteScalar())

                    If emailExists > 0 Then
                        MessageBox.Show("Email already exists. Please use a different email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        HighlightField(rtxtboxemail, True)
                        Exit Sub
                    End If
                End Using

                ' Insert into Users table
                Dim insertUserQuery As String = "INSERT INTO Users (email, password, user_type, status) VALUES (@Email, HASHBYTES('SHA2_512', @Password), @UserType, @Status); SELECT SCOPE_IDENTITY();"
                Using insertUserCommand As New SqlCommand(insertUserQuery, connection)
                    insertUserCommand.Parameters.AddWithValue("@Email", email)
                    insertUserCommand.Parameters.AddWithValue("@Password", password)
                    insertUserCommand.Parameters.AddWithValue("@UserType", "customer")
                    insertUserCommand.Parameters.AddWithValue("@Status", 1)

                    ' Get the inserted user_id
                    Dim newUserId As Integer = Convert.ToInt32(insertUserCommand.ExecuteScalar())

                    ' Insert into User_Details table
                    Dim insertUserDetailsQuery As String = "INSERT INTO User_Details (user_id, first_name, last_name, age, gender, phone_no) VALUES (@UserId, @FirstName, @LastName, @Age, @Gender, @PhoneNo)"
                    Using insertUserDetailsCommand As New SqlCommand(insertUserDetailsQuery, connection)
                        insertUserDetailsCommand.Parameters.AddWithValue("@UserId", newUserId)
                        insertUserDetailsCommand.Parameters.AddWithValue("@FirstName", firstName)
                        insertUserDetailsCommand.Parameters.AddWithValue("@LastName", lastName)
                        insertUserDetailsCommand.Parameters.AddWithValue("@Age", age)
                        insertUserDetailsCommand.Parameters.AddWithValue("@Gender", gender)
                        insertUserDetailsCommand.Parameters.AddWithValue("@PhoneNo", If(String.IsNullOrEmpty(phoneNo), "Not Provided", phoneNo))

                        insertUserDetailsCommand.ExecuteNonQuery()
                    End Using
                End Using
            End Using

            ' Registration successful
            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show($"An error occurred while registering: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Function to validate form inputs
    Private Function ValidateInputs(email As String, password As String, confirmPassword As String, firstName As String, lastName As String, age As String, phoneNo As String) As Boolean
        Dim isValid As Boolean = True

        If String.IsNullOrWhiteSpace(email) Then
            HighlightField(rtxtboxemail, True)
            isValid = False
        Else
            HighlightField(rtxtboxemail, False)
        End If

        If String.IsNullOrWhiteSpace(firstName) Then
            HighlightField(rtxtboxfirstname, True)
            isValid = False
        Else
            HighlightField(rtxtboxfirstname, False)
        End If

        If String.IsNullOrWhiteSpace(lastName) Then
            HighlightField(rtxtboxlastname, True)
            isValid = False
        Else
            HighlightField(rtxtboxlastname, False)
        End If

        If String.IsNullOrWhiteSpace(phoneNo) Then
            HighlightField(rtxtboxphoneno, True)
            isValid = False
        ElseIf phoneNo.Length <> 10 Then
            MessageBox.Show("Phone number must be 10 digits long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            HighlightField(rtxtboxphoneno, True)
            isValid = False
        Else
            HighlightField(rtxtboxphoneno, False)
        End If

        If String.IsNullOrWhiteSpace(age) OrElse Not IsNumeric(age) OrElse Convert.ToInt32(age) <= 0 OrElse Convert.ToInt32(age) >= 150 Then
            MessageBox.Show("Please enter a valid age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            HighlightField(rtxtboxage, True)
            isValid = False
        Else
            HighlightField(rtxtboxage, False)
        End If

        ' Validate gender selection
        If Not radiobtnmale.Checked AndAlso Not radiobtnfemale.Checked Then
            MessageBox.Show("Please select a gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            isValid = False
        End If

        ' Password validation (based on your new requirements)
        If Not IsPasswordValid(password) Then
            MessageBox.Show("Password does not meet the required criteria.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            HighlightField(txtboxpassword, True)
            isValid = False
        Else
            HighlightField(txtboxpassword, False)
        End If

        ' Confirm password validation
        If String.IsNullOrWhiteSpace(confirmPassword) Then
            HighlightField(txtboxconfirmpassword, True)
            isValid = False
        ElseIf password <> confirmPassword Then
            MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            HighlightField(txtboxpassword, True)
            HighlightField(txtboxconfirmpassword, True)
            isValid = False
        Else
            HighlightField(txtboxconfirmpassword, False)
        End If

        If Not IsValidEmail(email) Then
            MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            HighlightField(rtxtboxemail, True)
            isValid = False
        End If

        If Not isValid Then
            MessageBox.Show("Please correct the highlighted fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return isValid
    End Function



    ' Function to validate email format
    Private Function IsValidEmail(email As String) As Boolean
        Dim emailPattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        Return Regex.IsMatch(email, emailPattern)
    End Function


    ' Function to highlight required fields
    Private Sub HighlightField(field As Control, highlight As Boolean)
        If highlight Then
            field.BackColor = Color.FromArgb(252, 73, 73)
        Else
            field.BackColor = Color.White
        End If
    End Sub

    ' Event handler for the Cancel button click event
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    ' Toggle password visibility for password field
    Private Sub btntogglepassword_Click(sender As Object, e As EventArgs) Handles btnTogglePassword.Click
        TogglePasswordVisibility(txtboxpassword, btnTogglePassword, originalPassword)
    End Sub

    ' Toggle password visibility for confirm password field
    Private Sub btntogglecpassword_Click(sender As Object, e As EventArgs) Handles btnTogglecPassword.Click
        TogglePasswordVisibility(txtboxconfirmpassword, btnTogglecPassword, originalConfirmPassword)
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
            toggleButton.BackgroundImage = My.Resources.Eye_Open
        Else
            ' Unmask the password
            passwordBox.PasswordChar = ControlChars.NullChar
            toggleButton.BackgroundImage = My.Resources.Eye_Close
        End If
    End Sub

    ' Event handler for KeyPress event of rtxtboxphoneno
    Private Sub rtxtboxphoneno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rtxtboxphoneno.KeyPress
        ' Allow control keys (backspace, delete)
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        ' Allow only numeric input
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

        ' Restrict the length to 10 characters
        If rtxtboxphoneno.Text.Length >= 10 Then
            e.Handled = True
        End If
    End Sub

    'Function to valid the password
    Private Function IsPasswordValid(password As String) As Boolean
        Dim specialChars As String = "@$!%*?&"
        ' Check if the password meets all criteria:
        Return password.Length >= 8 AndAlso password.Length <= 16 AndAlso
           password.Any(Function(c) Char.IsUpper(c)) AndAlso
           password.Any(Function(c) Char.IsLower(c)) AndAlso
           password.Any(Function(c) Char.IsDigit(c)) AndAlso
           password.Any(Function(c) specialChars.Contains(c))
    End Function


    ' Event handler for password input text change
    Private Sub txtboxpassword_TextChanged(sender As Object, e As EventArgs) Handles txtboxpassword.TextChanged
        Dim password As String = txtboxpassword.Text

        ' Validate password length
        If password.Length >= 8 AndAlso password.Length <= 16 Then
            lblLength.ForeColor = Color.Green
        Else
            lblLength.ForeColor = Color.Red
        End If

        ' Validate at least one uppercase letter
        If password.Any(Function(c) Char.IsUpper(c)) Then
            lblUppercase.ForeColor = Color.Green
        Else
            lblUppercase.ForeColor = Color.Red
        End If

        ' Validate at least one lowercase letter
        If password.Any(Function(c) Char.IsLower(c)) Then
            lblLowercase.ForeColor = Color.Green
        Else
            lblLowercase.ForeColor = Color.Red
        End If

        ' Validate at least one digit
        If password.Any(Function(c) Char.IsDigit(c)) Then
            lblNumber.ForeColor = Color.Green
        Else
            lblNumber.ForeColor = Color.Red
        End If

        ' Validate at least one special character
        Dim specialChars As String = "@$!%*?&"
        If password.Any(Function(c) specialChars.Contains(c)) Then
            lblSpecialChar.ForeColor = Color.Green
        Else
            lblSpecialChar.ForeColor = Color.Red
        End If
    End Sub

    'Event handler for bthlogin to redirect user to login page
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Create a new instance of the Login_Page form.
        Dim login_page As New Login_Page()

        ' Show the Login_Page form as a modal dialog.
        ' This will block interaction with the current form until the login form is closed.
        login_page.ShowDialog()

        ' Close the current form (the registration form) after showing the login page.
        Me.Close()
    End Sub

    ' MouseEnter and MouseLeave events for the Login button
    Private Sub btnLogin_MouseEnter(sender As Object, e As EventArgs) Handles btnSignIn.MouseEnter
        btnSignIn.BackColor = Color.FromArgb(0, 175, 99) ' Darker green for hover effect
    End Sub

    Private Sub btnLogin_MouseLeave(sender As Object, e As EventArgs) Handles btnSignIn.MouseLeave
        btnSignIn.BackColor = Color.FromArgb(0, 191, 99) ' Original color
    End Sub

    ' MouseEnter and MouseLeave events for the Cancel button
    Private Sub btncancel_MouseEnter(sender As Object, e As EventArgs) Handles btncancel.MouseEnter
        btncancel.BackColor = Color.FromArgb(0, 191, 99) ' Highlight text on hover
        btncancel.ForeColor = Color.White
    End Sub

    Private Sub btncancel_MouseLeave(sender As Object, e As EventArgs) Handles btncancel.MouseLeave
        btncancel.BackColor = Color.White
        btncancel.ForeColor = Color.FromArgb(0, 191, 99) ' Revert text color
    End Sub

End Class
