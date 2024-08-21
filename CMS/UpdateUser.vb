Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Configuration


Public Class UpdateUser

    ' Connection string to access the database
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("CMS.My.MySettings.CMSConnectionString").ConnectionString

    ' Variables to store original password and confirm password
    Private originalPassword As String = ""
    Private originalConfirmPassword As String = ""

    ' Variable to store user ID for update operations
    Private userId As Integer

    ' Form load event handler to center the form and initialize the password fields
    Private Sub UpdateUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm() ' Centers the form
    End Sub

    ' Centers the form on the parent form or screen
    Private Sub CenterForm()
        Dim x, y As Integer
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

    ' Event handler for the Search button click
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchValue As String = rtxtSearch.Text.Trim()

        If rbtnUserID.Checked Then
            ' Search by user ID
            If String.IsNullOrWhiteSpace(searchValue) OrElse Not IsNumeric(searchValue) Then
                MessageBox.Show("Please enter a valid User ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            SearchUser("user_id", Convert.ToInt32(searchValue))
        ElseIf rbtnUserEmail.Checked Then
            ' Search by email
            If String.IsNullOrWhiteSpace(searchValue) OrElse Not IsValidEmail(searchValue) Then
                MessageBox.Show("Please enter a valid Email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            SearchUser("email", Convert.ToString(searchValue))
        Else
            MessageBox.Show("Please select either 'User ID' or 'Email' to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Function to search user by either User ID or Email
    Private Sub SearchUser(searchBy As String, searchValue As Object)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT U.user_id, U.email, UD.first_name, UD.last_name, UD.age, UD.gender, UD.phone_no 
                                       FROM Users U
                                       INNER JOIN User_Details UD ON U.user_id = UD.user_id 
                                       WHERE U." & searchBy & " = @SearchValue"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@SearchValue", searchValue)

                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Populate the fields with the current data
                            userId = Convert.ToInt32(reader("user_id"))
                            rtxtboxemail.Text = reader("email").ToString()
                            rtxtboxfirstname.Text = reader("first_name").ToString()
                            rtxtboxlastname.Text = reader("last_name").ToString()
                            rtxtboxage.Text = reader("age").ToString()
                            rtxtboxphoneno.Text = reader("phone_no").ToString()

                            ' Set gender radio buttons
                            If reader("gender").ToString() = "Male" Then
                                radiobtnmale.Checked = True
                            ElseIf reader("gender").ToString() = "Female" Then
                                radiobtnfemale.Checked = True
                            End If

                        Else
                            MessageBox.Show("No user found with the given search criteria.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Event handler for the Update button click
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim email As String = rtxtboxemail.Text.Trim()
        Dim firstName As String = rtxtboxfirstname.Text.Trim()
        Dim lastName As String = rtxtboxlastname.Text.Trim()
        Dim age As String = rtxtboxage.Text.Trim()
        Dim gender As String = If(radiobtnmale.Checked, "Male", If(radiobtnfemale.Checked, "Female", "Other"))
        Dim phoneNo As String = rtxtboxphoneno.Text.Trim()

        ' Validate the input fields
        If Not ValidateInputs(email, firstName, lastName, age, phoneNo) Then
            Return
        End If

        ' Ensure the userId is valid
        If userId = 0 Then
            MessageBox.Show("Please search for a user first before updating.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Update the details
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "UPDATE User_Details 
                                       SET first_name = @FirstName, last_name = @LastName, age = @Age, gender = @Gender, phone_no = @PhoneNo 
                                       WHERE user_id = @UserId;
                                       UPDATE Users SET email = @Email 
                                       WHERE user_id = @UserId;"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@UserId", userId)
                    command.Parameters.AddWithValue("@FirstName", firstName)
                    command.Parameters.AddWithValue("@LastName", lastName)
                    command.Parameters.AddWithValue("@Age", age)
                    command.Parameters.AddWithValue("@Gender", gender)
                    command.Parameters.AddWithValue("@PhoneNo", phoneNo)
                    command.Parameters.AddWithValue("@Email", email)
                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Details updated successfully.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show($"An error occurred while updating: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidateInputs(email As String, firstName As String, lastName As String, age As String, phoneNo As String) As Boolean
        Dim isValid As Boolean = True

        If String.IsNullOrWhiteSpace(email) Then
            HighlightField(rtxtboxemail, True)
            isValid = False
        Else
            HighlightField(rtxtboxemail, False)
        End If

        If String.IsNullOrWhiteSpace(firstName) Then
            HighlightField(rtxtboxfirstname, True)
            isValid = False
        Else
            HighlightField(rtxtboxfirstname, False)
        End If

        If String.IsNullOrWhiteSpace(lastName) Then
            HighlightField(rtxtboxlastname, True)
            isValid = False
        Else
            HighlightField(rtxtboxlastname, False)
        End If

        If String.IsNullOrWhiteSpace(phoneNo) Then
            HighlightField(rtxtboxphoneno, True)
            isValid = False
        ElseIf phoneNo.Length <> 10 Then
            MessageBox.Show("Phone number must be 10 digits long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            HighlightField(rtxtboxphoneno, True)
            isValid = False
        Else
            HighlightField(rtxtboxphoneno, False)
        End If

        If String.IsNullOrWhiteSpace(age) OrElse Not IsNumeric(age) OrElse Convert.ToInt32(age) <= 0 OrElse Convert.ToInt32(age) >= 150 Then
            MessageBox.Show("Please enter a valid age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            HighlightField(rtxtboxage, True)
            isValid = False
        Else
            HighlightField(rtxtboxage, False)
        End If

        ' Validate gender selection
        If Not radiobtnmale.Checked AndAlso Not radiobtnfemale.Checked Then
            MessageBox.Show("Please select a gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            isValid = False
        End If

        If Not IsValidEmail(email) Then
            MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            HighlightField(rtxtboxemail, True)
            isValid = False
        End If

        If Not isValid Then
            MessageBox.Show("Please correct the highlighted fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return isValid
    End Function


    ' Function to validate email format
    Private Function IsValidEmail(email As String) As Boolean
        Dim emailPattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        Return Regex.IsMatch(email, emailPattern)
    End Function


    ' Function to highlight required fields
    Private Sub HighlightField(field As Control, highlight As Boolean)
        If highlight Then
            field.BackColor = Color.FromArgb(252, 73, 73)
        Else
            field.BackColor = Color.White
        End If
    End Sub

    ' Event handler for KeyPress event of rtxtboxphoneno
    Private Sub rtxtboxphoneno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rtxtboxphoneno.KeyPress
        ' Allow control keys (backspace, delete)
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        ' Allow only numeric input
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

        ' Restrict the length to 10 characters
        If rtxtboxphoneno.Text.Length >= 10 Then
            e.Handled = True
        End If
    End Sub

    ' Event handler for the Cancel button click event
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
    ' Mouse hover effect for Update button (changes color on hover)
    Private Sub btnUpdate_MouseEnter(sender As Object, e As EventArgs) Handles btnUpdate.MouseEnter
        btnUpdate.BackColor = Color.FromArgb(0, 175, 99) ' Darker green on hover
    End Sub

    Private Sub btnUpdate_MouseLeave(sender As Object, e As EventArgs) Handles btnUpdate.MouseLeave
        btnUpdate.BackColor = Color.FromArgb(0, 191, 99) ' Reverts to original color
    End Sub

    ' Mouse hover effect for Cancel button (changes color and text color on hover)
    Private Sub btnCancel_MouseEnter(sender As Object, e As EventArgs) Handles btncancel.MouseEnter
        btncancel.BackColor = Color.FromArgb(0, 191, 99) ' Highlight on hover
        btncancel.ForeColor = Color.White
    End Sub

    Private Sub btnCancel_MouseLeave(sender As Object, e As EventArgs) Handles btncancel.MouseLeave
        btncancel.BackColor = Color.White ' Reverts background
        btncancel.ForeColor = Color.FromArgb(0, 191, 99) ' Reverts text color
    End Sub

End Class
