Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If ValidateInput() Then
            Dim username As String = txtName.Text
            Dim password As String = txtPass.Text
            con.Close()
            con.Open()
            Dim query As String = $"SELECT * FROM tbl_login WHERE [LOG_USERNAME] = '{username}' AND [LOG_PASSWORD] = '{password}'"
            cmd.CommandText = query
            cmd.Connection = con
            dataReader = cmd.ExecuteReader()
            If (dataReader.Read() = True) Then
                MessageBox.Show("Welcome " + username, "Successful Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Form2.Show()
            Else
                MessageBox.Show("Username or password is incorrect", "Failed Login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

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

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Form3.Show()
    End Sub
End Class
