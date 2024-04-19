Imports System.Configuration
Imports System.Data.SqlClient

Public Class Login_Page

    ' Database Connection
    Private connectionString As String = ConfigurationManager.ConnectionStrings("CMS.My.MySettings.CMSConnectionString").ConnectionString

    Private loginAttempts As Integer = 3
    Private isPasswordVisible As Boolean = False

    ' Form load event to initialize and center the login page
    Private Sub Login_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblmsg.Visible = True

        ' Center the form on the screen
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

        ' Initialize password field to hide characters
        rtxtboxpassword.PasswordChar = "●"c
    End Sub

    ' Login button click event
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If loginAttempts <= 0 Then
            lblmsg.Text = "No login attempts remaining."
            lblmsg.ForeColor = Color.Red
            btnLogin.Enabled = False
            btnLogin.BackColor = Color.Gray ' Disable button and change color
            Exit Sub
        End If

        Dim email As String = rtxtboxusername.Text
        Dim password As String = rtxtboxpassword.Text

        ' Input Validation
        If String.IsNullOrWhiteSpace(email) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please enter both email and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Check if email exists
                If Not CheckEmailExists(email, connection) Then
                    MessageBox.Show("Invalid Email!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    DecrementLoginAttempts()
                    Exit Sub
                End If

                ' Validate email and password
                If Not ValidateUser(email, password, connection) Then
                    DecrementLoginAttempts()
                    MessageBox.Show("Incorrect Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Check if the email exists in the database
    Private Function CheckEmailExists(email As String, connection As SqlConnection) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM Users WHERE email = @Email"
        Using command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Email", email)
            Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())
            Return result > 0
        End Using
    End Function

    ' Validate user by checking email and password
    Private Function ValidateUser(email As String, password As String, connection As SqlConnection) As Boolean
        Dim query As String = "SELECT user_id, user_type, status FROM Users WHERE email = @Email AND password = HASHBYTES('SHA2_512', @Password)"
        Using command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Email", email)
            command.Parameters.AddWithValue("@Password", password)

            Using reader As SqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    Dim userId As Integer = Convert.ToInt32(reader("user_id")) ' Retrieve user ID
                    Dim userType As String = reader("user_type").ToString()
                    Dim status As Integer = Convert.ToInt32(reader("status"))

                    If status = 0 Then
                        MessageBox.Show("Your account is inactive. Please contact the administrator.", "Account Inactive", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return False
                    Else
                        ShowSuccessMessage(userType, userId) ' Display success message and navigate to the appropriate page
                        Return True
                    End If
                Else
                    Return False ' Invalid credentials
                End If
            End Using
        End Using
    End Function

    ' Show success message and redirect based on user type
    Private Sub ShowSuccessMessage(userType As String, userId As Integer)
        If userType = "admin" Then
            Dim adminPage As New Admin_Page()
            adminPage.ShowDialog()
            Me.Close()
        ElseIf userType = "customer" Then
            Dim homePage As New Home_Page(userId) ' Pass user ID to home page
            homePage.ShowDialog()
            Me.Close()
        End If
    End Sub

    ' Decrement login attempts and disable login if no attempts are left
    Private Sub DecrementLoginAttempts()
        loginAttempts -= 1
        If loginAttempts > 0 Then
            lblmsg.Text = $"You have {loginAttempts} attempt(s) remaining."
            lblmsg.ForeColor = Color.Orange
        Else
            lblmsg.Text = "No login attempts remaining."
            lblmsg.ForeColor = Color.Red
            btnLogin.Enabled = False
            btnLogin.BackColor = Color.Gray ' Disable button and change color
        End If
    End Sub

    ' Toggle password visibility
    Private Sub btnshowpassword_Click(sender As Object, e As EventArgs) Handles btnTogglePassword.Click
        If isPasswordVisible Then
            ' Hide password
            rtxtboxpassword.PasswordChar = "●"c
            btnTogglePassword.BackgroundImage = My.Resources.Eye_Open
            isPasswordVisible = False
        Else
            ' Show password
            rtxtboxpassword.PasswordChar = ControlChars.NullChar
            btnTogglePassword.BackgroundImage = My.Resources.Eye_Close
            isPasswordVisible = True
        End If
    End Sub

    ' Cancel button to close the login page
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    ' Registration button click event
    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        Dim registerForm As New Register()
        registerForm.ShowDialog()
        Me.Close()
    End Sub

    ' Handle Forgot Password click event
    Private Sub lblforgetpassword_Click(sender As Object, e As EventArgs) Handles lblforgetpassword.Click
        Dim forgetpassword As New ForgetPassword()
        forgetpassword.ShowDialog()
        Me.Close()
    End Sub

    ' MouseEnter and MouseLeave events to change the appearance of the "Forgot Password" label
    Private Sub lblforgetpassword_MouseEnter(sender As Object, e As EventArgs) Handles lblforgetpassword.MouseEnter
        lblforgetpassword.ForeColor = Color.FromArgb(0, 191, 99) ' Highlight the text on hover
    End Sub

    Private Sub lblforgetpassword_MouseLeave(sender As Object, e As EventArgs) Handles lblforgetpassword.MouseLeave
        lblforgetpassword.ForeColor = Color.DarkGray ' Revert the text color when the mouse leaves
    End Sub

    ' MouseEnter and MouseLeave events for the Login button
    Private Sub btnLogin_MouseEnter(sender As Object, e As EventArgs) Handles btnLogin.MouseEnter
        btnLogin.BackColor = Color.FromArgb(0, 175, 99) ' Darker green for hover effect
    End Sub

    Private Sub btnLogin_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin.MouseLeave
        btnLogin.BackColor = Color.FromArgb(0, 191, 99) ' Original color
    End Sub

    ' MouseEnter and MouseLeave events for the Cancel button
    Private Sub btncancel_MouseEnter(sender As Object, e As EventArgs) Handles btnCancel.MouseEnter
        btnCancel.BackColor = Color.FromArgb(0, 191, 99) ' Highlight text on hover
        btnCancel.ForeColor = Color.White
    End Sub

    Private Sub btncancel_MouseLeave(sender As Object, e As EventArgs) Handles btnCancel.MouseLeave
        btnCancel.BackColor = Color.White
        btnCancel.ForeColor = Color.FromArgb(0, 191, 99) ' Revert text color
    End Sub

    ' MouseEnter and MouseLeave events for the Register button
    Private Sub btnregister_MouseEnter(sender As Object, e As EventArgs) Handles btnregister.MouseEnter
        btnregister.ForeColor = Color.FromArgb(0, 191, 99) ' Highlight text on hover
    End Sub

    Private Sub btnregister_MouseLeave(sender As Object, e As EventArgs) Handles btnregister.MouseLeave
        btnregister.ForeColor = Color.FromArgb(0, 175, 99) ' Revert text color
    End Sub
End Class
