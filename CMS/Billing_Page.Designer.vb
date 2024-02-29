<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Billing_Page
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
        Me.lbl_title1 = New System.Windows.Forms.Label()
        Me.paneltitle = New System.Windows.Forms.Panel()
        Me.lblParticularsTotal = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblParticulars = New System.Windows.Forms.Label()
        Me.lblPronouns = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.lblorder = New System.Windows.Forms.Label()
        Me.lblorderid = New System.Windows.Forms.Label()
        Me.lblPaymentMode = New System.Windows.Forms.Label()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tbllayoutparticulars = New System.Windows.Forms.TableLayoutPanel()
        Me.panelparticulars = New System.Windows.Forms.Panel()
        Me.pnlBillarea = New System.Windows.Forms.Panel()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.btnOnlinePayment = New CMS.RoundedButton()
        Me.btnCash = New CMS.RoundedButton()
        Me.lblsubtotal = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lblsubtotalamt = New System.Windows.Forms.Label()
        Me.lbltotalamt = New System.Windows.Forms.Label()
        Me.lbldisamt = New System.Windows.Forms.Label()
        Me.lbldis = New System.Windows.Forms.Label()
        Me.paneltitle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelparticulars.SuspendLayout()
        Me.pnlBillarea.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_title1
        '
        Me.lbl_title1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_title1.AutoSize = True
        Me.lbl_title1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title1.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title1.ForeColor = System.Drawing.Color.Black
        Me.lbl_title1.Location = New System.Drawing.Point(298, 5)
        Me.lbl_title1.Name = "lbl_title1"
        Me.lbl_title1.Size = New System.Drawing.Size(149, 49)
        Me.lbl_title1.TabIndex = 8
        Me.lbl_title1.Text = "Invoice"
        '
        'paneltitle
        '
        Me.paneltitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.paneltitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.paneltitle.Controls.Add(Me.lblParticularsTotal)
        Me.paneltitle.Controls.Add(Me.lblPrice)
        Me.paneltitle.Controls.Add(Me.lblQuantity)
        Me.paneltitle.Controls.Add(Me.lblParticulars)
        Me.paneltitle.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paneltitle.Location = New System.Drawing.Point(4, 247)
        Me.paneltitle.Name = "paneltitle"
        Me.paneltitle.Size = New System.Drawing.Size(724, 59)
        Me.paneltitle.TabIndex = 10
        '
        'lblParticularsTotal
        '
        Me.lblParticularsTotal.AutoSize = True
        Me.lblParticularsTotal.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblParticularsTotal.ForeColor = System.Drawing.Color.White
        Me.lblParticularsTotal.Location = New System.Drawing.Point(636, 18)
        Me.lblParticularsTotal.Name = "lblParticularsTotal"
        Me.lblParticularsTotal.Size = New System.Drawing.Size(57, 26)
        Me.lblParticularsTotal.TabIndex = 3
        Me.lblParticularsTotal.Text = "Total"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPrice.ForeColor = System.Drawing.Color.White
        Me.lblPrice.Location = New System.Drawing.Point(497, 18)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(61, 26)
        Me.lblPrice.TabIndex = 2
        Me.lblPrice.Text = "Price"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblQuantity.ForeColor = System.Drawing.Color.White
        Me.lblQuantity.Location = New System.Drawing.Point(349, 18)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(94, 26)
        Me.lblQuantity.TabIndex = 1
        Me.lblQuantity.Text = "Quantity"
        '
        'lblParticulars
        '
        Me.lblParticulars.AutoSize = True
        Me.lblParticulars.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParticulars.ForeColor = System.Drawing.Color.White
        Me.lblParticulars.Location = New System.Drawing.Point(51, 18)
        Me.lblParticulars.Name = "lblParticulars"
        Me.lblParticulars.Size = New System.Drawing.Size(114, 26)
        Me.lblParticulars.TabIndex = 0
        Me.lblParticulars.Text = "Particulars"
        '
        'lblPronouns
        '
        Me.lblPronouns.AutoSize = True
        Me.lblPronouns.Font = New System.Drawing.Font("Monotype Corsiva", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPronouns.ForeColor = System.Drawing.Color.Black
        Me.lblPronouns.Location = New System.Drawing.Point(30, 170)
        Me.lblPronouns.Name = "lblPronouns"
        Me.lblPronouns.Size = New System.Drawing.Size(89, 27)
        Me.lblPronouns.TabIndex = 4
        Me.lblPronouns.Text = "Mr./Mrs."
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Monotype Corsiva", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(162, 170)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(63, 29)
        Me.lblName.TabIndex = 11
        Me.lblName.Text = "name"
        '
        'lbldate
        '
        Me.lbldate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(624, 24)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(85, 20)
        Me.lbldate.TabIndex = 12
        Me.lbldate.Text = "2024-07-09"
        '
        'lbltime
        '
        Me.lbltime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.Location = New System.Drawing.Point(628, 54)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(69, 20)
        Me.lbltime.TabIndex = 13
        Me.lbltime.Text = "16:45:30"
        '
        'lblorder
        '
        Me.lblorder.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblorder.AutoSize = True
        Me.lblorder.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblorder.Location = New System.Drawing.Point(303, 62)
        Me.lblorder.Name = "lblorder"
        Me.lblorder.Size = New System.Drawing.Size(70, 20)
        Me.lblorder.TabIndex = 14
        Me.lblorder.Text = "Order Id:"
        '
        'lblorderid
        '
        Me.lblorderid.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblorderid.AutoSize = True
        Me.lblorderid.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblorderid.Location = New System.Drawing.Point(378, 62)
        Me.lblorderid.Name = "lblorderid"
        Me.lblorderid.Size = New System.Drawing.Size(57, 20)
        Me.lblorderid.TabIndex = 15
        Me.lblorderid.Text = "012546"
        '
        'lblPaymentMode
        '
        Me.lblPaymentMode.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPaymentMode.AutoSize = True
        Me.lblPaymentMode.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentMode.Location = New System.Drawing.Point(423, 92)
        Me.lblPaymentMode.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.lblPaymentMode.Name = "lblPaymentMode"
        Me.lblPaymentMode.Size = New System.Drawing.Size(40, 20)
        Me.lblPaymentMode.TabIndex = 26
        Me.lblPaymentMode.Text = "Cash"
        '
        'lblPayment
        '
        Me.lblPayment.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayment.Location = New System.Drawing.Point(288, 92)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(126, 20)
        Me.lblPayment.TabIndex = 27
        Me.lblPayment.Text = "Payment Method:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox1.Image = Global.CMS.My.Resources.Resources.CMS_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(13, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'tbllayoutparticulars
        '
        Me.tbllayoutparticulars.AutoScroll = True
        Me.tbllayoutparticulars.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tbllayoutparticulars.ColumnCount = 4
        Me.tbllayoutparticulars.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.84536!))
        Me.tbllayoutparticulars.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.15464!))
        Me.tbllayoutparticulars.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128.0!))
        Me.tbllayoutparticulars.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124.0!))
        Me.tbllayoutparticulars.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbllayoutparticulars.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbllayoutparticulars.Location = New System.Drawing.Point(0, 0)
        Me.tbllayoutparticulars.Margin = New System.Windows.Forms.Padding(0)
        Me.tbllayoutparticulars.Name = "tbllayoutparticulars"
        Me.tbllayoutparticulars.RowCount = 1
        Me.tbllayoutparticulars.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 336.0!))
        Me.tbllayoutparticulars.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 336.0!))
        Me.tbllayoutparticulars.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 336.0!))
        Me.tbllayoutparticulars.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 336.0!))
        Me.tbllayoutparticulars.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 336.0!))
        Me.tbllayoutparticulars.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 336.0!))
        Me.tbllayoutparticulars.Size = New System.Drawing.Size(723, 336)
        Me.tbllayoutparticulars.TabIndex = 31
        '
        'panelparticulars
        '
        Me.panelparticulars.AutoScroll = True
        Me.panelparticulars.Controls.Add(Me.tbllayoutparticulars)
        Me.panelparticulars.Location = New System.Drawing.Point(3, 308)
        Me.panelparticulars.Name = "panelparticulars"
        Me.panelparticulars.Size = New System.Drawing.Size(723, 336)
        Me.panelparticulars.TabIndex = 32
        '
        'pnlBillarea
        '
        Me.pnlBillarea.Controls.Add(Me.panelparticulars)
        Me.pnlBillarea.Controls.Add(Me.lblPayment)
        Me.pnlBillarea.Controls.Add(Me.lblPaymentMode)
        Me.pnlBillarea.Controls.Add(Me.lblorderid)
        Me.pnlBillarea.Controls.Add(Me.lblorder)
        Me.pnlBillarea.Controls.Add(Me.lbltime)
        Me.pnlBillarea.Controls.Add(Me.lbldate)
        Me.pnlBillarea.Controls.Add(Me.lblName)
        Me.pnlBillarea.Controls.Add(Me.lblPronouns)
        Me.pnlBillarea.Controls.Add(Me.lbl_title1)
        Me.pnlBillarea.Controls.Add(Me.PictureBox1)
        Me.pnlBillarea.Controls.Add(Me.pnlFooter)
        Me.pnlBillarea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBillarea.Location = New System.Drawing.Point(0, 0)
        Me.pnlBillarea.Name = "pnlBillarea"
        Me.pnlBillarea.Size = New System.Drawing.Size(732, 911)
        Me.pnlBillarea.TabIndex = 33
        '
        'pnlFooter
        '
        Me.pnlFooter.Controls.Add(Me.btnOnlinePayment)
        Me.pnlFooter.Controls.Add(Me.btnCash)
        Me.pnlFooter.Controls.Add(Me.lblsubtotal)
        Me.pnlFooter.Controls.Add(Me.lbltotal)
        Me.pnlFooter.Controls.Add(Me.lblsubtotalamt)
        Me.pnlFooter.Controls.Add(Me.lbltotalamt)
        Me.pnlFooter.Controls.Add(Me.lbldisamt)
        Me.pnlFooter.Controls.Add(Me.lbldis)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 711)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(732, 200)
        Me.pnlFooter.TabIndex = 40
        '
        'btnOnlinePayment
        '
        Me.btnOnlinePayment.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOnlinePayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnOnlinePayment.CornerRadius = 40
        Me.btnOnlinePayment.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnOnlinePayment.FlatAppearance.BorderSize = 10
        Me.btnOnlinePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOnlinePayment.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOnlinePayment.ForeColor = System.Drawing.Color.White
        Me.btnOnlinePayment.Location = New System.Drawing.Point(488, 138)
        Me.btnOnlinePayment.Name = "btnOnlinePayment"
        Me.btnOnlinePayment.Size = New System.Drawing.Size(155, 50)
        Me.btnOnlinePayment.TabIndex = 41
        Me.btnOnlinePayment.Text = "Online Payment"
        Me.btnOnlinePayment.UseVisualStyleBackColor = False
        '
        'btnCash
        '
        Me.btnCash.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCash.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnCash.CornerRadius = 40
        Me.btnCash.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnCash.FlatAppearance.BorderSize = 10
        Me.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCash.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCash.ForeColor = System.Drawing.Color.White
        Me.btnCash.Location = New System.Drawing.Point(35, 138)
        Me.btnCash.Name = "btnCash"
        Me.btnCash.Size = New System.Drawing.Size(155, 50)
        Me.btnCash.TabIndex = 40
        Me.btnCash.Text = "Cash"
        Me.btnCash.UseVisualStyleBackColor = False
        '
        'lblsubtotal
        '
        Me.lblsubtotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblsubtotal.AutoSize = True
        Me.lblsubtotal.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblsubtotal.Location = New System.Drawing.Point(493, 12)
        Me.lblsubtotal.Name = "lblsubtotal"
        Me.lblsubtotal.Size = New System.Drawing.Size(80, 21)
        Me.lblsubtotal.TabIndex = 35
        Me.lblsubtotal.Text = "Sub Total"
        '
        'lbltotal
        '
        Me.lbltotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lbltotal.Location = New System.Drawing.Point(525, 86)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(48, 21)
        Me.lbltotal.TabIndex = 36
        Me.lbltotal.Text = "Total"
        '
        'lblsubtotalamt
        '
        Me.lblsubtotalamt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblsubtotalamt.AutoSize = True
        Me.lblsubtotalamt.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubtotalamt.Location = New System.Drawing.Point(609, 12)
        Me.lblsubtotalamt.Name = "lblsubtotalamt"
        Me.lblsubtotalamt.Size = New System.Drawing.Size(34, 21)
        Me.lblsubtotalamt.TabIndex = 39
        Me.lblsubtotalamt.Text = "Rs."
        '
        'lbltotalamt
        '
        Me.lbltotalamt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltotalamt.AutoSize = True
        Me.lbltotalamt.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalamt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lbltotalamt.Location = New System.Drawing.Point(609, 86)
        Me.lbltotalamt.Name = "lbltotalamt"
        Me.lbltotalamt.Size = New System.Drawing.Size(34, 21)
        Me.lbltotalamt.TabIndex = 37
        Me.lbltotalamt.Text = "Rs."
        '
        'lbldisamt
        '
        Me.lbldisamt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldisamt.AutoSize = True
        Me.lbldisamt.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldisamt.Location = New System.Drawing.Point(609, 44)
        Me.lbldisamt.Name = "lbldisamt"
        Me.lbldisamt.Size = New System.Drawing.Size(34, 21)
        Me.lbldisamt.TabIndex = 38
        Me.lbldisamt.Text = "Rs."
        '
        'lbldis
        '
        Me.lbldis.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldis.AutoSize = True
        Me.lbldis.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lbldis.Location = New System.Drawing.Point(455, 44)
        Me.lbldis.Name = "lbldis"
        Me.lbldis.Size = New System.Drawing.Size(118, 21)
        Me.lbldis.TabIndex = 34
        Me.lbldis.Text = "Total Discount"
        '
        'Billing_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(732, 911)
        Me.Controls.Add(Me.paneltitle)
        Me.Controls.Add(Me.pnlBillarea)
        Me.Name = "Billing_Page"
        Me.Text = "Billing_Page"
        Me.paneltitle.ResumeLayout(False)
        Me.paneltitle.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelparticulars.ResumeLayout(False)
        Me.pnlBillarea.ResumeLayout(False)
        Me.pnlBillarea.PerformLayout()
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlFooter.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_title1 As Label
    Friend WithEvents paneltitle As Panel
    Friend WithEvents lblParticulars As Label
    Friend WithEvents lblParticularsTotal As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblPronouns As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents lblorder As Label
    Friend WithEvents lblorderid As Label
    Friend WithEvents lblPaymentMode As Label
    Friend WithEvents lblPayment As Label
    Friend WithEvents tbllayoutparticulars As TableLayoutPanel
    Friend WithEvents panelparticulars As Panel
    Friend WithEvents pnlBillarea As Panel
    Friend WithEvents lbltotal As Label
    Friend WithEvents lbltotalamt As Label
    Friend WithEvents lblsubtotal As Label
    Friend WithEvents lblsubtotalamt As Label
    Friend WithEvents lbldisamt As Label
    Friend WithEvents lbldis As Label
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents btnOnlinePayment As RoundedButton
    Friend WithEvents btnCash As RoundedButton
End Class
