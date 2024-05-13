<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderDetails_Page
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
        Me.pnlMainarea = New System.Windows.Forms.Panel()
        Me.pnlOrderDetails = New System.Windows.Forms.Panel()
        Me.lblOrderIDVal = New System.Windows.Forms.Label()
        Me.lblProductIDVal = New System.Windows.Forms.Label()
        Me.lblPaymentModeVal = New System.Windows.Forms.Label()
        Me.lblPaymentStatusVal = New System.Windows.Forms.Label()
        Me.lblOrderStatusVal = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.lblOrderStatus = New System.Windows.Forms.Label()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.lblPaymentStatus = New System.Windows.Forms.Label()
        Me.lblPaymentMode = New System.Windows.Forms.Label()
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblsubtotalamt = New System.Windows.Forms.Label()
        Me.lbldisamt = New System.Windows.Forms.Label()
        Me.lblsubtotal = New System.Windows.Forms.Label()
        Me.lbltotalamt = New System.Windows.Forms.Label()
        Me.lbldis = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.pnlProductArea = New System.Windows.Forms.Panel()
        Me.ftlayoutProducts = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlProduct1 = New System.Windows.Forms.Panel()
        Me.lblProductQuantity1 = New System.Windows.Forms.Label()
        Me.lblProductDiscount1 = New System.Windows.Forms.Label()
        Me.lblProductPrice1 = New System.Windows.Forms.Label()
        Me.lblProductName1 = New System.Windows.Forms.Label()
        Me.picboxProduct1 = New System.Windows.Forms.PictureBox()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.picboxIcon = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlMainarea.SuspendLayout()
        Me.pnlOrderDetails.SuspendLayout()
        Me.pnlProductArea.SuspendLayout()
        Me.ftlayoutProducts.SuspendLayout()
        Me.pnlProduct1.SuspendLayout()
        CType(Me.picboxProduct1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        CType(Me.picboxIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMainarea
        '
        Me.pnlMainarea.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlMainarea.Controls.Add(Me.pnlOrderDetails)
        Me.pnlMainarea.Controls.Add(Me.pnlProductArea)
        Me.pnlMainarea.Controls.Add(Me.pnlHeader)
        Me.pnlMainarea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMainarea.Location = New System.Drawing.Point(0, 0)
        Me.pnlMainarea.Name = "pnlMainarea"
        Me.pnlMainarea.Size = New System.Drawing.Size(947, 734)
        Me.pnlMainarea.TabIndex = 0
        '
        'pnlOrderDetails
        '
        Me.pnlOrderDetails.BackColor = System.Drawing.Color.White
        Me.pnlOrderDetails.Controls.Add(Me.lblOrderIDVal)
        Me.pnlOrderDetails.Controls.Add(Me.lblProductIDVal)
        Me.pnlOrderDetails.Controls.Add(Me.lblPaymentModeVal)
        Me.pnlOrderDetails.Controls.Add(Me.lblPaymentStatusVal)
        Me.pnlOrderDetails.Controls.Add(Me.lblOrderStatusVal)
        Me.pnlOrderDetails.Controls.Add(Me.lblDateTime)
        Me.pnlOrderDetails.Controls.Add(Me.lblOrderStatus)
        Me.pnlOrderDetails.Controls.Add(Me.lblProductID)
        Me.pnlOrderDetails.Controls.Add(Me.lblPaymentStatus)
        Me.pnlOrderDetails.Controls.Add(Me.lblPaymentMode)
        Me.pnlOrderDetails.Controls.Add(Me.lblOrderID)
        Me.pnlOrderDetails.Controls.Add(Me.lblCustomerName)
        Me.pnlOrderDetails.Controls.Add(Me.lblsubtotalamt)
        Me.pnlOrderDetails.Controls.Add(Me.lbldisamt)
        Me.pnlOrderDetails.Controls.Add(Me.lblsubtotal)
        Me.pnlOrderDetails.Controls.Add(Me.lbltotalamt)
        Me.pnlOrderDetails.Controls.Add(Me.lbldis)
        Me.pnlOrderDetails.Controls.Add(Me.lbltotal)
        Me.pnlOrderDetails.Location = New System.Drawing.Point(427, 115)
        Me.pnlOrderDetails.Margin = New System.Windows.Forms.Padding(3, 20, 3, 3)
        Me.pnlOrderDetails.Name = "pnlOrderDetails"
        Me.pnlOrderDetails.Size = New System.Drawing.Size(508, 616)
        Me.pnlOrderDetails.TabIndex = 2
        '
        'lblOrderIDVal
        '
        Me.lblOrderIDVal.AutoSize = True
        Me.lblOrderIDVal.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderIDVal.ForeColor = System.Drawing.Color.Black
        Me.lblOrderIDVal.Location = New System.Drawing.Point(221, 199)
        Me.lblOrderIDVal.Name = "lblOrderIDVal"
        Me.lblOrderIDVal.Size = New System.Drawing.Size(136, 26)
        Me.lblOrderIDVal.TabIndex = 33
        Me.lblOrderIDVal.Text = "ordersidvalue"
        '
        'lblProductIDVal
        '
        Me.lblProductIDVal.AutoSize = True
        Me.lblProductIDVal.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductIDVal.ForeColor = System.Drawing.Color.Black
        Me.lblProductIDVal.Location = New System.Drawing.Point(221, 263)
        Me.lblProductIDVal.Name = "lblProductIDVal"
        Me.lblProductIDVal.Size = New System.Drawing.Size(136, 26)
        Me.lblProductIDVal.TabIndex = 32
        Me.lblProductIDVal.Text = "paymentidval"
        '
        'lblPaymentModeVal
        '
        Me.lblPaymentModeVal.AutoSize = True
        Me.lblPaymentModeVal.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentModeVal.ForeColor = System.Drawing.Color.Black
        Me.lblPaymentModeVal.Location = New System.Drawing.Point(221, 384)
        Me.lblPaymentModeVal.Name = "lblPaymentModeVal"
        Me.lblPaymentModeVal.Size = New System.Drawing.Size(169, 26)
        Me.lblPaymentModeVal.TabIndex = 31
        Me.lblPaymentModeVal.Text = "paymentmodeval"
        '
        'lblPaymentStatusVal
        '
        Me.lblPaymentStatusVal.AutoSize = True
        Me.lblPaymentStatusVal.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentStatusVal.ForeColor = System.Drawing.Color.Black
        Me.lblPaymentStatusVal.Location = New System.Drawing.Point(221, 326)
        Me.lblPaymentStatusVal.Name = "lblPaymentStatusVal"
        Me.lblPaymentStatusVal.Size = New System.Drawing.Size(173, 26)
        Me.lblPaymentStatusVal.TabIndex = 29
        Me.lblPaymentStatusVal.Text = "paymentstatusval"
        '
        'lblOrderStatusVal
        '
        Me.lblOrderStatusVal.AutoSize = True
        Me.lblOrderStatusVal.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderStatusVal.ForeColor = System.Drawing.Color.Black
        Me.lblOrderStatusVal.Location = New System.Drawing.Point(221, 136)
        Me.lblOrderStatusVal.Name = "lblOrderStatusVal"
        Me.lblOrderStatusVal.Size = New System.Drawing.Size(165, 26)
        Me.lblOrderStatusVal.TabIndex = 28
        Me.lblOrderStatusVal.Text = "orderstatusvalue"
        '
        'lblDateTime
        '
        Me.lblDateTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblDateTime.Location = New System.Drawing.Point(289, 71)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(81, 21)
        Me.lblDateTime.TabIndex = 27
        Me.lblDateTime.Text = "date time"
        '
        'lblOrderStatus
        '
        Me.lblOrderStatus.AutoSize = True
        Me.lblOrderStatus.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblOrderStatus.Location = New System.Drawing.Point(37, 133)
        Me.lblOrderStatus.Name = "lblOrderStatus"
        Me.lblOrderStatus.Size = New System.Drawing.Size(125, 26)
        Me.lblOrderStatus.TabIndex = 26
        Me.lblOrderStatus.Text = "Order Status"
        '
        'lblProductID
        '
        Me.lblProductID.AutoSize = True
        Me.lblProductID.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblProductID.Location = New System.Drawing.Point(37, 263)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(114, 26)
        Me.lblProductID.TabIndex = 25
        Me.lblProductID.Text = "Payment ID"
        '
        'lblPaymentStatus
        '
        Me.lblPaymentStatus.AutoSize = True
        Me.lblPaymentStatus.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblPaymentStatus.Location = New System.Drawing.Point(37, 326)
        Me.lblPaymentStatus.Name = "lblPaymentStatus"
        Me.lblPaymentStatus.Size = New System.Drawing.Size(152, 26)
        Me.lblPaymentStatus.TabIndex = 24
        Me.lblPaymentStatus.Text = "Payment Status"
        '
        'lblPaymentMode
        '
        Me.lblPaymentMode.AutoSize = True
        Me.lblPaymentMode.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentMode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblPaymentMode.Location = New System.Drawing.Point(37, 384)
        Me.lblPaymentMode.Name = "lblPaymentMode"
        Me.lblPaymentMode.Size = New System.Drawing.Size(144, 26)
        Me.lblPaymentMode.TabIndex = 23
        Me.lblPaymentMode.Text = "Payment Mode"
        '
        'lblOrderID
        '
        Me.lblOrderID.AutoSize = True
        Me.lblOrderID.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblOrderID.Location = New System.Drawing.Point(37, 199)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(87, 26)
        Me.lblOrderID.TabIndex = 20
        Me.lblOrderID.Text = "Order ID"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Trebuchet MS", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(174, 18)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(165, 27)
        Me.lblCustomerName.TabIndex = 7
        Me.lblCustomerName.Text = "customer name"
        '
        'lblsubtotalamt
        '
        Me.lblsubtotalamt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblsubtotalamt.AutoSize = True
        Me.lblsubtotalamt.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.lblsubtotalamt.Location = New System.Drawing.Point(376, 478)
        Me.lblsubtotalamt.Name = "lblsubtotalamt"
        Me.lblsubtotalamt.Size = New System.Drawing.Size(34, 23)
        Me.lblsubtotalamt.TabIndex = 14
        Me.lblsubtotalamt.Text = "Rs."
        '
        'lbldisamt
        '
        Me.lbldisamt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldisamt.AutoSize = True
        Me.lbldisamt.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.lbldisamt.Location = New System.Drawing.Point(376, 519)
        Me.lbldisamt.Name = "lbldisamt"
        Me.lbldisamt.Size = New System.Drawing.Size(34, 23)
        Me.lbldisamt.TabIndex = 13
        Me.lbldisamt.Text = "Rs."
        '
        'lblsubtotal
        '
        Me.lblsubtotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblsubtotal.AutoSize = True
        Me.lblsubtotal.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.lblsubtotal.Location = New System.Drawing.Point(241, 478)
        Me.lblsubtotal.Name = "lblsubtotal"
        Me.lblsubtotal.Size = New System.Drawing.Size(79, 23)
        Me.lblsubtotal.TabIndex = 10
        Me.lblsubtotal.Text = "Sub Total"
        '
        'lbltotalamt
        '
        Me.lbltotalamt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltotalamt.AutoSize = True
        Me.lbltotalamt.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.lbltotalamt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lbltotalamt.Location = New System.Drawing.Point(376, 552)
        Me.lbltotalamt.Name = "lbltotalamt"
        Me.lbltotalamt.Size = New System.Drawing.Size(34, 23)
        Me.lbltotalamt.TabIndex = 12
        Me.lbltotalamt.Text = "Rs."
        '
        'lbldis
        '
        Me.lbldis.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldis.AutoSize = True
        Me.lbldis.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.lbldis.Location = New System.Drawing.Point(203, 519)
        Me.lbldis.Name = "lbldis"
        Me.lbldis.Size = New System.Drawing.Size(118, 23)
        Me.lbldis.TabIndex = 9
        Me.lbldis.Text = "Total Discount"
        '
        'lbltotal
        '
        Me.lbltotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.lbltotal.Location = New System.Drawing.Point(273, 552)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(48, 23)
        Me.lbltotal.TabIndex = 11
        Me.lbltotal.Text = "Total"
        '
        'pnlProductArea
        '
        Me.pnlProductArea.AutoScroll = True
        Me.pnlProductArea.Controls.Add(Me.ftlayoutProducts)
        Me.pnlProductArea.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlProductArea.Location = New System.Drawing.Point(0, 100)
        Me.pnlProductArea.Name = "pnlProductArea"
        Me.pnlProductArea.Size = New System.Drawing.Size(421, 634)
        Me.pnlProductArea.TabIndex = 1
        '
        'ftlayoutProducts
        '
        Me.ftlayoutProducts.AutoScroll = True
        Me.ftlayoutProducts.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ftlayoutProducts.Controls.Add(Me.pnlProduct1)
        Me.ftlayoutProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ftlayoutProducts.Location = New System.Drawing.Point(0, 0)
        Me.ftlayoutProducts.Name = "ftlayoutProducts"
        Me.ftlayoutProducts.Size = New System.Drawing.Size(421, 634)
        Me.ftlayoutProducts.TabIndex = 14
        '
        'pnlProduct1
        '
        Me.pnlProduct1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlProduct1.BackColor = System.Drawing.Color.White
        Me.pnlProduct1.Controls.Add(Me.lblProductQuantity1)
        Me.pnlProduct1.Controls.Add(Me.lblProductDiscount1)
        Me.pnlProduct1.Controls.Add(Me.lblProductPrice1)
        Me.pnlProduct1.Controls.Add(Me.lblProductName1)
        Me.pnlProduct1.Controls.Add(Me.picboxProduct1)
        Me.pnlProduct1.Location = New System.Drawing.Point(20, 15)
        Me.pnlProduct1.Margin = New System.Windows.Forms.Padding(20, 15, 0, 0)
        Me.pnlProduct1.Name = "pnlProduct1"
        Me.pnlProduct1.Size = New System.Drawing.Size(376, 161)
        Me.pnlProduct1.TabIndex = 0
        '
        'lblProductQuantity1
        '
        Me.lblProductQuantity1.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.lblProductQuantity1.Location = New System.Drawing.Point(184, 53)
        Me.lblProductQuantity1.Name = "lblProductQuantity1"
        Me.lblProductQuantity1.Size = New System.Drawing.Size(167, 23)
        Me.lblProductQuantity1.TabIndex = 6
        Me.lblProductQuantity1.Text = "Quantity"
        '
        'lblProductDiscount1
        '
        Me.lblProductDiscount1.Font = New System.Drawing.Font("Trebuchet MS", 10.2!)
        Me.lblProductDiscount1.Location = New System.Drawing.Point(183, 118)
        Me.lblProductDiscount1.Name = "lblProductDiscount1"
        Me.lblProductDiscount1.Size = New System.Drawing.Size(168, 23)
        Me.lblProductDiscount1.TabIndex = 5
        Me.lblProductDiscount1.Text = "Discount"
        '
        'lblProductPrice1
        '
        Me.lblProductPrice1.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductPrice1.Location = New System.Drawing.Point(183, 84)
        Me.lblProductPrice1.Name = "lblProductPrice1"
        Me.lblProductPrice1.Size = New System.Drawing.Size(168, 23)
        Me.lblProductPrice1.TabIndex = 3
        Me.lblProductPrice1.Text = "Price"
        '
        'lblProductName1
        '
        Me.lblProductName1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductName1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblProductName1.Location = New System.Drawing.Point(183, 18)
        Me.lblProductName1.Name = "lblProductName1"
        Me.lblProductName1.Size = New System.Drawing.Size(168, 26)
        Me.lblProductName1.TabIndex = 2
        Me.lblProductName1.Text = "Item Name"
        '
        'picboxProduct1
        '
        Me.picboxProduct1.Location = New System.Drawing.Point(17, 18)
        Me.picboxProduct1.Name = "picboxProduct1"
        Me.picboxProduct1.Size = New System.Drawing.Size(144, 121)
        Me.picboxProduct1.TabIndex = 0
        Me.picboxProduct1.TabStop = False
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlHeader.Controls.Add(Me.picboxIcon)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(947, 100)
        Me.pnlHeader.TabIndex = 0
        '
        'picboxIcon
        '
        Me.picboxIcon.Image = Global.CMS.My.Resources.Resources.CMS_Logo
        Me.picboxIcon.Location = New System.Drawing.Point(12, 12)
        Me.picboxIcon.Name = "picboxIcon"
        Me.picboxIcon.Size = New System.Drawing.Size(89, 77)
        Me.picboxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxIcon.TabIndex = 7
        Me.picboxIcon.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(326, 23)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(229, 49)
        Me.lblTitle.TabIndex = 15
        Me.lblTitle.Text = "Order Details"
        '
        'OrderDetails_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(947, 734)
        Me.Controls.Add(Me.pnlMainarea)
        Me.Name = "OrderDetails_Page"
        Me.Text = "OrderDetails_Page"
        Me.pnlMainarea.ResumeLayout(False)
        Me.pnlOrderDetails.ResumeLayout(False)
        Me.pnlOrderDetails.PerformLayout()
        Me.pnlProductArea.ResumeLayout(False)
        Me.ftlayoutProducts.ResumeLayout(False)
        Me.pnlProduct1.ResumeLayout(False)
        CType(Me.picboxProduct1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.picboxIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMainarea As Panel
    Friend WithEvents pnlOrderDetails As Panel
    Friend WithEvents pnlProductArea As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents ftlayoutProducts As FlowLayoutPanel
    Friend WithEvents pnlProduct1 As Panel
    Friend WithEvents lblProductQuantity1 As Label
    Friend WithEvents lblProductDiscount1 As Label
    Friend WithEvents lblProductPrice1 As Label
    Friend WithEvents lblProductName1 As Label
    Friend WithEvents picboxProduct1 As PictureBox
    Friend WithEvents lblDateTime As Label
    Friend WithEvents lblOrderStatus As Label
    Friend WithEvents lblProductID As Label
    Friend WithEvents lblPaymentStatus As Label
    Friend WithEvents lblPaymentMode As Label
    Friend WithEvents lblOrderID As Label
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblsubtotalamt As Label
    Friend WithEvents lbldisamt As Label
    Friend WithEvents lblsubtotal As Label
    Friend WithEvents lbltotalamt As Label
    Friend WithEvents lbldis As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents lblOrderIDVal As Label
    Friend WithEvents lblProductIDVal As Label
    Friend WithEvents lblPaymentModeVal As Label
    Friend WithEvents lblPaymentStatusVal As Label
    Friend WithEvents lblOrderStatusVal As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents picboxIcon As PictureBox
End Class
