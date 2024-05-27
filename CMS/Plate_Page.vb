Public Class Plate_Page

    Private userId As Integer

    ' Constructor to accept user ID
    Public Sub New(userId As Integer)
        InitializeComponent()
        Me.userId = userId
    End Sub

    ' Plate_Page Load event to center the form and display plate items
    Private Sub Cart_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(1067, 650)
        plateItemsflowlayout.Size = New Size(1034, 621)
        Try
            CenterForm()
            DisplayPlateItems()
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading the page: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Method to center the form on the screen
    Private Sub CenterForm()
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

    ' Method to display plate items dynamically on the form
    Private Sub DisplayPlateItems()
        Try
            ' Clear existing controls
            plateItemsflowlayout.Controls.Clear()

            plateItemsflowlayout.AutoScroll = True
            plateItemsflowlayout.FlowDirection = FlowDirection.TopDown
            plateItemsflowlayout.WrapContents = False

            ' Loop through each item in PlateItems and add it to the UI
            For Each item As PlateItem In GlobalVariables.PlateItems
                ' Create a panel for the plate item
                Dim panel_plateItem As New Panel() With {
                    .BackColor = Color.White,
                    .Size = New Size(986, 161),
                    .Margin = New Padding(15, 30, 3, 3)
                }

                ' Create and configure PictureBox
                Dim pictureBox As New PictureBox() With {
                    .Location = New Point(17, 18),
                    .Size = New Size(144, 121),
                    .SizeMode = PictureBoxSizeMode.StretchImage,
                    .Image = item.Image
                }
                panel_plateItem.Controls.Add(pictureBox)

                ' Create and configure name label
                Dim nameLabel As New Label() With {
                    .AutoSize = True,
                    .Font = New Font("Trebuchet MS", 12.0!, FontStyle.Regular),
                    .Location = New Point(183, 44),
                    .Text = item.Name
                }
                panel_plateItem.Controls.Add(nameLabel)

                ' Create and configure price label
                Dim priceLabel As New Label() With {
                    .AutoSize = True,
                    .Font = New Font("Trebuchet MS", 10.2!, FontStyle.Regular),
                    .Location = New Point(183, 77),
                    .Text = "Rs. " & item.Price.ToString()
                }
                panel_plateItem.Controls.Add(priceLabel)

                ' Create and configure discount label
                Dim discountLabel As New Label() With {
                    .AutoSize = True,
                    .Font = New Font("Trebuchet MS", 10.2!, FontStyle.Regular),
                    .Location = New Point(183, 109),
                    .Text = "Discount: Rs 0"
                }
                panel_plateItem.Controls.Add(discountLabel)

                ' Create and configure the quantity panel with buttons
                Dim quantityPanel As New TableLayoutPanel() With {
                    .BackColor = Color.FromArgb(0, 191, 99),
                    .ColumnCount = 3,
                    .Location = New Point(524, 55),
                    .Size = New Size(151, 43)
                }
                quantityPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 39.0!))
                quantityPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 73.0!))
                quantityPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 39.0!))

                ' Create and configure decrease button
                Dim decreaseButton As New Button() With {
                    .FlatStyle = FlatStyle.Flat,
                    .Font = New Font("Trebuchet MS", 16.0!, FontStyle.Bold),
                    .Text = "-",
                    .Dock = DockStyle.Fill
                }
                decreaseButton.FlatAppearance.BorderColor = Color.FromArgb(0, 191, 99)
                AddHandler decreaseButton.Click, Sub(sender, e) UpdateQuantity(item, -1)
                quantityPanel.Controls.Add(decreaseButton, 0, 0)

                ' Create and configure quantity label
                Dim quantityLabel As New Label() With {
                    .AutoSize = True,
                    .Dock = DockStyle.Fill,
                    .Font = New Font("Trebuchet MS", 10.2!, FontStyle.Regular),
                    .Text = item.Quantity.ToString(),
                    .TextAlign = ContentAlignment.MiddleCenter
                }
                quantityPanel.Controls.Add(quantityLabel, 1, 0)

                ' Create and configure increase button
                Dim increaseButton As New Button() With {
                    .FlatStyle = FlatStyle.Flat,
                    .Font = New Font("Trebuchet MS", 16.0!, FontStyle.Regular),
                    .Text = "+",
                    .Dock = DockStyle.Fill
                }
                increaseButton.FlatAppearance.BorderColor = Color.FromArgb(0, 191, 99)
                AddHandler increaseButton.Click, Sub(sender, e) UpdateQuantity(item, 1)
                quantityPanel.Controls.Add(increaseButton, 2, 0)

                panel_plateItem.Controls.Add(quantityPanel)

                ' Create and configure delete button
                Dim deleteButton As New Button() With {
                    .BackgroundImage = Global.CMS.My.Resources.Resources.delete2,
                    .BackgroundImageLayout = ImageLayout.Zoom,
                    .FlatStyle = FlatStyle.Flat,
                    .Dock = DockStyle.Right,
                    .Location = New Point(899, 0),
                    .Size = New Size(87, 161)
                }
                deleteButton.FlatAppearance.BorderColor = Color.White
                AddHandler deleteButton.Click, Sub(sender, e) DeleteItem(item)
                panel_plateItem.Controls.Add(deleteButton)

                ' Add the panel to the FlowLayoutPanel
                plateItemsflowlayout.Controls.Add(panel_plateItem)
            Next

            ' Refresh the layout
            plateItemsflowlayout.Refresh()
            plateItemsflowlayout.PerformLayout()

            ' Calculate billing after displaying items
            CalculateBilling()
        Catch ex As Exception
            MessageBox.Show("An error occurred while displaying items: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Update the quantity of a given item
    Private Sub UpdateQuantity(item As PlateItem, change As Integer)
        Try
            item.Quantity += change
            If item.Quantity < 0 Then
                item.Quantity = 0
            End If
            DisplayPlateItems()
        Catch ex As Exception
            MessageBox.Show("An error occurred while updating quantity: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Delete a specific item from the list
    Private Sub DeleteItem(item As PlateItem)
        Try
            ' Remove the item from the global collection
            GlobalVariables.PlateItems.Remove(item)

            ' Re-display the items (this will clear and re-render the layout)
            DisplayPlateItems()

            ' Force the layout to recalculate and update the controls
            plateItemsflowlayout.Refresh()  ' Repaint the control
            plateItemsflowlayout.PerformLayout()  ' Force layout changes
            plateItemsflowlayout.Update()  ' Process any pending painting
        Catch ex As Exception
            MessageBox.Show("An error occurred while deleting item: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' Calculate and display the billing details
    Private Sub CalculateBilling()
        Try
            Dim subtotal As Integer = 0
            Dim discount As Decimal = 0

            For Each item As PlateItem In GlobalVariables.PlateItems
                subtotal += item.Quantity * item.Price
                ' Apply discount logic here, currently it's just zero
            Next

            lblsubtotalamt.Text = "Rs. " & subtotal
            lbldisamt.Text = "Rs. " & discount
            lbltotalamt.Text = "Rs. " & (subtotal - discount)
        Catch ex As Exception
            MessageBox.Show("An error occurred during billing calculation: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Click event for the "Bring Plate" button, which navigates to the Billing_Page
    Private Sub btnBringPlate_Click(sender As Object, e As EventArgs) Handles btnBringPlate.Click
        Try
            Dim billingPage As New Billing_Page(userId)
            billingPage.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred while opening the billing page: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' MouseEnter and MouseLeave events for the Bring Plate button
    Private Sub btnBringPlate_MouseEnter(sender As Object, e As EventArgs) Handles btnBringPlate.MouseEnter
        btnBringPlate.BackColor = Color.FromArgb(0, 175, 99) ' Darker green for hover effect
    End Sub

    Private Sub btnBringPlate_MouseLeave(sender As Object, e As EventArgs) Handles btnBringPlate.MouseLeave
        btnBringPlate.BackColor = Color.FromArgb(0, 191, 99) ' Original color
    End Sub

End Class
