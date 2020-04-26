Public Class Menu
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CasaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CasaToolStripMenuItem.Click
        agregarCasa.Show()

    End Sub

    Private Sub CargoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargoToolStripMenuItem.Click
        cargo.Show()

    End Sub
End Class