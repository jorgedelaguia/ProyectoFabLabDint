﻿Imports System.Data.SqlClient

Public Class MaquinasGateway

    Private conexion As SqlConnection
    Private comando As SqlCommand

    Public Sub New(ByRef cadenaConexion As String)
        conexion = New SqlConnection(cadenaConexion)
        comando = New SqlCommand()
        comando.Connection = conexion
    End Sub

    Public Function Actualizar(id As Integer, modelo As String, precio_hora As Decimal, fecha_compra As Date, telefono_sat As String, tipo As Integer, descripcion As String, caracteristicas As String) As Integer

        Dim filas As Integer
        'Sentencia SQL de actualizaciónn
        Dim consulta As String = String.Format("UPDATE Fablab SET modelo='{0}',precio_hora='{1}',fecha_compra='{2}',telefono_sat='{3}',tipo='{4}', descripcion='{5}',caracteristicas='{6}' WHERE id={7})", modelo, precio_hora, fecha_compra, fecha_compra, telefono_sat, tipo, descripcion, caracteristicas, id)

        'Validamos
        If id = 0 Or id = Nothing Then
            Throw New ArgumentException("El id no puede ser null o vacio")
        End If

        If modelo = "" Or modelo Is Nothing Then
            Throw New ArgumentException("El modelo no puede estar vacío")
        End If

        If tipo = 0 Then
            Throw New ArgumentException("El tipo no puede ser 0")
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
                                                VALUES ('{0}','{1}','{2}','{3}')",
                                                                     modelo,
                                                                     precio_hora,
                                                                     fecha_compra,
                                                                     telefono_sat,
                                                                     tipo,
                                                                     descripcion,
                                                                     caracteristicas)

        'Validamos

        If modelo = "" Or modelo Is Nothing Then
            Throw New ArgumentException("El modelo no puede estar vacío")
        End If

        If tipo = 0 Then
            Throw New ArgumentException("El tipo no puede ser 0")
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
        Dim consulta As String = "SELECT * FROM Maquinas where id=@id"
        Dim resultado As New DataTable
        Dim lector As SqlDataReader


        If id = 0 Then
            Throw New ArgumentException("El id no puede estar vacio")
        End If


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

End Class