Imports System
Imports System.IO
Imports System.Math
Imports MetadataExtractor
Imports MetadataExtractor.Formats.Exif
Public Class frmMain
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_DragDrop(sender As Object, e As DragEventArgs) Handles PictureBox1.DragDrop
        MsgBox("test", vbOK)

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AllowDrop = True

    End Sub

    Private Sub frmMain_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        'Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        'For Each path In files
        'MsgBox(path)
        ' Next
    End Sub

    Private Sub frmMain_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim files As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())

            For Each file In files
                MessageBox.Show(file)
            Next
        End If
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Me.ofdSelect.ShowDialog()
        If Me.ofdSelect.FileName.Trim <> "" Then
            DisplayEXIF(Me.ofdSelect.FileName.Trim)
        End If

    End Sub
    Private Sub DisplayEXIF(filename As String)
        Dim directories As IEnumerable(Of MetadataExtractor.Directory) = ImageMetadataReader.ReadMetadata(filename)
        Dim directory = directories.OfType(Of ExifSubIfdDirectory)().FirstOrDefault()
        Dim deviceDirectory = directories.OfType(Of ExifIfd0Directory)().FirstOrDefault

        Dim gpsdirectory = directories.OfType(Of GpsDirectory)().FirstOrDefault()
        Dim latitude = Nothing
        Dim datetime = Nothing
        Dim Longitude = Nothing
        Dim aperture As String = Nothing
        Dim ColorSpace = Nothing
        Dim TagWhiteBalance
        Dim camera As String = ""
        Dim focallength As String = ""
        Dim ISO As String = ""
        Dim ShutterSpeed As String = ""
        Dim TagExposureBias
        Dim TagMeteringMode
        Dim TagExifImageWidth
        Dim TagFlash
        Dim TagExifImageHeight
        Dim TagLensSpecification
        Dim TagLensMake
        Dim TagLens
        Dim TagLensModel
        Dim TagExposureIndex
        If directory.TryGetDateTime(ExifDirectoryBase.TagDateTimeOriginal, datetime) Then
            Console.WriteLine("datetime:" & datetime)
        End If

        If directory IsNot Nothing Then
            aperture = directory.GetDescription(ExifDirectoryBase.TagAperture)

            focallength = directory.GetDescription(ExifDirectoryBase.TagFocalLength)
            ColorSpace = directory.GetDescription(ExifDirectoryBase.TagColorSpace)
            ISO = directory.GetDescription(ExifDirectoryBase.TagIsoEquivalent)
            ShutterSpeed = directory.GetDescription(ExifDirectoryBase.TagShutterSpeed)
            TagWhiteBalance = directory.GetDescription(ExifDirectoryBase.TagWhiteBalance)
            TagExposureBias = directory.GetDescription(ExifDirectoryBase.TagExposureBias)
            TagMeteringMode = directory.GetDescription(ExifDirectoryBase.TagMeteringMode)
            TagFlash = directory.GetDescription(ExifDirectoryBase.TagFlash)
            TagExifImageWidth = directory.GetDescription(ExifDirectoryBase.TagExifImageWidth)
            TagExifImageHeight = directory.GetDescription(ExifDirectoryBase.TagExifImageHeight)
            TagLensSpecification = directory.GetDescription(ExifDirectoryBase.TagLensSpecification)
            TagLensMake = directory.GetDescription(ExifDirectoryBase.TagLensMake)
            TagLens = directory.GetDescription(ExifDirectoryBase.TagLens)
            TagLensModel = directory.GetDescription(ExifDirectoryBase.TagLensModel)
            TagExposureIndex = directory.GetDescription(ExifDirectoryBase.TagExposureIndex)

            If ShutterSpeed IsNot Nothing Then
                ShutterSpeed = FixSS(ShutterSpeed.Replace("sec", "")) & "sec"
            End If
            Console.WriteLine("focallength:" & focallength)
            Console.WriteLine("aperture:" & aperture)
            Console.WriteLine("ColorSpace:" & ColorSpace)
            Console.WriteLine("ShutterSpeed:" & ShutterSpeed)
            Console.WriteLine("ISO:" & ISO)
            Console.WriteLine("ShutterSpeed:" & ShutterSpeed)

            Console.WriteLine("TagExposureBias:" & TagExposureBias)
            Console.WriteLine("TagMeteringMode:" & TagMeteringMode)

            Console.WriteLine("TagFlash:" & TagFlash)

            Console.WriteLine("TagLensModel:" & TagLensModel)
            Console.WriteLine("TagExposureIndex:" & TagExposureIndex)

        End If
        If deviceDirectory IsNot Nothing Then
            camera = deviceDirectory.GetDescription(ExifDirectoryBase.TagModel.ToString)
            If camera IsNot Nothing Then
                camera = camera.Replace(",", "")
            End If
            Console.WriteLine("camera:" & camera)
        End If
        If gpsdirectory IsNot Nothing Then
            gpsdirectory.GetGeoLocation()
            latitude = gpsdirectory.GetGeoLocation.Latitude
            Longitude = gpsdirectory.GetGeoLocation.Longitude

            Console.WriteLine("Coordinates:" & latitude & "," & Longitude)
            'filename = Path.GetFileName(filename)



        End If
    End Sub
    Public Function FixSS(ss As String)
        Dim sspeed() As String
        Dim denom As Int16

        If ss.Contains("/") Then
            sspeed = ss.Split("/")
            If IsNumeric(sspeed(1)) Then
                denom = Convert.ToInt16(sspeed(1))

                denom = Round(denom / 5) * 5
                Return "1/" & denom.ToString()
            End If
        End If
        Return ss
    End Function
End Class
