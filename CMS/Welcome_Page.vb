Imports System.Data.SqlClient
Imports System.Drawing

Public Class Welcome_Page

    ' Form load event to center the form on the screen with error handling
    Private Sub Welcome_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CenterForm()
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading the page: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Center the form manually on the screen
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

    ' Event handler for Sign In button click
    Private Sub BtnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        Try
            Dim loginpage As New Login_Page
            loginpage.ShowDialog()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred while opening the login page: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Event handler for Sign In button click
    Private Sub btnRegistration_Click(sender As Object, e As EventArgs) Handles btnRegistration.Click
        Try
            Dim registerpage As New Register
            registerpage.ShowDialog()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred while opening the login page: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' Event handler for Guest button click (Male)
    Private Sub btnGuestSignInMale_Click(sender As Object, e As EventArgs) Handles btnGuestSignInMale.Click
        Try
            Dim homepage As New Home_Page(1011) ' Assuming 1011 is an identifier for guest user
            homepage.ShowDialog()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred while opening the guest page: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Event handler for Guest button click (Female)
    Private Sub btnSignInFemale_Click(sender As Object, e As EventArgs) Handles btnGuestSignInFemale.Click
        Try
            Dim homepage As New Home_Page(1013) ' Assuming 1013 is an identifier for female guest user
            homepage.ShowDialog()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred while opening the female guest page: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' MouseEnter and MouseLeave events to change button appearance (Hover effects)

    ' Changes the background color of the Sign In button when hovered
    Private Sub BtnSignIn_MouseEnter(sender As Object, e As EventArgs) Handles btnSignIn.MouseEnter
        btnSignIn.BackColor = Color.FromArgb(0, 175, 99) ' Darker shade for hover
    End Sub

    Private Sub btnSignIn_MouseLeave(sender As Object, e As EventArgs) Handles btnSignIn.MouseLeave
        btnSignIn.BackColor = Color.FromArgb(0, 191, 99) ' Original color
    End Sub

    ' Changes the background color of the Guest button (Male) when hovered
    Private Sub btnGuest_MouseEnter(sender As Object, e As EventArgs) Handles btnGuestSignInMale.MouseEnter
        btnGuestSignInMale.BackColor = Color.Gray
        btnGuestSignInMale.ForeColor = Color.White
    End Sub

    Private Sub btnGuest_MouseLeave(sender As Object, e As EventArgs) Handles btnGuestSignInMale.MouseLeave
        btnGuestSignInMale.BackColor = Color.Black ' Original color
        btnGuestSignInMale.ForeColor = Color.White
    End Sub

    ' Changes the background color of the Sign Up button when hovered
    Private Sub btnRegistration_MouseEnter(sender As Object, e As EventArgs) Handles btnRegistration.MouseEnter
        btnRegistration.BackColor = Color.FromArgb(0, 191, 99) ' Highlighted green
        btnRegistration.ForeColor = Color.White
    End Sub

    Private Sub btnRegistration_MouseLeave(sender As Object, e As EventArgs) Handles btnRegistration.MouseLeave
        btnRegistration.BackColor = Color.White ' Original color
        btnRegistration.ForeColor = Color.FromArgb(0, 191, 99)
    End Sub

    ' Changes the background color of the Guest button (Female) when hovered
    Private Sub btnSignInFemale_MouseEnter(sender As Object, e As EventArgs) Handles btnGuestSignInFemale.MouseEnter
        btnGuestSignInFemale.BackColor = Color.Gray
        btnGuestSignInFemale.ForeColor = Color.White
    End Sub

    Private Sub btnSignInFemale_MouseLeave(sender As Object, e As EventArgs) Handles btnGuestSignInFemale.MouseLeave
        btnGuestSignInFemale.BackColor = Color.Black ' Original color
        btnGuestSignInFemale.ForeColor = Color.White
    End Sub

End Class
