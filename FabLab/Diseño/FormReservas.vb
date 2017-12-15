Public Class FormReservas
    Public id As Integer
    Private Sub FormReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim enlace As BindingSource
        Dim gateway As New ReservasGateway(My.Settings.cadena)

        enlace = gateway.SeleccionarReservasUsuarios(id)


        DataGridView1.DataSource = enlace
        'usuariosDataGridView.Columns("id").Visible = False
        'usuariosDataGridView.Columns("tipo").Visible = False
        'usuariosDataGridView.Columns("fecha_alta").Visible = False
        DataGridView1.ReadOnly = True
    End Sub
End Class