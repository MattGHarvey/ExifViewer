Public Class map
    Private Sub map_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  WebView1.Navigate(New Uri(frmMain.mapURL))
        WebView1.NavigateToString(frmMain.mapURL)

        'WebBrowser1.Navigate(New Uri(frmMain.mapURL))
    End Sub
End Class