Imports System.Windows.Forms
Imports System.Drawing

Public Class Form1
    Dim selector As Integer = 0
    Dim imagenes As Image()
    Dim cantidadImagenes As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializa el array de imágenes con las imágenes que se van a mostrar
        imagenes = New Image() {
            My.Resources.Recurso1,
            My.Resources.Recurso2,
            My.Resources.Recurso3,
            My.Resources.Recurso4,
            My.Resources.Recurso5,
            My.Resources.Recurso6,
            My.Resources.Recurso7,
            My.Resources.Recurso8
        }
        cantidadImagenes = imagenes.Length


        ProgressBar1.Size = New Size(200, 30) ' Ajusta el tamaño según sea necesario
        ProgressBar1.Maximum = 100
        Me.Controls.Add(ProgressBar1)




        MostrarImagen() ' Muestra la primera imagen al cargar el formulario
    End Sub

    Private Sub MostrarImagen()
        pb_Principal.Image = imagenes(selector)
        etiq.Text = "Imagen " & (selector + 1).ToString() & " de " & cantidadImagenes.ToString()
        ProgressBar1.Value = (selector + 1) * 100 / cantidadImagenes
    End Sub



    Private Sub Cambiar_Imagen(siguiente As Boolean)
        If siguiente Then
            selector = (selector + 1) Mod cantidadImagenes
        Else
            selector = (selector - 1 + cantidadImagenes) Mod cantidadImagenes
        End If
        MostrarImagen()
    End Sub

    Private Sub btn_siguiente_Click(sender As Object, e As EventArgs) Handles btn_siguiente.Click
        Cambiar_Imagen(True)
    End Sub

    Private Sub btn_atras_Click(sender As Object, e As EventArgs) Handles btn_atras.Click
        Cambiar_Imagen(False)
    End Sub


    Private Sub btn_pantalla_completa_Click_Click(sender As Object, e As EventArgs) Handles btn_pantalla_completa_Click.Click
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        pb_Principal.Dock = DockStyle.Fill
    End Sub

    Private Sub btn_salir_pantalla_completa_Click_Click(sender As Object, e As EventArgs) Handles btn_salir_pantalla_completa_Click.Click
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Normal
        pb_Principal.Dock = DockStyle.None


    End Sub







    Private Sub btnMinimizar_Click_Click(sender As Object, e As EventArgs) Handles btnMinimizar_Click.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrar_Click_Click(sender As Object, e As EventArgs) Handles btnCerrar_Click.Click
        Me.Close()
    End Sub
End Class
