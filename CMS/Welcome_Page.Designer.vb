<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Welcome_Page
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Welcome_Page))
        Me.lblProjectName = New System.Windows.Forms.Label()
        Me.lblTeamName = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblWelcomemsg = New System.Windows.Forms.Label()
        Me.btnSignIn = New CMS.RoundedButton()
        Me.btnRegistration = New CMS.RoundedButton()
        Me.btnGuestSignInFemale = New CMS.RoundedButton()
        Me.btnGuestSignInMale = New CMS.RoundedButton()
        Me.SuspendLayout()
        '
        'lblProjectName
        '
        Me.lblProjectName.AutoSize = True
        Me.lblProjectName.Font = New System.Drawing.Font("Monotype Corsiva", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblProjectName.Location = New System.Drawing.Point(12, 29)
        Me.lblProjectName.Name = "lblProjectName"
        Me.lblProjectName.Size = New System.Drawing.Size(569, 60)
        Me.lblProjectName.TabIndex = 0
        Me.lblProjectName.Text = "Canteen Management System"
        '
        'lblTeamName
        '
        Me.lblTeamName.AutoSize = True
        Me.lblTeamName.BackColor = System.Drawing.Color.Transparent
        Me.lblTeamName.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeamName.Location = New System.Drawing.Point(252, 100)
        Me.lblTeamName.Name = "lblTeamName"
        Me.lblTeamName.Size = New System.Drawing.Size(262, 37)
        Me.lblTeamName.TabIndex = 1
        Me.lblTeamName.Text = "Project by CRF Crew"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblWelcome.Location = New System.Drawing.Point(58, 246)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(354, 49)
        Me.lblWelcome.TabIndex = 4
        Me.lblWelcome.Text = "WELCOME TO CMS"
        '
        'lblWelcomemsg
        '
        Me.lblWelcomemsg.AutoSize = True
        Me.lblWelcomemsg.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomemsg.ForeColor = System.Drawing.Color.DimGray
        Me.lblWelcomemsg.Location = New System.Drawing.Point(35, 307)
        Me.lblWelcomemsg.Name = "lblWelcomemsg"
        Me.lblWelcomemsg.Size = New System.Drawing.Size(410, 60)
        Me.lblWelcomemsg.TabIndex = 6
        Me.lblWelcomemsg.Text = " Enjoy a seamless dining experience with " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "easy access to menus, order tracking, " &
    "and payment options" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "—all designed to serve you better!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblWelcomemsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSignIn
        '
        Me.btnSignIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnSignIn.CornerRadius = 50
        Me.btnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSignIn.FlatAppearance.BorderSize = 10
        Me.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignIn.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignIn.ForeColor = System.Drawing.Color.White
        Me.btnSignIn.Location = New System.Drawing.Point(281, 428)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(191, 58)
        Me.btnSignIn.TabIndex = 32
        Me.btnSignIn.Text = "Sign In"
        Me.btnSignIn.UseVisualStyleBackColor = False
        '
        'btnRegistration
        '
        Me.btnRegistration.BackColor = System.Drawing.Color.White
        Me.btnRegistration.CornerRadius = 50
        Me.btnRegistration.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRegistration.FlatAppearance.BorderSize = 10
        Me.btnRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistration.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnRegistration.Location = New System.Drawing.Point(22, 430)
        Me.btnRegistration.Name = "btnRegistration"
        Me.btnRegistration.Size = New System.Drawing.Size(191, 56)
        Me.btnRegistration.TabIndex = 33
        Me.btnRegistration.Text = "Sign Up"
        Me.btnRegistration.UseVisualStyleBackColor = False
        '
        'btnGuestSignInFemale
        '
        Me.btnGuestSignInFemale.BackColor = System.Drawing.Color.Black
        Me.btnGuestSignInFemale.CornerRadius = 50
        Me.btnGuestSignInFemale.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnGuestSignInFemale.FlatAppearance.BorderSize = 10
        Me.btnGuestSignInFemale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuestSignInFemale.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuestSignInFemale.ForeColor = System.Drawing.Color.White
        Me.btnGuestSignInFemale.Location = New System.Drawing.Point(281, 544)
        Me.btnGuestSignInFemale.Name = "btnGuestSignInFemale"
        Me.btnGuestSignInFemale.Size = New System.Drawing.Size(191, 58)
        Me.btnGuestSignInFemale.TabIndex = 34
        Me.btnGuestSignInFemale.Text = "Guest Acc (F)"
        Me.btnGuestSignInFemale.UseVisualStyleBackColor = False
        '
        'btnGuestSignInMale
        '
        Me.btnGuestSignInMale.BackColor = System.Drawing.Color.Black
        Me.btnGuestSignInMale.CornerRadius = 50
        Me.btnGuestSignInMale.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnGuestSignInMale.FlatAppearance.BorderSize = 10
        Me.btnGuestSignInMale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuestSignInMale.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuestSignInMale.ForeColor = System.Drawing.Color.White
        Me.btnGuestSignInMale.Location = New System.Drawing.Point(22, 544)
        Me.btnGuestSignInMale.Name = "btnGuestSignInMale"
        Me.btnGuestSignInMale.Size = New System.Drawing.Size(191, 58)
        Me.btnGuestSignInMale.TabIndex = 35
        Me.btnGuestSignInMale.Text = "Guest Acc (M)"
        Me.btnGuestSignInMale.UseVisualStyleBackColor = False
        '
        'Welcome_Page
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1041, 632)
        Me.Controls.Add(Me.btnGuestSignInMale)
        Me.Controls.Add(Me.btnGuestSignInFemale)
        Me.Controls.Add(Me.btnRegistration)
        Me.Controls.Add(Me.btnSignIn)
        Me.Controls.Add(Me.lblWelcomemsg)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblTeamName)
        Me.Controls.Add(Me.lblProjectName)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Welcome_Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProjectName As Label
    Friend WithEvents lblTeamName As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblWelcomemsg As Label
    Friend WithEvents btnSignIn As RoundedButton
    Friend WithEvents btnRegistration As RoundedButton
    Friend WithEvents btnGuestSignInFemale As RoundedButton
    Friend WithEvents btnGuestSignInMale As RoundedButton
End Class
