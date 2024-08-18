<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdateUser
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
        Me.pnlUpdateDetails = New System.Windows.Forms.Panel()
        Me.lblphone = New System.Windows.Forms.Label()
        Me.btncancel = New CanteenManagementSystem.RoundedButton()
        Me.lblage = New System.Windows.Forms.Label()
        Me.rtxtboxage = New System.Windows.Forms.RichTextBox()
        Me.lblsex = New System.Windows.Forms.Label()
        Me.radiobtnfemale = New System.Windows.Forms.RadioButton()
        Me.radiobtnothers = New System.Windows.Forms.RadioButton()
        Me.radiobtnmale = New System.Windows.Forms.RadioButton()
        Me.lblfirstname = New System.Windows.Forms.Label()
        Me.lbllastname = New System.Windows.Forms.Label()
        Me.rtxtboxlastname = New System.Windows.Forms.RichTextBox()
        Me.rtxtboxfirstname = New System.Windows.Forms.RichTextBox()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.btnUpdate = New CanteenManagementSystem.RoundedButton()
        Me.rtxtboxemail = New System.Windows.Forms.RichTextBox()
        Me.rtxtboxphoneno = New System.Windows.Forms.RichTextBox()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.rtxtSearch = New System.Windows.Forms.RichTextBox()
        Me.rbtnUserID = New System.Windows.Forms.RadioButton()
        Me.rbtnUserEmail = New System.Windows.Forms.RadioButton()
        Me.pnlUpdateDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlUpdateDetails
        '
        Me.pnlUpdateDetails.BackColor = System.Drawing.Color.White
        Me.pnlUpdateDetails.Controls.Add(Me.lblphone)
        Me.pnlUpdateDetails.Controls.Add(Me.btncancel)
        Me.pnlUpdateDetails.Controls.Add(Me.lblage)
        Me.pnlUpdateDetails.Controls.Add(Me.rtxtboxage)
        Me.pnlUpdateDetails.Controls.Add(Me.lblsex)
        Me.pnlUpdateDetails.Controls.Add(Me.radiobtnfemale)
        Me.pnlUpdateDetails.Controls.Add(Me.radiobtnothers)
        Me.pnlUpdateDetails.Controls.Add(Me.radiobtnmale)
        Me.pnlUpdateDetails.Controls.Add(Me.lblfirstname)
        Me.pnlUpdateDetails.Controls.Add(Me.lbllastname)
        Me.pnlUpdateDetails.Controls.Add(Me.rtxtboxlastname)
        Me.pnlUpdateDetails.Controls.Add(Me.rtxtboxfirstname)
        Me.pnlUpdateDetails.Controls.Add(Me.lblemail)
        Me.pnlUpdateDetails.Controls.Add(Me.btnUpdate)
        Me.pnlUpdateDetails.Controls.Add(Me.rtxtboxemail)
        Me.pnlUpdateDetails.Controls.Add(Me.rtxtboxphoneno)
        Me.pnlUpdateDetails.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlUpdateDetails.Location = New System.Drawing.Point(12, 119)
        Me.pnlUpdateDetails.Name = "pnlUpdateDetails"
        Me.pnlUpdateDetails.Size = New System.Drawing.Size(869, 523)
        Me.pnlUpdateDetails.TabIndex = 0
        '
        'lblphone
        '
        Me.lblphone.AutoSize = True
        Me.lblphone.BackColor = System.Drawing.Color.Transparent
        Me.lblphone.Font = New System.Drawing.Font("Trebuchet MS", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblphone.ForeColor = System.Drawing.Color.Gray
        Me.lblphone.Location = New System.Drawing.Point(488, 161)
        Me.lblphone.Name = "lblphone"
        Me.lblphone.Size = New System.Drawing.Size(89, 23)
        Me.lblphone.TabIndex = 76
        Me.lblphone.Text = "Phone no"
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.White
        Me.btncancel.CornerRadius = 40
        Me.btncancel.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btncancel.FlatAppearance.BorderSize = 8
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Trebuchet MS", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btncancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btncancel.Location = New System.Drawing.Point(480, 466)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(141, 47)
        Me.btncancel.TabIndex = 63
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'lblage
        '
        Me.lblage.AutoSize = True
        Me.lblage.BackColor = System.Drawing.Color.Transparent
        Me.lblage.Font = New System.Drawing.Font("Trebuchet MS", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblage.ForeColor = System.Drawing.Color.Gray
        Me.lblage.Location = New System.Drawing.Point(489, 276)
        Me.lblage.Name = "lblage"
        Me.lblage.Size = New System.Drawing.Size(40, 23)
        Me.lblage.TabIndex = 73
        Me.lblage.Text = "Age"
        '
        'rtxtboxage
        '
        Me.rtxtboxage.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rtxtboxage.Location = New System.Drawing.Point(480, 293)
        Me.rtxtboxage.Name = "rtxtboxage"
        Me.rtxtboxage.Size = New System.Drawing.Size(357, 40)
        Me.rtxtboxage.TabIndex = 72
        Me.rtxtboxage.Text = ""
        '
        'lblsex
        '
        Me.lblsex.AutoSize = True
        Me.lblsex.BackColor = System.Drawing.Color.Transparent
        Me.lblsex.Font = New System.Drawing.Font("Trebuchet MS", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblsex.ForeColor = System.Drawing.Color.Gray
        Me.lblsex.Location = New System.Drawing.Point(33, 270)
        Me.lblsex.Name = "lblsex"
        Me.lblsex.Size = New System.Drawing.Size(39, 23)
        Me.lblsex.TabIndex = 71
        Me.lblsex.Text = "Sex"
        '
        'radiobtnfemale
        '
        Me.radiobtnfemale.AutoSize = True
        Me.radiobtnfemale.Font = New System.Drawing.Font("Trebuchet MS", 10.5!, System.Drawing.FontStyle.Bold)
        Me.radiobtnfemale.Location = New System.Drawing.Point(92, 306)
        Me.radiobtnfemale.Name = "radiobtnfemale"
        Me.radiobtnfemale.Size = New System.Drawing.Size(42, 27)
        Me.radiobtnfemale.TabIndex = 70
        Me.radiobtnfemale.TabStop = True
        Me.radiobtnfemale.Text = "F"
        Me.radiobtnfemale.UseVisualStyleBackColor = True
        '
        'radiobtnothers
        '
        Me.radiobtnothers.AutoSize = True
        Me.radiobtnothers.Font = New System.Drawing.Font("Trebuchet MS", 10.5!, System.Drawing.FontStyle.Bold)
        Me.radiobtnothers.Location = New System.Drawing.Point(144, 306)
        Me.radiobtnothers.Name = "radiobtnothers"
        Me.radiobtnothers.Size = New System.Drawing.Size(88, 27)
        Me.radiobtnothers.TabIndex = 69
        Me.radiobtnothers.TabStop = True
        Me.radiobtnothers.Text = "Others"
        Me.radiobtnothers.UseVisualStyleBackColor = True
        '
        'radiobtnmale
        '
        Me.radiobtnmale.AutoSize = True
        Me.radiobtnmale.Font = New System.Drawing.Font("Trebuchet MS", 10.5!, System.Drawing.FontStyle.Bold)
        Me.radiobtnmale.Location = New System.Drawing.Point(36, 306)
        Me.radiobtnmale.Name = "radiobtnmale"
        Me.radiobtnmale.Size = New System.Drawing.Size(44, 27)
        Me.radiobtnmale.TabIndex = 68
        Me.radiobtnmale.TabStop = True
        Me.radiobtnmale.Text = "M"
        Me.radiobtnmale.UseVisualStyleBackColor = True
        '
        'lblfirstname
        '
        Me.lblfirstname.AutoSize = True
        Me.lblfirstname.BackColor = System.Drawing.Color.Transparent
        Me.lblfirstname.Font = New System.Drawing.Font("Trebuchet MS", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblfirstname.ForeColor = System.Drawing.Color.Gray
        Me.lblfirstname.Location = New System.Drawing.Point(33, 47)
        Me.lblfirstname.Name = "lblfirstname"
        Me.lblfirstname.Size = New System.Drawing.Size(101, 23)
        Me.lblfirstname.TabIndex = 67
        Me.lblfirstname.Text = "First Name"
        '
        'lbllastname
        '
        Me.lbllastname.AutoSize = True
        Me.lbllastname.BackColor = System.Drawing.Color.Transparent
        Me.lbllastname.Font = New System.Drawing.Font("Trebuchet MS", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lbllastname.ForeColor = System.Drawing.Color.Gray
        Me.lbllastname.Location = New System.Drawing.Point(31, 161)
        Me.lbllastname.Name = "lbllastname"
        Me.lbllastname.Size = New System.Drawing.Size(97, 23)
        Me.lbllastname.TabIndex = 66
        Me.lbllastname.Text = "Last Name"
        '
        'rtxtboxlastname
        '
        Me.rtxtboxlastname.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rtxtboxlastname.Location = New System.Drawing.Point(25, 177)
        Me.rtxtboxlastname.Name = "rtxtboxlastname"
        Me.rtxtboxlastname.Size = New System.Drawing.Size(357, 40)
        Me.rtxtboxlastname.TabIndex = 65
        Me.rtxtboxlastname.Text = ""
        '
        'rtxtboxfirstname
        '
        Me.rtxtboxfirstname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtxtboxfirstname.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rtxtboxfirstname.Location = New System.Drawing.Point(25, 65)
        Me.rtxtboxfirstname.Name = "rtxtboxfirstname"
        Me.rtxtboxfirstname.Size = New System.Drawing.Size(357, 40)
        Me.rtxtboxfirstname.TabIndex = 61
        Me.rtxtboxfirstname.Text = ""
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.BackColor = System.Drawing.Color.Transparent
        Me.lblemail.Font = New System.Drawing.Font("Trebuchet MS", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblemail.ForeColor = System.Drawing.Color.Gray
        Me.lblemail.Location = New System.Drawing.Point(489, 47)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(55, 23)
        Me.lblemail.TabIndex = 64
        Me.lblemail.Text = "Email"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnUpdate.CornerRadius = 35
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnUpdate.FlatAppearance.BorderSize = 8
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Trebuchet MS", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(276, 466)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(141, 47)
        Me.btnUpdate.TabIndex = 63
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'rtxtboxemail
        '
        Me.rtxtboxemail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtxtboxemail.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rtxtboxemail.Location = New System.Drawing.Point(481, 64)
        Me.rtxtboxemail.Name = "rtxtboxemail"
        Me.rtxtboxemail.Size = New System.Drawing.Size(357, 40)
        Me.rtxtboxemail.TabIndex = 62
        Me.rtxtboxemail.Text = ""
        '
        'rtxtboxphoneno
        '
        Me.rtxtboxphoneno.BackColor = System.Drawing.Color.White
        Me.rtxtboxphoneno.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rtxtboxphoneno.Location = New System.Drawing.Point(480, 179)
        Me.rtxtboxphoneno.Name = "rtxtboxphoneno"
        Me.rtxtboxphoneno.Size = New System.Drawing.Size(357, 40)
        Me.rtxtboxphoneno.TabIndex = 75
        Me.rtxtboxphoneno.Text = ""
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.Transparent
        Me.lbltitle.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lbltitle.Location = New System.Drawing.Point(12, 24)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(343, 49)
        Me.lbltitle.TabIndex = 15
        Me.lbltitle.Text = "Update User Details"
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.BackgroundImage = Global.CMS.My.Resources.Resources.SearchImage
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.Location = New System.Drawing.Point(828, 24)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(52, 44)
        Me.btnSearch.TabIndex = 17
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'rtxtSearch
        '
        Me.rtxtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtxtSearch.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtSearch.Location = New System.Drawing.Point(415, 24)
        Me.rtxtSearch.Name = "rtxtSearch"
        Me.rtxtSearch.Size = New System.Drawing.Size(465, 44)
        Me.rtxtSearch.TabIndex = 16
        Me.rtxtSearch.Text = ""
        '
        'rbtnUserID
        '
        Me.rbtnUserID.AutoSize = True
        Me.rbtnUserID.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnUserID.Location = New System.Drawing.Point(442, 79)
        Me.rbtnUserID.Name = "rbtnUserID"
        Me.rbtnUserID.Size = New System.Drawing.Size(71, 22)
        Me.rbtnUserID.TabIndex = 18
        Me.rbtnUserID.TabStop = True
        Me.rbtnUserID.Text = "User ID"
        Me.rbtnUserID.UseVisualStyleBackColor = True
        '
        'rbtnUserEmail
        '
        Me.rbtnUserEmail.AutoSize = True
        Me.rbtnUserEmail.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnUserEmail.Location = New System.Drawing.Point(549, 79)
        Me.rbtnUserEmail.Name = "rbtnUserEmail"
        Me.rbtnUserEmail.Size = New System.Drawing.Size(92, 22)
        Me.rbtnUserEmail.TabIndex = 19
        Me.rbtnUserEmail.TabStop = True
        Me.rbtnUserEmail.Text = "User Email"
        Me.rbtnUserEmail.UseVisualStyleBackColor = True
        '
        'UpdateUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(892, 653)
        Me.Controls.Add(Me.rbtnUserEmail)
        Me.Controls.Add(Me.rbtnUserID)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.rtxtSearch)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.pnlUpdateDetails)
        Me.Name = "UpdateUser"
        Me.Text = "UpdateCustomer"
        Me.pnlUpdateDetails.ResumeLayout(False)
        Me.pnlUpdateDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlUpdateDetails As Panel
    Friend WithEvents lblphone As Label
    Friend WithEvents btncancel As CanteenManagementSystem.RoundedButton
    Friend WithEvents lblage As Label
    Friend WithEvents rtxtboxage As RichTextBox
    Friend WithEvents lblsex As Label
    Friend WithEvents radiobtnfemale As RadioButton
    Friend WithEvents radiobtnothers As RadioButton
    Friend WithEvents radiobtnmale As RadioButton
    Friend WithEvents lblfirstname As Label
    Friend WithEvents lbllastname As Label
    Friend WithEvents rtxtboxlastname As RichTextBox
    Friend WithEvents rtxtboxfirstname As RichTextBox
    Friend WithEvents lblemail As Label
    Friend WithEvents btnUpdate As CanteenManagementSystem.RoundedButton
    Friend WithEvents rtxtboxemail As RichTextBox
    Friend WithEvents rtxtboxphoneno As RichTextBox
    Friend WithEvents lbltitle As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents rtxtSearch As RichTextBox
    Friend WithEvents rbtnUserID As RadioButton
    Friend WithEvents rbtnUserEmail As RadioButton
End Class
