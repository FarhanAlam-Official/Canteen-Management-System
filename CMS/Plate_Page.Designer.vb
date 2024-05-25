<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Plate_Page
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
        Me.pnlMainarea = New System.Windows.Forms.Panel()
        Me.pboxicon = New System.Windows.Forms.PictureBox()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.btnBringPlate = New CMS.RoundedButton()
        Me.lblsubtotalamt = New System.Windows.Forms.Label()
        Me.lbldisamt = New System.Windows.Forms.Label()
        Me.lblsubtotal = New System.Windows.Forms.Label()
        Me.lbltotalamt = New System.Windows.Forms.Label()
        Me.lbldis = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lbl_title2 = New System.Windows.Forms.Label()
        Me.lbl_title1 = New System.Windows.Forms.Label()
        Me.pnlPlatearea = New System.Windows.Forms.Panel()
        Me.plateItemsflowlayout = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbldiscount = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlMainarea.SuspendLayout()
        CType(Me.pboxicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFooter.SuspendLayout()
        Me.pnlPlatearea.SuspendLayout()
        Me.plateItemsflowlayout.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMainarea
        '
        Me.pnlMainarea.Controls.Add(Me.pnlPlatearea)
        Me.pnlMainarea.Controls.Add(Me.pboxicon)
        Me.pnlMainarea.Controls.Add(Me.pnlFooter)
        Me.pnlMainarea.Controls.Add(Me.lbl_title2)
        Me.pnlMainarea.Controls.Add(Me.lbl_title1)
        Me.pnlMainarea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMainarea.Location = New System.Drawing.Point(0, 0)
        Me.pnlMainarea.Name = "pnlMainarea"
        Me.pnlMainarea.Size = New System.Drawing.Size(1075, 774)
        Me.pnlMainarea.TabIndex = 0
        '
        'pboxicon
        '
        Me.pboxicon.Image = Global.CMS.My.Resources.Resources.CMS_Logo
        Me.pboxicon.Location = New System.Drawing.Point(9, 5)
        Me.pboxicon.Name = "pboxicon"
        Me.pboxicon.Size = New System.Drawing.Size(145, 106)
        Me.pboxicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxicon.TabIndex = 16
        Me.pboxicon.TabStop = False
        '
        'pnlFooter
        '
        Me.pnlFooter.Controls.Add(Me.btnBringPlate)
        Me.pnlFooter.Controls.Add(Me.lblsubtotalamt)
        Me.pnlFooter.Controls.Add(Me.lbldisamt)
        Me.pnlFooter.Controls.Add(Me.lblsubtotal)
        Me.pnlFooter.Controls.Add(Me.lbltotalamt)
        Me.pnlFooter.Controls.Add(Me.lbldis)
        Me.pnlFooter.Controls.Add(Me.lbltotal)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 644)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1075, 130)
        Me.pnlFooter.TabIndex = 15
        '
        'btnBringPlate
        '
        Me.btnBringPlate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBringPlate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnBringPlate.CornerRadius = 50
        Me.btnBringPlate.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnBringPlate.FlatAppearance.BorderSize = 10
        Me.btnBringPlate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBringPlate.Font = New System.Drawing.Font("Trebuchet MS", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBringPlate.ForeColor = System.Drawing.Color.White
        Me.btnBringPlate.Location = New System.Drawing.Point(75, 37)
        Me.btnBringPlate.Name = "btnBringPlate"
        Me.btnBringPlate.Size = New System.Drawing.Size(208, 65)
        Me.btnBringPlate.TabIndex = 21
        Me.btnBringPlate.Text = "Bring the Plate"
        Me.btnBringPlate.UseVisualStyleBackColor = False
        '
        'lblsubtotalamt
        '
        Me.lblsubtotalamt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblsubtotalamt.AutoSize = True
        Me.lblsubtotalamt.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubtotalamt.Location = New System.Drawing.Point(836, 19)
        Me.lblsubtotalamt.Name = "lblsubtotalamt"
        Me.lblsubtotalamt.Size = New System.Drawing.Size(34, 21)
        Me.lblsubtotalamt.TabIndex = 8
        Me.lblsubtotalamt.Text = "Rs."
        '
        'lbldisamt
        '
        Me.lbldisamt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldisamt.AutoSize = True
        Me.lbldisamt.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldisamt.Location = New System.Drawing.Point(836, 60)
        Me.lbldisamt.Name = "lbldisamt"
        Me.lbldisamt.Size = New System.Drawing.Size(34, 21)
        Me.lbldisamt.TabIndex = 7
        Me.lbldisamt.Text = "Rs."
        '
        'lblsubtotal
        '
        Me.lblsubtotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblsubtotal.AutoSize = True
        Me.lblsubtotal.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblsubtotal.Location = New System.Drawing.Point(701, 19)
        Me.lblsubtotal.Name = "lblsubtotal"
        Me.lblsubtotal.Size = New System.Drawing.Size(80, 21)
        Me.lblsubtotal.TabIndex = 4
        Me.lblsubtotal.Text = "Sub Total"
        '
        'lbltotalamt
        '
        Me.lbltotalamt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltotalamt.AutoSize = True
        Me.lbltotalamt.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalamt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lbltotalamt.Location = New System.Drawing.Point(836, 93)
        Me.lbltotalamt.Name = "lbltotalamt"
        Me.lbltotalamt.Size = New System.Drawing.Size(34, 21)
        Me.lbltotalamt.TabIndex = 6
        Me.lbltotalamt.Text = "Rs."
        '
        'lbldis
        '
        Me.lbldis.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldis.AutoSize = True
        Me.lbldis.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lbldis.Location = New System.Drawing.Point(663, 60)
        Me.lbldis.Name = "lbldis"
        Me.lbldis.Size = New System.Drawing.Size(118, 21)
        Me.lbldis.TabIndex = 3
        Me.lbldis.Text = "Total Discount"
        '
        'lbltotal
        '
        Me.lbltotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lbltotal.Location = New System.Drawing.Point(733, 93)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(48, 21)
        Me.lbltotal.TabIndex = 5
        Me.lbltotal.Text = "Total"
        '
        'lbl_title2
        '
        Me.lbl_title2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_title2.AutoSize = True
        Me.lbl_title2.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title2.Location = New System.Drawing.Point(557, 32)
        Me.lbl_title2.Name = "lbl_title2"
        Me.lbl_title2.Size = New System.Drawing.Size(103, 49)
        Me.lbl_title2.TabIndex = 13
        Me.lbl_title2.Text = "Plate"
        '
        'lbl_title1
        '
        Me.lbl_title1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_title1.AutoSize = True
        Me.lbl_title1.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lbl_title1.Location = New System.Drawing.Point(481, 32)
        Me.lbl_title1.Name = "lbl_title1"
        Me.lbl_title1.Size = New System.Drawing.Size(74, 49)
        Me.lbl_title1.TabIndex = 14
        Me.lbl_title1.Text = "My"
        '
        'pnlPlatearea
        '
        Me.pnlPlatearea.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPlatearea.Controls.Add(Me.plateItemsflowlayout)
        Me.pnlPlatearea.Location = New System.Drawing.Point(3, 136)
        Me.pnlPlatearea.Name = "pnlPlatearea"
        Me.pnlPlatearea.Size = New System.Drawing.Size(1069, 502)
        Me.pnlPlatearea.TabIndex = 17
        '
        'plateItemsflowlayout
        '
        Me.plateItemsflowlayout.AutoScroll = True
        Me.plateItemsflowlayout.BackColor = System.Drawing.Color.WhiteSmoke
        Me.plateItemsflowlayout.Controls.Add(Me.Panel2)
        Me.plateItemsflowlayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.plateItemsflowlayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.plateItemsflowlayout.Location = New System.Drawing.Point(0, 0)
        Me.plateItemsflowlayout.Name = "plateItemsflowlayout"
        Me.plateItemsflowlayout.Size = New System.Drawing.Size(1069, 502)
        Me.plateItemsflowlayout.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.lbldiscount)
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(25, 30)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(25, 30, 3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(986, 161)
        Me.Panel2.TabIndex = 0
        '
        'lbldiscount
        '
        Me.lbldiscount.AutoSize = True
        Me.lbldiscount.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldiscount.Location = New System.Drawing.Point(183, 109)
        Me.lbldiscount.Name = "lbldiscount"
        Me.lbldiscount.Size = New System.Drawing.Size(75, 21)
        Me.lbldiscount.TabIndex = 5
        Me.lbldiscount.Text = "Discount"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button3, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(524, 55)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(151, 43)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 43)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Qty"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(33, 37)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "-"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(115, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(33, 37)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "+"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(183, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Price"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(183, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Item Name"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.CMS.My.Resources.Resources.delete2
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(899, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 161)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(17, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 121)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Plate_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1075, 774)
        Me.Controls.Add(Me.pnlMainarea)
        Me.Name = "Plate_Page"
        Me.Text = " Plate    "
        Me.pnlMainarea.ResumeLayout(False)
        Me.pnlMainarea.PerformLayout()
        CType(Me.pboxicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlFooter.PerformLayout()
        Me.pnlPlatearea.ResumeLayout(False)
        Me.plateItemsflowlayout.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMainarea As Panel
    Friend WithEvents pboxicon As PictureBox
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents lblsubtotalamt As Label
    Friend WithEvents lbldisamt As Label
    Friend WithEvents lblsubtotal As Label
    Friend WithEvents lbltotalamt As Label
    Friend WithEvents lbldis As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents lbl_title2 As Label
    Friend WithEvents lbl_title1 As Label
    Friend WithEvents btnBringPlate As RoundedButton
    Friend WithEvents pnlPlatearea As Panel
    Friend WithEvents plateItemsflowlayout As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbldiscount As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
