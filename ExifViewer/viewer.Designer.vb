<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewer))
        Me.pbViewer = New System.Windows.Forms.PictureBox()
        CType(Me.pbViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbViewer
        '
        Me.pbViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbViewer.Location = New System.Drawing.Point(0, 0)
        Me.pbViewer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pbViewer.Name = "pbViewer"
        Me.pbViewer.Size = New System.Drawing.Size(1478, 1392)
        Me.pbViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbViewer.TabIndex = 0
        Me.pbViewer.TabStop = False
        '
        'viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1478, 1392)
        Me.Controls.Add(Me.pbViewer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimizeBox = False
        Me.Name = "viewer"
        Me.Text = "Image Viewer"
        CType(Me.pbViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbViewer As PictureBox
End Class
