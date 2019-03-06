Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging


Public Class EXIFRemover
    Public Sub RemoveExif(filename As String)
        Dim jpg As New Bitmap(filename)

        If System.IO.File.Exists(filename) Then
                System.IO.File.Delete(filename)
            End If
            jpg.Save(filename, ImageFormat.Jpeg)
    End Sub
End Class
