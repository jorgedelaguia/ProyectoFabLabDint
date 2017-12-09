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
        Me.buscarMaquinaTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.nuevaMaquinaButton = New System.Windows.Forms.Button()
        Me.consultarMaquinaButton = New System.Windows.Forms.Button()
        Me.editarMaquinaButton = New System.Windows.Forms.Button()
        Me.eliminarMaquinaButton = New System.Windows.Forms.Button()
        Me.mainTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainTableLayoutPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'buscarMaquinaTextBox
        '
        Me.buscarMaquinaTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.buscarMaquinaTextBox.Location = New System.Drawing.Point(30, 31)
        Me.buscarMaquinaTextBox.Margin = New System.Windows.Forms.Padding(30, 3, 3, 3)
        Me.buscarMaquinaTextBox.Name = "buscarMaquinaTextBox"
        Me.buscarMaquinaTextBox.Size = New System.Drawing.Size(319, 20)
        Me.buscarMaquinaTextBox.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(30, 119)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(30)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(829, 251)
        Me.DataGridView1.TabIndex = 1
        '
        'nuevaMaquinaButton
        '
        Me.nuevaMaquinaButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.nuevaMaquinaButton.Location = New System.Drawing.Point(754, 30)
        Me.nuevaMaquinaButton.Margin = New System.Windows.Forms.Padding(3, 3, 30, 3)
        Me.nuevaMaquinaButton.Name = "nuevaMaquinaButton"
        Me.nuevaMaquinaButton.Size = New System.Drawing.Size(99, 23)
        Me.nuevaMaquinaButton.TabIndex = 2
        Me.nuevaMaquinaButton.Text = "Nueva maquina"
        Me.nuevaMaquinaButton.UseVisualStyleBackColor = True
        '
        'consultarMaquinaButton
        '
        Me.consultarMaquinaButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.consultarMaquinaButton.Location = New System.Drawing.Point(16, 8)
        Me.consultarMaquinaButton.Name = "consultarMaquinaButton"
        Me.consultarMaquinaButton.Size = New System.Drawing.Size(75, 23)
        Me.consultarMaquinaButton.TabIndex = 3
        Me.consultarMaquinaButton.Text = "Consultar"
        Me.consultarMaquinaButton.UseVisualStyleBackColor = True
        '
        'editarMaquinaButton
        '
        Me.editarMaquinaButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.editarMaquinaButton.Location = New System.Drawing.Point(110, 8)
        Me.editarMaquinaButton.Name = "editarMaquinaButton"
        Me.editarMaquinaButton.Size = New System.Drawing.Size(75, 23)
        Me.editarMaquinaButton.TabIndex = 4
        Me.editarMaquinaButton.Text = "Editar"
        Me.editarMaquinaButton.UseVisualStyleBackColor = True
        '
        'eliminarMaquinaButton
        '
        Me.eliminarMaquinaButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.eliminarMaquinaButton.Location = New System.Drawing.Point(206, 8)
        Me.eliminarMaquinaButton.Name = "eliminarMaquinaButton"
        Me.eliminarMaquinaButton.Size = New System.Drawing.Size(75, 23)
        Me.eliminarMaquinaButton.TabIndex = 5
        Me.eliminarMaquinaButton.Text = "Eliminar"
        Me.eliminarMaquinaButton.UseVisualStyleBackColor = True
        '
        'mainTableLayoutPanel
        '
        Me.mainTableLayoutPanel.ColumnCount = 1
        Me.mainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.mainTableLayoutPanel.Controls.Add(Me.TableLayoutPanel1, 0, 2)
        Me.mainTableLayoutPanel.Controls.Add(Me.DataGridView1, 0, 1)
        Me.mainTableLayoutPanel.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.mainTableLayoutPanel.Name = "mainTableLayoutPanel"
        Me.mainTableLayoutPanel.RowCount = 3
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.mainTableLayoutPanel.Size = New System.Drawing.Size(889, 445)
        Me.mainTableLayoutPanel.TabIndex = 6
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.eliminarMaquinaButton, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.consultarMaquinaButton, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.editarMaquinaButton, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(575, 403)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 3, 30, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(284, 39)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.nuevaMaquinaButton, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.buscarMaquinaTextBox, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(883, 83)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'FormGestionMaquinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 445)
        Me.Controls.Add(Me.mainTableLayoutPanel)
        Me.Name = "FormGestionMaquinas"
        Me.Text = "FormGestionMaquinas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainTableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents buscarMaquinaTextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents nuevaMaquinaButton As Button
    Friend WithEvents consultarMaquinaButton As Button
    Friend WithEvents editarMaquinaButton As Button
    Friend WithEvents eliminarMaquinaButton As Button
    Friend WithEvents mainTableLayoutPanel As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
End Class
