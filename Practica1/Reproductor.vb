Public Class Reproductor
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

    Private Sub PantallaCompletaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PantallaCompletaToolStripMenuItem.Click
        If (AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying And AxWindowsMediaPlayer1.fullScreen = False) Then
            AxWindowsMediaPlayer1.fullScreen = True
        ElseIf (AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying And AxWindowsMediaPlayer1.fullScreen = True) Then
            AxWindowsMediaPlayer1.fullScreen = False
        End If
    End Sub
End Class