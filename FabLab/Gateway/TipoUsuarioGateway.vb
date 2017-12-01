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

End Class
