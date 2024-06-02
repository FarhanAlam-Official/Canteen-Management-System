<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.lblfootermsg = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rtxtboxemail = New System.Windows.Forms.RichTextBox()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.rtxtboxfirstname = New System.Windows.Forms.RichTextBox()
        Me.rtxtboxlastname = New System.Windows.Forms.RichTextBox()
        Me.lbllastname = New System.Windows.Forms.Label()
        Me.lblfirstname = New System.Windows.Forms.Label()
        Me.radiobtnmale = New System.Windows.Forms.RadioButton()
        Me.radiobtnothers = New System.Windows.Forms.RadioButton()
        Me.radiobtnfemale = New System.Windows.Forms.RadioButton()
        Me.lblsex = New System.Windows.Forms.Label()
        Me.rtxtboxage = New System.Windows.Forms.RichTextBox()
        Me.lblage = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.gboxregister = New System.Windows.Forms.GroupBox()
        Me.btncancel = New CMS.RoundedButton()
        Me.btnSignIn = New CMS.RoundedButton()
        Me.lblUppercase = New System.Windows.Forms.Label()
        Me.lblLowercase = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblSpecialChar = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.btnTogglecPassword = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtboxconfirmpassword = New System.Windows.Forms.TextBox()
        Me.btnTogglePassword = New System.Windows.Forms.Button()
        Me.lblphone = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtboxpassword = New System.Windows.Forms.TextBox()
        Me.rtxtboxphoneno = New System.Windows.Forms.RichTextBox()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.gboxregister.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblfootermsg
        '
        Me.lblfootermsg.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblfootermsg.AutoSize = True
        Me.lblfootermsg.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfootermsg.ForeColor = System.Drawing.Color.DarkGray
        Me.lblfootermsg.Location = New System.Drawing.Point(59, 651)
        Me.lblfootermsg.Name = "lblfootermsg"
        Me.lblfootermsg.Size = New System.Drawing.Size(215, 20)
        Me.lblfootermsg.TabIndex = 24
        Me.lblfootermsg.Text = "Already have a account ?  "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(-131, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 17)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(-131, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 17)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Username"
        '
        'rtxtboxemail
        '
        Me.rtxtboxemail.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Bold)
        Me.rtxtboxemail.Location = New System.Drawing.Point(51, 239)
        Me.rtxtboxemail.Name = "rtxtboxemail"
        Me.rtxtboxemail.Size = New System.Drawing.Size(371, 35)
        Me.rtxtboxemail.TabIndex = 16
        Me.rtxtboxemail.Text = ""
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.Transparent
        Me.lbltitle.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lbltitle.Location = New System.Drawing.Point(953, -1)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(235, 37)
        Me.lbltitle.TabIndex = 14
        Me.lbltitle.Text = "Create Account"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.BackColor = System.Drawing.Color.Transparent
        Me.lblemail.Font = New System.Drawing.Font("Times New Roman", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.ForeColor = System.Drawing.Color.Gray
        Me.lblemail.Location = New System.Drawing.Point(59, 227)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(47, 19)
        Me.lblemail.TabIndex = 27
        Me.lblemail.Text = "Email"
        '
        'rtxtboxfirstname
        '
        Me.rtxtboxfirstname.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtboxfirstname.Location = New System.Drawing.Point(51, 38)
        Me.rtxtboxfirstname.Name = "rtxtboxfirstname"
        Me.rtxtboxfirstname.Size = New System.Drawing.Size(176, 35)
        Me.rtxtboxfirstname.TabIndex = 0
        Me.rtxtboxfirstname.Text = ""
        '
        'rtxtboxlastname
        '
        Me.rtxtboxlastname.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Bold)
        Me.rtxtboxlastname.Location = New System.Drawing.Point(246, 38)
        Me.rtxtboxlastname.Name = "rtxtboxlastname"
        Me.rtxtboxlastname.Size = New System.Drawing.Size(176, 35)
        Me.rtxtboxlastname.TabIndex = 29
        Me.rtxtboxlastname.Text = ""
        '
        'lbllastname
        '
        Me.lbllastname.AutoSize = True
        Me.lbllastname.BackColor = System.Drawing.Color.Transparent
        Me.lbllastname.Font = New System.Drawing.Font("Times New Roman", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllastname.ForeColor = System.Drawing.Color.Gray
        Me.lbllastname.Location = New System.Drawing.Point(252, 25)
        Me.lbllastname.Name = "lbllastname"
        Me.lbllastname.Size = New System.Drawing.Size(79, 19)
        Me.lbllastname.TabIndex = 33
        Me.lbllastname.Text = "LastName"
        '
        'lblfirstname
        '
        Me.lblfirstname.AutoSize = True
        Me.lblfirstname.BackColor = System.Drawing.Color.Transparent
        Me.lblfirstname.Font = New System.Drawing.Font("Times New Roman", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfirstname.ForeColor = System.Drawing.Color.Gray
        Me.lblfirstname.Location = New System.Drawing.Point(59, 25)
        Me.lblfirstname.Name = "lblfirstname"
        Me.lblfirstname.Size = New System.Drawing.Size(80, 19)
        Me.lblfirstname.TabIndex = 34
        Me.lblfirstname.Text = "FirstName"
        '
        'radiobtnmale
        '
        Me.radiobtnmale.AutoSize = True
        Me.radiobtnmale.Location = New System.Drawing.Point(53, 120)
        Me.radiobtnmale.Name = "radiobtnmale"
        Me.radiobtnmale.Size = New System.Drawing.Size(39, 20)
        Me.radiobtnmale.TabIndex = 35
        Me.radiobtnmale.TabStop = True
        Me.radiobtnmale.Text = "M"
        Me.radiobtnmale.UseVisualStyleBackColor = True
        '
        'radiobtnothers
        '
        Me.radiobtnothers.AutoSize = True
        Me.radiobtnothers.Location = New System.Drawing.Point(161, 120)
        Me.radiobtnothers.Name = "radiobtnothers"
        Me.radiobtnothers.Size = New System.Drawing.Size(67, 20)
        Me.radiobtnothers.TabIndex = 36
        Me.radiobtnothers.TabStop = True
        Me.radiobtnothers.Text = "Others"
        Me.radiobtnothers.UseVisualStyleBackColor = True
        '
        'radiobtnfemale
        '
        Me.radiobtnfemale.AutoSize = True
        Me.radiobtnfemale.Location = New System.Drawing.Point(109, 120)
        Me.radiobtnfemale.Name = "radiobtnfemale"
        Me.radiobtnfemale.Size = New System.Drawing.Size(36, 20)
        Me.radiobtnfemale.TabIndex = 37
        Me.radiobtnfemale.TabStop = True
        Me.radiobtnfemale.Text = "F"
        Me.radiobtnfemale.UseVisualStyleBackColor = True
        '
        'lblsex
        '
        Me.lblsex.AutoSize = True
        Me.lblsex.BackColor = System.Drawing.Color.Transparent
        Me.lblsex.Font = New System.Drawing.Font("Times New Roman", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsex.ForeColor = System.Drawing.Color.Gray
        Me.lblsex.Location = New System.Drawing.Point(50, 99)
        Me.lblsex.Name = "lblsex"
        Me.lblsex.Size = New System.Drawing.Size(34, 19)
        Me.lblsex.TabIndex = 38
        Me.lblsex.Text = "Sex"
        '
        'rtxtboxage
        '
        Me.rtxtboxage.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Bold)
        Me.rtxtboxage.Location = New System.Drawing.Point(268, 119)
        Me.rtxtboxage.Name = "rtxtboxage"
        Me.rtxtboxage.Size = New System.Drawing.Size(154, 35)
        Me.rtxtboxage.TabIndex = 41
        Me.rtxtboxage.Text = ""
        '
        'lblage
        '
        Me.lblage.AutoSize = True
        Me.lblage.BackColor = System.Drawing.Color.Transparent
        Me.lblage.Font = New System.Drawing.Font("Times New Roman", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblage.ForeColor = System.Drawing.Color.Gray
        Me.lblage.Location = New System.Drawing.Point(277, 108)
        Me.lblage.Name = "lblage"
        Me.lblage.Size = New System.Drawing.Size(36, 19)
        Me.lblage.TabIndex = 42
        Me.lblage.Text = "Age"
        '
        'btnLogin
        '
        Me.btnLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(306, 644)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(88, 33)
        Me.btnLogin.TabIndex = 46
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'gboxregister
        '
        Me.gboxregister.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gboxregister.BackColor = System.Drawing.Color.White
        Me.gboxregister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.gboxregister.Controls.Add(Me.btncancel)
        Me.gboxregister.Controls.Add(Me.btnSignIn)
        Me.gboxregister.Controls.Add(Me.lblUppercase)
        Me.gboxregister.Controls.Add(Me.lblLowercase)
        Me.gboxregister.Controls.Add(Me.lblNumber)
        Me.gboxregister.Controls.Add(Me.lblSpecialChar)
        Me.gboxregister.Controls.Add(Me.lblLength)
        Me.gboxregister.Controls.Add(Me.btnTogglecPassword)
        Me.gboxregister.Controls.Add(Me.Label2)
        Me.gboxregister.Controls.Add(Me.txtboxconfirmpassword)
        Me.gboxregister.Controls.Add(Me.btnTogglePassword)
        Me.gboxregister.Controls.Add(Me.lblphone)
        Me.gboxregister.Controls.Add(Me.Label1)
        Me.gboxregister.Controls.Add(Me.btnLogin)
        Me.gboxregister.Controls.Add(Me.txtboxpassword)
        Me.gboxregister.Controls.Add(Me.lblage)
        Me.gboxregister.Controls.Add(Me.rtxtboxage)
        Me.gboxregister.Controls.Add(Me.lblsex)
        Me.gboxregister.Controls.Add(Me.radiobtnfemale)
        Me.gboxregister.Controls.Add(Me.radiobtnothers)
        Me.gboxregister.Controls.Add(Me.radiobtnmale)
        Me.gboxregister.Controls.Add(Me.lblfirstname)
        Me.gboxregister.Controls.Add(Me.lbllastname)
        Me.gboxregister.Controls.Add(Me.rtxtboxlastname)
        Me.gboxregister.Controls.Add(Me.rtxtboxfirstname)
        Me.gboxregister.Controls.Add(Me.lblemail)
        Me.gboxregister.Controls.Add(Me.lblfootermsg)
        Me.gboxregister.Controls.Add(Me.rtxtboxemail)
        Me.gboxregister.Controls.Add(Me.rtxtboxphoneno)
        Me.gboxregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gboxregister.Location = New System.Drawing.Point(805, 62)
        Me.gboxregister.Name = "gboxregister"
        Me.gboxregister.Size = New System.Drawing.Size(469, 686)
        Me.gboxregister.TabIndex = 48
        Me.gboxregister.TabStop = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.White
        Me.btncancel.CornerRadius = 35
        Me.btncancel.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btncancel.FlatAppearance.BorderSize = 10
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btncancel.Location = New System.Drawing.Point(268, 586)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(145, 47)
        Me.btncancel.TabIndex = 62
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnSignIn
        '
        Me.btnSignIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnSignIn.CornerRadius = 35
        Me.btnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSignIn.FlatAppearance.BorderSize = 10
        Me.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignIn.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignIn.ForeColor = System.Drawing.Color.White
        Me.btnSignIn.Location = New System.Drawing.Point(72, 586)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(145, 47)
        Me.btnSignIn.TabIndex = 61
        Me.btnSignIn.Text = "Register"
        Me.btnSignIn.UseVisualStyleBackColor = False
        '
        'lblUppercase
        '
        Me.lblUppercase.AutoSize = True
        Me.lblUppercase.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUppercase.ForeColor = System.Drawing.Color.Red
        Me.lblUppercase.Location = New System.Drawing.Point(51, 455)
        Me.lblUppercase.Name = "lblUppercase"
        Me.lblUppercase.Size = New System.Drawing.Size(234, 23)
        Me.lblUppercase.TabIndex = 60
        Me.lblUppercase.Text = "At least one uppercase letter"
        '
        'lblLowercase
        '
        Me.lblLowercase.AutoSize = True
        Me.lblLowercase.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLowercase.ForeColor = System.Drawing.Color.Red
        Me.lblLowercase.Location = New System.Drawing.Point(51, 485)
        Me.lblLowercase.Name = "lblLowercase"
        Me.lblLowercase.Size = New System.Drawing.Size(234, 23)
        Me.lblLowercase.TabIndex = 59
        Me.lblLowercase.Text = "At least one lowercase letter"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.ForeColor = System.Drawing.Color.Red
        Me.lblNumber.Location = New System.Drawing.Point(52, 515)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(165, 23)
        Me.lblNumber.TabIndex = 58
        Me.lblNumber.Text = "At least one number"
        '
        'lblSpecialChar
        '
        Me.lblSpecialChar.AutoSize = True
        Me.lblSpecialChar.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpecialChar.ForeColor = System.Drawing.Color.Red
        Me.lblSpecialChar.Location = New System.Drawing.Point(52, 544)
        Me.lblSpecialChar.Name = "lblSpecialChar"
        Me.lblSpecialChar.Size = New System.Drawing.Size(315, 23)
        Me.lblSpecialChar.TabIndex = 57
        Me.lblSpecialChar.Text = "At least one special character (@#$!%*?&)"
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength.ForeColor = System.Drawing.Color.Red
        Me.lblLength.Location = New System.Drawing.Point(51, 424)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(264, 23)
        Me.lblLength.TabIndex = 56
        Me.lblLength.Text = "Password length: 8-16 characters"
        '
        'btnTogglecPassword
        '
        Me.btnTogglecPassword.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTogglecPassword.BackgroundImage = Global.CMS.My.Resources.Resources.Eye_Open
        Me.btnTogglecPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTogglecPassword.FlatAppearance.BorderSize = 0
        Me.btnTogglecPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTogglecPassword.Location = New System.Drawing.Point(380, 371)
        Me.btnTogglecPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTogglecPassword.Name = "btnTogglecPassword"
        Me.btnTogglecPassword.Size = New System.Drawing.Size(42, 35)
        Me.btnTogglecPassword.TabIndex = 54
        Me.btnTogglecPassword.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(58, 357)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 19)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Confirm Password"
        '
        'txtboxconfirmpassword
        '
        Me.txtboxconfirmpassword.Font = New System.Drawing.Font("Trebuchet MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtboxconfirmpassword.Location = New System.Drawing.Point(51, 371)
        Me.txtboxconfirmpassword.Name = "txtboxconfirmpassword"
        Me.txtboxconfirmpassword.Size = New System.Drawing.Size(332, 35)
        Me.txtboxconfirmpassword.TabIndex = 55
        '
        'btnTogglePassword
        '
        Me.btnTogglePassword.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTogglePassword.BackgroundImage = Global.CMS.My.Resources.Resources.Eye_Open
        Me.btnTogglePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTogglePassword.FlatAppearance.BorderSize = 0
        Me.btnTogglePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTogglePassword.Location = New System.Drawing.Point(380, 300)
        Me.btnTogglePassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTogglePassword.Name = "btnTogglePassword"
        Me.btnTogglePassword.Size = New System.Drawing.Size(42, 35)
        Me.btnTogglePassword.TabIndex = 51
        Me.btnTogglePassword.UseVisualStyleBackColor = True
        '
        'lblphone
        '
        Me.lblphone.AutoSize = True
        Me.lblphone.BackColor = System.Drawing.Color.Transparent
        Me.lblphone.Font = New System.Drawing.Font("Times New Roman", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblphone.ForeColor = System.Drawing.Color.Gray
        Me.lblphone.Location = New System.Drawing.Point(59, 161)
        Me.lblphone.Name = "lblphone"
        Me.lblphone.Size = New System.Drawing.Size(70, 19)
        Me.lblphone.TabIndex = 49
        Me.lblphone.Text = "Phone no"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(59, 287)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 19)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Password"
        '
        'txtboxpassword
        '
        Me.txtboxpassword.Font = New System.Drawing.Font("Trebuchet MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtboxpassword.Location = New System.Drawing.Point(50, 300)
        Me.txtboxpassword.Name = "txtboxpassword"
        Me.txtboxpassword.Size = New System.Drawing.Size(333, 35)
        Me.txtboxpassword.TabIndex = 52
        '
        'rtxtboxphoneno
        '
        Me.rtxtboxphoneno.BackColor = System.Drawing.Color.White
        Me.rtxtboxphoneno.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Bold)
        Me.rtxtboxphoneno.Location = New System.Drawing.Point(51, 173)
        Me.rtxtboxphoneno.Name = "rtxtboxphoneno"
        Me.rtxtboxphoneno.Size = New System.Drawing.Size(371, 35)
        Me.rtxtboxphoneno.TabIndex = 48
        Me.rtxtboxphoneno.Text = ""
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubtitle.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitle.ForeColor = System.Drawing.Color.Gray
        Me.lblSubtitle.Location = New System.Drawing.Point(978, 40)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(202, 23)
        Me.lblSubtitle.TabIndex = 61
        Me.lblSubtitle.Text = "Welcome to CMS Family"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1304, 760)
        Me.Controls.Add(Me.lblSubtitle)
        Me.Controls.Add(Me.gboxregister)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbltitle)
        Me.Location = New System.Drawing.Point(900, 600)
        Me.Name = "Register"
        Me.Text = "Sign Up Page"
        Me.gboxregister.ResumeLayout(False)
        Me.gboxregister.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblfootermsg As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents rtxtboxemail As RichTextBox
    Friend WithEvents lbltitle As Label
    Friend WithEvents lblemail As Label
    Friend WithEvents rtxtboxfirstname As RichTextBox
    Friend WithEvents rtxtboxlastname As RichTextBox
    Friend WithEvents lbllastname As Label
    Friend WithEvents lblfirstname As Label
    Friend WithEvents radiobtnmale As RadioButton
    Friend WithEvents radiobtnothers As RadioButton
    Friend WithEvents radiobtnfemale As RadioButton
    Friend WithEvents lblsex As Label
    Friend WithEvents rtxtboxage As RichTextBox
    Friend WithEvents lblage As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents gboxregister As GroupBox
    Friend WithEvents lblphone As Label
    Friend WithEvents rtxtboxphoneno As RichTextBox
    Friend WithEvents btnTogglecPassword As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtboxconfirmpassword As TextBox
    Friend WithEvents btnTogglePassword As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtboxpassword As TextBox
    Friend WithEvents lblLength As Label
    Friend WithEvents lblUppercase As Label
    Friend WithEvents lblLowercase As Label
    Friend WithEvents lblNumber As Label
    Friend WithEvents lblSpecialChar As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents btnSignIn As RoundedButton
    Friend WithEvents btncancel As RoundedButton
End Class
