Imports System.Text.RegularExpressions


' Tipos de funcionamiento del formulario FormUsuarios
Public Class FormUsuarios
    Public Enum TipoForm
        Consultar
        Modificar
        Insertar
        Eliminar
    End Enum

    'Variables para poder consultar/modificar datos
    Public tipo As TipoForm
    Public usuario As Integer
    Private rutaFotos As String()


    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If tipo = TipoForm.Consultar Then
            VerDatosUsuario()
            InsertaFoto(usuario)
        ElseIf tipo = TipoForm.Modificar Then
            VerDatosModificarUsuario()
            InsertaFoto(usuario)
        ElseIf tipo = TipoForm.Insertar Then
            VerTiposUsuarios()

        End If

    End Sub


    ''' <summary>
    ''' Carga en tipoUsuarioComboBox los tipos de usuario
    ''' </summary>
    Private Sub VerTiposUsuarios()
        Dim tablaTipoUsuario As DataTable = NegocioUsuarios.VerTodosTipoUsuarios()

        tipoUsuarioComboBox.Items.Clear()

        For i As Integer = 0 To tablaTipoUsuario.Rows.Count - 1
            tipoUsuarioComboBox.Items.Add(tablaTipoUsuario.Rows(i).Item("tipo").ToString)
        Next
    End Sub

    ''' <summary>
    ''' Valida el email
    ''' </summary>
    ''' <param name="correo"></param>
    ''' <returns>True si el valido</returns>
    Private Function ValidarEmail(ByVal correo As String) As Boolean

        Dim regex As Regex = New Regex("^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}$")
        Dim match As Match = regex.Match(correo)

        If match.Success Then
            Return True
        Else
            Return False
        End If

    End Function

    ''' <summary>
    ''' Valida que todos los campos obligatorios tengan datos y sean validos
    ''' </summary>
    ''' <returns>True si todos los datos son valido</returns>
    Private Function DatosValidos() As Boolean
        If nombreUsuarioTextBox.Text = "" Then
            ErrorProvider1.SetError(nombreUsuarioTextBox, "El nombre no puede estar vacio")
            Return False
        ElseIf apellidosUsuarioTextBox.Text = "" Then
            ErrorProvider1.SetError(apellidosUsuarioTextBox, "El apellido no puede estar vacio")
            Return False
        ElseIf IsNothing(tipoUsuarioComboBox.SelectedItem) Then
            ErrorProvider1.SetError(tipoUsuarioComboBox, "Selecciona tipo de usuario")
            Return False
        ElseIf tipoUsuarioComboBox.SelectedItem.ToString = "Profesional" Or tipoUsuarioComboBox.SelectedItem.ToString = "Investigador" And organizacionUsuarioTextBox.Text = "" Then
            ErrorProvider1.SetError(organizacionUsuarioTextBox, "Campo obligatorio")
            Return False
        ElseIf telefonoUsuarioTextBox.Text = "" And emailUsuarioTextBox.Text = "" Then
            ErrorProvider1.SetError(telefonoUsuarioTextBox, "Telefono o correo obligatorio")
            ErrorProvider1.SetError(emailUsuarioTextBox, "Correo o telefono obligatorio")
            Return False
        ElseIf ValidarEmail(emailUsuarioTextBox.Text) Then
            ErrorProvider1.SetError(emailUsuarioTextBox, "Correo no valido")
            Return False
        Else
            Return True
        End If
    End Function

    ''' <summary>
    ''' Inserta un nuevo usuario en la base de datos
    ''' </summary>
    Private Sub InsertarDatosUsuario()
        'Elimina los errorProvider si los hay
        ErrorProvider1.SetError(nombreUsuarioTextBox, "")
        ErrorProvider1.SetError(apellidosUsuarioTextBox, "")
        ErrorProvider1.SetError(tipoUsuarioComboBox, "")
        ErrorProvider1.SetError(telefonoUsuarioTextBox, "")
        ErrorProvider1.SetError(tipoUsuarioComboBox, "")
        ErrorProvider1.SetError(organizacionUsuarioTextBox, "")

        If DatosValidos() Then
            Try
                Dim filas As Integer

                filas = NegocioUsuarios.InsertarUsuario(nombreUsuarioTextBox.Text.Trim,
                                                    apellidosUsuarioTextBox.Text.Trim,
                                                    fechaNacimientoUsuarioDateTimePicker.Value,
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
        End If
    End Sub

    ''' <summary>
    ''' Carga los datos del usuario seleccionado para editarlos
    ''' </summary>
    Private Sub VerDatosModificarUsuario()
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

        VerTiposUsuarios()

        tipoUsuarioComboBox.SelectedIndex = Integer.Parse(tabla.Rows(0).Item("tipo").ToString) - 1
    End Sub

    ''' <summary>
    ''' Obtiene los datos modificados y los actualiza en la base de datos
    ''' </summary>
    Private Sub ModificarDatosUsuario()
        If DatosValidos() Then

            Try
                Dim filas As Integer
                filas = NegocioUsuarios.ModificarUsuario(usuario,
                                                         nombreUsuarioTextBox.Text.Trim,
                                                         apellidosUsuarioTextBox.Text.Trim,
                                                         fechaNacimientoUsuarioDateTimePicker.Value,
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
        End If
    End Sub

    ''' <summary>
    ''' Elimina al usuario de la base de datos
    ''' </summary>
    ''' <param name="id">Id del usuario</param>
    Sub EliminarFila(id As Integer)
        Try
            Dim filas As Integer

            filas = NegocioUsuarios.EliminarUsuario(id)

            MessageBox.Show("Usuario eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Muestra los datos del usuario seleccionado(FormUsuarios.usuario) y los bloquea para que no se puedan modificar
    ''' </summary>
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

            examinarFotosButton.Enabled = False
            aniadirTipoUsuarioButton.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub aceptarUsuarioButton_Click(sender As Object, e As EventArgs) Handles aceptarUsuarioButton.Click
        'realiza una accion depediendo de si se va a crear un nuevo usuario o modificar
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
        'Agrega un nuevo tipo de usuario
        Try
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

    Private Sub examinarFotosButton_Click(sender As Object, e As EventArgs) Handles examinarFotosButton.Click
        'dialogo para seleccionar las fotos
        OpenFileDialog1.Multiselect = False
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            Dim fotos As String() = OpenFileDialog1.FileNames

            MoverFotos(fotos, UltimoUsuarioID() + 1)
        End If
    End Sub

    ''' <summary>
    ''' Asigna la foto al PictureBox
    ''' </summary>
    ''' <param name="foto">Ruta de la foto</param>
    Private Sub InsertaFoto(ByVal foto As String)
        PictureBox1.ImageLocation = foto
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        'Next
    End Sub

    ''' <summary>
    ''' Asigna la foto al PictureBox
    ''' </summary>
    ''' <param name="id">Id usuario</param>
    Private Sub InsertaFoto(ByVal id As Integer)
        Dim fotos As String() = System.IO.Directory.GetFiles(My.Settings.DirectorioImagenesUsuario, "usuario" & id & "*")

        If fotos.Count > 0 Then
            PictureBox1.ImageLocation = fotos(0)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    ''' <summary>
    ''' Envia las fotos generadas por la API a la carpeta de imagenes de usuario
    ''' </summary>
    ''' <param name="archivos">Ruta fotos</param>
    ''' <param name="id">Id usuario</param>
    Private Sub MoverFotos(ByVal archivos As String(), ByVal id As Integer)
        System.IO.Directory.CreateDirectory(My.Settings.DirectorioImagenesUsuario)

        For counter As Integer = 0 To archivos.Count - 1
            Dim archivo As String() = Split(archivos(counter), "\"c)

            GetThumbnail(archivos(counter), My.Settings.DirectorioImagenesUsuario & "usuario" & id & "_" & counter & "." & archivo(archivo.Count - 1).Split("."c)(1))
        Next
    End Sub

    'FIXME: FormUsuarios solo una foto
    'Private Sub RellenaFotos(ByVal id As Integer)
    '    Dim fotos As String() = System.IO.Directory.GetFiles(My.Settings.DirectorioImagenesUsuario, "usuario" & id & "*")

    '    For index As Integer = 0 To fotos.Count - 1
    '        Dim imagen As New PictureBox()
    '        imagen.ImageLocation = fotos(index)
    '        imagen.Height = 96
    '        imagen.Width = 96
    '        imagen.SizeMode = PictureBoxSizeMode.StretchImage
    '        FlowLayoutPanel1.Controls.Add(imagen)
    '    Next
    'End Sub

    ''' <summary>
    ''' API generar Thumbnail
    ''' </summary>
    ''' <param name="rutaFoto">Ruta imagen</param>
    ''' <param name="ruta">Destino imagen</param>
    Private Async Sub GetThumbnail(ByVal rutaFoto As String, ByVal ruta As String)
        Try
            Form1.toolStripProgressBar1.Visible = True

            Dim cliente As New Microsoft.ProjectOxford.Vision.VisionServiceClient(My.Settings.APIKEY, My.Settings.enlace)

            Dim foto As Task(Of Byte()) = cliente.GetThumbnailAsync(System.IO.File.OpenRead(rutaFoto), 96, 96)
            Dim a As Byte() = Await foto

            System.IO.File.WriteAllBytes(ruta, a)

            Form1.toolStripProgressBar1.Visible = False

            InsertaFoto(rutaFoto)
        Catch ex As Microsoft.ProjectOxford.Vision.ClientException
            MessageBox.Show(ex.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class