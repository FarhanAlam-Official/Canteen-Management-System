<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Thankyou_Page
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
        Me.lblthnk = New System.Windows.Forms.Label()
        Me.lblvisit = New System.Windows.Forms.Label()
        Me.pboxicon = New System.Windows.Forms.PictureBox()
        Me.btnPrint = New CMS.RoundedButton()
        Me.btnLogout = New CMS.RoundedButton()
        CType(Me.pboxicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblthnk
        '
        Me.lblthnk.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblthnk.AutoSize = True
        Me.lblthnk.Font = New System.Drawing.Font("Monotype Corsiva", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblthnk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblthnk.Location = New System.Drawing.Point(163, 156)
        Me.lblthnk.Name = "lblthnk"
        Me.lblthnk.Size = New System.Drawing.Size(233, 60)
        Me.lblthnk.TabIndex = 32
        Me.lblthnk.Text = "Thank you,"
        '
        'lblvisit
        '
        Me.lblvisit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblvisit.AutoSize = True
        Me.lblvisit.Font = New System.Drawing.Font("Monotype Corsiva", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvisit.Location = New System.Drawing.Point(409, 156)
        Me.lblvisit.Margin = New System.Windows.Forms.Padding(10, 0, 3, 0)
        Me.lblvisit.Name = "lblvisit"
        Me.lblvisit.Size = New System.Drawing.Size(242, 60)
        Me.lblvisit.TabIndex = 31
        Me.lblvisit.Text = "Visit Again"
        '
        'pboxicon
        '
        Me.pboxicon.Image = Global.CMS.My.Resources.Resources.Icon
        Me.pboxicon.Location = New System.Drawing.Point(13, 14)
        Me.pboxicon.Name = "pboxicon"
        Me.pboxicon.Size = New System.Drawing.Size(118, 100)
        Me.pboxicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxicon.TabIndex = 33
        Me.pboxicon.TabStop = False
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnPrint.CornerRadius = 50
        Me.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnPrint.FlatAppearance.BorderSize = 10
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(82, 299)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(216, 64)
        Me.btnPrint.TabIndex = 36
        Me.btnPrint.Text = "Print Receipt"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.BackColor = System.Drawing.Color.White
        Me.btnLogout.CornerRadius = 50
        Me.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLogout.FlatAppearance.BorderSize = 10
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnLogout.Location = New System.Drawing.Point(490, 299)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(216, 64)
        Me.btnLogout.TabIndex = 37
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Thankyou_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(827, 451)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.pboxicon)
        Me.Controls.Add(Me.lblthnk)
        Me.Controls.Add(Me.lblvisit)
        Me.Name = "Thankyou_Page"
        Me.Text = "Thankyou Page"
        CType(Me.pboxicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblthnk As Label
    Friend WithEvents lblvisit As Label
    Friend WithEvents pboxicon As PictureBox
    Friend WithEvents btnPrint As RoundedButton
    Friend WithEvents btnLogout As RoundedButton
End Class
