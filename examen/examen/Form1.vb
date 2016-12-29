Public Class MenuPrincipal

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click

    End Sub

    Private Sub SalirAplicacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirAplicacionToolStripMenuItem.Click
        Application.ExitThread()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Acercade.IsMdiContainer = True
        Acercade.Show()
    End Sub
End Class
