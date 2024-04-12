<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory_Page
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvInventoryDetails = New System.Windows.Forms.DataGridView()
        Me.pnlInventoryarea = New System.Windows.Forms.Panel()
        Me.rbtnUpdateInventoryitems = New CMS.RoundedButton()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnRefresh = New CMS.RoundedButton()
        Me.pnlInventorydataArea = New System.Windows.Forms.Panel()
        Me.rtxtSearch = New System.Windows.Forms.RichTextBox()
        CType(Me.dgvInventoryDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInventoryarea.SuspendLayout()
        Me.pnlInventorydataArea.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvInventoryDetails
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvInventoryDetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvInventoryDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInventoryDetails.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInventoryDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvInventoryDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventoryDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvInventoryDetails.EnableHeadersVisualStyles = False
        Me.dgvInventoryDetails.GridColor = System.Drawing.Color.Black
        Me.dgvInventoryDetails.Location = New System.Drawing.Point(0, 0)
        Me.dgvInventoryDetails.Name = "dgvInventoryDetails"
        Me.dgvInventoryDetails.ReadOnly = True
        Me.dgvInventoryDetails.RowHeadersWidth = 51
        Me.dgvInventoryDetails.RowTemplate.Height = 40
        Me.dgvInventoryDetails.Size = New System.Drawing.Size(1587, 629)
        Me.dgvInventoryDetails.TabIndex = 0
        '
        'pnlInventoryarea
        '
        Me.pnlInventoryarea.BackColor = System.Drawing.Color.White
        Me.pnlInventoryarea.Controls.Add(Me.rbtnUpdateInventoryitems)
        Me.pnlInventoryarea.Controls.Add(Me.lblTitle)
        Me.pnlInventoryarea.Controls.Add(Me.btnSearch)
        Me.pnlInventoryarea.Controls.Add(Me.btnRefresh)
        Me.pnlInventoryarea.Controls.Add(Me.pnlInventorydataArea)
        Me.pnlInventoryarea.Controls.Add(Me.rtxtSearch)
        Me.pnlInventoryarea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInventoryarea.Location = New System.Drawing.Point(0, 0)
        Me.pnlInventoryarea.Name = "pnlInventoryarea"
        Me.pnlInventoryarea.Size = New System.Drawing.Size(1593, 728)
        Me.pnlInventoryarea.TabIndex = 4
        '
        'rbtnUpdateInventoryitems
        '
        Me.rbtnUpdateInventoryitems.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.rbtnUpdateInventoryitems.CornerRadius = 35
        Me.rbtnUpdateInventoryitems.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rbtnUpdateInventoryitems.FlatAppearance.BorderSize = 8
        Me.rbtnUpdateInventoryitems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtnUpdateInventoryitems.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnUpdateInventoryitems.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.rbtnUpdateInventoryitems.Location = New System.Drawing.Point(56, 22)
        Me.rbtnUpdateInventoryitems.Name = "rbtnUpdateInventoryitems"
        Me.rbtnUpdateInventoryitems.Size = New System.Drawing.Size(92, 41)
        Me.rbtnUpdateInventoryitems.TabIndex = 11
        Me.rbtnUpdateInventoryitems.Text = "Update"
        Me.rbtnUpdateInventoryitems.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Monotype Corsiva", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(393, 7)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(30, 0, 3, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(487, 60)
        Me.lblTitle.TabIndex = 10
        Me.lblTitle.Text = "Manage Inventory Items"
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
        'pnlInventorydataArea
        '
        Me.pnlInventorydataArea.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlInventorydataArea.Controls.Add(Me.dgvInventoryDetails)
        Me.pnlInventorydataArea.Location = New System.Drawing.Point(3, 96)
        Me.pnlInventorydataArea.Name = "pnlInventorydataArea"
        Me.pnlInventorydataArea.Size = New System.Drawing.Size(1587, 629)
        Me.pnlInventorydataArea.TabIndex = 7
        '
        'rtxtSearch
        '
        Me.rtxtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtxtSearch.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtSearch.Location = New System.Drawing.Point(1073, 25)
        Me.rtxtSearch.Name = "rtxtSearch"
        Me.rtxtSearch.Size = New System.Drawing.Size(462, 40)
        Me.rtxtSearch.TabIndex = 8
        Me.rtxtSearch.Text = ""
        '
        'Inventory_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1593, 728)
        Me.Controls.Add(Me.pnlInventoryarea)
        Me.Name = "Inventory_Page"
        Me.Text = "Inventory"
        CType(Me.dgvInventoryDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInventoryarea.ResumeLayout(False)
        Me.pnlInventoryarea.PerformLayout()
        Me.pnlInventorydataArea.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvInventoryDetails As DataGridView
    Friend WithEvents pnlInventoryarea As Panel
    Friend WithEvents rbtnUpdateInventoryitems As RoundedButton
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnRefresh As RoundedButton
    Friend WithEvents pnlInventorydataArea As Panel
    Friend WithEvents rtxtSearch As RichTextBox
End Class
