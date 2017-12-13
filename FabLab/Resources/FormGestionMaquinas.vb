Imports FabLab.FormUsuarios

Public Class FormGestionMaquinas
    Private Sub nuevaMaquinaButton_Click(sender As Object, e As EventArgs) Handles nuevaMaquinaButton.Click
        'TODO: temporal

        Dim nuevoUsuarioForm As New FormUsuarios
        nuevoUsuarioForm.tipo = TipoForm.Ver
        nuevoUsuarioForm.usuario = 99
        nuevoUsuarioForm.Show()
    End Sub
End Class