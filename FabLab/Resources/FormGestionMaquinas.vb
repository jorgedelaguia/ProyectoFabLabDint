Imports FabLab.FormUsuarios

Public Class FormGestionMaquinas
    Private Sub nuevaMaquinaButton_Click(sender As Object, e As EventArgs) Handles nuevaMaquinaButton.Click
        'TODO: temporal

        Dim nuevoMaquinasForm As New FormMaquinas
        nuevoMaquinasForm.tipo = FormMaquinas.TipoForm.Insertar
        nuevoMaquinasForm.MdiParent = Form1
        'nuevoUsuarioForm.usuario = 99
        nuevoMaquinasForm.Show()
    End Sub

    Private Sub consultarMaquinaButton_Click(sender As Object, e As EventArgs) Handles consultarMaquinaButton.Click
        Dim nuevoMaquinaForm As New FormMaquinas
        nuevoMaquinaForm.tipo = FormMaquinas.TipoForm.Consultar
        nuevoMaquinaForm.MdiParent = Form1


        nuevoMaquinaForm.maquina = CType(DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value, Integer)
        nuevoMaquinaForm.Show()
    End Sub

    Private Sub editarMaquinaButton_Click(sender As Object, e As EventArgs) Handles editarMaquinaButton.Click
        Dim nuevoMaquinaForm As New FormMaquinas
        nuevoMaquinaForm.tipo = FormMaquinas.TipoForm.Modificar
        nuevoMaquinaForm.MdiParent = Form1
        nuevoMaquinaForm.maquina = CType(DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value, Integer)
        nuevoMaquinaForm.Show()
    End Sub

    Private Sub FormGestionMaquinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load, buscarMaquinaTextBox.TextChanged
        Dim enlace As BindingSource
        Dim gateway As New MaquinasGateway(My.Settings.cadena)

        enlace = gateway.SeleccionarTodasMaquinas()

        enlace.Filter = "modelo like '*" & buscarMaquinaTextBox.Text & "*'"


        DataGridView1.DataSource = enlace
        DataGridView1.Columns("id").Visible = False
        DataGridView1.ReadOnly = True

    End Sub

    Private Sub eliminarMaquinaButton_Click(sender As Object, e As EventArgs) Handles eliminarMaquinaButton.Click
        Dim nuevaMaquinaForm As New FormMaquinas
        nuevaMaquinaForm.tipo = FormMaquinas.TipoForm.Eliminar


        nuevaMaquinaForm.EliminarFila(CType(DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value, Integer))
    End Sub
End Class