Imports MetadataExtractor
Imports MetadataExtractor.Formats.Exif
Imports System.IO


Public Class allExif
    Private Sub allExif_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DisplayExif(utilities.filename)
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub DisplayExif(filename As String)
        Dim directories As IEnumerable(Of MetadataExtractor.Directory) = ImageMetadataReader.ReadMetadata(filename)
        Dim Tagcount As Integer = 0
        For Each directory In directories
            Tagcount = directory.TagCount
            ' For Each Tag In directory.Tags
            For i As Integer = 0 To Tagcount - 1
                'Console.WriteLine($"{directory.Name} - {directory.Tags.Item(i).Name} = {directory.Tags.Item(i).Description}")
                'Me.txtAllExif.Text = txtAllExif.Text.ToString & vbCrLf & directory.Name.ToString & " " & directory.Tags.Item(i).Name.ToString & " " & directory.Tags.Item(i).Description.ToString
                Me.txtAllExif.Text = txtAllExif.Text.ToString & vbCrLf & directory.Tags.Item(i).Name.ToString & ": " & directory.Tags.Item(i).Description.ToString
            Next i
        Next
    End Sub
End Class