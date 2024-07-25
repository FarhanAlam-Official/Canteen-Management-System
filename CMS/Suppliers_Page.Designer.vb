<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Suppliers_Page
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
        Me.pnlManageSupplier = New System.Windows.Forms.Panel()
        Me.rbtnAddSupplier = New CMS.RoundedButton()
        Me.rbtnUpdateSupplier = New CMS.RoundedButton()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnRefresh = New CMS.RoundedButton()
        Me.pnlProductsArea = New System.Windows.Forms.Panel()
        Me.ctxMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Working = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotWorking = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvSupplierDetails = New System.Windows.Forms.DataGridView()
        Me.rtxtSearch = New System.Windows.Forms.RichTextBox()
        Me.pnlManageSupplier.SuspendLayout()
        Me.pnlProductsArea.SuspendLayout()
        Me.ctxMenu.SuspendLayout()
        CType(Me.dgvSupplierDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlManageSupplier
        '
        Me.pnlManageSupplier.BackColor = System.Drawing.Color.White
        Me.pnlManageSupplier.Controls.Add(Me.rbtnAddSupplier)
        Me.pnlManageSupplier.Controls.Add(Me.rbtnUpdateSupplier)
        Me.pnlManageSupplier.Controls.Add(Me.lblTitle)
        Me.pnlManageSupplier.Controls.Add(Me.btnSearch)
        Me.pnlManageSupplier.Controls.Add(Me.btnRefresh)
        Me.pnlManageSupplier.Controls.Add(Me.pnlProductsArea)
        Me.pnlManageSupplier.Controls.Add(Me.rtxtSearch)
        Me.pnlManageSupplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlManageSupplier.Location = New System.Drawing.Point(0, 0)
        Me.pnlManageSupplier.Name = "pnlManageSupplier"
        Me.pnlManageSupplier.Size = New System.Drawing.Size(1593, 728)
        Me.pnlManageSupplier.TabIndex = 4
        '
        'rbtnAddSupplier
        '
        Me.rbtnAddSupplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.rbtnAddSupplier.CornerRadius = 35
        Me.rbtnAddSupplier.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rbtnAddSupplier.FlatAppearance.BorderSize = 10
        Me.rbtnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtnAddSupplier.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnAddSupplier.ForeColor = System.Drawing.Color.White
        Me.rbtnAddSupplier.Location = New System.Drawing.Point(26, 26)
        Me.rbtnAddSupplier.Name = "rbtnAddSupplier"
        Me.rbtnAddSupplier.Size = New System.Drawing.Size(92, 41)
        Me.rbtnAddSupplier.TabIndex = 12
        Me.rbtnAddSupplier.Text = "Add"
        Me.rbtnAddSupplier.UseVisualStyleBackColor = False
        '
        'rbtnUpdateSupplier
        '
        Me.rbtnUpdateSupplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.rbtnUpdateSupplier.CornerRadius = 35
        Me.rbtnUpdateSupplier.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rbtnUpdateSupplier.FlatAppearance.BorderSize = 10
        Me.rbtnUpdateSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtnUpdateSupplier.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnUpdateSupplier.ForeColor = System.Drawing.Color.White
        Me.rbtnUpdateSupplier.Location = New System.Drawing.Point(176, 26)
        Me.rbtnUpdateSupplier.Name = "rbtnUpdateSupplier"
        Me.rbtnUpdateSupplier.Size = New System.Drawing.Size(92, 41)
        Me.rbtnUpdateSupplier.TabIndex = 11
        Me.rbtnUpdateSupplier.Text = "Update"
        Me.rbtnUpdateSupplier.UseVisualStyleBackColor = False
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
        Me.lblTitle.Size = New System.Drawing.Size(358, 60)
        Me.lblTitle.TabIndex = 10
        Me.lblTitle.Text = "Manage Suppliers" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        Me.btnRefresh.Font = New System.Drawing.Font("Trebuchet MS", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
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
        Me.pnlProductsArea.ContextMenuStrip = Me.ctxMenu
        Me.pnlProductsArea.Controls.Add(Me.dgvSupplierDetails)
        Me.pnlProductsArea.Location = New System.Drawing.Point(0, 92)
        Me.pnlProductsArea.Name = "pnlProductsArea"
        Me.pnlProductsArea.Size = New System.Drawing.Size(1593, 636)
        Me.pnlProductsArea.TabIndex = 7
        '
        'ctxMenu
        '
        Me.ctxMenu.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctxMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ctxMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Working, Me.NotWorking})
        Me.ctxMenu.Name = "ctxMenuUserType"
        Me.ctxMenu.Size = New System.Drawing.Size(162, 52)
        '
        'Working
        '
        Me.Working.Name = "Working"
        Me.Working.Size = New System.Drawing.Size(161, 24)
        Me.Working.Text = "Working"
        '
        'NotWorking
        '
        Me.NotWorking.Name = "NotWorking"
        Me.NotWorking.Size = New System.Drawing.Size(161, 24)
        Me.NotWorking.Text = "Not Working"
        '
        'dgvSupplierDetails
        '
        Me.dgvSupplierDetails.BackgroundColor = System.Drawing.Color.White
        Me.dgvSupplierDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSupplierDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSupplierDetails.Location = New System.Drawing.Point(0, 0)
        Me.dgvSupplierDetails.Name = "dgvSupplierDetails"
        Me.dgvSupplierDetails.RowHeadersWidth = 51
        Me.dgvSupplierDetails.RowTemplate.Height = 24
        Me.dgvSupplierDetails.Size = New System.Drawing.Size(1593, 636)
        Me.dgvSupplierDetails.TabIndex = 0
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
        'Suppliers_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1593, 728)
        Me.Controls.Add(Me.pnlManageSupplier)
        Me.Name = "Suppliers_Page"
        Me.Text = "Suppliers"
        Me.pnlManageSupplier.ResumeLayout(False)
        Me.pnlManageSupplier.PerformLayout()
        Me.pnlProductsArea.ResumeLayout(False)
        Me.ctxMenu.ResumeLayout(False)
        CType(Me.dgvSupplierDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlManageSupplier As Panel
    Friend WithEvents rbtnAddSupplier As RoundedButton
    Friend WithEvents rbtnUpdateSupplier As RoundedButton
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnRefresh As RoundedButton
    Friend WithEvents pnlProductsArea As Panel
    Friend WithEvents ctxMenu As ContextMenuStrip
    Friend WithEvents Working As ToolStripMenuItem
    Friend WithEvents NotWorking As ToolStripMenuItem
    Friend WithEvents dgvSupplierDetails As DataGridView
    Friend WithEvents rtxtSearch As RichTextBox
End Class
