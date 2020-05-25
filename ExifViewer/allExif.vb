Imports MetadataExtractor
Imports MetadataExtractor.Formats.Exif
Imports System.IO


Public Class allExif
    Private Sub allExif_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DisplayExif(utilities.filename)
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub DisplayExif(filename As String)
        Try
            Dim directories As IEnumerable(Of MetadataExtractor.Directory) = ImageMetadataReader.ReadMetadata(filename)
            Dim Tagcount As Integer = 0
            For Each directory In directories
                Tagcount = directory.TagCount
                ' For Each Tag In directory.Tags
                For i As Integer = 0 To Tagcount - 1

                    If directory.Tags.Item(i).Name.ToString = "Red TRC" Or directory.Tags.Item(i).Name.ToString = "Green TRC" Or directory.Tags.Item(i).Name.ToString = "Blue TRC" Then 'this is esoteric and takes up a lot of real estate 
                        Continue For

                    End If

                    Me.txtAllExif.Text = txtAllExif.Text.ToString & vbCrLf & directory.Tags.Item(i).Name.ToString & ": " & directory.Tags.Item(i).Description.ToString
                Next i
            Next
        Catch
            Me.txtAllExif.Text = "There was an error reading the metadata for this photo. Perhaps none exists?"
        End Try

    End Sub
End Class