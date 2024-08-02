<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateInventory
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
        Me.btnUpdate = New CanteenManagementSystem.RoundedButton()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.pnlUpdateInventoryItems = New System.Windows.Forms.Panel()
        Me.lblLastUpdated = New System.Windows.Forms.Label()
        Me.rtxtLastUpdated = New System.Windows.Forms.RichTextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.rtxtboxQuantity = New System.Windows.Forms.RichTextBox()
        Me.lblSuppliers = New System.Windows.Forms.Label()
        Me.cmbSuppliers = New System.Windows.Forms.ComboBox()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.picboxProduct = New System.Windows.Forms.PictureBox()
        Me.btncancel = New CanteenManagementSystem.RoundedButton()
        Me.cmbProducts = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.rtxtSearch = New System.Windows.Forms.RichTextBox()
        Me.pnlUpdateInventoryItems.SuspendLayout()
        CType(Me.picboxProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.Transparent
        Me.lbltitle.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lbltitle.Location = New System.Drawing.Point(3, 29)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(392, 49)
        Me.lbltitle.TabIndex = 33
        Me.lbltitle.Text = "Update Inventory Items"
        '
        'pnlUpdateInventoryItems
        '
        Me.pnlUpdateInventoryItems.BackColor = System.Drawing.Color.White
        Me.pnlUpdateInventoryItems.Controls.Add(Me.lblLastUpdated)
        Me.pnlUpdateInventoryItems.Controls.Add(Me.rtxtLastUpdated)
        Me.pnlUpdateInventoryItems.Controls.Add(Me.lblQuantity)
        Me.pnlUpdateInventoryItems.Controls.Add(Me.rtxtboxQuantity)
        Me.pnlUpdateInventoryItems.Controls.Add(Me.lblSuppliers)
        Me.pnlUpdateInventoryItems.Controls.Add(Me.cmbSuppliers)
        Me.pnlUpdateInventoryItems.Controls.Add(Me.lblProductName)
        Me.pnlUpdateInventoryItems.Controls.Add(Me.picboxProduct)
        Me.pnlUpdateInventoryItems.Controls.Add(Me.btncancel)
        Me.pnlUpdateInventoryItems.Controls.Add(Me.btnUpdate)
        Me.pnlUpdateInventoryItems.Controls.Add(Me.cmbProducts)
        Me.pnlUpdateInventoryItems.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlUpdateInventoryItems.Location = New System.Drawing.Point(12, 112)
        Me.pnlUpdateInventoryItems.Name = "pnlUpdateInventoryItems"
        Me.pnlUpdateInventoryItems.Size = New System.Drawing.Size(869, 441)
        Me.pnlUpdateInventoryItems.TabIndex = 32
        '
        'lblLastUpdated
        '
        Me.lblLastUpdated.AutoSize = True
        Me.lblLastUpdated.BackColor = System.Drawing.Color.Transparent
        Me.lblLastUpdated.Font = New System.Drawing.Font("Trebuchet MS", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblLastUpdated.ForeColor = System.Drawing.Color.Gray
        Me.lblLastUpdated.Location = New System.Drawing.Point(31, 273)
        Me.lblLastUpdated.Name = "lblLastUpdated"
        Me.lblLastUpdated.Size = New System.Drawing.Size(119, 23)
        Me.lblLastUpdated.TabIndex = 89
        Me.lblLastUpdated.Text = "Last Updated"
        '
        'rtxtLastUpdated
        '
        Me.rtxtLastUpdated.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rtxtLastUpdated.Location = New System.Drawing.Point(24, 288)
        Me.rtxtLastUpdated.Name = "rtxtLastUpdated"
        Me.rtxtLastUpdated.Size = New System.Drawing.Size(357, 36)
        Me.rtxtLastUpdated.TabIndex = 88
        Me.rtxtLastUpdated.Text = ""
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.BackColor = System.Drawing.Color.Transparent
        Me.lblQuantity.Font = New System.Drawing.Font("Trebuchet MS", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblQuantity.ForeColor = System.Drawing.Color.Gray
        Me.lblQuantity.Location = New System.Drawing.Point(31, 204)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(84, 23)
        Me.lblQuantity.TabIndex = 87
        Me.lblQuantity.Text = "Quantity"
        '
        'rtxtboxQuantity
        '
        Me.rtxtboxQuantity.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rtxtboxQuantity.Location = New System.Drawing.Point(24, 219)
        Me.rtxtboxQuantity.Name = "rtxtboxQuantity"
        Me.rtxtboxQuantity.Size = New System.Drawing.Size(357, 36)
        Me.rtxtboxQuantity.TabIndex = 86
        Me.rtxtboxQuantity.Text = ""
        '
        'lblSuppliers
        '
        Me.lblSuppliers.AutoSize = True
        Me.lblSuppliers.BackColor = System.Drawing.Color.Transparent
        Me.lblSuppliers.Font = New System.Drawing.Font("Trebuchet MS", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblSuppliers.ForeColor = System.Drawing.Color.Gray
        Me.lblSuppliers.Location = New System.Drawing.Point(31, 119)
        Me.lblSuppliers.Name = "lblSuppliers"
        Me.lblSuppliers.Size = New System.Drawing.Size(130, 23)
        Me.lblSuppliers.TabIndex = 84
        Me.lblSuppliers.Text = "Supplier Name"
        '
        'cmbSuppliers
        '
        Me.cmbSuppliers.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSuppliers.FormattingEnabled = True
        Me.cmbSuppliers.Location = New System.Drawing.Point(24, 136)
        Me.cmbSuppliers.Name = "cmbSuppliers"
        Me.cmbSuppliers.Size = New System.Drawing.Size(357, 34)
        Me.cmbSuppliers.TabIndex = 85
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
        'cmbProducts
        '
        Me.cmbProducts.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProducts.FormattingEnabled = True
        Me.cmbProducts.Location = New System.Drawing.Point(24, 56)
        Me.cmbProducts.Name = "cmbProducts"
        Me.cmbProducts.Size = New System.Drawing.Size(357, 34)
        Me.cmbProducts.TabIndex = 83
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.BackgroundImage = Global.CMS.My.Resources.Resources.SearchImage
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.Location = New System.Drawing.Point(838, 34)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(52, 44)
        Me.btnSearch.TabIndex = 35
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'rtxtSearch
        '
        Me.rtxtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtxtSearch.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtSearch.Location = New System.Drawing.Point(425, 34)
        Me.rtxtSearch.Name = "rtxtSearch"
        Me.rtxtSearch.Size = New System.Drawing.Size(465, 44)
        Me.rtxtSearch.TabIndex = 34
        Me.rtxtSearch.Text = ""
        '
        'UpdateInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(892, 574)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.rtxtSearch)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.pnlUpdateInventoryItems)
        Me.Name = "UpdateInventory"
        Me.Text = "Update Inventory  Items"
        Me.pnlUpdateInventoryItems.ResumeLayout(False)
        Me.pnlUpdateInventoryItems.PerformLayout()
        CType(Me.picboxProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUpdate As CanteenManagementSystem.RoundedButton
    Friend WithEvents lbltitle As Label
    Friend WithEvents pnlUpdateInventoryItems As Panel
    Friend WithEvents lblSuppliers As Label
    Friend WithEvents cmbSuppliers As ComboBox
    Friend WithEvents lblProductName As Label
    Friend WithEvents picboxProduct As PictureBox
    Friend WithEvents btncancel As CanteenManagementSystem.RoundedButton
    Friend WithEvents cmbProducts As ComboBox
    Friend WithEvents lblLastUpdated As Label
    Friend WithEvents rtxtLastUpdated As RichTextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents rtxtboxQuantity As RichTextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents rtxtSearch As RichTextBox
End Class
