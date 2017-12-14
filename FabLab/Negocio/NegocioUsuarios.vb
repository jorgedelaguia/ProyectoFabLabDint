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

    Public Function InsertarUsuario(ByVal nombre As String, ByVal apellidos As String, ByVal fecha_nacimiento As String, ByVal telefono As String, ByVal email As String, ByVal direccion As String, ByVal organizacion As String, ByVal tipo As Integer) As Integer
        Dim gateway As New UsuariosGateway(My.Settings.cadena)
        Dim filas As Integer

        'FIXME: error insertar fechas en bd
        'filas = gatewat.Insertar(nombre, apellidos, fecha_nacimiento, telefono, email, direccion, organizacion, tipo, DateAndTime.Now.ToString)
        filas = gateway.Insertar(nombre, apellidos, "10/10/2010", telefono, email, direccion, organizacion, tipo, "05/05/1960")

        Return filas
    End Function

    Public Function ModificarUsuario(ByVal id As Integer, nombre As String, apellidos As String, fecha_nacimiento As String, telefono As String, email As String, direccion As String, organizacion As String, tipo As Integer) As Integer
        Dim gateway As New UsuariosGateway(My.Settings.cadena)
        Dim filas As Integer

        filas = gateway.Actualizar(id, nombre, apellidos, "10/10/2010", telefono, email, direccion, organizacion, tipo)

        Return filas
    End Function

End Module
