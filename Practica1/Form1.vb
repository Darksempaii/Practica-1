Public Class practica1


    Public Property Practca1 As Object


    Private Sub HerramientasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HerramientasToolStripMenuItem.Click

    End Sub

    Private Sub AnimeIDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnimeFLVToolStripMenuItem.Click
        WebBrowser1.Navigate("https://www.animeid.tv/")
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click

    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Dim Calculadora As New Calc
        Calculadora.Show()
    End Sub

    Private Sub CalendarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalendarioToolStripMenuItem.Click
        MonthCalendar1.Visible = True
        OcultarCalendarioToolStripMenuItem.Visible = True
        CalendarioToolStripMenuItem.Visible = False
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim Acerca As New Form2
        Acerca.Show()
    End Sub

    Private Sub ArchivoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ArchivoToolStripMenuItem1.Click

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        WebBrowser1.Navigate("https://www.google.com.mx/")
    End Sub

    Private Sub CerrarNavegadorToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReproductorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReproductorToolStripMenuItem.Click
        Dim reproductorV As New Reproductor
        reproductorV.Show()
    End Sub

    Private Sub MusicPlayerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MusicPlayerToolStripMenuItem.Click
        Dim MusicPlayer As New Mplayer
        MusicPlayer.Show()
    End Sub

    Private Sub FacebookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacebookToolStripMenuItem.Click
        WebBrowser1.Navigate("http://www.facebook.com/")
    End Sub

    Private Sub TwitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TwitterToolStripMenuItem.Click
        WebBrowser1.Navigate("https://www.Twitter.com")
    End Sub

    Private Sub OutlookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OutlookToolStripMenuItem.Click
        WebBrowser1.Navigate("https://www.Outlook.com")
    End Sub

    Private Sub AnimeFLVToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AnimeFLVToolStripMenuItem1.Click
        WebBrowser1.Navigate("https://www3.animeflv.net")
    End Sub

    Private Sub Atras_Click(sender As Object, e As EventArgs) Handles Atras.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub Siguiente_Click(sender As Object, e As EventArgs) Handles Siguiente.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub Refrescar_Click(sender As Object, e As EventArgs) Handles Refrescar.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub Inicio_Click(sender As Object, e As EventArgs) Handles Inicio.Click
        WebBrowser1.Navigate("www.google.com")
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        WebBrowser1.Navigate(ToolStripTextBox1.Text)
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click

    End Sub

    Private Sub WebBrowser1_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged
        ToolStripLabel1.Text = WebBrowser1.StatusText
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        ToolStripTextBox1.Text = WebBrowser1.Url.ToString
    End Sub

    Private Sub OcultarCalendarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OcultarCalendarioToolStripMenuItem.Click
        MonthCalendar1.Visible = False
        OcultarCalendarioToolStripMenuItem.Visible = False
        CalendarioToolStripMenuItem.Visible = True
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged

    End Sub
End Class
