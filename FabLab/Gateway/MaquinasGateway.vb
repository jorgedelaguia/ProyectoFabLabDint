﻿Imports System.Data.SqlClient
''' <summary>
''' Clase para definir los gateways de Maquinas
''' </summary>
Public Class MaquinasGateway
    ''' <summary>
    ''' Almacena el objeto Connection
    ''' </summary>
    Private conexion As SqlConnection
    ''' <summary>
    ''' Almacena el objeto Command
    ''' </summary>
    Private comando As SqlCommand
    ''' <summary>
    ''' Constructor: crea el objeto de aceso a la base de datos
    ''' </summary>
    Public Sub New(ByRef cadenaConexion As String)
        conexion = New SqlConnection(cadenaConexion)
        comando = New SqlCommand()
        comando.Connection = conexion
    End Sub

    ''' <summary>
    ''' Actualiza un registro
    ''' </summary>
    ''' <param name="id">id de la maquina</param>
    ''' <param name="modelo">modelo de la maquina</param>
    ''' <param name="precio_hora">Precio por hora</param>
    ''' <param name="fecha_compra">La fecha en la que se a comprado la maquina</param>
    ''' <param name="telefono_sat">telefono para ayuda de la maquina</param>
    ''' <param name="tipo">tipo de maquina que es</param>
    ''' <param name="descripcion">descripcion de la maquina</param>
    ''' <param name="caracteristicas">caracteristicas de la maquina</param>
    ''' <returns></returns>
    ''' 
    Public Function Actualizar(id As Integer, modelo As String, precio_hora As Decimal, fecha_compra As Date, telefono_sat As String, tipo As Integer, descripcion As String, caracteristicas As String) As Integer

        Dim filas As Integer
        'Sentencia SQL de actualizaciónn
        Dim consulta As String = String.Format("UPDATE Fablab SET modelo='{0}',precio_hora='{1}',fecha_compra='{2}',telefono_sat='{3}',tipo='{4}', descripcion='{5}',caracteristicas='{6}' WHERE id={7})", modelo, precio_hora, fecha_compra, fecha_compra, telefono_sat, tipo, descripcion, caracteristicas, id)

        'Validamos datos
        If id = 0 Or id = Nothing Then
            Throw New ArgumentException("El id no puede ser null o vacio")
        End If

        If modelo = "" Or modelo Is Nothing Then
            Throw New ArgumentException("El modelo no puede estar vacío")
        End If

        If tipo = 0 Then
            Throw New ArgumentException("El tipo no puede ser 0")
        End If

        If precio_hora < 0 Then
            Throw New ArgumentException("El precio por hora tiene que ser mayor que 0")
        End If

        Dim expresionRegular As New System.Text.RegularExpressions.Regex("[0-9]{9}")
        If expresionRegular.IsMatch(telefono_sat) Then
            Throw New ArgumentException("El teléfono debe contener 9 dígitos")
        End If


        'Ejecutamos la consulta
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

    Public Function Insertar(modelo As String, precio_hora As Decimal, fecha_compra As Date, telefono_sat As String, tipo As Integer, descripcion As String, caracteristicas As String) As Integer

        Dim filas As Integer
        'Sentencia SQL de inserción
        Dim consulta As String = String.Format("INSERT INTO Maquinas(modelo,
                                                                     precio_hora,
                                                                     fecha_compra,
                                                                     telefono_sat,
                                                                     tipo,
                                                                     descripcion,
                                                                     caracteristicas)
                                                VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                                                                     modelo,
                                                                     precio_hora,
                                                                     fecha_compra,
                                                                     telefono_sat,
                                                                     tipo,
                                                                     descripcion,
                                                                     caracteristicas)

        'Validamos los datos

        If modelo = "" Or modelo Is Nothing Then
            Throw New ArgumentException("El modelo no puede estar vacío")
        End If

        If tipo = 0 Then
            Throw New ArgumentException("El tipo no puede ser 0")
        End If

        If precio_hora < 0 Then
            Throw New ArgumentException("El precio por hora tiene que ser mayor que 0")
        End If


        Dim expresionRegular As New System.Text.RegularExpressions.Regex("[0-9]{9}")
        If expresionRegular.IsMatch(telefono_sat) Then
            Throw New ArgumentException("El teléfono debe contener 9 dígitos")
        End If

        'Ejecutamos la consulta
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

    Public Function Eliminar(id As Integer) As Integer

        Dim filas As Integer

        Dim consulta As String = "DELETE FROM Maquinas WHERE id=@id"

        'Validar el dato
        If id = 0 Then
            Throw New ArgumentException("El id no puede estar vacio")
        End If



        'Ejecutamos la consulta
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

    ''' <summary>
    ''' Obtiene una maquina segun su id
    ''' </summary>
    ''' <returns></returns>
    Public Function SeleccionarId(id As Integer) As DataTable
        Dim consulta As String = "SELECT * FROM Maquinas where id=@id"
        Dim resultado As New DataTable
        Dim lector As SqlDataReader


        If id = 0 Then
            Throw New ArgumentException("El id no puede estar vacio")
        End If

        'Ejecutamos la consulta
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

    ''' <summary>
    ''' Obtiene la ultima maquina
    ''' </summary>
    ''' <returns></returns>
    Public Function IdUltimaMaquina() As Integer
        Dim consulta As String = "select id from Maquinas where id = (select max(id) from Maquinas)"
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

        Return Integer.Parse(resultado.Rows(0).Item("id").ToString)
    End Function

    ''' <summary>
    ''' Coje todos los datos de maquinas
    ''' </summary>
    ''' <returns></returns>
    ''' 
    Public Function SeleccionarTodasMaquinas() As BindingSource
        Dim enlace As BindingSource


        Try
            'conexion.Open()
            Dim adaptador As New SqlDataAdapter("SELECT * FROM Maquinas", conexion)
            Dim generador As New SqlCommandBuilder(adaptador)
            Dim resultado As New DataSet

            adaptador.Fill(resultado, "Maquinas")
            enlace = New BindingSource(resultado, "Maquinas")

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try

        Return enlace
    End Function

    Public Function CantidadMaquinas() As Integer
        Dim consulta As String = "SELECT count(*) FROM Maquinas"
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