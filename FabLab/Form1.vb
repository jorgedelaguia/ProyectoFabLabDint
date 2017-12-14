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




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Temporal
    Private Sub VerUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerUsuarioToolStripMenuItem.Click
        Dim nuevoUsuarioForm As New FormUsuarios
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

    Private Sub GestiónDeMáquinasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NuevaMaquinaToolStripMenuItem1.Click
        Dim form As New FromMaquinas
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim nuevoUsuarioForm As New FormAcercaDe
        nuevoUsuarioForm.MdiParent = Me

        nuevoUsuarioForm.Show()
    End Sub
End Class
