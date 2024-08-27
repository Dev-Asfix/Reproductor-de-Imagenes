<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomProgressBarForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.customProgressBarControl = New Reproductor_de_Imagenes.CustomProgressBar()
        Me.SuspendLayout()
        '
        'customProgressBarControl
        '
        Me.customProgressBarControl.Location = New System.Drawing.Point(28, 26)
        Me.customProgressBarControl.Name = "customProgressBarControl"
        Me.customProgressBarControl.Size = New System.Drawing.Size(200, 30) ' Asegúrate de que el tamaño sea el que necesitas
        Me.customProgressBarControl.TabIndex = 0
        '
        'CustomProgressBarForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.customProgressBarControl)
        Me.Name = "CustomProgressBarForm"
        Me.Text = "CustomProgressBarForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents customProgressBarControl As Reproductor_de_Imagenes.CustomProgressBar
End Class
