Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class Admin_Page
    ' Track the sidebar state (collapsed or expanded)
    Private isCollapsed As Boolean = False
    Private WithEvents sidebarTransitionTimer As New Timer With {.Interval = 18}
    Private targetWidth As Integer ' Width to transition to

    ' Constants for sidebar dimensions and colors
    Private Const EXPAND_WIDTH As Integer = 200
    Private Const COLLAPSED_WIDTH As Integer = 80
    Private ReadOnly DefaultBackClr As Color = Color.Black
    Private ReadOnly PanelHoverColor As Color = Color.WhiteSmoke
    Private ReadOnly ButtonHoverColor As Color = PanelHoverColor
    Private ReadOnly ButtonTextHoverColor As Color = Color.Black

    ' Radius for rounded corners
    Private rad As Integer = 50

    ' Dictionaries to store original colors of UI elements
    Private originalPanelColors As New Dictionary(Of Panel, Color)
    Private originalButtonColors As New Dictionary(Of Button, Color)
    Private originalButtonTextColors As New Dictionary(Of Button, Color)
    Private originalPictureBoxColors As New Dictionary(Of PictureBox, Color)

    ' Admin_Page Load event
    Private Sub Admin_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Apply rounded corners and default dashboard on load
        SetRoundedCorners()
        Try
            ' Load the default control (Dashboard) on startup
            LoadForm(New Dashboard_Page())

            ' Attach hover and click events for sidebar panels
            AddSidebarHoverAndClickEvents()

        Catch ex As Exception
            MessageBox.Show("An error occurred during page load: " & ex.Message)
        End Try
    End Sub

    ' Toggle sidebar (expand or collapse) on double-click
    Private Sub pnlSidebar_DoubleClick(sender As Object, e As EventArgs) Handles pnlSidebar.DoubleClick
        Try
            If isCollapsed Then
                ' Expand the sidebar
                StartSidebarTransition(EXPAND_WIDTH)
                ToggleButtonText(True)
            Else
                ' Collapse the sidebar
                StartSidebarTransition(COLLAPSED_WIDTH)
                ToggleButtonText(False)
            End If
            isCollapsed = Not isCollapsed
        Catch ex As Exception
            MessageBox.Show("An error occurred while toggling sidebar: " & ex.Message)
        End Try
    End Sub

    ' Start the sidebar transition animation
    Private Sub StartSidebarTransition(target As Integer)
        targetWidth = target
        sidebarTransitionTimer.Start()
    End Sub

    ' Smooth sidebar transition using Timer
    Private Sub sidebarTransitionTimer_Tick(sender As Object, e As EventArgs) Handles sidebarTransitionTimer.Tick
        Try
            If pnlSidebar.Width <> targetWidth Then
                ' Smoothly adjust the width step by step
                Dim stepSize As Integer = Math.Sign(targetWidth - pnlSidebar.Width) * 10
                pnlSidebar.Width += stepSize

                ' Stop timer once the target width is reached
                If Math.Abs(pnlSidebar.Width - targetWidth) < Math.Abs(stepSize) Then
                    pnlSidebar.Width = targetWidth
                    sidebarTransitionTimer.Stop()
                End If
            Else
                sidebarTransitionTimer.Stop()
            End If

            ' Reapply rounded corners after resizing
            SetRoundedCorners()

        Catch ex As Exception
            MessageBox.Show("An error occurred during sidebar transition: " & ex.Message)
        End Try
    End Sub

    ' Toggle button text visibility based on sidebar state
    Private Sub ToggleButtonText(showText As Boolean)
        For Each pnl As Panel In pnlSidebar.Controls.OfType(Of Panel)()
            For Each ctrl In pnl.Controls
                If TypeOf ctrl Is Button Then
                    Dim button = DirectCast(ctrl, Button)
                    If showText Then
                        button.Text = button.Tag.ToString() ' Restore button text
                    Else
                        button.Tag = button.Text ' Store button text in Tag
                        button.Text = "" ' Hide button text
                    End If
                End If
            Next
        Next
    End Sub

    ' Load the correct form based on the clicked panel
    Private Sub LoadPanelForm(pnl As Panel)
        Try
            Select Case pnl.Name
                Case "pnlDashboard"
                    LoadForm(New Dashboard_Page())
                Case "pnlAnalytics"
                    LoadForm(New Analytics_Page())
                Case "pnlPayments"
                    LoadForm(New Payments_Page())
                Case "pnlUsers"
                    LoadForm(New Users_Page())
                Case "pnlProducts"
                    LoadForm(New Products_Page())
                Case "pnlSuppliers"
                    LoadForm(New Suppliers_Page())
                Case "pnlInventory"
                    LoadForm(New Inventory_Page())
                Case "pnlOrders"
                    LoadForm(New Orders_Page())
                Case "pnlMenu"
                    LoadForm(New MenuManage_Page())
            End Select
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading panel form: " & ex.Message)
        End Try
    End Sub

    ' Load the form inside the main panel
    Private Sub LoadForm(form As Form)
        Try
            pnlMain.Controls.Clear() ' Clear existing controls
            form.FormBorderStyle = FormBorderStyle.None ' Remove form border
            form.TopLevel = False ' Make it a child control
            form.Dock = DockStyle.Fill ' Fill the panel
            pnlMain.Controls.Add(form)
            form.Show() ' Display the form
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading form: " & ex.Message)
        End Try
    End Sub

    ' Attach hover and click events for all relevant sidebar panels and controls
    Private Sub AddSidebarHoverAndClickEvents()
        ' Add hover effects and click events for each panel, picture box, and button
        AddHoverEffectAndClick(pnlDashboard, PicboxDashboard, btnDashboard)
        AddHoverEffectAndClick(pnlAnalytics, PicboxAnalytics, btnAnalytics)
        AddHoverEffectAndClick(pnlPayments, picboxPayments, btnPayments)
        AddHoverEffectAndClick(pnlUsers, picboxUsers, btnUsers)
        AddHoverEffectAndClick(pnlProducts, picboxProducts, btnProducts)
        AddHoverEffectAndClick(pnlSuppliers, picboxSuppliers, btnSuppliers)
        AddHoverEffectAndClick(pnlInventory, picboxInventory, btnInventory)
        AddHoverEffectAndClick(pnlOrders, picboxOrders, btnOrders)
        AddHoverEffectAndClick(pnlMenu, picboxMenu, btnMenu)
    End Sub

    ' Add hover effects and click events for panels, picture boxes, and buttons
    Private Sub AddHoverEffectAndClick(pnl As Panel, picbox As PictureBox, btn As Button)
        ' Store original background and text colors if not already stored
        If Not originalPanelColors.ContainsKey(pnl) Then
            originalPanelColors(pnl) = pnl.BackColor
        End If
        If Not originalPictureBoxColors.ContainsKey(picbox) Then
            originalPictureBoxColors(picbox) = picbox.BackColor
        End If
        If Not originalButtonColors.ContainsKey(btn) Then
            originalButtonColors(btn) = btn.BackColor
        End If
        If Not originalButtonTextColors.ContainsKey(btn) Then
            originalButtonTextColors(btn) = btn.ForeColor
        End If

        ' Attach hover and leave events for both picture boxes and buttons
        AddHandler picbox.MouseEnter, Sub(sender, e) ApplyHoverEffect(pnl, picbox, btn)
        AddHandler btn.MouseEnter, Sub(sender, e) ApplyHoverEffect(pnl, picbox, btn)

        AddHandler picbox.MouseLeave, Sub(sender, e) RevertHoverEffect(pnl, picbox, btn)
        AddHandler btn.MouseLeave, Sub(sender, e) RevertHoverEffect(pnl, picbox, btn)

        ' Attach click events
        AddHandler picbox.Click, Sub(sender, e) HandleClickEffect(picbox, pnl)
        AddHandler btn.Click, Sub(sender, e) HandleClickEffect(btn, pnl)
    End Sub

    ' Apply hover effect for buttons and picture boxes
    Private Sub ApplyHoverEffect(pnl As Panel, picbox As PictureBox, btn As Button)
        pnl.BackColor = PanelHoverColor
        picbox.BackColor = PanelHoverColor
        btn.BackColor = ButtonHoverColor
        btn.ForeColor = ButtonTextHoverColor
    End Sub

    ' Revert hover effect on panel, picture box, and button
    Private Sub RevertHoverEffect(pnl As Panel, picbox As PictureBox, btn As Button)
        pnl.BackColor = originalPanelColors(pnl)
        picbox.BackColor = originalPictureBoxColors(picbox)
        btn.BackColor = originalButtonColors(btn)
        btn.ForeColor = originalButtonTextColors(btn)
    End Sub

    ' Handle click effect and load the corresponding user control
    Private Sub HandleClickEffect(ctrl As Control, pnl As Panel)
        Try
            ApplyHoverEffect(pnl, GetAssociatedPictureBox(pnl), GetAssociatedButton(pnl))

            ' Temporary click effect timer
            Using clickFeedbackTimer As New Timer With {.Interval = 200}
                AddHandler clickFeedbackTimer.Tick, Sub(sender, e)
                                                        RevertHoverEffect(pnl, GetAssociatedPictureBox(pnl), GetAssociatedButton(pnl))
                                                        clickFeedbackTimer.Stop()
                                                    End Sub
                clickFeedbackTimer.Start()
            End Using

            ' Load the corresponding form based on the clicked panel
            LoadPanelForm(pnl)

        Catch ex As Exception
            MessageBox.Show("An error occurred while handling click effect: " & ex.Message)
        End Try
    End Sub

    ' Helper function to get the associated PictureBox from a panel
    Private Function GetAssociatedPictureBox(pnl As Panel) As PictureBox
        Return pnl.Controls.OfType(Of PictureBox)().FirstOrDefault()
    End Function

    ' Helper function to get the associated Button from a panel
    Private Function GetAssociatedButton(pnl As Panel) As Button
        Return pnl.Controls.OfType(Of Button)().FirstOrDefault()
    End Function

    ' Function to create a rounded rectangle for custom painting
    Private Function CreateRoundedRectangle(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        path.AddArc(rect.Left, rect.Top, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Top, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.Left, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseAllFigures()
        Return path
    End Function

    ' Apply rounded corners to the sidebar panel
    Private Sub SetRoundedCorners()
        pnlSidebar.Region = New Region(CreateRoundedRectangle(pnlSidebar.ClientRectangle, rad))
    End Sub

    ' Control hover effects (both for buttons and picture boxes)
    Private Sub Control_MouseEnter(sender As Object, e As EventArgs)
        Dim control = DirectCast(sender, Control)
        If control IsNot Nothing Then
            ApplyHoverEffect(DirectCast(control.Parent, Panel), GetAssociatedPictureBox(control.Parent), GetAssociatedButton(control.Parent))
        End If
    End Sub

    Private Sub Control_MouseLeave(sender As Object, e As EventArgs)
        Dim control = DirectCast(sender, Control)
        If control IsNot Nothing Then
            RevertHoverEffect(DirectCast(control.Parent, Panel), GetAssociatedPictureBox(control.Parent), GetAssociatedButton(control.Parent))
        End If
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

End Class
