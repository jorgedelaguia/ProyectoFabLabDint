Module NegocioUsuarios

    Public Function VerDatosUsuarios(ByVal id As Integer) As DataTable
        Dim tabla As DataTable
        Dim gateway As New UsuariosGateway(My.Settings.cadena)

        tabla = gateway.SeleccionarId(id)

        Return tabla
    End Function

    Public Function InsertarTipoUsuario(ByVal nombre As String) As Integer
        Dim gateway As New TipoUsuarioGateway(My.Settings.cadena)
        Dim filas As Integer

        filas = gateway.Insertar(nombre)

        Return filas
    End Function

    Public Function VerTipoUsuario(ByVal id As Integer) As DataTable
        Dim tabla As DataTable
        Dim gateway As New TipoUsuarioGateway(My.Settings.cadena)

        tabla = gateway.SeleccionarId(id)

        Return tabla
    End Function

    Public Function VerTodosTipoUsuarios() As DataTable
        Dim tabla As DataTable
        Dim gateway As New TipoUsuarioGateway(My.Settings.cadena)

        tabla = gateway.SeleccionarTodos()

        Return tabla
    End Function

    Public Function InsertarUsuario(ByVal nombre As String, ByVal apellidos As String, ByVal fecha_nacimiento As Date, ByVal telefono As String, ByVal email As String, ByVal direccion As String, ByVal organizacion As String, ByVal tipo As Integer) As Integer
        Dim gateway As New UsuariosGateway(My.Settings.cadena)
        Dim filas As Integer

        Debug.WriteLine(DateAndTime.Now.ToShortDateString)

        filas = gateway.Insertar(nombre, apellidos, fecha_nacimiento, telefono, email, direccion, organizacion, tipo, DateAndTime.Now)

        Return filas
    End Function

    Public Function ModificarUsuario(ByVal id As Integer, nombre As String, apellidos As String, fecha_nacimiento As Date, telefono As String, email As String, direccion As String, organizacion As String, tipo As Integer) As Integer
        Dim gateway As New UsuariosGateway(My.Settings.cadena)
        Dim filas As Integer

        filas = gateway.Actualizar(id, nombre, apellidos, fecha_nacimiento, telefono, email, direccion, organizacion, tipo)

        Return filas
    End Function

    Public Function EliminarUsuario(ByVal id As Integer) As Integer
        Dim gateway As New UsuariosGateway(My.Settings.cadena)
        Dim filas As Integer

        filas = gateway.Eliminar(id)
        Return filas

    End Function

    Public Function UltimoUsuarioID() As Integer
        Dim gateway As New UsuariosGateway(My.Settings.cadena)
        Dim id As Integer

        id = gateway.ObtenerIdUltimoUsuario()

        Return id
    End Function

    Public Function CantidadUsuarios() As Integer
        Dim gateway As New UsuariosGateway(My.Settings.cadena)
        Dim i As Integer

        i = gateway.CantidadUsuarios()

        Return i
    End Function

End Module
