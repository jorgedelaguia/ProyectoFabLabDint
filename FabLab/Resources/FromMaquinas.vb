Public Class FromMaquinas
    Public Enum TipoForm
        Consultar
        Modificar
        Insertar
        Eliminar
    End Enum

    Public tipo As TipoForm
    Public usuario As Integer
    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If tipo = TipoForm.Consultar Then
            ' VerDatosMaquina()
        ElseIf tipo = TipoForm.Modificar Then
            ' VerDatosModificarUsuario()
        ElseIf tipo = TipoForm.Insertar Then
            ' VerTiposUsuarios()
        End If

    End Sub

    Private Sub VerTiposMaquinas()
        Dim tablaTipoMaquinas As DataTable = NegocioMaquinas.VerTodosTipoMaquinas()

        tipoMaquinaComboBox.Items.Clear()

        For i As Integer = 0 To tablaTipoMaquinas.Rows.Count - 1
            tipoMaquinaComboBox.Items.Add(tablaTipoMaquinas.Rows(i).Item("tipo").ToString)
        Next
    End Sub




    Private Sub CancelarMaquinaButton_Click(sender As Object, e As EventArgs) Handles CancelarMaquinaButton.Click
        Me.Close()
    End Sub

    Private Sub anyadirTipoMaquinaButton_Click(sender As Object, e As EventArgs) Handles anyadirTipoMaquinaButton.Click

        Dim filas As Integer

            filas = NegocioUsuarios.InsertarTipoUsuario(tipoMaquinaComboBox.Text.Trim)


            If filas > 0 Then
                MessageBox.Show("Se han insertado " & filas & " tipo de usuario.", "Insertado con exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        VerTiposMaquinas()

    End Sub

    'Private Sub VerDatosMaquina()
    '    Try
    '        Dim tabla As DataTable = NegocioMaquinas.VerDatosMaquina(usuario)
    '
    '
    '        modeloMaquinaTextBox.Enabled = False
    '        modeloMaquinaTextBox.Text = tabla.Rows(0).Item("modelo").ToString
    '
    '        TelefonoSatMaquinaTextBox.Enabled = False
    '        TelefonoSatMaquinaTextBox.Text = tabla.Rows(0).Item("telefonosat").ToString
    '
    '        Dim fecha As String = tabla.Rows(0).Item("fecha_nacimiento").ToString
    '        Dim fechas As String() = fecha.Split("/"c)
    '        Dim anio As Integer = Integer.Parse(fechas(2).Substring(0, 4))
    '
    '
    '
    '        TelefonoSatMaquinaTextBox.Enabled = False
    '        TelefonoSatMaquinaTextBox.Text = tabla.Rows(0).Item("telefono").ToString
    '
    '
    '
    '        organizacionUsuarioTextBox.Enabled = False
    '        organizacionUsuarioTextBox.Text = tabla.Rows(0).Item("organizacion").ToString
    '
    '        Dim tablaTipoUsuario As DataTable = NegocioUsuarios.VerTipoUsuario(Integer.Parse(tabla.Rows(0).Item("tipo").ToString))
    '        tipoUsuarioComboBox.Enabled = False
    '        tipoUsuarioComboBox.Items.Add(tablaTipoUsuario.Rows(0).Item("tipo").ToString)
    '        tipoUsuarioComboBox.SelectedIndex = 0
    '
    '        'FIXME: falta el campo observaciones en la tabla Usuarios
    '        observacionesUsuarioTextBox.Enabled = False
    '
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    ' End Sub

End Class