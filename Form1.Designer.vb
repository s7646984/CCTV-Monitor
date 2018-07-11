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
        Me.btnPause = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.pnlControls = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAlertTotal = New System.Windows.Forms.Label()
        Me.lblLastAlert = New System.Windows.Forms.Label()
        Me.lblTotalImages = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlControls.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(9, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(380, 355)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'textbanner
        '
        Me.textbanner.AutoSize = True
        Me.textbanner.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbanner.Location = New System.Drawing.Point(122, 9)
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
        Me.btnDismiss.Location = New System.Drawing.Point(5, 14)
        Me.btnDismiss.Name = "btnDismiss"
        Me.btnDismiss.Size = New System.Drawing.Size(76, 58)
        Me.btnDismiss.TabIndex = 2
        Me.btnDismiss.Text = "Hide"
        Me.btnDismiss.UseVisualStyleBackColor = True
        '
        'NotifyIcon
        '
        Me.NotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon.BalloonTipText = "Motion Detected"
        Me.NotifyIcon.BalloonTipTitle = "Motion Detected"
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "CCTV Monitor"
        Me.NotifyIcon.Visible = True
        '
        'changeDirc
        '
        Me.changeDirc.Location = New System.Drawing.Point(1, 1)
        Me.changeDirc.Name = "changeDirc"
        Me.changeDirc.Size = New System.Drawing.Size(41, 33)
        Me.changeDirc.TabIndex = 3
        Me.changeDirc.Text = "@"
        Me.changeDirc.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 434)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Directory:"
        '
        'currentDirectory
        '
        Me.currentDirectory.Location = New System.Drawing.Point(62, 435)
        Me.currentDirectory.Name = "currentDirectory"
        Me.currentDirectory.Size = New System.Drawing.Size(430, 15)
        Me.currentDirectory.TabIndex = 5
        Me.currentDirectory.Text = "-"
        '
        'btnPause
        '
        Me.btnPause.Location = New System.Drawing.Point(5, 83)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(36, 61)
        Me.btnPause.TabIndex = 6
        Me.btnPause.Text = "| |"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'btnPlay
        '
        Me.btnPlay.Enabled = False
        Me.btnPlay.Location = New System.Drawing.Point(47, 83)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(36, 61)
        Me.btnPlay.TabIndex = 7
        Me.btnPlay.Text = "I>"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'pnlControls
        '
        Me.pnlControls.BackColor = System.Drawing.SystemColors.Control
        Me.pnlControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlControls.Controls.Add(Me.btnDismiss)
        Me.pnlControls.Controls.Add(Me.btnPlay)
        Me.pnlControls.Controls.Add(Me.btnPause)
        Me.pnlControls.Location = New System.Drawing.Point(395, 36)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(97, 164)
        Me.pnlControls.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblAlertTotal)
        Me.Panel1.Controls.Add(Me.lblLastAlert)
        Me.Panel1.Controls.Add(Me.lblTotalImages)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(393, 223)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(118, 157)
        Me.Panel1.TabIndex = 9
        '
        'lblAlertTotal
        '
        Me.lblAlertTotal.AutoSize = True
        Me.lblAlertTotal.Location = New System.Drawing.Point(54, 40)
        Me.lblAlertTotal.Name = "lblAlertTotal"
        Me.lblAlertTotal.Size = New System.Drawing.Size(13, 13)
        Me.lblAlertTotal.TabIndex = 14
        Me.lblAlertTotal.Text = "0"
        '
        'lblLastAlert
        '
        Me.lblLastAlert.AutoSize = True
        Me.lblLastAlert.Location = New System.Drawing.Point(54, 53)
        Me.lblLastAlert.Name = "lblLastAlert"
        Me.lblLastAlert.Size = New System.Drawing.Size(10, 13)
        Me.lblLastAlert.TabIndex = 13
        Me.lblLastAlert.Text = "-"
        '
        'lblTotalImages
        '
        Me.lblTotalImages.AutoSize = True
        Me.lblTotalImages.Location = New System.Drawing.Point(54, 67)
        Me.lblTotalImages.Name = "lblTotalImages"
        Me.lblTotalImages.Size = New System.Drawing.Size(10, 13)
        Me.lblTotalImages.TabIndex = 10
        Me.lblTotalImages.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Last Alert: "
        Me.ToolTipMain.SetToolTip(Me.Label4, "Time of last alert")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Images: "
        Me.ToolTipMain.SetToolTip(Me.Label2, "Total number of image files in the monitored directory")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Alerts: "
        Me.ToolTipMain.SetToolTip(Me.Label3, "Total number of alerts recorded since the program was opened")
        '
        'ToolTipMain
        '
        Me.ToolTipMain.AutoPopDelay = 2500
        Me.ToolTipMain.InitialDelay = 500
        Me.ToolTipMain.ReshowDelay = 100
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 459)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlControls)
        Me.Controls.Add(Me.currentDirectory)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.changeDirc)
        Me.Controls.Add(Me.textbanner)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(530, 550)
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "CCTV Monitor"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlControls.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents btnPause As System.Windows.Forms.Button
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents pnlControls As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTotalImages As System.Windows.Forms.Label
    Friend WithEvents lblAlertTotal As System.Windows.Forms.Label
    Friend WithEvents lblLastAlert As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolTipMain As System.Windows.Forms.ToolTip

End Class
