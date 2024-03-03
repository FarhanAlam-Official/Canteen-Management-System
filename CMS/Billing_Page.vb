Imports System.Drawing.Text
Imports System.Drawing.Printing
Imports System.Data.SqlClient
Imports System.Configuration

Public Class Billing_Page

    Dim connectionString As String = ConfigurationManager.ConnectionStrings("CMS.My.MySettings.CMSConnectionString").ConnectionString

    Private userId As Integer

    ' Constructor to accept user ID
    Public Sub New(userId As Integer)
        InitializeComponent()
        Me.userId = userId
    End Sub

    Private Sub Billing_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelparticulars.AutoScroll = True

        ' Centering the form in the middle of the parent form
        CenterForm()

        ' Display the current date and time
        lbldate.Text = DateTime.Now.ToString("yyyy-MM-dd")
        lbltime.Text = DateTime.Now.ToString("HH:mm:ss")

        ' Set other label contents
        lblName.Text = GetUsernameById(userId) ' Assuming this function retrieves username
        lblorderid.Text = " " ' Set this after creating the order
        lblPaymentMode.Text = " " ' Set this after selecting payment mode

        PopulateTable()
    End Sub

    ' Centering logic
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

    ' Custom font for table items
    Dim customFont As New Font("Trebuchet MS", 10, FontStyle.Regular)

    Private Sub PopulateTable()
        ' Clear any existing rows
        tbllayoutparticulars.Controls.Clear()
        tbllayoutparticulars.RowStyles.Clear()

        ' Reset the row count to 0 before adding new rows
        tbllayoutparticulars.RowCount = 0

        ' Set AutoSize to handle content dynamically
        tbllayoutparticulars.AutoSize = True
        tbllayoutparticulars.AutoSizeMode = AutoSizeMode.GrowAndShrink

        ' Iterate through each item in PlateItems
        For Each item As PlateItem In GlobalVariables.PlateItems
            ' Increment RowCount
            tbllayoutparticulars.RowCount += 1

            ' Set a uniform row height
            tbllayoutparticulars.RowStyles.Add(New RowStyle(SizeType.Absolute, 45)) ' Set fixed height for each row (30px)

            ' Create labels for name, quantity, price, total and add them to the new row
            tbllayoutparticulars.Controls.Add(CreateLabel(item.Name), 0, tbllayoutparticulars.RowCount - 1)
            tbllayoutparticulars.Controls.Add(CreateLabel(item.Quantity.ToString()), 1, tbllayoutparticulars.RowCount - 1)
            tbllayoutparticulars.Controls.Add(CreateLabel("Rs." & item.Price.ToString("F2")), 2, tbllayoutparticulars.RowCount - 1)
            tbllayoutparticulars.Controls.Add(CreateLabel("Rs." & (item.Price * item.Quantity).ToString("F2")), 3, tbllayoutparticulars.RowCount - 1)
        Next

        ' Call method to update billing details if needed
        UpdateBilling()
    End Sub

    ' Helper method to create labels
    Private Function CreateLabel(text As String) As Label
        Return New Label With {
            .Text = text,
            .Dock = DockStyle.Fill,
            .Font = customFont,
            .AutoSize = True,
            .TextAlign = ContentAlignment.MiddleCenter
        }
    End Function

    ' Update billing totals
    Private Sub UpdateBilling()
        Dim subtotalamt As Integer = 0
        Dim disamount As Decimal = 0

        For Each item As PlateItem In GlobalVariables.PlateItems
            subtotalamt += item.Quantity * item.Price
        Next

        lblsubtotalamt.Text = "Rs." & subtotalamt
        lbldisamt.Text = "Rs." & disamount
        lbltotalamt.Text = "Rs." & (subtotalamt - disamount)
    End Sub

    Private Function GetUsernameById(userId As Integer) As String
        Dim fullName As String = String.Empty
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT first_name, last_name FROM User_Details WHERE user_id = @userId"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@userId", userId)

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Combine first and last name
                        fullName = $"{reader("first_name")} {reader("last_name")}"
                    End If
                End Using
            End Using
        End Using
        Return fullName
    End Function

    ' Capture and print only the pnlBillarea
    Public Function CaptureBillArea() As Bitmap
        btnCash.Visible = False
        btnOnlinePayment.Visible = False
        Dim bmp As New Bitmap(pnlBillarea.Width, pnlBillarea.Height)
        pnlBillarea.DrawToBitmap(bmp, New Rectangle(0, 0, pnlBillarea.Width, pnlBillarea.Height))
        Return bmp
    End Function

    ' Handle online payment button click
    Private Sub btnonlinepayment_Click(sender As Object, e As EventArgs) Handles btnOnlinePayment.Click
        ' Insert order with pending status
        Dim orderId As Integer = CreateOrder("online", "pending")

        ' Update the Order ID and Payment Mode labels
        lblorderid.Text = " " & orderId
        lblPaymentMode.Text = "Online"

        ' Insert the order details for each product
        InsertOrderDetails(orderId)

        ' Clear the PlateItems after order is placed
        GlobalVariables.PlateItems.Clear()

        ' Show the online payment page
        Dim qrpayment As New Onlinepayment_page(userId, CaptureBillArea())
        qrpayment.Show()

        Me.Close()
    End Sub

    ' Handle cash payment button click
    Private Sub btncash_Click(sender As Object, e As EventArgs) Handles btnCash.Click
        ' Insert order with pending status
        Dim orderId As Integer = CreateOrder("cash", "pending")

        ' Update the Order ID and Payment Mode labels
        lblorderid.Text = " " & orderId
        lblPaymentMode.Text = "Cash"

        ' Insert the order details for each product
        InsertOrderDetails(orderId)

        ' Clear the PlateItems after order is placed
        GlobalVariables.PlateItems.Clear()

        ' Show the thank you page with the captured bill image
        Dim thankyoupage As New Thankyou_Page(userId, CaptureBillArea())
        thankyoupage.Show()
        Me.Close()

    End Sub
    Private Function CreateOrder(paymentMode As String, paymentStatus As String) As Integer
        Dim orderId As Integer = 0
        Dim totalAmount As Decimal = Convert.ToDecimal(lbltotalamt.Text.Replace("Rs.", "").Trim())

        ' Debugging: Check if userId exists
        If Not UserExists(userId) Then
            MessageBox.Show("User ID does not exist.")
            Return 0
        End If

        Using conn As New SqlConnection(connectionString)
            conn.Open()

            Dim orderQuery As String = "INSERT INTO Orders (customer_id, total_amount, status) VALUES (@customer_id, @total_amount, @status); SELECT SCOPE_IDENTITY();"
            Using orderCmd As New SqlCommand(orderQuery, conn)
                orderCmd.Parameters.AddWithValue("@customer_id", userId)
                orderCmd.Parameters.AddWithValue("@total_amount", totalAmount)
                orderCmd.Parameters.AddWithValue("@status", "pending")
                orderId = Convert.ToInt32(orderCmd.ExecuteScalar())
            End Using

            Dim paymentQuery As String = "INSERT INTO Payments (order_id, customer_id, amount, payment_mode, status) VALUES (@order_id, @customer_id, @amount, @payment_mode, @status)"
            Using paymentCmd As New SqlCommand(paymentQuery, conn)
                paymentCmd.Parameters.AddWithValue("@order_id", orderId)
                paymentCmd.Parameters.AddWithValue("@customer_id", userId)
                paymentCmd.Parameters.AddWithValue("@amount", totalAmount)
                paymentCmd.Parameters.AddWithValue("@payment_mode", paymentMode)
                paymentCmd.Parameters.AddWithValue("@status", paymentStatus)
                paymentCmd.ExecuteNonQuery()
            End Using
        End Using

        Return orderId
    End Function

    Private Function UserExists(userId As Integer) As Boolean
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT COUNT(*) FROM Users WHERE user_id = @userId"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@userId", userId)
                Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
            End Using
        End Using
    End Function


    ' Insert order details for each product and update inventory
    Private Sub InsertOrderDetails(orderId As Integer)
        Using conn As New SqlConnection(connectionString)
            conn.Open()

            ' First, validate stock availability for all items
            For Each item As PlateItem In GlobalVariables.PlateItems
                ' Check if quantity is available before updating
                Dim checkStockQuery As String = "
            SELECT quantity_in_stock FROM Inventory
            WHERE product_id = @product_id"

                Using checkStockCmd As New SqlCommand(checkStockQuery, conn)
                    checkStockCmd.Parameters.AddWithValue("@product_id", item.ProductId)
                    Dim stockAvailable As Integer = Convert.ToInt32(checkStockCmd.ExecuteScalar())

                    If stockAvailable < item.Quantity Then
                        MessageBox.Show("Only " & stockAvailable & " of '" & item.Name & "' is available. Please reduce the quantity.")
                        Exit Sub ' Stop the process if the quantity is more than the stock available
                    End If
                End Using
            Next

            ' If all stock is available, proceed to insert order details and update inventory
            For Each item As PlateItem In GlobalVariables.PlateItems
                Dim orderDetailsQuery As String = "
            INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price, discount)
            VALUES (@order_id, @product_id, @category_id, @quantity, @price, @discount)"

                Using orderDetailsCmd As New SqlCommand(orderDetailsQuery, conn)
                    orderDetailsCmd.Parameters.AddWithValue("@order_id", orderId)
                    orderDetailsCmd.Parameters.AddWithValue("@product_id", item.ProductId)
                    orderDetailsCmd.Parameters.AddWithValue("@category_id", item.CategoryId)
                    orderDetailsCmd.Parameters.AddWithValue("@quantity", item.Quantity)
                    orderDetailsCmd.Parameters.AddWithValue("@price", item.Price)
                    orderDetailsCmd.Parameters.AddWithValue("@discount", item.Discount)
                    orderDetailsCmd.ExecuteNonQuery()
                End Using

                ' Update inventory by reducing the quantity_in_stock
                Dim inventoryUpdateQuery As String = "
            UPDATE Inventory
            SET quantity_in_stock = quantity_in_stock - @quantity, last_updated = GETDATE()
            WHERE product_id = @product_id"

                Using inventoryUpdateCmd As New SqlCommand(inventoryUpdateQuery, conn)
                    inventoryUpdateCmd.Parameters.AddWithValue("@quantity", item.Quantity)
                    inventoryUpdateCmd.Parameters.AddWithValue("@product_id", item.ProductId)
                    inventoryUpdateCmd.ExecuteNonQuery()
                End Using
            Next
        End Using
    End Sub

    ' MouseEnter and MouseLeave events for the Cash button
    Private Sub btnCash_MouseEnter(sender As Object, e As EventArgs) Handles btnCash.MouseEnter
        btnCash.BackColor = Color.FromArgb(0, 175, 99) ' Darker green for hover effect
    End Sub

    Private Sub btnCash_MouseLeave(sender As Object, e As EventArgs) Handles btnCash.MouseLeave
        btnCash.BackColor = Color.FromArgb(0, 191, 99) ' Original color
    End Sub

    ' MouseEnter and MouseLeave events for the OnlinePayment button
    Private Sub btnOnlinePayment_MouseEnter(sender As Object, e As EventArgs) Handles btnOnlinePayment.MouseEnter
        btnOnlinePayment.BackColor = Color.FromArgb(0, 175, 99) ' Darker green for hover effect
    End Sub

    Private Sub btnOnlinePayment_MouseLeave(sender As Object, e As EventArgs) Handles btnOnlinePayment.MouseLeave
        btnOnlinePayment.BackColor = Color.FromArgb(0, 191, 99) ' Original color
    End Sub

End Class
