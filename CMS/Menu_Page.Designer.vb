<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu_Page
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
        Me.lbl_title2 = New System.Windows.Forms.Label()
        Me.lbl_title1 = New System.Windows.Forms.Label()
        Me.lbl_title3 = New System.Windows.Forms.Label()
        Me.Menuarea = New System.Windows.Forms.FlowLayoutPanel()
        Me.addPlateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.btnViewPlate = New CMS.RoundedButton()
        Me.picboxLogo = New System.Windows.Forms.PictureBox()
        CType(Me.picboxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title2
        '
        Me.lbl_title2.AutoSize = True
        Me.lbl_title2.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title2.Location = New System.Drawing.Point(550, 28)
        Me.lbl_title2.Name = "lbl_title2"
        Me.lbl_title2.Size = New System.Drawing.Size(219, 49)
        Me.lbl_title2.TabIndex = 5
        Me.lbl_title2.Text = " in every bite"
        '
        'lbl_title1
        '
        Me.lbl_title1.AutoSize = True
        Me.lbl_title1.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lbl_title1.Location = New System.Drawing.Point(450, 28)
        Me.lbl_title1.Name = "lbl_title1"
        Me.lbl_title1.Size = New System.Drawing.Size(118, 49)
        Me.lbl_title1.TabIndex = 6
        Me.lbl_title1.Text = "Magic"
        '
        'lbl_title3
        '
        Me.lbl_title3.AutoSize = True
        Me.lbl_title3.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title3.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lbl_title3.Location = New System.Drawing.Point(775, 26)
        Me.lbl_title3.Name = "lbl_title3"
        Me.lbl_title3.Size = New System.Drawing.Size(37, 49)
        Me.lbl_title3.TabIndex = 7
        Me.lbl_title3.Text = "."
        '
        'Menuarea
        '
        Me.Menuarea.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Menuarea.AutoScroll = True
        Me.Menuarea.Location = New System.Drawing.Point(0, 113)
        Me.Menuarea.Margin = New System.Windows.Forms.Padding(30, 30, 0, 0)
        Me.Menuarea.Name = "Menuarea"
        Me.Menuarea.Size = New System.Drawing.Size(1317, 702)
        Me.Menuarea.TabIndex = 0
        Me.Menuarea.TabStop = True
        '
        'addPlateTimer
        '
        Me.addPlateTimer.Interval = 800
        '
        'btnViewPlate
        '
        Me.btnViewPlate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnViewPlate.CornerRadius = 50
        Me.btnViewPlate.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnViewPlate.FlatAppearance.BorderSize = 10
        Me.btnViewPlate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewPlate.Font = New System.Drawing.Font("Trebuchet MS", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewPlate.ForeColor = System.Drawing.Color.White
        Me.btnViewPlate.Location = New System.Drawing.Point(1110, 24)
        Me.btnViewPlate.Name = "btnViewPlate"
        Me.btnViewPlate.Size = New System.Drawing.Size(189, 66)
        Me.btnViewPlate.TabIndex = 20
        Me.btnViewPlate.Text = "View Plate"
        Me.btnViewPlate.UseVisualStyleBackColor = False
        '
        'picboxLogo
        '
        Me.picboxLogo.Image = Global.CMS.My.Resources.Resources.CMS_Logo
        Me.picboxLogo.Location = New System.Drawing.Point(12, 12)
        Me.picboxLogo.Name = "picboxLogo"
        Me.picboxLogo.Size = New System.Drawing.Size(116, 93)
        Me.picboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxLogo.TabIndex = 21
        Me.picboxLogo.TabStop = False
        '
        'Menu_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1317, 815)
        Me.Controls.Add(Me.picboxLogo)
        Me.Controls.Add(Me.btnViewPlate)
        Me.Controls.Add(Me.Menuarea)
        Me.Controls.Add(Me.lbl_title3)
        Me.Controls.Add(Me.lbl_title1)
        Me.Controls.Add(Me.lbl_title2)
        Me.Name = "Menu_Page"
        Me.Text = "Menu"
        CType(Me.picboxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_title2 As Label
    Friend WithEvents lbl_title1 As Label
    Friend WithEvents lbl_title3 As Label
    Friend WithEvents Menuarea As FlowLayoutPanel
    Friend WithEvents addPlateTimer As Timer
    Friend WithEvents btnViewPlate As RoundedButton
    Friend WithEvents picboxLogo As PictureBox
End Class
