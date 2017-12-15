Module NegocioMaquinas

    Public Function VerTodosTipoMaquinas() As DataTable
        Dim tabla As DataTable
        Dim gateway As New TipoMaquinasGateway(My.Settings.cadena)

        tabla = gateway.SeleccionarTodos()

        Return tabla
    End Function

    Public Function InsertarTipoMaquina(ByVal nombre As String) As Integer
        Dim gateway As New TipoMaquinasGateway(My.Settings.cadena)
        Dim filas As Integer

        filas = gateway.Insertar(nombre)

        Return filas
    End Function

    Public Function VerTipoMaquina(ByVal id As Integer) As DataTable
        Dim tabla As DataTable
        Dim gateway As New TipoUsuarioGateway(My.Settings.cadena)

        tabla = gateway.SeleccionarId(id)

        Return tabla
    End Function

    Public Function VerDatosMaquinas(ByVal id As Integer) As DataTable
        Dim tabla As DataTable
        Dim gateway As New MaquinasGateway(My.Settings.cadena)

        tabla = gateway.SeleccionarId(id)

        Return tabla
    End Function

    Public Function InsertarMaquina(ByVal modelo As String, ByVal precio_hora As Decimal, ByVal fecha_compra As Date, ByVal telefono_sat As String, ByVal tipo As Integer, ByVal descripcion As String, ByVal caracteristicas As String) As Integer

        Dim gatewayMaquinas As New MaquinasGateway(My.Settings.cadena)

        Dim filas As Integer

        filas = gatewayMaquinas.Insertar(modelo, precio_hora, fecha_compra, telefono_sat, tipo, descripcion, caracteristicas)

        Return filas
    End Function

    Public Function EliminarMaquina(ByVal id As Integer) As Integer
        Dim gateway As New MaquinasGateway(My.Settings.cadena)
        Dim filas As Integer

        filas = gateway.Eliminar(id)
        Return filas

    End Function

    Public Function UltimaMaquinaPorID() As Integer
        Dim gateway As New MaquinasGateway(My.Settings.cadena)
        Dim id As Integer

        id = gateway.IdUltimaMaquina()

        Return id
    End Function

    Public Function ModificarMaquina(ByVal id As Integer, ByVal modelo As String, ByVal precio_hora As Decimal, ByVal fecha_compra As Date, ByVal telefono_sat As String, ByVal tipo As Integer, ByVal descripcion As String, ByVal caracteristicas As String) As Integer

        Dim gatewayMaquinas As New MaquinasGateway(My.Settings.cadena)

        Dim filas As Integer

        filas = gatewayMaquinas.Actualizar(id, modelo, precio_hora, fecha_compra, telefono_sat, tipo, descripcion, caracteristicas)

        Return filas
    End Function
End Module