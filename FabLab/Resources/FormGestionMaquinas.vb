Imports FabLab.FormUsuarios

Public Class FormGestionMaquinas
    Private Sub nuevaMaquinaButton_Click(sender As Object, e As EventArgs) Handles nuevaMaquinaButton.Click
        'TODO: temporal

        Dim nuevoUsuarioForm As New FormUsuarios
        nuevoUsuarioForm.tipo = TipoForm.Insertar
        nuevoUsuarioForm.MdiParent = Form1
        'nuevoUsuarioForm.usuario = 99
        nuevoUsuarioForm.Show()
    End Sub

    Private Sub consultarMaquinaButton_Click(sender As Object, e As EventArgs) Handles consultarMaquinaButton.Click
        Dim nuevoUsuarioForm As New FormUsuarios
        nuevoUsuarioForm.tipo = TipoForm.Consultar
        nuevoUsuarioForm.MdiParent = Form1
        nuevoUsuarioForm.usuario = 1
        nuevoUsuarioForm.Show()
    End Sub

    Private Sub editarMaquinaButton_Click(sender As Object, e As EventArgs) Handles editarMaquinaButton.Click
        Dim nuevoUsuarioForm As New FormUsuarios
        nuevoUsuarioForm.tipo = TipoForm.Modificar
        nuevoUsuarioForm.MdiParent = Form1
        nuevoUsuarioForm.usuario = 1
        nuevoUsuarioForm.Show()
    End Sub
End Class