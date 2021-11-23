Public Class map
    Private Sub map_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebView1.Navigate(frmMain.finalMapURL)
        ' WebView1.NavigateToString(frmMain.mapURL)
        Console.WriteLine(frmMain.finalMapURL.ToString)
        'WebBrowser1.Navigate(New Uri(frmMain.mapURL))
    End Sub

    Private Sub WebView1_DOMContentLoaded(sender As Object, e As Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlDOMContentLoadedEventArgs) Handles WebView1.DOMContentLoaded

    End Sub
End Class