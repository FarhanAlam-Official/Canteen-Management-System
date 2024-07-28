Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.IO ' For file operations

Public Class Suppliers_Page

    ' Connection String to connect to the database
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("CMS.My.MySettings.CMSConnectionString").ConnectionString

    ' Path to the default image in case no image is available (for suppliers)
    Private defaultImagePath As String = "D:\Semester Final Project\4th Sem Final Project\Images\DefaultSupplierImage.jpg"

    ' Event: Page Load
    Private Sub SupplierManageControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rtxtSearch.Text = "  Supplier Name  "
        rtxtSearch.ForeColor = System.Drawing.Color.LightGray

        Try
            ' Load supplier details
            LoadSupplierDetails()
        Catch ex As Exception
            ShowError("Error loading control", ex)
        End Try
    End Sub

    ' Load supplier details into DataGridView
    Public Sub LoadSupplierDetails(Optional searchQuery As String = Nothing)
        ' Base query
        Dim query As String = "
        SELECT 
            s.supplier_id AS 'Supplier ID',
            s.supplier_name AS 'Supplier Name',
            s.contact_name AS 'Contact Name',
            s.contact_phone AS 'Contact Phone',
            s.contact_email AS 'Contact Email',
            CASE WHEN s.status = 1 THEN 'Working' ELSE 'Not Working' END AS 'Status',
            COUNT(isup.inventory_supplier_id) AS 'Number of Supplies',
            MAX(i.last_updated) AS 'Last Supplied Date'
        FROM Suppliers s
        LEFT JOIN Inventory_Suppliers isup ON s.supplier_id = isup.supplier_id
        LEFT JOIN Inventory i ON isup.inventory_id = i.inventory_id"

        ' Add the WHERE clause for search filtering before GROUP BY
        If Not String.IsNullOrEmpty(searchQuery) Then
            query &= " WHERE s.supplier_name LIKE '%' + @searchQuery + '%'"
        End If

        ' Group by supplier data after filtering
        query &= "
        GROUP BY 
            s.supplier_id, 
            s.supplier_name, 
            s.contact_name, 
            s.contact_phone, 
            s.contact_email, 
            s.status"

        ' Executing the query
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    ' Add parameter value if a search query is provided
                    If Not String.IsNullOrEmpty(searchQuery) Then
                        command.Parameters.AddWithValue("@searchQuery", searchQuery)
                    End If

                    ' Fill the DataTable and bind it to the DataGridView
                    Dim adapter As New SqlDataAdapter(command)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvSupplierDetails.DataSource = dt
                End Using
            Catch ex As SqlException
                MessageBox.Show("SQL Error loading supplier details: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show("General error loading supplier details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        ' Customize the DataGridView appearance
        Try
            CustomizeDataGridView()
        Catch ex As Exception
            MessageBox.Show("Error customizing DataGridView: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Customize the appearance of DataGridView
    Private Sub CustomizeDataGridView()
        dgvSupplierDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSupplierDetails.RowTemplate.Height = 50
        dgvSupplierDetails.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 191, 99)
        dgvSupplierDetails.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        dgvSupplierDetails.ColumnHeadersDefaultCellStyle.Font = New Font("Trebuchet MS", 12, FontStyle.Bold)
        dgvSupplierDetails.EnableHeadersVisualStyles = False
        dgvSupplierDetails.DefaultCellStyle.Font = New Font("Trebuchet MS", 10)
        dgvSupplierDetails.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGreen
        dgvSupplierDetails.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        dgvSupplierDetails.DefaultCellStyle.Padding = New Padding(5)
        dgvSupplierDetails.ReadOnly = True
        dgvSupplierDetails.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray
        dgvSupplierDetails.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgvSupplierDetails.GridColor = System.Drawing.Color.Black
    End Sub

    ' Event: Format cells for status column colors in DataGridView
    Private Sub dgvSupplierDetails_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvSupplierDetails.CellFormatting
        Try
            ' Format the 'Status' column to show different colors for "Working" and "Not Working"
            If dgvSupplierDetails.Columns(e.ColumnIndex).Name = "Status" AndAlso e.Value IsNot Nothing Then
                Dim status As String = e.Value.ToString().ToLower()

                Select Case status
                    Case "working"
                        e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(0, 191, 99) ' Green for Working
                    Case "not working"
                        e.CellStyle.ForeColor = System.Drawing.Color.Red ' Red for Not Working
                End Select
            End If
        Catch ex As Exception
            ShowError("Error formatting cell", ex)
        End Try
    End Sub

    ' Update supplier status in the database
    Private Sub UpdateSupplierStatus(supplierId As Integer, newStatus As Integer)
        Dim query As String = "UPDATE Suppliers SET status = @status WHERE supplier_id = @supplierId"

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@status", newStatus)
                    command.Parameters.AddWithValue("@supplierId", supplierId)
                    command.ExecuteNonQuery()
                End Using

            Catch ex As SqlException
                ShowError("SQL Error updating supplier status", ex)
            Catch ex As Exception
                ShowError("Error updating supplier status", ex)
            End Try
        End Using
    End Sub

    ' Event: Handle right-click to update supplier status from context menu
    Private Sub dgvSupplierDetails_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvSupplierDetails.CellMouseDown
        Try
            ' Show context menu only when right-clicked on the Status column
            If e.Button = MouseButtons.Right AndAlso e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                dgvSupplierDetails.CurrentCell = dgvSupplierDetails.Rows(e.RowIndex).Cells(e.ColumnIndex)

                ' Hide all items initially
                For Each item As ToolStripMenuItem In ctxMenu.Items
                    item.Visible = False
                Next

                ' Show the correct context menu based on the clicked column
                If e.ColumnIndex = dgvSupplierDetails.Columns("Status").Index Then
                    ctxMenu.Items(0).Visible = True ' Working
                    ctxMenu.Items(1).Visible = True ' Not Working
                End If

                ' Show the context menu at the clicked location
                ctxMenu.Show()
            End If
        Catch ex As Exception
            ShowError("Error handling context menu", ex)
        End Try
    End Sub

    ' Event: Update supplier status via context menu
    Private Sub StatusMenuItem_Click(sender As Object, e As EventArgs) Handles Working.Click, NotWorking.Click
        Try
            Dim selectedOption As String = DirectCast(sender, ToolStripMenuItem).Text
            Dim rowIndex As Integer = dgvSupplierDetails.CurrentCell.RowIndex
            Dim supplierId As Integer = Convert.ToInt32(dgvSupplierDetails.Rows(rowIndex).Cells("Supplier ID").Value)
            Dim newStatus As Integer = If(selectedOption = "Working", 1, 0)

            ' Update supplier status
            UpdateSupplierStatus(supplierId, newStatus)

            ' Refresh supplier details after updating
            LoadSupplierDetails()

        Catch ex As InvalidCastException
            ShowError("Invalid selection or conversion error", ex)
        Catch ex As Exception
            ShowError("Error updating supplier details", ex)
        End Try
    End Sub

    ' Event: Search for suppliers based on input
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim searchQuery As String = rtxtSearch.Text.Trim()

            If String.IsNullOrEmpty(searchQuery) Then
                MessageBox.Show("Please enter a supplier name to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            LoadSupplierDetails(searchQuery)

        Catch ex As Exception
            ShowError("Error searching for suppliers", ex)
        End Try
    End Sub

    ' Event: Update Supplier button click
    Private Sub rbtnUpdateSupplier_Click(sender As Object, e As EventArgs) Handles rbtnUpdateSupplier.Click
        Try
            ' Avoid multiple instances of the UpdateSupplier form
            If Not IsFormOpen(GetType(UpdateSupplier)) Then
                Dim updateSupplier As New UpdateSupplier()
                updateSupplier.Show()
            Else
                MessageBox.Show("Update Supplier form is already open.", "Form Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            ShowError("Error opening Update Supplier form", ex)
        End Try
    End Sub

    ' Event: Add Supplier button click
    Private Sub rbtnAddSupplier_Click(sender As Object, e As EventArgs) Handles rbtnAddSupplier.Click
        Try
            ' Avoid multiple instances of the AddSupplier form
            If Not IsFormOpen(GetType(AddSupplier)) Then
                Dim newSupplier As New AddSupplier()
                newSupplier.Show()
            Else
                MessageBox.Show("Add Supplier form is already open.", "Form Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            ShowError("Error opening Add Supplier form", ex)
        End Try
    End Sub

    ' Event: Refresh supplier data
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadSupplierDetails()
    End Sub

    ' Utility function: Check if a form is already open to avoid multiple instances
    Private Function IsFormOpen(formType As Type) As Boolean
        Return Application.OpenForms.Cast(Of Form).Any(Function(openForm) openForm.GetType() = formType)
    End Function

    ' Centralized error display
    Private Sub ShowError(message As String, ex As Exception)
        MessageBox.Show($"{message}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    ' Placeholder text handling for the search box
    Private Sub rtxtSearch_Enter(sender As Object, e As EventArgs) Handles rtxtSearch.Enter
        If rtxtSearch.Text = "  Supplier Name  " Then
            rtxtSearch.Text = ""
            rtxtSearch.ForeColor = System.Drawing.Color.Black
        End If
    End Sub

    Private Sub rtxtSearch_Leave(sender As Object, e As EventArgs) Handles rtxtSearch.Leave
        If String.IsNullOrWhiteSpace(rtxtSearch.Text) Then
            rtxtSearch.Text = "  Supplier Name  "
            rtxtSearch.ForeColor = System.Drawing.Color.LightGray
        End If
    End Sub

    ' Event: Button hover effect
    Dim selectedButton As New Button
    Private Sub btn_MouseEnter(sender As Object, e As EventArgs) Handles rbtnAddSupplier.MouseEnter, rbtnUpdateSupplier.MouseEnter, btnRefresh.MouseEnter
        If Not sender.Equals(selectedButton) Then
            DirectCast(sender, Button).BackColor = System.Drawing.Color.FromArgb(0, 175, 99)
        End If
    End Sub

    Private Sub btn_MouseLeave(sender As Object, e As EventArgs) Handles rbtnAddSupplier.MouseLeave, rbtnUpdateSupplier.MouseLeave, btnRefresh.MouseLeave
        If Not sender.Equals(selectedButton) Then
            DirectCast(sender, Button).BackColor = System.Drawing.Color.FromArgb(0, 191, 99)
        End If
    End Sub

End Class
