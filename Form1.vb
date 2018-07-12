' ********************************************************************
'                       CCTV Monitor V1.00
'
'Small program that monitors and alerts user of a new image in a directory
'Use case is a security camera or software package saving a image into a
'folder on motion. When this picture is detected in the folder (either local
' or network the program will display an alert on screen with the new picture.
'
'This program is freeware and opensource under GNU GPLv3. It can be used
'for Personal or Commerical purposes. If you modify the program please give
'credit where its due and keep it open source. 
'
'There is no Warranty or guarantee with this program and I am not liable
'for any damages.
'
'Please send any feedback to james@air-gap.com.au
'
' ********************************************************************



Imports System.IO

Public Class Form1

    Dim picturesinFolder    'Current number of pictures in folder
    Dim priornumber         'Number of photos on the past poll

    Public dir              'Current Picture Directory
    Public PollRate         'How oftne the program will check the folder (in milliseconds)
    Public Muted            'Is the beep on new alerts muted
    Public StartMin         'Start Program Minimised
    Public Filetype         'Filetype that program will look for in directory, Default JPG. Supported: gif, jpg, jpeg, bmp, wmf, png
    Public Silent           'Only Pops up notification


    Private Sub CheckNew_Tick(sender As Object, e As EventArgs) Handles CheckNew.Tick
        'Timer which runs every interval (Default every 1000miliseconds/1second

        CheckNumberOfPhotos()
        If picturesinFolder > priornumber Then  'If a new photo has been added to the directory
            priornumber = picturesinFolder
            LatestPicture()                     'Determines what photo is the most recent and loads it into the picturebox
            
            lblTotalImages.Text = picturesinFolder
            lblAlertTotal.Text = lblAlertTotal.Text + 1
            lblLastAlert.Text = TimeOfDay
            textbanner.Text = "New Alert"
            If Muted = False Then Beep()
            If Silent = False Then
                Me.WindowState = FormWindowState.Normal 'Opens the window
                ShowInTaskbar = True    'Restores Taskbar Icon
            Else
                NotifyIcon.ShowBalloonTip(3000)
            End If
            


        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDismiss.Click
        Me.WindowState = FormWindowState.Minimized
        PictureBox1.Image = Nothing 'Clears picturebox image
        textbanner.Text = "No New Alerts"
        ShowInTaskbar = False
        NotifyIcon.Visible = True   'Icon in the Notification bar (near clock/speaker icon) Visible

    End Sub

    Private Sub CheckNumberOfPhotos()

        picturesinFolder = Directory.GetFiles(dir, Filetype).Count

        If priornumber > picturesinFolder Then  'If images are deleted from the folder, the count of numbers is reset without alerting the user
            priornumber = picturesinFolder
        End If

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No) Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadConfig()
        CheckDirectory()
        CheckNumberOfPhotos()
        lblTotalImages.Text = picturesinFolder
        NotifyIcon.BalloonTipText = "Click to View"
        If StartMin Then
            Me.WindowState = FormWindowState.Minimized
            PictureBox1.Image = Nothing
            textbanner.Text = "No New Alerts"
            ShowInTaskbar = False
            NotifyIcon.Visible = True
        End If
    End Sub
    Private Sub LatestPicture()
        Dim dirc = New System.IO.DirectoryInfo(dir)
        Dim file = dirc.EnumerateFiles(Filetype).
            OrderByDescending(Function(f) f.LastWriteTime).
            FirstOrDefault()    'Enumerate Over files in directory and order them by last write time. Latest file is selected
        If file IsNot Nothing Then
            Dim path = file.FullName
            PictureBox1.Image = Image.FromFile(path)    'Load Image in Picturebox

        End If

    End Sub
    Public Sub CheckDirectory()

        If Directory.Exists(dir) Then
            CheckNumberOfPhotos()
            priornumber = picturesinFolder
            CheckNew.Enabled = True
            currentDirectory.Text = dir
        Else

            MsgBox("No Directory Set")
            If (PhotoStore.ShowDialog() = DialogResult.OK) Then 'Launches the Dialog Box for user to select default directory

                dir = PhotoStore.SelectedPath

                Dim root As Environment.SpecialFolder = PhotoStore.RootFolder
                CheckDirectory()
            End If

        End If
    End Sub

    Private Sub NotifyIcon_BalloonTipClicked(sender As Object, e As EventArgs) Handles NotifyIcon.BalloonTipClicked
        Me.WindowState = FormWindowState.Normal 'Opens the window
        ShowInTaskbar = True    'Restores Taskbar Icon

    End Sub

    Private Sub NotifyIcon_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon.DoubleClick
        'When icon in notification tab (near clock/speaker) is double clicked 
        ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        NotifyIcon.Visible = False
    End Sub

    Private Sub changeDirc_Click(sender As Object, e As EventArgs) Handles changeDirc.Click
        Form2.txtPollRate.Value = PollRate / 1000   'Update setting information on setting page
        Form2.chkMuted.Checked = Muted
        Form2.chkStartMin.Checked = StartMin
        Form2.chkNotification.Checked = Silent
        Form2.cmbImagetype.Text = Filetype.remove(0, 2)
        Form2.Visible = True    'Opens Setting page
        Form2.chkNotification.Checked = Silent
    End Sub

    Public Sub LoadConfig()
        'Registry Settings are loaded from   'HKEY_CURRENT_USER\SOFTWARE\VB and VBA Program Settings\CCTV Monitor\Config'       if possible
        dir = GetSetting("CCTV Monitor", "Config", "DefaultLocation", "")
        PollRate = GetSetting("CCTV Monitor", "Config", "PollRate", 1000)
        Muted = GetSetting("CCTV Monitor", "Config", "Mute", False)
        StartMin = GetSetting("CCTV Monitor", "Config", "StartMinimised", False)
        Filetype = GetSetting("CCTV Monitor", "Config", "FileType", "*.jpg")
        Silent = GetSetting("CCTV Monitor", "Config", "Notification", False)
        CheckNew.Interval = PollRate    'Updates the timer interval for polling


    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        PauseProgram()

    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        PlayProgram()
    End Sub

    Private Sub ToolStripMenuItemExit_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemExit.Click
        'When Notification Icon has been right clicked and Exit clicked
        End
    End Sub

    Private Sub IndefintlyToolStripMenuPauseIndef_Click(sender As Object, e As EventArgs) Handles IndefintlyToolStripMenuPauseIndef.Click
        'When Notification Icon has been right clicked and paused indefintly
        PauseProgram()
    End Sub

    Private Sub ToolStripMenuItemOpen_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemOpen.Click
        'When Notification Icon has been right clicked and open clicked
        ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        NotifyIcon.Visible = False
    End Sub

    Private Sub PauseProgram()
        CheckNew.Enabled = False
        textbanner.Text = "Paused"
        btnPause.Enabled = False
        btnPlay.Enabled = True
    End Sub

    Private Sub PlayProgram()
        CheckNew.Enabled = Enabled
        textbanner.Text = "No New Alerts"
        btnPlay.Enabled = False
        btnPause.Enabled = True
    End Sub

    Private Sub SleepTimer_Tick(sender As Object, e As EventArgs) Handles SleepTimer.Tick
        PlayProgram()
        SleepTimer.Enabled = False
    End Sub

    Private Sub MinutesToolStripMenuItemPause5_Click(sender As Object, e As EventArgs) Handles MinutesToolStripMenuItemPause5.Click
        SleepTimer.Interval = 300000
        PauseProgram()
        SleepTimer.Enabled = True
    End Sub

    Private Sub MinutesToolStripMenuItemPause30_Click(sender As Object, e As EventArgs) Handles MinutesToolStripMenuItemPause30.Click
        SleepTimer.Interval = 1800000
        PauseProgram()
        SleepTimer.Enabled = True
    End Sub

    Private Sub HourToolStripMenuItemPause1Hour_Click(sender As Object, e As EventArgs) Handles HourToolStripMenuItemPause1Hour.Click
        SleepTimer.Interval = 3600000
        PauseProgram()
        SleepTimer.Enabled = True
    End Sub

    Private Sub ToolStripMenuItemImageDirectory_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemImageDirectory.Click
        Try
            Process.Start(dir)  'Opens up set picture directory
        Catch ex As Exception
            MsgBox("Error Opening Directory")
        End Try

    End Sub
End Class
