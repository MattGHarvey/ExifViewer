<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class allExif
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(allExif))
        Me.txtAllExif = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtAllExif
        '
        Me.txtAllExif.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAllExif.Location = New System.Drawing.Point(8, 8)
        Me.txtAllExif.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAllExif.Multiline = True
        Me.txtAllExif.Name = "txtAllExif"
        Me.txtAllExif.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAllExif.Size = New System.Drawing.Size(569, 762)
        Me.txtAllExif.TabIndex = 0
        Me.txtAllExif.TabStop = False
        '
        'allExif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 783)
        Me.Controls.Add(Me.txtAllExif)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "allExif"
        Me.Text = "All Exif Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAllExif As TextBox
End Class
