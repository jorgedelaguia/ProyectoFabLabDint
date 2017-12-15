Public Class FormMaquinas
    Public Enum TipoForm
        Consultar
        Modificar
        Insertar
        Eliminar
    End Enum

    Public tipo As TipoForm
    Public maquina As Integer
    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If tipo = TipoForm.Consultar Then
            VerDatosMaquina()
        ElseIf tipo = TipoForm.Modificar Then
            VerDatosModificarMaquinas()
        ElseIf tipo = TipoForm.Insertar Then
            VerTiposMaquinas()
        End If

    End Sub

    Private Sub VerTiposMaquinas()
        Dim tablaTipoMaquinas As DataTable = NegocioMaquinas.VerTodosTipoMaquinas()

        tipoMaquinaComboBox.Items.Clear()

        For i As Integer = 0 To tablaTipoMaquinas.Rows.Count - 1
            tipoMaquinaComboBox.Items.Add(tablaTipoMaquinas.Rows(i).Item("tipo").ToString)
        Next
    End Sub


    Private Sub anyadirTipoMaquinaButton_Click(sender As Object, e As EventArgs) Handles anyadirTipoMaquinaButton.Click

        Dim filas As Integer

        filas = NegocioMaquinas.InsertarTipoMaquina(tipoMaquinaComboBox.Text.Trim)


        If filas > 0 Then
            MessageBox.Show("Se han insertado " & filas & " tipo de usuario.", "Insertado con exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        VerTiposMaquinas()

    End Sub

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

    Private Sub VerDatosMaquina()
        Try
            Dim tabla As DataTable = NegocioMaquinas.VerDatosMaquinas(maquina)

            modeloMaquinaTextBox.Enabled = False
            TelefonoSatMaquinaTextBox.Enabled = False
            precioHoraMaquinaTextBox.Enabled = False
            caracteristicasMaquinaTextBox.Enabled = False
            descripcionMaquinaTextBox.Enabled = False
            tipoMaquinaComboBox.Enabled = False
            anyadirTipoMaquinaButton.Enabled = False


            modeloMaquinaTextBox.Text = tabla.Rows(0).Item("modelo").ToString

            TelefonoSatMaquinaTextBox.Text = tabla.Rows(0).Item("telefono_sat").ToString

            precioHoraMaquinaTextBox.Text = tabla.Rows(0).Item("precio_hora").ToString

            caracteristicasMaquinaTextBox.Text = tabla.Rows(0).Item("caracteristicas").ToString

            descripcionMaquinaTextBox.Text = tabla.Rows(0).Item("descripcion").ToString


            'TODO falta la fechaCompra

            Dim tablaTipoMaquina As DataTable = NegocioMaquinas.VerTipoMaquina(Integer.Parse(tabla.Rows(0).Item("tipo").ToString))

            tipoMaquinaComboBox.Items.Add(tablaTipoMaquina.Rows(0).Item("tipo").ToString)
            tipoMaquinaComboBox.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

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
    Sub EliminarFila(id As Integer)
        Try
            Dim filas As Integer

            filas = NegocioMaquinas.EliminarMaquina(id)

            MessageBox.Show("Maquina borrada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub VerDatosModificarMaquinas()
        'Carga los datos del usuario para modificarlos
        Dim tabla As DataTable = NegocioUsuarios.VerDatosUsuarios(maquina)

        modeloMaquinaTextBox.Text = tabla.Rows(0).Item("modelo").ToString

        TelefonoSatMaquinaTextBox.Text = tabla.Rows(0).Item("telefono_sat").ToString

        precioHoraMaquinaTextBox.Text = tabla.Rows(0).Item("precio_hora").ToString

        caracteristicasMaquinaTextBox.Text = tabla.Rows(0).Item("caracteristicas").ToString

        descripcionMaquinaTextBox.Text = tabla.Rows(0).Item("descripcion").ToString

        VerTiposMaquinas()

        tipoMaquinaComboBox.SelectedIndex = Integer.Parse(tabla.Rows(0).Item("tipo").ToString) - 1
    End Sub

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


    Private Sub FotosInsertarEnFlowPanel(ByVal fotos As String())
        For index As Integer = 0 To fotos.Count - 1
            Dim imagen As New PictureBox()
            imagen.ImageLocation = fotos(index)
            imagen.Height = 96
            imagen.Width = 96
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
            contenedorImagenesFlowLayoutPanel.Controls.Add(imagen)
        Next
    End Sub


    Private Sub examinarImagenesMaquinaButton_Click(sender As Object, e As EventArgs) Handles examinarImagenesMaquinaButton.Click
        imagenesOpenFileDialog.Multiselect = True
        If imagenesOpenFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            Dim fotos As String() = imagenesOpenFileDialog.FileNames

            FotosInsertarEnFlowPanel(fotos)
            'rutaFotos = fotos
        End If
    End Sub


End Class