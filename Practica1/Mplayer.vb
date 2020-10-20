Public Class Mplayer
    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        For Each Track As String In OpenFileDialog1.FileNames
            ListBox1.Items.Add(Track)
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        AxWindowsMediaPlayer1.URL = ListBox1.SelectedItem
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim MplayerAd As New MplayerAD
        MplayerAd.Show()
    End Sub

    Private Sub AjustesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjustesToolStripMenuItem.Click
        AxWindowsMediaPlayer1.ShowPropertyPages()
    End Sub

    Private Sub RepetirUnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RepetirUnoToolStripMenuItem.Click

    End Sub
End Class