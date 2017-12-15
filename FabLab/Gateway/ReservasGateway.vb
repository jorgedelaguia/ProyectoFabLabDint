Imports System.Data.SqlClient

Public Class ReservasGateway

    Private conexion As SqlConnection

    Private comando As SqlCommand


    Public Sub New(ByRef cadena As String)
        conexion = New SqlConnection(cadena)
        comando = New SqlCommand()
        comando.Connection = conexion
    End Sub

    Public Function Insertar(fecha As String, hora As String, usuario As Integer, proyecto As String) As Integer

        Dim filas As Integer

        Dim consulta As String = "INSERT INTO Reservas(fecha, hora, usuario, proyecto) VALUES('@fecha', '@hora', '@usuario', '@proyecto')"

        If fecha = "" Or fecha Is Nothing Then
            Throw New ArgumentException("La fecha no puede ser null/vacio")
        End If

        If hora = "" Or hora Is Nothing Then
            Throw New ArgumentException("La hora no puede ser null/vacio")
        End If

        If IsNumeric(usuario) Or Not IsNothing(usuario) Then
            Throw New ArgumentException("El usuario no puede se null/vacio")
        End If

        'ejecuta la consulta
        Try
            conexion.Open()
            comando.Parameters.Add("@fecha", SqlDbType.Date)
            comando.Parameters.Add("@hora", SqlDbType.Time)
            comando.Parameters.Add("@ususario", SqlDbType.Int)
            comando.Parameters.Add("@proyecto", SqlDbType.VarChar)

            comando.Parameters("@fecha").Value = fecha
            comando.Parameters("@hora").Value = hora
            comando.Parameters("@usuario").Value = usuario
            comando.Parameters("@proyecto").Value = proyecto

            comando.CommandText = consulta
            filas = comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If conexion IsNot Nothing Then
                conexion.Close()
            End If
        End Try

        'numero de filas afectadas
        Return filas


    End Function


    Public Function Actualizar(id As Integer, fecha As String, hora As String, usuario As Integer, proyecto As String) As Integer


        Dim filas As Integer

        Dim consulta As String = "Update Reservas set fecha=@fecha, hora=@hora, usaurio@usuario, proyecto=@proyecto WHERE id=@id"


        'ejecuta la consulta
        Try
            conexion.Open()
            comando.Parameters.Add("@fecha", SqlDbType.Date)
            comando.Parameters.Add("@hora", SqlDbType.Time)
            comando.Parameters.Add("@ususario", SqlDbType.Int)
            comando.Parameters.Add("@proyecto", SqlDbType.VarChar)
            comando.Parameters.Add("@id", SqlDbType.Int)

            comando.Parameters("@fecha").Value = fecha
            comando.Parameters("@hora").Value = hora
            comando.Parameters("@usuario").Value = usuario
            comando.Parameters("@proyecto").Value = proyecto
            comando.Parameters("@id").Value = id

            comando.CommandText = consulta
            filas = comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If conexion IsNot Nothing Then
                conexion.Close()
            End If
        End Try

        Return filas

    End Function


    Public Function Eliminar(id As Integer) As Integer

        Dim filas As Integer

        Dim consulta As String = "DELETE FROM Reservas WHERE id=@id"

        'Validar
        If id = 0 Then
            Throw New ArgumentException("El id no puede estar vacio")
        End If



        'Ejecutar
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


    Public Function SeleccionarReservasUsuarios(id As Integer) As BindingSource
        Dim enlace As BindingSource

        Try
            Dim adaptador As New SqlDataAdapter("SELECT * FROM Reservas where id=" & id, conexion)
            Dim generador As New SqlCommandBuilder(adaptador)
            Dim resultado As New DataSet

            adaptador.Fill(resultado, "Reservas")
            enlace = New BindingSource(resultado, "Reservas")

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try

        Return enlace
    End Function
End Class
