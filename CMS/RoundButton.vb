Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class RoundedButton
    Inherits Button

    Private _cornerRadius As Integer = 20 ' Default radius

    <Browsable(True), Category("Appearance"), Description("The corner radius of the button.")>
    Public Property CornerRadius As Integer
        Get
            Return _cornerRadius
        End Get
        Set(ByVal value As Integer)
            _cornerRadius = value
            Me.Invalidate() ' Redraw the button when the radius changes
        End Set
    End Property

    Protected Overrides Sub OnPaint(ByVal pevent As PaintEventArgs)
        MyBase.OnPaint(pevent)

        Dim graphics As Graphics = pevent.Graphics
        graphics.SmoothingMode = SmoothingMode.AntiAlias

        ' Define the rounded rectangle path
        Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)
        Dim path As New GraphicsPath()
        Dim radius As Integer = _cornerRadius

        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()

        ' Fill the button background
        graphics.FillPath(New SolidBrush(Me.BackColor), path)

        ' Draw the button border
        graphics.DrawPath(New Pen(Me.ForeColor, 2), path)

        ' Draw the button text
        TextRenderer.DrawText(graphics, Me.Text, Me.Font, rect, Me.ForeColor, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
    End Sub
End Class
