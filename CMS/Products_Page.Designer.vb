<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Products_Page
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
        Me.pnlManageProducts = New System.Windows.Forms.Panel()
        Me.rbtnAddProduct = New CMS.RoundedButton()
        Me.rbtnUpdateProduct = New CMS.RoundedButton()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnRefresh = New CMS.RoundedButton()
        Me.pnlProductsArea = New System.Windows.Forms.Panel()
        Me.dgvProductDetails = New System.Windows.Forms.DataGridView()
        Me.ctxMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Available = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotAvailable = New System.Windows.Forms.ToolStripMenuItem()
        Me.rtxtSearch = New System.Windows.Forms.RichTextBox()
        Me.pnlManageProducts.SuspendLayout()
        Me.pnlProductsArea.SuspendLayout()
        CType(Me.dgvProductDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctxMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlManageProducts
        '
        Me.pnlManageProducts.BackColor = System.Drawing.Color.White
        Me.pnlManageProducts.Controls.Add(Me.rbtnAddProduct)
        Me.pnlManageProducts.Controls.Add(Me.rbtnUpdateProduct)
        Me.pnlManageProducts.Controls.Add(Me.lblTitle)
        Me.pnlManageProducts.Controls.Add(Me.btnSearch)
        Me.pnlManageProducts.Controls.Add(Me.btnRefresh)
        Me.pnlManageProducts.Controls.Add(Me.pnlProductsArea)
        Me.pnlManageProducts.Controls.Add(Me.rtxtSearch)
        Me.pnlManageProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlManageProducts.Location = New System.Drawing.Point(0, 0)
        Me.pnlManageProducts.Name = "pnlManageProducts"
        Me.pnlManageProducts.Size = New System.Drawing.Size(1593, 728)
        Me.pnlManageProducts.TabIndex = 3
        '
        'rbtnAddProduct
        '
        Me.rbtnAddProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.rbtnAddProduct.CornerRadius = 35
        Me.rbtnAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rbtnAddProduct.FlatAppearance.BorderSize = 10
        Me.rbtnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtnAddProduct.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnAddProduct.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.rbtnAddProduct.Location = New System.Drawing.Point(26, 26)
        Me.rbtnAddProduct.Name = "rbtnAddProduct"
        Me.rbtnAddProduct.Size = New System.Drawing.Size(92, 41)
        Me.rbtnAddProduct.TabIndex = 12
        Me.rbtnAddProduct.Text = "Add"
        Me.rbtnAddProduct.UseVisualStyleBackColor = False
        '
        'rbtnUpdateProduct
        '
        Me.rbtnUpdateProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.rbtnUpdateProduct.CornerRadius = 35
        Me.rbtnUpdateProduct.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rbtnUpdateProduct.FlatAppearance.BorderSize = 10
        Me.rbtnUpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtnUpdateProduct.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnUpdateProduct.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.rbtnUpdateProduct.Location = New System.Drawing.Point(176, 26)
        Me.rbtnUpdateProduct.Name = "rbtnUpdateProduct"
        Me.rbtnUpdateProduct.Size = New System.Drawing.Size(92, 41)
        Me.rbtnUpdateProduct.TabIndex = 11
        Me.rbtnUpdateProduct.Text = "Update"
        Me.rbtnUpdateProduct.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Monotype Corsiva", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(518, 7)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(30, 0, 3, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(351, 60)
        Me.lblTitle.TabIndex = 10
        Me.lblTitle.Text = "Manage Products"
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.BackgroundImage = Global.CMS.My.Resources.Resources.SearchImage
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.Location = New System.Drawing.Point(1529, 24)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(46, 41)
        Me.btnSearch.TabIndex = 9
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnRefresh.CornerRadius = 35
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRefresh.FlatAppearance.BorderSize = 10
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnRefresh.Location = New System.Drawing.Point(962, 24)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(92, 41)
        Me.btnRefresh.TabIndex = 7
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'pnlProductsArea
        '
        Me.pnlProductsArea.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlProductsArea.Controls.Add(Me.dgvProductDetails)
        Me.pnlProductsArea.Location = New System.Drawing.Point(0, 102)
        Me.pnlProductsArea.Name = "pnlProductsArea"
        Me.pnlProductsArea.Size = New System.Drawing.Size(1593, 626)
        Me.pnlProductsArea.TabIndex = 7
        '
        'dgvProductDetails
        '
        Me.dgvProductDetails.BackgroundColor = System.Drawing.Color.White
        Me.dgvProductDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductDetails.ContextMenuStrip = Me.ctxMenu
        Me.dgvProductDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProductDetails.Location = New System.Drawing.Point(0, 0)
        Me.dgvProductDetails.Name = "dgvProductDetails"
        Me.dgvProductDetails.RowHeadersWidth = 51
        Me.dgvProductDetails.RowTemplate.Height = 24
        Me.dgvProductDetails.Size = New System.Drawing.Size(1593, 626)
        Me.dgvProductDetails.TabIndex = 0
        '
        'ctxMenu
        '
        Me.ctxMenu.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctxMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ctxMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Available, Me.NotAvailable})
        Me.ctxMenu.Name = "ctxMenuUserType"
        Me.ctxMenu.Size = New System.Drawing.Size(194, 52)
        '
        'Available
        '
        Me.Available.Name = "Available"
        Me.Available.Size = New System.Drawing.Size(193, 24)
        Me.Available.Text = "Make Available"
        '
        'NotAvailable
        '
        Me.NotAvailable.Name = "NotAvailable"
        Me.NotAvailable.Size = New System.Drawing.Size(193, 24)
        Me.NotAvailable.Text = "Make Unavailable"
        '
        'rtxtSearch
        '
        Me.rtxtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtxtSearch.BackColor = System.Drawing.Color.White
        Me.rtxtSearch.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtSearch.Location = New System.Drawing.Point(1113, 25)
        Me.rtxtSearch.Name = "rtxtSearch"
        Me.rtxtSearch.Size = New System.Drawing.Size(462, 40)
        Me.rtxtSearch.TabIndex = 8
        Me.rtxtSearch.Text = ""
        '
        'Products_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1593, 728)
        Me.Controls.Add(Me.pnlManageProducts)
        Me.Name = "Products_Page"
        Me.Text = "Products"
        Me.pnlManageProducts.ResumeLayout(False)
        Me.pnlManageProducts.PerformLayout()
        Me.pnlProductsArea.ResumeLayout(False)
        CType(Me.dgvProductDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctxMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlManageProducts As Panel
    Friend WithEvents rbtnAddProduct As RoundedButton
    Friend WithEvents rbtnUpdateProduct As RoundedButton
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnRefresh As RoundedButton
    Friend WithEvents pnlProductsArea As Panel
    Friend WithEvents dgvProductDetails As DataGridView
    Friend WithEvents ctxMenu As ContextMenuStrip
    Friend WithEvents Available As ToolStripMenuItem
    Friend WithEvents NotAvailable As ToolStripMenuItem
    Friend WithEvents rtxtSearch As RichTextBox
End Class
