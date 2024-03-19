Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class ModernClockControl
    Inherits UserControl

    Private selectedHour As Integer
    Private selectedMinute As Integer
    Private isAM As Boolean = True
    Private center As Point
    Private clockRadius As Integer

    Private WithEvents clockTimer As Timer
    Private hourInput As TextBox
    Private minuteInput As TextBox
    Private setTimeButton As Button
    Private amPmButton As Button

    Private isDraggingHour As Boolean = False
    Private isDraggingMinute As Boolean = False

    ' Color palette for modern appearance
    Private clockFaceColor As Color = Color.FromArgb(250, 250, 250)
    Private clockBorderColor As Color = Color.FromArgb(120, 120, 120)
    Private clockHandColor As Color = Color.FromArgb(50, 50, 50)
    Private backgroundColor As Color = Color.FromArgb(220, 220, 230)

    Public Sub New()
        Me.Size = New Size(300, 350)
        Me.BackColor = backgroundColor

        clockTimer = New Timer()
        clockTimer.Interval = 1000
        clockTimer.Start()

        InitDigitalTimeInput()

        selectedHour = 6
        selectedMinute = 0
    End Sub

    Private Sub InitDigitalTimeInput()
        ' Hour input
        hourInput = New TextBox() With {
            .Width = 50,
            .Height = 30,
            .Font = New Font("Trebuchet MS", 12),
            .TextAlign = HorizontalAlignment.Center,
            .Text = "06"
        }

        ' Add event handler for TextChanged
        AddHandler hourInput.TextChanged, AddressOf OnTimeInputChanged
        Me.Controls.Add(hourInput)

        ' Minute input
        minuteInput = New TextBox() With {
            .Width = 50,
            .Height = 30,
            .Font = New Font("Trebuchet MS", 12),
            .TextAlign = HorizontalAlignment.Center,
            .Text = "00"
        }
        ' Add event handler for TextChanged
        AddHandler minuteInput.TextChanged, AddressOf OnTimeInputChanged
        Me.Controls.Add(minuteInput)

        ' Set Time Button
        setTimeButton = New Button() With {
            .Text = "Set Time",
            .Width = 90,
            .Height = 30,
            .Font = New Font("Trebuchet MS", 10)
        }
        AddHandler setTimeButton.MouseEnter, AddressOf OnButtonMouseEnter
        AddHandler setTimeButton.MouseLeave, AddressOf OnButtonMouseLeave
        AddHandler setTimeButton.Click, AddressOf SetTimeFromInput
        Me.Controls.Add(setTimeButton)

        ' AM/PM Button
        amPmButton = New Button() With {
            .Text = "AM",
            .Width = 50,
            .Height = 30,
            .Font = New Font("Trebuchet MS", 10)
        }
        AddHandler amPmButton.MouseEnter, AddressOf OnButtonMouseEnter
        AddHandler amPmButton.MouseLeave, AddressOf OnButtonMouseLeave
        AddHandler amPmButton.Click, AddressOf ToggleAMPM
        Me.Controls.Add(amPmButton)

        AddHandler Me.Resize, AddressOf OnResize
    End Sub

    ' Declare the event for time setting with AM/PM
    Public Event TimeSet(ByVal hour As Integer, ByVal minute As Integer, ByVal isPM As Boolean)

    Private Sub SetTimeFromInput(sender As Object, e As EventArgs)
        Try
            selectedHour = Convert.ToInt32(hourInput.Text) Mod 12
            If selectedHour = 0 Then selectedHour = 12
            selectedMinute = Convert.ToInt32(minuteInput.Text) Mod 60

            ' Raise the TimeSet event with AM/PM
            RaiseEvent TimeSet(selectedHour, selectedMinute, Not isAM)
            Me.Invalidate()
        Catch ex As Exception
            MessageBox.Show("Please enter valid numbers for hour and minute.")
        End Try
    End Sub

    Private Sub OnTimeInputChanged(sender As Object, e As EventArgs)
        Try
            ' Update the selectedHour and selectedMinute based on the input
            selectedHour = Convert.ToInt32(hourInput.Text) Mod 12
            If selectedHour = 0 Then selectedHour = 12
            selectedMinute = Convert.ToInt32(minuteInput.Text) Mod 60

            ' Repaint the clock to reflect the changes
            Me.Invalidate()
        Catch ex As Exception
            ' Handle invalid input, possibly with a message box or validation
        End Try
    End Sub


    Private Sub ToggleAMPM(sender As Object, e As EventArgs)
        isAM = Not isAM
        amPmButton.Text = If(isAM, "AM", "PM")
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias

        center = New Point(Me.Width / 2, Me.Height / 2 - 30)
        clockRadius = Math.Min(Me.Width, Me.Height - 100) / 2

        DrawClockFace(g)
        DrawClockHands(g)
    End Sub

    Private Sub DrawClockFace(g As Graphics)
        Dim clockRectangle As New Rectangle(center.X - clockRadius, center.Y - clockRadius, clockRadius * 2, clockRadius * 2)
        Using brush As New SolidBrush(clockFaceColor)
            g.FillEllipse(brush, clockRectangle)
        End Using

        g.DrawEllipse(New Pen(clockBorderColor, 2), clockRectangle)

        For i As Integer = 1 To 12
            Dim angle As Double = (i * 30 - 90) * Math.PI / 180
            Dim x As Integer = CInt(center.X + (clockRadius - 20) * Math.Cos(angle))
            Dim y As Integer = CInt(center.Y + (clockRadius - 20) * Math.Sin(angle))
            Dim font As New Font("Trebuchet MS", 10, FontStyle.Bold)
            g.DrawString(i.ToString(), font, Brushes.Black, New PointF(x - 10, y - 10))
        Next
    End Sub

    Private Sub DrawClockHands(g As Graphics)
        Dim hourAngle As Double = (selectedHour + selectedMinute / 60.0) * 30
        Dim minuteAngle As Double = selectedMinute * 6

        Dim hourHand As Point = GetPointOnCircle(hourAngle, clockRadius * 0.5)
        Dim minuteHand As Point = GetPointOnCircle(minuteAngle, clockRadius - 20)

        g.DrawLine(New Pen(clockHandColor, 5), center, hourHand)
        g.DrawLine(New Pen(clockHandColor, 3), center, minuteHand)
    End Sub

    Private Function GetPointOnCircle(angle As Double, radius As Integer) As Point
        Dim angleRad As Double = angle * Math.PI / 180.0
        Dim x As Integer = CInt(center.X + radius * Math.Cos(angleRad - Math.PI / 2))
        Dim y As Integer = CInt(center.Y + radius * Math.Sin(angleRad - Math.PI / 2))
        Return New Point(x, y)
    End Function

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        Dim hourHandAngle As Double = (selectedHour + selectedMinute / 60.0) * 30
        Dim minuteHandAngle As Double = selectedMinute * 6

        Dim hourHandPoint As Point = GetPointOnCircle(hourHandAngle, clockRadius * 0.5)
        Dim minuteHandPoint As Point = GetPointOnCircle(minuteHandAngle, clockRadius - 20)

        ' Increase tolerance area for detecting hand clicks for easier grabbing
        If (Math.Sqrt((e.X - hourHandPoint.X) ^ 2 + (e.Y - hourHandPoint.Y) ^ 2) < 15) Then
            isDraggingHour = True
        ElseIf (Math.Sqrt((e.X - minuteHandPoint.X) ^ 2 + (e.Y - minuteHandPoint.Y) ^ 2) < 15) Then
            isDraggingMinute = True
        End If

        MyBase.OnMouseDown(e)
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        If isDraggingHour OrElse isDraggingMinute Then
            ' Calculate angle from the center to the mouse position
            Dim angle As Double = Math.Atan2(e.Y - center.Y, e.X - center.X) * 180 / Math.PI + 90
            If angle < 0 Then angle += 360

            If isDraggingHour Then
                ' Adjust for smoother hour dragging
                selectedHour = CInt((angle / 30) Mod 12)
                If selectedHour = 0 Then selectedHour = 12
                hourInput.Text = selectedHour.ToString("") ' Update hour input field

            ElseIf isDraggingMinute Then
                ' Adjust for smoother minute dragging
                selectedMinute = CInt(angle / 6) Mod 60
                minuteInput.Text = selectedMinute.ToString("00") ' Update minute input field
            End If

            Me.Invalidate() ' Redraw the clock with updated hands
        End If

        MyBase.OnMouseMove(e)
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        ' Reset dragging flags on mouse release
        isDraggingHour = False
        isDraggingMinute = False
        MyBase.OnMouseUp(e)
    End Sub

    Private Sub OnButtonMouseEnter(sender As Object, e As EventArgs)
        Dim button As Button = CType(sender, Button)
        button.BackColor = Color.FromArgb(0, 191, 99) ' Green
        button.ForeColor = Color.White
    End Sub

    Private Sub OnButtonMouseLeave(sender As Object, e As EventArgs)
        Dim button As Button = CType(sender, Button)
        button.BackColor = Color.LightGray ' Reset to original BackColor
        button.ForeColor = Color.Black ' Reset to original ForeColor
    End Sub

    Private Shadows Sub OnResize(sender As Object, e As EventArgs)
        center = New Point(Me.Width / 2, Me.Height / 2 - 30)
        clockRadius = Math.Min(Me.Width, Me.Height - 100) / 2

        Dim controlHeight As Integer = Me.Height - (center.Y + clockRadius + 10)
        Dim controlSpacing As Integer = 10

        ' Position controls below the clock, centered
        hourInput.Location = New Point((Me.Width - hourInput.Width) / 2 - hourInput.Width - controlSpacing / 2, center.Y + clockRadius + controlSpacing)
        minuteInput.Location = New Point((Me.Width - minuteInput.Width) / 2 + hourInput.Width + controlSpacing / 2, center.Y + clockRadius + controlSpacing)
        amPmButton.Location = New Point(minuteInput.Right + controlSpacing, center.Y + clockRadius + controlSpacing)

        ' Adjust "Set Time" button to the center below the other inputs
        setTimeButton.Location = New Point((Me.Width - setTimeButton.Width) / 2, amPmButton.Bottom + controlSpacing)

        ' Adjust heights to maintain proportions
        Dim newControlHeight As Integer = Math.Max(30, controlHeight / 8)
        hourInput.Height = newControlHeight
        minuteInput.Height = newControlHeight
        setTimeButton.Height = newControlHeight
        amPmButton.Height = newControlHeight
    End Sub
End Class
