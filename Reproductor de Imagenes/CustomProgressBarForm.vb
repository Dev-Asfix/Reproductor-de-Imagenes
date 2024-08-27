Public Class CustomProgressBarForm
    Inherits Form

    Private customProgressBarControl As New CustomProgressBar()

    Public Sub New()
        InitializeComponent()

        ' Configura el CustomProgressBar
        customProgressBarControl.Size = New Size(200, 30)
        customProgressBarControl.Location = New Point((Me.ClientSize.Width - customProgressBarControl.Width) \ 2, (Me.ClientSize.Height - customProgressBarControl.Height) \ 2)
        Me.Controls.Add(customProgressBarControl)

        ' Configura el temporizador para cerrar el formulario después de 3 segundos
        Dim timer As New Timer()
        AddHandler timer.Tick, AddressOf Timer_Tick
        timer.Interval = 3000 ' 3 segundos
        timer.Start()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        Dim mainForm As New Form1()
        mainForm.Show()
        Me.Close()
    End Sub
End Class
