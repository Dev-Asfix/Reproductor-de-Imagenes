Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class CustomProgressBar
    Inherits ProgressBar

    Public Sub New()
        ' Establece el estilo para que el ProgressBar sea pintado por el usuario
        Me.SetStyle(ControlStyles.UserPaint, True)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        ' Obtén el área del control
        Dim rect As Rectangle = Me.ClientRectangle
        Dim fillWidth As Integer = CInt(rect.Width * (Me.Value / Me.Maximum))
        Dim fillRect As New Rectangle(0, 0, fillWidth, rect.Height)

        ' Configurar los gráficos para suavizar los bordes
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        ' Dibujar el fondo con cierta transparencia
        Using bgBrush As New SolidBrush(Color.FromArgb(50, 0, 0, 0)) ' Fondo negro con 50% de opacidad
            e.Graphics.FillRectangle(bgBrush, rect)
        End Using

        ' Dibujar el progreso con un relleno semi-transparente y bordes brillantes en rosado púrpura neón
        Using neonBrush As New SolidBrush(Color.FromArgb(100, 255, 20, 147)) ' Rosado púrpura neón con opacidad
            e.Graphics.FillRectangle(neonBrush, fillRect)
        End Using

        ' Dibujar los bordes neón alrededor del progreso y del borde redondeado
        Using neonPen As New Pen(Color.FromArgb(255, 20, 147), 2) ' Rosado púrpura neón para el borde
            neonPen.Alignment = PenAlignment.Inset

            ' Borde del progreso
            e.Graphics.DrawRectangle(neonPen, New Rectangle(1, 1, fillRect.Width - 2, fillRect.Height - 2))

            ' Borde redondeado alrededor del control completo
            Dim radius As Integer = 10 ' Radio de los bordes redondeados
            Dim path As New GraphicsPath()
            path.AddArc(0, 0, radius, radius, 180, 90)
            path.AddArc(rect.Width - radius, 0, radius, radius, 270, 90)
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90)
            path.AddArc(0, rect.Height - radius, radius, radius, 90, 90)
            path.CloseAllFigures()

            e.Graphics.DrawPath(neonPen, path)
        End Using
    End Sub
End Class
