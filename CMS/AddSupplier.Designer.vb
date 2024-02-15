<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddSupplier
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
        Me.pnlAddSupplier = New System.Windows.Forms.Panel()
        Me.lblContactPhone = New System.Windows.Forms.Label()
        Me.btncancel = New CanteenManagementSystem.RoundedButton()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.rbtnNotWorking = New System.Windows.Forms.RadioButton()
        Me.rbtnWorking = New System.Windows.Forms.RadioButton()
        Me.lblSupplierName = New System.Windows.Forms.Label()
        Me.lblContactName = New System.Windows.Forms.Label()
        Me.rtxtboxContactName = New System.Windows.Forms.RichTextBox()
        Me.rtxtboxSupplierName = New System.Windows.Forms.RichTextBox()
        Me.lblContactEmail = New System.Windows.Forms.Label()
        Me.btnAdd = New CanteenManagementSystem.RoundedButton()
        Me.rtxtboxContactEmail = New System.Windows.Forms.RichTextBox()
        Me.rtxtboxContactPhoneno = New System.Windows.Forms.RichTextBox()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.pnlAddSupplier.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlAddSupplier
        '
        Me.pnlAddSupplier.BackColor = System.Drawing.Color.White
        Me.pnlAddSupplier.Controls.Add(Me.lblContactPhone)
        Me.pnlAddSupplier.Controls.Add(Me.btncancel)
        Me.pnlAddSupplier.Controls.Add(Me.lblStatus)
        Me.pnlAddSupplier.Controls.Add(Me.rbtnNotWorking)
        Me.pnlAddSupplier.Controls.Add(Me.rbtnWorking)
        Me.pnlAddSupplier.Controls.Add(Me.lblSupplierName)
        Me.pnlAddSupplier.Controls.Add(Me.lblContactName)
        Me.pnlAddSupplier.Controls.Add(Me.rtxtboxContactName)
        Me.pnlAddSupplier.Controls.Add(Me.rtxtboxSupplierName)
        Me.pnlAddSupplier.Controls.Add(Me.lblContactEmail)
        Me.pnlAddSupplier.Controls.Add(Me.btnAdd)
        Me.pnlAddSupplier.Controls.Add(Me.rtxtboxContactEmail)
        Me.pnlAddSupplier.Controls.Add(Me.rtxtboxContactPhoneno)
        Me.pnlAddSupplier.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlAddSupplier.Location = New System.Drawing.Point(11, 118)
        Me.pnlAddSupplier.Name = "pnlAddSupplier"
        Me.pnlAddSupplier.Size = New System.Drawing.Size(869, 441)
        Me.pnlAddSupplier.TabIndex = 1
        '
        'lblContactPhone
        '
        Me.lblContactPhone.AutoSize = True
        Me.lblContactPhone.BackColor = System.Drawing.Color.Transparent
        Me.lblContactPhone.Font = New System.Drawing.Font("Trebuchet MS", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblContactPhone.ForeColor = System.Drawing.Color.Gray
        Me.lblContactPhone.Location = New System.Drawing.Point(486, 148)
        Me.lblContactPhone.Name = "lblContactPhone"
        Me.lblContactPhone.Size = New System.Drawing.Size(89, 23)
        Me.lblContactPhone.TabIndex = 76
        Me.lblContactPhone.Text = "Phone no"
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
        Me.btncancel.Location = New System.Drawing.Point(465, 356)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(141, 47)
        Me.btncancel.TabIndex = 63
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Trebuchet MS", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblStatus.ForeColor = System.Drawing.Color.Gray
        Me.lblStatus.Location = New System.Drawing.Point(274, 233)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(62, 23)
        Me.lblStatus.TabIndex = 71
        Me.lblStatus.Text = "Status"
        '
        'rbtnNotWorking
        '
        Me.rbtnNotWorking.AutoSize = True
        Me.rbtnNotWorking.Font = New System.Drawing.Font("Trebuchet MS", 10.5!, System.Drawing.FontStyle.Bold)
        Me.rbtnNotWorking.Location = New System.Drawing.Point(424, 269)
        Me.rbtnNotWorking.Name = "rbtnNotWorking"
        Me.rbtnNotWorking.Size = New System.Drawing.Size(159, 27)
        Me.rbtnNotWorking.TabIndex = 70
        Me.rbtnNotWorking.TabStop = True
        Me.rbtnNotWorking.Text = "Not Working(0)"
        Me.rbtnNotWorking.UseVisualStyleBackColor = True
        '
        'rbtnWorking
        '
        Me.rbtnWorking.AutoSize = True
        Me.rbtnWorking.Font = New System.Drawing.Font("Trebuchet MS", 10.5!, System.Drawing.FontStyle.Bold)
        Me.rbtnWorking.Location = New System.Drawing.Point(277, 269)
        Me.rbtnWorking.Name = "rbtnWorking"
        Me.rbtnWorking.Size = New System.Drawing.Size(125, 27)
        Me.rbtnWorking.TabIndex = 68
        Me.rbtnWorking.TabStop = True
        Me.rbtnWorking.Text = "Working(1)"
        Me.rbtnWorking.UseVisualStyleBackColor = True
        '
        'lblSupplierName
        '
        Me.lblSupplierName.AutoSize = True
        Me.lblSupplierName.BackColor = System.Drawing.Color.Transparent
        Me.lblSupplierName.Font = New System.Drawing.Font("Trebuchet MS", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblSupplierName.ForeColor = System.Drawing.Color.Gray
        Me.lblSupplierName.Location = New System.Drawing.Point(32, 31)
        Me.lblSupplierName.Name = "lblSupplierName"
        Me.lblSupplierName.Size = New System.Drawing.Size(130, 23)
        Me.lblSupplierName.TabIndex = 67
        Me.lblSupplierName.Text = "Supplier Name"
        '
        'lblContactName
        '
        Me.lblContactName.AutoSize = True
        Me.lblContactName.BackColor = System.Drawing.Color.Transparent
        Me.lblContactName.Font = New System.Drawing.Font("Trebuchet MS", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblContactName.ForeColor = System.Drawing.Color.Gray
        Me.lblContactName.Location = New System.Drawing.Point(30, 148)
        Me.lblContactName.Name = "lblContactName"
        Me.lblContactName.Size = New System.Drawing.Size(127, 23)
        Me.lblContactName.TabIndex = 66
        Me.lblContactName.Text = "Contact Name"
        '
        'rtxtboxContactName
        '
        Me.rtxtboxContactName.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rtxtboxContactName.Location = New System.Drawing.Point(24, 164)
        Me.rtxtboxContactName.Name = "rtxtboxContactName"
        Me.rtxtboxContactName.Size = New System.Drawing.Size(357, 40)
        Me.rtxtboxContactName.TabIndex = 65
        Me.rtxtboxContactName.Text = ""
        '
        'rtxtboxSupplierName
        '
        Me.rtxtboxSupplierName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtxtboxSupplierName.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rtxtboxSupplierName.Location = New System.Drawing.Point(24, 49)
        Me.rtxtboxSupplierName.Name = "rtxtboxSupplierName"
        Me.rtxtboxSupplierName.Size = New System.Drawing.Size(357, 40)
        Me.rtxtboxSupplierName.TabIndex = 61
        Me.rtxtboxSupplierName.Text = ""
        '
        'lblContactEmail
        '
        Me.lblContactEmail.AutoSize = True
        Me.lblContactEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblContactEmail.Font = New System.Drawing.Font("Trebuchet MS", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblContactEmail.ForeColor = System.Drawing.Color.Gray
        Me.lblContactEmail.Location = New System.Drawing.Point(488, 31)
        Me.lblContactEmail.Name = "lblContactEmail"
        Me.lblContactEmail.Size = New System.Drawing.Size(55, 23)
        Me.lblContactEmail.TabIndex = 64
        Me.lblContactEmail.Text = "Email"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnAdd.CornerRadius = 35
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAdd.FlatAppearance.BorderSize = 8
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Trebuchet MS", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(261, 356)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(141, 47)
        Me.btnAdd.TabIndex = 63
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'rtxtboxContactEmail
        '
        Me.rtxtboxContactEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtxtboxContactEmail.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rtxtboxContactEmail.Location = New System.Drawing.Point(480, 48)
        Me.rtxtboxContactEmail.Name = "rtxtboxContactEmail"
        Me.rtxtboxContactEmail.Size = New System.Drawing.Size(357, 40)
        Me.rtxtboxContactEmail.TabIndex = 62
        Me.rtxtboxContactEmail.Text = ""
        '
        'rtxtboxContactPhoneno
        '
        Me.rtxtboxContactPhoneno.BackColor = System.Drawing.Color.White
        Me.rtxtboxContactPhoneno.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rtxtboxContactPhoneno.Location = New System.Drawing.Point(478, 166)
        Me.rtxtboxContactPhoneno.Name = "rtxtboxContactPhoneno"
        Me.rtxtboxContactPhoneno.Size = New System.Drawing.Size(357, 40)
        Me.rtxtboxContactPhoneno.TabIndex = 75
        Me.rtxtboxContactPhoneno.Text = ""
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.Transparent
        Me.lbltitle.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lbltitle.Location = New System.Drawing.Point(279, 23)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(318, 49)
        Me.lbltitle.TabIndex = 16
        Me.lbltitle.Text = "Add New Suppliers"
        '
        'AddSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(892, 574)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.pnlAddSupplier)
        Me.Name = "AddSupplier"
        Me.Text = "Add Supplier"
        Me.pnlAddSupplier.ResumeLayout(False)
        Me.pnlAddSupplier.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlAddSupplier As Panel
    Friend WithEvents lblContactPhone As Label
    Friend WithEvents btncancel As CanteenManagementSystem.RoundedButton
    Friend WithEvents lblStatus As Label
    Friend WithEvents rbtnNotWorking As RadioButton
    Friend WithEvents rbtnWorking As RadioButton
    Friend WithEvents lblSupplierName As Label
    Friend WithEvents lblContactName As Label
    Friend WithEvents rtxtboxContactName As RichTextBox
    Friend WithEvents rtxtboxSupplierName As RichTextBox
    Friend WithEvents lblContactEmail As Label
    Friend WithEvents btnAdd As CanteenManagementSystem.RoundedButton
    Friend WithEvents rtxtboxContactEmail As RichTextBox
    Friend WithEvents rtxtboxContactPhoneno As RichTextBox
    Friend WithEvents lbltitle As Label
End Class
