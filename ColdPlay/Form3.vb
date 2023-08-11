Public Class Form3
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If ValidateInput() Then
            Dim username As String = txtName.Text
            Dim password As String = txtPass.Text
            Try
                con.Close()
                con.Open()
                Dim query As String = $"INSERT INTO tbl_login ([LOG_USERNAME],[LOG_PASSWORD]) VALUES ('{username}','{password}')"
                cmd.CommandText = query
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                MessageBox.Show("Successful insert data into database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Fail insert data into database", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub

    Private Function ValidateInput()
        Return IsPresent(txtName.Text, "Username") AndAlso
            IsPresent(txtPass.Text, "Password")
    End Function

    Private Function IsPresent(ByVal textbox As String, ByVal name As String)
        If textbox = "" Then
            MessageBox.Show("Please enter " + name, "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        Else
            Return True
        End If
    End Function
End Class