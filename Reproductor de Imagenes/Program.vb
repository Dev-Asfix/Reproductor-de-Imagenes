Module Program
    Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        ' Mostrar el formulario de inicio de sesión
        Dim loginForm As New LoginForm()
        If loginForm.ShowDialog() = DialogResult.OK Then
            ' Mostrar el formulario de progreso

        End If
    End Sub
End Module
