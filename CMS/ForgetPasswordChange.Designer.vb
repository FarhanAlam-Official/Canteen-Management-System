<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ForgetPasswordChange
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.lblsubtitle = New System.Windows.Forms.Label()
        Me.btnUpdate = New CanteenManagementSystem.RoundedButton()
        Me.lblUppercase = New System.Windows.Forms.Label()
        Me.lblLowercase = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblSpecialChar = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.btntogglecpassword = New System.Windows.Forms.Button()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.txtboxconfirmpassword = New System.Windows.Forms.TextBox()
        Me.btntogglepassword = New System.Windows.Forms.Button()
        Me.lblNewPassword = New System.Windows.Forms.Label()
        Me.txtboxpassword = New System.Windows.Forms.TextBox()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.White
        Me.pnlMain.Controls.Add(Me.lblsubtitle)
        Me.pnlMain.Controls.Add(Me.btnUpdate)
        Me.pnlMain.Controls.Add(Me.lblUppercase)
        Me.pnlMain.Controls.Add(Me.lblLowercase)
        Me.pnlMain.Controls.Add(Me.lblNumber)
        Me.pnlMain.Controls.Add(Me.lblSpecialChar)
        Me.pnlMain.Controls.Add(Me.lblLength)
        Me.pnlMain.Controls.Add(Me.btntogglecpassword)
        Me.pnlMain.Controls.Add(Me.lblConfirmPassword)
        Me.pnlMain.Controls.Add(Me.txtboxconfirmpassword)
        Me.pnlMain.Controls.Add(Me.btntogglepassword)
        Me.pnlMain.Controls.Add(Me.lblNewPassword)
        Me.pnlMain.Controls.Add(Me.txtboxpassword)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(494, 519)
        Me.pnlMain.TabIndex = 1
        '
        'lblsubtitle
        '
        Me.lblsubtitle.AutoSize = True
        Me.lblsubtitle.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblsubtitle.Location = New System.Drawing.Point(85, 12)
        Me.lblsubtitle.Name = "lblsubtitle"
        Me.lblsubtitle.Size = New System.Drawing.Size(290, 52)
        Me.lblsubtitle.TabIndex = 86
        Me.lblsubtitle.Text = "Enter a new Password below " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   to change your Password"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnUpdate.CornerRadius = 40
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnUpdate.FlatAppearance.BorderSize = 10
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Trebuchet MS", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(30, 445)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(415, 55)
        Me.btnUpdate.TabIndex = 85
        Me.btnUpdate.Text = "Update Password"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'lblUppercase
        '
        Me.lblUppercase.AutoSize = True
        Me.lblUppercase.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUppercase.ForeColor = System.Drawing.Color.Red
        Me.lblUppercase.Location = New System.Drawing.Point(38, 303)
        Me.lblUppercase.Name = "lblUppercase"
        Me.lblUppercase.Size = New System.Drawing.Size(234, 23)
        Me.lblUppercase.TabIndex = 84
        Me.lblUppercase.Text = "At least one uppercase letter"
        '
        'lblLowercase
        '
        Me.lblLowercase.AutoSize = True
        Me.lblLowercase.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLowercase.ForeColor = System.Drawing.Color.Red
        Me.lblLowercase.Location = New System.Drawing.Point(38, 333)
        Me.lblLowercase.Name = "lblLowercase"
        Me.lblLowercase.Size = New System.Drawing.Size(234, 23)
        Me.lblLowercase.TabIndex = 83
        Me.lblLowercase.Text = "At least one lowercase letter"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.ForeColor = System.Drawing.Color.Red
        Me.lblNumber.Location = New System.Drawing.Point(39, 363)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(165, 23)
        Me.lblNumber.TabIndex = 82
        Me.lblNumber.Text = "At least one number"
        '
        'lblSpecialChar
        '
        Me.lblSpecialChar.AutoSize = True
        Me.lblSpecialChar.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpecialChar.ForeColor = System.Drawing.Color.Red
        Me.lblSpecialChar.Location = New System.Drawing.Point(39, 392)
        Me.lblSpecialChar.Name = "lblSpecialChar"
        Me.lblSpecialChar.Size = New System.Drawing.Size(315, 23)
        Me.lblSpecialChar.TabIndex = 81
        Me.lblSpecialChar.Text = "At least one special character (@#$!%*?&)"
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength.ForeColor = System.Drawing.Color.Red
        Me.lblLength.Location = New System.Drawing.Point(38, 272)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(264, 23)
        Me.lblLength.TabIndex = 80
        Me.lblLength.Text = "Password length: 8-16 characters"
        '
        'btntogglecpassword
        '
        Me.btntogglecpassword.BackgroundImage = Global.CMS.My.Resources.Resources.Eye_Close
        Me.btntogglecpassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btntogglecpassword.Location = New System.Drawing.Point(418, 204)
        Me.btntogglecpassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btntogglecpassword.Name = "btntogglecpassword"
        Me.btntogglecpassword.Size = New System.Drawing.Size(42, 31)
        Me.btntogglecpassword.TabIndex = 78
        Me.btntogglecpassword.UseVisualStyleBackColor = True
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblConfirmPassword.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPassword.ForeColor = System.Drawing.Color.Gray
        Me.lblConfirmPassword.Location = New System.Drawing.Point(38, 187)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(151, 23)
        Me.lblConfirmPassword.TabIndex = 77
        Me.lblConfirmPassword.Text = "Confirm Password"
        '
        'txtboxconfirmpassword
        '
        Me.txtboxconfirmpassword.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtboxconfirmpassword.Location = New System.Drawing.Point(29, 204)
        Me.txtboxconfirmpassword.Name = "txtboxconfirmpassword"
        Me.txtboxconfirmpassword.Size = New System.Drawing.Size(391, 31)
        Me.txtboxconfirmpassword.TabIndex = 79
        '
        'btntogglepassword
        '
        Me.btntogglepassword.BackgroundImage = Global.CMS.My.Resources.Resources.Eye_Close
        Me.btntogglepassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btntogglepassword.Location = New System.Drawing.Point(418, 119)
        Me.btntogglepassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btntogglepassword.Name = "btntogglepassword"
        Me.btntogglepassword.Size = New System.Drawing.Size(42, 31)
        Me.btntogglepassword.TabIndex = 75
        Me.btntogglepassword.UseVisualStyleBackColor = True
        '
        'lblNewPassword
        '
        Me.lblNewPassword.AutoSize = True
        Me.lblNewPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblNewPassword.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPassword.ForeColor = System.Drawing.Color.Gray
        Me.lblNewPassword.Location = New System.Drawing.Point(39, 101)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(123, 23)
        Me.lblNewPassword.TabIndex = 74
        Me.lblNewPassword.Text = "New Password"
        '
        'txtboxpassword
        '
        Me.txtboxpassword.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxpassword.Location = New System.Drawing.Point(30, 119)
        Me.txtboxpassword.Name = "txtboxpassword"
        Me.txtboxpassword.Size = New System.Drawing.Size(391, 31)
        Me.txtboxpassword.TabIndex = 76
        '
        'ForgetPasswordChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "ForgetPasswordChange"
        Me.Size = New System.Drawing.Size(494, 519)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents lblUppercase As Label
    Friend WithEvents lblLowercase As Label
    Friend WithEvents lblNumber As Label
    Friend WithEvents lblSpecialChar As Label
    Friend WithEvents lblLength As Label
    Friend WithEvents btntogglecpassword As Button
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents txtboxconfirmpassword As TextBox
    Friend WithEvents btntogglepassword As Button
    Friend WithEvents lblNewPassword As Label
    Friend WithEvents txtboxpassword As TextBox
    Friend WithEvents btnUpdate As CanteenManagementSystem.RoundedButton
    Friend WithEvents lblsubtitle As Label
End Class
