Public Class Reproductor
    Private Sub Reproductor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim VPlayer As New VplayerAD
        VPlayer.Show()
    End Sub
End Class