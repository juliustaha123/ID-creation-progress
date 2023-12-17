Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ' Load all data into DataGridView
        LoadDataIntoDataGridView()
    End Sub

    Private Sub dgvUsers_SelectionChanged(sender As Object, e As EventArgs) Handles dgvUsers.SelectionChanged
        ' Handle the selection change in the DataGridView
        If dgvUsers.SelectedRows.Count > 0 Then
            ' Get the selected user's ID
            Dim userId As Integer = Convert.ToInt32(dgvUsers.SelectedRows(0).Cells("user_ID").Value)

            ' Load user data based on the selected ID
            LoadUserDataById(userId)
        End If
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        ' Load user data based on the entered ID from the TextBox
        If Not String.IsNullOrEmpty(txtSelectID.Text) Then
            Dim selectedUserId As Integer = Convert.ToInt32(txtSelectID.Text)
            LoadUserDataById(selectedUserId)
        End If
    End Sub

    Private Sub LoadDataIntoDataGridView()
        Dim connectionString As String = "server=localhost;user=root;password=;database=test_vb_connect;"
        Dim connection As New MySqlConnection(connectionString)

        Try
            connection.Open()

            ' Perform database operations
            Dim query As String = "SELECT * FROM users"
            Dim command As New MySqlCommand(query, connection)

            Dim dataTable As New DataTable()
            dataTable.Load(command.ExecuteReader())

            ' Bind DataTable to DataGridView
            dgvUsers.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

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

            ' Display the result in TextBox
            If reader.Read() Then
                txtName.Text = reader("name").ToString()
                txtEmail.Text = reader("email").ToString()
            Else
                txtName.Text = "No data found."
                txtEmail.Text = "No data found."
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

   
End Class
