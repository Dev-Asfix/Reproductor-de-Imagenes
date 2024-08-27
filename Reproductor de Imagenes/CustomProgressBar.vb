Imports System.Windows.Forms
Imports System.Drawing

Public Class CustomProgressBar
    Inherits ProgressBar

    Public Sub New()
        ' Establece el estilo para que el ProgressBar sea pintado por el usuario
        Me.SetStyle(ControlStyles.UserPaint, True)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        ' Obtén el área del control
        Dim rect As Rectangle = Me.ClientRectangle
        ' Calcula el área a rellenar basado en el valor actual del ProgressBar
        Dim fillRect As Rectangle = New Rectangle(0, 0, CInt(rect.Width * (Me.Value / Me.Maximum)), rect.Height)

        ' Dibujar el fondo del ProgressBar
        e.Graphics.FillRectangle(Brushes.White, rect)

        ' Dibujar el progreso con el color deseado (cambia "Blue" por el color que prefieras)
        e.Graphics.FillRectangle(Brushes.Blue, fillRect)
    End Sub
End Class
