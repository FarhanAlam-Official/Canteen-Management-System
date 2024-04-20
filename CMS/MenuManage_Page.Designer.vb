<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuManage_Page
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvMenuDetails = New System.Windows.Forms.DataGridView()
        Me.ctxMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.setAvailable = New System.Windows.Forms.ToolStripMenuItem()
        Me.setUnavailable = New System.Windows.Forms.ToolStripMenuItem()
        Me.removeMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.rbtnAddMenuitems = New CMS.RoundedButton()
        Me.rbtnUpdateMenuitems = New CMS.RoundedButton()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnRefresh = New CMS.RoundedButton()
        Me.pnlMenuArea = New System.Windows.Forms.Panel()
        Me.rtxtSearch = New System.Windows.Forms.RichTextBox()
        CType(Me.dgvMenuDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctxMenu.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        Me.pnlMenuArea.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvMenuDetails
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvMenuDetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMenuDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMenuDetails.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMenuDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMenuDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMenuDetails.ContextMenuStrip = Me.ctxMenu
        Me.dgvMenuDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMenuDetails.EnableHeadersVisualStyles = False
        Me.dgvMenuDetails.GridColor = System.Drawing.Color.Black
        Me.dgvMenuDetails.Location = New System.Drawing.Point(0, 0)
        Me.dgvMenuDetails.Name = "dgvMenuDetails"
        Me.dgvMenuDetails.ReadOnly = True
        Me.dgvMenuDetails.RowHeadersWidth = 51
        Me.dgvMenuDetails.RowTemplate.Height = 40
        Me.dgvMenuDetails.Size = New System.Drawing.Size(1587, 629)
        Me.dgvMenuDetails.TabIndex = 0
        '
        'ctxMenu
        '
        Me.ctxMenu.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctxMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ctxMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.setAvailable, Me.setUnavailable, Me.removeMenuItem})
        Me.ctxMenu.Name = "ctxMenuUserType"
        Me.ctxMenu.Size = New System.Drawing.Size(167, 76)
        '
        'setAvailable
        '
        Me.setAvailable.Name = "setAvailable"
        Me.setAvailable.Size = New System.Drawing.Size(166, 24)
        Me.setAvailable.Text = "Available"
        '
        'setUnavailable
        '
        Me.setUnavailable.Name = "setUnavailable"
        Me.setUnavailable.Size = New System.Drawing.Size(166, 24)
        Me.setUnavailable.Text = "Unavailable"
        '
        'removeMenuItem
        '
        Me.removeMenuItem.Name = "removeMenuItem"
        Me.removeMenuItem.Size = New System.Drawing.Size(166, 24)
        Me.removeMenuItem.Text = "Remove Item"
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.White
        Me.pnlMenu.Controls.Add(Me.rbtnAddMenuitems)
        Me.pnlMenu.Controls.Add(Me.rbtnUpdateMenuitems)
        Me.pnlMenu.Controls.Add(Me.lblTitle)
        Me.pnlMenu.Controls.Add(Me.btnSearch)
        Me.pnlMenu.Controls.Add(Me.btnRefresh)
        Me.pnlMenu.Controls.Add(Me.pnlMenuArea)
        Me.pnlMenu.Controls.Add(Me.rtxtSearch)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(1593, 728)
        Me.pnlMenu.TabIndex = 3
        '
        'rbtnAddMenuitems
        '
        Me.rbtnAddMenuitems.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.rbtnAddMenuitems.CornerRadius = 35
        Me.rbtnAddMenuitems.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rbtnAddMenuitems.FlatAppearance.BorderSize = 10
        Me.rbtnAddMenuitems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtnAddMenuitems.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnAddMenuitems.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.rbtnAddMenuitems.Location = New System.Drawing.Point(14, 22)
        Me.rbtnAddMenuitems.Name = "rbtnAddMenuitems"
        Me.rbtnAddMenuitems.Size = New System.Drawing.Size(92, 41)
        Me.rbtnAddMenuitems.TabIndex = 12
        Me.rbtnAddMenuitems.Text = "Add"
        Me.rbtnAddMenuitems.UseVisualStyleBackColor = False
        '
        'rbtnUpdateMenuitems
        '
        Me.rbtnUpdateMenuitems.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.rbtnUpdateMenuitems.CornerRadius = 35
        Me.rbtnUpdateMenuitems.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rbtnUpdateMenuitems.FlatAppearance.BorderSize = 8
        Me.rbtnUpdateMenuitems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtnUpdateMenuitems.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnUpdateMenuitems.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.rbtnUpdateMenuitems.Location = New System.Drawing.Point(161, 22)
        Me.rbtnUpdateMenuitems.Name = "rbtnUpdateMenuitems"
        Me.rbtnUpdateMenuitems.Size = New System.Drawing.Size(92, 41)
        Me.rbtnUpdateMenuitems.TabIndex = 11
        Me.rbtnUpdateMenuitems.Text = "Update"
        Me.rbtnUpdateMenuitems.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Monotype Corsiva", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(475, 7)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(30, 0, 3, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(412, 60)
        Me.lblTitle.TabIndex = 10
        Me.lblTitle.Text = "Manage Menu Items"
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.BackgroundImage = Global.CMS.My.Resources.Resources.SearchImage
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.Location = New System.Drawing.Point(1489, 24)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(46, 41)
        Me.btnSearch.TabIndex = 9
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnRefresh.CornerRadius = 35
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRefresh.FlatAppearance.BorderSize = 8
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnRefresh.Location = New System.Drawing.Point(922, 24)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(92, 41)
        Me.btnRefresh.TabIndex = 7
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'pnlMenuArea
        '
        Me.pnlMenuArea.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMenuArea.Controls.Add(Me.dgvMenuDetails)
        Me.pnlMenuArea.Location = New System.Drawing.Point(3, 96)
        Me.pnlMenuArea.Name = "pnlMenuArea"
        Me.pnlMenuArea.Size = New System.Drawing.Size(1587, 629)
        Me.pnlMenuArea.TabIndex = 7
        '
        'rtxtSearch
        '
        Me.rtxtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtxtSearch.Font = New System.Drawing.Font("Trebuchet MS", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtSearch.Location = New System.Drawing.Point(1073, 25)
        Me.rtxtSearch.Name = "rtxtSearch"
        Me.rtxtSearch.Size = New System.Drawing.Size(462, 40)
        Me.rtxtSearch.TabIndex = 8
        Me.rtxtSearch.Text = ""
        '
        'MenuManage_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1593, 728)
        Me.Controls.Add(Me.pnlMenu)
        Me.Name = "MenuManage_Page"
        Me.Text = "MenuManage"
        CType(Me.dgvMenuDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctxMenu.ResumeLayout(False)
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        Me.pnlMenuArea.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvMenuDetails As DataGridView
    Friend WithEvents ctxMenu As ContextMenuStrip
    Friend WithEvents setAvailable As ToolStripMenuItem
    Friend WithEvents setUnavailable As ToolStripMenuItem
    Friend WithEvents removeMenuItem As ToolStripMenuItem
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents rbtnAddMenuitems As RoundedButton
    Friend WithEvents rbtnUpdateMenuitems As RoundedButton
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnRefresh As RoundedButton
    Friend WithEvents pnlMenuArea As Panel
    Friend WithEvents rtxtSearch As RichTextBox
End Class
