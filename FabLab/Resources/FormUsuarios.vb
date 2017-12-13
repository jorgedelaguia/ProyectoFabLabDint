Public Class FormUsuarios
    Public Enum TipoForm
        Ver
        Modificar
        Insertar
    End Enum

    Public tipo As TipoForm
    Public usuario As Integer
    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If tipo = TipoForm.Ver Then
            'Debug.WriteLine(sender.ToString)
            'MessageBox.Show(usuario.ToString)

            VerDatosUsuario(usuario)
        End If

    End Sub



    Private Sub VerDatosUsuario(ByVal id As Integer)
        Dim tabla As DataTable = NegocioUsuarios.VerDatosUsuarios(1)

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

        tipoUsuarioComboBox.Enabled = False
        tipoUsuarioComboBox.Items.Add(tabla.Rows(0).Item("tipo").ToString)
        tipoUsuarioComboBox.SelectedItem = 0
    End Sub


End Class