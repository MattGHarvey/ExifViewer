<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class map
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
        Me.WebView1 = New Microsoft.Toolkit.Forms.UI.Controls.WebView()
        CType(Me.WebView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WebView1
        '
        Me.WebView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebView1.Location = New System.Drawing.Point(0, 0)
        Me.WebView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.WebView1.MinimumSize = New System.Drawing.Size(13, 13)
        Me.WebView1.Name = "WebView1"
        Me.WebView1.Size = New System.Drawing.Size(1155, 714)
        Me.WebView1.TabIndex = 0
        '
        'map
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1155, 714)
        Me.Controls.Add(Me.WebView1)
        Me.Name = "map"
        Me.Text = "Photo Map"
        CType(Me.WebView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WebView1 As Microsoft.Toolkit.Forms.UI.Controls.WebView
End Class
