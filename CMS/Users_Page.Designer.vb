<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Users_Page
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlDetailedTransactions = New System.Windows.Forms.Panel()
        Me.rbtnAddUsers = New CMS.RoundedButton()
        Me.rbtnUpdateUsers = New CMS.RoundedButton()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnRefresh = New CMS.RoundedButton()
        Me.pnlTransactionArea = New System.Windows.Forms.Panel()
        Me.dgvUserDetails = New System.Windows.Forms.DataGridView()
        Me.ctxMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.itemSetAdmin = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemSetCustomer = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemSetActive = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemSetInactive = New System.Windows.Forms.ToolStripMenuItem()
        Me.rtxtSearch = New System.Windows.Forms.RichTextBox()
        Me.pnlDetailedTransactions.SuspendLayout()
        Me.pnlTransactionArea.SuspendLayout()
        CType(Me.dgvUserDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctxMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlDetailedTransactions
        '
        Me.pnlDetailedTransactions.BackColor = System.Drawing.Color.White
        Me.pnlDetailedTransactions.Controls.Add(Me.rbtnAddUsers)
        Me.pnlDetailedTransactions.Controls.Add(Me.rbtnUpdateUsers)
        Me.pnlDetailedTransactions.Controls.Add(Me.lblTitle)
        Me.pnlDetailedTransactions.Controls.Add(Me.btnSearch)
        Me.pnlDetailedTransactions.Controls.Add(Me.btnRefresh)
        Me.pnlDetailedTransactions.Controls.Add(Me.pnlTransactionArea)
        Me.pnlDetailedTransactions.Controls.Add(Me.rtxtSearch)
        Me.pnlDetailedTransactions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDetailedTransactions.Location = New System.Drawing.Point(0, 0)
        Me.pnlDetailedTransactions.Name = "pnlDetailedTransactions"
        Me.pnlDetailedTransactions.Size = New System.Drawing.Size(1593, 728)
        Me.pnlDetailedTransactions.TabIndex = 2
        '
        'rbtnAddUsers
        '
        Me.rbtnAddUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.rbtnAddUsers.CornerRadius = 35
        Me.rbtnAddUsers.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rbtnAddUsers.FlatAppearance.BorderSize = 10
        Me.rbtnAddUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtnAddUsers.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnAddUsers.ForeColor = System.Drawing.Color.White
        Me.rbtnAddUsers.Location = New System.Drawing.Point(14, 22)
        Me.rbtnAddUsers.Name = "rbtnAddUsers"
        Me.rbtnAddUsers.Size = New System.Drawing.Size(92, 41)
        Me.rbtnAddUsers.TabIndex = 12
        Me.rbtnAddUsers.Text = "Add"
        Me.rbtnAddUsers.UseVisualStyleBackColor = False
        '
        'rbtnUpdateUsers
        '
        Me.rbtnUpdateUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.rbtnUpdateUsers.CornerRadius = 35
        Me.rbtnUpdateUsers.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rbtnUpdateUsers.FlatAppearance.BorderSize = 10
        Me.rbtnUpdateUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtnUpdateUsers.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnUpdateUsers.ForeColor = System.Drawing.Color.White
        Me.rbtnUpdateUsers.Location = New System.Drawing.Point(159, 25)
        Me.rbtnUpdateUsers.Name = "rbtnUpdateUsers"
        Me.rbtnUpdateUsers.Size = New System.Drawing.Size(92, 41)
        Me.rbtnUpdateUsers.TabIndex = 11
        Me.rbtnUpdateUsers.Text = "Update"
        Me.rbtnUpdateUsers.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Monotype Corsiva", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(456, 9)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(30, 0, 3, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(293, 60)
        Me.lblTitle.TabIndex = 10
        Me.lblTitle.Text = "Manage Users"
        '
        'btnSearch
        '
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
        'pnlTransactionArea
        '
        Me.pnlTransactionArea.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTransactionArea.Controls.Add(Me.dgvUserDetails)
        Me.pnlTransactionArea.Location = New System.Drawing.Point(3, 96)
        Me.pnlTransactionArea.Name = "pnlTransactionArea"
        Me.pnlTransactionArea.Size = New System.Drawing.Size(1587, 629)
        Me.pnlTransactionArea.TabIndex = 7
        '
        'dgvUserDetails
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvUserDetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUserDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUserDetails.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUserDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvUserDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUserDetails.ContextMenuStrip = Me.ctxMenu
        Me.dgvUserDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUserDetails.EnableHeadersVisualStyles = False
        Me.dgvUserDetails.GridColor = System.Drawing.Color.Black
        Me.dgvUserDetails.Location = New System.Drawing.Point(0, 0)
        Me.dgvUserDetails.Name = "dgvUserDetails"
        Me.dgvUserDetails.ReadOnly = True
        Me.dgvUserDetails.RowHeadersWidth = 51
        Me.dgvUserDetails.RowTemplate.Height = 40
        Me.dgvUserDetails.Size = New System.Drawing.Size(1587, 629)
        Me.dgvUserDetails.TabIndex = 0
        '
        'ctxMenu
        '
        Me.ctxMenu.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctxMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ctxMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itemSetAdmin, Me.itemSetCustomer, Me.itemSetActive, Me.itemSetInactive})
        Me.ctxMenu.Name = "ctxMenuUserType"
        Me.ctxMenu.Size = New System.Drawing.Size(183, 100)
        '
        'itemSetAdmin
        '
        Me.itemSetAdmin.Name = "itemSetAdmin"
        Me.itemSetAdmin.Size = New System.Drawing.Size(182, 24)
        Me.itemSetAdmin.Text = "Make Admin"
        '
        'itemSetCustomer
        '
        Me.itemSetCustomer.Name = "itemSetCustomer"
        Me.itemSetCustomer.Size = New System.Drawing.Size(182, 24)
        Me.itemSetCustomer.Text = "Make Customer"
        '
        'itemSetActive
        '
        Me.itemSetActive.Name = "itemSetActive"
        Me.itemSetActive.Size = New System.Drawing.Size(182, 24)
        Me.itemSetActive.Text = "Make Active"
        '
        'itemSetInactive
        '
        Me.itemSetInactive.Name = "itemSetInactive"
        Me.itemSetInactive.Size = New System.Drawing.Size(182, 24)
        Me.itemSetInactive.Text = "Make Inactive"
        '
        'rtxtSearch
        '
        Me.rtxtSearch.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtSearch.Location = New System.Drawing.Point(1113, 25)
        Me.rtxtSearch.Name = "rtxtSearch"
        Me.rtxtSearch.Size = New System.Drawing.Size(462, 40)
        Me.rtxtSearch.TabIndex = 8
        Me.rtxtSearch.Text = ""
        '
        'Users_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1593, 728)
        Me.Controls.Add(Me.pnlDetailedTransactions)
        Me.Name = "Users_Page"
        Me.Text = "Users"
        Me.pnlDetailedTransactions.ResumeLayout(False)
        Me.pnlDetailedTransactions.PerformLayout()
        Me.pnlTransactionArea.ResumeLayout(False)
        CType(Me.dgvUserDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctxMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlDetailedTransactions As Panel
    Friend WithEvents rbtnAddUsers As RoundedButton
    Friend WithEvents rbtnUpdateUsers As RoundedButton
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnRefresh As RoundedButton
    Friend WithEvents pnlTransactionArea As Panel
    Friend WithEvents dgvUserDetails As DataGridView
    Friend WithEvents ctxMenu As ContextMenuStrip
    Friend WithEvents itemSetAdmin As ToolStripMenuItem
    Friend WithEvents itemSetCustomer As ToolStripMenuItem
    Friend WithEvents itemSetActive As ToolStripMenuItem
    Friend WithEvents itemSetInactive As ToolStripMenuItem
    Friend WithEvents rtxtSearch As RichTextBox
End Class
