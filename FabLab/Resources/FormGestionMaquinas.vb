﻿Imports FabLab.FormUsuarios

Public Class FormGestionMaquinas
    Private Sub nuevaMaquinaButton_Click(sender As Object, e As EventArgs) Handles nuevaMaquinaButton.Click
        'TODO: temporal

        Dim nuevoUsuarioForm As New FromMaquinas
        nuevoUsuarioForm.tipo = FromMaquinas.TipoForm.Insertar
        nuevoUsuarioForm.MdiParent = Form1
        'nuevoUsuarioForm.usuario = 99
        nuevoUsuarioForm.Show()
    End Sub

    Private Sub consultarMaquinaButton_Click(sender As Object, e As EventArgs) Handles consultarMaquinaButton.Click
        Dim nuevoUsuarioForm As New FromMaquinas
        nuevoUsuarioForm.tipo = FromMaquinas.TipoForm.Consultar
        nuevoUsuarioForm.MdiParent = Form1


        nuevoUsuarioForm.usuario = CType(DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value, Integer)
        nuevoUsuarioForm.Show()
    End Sub

    Private Sub editarMaquinaButton_Click(sender As Object, e As EventArgs) Handles editarMaquinaButton.Click
        Dim nuevoUsuarioForm As New FromMaquinas
        nuevoUsuarioForm.tipo = FromMaquinas.TipoForm.Modificar
        nuevoUsuarioForm.MdiParent = Form1
        nuevoUsuarioForm.usuario = CType(DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value, Integer)
        nuevoUsuarioForm.Show()
    End Sub

    Private Sub FormGestionMaquinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load, buscarMaquinaTextBox.TextChanged
        Dim enlace As BindingSource
        Dim gateway As New MaquinasGateway(My.Settings.cadena)

        enlace = gateway.SeleccionarTodasMaquinas()

        enlace.Filter = "modelo like '*" & buscarMaquinaTextBox.Text & "*'"


        DataGridView1.DataSource = enlace
        DataGridView1.Columns("id").Visible = False
        DataGridView1.ReadOnly = True

    End Sub
End Class