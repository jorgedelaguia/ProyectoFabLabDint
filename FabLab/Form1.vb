﻿'Programador 1 -> Teo
'Programador 2 -> Jorge

Public Class Form1
    Private Sub NuevoUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoUsuarioToolStripMenuItem.Click
        Dim nuevoUsuarioForm As New FormUsuarios
        nuevoUsuarioForm.MdiParent = Me
        nuevoUsuarioForm.Show()


    End Sub

    Private Sub GestiónDeMáquinasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónDeMáquinasToolStripMenuItem.Click
        Dim form As New FormGestionMaquinas
        form.MdiParent = Me
        form.Show()
    End Sub
End Class
