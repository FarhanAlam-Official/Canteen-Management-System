Imports System.Data.SqlClient
Imports System.Configuration

Public Class ForgetPassword

    ' Assuming your connection string is set properly
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("CMS.My.MySettings.CMSConnectionString").ConnectionString
    Private generatedOTP As String = ""

    ' Form Load Event - Initially hide OTP and Update Password controls
    Private Sub ForgetPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    End Sub

    ' Send OTP Button Click Event
    Private Sub btnSendOTP_Click(sender As Object, e As EventArgs) Handles btnSendOTP.Click
        Dim email As String = rtxtboxemail.Text.Trim()

        If String.IsNullOrEmpty(email) Then
            MessageBox.Show("Please enter your email.")
            Return
        End If

        ' Validate if email exists in the Users table
        If ValidateEmailExists(email) Then
            ' Generate OTP
            generatedOTP = GenerateOTP()

            ' Set up the notification icon and message
            notifyOTP.BalloonTipTitle = "OTP Notification"
            notifyOTP.BalloonTipText = "Your OTP code is: " & generatedOTP
            notifyOTP.Icon = SystemIcons.Information ' You can use a custom icon if needed
            notifyOTP.Visible = True

            ' Show the notification
            notifyOTP.ShowBalloonTip(3000) ' Display for 3 seconds

            ' Hide email input and show OTP input
            lblemail.Visible = False
            lblEmailmsg.Text = "Enter the OTP Send to you"
            rtxtboxemail.Visible = False
            lblOTP.Visible = True
            rtxtboxOTP.Visible = True
            btnSubmitOTP.Visible = True
            btnSendOTP.Visible = False

        Else
            MessageBox.Show("This email does not exist in our records.")
        End If
    End Sub

    ' Function to Validate if the Email Exists in the Database
    Private Function ValidateEmailExists(email As String) As Boolean
        Dim query As String = "SELECT COUNT(1) FROM Users WHERE email = @Email AND status = 1"
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Email", email)
                conn.Open()
                Dim exists As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return exists > 0
            End Using
        End Using
    End Function

    ' OTP Submit Button Click Event
    Private Sub btnSubmitOTP_Click(sender As Object, e As EventArgs) Handles btnSubmitOTP.Click
        Dim enteredOTP As String = rtxtboxOTP.Text.Trim()

        ' Verify if entered OTP matches generated OTP
        If enteredOTP = generatedOTP Then
            ' Hide OTP controls and load ForgetPasswordChange user control
            lblOTP.Visible = False
            rtxtboxOTP.Visible = False

            ' Load ForgetPasswordChange and pass the email
            Dim passwordChangeControl As New ForgetPasswordChange(rtxtboxemail.Text.Trim()) ' Pass email here

            Try
                pnlMain.Controls.Clear()
                passwordChangeControl.Dock = DockStyle.Fill
                pnlMain.Controls.Add(passwordChangeControl)
            Catch ex As Exception
                MessageBox.Show("An error occurred while loading user control: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Invalid OTP. Please try again.")
        End If
    End Sub

    ' Function to Generate OTP
    Private Function GenerateOTP() As String
        Dim rnd As New Random()
        Return rnd.Next(100000, 999999).ToString() ' Generates a 6-digit OTP
    End Function

End Class
