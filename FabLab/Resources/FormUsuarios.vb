Public Class FormUsuarios
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
            VerDatosUsuario()
        ElseIf tipo = TipoForm.Modificar Then
            VerDatosModificarUsuario()
        ElseIf tipo = TipoForm.Insertar Then
            VerTiposUsuarios()
        End If

    End Sub

    Private Sub VerTiposUsuarios()
        Dim tablaTipoUsuario As DataTable = NegocioUsuarios.VerTodosTipoUsuarios()

        tipoUsuarioComboBox.Items.Clear()

        For i As Integer = 0 To tablaTipoUsuario.Rows.Count - 1
            tipoUsuarioComboBox.Items.Add(tablaTipoUsuario.Rows(i).Item("tipo").ToString)
        Next
    End Sub

    Private Sub InsertarDatosUsuario()

        Try
            Dim filas As Integer

            filas = NegocioUsuarios.InsertarUsuario(nombreUsuarioTextBox.Text.Trim,
                                            apellidosUsuarioTextBox.Text.Trim,
                                            fechaNacimientoUsuarioDateTimePicker.Value.ToString,
                                            telefonoUsuarioTextBox.Text.Trim,
                                            emailUsuarioTextBox.Text.Trim,
                                            direccionPostalUsuarioTextBox.Text.Trim,
                                            organizacionUsuarioTextBox.Text.Trim,
                                            tipoUsuarioComboBox.SelectedIndex + 1)


            If filas > 0 Then
                MessageBox.Show("Se han insertado " & filas & " usuarios.", "Insertado con exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub VerDatosModificarUsuario()
        'Carga los datos del usuario para modificarlos
        Dim tabla As DataTable = NegocioUsuarios.VerDatosUsuarios(usuario)


        nombreUsuarioTextBox.Text = tabla.Rows(0).Item("nombre").ToString

        apellidosUsuarioTextBox.Text = tabla.Rows(0).Item("apellidos").ToString

        Dim fecha As String = tabla.Rows(0).Item("fecha_nacimiento").ToString
        Dim fechas As String() = fecha.Split("/"c)
        Dim anio As Integer = Integer.Parse(fechas(2).Substring(0, 4))

        fechaNacimientoUsuarioDateTimePicker.Value = New Date(anio, Integer.Parse(fechas(1)), Integer.Parse(fechas(0)))

        telefonoUsuarioTextBox.Text = tabla.Rows(0).Item("telefono").ToString

        emailUsuarioTextBox.Text = tabla.Rows(0).Item("email").ToString

        direccionPostalUsuarioTextBox.Text = tabla.Rows(0).Item("direccion").ToString

        organizacionUsuarioTextBox.Text = tabla.Rows(0).Item("organizacion").ToString

        'Dim tablaTipoUsuario As DataTable = NegocioUsuarios.VerTipoUsuario(Integer.Parse(tabla.Rows(0).Item("tipo").ToString))
        'tipoUsuarioComboBox.Items.Add(tablaTipoUsuario.Rows(0).Item("tipo").ToString)
        'tipoUsuarioComboBox.SelectedIndex = 0

        VerTiposUsuarios()

        tipoUsuarioComboBox.SelectedIndex = Integer.Parse(tabla.Rows(0).Item("tipo").ToString) - 1
    End Sub

    Private Sub ModificarDatosUsuario()
        Try

            Debug.WriteLine(fechaNacimientoUsuarioDateTimePicker.Value.ToString, "Test fecha")
            Dim filas As Integer


            filas = NegocioUsuarios.ModificarUsuario(usuario,
                                                     nombreUsuarioTextBox.Text.Trim,
                                                     apellidosUsuarioTextBox.Text.Trim,
                                                     fechaNacimientoUsuarioDateTimePicker.Value.ToString,
                                                     telefonoUsuarioTextBox.Text.Trim,
                                                     emailUsuarioTextBox.Text.Trim,
                                                     direccionPostalUsuarioTextBox.Text.Trim,
                                                     organizacionUsuarioTextBox.Text.Trim,
                                                     tipoUsuarioComboBox.SelectedIndex + 1)


            If filas > 0 Then
                MessageBox.Show("Se han modificado " & filas & " usuarios.", "Insertado con exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub VerDatosUsuario()

        Try


            Dim tabla As DataTable = NegocioUsuarios.VerDatosUsuarios(usuario)


            nombreUsuarioTextBox.Enabled = False
            nombreUsuarioTextBox.Text = tabla.Rows(0).Item("nombre").ToString

            apellidosUsuarioTextBox.Enabled = False
            apellidosUsuarioTextBox.Text = tabla.Rows(0).Item("apellidos").ToString

            Dim fecha As String = tabla.Rows(0).Item("fecha_nacimiento").ToString
            Dim fechas As String() = fecha.Split("/"c)
            Dim anio As Integer = Integer.Parse(fechas(2).Substring(0, 4))


            fechaNacimientoUsuarioDateTimePicker.Enabled = False
            fechaNacimientoUsuarioDateTimePicker.Value = New Date(anio, Integer.Parse(fechas(1)), Integer.Parse(fechas(0)))

            telefonoUsuarioTextBox.Enabled = False
            telefonoUsuarioTextBox.Text = tabla.Rows(0).Item("telefono").ToString

            emailUsuarioTextBox.Enabled = False
            emailUsuarioTextBox.Text = tabla.Rows(0).Item("email").ToString

            direccionPostalUsuarioTextBox.Enabled = False
            direccionPostalUsuarioTextBox.Text = tabla.Rows(0).Item("direccion").ToString

            organizacionUsuarioTextBox.Enabled = False
            organizacionUsuarioTextBox.Text = tabla.Rows(0).Item("organizacion").ToString

            Dim tablaTipoUsuario As DataTable = NegocioUsuarios.VerTipoUsuario(Integer.Parse(tabla.Rows(0).Item("tipo").ToString))
            tipoUsuarioComboBox.Enabled = False
            tipoUsuarioComboBox.Items.Add(tablaTipoUsuario.Rows(0).Item("tipo").ToString)
            tipoUsuarioComboBox.SelectedIndex = 0

            'FIXME: falta el campo observaciones en la tabla Usuarios
            observacionesUsuarioTextBox.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub aceptarUsuarioButton_Click(sender As Object, e As EventArgs) Handles aceptarUsuarioButton.Click
        If tipo = TipoForm.Insertar Then
            InsertarDatosUsuario()
        ElseIf tipo = TipoForm.Modificar Then
            ModificarDatosUsuario()
        End If



    End Sub

    Private Sub cancelarUsuarioButton_Click(sender As Object, e As EventArgs) Handles cancelarUsuarioButton.Click
        Close()
    End Sub

    Private Sub aniadirTipoUsuarioButton_Click(sender As Object, e As EventArgs) Handles aniadirTipoUsuarioButton.Click
        Try
            Debug.WriteLine(fechaNacimientoUsuarioDateTimePicker.Value.ToString, "Test fecha")
            Dim filas As Integer

            filas = NegocioUsuarios.InsertarTipoUsuario(tipoUsuarioComboBox.Text.Trim)


            If filas > 0 Then
                MessageBox.Show("Se han insertado " & filas & " tipo de usuario.", "Insertado con exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            VerTiposUsuarios()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class