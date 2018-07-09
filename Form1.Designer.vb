<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.textbanner = New System.Windows.Forms.Label()
        Me.CheckNew = New System.Windows.Forms.Timer(Me.components)
        Me.btnDismiss = New System.Windows.Forms.Button()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.changeDirc = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.currentDirectory = New System.Windows.Forms.Label()
        Me.PhotoStore = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 76)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(380, 355)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = false
        '
        'textbanner
        '
        Me.textbanner.AutoSize = true
        Me.textbanner.Font = New System.Drawing.Font("Microsoft Sans Serif", 24!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.textbanner.Location = New System.Drawing.Point(70, 33)
        Me.textbanner.Name = "textbanner"
        Me.textbanner.Size = New System.Drawing.Size(223, 37)
        Me.textbanner.TabIndex = 1
        Me.textbanner.Text = "No New Alerts"
        '
        'CheckNew
        '
        Me.CheckNew.Interval = 1000
        '
        'btnDismiss
        '
        Me.btnDismiss.Location = New System.Drawing.Point(316, 12)
        Me.btnDismiss.Name = "btnDismiss"
        Me.btnDismiss.Size = New System.Drawing.Size(76, 58)
        Me.btnDismiss.TabIndex = 2
        Me.btnDismiss.Text = "Dismiss"
        Me.btnDismiss.UseVisualStyleBackColor = true
        '
        'NotifyIcon
        '
        Me.NotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon.BalloonTipText = "Motion Detected"
        Me.NotifyIcon.BalloonTipTitle = "Motion Detected"
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"),System.Drawing.Icon)
        Me.NotifyIcon.Text = "CCTV Monitor"
        Me.NotifyIcon.Visible = true
        '
        'changeDirc
        '
        Me.changeDirc.Location = New System.Drawing.Point(1, 1)
        Me.changeDirc.Name = "changeDirc"
        Me.changeDirc.Size = New System.Drawing.Size(41, 33)
        Me.changeDirc.TabIndex = 3
        Me.changeDirc.Text = "@"
        Me.changeDirc.UseVisualStyleBackColor = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(9, 434)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Directory:"
        '
        'currentDirectory
        '
        Me.currentDirectory.AutoSize = true
        Me.currentDirectory.Location = New System.Drawing.Point(62, 435)
        Me.currentDirectory.Name = "currentDirectory"
        Me.currentDirectory.Size = New System.Drawing.Size(10, 13)
        Me.currentDirectory.TabIndex = 5
        Me.currentDirectory.Text = "-"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 450)
        Me.Controls.Add(Me.currentDirectory)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.changeDirc)
        Me.Controls.Add(Me.btnDismiss)
        Me.Controls.Add(Me.textbanner)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MaximumSize = New System.Drawing.Size(420, 489)
        Me.MinimizeBox = false
        Me.Name = "Form1"
        Me.Text = "CCTV Monitor"
        Me.TopMost = true
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents textbanner As System.Windows.Forms.Label
    Friend WithEvents CheckNew As System.Windows.Forms.Timer
    Friend WithEvents btnDismiss As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents changeDirc As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents currentDirectory As System.Windows.Forms.Label
    Friend WithEvents PhotoStore As System.Windows.Forms.FolderBrowserDialog

End Class
