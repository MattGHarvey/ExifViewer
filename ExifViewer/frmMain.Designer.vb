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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ofdSelect = New System.Windows.Forms.OpenFileDialog()
        Me.txtEXIF = New System.Windows.Forms.TextBox()
        Me.pbPhoto = New System.Windows.Forms.PictureBox()
        Me.btnViewOnGoogleMaps = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadPhotoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRightClick = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ofdSelect
        '
        Me.ofdSelect.Filter = "JPG files|*.jpg|JPEG files|*.jpeg"
        '
        'txtEXIF
        '
        Me.txtEXIF.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.txtEXIF.Enabled = False
        Me.txtEXIF.Location = New System.Drawing.Point(30, 518)
        Me.txtEXIF.Multiline = True
        Me.txtEXIF.Name = "txtEXIF"
        Me.txtEXIF.Size = New System.Drawing.Size(572, 357)
        Me.txtEXIF.TabIndex = 3
        Me.txtEXIF.UseWaitCursor = True
        '
        'pbPhoto
        '
        Me.pbPhoto.BackColor = System.Drawing.Color.White
        Me.pbPhoto.BackgroundImage = CType(resources.GetObject("pbPhoto.BackgroundImage"), System.Drawing.Image)
        Me.pbPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbPhoto.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbPhoto.InitialImage = CType(resources.GetObject("pbPhoto.InitialImage"), System.Drawing.Image)
        Me.pbPhoto.Location = New System.Drawing.Point(30, 74)
        Me.pbPhoto.Name = "pbPhoto"
        Me.pbPhoto.Size = New System.Drawing.Size(572, 404)
        Me.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPhoto.TabIndex = 4
        Me.pbPhoto.TabStop = False
        '
        'btnViewOnGoogleMaps
        '
        Me.btnViewOnGoogleMaps.Location = New System.Drawing.Point(30, 903)
        Me.btnViewOnGoogleMaps.Name = "btnViewOnGoogleMaps"
        Me.btnViewOnGoogleMaps.Size = New System.Drawing.Size(572, 47)
        Me.btnViewOnGoogleMaps.TabIndex = 5
        Me.btnViewOnGoogleMaps.Text = "View Location on Google Maps"
        Me.btnViewOnGoogleMaps.UseVisualStyleBackColor = True
        Me.btnViewOnGoogleMaps.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(633, 38)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadPhotoToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(56, 34)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoadPhotoToolStripMenuItem
        '
        Me.LoadPhotoToolStripMenuItem.Name = "LoadPhotoToolStripMenuItem"
        Me.LoadPhotoToolStripMenuItem.Size = New System.Drawing.Size(288, 34)
        Me.LoadPhotoToolStripMenuItem.Text = "Load Photo..."
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(288, 34)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'mnuRightClick
        '
        Me.mnuRightClick.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.mnuRightClick.Name = "mnuRightClick"
        Me.mnuRightClick.Size = New System.Drawing.Size(61, 4)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(82, 34)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'frmMain
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(633, 975)
        Me.Controls.Add(Me.btnViewOnGoogleMaps)
        Me.Controls.Add(Me.pbPhoto)
        Me.Controls.Add(Me.txtEXIF)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "EXIFVIewer"
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ofdSelect As OpenFileDialog
    Friend WithEvents txtEXIF As TextBox
    Friend WithEvents pbPhoto As PictureBox
    Friend WithEvents btnViewOnGoogleMaps As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadPhotoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuRightClick As ContextMenuStrip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
