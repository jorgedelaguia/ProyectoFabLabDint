Imports System.Data.SqlClient

Public Class TipoUsuarioGateway
    ''' <summary>
    ''' Objeto Connection
    ''' </summary>
    Private conexion As SqlConnection

    ''' <summary>
    ''' Objeto Command
    ''' </summary>
    Private comando As SqlCommand


    ''' <summary>
    ''' Constructor crea la conexion a la base de datos
    ''' </summary>
    ''' <param name="cadena">Cadena de conexion</param>
    Public Sub New(ByRef cadena As String)
        conexion = New SqlConnection(cadena)
        comando = New SqlCommand()
        comando.Connection = conexion
    End Sub


    Public Function Insertar(tipo As String) As Integer

        Dim filas As Integer

        Dim consulta As String = "INSERT INTO TipoUsuarios(tipo) values ('@tipo')"

        'Validar
        If tipo = "" Or Not IsNothing(tipo) Then
            Throw New ArgumentException("El tipo no puede se null/vacio")
        End If


        'Ejecutar consulta
        Try
            conexion.Open()
            comando.CommandText = consulta
            comando.Parameters.Add("@tipo", SqlDbType.VarChar)

            comando.Parameters("@tipo").Value = tipo

            filas = comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try

        Return filas


    End Function


    Public Function Actualizar(tipo As String, idTipo As Integer) As Integer

        Dim filas As Integer

        Dim consulta As String = "Update TiposUsuario set tipo=@tipo where id=@id"

        'validar datos
        If IsNumeric(idTipo) Or Not IsNothing(idTipo) Then
            Throw New ArgumentException("El id del tipo de usuario no puede se null/vacio")
        End If

        If tipo = "" Or tipo Is Nothing Then
            Throw New ArgumentException("El tipo de usuario no puede se null/vacio")
        End If

        'Ejecuta consulta
        Try
            conexion.Open()
            comando.CommandText = consulta
            comando.Parameters.Add("@tipo", SqlDbType.VarChar)
            comando.Parameters.Add("@id", SqlDbType.Int)

            comando.Parameters("@tipo").Value = tipo
            comando.Parameters("@id").Value = idTipo

            filas = comando.ExecuteNonQuery()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try

        Return filas

    End Function



    Public Function Eliminar(id As Integer) As Integer

        Dim filas As Integer

        Dim consulta As String = "DELETE FROM TiposUsuarios where id=@id"

        'validar datos
        If IsNumeric(id) Or Not IsNothing(id) Then
            Throw New ArgumentException("El id del tipo de usuario no puede se null/vacio")
        End If

        'ejecutar

        Try
            comando.CommandText = consulta
            comando.Parameters.Add("@id", SqlDbType.Int)
            comando.Parameters("@id").Value = id
            filas = comando.ExecuteNonQuery()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try

        Return filas


    End Function


    Public Function SeleccionarId(id As Integer) As DataTable
        Dim consulta As String = "SELECT * FROM TiposUsuario where id=@id"
        Dim resultado As New DataTable
        Dim lector As SqlDataReader

        'Validar
        If id = 0 Then
            Throw New ArgumentException("El id no puede estar vacio")
        End If

        'Ejecutar
        Try
            conexion.Open()
            comando.CommandText = consulta
            comando.Parameters.Add("@id", SqlDbType.Int)
            comando.Parameters("@id").Value = id
            lector = comando.ExecuteReader()

            resultado.Load(lector)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try

        Return resultado
    End Function




    Public Function SeleccionarTodos() As DataTable
        Dim consulta As String = "SELECT * FROM TiposUsuario"
        Dim resultado As New DataTable
        Dim lector As SqlDataReader

        'Ejecutar
        Try
            conexion.Open()
            comando.CommandText = consulta
            lector = comando.ExecuteReader()

            resultado.Load(lector)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try

        Return resultado
    End Function

End Class
