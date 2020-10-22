Public Class MenuPrincipal


    Public Property Practca1 As Object

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Dim Calculadora As New Calc
        Calculadora.Show()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim Acerca As New Form2
        Acerca.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ReproductorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReproductorToolStripMenuItem.Click
        Dim reproductorV As New Reproductor
        reproductorV.Show()
    End Sub

    Private Sub MusicPlayerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MusicPlayerToolStripMenuItem.Click
        Dim MusicPlayer As New Mplayer
        MusicPlayer.Show()
    End Sub
End Class
