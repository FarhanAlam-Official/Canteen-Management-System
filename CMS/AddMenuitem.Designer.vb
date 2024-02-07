<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMenuitem
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
        Me.lblAvailableTo = New System.Windows.Forms.Label()
        Me.dtpAvailableTo = New System.Windows.Forms.DateTimePicker()
        Me.lblAvailableFrom = New System.Windows.Forms.Label()
        Me.btnAdd = New CanteenManagementSystem.RoundedButton()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.pnlAddMenuitems = New System.Windows.Forms.Panel()
        Me.ModernClockControl = New CMS.ModernClockControl()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.picboxProduct = New System.Windows.Forms.PictureBox()
        Me.dtpAvailableFrom = New System.Windows.Forms.DateTimePicker()
        Me.btnCancel = New CanteenManagementSystem.RoundedButton()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.rbtnNotWorking = New System.Windows.Forms.RadioButton()
        Me.rbtnAvailable = New System.Windows.Forms.RadioButton()
        Me.cmbProducts = New System.Windows.Forms.ComboBox()
        Me.pnlAddMenuitems.SuspendLayout()
        CType(Me.picboxProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAvailableTo
        '
        Me.lblAvailableTo.AutoSize = True
        Me.lblAvailableTo.BackColor = System.Drawing.Color.Transparent
        Me.lblAvailableTo.Font = New System.Drawing.Font("Trebuchet MS", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblAvailableTo.ForeColor = System.Drawing.Color.Gray
        Me.lblAvailableTo.Location = New System.Drawing.Point(32, 192)
        Me.lblAvailableTo.Name = "lblAvailableTo"
        Me.lblAvailableTo.Size = New System.Drawing.Size(110, 23)
        Me.lblAvailableTo.TabIndex = 79
        Me.lblAvailableTo.Text = "Available To"
        '
        'dtpAvailableTo
        '
        Me.dtpAvailableTo.CustomFormat = "hh:mm tt"
        Me.dtpAvailableTo.Font = New System.Drawing.Font("Trebuchet MS", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAvailableTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAvailableTo.Location = New System.Drawing.Point(24, 210)
        Me.dtpAvailableTo.Name = "dtpAvailableTo"
        Me.dtpAvailableTo.Size = New System.Drawing.Size(357, 33)
        Me.dtpAvailableTo.TabIndex = 81
        '
        'lblAvailableFrom
        '
        Me.lblAvailableFrom.AutoSize = True
        Me.lblAvailableFrom.BackColor = System.Drawing.Color.Transparent
        Me.lblAvailableFrom.Font = New System.Drawing.Font("Trebuchet MS", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblAvailableFrom.ForeColor = System.Drawing.Color.Gray
        Me.lblAvailableFrom.Location = New System.Drawing.Point(32, 118)
        Me.lblAvailableFrom.Name = "lblAvailableFrom"
        Me.lblAvailableFrom.Size = New System.Drawing.Size(135, 23)
        Me.lblAvailableFrom.TabIndex = 80
        Me.lblAvailableFrom.Text = "Available From"
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
        Me.btnAdd.Location = New System.Drawing.Point(258, 379)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(141, 47)
        Me.btnAdd.TabIndex = 63
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.Transparent
        Me.lbltitle.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lbltitle.Location = New System.Drawing.Point(309, 22)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(279, 49)
        Me.lbltitle.TabIndex = 31
        Me.lbltitle.Text = "Add Menu Items"
        '
        'pnlAddMenuitems
        '
        Me.pnlAddMenuitems.BackColor = System.Drawing.Color.White
        Me.pnlAddMenuitems.Controls.Add(Me.ModernClockControl)
        Me.pnlAddMenuitems.Controls.Add(Me.lblProductName)
        Me.pnlAddMenuitems.Controls.Add(Me.picboxProduct)
        Me.pnlAddMenuitems.Controls.Add(Me.lblAvailableTo)
        Me.pnlAddMenuitems.Controls.Add(Me.dtpAvailableTo)
        Me.pnlAddMenuitems.Controls.Add(Me.lblAvailableFrom)
        Me.pnlAddMenuitems.Controls.Add(Me.dtpAvailableFrom)
        Me.pnlAddMenuitems.Controls.Add(Me.btnCancel)
        Me.pnlAddMenuitems.Controls.Add(Me.lblStatus)
        Me.pnlAddMenuitems.Controls.Add(Me.rbtnNotWorking)
        Me.pnlAddMenuitems.Controls.Add(Me.rbtnAvailable)
        Me.pnlAddMenuitems.Controls.Add(Me.btnAdd)
        Me.pnlAddMenuitems.Controls.Add(Me.cmbProducts)
        Me.pnlAddMenuitems.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlAddMenuitems.Location = New System.Drawing.Point(12, 112)
        Me.pnlAddMenuitems.Name = "pnlAddMenuitems"
        Me.pnlAddMenuitems.Size = New System.Drawing.Size(869, 441)
        Me.pnlAddMenuitems.TabIndex = 30
        '
        'ModernClockControl
        '
        Me.ModernClockControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModernClockControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ModernClockControl.Location = New System.Drawing.Point(534, 16)
        Me.ModernClockControl.Name = "ModernClockControl"
        Me.ModernClockControl.Size = New System.Drawing.Size(298, 327)
        Me.ModernClockControl.TabIndex = 85
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.BackColor = System.Drawing.Color.Transparent
        Me.lblProductName.Font = New System.Drawing.Font("Trebuchet MS", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblProductName.ForeColor = System.Drawing.Color.Gray
        Me.lblProductName.Location = New System.Drawing.Point(31, 39)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(128, 23)
        Me.lblProductName.TabIndex = 67
        Me.lblProductName.Text = "Product Name"
        '
        'picboxProduct
        '
        Me.picboxProduct.Location = New System.Drawing.Point(575, 70)
        Me.picboxProduct.Name = "picboxProduct"
        Me.picboxProduct.Size = New System.Drawing.Size(212, 173)
        Me.picboxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxProduct.TabIndex = 82
        Me.picboxProduct.TabStop = False
        '
        'dtpAvailableFrom
        '
        Me.dtpAvailableFrom.CustomFormat = "hh:mm tt"
        Me.dtpAvailableFrom.Font = New System.Drawing.Font("Trebuchet MS", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAvailableFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAvailableFrom.Location = New System.Drawing.Point(24, 134)
        Me.dtpAvailableFrom.Name = "dtpAvailableFrom"
        Me.dtpAvailableFrom.Size = New System.Drawing.Size(357, 33)
        Me.dtpAvailableFrom.TabIndex = 78
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.CornerRadius = 40
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCancel.FlatAppearance.BorderSize = 10
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Trebuchet MS", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(462, 379)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(141, 47)
        Me.btnCancel.TabIndex = 63
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Trebuchet MS", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblStatus.ForeColor = System.Drawing.Color.Gray
        Me.lblStatus.Location = New System.Drawing.Point(32, 264)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(62, 23)
        Me.lblStatus.TabIndex = 71
        Me.lblStatus.Text = "Status"
        '
        'rbtnNotWorking
        '
        Me.rbtnNotWorking.AutoSize = True
        Me.rbtnNotWorking.Font = New System.Drawing.Font("Trebuchet MS", 10.5!, System.Drawing.FontStyle.Bold)
        Me.rbtnNotWorking.Location = New System.Drawing.Point(182, 300)
        Me.rbtnNotWorking.Name = "rbtnNotWorking"
        Me.rbtnNotWorking.Size = New System.Drawing.Size(159, 27)
        Me.rbtnNotWorking.TabIndex = 70
        Me.rbtnNotWorking.TabStop = True
        Me.rbtnNotWorking.Text = "Not Working(0)"
        Me.rbtnNotWorking.UseVisualStyleBackColor = True
        '
        'rbtnAvailable
        '
        Me.rbtnAvailable.AutoSize = True
        Me.rbtnAvailable.Font = New System.Drawing.Font("Trebuchet MS", 10.5!, System.Drawing.FontStyle.Bold)
        Me.rbtnAvailable.Location = New System.Drawing.Point(35, 300)
        Me.rbtnAvailable.Name = "rbtnAvailable"
        Me.rbtnAvailable.Size = New System.Drawing.Size(132, 27)
        Me.rbtnAvailable.TabIndex = 68
        Me.rbtnAvailable.TabStop = True
        Me.rbtnAvailable.Text = "Available(1)"
        Me.rbtnAvailable.UseVisualStyleBackColor = True
        '
        'cmbProducts
        '
        Me.cmbProducts.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProducts.FormattingEnabled = True
        Me.cmbProducts.Location = New System.Drawing.Point(24, 56)
        Me.cmbProducts.Name = "cmbProducts"
        Me.cmbProducts.Size = New System.Drawing.Size(357, 34)
        Me.cmbProducts.TabIndex = 83
        '
        'AddMenuitem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(892, 574)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.pnlAddMenuitems)
        Me.Name = "AddMenuitem"
        Me.Text = "Add  Menuitem"
        Me.pnlAddMenuitems.ResumeLayout(False)
        Me.pnlAddMenuitems.PerformLayout()
        CType(Me.picboxProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picboxProduct As PictureBox
    Friend WithEvents lblAvailableTo As Label
    Friend WithEvents dtpAvailableTo As DateTimePicker
    Friend WithEvents lblAvailableFrom As Label
    Friend WithEvents btnAdd As CanteenManagementSystem.RoundedButton
    Friend WithEvents lbltitle As Label
    Friend WithEvents pnlAddMenuitems As Panel
    Friend WithEvents lblProductName As Label
    Friend WithEvents dtpAvailableFrom As DateTimePicker
    Friend WithEvents btnCancel As CanteenManagementSystem.RoundedButton
    Friend WithEvents lblStatus As Label
    Friend WithEvents rbtnNotWorking As RadioButton
    Friend WithEvents rbtnAvailable As RadioButton
    Friend WithEvents cmbProducts As ComboBox
    Friend WithEvents ModernClockControl As ModernClockControl
End Class
