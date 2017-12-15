Public Class FormGestionUsuarios

    Dim filaSeleccionada As DataGridViewRow
    Private Sub ActualizarTablaUsuariosButton_Click(sender As Object, e As EventArgs) Handles ActualizarTablaUsuariosButton.Click
        Dim enlace As BindingSource
        Dim gateway As New UsuariosGateway(My.Settings.cadena)

        enlace = gateway.SeleccionarTodosUsuarios()

        enlace.Filter = "nombre like '*" & buscarUsuarioTextBox.Text & "*'"


        usuariosDataGridView.DataSource = enlace
        usuariosDataGridView.Columns("id").Visible = False
        usuariosDataGridView.ReadOnly = True
    End Sub

    Private Sub consultarUsuarioButton_Click(sender As Object, e As EventArgs) Handles consultarUsuarioButton.Click
        Dim nuevoUsuarioForm As New FormUsuarios
        nuevoUsuarioForm.tipo = FormUsuarios.TipoForm.Consultar
        nuevoUsuarioForm.MdiParent = Form1


        nuevoUsuarioForm.usuario = CType(usuariosDataGridView.Item(0, usuariosDataGridView.CurrentRow.Index).Value, Integer)
        nuevoUsuarioForm.Show()
    End Sub

    Private Sub editarUsuarioButton_Click(sender As Object, e As EventArgs) Handles editarUsuarioButton.Click
        Dim nuevoUsuarioForm As New FormUsuarios
        nuevoUsuarioForm.tipo = FormUsuarios.TipoForm.Modificar
        nuevoUsuarioForm.MdiParent = Form1
        nuevoUsuarioForm.usuario = CType(usuariosDataGridView.Item(0, usuariosDataGridView.CurrentRow.Index).Value, Integer)
        nuevoUsuarioForm.Show()
    End Sub

    Private Sub eliminarUsuarioButton_Click(sender As Object, e As EventArgs) Handles eliminarUsuarioButton.Click
        Dim nuevousuarioForm As New FormUsuarios
        nuevousuarioForm.tipo = FormUsuarios.TipoForm.Eliminar


        nuevousuarioForm.EliminarFila(CType(usuariosDataGridView.Item(0, usuariosDataGridView.CurrentRow.Index).Value, Integer))

    End Sub

    Private Sub nuevoUsuarioButton_Click(sender As Object, e As EventArgs) Handles nuevoUsuarioButton.Click
        Dim nuevoUsuarioForm As New FormUsuarios
        nuevoUsuarioForm.tipo = FormUsuarios.TipoForm.Insertar
        nuevoUsuarioForm.MdiParent = Form1
        nuevoUsuarioForm.Show()
    End Sub
End Class