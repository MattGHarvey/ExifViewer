<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ofdSelect = New System.Windows.Forms.OpenFileDialog()
        Me.btnSelect = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(23, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(493, 391)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.UseWaitCursor = True
        '
        'ofdSelect
        '
        Me.ofdSelect.Filter = "JPG files|*.jpg|JPEG files|*.jpeg"
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(532, 105)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(231, 90)
        Me.btnSelect.TabIndex = 1
        Me.btnSelect.Text = "Select Photo"
        Me.btnSelect.UseVisualStyleBackColor = True
        Me.btnSelect.UseWaitCursor = True
        '
        'frmMain
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmMain"
        Me.Text = "EXIFVIewer"
        Me.UseWaitCursor = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ofdSelect As OpenFileDialog
    Friend WithEvents btnSelect As Button
End Class
