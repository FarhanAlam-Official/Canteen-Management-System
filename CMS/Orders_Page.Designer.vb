<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Orders_Page
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
        Me.picboxCancelled = New System.Windows.Forms.PictureBox()
        Me.lblCanceledPayments = New System.Windows.Forms.Label()
        Me.lblPendingCount = New System.Windows.Forms.Label()
        Me.lblPendingAmount = New System.Windows.Forms.Label()
        Me.lblPendingOrders = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlPendingOrders = New System.Windows.Forms.Panel()
        Me.picboxPending = New System.Windows.Forms.PictureBox()
        Me.pnlCanceledOrders = New System.Windows.Forms.Panel()
        Me.lblCancelledCount = New System.Windows.Forms.Label()
        Me.lblCancelledAmount = New System.Windows.Forms.Label()
        Me.rbtnOrderID = New System.Windows.Forms.RadioButton()
        Me.rbtnCustomerID = New System.Windows.Forms.RadioButton()
        Me.btnAllRecord = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.pnlOrdersArea = New System.Windows.Forms.Panel()
        Me.dgvOrdersDetails = New System.Windows.Forms.DataGridView()
        Me.ctxmenuOrders = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.completedItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PendingItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelledItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnMonthly = New System.Windows.Forms.Button()
        Me.btnWeekly = New System.Windows.Forms.Button()
        Me.btnToday = New System.Windows.Forms.Button()
        Me.pnlDateFilterbtns = New System.Windows.Forms.Panel()
        Me.pieChartOrders = New LiveCharts.WinForms.PieChart()
        Me.dtpMonthly = New System.Windows.Forms.DateTimePicker()
        Me.pnlPiechart = New System.Windows.Forms.Panel()
        Me.rtxtSearch = New System.Windows.Forms.RichTextBox()
        Me.lblDetailedOrders = New System.Windows.Forms.Label()
        Me.pnlDetailedOrders = New System.Windows.Forms.Panel()
        Me.picboxCompleted = New System.Windows.Forms.PictureBox()
        Me.lblCompletedCount = New System.Windows.Forms.Label()
        Me.lblCompletedAmount = New System.Windows.Forms.Label()
        Me.lblCompletedOrders = New System.Windows.Forms.Label()
        Me.pnlCompletedOrders = New System.Windows.Forms.Panel()
        Me.pnlOrders = New System.Windows.Forms.Panel()
        Me.btnRefresh = New CMS.RoundedButton()
        CType(Me.picboxCancelled, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPendingOrders.SuspendLayout()
        CType(Me.picboxPending, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCanceledOrders.SuspendLayout()
        Me.pnlOrdersArea.SuspendLayout()
        CType(Me.dgvOrdersDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctxmenuOrders.SuspendLayout()
        Me.pnlDateFilterbtns.SuspendLayout()
        Me.pnlPiechart.SuspendLayout()
        Me.pnlDetailedOrders.SuspendLayout()
        CType(Me.picboxCompleted, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCompletedOrders.SuspendLayout()
        Me.pnlOrders.SuspendLayout()
        Me.SuspendLayout()
        '
        'picboxCancelled
        '
        Me.picboxCancelled.Image = Global.CMS.My.Resources.Resources.Cancelled
        Me.picboxCancelled.Location = New System.Drawing.Point(222, 40)
        Me.picboxCancelled.Name = "picboxCancelled"
        Me.picboxCancelled.Size = New System.Drawing.Size(82, 75)
        Me.picboxCancelled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxCancelled.TabIndex = 8
        Me.picboxCancelled.TabStop = False
        '
        'lblCanceledPayments
        '
        Me.lblCanceledPayments.AutoSize = True
        Me.lblCanceledPayments.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCanceledPayments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblCanceledPayments.Location = New System.Drawing.Point(23, 23)
        Me.lblCanceledPayments.Name = "lblCanceledPayments"
        Me.lblCanceledPayments.Size = New System.Drawing.Size(166, 26)
        Me.lblCanceledPayments.TabIndex = 4
        Me.lblCanceledPayments.Text = " Canceled Orders"
        '
        'lblPendingCount
        '
        Me.lblPendingCount.AutoSize = True
        Me.lblPendingCount.Font = New System.Drawing.Font("Trebuchet MS", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPendingCount.Location = New System.Drawing.Point(16, 63)
        Me.lblPendingCount.Name = "lblPendingCount"
        Me.lblPendingCount.Size = New System.Drawing.Size(98, 35)
        Me.lblPendingCount.TabIndex = 8
        Me.lblPendingCount.Text = "nofOrd"
        Me.lblPendingCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPendingAmount
        '
        Me.lblPendingAmount.AutoSize = True
        Me.lblPendingAmount.Font = New System.Drawing.Font("Trebuchet MS", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPendingAmount.Location = New System.Drawing.Point(18, 113)
        Me.lblPendingAmount.Name = "lblPendingAmount"
        Me.lblPendingAmount.Size = New System.Drawing.Size(36, 24)
        Me.lblPendingAmount.TabIndex = 6
        Me.lblPendingAmount.Text = "Rs."
        Me.lblPendingAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPendingOrders
        '
        Me.lblPendingOrders.AutoSize = True
        Me.lblPendingOrders.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPendingOrders.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblPendingOrders.Location = New System.Drawing.Point(17, 23)
        Me.lblPendingOrders.Name = "lblPendingOrders"
        Me.lblPendingOrders.Size = New System.Drawing.Size(147, 26)
        Me.lblPendingOrders.TabIndex = 5
        Me.lblPendingOrders.Text = "Pending Orders"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Monotype Corsiva", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(17, 25)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(30, 0, 3, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(379, 60)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Summary of Orders"
        '
        'pnlPendingOrders
        '
        Me.pnlPendingOrders.BackColor = System.Drawing.Color.White
        Me.pnlPendingOrders.Controls.Add(Me.picboxPending)
        Me.pnlPendingOrders.Controls.Add(Me.lblPendingCount)
        Me.pnlPendingOrders.Controls.Add(Me.lblPendingAmount)
        Me.pnlPendingOrders.Controls.Add(Me.lblPendingOrders)
        Me.pnlPendingOrders.Location = New System.Drawing.Point(359, 200)
        Me.pnlPendingOrders.Name = "pnlPendingOrders"
        Me.pnlPendingOrders.Size = New System.Drawing.Size(326, 151)
        Me.pnlPendingOrders.TabIndex = 3
        '
        'picboxPending
        '
        Me.picboxPending.Image = Global.CMS.My.Resources.Resources.Pending
        Me.picboxPending.Location = New System.Drawing.Point(223, 40)
        Me.picboxPending.Name = "picboxPending"
        Me.picboxPending.Size = New System.Drawing.Size(82, 75)
        Me.picboxPending.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxPending.TabIndex = 9
        Me.picboxPending.TabStop = False
        '
        'pnlCanceledOrders
        '
        Me.pnlCanceledOrders.BackColor = System.Drawing.Color.White
        Me.pnlCanceledOrders.Controls.Add(Me.picboxCancelled)
        Me.pnlCanceledOrders.Controls.Add(Me.lblCancelledCount)
        Me.pnlCanceledOrders.Controls.Add(Me.lblCancelledAmount)
        Me.pnlCanceledOrders.Controls.Add(Me.lblCanceledPayments)
        Me.pnlCanceledOrders.Location = New System.Drawing.Point(702, 200)
        Me.pnlCanceledOrders.Name = "pnlCanceledOrders"
        Me.pnlCanceledOrders.Size = New System.Drawing.Size(326, 151)
        Me.pnlCanceledOrders.TabIndex = 3
        '
        'lblCancelledCount
        '
        Me.lblCancelledCount.AutoSize = True
        Me.lblCancelledCount.Font = New System.Drawing.Font("Trebuchet MS", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCancelledCount.Location = New System.Drawing.Point(23, 63)
        Me.lblCancelledCount.Name = "lblCancelledCount"
        Me.lblCancelledCount.Size = New System.Drawing.Size(98, 35)
        Me.lblCancelledCount.TabIndex = 7
        Me.lblCancelledCount.Text = "nofOrd"
        Me.lblCancelledCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCancelledAmount
        '
        Me.lblCancelledAmount.AutoSize = True
        Me.lblCancelledAmount.Font = New System.Drawing.Font("Trebuchet MS", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCancelledAmount.Location = New System.Drawing.Point(24, 113)
        Me.lblCancelledAmount.Name = "lblCancelledAmount"
        Me.lblCancelledAmount.Size = New System.Drawing.Size(36, 24)
        Me.lblCancelledAmount.TabIndex = 7
        Me.lblCancelledAmount.Text = "Rs."
        Me.lblCancelledAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rbtnOrderID
        '
        Me.rbtnOrderID.AutoSize = True
        Me.rbtnOrderID.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnOrderID.Location = New System.Drawing.Point(1150, 58)
        Me.rbtnOrderID.Name = "rbtnOrderID"
        Me.rbtnOrderID.Size = New System.Drawing.Size(78, 22)
        Me.rbtnOrderID.TabIndex = 12
        Me.rbtnOrderID.TabStop = True
        Me.rbtnOrderID.Text = "Order ID"
        Me.rbtnOrderID.UseVisualStyleBackColor = True
        '
        'rbtnCustomerID
        '
        Me.rbtnCustomerID.AutoSize = True
        Me.rbtnCustomerID.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnCustomerID.Location = New System.Drawing.Point(990, 58)
        Me.rbtnCustomerID.Name = "rbtnCustomerID"
        Me.rbtnCustomerID.Size = New System.Drawing.Size(101, 22)
        Me.rbtnCustomerID.TabIndex = 11
        Me.rbtnCustomerID.TabStop = True
        Me.rbtnCustomerID.Text = "Customer ID"
        Me.rbtnCustomerID.UseVisualStyleBackColor = True
        '
        'btnAllRecord
        '
        Me.btnAllRecord.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAllRecord.BackColor = System.Drawing.Color.White
        Me.btnAllRecord.Font = New System.Drawing.Font("Trebuchet MS", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAllRecord.Location = New System.Drawing.Point(1442, 12)
        Me.btnAllRecord.Name = "btnAllRecord"
        Me.btnAllRecord.Size = New System.Drawing.Size(82, 40)
        Me.btnAllRecord.TabIndex = 10
        Me.btnAllRecord.Text = "Show All Records"
        Me.btnAllRecord.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImage = Global.CMS.My.Resources.Resources.SearchImage
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.Location = New System.Drawing.Point(1370, 11)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(46, 41)
        Me.btnSearch.TabIndex = 9
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'pnlOrdersArea
        '
        Me.pnlOrdersArea.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlOrdersArea.Controls.Add(Me.dgvOrdersDetails)
        Me.pnlOrdersArea.Location = New System.Drawing.Point(3, 96)
        Me.pnlOrdersArea.Name = "pnlOrdersArea"
        Me.pnlOrdersArea.Size = New System.Drawing.Size(1557, 244)
        Me.pnlOrdersArea.TabIndex = 7
        '
        'dgvOrdersDetails
        '
        Me.dgvOrdersDetails.BackgroundColor = System.Drawing.Color.White
        Me.dgvOrdersDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrdersDetails.ContextMenuStrip = Me.ctxmenuOrders
        Me.dgvOrdersDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOrdersDetails.Location = New System.Drawing.Point(0, 0)
        Me.dgvOrdersDetails.Name = "dgvOrdersDetails"
        Me.dgvOrdersDetails.RowHeadersWidth = 51
        Me.dgvOrdersDetails.RowTemplate.Height = 24
        Me.dgvOrdersDetails.Size = New System.Drawing.Size(1557, 244)
        Me.dgvOrdersDetails.TabIndex = 0
        '
        'ctxmenuOrders
        '
        Me.ctxmenuOrders.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctxmenuOrders.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ctxmenuOrders.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.completedItem, Me.PendingItem, Me.CancelledItem})
        Me.ctxmenuOrders.Name = "cmenustripTransaction"
        Me.ctxmenuOrders.Size = New System.Drawing.Size(211, 104)
        '
        'completedItem
        '
        Me.completedItem.Name = "completedItem"
        Me.completedItem.Size = New System.Drawing.Size(210, 24)
        Me.completedItem.Text = "Completed"
        '
        'PendingItem
        '
        Me.PendingItem.Name = "PendingItem"
        Me.PendingItem.Size = New System.Drawing.Size(210, 24)
        Me.PendingItem.Text = "Pending"
        '
        'CancelledItem
        '
        Me.CancelledItem.Name = "CancelledItem"
        Me.CancelledItem.Size = New System.Drawing.Size(210, 24)
        Me.CancelledItem.Text = "Cancelled"
        '
        'btnMonthly
        '
        Me.btnMonthly.BackColor = System.Drawing.Color.White
        Me.btnMonthly.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMonthly.Location = New System.Drawing.Point(10, 5)
        Me.btnMonthly.Name = "btnMonthly"
        Me.btnMonthly.Size = New System.Drawing.Size(122, 48)
        Me.btnMonthly.TabIndex = 2
        Me.btnMonthly.Text = "Monthly"
        Me.btnMonthly.UseVisualStyleBackColor = False
        '
        'btnWeekly
        '
        Me.btnWeekly.BackColor = System.Drawing.Color.White
        Me.btnWeekly.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWeekly.Location = New System.Drawing.Point(140, 5)
        Me.btnWeekly.Name = "btnWeekly"
        Me.btnWeekly.Size = New System.Drawing.Size(122, 48)
        Me.btnWeekly.TabIndex = 1
        Me.btnWeekly.Text = "Weekly"
        Me.btnWeekly.UseVisualStyleBackColor = False
        '
        'btnToday
        '
        Me.btnToday.BackColor = System.Drawing.Color.White
        Me.btnToday.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToday.Location = New System.Drawing.Point(268, 5)
        Me.btnToday.Name = "btnToday"
        Me.btnToday.Size = New System.Drawing.Size(122, 48)
        Me.btnToday.TabIndex = 0
        Me.btnToday.Text = "Today"
        Me.btnToday.UseVisualStyleBackColor = False
        '
        'pnlDateFilterbtns
        '
        Me.pnlDateFilterbtns.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlDateFilterbtns.Controls.Add(Me.btnMonthly)
        Me.pnlDateFilterbtns.Controls.Add(Me.btnWeekly)
        Me.pnlDateFilterbtns.Controls.Add(Me.btnToday)
        Me.pnlDateFilterbtns.Location = New System.Drawing.Point(631, 26)
        Me.pnlDateFilterbtns.Name = "pnlDateFilterbtns"
        Me.pnlDateFilterbtns.Size = New System.Drawing.Size(397, 59)
        Me.pnlDateFilterbtns.TabIndex = 4
        '
        'pieChartOrders
        '
        Me.pieChartOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pieChartOrders.Location = New System.Drawing.Point(0, 0)
        Me.pieChartOrders.Name = "pieChartOrders"
        Me.pieChartOrders.Size = New System.Drawing.Size(529, 325)
        Me.pieChartOrders.TabIndex = 6
        Me.pieChartOrders.Text = "PieChart1"
        '
        'dtpMonthly
        '
        Me.dtpMonthly.CustomFormat = "MMMM"
        Me.dtpMonthly.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpMonthly.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonthly.Location = New System.Drawing.Point(641, 91)
        Me.dtpMonthly.Name = "dtpMonthly"
        Me.dtpMonthly.Size = New System.Drawing.Size(121, 27)
        Me.dtpMonthly.TabIndex = 7
        Me.dtpMonthly.Visible = False
        '
        'pnlPiechart
        '
        Me.pnlPiechart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPiechart.BackColor = System.Drawing.Color.White
        Me.pnlPiechart.Controls.Add(Me.pieChartOrders)
        Me.pnlPiechart.Location = New System.Drawing.Point(1049, 25)
        Me.pnlPiechart.Name = "pnlPiechart"
        Me.pnlPiechart.Size = New System.Drawing.Size(529, 325)
        Me.pnlPiechart.TabIndex = 5
        '
        'rtxtSearch
        '
        Me.rtxtSearch.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtSearch.Location = New System.Drawing.Point(954, 12)
        Me.rtxtSearch.Name = "rtxtSearch"
        Me.rtxtSearch.Size = New System.Drawing.Size(462, 40)
        Me.rtxtSearch.TabIndex = 8
        Me.rtxtSearch.Text = ""
        '
        'lblDetailedOrders
        '
        Me.lblDetailedOrders.AutoSize = True
        Me.lblDetailedOrders.Font = New System.Drawing.Font("Trebuchet MS", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetailedOrders.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblDetailedOrders.Location = New System.Drawing.Point(231, 15)
        Me.lblDetailedOrders.Name = "lblDetailedOrders"
        Me.lblDetailedOrders.Size = New System.Drawing.Size(385, 37)
        Me.lblDetailedOrders.TabIndex = 6
        Me.lblDetailedOrders.Text = "Detailed Summary of Orders"
        '
        'pnlDetailedOrders
        '
        Me.pnlDetailedOrders.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlDetailedOrders.BackColor = System.Drawing.Color.White
        Me.pnlDetailedOrders.Controls.Add(Me.rbtnOrderID)
        Me.pnlDetailedOrders.Controls.Add(Me.rbtnCustomerID)
        Me.pnlDetailedOrders.Controls.Add(Me.btnAllRecord)
        Me.pnlDetailedOrders.Controls.Add(Me.btnSearch)
        Me.pnlDetailedOrders.Controls.Add(Me.pnlOrdersArea)
        Me.pnlDetailedOrders.Controls.Add(Me.rtxtSearch)
        Me.pnlDetailedOrders.Controls.Add(Me.lblDetailedOrders)
        Me.pnlDetailedOrders.Location = New System.Drawing.Point(16, 370)
        Me.pnlDetailedOrders.Name = "pnlDetailedOrders"
        Me.pnlDetailedOrders.Size = New System.Drawing.Size(1563, 343)
        Me.pnlDetailedOrders.TabIndex = 0
        '
        'picboxCompleted
        '
        Me.picboxCompleted.Image = Global.CMS.My.Resources.Resources.Completed
        Me.picboxCompleted.Location = New System.Drawing.Point(215, 40)
        Me.picboxCompleted.Name = "picboxCompleted"
        Me.picboxCompleted.Size = New System.Drawing.Size(82, 75)
        Me.picboxCompleted.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxCompleted.TabIndex = 7
        Me.picboxCompleted.TabStop = False
        '
        'lblCompletedCount
        '
        Me.lblCompletedCount.AutoSize = True
        Me.lblCompletedCount.Font = New System.Drawing.Font("Trebuchet MS", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompletedCount.Location = New System.Drawing.Point(18, 63)
        Me.lblCompletedCount.Name = "lblCompletedCount"
        Me.lblCompletedCount.Size = New System.Drawing.Size(98, 35)
        Me.lblCompletedCount.TabIndex = 6
        Me.lblCompletedCount.Text = "nofOrd"
        Me.lblCompletedCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCompletedAmount
        '
        Me.lblCompletedAmount.AutoSize = True
        Me.lblCompletedAmount.Font = New System.Drawing.Font("Trebuchet MS", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompletedAmount.Location = New System.Drawing.Point(20, 113)
        Me.lblCompletedAmount.Name = "lblCompletedAmount"
        Me.lblCompletedAmount.Size = New System.Drawing.Size(36, 24)
        Me.lblCompletedAmount.TabIndex = 5
        Me.lblCompletedAmount.Text = "Rs."
        Me.lblCompletedAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCompletedOrders
        '
        Me.lblCompletedOrders.AutoSize = True
        Me.lblCompletedOrders.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompletedOrders.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblCompletedOrders.Location = New System.Drawing.Point(19, 23)
        Me.lblCompletedOrders.Name = "lblCompletedOrders"
        Me.lblCompletedOrders.Size = New System.Drawing.Size(175, 26)
        Me.lblCompletedOrders.TabIndex = 3
        Me.lblCompletedOrders.Text = "Completed Orders"
        '
        'pnlCompletedOrders
        '
        Me.pnlCompletedOrders.BackColor = System.Drawing.Color.White
        Me.pnlCompletedOrders.Controls.Add(Me.picboxCompleted)
        Me.pnlCompletedOrders.Controls.Add(Me.lblCompletedCount)
        Me.pnlCompletedOrders.Controls.Add(Me.lblCompletedAmount)
        Me.pnlCompletedOrders.Controls.Add(Me.lblCompletedOrders)
        Me.pnlCompletedOrders.Location = New System.Drawing.Point(16, 200)
        Me.pnlCompletedOrders.Name = "pnlCompletedOrders"
        Me.pnlCompletedOrders.Size = New System.Drawing.Size(326, 151)
        Me.pnlCompletedOrders.TabIndex = 2
        '
        'pnlOrders
        '
        Me.pnlOrders.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlOrders.Controls.Add(Me.dtpMonthly)
        Me.pnlOrders.Controls.Add(Me.btnRefresh)
        Me.pnlOrders.Controls.Add(Me.pnlPiechart)
        Me.pnlOrders.Controls.Add(Me.pnlDateFilterbtns)
        Me.pnlOrders.Controls.Add(Me.lblTitle)
        Me.pnlOrders.Controls.Add(Me.pnlPendingOrders)
        Me.pnlOrders.Controls.Add(Me.pnlCanceledOrders)
        Me.pnlOrders.Controls.Add(Me.pnlCompletedOrders)
        Me.pnlOrders.Controls.Add(Me.pnlDetailedOrders)
        Me.pnlOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlOrders.Location = New System.Drawing.Point(0, 0)
        Me.pnlOrders.Name = "pnlOrders"
        Me.pnlOrders.Size = New System.Drawing.Size(1593, 728)
        Me.pnlOrders.TabIndex = 2
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnRefresh.CornerRadius = 40
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnRefresh.FlatAppearance.BorderSize = 10
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnRefresh.Location = New System.Drawing.Point(40, 106)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(174, 51)
        Me.btnRefresh.TabIndex = 6
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'Orders_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1593, 728)
        Me.Controls.Add(Me.pnlOrders)
        Me.Name = "Orders_Page"
        Me.Text = "Orders_Page"
        CType(Me.picboxCancelled, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPendingOrders.ResumeLayout(False)
        Me.pnlPendingOrders.PerformLayout()
        CType(Me.picboxPending, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCanceledOrders.ResumeLayout(False)
        Me.pnlCanceledOrders.PerformLayout()
        Me.pnlOrdersArea.ResumeLayout(False)
        CType(Me.dgvOrdersDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctxmenuOrders.ResumeLayout(False)
        Me.pnlDateFilterbtns.ResumeLayout(False)
        Me.pnlPiechart.ResumeLayout(False)
        Me.pnlDetailedOrders.ResumeLayout(False)
        Me.pnlDetailedOrders.PerformLayout()
        CType(Me.picboxCompleted, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCompletedOrders.ResumeLayout(False)
        Me.pnlCompletedOrders.PerformLayout()
        Me.pnlOrders.ResumeLayout(False)
        Me.pnlOrders.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picboxCancelled As PictureBox
    Friend WithEvents lblCanceledPayments As Label
    Friend WithEvents lblPendingCount As Label
    Friend WithEvents lblPendingAmount As Label
    Friend WithEvents lblPendingOrders As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlPendingOrders As Panel
    Friend WithEvents picboxPending As PictureBox
    Friend WithEvents pnlCanceledOrders As Panel
    Friend WithEvents lblCancelledCount As Label
    Friend WithEvents lblCancelledAmount As Label
    Friend WithEvents rbtnOrderID As RadioButton
    Friend WithEvents rbtnCustomerID As RadioButton
    Friend WithEvents btnAllRecord As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents pnlOrdersArea As Panel
    Friend WithEvents dgvOrdersDetails As DataGridView
    Friend WithEvents ctxmenuOrders As ContextMenuStrip
    Friend WithEvents completedItem As ToolStripMenuItem
    Friend WithEvents PendingItem As ToolStripMenuItem
    Friend WithEvents CancelledItem As ToolStripMenuItem
    Friend WithEvents btnMonthly As Button
    Friend WithEvents btnWeekly As Button
    Friend WithEvents btnToday As Button
    Friend WithEvents pnlDateFilterbtns As Panel
    Friend WithEvents pieChartOrders As LiveCharts.WinForms.PieChart
    Friend WithEvents dtpMonthly As DateTimePicker
    Friend WithEvents pnlPiechart As Panel
    Friend WithEvents rtxtSearch As RichTextBox
    Friend WithEvents lblDetailedOrders As Label
    Friend WithEvents btnRefresh As RoundedButton
    Friend WithEvents pnlDetailedOrders As Panel
    Friend WithEvents picboxCompleted As PictureBox
    Friend WithEvents lblCompletedCount As Label
    Friend WithEvents lblCompletedAmount As Label
    Friend WithEvents lblCompletedOrders As Label
    Friend WithEvents pnlCompletedOrders As Panel
    Friend WithEvents pnlOrders As Panel
End Class
