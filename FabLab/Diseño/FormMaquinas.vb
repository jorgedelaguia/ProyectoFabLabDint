Public Class FormMaquinas

    ' Dependiendo de lo que se quiera hacer se elige tipo de formulario 
    Public Enum TipoForm
        Consultar
        Modificar
        Insertar
        Eliminar
    End Enum
    'variable para saber que tipo de formulario queremos
    Public tipo As TipoForm
    'variable para saber el id de la maquina que hemos seleccionado
    Public maquina As Integer


    ''' <summary>
    ''' Dependiendo de que tipo de form se quiera entrara en un metodo o en otros
    ''' </summary>
    Private Sub FormMaquinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If tipo = TipoForm.Consultar Then
            VerDatosMaquina()
        ElseIf tipo = TipoForm.Modificar Then
            VerDatosModificarMaquinas()
        ElseIf tipo = TipoForm.Insertar Then
            VerTiposMaquinas()
        End If

    End Sub


    ''' <summary>
    ''' Pone los tipos de maquinas que hay en el campo de las maquinas
    ''' </summary>
    Private Sub VerTiposMaquinas()
        Dim tablaTipoMaquinas As DataTable = NegocioMaquinas.VerTodosTipoMaquinas()

        tipoMaquinaComboBox.Items.Clear()

        For i As Integer = 0 To tablaTipoMaquinas.Rows.Count - 1
            tipoMaquinaComboBox.Items.Add(tablaTipoMaquinas.Rows(i).Item("tipo").ToString)
        Next
    End Sub

    ''' <summary>
    ''' Metodo para añadir tipo de maquina
    ''' </summary>
    Private Sub anyadirTipoMaquinaButton_Click(sender As Object, e As EventArgs) Handles anyadirTipoMaquinaButton.Click

        Dim filas As Integer

        filas = NegocioMaquinas.InsertarTipoMaquina(tipoMaquinaComboBox.Text.Trim)


        If filas > 0 Then
            MessageBox.Show("Se han insertado " & filas & " tipo de maquina.", "Insertado con exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        VerTiposMaquinas()

    End Sub


    ''' <summary>
    ''' metodo para añadir nueva maquina en la base de datos
    ''' </summary>
    Private Sub InsertarDatosMaquina()

        Try
            Dim filas As Integer

            filas = NegocioMaquinas.InsertarMaquina(modeloMaquinaTextBox.Text.Trim,
                                                     Decimal.Parse(precioHoraMaquinaTextBox.Text.Trim),
                                                     fechaCompraMaquinaDateTimePicker.Value,
                                                     TelefonoSatMaquinaTextBox.Text.Trim,
                                                     tipoMaquinaComboBox.SelectedIndex + 1,
                                                     descripcionMaquinaTextBox.Text.Trim,
                                                     caracteristicasMaquinaTextBox.Text.Trim)


            If filas > 0 Then
                MessageBox.Show("Se han insertado " & filas & " maquinas.", "Insertado con exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    ''' <summary>
    ''' Sacar los datos de una maquina
    ''' </summary>
    Private Sub VerDatosMaquina()
        Try
            Dim tabla As DataTable = NegocioMaquinas.VerDatosMaquinas(maquina)

            modeloMaquinaTextBox.Enabled = False
            TelefonoSatMaquinaTextBox.Enabled = False
            precioHoraMaquinaTextBox.Enabled = False
            caracteristicasMaquinaTextBox.Enabled = False
            descripcionMaquinaTextBox.Enabled = False
            fechaCompraMaquinaDateTimePicker.Enabled = False
            tipoMaquinaComboBox.Enabled = False
            anyadirTipoMaquinaButton.Enabled = False


            modeloMaquinaTextBox.Text = tabla.Rows(0).Item("modelo").ToString

            TelefonoSatMaquinaTextBox.Text = tabla.Rows(0).Item("telefono_sat").ToString

            precioHoraMaquinaTextBox.Text = tabla.Rows(0).Item("precio_hora").ToString

            caracteristicasMaquinaTextBox.Text = tabla.Rows(0).Item("caracteristicas").ToString

            descripcionMaquinaTextBox.Text = tabla.Rows(0).Item("descripcion").ToString

            Dim fecha As String = tabla.Rows(0).Item("fecha_compra").ToString
            Dim fechas As String() = fecha.Split("/"c)
            Dim anio As Integer = Integer.Parse(fechas(2).Substring(0, 4))

            fechaCompraMaquinaDateTimePicker.Value = New Date(anio, Integer.Parse(fechas(1)), Integer.Parse(fechas(0)))


            Dim tablaTipoMaquina As DataTable = NegocioMaquinas.VerTipoMaquina(Integer.Parse(tabla.Rows(0).Item("tipo").ToString))

            tipoMaquinaComboBox.Items.Add(tablaTipoMaquina.Rows(0).Item("tipo").ToString)
            tipoMaquinaComboBox.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ''' <summary>
    ''' Metodo para modificar maquina
    ''' </summary>
    Private Sub ModificarMaquina()
        Try

            Dim filas As Integer


            filas = NegocioMaquinas.ModificarMaquina(maquina,
                                                     modeloMaquinaTextBox.Text.Trim,
                                                     Decimal.Parse(precioHoraMaquinaTextBox.Text.Trim),
                                                     Date.Parse(fechaCompraMaquinaDateTimePicker.Value.ToString),
                                                     TelefonoSatMaquinaTextBox.Text.Trim,
                                                     tipoMaquinaComboBox.SelectedIndex + 1,
                                                     descripcionMaquinaTextBox.Text.Trim,
                                                     caracteristicasMaquinaTextBox.Text.Trim)


            If filas > 0 Then
                MessageBox.Show("Se han modificado " & filas & " maquinas.", "Insertado con exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ''' <summary>
    ''' Metodo para eliminar maquina
    ''' </summary>
    ''' <param name="id">Id de la maquina</param>
    Sub EliminarFila(id As Integer)
        Try
            Dim filas As Integer

            filas = NegocioMaquinas.EliminarMaquina(id)

            MessageBox.Show("Maquina borrada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ''' <summary>
    ''' Metodo para mostrar y luego modificar los datos de una maquina
    ''' </summary>
    Private Sub VerDatosModificarMaquinas()

        Dim tabla As DataTable = NegocioMaquinas.VerDatosMaquinas(maquina)

        modeloMaquinaTextBox.Text = tabla.Rows(0).Item("modelo").ToString

        TelefonoSatMaquinaTextBox.Text = tabla.Rows(0).Item("telefono_sat").ToString

        precioHoraMaquinaTextBox.Text = tabla.Rows(0).Item("precio_hora").ToString

        Dim fecha As String = tabla.Rows(0).Item("fecha_compra").ToString
        Dim fechas As String() = fecha.Split("/"c)
        Dim anio As Integer = Integer.Parse(fechas(2).Substring(0, 4))

        fechaCompraMaquinaDateTimePicker.Value = New Date(anio, Integer.Parse(fechas(1)), Integer.Parse(fechas(0)))

        caracteristicasMaquinaTextBox.Text = tabla.Rows(0).Item("caracteristicas").ToString

        descripcionMaquinaTextBox.Text = tabla.Rows(0).Item("descripcion").ToString

        VerTiposMaquinas()

        tipoMaquinaComboBox.SelectedIndex = Integer.Parse(tabla.Rows(0).Item("tipo").ToString) - 1
    End Sub

    ''' <summary>
    ''' Cuando apretemos el boton de aceptar , dependiendo de lo que estubiermos haciendo(modificando o insertando) se ejecuta un metodo o otro
    ''' </summary>
    Private Sub aceptarMaquinaButton_Click(sender As Object, e As EventArgs) Handles aceptarMaquinaButton.Click
        If tipo = TipoForm.Insertar Then
            InsertarDatosMaquina()

        ElseIf tipo = TipoForm.Modificar Then
            ModificarMaquina()
        End If
    End Sub

    Private Sub CancelarMaquinaButton_Click(sender As Object, e As EventArgs) Handles CancelarMaquinaButton.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Insertamos las fotos en el flow panel
    ''' </summary>
    Private Sub FotosInsertarEnFlowPanel(ByVal fotos As String)
        Dim imagen As New PictureBox()
        imagen.ImageLocation = fotos
        imagen.Height = 150
        imagen.Width = 150
        imagen.SizeMode = PictureBoxSizeMode.Zoom
        contenedorImagenesFlowLayoutPanel.Controls.Add(imagen)
    End Sub

    ''' <summary>
    ''' las fotos generadas por la api se guardan en la carpeta de fotos  maquinas
    ''' </summary>
    ''' <param name="archivos">Ruta fotos</param>
    ''' <param name="id">Id maquina</param>
    Private Sub MoverFotos(ByVal archivos As String(), ByVal id As Integer)
        System.IO.Directory.CreateDirectory(My.Settings.DirectorioImagenesMaquina)

        For counter As Integer = 0 To archivos.Count - 1
            Dim archivo As String() = Split(archivos(counter), "\"c)

            GetThumbnail(archivos(counter), My.Settings.DirectorioImagenesMaquina & "maquina" & id & "_" & counter & "." & archivo(archivo.Count - 1).Split("."c)(1))
        Next

    End Sub

    Private Sub examinarImagenesMaquinaButton_Click(sender As Object, e As EventArgs) Handles examinarImagenesMaquinaButton.Click
        imagenesOpenFileDialog.Multiselect = True
        If imagenesOpenFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            Dim fotos As String() = imagenesOpenFileDialog.FileNames

            MoverFotos(fotos, UltimaMaquinaPorID() + 1)

        End If
    End Sub

    Private Sub RellenaFoto(ByVal id As Integer)
        Dim fotos As String() = System.IO.Directory.GetFiles(My.Settings.DirectorioImagenesMaquina, "maquina" & id & "*")

        For index As Integer = 0 To fotos.Count - 1
            Dim imagen As New PictureBox()
            imagen.ImageLocation = fotos(index)
            imagen.Height = 150
            imagen.Width = 150
            imagen.SizeMode = PictureBoxSizeMode.Zoom
            contenedorImagenesFlowLayoutPanel.Controls.Add(imagen)
        Next
    End Sub

    ''' <summary>
    ''' Metodo de la api que convierte la imagen
    ''' </summary>
    ''' <param name="rutaFoto">Ruta imagen</param>
    ''' <param name="ruta">Destino imagen</param>
    Private Async Sub GetThumbnail(ByVal rutaFoto As String, ByVal ruta As String)
        Try
            Form1.toolStripProgressBar1.Visible = True

            Dim cliente As New Microsoft.ProjectOxford.Vision.VisionServiceClient("a6bcba3173744e87b2c70cc9ff2be44a", "https://westcentralus.api.cognitive.microsoft.com/vision/v1.0")

            Dim foto As Task(Of Byte()) = cliente.GetThumbnailAsync(System.IO.File.OpenRead(rutaFoto), 150, 150)
            Dim a As Byte() = Await foto

            IO.File.WriteAllBytes(ruta, a)

            Form1.toolStripProgressBar1.Visible = False

        Catch ex As Microsoft.ProjectOxford.Vision.ClientException
            MessageBox.Show(ex.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class