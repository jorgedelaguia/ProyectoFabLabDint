Module NegocioUsuarios

    Public Function VerDatosUsuarios(ByVal id As Integer) As DataTable
        Dim tabla As DataTable
        Dim gateway As New UsuariosGateway(My.Settings.cadena)

        tabla = gateway.SeleccionarId(id)

        Return tabla
    End Function

End Module
