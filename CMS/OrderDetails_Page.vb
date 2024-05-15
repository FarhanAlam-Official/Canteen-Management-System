Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO

Public Class OrderDetails_Page
    Private orderID As Integer
    ' Connection string to connect to the database
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("CMS.My.MySettings.CMSConnectionString").ConnectionString

    ' Constructor to initialize form with a specific Order ID
    Public Sub New(order_id As Integer)
        InitializeComponent() ' Initialize form components
        Me.orderID = order_id ' Store the order ID for use
    End Sub

    ' Constructor to initialize form with a default Order ID
    Public Sub New()
        InitializeComponent() ' Initialize form components
        Me.orderID = 133 ' Store default order ID
    End Sub

    ' Form Load event handler
    Private Sub OrderDetails_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlProduct1.Hide() ' Hide the template panel initially
        LoadOrderDetails(orderID) ' Load order details based on the Order ID
        CenterForm() ' Center the form on the screen
    End Sub

    ' Method to center the form on the screen
    Private Sub CenterForm()
        Dim x, y As Integer
        Dim r As Rectangle

        ' Calculate the coordinates based on parent or screen size
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

        ' Set the form's position manually
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(x, y)
    End Sub

    ' Method to load order details from the database
    Private Sub LoadOrderDetails(order_id As Integer)
        ' SQL query to fetch order and payment details
        Dim queryOrder As String = "
            SELECT O.order_id, O.order_date, O.status AS order_status, 
                   U.first_name + ' ' + U.last_name AS customer_name, P.payment_id,
                   P.payment_mode, P.status AS payment_status, P.amount, P.payment_date 
            FROM Orders O
            JOIN User_Details U ON O.customer_id = U.user_id
            LEFT JOIN Payments P ON O.order_id = P.order_id
            WHERE O.order_id = @order_id"

        ' SQL query to fetch product details for the order
        Dim queryOrderDetails As String = "
            SELECT OD.product_id, P.product_name, OD.quantity, P.price As Product_Price, OD.discount, P.image_url
            FROM Order_Details OD
            JOIN Products P ON OD.product_id = P.product_id
            WHERE OD.order_id = @order_id"

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open() ' Open the database connection

                ' Fetch order and payment details
                Using cmdOrder As New SqlCommand(queryOrder, conn)
                    cmdOrder.Parameters.AddWithValue("@order_id", order_id)
                    Using reader As SqlDataReader = cmdOrder.ExecuteReader()
                        If reader.Read() Then
                            ' Set order details in the UI labels
                            lblOrderIDVal.Text = reader("order_id").ToString()
                            lblCustomerName.Text = reader("customer_name").ToString()
                            lblPaymentModeVal.Text = reader("payment_mode").ToString()
                            lblProductIDVal.Text = reader("payment_id").ToString()
                            lblDateTime.Text = reader("payment_date").ToString()

                            ' Set order status label and color based on status
                            Dim orderStatus As String = reader("order_status").ToString()
                            lblOrderStatusVal.Text = orderStatus
                            Select Case orderStatus
                                Case "completed", "Completed"
                                    lblOrderStatusVal.ForeColor = Color.Green
                                Case "pending", "Pending"
                                    lblOrderStatusVal.ForeColor = Color.OrangeRed
                                Case "cancelled", "Cancelled"
                                    lblOrderStatusVal.ForeColor = Color.Red
                                Case Else
                                    lblOrderStatusVal.ForeColor = Color.Black
                            End Select

                            ' Set payment status label and color based on status
                            Dim paymentStatus As String = reader("payment_status").ToString().ToLower()
                            lblPaymentStatusVal.Text = paymentStatus
                            Select Case paymentStatus
                                Case "completed"
                                    lblPaymentStatusVal.ForeColor = Color.Green
                                Case "pending"
                                    lblPaymentStatusVal.ForeColor = Color.OrangeRed
                                Case "cancelled"
                                    lblPaymentStatusVal.ForeColor = Color.Red
                                Case Else
                                    lblPaymentStatusVal.ForeColor = Color.Black
                            End Select

                        Else
                            MessageBox.Show("Order not found.", "Error")
                            Return
                        End If
                    End Using
                End Using

                ' Fetch product details and dynamically add them to the FlowLayoutPanel
                Dim subtotal As Decimal = 0
                Dim totalDiscount As Decimal = 0

                Using cmdOrderDetails As New SqlCommand(queryOrderDetails, conn)
                    cmdOrderDetails.Parameters.AddWithValue("@order_id", order_id)
                    Using reader As SqlDataReader = cmdOrderDetails.ExecuteReader()
                        Dim productIndex As Integer = 1
                        While reader.Read()
                            ' Extract product details from the database
                            Dim productName As String = reader("product_name").ToString()
                            Dim quantity As Integer = Convert.ToInt32(reader("quantity"))
                            Dim price As Decimal = Convert.ToDecimal(reader("Product_Price"))
                            Dim discount As Decimal = If(IsDBNull(reader("discount")), 0, Convert.ToDecimal(reader("discount")))
                            Dim imageUrl As String = reader("image_url").ToString()

                            ' Add a new product panel to the FlowLayoutPanel
                            AddProductPanel(productIndex, productName, quantity, price, discount, imageUrl)
                            productIndex += 1

                            ' Calculate totals
                            subtotal += (price * quantity)
                            totalDiscount += discount
                        End While
                    End Using
                End Using

                ' Calculate and display the totals
                Dim total As Decimal = subtotal - totalDiscount
                lblsubtotalamt.Text = "Rs. " & subtotal.ToString("F2")
                lbldisamt.Text = "Rs. " & totalDiscount.ToString("F2")
                lbltotalamt.Text = "Rs. " & total.ToString("F2")
            End Using

        Catch ex As SqlException
            ' Handle SQL-specific errors
            MessageBox.Show("Database error: " & ex.Message, "Error")
        Catch ex As Exception
            ' Handle general errors
            MessageBox.Show("Error loading order details: " & ex.Message, "Error")
        End Try
    End Sub

    ' Method to dynamically add a product panel to the UI
    Private Sub AddProductPanel(index As Integer, productName As String, quantity As Integer, price As Decimal, discount As Decimal, imageUrl As String)

        ' Clone the template panel (pnlProduct1)
        Dim newPanel As New Panel With {
            .Size = pnlProduct1.Size,
            .BackColor = pnlProduct1.BackColor,
            .Margin = pnlProduct1.Margin
        }

        ' Create and add a label for the product name
        Dim lblProductName As New Label With {
            .Text = productName,
            .ForeColor = Color.FromArgb(0, 191, 99),
            .Font = lblProductName1.Font,
            .Location = lblProductName1.Location
        }
        newPanel.Controls.Add(lblProductName)

        ' Create and add a label for the product price
        Dim lblPrice As New Label With {
            .Text = "Price: Rs. " & price.ToString("F2"),
            .Font = lblProductPrice1.Font,
            .Location = lblProductPrice1.Location,
            .Size = lblProductPrice1.Size
        }
        newPanel.Controls.Add(lblPrice)

        ' Create and add a label for the product quantity
        Dim lblQuantity As New Label With {
            .Text = "Quantity: " & quantity.ToString(),
            .Font = lblProductQuantity1.Font,
            .Location = lblProductQuantity1.Location,
            .Size = lblProductQuantity1.Size
        }
        newPanel.Controls.Add(lblQuantity)

        ' Create and add a label for the product discount
        Dim lblDiscount As New Label With {
            .Text = If(discount = 0, "Discount: NA", "Discount: Rs. " & discount.ToString("F2")),
            .Font = lblProductDiscount1.Font,
            .Location = lblProductDiscount1.Location,
            .Size = lblProductDiscount1.Size
        }
        newPanel.Controls.Add(lblDiscount)

        ' Create and add a PictureBox for the product image
        Dim picboxProduct As New PictureBox With {
            .Size = picboxProduct1.Size,
            .Location = picboxProduct1.Location,
            .SizeMode = PictureBoxSizeMode.StretchImage
        }

        ' Attempt to load the product image from the provided URL
        Try
            If Not String.IsNullOrEmpty(imageUrl) AndAlso File.Exists(imageUrl) Then
                picboxProduct.Image = Image.FromFile(imageUrl)
            Else
                picboxProduct.Image = Nothing ' Display nothing if the image is not found
            End If
        Catch ex As FileNotFoundException
            MessageBox.Show("Image file not found: " & ex.Message, "Image Error")
        Catch ex As Exception
            MessageBox.Show("Error loading product image: " & ex.Message, "Image Error")
        End Try

        ' Add the PictureBox to the panel
        newPanel.Controls.Add(picboxProduct)

        ' Add the new product panel to the FlowLayoutPanel
        ftlayoutProducts.Controls.Add(newPanel)
    End Sub
End Class
