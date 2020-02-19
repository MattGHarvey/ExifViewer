Public Class viewer
    Private Sub viewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim imageheight As Integer = frmMain.pbPhoto.Image.Height
        Dim imagewidth As Integer = frmMain.pbPhoto.Image.Width
        Me.pbViewer.Image = frmMain.pbPhoto.Image
        If imageheight < screenHeight Then
            Me.Width = Me.pbViewer.Image.Width
            Me.Height = Me.pbViewer.Image.Height
        Else
            Me.Width = Me.pbViewer.Image.Width
            Me.Height = screenHeight
        End If

    End Sub

    Private Sub pbViewer_Click(sender As Object, e As EventArgs) Handles pbViewer.Click
        Me.Hide()
        Me.Dispose()


    End Sub
End Class