<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.pb_Principal = New System.Windows.Forms.PictureBox()
        Me.btn_siguiente = New System.Windows.Forms.Button()
        Me.btn_atras = New System.Windows.Forms.Button()
        Me.etiq = New System.Windows.Forms.Label()
        Me.btn_pantalla_completa_Click = New System.Windows.Forms.Button()
        Me.btn_salir_pantalla_completa_Click = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New Reproductor_de_Imagenes.CustomProgressBar()
        CType(Me.pb_Principal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_Principal
        '
        Me.pb_Principal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_Principal.Image = Global.Reproductor_de_Imagenes.My.Resources.Resources.Recurso7
        Me.pb_Principal.Location = New System.Drawing.Point(52, 81)
        Me.pb_Principal.Name = "pb_Principal"
        Me.pb_Principal.Size = New System.Drawing.Size(469, 275)
        Me.pb_Principal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_Principal.TabIndex = 0
        Me.pb_Principal.TabStop = False
        '
        'btn_siguiente
        '
        Me.btn_siguiente.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_siguiente.BackColor = System.Drawing.Color.Black
        Me.btn_siguiente.Cursor = System.Windows.Forms.Cursors.PanEast
        Me.btn_siguiente.ForeColor = System.Drawing.Color.Red
        Me.btn_siguiente.ImageKey = "(ninguno)"
        Me.btn_siguiente.Location = New System.Drawing.Point(472, 218)
        Me.btn_siguiente.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_siguiente.Name = "btn_siguiente"
        Me.btn_siguiente.Size = New System.Drawing.Size(75, 23)
        Me.btn_siguiente.TabIndex = 1
        Me.btn_siguiente.Text = "Siguiente"
        Me.btn_siguiente.UseVisualStyleBackColor = False
        '
        'btn_atras
        '
        Me.btn_atras.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_atras.BackColor = System.Drawing.Color.Black
        Me.btn_atras.Cursor = System.Windows.Forms.Cursors.PanWest
        Me.btn_atras.ForeColor = System.Drawing.Color.Red
        Me.btn_atras.Location = New System.Drawing.Point(12, 218)
        Me.btn_atras.Name = "btn_atras"
        Me.btn_atras.Size = New System.Drawing.Size(75, 23)
        Me.btn_atras.TabIndex = 2
        Me.btn_atras.Text = "Atras"
        Me.btn_atras.UseVisualStyleBackColor = False
        '
        'etiq
        '
        Me.etiq.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.etiq.AutoSize = True
        Me.etiq.BackColor = System.Drawing.Color.WhiteSmoke
        Me.etiq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.etiq.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiq.Location = New System.Drawing.Point(237, 390)
        Me.etiq.Name = "etiq"
        Me.etiq.Size = New System.Drawing.Size(71, 21)
        Me.etiq.TabIndex = 3
        Me.etiq.Text = "Indice"
        '
        'btn_pantalla_completa_Click
        '
        Me.btn_pantalla_completa_Click.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_pantalla_completa_Click.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pantalla_completa_Click.Location = New System.Drawing.Point(52, 362)
        Me.btn_pantalla_completa_Click.Name = "btn_pantalla_completa_Click"
        Me.btn_pantalla_completa_Click.Size = New System.Drawing.Size(88, 25)
        Me.btn_pantalla_completa_Click.TabIndex = 5
        Me.btn_pantalla_completa_Click.Text = "Maximizar"
        Me.btn_pantalla_completa_Click.UseVisualStyleBackColor = True
        '
        'btn_salir_pantalla_completa_Click
        '
        Me.btn_salir_pantalla_completa_Click.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_salir_pantalla_completa_Click.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir_pantalla_completa_Click.Location = New System.Drawing.Point(432, 362)
        Me.btn_salir_pantalla_completa_Click.Name = "btn_salir_pantalla_completa_Click"
        Me.btn_salir_pantalla_completa_Click.Size = New System.Drawing.Size(89, 25)
        Me.btn_salir_pantalla_completa_Click.TabIndex = 6
        Me.btn_salir_pantalla_completa_Click.Text = "Minimizar"
        Me.btn_salir_pantalla_completa_Click.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.Black
        Me.ProgressBar1.Location = New System.Drawing.Point(184, 22)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(182, 34)
        Me.ProgressBar1.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.Reproductor_de_Imagenes.My.Resources.Resources.Recurso7
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(577, 440)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btn_salir_pantalla_completa_Click)
        Me.Controls.Add(Me.btn_pantalla_completa_Click)
        Me.Controls.Add(Me.etiq)
        Me.Controls.Add(Me.btn_atras)
        Me.Controls.Add(Me.btn_siguiente)
        Me.Controls.Add(Me.pb_Principal)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.pb_Principal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pb_Principal As System.Windows.Forms.PictureBox
    Friend WithEvents btn_siguiente As System.Windows.Forms.Button
    Friend WithEvents btn_atras As System.Windows.Forms.Button
    Friend WithEvents etiq As System.Windows.Forms.Label
    Friend WithEvents btn_pantalla_completa_Click As System.Windows.Forms.Button
    Friend WithEvents btn_salir_pantalla_completa_Click As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As Reproductor_de_Imagenes.CustomProgressBar

End Class
