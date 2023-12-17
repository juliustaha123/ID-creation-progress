Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
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

    
End Class
