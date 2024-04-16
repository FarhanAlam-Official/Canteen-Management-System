<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login_Page
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
        Me.components = New System.ComponentModel.Container()
        Me.lblwelcome = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.rtxtboxusername = New System.Windows.Forms.RichTextBox()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.lblsubtitle = New System.Windows.Forms.Label()
        Me.lblforgetpassword = New System.Windows.Forms.Label()
        Me.lblfootermsg = New System.Windows.Forms.Label()
        Me.btnTogglePassword = New System.Windows.Forms.Button()
        Me.btnregister = New System.Windows.Forms.Button()
        Me.gboxlogin = New System.Windows.Forms.GroupBox()
        Me.lblprocessing = New System.Windows.Forms.Label()
        Me.lblmsg = New System.Windows.Forms.Label()
        Me.rtxtboxpassword = New System.Windows.Forms.TextBox()
        Me.notifyOTP = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.btnCancel = New CMS.RoundedButton()
        Me.btnLogin = New CMS.RoundedButton()
        Me.gboxlogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblwelcome
        '
        Me.lblwelcome.AutoSize = True
        Me.lblwelcome.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwelcome.Location = New System.Drawing.Point(24, 20)
        Me.lblwelcome.Name = "lblwelcome"
        Me.lblwelcome.Size = New System.Drawing.Size(237, 36)
        Me.lblwelcome.TabIndex = 1
        Me.lblwelcome.Text = "Welcome Back"
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.White
        Me.lbltitle.Font = New System.Drawing.Font("Monotype Corsiva", 25.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lbltitle.Location = New System.Drawing.Point(131, 47)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(103, 52)
        Me.lbltitle.TabIndex = 2
        Me.lbltitle.Text = "CMS"
        '
        'rtxtboxusername
        '
        Me.rtxtboxusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtxtboxusername.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtboxusername.Location = New System.Drawing.Point(33, 139)
        Me.rtxtboxusername.Margin = New System.Windows.Forms.Padding(3, 6, 3, 2)
        Me.rtxtboxusername.Name = "rtxtboxusername"
        Me.rtxtboxusername.Size = New System.Drawing.Size(356, 35)
        Me.rtxtboxusername.TabIndex = 3
        Me.rtxtboxusername.Text = ""
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.BackColor = System.Drawing.Color.Transparent
        Me.lblusername.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.ForeColor = System.Drawing.Color.Gray
        Me.lblusername.Location = New System.Drawing.Point(42, 124)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(54, 19)
        Me.lblusername.TabIndex = 4
        Me.lblusername.Text = "Email"
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.BackColor = System.Drawing.Color.Transparent
        Me.lblpassword.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpassword.ForeColor = System.Drawing.Color.Gray
        Me.lblpassword.Location = New System.Drawing.Point(42, 218)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(81, 19)
        Me.lblpassword.TabIndex = 6
        Me.lblpassword.Text = "Password"
        '
        'lblsubtitle
        '
        Me.lblsubtitle.AutoSize = True
        Me.lblsubtitle.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubtitle.ForeColor = System.Drawing.Color.Gray
        Me.lblsubtitle.Location = New System.Drawing.Point(26, 65)
        Me.lblsubtitle.Name = "lblsubtitle"
        Me.lblsubtitle.Size = New System.Drawing.Size(328, 21)
        Me.lblsubtitle.TabIndex = 7
        Me.lblsubtitle.Text = "Sign In with your Username and Password "
        '
        'lblforgetpassword
        '
        Me.lblforgetpassword.AutoSize = True
        Me.lblforgetpassword.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblforgetpassword.ForeColor = System.Drawing.Color.Gray
        Me.lblforgetpassword.Location = New System.Drawing.Point(128, 375)
        Me.lblforgetpassword.Name = "lblforgetpassword"
        Me.lblforgetpassword.Size = New System.Drawing.Size(160, 23)
        Me.lblforgetpassword.TabIndex = 8
        Me.lblforgetpassword.Text = "Forget Password ?"
        '
        'lblfootermsg
        '
        Me.lblfootermsg.AutoSize = True
        Me.lblfootermsg.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfootermsg.ForeColor = System.Drawing.Color.Gray
        Me.lblfootermsg.Location = New System.Drawing.Point(26, 546)
        Me.lblfootermsg.Name = "lblfootermsg"
        Me.lblfootermsg.Size = New System.Drawing.Size(210, 23)
        Me.lblfootermsg.TabIndex = 11
        Me.lblfootermsg.Text = "Don't have a account ?  "
        '
        'btnTogglePassword
        '
        Me.btnTogglePassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTogglePassword.BackgroundImage = Global.CMS.My.Resources.Resources.Eye_Open
        Me.btnTogglePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTogglePassword.FlatAppearance.BorderSize = 0
        Me.btnTogglePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTogglePassword.Location = New System.Drawing.Point(355, 230)
        Me.btnTogglePassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTogglePassword.Name = "btnTogglePassword"
        Me.btnTogglePassword.Size = New System.Drawing.Size(40, 35)
        Me.btnTogglePassword.TabIndex = 9
        Me.btnTogglePassword.UseVisualStyleBackColor = True
        '
        'btnregister
        '
        Me.btnregister.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnregister.BackColor = System.Drawing.Color.Transparent
        Me.btnregister.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnregister.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregister.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnregister.Location = New System.Drawing.Point(261, 538)
        Me.btnregister.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnregister.Name = "btnregister"
        Me.btnregister.Size = New System.Drawing.Size(96, 37)
        Me.btnregister.TabIndex = 14
        Me.btnregister.Text = "Sign Up"
        Me.btnregister.UseVisualStyleBackColor = False
        '
        'gboxlogin
        '
        Me.gboxlogin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gboxlogin.BackColor = System.Drawing.Color.White
        Me.gboxlogin.Controls.Add(Me.btnCancel)
        Me.gboxlogin.Controls.Add(Me.btnLogin)
        Me.gboxlogin.Controls.Add(Me.lblprocessing)
        Me.gboxlogin.Controls.Add(Me.lblmsg)
        Me.gboxlogin.Controls.Add(Me.btnregister)
        Me.gboxlogin.Controls.Add(Me.lblfootermsg)
        Me.gboxlogin.Controls.Add(Me.btnTogglePassword)
        Me.gboxlogin.Controls.Add(Me.lblforgetpassword)
        Me.gboxlogin.Controls.Add(Me.lblsubtitle)
        Me.gboxlogin.Controls.Add(Me.lblpassword)
        Me.gboxlogin.Controls.Add(Me.lblusername)
        Me.gboxlogin.Controls.Add(Me.rtxtboxusername)
        Me.gboxlogin.Controls.Add(Me.lblwelcome)
        Me.gboxlogin.Controls.Add(Me.rtxtboxpassword)
        Me.gboxlogin.Location = New System.Drawing.Point(34, 113)
        Me.gboxlogin.Name = "gboxlogin"
        Me.gboxlogin.Padding = New System.Windows.Forms.Padding(3, 15, 3, 3)
        Me.gboxlogin.Size = New System.Drawing.Size(426, 607)
        Me.gboxlogin.TabIndex = 17
        Me.gboxlogin.TabStop = False
        '
        'lblprocessing
        '
        Me.lblprocessing.AutoSize = True
        Me.lblprocessing.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprocessing.ForeColor = System.Drawing.Color.Black
        Me.lblprocessing.Location = New System.Drawing.Point(116, 281)
        Me.lblprocessing.Name = "lblprocessing"
        Me.lblprocessing.Size = New System.Drawing.Size(0, 23)
        Me.lblprocessing.TabIndex = 21
        Me.lblprocessing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblprocessing.Visible = False
        '
        'lblmsg
        '
        Me.lblmsg.AutoSize = True
        Me.lblmsg.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmsg.Location = New System.Drawing.Point(42, 293)
        Me.lblmsg.Name = "lblmsg"
        Me.lblmsg.Size = New System.Drawing.Size(0, 23)
        Me.lblmsg.TabIndex = 19
        Me.lblmsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblmsg.Visible = False
        '
        'rtxtboxpassword
        '
        Me.rtxtboxpassword.Font = New System.Drawing.Font("Trebuchet MS", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtboxpassword.Location = New System.Drawing.Point(33, 230)
        Me.rtxtboxpassword.Name = "rtxtboxpassword"
        Me.rtxtboxpassword.Size = New System.Drawing.Size(324, 35)
        Me.rtxtboxpassword.TabIndex = 30
        '
        'notifyOTP
        '
        Me.notifyOTP.Text = "NotifyIcon1"
        Me.notifyOTP.Visible = True
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.CornerRadius = 35
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCancel.FlatAppearance.BorderSize = 10
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(222, 425)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(145, 47)
        Me.btnCancel.TabIndex = 32
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnLogin.CornerRadius = 35
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLogin.FlatAppearance.BorderSize = 10
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(33, 425)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(145, 47)
        Me.btnLogin.TabIndex = 31
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Login_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = Global.CMS.My.Resources.Resources.loginpage2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1304, 760)
        Me.Controls.Add(Me.gboxlogin)
        Me.Controls.Add(Me.lbltitle)
        Me.Location = New System.Drawing.Point(900, 500)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Login_Page"
        Me.Text = "Login Page"
        Me.gboxlogin.ResumeLayout(False)
        Me.gboxlogin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblwelcome As Label
    Friend WithEvents lbltitle As Label
    Friend WithEvents rtxtboxusername As RichTextBox
    Friend WithEvents lblusername As Label
    Friend WithEvents lblpassword As Label
    Friend WithEvents lblsubtitle As Label
    Friend WithEvents lblforgetpassword As Label
    Friend WithEvents btnTogglePassword As Button
    Friend WithEvents lblfootermsg As Label
    Friend WithEvents btnregister As Button
    Friend WithEvents gboxlogin As GroupBox
    Friend WithEvents lblmsg As Label
    Friend WithEvents lblprocessing As Label
    Friend WithEvents rtxtboxpassword As TextBox
    Friend WithEvents notifyOTP As NotifyIcon
    Friend WithEvents btnCancel As RoundedButton
    Friend WithEvents btnLogin As RoundedButton
End Class
