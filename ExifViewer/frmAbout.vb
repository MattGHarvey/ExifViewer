Public Class frmAbout
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub lnkGitHub_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkGitHub.LinkClicked
        Process.Start("https://github.com/MattGHarvey/ExifViewer")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class