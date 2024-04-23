Imports System.Configuration
Imports System.Data.SqlClient

Public Class MenuManage_Page

    ' Connection string to connect to the database
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("CMS.My.MySettings.CMSConnectionString").ConnectionString

    ' Event: Page Load
    Private Sub MenuManageControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        rtxtSearch.Text = "  Menu items Name  "
        rtxtSearch.ForeColor = System.Drawing.Color.LightGray

        Try
            ' Load menu details on form load
            LoadMenuDetails()
        Catch ex As Exception
            ShowError("Error loading menus", ex)
        End Try
    End Sub

    ' Load menu details into DataGridView
    Public Sub LoadMenuDetails(Optional searchQuery As String = Nothing)
        Dim query As String = "
            SELECT 
                m.menu_id AS 'Menu ID',
                p.product_name AS 'Product Name',
                p.description AS 'Product Description',
                p.price AS 'Price  ( Rs. )',
                c.category_name AS 'Category',
                CASE WHEN m.status = 1 THEN 'Available' ELSE 'Unavailable' END AS 'Menu Status',
                m.available_from AS 'Available From',
                m.available_to AS 'Available To'
            FROM Menu m
            INNER JOIN Products p ON m.product_id = p.product_id
            INNER JOIN Categories c ON p.category_id = c.category_id"

        ' Append WHERE clause if search query is provided
        If Not String.IsNullOrEmpty(searchQuery) Then
            query &= " WHERE p.product_name LIKE '%' + @searchQuery + '%'"
        End If

        ' Fetch and bind menu details to DataGridView
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

                    ' Bind the data to the DataGridView
                    dgvMenuDetails.DataSource = dt
                End Using

            Catch ex As SqlException
                ShowError("SQL Error loading menu details", ex)
            Catch ex As Exception
                ShowError("General error loading menu details", ex)
            End Try
        End Using

        ' Customize DataGridView after loading the data
        Try
            CustomizeDataGridView()
        Catch ex As Exception
            ShowError("Error customizing DataGridView", ex)
        End Try
    End Sub

    ' Customize the appearance of the DataGridView
    Private Sub CustomizeDataGridView()
        dgvMenuDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMenuDetails.RowTemplate.Height = 40
        dgvMenuDetails.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 191, 99)
        dgvMenuDetails.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        dgvMenuDetails.ColumnHeadersDefaultCellStyle.Font = New Font("Trebuchet MS", 12, FontStyle.Bold)
        dgvMenuDetails.EnableHeadersVisualStyles = False
        dgvMenuDetails.DefaultCellStyle.Font = New Font("Trebuchet MS", 10)
        dgvMenuDetails.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGreen
        dgvMenuDetails.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        dgvMenuDetails.DefaultCellStyle.Padding = New Padding(5)
        dgvMenuDetails.ReadOnly = True
        dgvMenuDetails.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray
        dgvMenuDetails.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgvMenuDetails.GridColor = System.Drawing.Color.Black
    End Sub

    ' Format DataGridView cells (e.g., color the "Menu Status" column based on status)
    Private Sub dgvMenuDetails_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvMenuDetails.CellFormatting
        Try
            If dgvMenuDetails.Columns(e.ColumnIndex).Name = "Menu Status" AndAlso e.Value IsNot Nothing Then
                Dim status As String = e.Value.ToString().ToLower()

                Select Case status
                    Case "available"
                        e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(0, 191, 99) ' Green for available status
                    Case "unavailable"
                        e.CellStyle.ForeColor = System.Drawing.Color.Red ' Red for unavailable status
                End Select
            End If
        Catch ex As Exception
            ShowError("Error formatting cell", ex)
        End Try
    End Sub

    ' Search menu items based on product name
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim searchQuery As String = rtxtSearch.Text.Trim()

            If String.IsNullOrEmpty(searchQuery) Then
                MessageBox.Show("Please enter a menu item to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Load menu details with search query
            LoadMenuDetails(searchQuery)

        Catch ex As Exception
            ShowError("Error searching for menu items", ex)
        End Try
    End Sub

    ' Refresh menu data
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            ' Reload all menu details
            LoadMenuDetails()
        Catch ex As Exception
            ShowError("Error refreshing menu details", ex)
        End Try
    End Sub

    ' Context menu event: Handle right-click to manage availability of menu items
    Private Sub dgvMenuDetails_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvMenuDetails.CellMouseDown
        Try
            If e.Button = MouseButtons.Right AndAlso e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                dgvMenuDetails.CurrentCell = dgvMenuDetails.Rows(e.RowIndex).Cells(e.ColumnIndex)

                ' Hide all menu options initially
                For Each item As ToolStripMenuItem In ctxMenu.Items
                    item.Visible = False
                Next

                ' Show relevant options for the "Menu Status" column
                If e.ColumnIndex = dgvMenuDetails.Columns("Menu Status").Index Then
                    ctxMenu.Items(0).Visible = True ' Available
                    ctxMenu.Items(1).Visible = True ' Unavailable
                    ctxMenu.Items(2).Visible = True ' Remove
                End If
            End If
        Catch ex As Exception
            ShowError("Error handling context menu", ex)
        End Try
    End Sub

    ' Update menu item status to "Available"
    Private Sub setAvailable_Click(sender As Object, e As EventArgs) Handles setAvailable.Click
        UpdateMenuStatus(1)
    End Sub

    ' Update menu item status to "Unavailable"
    Private Sub setUnavailable_Click(sender As Object, e As EventArgs) Handles setUnavailable.Click
        UpdateMenuStatus(0)
    End Sub

    ' Update menu status in the database
    Private Sub UpdateMenuStatus(newStatus As Integer)
        Try
            ' Get the selected menu ID
            Dim rowIndex As Integer = dgvMenuDetails.CurrentCell.RowIndex
            Dim menuId As Integer = Convert.ToInt32(dgvMenuDetails.Rows(rowIndex).Cells("Menu ID").Value)

            Dim query As String = "UPDATE Menu SET status = @status WHERE menu_id = @menuId"

            ' Execute the update query
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@status", newStatus)
                    command.Parameters.AddWithValue("@menuId", menuId)
                    command.ExecuteNonQuery()
                End Using
            End Using

            ' Refresh menu details after updating
            LoadMenuDetails()

        Catch ex As SqlException
            ShowError("SQL Error updating menu status", ex)
        Catch ex As Exception
            ShowError("Error updating menu status", ex)
        End Try
    End Sub

    ' Remove selected menu item from the database
    Private Sub removeMenuItem_Click(sender As Object, e As EventArgs) Handles removeMenuItem.Click
        DeleteMenuItem()
    End Sub

    ' Delete the selected menu item
    Private Sub DeleteMenuItem()
        Try
            ' Get the selected menu ID
            Dim rowIndex As Integer = dgvMenuDetails.CurrentCell.RowIndex
            Dim menuId As Integer = Convert.ToInt32(dgvMenuDetails.Rows(rowIndex).Cells("Menu ID").Value)

            ' Confirm deletion from the user
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove this menu item?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                Dim query As String = "DELETE FROM Menu WHERE menu_id = @menuId"

                ' Execute the delete query
                Using connection As New SqlConnection(connectionString)
                    connection.Open()

                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@menuId", menuId)

                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        ' Check if the deletion was successful
                        If rowsAffected > 0 Then
                            MessageBox.Show("Menu item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            LoadMenuDetails() ' Refresh menu details after deletion
                        Else
                            MessageBox.Show("Failed to delete menu item.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using
                End Using
            End If

        Catch ex As SqlException
            ShowError("SQL Error deleting menu item", ex)
        Catch ex As Exception
            ShowError("Error deleting menu item", ex)
        End Try
    End Sub

    ' Handle Update menu items button click
    Private Sub rbtnUpdateMenuitems_Click(sender As Object, e As EventArgs) Handles rbtnUpdateMenuitems.Click
        Try
            If Not IsFormOpen(GetType(UpdateMenuitems)) Then
                Dim updateMenuItems As New UpdateMenuitems()
                updateMenuItems.Show()
            Else
                MessageBox.Show("Update Menu Items form is already open.", "Form Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            ShowError("Error opening Update Menu Items form", ex)
        End Try
    End Sub

    ' Handle Add new menu item button click
    Private Sub rbtnAddMenuitems_Click(sender As Object, e As EventArgs) Handles rbtnAddMenuitems.Click
        Try
            If Not IsFormOpen(GetType(AddMenuitem)) Then
                Dim newMenuitem As New AddMenuitem()
                newMenuitem.Show()
            Else
                MessageBox.Show("Add Menu Item form is already open.", "Form Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            ShowError("Error opening Add Menu Item form", ex)
        End Try
    End Sub

    ' Utility function: Check if a form is already open to avoid multiple instances
    Private Function IsFormOpen(formType As Type) As Boolean
        Return Application.OpenForms.Cast(Of Form).Any(Function(openForm) openForm.GetType() = formType)
    End Function

    ' Centralized error display function for consistency
    Private Sub ShowError(message As String, ex As Exception)
        MessageBox.Show($"{message}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    ' Event: Handle search box placeholder text
    Private Sub rtxtSearch_Enter(sender As Object, e As EventArgs) Handles rtxtSearch.Enter
        If rtxtSearch.Text = "  Menu item Name  " Then
            rtxtSearch.Text = ""
            rtxtSearch.ForeColor = System.Drawing.Color.Black
        End If
    End Sub

    Private Sub rtxtSearch_Leave(sender As Object, e As EventArgs) Handles rtxtSearch.Leave
        If String.IsNullOrWhiteSpace(rtxtSearch.Text) Then
            rtxtSearch.Text = "  Menu item Name  "
            rtxtSearch.ForeColor = System.Drawing.Color.LightGray
        End If
    End Sub

    ' Event: Button hover effect
    Dim selectedButton As New Button
    Private Sub btn_MouseEnter(sender As Object, e As EventArgs) Handles rbtnAddMenuitems.MouseEnter, rbtnUpdateMenuitems.MouseEnter, btnRefresh.MouseEnter
        If Not sender.Equals(selectedButton) Then
            DirectCast(sender, Button).BackColor = System.Drawing.Color.FromArgb(0, 175, 99)
        End If
    End Sub

    Private Sub btn_MouseLeave(sender As Object, e As EventArgs) Handles rbtnAddMenuitems.MouseLeave, rbtnUpdateMenuitems.MouseLeave, btnRefresh.MouseLeave
        If Not sender.Equals(selectedButton) Then
            DirectCast(sender, Button).BackColor = System.Drawing.Color.FromArgb(0, 191, 99)
        End If
    End Sub

End Class
