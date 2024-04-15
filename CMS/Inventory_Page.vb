Imports System.Configuration
Imports System.Data.SqlClient

Public Class Inventory_Page

    ' Connection string to connect to the database
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("CMS.My.MySettings.CMSConnectionString").ConnectionString

    ' Event: Page Load
    Private Sub InventoryManageControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rtxtSearch.Text = "  Product Name  "
        rtxtSearch.ForeColor = System.Drawing.Color.LightGray

        ' Load inventory details when the page is loaded
        Try
            LoadInventoryDetails()
        Catch ex As Exception
            ShowError("Error loading inventory", ex)
        End Try
    End Sub

    ' Load inventory details into DataGridView
    Public Sub LoadInventoryDetails(Optional searchQuery As String = Nothing)
        ' SQL query to retrieve inventory details
        Dim query As String = "
        SELECT 
            i.inventory_id AS 'Inventory ID',
            p.product_name AS 'Product Name',
            i.quantity_in_stock AS 'Quantity',
            ISNULL(s.supplier_name, 'No Supplier') AS 'Supplier Name',
            CASE 
                WHEN i.quantity_in_stock > 50 THEN 'Surplus' 
                WHEN i.quantity_in_stock < 5 THEN 'Deficit' 
                ELSE 'Normal' 
            END AS 'Product Stock Status', -- New column for stock status
            i.last_updated AS 'Product Last Updated' -- Last updated field
        FROM Inventory i
        INNER JOIN Products p ON i.product_id = p.product_id
        LEFT JOIN Inventory_Suppliers ivs ON i.inventory_id = ivs.inventory_id
        LEFT JOIN Suppliers s ON s.supplier_id = ivs.supplier_id
        WHERE p.status = 1" ' Only show products that are active (status = 1)

        ' Add a search filter for product name if search query is provided
        If Not String.IsNullOrEmpty(searchQuery) Then
            query &= " AND p.product_name LIKE '%' + @searchQuery + '%'"
        End If

        ' Execute the query and bind the result to DataGridView
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

                    ' Bind the data to DataGridView
                    dgvInventoryDetails.DataSource = dt
                End Using

            Catch ex As SqlException
                ShowError("SQL Error loading inventory details", ex)
            Catch ex As Exception
                ShowError("General error loading inventory details", ex)
            End Try
        End Using

        ' Customize the DataGridView appearance
        Try
            CustomizeDataGridView()
        Catch ex As Exception
            ShowError("Error customizing DataGridView", ex)
        End Try
    End Sub

    ' Customize the appearance of the DataGridView
    Private Sub CustomizeDataGridView()
        dgvInventoryDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvInventoryDetails.RowTemplate.Height = 40
        dgvInventoryDetails.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 191, 99)
        dgvInventoryDetails.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        dgvInventoryDetails.ColumnHeadersDefaultCellStyle.Font = New Font("Trebuchet MS", 12, FontStyle.Bold)
        dgvInventoryDetails.EnableHeadersVisualStyles = False
        dgvInventoryDetails.DefaultCellStyle.Font = New Font("Trebuchet MS", 10)
        dgvInventoryDetails.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGreen
        dgvInventoryDetails.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        dgvInventoryDetails.DefaultCellStyle.Padding = New Padding(5)
        dgvInventoryDetails.ReadOnly = True
        dgvInventoryDetails.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray
        dgvInventoryDetails.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgvInventoryDetails.GridColor = System.Drawing.Color.Black
    End Sub

    ' Event: Handle cell formatting for stock status colors in DataGridView
    Private Sub dgvInventoryDetails_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvInventoryDetails.CellFormatting
        Try
            ' Apply conditional formatting based on stock status
            If dgvInventoryDetails.Columns(e.ColumnIndex).Name = "Product Stock Status" AndAlso e.Value IsNot Nothing Then
                Dim stockStatus As String = e.Value.ToString().ToLower()

                Select Case stockStatus
                    Case "surplus"
                        e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(0, 191, 99) ' Green for surplus stock
                    Case "deficit"
                        e.CellStyle.ForeColor = System.Drawing.Color.Red ' Red for deficit stock
                End Select
            End If
        Catch ex As Exception
            ShowError("Error formatting cell", ex)
        End Try
    End Sub

    ' Event: Handle search button click to find specific products
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim searchQuery As String = rtxtSearch.Text.Trim()

            ' Check if the search query is empty
            If String.IsNullOrEmpty(searchQuery) Then
                MessageBox.Show("Please enter a product name to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Reload inventory details based on search query
            LoadInventoryDetails(searchQuery)

        Catch ex As Exception
            ShowError("Error searching for inventory items", ex)
        End Try
    End Sub

    ' Event: Refresh inventory details
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            ' Reload inventory details without search filtering
            LoadInventoryDetails()
        Catch ex As Exception
            ShowError("Error refreshing inventory details", ex)
        End Try
    End Sub

    ' Event: Handle Update Inventory button click
    Private Sub rbtnUpdatInventoryItems_Click(sender As Object, e As EventArgs) Handles rbtnUpdateInventoryitems.Click
        Try
            ' Open Update Inventory form if it's not already open
            If Not IsFormOpen(GetType(UpdateInventory)) Then
                Dim updateInventory As New UpdateInventory()
                updateInventory.Show()
            Else
                MessageBox.Show("Update Inventory form is already open.", "Form Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            ShowError("Error opening Update Inventory form", ex)
        End Try
    End Sub

    ' Utility: Check if a form is already open to prevent multiple instances
    Private Function IsFormOpen(formType As Type) As Boolean
        Return Application.OpenForms.Cast(Of Form).Any(Function(openForm) openForm.GetType() = formType)
    End Function

    ' Utility: Centralized error handling for displaying messages
    Private Sub ShowError(message As String, ex As Exception)
        MessageBox.Show($"{message}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    ' Event: Handle focus change when the user enters the search box
    Private Sub rtxtSearch_Enter(sender As Object, e As EventArgs) Handles rtxtSearch.Enter
        If rtxtSearch.Text = "  Product Name  " Then
            rtxtSearch.Text = ""
            rtxtSearch.ForeColor = System.Drawing.Color.Black
        End If
    End Sub

    ' Event: Handle focus change when the user leaves the search box
    Private Sub rtxtSearch_Leave(sender As Object, e As EventArgs) Handles rtxtSearch.Leave
        If String.IsNullOrWhiteSpace(rtxtSearch.Text) Then
            rtxtSearch.Text = "  Product Name  "
            rtxtSearch.ForeColor = System.Drawing.Color.LightGray
        End If
    End Sub

    ' Event: Handle button hover effect for mouse enter
    Dim selectedButton As New Button
    Private Sub btn_MouseEnter(sender As Object, e As EventArgs) Handles rbtnUpdateInventoryitems.MouseEnter, btnRefresh.MouseEnter
        If Not sender.Equals(selectedButton) Then
            DirectCast(sender, Button).BackColor = System.Drawing.Color.FromArgb(0, 175, 99)
        End If
    End Sub

    ' Event: Handle button hover effect for mouse leave
    Private Sub btn_MouseLeave(sender As Object, e As EventArgs) Handles rbtnUpdateInventoryitems.MouseLeave, btnRefresh.MouseLeave
        If Not sender.Equals(selectedButton) Then
            DirectCast(sender, Button).BackColor = System.Drawing.Color.FromArgb(0, 191, 99)
        End If
    End Sub

End Class
