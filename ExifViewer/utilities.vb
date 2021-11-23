Imports System
Imports System.IO
Imports System.Math
Imports MetadataExtractor
Imports MetadataExtractor.Formats.Exif
Imports MetadataExtractor.Formats.Xmp
Public Class utilities
    Public Shared filename As String
    Public Function CreatePreset(filename) As Boolean
        Dim directories As IEnumerable(Of MetadataExtractor.Directory) = ImageMetadataReader.ReadMetadata(filename)
        Dim directory = directories.OfType(Of ExifSubIfdDirectory)().FirstOrDefault()
        'Dim directory = directories.OfType(O)().FirstOrDefault()
        Dim deviceDirectory = directories.OfType(Of ExifIfd0Directory)().FirstOrDefault

        Dim gpsdirectory = directories.OfType(Of GpsDirectory)().FirstOrDefault()

        Dim xmpDirectory = directories.OfType(Of XmpDirectory)().FirstOrDefault()
        For Each xmpDirectory In directories.OfType(Of XmpDirectory)()

            For Each [property] In xmpDirectory.XmpMeta.Properties
                Console.WriteLine($"{[property].Path}: {[property].Value}")
            Next
        Next
        Return True

    End Function

End Class
