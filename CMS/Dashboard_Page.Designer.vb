<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard_Page
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
        Me.lblStatus3 = New System.Windows.Forms.Label()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblPrice3 = New System.Windows.Forms.Label()
        Me.lblitemName3 = New System.Windows.Forms.Label()
        Me.lblPrice1 = New System.Windows.Forms.Label()
        Me.lblitemName1 = New System.Windows.Forms.Label()
        Me.lblStatus1 = New System.Windows.Forms.Label()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblPrice2 = New System.Windows.Forms.Label()
        Me.lblitemName2 = New System.Windows.Forms.Label()
        Me.lblStatus2 = New System.Windows.Forms.Label()
        Me.pnlPendingPayment = New System.Windows.Forms.Panel()
        Me.lblPendingPayments = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvTopInventoryItems = New System.Windows.Forms.DataGridView()
        Me.pnlPendingOrders = New System.Windows.Forms.Panel()
        Me.lblPendingOrders = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlTotalOrders = New System.Windows.Forms.Panel()
        Me.lblTotalOrdersToday = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlTotalRevenue = New System.Windows.Forms.Panel()
        Me.lblTotalRevenueMonth = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.pnlInventory = New System.Windows.Forms.Panel()
        Me.lblInventoryTitle = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.pnlDashboard = New System.Windows.Forms.Panel()
        Me.pnlDailyRevenue = New System.Windows.Forms.Panel()
        Me.pnlChartarea = New System.Windows.Forms.Panel()
        Me.cartesianChartDailyRevenue = New LiveCharts.WinForms.CartesianChart()
        Me.lblRevenueChange = New System.Windows.Forms.Label()
        Me.lbllessthanlastweek = New System.Windows.Forms.Label()
        Me.lblTotalRevenue = New System.Windows.Forms.Label()
        Me.lblDailyRevenueTitle = New System.Windows.Forms.Label()
        Me.pnlMiscArea = New System.Windows.Forms.Panel()
        Me.pnlOrdersInProgress = New System.Windows.Forms.Panel()
        Me.dgvOrdersInProgress = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlHighestOrderAmount = New System.Windows.Forms.Panel()
        Me.lblOrderAmount = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblHighestOrderAmountTitle = New System.Windows.Forms.Label()
        Me.pnlBestSellingItem = New System.Windows.Forms.Panel()
        Me.lblBestSellingItemTitle = New System.Windows.Forms.Label()
        Me.picBox3 = New System.Windows.Forms.PictureBox()
        Me.picBox2 = New System.Windows.Forms.PictureBox()
        Me.picBox1 = New System.Windows.Forms.PictureBox()
        Me.lblmsg = New System.Windows.Forms.Label()
        Me.TimerRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.groupBox3.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.pnlPendingPayment.SuspendLayout()
        CType(Me.dgvTopInventoryItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPendingOrders.SuspendLayout()
        Me.pnlTotalOrders.SuspendLayout()
        Me.pnlTotalRevenue.SuspendLayout()
        Me.pnlInventory.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.pnlDashboard.SuspendLayout()
        Me.pnlDailyRevenue.SuspendLayout()
        Me.pnlChartarea.SuspendLayout()
        Me.pnlMiscArea.SuspendLayout()
        Me.pnlOrdersInProgress.SuspendLayout()
        CType(Me.dgvOrdersInProgress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHighestOrderAmount.SuspendLayout()
        Me.pnlBestSellingItem.SuspendLayout()
        CType(Me.picBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStatus3
        '
        Me.lblStatus3.AutoSize = True
        Me.lblStatus3.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblStatus3.Location = New System.Drawing.Point(6, 41)
        Me.lblStatus3.Name = "lblStatus3"
        Me.lblStatus3.Size = New System.Drawing.Size(30, 23)
        Me.lblStatus3.TabIndex = 3
        Me.lblStatus3.Text = "#3"
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.lblPrice3)
        Me.groupBox3.Controls.Add(Me.lblitemName3)
        Me.groupBox3.Controls.Add(Me.lblStatus3)
        Me.groupBox3.Location = New System.Drawing.Point(18, 237)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(240, 94)
        Me.groupBox3.TabIndex = 6
        Me.groupBox3.TabStop = False
        '
        'lblPrice3
        '
        Me.lblPrice3.AutoSize = True
        Me.lblPrice3.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice3.Location = New System.Drawing.Point(51, 52)
        Me.lblPrice3.Name = "lblPrice3"
        Me.lblPrice3.Size = New System.Drawing.Size(33, 23)
        Me.lblPrice3.TabIndex = 5
        Me.lblPrice3.Text = "Rs."
        '
        'lblitemName3
        '
        Me.lblitemName3.AutoSize = True
        Me.lblitemName3.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblitemName3.Location = New System.Drawing.Point(51, 18)
        Me.lblitemName3.Name = "lblitemName3"
        Me.lblitemName3.Size = New System.Drawing.Size(94, 23)
        Me.lblitemName3.TabIndex = 4
        Me.lblitemName3.Text = "Item Name"
        '
        'lblPrice1
        '
        Me.lblPrice1.AutoSize = True
        Me.lblPrice1.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice1.Location = New System.Drawing.Point(51, 52)
        Me.lblPrice1.Name = "lblPrice1"
        Me.lblPrice1.Size = New System.Drawing.Size(33, 23)
        Me.lblPrice1.TabIndex = 5
        Me.lblPrice1.Text = "Rs."
        '
        'lblitemName1
        '
        Me.lblitemName1.AutoSize = True
        Me.lblitemName1.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblitemName1.Location = New System.Drawing.Point(51, 18)
        Me.lblitemName1.Name = "lblitemName1"
        Me.lblitemName1.Size = New System.Drawing.Size(94, 23)
        Me.lblitemName1.TabIndex = 4
        Me.lblitemName1.Text = "Item Name"
        '
        'lblStatus1
        '
        Me.lblStatus1.AutoSize = True
        Me.lblStatus1.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblStatus1.Location = New System.Drawing.Point(6, 41)
        Me.lblStatus1.Name = "lblStatus1"
        Me.lblStatus1.Size = New System.Drawing.Size(30, 23)
        Me.lblStatus1.TabIndex = 3
        Me.lblStatus1.Text = "#1"
        '
        'groupBox2
        '
        Me.groupBox2.BackColor = System.Drawing.Color.Transparent
        Me.groupBox2.Controls.Add(Me.lblPrice2)
        Me.groupBox2.Controls.Add(Me.lblitemName2)
        Me.groupBox2.Controls.Add(Me.lblStatus2)
        Me.groupBox2.Location = New System.Drawing.Point(18, 142)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(240, 94)
        Me.groupBox2.TabIndex = 6
        Me.groupBox2.TabStop = False
        '
        'lblPrice2
        '
        Me.lblPrice2.AutoSize = True
        Me.lblPrice2.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice2.Location = New System.Drawing.Point(51, 52)
        Me.lblPrice2.Name = "lblPrice2"
        Me.lblPrice2.Size = New System.Drawing.Size(33, 23)
        Me.lblPrice2.TabIndex = 5
        Me.lblPrice2.Text = "Rs."
        '
        'lblitemName2
        '
        Me.lblitemName2.AutoSize = True
        Me.lblitemName2.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblitemName2.Location = New System.Drawing.Point(51, 18)
        Me.lblitemName2.Name = "lblitemName2"
        Me.lblitemName2.Size = New System.Drawing.Size(94, 23)
        Me.lblitemName2.TabIndex = 4
        Me.lblitemName2.Text = "Item Name"
        '
        'lblStatus2
        '
        Me.lblStatus2.AutoSize = True
        Me.lblStatus2.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblStatus2.Location = New System.Drawing.Point(6, 41)
        Me.lblStatus2.Name = "lblStatus2"
        Me.lblStatus2.Size = New System.Drawing.Size(30, 23)
        Me.lblStatus2.TabIndex = 3
        Me.lblStatus2.Text = "#2"
        '
        'pnlPendingPayment
        '
        Me.pnlPendingPayment.BackColor = System.Drawing.Color.White
        Me.pnlPendingPayment.Controls.Add(Me.lblPendingPayments)
        Me.pnlPendingPayment.Controls.Add(Me.Label5)
        Me.pnlPendingPayment.Location = New System.Drawing.Point(354, 187)
        Me.pnlPendingPayment.Name = "pnlPendingPayment"
        Me.pnlPendingPayment.Size = New System.Drawing.Size(321, 164)
        Me.pnlPendingPayment.TabIndex = 25
        '
        'lblPendingPayments
        '
        Me.lblPendingPayments.AutoSize = True
        Me.lblPendingPayments.Font = New System.Drawing.Font("Trebuchet MS", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPendingPayments.Location = New System.Drawing.Point(20, 84)
        Me.lblPendingPayments.Name = "lblPendingPayments"
        Me.lblPendingPayments.Size = New System.Drawing.Size(141, 24)
        Me.lblPendingPayments.TabIndex = 2
        Me.lblPendingPayments.Text = "no of payments"
        Me.lblPendingPayments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(17, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 27)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Pending Payment"
        '
        'dgvTopInventoryItems
        '
        Me.dgvTopInventoryItems.AllowUserToAddRows = False
        Me.dgvTopInventoryItems.AllowUserToDeleteRows = False
        Me.dgvTopInventoryItems.AllowUserToResizeColumns = False
        Me.dgvTopInventoryItems.AllowUserToResizeRows = False
        Me.dgvTopInventoryItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTopInventoryItems.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTopInventoryItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTopInventoryItems.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvTopInventoryItems.GridColor = System.Drawing.Color.Black
        Me.dgvTopInventoryItems.Location = New System.Drawing.Point(5, 47)
        Me.dgvTopInventoryItems.Name = "dgvTopInventoryItems"
        Me.dgvTopInventoryItems.ReadOnly = True
        Me.dgvTopInventoryItems.RowHeadersWidth = 51
        Me.dgvTopInventoryItems.RowTemplate.Height = 24
        Me.dgvTopInventoryItems.Size = New System.Drawing.Size(482, 293)
        Me.dgvTopInventoryItems.TabIndex = 4
        '
        'pnlPendingOrders
        '
        Me.pnlPendingOrders.BackColor = System.Drawing.Color.White
        Me.pnlPendingOrders.Controls.Add(Me.lblPendingOrders)
        Me.pnlPendingOrders.Controls.Add(Me.Label4)
        Me.pnlPendingOrders.Location = New System.Drawing.Point(14, 189)
        Me.pnlPendingOrders.Name = "pnlPendingOrders"
        Me.pnlPendingOrders.Size = New System.Drawing.Size(321, 164)
        Me.pnlPendingOrders.TabIndex = 25
        '
        'lblPendingOrders
        '
        Me.lblPendingOrders.AutoSize = True
        Me.lblPendingOrders.Font = New System.Drawing.Font("Trebuchet MS", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPendingOrders.Location = New System.Drawing.Point(22, 84)
        Me.lblPendingOrders.Name = "lblPendingOrders"
        Me.lblPendingOrders.Size = New System.Drawing.Size(112, 24)
        Me.lblPendingOrders.TabIndex = 4
        Me.lblPendingOrders.Text = "no of orders"
        Me.lblPendingOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(19, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 27)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Pending Orders"
        '
        'pnlTotalOrders
        '
        Me.pnlTotalOrders.BackColor = System.Drawing.Color.White
        Me.pnlTotalOrders.Controls.Add(Me.lblTotalOrdersToday)
        Me.pnlTotalOrders.Controls.Add(Me.Label1)
        Me.pnlTotalOrders.Location = New System.Drawing.Point(14, 6)
        Me.pnlTotalOrders.Name = "pnlTotalOrders"
        Me.pnlTotalOrders.Size = New System.Drawing.Size(321, 164)
        Me.pnlTotalOrders.TabIndex = 25
        '
        'lblTotalOrdersToday
        '
        Me.lblTotalOrdersToday.AutoSize = True
        Me.lblTotalOrdersToday.Font = New System.Drawing.Font("Trebuchet MS", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalOrdersToday.Location = New System.Drawing.Point(23, 85)
        Me.lblTotalOrdersToday.Name = "lblTotalOrdersToday"
        Me.lblTotalOrdersToday.Size = New System.Drawing.Size(112, 24)
        Me.lblTotalOrdersToday.TabIndex = 3
        Me.lblTotalOrdersToday.Text = "no of orders"
        Me.lblTotalOrdersToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(19, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total Orders"
        '
        'pnlTotalRevenue
        '
        Me.pnlTotalRevenue.BackColor = System.Drawing.Color.White
        Me.pnlTotalRevenue.Controls.Add(Me.lblTotalRevenueMonth)
        Me.pnlTotalRevenue.Controls.Add(Me.Label21)
        Me.pnlTotalRevenue.Location = New System.Drawing.Point(354, 4)
        Me.pnlTotalRevenue.Name = "pnlTotalRevenue"
        Me.pnlTotalRevenue.Size = New System.Drawing.Size(321, 164)
        Me.pnlTotalRevenue.TabIndex = 24
        '
        'lblTotalRevenueMonth
        '
        Me.lblTotalRevenueMonth.AutoSize = True
        Me.lblTotalRevenueMonth.Font = New System.Drawing.Font("Trebuchet MS", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRevenueMonth.Location = New System.Drawing.Point(23, 85)
        Me.lblTotalRevenueMonth.Name = "lblTotalRevenueMonth"
        Me.lblTotalRevenueMonth.Size = New System.Drawing.Size(36, 24)
        Me.lblTotalRevenueMonth.TabIndex = 4
        Me.lblTotalRevenueMonth.Text = "Rs."
        Me.lblTotalRevenueMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Trebuchet MS", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(20, 29)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(236, 27)
        Me.Label21.TabIndex = 3
        Me.Label21.Text = "Total Monthly Revenue"
        '
        'pnlInventory
        '
        Me.pnlInventory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlInventory.BackColor = System.Drawing.Color.White
        Me.pnlInventory.Controls.Add(Me.dgvTopInventoryItems)
        Me.pnlInventory.Controls.Add(Me.lblInventoryTitle)
        Me.pnlInventory.Location = New System.Drawing.Point(693, 4)
        Me.pnlInventory.Name = "pnlInventory"
        Me.pnlInventory.Padding = New System.Windows.Forms.Padding(5, 0, 5, 5)
        Me.pnlInventory.Size = New System.Drawing.Size(492, 345)
        Me.pnlInventory.TabIndex = 23
        '
        'lblInventoryTitle
        '
        Me.lblInventoryTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInventoryTitle.AutoSize = True
        Me.lblInventoryTitle.Font = New System.Drawing.Font("Trebuchet MS", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInventoryTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblInventoryTitle.Location = New System.Drawing.Point(177, 7)
        Me.lblInventoryTitle.Name = "lblInventoryTitle"
        Me.lblInventoryTitle.Size = New System.Drawing.Size(106, 27)
        Me.lblInventoryTitle.TabIndex = 3
        Me.lblInventoryTitle.Text = "Inventory"
        Me.lblInventoryTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.lblPrice1)
        Me.groupBox1.Controls.Add(Me.lblitemName1)
        Me.groupBox1.Controls.Add(Me.lblStatus1)
        Me.groupBox1.Location = New System.Drawing.Point(18, 36)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(240, 94)
        Me.groupBox1.TabIndex = 3
        Me.groupBox1.TabStop = False
        '
        'pnlDashboard
        '
        Me.pnlDashboard.BackColor = System.Drawing.Color.Transparent
        Me.pnlDashboard.Controls.Add(Me.pnlDailyRevenue)
        Me.pnlDashboard.Controls.Add(Me.pnlMiscArea)
        Me.pnlDashboard.Controls.Add(Me.pnlPendingPayment)
        Me.pnlDashboard.Controls.Add(Me.pnlPendingOrders)
        Me.pnlDashboard.Controls.Add(Me.pnlTotalOrders)
        Me.pnlDashboard.Controls.Add(Me.pnlTotalRevenue)
        Me.pnlDashboard.Controls.Add(Me.pnlInventory)
        Me.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDashboard.Location = New System.Drawing.Point(0, 0)
        Me.pnlDashboard.Name = "pnlDashboard"
        Me.pnlDashboard.Size = New System.Drawing.Size(1611, 775)
        Me.pnlDashboard.TabIndex = 16
        '
        'pnlDailyRevenue
        '
        Me.pnlDailyRevenue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlDailyRevenue.BackColor = System.Drawing.Color.White
        Me.pnlDailyRevenue.Controls.Add(Me.pnlChartarea)
        Me.pnlDailyRevenue.Controls.Add(Me.lblRevenueChange)
        Me.pnlDailyRevenue.Controls.Add(Me.lbllessthanlastweek)
        Me.pnlDailyRevenue.Controls.Add(Me.lblTotalRevenue)
        Me.pnlDailyRevenue.Controls.Add(Me.lblDailyRevenueTitle)
        Me.pnlDailyRevenue.Location = New System.Drawing.Point(14, 372)
        Me.pnlDailyRevenue.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlDailyRevenue.Name = "pnlDailyRevenue"
        Me.pnlDailyRevenue.Size = New System.Drawing.Size(1171, 400)
        Me.pnlDailyRevenue.TabIndex = 27
        '
        'pnlChartarea
        '
        Me.pnlChartarea.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlChartarea.Controls.Add(Me.cartesianChartDailyRevenue)
        Me.pnlChartarea.Location = New System.Drawing.Point(17, 85)
        Me.pnlChartarea.Name = "pnlChartarea"
        Me.pnlChartarea.Size = New System.Drawing.Size(1138, 312)
        Me.pnlChartarea.TabIndex = 13
        '
        'cartesianChartDailyRevenue
        '
        Me.cartesianChartDailyRevenue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cartesianChartDailyRevenue.Location = New System.Drawing.Point(0, 0)
        Me.cartesianChartDailyRevenue.Name = "cartesianChartDailyRevenue"
        Me.cartesianChartDailyRevenue.Size = New System.Drawing.Size(1138, 312)
        Me.cartesianChartDailyRevenue.TabIndex = 9
        Me.cartesianChartDailyRevenue.Text = "CartesianChart1"
        '
        'lblRevenueChange
        '
        Me.lblRevenueChange.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRevenueChange.AutoSize = True
        Me.lblRevenueChange.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRevenueChange.Location = New System.Drawing.Point(857, 47)
        Me.lblRevenueChange.Name = "lblRevenueChange"
        Me.lblRevenueChange.Size = New System.Drawing.Size(63, 23)
        Me.lblRevenueChange.TabIndex = 12
        Me.lblRevenueChange.Text = "chng %"
        '
        'lbllessthanlastweek
        '
        Me.lbllessthanlastweek.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbllessthanlastweek.AutoSize = True
        Me.lbllessthanlastweek.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllessthanlastweek.Location = New System.Drawing.Point(1044, 49)
        Me.lbllessthanlastweek.Name = "lbllessthanlastweek"
        Me.lbllessthanlastweek.Size = New System.Drawing.Size(111, 20)
        Me.lbllessthanlastweek.TabIndex = 11
        Me.lbllessthanlastweek.Text = "than last week"
        '
        'lblTotalRevenue
        '
        Me.lblTotalRevenue.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalRevenue.AutoSize = True
        Me.lblTotalRevenue.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRevenue.Location = New System.Drawing.Point(933, 10)
        Me.lblTotalRevenue.Name = "lblTotalRevenue"
        Me.lblTotalRevenue.Size = New System.Drawing.Size(178, 32)
        Me.lblTotalRevenue.TabIndex = 10
        Me.lblTotalRevenue.Text = "Total Revenue"
        '
        'lblDailyRevenueTitle
        '
        Me.lblDailyRevenueTitle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDailyRevenueTitle.AutoSize = True
        Me.lblDailyRevenueTitle.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDailyRevenueTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblDailyRevenueTitle.Location = New System.Drawing.Point(102, 10)
        Me.lblDailyRevenueTitle.Name = "lblDailyRevenueTitle"
        Me.lblDailyRevenueTitle.Size = New System.Drawing.Size(173, 32)
        Me.lblDailyRevenueTitle.TabIndex = 8
        Me.lblDailyRevenueTitle.Text = "Daily Revenue"
        '
        'pnlMiscArea
        '
        Me.pnlMiscArea.Controls.Add(Me.pnlOrdersInProgress)
        Me.pnlMiscArea.Controls.Add(Me.pnlHighestOrderAmount)
        Me.pnlMiscArea.Controls.Add(Me.pnlBestSellingItem)
        Me.pnlMiscArea.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlMiscArea.Location = New System.Drawing.Point(1202, 0)
        Me.pnlMiscArea.Name = "pnlMiscArea"
        Me.pnlMiscArea.Size = New System.Drawing.Size(409, 775)
        Me.pnlMiscArea.TabIndex = 26
        '
        'pnlOrdersInProgress
        '
        Me.pnlOrdersInProgress.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlOrdersInProgress.BackColor = System.Drawing.Color.White
        Me.pnlOrdersInProgress.Controls.Add(Me.dgvOrdersInProgress)
        Me.pnlOrdersInProgress.Controls.Add(Me.Label2)
        Me.pnlOrdersInProgress.Location = New System.Drawing.Point(0, 502)
        Me.pnlOrdersInProgress.Name = "pnlOrdersInProgress"
        Me.pnlOrdersInProgress.Size = New System.Drawing.Size(397, 267)
        Me.pnlOrdersInProgress.TabIndex = 2
        '
        'dgvOrdersInProgress
        '
        Me.dgvOrdersInProgress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvOrdersInProgress.BackgroundColor = System.Drawing.Color.White
        Me.dgvOrdersInProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrdersInProgress.Location = New System.Drawing.Point(3, 60)
        Me.dgvOrdersInProgress.Name = "dgvOrdersInProgress"
        Me.dgvOrdersInProgress.RowHeadersWidth = 51
        Me.dgvOrdersInProgress.RowTemplate.Height = 24
        Me.dgvOrdersInProgress.Size = New System.Drawing.Size(391, 213)
        Me.dgvOrdersInProgress.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(96, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 27)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Orders in Progress"
        '
        'pnlHighestOrderAmount
        '
        Me.pnlHighestOrderAmount.BackColor = System.Drawing.Color.White
        Me.pnlHighestOrderAmount.Controls.Add(Me.lblOrderAmount)
        Me.pnlHighestOrderAmount.Controls.Add(Me.lblCustomerName)
        Me.pnlHighestOrderAmount.Controls.Add(Me.lblHighestOrderAmountTitle)
        Me.pnlHighestOrderAmount.Location = New System.Drawing.Point(4, 372)
        Me.pnlHighestOrderAmount.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlHighestOrderAmount.Name = "pnlHighestOrderAmount"
        Me.pnlHighestOrderAmount.Size = New System.Drawing.Size(391, 114)
        Me.pnlHighestOrderAmount.TabIndex = 1
        '
        'lblOrderAmount
        '
        Me.lblOrderAmount.AutoSize = True
        Me.lblOrderAmount.Font = New System.Drawing.Font("Trebuchet MS", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderAmount.Location = New System.Drawing.Point(267, 65)
        Me.lblOrderAmount.Name = "lblOrderAmount"
        Me.lblOrderAmount.Size = New System.Drawing.Size(36, 24)
        Me.lblOrderAmount.TabIndex = 9
        Me.lblOrderAmount.Text = "Rs."
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Trebuchet MS", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(59, 65)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(146, 24)
        Me.lblCustomerName.TabIndex = 8
        Me.lblCustomerName.Text = "Customer Name"
        '
        'lblHighestOrderAmountTitle
        '
        Me.lblHighestOrderAmountTitle.AutoSize = True
        Me.lblHighestOrderAmountTitle.Font = New System.Drawing.Font("Trebuchet MS", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighestOrderAmountTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblHighestOrderAmountTitle.Location = New System.Drawing.Point(49, 10)
        Me.lblHighestOrderAmountTitle.Name = "lblHighestOrderAmountTitle"
        Me.lblHighestOrderAmountTitle.Size = New System.Drawing.Size(308, 27)
        Me.lblHighestOrderAmountTitle.TabIndex = 7
        Me.lblHighestOrderAmountTitle.Text = "Today's Highest Order Amount"
        '
        'pnlBestSellingItem
        '
        Me.pnlBestSellingItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBestSellingItem.BackColor = System.Drawing.Color.White
        Me.pnlBestSellingItem.Controls.Add(Me.groupBox2)
        Me.pnlBestSellingItem.Controls.Add(Me.groupBox3)
        Me.pnlBestSellingItem.Controls.Add(Me.groupBox1)
        Me.pnlBestSellingItem.Controls.Add(Me.lblBestSellingItemTitle)
        Me.pnlBestSellingItem.Controls.Add(Me.picBox3)
        Me.pnlBestSellingItem.Controls.Add(Me.picBox2)
        Me.pnlBestSellingItem.Controls.Add(Me.picBox1)
        Me.pnlBestSellingItem.Controls.Add(Me.lblmsg)
        Me.pnlBestSellingItem.Location = New System.Drawing.Point(3, 6)
        Me.pnlBestSellingItem.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlBestSellingItem.Name = "pnlBestSellingItem"
        Me.pnlBestSellingItem.Size = New System.Drawing.Size(392, 345)
        Me.pnlBestSellingItem.TabIndex = 0
        '
        'lblBestSellingItemTitle
        '
        Me.lblBestSellingItemTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBestSellingItemTitle.AutoSize = True
        Me.lblBestSellingItemTitle.Font = New System.Drawing.Font("Trebuchet MS", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBestSellingItemTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblBestSellingItemTitle.Location = New System.Drawing.Point(104, 7)
        Me.lblBestSellingItemTitle.Name = "lblBestSellingItemTitle"
        Me.lblBestSellingItemTitle.Size = New System.Drawing.Size(194, 27)
        Me.lblBestSellingItemTitle.TabIndex = 2
        Me.lblBestSellingItemTitle.Text = "Today's Best Seller"
        '
        'picBox3
        '
        Me.picBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBox3.Location = New System.Drawing.Point(277, 245)
        Me.picBox3.Name = "picBox3"
        Me.picBox3.Size = New System.Drawing.Size(109, 86)
        Me.picBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBox3.TabIndex = 2
        Me.picBox3.TabStop = False
        '
        'picBox2
        '
        Me.picBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBox2.Location = New System.Drawing.Point(278, 142)
        Me.picBox2.Name = "picBox2"
        Me.picBox2.Size = New System.Drawing.Size(108, 86)
        Me.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBox2.TabIndex = 1
        Me.picBox2.TabStop = False
        '
        'picBox1
        '
        Me.picBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBox1.ErrorImage = Global.CMS.My.Resources.Resources.DefaultProductImage
        Me.picBox1.Location = New System.Drawing.Point(278, 44)
        Me.picBox1.Name = "picBox1"
        Me.picBox1.Size = New System.Drawing.Size(108, 86)
        Me.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBox1.TabIndex = 0
        Me.picBox1.TabStop = False
        '
        'lblmsg
        '
        Me.lblmsg.AutoSize = True
        Me.lblmsg.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmsg.ForeColor = System.Drawing.Color.Red
        Me.lblmsg.Location = New System.Drawing.Point(113, 140)
        Me.lblmsg.Name = "lblmsg"
        Me.lblmsg.Size = New System.Drawing.Size(218, 56)
        Me.lblmsg.TabIndex = 7
        Me.lblmsg.Text = """No sales have been" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    recorded yet"""
        Me.lblmsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblmsg.Visible = False
        '
        'TimerRefresh
        '
        '
        'Dashboard_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1611, 775)
        Me.Controls.Add(Me.pnlDashboard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Dashboard_Page"
        Me.Text = "Dashboard"
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.pnlPendingPayment.ResumeLayout(False)
        Me.pnlPendingPayment.PerformLayout()
        CType(Me.dgvTopInventoryItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPendingOrders.ResumeLayout(False)
        Me.pnlPendingOrders.PerformLayout()
        Me.pnlTotalOrders.ResumeLayout(False)
        Me.pnlTotalOrders.PerformLayout()
        Me.pnlTotalRevenue.ResumeLayout(False)
        Me.pnlTotalRevenue.PerformLayout()
        Me.pnlInventory.ResumeLayout(False)
        Me.pnlInventory.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.pnlDashboard.ResumeLayout(False)
        Me.pnlDailyRevenue.ResumeLayout(False)
        Me.pnlDailyRevenue.PerformLayout()
        Me.pnlChartarea.ResumeLayout(False)
        Me.pnlMiscArea.ResumeLayout(False)
        Me.pnlOrdersInProgress.ResumeLayout(False)
        Me.pnlOrdersInProgress.PerformLayout()
        CType(Me.dgvOrdersInProgress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHighestOrderAmount.ResumeLayout(False)
        Me.pnlHighestOrderAmount.PerformLayout()
        Me.pnlBestSellingItem.ResumeLayout(False)
        Me.pnlBestSellingItem.PerformLayout()
        CType(Me.picBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblStatus3 As Label
    Friend WithEvents groupBox3 As GroupBox
    Friend WithEvents lblPrice3 As Label
    Friend WithEvents lblitemName3 As Label
    Friend WithEvents lblPrice1 As Label
    Friend WithEvents lblitemName1 As Label
    Friend WithEvents lblStatus1 As Label
    Friend WithEvents groupBox2 As GroupBox
    Friend WithEvents lblPrice2 As Label
    Friend WithEvents lblitemName2 As Label
    Friend WithEvents lblStatus2 As Label
    Friend WithEvents pnlPendingPayment As Panel
    Friend WithEvents lblPendingPayments As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvTopInventoryItems As DataGridView
    Friend WithEvents pnlPendingOrders As Panel
    Friend WithEvents lblPendingOrders As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pnlTotalOrders As Panel
    Friend WithEvents lblTotalOrdersToday As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlTotalRevenue As Panel
    Friend WithEvents lblTotalRevenueMonth As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents pnlInventory As Panel
    Friend WithEvents lblInventoryTitle As Label
    Friend WithEvents groupBox1 As GroupBox
    Friend WithEvents pnlDashboard As Panel
    Friend WithEvents pnlDailyRevenue As Panel
    Friend WithEvents pnlChartarea As Panel
    Friend WithEvents cartesianChartDailyRevenue As LiveCharts.WinForms.CartesianChart
    Friend WithEvents lblRevenueChange As Label
    Friend WithEvents lbllessthanlastweek As Label
    Friend WithEvents lblTotalRevenue As Label
    Friend WithEvents lblDailyRevenueTitle As Label
    Friend WithEvents pnlMiscArea As Panel
    Friend WithEvents pnlHighestOrderAmount As Panel
    Friend WithEvents lblOrderAmount As Label
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblHighestOrderAmountTitle As Label
    Friend WithEvents pnlBestSellingItem As Panel
    Friend WithEvents lblBestSellingItemTitle As Label
    Friend WithEvents picBox3 As PictureBox
    Friend WithEvents picBox2 As PictureBox
    Friend WithEvents picBox1 As PictureBox
    Friend WithEvents lblmsg As Label
    Friend WithEvents TimerRefresh As Timer
    Friend WithEvents pnlOrdersInProgress As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvOrdersInProgress As DataGridView
End Class
