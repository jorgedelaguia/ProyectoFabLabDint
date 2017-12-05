<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUsuarios
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
        Me.nombreUsuarioLabel = New System.Windows.Forms.Label()
        Me.telefonoUsuarioLabel = New System.Windows.Forms.Label()
        Me.organizacionUsuarioLabel = New System.Windows.Forms.Label()
        Me.fotoUsuarioLabel = New System.Windows.Forms.Label()
        Me.apellidosUsuarioLabel = New System.Windows.Forms.Label()
        Me.emailUsuarioLabel = New System.Windows.Forms.Label()
        Me.tipoUsuarioLabel = New System.Windows.Forms.Label()
        Me.fechaNacimientoUsuarioLabel = New System.Windows.Forms.Label()
        Me.direccionPostalLabel = New System.Windows.Forms.Label()
        Me.observacionesUsuarioLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'nombreUsuarioLabel
        '
        Me.nombreUsuarioLabel.AutoSize = True
        Me.nombreUsuarioLabel.Location = New System.Drawing.Point(49, 53)
        Me.nombreUsuarioLabel.Name = "nombreUsuarioLabel"
        Me.nombreUsuarioLabel.Size = New System.Drawing.Size(44, 13)
        Me.nombreUsuarioLabel.TabIndex = 0
        Me.nombreUsuarioLabel.Text = "Nombre"
        '
        'telefonoUsuarioLabel
        '
        Me.telefonoUsuarioLabel.AutoSize = True
        Me.telefonoUsuarioLabel.Location = New System.Drawing.Point(49, 111)
        Me.telefonoUsuarioLabel.Name = "telefonoUsuarioLabel"
        Me.telefonoUsuarioLabel.Size = New System.Drawing.Size(49, 13)
        Me.telefonoUsuarioLabel.TabIndex = 1
        Me.telefonoUsuarioLabel.Text = "Teléfono"
        '
        'organizacionUsuarioLabel
        '
        Me.organizacionUsuarioLabel.AutoSize = True
        Me.organizacionUsuarioLabel.Location = New System.Drawing.Point(49, 174)
        Me.organizacionUsuarioLabel.Name = "organizacionUsuarioLabel"
        Me.organizacionUsuarioLabel.Size = New System.Drawing.Size(69, 13)
        Me.organizacionUsuarioLabel.TabIndex = 2
        Me.organizacionUsuarioLabel.Text = "Organización"
        '
        'fotoUsuarioLabel
        '
        Me.fotoUsuarioLabel.AutoSize = True
        Me.fotoUsuarioLabel.Location = New System.Drawing.Point(53, 260)
        Me.fotoUsuarioLabel.Name = "fotoUsuarioLabel"
        Me.fotoUsuarioLabel.Size = New System.Drawing.Size(28, 13)
        Me.fotoUsuarioLabel.TabIndex = 3
        Me.fotoUsuarioLabel.Text = "Foto"
        '
        'apellidosUsuarioLabel
        '
        Me.apellidosUsuarioLabel.AutoSize = True
        Me.apellidosUsuarioLabel.Location = New System.Drawing.Point(304, 53)
        Me.apellidosUsuarioLabel.Name = "apellidosUsuarioLabel"
        Me.apellidosUsuarioLabel.Size = New System.Drawing.Size(49, 13)
        Me.apellidosUsuarioLabel.TabIndex = 4
        Me.apellidosUsuarioLabel.Text = "Apellidos"
        '
        'emailUsuarioLabel
        '
        Me.emailUsuarioLabel.AutoSize = True
        Me.emailUsuarioLabel.Location = New System.Drawing.Point(304, 111)
        Me.emailUsuarioLabel.Name = "emailUsuarioLabel"
        Me.emailUsuarioLabel.Size = New System.Drawing.Size(35, 13)
        Me.emailUsuarioLabel.TabIndex = 5
        Me.emailUsuarioLabel.Text = "E-mail"
        '
        'tipoUsuarioLabel
        '
        Me.tipoUsuarioLabel.AutoSize = True
        Me.tipoUsuarioLabel.Location = New System.Drawing.Point(310, 174)
        Me.tipoUsuarioLabel.Name = "tipoUsuarioLabel"
        Me.tipoUsuarioLabel.Size = New System.Drawing.Size(28, 13)
        Me.tipoUsuarioLabel.TabIndex = 6
        Me.tipoUsuarioLabel.Text = "Tipo"
        '
        'fechaNacimientoUsuarioLabel
        '
        Me.fechaNacimientoUsuarioLabel.AutoSize = True
        Me.fechaNacimientoUsuarioLabel.Location = New System.Drawing.Point(597, 72)
        Me.fechaNacimientoUsuarioLabel.Name = "fechaNacimientoUsuarioLabel"
        Me.fechaNacimientoUsuarioLabel.Size = New System.Drawing.Size(106, 13)
        Me.fechaNacimientoUsuarioLabel.TabIndex = 7
        Me.fechaNacimientoUsuarioLabel.Text = "Fecha de nacimiento"
        '
        'direccionPostalLabel
        '
        Me.direccionPostalLabel.AutoSize = True
        Me.direccionPostalLabel.Location = New System.Drawing.Point(599, 150)
        Me.direccionPostalLabel.Name = "direccionPostalLabel"
        Me.direccionPostalLabel.Size = New System.Drawing.Size(83, 13)
        Me.direccionPostalLabel.TabIndex = 8
        Me.direccionPostalLabel.Text = "Direccion postal"
        '
        'observacionesUsuarioLabel
        '
        Me.observacionesUsuarioLabel.AutoSize = True
        Me.observacionesUsuarioLabel.Location = New System.Drawing.Point(394, 295)
        Me.observacionesUsuarioLabel.Name = "observacionesUsuarioLabel"
        Me.observacionesUsuarioLabel.Size = New System.Drawing.Size(78, 13)
        Me.observacionesUsuarioLabel.TabIndex = 9
        Me.observacionesUsuarioLabel.Text = "Observaciones"
        '
        'FormUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 492)
        Me.Controls.Add(Me.observacionesUsuarioLabel)
        Me.Controls.Add(Me.direccionPostalLabel)
        Me.Controls.Add(Me.fechaNacimientoUsuarioLabel)
        Me.Controls.Add(Me.tipoUsuarioLabel)
        Me.Controls.Add(Me.emailUsuarioLabel)
        Me.Controls.Add(Me.apellidosUsuarioLabel)
        Me.Controls.Add(Me.fotoUsuarioLabel)
        Me.Controls.Add(Me.organizacionUsuarioLabel)
        Me.Controls.Add(Me.telefonoUsuarioLabel)
        Me.Controls.Add(Me.nombreUsuarioLabel)
        Me.Name = "FormUsuarios"
        Me.Text = "FormUsuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nombreUsuarioLabel As Label
    Friend WithEvents telefonoUsuarioLabel As Label
    Friend WithEvents organizacionUsuarioLabel As Label
    Friend WithEvents fotoUsuarioLabel As Label
    Friend WithEvents apellidosUsuarioLabel As Label
    Friend WithEvents emailUsuarioLabel As Label
    Friend WithEvents tipoUsuarioLabel As Label
    Friend WithEvents fechaNacimientoUsuarioLabel As Label
    Friend WithEvents direccionPostalLabel As Label
    Friend WithEvents observacionesUsuarioLabel As Label
End Class
