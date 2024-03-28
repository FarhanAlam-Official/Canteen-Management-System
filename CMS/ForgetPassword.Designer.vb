<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgetPassword
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.lblEmailmsg = New System.Windows.Forms.Label()
        Me.btnSubmitOTP = New CanteenManagementSystem.RoundedButton()
        Me.btnSendOTP = New CanteenManagementSystem.RoundedButton()
        Me.lblOTP = New System.Windows.Forms.Label()
        Me.rtxtboxOTP = New System.Windows.Forms.RichTextBox()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.rtxtboxemail = New System.Windows.Forms.RichTextBox()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.notifyOTP = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMain.BackColor = System.Drawing.Color.White
        Me.pnlMain.Controls.Add(Me.lblEmailmsg)
        Me.pnlMain.Controls.Add(Me.btnSubmitOTP)
        Me.pnlMain.Controls.Add(Me.btnSendOTP)
        Me.pnlMain.Controls.Add(Me.lblOTP)
        Me.pnlMain.Controls.Add(Me.rtxtboxOTP)
        Me.pnlMain.Controls.Add(Me.lblemail)
        Me.pnlMain.Controls.Add(Me.rtxtboxemail)
        Me.pnlMain.Location = New System.Drawing.Point(22, 105)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(494, 519)
        Me.pnlMain.TabIndex = 0
        '
        'lblEmailmsg
        '
        Me.lblEmailmsg.AutoSize = True
        Me.lblEmailmsg.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailmsg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblEmailmsg.Location = New System.Drawing.Point(90, 56)
        Me.lblEmailmsg.Name = "lblEmailmsg"
        Me.lblEmailmsg.Size = New System.Drawing.Size(291, 26)
        Me.lblEmailmsg.TabIndex = 67
        Me.lblEmailmsg.Text = "Enter your Email to Send OTP"
        '
        'btnSubmitOTP
        '
        Me.btnSubmitOTP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubmitOTP.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnSubmitOTP.CornerRadius = 40
        Me.btnSubmitOTP.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSubmitOTP.FlatAppearance.BorderSize = 8
        Me.btnSubmitOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmitOTP.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitOTP.ForeColor = System.Drawing.Color.White
        Me.btnSubmitOTP.Location = New System.Drawing.Point(72, 378)
        Me.btnSubmitOTP.Name = "btnSubmitOTP"
        Me.btnSubmitOTP.Size = New System.Drawing.Size(322, 48)
        Me.btnSubmitOTP.TabIndex = 66
        Me.btnSubmitOTP.Text = "Submit OTP"
        Me.btnSubmitOTP.UseVisualStyleBackColor = False
        Me.btnSubmitOTP.Visible = False
        '
        'btnSendOTP
        '
        Me.btnSendOTP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSendOTP.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnSendOTP.CornerRadius = 40
        Me.btnSendOTP.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSendOTP.FlatAppearance.BorderSize = 8
        Me.btnSendOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSendOTP.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendOTP.ForeColor = System.Drawing.Color.White
        Me.btnSendOTP.Location = New System.Drawing.Point(72, 305)
        Me.btnSendOTP.Name = "btnSendOTP"
        Me.btnSendOTP.Size = New System.Drawing.Size(322, 48)
        Me.btnSendOTP.TabIndex = 65
        Me.btnSendOTP.Text = "Send OTP"
        Me.btnSendOTP.UseVisualStyleBackColor = False
        '
        'lblOTP
        '
        Me.lblOTP.AutoSize = True
        Me.lblOTP.BackColor = System.Drawing.Color.Transparent
        Me.lblOTP.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOTP.ForeColor = System.Drawing.Color.Gray
        Me.lblOTP.Location = New System.Drawing.Point(39, 196)
        Me.lblOTP.Name = "lblOTP"
        Me.lblOTP.Size = New System.Drawing.Size(45, 23)
        Me.lblOTP.TabIndex = 64
        Me.lblOTP.Text = "OTP"
        Me.lblOTP.Visible = False
        '
        'rtxtboxOTP
        '
        Me.rtxtboxOTP.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtboxOTP.Location = New System.Drawing.Point(31, 214)
        Me.rtxtboxOTP.Name = "rtxtboxOTP"
        Me.rtxtboxOTP.Size = New System.Drawing.Size(415, 48)
        Me.rtxtboxOTP.TabIndex = 63
        Me.rtxtboxOTP.Text = ""
        Me.rtxtboxOTP.Visible = False
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.BackColor = System.Drawing.Color.Transparent
        Me.lblemail.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.ForeColor = System.Drawing.Color.Gray
        Me.lblemail.Location = New System.Drawing.Point(39, 118)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(55, 23)
        Me.lblemail.TabIndex = 62
        Me.lblemail.Text = "Email"
        '
        'rtxtboxemail
        '
        Me.rtxtboxemail.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtboxemail.Location = New System.Drawing.Point(31, 135)
        Me.rtxtboxemail.Name = "rtxtboxemail"
        Me.rtxtboxemail.Size = New System.Drawing.Size(415, 48)
        Me.rtxtboxemail.TabIndex = 61
        Me.rtxtboxemail.Text = ""
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lbltitle.Location = New System.Drawing.Point(87, 24)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(329, 38)
        Me.lbltitle.TabIndex = 8
        Me.lbltitle.Text = "Change Your Password"
        '
        'notifyOTP
        '
        Me.notifyOTP.Text = "NotifyIcon1"
        Me.notifyOTP.Visible = True
        '
        'ForgetPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 636)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "ForgetPassword"
        Me.Text = "Forget  Password"
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents lblemail As Label
    Friend WithEvents rtxtboxemail As RichTextBox
    Friend WithEvents lbltitle As Label
    Friend WithEvents lblOTP As Label
    Friend WithEvents rtxtboxOTP As RichTextBox
    Friend WithEvents btnSendOTP As CanteenManagementSystem.RoundedButton
    Friend WithEvents notifyOTP As NotifyIcon
    Friend WithEvents btnSubmitOTP As CanteenManagementSystem.RoundedButton
    Friend WithEvents lblEmailmsg As Label
End Class
