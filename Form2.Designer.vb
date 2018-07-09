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
        CType(Me.txtPollRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSaveConfig
        '
        Me.btnSaveConfig.Location = New System.Drawing.Point(92, 198)
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
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Poll Rate"
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
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Start Minimised"
        '
        'chkMuted
        '
        Me.chkMuted.AutoSize = True
        Me.chkMuted.Location = New System.Drawing.Point(106, 85)
        Me.chkMuted.Name = "chkMuted"
        Me.chkMuted.Size = New System.Drawing.Size(15, 14)
        Me.chkMuted.TabIndex = 6
        Me.chkMuted.UseVisualStyleBackColor = True
        '
        'chkStartMin
        '
        Me.chkStartMin.AutoSize = True
        Me.chkStartMin.Location = New System.Drawing.Point(105, 107)
        Me.chkStartMin.Name = "chkStartMin"
        Me.chkStartMin.Size = New System.Drawing.Size(15, 14)
        Me.chkStartMin.TabIndex = 7
        Me.chkStartMin.UseVisualStyleBackColor = True
        '
        'txtPollRate
        '
        Me.txtPollRate.Location = New System.Drawing.Point(106, 55)
        Me.txtPollRate.Maximum = New Decimal(New Integer() {240, 0, 0, 0})
        Me.txtPollRate.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtPollRate.Name = "txtPollRate"
        Me.txtPollRate.Size = New System.Drawing.Size(49, 20)
        Me.txtPollRate.TabIndex = 8
        Me.txtPollRate.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ChangeDirectory
        '
        Me.ChangeDirectory.Location = New System.Drawing.Point(15, 139)
        Me.ChangeDirectory.Name = "ChangeDirectory"
        Me.ChangeDirectory.Size = New System.Drawing.Size(125, 23)
        Me.ChangeDirectory.TabIndex = 9
        Me.ChangeDirectory.Text = "Change Directory"
        Me.ChangeDirectory.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ChangeDirectory)
        Me.Controls.Add(Me.txtPollRate)
        Me.Controls.Add(Me.chkStartMin)
        Me.Controls.Add(Me.chkMuted)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSaveConfig)
        Me.Name = "Form2"
        Me.Text = "Form2"
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
End Class
