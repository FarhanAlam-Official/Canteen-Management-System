<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Analytics_Page
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
        Me.pnlPaymentMode = New System.Windows.Forms.Panel()
        Me.dtpPaymentDate = New System.Windows.Forms.DateTimePicker()
        Me.lblPaymentModeFilter = New System.Windows.Forms.Label()
        Me.cmbPaymentModeFilter = New System.Windows.Forms.ComboBox()
        Me.lblPaymentMode = New System.Windows.Forms.Label()
        Me.pieChartPaymentSummary = New LiveCharts.WinForms.PieChart()
        Me.pnlUserInformation = New System.Windows.Forms.Panel()
        Me.lblUserInformation = New System.Windows.Forms.Label()
        Me.lblUserInformationFilter = New System.Windows.Forms.Label()
        Me.cmbUserFilter = New System.Windows.Forms.ComboBox()
        Me.PieChartUserSummary = New LiveCharts.WinForms.PieChart()
        Me.pnlOrderSummary = New System.Windows.Forms.Panel()
        Me.chartOrderSummary = New LiveCharts.WinForms.CartesianChart()
        Me.lblOrdersummary = New System.Windows.Forms.Label()
        Me.pnlQuartessalesGrowth = New System.Windows.Forms.Panel()
        Me.lblMonthlysalesGrowth = New System.Windows.Forms.Label()
        Me.chartMonthlySales = New LiveCharts.WinForms.CartesianChart()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chartSalesByCategory = New LiveCharts.WinForms.CartesianChart()
        Me.cmbTimeFilter = New System.Windows.Forms.ComboBox()
        Me.dtpSalesCategoryDate = New System.Windows.Forms.DateTimePicker()
        Me.lblCategoryfilter = New System.Windows.Forms.Label()
        Me.pnlSalesbyCategory = New System.Windows.Forms.Panel()
        Me.pnlInsights = New System.Windows.Forms.Panel()
        Me.PieChartOrderChunRate = New LiveCharts.WinForms.PieChart()
        Me.lblInsights = New System.Windows.Forms.Label()
        Me.TimerRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.pnlPaymentMode.SuspendLayout()
        Me.pnlUserInformation.SuspendLayout()
        Me.pnlOrderSummary.SuspendLayout()
        Me.pnlQuartessalesGrowth.SuspendLayout()
        Me.pnlSalesbyCategory.SuspendLayout()
        Me.pnlInsights.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlPaymentMode
        '
        Me.pnlPaymentMode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlPaymentMode.BackColor = System.Drawing.Color.White
        Me.pnlPaymentMode.Controls.Add(Me.dtpPaymentDate)
        Me.pnlPaymentMode.Controls.Add(Me.lblPaymentModeFilter)
        Me.pnlPaymentMode.Controls.Add(Me.cmbPaymentModeFilter)
        Me.pnlPaymentMode.Controls.Add(Me.lblPaymentMode)
        Me.pnlPaymentMode.Controls.Add(Me.pieChartPaymentSummary)
        Me.pnlPaymentMode.Location = New System.Drawing.Point(0, 504)
        Me.pnlPaymentMode.Name = "pnlPaymentMode"
        Me.pnlPaymentMode.Size = New System.Drawing.Size(530, 326)
        Me.pnlPaymentMode.TabIndex = 12
        '
        'dtpPaymentDate
        '
        Me.dtpPaymentDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpPaymentDate.CustomFormat = "MMMM yyyy"
        Me.dtpPaymentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPaymentDate.Location = New System.Drawing.Point(392, 72)
        Me.dtpPaymentDate.Name = "dtpPaymentDate"
        Me.dtpPaymentDate.Size = New System.Drawing.Size(121, 26)
        Me.dtpPaymentDate.TabIndex = 11
        Me.dtpPaymentDate.Visible = False
        '
        'lblPaymentModeFilter
        '
        Me.lblPaymentModeFilter.AutoSize = True
        Me.lblPaymentModeFilter.Font = New System.Drawing.Font("Trebuchet MS", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentModeFilter.ForeColor = System.Drawing.Color.DarkGray
        Me.lblPaymentModeFilter.Location = New System.Drawing.Point(419, 6)
        Me.lblPaymentModeFilter.Name = "lblPaymentModeFilter"
        Me.lblPaymentModeFilter.Size = New System.Drawing.Size(56, 24)
        Me.lblPaymentModeFilter.TabIndex = 13
        Me.lblPaymentModeFilter.Text = "Filter"
        '
        'cmbPaymentModeFilter
        '
        Me.cmbPaymentModeFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPaymentModeFilter.FormattingEnabled = True
        Me.cmbPaymentModeFilter.Items.AddRange(New Object() {"Today", "Weekly", "Monthly", "Yearly"})
        Me.cmbPaymentModeFilter.Location = New System.Drawing.Point(392, 31)
        Me.cmbPaymentModeFilter.Name = "cmbPaymentModeFilter"
        Me.cmbPaymentModeFilter.Size = New System.Drawing.Size(121, 28)
        Me.cmbPaymentModeFilter.TabIndex = 5
        Me.cmbPaymentModeFilter.Text = "Today"
        '
        'lblPaymentMode
        '
        Me.lblPaymentMode.AutoSize = True
        Me.lblPaymentMode.Font = New System.Drawing.Font("Trebuchet MS", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentMode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblPaymentMode.Location = New System.Drawing.Point(51, 19)
        Me.lblPaymentMode.Name = "lblPaymentMode"
        Me.lblPaymentMode.Size = New System.Drawing.Size(169, 29)
        Me.lblPaymentMode.TabIndex = 3
        Me.lblPaymentMode.Text = "Payment Mode"
        '
        'pieChartPaymentSummary
        '
        Me.pieChartPaymentSummary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pieChartPaymentSummary.BackColor = System.Drawing.Color.Black
        Me.pieChartPaymentSummary.Location = New System.Drawing.Point(0, 72)
        Me.pieChartPaymentSummary.Name = "pieChartPaymentSummary"
        Me.pieChartPaymentSummary.Size = New System.Drawing.Size(530, 254)
        Me.pieChartPaymentSummary.TabIndex = 14
        Me.pieChartPaymentSummary.Text = "PieChart2"
        '
        'pnlUserInformation
        '
        Me.pnlUserInformation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlUserInformation.BackColor = System.Drawing.Color.White
        Me.pnlUserInformation.Controls.Add(Me.lblUserInformation)
        Me.pnlUserInformation.Controls.Add(Me.lblUserInformationFilter)
        Me.pnlUserInformation.Controls.Add(Me.cmbUserFilter)
        Me.pnlUserInformation.Controls.Add(Me.PieChartUserSummary)
        Me.pnlUserInformation.Location = New System.Drawing.Point(545, 504)
        Me.pnlUserInformation.Name = "pnlUserInformation"
        Me.pnlUserInformation.Size = New System.Drawing.Size(540, 326)
        Me.pnlUserInformation.TabIndex = 14
        '
        'lblUserInformation
        '
        Me.lblUserInformation.AutoSize = True
        Me.lblUserInformation.Font = New System.Drawing.Font("Trebuchet MS", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserInformation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblUserInformation.Location = New System.Drawing.Point(57, 19)
        Me.lblUserInformation.Name = "lblUserInformation"
        Me.lblUserInformation.Size = New System.Drawing.Size(195, 29)
        Me.lblUserInformation.TabIndex = 3
        Me.lblUserInformation.Text = "User Information"
        '
        'lblUserInformationFilter
        '
        Me.lblUserInformationFilter.AutoSize = True
        Me.lblUserInformationFilter.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserInformationFilter.ForeColor = System.Drawing.Color.DarkGray
        Me.lblUserInformationFilter.Location = New System.Drawing.Point(435, 6)
        Me.lblUserInformationFilter.Name = "lblUserInformationFilter"
        Me.lblUserInformationFilter.Size = New System.Drawing.Size(52, 23)
        Me.lblUserInformationFilter.TabIndex = 8
        Me.lblUserInformationFilter.Text = "Filter"
        '
        'cmbUserFilter
        '
        Me.cmbUserFilter.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUserFilter.FormattingEnabled = True
        Me.cmbUserFilter.Items.AddRange(New Object() {"Status", "Age_Group", "Gender", "User_Type", "Creation_Period"})
        Me.cmbUserFilter.Location = New System.Drawing.Point(402, 35)
        Me.cmbUserFilter.Name = "cmbUserFilter"
        Me.cmbUserFilter.Size = New System.Drawing.Size(121, 31)
        Me.cmbUserFilter.TabIndex = 6
        Me.cmbUserFilter.Text = "Status"
        '
        'PieChartUserSummary
        '
        Me.PieChartUserSummary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PieChartUserSummary.BackColor = System.Drawing.Color.Black
        Me.PieChartUserSummary.Location = New System.Drawing.Point(0, 72)
        Me.PieChartUserSummary.Name = "PieChartUserSummary"
        Me.PieChartUserSummary.Size = New System.Drawing.Size(540, 254)
        Me.PieChartUserSummary.TabIndex = 1
        Me.PieChartUserSummary.Text = "PieChart2"
        '
        'pnlOrderSummary
        '
        Me.pnlOrderSummary.BackColor = System.Drawing.Color.White
        Me.pnlOrderSummary.Controls.Add(Me.chartOrderSummary)
        Me.pnlOrderSummary.Controls.Add(Me.lblOrdersummary)
        Me.pnlOrderSummary.Location = New System.Drawing.Point(1104, 76)
        Me.pnlOrderSummary.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.pnlOrderSummary.Name = "pnlOrderSummary"
        Me.pnlOrderSummary.Size = New System.Drawing.Size(569, 400)
        Me.pnlOrderSummary.TabIndex = 17
        '
        'chartOrderSummary
        '
        Me.chartOrderSummary.BackColor = System.Drawing.Color.White
        Me.chartOrderSummary.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.chartOrderSummary.Location = New System.Drawing.Point(0, 115)
        Me.chartOrderSummary.Name = "chartOrderSummary"
        Me.chartOrderSummary.Size = New System.Drawing.Size(569, 285)
        Me.chartOrderSummary.TabIndex = 3
        Me.chartOrderSummary.Text = "CartesianChart2"
        '
        'lblOrdersummary
        '
        Me.lblOrdersummary.Font = New System.Drawing.Font("Trebuchet MS", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrdersummary.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblOrdersummary.Location = New System.Drawing.Point(30, 15)
        Me.lblOrdersummary.Name = "lblOrdersummary"
        Me.lblOrdersummary.Size = New System.Drawing.Size(189, 29)
        Me.lblOrdersummary.TabIndex = 2
        Me.lblOrdersummary.Text = "Orders Summary"
        '
        'pnlQuartessalesGrowth
        '
        Me.pnlQuartessalesGrowth.BackColor = System.Drawing.Color.White
        Me.pnlQuartessalesGrowth.Controls.Add(Me.lblMonthlysalesGrowth)
        Me.pnlQuartessalesGrowth.Controls.Add(Me.chartMonthlySales)
        Me.pnlQuartessalesGrowth.Location = New System.Drawing.Point(545, 76)
        Me.pnlQuartessalesGrowth.Name = "pnlQuartessalesGrowth"
        Me.pnlQuartessalesGrowth.Size = New System.Drawing.Size(540, 400)
        Me.pnlQuartessalesGrowth.TabIndex = 16
        '
        'lblMonthlysalesGrowth
        '
        Me.lblMonthlysalesGrowth.AutoSize = True
        Me.lblMonthlysalesGrowth.Font = New System.Drawing.Font("Trebuchet MS", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthlysalesGrowth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblMonthlysalesGrowth.Location = New System.Drawing.Point(60, 15)
        Me.lblMonthlysalesGrowth.Name = "lblMonthlysalesGrowth"
        Me.lblMonthlysalesGrowth.Size = New System.Drawing.Size(246, 29)
        Me.lblMonthlysalesGrowth.TabIndex = 3
        Me.lblMonthlysalesGrowth.Text = "Monthly Sales Growth"
        '
        'chartMonthlySales
        '
        Me.chartMonthlySales.BackColor = System.Drawing.Color.White
        Me.chartMonthlySales.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.chartMonthlySales.Location = New System.Drawing.Point(0, 114)
        Me.chartMonthlySales.Name = "chartMonthlySales"
        Me.chartMonthlySales.Size = New System.Drawing.Size(540, 286)
        Me.chartMonthlySales.TabIndex = 1
        Me.chartMonthlySales.Text = "CartesianChart2"
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Monotype Corsiva", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(633, -2)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(30, 0, 3, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(286, 60)
        Me.lblTitle.TabIndex = 13
        Me.lblTitle.Text = "Analytic Page"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(76, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(203, 29)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Sales by Category"
        '
        'chartSalesByCategory
        '
        Me.chartSalesByCategory.BackColor = System.Drawing.Color.White
        Me.chartSalesByCategory.BackColorTransparent = True
        Me.chartSalesByCategory.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.chartSalesByCategory.Location = New System.Drawing.Point(0, 114)
        Me.chartSalesByCategory.Name = "chartSalesByCategory"
        Me.chartSalesByCategory.Size = New System.Drawing.Size(530, 286)
        Me.chartSalesByCategory.TabIndex = 4
        Me.chartSalesByCategory.Text = "CartesianChart1"
        '
        'cmbTimeFilter
        '
        Me.cmbTimeFilter.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTimeFilter.FormattingEnabled = True
        Me.cmbTimeFilter.Items.AddRange(New Object() {"Today", "Weekly", "Monthly"})
        Me.cmbTimeFilter.Location = New System.Drawing.Point(392, 41)
        Me.cmbTimeFilter.Name = "cmbTimeFilter"
        Me.cmbTimeFilter.Size = New System.Drawing.Size(121, 31)
        Me.cmbTimeFilter.TabIndex = 6
        Me.cmbTimeFilter.Text = "Today"
        '
        'dtpSalesCategoryDate
        '
        Me.dtpSalesCategoryDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpSalesCategoryDate.CustomFormat = "MMMM yyyy"
        Me.dtpSalesCategoryDate.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSalesCategoryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSalesCategoryDate.Location = New System.Drawing.Point(392, 78)
        Me.dtpSalesCategoryDate.Name = "dtpSalesCategoryDate"
        Me.dtpSalesCategoryDate.Size = New System.Drawing.Size(121, 27)
        Me.dtpSalesCategoryDate.TabIndex = 9
        Me.dtpSalesCategoryDate.Visible = False
        '
        'lblCategoryfilter
        '
        Me.lblCategoryfilter.AutoSize = True
        Me.lblCategoryfilter.Font = New System.Drawing.Font("Trebuchet MS", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoryfilter.ForeColor = System.Drawing.Color.DarkGray
        Me.lblCategoryfilter.Location = New System.Drawing.Point(432, 14)
        Me.lblCategoryfilter.Name = "lblCategoryfilter"
        Me.lblCategoryfilter.Size = New System.Drawing.Size(56, 24)
        Me.lblCategoryfilter.TabIndex = 7
        Me.lblCategoryfilter.Text = "Filter"
        '
        'pnlSalesbyCategory
        '
        Me.pnlSalesbyCategory.BackColor = System.Drawing.Color.White
        Me.pnlSalesbyCategory.Controls.Add(Me.lblCategoryfilter)
        Me.pnlSalesbyCategory.Controls.Add(Me.dtpSalesCategoryDate)
        Me.pnlSalesbyCategory.Controls.Add(Me.cmbTimeFilter)
        Me.pnlSalesbyCategory.Controls.Add(Me.chartSalesByCategory)
        Me.pnlSalesbyCategory.Controls.Add(Me.Label5)
        Me.pnlSalesbyCategory.Location = New System.Drawing.Point(0, 76)
        Me.pnlSalesbyCategory.Name = "pnlSalesbyCategory"
        Me.pnlSalesbyCategory.Size = New System.Drawing.Size(530, 400)
        Me.pnlSalesbyCategory.TabIndex = 15
        '
        'pnlInsights
        '
        Me.pnlInsights.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlInsights.BackColor = System.Drawing.Color.White
        Me.pnlInsights.Controls.Add(Me.PieChartOrderChunRate)
        Me.pnlInsights.Controls.Add(Me.lblInsights)
        Me.pnlInsights.Location = New System.Drawing.Point(1104, 504)
        Me.pnlInsights.Name = "pnlInsights"
        Me.pnlInsights.Size = New System.Drawing.Size(569, 326)
        Me.pnlInsights.TabIndex = 19
        '
        'PieChartOrderChunRate
        '
        Me.PieChartOrderChunRate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PieChartOrderChunRate.BackColor = System.Drawing.Color.Black
        Me.PieChartOrderChunRate.Location = New System.Drawing.Point(3, 72)
        Me.PieChartOrderChunRate.Name = "PieChartOrderChunRate"
        Me.PieChartOrderChunRate.Size = New System.Drawing.Size(563, 254)
        Me.PieChartOrderChunRate.TabIndex = 4
        Me.PieChartOrderChunRate.Text = "PieChart2"
        '
        'lblInsights
        '
        Me.lblInsights.AutoSize = True
        Me.lblInsights.Font = New System.Drawing.Font("Trebuchet MS", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsights.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblInsights.Location = New System.Drawing.Point(167, 19)
        Me.lblInsights.Name = "lblInsights"
        Me.lblInsights.Size = New System.Drawing.Size(200, 29)
        Me.lblInsights.TabIndex = 3
        Me.lblInsights.Text = "Orders Chun Rate"
        '
        'TimerRefresh
        '
        Me.TimerRefresh.Enabled = True
        Me.TimerRefresh.Interval = 300000
        '
        'Analytics_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1685, 841)
        Me.Controls.Add(Me.pnlInsights)
        Me.Controls.Add(Me.pnlSalesbyCategory)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pnlPaymentMode)
        Me.Controls.Add(Me.pnlQuartessalesGrowth)
        Me.Controls.Add(Me.pnlOrderSummary)
        Me.Controls.Add(Me.pnlUserInformation)
        Me.Name = "Analytics_Page"
        Me.Text = "testdashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlPaymentMode.ResumeLayout(False)
        Me.pnlPaymentMode.PerformLayout()
        Me.pnlUserInformation.ResumeLayout(False)
        Me.pnlUserInformation.PerformLayout()
        Me.pnlOrderSummary.ResumeLayout(False)
        Me.pnlQuartessalesGrowth.ResumeLayout(False)
        Me.pnlQuartessalesGrowth.PerformLayout()
        Me.pnlSalesbyCategory.ResumeLayout(False)
        Me.pnlSalesbyCategory.PerformLayout()
        Me.pnlInsights.ResumeLayout(False)
        Me.pnlInsights.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlPaymentMode As Panel
    Friend WithEvents dtpPaymentDate As DateTimePicker
    Friend WithEvents pieChartPaymentSummary As LiveCharts.WinForms.PieChart
    Friend WithEvents lblPaymentModeFilter As Label
    Friend WithEvents lblPaymentMode As Label
    Friend WithEvents cmbPaymentModeFilter As ComboBox
    Friend WithEvents pnlUserInformation As Panel
    Friend WithEvents lblUserInformationFilter As Label
    Friend WithEvents cmbUserFilter As ComboBox
    Friend WithEvents PieChartUserSummary As LiveCharts.WinForms.PieChart
    Friend WithEvents lblUserInformation As Label
    Friend WithEvents pnlOrderSummary As Panel
    Friend WithEvents chartOrderSummary As LiveCharts.WinForms.CartesianChart
    Friend WithEvents lblOrdersummary As Label
    Friend WithEvents pnlQuartessalesGrowth As Panel
    Friend WithEvents lblMonthlysalesGrowth As Label
    Friend WithEvents chartMonthlySales As LiveCharts.WinForms.CartesianChart
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents chartSalesByCategory As LiveCharts.WinForms.CartesianChart
    Friend WithEvents cmbTimeFilter As ComboBox
    Friend WithEvents dtpSalesCategoryDate As DateTimePicker
    Friend WithEvents lblCategoryfilter As Label
    Friend WithEvents pnlSalesbyCategory As Panel
    Friend WithEvents pnlInsights As Panel
    Friend WithEvents lblInsights As Label
    Friend WithEvents TimerRefresh As Timer
    Friend WithEvents PieChartOrderChunRate As LiveCharts.WinForms.PieChart
End Class
