Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Imports MailKit.Search

Public Class UpdateInventory

    ' Database connection string
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("CMS.My.MySettings.CMSConnectionString").ConnectionString
    Private inventoryId As Integer = -1

    Private Sub UpdateInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Center the form and bind the combo boxes
        CenterForm()
        BindProducts()
        BindSuppliers()

        ' Clear the initial selection
        cmbProducts.SelectedIndex = -1 ' No product selected initially
        picboxProduct.Image = Nothing ' Ensure the PictureBox starts with no image
        ClearFields() ' Ensure fields are empty on load
    End Sub

    ' Center the form in the middle of the screen
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

    ' Bind products to cmbProducts
    Private Sub BindProducts()
        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "SELECT product_id, product_name FROM Products WHERE status = 1"
                connection.Open()
                Dim command As New SqlCommand(query, connection)
                Dim reader As SqlDataReader = command.ExecuteReader()

                Dim productTable As New DataTable()
                productTable.Load(reader)

                cmbProducts.DataSource = productTable
                cmbProducts.DisplayMember = "product_name"  ' Display product name in the combo box
                cmbProducts.ValueMember = "product_id"      ' Store product_id as the value
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Bind suppliers to cmbSuppliers
    Private Sub BindSuppliers()
        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "SELECT supplier_id, supplier_name FROM Suppliers WHERE status = 1"
                connection.Open()
                Dim command As New SqlCommand(query, connection)
                Dim reader As SqlDataReader = command.ExecuteReader()

                Dim supplierTable As New DataTable()
                supplierTable.Load(reader)

                cmbSuppliers.DataSource = supplierTable
                cmbSuppliers.DisplayMember = "supplier_name"  ' Display supplier name in the combo box
                cmbSuppliers.ValueMember = "supplier_id"      ' Store supplier_id as the value
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading suppliers: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Event handler for product selection change
    Private Sub cmbProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProducts.SelectedIndexChanged
        If cmbProducts.SelectedIndex <> -1 Then
            ' Handle DataRowView correctly by casting it to the appropriate type
            Dim selectedProductRow As DataRowView = TryCast(cmbProducts.SelectedItem, DataRowView)
            If selectedProductRow IsNot Nothing Then
                Dim selectedProductId As Integer = Convert.ToInt32(selectedProductRow("product_id"))
                LoadInventoryData(selectedProductId) ' Call the method to load inventory data
            End If
        Else
            ClearFields() ' Clear the fields if no product is selected
        End If
    End Sub

    ' Load inventory data for the selected product
    Private Sub LoadInventoryData(productId As Integer)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "
                SELECT i.inventory_id, i.quantity_in_stock, i.last_updated, s.supplier_id, p.image_url 
                FROM Inventory i 
                LEFT JOIN Products p ON p.product_id = i.product_id
                LEFT JOIN Inventory_Suppliers ivs ON i.inventory_id = ivs.inventory_id 
                LEFT JOIN Suppliers s ON ivs.supplier_id = s.supplier_id
                WHERE i.product_id = @ProductId"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@ProductId", productId)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Populate fields with inventory data
                            inventoryId = Convert.ToInt32(reader("inventory_id"))
                            rtxtboxQuantity.Text = reader("quantity_in_stock").ToString()
                            rtxtLastUpdated.Text = Convert.ToDateTime(reader("last_updated")).ToString("MM/dd/yyyy")
                            rtxtLastUpdated.ReadOnly = True ' Make last updated non-editable

                            ' Set the supplier in cmbSuppliers if available
                            If Not IsDBNull(reader("supplier_id")) Then
                                cmbSuppliers.SelectedValue = reader("supplier_id")
                            Else
                                cmbSuppliers.SelectedIndex = -1 ' No supplier selected
                            End If

                            ' Handle product image
                            Dim imagePath As String = reader("image_url").ToString()
                            If Not String.IsNullOrEmpty(imagePath) AndAlso File.Exists(imagePath) Then
                                picboxProduct.Image = Image.FromFile(imagePath)
                            Else
                                picboxProduct.Image = Nothing ' Clear PictureBox if no image or image not found
                            End If
                        Else
                            ' If no inventory record found, allow new entry
                            inventoryId = -1 ' No inventory record exists
                            MessageBox.Show("No inventory data found for this product. You can create a new record.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ClearFields(False) ' Allow adding new data without clearing everything
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            picboxProduct.Image = Nothing ' Ensure PictureBox is cleared in case of an error
        End Try
    End Sub

    ' Clear all input fields, optionally clear product combo
    Private Sub ClearFields(Optional clearProduct As Boolean = True)
        If clearProduct Then cmbProducts.SelectedIndex = -1
        rtxtboxQuantity.Clear()
        rtxtLastUpdated.Clear()
        cmbSuppliers.SelectedIndex = -1
        picboxProduct.Image = Nothing
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim productId As Integer = Convert.ToInt32(cmbProducts.SelectedValue)
        Dim supplierId As Integer = Convert.ToInt32(cmbSuppliers.SelectedValue)
        Dim quantity As Integer = Convert.ToInt32(rtxtboxQuantity.Text)

        ' Ensure inputs are valid
        If Not ValidateInputs(quantity) Then
            Return
        End If

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Check if the inventory record exists
                If inventoryId = -1 Then
                    ' Insert a new inventory record
                    Dim insertInventoryQuery As String = "
                    INSERT INTO Inventory (product_id, quantity_in_stock, last_updated) 
                    VALUES (@ProductId, @Quantity, GETDATE());
                    SELECT SCOPE_IDENTITY();" ' Get the new inventory_id

                    Using command As New SqlCommand(insertInventoryQuery, connection)
                        command.Parameters.AddWithValue("@ProductId", productId)
                        command.Parameters.AddWithValue("@Quantity", quantity)
                        inventoryId = Convert.ToInt32(command.ExecuteScalar())
                    End Using

                    ' Insert into Inventory_Suppliers table
                    Dim insertSupplierQuery As String = "
                    INSERT INTO Inventory_Suppliers (inventory_id, supplier_id) 
                    VALUES (@InventoryId, @SupplierId);"

                    Using command As New SqlCommand(insertSupplierQuery, connection)
                        command.Parameters.AddWithValue("@InventoryId", inventoryId)
                        command.Parameters.AddWithValue("@SupplierId", supplierId)
                        command.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("New inventory record added successfully!", "Insert Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ' Update existing inventory record
                    Dim updateInventoryQuery As String = "
                    UPDATE Inventory SET quantity_in_stock = @Quantity, last_updated = GETDATE()
                    WHERE inventory_id = @InventoryId"

                    Using command As New SqlCommand(updateInventoryQuery, connection)
                        command.Parameters.AddWithValue("@Quantity", quantity)
                        command.Parameters.AddWithValue("@InventoryId", inventoryId)
                        command.ExecuteNonQuery()
                    End Using

                    ' Check if a record exists in Inventory_Suppliers for the selected supplier
                    Dim checkSupplierQuery As String = "
                    IF EXISTS (SELECT 1 FROM Inventory_Suppliers WHERE inventory_id = @InventoryId)
                    BEGIN
                        UPDATE Inventory_Suppliers 
                        SET supplier_id = @SupplierId 
                        WHERE inventory_id = @InventoryId;
                    END
                    ELSE
                    BEGIN
                        INSERT INTO Inventory_Suppliers (inventory_id, supplier_id) 
                        VALUES (@InventoryId, @SupplierId);
                    END"

                    Using command As New SqlCommand(checkSupplierQuery, connection)
                        command.Parameters.AddWithValue("@InventoryId", inventoryId)
                        command.Parameters.AddWithValue("@SupplierId", supplierId)
                        command.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Inventory and Supplier updated successfully!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Me.Close()

            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred while updating: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Validate inputs (e.g., quantity must be a positive integer)
    Private Function ValidateInputs(quantity As Integer) As Boolean
        If quantity <= 0 Then
            MessageBox.Show("Quantity must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            HighlightField(rtxtboxQuantity, True)
            Return False
        End If

        HighlightField(rtxtboxQuantity, False)
        Return True
    End Function

    ' Function to highlight required fields
    Private Sub HighlightField(field As Control, highlight As Boolean)
        If highlight Then
            field.BackColor = Color.FromArgb(252, 73, 73)
        Else
            field.BackColor = Color.White
        End If
    End Sub

    ' Event: Search button click, load products based on search query
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            ' Get the search query from the RichTextBox
            Dim searchQuery As String = rtxtSearch.Text.Trim()

            ' Validate input
            If String.IsNullOrEmpty(searchQuery) Then
                MessageBox.Show("Please enter a product name to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Search for the product by name and get the product_id
            Dim productId As Integer = SearchProductByName(searchQuery)

            ' If productId is valid, load the inventory data and select the product in the ComboBox
            If productId <> -1 Then
                ' Set the selected product in the ComboBox
                cmbProducts.SelectedValue = productId

                ' Load the inventory data for the found product
                LoadInventoryData(productId)
            Else
                MessageBox.Show("Product not found. Please check the product name and try again.", "Product Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            ShowError("Error searching for products", ex)
        End Try
    End Sub

    ' Helper method to search product by name and return the product_id
    Private Function SearchProductByName(productName As String) As Integer
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Query to search for the product by name
                Dim query As String = "SELECT product_id FROM Products WHERE product_name = @ProductName AND status = 1"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@ProductName", productName)

                    ' Execute the query and return the product_id if found
                    Dim result = command.ExecuteScalar()

                    If result IsNot Nothing Then
                        Return Convert.ToInt32(result)
                    Else
                        Return -1 ' Return -1 if no product is found
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred while searching for the product: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function

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

    ' Centralized error handling and display
    Private Sub ShowError(message As String, ex As Exception)
        MessageBox.Show($"{message}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    ' Cancel button event handler
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    ' Event: Mouse hover effect for Add button
    Private Sub btnUpdate_MouseEnter(sender As Object, e As EventArgs) Handles btnUpdate.MouseEnter
        btnUpdate.BackColor = Color.FromArgb(0, 175, 99) ' Darker green for hover effect
    End Sub

    Private Sub btnUpdate_MouseLeave(sender As Object, e As EventArgs) Handles btnUpdate.MouseLeave
        btnUpdate.BackColor = Color.FromArgb(0, 191, 99) ' Revert to original color
    End Sub

    ' Event: Mouse hover effect for Cancel button
    Private Sub btnCancel_MouseEnter(sender As Object, e As EventArgs) Handles btncancel.MouseEnter
        btncancel.BackColor = Color.FromArgb(0, 191, 99) ' Highlight on hover
        btncancel.ForeColor = Color.White
    End Sub

    Private Sub btnCancel_MouseLeave(sender As Object, e As EventArgs) Handles btncancel.MouseLeave
        btncancel.BackColor = Color.White ' Revert to original background
        btncancel.ForeColor = Color.FromArgb(0, 191, 99) ' Revert to original text color
    End Sub
End Class
