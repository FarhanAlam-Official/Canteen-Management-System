Imports System.Configuration
Imports System.Data.SqlClient

Public Class Menu_Page

    Dim connectionString As String = ConfigurationManager.ConnectionStrings("CMS.My.MySettings.CMSConnectionString").ConnectionString
    Private userId As Integer

    ' Constructor to accept user ID
    Public Sub New(userId As Integer)
        InitializeComponent()
        Me.userId = userId
    End Sub

    Private Sub Menu_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Centering the form in the middle of the parent form
        CenterForm()

        ' Call the function in load event to add menu items
        AddProductGroupBoxes()
    End Sub

    ' Center the form in the middle of the screen or parent
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

    ' Dynamically add GroupBoxes for products with availability and status check
    Private Sub AddProductGroupBoxes()
        ' Fetch menu items and their product details
        Dim productsWithMenu As DataTable = GetProductsFromMenu()

        ' Dynamically create UI elements for each product
        For Each row As DataRow In productsWithMenu.Rows
            ' Create and configure the panel for each menu item
            Dim panel_menuitems As New Panel()
            panel_menuitems.BackColor = Color.White
            panel_menuitems.Padding = New Padding(0)
            panel_menuitems.Size = New Size(227, 267)
            panel_menuitems.BorderStyle = BorderStyle.None
            panel_menuitems.Location = New Point(40)
            panel_menuitems.Margin = New Padding(25, 30, 3, 3)
            panel_menuitems.Name = "panel_menuitem"

            ' Create and configure the stock alert label for availability
            Dim stockAlertLabel As New Label()
            stockAlertLabel.AutoSize = True
            stockAlertLabel.Font = New Font("Tahoma", 9.0!)
            stockAlertLabel.ForeColor = Color.Red
            stockAlertLabel.Location = New Point(44, 195)
            stockAlertLabel.Text = "Not available now!!"

            ' Check availability by time, status, and inventory quantity
            Dim available As Boolean = IsProductAvailable(row("available_from"), row("available_to"), row("status")) AndAlso IsProductInStock(row("product_id"))
            stockAlertLabel.Visible = Not available
            panel_menuitems.Controls.Add(stockAlertLabel)

            ' Create and configure the picture box for product image
            Dim pictureBox As New PictureBox()
            pictureBox.Image = Image.FromFile(row("image_url")) ' Replace with actual image or resource
            pictureBox.Location = New Point(30, 21)
            pictureBox.Size = New Size(169, 127)
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage
            panel_menuitems.Controls.Add(pictureBox)

            ' Create and configure the price label
            Dim priceLabel As New Label()
            priceLabel.AutoSize = True
            priceLabel.Font = New Font("Tahoma", 9.0!)
            priceLabel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
            priceLabel.Location = New Point(147, 235)
            priceLabel.Text = "Rs. " & row("price").ToString() ' Display product price
            panel_menuitems.Controls.Add(priceLabel)

            ' Create and configure the name label
            Dim nameLabel As New Label()
            nameLabel.AutoSize = True
            nameLabel.Font = New Font("Tahoma", 10.2!, FontStyle.Regular, GraphicsUnit.Point, 0)
            nameLabel.Location = New Point(47, 163)
            nameLabel.Text = row("product_name").ToString() ' Display product name
            panel_menuitems.Controls.Add(nameLabel)

            ' Create and configure the "Add to Plate" button
            Dim btn_addtoplate As New RoundedButton()
            btn_addtoplate.BackColor = If(available, System.Drawing.Color.FromArgb(0, 191, 99), Color.Black)
            btn_addtoplate.CornerRadius = 28
            btn_addtoplate.FlatAppearance.BorderColor = System.Drawing.Color.White
            btn_addtoplate.FlatAppearance.BorderSize = 5
            btn_addtoplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            btn_addtoplate.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            btn_addtoplate.ForeColor = If(available, System.Drawing.Color.White, Color.White) ' Set white text for disabled button too
            btn_addtoplate.Location = New Point(12, 226)
            btn_addtoplate.Name = "btn_addtoplate"
            btn_addtoplate.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
            btn_addtoplate.Size = New Size(100, 32)
            btn_addtoplate.TabIndex = 1
            btn_addtoplate.Text = If(available, "ADD TO PLATE", "ADD TO PLATE")
            btn_addtoplate.UseVisualStyleBackColor = False
            btn_addtoplate.Enabled = available ' Disable button if not available
            panel_menuitems.Controls.Add(btn_addtoplate)

            If available Then
                ' Add click and hover events for the button
                AddHandler btn_addtoplate.Click, Sub(sender As Object, e As EventArgs)
                                                     AddToPlate(row, btn_addtoplate)
                                                 End Sub
                AddHandler btn_addtoplate.MouseEnter, Sub(sender As Object, e As EventArgs)
                                                          btn_addtoplate.BackColor = Color.FromArgb(0, 171, 99)
                                                      End Sub
                AddHandler btn_addtoplate.MouseLeave, Sub(sender As Object, e As EventArgs)
                                                          btn_addtoplate.BackColor = Color.FromArgb(0, 191, 99)
                                                      End Sub
            End If

            ' Add the panel to the form's menu area
            Menuarea.Controls.Add(panel_menuitems)
        Next
    End Sub

    ' Method to check if product is available based on availability time, status, and stock
    Private Function IsProductAvailable(availableFromObj As Object, availableToObj As Object, status As Integer) As Boolean
        ' Check product status first (status: 1 = available, 0 = not available)
        If status = 0 Then
            Return False
        End If

        ' Check if the current time is within the specified availability time range
        If IsDBNull(availableFromObj) Or IsDBNull(availableToObj) Then
            Return False ' If either availableFromObj or availableToObj is DBNull, product is not available
        End If

        Dim currentTime As TimeSpan = DateTime.Now.TimeOfDay
        Dim availableFrom As TimeSpan
        Dim availableTo As TimeSpan

        If TimeSpan.TryParse(availableFromObj.ToString(), availableFrom) AndAlso TimeSpan.TryParse(availableToObj.ToString(), availableTo) Then
            Return currentTime >= availableFrom AndAlso currentTime <= availableTo
        Else
            Return False ' If parsing fails, assume product is not available
        End If
    End Function

    ' Method to check if product is available in stock
    Private Function IsProductInStock(productId As Integer) As Boolean
        Dim query As String = "SELECT quantity_in_stock FROM Inventory WHERE product_id = @product_id"
        Dim stockAvailable As Integer = 0

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@product_id", productId)
                conn.Open()
                stockAvailable = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End Using

        ' Return true if stock is greater than zero, else false
        Return stockAvailable > 0
    End Function

    ' Retrieve data from the Menu table with associated product information
    Public Function GetProductsFromMenu() As DataTable
        Dim query As String = "
        SELECT Distinct p.product_id, p.product_name, p.price, p.image_url, 
               m.menu_id, m.available_from, m.available_to, m.status,
               c.category_name AS Category, c.category_id AS CategoryId
        FROM Menu m
        JOIN Products p ON m.product_id = p.product_id
        JOIN Categories c ON p.category_id = c.category_id
        WHERE m.status = 1" ' Only fetch available products from the menu and categories

        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    dataTable.Load(reader) ' Load the results into the DataTable
                End Using
            End Using
        End Using

        Return dataTable
    End Function

    ' Method to add a product to the plate/cart
    Private Sub AddToPlate(row As DataRow, addButton As Button)
        Dim productId As Integer = Convert.ToInt32(row("product_id"))
        Dim productName As String = row("product_name").ToString()
        Dim productPrice As Decimal = Convert.ToDecimal(row("price"))
        Dim imageUrl As String = row("image_url").ToString()
        Dim category As String = row("Category").ToString()
        Dim categoryId As Integer = Convert.ToInt32(row("CategoryId"))
        Dim discount As Decimal = 0

        ' Check if the image file exists before loading it
        Dim productImage As Image = Nothing
        If IO.File.Exists(imageUrl) Then
            productImage = Image.FromFile(imageUrl)
        Else
            productImage = My.Resources.DefaultProductImage ' Use default image if file not found
        End If

        ' Check if the product is already in the plate/cart
        Dim existingItem As PlateItem = GlobalVariables.PlateItems.FirstOrDefault(Function(i) i.ProductId = productId)

        If existingItem IsNot Nothing Then
            ' If the product is already in the plate, increase the quantity
            existingItem.Quantity += 1
        Else
            ' If the product is not in the plate, add it as a new item
            Dim plateItem As New PlateItem With {
            .ProductId = productId,
            .Name = productName,
            .Price = productPrice,
            .Quantity = 1,
            .Image = productImage,
            .Category = category,
            .CategoryId = categoryId,
            .Discount = discount
        }
            GlobalVariables.PlateItems.Add(plateItem)
        End If

        ' Change the button text to "ADDED ✓"
        addButton.Text = "ADDED ✓"

        ' Use a timer to reset the button text back to the original after 3 seconds
        addPlateTimer.Interval = 500 ' 0.5 seconds
        addPlateTimer.Tag = addButton ' Store the button reference in the timer tag
        AddHandler addPlateTimer.Tick, AddressOf ResetButtonText
        addPlateTimer.Start()
    End Sub

    ' Timer event handler to reset the button text
    Private Sub ResetButtonText(sender As Object, e As EventArgs)
        Dim timer As Timer = CType(sender, Timer)
        Dim button As Button = CType(timer.Tag, Button)

        ' Reset the button text to the original state
        button.Text = "ADD TO PLATE"

        ' Stop the timer
        timer.Stop()
        RemoveHandler addPlateTimer.Tick, AddressOf ResetButtonText
    End Sub
    ' Timer to reset the "Add to Plate" button text
    Private Sub addPlateTimer_Tick(sender As Object, e As EventArgs) Handles addPlateTimer.Tick
        Dim addButton As Button = CType(addPlateTimer.Tag, Button)
        addButton.Text = "ADD TO PLATE"
        addPlateTimer.Stop()
    End Sub

    Private Sub btnViewPlate_Click(sender As Object, e As EventArgs) Handles btnViewPlate.Click
        Dim viewplate As New Plate_Page(userId)
        viewplate.Show()
    End Sub

    Private Sub BtnViewPlate_MouseEnter(sender As Object, e As EventArgs) Handles btnViewPlate.MouseEnter
        btnViewPlate.BackColor = Color.FromArgb(0, 175, 99) ' shade for hover
        btnViewPlate.ForeColor = Color.White
    End Sub

    Private Sub btnViewPlate_MouseLeave(sender As Object, e As EventArgs) Handles btnViewPlate.MouseLeave
        btnViewPlate.BackColor = Color.FromArgb(0, 191, 99)
        btnViewPlate.ForeColor = Color.White ' Original color
    End Sub
End Class
