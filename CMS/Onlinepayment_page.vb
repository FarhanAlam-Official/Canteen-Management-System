Imports System.Windows.Forms.DataVisualization.Charting
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Onlinepayment_page
    Private userId As Integer
    Private capturedBillImage As Bitmap
    Public Sub New(userId As Integer, Optional capturedBillImage As Bitmap = Nothing)
        InitializeComponent()
        Me.userId = userId
        Me.capturedBillImage = capturedBillImage ' Store the captured bill image
    End Sub
    Private Sub Onlinepayment_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Centering the form in middle of parent form
        Dim x As Integer
        Dim y As Integer
        Dim r As Rectangle

        If Not Parent Is Nothing Then
            r = Parent.ClientRectangle
            x = r.Width - Me.Width + Parent.Left
            y = r.Height - Me.Height + Parent.Top
        Else
            r = Screen.PrimaryScreen.WorkingArea
            x = r.Width - Me.Width
            y = r.Height - Me.Height
        End If

        x = CInt(x / 2)
        y = CInt(y / 2)

        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(x, y)
    End Sub

    Private Sub Onlinepayment_page_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        ' Show the thank you page with the captured bill image
        Dim thankyoupage As New Thankyou_Page(userId, capturedBillImage)
        thankyoupage.ShowDialog()
    End Sub
End Class