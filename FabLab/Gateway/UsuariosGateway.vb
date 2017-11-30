'Todo Gateways solo comprobaciones basicas(not null), otra capa(Ej. negocios) ortas comprobaciones ej. tamaño string...



Imports System.Data.OleDb

''' <summary>
''' Gateway para la tabla Usuarios
''' </summary>
Public Class UsuariosGateway
    ''' <summary>
    ''' Objeto Connection
    ''' </summary>
    Private conexion As OleDbConnection

    ''' <summary>
    ''' Objeto Command
    ''' </summary>
    Private comando As OleDbCommand


    ''' <summary>
    ''' Constructor crea la conexion a la base de datos
    ''' </summary>
    ''' <param name="cadena">Cadena de conexion</param>
    Public Sub New(ByRef cadena As String)
        conexion = New OleDbConnection(cadena)
        comando = New OleDbCommand()
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
    Public Function Insertar(nombre As String, apellidos As String, fechaNacimiento As String, telefono As String, email As String, direccion As String, organizacion As String, tipoUsuario As Integer) As Integer

        Dim filas As Integer

        'FIXME: usar parametros del objeto Command pdf ut3_ado pag 9
        Dim consulta As String = "INSERT INTO Usuarios(nombre, apellidos, fecha_nacimiento, telefono, email, direccion, organizacion, tipo, fecha_alta) VALUES ('" & nombre & "', '" & apellidos & "', '" & fechaNacimiento & "', '" & telefono & "', '" & email & "', '" & direccion & "', '" & organizacion & "', '" & tipoUsuario & "', '01/12/2999')"

        'validar datos
        If nombre = "" Or nombre Is Nothing Then
            Throw New ArgumentException("El nombre no puede se null/vacio")
        End If

        If apellidos = "" Or apellidos Is Nothing Then
            Throw New ArgumentException("El apellido no puede se null/vacio")
        End If

        If fechaNacimiento = "" Or fechaNacimiento Is Nothing Then
            Throw New ArgumentException("El fecha de nacimiento no puede se null/vacio")
        End If

        If IsNumeric(tipoUsuario) Or Not IsNothing(tipoUsuario) Then
            Throw New ArgumentException("El tipo de usuario no puede se null/vacio")
        End If

        'ejecuta la consulta
        Try
            conexion.Open()
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


End Class
