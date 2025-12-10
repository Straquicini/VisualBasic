Public Class Form1

    Private Sub EquipamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EquipamentosToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub TiposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class