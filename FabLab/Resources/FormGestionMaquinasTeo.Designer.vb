<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGestionMaquinas
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
        Me.BuscadorGestionMaquinasTextBox = New System.Windows.Forms.TextBox()
        Me.nuevaMaquinaButton = New System.Windows.Forms.Button()
        Me.consultarGestionMaquinasButton = New System.Windows.Forms.Button()
        Me.editarGestionMaquinasButton = New System.Windows.Forms.Button()
        Me.EliminarGestionMaquinasButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BuscadorGestionMaquinasTextBox
        '
        Me.BuscadorGestionMaquinasTextBox.Location = New System.Drawing.Point(30, 33)
        Me.BuscadorGestionMaquinasTextBox.Name = "BuscadorGestionMaquinasTextBox"
        Me.BuscadorGestionMaquinasTextBox.Size = New System.Drawing.Size(189, 20)
        Me.BuscadorGestionMaquinasTextBox.TabIndex = 0
        Me.BuscadorGestionMaquinasTextBox.Text = "Buscar"
        '
        'nuevaMaquinaButton
        '
        Me.nuevaMaquinaButton.Location = New System.Drawing.Point(736, 33)
        Me.nuevaMaquinaButton.Name = "nuevaMaquinaButton"
        Me.nuevaMaquinaButton.Size = New System.Drawing.Size(98, 32)
        Me.nuevaMaquinaButton.TabIndex = 1
        Me.nuevaMaquinaButton.Text = "Nueva máquina"
        Me.nuevaMaquinaButton.UseVisualStyleBackColor = True
        '
        'consultarGestionMaquinasButton
        '
        Me.consultarGestionMaquinasButton.Location = New System.Drawing.Point(565, 461)
        Me.consultarGestionMaquinasButton.Name = "consultarGestionMaquinasButton"
        Me.consultarGestionMaquinasButton.Size = New System.Drawing.Size(75, 23)
        Me.consultarGestionMaquinasButton.TabIndex = 2
        Me.consultarGestionMaquinasButton.Text = "Consultar"
        Me.consultarGestionMaquinasButton.UseVisualStyleBackColor = True
        '
        'editarGestionMaquinasButton
        '
        Me.editarGestionMaquinasButton.Location = New System.Drawing.Point(656, 461)
        Me.editarGestionMaquinasButton.Name = "editarGestionMaquinasButton"
        Me.editarGestionMaquinasButton.Size = New System.Drawing.Size(75, 23)
        Me.editarGestionMaquinasButton.TabIndex = 3
        Me.editarGestionMaquinasButton.Text = "Editar"
        Me.editarGestionMaquinasButton.UseVisualStyleBackColor = True
        '
        'EliminarGestionMaquinasButton
        '
        Me.EliminarGestionMaquinasButton.Location = New System.Drawing.Point(746, 461)
        Me.EliminarGestionMaquinasButton.Name = "EliminarGestionMaquinasButton"
        Me.EliminarGestionMaquinasButton.Size = New System.Drawing.Size(75, 23)
        Me.EliminarGestionMaquinasButton.TabIndex = 4
        Me.EliminarGestionMaquinasButton.Text = "Eliminar"
        Me.EliminarGestionMaquinasButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(30, 86)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(804, 360)
        Me.DataGridView1.TabIndex = 5
        '
        'FormGestionMaquinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 496)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.EliminarGestionMaquinasButton)
        Me.Controls.Add(Me.editarGestionMaquinasButton)
        Me.Controls.Add(Me.consultarGestionMaquinasButton)
        Me.Controls.Add(Me.nuevaMaquinaButton)
        Me.Controls.Add(Me.BuscadorGestionMaquinasTextBox)
        Me.Name = "FormGestionMaquinas"
        Me.Text = "FabLab - Gestion de máquinas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BuscadorGestionMaquinasTextBox As TextBox
    Friend WithEvents nuevaMaquinaButton As Button
    Friend WithEvents consultarGestionMaquinasButton As Button
    Friend WithEvents editarGestionMaquinasButton As Button
    Friend WithEvents EliminarGestionMaquinasButton As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
