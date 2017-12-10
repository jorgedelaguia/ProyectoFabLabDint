<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FromMaquinas
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
        Me.modeloMaquinaLabel = New System.Windows.Forms.Label()
        Me.telefonoSatLabel = New System.Windows.Forms.Label()
        Me.descripcionMaquinaLabel = New System.Windows.Forms.Label()
        Me.PrecioHoraMaquinaLabel = New System.Windows.Forms.Label()
        Me.tipoMaquinaLabel = New System.Windows.Forms.Label()
        Me.fechaCompraMaquinaLabel = New System.Windows.Forms.Label()
        Me.imagenesMaquinaLabel = New System.Windows.Forms.Label()
        Me.caracteristicasMaquinaLabel = New System.Windows.Forms.Label()
        Me.modeloMaquinaTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoSatMaquinaTextBox = New System.Windows.Forms.TextBox()
        Me.precioHoraMaquinaTextBox = New System.Windows.Forms.TextBox()
        Me.tipoMaquinaComboBox = New System.Windows.Forms.ComboBox()
        Me.descripcionMaquinaTextBox = New System.Windows.Forms.TextBox()
        Me.caracteristicasMaquinaTextBox = New System.Windows.Forms.TextBox()
        Me.fechaCompraMaquinaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.examinarImagenesMaquinaButton = New System.Windows.Forms.Button()
        Me.aceptarMaquinaButton = New System.Windows.Forms.Button()
        Me.CancelarMaquinaButton = New System.Windows.Forms.Button()
        Me.contenedorImagenesMaquinaPanel = New System.Windows.Forms.Panel()
        Me.imagen1MaquinaPictureBox = New System.Windows.Forms.PictureBox()
        Me.imagen2MaquinaPictureBox = New System.Windows.Forms.PictureBox()
        Me.imagen3MaquinaPictureBox = New System.Windows.Forms.PictureBox()
        Me.imagen4MaquinaPictureBox = New System.Windows.Forms.PictureBox()
        Me.contenedorImagenesMaquinaPanel.SuspendLayout()
        CType(Me.imagen1MaquinaPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagen2MaquinaPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagen3MaquinaPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagen4MaquinaPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'modeloMaquinaLabel
        '
        Me.modeloMaquinaLabel.AutoSize = True
        Me.modeloMaquinaLabel.Location = New System.Drawing.Point(18, 43)
        Me.modeloMaquinaLabel.Name = "modeloMaquinaLabel"
        Me.modeloMaquinaLabel.Size = New System.Drawing.Size(42, 13)
        Me.modeloMaquinaLabel.TabIndex = 0
        Me.modeloMaquinaLabel.Text = "Modelo"
        '
        'telefonoSatLabel
        '
        Me.telefonoSatLabel.AutoSize = True
        Me.telefonoSatLabel.Location = New System.Drawing.Point(18, 107)
        Me.telefonoSatLabel.Name = "telefonoSatLabel"
        Me.telefonoSatLabel.Size = New System.Drawing.Size(73, 13)
        Me.telefonoSatLabel.TabIndex = 1
        Me.telefonoSatLabel.Text = "Telefono SAT"
        '
        'descripcionMaquinaLabel
        '
        Me.descripcionMaquinaLabel.AutoSize = True
        Me.descripcionMaquinaLabel.Location = New System.Drawing.Point(18, 144)
        Me.descripcionMaquinaLabel.Name = "descripcionMaquinaLabel"
        Me.descripcionMaquinaLabel.Size = New System.Drawing.Size(63, 13)
        Me.descripcionMaquinaLabel.TabIndex = 2
        Me.descripcionMaquinaLabel.Text = "Descripción"
        '
        'PrecioHoraMaquinaLabel
        '
        Me.PrecioHoraMaquinaLabel.AutoSize = True
        Me.PrecioHoraMaquinaLabel.Location = New System.Drawing.Point(263, 43)
        Me.PrecioHoraMaquinaLabel.Name = "PrecioHoraMaquinaLabel"
        Me.PrecioHoraMaquinaLabel.Size = New System.Drawing.Size(65, 13)
        Me.PrecioHoraMaquinaLabel.TabIndex = 3
        Me.PrecioHoraMaquinaLabel.Text = "Precio/Hora"
        '
        'tipoMaquinaLabel
        '
        Me.tipoMaquinaLabel.AutoSize = True
        Me.tipoMaquinaLabel.Location = New System.Drawing.Point(263, 107)
        Me.tipoMaquinaLabel.Name = "tipoMaquinaLabel"
        Me.tipoMaquinaLabel.Size = New System.Drawing.Size(28, 13)
        Me.tipoMaquinaLabel.TabIndex = 4
        Me.tipoMaquinaLabel.Text = "Tipo"
        '
        'fechaCompraMaquinaLabel
        '
        Me.fechaCompraMaquinaLabel.AutoSize = True
        Me.fechaCompraMaquinaLabel.Location = New System.Drawing.Point(516, 43)
        Me.fechaCompraMaquinaLabel.Name = "fechaCompraMaquinaLabel"
        Me.fechaCompraMaquinaLabel.Size = New System.Drawing.Size(90, 13)
        Me.fechaCompraMaquinaLabel.TabIndex = 5
        Me.fechaCompraMaquinaLabel.Text = "Fecha de compra"
        '
        'imagenesMaquinaLabel
        '
        Me.imagenesMaquinaLabel.AutoSize = True
        Me.imagenesMaquinaLabel.Location = New System.Drawing.Point(18, 284)
        Me.imagenesMaquinaLabel.Name = "imagenesMaquinaLabel"
        Me.imagenesMaquinaLabel.Size = New System.Drawing.Size(53, 13)
        Me.imagenesMaquinaLabel.TabIndex = 6
        Me.imagenesMaquinaLabel.Text = "Imágenes"
        '
        'caracteristicasMaquinaLabel
        '
        Me.caracteristicasMaquinaLabel.AutoSize = True
        Me.caracteristicasMaquinaLabel.Location = New System.Drawing.Point(425, 144)
        Me.caracteristicasMaquinaLabel.Name = "caracteristicasMaquinaLabel"
        Me.caracteristicasMaquinaLabel.Size = New System.Drawing.Size(125, 13)
        Me.caracteristicasMaquinaLabel.TabIndex = 7
        Me.caracteristicasMaquinaLabel.Text = "Características Técnicas"
        '
        'modeloMaquinaTextBox
        '
        Me.modeloMaquinaTextBox.Location = New System.Drawing.Point(97, 40)
        Me.modeloMaquinaTextBox.Name = "modeloMaquinaTextBox"
        Me.modeloMaquinaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.modeloMaquinaTextBox.TabIndex = 8
        '
        'TelefonoSatMaquinaTextBox
        '
        Me.TelefonoSatMaquinaTextBox.Location = New System.Drawing.Point(97, 103)
        Me.TelefonoSatMaquinaTextBox.Name = "TelefonoSatMaquinaTextBox"
        Me.TelefonoSatMaquinaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoSatMaquinaTextBox.TabIndex = 9
        '
        'precioHoraMaquinaTextBox
        '
        Me.precioHoraMaquinaTextBox.Location = New System.Drawing.Point(334, 40)
        Me.precioHoraMaquinaTextBox.Name = "precioHoraMaquinaTextBox"
        Me.precioHoraMaquinaTextBox.Size = New System.Drawing.Size(113, 20)
        Me.precioHoraMaquinaTextBox.TabIndex = 10
        '
        'tipoMaquinaComboBox
        '
        Me.tipoMaquinaComboBox.FormattingEnabled = True
        Me.tipoMaquinaComboBox.Location = New System.Drawing.Point(334, 103)
        Me.tipoMaquinaComboBox.Name = "tipoMaquinaComboBox"
        Me.tipoMaquinaComboBox.Size = New System.Drawing.Size(113, 21)
        Me.tipoMaquinaComboBox.TabIndex = 11
        '
        'descripcionMaquinaTextBox
        '
        Me.descripcionMaquinaTextBox.Location = New System.Drawing.Point(21, 165)
        Me.descripcionMaquinaTextBox.Multiline = True
        Me.descripcionMaquinaTextBox.Name = "descripcionMaquinaTextBox"
        Me.descripcionMaquinaTextBox.Size = New System.Drawing.Size(384, 105)
        Me.descripcionMaquinaTextBox.TabIndex = 12
        '
        'caracteristicasMaquinaTextBox
        '
        Me.caracteristicasMaquinaTextBox.Location = New System.Drawing.Point(428, 165)
        Me.caracteristicasMaquinaTextBox.Multiline = True
        Me.caracteristicasMaquinaTextBox.Name = "caracteristicasMaquinaTextBox"
        Me.caracteristicasMaquinaTextBox.Size = New System.Drawing.Size(405, 105)
        Me.caracteristicasMaquinaTextBox.TabIndex = 13
        '
        'fechaCompraMaquinaDateTimePicker
        '
        Me.fechaCompraMaquinaDateTimePicker.Location = New System.Drawing.Point(623, 40)
        Me.fechaCompraMaquinaDateTimePicker.Name = "fechaCompraMaquinaDateTimePicker"
        Me.fechaCompraMaquinaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.fechaCompraMaquinaDateTimePicker.TabIndex = 14
        '
        'examinarImagenesMaquinaButton
        '
        Me.examinarImagenesMaquinaButton.Location = New System.Drawing.Point(77, 276)
        Me.examinarImagenesMaquinaButton.Name = "examinarImagenesMaquinaButton"
        Me.examinarImagenesMaquinaButton.Size = New System.Drawing.Size(75, 28)
        Me.examinarImagenesMaquinaButton.TabIndex = 15
        Me.examinarImagenesMaquinaButton.Text = "Examinar"
        Me.examinarImagenesMaquinaButton.UseVisualStyleBackColor = True
        '
        'aceptarMaquinaButton
        '
        Me.aceptarMaquinaButton.Location = New System.Drawing.Point(684, 456)
        Me.aceptarMaquinaButton.Name = "aceptarMaquinaButton"
        Me.aceptarMaquinaButton.Size = New System.Drawing.Size(75, 23)
        Me.aceptarMaquinaButton.TabIndex = 16
        Me.aceptarMaquinaButton.Text = "Aceptar"
        Me.aceptarMaquinaButton.UseVisualStyleBackColor = True
        '
        'CancelarMaquinaButton
        '
        Me.CancelarMaquinaButton.Location = New System.Drawing.Point(775, 456)
        Me.CancelarMaquinaButton.Name = "CancelarMaquinaButton"
        Me.CancelarMaquinaButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelarMaquinaButton.TabIndex = 17
        Me.CancelarMaquinaButton.Text = "Cancelar"
        Me.CancelarMaquinaButton.UseVisualStyleBackColor = True
        '
        'contenedorImagenesMaquinaPanel
        '
        Me.contenedorImagenesMaquinaPanel.Controls.Add(Me.imagen4MaquinaPictureBox)
        Me.contenedorImagenesMaquinaPanel.Controls.Add(Me.imagen3MaquinaPictureBox)
        Me.contenedorImagenesMaquinaPanel.Controls.Add(Me.imagen2MaquinaPictureBox)
        Me.contenedorImagenesMaquinaPanel.Controls.Add(Me.imagen1MaquinaPictureBox)
        Me.contenedorImagenesMaquinaPanel.Location = New System.Drawing.Point(21, 313)
        Me.contenedorImagenesMaquinaPanel.Name = "contenedorImagenesMaquinaPanel"
        Me.contenedorImagenesMaquinaPanel.Size = New System.Drawing.Size(812, 137)
        Me.contenedorImagenesMaquinaPanel.TabIndex = 18
        '
        'imagen1MaquinaPictureBox
        '
        Me.imagen1MaquinaPictureBox.Location = New System.Drawing.Point(31, 3)
        Me.imagen1MaquinaPictureBox.Name = "imagen1MaquinaPictureBox"
        Me.imagen1MaquinaPictureBox.Size = New System.Drawing.Size(145, 131)
        Me.imagen1MaquinaPictureBox.TabIndex = 0
        Me.imagen1MaquinaPictureBox.TabStop = False
        '
        'imagen2MaquinaPictureBox
        '
        Me.imagen2MaquinaPictureBox.Location = New System.Drawing.Point(228, 3)
        Me.imagen2MaquinaPictureBox.Name = "imagen2MaquinaPictureBox"
        Me.imagen2MaquinaPictureBox.Size = New System.Drawing.Size(145, 131)
        Me.imagen2MaquinaPictureBox.TabIndex = 1
        Me.imagen2MaquinaPictureBox.TabStop = False
        '
        'imagen3MaquinaPictureBox
        '
        Me.imagen3MaquinaPictureBox.Location = New System.Drawing.Point(426, 3)
        Me.imagen3MaquinaPictureBox.Name = "imagen3MaquinaPictureBox"
        Me.imagen3MaquinaPictureBox.Size = New System.Drawing.Size(145, 131)
        Me.imagen3MaquinaPictureBox.TabIndex = 2
        Me.imagen3MaquinaPictureBox.TabStop = False
        '
        'imagen4MaquinaPictureBox
        '
        Me.imagen4MaquinaPictureBox.Location = New System.Drawing.Point(631, 3)
        Me.imagen4MaquinaPictureBox.Name = "imagen4MaquinaPictureBox"
        Me.imagen4MaquinaPictureBox.Size = New System.Drawing.Size(145, 131)
        Me.imagen4MaquinaPictureBox.TabIndex = 3
        Me.imagen4MaquinaPictureBox.TabStop = False
        '
        'FromMaquinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 491)
        Me.Controls.Add(Me.contenedorImagenesMaquinaPanel)
        Me.Controls.Add(Me.CancelarMaquinaButton)
        Me.Controls.Add(Me.aceptarMaquinaButton)
        Me.Controls.Add(Me.examinarImagenesMaquinaButton)
        Me.Controls.Add(Me.fechaCompraMaquinaDateTimePicker)
        Me.Controls.Add(Me.caracteristicasMaquinaTextBox)
        Me.Controls.Add(Me.descripcionMaquinaTextBox)
        Me.Controls.Add(Me.tipoMaquinaComboBox)
        Me.Controls.Add(Me.precioHoraMaquinaTextBox)
        Me.Controls.Add(Me.TelefonoSatMaquinaTextBox)
        Me.Controls.Add(Me.modeloMaquinaTextBox)
        Me.Controls.Add(Me.caracteristicasMaquinaLabel)
        Me.Controls.Add(Me.imagenesMaquinaLabel)
        Me.Controls.Add(Me.fechaCompraMaquinaLabel)
        Me.Controls.Add(Me.tipoMaquinaLabel)
        Me.Controls.Add(Me.PrecioHoraMaquinaLabel)
        Me.Controls.Add(Me.descripcionMaquinaLabel)
        Me.Controls.Add(Me.telefonoSatLabel)
        Me.Controls.Add(Me.modeloMaquinaLabel)
        Me.Name = "FromMaquinas"
        Me.Text = "FabLab - Nueva máquina"
        Me.contenedorImagenesMaquinaPanel.ResumeLayout(False)
        CType(Me.imagen1MaquinaPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagen2MaquinaPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagen3MaquinaPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagen4MaquinaPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents modeloMaquinaLabel As Label
    Friend WithEvents telefonoSatLabel As Label
    Friend WithEvents descripcionMaquinaLabel As Label
    Friend WithEvents PrecioHoraMaquinaLabel As Label
    Friend WithEvents tipoMaquinaLabel As Label
    Friend WithEvents fechaCompraMaquinaLabel As Label
    Friend WithEvents imagenesMaquinaLabel As Label
    Friend WithEvents caracteristicasMaquinaLabel As Label
    Friend WithEvents modeloMaquinaTextBox As TextBox
    Friend WithEvents TelefonoSatMaquinaTextBox As TextBox
    Friend WithEvents precioHoraMaquinaTextBox As TextBox
    Friend WithEvents tipoMaquinaComboBox As ComboBox
    Friend WithEvents descripcionMaquinaTextBox As TextBox
    Friend WithEvents caracteristicasMaquinaTextBox As TextBox
    Friend WithEvents fechaCompraMaquinaDateTimePicker As DateTimePicker
    Friend WithEvents examinarImagenesMaquinaButton As Button
    Friend WithEvents aceptarMaquinaButton As Button
    Friend WithEvents CancelarMaquinaButton As Button
    Friend WithEvents contenedorImagenesMaquinaPanel As Panel
    Friend WithEvents imagen4MaquinaPictureBox As PictureBox
    Friend WithEvents imagen3MaquinaPictureBox As PictureBox
    Friend WithEvents imagen2MaquinaPictureBox As PictureBox
    Friend WithEvents imagen1MaquinaPictureBox As PictureBox
End Class
