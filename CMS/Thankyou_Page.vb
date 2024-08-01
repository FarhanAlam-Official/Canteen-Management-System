Imports System.Drawing.Printing

Public Class Thankyou_Page

    Private userId As Integer
    Private capturedBillImage As Bitmap
    Private isPrinting As Boolean = False ' Flag to prevent multiple prints
    Private WithEvents printDocument As New PrintDocument()

    ' Constructor to accept user ID and captured bill image
    Public Sub New(userId As Integer, capturedBillImage As Bitmap)
        InitializeComponent()
        Me.userId = userId
        Me.capturedBillImage = capturedBillImage
    End Sub

    ' Form Load event to center the form on the screen
    Private Sub Thankyou_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm()
    End Sub

    ' Method to center the form on the screen
    Private Sub CenterForm()
        Dim x As Integer, y As Integer, r As Rectangle
        If Not Parent Is Nothing Then
            r = Parent.ClientRectangle
            x = r.Width - Me.Width + Parent.Left
            y = r.Height - Me.Height + Parent.Top
        Else
            r = Screen.PrimaryScreen.WorkingArea
            x = r.Width - Me.Width
            y = r.Height - Me.Height
        End If
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(CInt(x / 2), CInt(y / 2))
    End Sub

    ' Event to handle the Logout button click - close all open forms
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Try
            For Each frm As Form In Application.OpenForms.Cast(Of Form).ToList()
                frm.Close()
            Next
        Catch ex As Exception
            MessageBox.Show("An error occurred while logging out: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Event to handle the printing of the captured bill image
    Private Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs) Handles printDocument.PrintPage
        Try
            If capturedBillImage IsNot Nothing Then
                e.Graphics.DrawImage(capturedBillImage, 0, 0)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred during printing: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Event to handle the Print button click
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If Not isPrinting Then
            isPrinting = True ' Set flag to true to indicate printing is in progress

            Try
                Dim printDialog As New PrintDialog With {
                    .Document = printDocument
                }

                ' Display the print dialog and print if the user confirms
                If printDialog.ShowDialog() = DialogResult.OK Then
                    printDocument.Print()
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred during printing: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                isPrinting = False ' Reset the flag after printing
            End Try
        End If
    End Sub

    ' Form Closing event to ensure the PrintPage event handler is removed
    Private Sub Thankyou_Page_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        RemoveHandler printDocument.PrintPage, AddressOf PrintDocument_PrintPage
    End Sub

    ' MouseEnter and MouseLeave events for the Logout button
    Private Sub btnLogout_MouseEnter(sender As Object, e As EventArgs) Handles btnLogout.MouseEnter
        btnLogout.BackColor = Color.FromArgb(0, 191, 99) ' Highlight button on hover
        btnLogout.ForeColor = Color.White
    End Sub

    Private Sub btnLogout_MouseLeave(sender As Object, e As EventArgs) Handles btnLogout.MouseLeave
        btnLogout.BackColor = Color.White ' Revert button background color
        btnLogout.ForeColor = Color.FromArgb(0, 191, 99) ' Revert text color
    End Sub

    ' MouseEnter and MouseLeave events for the Print button
    Private Sub btnPrint_MouseEnter(sender As Object, e As EventArgs) Handles btnPrint.MouseEnter
        btnPrint.BackColor = Color.FromArgb(0, 175, 99) ' Highlight text on hover
    End Sub

    Private Sub btnPrint_MouseLeave(sender As Object, e As EventArgs) Handles btnPrint.MouseLeave
        btnPrint.BackColor = Color.FromArgb(0, 191, 99) ' Revert text color
    End Sub

End Class
