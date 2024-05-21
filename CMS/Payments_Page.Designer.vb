<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payments_Page
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
        Me.pnlCompletedPayments = New System.Windows.Forms.Panel()
        Me.picboxCompleted = New System.Windows.Forms.PictureBox()
        Me.lblCompletedCount = New System.Windows.Forms.Label()
        Me.lblCompletedAmount = New System.Windows.Forms.Label()
        Me.lblCompletedPayments = New System.Windows.Forms.Label()
        Me.picboxCancelled = New System.Windows.Forms.PictureBox()
        Me.pnlDetailedTransactions = New System.Windows.Forms.Panel()
        Me.rbtnOrderID = New System.Windows.Forms.RadioButton()
        Me.rbtnCustomerID = New System.Windows.Forms.RadioButton()
        Me.btnAllRecord = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.pnlTransactionArea = New System.Windows.Forms.Panel()
        Me.dgvTransactionsDetails = New System.Windows.Forms.DataGridView()
        Me.cmenustripTransaction = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.completedItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PendingItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelledItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rtxtSearch = New System.Windows.Forms.RichTextBox()
        Me.lblDetailedTransactions = New System.Windows.Forms.Label()
        Me.lblCancelledCount = New System.Windows.Forms.Label()
        Me.lblCancelledAmount = New System.Windows.Forms.Label()
        Me.pnlPayments = New System.Windows.Forms.Panel()
        Me.dtpMonthly = New System.Windows.Forms.DateTimePicker()
        Me.btnRefresh = New CMS.RoundedButton()
        Me.pnlPiechart = New System.Windows.Forms.Panel()
        Me.pieChartPayments1 = New LiveCharts.WinForms.PieChart()
        Me.pnlDateFilterbtns = New System.Windows.Forms.Panel()
        Me.btnMonthly = New System.Windows.Forms.Button()
        Me.btnWeekly = New System.Windows.Forms.Button()
        Me.btnToday = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlPendingPayments = New System.Windows.Forms.Panel()
        Me.picboxPending = New System.Windows.Forms.PictureBox()
        Me.lblPendingCount = New System.Windows.Forms.Label()
        Me.lblPendingAmount = New System.Windows.Forms.Label()
        Me.lblPendingPayments = New System.Windows.Forms.Label()
        Me.pnlCanceledPayments = New System.Windows.Forms.Panel()
        Me.lblCanceledPayments = New System.Windows.Forms.Label()
        Me.pnlCompletedPayments.SuspendLayout()
        CType(Me.picboxCompleted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxCancelled, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDetailedTransactions.SuspendLayout()
        Me.pnlTransactionArea.SuspendLayout()
        CType(Me.dgvTransactionsDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmenustripTransaction.SuspendLayout()
        Me.pnlPayments.SuspendLayout()
        Me.pnlPiechart.SuspendLayout()
        Me.pnlDateFilterbtns.SuspendLayout()
        Me.pnlPendingPayments.SuspendLayout()
        CType(Me.picboxPending, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCanceledPayments.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCompletedPayments
        '
        Me.pnlCompletedPayments.BackColor = System.Drawing.Color.White
        Me.pnlCompletedPayments.Controls.Add(Me.picboxCompleted)
        Me.pnlCompletedPayments.Controls.Add(Me.lblCompletedCount)
        Me.pnlCompletedPayments.Controls.Add(Me.lblCompletedAmount)
        Me.pnlCompletedPayments.Controls.Add(Me.lblCompletedPayments)
        Me.pnlCompletedPayments.Location = New System.Drawing.Point(16, 200)
        Me.pnlCompletedPayments.Name = "pnlCompletedPayments"
        Me.pnlCompletedPayments.Size = New System.Drawing.Size(326, 151)
        Me.pnlCompletedPayments.TabIndex = 2
        '
        'picboxCompleted
        '
        Me.picboxCompleted.Image = Global.CMS.My.Resources.Resources.Completed
        Me.picboxCompleted.Location = New System.Drawing.Point(227, 49)
        Me.picboxCompleted.Name = "picboxCompleted"
        Me.picboxCompleted.Size = New System.Drawing.Size(82, 75)
        Me.picboxCompleted.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxCompleted.TabIndex = 8
        Me.picboxCompleted.TabStop = False
        '
        'lblCompletedCount
        '
        Me.lblCompletedCount.AutoSize = True
        Me.lblCompletedCount.Font = New System.Drawing.Font("Trebuchet MS", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompletedCount.Location = New System.Drawing.Point(18, 63)
        Me.lblCompletedCount.Name = "lblCompletedCount"
        Me.lblCompletedCount.Size = New System.Drawing.Size(96, 35)
        Me.lblCompletedCount.TabIndex = 6
        Me.lblCompletedCount.Text = "nofpay"
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
        'lblCompletedPayments
        '
        Me.lblCompletedPayments.AutoSize = True
        Me.lblCompletedPayments.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompletedPayments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblCompletedPayments.Location = New System.Drawing.Point(19, 23)
        Me.lblCompletedPayments.Name = "lblCompletedPayments"
        Me.lblCompletedPayments.Size = New System.Drawing.Size(202, 26)
        Me.lblCompletedPayments.TabIndex = 3
        Me.lblCompletedPayments.Text = "Completed Payments"
        '
        'picboxCancelled
        '
        Me.picboxCancelled.Image = Global.CMS.My.Resources.Resources.Cancelled
        Me.picboxCancelled.Location = New System.Drawing.Point(222, 49)
        Me.picboxCancelled.Name = "picboxCancelled"
        Me.picboxCancelled.Size = New System.Drawing.Size(82, 75)
        Me.picboxCancelled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxCancelled.TabIndex = 9
        Me.picboxCancelled.TabStop = False
        '
        'pnlDetailedTransactions
        '
        Me.pnlDetailedTransactions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlDetailedTransactions.BackColor = System.Drawing.Color.White
        Me.pnlDetailedTransactions.Controls.Add(Me.rbtnOrderID)
        Me.pnlDetailedTransactions.Controls.Add(Me.rbtnCustomerID)
        Me.pnlDetailedTransactions.Controls.Add(Me.btnAllRecord)
        Me.pnlDetailedTransactions.Controls.Add(Me.btnSearch)
        Me.pnlDetailedTransactions.Controls.Add(Me.pnlTransactionArea)
        Me.pnlDetailedTransactions.Controls.Add(Me.rtxtSearch)
        Me.pnlDetailedTransactions.Controls.Add(Me.lblDetailedTransactions)
        Me.pnlDetailedTransactions.Location = New System.Drawing.Point(16, 370)
        Me.pnlDetailedTransactions.Name = "pnlDetailedTransactions"
        Me.pnlDetailedTransactions.Size = New System.Drawing.Size(1563, 343)
        Me.pnlDetailedTransactions.TabIndex = 0
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
        Me.btnAllRecord.Size = New System.Drawing.Size(71, 40)
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
        'pnlTransactionArea
        '
        Me.pnlTransactionArea.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTransactionArea.Controls.Add(Me.dgvTransactionsDetails)
        Me.pnlTransactionArea.Location = New System.Drawing.Point(3, 96)
        Me.pnlTransactionArea.Name = "pnlTransactionArea"
        Me.pnlTransactionArea.Size = New System.Drawing.Size(1557, 244)
        Me.pnlTransactionArea.TabIndex = 7
        '
        'dgvTransactionsDetails
        '
        Me.dgvTransactionsDetails.BackgroundColor = System.Drawing.Color.White
        Me.dgvTransactionsDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransactionsDetails.ContextMenuStrip = Me.cmenustripTransaction
        Me.dgvTransactionsDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTransactionsDetails.Location = New System.Drawing.Point(0, 0)
        Me.dgvTransactionsDetails.Name = "dgvTransactionsDetails"
        Me.dgvTransactionsDetails.RowHeadersWidth = 51
        Me.dgvTransactionsDetails.RowTemplate.Height = 24
        Me.dgvTransactionsDetails.Size = New System.Drawing.Size(1557, 244)
        Me.dgvTransactionsDetails.TabIndex = 0
        '
        'cmenustripTransaction
        '
        Me.cmenustripTransaction.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmenustripTransaction.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmenustripTransaction.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.completedItem, Me.PendingItem, Me.CancelledItem})
        Me.cmenustripTransaction.Name = "cmenustripTransaction"
        Me.cmenustripTransaction.Size = New System.Drawing.Size(150, 76)
        '
        'completedItem
        '
        Me.completedItem.Name = "completedItem"
        Me.completedItem.Size = New System.Drawing.Size(149, 24)
        Me.completedItem.Text = "Completed"
        '
        'PendingItem
        '
        Me.PendingItem.Name = "PendingItem"
        Me.PendingItem.Size = New System.Drawing.Size(149, 24)
        Me.PendingItem.Text = "Pending"
        '
        'CancelledItem
        '
        Me.CancelledItem.Name = "CancelledItem"
        Me.CancelledItem.Size = New System.Drawing.Size(149, 24)
        Me.CancelledItem.Text = "Cancelled"
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
        'lblDetailedTransactions
        '
        Me.lblDetailedTransactions.AutoSize = True
        Me.lblDetailedTransactions.Font = New System.Drawing.Font("Trebuchet MS", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetailedTransactions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblDetailedTransactions.Location = New System.Drawing.Point(284, 20)
        Me.lblDetailedTransactions.Name = "lblDetailedTransactions"
        Me.lblDetailedTransactions.Size = New System.Drawing.Size(426, 35)
        Me.lblDetailedTransactions.TabIndex = 6
        Me.lblDetailedTransactions.Text = "Detailed Summary of Transactions"
        '
        'lblCancelledCount
        '
        Me.lblCancelledCount.AutoSize = True
        Me.lblCancelledCount.Font = New System.Drawing.Font("Trebuchet MS", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCancelledCount.Location = New System.Drawing.Point(23, 63)
        Me.lblCancelledCount.Name = "lblCancelledCount"
        Me.lblCancelledCount.Size = New System.Drawing.Size(96, 35)
        Me.lblCancelledCount.TabIndex = 7
        Me.lblCancelledCount.Text = "nofpay"
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
        'pnlPayments
        '
        Me.pnlPayments.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlPayments.Controls.Add(Me.dtpMonthly)
        Me.pnlPayments.Controls.Add(Me.btnRefresh)
        Me.pnlPayments.Controls.Add(Me.pnlPiechart)
        Me.pnlPayments.Controls.Add(Me.pnlDateFilterbtns)
        Me.pnlPayments.Controls.Add(Me.lblTitle)
        Me.pnlPayments.Controls.Add(Me.pnlPendingPayments)
        Me.pnlPayments.Controls.Add(Me.pnlCanceledPayments)
        Me.pnlPayments.Controls.Add(Me.pnlCompletedPayments)
        Me.pnlPayments.Controls.Add(Me.pnlDetailedTransactions)
        Me.pnlPayments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPayments.Location = New System.Drawing.Point(0, 0)
        Me.pnlPayments.Name = "pnlPayments"
        Me.pnlPayments.Size = New System.Drawing.Size(1593, 728)
        Me.pnlPayments.TabIndex = 1
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
        'pnlPiechart
        '
        Me.pnlPiechart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPiechart.BackColor = System.Drawing.Color.White
        Me.pnlPiechart.Controls.Add(Me.pieChartPayments1)
        Me.pnlPiechart.Location = New System.Drawing.Point(1049, 25)
        Me.pnlPiechart.Name = "pnlPiechart"
        Me.pnlPiechart.Size = New System.Drawing.Size(529, 325)
        Me.pnlPiechart.TabIndex = 5
        '
        'pieChartPayments1
        '
        Me.pieChartPayments1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pieChartPayments1.Location = New System.Drawing.Point(0, 0)
        Me.pieChartPayments1.Name = "pieChartPayments1"
        Me.pieChartPayments1.Size = New System.Drawing.Size(529, 325)
        Me.pieChartPayments1.TabIndex = 6
        Me.pieChartPayments1.Text = "PieChart1"
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
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Monotype Corsiva", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(17, 25)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(30, 0, 3, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(437, 60)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Summary of Payments"
        '
        'pnlPendingPayments
        '
        Me.pnlPendingPayments.BackColor = System.Drawing.Color.White
        Me.pnlPendingPayments.Controls.Add(Me.picboxPending)
        Me.pnlPendingPayments.Controls.Add(Me.lblPendingCount)
        Me.pnlPendingPayments.Controls.Add(Me.lblPendingAmount)
        Me.pnlPendingPayments.Controls.Add(Me.lblPendingPayments)
        Me.pnlPendingPayments.Location = New System.Drawing.Point(359, 200)
        Me.pnlPendingPayments.Name = "pnlPendingPayments"
        Me.pnlPendingPayments.Size = New System.Drawing.Size(326, 151)
        Me.pnlPendingPayments.TabIndex = 3
        '
        'picboxPending
        '
        Me.picboxPending.Image = Global.CMS.My.Resources.Resources.Pending
        Me.picboxPending.Location = New System.Drawing.Point(223, 49)
        Me.picboxPending.Name = "picboxPending"
        Me.picboxPending.Size = New System.Drawing.Size(82, 75)
        Me.picboxPending.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxPending.TabIndex = 10
        Me.picboxPending.TabStop = False
        '
        'lblPendingCount
        '
        Me.lblPendingCount.AutoSize = True
        Me.lblPendingCount.Font = New System.Drawing.Font("Trebuchet MS", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPendingCount.Location = New System.Drawing.Point(16, 63)
        Me.lblPendingCount.Name = "lblPendingCount"
        Me.lblPendingCount.Size = New System.Drawing.Size(96, 35)
        Me.lblPendingCount.TabIndex = 8
        Me.lblPendingCount.Text = "nofpay"
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
        'lblPendingPayments
        '
        Me.lblPendingPayments.AutoSize = True
        Me.lblPendingPayments.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPendingPayments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblPendingPayments.Location = New System.Drawing.Point(17, 23)
        Me.lblPendingPayments.Name = "lblPendingPayments"
        Me.lblPendingPayments.Size = New System.Drawing.Size(174, 26)
        Me.lblPendingPayments.TabIndex = 5
        Me.lblPendingPayments.Text = "Pending Payments"
        '
        'pnlCanceledPayments
        '
        Me.pnlCanceledPayments.BackColor = System.Drawing.Color.White
        Me.pnlCanceledPayments.Controls.Add(Me.picboxCancelled)
        Me.pnlCanceledPayments.Controls.Add(Me.lblCancelledCount)
        Me.pnlCanceledPayments.Controls.Add(Me.lblCancelledAmount)
        Me.pnlCanceledPayments.Controls.Add(Me.lblCanceledPayments)
        Me.pnlCanceledPayments.Location = New System.Drawing.Point(702, 200)
        Me.pnlCanceledPayments.Name = "pnlCanceledPayments"
        Me.pnlCanceledPayments.Size = New System.Drawing.Size(326, 151)
        Me.pnlCanceledPayments.TabIndex = 3
        '
        'lblCanceledPayments
        '
        Me.lblCanceledPayments.AutoSize = True
        Me.lblCanceledPayments.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCanceledPayments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblCanceledPayments.Location = New System.Drawing.Point(23, 23)
        Me.lblCanceledPayments.Name = "lblCanceledPayments"
        Me.lblCanceledPayments.Size = New System.Drawing.Size(193, 26)
        Me.lblCanceledPayments.TabIndex = 4
        Me.lblCanceledPayments.Text = " Canceled Payments"
        '
        'Payments_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1593, 728)
        Me.Controls.Add(Me.pnlPayments)
        Me.Name = "Payments_Page"
        Me.Text = "Payments"
        Me.pnlCompletedPayments.ResumeLayout(False)
        Me.pnlCompletedPayments.PerformLayout()
        CType(Me.picboxCompleted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxCancelled, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDetailedTransactions.ResumeLayout(False)
        Me.pnlDetailedTransactions.PerformLayout()
        Me.pnlTransactionArea.ResumeLayout(False)
        CType(Me.dgvTransactionsDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmenustripTransaction.ResumeLayout(False)
        Me.pnlPayments.ResumeLayout(False)
        Me.pnlPayments.PerformLayout()
        Me.pnlPiechart.ResumeLayout(False)
        Me.pnlDateFilterbtns.ResumeLayout(False)
        Me.pnlPendingPayments.ResumeLayout(False)
        Me.pnlPendingPayments.PerformLayout()
        CType(Me.picboxPending, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCanceledPayments.ResumeLayout(False)
        Me.pnlCanceledPayments.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlCompletedPayments As Panel
    Friend WithEvents picboxCompleted As PictureBox
    Friend WithEvents lblCompletedCount As Label
    Friend WithEvents lblCompletedAmount As Label
    Friend WithEvents lblCompletedPayments As Label
    Friend WithEvents picboxCancelled As PictureBox
    Friend WithEvents pnlDetailedTransactions As Panel
    Friend WithEvents rbtnOrderID As RadioButton
    Friend WithEvents rbtnCustomerID As RadioButton
    Friend WithEvents btnAllRecord As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents pnlTransactionArea As Panel
    Friend WithEvents dgvTransactionsDetails As DataGridView
    Friend WithEvents cmenustripTransaction As ContextMenuStrip
    Friend WithEvents completedItem As ToolStripMenuItem
    Friend WithEvents PendingItem As ToolStripMenuItem
    Friend WithEvents CancelledItem As ToolStripMenuItem
    Friend WithEvents rtxtSearch As RichTextBox
    Friend WithEvents lblDetailedTransactions As Label
    Friend WithEvents lblCancelledCount As Label
    Friend WithEvents lblCancelledAmount As Label
    Friend WithEvents pnlPayments As Panel
    Friend WithEvents dtpMonthly As DateTimePicker
    Friend WithEvents btnRefresh As RoundedButton
    Friend WithEvents pnlPiechart As Panel
    Friend WithEvents pieChartPayments1 As LiveCharts.WinForms.PieChart
    Friend WithEvents pnlDateFilterbtns As Panel
    Friend WithEvents btnMonthly As Button
    Friend WithEvents btnWeekly As Button
    Friend WithEvents btnToday As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlPendingPayments As Panel
    Friend WithEvents picboxPending As PictureBox
    Friend WithEvents lblPendingCount As Label
    Friend WithEvents lblPendingAmount As Label
    Friend WithEvents lblPendingPayments As Label
    Friend WithEvents pnlCanceledPayments As Panel
    Friend WithEvents lblCanceledPayments As Label
End Class
