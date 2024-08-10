<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateProduct
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
        Me.pnlAddProduct = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBrowse = New CanteenManagementSystem.RoundedButton()
        Me.picboxProductImage = New System.Windows.Forms.PictureBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.btnCancel = New CanteenManagementSystem.RoundedButton()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.rbtnInactive = New System.Windows.Forms.RadioButton()
        Me.rbtnActive = New System.Windows.Forms.RadioButton()
        Me.lblProductname = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.rtxtboxPrice = New System.Windows.Forms.RichTextBox()
        Me.rtxtboxfirstname = New System.Windows.Forms.RichTextBox()
        Me.btnUpdate = New CanteenManagementSystem.RoundedButton()
        Me.rtxtboxDescription = New System.Windows.Forms.RichTextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.rtxtSearch = New System.Windows.Forms.RichTextBox()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.rbtnProductName = New System.Windows.Forms.RadioButton()
        Me.rbtnProductID = New System.Windows.Forms.RadioButton()
        Me.pnlAddProduct.SuspendLayout()
        CType(Me.picboxProductImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlAddProduct
        '
        Me.pnlAddProduct.BackColor = System.Drawing.Color.White
        Me.pnlAddProduct.Controls.Add(Me.Label1)
        Me.pnlAddProduct.Controls.Add(Me.btnBrowse)
        Me.pnlAddProduct.Controls.Add(Me.picboxProductImage)
        Me.pnlAddProduct.Controls.Add(Me.lblCategory)
        Me.pnlAddProduct.Controls.Add(Me.cmbCategory)
        Me.pnlAddProduct.Controls.Add(Me.lblDescription)
        Me.pnlAddProduct.Controls.Add(Me.btnCancel)
        Me.pnlAddProduct.Controls.Add(Me.lblStatus)
        Me.pnlAddProduct.Controls.Add(Me.rbtnInactive)
        Me.pnlAddProduct.Controls.Add(Me.rbtnActive)
        Me.pnlAddProduct.Controls.Add(Me.lblProductname)
        Me.pnlAddProduct.Controls.Add(Me.lblPrice)
        Me.pnlAddProduct.Controls.Add(Me.rtxtboxPrice)
        Me.pnlAddProduct.Controls.Add(Me.rtxtboxfirstname)
        Me.pnlAddProduct.Controls.Add(Me.btnUpdate)
        Me.pnlAddProduct.Controls.Add(Me.rtxtboxDescription)
        Me.pnlAddProduct.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlAddProduct.Location = New System.Drawing.Point(11, 118)
        Me.pnlAddProduct.Name = "pnlAddProduct"
        Me.pnlAddProduct.Size = New System.Drawing.Size(869, 523)
        Me.pnlAddProduct.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 10.5!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(607, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 23)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Image"
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnBrowse.CornerRadius = 35
        Me.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBrowse.FlatAppearance.BorderSize = 10
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Trebuchet MS", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.Location = New System.Drawing.Point(629, 254)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(141, 47)
        Me.btnBrowse.TabIndex = 80
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'picboxProductImage
        '
        Me.picboxProductImage.Location = New System.Drawing.Point(598, 48)
        Me.picboxProductImage.Name = "picboxProductImage"
        Me.picboxProductImage.Size = New System.Drawing.Size(213, 181)
        Me.picboxProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxProductImage.TabIndex = 79
        Me.picboxProductImage.TabStop = False
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.BackColor = System.Drawing.Color.Transparent
        Me.lblCategory.Font = New System.Drawing.Font("Trebuchet MS", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblCategory.ForeColor = System.Drawing.Color.Gray
        Me.lblCategory.Location = New System.Drawing.Point(32, 268)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(85, 23)
        Me.lblCategory.TabIndex = 78
        Me.lblCategory.Text = "Category"
        '
        'cmbCategory
        '
        Me.cmbCategory.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Items.AddRange(New Object() {"Beverages", "Snacks", "Main Course", "Desserts", "Sides"})
        Me.cmbCategory.Location = New System.Drawing.Point(24, 284)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(355, 34)
        Me.cmbCategory.TabIndex = 77
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblDescription.Font = New System.Drawing.Font("Trebuchet MS", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblDescription.ForeColor = System.Drawing.Color.Gray
        Me.lblDescription.Location = New System.Drawing.Point(31, 342)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(105, 23)
        Me.lblDescription.TabIndex = 76
        Me.lblDescription.Text = "Description"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.CornerRadius = 40
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCancel.FlatAppearance.BorderSize = 8
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Trebuchet MS", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(480, 466)
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
        Me.lblStatus.Location = New System.Drawing.Point(31, 179)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(62, 23)
        Me.lblStatus.TabIndex = 71
        Me.lblStatus.Text = "Status"
        '
        'rbtnInactive
        '
        Me.rbtnInactive.AutoSize = True
        Me.rbtnInactive.Font = New System.Drawing.Font("Trebuchet MS", 10.5!, System.Drawing.FontStyle.Bold)
        Me.rbtnInactive.Location = New System.Drawing.Point(153, 215)
        Me.rbtnInactive.Name = "rbtnInactive"
        Me.rbtnInactive.Size = New System.Drawing.Size(123, 27)
        Me.rbtnInactive.TabIndex = 70
        Me.rbtnInactive.TabStop = True
        Me.rbtnInactive.Text = "Inactive(0)"
        Me.rbtnInactive.UseVisualStyleBackColor = True
        '
        'rbtnActive
        '
        Me.rbtnActive.AutoSize = True
        Me.rbtnActive.Font = New System.Drawing.Font("Trebuchet MS", 10.5!, System.Drawing.FontStyle.Bold)
        Me.rbtnActive.Location = New System.Drawing.Point(34, 215)
        Me.rbtnActive.Name = "rbtnActive"
        Me.rbtnActive.Size = New System.Drawing.Size(113, 27)
        Me.rbtnActive.TabIndex = 68
        Me.rbtnActive.TabStop = True
        Me.rbtnActive.Text = "Active (1)"
        Me.rbtnActive.UseVisualStyleBackColor = True
        '
        'lblProductname
        '
        Me.lblProductname.AutoSize = True
        Me.lblProductname.BackColor = System.Drawing.Color.Transparent
        Me.lblProductname.Font = New System.Drawing.Font("Trebuchet MS", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblProductname.ForeColor = System.Drawing.Color.Gray
        Me.lblProductname.Location = New System.Drawing.Point(32, 18)
        Me.lblProductname.Name = "lblProductname"
        Me.lblProductname.Size = New System.Drawing.Size(128, 23)
        Me.lblProductname.TabIndex = 67
        Me.lblProductname.Text = "Product Name"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.Font = New System.Drawing.Font("Trebuchet MS", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblPrice.ForeColor = System.Drawing.Color.Gray
        Me.lblPrice.Location = New System.Drawing.Point(31, 100)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(53, 23)
        Me.lblPrice.TabIndex = 66
        Me.lblPrice.Text = "Price"
        '
        'rtxtboxPrice
        '
        Me.rtxtboxPrice.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rtxtboxPrice.Location = New System.Drawing.Point(25, 115)
        Me.rtxtboxPrice.Name = "rtxtboxPrice"
        Me.rtxtboxPrice.Size = New System.Drawing.Size(357, 41)
        Me.rtxtboxPrice.TabIndex = 65
        Me.rtxtboxPrice.Text = ""
        '
        'rtxtboxfirstname
        '
        Me.rtxtboxfirstname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtxtboxfirstname.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rtxtboxfirstname.Location = New System.Drawing.Point(24, 36)
        Me.rtxtboxfirstname.Name = "rtxtboxfirstname"
        Me.rtxtboxfirstname.Size = New System.Drawing.Size(357, 40)
        Me.rtxtboxfirstname.TabIndex = 61
        Me.rtxtboxfirstname.Text = ""
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
        'rtxtboxDescription
        '
        Me.rtxtboxDescription.BackColor = System.Drawing.Color.White
        Me.rtxtboxDescription.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rtxtboxDescription.Location = New System.Drawing.Point(23, 360)
        Me.rtxtboxDescription.Name = "rtxtboxDescription"
        Me.rtxtboxDescription.Size = New System.Drawing.Size(357, 81)
        Me.rtxtboxDescription.TabIndex = 75
        Me.rtxtboxDescription.Text = ""
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImage = Global.CMS.My.Resources.Resources.SearchImage
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.Location = New System.Drawing.Point(836, 28)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(44, 41)
        Me.btnSearch.TabIndex = 11
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'rtxtSearch
        '
        Me.rtxtSearch.BackColor = System.Drawing.Color.White
        Me.rtxtSearch.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtSearch.Location = New System.Drawing.Point(491, 29)
        Me.rtxtSearch.Name = "rtxtSearch"
        Me.rtxtSearch.Size = New System.Drawing.Size(389, 40)
        Me.rtxtSearch.TabIndex = 10
        Me.rtxtSearch.Text = ""
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.Transparent
        Me.lbltitle.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lbltitle.Location = New System.Drawing.Point(12, 20)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(390, 49)
        Me.lbltitle.TabIndex = 17
        Me.lbltitle.Text = "Update Product Details"
        '
        'rbtnProductName
        '
        Me.rbtnProductName.AutoSize = True
        Me.rbtnProductName.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnProductName.Location = New System.Drawing.Point(640, 75)
        Me.rbtnProductName.Name = "rbtnProductName"
        Me.rbtnProductName.Size = New System.Drawing.Size(110, 22)
        Me.rbtnProductName.TabIndex = 21
        Me.rbtnProductName.TabStop = True
        Me.rbtnProductName.Text = "Product Name"
        Me.rbtnProductName.UseVisualStyleBackColor = True
        '
        'rbtnProductID
        '
        Me.rbtnProductID.AutoSize = True
        Me.rbtnProductID.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnProductID.Location = New System.Drawing.Point(533, 75)
        Me.rbtnProductID.Name = "rbtnProductID"
        Me.rbtnProductID.Size = New System.Drawing.Size(89, 22)
        Me.rbtnProductID.TabIndex = 20
        Me.rbtnProductID.TabStop = True
        Me.rbtnProductID.Text = "Product ID"
        Me.rbtnProductID.UseVisualStyleBackColor = True
        '
        'UpdateProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(892, 653)
        Me.Controls.Add(Me.rbtnProductName)
        Me.Controls.Add(Me.rbtnProductID)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.rtxtSearch)
        Me.Controls.Add(Me.pnlAddProduct)
        Me.Name = "UpdateProduct"
        Me.pnlAddProduct.ResumeLayout(False)
        Me.pnlAddProduct.PerformLayout()
        CType(Me.picboxProductImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlAddProduct As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBrowse As CanteenManagementSystem.RoundedButton
    Friend WithEvents picboxProductImage As PictureBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents btnCancel As CanteenManagementSystem.RoundedButton
    Friend WithEvents lblStatus As Label
    Friend WithEvents rbtnInactive As RadioButton
    Friend WithEvents rbtnActive As RadioButton
    Friend WithEvents lblProductname As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents rtxtboxPrice As RichTextBox
    Friend WithEvents rtxtboxfirstname As RichTextBox
    Friend WithEvents btnUpdate As CanteenManagementSystem.RoundedButton
    Friend WithEvents rtxtboxDescription As RichTextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents rtxtSearch As RichTextBox
    Friend WithEvents lbltitle As Label
    Friend WithEvents rbtnProductName As RadioButton
    Friend WithEvents rbtnProductID As RadioButton
End Class
