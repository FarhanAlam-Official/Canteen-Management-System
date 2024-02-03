<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About_Us_Page
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About_Us_Page))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblStory = New System.Windows.Forms.Label()
        Me.picboxLogo = New System.Windows.Forms.PictureBox()
        Me.lblStoryValue = New System.Windows.Forms.Label()
        Me.lblHistory = New System.Windows.Forms.Label()
        Me.lblHistoryValue = New System.Windows.Forms.Label()
        Me.lblBelieves = New System.Windows.Forms.Label()
        Me.lblBelievesValue = New System.Windows.Forms.Label()
        CType(Me.picboxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Monotype Corsiva", 25.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(307, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(164, 51)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "About us"
        '
        'lblStory
        '
        Me.lblStory.AutoSize = True
        Me.lblStory.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblStory.Location = New System.Drawing.Point(26, 123)
        Me.lblStory.Name = "lblStory"
        Me.lblStory.Size = New System.Drawing.Size(115, 28)
        Me.lblStory.TabIndex = 13
        Me.lblStory.Text = "Our Story"
        '
        'picboxLogo
        '
        Me.picboxLogo.Image = Global.CMS.My.Resources.Resources.Icon
        Me.picboxLogo.Location = New System.Drawing.Point(12, 2)
        Me.picboxLogo.Name = "picboxLogo"
        Me.picboxLogo.Size = New System.Drawing.Size(116, 93)
        Me.picboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxLogo.TabIndex = 14
        Me.picboxLogo.TabStop = False
        '
        'lblStoryValue
        '
        Me.lblStoryValue.AutoSize = True
        Me.lblStoryValue.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStoryValue.Location = New System.Drawing.Point(27, 163)
        Me.lblStoryValue.Name = "lblStoryValue"
        Me.lblStoryValue.Size = New System.Drawing.Size(302, 115)
        Me.lblStoryValue.TabIndex = 15
        Me.lblStoryValue.Text = "Welcome to CMS!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "We aim to provide the       " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "best meals at affordable prices, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "with a focus on      " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "freshness and customer satisfaction.  "
        '
        'lblHistory
        '
        Me.lblHistory.AutoSize = True
        Me.lblHistory.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHistory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblHistory.Location = New System.Drawing.Point(507, 123)
        Me.lblHistory.Name = "lblHistory"
        Me.lblHistory.Size = New System.Drawing.Size(136, 28)
        Me.lblHistory.TabIndex = 16
        Me.lblHistory.Text = "Our History"
        '
        'lblHistoryValue
        '
        Me.lblHistoryValue.AutoSize = True
        Me.lblHistoryValue.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHistoryValue.Location = New System.Drawing.Point(508, 163)
        Me.lblHistoryValue.Name = "lblHistoryValue"
        Me.lblHistoryValue.Size = New System.Drawing.Size(341, 161)
        Me.lblHistoryValue.TabIndex = 17
        Me.lblHistoryValue.Text = resources.GetString("lblHistoryValue.Text")
        '
        'lblBelieves
        '
        Me.lblBelieves.AutoSize = True
        Me.lblBelieves.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBelieves.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblBelieves.Location = New System.Drawing.Point(26, 397)
        Me.lblBelieves.Name = "lblBelieves"
        Me.lblBelieves.Size = New System.Drawing.Size(219, 28)
        Me.lblBelieves.TabIndex = 18
        Me.lblBelieves.Text = "What we believe in"
        '
        'lblBelievesValue
        '
        Me.lblBelievesValue.AutoSize = True
        Me.lblBelievesValue.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBelievesValue.Location = New System.Drawing.Point(27, 453)
        Me.lblBelievesValue.Name = "lblBelievesValue"
        Me.lblBelievesValue.Size = New System.Drawing.Size(751, 115)
        Me.lblBelievesValue.TabIndex = 19
        Me.lblBelievesValue.Text = resources.GetString("lblBelievesValue.Text")
        '
        'About_Us_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(913, 638)
        Me.Controls.Add(Me.lblBelievesValue)
        Me.Controls.Add(Me.lblBelieves)
        Me.Controls.Add(Me.lblHistoryValue)
        Me.Controls.Add(Me.lblHistory)
        Me.Controls.Add(Me.lblStoryValue)
        Me.Controls.Add(Me.picboxLogo)
        Me.Controls.Add(Me.lblStory)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "About_Us_Page"
        Me.Text = "About Us Page"
        CType(Me.picboxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblStory As Label
    Friend WithEvents picboxLogo As PictureBox
    Friend WithEvents lblStoryValue As Label
    Friend WithEvents lblHistory As Label
    Friend WithEvents lblHistoryValue As Label
    Friend WithEvents lblBelieves As Label
    Friend WithEvents lblBelievesValue As Label
End Class
