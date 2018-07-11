<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.btnSaveConfig = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkMuted = New System.Windows.Forms.CheckBox()
        Me.chkStartMin = New System.Windows.Forms.CheckBox()
        Me.txtPollRate = New System.Windows.Forms.NumericUpDown()
        Me.ChangeDirectory = New System.Windows.Forms.Button()
        Me.PhotoStore = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ToolTipSettings = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbImagetype = New System.Windows.Forms.ComboBox()
        CType(Me.txtPollRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSaveConfig
        '
        Me.btnSaveConfig.Location = New System.Drawing.Point(92, 217)
        Me.btnSaveConfig.Name = "btnSaveConfig"
        Me.btnSaveConfig.Size = New System.Drawing.Size(86, 23)
        Me.btnSaveConfig.TabIndex = 0
        Me.btnSaveConfig.Text = "Save"
        Me.btnSaveConfig.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(102, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Settings"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Poll Rate (sec)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Muted:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Start Minimised:"
        '
        'chkMuted
        '
        Me.chkMuted.AutoSize = True
        Me.chkMuted.Location = New System.Drawing.Point(106, 85)
        Me.chkMuted.Name = "chkMuted"
        Me.chkMuted.Size = New System.Drawing.Size(15, 14)
        Me.chkMuted.TabIndex = 6
        Me.ToolTipSettings.SetToolTip(Me.chkMuted, "If ticked the program will no longer Beep when" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a new image is detected.")
        Me.chkMuted.UseVisualStyleBackColor = True
        '
        'chkStartMin
        '
        Me.chkStartMin.AutoSize = True
        Me.chkStartMin.Location = New System.Drawing.Point(105, 107)
        Me.chkStartMin.Name = "chkStartMin"
        Me.chkStartMin.Size = New System.Drawing.Size(15, 14)
        Me.chkStartMin.TabIndex = 7
        Me.ToolTipSettings.SetToolTip(Me.chkStartMin, "The program will remain hidden when starting" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and will be visible in the notifcat" & _
        "ion bar." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It will still alert you of new images.")
        Me.chkStartMin.UseVisualStyleBackColor = True
        '
        'txtPollRate
        '
        Me.txtPollRate.Location = New System.Drawing.Point(106, 55)
        Me.txtPollRate.Maximum = New Decimal(New Integer() {3600, 0, 0, 0})
        Me.txtPollRate.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtPollRate.Name = "txtPollRate"
        Me.txtPollRate.Size = New System.Drawing.Size(49, 20)
        Me.txtPollRate.TabIndex = 8
        Me.ToolTipSettings.SetToolTip(Me.txtPollRate, "How often the program will check" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "your directory for new images and alert you." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "M" & _
        "in: 1 second (Default), Max 3600 seconds")
        Me.txtPollRate.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ChangeDirectory
        '
        Me.ChangeDirectory.Location = New System.Drawing.Point(12, 169)
        Me.ChangeDirectory.Name = "ChangeDirectory"
        Me.ChangeDirectory.Size = New System.Drawing.Size(125, 23)
        Me.ChangeDirectory.TabIndex = 9
        Me.ChangeDirectory.Text = "Change Directory"
        Me.ToolTipSettings.SetToolTip(Me.ChangeDirectory, "Change the default image directory")
        Me.ChangeDirectory.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(195, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Version: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(240, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "1.01"
        '
        'ToolTipSettings
        '
        Me.ToolTipSettings.AutoPopDelay = 3000
        Me.ToolTipSettings.InitialDelay = 500
        Me.ToolTipSettings.ReshowDelay = 100
        Me.ToolTipSettings.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTipSettings.ToolTipTitle = "Settings"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Image Type: "
        '
        'cmbImagetype
        '
        Me.cmbImagetype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbImagetype.FormattingEnabled = True
        Me.cmbImagetype.Items.AddRange(New Object() {"jpg", "jpeg", "gif", "bmp", "wmf", "png"})
        Me.cmbImagetype.Location = New System.Drawing.Point(87, 127)
        Me.cmbImagetype.Name = "cmbImagetype"
        Me.cmbImagetype.Size = New System.Drawing.Size(50, 21)
        Me.cmbImagetype.TabIndex = 13
        Me.ToolTipSettings.SetToolTip(Me.cmbImagetype, "Specify what format of image file the program should alert on")
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.cmbImagetype)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ChangeDirectory)
        Me.Controls.Add(Me.txtPollRate)
        Me.Controls.Add(Me.chkStartMin)
        Me.Controls.Add(Me.chkMuted)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSaveConfig)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "CCTV Monitor"
        Me.TopMost = True
        CType(Me.txtPollRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSaveConfig As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkMuted As System.Windows.Forms.CheckBox
    Friend WithEvents chkStartMin As System.Windows.Forms.CheckBox
    Friend WithEvents txtPollRate As System.Windows.Forms.NumericUpDown
    Friend WithEvents ChangeDirectory As System.Windows.Forms.Button
    Friend WithEvents PhotoStore As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolTipSettings As System.Windows.Forms.ToolTip
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbImagetype As System.Windows.Forms.ComboBox
End Class
