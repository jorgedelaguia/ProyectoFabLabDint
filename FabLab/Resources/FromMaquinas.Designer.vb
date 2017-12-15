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
        Me.PrecioHoraMaquinaLabel = New System.Windows.Forms.Label()
        Me.tipoMaquinaLabel = New System.Windows.Forms.Label()
        Me.fechaCompraMaquinaLabel = New System.Windows.Forms.Label()
        Me.modeloMaquinaTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoSatMaquinaTextBox = New System.Windows.Forms.TextBox()
        Me.precioHoraMaquinaTextBox = New System.Windows.Forms.TextBox()
        Me.tipoMaquinaComboBox = New System.Windows.Forms.ComboBox()
        Me.fechaCompraMaquinaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.anyadirTipoMaquinaButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.examinarImagenesMaquinaButton = New System.Windows.Forms.Button()
        Me.imagenesMaquinaLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.aceptarMaquinaButton = New System.Windows.Forms.Button()
        Me.CancelarMaquinaButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.descripcionMaquinaLabel = New System.Windows.Forms.Label()
        Me.descripcionMaquinaTextBox = New System.Windows.Forms.TextBox()
        Me.caracteristicasMaquinaLabel = New System.Windows.Forms.Label()
        Me.caracteristicasMaquinaTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'modeloMaquinaLabel
        '
        Me.modeloMaquinaLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.modeloMaquinaLabel.AutoSize = True
        Me.modeloMaquinaLabel.Location = New System.Drawing.Point(3, 19)
        Me.modeloMaquinaLabel.Name = "modeloMaquinaLabel"
        Me.modeloMaquinaLabel.Size = New System.Drawing.Size(42, 13)
        Me.modeloMaquinaLabel.TabIndex = 0
        Me.modeloMaquinaLabel.Text = "Modelo"
        '
        'telefonoSatLabel
        '
        Me.telefonoSatLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.telefonoSatLabel.AutoSize = True
        Me.telefonoSatLabel.Location = New System.Drawing.Point(3, 71)
        Me.telefonoSatLabel.Name = "telefonoSatLabel"
        Me.telefonoSatLabel.Size = New System.Drawing.Size(73, 13)
        Me.telefonoSatLabel.TabIndex = 1
        Me.telefonoSatLabel.Text = "Telefono SAT"
        '
        'PrecioHoraMaquinaLabel
        '
        Me.PrecioHoraMaquinaLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PrecioHoraMaquinaLabel.AutoSize = True
        Me.PrecioHoraMaquinaLabel.Location = New System.Drawing.Point(456, 19)
        Me.PrecioHoraMaquinaLabel.Name = "PrecioHoraMaquinaLabel"
        Me.PrecioHoraMaquinaLabel.Size = New System.Drawing.Size(65, 13)
        Me.PrecioHoraMaquinaLabel.TabIndex = 3
        Me.PrecioHoraMaquinaLabel.Text = "Precio/Hora"
        '
        'tipoMaquinaLabel
        '
        Me.tipoMaquinaLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tipoMaquinaLabel.AutoSize = True
        Me.tipoMaquinaLabel.Location = New System.Drawing.Point(456, 71)
        Me.tipoMaquinaLabel.Name = "tipoMaquinaLabel"
        Me.tipoMaquinaLabel.Size = New System.Drawing.Size(28, 13)
        Me.tipoMaquinaLabel.TabIndex = 4
        Me.tipoMaquinaLabel.Text = "Tipo"
        '
        'fechaCompraMaquinaLabel
        '
        Me.fechaCompraMaquinaLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.fechaCompraMaquinaLabel.AutoSize = True
        Me.fechaCompraMaquinaLabel.Location = New System.Drawing.Point(732, 19)
        Me.fechaCompraMaquinaLabel.Name = "fechaCompraMaquinaLabel"
        Me.fechaCompraMaquinaLabel.Size = New System.Drawing.Size(90, 13)
        Me.fechaCompraMaquinaLabel.TabIndex = 5
        Me.fechaCompraMaquinaLabel.Text = "Fecha de compra"
        '
        'modeloMaquinaTextBox
        '
        Me.modeloMaquinaTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.modeloMaquinaTextBox.Location = New System.Drawing.Point(216, 16)
        Me.modeloMaquinaTextBox.Name = "modeloMaquinaTextBox"
        Me.modeloMaquinaTextBox.Size = New System.Drawing.Size(54, 20)
        Me.modeloMaquinaTextBox.TabIndex = 8
        '
        'TelefonoSatMaquinaTextBox
        '
        Me.TelefonoSatMaquinaTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TelefonoSatMaquinaTextBox.Location = New System.Drawing.Point(216, 68)
        Me.TelefonoSatMaquinaTextBox.Name = "TelefonoSatMaquinaTextBox"
        Me.TelefonoSatMaquinaTextBox.Size = New System.Drawing.Size(54, 20)
        Me.TelefonoSatMaquinaTextBox.TabIndex = 9
        '
        'precioHoraMaquinaTextBox
        '
        Me.precioHoraMaquinaTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.precioHoraMaquinaTextBox.Location = New System.Drawing.Point(607, 16)
        Me.precioHoraMaquinaTextBox.Name = "precioHoraMaquinaTextBox"
        Me.precioHoraMaquinaTextBox.Size = New System.Drawing.Size(113, 20)
        Me.precioHoraMaquinaTextBox.TabIndex = 10
        '
        'tipoMaquinaComboBox
        '
        Me.tipoMaquinaComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tipoMaquinaComboBox.FormattingEnabled = True
        Me.tipoMaquinaComboBox.Location = New System.Drawing.Point(607, 67)
        Me.tipoMaquinaComboBox.Name = "tipoMaquinaComboBox"
        Me.tipoMaquinaComboBox.Size = New System.Drawing.Size(113, 21)
        Me.tipoMaquinaComboBox.TabIndex = 11
        '
        'fechaCompraMaquinaDateTimePicker
        '
        Me.fechaCompraMaquinaDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.fechaCompraMaquinaDateTimePicker.Location = New System.Drawing.Point(867, 16)
        Me.fechaCompraMaquinaDateTimePicker.Name = "fechaCompraMaquinaDateTimePicker"
        Me.fechaCompraMaquinaDateTimePicker.Size = New System.Drawing.Size(166, 20)
        Me.fechaCompraMaquinaDateTimePicker.TabIndex = 14
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.03196!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.96804!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.telefonoSatLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.modeloMaquinaTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TelefonoSatMaquinaTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PrecioHoraMaquinaLabel, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.fechaCompraMaquinaDateTimePicker, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tipoMaquinaLabel, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.precioHoraMaquinaTextBox, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tipoMaquinaComboBox, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.fechaCompraMaquinaLabel, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.modeloMaquinaLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.anyadirTipoMaquinaButton, 4, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1039, 104)
        Me.TableLayoutPanel1.TabIndex = 19
        '
        'anyadirTipoMaquinaButton
        '
        Me.anyadirTipoMaquinaButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.anyadirTipoMaquinaButton.Image = Global.FabLab.My.Resources.Resources.add
        Me.anyadirTipoMaquinaButton.Location = New System.Drawing.Point(732, 64)
        Me.anyadirTipoMaquinaButton.Name = "anyadirTipoMaquinaButton"
        Me.anyadirTipoMaquinaButton.Size = New System.Drawing.Size(27, 28)
        Me.anyadirTipoMaquinaButton.TabIndex = 15
        Me.anyadirTipoMaquinaButton.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(28, 12)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.71429!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 219.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1045, 529)
        Me.TableLayoutPanel2.TabIndex = 20
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel2, 0, 2)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 312)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.09467!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.90533!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1039, 214)
        Me.TableLayoutPanel4.TabIndex = 21
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.examinarImagenesMaquinaButton)
        Me.Panel1.Controls.Add(Me.imagenesMaquinaLabel)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(160, 52)
        Me.Panel1.TabIndex = 22
        '
        'examinarImagenesMaquinaButton
        '
        Me.examinarImagenesMaquinaButton.Location = New System.Drawing.Point(70, 8)
        Me.examinarImagenesMaquinaButton.Name = "examinarImagenesMaquinaButton"
        Me.examinarImagenesMaquinaButton.Size = New System.Drawing.Size(75, 28)
        Me.examinarImagenesMaquinaButton.TabIndex = 15
        Me.examinarImagenesMaquinaButton.Text = "Examinar"
        Me.examinarImagenesMaquinaButton.UseVisualStyleBackColor = True
        '
        'imagenesMaquinaLabel
        '
        Me.imagenesMaquinaLabel.AutoSize = True
        Me.imagenesMaquinaLabel.Location = New System.Drawing.Point(3, 16)
        Me.imagenesMaquinaLabel.Name = "imagenesMaquinaLabel"
        Me.imagenesMaquinaLabel.Size = New System.Drawing.Size(53, 13)
        Me.imagenesMaquinaLabel.TabIndex = 6
        Me.imagenesMaquinaLabel.Text = "Imágenes"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.aceptarMaquinaButton)
        Me.Panel2.Controls.Add(Me.CancelarMaquinaButton)
        Me.Panel2.Location = New System.Drawing.Point(873, 183)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(163, 28)
        Me.Panel2.TabIndex = 22
        '
        'aceptarMaquinaButton
        '
        Me.aceptarMaquinaButton.Location = New System.Drawing.Point(3, 3)
        Me.aceptarMaquinaButton.Name = "aceptarMaquinaButton"
        Me.aceptarMaquinaButton.Size = New System.Drawing.Size(75, 23)
        Me.aceptarMaquinaButton.TabIndex = 16
        Me.aceptarMaquinaButton.Text = "Aceptar"
        Me.aceptarMaquinaButton.UseVisualStyleBackColor = True
        '
        'CancelarMaquinaButton
        '
        Me.CancelarMaquinaButton.Location = New System.Drawing.Point(84, 3)
        Me.CancelarMaquinaButton.Name = "CancelarMaquinaButton"
        Me.CancelarMaquinaButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelarMaquinaButton.TabIndex = 17
        Me.CancelarMaquinaButton.Text = "Cancelar"
        Me.CancelarMaquinaButton.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.5!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.5!))
        Me.TableLayoutPanel3.Controls.Add(Me.descripcionMaquinaLabel, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.descripcionMaquinaTextBox, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.caracteristicasMaquinaLabel, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.caracteristicasMaquinaTextBox, 1, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 113)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 136.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1039, 193)
        Me.TableLayoutPanel3.TabIndex = 21
        '
        'descripcionMaquinaLabel
        '
        Me.descripcionMaquinaLabel.AutoSize = True
        Me.descripcionMaquinaLabel.Location = New System.Drawing.Point(3, 0)
        Me.descripcionMaquinaLabel.Name = "descripcionMaquinaLabel"
        Me.descripcionMaquinaLabel.Size = New System.Drawing.Size(63, 13)
        Me.descripcionMaquinaLabel.TabIndex = 2
        Me.descripcionMaquinaLabel.Text = "Descripción"
        '
        'descripcionMaquinaTextBox
        '
        Me.descripcionMaquinaTextBox.Location = New System.Drawing.Point(3, 60)
        Me.descripcionMaquinaTextBox.Multiline = True
        Me.descripcionMaquinaTextBox.Name = "descripcionMaquinaTextBox"
        Me.descripcionMaquinaTextBox.Size = New System.Drawing.Size(384, 105)
        Me.descripcionMaquinaTextBox.TabIndex = 12
        '
        'caracteristicasMaquinaLabel
        '
        Me.caracteristicasMaquinaLabel.AutoSize = True
        Me.caracteristicasMaquinaLabel.Location = New System.Drawing.Point(527, 0)
        Me.caracteristicasMaquinaLabel.Name = "caracteristicasMaquinaLabel"
        Me.caracteristicasMaquinaLabel.Size = New System.Drawing.Size(125, 13)
        Me.caracteristicasMaquinaLabel.TabIndex = 7
        Me.caracteristicasMaquinaLabel.Text = "Características Técnicas"
        '
        'caracteristicasMaquinaTextBox
        '
        Me.caracteristicasMaquinaTextBox.Location = New System.Drawing.Point(527, 60)
        Me.caracteristicasMaquinaTextBox.Multiline = True
        Me.caracteristicasMaquinaTextBox.Name = "caracteristicasMaquinaTextBox"
        Me.caracteristicasMaquinaTextBox.Size = New System.Drawing.Size(405, 105)
        Me.caracteristicasMaquinaTextBox.TabIndex = 13
        '
        'FromMaquinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 553)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Name = "FromMaquinas"
        Me.Text = "FabLab - Máquinas"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents modeloMaquinaLabel As Label
    Friend WithEvents telefonoSatLabel As Label
    Friend WithEvents PrecioHoraMaquinaLabel As Label
    Friend WithEvents tipoMaquinaLabel As Label
    Friend WithEvents fechaCompraMaquinaLabel As Label
    Friend WithEvents modeloMaquinaTextBox As TextBox
    Friend WithEvents TelefonoSatMaquinaTextBox As TextBox
    Friend WithEvents precioHoraMaquinaTextBox As TextBox
    Friend WithEvents tipoMaquinaComboBox As ComboBox
    Friend WithEvents fechaCompraMaquinaDateTimePicker As DateTimePicker
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents descripcionMaquinaLabel As Label
    Friend WithEvents imagenesMaquinaLabel As Label
    Friend WithEvents caracteristicasMaquinaLabel As Label
    Friend WithEvents descripcionMaquinaTextBox As TextBox
    Friend WithEvents caracteristicasMaquinaTextBox As TextBox
    Friend WithEvents examinarImagenesMaquinaButton As Button
    Friend WithEvents aceptarMaquinaButton As Button
    Friend WithEvents CancelarMaquinaButton As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents anyadirTipoMaquinaButton As Button
End Class
