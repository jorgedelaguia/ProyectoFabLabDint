Imports System.Data.SqlClient

Public Class TipoMaquinasGateway


    Private conexion As SqlConnection
    Private comando As SqlCommand

    Public Sub New(ByRef cadenaConexion As String)
        conexion = New SqlConnection(cadenaConexion)
        comando = New SqlCommand()
        comando.Connection = conexion
    End Sub


    Public Function Insertar(tipo As String) As Integer

        Dim filas As Integer
        Dim consulta As String = "INSERT INTO TiposMaquina(tipo) values ('@tipo')"

        'Validamos
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

    Public Function Eliminar(id As Integer) As Integer

        Dim filas As Integer

        Dim consulta As String = "DELETE FROM TiposMaquina where id=@id"

        'Validamos
        If id = 0 Or id = Nothing Then
            Throw New ArgumentException("El id no puede ser null o vacio")
        End If

        Try
            conexion.Open()
            comando.CommandText = consulta
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

        Dim consulta As String = "Update TiposMaquina set tipo=@tipo where id=@id"

        'validar datos
        If idTipo = 0 Or idTipo = Nothing Then
            Throw New ArgumentException("El idtipo no puede ser null o vacio")
        End If

        If tipo = "" Or tipo Is Nothing Then
            Throw New ArgumentException("El tipo de maquina no puede se null/vacio")
        End If

        'Ejecuta consulta
        Try
            conexion.Open()
            comando.CommandText = consulta
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

    Public Function SeleccionarTodos() As DataTable
        Dim consulta As String = "SELECT * FROM TiposMaquina"
        Dim resultado As New DataTable
        Dim lector As SqlDataReader

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
