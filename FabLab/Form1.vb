'Programador 1 -> Teo
'Programador 2 -> Jorge

Imports FabLab.FormUsuarios

Public Class Form1
    Private Sub NuevoUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoUsuarioToolStripMenuItem.Click
        Dim nuevoUsuarioForm As New FormUsuarios
        nuevoUsuarioForm.tipo = TipoForm.Insertar
        nuevoUsuarioForm.MdiParent = Me
        nuevoUsuarioForm.Show()

    End Sub


    'Temporal
    Private Sub VerUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerUsuarioToolStripMenuItem.Click
        Dim nuevoUsuarioForm As New FormGestionUsuarios
        nuevoUsuarioForm.MdiParent = Me

        nuevoUsuarioForm.Show()
    End Sub

    Private Sub GestiónDeMáquinasToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles GestiónDeMáquinasToolStripMenuItem.Click
        Dim form As New FormGestionMaquinas

        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        NuevoUsuarioToolStripMenuItem.PerformClick()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        NuevaMaquinaToolStripMenuItem1.PerformClick()
    End Sub

    Private Sub NuevaMaquina(sender As Object, e As EventArgs) Handles NuevaMaquinaToolStripMenuItem1.Click
        Dim nuevamaquinaform As New FormMaquinas
        nuevamaquinaform.tipo = FormMaquinas.TipoForm.Insertar
        nuevamaquinaform.MdiParent = Me
        nuevamaquinaform.Show()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim nuevoUsuarioForm As New FormAcercaDe
        nuevoUsuarioForm.MdiParent = Me

        nuevoUsuarioForm.Show()
    End Sub

    Private Sub HorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub VerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub CascadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadaToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub MinimizarTodasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizarTodasToolStripMenuItem.Click
        Dim i As Integer
        For i = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).WindowState = FormWindowState.Minimized
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        toolStripProgressBar1.Visible = False

        ToolStripStatusLabel1.Text = "Usuarios: " + NegocioUsuarios.CantidadUsuarios().ToString
        ToolStripStatusLabel2.Text = "Máquinas: " + NegocioMaquinas.CantidadMaquinas().ToString





    End Sub


End Class
