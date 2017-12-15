﻿Imports System.Data.SqlClient

''' <summary>
''' Gateway para la tabla Usuarios
''' </summary>
Public Class UsuariosGateway
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


    ''' <summary>
    ''' Inserta un nuevo registro
    ''' </summary>
    ''' <param name="nombre">Nombre del usuario</param>
    ''' <param name="apellidos">Apellidos del usuario</param>
    ''' <param name="fechaNacimiento">Fecha de nacimiento del usuario</param>
    ''' <param name="telefono">Telefono del usuario</param>
    ''' <param name="email">Email del usuario</param>
    ''' <param name="direccion">Dirección del usuario</param>
    ''' <param name="organizacion">Organización</param>
    ''' <param name="tipoUsuario">Tipo usuario</param>
    ''' <returns></returns>
    Public Function Insertar(nombre As String, apellidos As String, fechaNacimiento As Date, telefono As String, email As String, direccion As String, organizacion As String, tipoUsuario As Integer, fecha_alta As Date) As Integer
        Dim filas As Integer

        Dim consulta As String = "INSERT INTO Usuarios(nombre, 
                                                        apellidos, 
                                                        fecha_nacimiento, 
                                                        telefono, email, 
                                                        direccion, 
                                                        organizacion, 
                                                        tipo, 
                                                        fecha_alta) VALUES (@nombre,
                                                                            @apellidos,
                                                                            @fechaNacimiento,
                                                                            @telefono,
                                                                            @email,
                                                                            @direccion,
                                                                            @organizacion,
                                                                            @tipoUsuario,
                                                                            @fecha_alta)"

        'validar datos
        If nombre = "" Or nombre Is Nothing Then
            Throw New ArgumentException("El nombre no puede se null/vacio")
        End If

        If apellidos = "" Or apellidos Is Nothing Then
            Throw New ArgumentException("El apellido no puede se null/vacio")
        End If

        If IsNothing(tipoUsuario) Then
            Throw New ArgumentException("El tipo de usuario no puede se null/vacio")
        End If

        'ejecuta la consulta
        Try
            conexion.Open()
            comando.CommandText = consulta
            comando.Parameters.Add("@nombre", SqlDbType.VarChar)
            comando.Parameters.Add("@apellidos", SqlDbType.VarChar)
            comando.Parameters.Add("@fechaNacimiento", SqlDbType.Date)
            comando.Parameters.Add("@telefono", SqlDbType.VarChar)
            comando.Parameters.Add("@email", SqlDbType.VarChar)
            comando.Parameters.Add("@direccion", SqlDbType.VarChar)
            comando.Parameters.Add("@organizacion", SqlDbType.VarChar)
            comando.Parameters.Add("@tipoUsuario", SqlDbType.Int)
            comando.Parameters.Add("@fecha_alta", SqlDbType.Date)


            comando.Parameters("@nombre").Value = nombre
            comando.Parameters("@apellidos").Value = apellidos
            comando.Parameters("@fechaNacimiento").Value = fechaNacimiento
            comando.Parameters("@telefono").Value = telefono
            comando.Parameters("@email").Value = email
            comando.Parameters("@direccion").Value = direccion
            comando.Parameters("@organizacion").Value = organizacion
            comando.Parameters("@tipoUsuario").Value = tipoUsuario
            comando.Parameters("@fecha_alta").Value = fecha_alta

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

    Public Function Actualizar(id As Integer, nombre As String, apellidos As String, fecha_nacimiento As Date, telefono As String, email As String, direccion As String, organizacion As String, tipo As Integer) As Integer

        Dim filas As Integer

        Dim consulta As String = "Update Usuarios set nombre=@nombre, apellidos=@apellidos, fecha_nacimiento=@fecha_nacimiento, telefono=@telefono, email=@email, direccion=@direccion, organizacion=@organizacion, tipo=@tipo WHERE id=@id"

        'validar datos
        If nombre = "" Or nombre Is Nothing Then
            Throw New ArgumentException("El nombre no puede se null/vacio")
        End If

        If apellidos = "" Or apellidos Is Nothing Then
            Throw New ArgumentException("El apellido no puede se null/vacio")
        End If

        If IsNothing(tipo) Then
            Throw New ArgumentException("El tipo de usuario no puede se null/vacio")
        End If



        'Ejercutar consulta
        Try
            conexion.Open()
            comando.CommandText = consulta
            comando.Parameters.Add("@id", SqlDbType.Int)
            comando.Parameters.Add("@nombre", SqlDbType.VarChar)
            comando.Parameters.Add("@apellidos", SqlDbType.VarChar)
            comando.Parameters.Add("@fecha_nacimiento", SqlDbType.Date)
            comando.Parameters.Add("@telefono", SqlDbType.VarChar)
            comando.Parameters.Add("@email", SqlDbType.VarChar)
            comando.Parameters.Add("@direccion", SqlDbType.VarChar)
            comando.Parameters.Add("@organizacion", SqlDbType.VarChar)
            comando.Parameters.Add("@tipo", SqlDbType.Int)


            comando.Parameters("@id").Value = id
            comando.Parameters("@nombre").Value = nombre
            comando.Parameters("@apellidos").Value = apellidos
            comando.Parameters("@fecha_nacimiento").Value = fecha_nacimiento
            comando.Parameters("@telefono").Value = telefono
            comando.Parameters("@email").Value = email
            comando.Parameters("@direccion").Value = direccion
            comando.Parameters("@organizacion").Value = organizacion
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

        Dim consulta As String = "DELETE FROM Usuarios WHERE id=@id"

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
        Dim consulta As String = "SELECT * FROM Usuarios where id=@id"
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

    Public Function ObtenerIdUltimoUsuario() As Integer
        Dim consulta As String = "select id from Usuarios where id = (select max(id) from Usuarios)"
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

        Return Integer.Parse(resultado.Rows(0).Item("id").ToString)
    End Function

    ''' <summary>
    ''' Obtiene todos los datos de los usuarios de la base de datos
    ''' </summary>
    ''' <returns></returns>
    Public Function SeleccionarTodosUsuarios() As BindingSource
        Dim enlace As BindingSource

        Try
            'conexion.Open()
            Dim adaptador As New SqlDataAdapter("SELECT * FROM Usuarios", conexion)
            Dim generador As New SqlCommandBuilder(adaptador)
            Dim resultado As New DataSet

            adaptador.Fill(resultado, "Usuarios")
            enlace = New BindingSource(resultado, "Usuarios")

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try

        Return enlace
    End Function


    Public Function CantidadUsuarios() As Integer
        Dim consulta As String = "SELECT count(*) FROM Usuarios"
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

        Return Integer.Parse(resultado.Rows(0).Item(0).ToString)


    End Function
End Class
