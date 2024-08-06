<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdateMenuitems
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
        Me.rtxtSearch = New System.Windows.Forms.RichTextBox()
        Me.btncancel = New CanteenManagementSystem.RoundedButton()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.rbtnNotAvailable = New System.Windows.Forms.RadioButton()
        Me.rbtnAvailable = New System.Windows.Forms.RadioButton()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.rbtnMenuitemsName = New System.Windows.Forms.RadioButton()
        Me.rbtnMenuitemsID = New System.Windows.Forms.RadioButton()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.btnUpdate = New CanteenManagementSystem.RoundedButton()
        Me.pnlUpdateMenuitems = New System.Windows.Forms.Panel()
        Me.ModernClockControl = New CMS.ModernClockControl()
        Me.rtxtboxProductName = New System.Windows.Forms.RichTextBox()
        Me.picboxProduct = New System.Windows.Forms.PictureBox()
        Me.lblAvailableTo = New System.Windows.Forms.Label()
        Me.dtpAvailableTo = New System.Windows.Forms.DateTimePicker()
        Me.lblAvailableFrom = New System.Windows.Forms.Label()
        Me.dtpAvailableFrom = New System.Windows.Forms.DateTimePicker()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.pnlUpdateMenuitems.SuspendLayout()
        CType(Me.picboxProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rtxtSearch
        '
        Me.rtxtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtxtSearch.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtSearch.Location = New System.Drawing.Point(477, 27)
        Me.rtxtSearch.Name = "rtxtSearch"
        Me.rtxtSearch.Size = New System.Drawing.Size(403, 44)
        Me.rtxtSearch.TabIndex = 26
        Me.rtxtSearch.Text = ""
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
        Me.btncancel.Location = New System.Drawing.Point(462, 379)
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
        Me.lblStatus.Location = New System.Drawing.Point(32, 264)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(62, 23)
        Me.lblStatus.TabIndex = 71
        Me.lblStatus.Text = "Status"
        '
        'rbtnNotAvailable
        '
        Me.rbtnNotAvailable.AutoSize = True
        Me.rbtnNotAvailable.Font = New System.Drawing.Font("Trebuchet MS", 10.5!, System.Drawing.FontStyle.Bold)
        Me.rbtnNotAvailable.Location = New System.Drawing.Point(182, 300)
        Me.rbtnNotAvailable.Name = "rbtnNotAvailable"
        Me.rbtnNotAvailable.Size = New System.Drawing.Size(165, 27)
        Me.rbtnNotAvailable.TabIndex = 70
        Me.rbtnNotAvailable.TabStop = True
        Me.rbtnNotAvailable.Text = "Not Available(0)"
        Me.rbtnNotAvailable.UseVisualStyleBackColor = True
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
        'rbtnMenuitemsName
        '
        Me.rbtnMenuitemsName.AutoSize = True
        Me.rbtnMenuitemsName.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnMenuitemsName.Location = New System.Drawing.Point(668, 77)
        Me.rbtnMenuitemsName.Name = "rbtnMenuitemsName"
        Me.rbtnMenuitemsName.Size = New System.Drawing.Size(93, 22)
        Me.rbtnMenuitemsName.TabIndex = 29
        Me.rbtnMenuitemsName.TabStop = True
        Me.rbtnMenuitemsName.Text = "Item Name"
        Me.rbtnMenuitemsName.UseVisualStyleBackColor = True
        '
        'rbtnMenuitemsID
        '
        Me.rbtnMenuitemsID.AutoSize = True
        Me.rbtnMenuitemsID.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnMenuitemsID.Location = New System.Drawing.Point(546, 77)
        Me.rbtnMenuitemsID.Name = "rbtnMenuitemsID"
        Me.rbtnMenuitemsID.Size = New System.Drawing.Size(103, 22)
        Me.rbtnMenuitemsID.TabIndex = 28
        Me.rbtnMenuitemsID.TabStop = True
        Me.rbtnMenuitemsID.Text = "Menuitem ID"
        Me.rbtnMenuitemsID.UseVisualStyleBackColor = True
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.Transparent
        Me.lbltitle.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lbltitle.Location = New System.Drawing.Point(12, 22)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(331, 49)
        Me.lbltitle.TabIndex = 25
        Me.lbltitle.Text = "Update Menu Items"
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
        Me.btnUpdate.Location = New System.Drawing.Point(258, 379)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(141, 47)
        Me.btnUpdate.TabIndex = 63
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'pnlUpdateMenuitems
        '
        Me.pnlUpdateMenuitems.BackColor = System.Drawing.Color.White
        Me.pnlUpdateMenuitems.Controls.Add(Me.ModernClockControl)
        Me.pnlUpdateMenuitems.Controls.Add(Me.lblProductName)
        Me.pnlUpdateMenuitems.Controls.Add(Me.rtxtboxProductName)
        Me.pnlUpdateMenuitems.Controls.Add(Me.picboxProduct)
        Me.pnlUpdateMenuitems.Controls.Add(Me.lblAvailableTo)
        Me.pnlUpdateMenuitems.Controls.Add(Me.dtpAvailableTo)
        Me.pnlUpdateMenuitems.Controls.Add(Me.lblAvailableFrom)
        Me.pnlUpdateMenuitems.Controls.Add(Me.dtpAvailableFrom)
        Me.pnlUpdateMenuitems.Controls.Add(Me.btncancel)
        Me.pnlUpdateMenuitems.Controls.Add(Me.lblStatus)
        Me.pnlUpdateMenuitems.Controls.Add(Me.rbtnNotAvailable)
        Me.pnlUpdateMenuitems.Controls.Add(Me.rbtnAvailable)
        Me.pnlUpdateMenuitems.Controls.Add(Me.btnUpdate)
        Me.pnlUpdateMenuitems.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlUpdateMenuitems.Location = New System.Drawing.Point(12, 112)
        Me.pnlUpdateMenuitems.Name = "pnlUpdateMenuitems"
        Me.pnlUpdateMenuitems.Size = New System.Drawing.Size(869, 441)
        Me.pnlUpdateMenuitems.TabIndex = 24
        '
        'ModernClockControl
        '
        Me.ModernClockControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModernClockControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ModernClockControl.Location = New System.Drawing.Point(506, 22)
        Me.ModernClockControl.Name = "ModernClockControl"
        Me.ModernClockControl.Size = New System.Drawing.Size(298, 327)
        Me.ModernClockControl.TabIndex = 84
        '
        'rtxtboxProductName
        '
        Me.rtxtboxProductName.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtboxProductName.Location = New System.Drawing.Point(25, 56)
        Me.rtxtboxProductName.Name = "rtxtboxProductName"
        Me.rtxtboxProductName.Size = New System.Drawing.Size(355, 37)
        Me.rtxtboxProductName.TabIndex = 83
        Me.rtxtboxProductName.Text = ""
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
        'btnSearch
        '
        Me.btnSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.BackgroundImage = Global.CMS.My.Resources.Resources.SearchImage
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.Location = New System.Drawing.Point(828, 27)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(52, 44)
        Me.btnSearch.TabIndex = 27
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'UpdateMenuitems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(892, 574)
        Me.Controls.Add(Me.rbtnMenuitemsName)
        Me.Controls.Add(Me.rbtnMenuitemsID)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.pnlUpdateMenuitems)
        Me.Controls.Add(Me.rtxtSearch)
        Me.Name = "UpdateMenuitems"
        Me.Text = "Update  Menuitems"
        Me.pnlUpdateMenuitems.ResumeLayout(False)
        Me.pnlUpdateMenuitems.PerformLayout()
        CType(Me.picboxProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rtxtSearch As RichTextBox
    Friend WithEvents btncancel As CanteenManagementSystem.RoundedButton
    Friend WithEvents lblStatus As Label
    Friend WithEvents rbtnNotAvailable As RadioButton
    Friend WithEvents rbtnAvailable As RadioButton
    Friend WithEvents lblProductName As Label
    Friend WithEvents rbtnMenuitemsName As RadioButton
    Friend WithEvents rbtnMenuitemsID As RadioButton
    Friend WithEvents lbltitle As Label
    Friend WithEvents btnUpdate As CanteenManagementSystem.RoundedButton
    Friend WithEvents btnSearch As Button
    Friend WithEvents pnlUpdateMenuitems As Panel
    Friend WithEvents dtpAvailableFrom As DateTimePicker
    Friend WithEvents lblAvailableTo As Label
    Friend WithEvents dtpAvailableTo As DateTimePicker
    Friend WithEvents lblAvailableFrom As Label
    Friend WithEvents picboxProduct As PictureBox
    Friend WithEvents rtxtboxProductName As RichTextBox
    Friend WithEvents ModernClockControl As ModernClockControl
End Class
