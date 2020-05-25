Imports System
Imports System.IO
Imports System.Math
Imports MetadataExtractor
Imports MetadataExtractor.Formats.Exif
Imports System.Drawing
Imports System.Drawing.Imaging

Public Class frmMain
    Public Shared dtab As New DataTable
    Public Shared mapURL As String
    Public Shared masterFilename As String
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_DragDrop(sender As Object, e As DragEventArgs)
        MsgBox("test", vbOK)

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = DefaultCursor

        dtab.Columns.Add("fName", GetType(System.String))
        dtab.Columns.Add("datetime", GetType(System.DateTime))
        dtab.Columns.Add("focallength", GetType(System.String))
        dtab.Columns.Add("ShutterSpeed", GetType(System.String))
        dtab.Columns.Add("ISO", GetType(System.String))
        dtab.Columns.Add("aperture", GetType(System.String))
        dtab.Columns.Add("camera", GetType(System.String))
        dtab.Columns.Add("TagExposureBias", GetType(System.String))
        dtab.Columns.Add("TagMeteringMode", GetType(System.String))
        dtab.Columns.Add("TagFlash", GetType(System.String))
        dtab.Columns.Add("TagLensModel", GetType(System.String))

        dtab.Columns.Add("ColorSpace", GetType(System.String))
        dtab.Columns.Add("latitude", GetType(System.String))
        dtab.Columns.Add("Longitude", GetType(System.String))


        'Dim sMsg As String = ""
        'For Each sArg As String In My.Application.CommandLineArgs
        '    sMsg &= sArg & ": "
        'Next
        'If Me.ofdSelect.FileName.Trim <> "" Then
        '    Me.btnViewOnGoogleMaps.Visible = False

        '    DisplayEXIF(Me.ofdSelect.FileName.Trim)
        '    postDisplayActions(Me.ofdSelect.FileName)

        'End If
    End Sub

    Private Sub frmMain_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        'For Each path In files
        ' MsgBox(path)
        ' Next
        Dim filename As String = Path.GetFileName(files(0))
        Dim extension As String = Path.GetExtension(files(0))
        If (extension <> ".jpg" And extension <> ".jpeg") Then
            Me.Cursor = Cursors.No
            e.Effect = DragDropEffects.None
        Else
            e.Effect = DragDropEffects.Link
        End If
    End Sub

    Private Sub frmMain_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim files As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
            Dim u As New utilities

            btnViewOnGoogleMaps.Visible = False
            u.filename = files(0)
            masterFilename = files(0)

            DisplayEXIF(files(0))
            postDisplayActions(files(0))
            Me.Cursor = Cursors.Default
            Me.ShowAllEXIFDataToolStripMenuItem.Enabled = True


        End If
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs)
        Me.ofdSelect.ShowDialog()
        If Me.ofdSelect.FileName.Trim <> "" Then
            Me.btnViewOnGoogleMaps.Visible = False

            DisplayEXIF(Me.ofdSelect.FileName.Trim)
            postDisplayActions(Me.ofdSelect.FileName)

        End If

    End Sub
    Private Sub postDisplayActions(filename As String)
        'Dim tImage As Bitmap = Bitmap.FromFile(filename)
        'Dim ImageA As Image = Image.FromFile(filename)
        Dim fs As System.IO.FileStream
        fs = New System.IO.FileStream(filename, IO.FileMode.Open, IO.FileAccess.Read)
        Me.pbPhoto.Image = System.Drawing.Image.FromStream(fs)
        fs.Close()

        '  Me.pbPhoto.Image = tImage
        Me.pbPhoto.BackgroundImage = Nothing

        If mapURL <> "" Then
            Dim finalMapURL As New Uri(mapURL)
            btnViewOnGoogleMaps.Visible = True





        End If
        fs.Dispose()

        'ImageA.Dispose()
        ' ImageA = Nothing

        'Me.pbPhoto.Image.Dispose()
        'Me.pbPhoto.Image = Nothing

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
        Dim TagExposureBias = Nothing
        Dim TagMeteringMode = Nothing
        Dim TagExifImageWidth = Nothing
        Dim TagFlash = Nothing
        Dim TagExifImageHeight = Nothing
        Dim TagLensSpecification = Nothing
        Dim TagLensMake = Nothing
        Dim TagLens = Nothing
        Dim TagLensModel = Nothing
        Dim TagExposureIndex = Nothing
        Dim fName As String
        Dim exifString As String = Nothing
        fName = Path.GetFileName(filename)
        exifString = exifString & "Filename: " & fName

        If directory.TryGetDateTime(ExifDirectoryBase.TagDateTimeOriginal, datetime) Then
            Console.WriteLine("datetime:" & datetime)
            exifString = exifString & vbCrLf & "Date Captured: " & datetime
        End If
        If deviceDirectory IsNot Nothing Then
            camera = deviceDirectory.GetDescription(ExifDirectoryBase.TagModel.ToString)
            If camera IsNot Nothing Then
                camera = camera.Replace(",", "")
            End If
            Console.WriteLine("camera:" & camera)
            exifString = exifString & vbCrLf & "Camera: " & camera
        End If

        If directory IsNot Nothing Then
            TagLensModel = directory.GetDescription(ExifDirectoryBase.TagLensModel)
            exifString = exifString & vbCrLf & "Lens: " & TagLensModel
            focallength = directory.GetDescription(ExifDirectoryBase.TagFocalLength)
            exifString = exifString & vbCrLf & "Focal Length: " & focallength

            ShutterSpeed = directory.GetDescription(ExifDirectoryBase.TagShutterSpeed)
            exifString = exifString & vbCrLf & "Shutter Speed: " & ShutterSpeed
            ISO = directory.GetDescription(ExifDirectoryBase.TagIsoEquivalent)
            exifString = exifString & vbCrLf & "ISO: " & ISO
            aperture = directory.GetDescription(ExifDirectoryBase.TagAperture)
            exifString = exifString & vbCrLf & "Aperture: " & aperture
            TagExposureBias = directory.GetDescription(ExifDirectoryBase.TagExposureBias)
            exifString = exifString & vbCrLf & "Exposure Compensation: " & TagExposureBias
            TagMeteringMode = directory.GetDescription(ExifDirectoryBase.TagMeteringMode)
            exifString = exifString & vbCrLf & "Metering Mode: " & TagMeteringMode
            TagFlash = directory.GetDescription(ExifDirectoryBase.TagFlash)
            exifString = exifString & vbCrLf & "Flash: " & TagFlash
            ColorSpace = directory.GetDescription(ExifDirectoryBase.TagColorSpace)
            exifString = exifString & vbCrLf & "Color Space: " & ColorSpace



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

        If gpsdirectory IsNot Nothing Then
            gpsdirectory.GetGeoLocation()
            latitude = gpsdirectory.GetGeoLocation.Latitude
            Longitude = gpsdirectory.GetGeoLocation.Longitude

            Console.WriteLine("Coordinates:" & latitude & "," & Longitude)
            exifString = exifString & vbCrLf & "Coordinates: " & latitude & "," & Longitude
            mapURL = "https://www.google.com/maps/search/?api=1&query=" & latitude & "," & Longitude


        End If

        dtab.Rows.Add(fName, datetime, focallength, ShutterSpeed, ISO, aperture, camera, TagExposureBias, TagMeteringMode, TagFlash, TagLensModel, ColorSpace, latitude, Longitude)

        Me.txtEXIF.Text = exifString

        Dim dv As New DataView(dtab)
        ' dv.Sort = "datetake ASC"
        ' DataGridView1.DataSource = dv
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

    Private Sub txtEXIF_TextChanged(sender As Object, e As EventArgs) Handles txtEXIF.TextChanged

    End Sub

    Private Sub btnViewOnGoogleMaps_Click(sender As Object, e As EventArgs) Handles btnViewOnGoogleMaps.Click
        Process.Start(mapURL)
        ' map.WebView1.Navigate(New Uri(mapURL))
        '  map.Show()

    End Sub

    Private Sub LoadPhotoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadPhotoToolStripMenuItem.Click
        Me.ofdSelect.ShowDialog()
        If Me.ofdSelect.FileName.Trim <> "" Then
            Me.btnViewOnGoogleMaps.Visible = False
            Me.ShowAllEXIFDataToolStripMenuItem.Enabled = True
            utilities.filename = Me.ofdSelect.FileName.Trim
            DisplayEXIF(Me.ofdSelect.FileName.Trim)
            postDisplayActions(Me.ofdSelect.FileName)

        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub pbPhoto_Click(sender As Object, e As EventArgs) Handles pbPhoto.Click
        If Not pbPhoto.Image Is Nothing Then
            viewer.Show()
        End If
    End Sub

    Private Sub ViewAllExifDataToolStripMenuItem_Click(sender As Object, e As EventArgs)
        allExif.Show()

    End Sub

    Private Sub ShowAllEXIFDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowAllEXIFDataToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor


        allExif.Show()

    End Sub
    'TODO: Finish implementation
    Private Sub RemoveAllMetadataToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        'MessageBox.Show()
        Dim img As Image = Image.FromFile(masterFilename)
        Dim jpgEncoder As ImageCodecInfo = GetEncoder(ImageFormat.Jpeg)
        Dim myEncoder As System.Drawing.Imaging.Encoder = System.Drawing.Imaging.Encoder.Quality
        Dim safeImage As New Bitmap(img)
        Dim myEncoderParameters As New EncoderParameters(1)

        Dim myEncoderParameter As New EncoderParameter(myEncoder, 50L)
        myEncoderParameters.Param(0) = myEncoderParameter


        myEncoderParameter = New EncoderParameter(myEncoder, 100L)
        myEncoderParameters.Param(0) = myEncoderParameter
        '  img.Save(masterFilename, ImageFormat.Jpeg, myEncoderParameters)
        safeImage.Save(masterFilename, jpgEncoder, myEncoderParameters)




    End Sub
    Private Function GetEncoder(ByVal format As ImageFormat) As ImageCodecInfo

        Dim codecs As ImageCodecInfo() = ImageCodecInfo.GetImageDecoders()
        Dim codec As ImageCodecInfo
        For Each codec In codecs
            If codec.FormatID = format.Guid Then
                Return codec
            End If
        Next codec
        Return Nothing

    End Function
End Class
