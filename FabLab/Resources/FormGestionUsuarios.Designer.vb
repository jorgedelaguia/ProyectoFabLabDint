<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGestionUsuarios
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
        Me.mainTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.eliminarUsuarioButton = New System.Windows.Forms.Button()
        Me.consultarUsuarioButton = New System.Windows.Forms.Button()
        Me.editarUsuarioButton = New System.Windows.Forms.Button()
        Me.usuariosDataGridView = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.nuevoUsuarioButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ActualizarTablaUsuariosButton = New System.Windows.Forms.Button()
        Me.buscarUsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.mainTableLayoutPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.usuariosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainTableLayoutPanel
        '
        Me.mainTableLayoutPanel.ColumnCount = 1
        Me.mainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.mainTableLayoutPanel.Controls.Add(Me.TableLayoutPanel1, 0, 2)
        Me.mainTableLayoutPanel.Controls.Add(Me.usuariosDataGridView, 0, 1)
        Me.mainTableLayoutPanel.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.mainTableLayoutPanel.Name = "mainTableLayoutPanel"
        Me.mainTableLayoutPanel.RowCount = 3
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.mainTableLayoutPanel.Size = New System.Drawing.Size(901, 440)
        Me.mainTableLayoutPanel.TabIndex = 7
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.eliminarUsuarioButton, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.consultarUsuarioButton, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.editarUsuarioButton, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(587, 399)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 3, 30, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(284, 38)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'eliminarUsuarioButton
        '
        Me.eliminarUsuarioButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.eliminarUsuarioButton.Location = New System.Drawing.Point(206, 7)
        Me.eliminarUsuarioButton.Name = "eliminarUsuarioButton"
        Me.eliminarUsuarioButton.Size = New System.Drawing.Size(75, 23)
        Me.eliminarUsuarioButton.TabIndex = 5
        Me.eliminarUsuarioButton.Text = "Eliminar"
        Me.eliminarUsuarioButton.UseVisualStyleBackColor = True
        '
        'consultarUsuarioButton
        '
        Me.consultarUsuarioButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.consultarUsuarioButton.Location = New System.Drawing.Point(16, 7)
        Me.consultarUsuarioButton.Name = "consultarUsuarioButton"
        Me.consultarUsuarioButton.Size = New System.Drawing.Size(75, 23)
        Me.consultarUsuarioButton.TabIndex = 3
        Me.consultarUsuarioButton.Text = "Consultar"
        Me.consultarUsuarioButton.UseVisualStyleBackColor = True
        '
        'editarUsuarioButton
        '
        Me.editarUsuarioButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.editarUsuarioButton.Location = New System.Drawing.Point(110, 7)
        Me.editarUsuarioButton.Name = "editarUsuarioButton"
        Me.editarUsuarioButton.Size = New System.Drawing.Size(75, 23)
        Me.editarUsuarioButton.TabIndex = 4
        Me.editarUsuarioButton.Text = "Editar"
        Me.editarUsuarioButton.UseVisualStyleBackColor = True
        '
        'usuariosDataGridView
        '
        Me.usuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.usuariosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.usuariosDataGridView.Location = New System.Drawing.Point(30, 118)
        Me.usuariosDataGridView.Margin = New System.Windows.Forms.Padding(30)
        Me.usuariosDataGridView.Name = "usuariosDataGridView"
        Me.usuariosDataGridView.Size = New System.Drawing.Size(841, 248)
        Me.usuariosDataGridView.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.nuevoUsuarioButton, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(895, 82)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'nuevoUsuarioButton
        '
        Me.nuevoUsuarioButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.nuevoUsuarioButton.Location = New System.Drawing.Point(766, 29)
        Me.nuevoUsuarioButton.Margin = New System.Windows.Forms.Padding(3, 3, 30, 3)
        Me.nuevoUsuarioButton.Name = "nuevoUsuarioButton"
        Me.nuevoUsuarioButton.Size = New System.Drawing.Size(99, 23)
        Me.nuevoUsuarioButton.TabIndex = 2
        Me.nuevoUsuarioButton.Text = "Nuevo usuario"
        Me.nuevoUsuarioButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ActualizarTablaUsuariosButton)
        Me.Panel1.Controls.Add(Me.buscarUsuarioTextBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(441, 76)
        Me.Panel1.TabIndex = 3
        '
        'ActualizarTablaUsuariosButton
        '
        Me.ActualizarTablaUsuariosButton.Location = New System.Drawing.Point(351, 26)
        Me.ActualizarTablaUsuariosButton.Name = "ActualizarTablaUsuariosButton"
        Me.ActualizarTablaUsuariosButton.Size = New System.Drawing.Size(75, 23)
        Me.ActualizarTablaUsuariosButton.TabIndex = 1
        Me.ActualizarTablaUsuariosButton.Text = "Actualizar"
        Me.ActualizarTablaUsuariosButton.UseVisualStyleBackColor = True
        '
        'buscarUsuarioTextBox
        '
        Me.buscarUsuarioTextBox.Location = New System.Drawing.Point(24, 26)
        Me.buscarUsuarioTextBox.Name = "buscarUsuarioTextBox"
        Me.buscarUsuarioTextBox.Size = New System.Drawing.Size(304, 20)
        Me.buscarUsuarioTextBox.TabIndex = 0
        '
        'FormGestionUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 440)
        Me.Controls.Add(Me.mainTableLayoutPanel)
        Me.Name = "FormGestionUsuarios"
        Me.Text = "FabLab - Gestion de usuarios"
        Me.mainTableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.usuariosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainTableLayoutPanel As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents eliminarUsuarioButton As Button
    Friend WithEvents consultarUsuarioButton As Button
    Friend WithEvents editarUsuarioButton As Button
    Friend WithEvents usuariosDataGridView As DataGridView
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents nuevoUsuarioButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ActualizarTablaUsuariosButton As Button
    Friend WithEvents buscarUsuarioTextBox As TextBox
End Class
