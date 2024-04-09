Public Class Home_Page

    Private userId As Integer

    ' Constructor to accept user ID
    Public Sub New(Optional userId As Integer = 1011)
        InitializeComponent()
        Me.userId = userId
        ' You can now use the userId to track the customer
    End Sub

    'Default Constructor
    Public Sub New()
        InitializeComponent()
        Me.userId = 1011
        ' You can now use the userId to track the customer
    End Sub

    ' Mouse Enter/Leave events to change colors for labels and buttons for visual appeal
    Private Sub LblHome_MouseEnter(sender As Object, e As EventArgs) Handles lblHome.MouseEnter
        ChangeLabelColor(lblHome, Color.FromArgb(0, 191, 99))
    End Sub

    Private Sub LblHome_MouseLeave(sender As Object, e As EventArgs) Handles lblHome.MouseLeave
        ChangeLabelColor(lblHome, Color.Black)
    End Sub

    Private Sub LblMenu_MouseEnter(sender As Object, e As EventArgs) Handles lblMenu.MouseEnter
        ChangeLabelColor(lblMenu, Color.FromArgb(0, 191, 99))
    End Sub

    Private Sub LblMenu_MouseLeave(sender As Object, e As EventArgs) Handles lblMenu.MouseLeave
        ChangeLabelColor(lblMenu, Color.Black)
    End Sub

    Private Sub LblAboutUs_MouseEnter(sender As Object, e As EventArgs) Handles lblAboutUs.MouseEnter
        ChangeLabelColor(lblAboutUs, Color.FromArgb(0, 191, 99))
    End Sub

    Private Sub LblAboutUs_MouseLeave(sender As Object, e As EventArgs) Handles lblAboutUs.MouseLeave
        ChangeLabelColor(lblAboutUs, Color.Black)
    End Sub

    Private Sub LblContact_MouseEnter(sender As Object, e As EventArgs) Handles lblContact.MouseEnter
        ChangeLabelColor(lblContact, Color.FromArgb(0, 191, 99))
    End Sub

    Private Sub LblContact_MouseLeave(sender As Object, e As EventArgs) Handles lblContact.MouseLeave
        ChangeLabelColor(lblContact, Color.Black)
    End Sub

    ' Social media label color changes for Google, Facebook, etc.
    Private Sub LblGoogle_MouseEnter(sender As Object, e As EventArgs) Handles lblGoogle.MouseEnter
        ChangeLabelColor(lblGoogle, Color.Black)
    End Sub

    Private Sub LblGoogle_MouseLeave(sender As Object, e As EventArgs) Handles lblGoogle.MouseLeave
        ChangeLabelColor(lblGoogle, Color.DimGray)
    End Sub

    Private Sub LblFacebook_MouseEnter(sender As Object, e As EventArgs) Handles lblFacebook.MouseEnter
        ChangeLabelColor(lblFacebook, Color.Blue)
    End Sub

    Private Sub LblFacebook_MouseLeave(sender As Object, e As EventArgs) Handles lblFacebook.MouseLeave
        ChangeLabelColor(lblFacebook, Color.DimGray)
    End Sub

    Private Sub LblYoutube_MouseEnter(sender As Object, e As EventArgs) Handles lblYoutube.MouseEnter
        ChangeLabelColor(lblYoutube, Color.Red)
    End Sub

    Private Sub LblYoutube_MouseLeave(sender As Object, e As EventArgs) Handles lblYoutube.MouseLeave
        ChangeLabelColor(lblYoutube, Color.DimGray)
    End Sub

    Private Sub LblInstagram_MouseEnter(sender As Object, e As EventArgs) Handles lblInstagram.MouseEnter
        ChangeLabelColor(lblInstagram, Color.Red)
    End Sub

    Private Sub LblInstagram_MouseLeave(sender As Object, e As EventArgs) Handles lblInstagram.MouseLeave
        ChangeLabelColor(lblInstagram, Color.DimGray)
    End Sub

    ' Changes the background color of the Sign In button when hovered
    Private Sub BtnSignIn_MouseEnter(sender As Object, e As EventArgs) Handles btnLogin.MouseEnter
        btnLogin.BackColor = Color.FromArgb(0, 175, 99) ' Darker shade for hover
        btnLogin.ForeColor = Color.White
    End Sub

    Private Sub btnSignIn_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin.MouseLeave
        btnLogin.BackColor = Color.FromArgb(0, 191, 99) ' Original color
        btnLogin.ForeColor = Color.White
    End Sub

    Private Sub BtnSignUp_MouseEnter(sender As Object, e As EventArgs) Handles btnSignUp.MouseEnter
        btnSignUp.BackColor = Color.FromArgb(0, 175, 99) ' shade for hover
        btnSignUp.ForeColor = Color.White
    End Sub

    Private Sub btnSignUp_MouseLeave(sender As Object, e As EventArgs) Handles btnSignUp.MouseLeave
        btnSignUp.BackColor = Color.White
        btnSignUp.ForeColor = Color.FromArgb(0, 191, 99) ' Original color
    End Sub

    Private Sub BtnOrderNow_MouseEnter(sender As Object, e As EventArgs) Handles btnOrderNow.MouseEnter
        btnOrderNow.BackColor = Color.FromArgb(0, 175, 99) ' Darker shade for hover
        btnOrderNow.ForeColor = Color.White
    End Sub

    Private Sub btnOrderNow_MouseLeave(sender As Object, e As EventArgs) Handles btnOrderNow.MouseLeave
        btnOrderNow.BackColor = Color.FromArgb(0, 191, 99) ' Original color
        btnOrderNow.ForeColor = Color.White
    End Sub

    Private Sub BtnViewPlate_MouseEnter(sender As Object, e As EventArgs) Handles btnViewPlate.MouseEnter
        btnViewPlate.BackColor = Color.FromArgb(0, 175, 99) ' shade for hover
        btnViewPlate.ForeColor = Color.White
    End Sub

    Private Sub btnViewPlate_MouseLeave(sender As Object, e As EventArgs) Handles btnViewPlate.MouseLeave
        btnViewPlate.BackColor = Color.White
        btnViewPlate.ForeColor = Color.FromArgb(0, 191, 99) ' Original color
    End Sub

    ' Click event for navigating to the Menu_Page and passing userId
    Private Sub LblMenu_Click(sender As Object, e As EventArgs) Handles lblMenu.Click
        Try
            Dim menuPage As New Menu_Page(userId)
            menuPage.Show()
        Catch ex As Exception
            MessageBox.Show("An error occurred while opening the menu page: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Click event for navigating to Contact_Us_Page
    Private Sub lblContact_Click(sender As Object, e As EventArgs) Handles lblContact.Click
        Try
            Dim contactUsPage As New Contact_Us_Page
            contactUsPage.Show()
        Catch ex As Exception
            MessageBox.Show("An error occurred while opening the contact page: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Click event for navigating to About_Us_Page
    Private Sub lblAboutUs_Click(sender As Object, e As EventArgs) Handles lblAboutUs.Click
        Try
            Dim aboutUsPage As New About_Us_Page
            aboutUsPage.Show()
        Catch ex As Exception
            MessageBox.Show("An error occurred while opening the about page: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Click event for the Sign Up button
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Try
            Dim signUpPage As New Register()
            signUpPage.Show()
        Catch ex As Exception
            MessageBox.Show("An error occurred while opening the sign-up page: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Click event for the Login button
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Dim loginPage As New Login_Page()
            loginPage.Show()
        Catch ex As Exception
            MessageBox.Show("An error occurred while opening the login page: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Event to navigate to Plate_Page when the "View Plate" button is clicked
    Private Sub btnViewPlate_Click(sender As Object, e As EventArgs) Handles btnViewPlate.Click
        Try
            Dim platePage As New Plate_Page(userId)
            platePage.Show()
        Catch ex As Exception
            MessageBox.Show("An error occurred while opening the plate page: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Event to navigate to Order_Page when the "Order Now" button is clicked
    Private Sub btnOrderNow_Click(sender As Object, e As EventArgs) Handles btnOrderNow.Click
        Try
            Dim billPage As New Billing_Page(userId)
            billPage.Show()
        Catch ex As Exception
            MessageBox.Show("An error occurred while opening the order page: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Helper function to change label color dynamically
    Private Sub ChangeLabelColor(label As Label, color As Color)
        label.ForeColor = color
    End Sub

    ' Helper function to change buttin color dynamically
    Private Sub ChangeButtonColor(btn As Label, color As Color)
        btn.ForeColor = color
    End Sub
    ' Event to handle the Logout button click - close all open forms
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Try
            For Each frm As Form In Application.OpenForms.Cast(Of Form).ToList()
                frm.Close()
            Next
        Catch ex As Exception
            MessageBox.Show("An error occurred while logging out: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Home_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
