Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.IO ' For file operations

Public Class Products_Page

    ' Connection string to the database
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("CMS.My.MySettings.CMSConnectionString").ConnectionString

    ' Default image path in case no image is provided
    Private ReadOnly defaultImagePath As String = Path.Combine(Application.StartupPath, "Images", "DefaultProductImage.jpg")

    ' Event: On page load, initialize the UI components and load product details
    Private Sub ProductsManageControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rtxtSearch.Text = "  Product Name  "
        rtxtSearch.ForeColor = System.Drawing.Color.LightGray

        Try
            ' Load product details into DataGridView
            LoadProductDetails()
        Catch ex As Exception
            ShowError("Error loading control", ex)
        End Try
    End Sub

    ' Load product details into the DataGridView with optional search functionality
    Public Sub LoadProductDetails(Optional searchQuery As String = Nothing)
        Dim query As String = "
            SELECT 
                p.product_id AS 'Product ID',
                p.product_name AS 'Product Name',
                p.price AS 'Price',
                c.category_name AS 'Category',
                CASE WHEN p.status = 1 THEN 'Available' ELSE 'Not Available' END AS 'Status',
                i.quantity_in_stock AS 'Stock Quantity',
                p.description AS 'Product Description',
                p.image_url AS 'Image URL'
            FROM Products p
            INNER JOIN Categories c ON p.category_id = c.category_id
            LEFT JOIN Inventory i ON p.product_id = i.product_id"

        ' Add search query if provided
        If Not String.IsNullOrEmpty(searchQuery) Then
            query &= " WHERE p.product_name LIKE '%' + @searchQuery + '%'"
        End If

        ' Database connection and data fetching
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    If Not String.IsNullOrEmpty(searchQuery) Then
                        command.Parameters.AddWithValue("@searchQuery", searchQuery)
                    End If

                    Dim adapter As New SqlDataAdapter(command)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    ' Add a column for the product images
                    dt.Columns.Add("Product Image", GetType(Image))

                    ' Populate the image column for each product
                    For Each row As DataRow In dt.Rows
                        Dim imageUrl As String = row("Image URL").ToString()
                        row("Product Image") = GetImage(imageUrl)
                    Next

                    ' Bind the data to the DataGridView
                    dgvProductDetails.DataSource = dt

                    ' Ensure the image column is displayed correctly
                    If dgvProductDetails.Columns("Product Image") Is Nothing Then
                        Dim imgColumn As New DataGridViewImageColumn With {
                            .Name = "Product Image",
                            .HeaderText = "Product Image",
                            .ImageLayout = DataGridViewImageCellLayout.Stretch
                        }
                        dgvProductDetails.Columns.Insert(0, imgColumn)
                    End If

                End Using
            Catch ex As SqlException
                ShowError("SQL Error loading product details", ex)
            Catch ex As Exception
                ShowError("General error loading product details", ex)
            End Try
        End Using

        ' Customize the DataGridView appearance
        Try
            CustomizeDataGridView()
        Catch ex As Exception
            ShowError("Error customizing DataGridView", ex)
        End Try
    End Sub

    ' Retrieves the image for a product, uses a default image if not found
    Private Function GetImage(imageUrl As String) As Image
        Try
            If File.Exists(imageUrl) Then
                Using fs As New FileStream(imageUrl, FileMode.Open, FileAccess.Read)
                    Return Image.FromStream(fs)
                End Using
            Else
                ' Load default image if file does not exist
                Using fs As New FileStream(defaultImagePath, FileMode.Open, FileAccess.Read)
                    Return Image.FromStream(fs)
                End Using
            End If
        Catch ex As Exception
            ShowError("Error loading image", ex)
            ' Return nothing on error to avoid breaking the DataGridView binding
            Return Nothing
        End Try
    End Function

    ' Customize DataGridView appearance (colors, fonts, etc.)
    Private Sub CustomizeDataGridView()
        dgvProductDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProductDetails.RowTemplate.Height = 80 ' Adjust row height for image display
        dgvProductDetails.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 191, 99)
        dgvProductDetails.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        dgvProductDetails.ColumnHeadersDefaultCellStyle.Font = New Font("Trebuchet MS", 12, FontStyle.Bold)
        dgvProductDetails.EnableHeadersVisualStyles = False
        dgvProductDetails.DefaultCellStyle.Font = New Font("Trebuchet MS", 10)
        dgvProductDetails.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGreen
        dgvProductDetails.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        dgvProductDetails.DefaultCellStyle.Padding = New Padding(5)
        dgvProductDetails.ReadOnly = True
        dgvProductDetails.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray
        dgvProductDetails.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgvProductDetails.GridColor = System.Drawing.Color.Black
        dgvProductDetails.Columns("Product Name").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvProductDetails.Columns("Price").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvProductDetails.Columns("Product Description").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvProductDetails.Columns("Product Description").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvProductDetails.Columns("Image URL").Visible = False ' Hide the image URL column
    End Sub

    ' Format cell colors based on the product status
    Private Sub dgvProductDetails_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvProductDetails.CellFormatting
        Try
            ' Change cell text color for the 'Status' column
            If dgvProductDetails.Columns(e.ColumnIndex).Name = "Status" AndAlso e.Value IsNot Nothing Then
                Dim status As String = e.Value.ToString().ToLower()

                Select Case status
                    Case "available"
                        e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(0, 191, 99) ' Available - Green
                    Case "not available"
                        e.CellStyle.ForeColor = System.Drawing.Color.Red ' Not Available - Red
                End Select
            End If
        Catch ex As Exception
            ShowError("Error formatting cell", ex)
        End Try
    End Sub

    ' Handle right-click on a cell to show a context menu based on column
    Private Sub dgvProductDetails_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvProductDetails.CellMouseDown
        Try
            If e.Button = MouseButtons.Right AndAlso e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                dgvProductDetails.CurrentCell = dgvProductDetails.Rows(e.RowIndex).Cells(e.ColumnIndex)

                ' Hide all context menu items initially
                For Each item As ToolStripMenuItem In ctxMenu.Items
                    item.Visible = False
                Next

                ' Show the correct items based on the clicked column
                If e.ColumnIndex = dgvProductDetails.Columns("Status").Index Then
                    ctxMenu.Items(0).Visible = True ' Available
                    ctxMenu.Items(1).Visible = True ' Not Available
                End If

                ' Show the context menu at the clicked location
                ctxMenu.Show()
            End If
        Catch ex As Exception
            ShowError("Error handling context menu", ex)
        End Try
    End Sub

    ' Update product status in the database
    Private Sub UpdateProductStatus(productId As Integer, newStatus As Integer)
        Dim query As String = "UPDATE Products SET status = @status WHERE product_id = @productId"

        ' Execute the status update in the database
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@status", newStatus)
                    command.Parameters.AddWithValue("@productId", productId)
                    command.ExecuteNonQuery()
                End Using
            Catch ex As SqlException
                ShowError("SQL Error updating product status", ex)
            Catch ex As Exception
                ShowError("Error updating product status", ex)
            End Try
        End Using
    End Sub

    ' Event: Update product status via context menu (Available/Not Available)
    Private Sub StatusMenuItem_Click(sender As Object, e As EventArgs) Handles Available.Click, NotAvailable.Click
        Try
            Dim selectedOption As String = DirectCast(sender, ToolStripMenuItem).Name
            Dim rowIndex As Integer = dgvProductDetails.CurrentCell.RowIndex
            Dim productId As Integer = Convert.ToInt32(dgvProductDetails.Rows(rowIndex).Cells("Product ID").Value)
            Dim newStatus As Integer

            ' Set status based on clicked menu item
            If selectedOption = "Available" Then
                newStatus = 1 ' Available
            ElseIf selectedOption = "Not Available" Then
                newStatus = 0 ' Not Available
            End If

            ' Update the product status and refresh the grid
            UpdateProductStatus(productId, newStatus)
            LoadProductDetails()

        Catch ex As InvalidCastException
            ShowError("Invalid selection or conversion error", ex)
        Catch ex As Exception
            ShowError("Error updating product details", ex)
        End Try
    End Sub

    ' Event: Search button click, load products based on search query
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim searchQuery As String = rtxtSearch.Text.Trim()

            If String.IsNullOrEmpty(searchQuery) Then
                MessageBox.Show("Please enter a product name to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            LoadProductDetails(searchQuery)

        Catch ex As Exception
            ShowError("Error searching for products", ex)
        End Try
    End Sub

    ' Event: Open the Update Product form
    Private Sub rbtnUpdateProduct_Click(sender As Object, e As EventArgs) Handles rbtnUpdateProduct.Click
        Try
            If Not IsFormOpen(GetType(UpdateProduct)) Then
                Dim updateProduct As New UpdateProduct()
                updateProduct.Show()
            Else
                MessageBox.Show("Update Product form is already open.", "Form Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            ShowError("Error opening Update Product form", ex)
        End Try
    End Sub

    ' Event: Open the Add Product form
    Private Sub rbtnAddProduct_Click(sender As Object, e As EventArgs) Handles rbtnAddProduct.Click
        Try
            If Not IsFormOpen(GetType(AddProduct)) Then
                Dim newProduct As New AddProduct()
                newProduct.Show()
            Else
                MessageBox.Show("Add Product form is already open.", "Form Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            ShowError("Error opening Add Product form", ex)
        End Try
    End Sub

    ' Check if a form is already open to avoid multiple instances
    Private Function IsFormOpen(formType As Type) As Boolean
        Return Application.OpenForms.Cast(Of Form).Any(Function(openForm) openForm.GetType() = formType)
    End Function

    ' Centralized error handling and display
    Private Sub ShowError(message As String, ex As Exception)
        MessageBox.Show($"{message}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    ' Event: Refresh the product details
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadProductDetails()
    End Sub

    ' Event: Clear the default text in search box when entering
    Private Sub rtxtSearch_Enter(sender As Object, e As EventArgs) Handles rtxtSearch.Enter
        If rtxtSearch.Text = "  Product Name  " Then
            rtxtSearch.Text = ""
            rtxtSearch.ForeColor = System.Drawing.Color.Black
        End If
    End Sub

    ' Event: Restore default text when leaving the search box empty
    Private Sub rtxtSearch_Leave(sender As Object, e As EventArgs) Handles rtxtSearch.Leave
        If String.IsNullOrWhiteSpace(rtxtSearch.Text) Then
            rtxtSearch.Text = "  Product Name  "
            rtxtSearch.Font = New Font("Trebuchet MS", 12)
            rtxtSearch.ForeColor = System.Drawing.Color.LightGray
        End If
    End Sub

    ' Event: Button hover effect for Add, Update, and Refresh buttons
    Dim selectedButton As New Button
    Private Sub btn_MouseEnter(sender As Object, e As EventArgs) Handles rbtnAddProduct.MouseEnter, rbtnUpdateProduct.MouseEnter, btnRefresh.MouseEnter
        If Not sender.Equals(selectedButton) Then
            DirectCast(sender, Button).BackColor = System.Drawing.Color.FromArgb(0, 175, 99)
        End If
    End Sub

    Private Sub btn_MouseLeave(sender As Object, e As EventArgs) Handles rbtnAddProduct.MouseLeave, rbtnUpdateProduct.MouseLeave, btnRefresh.MouseLeave
        If Not sender.Equals(selectedButton) Then
            DirectCast(sender, Button).BackColor = System.Drawing.Color.FromArgb(0, 191, 99)
        End If
    End Sub
End Class
