<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ofdSelect = New System.Windows.Forms.OpenFileDialog()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.txtEXIF = New System.Windows.Forms.TextBox()
        Me.pbPhoto = New System.Windows.Forms.PictureBox()
        Me.btnViewOnGoogleMaps = New System.Windows.Forms.Button()
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ofdSelect
        '
        Me.ofdSelect.Filter = "JPG files|*.jpg|JPEG files|*.jpeg"
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(30, 28)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(231, 90)
        Me.btnSelect.TabIndex = 1
        Me.btnSelect.Text = "Select Photo"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'txtEXIF
        '
        Me.txtEXIF.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.txtEXIF.Enabled = False
        Me.txtEXIF.Location = New System.Drawing.Point(30, 591)
        Me.txtEXIF.Multiline = True
        Me.txtEXIF.Name = "txtEXIF"
        Me.txtEXIF.Size = New System.Drawing.Size(572, 357)
        Me.txtEXIF.TabIndex = 3
        Me.txtEXIF.UseWaitCursor = True
        '
        'pbPhoto
        '
        Me.pbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbPhoto.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbPhoto.Location = New System.Drawing.Point(30, 159)
        Me.pbPhoto.Name = "pbPhoto"
        Me.pbPhoto.Size = New System.Drawing.Size(572, 404)
        Me.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPhoto.TabIndex = 4
        Me.pbPhoto.TabStop = False
        '
        'btnViewOnGoogleMaps
        '
        Me.btnViewOnGoogleMaps.Location = New System.Drawing.Point(30, 968)
        Me.btnViewOnGoogleMaps.Name = "btnViewOnGoogleMaps"
        Me.btnViewOnGoogleMaps.Size = New System.Drawing.Size(572, 47)
        Me.btnViewOnGoogleMaps.TabIndex = 5
        Me.btnViewOnGoogleMaps.Text = "View Location on Google Maps"
        Me.btnViewOnGoogleMaps.UseVisualStyleBackColor = True
        Me.btnViewOnGoogleMaps.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 1031)
        Me.Controls.Add(Me.btnViewOnGoogleMaps)
        Me.Controls.Add(Me.pbPhoto)
        Me.Controls.Add(Me.txtEXIF)
        Me.Controls.Add(Me.btnSelect)
        Me.Name = "frmMain"
        Me.Text = "EXIFVIewer"
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ofdSelect As OpenFileDialog
    Friend WithEvents btnSelect As Button
    Friend WithEvents txtEXIF As TextBox
    Friend WithEvents pbPhoto As PictureBox
    Friend WithEvents btnViewOnGoogleMaps As Button
End Class
