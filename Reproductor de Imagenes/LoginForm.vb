Public Class LoginForm

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Validar las credenciales del usuario
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If ValidateCredentials(username, password) Then
            ' Credenciales válidas, mostrar el formulario principal
            OpenMainForm()
        Else
            ' Credenciales inválidas, mostrar mensaje de error
            ShowInvalidCredentialsMessage()
        End If
    End Sub

    Private Function ValidateCredentials(username As String, password As String) As Boolean
        ' Aquí puedes reemplazar la lógica de validación con una consulta a una base de datos u otro método
        Return username = "Pablo" AndAlso password = "123"
    End Function

    Private Sub OpenMainForm()
        Dim mainForm As New Form1()
        mainForm.Show()
        Me.Close() ' Cierra el formulario de login
    End Sub

    Private Sub ShowInvalidCredentialsMessage()
        MessageBox.Show("Credenciales inválidas. Por favor, intente de nuevo.", "Error de Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub btnCerrar_Click_Click(sender As Object, e As EventArgs) Handles btnCerrar_Click.Click
        Me.Close()
    End Sub
End Class
