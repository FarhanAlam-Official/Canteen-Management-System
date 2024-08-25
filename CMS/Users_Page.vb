Imports System.Configuration
Imports System.Data.SqlClient

Public Class Users_Page

    ' Connection string for database connection
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("CMS.My.MySettings.CMSConnectionString").ConnectionString

    ' On form load, initialize search box and load user details
    Private Sub UsersManageControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rtxtSearch.Text = "  Customer Name  "
        rtxtSearch.ForeColor = System.Drawing.Color.LightGray

        Try
            LoadUserDetails()
        Catch ex As Exception
            ShowError("Error loading control", ex)
        End Try
    End Sub

    ' Load user details into DataGridView, optionally with a search query
    Public Sub LoadUserDetails(Optional searchQuery As String = Nothing)
        Dim query As String = "
            SELECT 
                u.user_id AS 'User ID',
                u.email AS 'Email',
                u.user_type AS 'User Type',
                CASE WHEN u.status = 1 THEN 'Active' ELSE 'Inactive' END AS 'Status',
                ud.first_name AS 'First Name',
                ud.last_name AS 'Last Name',
                ud.age AS 'Age',
                ud.gender AS 'Gender',
                ud.created_date AS 'Created Date',
                ud.phone_no AS 'Phone No'
            FROM Users u
            INNER JOIN User_Details ud ON u.user_id = ud.user_id"

        If Not String.IsNullOrEmpty(searchQuery) Then
            query &= " WHERE u.email LIKE '%' + @searchQuery + '%'"
        End If

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

                    dgvUserDetails.DataSource = dt
                End Using
            Catch ex As SqlException
                ShowError("SQL Error loading user details", ex)
            Catch ex As Exception
                ShowError("General error loading user details", ex)
            End Try
        End Using

        Try
            CustomizeDataGridView()
        Catch ex As Exception
            ShowError("Error customizing DataGridView", ex)
        End Try
    End Sub

    ' Customize the appearance of the DataGridView
    Private Sub CustomizeDataGridView()
        dgvUserDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvUserDetails.RowTemplate.Height = 40
        dgvUserDetails.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 191, 99)
        dgvUserDetails.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        dgvUserDetails.ColumnHeadersDefaultCellStyle.Font = New Font("Trebuchet MS", 12, FontStyle.Bold)
        dgvUserDetails.EnableHeadersVisualStyles = False
        dgvUserDetails.DefaultCellStyle.Font = New Font("Trebuchet MS", 10)
        dgvUserDetails.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGreen
        dgvUserDetails.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        dgvUserDetails.DefaultCellStyle.Padding = New Padding(5)
        dgvUserDetails.ReadOnly = True
        dgvUserDetails.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray
        dgvUserDetails.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgvUserDetails.GridColor = System.Drawing.Color.Black
        dgvUserDetails.Columns("Email").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub

    ' Format cells in DataGridView based on column name (e.g., User Type and Status)
    Private Sub dgvUserDetails_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvUserDetails.CellFormatting
        Try
            ' Format the 'User Type' column
            If dgvUserDetails.Columns(e.ColumnIndex).Name = "User Type" AndAlso e.Value IsNot Nothing Then
                Dim userType As String = e.Value.ToString().ToLower()
                e.Value = StrConv(userType, VbStrConv.ProperCase)

                Select Case userType
                    Case "admin"
                        e.CellStyle.ForeColor = System.Drawing.Color.Blue ' Admin - Blue
                    Case "customer"
                        e.CellStyle.ForeColor = System.Drawing.Color.Orange ' Customer - Orange
                End Select
            End If

            ' Format the 'Status' column
            If dgvUserDetails.Columns(e.ColumnIndex).Name = "Status" AndAlso e.Value IsNot Nothing Then
                Dim status As String = e.Value.ToString().ToLower()

                Select Case status
                    Case "active"
                        e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(0, 191, 99) ' Active - Green
                    Case "inactive"
                        e.CellStyle.ForeColor = System.Drawing.Color.Red ' Inactive - Red
                End Select
            End If
        Catch ex As Exception
            ShowError("Error formatting cell", ex)
        End Try
    End Sub

    ' Context menu event handler to update user type or status
    Private Sub UserTypeStatusMenuItem_Click(sender As Object, e As EventArgs) Handles itemSetActive.Click, itemSetInactive.Click, itemSetAdmin.Click, itemSetCustomer.Click
        Try
            Dim selectedOption As String = DirectCast(sender, ToolStripMenuItem).Text
            Dim rowIndex As Integer = dgvUserDetails.CurrentCell.RowIndex
            Dim userId As Integer = Convert.ToInt32(dgvUserDetails.Rows(rowIndex).Cells("User ID").Value)

            ' Check whether to update user type or status
            If selectedOption = "Make Admin" OrElse selectedOption = "Make Customer" Then
                Dim newType As String = If(selectedOption = "Make Admin", "Admin", "Customer").ToLower()
                UpdateUserType(userId, newType)
            ElseIf selectedOption = "Make Active" OrElse selectedOption = "Make Inactive" Then
                Dim newStatus As Integer = If(selectedOption = "Make Active", 1, 0)
                UpdateUserStatus(userId, newStatus)
            End If

            ' Refresh the user details after updating
            LoadUserDetails()
        Catch ex As InvalidCastException
            ShowError("Invalid selection or conversion error", ex)
        Catch ex As Exception
            ShowError("Error updating user details", ex)
        End Try
    End Sub

    ' Update user type in the database
    Private Sub UpdateUserType(userId As Integer, newType As String)
        Dim query As String = "UPDATE Users SET user_type = @userType WHERE user_id = @userId"

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@userType", newType)
                    command.Parameters.AddWithValue("@userId", userId)
                    command.ExecuteNonQuery()
                End Using
            Catch ex As SqlException
                ShowError("SQL Error updating user type", ex)
            Catch ex As Exception
                ShowError("Error updating user type", ex)
            End Try
        End Using
    End Sub

    ' Update user status in the database
    Private Sub UpdateUserStatus(userId As Integer, newStatus As Integer)
        Dim query As String = "UPDATE Users SET status = @status WHERE user_id = @userId"

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@status", newStatus)
                    command.Parameters.AddWithValue("@userId", userId)
                    command.ExecuteNonQuery()
                End Using
            Catch ex As SqlException
                ShowError("SQL Error updating user status", ex)
            Catch ex As Exception
                ShowError("Error updating user status", ex)
            End Try
        End Using
    End Sub

    ' Right-click event to show context menu and select options based on the column
    Private Sub dgvUserDetails_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvUserDetails.CellMouseDown
        Try
            If e.Button = MouseButtons.Right AndAlso e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                dgvUserDetails.CurrentCell = dgvUserDetails.Rows(e.RowIndex).Cells(e.ColumnIndex)

                ' Hide all items initially
                For Each item As ToolStripMenuItem In ctxMenu.Items
                    item.Visible = False
                Next

                ' Show appropriate items based on the clicked column
                If e.ColumnIndex = dgvUserDetails.Columns("User Type").Index Then
                    ctxMenu.Items(0).Visible = True ' Admin
                    ctxMenu.Items(1).Visible = True ' Customer
                ElseIf e.ColumnIndex = dgvUserDetails.Columns("Status").Index Then
                    ctxMenu.Items(2).Visible = True ' Active
                    ctxMenu.Items(3).Visible = True ' Inactive
                End If

                ctxMenu.Show()
            End If
        Catch ex As Exception
            ShowError("Error handling context menu", ex)
        End Try
    End Sub

    ' Search button click event to search users by email
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim searchQuery As String = rtxtSearch.Text.Trim()

            If String.IsNullOrEmpty(searchQuery) Then
                MessageBox.Show("Please enter an email to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            LoadUserDetails(searchQuery)
        Catch ex As Exception
            ShowError("Error searching for users", ex)
        End Try
    End Sub

    ' Button click event to open Update Users form
    Private Sub rbtnUpdateUsers_Click(sender As Object, e As EventArgs) Handles rbtnUpdateUsers.Click
        Try
            If Not IsFormOpen(GetType(UpdateUser)) Then
                Dim updateUser As New UpdateUser()
                updateUser.Show()
            Else
                MessageBox.Show("Update User form is already open.", "Form Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            ShowError("Error opening Update User form", ex)
        End Try
    End Sub

    ' Button click event to open Add Users form
    Private Sub rbtnAddUsers_Click(sender As Object, e As EventArgs) Handles rbtnAddUsers.Click
        Try
            If Not IsFormOpen(GetType(Register)) Then
                Dim newUser As New Register(isAdminMode:=True)
                newUser.Show()
            Else
                MessageBox.Show("Add User form is already open.", "Form Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            ShowError("Error opening Add User form", ex)
        End Try
    End Sub

    ' Button click event to refresh user details
    Private Sub btnRefreshPayments_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            LoadUserDetails()
        Catch ex As Exception
            ShowError("Error refreshing user details", ex)
        End Try
    End Sub

    ' Check if a specific form type is already open
    Private Function IsFormOpen(formType As Type) As Boolean
        Return Application.OpenForms.Cast(Of Form).Any(Function(openForm) openForm.GetType() = formType)
    End Function

    ' Show error messages with centralized error handling
    Private Sub ShowError(message As String, ex As Exception)
        MessageBox.Show($"{message}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    ' Handles "Show Passwords" checkbox change
    Private Sub chkShowPasswords_CheckedChanged(sender As Object, e As EventArgs)
        LoadUserDetails()
    End Sub

    ' Placeholder text handling for search box on Enter
    Private Sub rtxtSearch_Enter(sender As Object, e As EventArgs) Handles rtxtSearch.Enter
        If rtxtSearch.Text = "  Customer Name  " Then
            rtxtSearch.Text = ""
            rtxtSearch.ForeColor = System.Drawing.Color.Black
        End If
    End Sub

    ' Placeholder text handling for search box on Leave
    Private Sub rtxtSearch_Leave(sender As Object, e As EventArgs) Handles rtxtSearch.Leave
        If String.IsNullOrWhiteSpace(rtxtSearch.Text) Then
            rtxtSearch.Text = "  Customer Name  "
            rtxtSearch.Font = New Font("Trebuchet MS", 12)
            rtxtSearch.ForeColor = System.Drawing.Color.LightGray
        End If
    End Sub

    ' MouseEnter event for button hover effect
    Dim selectedButton As New Button
    Private Sub btn_MouseEnter(sender As Object, e As EventArgs) Handles rbtnAddUsers.MouseEnter, rbtnUpdateUsers.MouseEnter, btnRefresh.MouseEnter
        If Not sender.Equals(selectedButton) Then
            DirectCast(sender, Button).BackColor = System.Drawing.Color.FromArgb(0, 175, 99)
        End If
    End Sub

    ' MouseLeave event for button hover effect
    Private Sub btn_MouseLeave(sender As Object, e As EventArgs) Handles rbtnAddUsers.MouseLeave, rbtnUpdateUsers.MouseLeave, btnRefresh.MouseLeave
        If Not sender.Equals(selectedButton) Then
            DirectCast(sender, Button).BackColor = System.Drawing.Color.FromArgb(0, 191, 99)
        End If
    End Sub
End Class
