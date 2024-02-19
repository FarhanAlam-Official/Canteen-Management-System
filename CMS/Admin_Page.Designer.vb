<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin_Page
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
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.picboxMenu = New System.Windows.Forms.PictureBox()
        Me.pnlOrders = New System.Windows.Forms.Panel()
        Me.btnOrders = New System.Windows.Forms.Button()
        Me.picboxOrders = New System.Windows.Forms.PictureBox()
        Me.pnlInventory = New System.Windows.Forms.Panel()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.picboxInventory = New System.Windows.Forms.PictureBox()
        Me.pnlProducts = New System.Windows.Forms.Panel()
        Me.btnProducts = New System.Windows.Forms.Button()
        Me.picboxProducts = New System.Windows.Forms.PictureBox()
        Me.pnlUsers = New System.Windows.Forms.Panel()
        Me.picboxUsers = New System.Windows.Forms.PictureBox()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.pnlPayments = New System.Windows.Forms.Panel()
        Me.btnPayments = New System.Windows.Forms.Button()
        Me.picboxPayments = New System.Windows.Forms.PictureBox()
        Me.pnlAnalytics = New System.Windows.Forms.Panel()
        Me.btnAnalytics = New System.Windows.Forms.Button()
        Me.PicboxAnalytics = New System.Windows.Forms.PictureBox()
        Me.pnlSuppliers = New System.Windows.Forms.Panel()
        Me.btnSuppliers = New System.Windows.Forms.Button()
        Me.picboxSuppliers = New System.Windows.Forms.PictureBox()
        Me.pnlDashboard = New System.Windows.Forms.Panel()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.PicboxDashboard = New System.Windows.Forms.PictureBox()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.CartesianChart1 = New LiveCharts.WinForms.CartesianChart()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnTogglePanel = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.pnlLogutButton = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        CType(Me.picboxMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOrders.SuspendLayout()
        CType(Me.picboxOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInventory.SuspendLayout()
        CType(Me.picboxInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlProducts.SuspendLayout()
        CType(Me.picboxProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlUsers.SuspendLayout()
        CType(Me.picboxUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPayments.SuspendLayout()
        CType(Me.picboxPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAnalytics.SuspendLayout()
        CType(Me.PicboxAnalytics, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSuppliers.SuspendLayout()
        CType(Me.picboxSuppliers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDashboard.SuspendLayout()
        CType(Me.PicboxDashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.pnlLogutButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.Black
        Me.pnlSidebar.Controls.Add(Me.pnlMenu)
        Me.pnlSidebar.Controls.Add(Me.pnlOrders)
        Me.pnlSidebar.Controls.Add(Me.pnlInventory)
        Me.pnlSidebar.Controls.Add(Me.pnlProducts)
        Me.pnlSidebar.Controls.Add(Me.pnlUsers)
        Me.pnlSidebar.Controls.Add(Me.pnlPayments)
        Me.pnlSidebar.Controls.Add(Me.pnlAnalytics)
        Me.pnlSidebar.Controls.Add(Me.pnlSuppliers)
        Me.pnlSidebar.Controls.Add(Me.pnlDashboard)
        Me.pnlSidebar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlSidebar.Location = New System.Drawing.Point(3, 167)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(203, 713)
        Me.pnlSidebar.TabIndex = 0
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.Black
        Me.pnlMenu.Controls.Add(Me.btnMenu)
        Me.pnlMenu.Controls.Add(Me.picboxMenu)
        Me.pnlMenu.Location = New System.Drawing.Point(10, 565)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(194, 54)
        Me.pnlMenu.TabIndex = 6
        '
        'btnMenu
        '
        Me.btnMenu.FlatAppearance.BorderSize = 0
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnMenu.ForeColor = System.Drawing.Color.White
        Me.btnMenu.Location = New System.Drawing.Point(58, 3)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(136, 48)
        Me.btnMenu.TabIndex = 1
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'picboxMenu
        '
        Me.picboxMenu.BackColor = System.Drawing.Color.Black
        Me.picboxMenu.Image = Global.CMS.My.Resources.Resources.Menu_Icon
        Me.picboxMenu.Location = New System.Drawing.Point(0, 3)
        Me.picboxMenu.Name = "picboxMenu"
        Me.picboxMenu.Size = New System.Drawing.Size(55, 48)
        Me.picboxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxMenu.TabIndex = 0
        Me.picboxMenu.TabStop = False
        '
        'pnlOrders
        '
        Me.pnlOrders.BackColor = System.Drawing.Color.Black
        Me.pnlOrders.Controls.Add(Me.btnOrders)
        Me.pnlOrders.Controls.Add(Me.picboxOrders)
        Me.pnlOrders.Location = New System.Drawing.Point(10, 192)
        Me.pnlOrders.Name = "pnlOrders"
        Me.pnlOrders.Size = New System.Drawing.Size(194, 54)
        Me.pnlOrders.TabIndex = 5
        '
        'btnOrders
        '
        Me.btnOrders.FlatAppearance.BorderSize = 0
        Me.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrders.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnOrders.ForeColor = System.Drawing.Color.White
        Me.btnOrders.Location = New System.Drawing.Point(58, 3)
        Me.btnOrders.Name = "btnOrders"
        Me.btnOrders.Size = New System.Drawing.Size(136, 48)
        Me.btnOrders.TabIndex = 1
        Me.btnOrders.Text = "Orders"
        Me.btnOrders.UseVisualStyleBackColor = True
        '
        'picboxOrders
        '
        Me.picboxOrders.BackColor = System.Drawing.Color.Black
        Me.picboxOrders.Image = Global.CMS.My.Resources.Resources.Orders_Icon
        Me.picboxOrders.Location = New System.Drawing.Point(0, 3)
        Me.picboxOrders.Name = "picboxOrders"
        Me.picboxOrders.Size = New System.Drawing.Size(55, 48)
        Me.picboxOrders.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxOrders.TabIndex = 0
        Me.picboxOrders.TabStop = False
        '
        'pnlInventory
        '
        Me.pnlInventory.BackColor = System.Drawing.Color.Black
        Me.pnlInventory.Controls.Add(Me.btnInventory)
        Me.pnlInventory.Controls.Add(Me.picboxInventory)
        Me.pnlInventory.Location = New System.Drawing.Point(10, 639)
        Me.pnlInventory.Name = "pnlInventory"
        Me.pnlInventory.Size = New System.Drawing.Size(194, 54)
        Me.pnlInventory.TabIndex = 4
        '
        'btnInventory
        '
        Me.btnInventory.FlatAppearance.BorderSize = 0
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventory.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnInventory.ForeColor = System.Drawing.Color.White
        Me.btnInventory.Location = New System.Drawing.Point(58, 3)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(136, 48)
        Me.btnInventory.TabIndex = 1
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'picboxInventory
        '
        Me.picboxInventory.BackColor = System.Drawing.Color.Black
        Me.picboxInventory.Image = Global.CMS.My.Resources.Resources.Inventory_Icon
        Me.picboxInventory.Location = New System.Drawing.Point(0, 3)
        Me.picboxInventory.Name = "picboxInventory"
        Me.picboxInventory.Size = New System.Drawing.Size(55, 48)
        Me.picboxInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxInventory.TabIndex = 0
        Me.picboxInventory.TabStop = False
        '
        'pnlProducts
        '
        Me.pnlProducts.Controls.Add(Me.btnProducts)
        Me.pnlProducts.Controls.Add(Me.picboxProducts)
        Me.pnlProducts.Location = New System.Drawing.Point(9, 491)
        Me.pnlProducts.Name = "pnlProducts"
        Me.pnlProducts.Size = New System.Drawing.Size(194, 54)
        Me.pnlProducts.TabIndex = 3
        '
        'btnProducts
        '
        Me.btnProducts.FlatAppearance.BorderSize = 0
        Me.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProducts.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnProducts.ForeColor = System.Drawing.Color.White
        Me.btnProducts.Location = New System.Drawing.Point(58, 3)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Size = New System.Drawing.Size(136, 48)
        Me.btnProducts.TabIndex = 1
        Me.btnProducts.Text = "Products"
        Me.btnProducts.UseVisualStyleBackColor = True
        '
        'picboxProducts
        '
        Me.picboxProducts.Image = Global.CMS.My.Resources.Resources.Product_Icon
        Me.picboxProducts.Location = New System.Drawing.Point(3, 0)
        Me.picboxProducts.Name = "picboxProducts"
        Me.picboxProducts.Size = New System.Drawing.Size(52, 48)
        Me.picboxProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxProducts.TabIndex = 0
        Me.picboxProducts.TabStop = False
        '
        'pnlUsers
        '
        Me.pnlUsers.Controls.Add(Me.picboxUsers)
        Me.pnlUsers.Controls.Add(Me.btnUsers)
        Me.pnlUsers.Location = New System.Drawing.Point(12, 341)
        Me.pnlUsers.Name = "pnlUsers"
        Me.pnlUsers.Size = New System.Drawing.Size(194, 54)
        Me.pnlUsers.TabIndex = 2
        '
        'picboxUsers
        '
        Me.picboxUsers.Image = Global.CMS.My.Resources.Resources.Users_Icon
        Me.picboxUsers.Location = New System.Drawing.Point(0, 3)
        Me.picboxUsers.Name = "picboxUsers"
        Me.picboxUsers.Size = New System.Drawing.Size(48, 48)
        Me.picboxUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxUsers.TabIndex = 0
        Me.picboxUsers.TabStop = False
        '
        'btnUsers
        '
        Me.btnUsers.FlatAppearance.BorderSize = 0
        Me.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsers.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnUsers.ForeColor = System.Drawing.Color.White
        Me.btnUsers.Location = New System.Drawing.Point(55, 3)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(136, 48)
        Me.btnUsers.TabIndex = 1
        Me.btnUsers.Text = "Users"
        Me.btnUsers.UseVisualStyleBackColor = True
        '
        'pnlPayments
        '
        Me.pnlPayments.Controls.Add(Me.btnPayments)
        Me.pnlPayments.Controls.Add(Me.picboxPayments)
        Me.pnlPayments.Location = New System.Drawing.Point(9, 264)
        Me.pnlPayments.Name = "pnlPayments"
        Me.pnlPayments.Size = New System.Drawing.Size(194, 54)
        Me.pnlPayments.TabIndex = 2
        '
        'btnPayments
        '
        Me.btnPayments.FlatAppearance.BorderSize = 0
        Me.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayments.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnPayments.ForeColor = System.Drawing.Color.White
        Me.btnPayments.Location = New System.Drawing.Point(58, 3)
        Me.btnPayments.Name = "btnPayments"
        Me.btnPayments.Size = New System.Drawing.Size(136, 48)
        Me.btnPayments.TabIndex = 1
        Me.btnPayments.Text = "Payments"
        Me.btnPayments.UseVisualStyleBackColor = True
        '
        'picboxPayments
        '
        Me.picboxPayments.Image = Global.CMS.My.Resources.Resources.Payments_Icon
        Me.picboxPayments.Location = New System.Drawing.Point(3, 0)
        Me.picboxPayments.Name = "picboxPayments"
        Me.picboxPayments.Size = New System.Drawing.Size(52, 48)
        Me.picboxPayments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxPayments.TabIndex = 0
        Me.picboxPayments.TabStop = False
        '
        'pnlAnalytics
        '
        Me.pnlAnalytics.Controls.Add(Me.btnAnalytics)
        Me.pnlAnalytics.Controls.Add(Me.PicboxAnalytics)
        Me.pnlAnalytics.Location = New System.Drawing.Point(10, 114)
        Me.pnlAnalytics.Name = "pnlAnalytics"
        Me.pnlAnalytics.Size = New System.Drawing.Size(194, 54)
        Me.pnlAnalytics.TabIndex = 2
        '
        'btnAnalytics
        '
        Me.btnAnalytics.FlatAppearance.BorderSize = 0
        Me.btnAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnalytics.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnAnalytics.ForeColor = System.Drawing.Color.White
        Me.btnAnalytics.Location = New System.Drawing.Point(58, 3)
        Me.btnAnalytics.Name = "btnAnalytics"
        Me.btnAnalytics.Size = New System.Drawing.Size(136, 48)
        Me.btnAnalytics.TabIndex = 1
        Me.btnAnalytics.Text = "Analytics"
        Me.btnAnalytics.UseVisualStyleBackColor = True
        '
        'PicboxAnalytics
        '
        Me.PicboxAnalytics.BackColor = System.Drawing.Color.Transparent
        Me.PicboxAnalytics.Image = Global.CMS.My.Resources.Resources.Analytics_Icon
        Me.PicboxAnalytics.Location = New System.Drawing.Point(0, 3)
        Me.PicboxAnalytics.Name = "PicboxAnalytics"
        Me.PicboxAnalytics.Size = New System.Drawing.Size(54, 48)
        Me.PicboxAnalytics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicboxAnalytics.TabIndex = 0
        Me.PicboxAnalytics.TabStop = False
        '
        'pnlSuppliers
        '
        Me.pnlSuppliers.Controls.Add(Me.btnSuppliers)
        Me.pnlSuppliers.Controls.Add(Me.picboxSuppliers)
        Me.pnlSuppliers.Location = New System.Drawing.Point(9, 411)
        Me.pnlSuppliers.Name = "pnlSuppliers"
        Me.pnlSuppliers.Size = New System.Drawing.Size(194, 54)
        Me.pnlSuppliers.TabIndex = 1
        '
        'btnSuppliers
        '
        Me.btnSuppliers.FlatAppearance.BorderSize = 0
        Me.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuppliers.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnSuppliers.ForeColor = System.Drawing.Color.White
        Me.btnSuppliers.Location = New System.Drawing.Point(58, 3)
        Me.btnSuppliers.Name = "btnSuppliers"
        Me.btnSuppliers.Size = New System.Drawing.Size(136, 48)
        Me.btnSuppliers.TabIndex = 1
        Me.btnSuppliers.Text = "Suppliers"
        Me.btnSuppliers.UseVisualStyleBackColor = True
        '
        'picboxSuppliers
        '
        Me.picboxSuppliers.Image = Global.CMS.My.Resources.Resources.Supplier_Icon
        Me.picboxSuppliers.Location = New System.Drawing.Point(7, 3)
        Me.picboxSuppliers.Name = "picboxSuppliers"
        Me.picboxSuppliers.Size = New System.Drawing.Size(48, 48)
        Me.picboxSuppliers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxSuppliers.TabIndex = 0
        Me.picboxSuppliers.TabStop = False
        '
        'pnlDashboard
        '
        Me.pnlDashboard.Controls.Add(Me.btnDashboard)
        Me.pnlDashboard.Controls.Add(Me.PicboxDashboard)
        Me.pnlDashboard.Location = New System.Drawing.Point(10, 39)
        Me.pnlDashboard.Name = "pnlDashboard"
        Me.pnlDashboard.Size = New System.Drawing.Size(194, 54)
        Me.pnlDashboard.TabIndex = 0
        '
        'btnDashboard
        '
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Location = New System.Drawing.Point(58, 3)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(136, 48)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'PicboxDashboard
        '
        Me.PicboxDashboard.BackColor = System.Drawing.Color.Transparent
        Me.PicboxDashboard.Image = Global.CMS.My.Resources.Resources.Dashboard_Icon
        Me.PicboxDashboard.Location = New System.Drawing.Point(0, 3)
        Me.PicboxDashboard.Name = "PicboxDashboard"
        Me.PicboxDashboard.Size = New System.Drawing.Size(54, 48)
        Me.PicboxDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicboxDashboard.TabIndex = 0
        Me.PicboxDashboard.TabStop = False
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlMain.Controls.Add(Me.CartesianChart1)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(226, 105)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1611, 775)
        Me.pnlMain.TabIndex = 14
        '
        'CartesianChart1
        '
        Me.CartesianChart1.Location = New System.Drawing.Point(24, 776)
        Me.CartesianChart1.Name = "CartesianChart1"
        Me.CartesianChart1.Size = New System.Drawing.Size(10, 10)
        Me.CartesianChart1.TabIndex = 0
        Me.CartesianChart1.Text = "CartesianChart1"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnTogglePanel)
        Me.Panel2.Controls.Add(Me.pnlSidebar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(226, 880)
        Me.Panel2.TabIndex = 16
        '
        'btnTogglePanel
        '
        Me.btnTogglePanel.BackColor = System.Drawing.Color.White
        Me.btnTogglePanel.BackgroundImage = Global.CMS.My.Resources.Resources.CMS_Logo
        Me.btnTogglePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTogglePanel.FlatAppearance.BorderSize = 0
        Me.btnTogglePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTogglePanel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTogglePanel.Location = New System.Drawing.Point(21, 8)
        Me.btnTogglePanel.Name = "btnTogglePanel"
        Me.btnTogglePanel.Size = New System.Drawing.Size(120, 87)
        Me.btnTogglePanel.TabIndex = 2
        Me.btnTogglePanel.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(638, 6)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(30, 0, 3, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.lblTitle.Size = New System.Drawing.Size(263, 72)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "CMS"
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.pnlLogutButton)
        Me.pnlTop.Controls.Add(Me.lblTitle)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(226, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1611, 105)
        Me.pnlTop.TabIndex = 15
        '
        'pnlLogutButton
        '
        Me.pnlLogutButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlLogutButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlLogutButton.Controls.Add(Me.btnLogout)
        Me.pnlLogutButton.Location = New System.Drawing.Point(1523, 26)
        Me.pnlLogutButton.Name = "pnlLogutButton"
        Me.pnlLogutButton.Size = New System.Drawing.Size(49, 52)
        Me.pnlLogutButton.TabIndex = 4
        '
        'btnLogout
        '
        Me.btnLogout.BackgroundImage = Global.CMS.My.Resources.Resources.Logout_Icon
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Location = New System.Drawing.Point(0, 0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(49, 52)
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Admin_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1837, 880)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.Panel2)
        Me.DoubleBuffered = True
        Me.Name = "Admin_Page"
        Me.Text = "Admin Page"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlMenu.ResumeLayout(False)
        CType(Me.picboxMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOrders.ResumeLayout(False)
        CType(Me.picboxOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInventory.ResumeLayout(False)
        CType(Me.picboxInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlProducts.ResumeLayout(False)
        CType(Me.picboxProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlUsers.ResumeLayout(False)
        CType(Me.picboxUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPayments.ResumeLayout(False)
        CType(Me.picboxPayments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAnalytics.ResumeLayout(False)
        CType(Me.PicboxAnalytics, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSuppliers.ResumeLayout(False)
        CType(Me.picboxSuppliers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDashboard.ResumeLayout(False)
        CType(Me.PicboxDashboard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlLogutButton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents btnTogglePanel As Button
    Friend WithEvents pnlMain As Panel
    Friend WithEvents CartesianChart1 As LiveCharts.WinForms.CartesianChart
    Friend WithEvents pnlDashboard As Panel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents PicboxDashboard As PictureBox
    Friend WithEvents pnlProducts As Panel
    Friend WithEvents btnProducts As Button
    Friend WithEvents picboxProducts As PictureBox
    Friend WithEvents pnlUsers As Panel
    Friend WithEvents picboxUsers As PictureBox
    Friend WithEvents btnUsers As Button
    Friend WithEvents pnlPayments As Panel
    Friend WithEvents btnPayments As Button
    Friend WithEvents picboxPayments As PictureBox
    Friend WithEvents pnlAnalytics As Panel
    Friend WithEvents btnAnalytics As Button
    Friend WithEvents PicboxAnalytics As PictureBox
    Friend WithEvents pnlSuppliers As Panel
    Friend WithEvents btnSuppliers As Button
    Friend WithEvents picboxSuppliers As PictureBox
    Friend WithEvents pnlInventory As Panel
    Friend WithEvents btnInventory As Button
    Friend WithEvents picboxInventory As PictureBox
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents btnMenu As Button
    Friend WithEvents picboxMenu As PictureBox
    Friend WithEvents pnlOrders As Panel
    Friend WithEvents btnOrders As Button
    Friend WithEvents picboxOrders As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlTop As Panel
    Friend WithEvents pnlLogutButton As Panel
    Friend WithEvents btnLogout As Button
End Class
