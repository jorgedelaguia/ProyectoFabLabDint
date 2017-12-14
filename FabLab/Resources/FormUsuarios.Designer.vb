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
        Me.nombreUsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.telefonoUsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.organizacionUsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.apellidosUsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.emailUsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.direccionPostalUsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.fechaNacimientoUsuarioDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.examinarFotosButton = New System.Windows.Forms.Button()
        Me.observacionesUsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.tipoUsuarioComboBox = New System.Windows.Forms.ComboBox()
        Me.aceptarUsuarioButton = New System.Windows.Forms.Button()
        Me.cancelarUsuarioButton = New System.Windows.Forms.Button()
        Me.mainTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.datosUsuarioTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.aniadirTipoUsuarioButton = New System.Windows.Forms.Button()
        Me.fotosObservacionesTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.mainTableLayoutPanel.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.datosUsuarioTableLayoutPanel.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.fotosObservacionesTableLayoutPanel.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'nombreUsuarioLabel
        '
        Me.nombreUsuarioLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.nombreUsuarioLabel.AutoSize = True
        Me.nombreUsuarioLabel.Location = New System.Drawing.Point(3, 32)
        Me.nombreUsuarioLabel.Name = "nombreUsuarioLabel"
        Me.nombreUsuarioLabel.Size = New System.Drawing.Size(44, 13)
        Me.nombreUsuarioLabel.TabIndex = 0
        Me.nombreUsuarioLabel.Text = "Nombre"
        '
        'telefonoUsuarioLabel
        '
        Me.telefonoUsuarioLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.telefonoUsuarioLabel.AutoSize = True
        Me.telefonoUsuarioLabel.Location = New System.Drawing.Point(3, 109)
        Me.telefonoUsuarioLabel.Name = "telefonoUsuarioLabel"
        Me.telefonoUsuarioLabel.Size = New System.Drawing.Size(49, 13)
        Me.telefonoUsuarioLabel.TabIndex = 1
        Me.telefonoUsuarioLabel.Text = "Teléfono"
        '
        'organizacionUsuarioLabel
        '
        Me.organizacionUsuarioLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.organizacionUsuarioLabel.AutoSize = True
        Me.organizacionUsuarioLabel.Location = New System.Drawing.Point(3, 186)
        Me.organizacionUsuarioLabel.Name = "organizacionUsuarioLabel"
        Me.organizacionUsuarioLabel.Size = New System.Drawing.Size(69, 13)
        Me.organizacionUsuarioLabel.TabIndex = 2
        Me.organizacionUsuarioLabel.Text = "Organización"
        '
        'fotoUsuarioLabel
        '
        Me.fotoUsuarioLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.fotoUsuarioLabel.AutoSize = True
        Me.fotoUsuarioLabel.Location = New System.Drawing.Point(3, 12)
        Me.fotoUsuarioLabel.Name = "fotoUsuarioLabel"
        Me.fotoUsuarioLabel.Size = New System.Drawing.Size(28, 13)
        Me.fotoUsuarioLabel.TabIndex = 3
        Me.fotoUsuarioLabel.Text = "Foto"
        '
        'apellidosUsuarioLabel
        '
        Me.apellidosUsuarioLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.apellidosUsuarioLabel.AutoSize = True
        Me.apellidosUsuarioLabel.Location = New System.Drawing.Point(274, 32)
        Me.apellidosUsuarioLabel.Name = "apellidosUsuarioLabel"
        Me.apellidosUsuarioLabel.Size = New System.Drawing.Size(49, 13)
        Me.apellidosUsuarioLabel.TabIndex = 4
        Me.apellidosUsuarioLabel.Text = "Apellidos"
        '
        'emailUsuarioLabel
        '
        Me.emailUsuarioLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.emailUsuarioLabel.AutoSize = True
        Me.emailUsuarioLabel.Location = New System.Drawing.Point(274, 109)
        Me.emailUsuarioLabel.Name = "emailUsuarioLabel"
        Me.emailUsuarioLabel.Size = New System.Drawing.Size(35, 13)
        Me.emailUsuarioLabel.TabIndex = 5
        Me.emailUsuarioLabel.Text = "E-mail"
        '
        'tipoUsuarioLabel
        '
        Me.tipoUsuarioLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tipoUsuarioLabel.AutoSize = True
        Me.tipoUsuarioLabel.Location = New System.Drawing.Point(274, 186)
        Me.tipoUsuarioLabel.Name = "tipoUsuarioLabel"
        Me.tipoUsuarioLabel.Size = New System.Drawing.Size(28, 13)
        Me.tipoUsuarioLabel.TabIndex = 6
        Me.tipoUsuarioLabel.Text = "Tipo"
        '
        'fechaNacimientoUsuarioLabel
        '
        Me.fechaNacimientoUsuarioLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.fechaNacimientoUsuarioLabel.AutoSize = True
        Me.fechaNacimientoUsuarioLabel.Location = New System.Drawing.Point(545, 25)
        Me.fechaNacimientoUsuarioLabel.Name = "fechaNacimientoUsuarioLabel"
        Me.fechaNacimientoUsuarioLabel.Size = New System.Drawing.Size(58, 26)
        Me.fechaNacimientoUsuarioLabel.TabIndex = 7
        Me.fechaNacimientoUsuarioLabel.Text = "Fecha de nacimiento"
        '
        'direccionPostalLabel
        '
        Me.direccionPostalLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.direccionPostalLabel.AutoSize = True
        Me.direccionPostalLabel.Location = New System.Drawing.Point(545, 102)
        Me.direccionPostalLabel.Name = "direccionPostalLabel"
        Me.direccionPostalLabel.Size = New System.Drawing.Size(55, 26)
        Me.direccionPostalLabel.TabIndex = 8
        Me.direccionPostalLabel.Text = "Direccion postal"
        '
        'observacionesUsuarioLabel
        '
        Me.observacionesUsuarioLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.observacionesUsuarioLabel.AutoSize = True
        Me.observacionesUsuarioLabel.Location = New System.Drawing.Point(422, 15)
        Me.observacionesUsuarioLabel.Name = "observacionesUsuarioLabel"
        Me.observacionesUsuarioLabel.Size = New System.Drawing.Size(78, 13)
        Me.observacionesUsuarioLabel.TabIndex = 9
        Me.observacionesUsuarioLabel.Text = "Observaciones"
        '
        'nombreUsuarioTextBox
        '
        Me.nombreUsuarioTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nombreUsuarioTextBox.Location = New System.Drawing.Point(86, 28)
        Me.nombreUsuarioTextBox.Margin = New System.Windows.Forms.Padding(3, 3, 30, 3)
        Me.nombreUsuarioTextBox.Name = "nombreUsuarioTextBox"
        Me.nombreUsuarioTextBox.Size = New System.Drawing.Size(155, 20)
        Me.nombreUsuarioTextBox.TabIndex = 10
        '
        'telefonoUsuarioTextBox
        '
        Me.telefonoUsuarioTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.telefonoUsuarioTextBox.Location = New System.Drawing.Point(86, 105)
        Me.telefonoUsuarioTextBox.Name = "telefonoUsuarioTextBox"
        Me.telefonoUsuarioTextBox.Size = New System.Drawing.Size(94, 20)
        Me.telefonoUsuarioTextBox.TabIndex = 11
        '
        'organizacionUsuarioTextBox
        '
        Me.organizacionUsuarioTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.organizacionUsuarioTextBox.Location = New System.Drawing.Point(86, 183)
        Me.organizacionUsuarioTextBox.Margin = New System.Windows.Forms.Padding(3, 3, 30, 3)
        Me.organizacionUsuarioTextBox.Name = "organizacionUsuarioTextBox"
        Me.organizacionUsuarioTextBox.Size = New System.Drawing.Size(155, 20)
        Me.organizacionUsuarioTextBox.TabIndex = 12
        '
        'apellidosUsuarioTextBox
        '
        Me.apellidosUsuarioTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.apellidosUsuarioTextBox.Location = New System.Drawing.Point(357, 28)
        Me.apellidosUsuarioTextBox.Margin = New System.Windows.Forms.Padding(3, 3, 30, 3)
        Me.apellidosUsuarioTextBox.Name = "apellidosUsuarioTextBox"
        Me.apellidosUsuarioTextBox.Size = New System.Drawing.Size(155, 20)
        Me.apellidosUsuarioTextBox.TabIndex = 13
        '
        'emailUsuarioTextBox
        '
        Me.emailUsuarioTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.emailUsuarioTextBox.Location = New System.Drawing.Point(357, 105)
        Me.emailUsuarioTextBox.Margin = New System.Windows.Forms.Padding(3, 3, 30, 3)
        Me.emailUsuarioTextBox.Name = "emailUsuarioTextBox"
        Me.emailUsuarioTextBox.Size = New System.Drawing.Size(155, 20)
        Me.emailUsuarioTextBox.TabIndex = 14
        '
        'direccionPostalUsuarioTextBox
        '
        Me.direccionPostalUsuarioTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.direccionPostalUsuarioTextBox.Location = New System.Drawing.Point(628, 105)
        Me.direccionPostalUsuarioTextBox.Margin = New System.Windows.Forms.Padding(3, 3, 30, 3)
        Me.direccionPostalUsuarioTextBox.Name = "direccionPostalUsuarioTextBox"
        Me.direccionPostalUsuarioTextBox.Size = New System.Drawing.Size(181, 20)
        Me.direccionPostalUsuarioTextBox.TabIndex = 15
        '
        'fechaNacimientoUsuarioDateTimePicker
        '
        Me.fechaNacimientoUsuarioDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.fechaNacimientoUsuarioDateTimePicker.Location = New System.Drawing.Point(628, 28)
        Me.fechaNacimientoUsuarioDateTimePicker.Name = "fechaNacimientoUsuarioDateTimePicker"
        Me.fechaNacimientoUsuarioDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.fechaNacimientoUsuarioDateTimePicker.TabIndex = 16
        '
        'examinarFotosButton
        '
        Me.examinarFotosButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.examinarFotosButton.Location = New System.Drawing.Point(54, 7)
        Me.examinarFotosButton.Name = "examinarFotosButton"
        Me.examinarFotosButton.Size = New System.Drawing.Size(75, 23)
        Me.examinarFotosButton.TabIndex = 17
        Me.examinarFotosButton.Text = "Examinar"
        Me.examinarFotosButton.UseVisualStyleBackColor = True
        '
        'observacionesUsuarioTextBox
        '
        Me.observacionesUsuarioTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.observacionesUsuarioTextBox.Location = New System.Drawing.Point(422, 46)
        Me.observacionesUsuarioTextBox.Multiline = True
        Me.observacionesUsuarioTextBox.Name = "observacionesUsuarioTextBox"
        Me.observacionesUsuarioTextBox.Size = New System.Drawing.Size(414, 183)
        Me.observacionesUsuarioTextBox.TabIndex = 18
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 46)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(413, 183)
        Me.FlowLayoutPanel1.TabIndex = 19
        '
        'tipoUsuarioComboBox
        '
        Me.tipoUsuarioComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tipoUsuarioComboBox.FormattingEnabled = True
        Me.tipoUsuarioComboBox.Location = New System.Drawing.Point(3, 25)
        Me.tipoUsuarioComboBox.Margin = New System.Windows.Forms.Padding(3, 3, 15, 3)
        Me.tipoUsuarioComboBox.Name = "tipoUsuarioComboBox"
        Me.tipoUsuarioComboBox.Size = New System.Drawing.Size(104, 21)
        Me.tipoUsuarioComboBox.TabIndex = 22
        '
        'aceptarUsuarioButton
        '
        Me.aceptarUsuarioButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.aceptarUsuarioButton.Location = New System.Drawing.Point(21, 12)
        Me.aceptarUsuarioButton.Name = "aceptarUsuarioButton"
        Me.aceptarUsuarioButton.Size = New System.Drawing.Size(75, 23)
        Me.aceptarUsuarioButton.TabIndex = 23
        Me.aceptarUsuarioButton.Text = "Aceptar"
        Me.aceptarUsuarioButton.UseVisualStyleBackColor = True
        '
        'cancelarUsuarioButton
        '
        Me.cancelarUsuarioButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cancelarUsuarioButton.Location = New System.Drawing.Point(117, 12)
        Me.cancelarUsuarioButton.Name = "cancelarUsuarioButton"
        Me.cancelarUsuarioButton.Size = New System.Drawing.Size(79, 23)
        Me.cancelarUsuarioButton.TabIndex = 24
        Me.cancelarUsuarioButton.Text = "Cancelar"
        Me.cancelarUsuarioButton.UseVisualStyleBackColor = True
        '
        'mainTableLayoutPanel
        '
        Me.mainTableLayoutPanel.ColumnCount = 1
        Me.mainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mainTableLayoutPanel.Controls.Add(Me.TableLayoutPanel4, 0, 2)
        Me.mainTableLayoutPanel.Controls.Add(Me.datosUsuarioTableLayoutPanel, 0, 0)
        Me.mainTableLayoutPanel.Controls.Add(Me.fotosObservacionesTableLayoutPanel, 0, 1)
        Me.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.mainTableLayoutPanel.Name = "mainTableLayoutPanel"
        Me.mainTableLayoutPanel.RowCount = 3
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.mainTableLayoutPanel.Size = New System.Drawing.Size(899, 530)
        Me.mainTableLayoutPanel.TabIndex = 25
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.aceptarUsuarioButton, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.cancelarUsuarioButton, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(670, 479)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(3, 3, 30, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(199, 48)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'datosUsuarioTableLayoutPanel
        '
        Me.datosUsuarioTableLayoutPanel.ColumnCount = 6
        Me.datosUsuarioTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.datosUsuarioTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5!))
        Me.datosUsuarioTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.datosUsuarioTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5!))
        Me.datosUsuarioTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.datosUsuarioTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.datosUsuarioTableLayoutPanel.Controls.Add(Me.nombreUsuarioLabel, 0, 0)
        Me.datosUsuarioTableLayoutPanel.Controls.Add(Me.telefonoUsuarioLabel, 0, 1)
        Me.datosUsuarioTableLayoutPanel.Controls.Add(Me.organizacionUsuarioLabel, 0, 2)
        Me.datosUsuarioTableLayoutPanel.Controls.Add(Me.nombreUsuarioTextBox, 1, 0)
        Me.datosUsuarioTableLayoutPanel.Controls.Add(Me.telefonoUsuarioTextBox, 1, 1)
        Me.datosUsuarioTableLayoutPanel.Controls.Add(Me.direccionPostalUsuarioTextBox, 5, 1)
        Me.datosUsuarioTableLayoutPanel.Controls.Add(Me.fechaNacimientoUsuarioDateTimePicker, 5, 0)
        Me.datosUsuarioTableLayoutPanel.Controls.Add(Me.direccionPostalLabel, 4, 1)
        Me.datosUsuarioTableLayoutPanel.Controls.Add(Me.organizacionUsuarioTextBox, 1, 2)
        Me.datosUsuarioTableLayoutPanel.Controls.Add(Me.apellidosUsuarioLabel, 2, 0)
        Me.datosUsuarioTableLayoutPanel.Controls.Add(Me.emailUsuarioTextBox, 3, 1)
        Me.datosUsuarioTableLayoutPanel.Controls.Add(Me.fechaNacimientoUsuarioLabel, 4, 0)
        Me.datosUsuarioTableLayoutPanel.Controls.Add(Me.emailUsuarioLabel, 2, 1)
        Me.datosUsuarioTableLayoutPanel.Controls.Add(Me.apellidosUsuarioTextBox, 3, 0)
        Me.datosUsuarioTableLayoutPanel.Controls.Add(Me.tipoUsuarioLabel, 2, 2)
        Me.datosUsuarioTableLayoutPanel.Controls.Add(Me.TableLayoutPanel6, 3, 2)
        Me.datosUsuarioTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datosUsuarioTableLayoutPanel.Location = New System.Drawing.Point(30, 3)
        Me.datosUsuarioTableLayoutPanel.Margin = New System.Windows.Forms.Padding(30, 3, 30, 3)
        Me.datosUsuarioTableLayoutPanel.Name = "datosUsuarioTableLayoutPanel"
        Me.datosUsuarioTableLayoutPanel.RowCount = 3
        Me.datosUsuarioTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.datosUsuarioTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.datosUsuarioTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.datosUsuarioTableLayoutPanel.Size = New System.Drawing.Size(839, 232)
        Me.datosUsuarioTableLayoutPanel.TabIndex = 2
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.30769!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.69231!))
        Me.TableLayoutPanel6.Controls.Add(Me.tipoUsuarioComboBox, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.aniadirTipoUsuarioButton, 1, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(357, 157)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(182, 72)
        Me.TableLayoutPanel6.TabIndex = 17
        '
        'aniadirTipoUsuarioButton
        '
        Me.aniadirTipoUsuarioButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.aniadirTipoUsuarioButton.Image = Global.FabLab.My.Resources.Resources.add
        Me.aniadirTipoUsuarioButton.Location = New System.Drawing.Point(125, 24)
        Me.aniadirTipoUsuarioButton.Name = "aniadirTipoUsuarioButton"
        Me.aniadirTipoUsuarioButton.Size = New System.Drawing.Size(30, 23)
        Me.aniadirTipoUsuarioButton.TabIndex = 21
        Me.aniadirTipoUsuarioButton.UseVisualStyleBackColor = True
        '
        'fotosObservacionesTableLayoutPanel
        '
        Me.fotosObservacionesTableLayoutPanel.ColumnCount = 2
        Me.fotosObservacionesTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.fotosObservacionesTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.fotosObservacionesTableLayoutPanel.Controls.Add(Me.observacionesUsuarioLabel, 1, 0)
        Me.fotosObservacionesTableLayoutPanel.Controls.Add(Me.observacionesUsuarioTextBox, 1, 1)
        Me.fotosObservacionesTableLayoutPanel.Controls.Add(Me.FlowLayoutPanel1, 0, 1)
        Me.fotosObservacionesTableLayoutPanel.Controls.Add(Me.TableLayoutPanel5, 0, 0)
        Me.fotosObservacionesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fotosObservacionesTableLayoutPanel.Location = New System.Drawing.Point(30, 241)
        Me.fotosObservacionesTableLayoutPanel.Margin = New System.Windows.Forms.Padding(30, 3, 30, 3)
        Me.fotosObservacionesTableLayoutPanel.Name = "fotosObservacionesTableLayoutPanel"
        Me.fotosObservacionesTableLayoutPanel.RowCount = 2
        Me.fotosObservacionesTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.95425!))
        Me.fotosObservacionesTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.04575!))
        Me.fotosObservacionesTableLayoutPanel.Size = New System.Drawing.Size(839, 232)
        Me.fotosObservacionesTableLayoutPanel.TabIndex = 1
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.3253!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.6747!))
        Me.TableLayoutPanel5.Controls.Add(Me.fotoUsuarioLabel, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.examinarFotosButton, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(166, 37)
        Me.TableLayoutPanel5.TabIndex = 20
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FormUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 530)
        Me.Controls.Add(Me.mainTableLayoutPanel)
        Me.Name = "FormUsuarios"
        Me.Text = "FabLab - Usuarios"
        Me.mainTableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.datosUsuarioTableLayoutPanel.ResumeLayout(False)
        Me.datosUsuarioTableLayoutPanel.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.fotosObservacionesTableLayoutPanel.ResumeLayout(False)
        Me.fotosObservacionesTableLayoutPanel.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents nombreUsuarioTextBox As TextBox
    Friend WithEvents telefonoUsuarioTextBox As TextBox
    Friend WithEvents organizacionUsuarioTextBox As TextBox
    Friend WithEvents apellidosUsuarioTextBox As TextBox
    Friend WithEvents emailUsuarioTextBox As TextBox
    Friend WithEvents direccionPostalUsuarioTextBox As TextBox
    Friend WithEvents fechaNacimientoUsuarioDateTimePicker As DateTimePicker
    Friend WithEvents examinarFotosButton As Button
    Friend WithEvents observacionesUsuarioTextBox As TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents aniadirTipoUsuarioButton As Button
    Friend WithEvents tipoUsuarioComboBox As ComboBox
    Friend WithEvents aceptarUsuarioButton As Button
    Friend WithEvents cancelarUsuarioButton As Button
    Friend WithEvents mainTableLayoutPanel As TableLayoutPanel
    Friend WithEvents fotosObservacionesTableLayoutPanel As TableLayoutPanel
    Friend WithEvents datosUsuarioTableLayoutPanel As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
