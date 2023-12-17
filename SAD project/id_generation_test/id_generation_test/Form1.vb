Imports MySql.Data.MySqlClient

Public Class Form1
    Private userIdToEdit As Integer = -1 ' Variable to store the user ID being edited

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ' Load all data into DataGridView
        LoadDataIntoDataGridView()
    End Sub

    'DATAGRIDVIEW

    Private Sub dgvUsers_SelectionChanged(sender As Object, e As EventArgs) Handles dgvUsers.SelectionChanged
        ' Handle the selection change in the DataGridView
        If dgvUsers.SelectedRows.Count > 0 Then
            ' Get the selected user's ID
            Dim userId As Integer = Convert.ToInt32(dgvUsers.SelectedRows(0).Cells("user_ID").Value)

            ' Load user data based on the selected ID
            LoadUserDataById(userId)
        End If
    End Sub

    'BUTTONS

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        ' Load user data based on the entered ID from the TextBox
        If Not String.IsNullOrEmpty(txtSelectID.Text) Then
            Dim selectedUserId As Integer
            If Integer.TryParse(txtSelectID.Text, selectedUserId) Then
                LoadUserDataById(selectedUserId)
            Else
                MessageBox.Show("Invalid user ID. Please enter a valid numeric ID.")
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Save changes to the database
        SaveChangesToDatabase()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        EnableEditing()
    End Sub

    'LOAD DATA INTO DATA GRID VIEW

    Private Sub LoadDataIntoDataGridView()
        Dim connectionString As String = "server=localhost;user=root;password=;database=test_vb_connect;"
        Dim connection As New MySqlConnection(connectionString)

        Try
            connection.Open()

            ' Perform database operations
            Dim query As String = "SELECT * FROM users"
            Dim adapter As New MySqlDataAdapter(query, connection)

            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            ' Bind DataTable to DataGridView
            dgvUsers.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    'LOAD USER DATA TO THE TEXT BOX

    Private Sub LoadUserDataById(userId As Integer)
        Dim connectionString As String = "server=localhost;user=root;password=;database=test_vb_connect;"
        Dim connection As New MySqlConnection(connectionString)

        Try
            connection.Open()

            ' Perform database operations to get user data by ID
            Dim query As String = "SELECT name, email FROM users WHERE user_ID = @userId"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@userId", userId)

            Dim reader As MySqlDataReader = command.ExecuteReader()

            ' Enable or disable the "Edit" button based on whether data is found
            btnEdit.Enabled = reader.HasRows
            btnSave.Enabled = False ' Disable the "Save" button until editing is initiated

            ' Display the result in TextBox
            If reader.Read() Then
                txtName.Text = reader("name").ToString()
                txtEmail.Text = reader("email").ToString()

            Else
                txtName.Text = String.Empty
                txtEmail.Text = String.Empty
                MessageBox.Show("No data found for the selected user ID.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub


    'THIS WILL ENABLE THE EDITING

    Private Sub EnableEditing()
        ' Enable editing in the TextBox controls
        txtName.ReadOnly = False
        txtEmail.ReadOnly = False


        ' Store the user ID being edited from the txtSelectID TextBox
        If Not String.IsNullOrEmpty(txtSelectID.Text) Then
            userIdToEdit = Convert.ToInt32(txtSelectID.Text)
        End If

        ' Debugging output
        MessageBox.Show("EnableEditing clicked. userIdToEdit: " & userIdToEdit.ToString())

        btnSave.Enabled = True ' Enable the "Save" button
    End Sub

    'THIS WILL SAVE THE CHANGES TO THE DATABASE

    Private Sub SaveChangesToDatabase()
        ' Save changes to the database based on the user ID being edited
        If userIdToEdit <> -1 Then
            Dim connectionString As String = "server=localhost;user=root;password=;database=test_vb_connect;"
            Dim connection As New MySqlConnection(connectionString)

            Try
                connection.Open()

                ' Perform database operations to update user data
                Dim query As String = "UPDATE users SET name = @name, email = @email WHERE user_ID = @userId"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@name", txtName.Text)
                command.Parameters.AddWithValue("@email", txtEmail.Text)
                command.Parameters.AddWithValue("@userId", userIdToEdit)

                command.ExecuteNonQuery()

                ' Disable editing after saving changes
                txtName.ReadOnly = True
                txtEmail.ReadOnly = True
                btnSave.Enabled = False

                ' Refresh the DataGridView
                LoadDataIntoDataGridView()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End If
    End Sub



    
End Class
