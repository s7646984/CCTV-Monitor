Imports System.IO

Public Class Form1

    Dim picturesinFolder
    Dim priornumber

    Public dir
    Public PollRate
    Public Muted As Boolean
    Public StartMin


    Private Sub CheckNew_Tick(sender As Object, e As EventArgs) Handles CheckNew.Tick

        CheckNumberOfPhotos()
        If picturesinFolder > priornumber Then
            priornumber = picturesinFolder
            LatestPicture()
            Me.WindowState = FormWindowState.Normal
            ShowInTaskbar = True

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDismiss.Click
        Me.WindowState = FormWindowState.Minimized
        PictureBox1.Image = Nothing
        textbanner.Text = "No New Alerts"
        ShowInTaskbar = False
        NotifyIcon.Visible = True

    End Sub

    Private Sub CheckNumberOfPhotos()

        picturesinFolder = Directory.GetFiles(dir, "*.jpg").Count

        If priornumber > picturesinFolder Then
            priornumber = picturesinFolder
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadConfig()
        CheckDirectory()
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
        Dim file = dirc.EnumerateFiles("*.jpg").
            OrderByDescending(Function(f) f.LastWriteTime).
            FirstOrDefault()
        If file IsNot Nothing Then
            Dim path = file.FullName
            PictureBox1.Image = Image.FromFile(path)
            textbanner.Text = "New Alert"
            If Muted = False Then Beep()
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
            If (PhotoStore.ShowDialog() = DialogResult.OK) Then

                dir = PhotoStore.SelectedPath

                Dim root As Environment.SpecialFolder = PhotoStore.RootFolder
                CheckDirectory()
            End If

        End If
    End Sub

    Private Sub NotifyIcon_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon.DoubleClick
        ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        NotifyIcon.Visible = False
    End Sub

    'Icon made by Freepik http://www.freepik.com" from Flaticon"https://www.flaticon.com/" which is licensed under Creative Commons BY 3.0 "http://creativecommons.org/licenses/by/3.0/"

    Private Sub changeDirc_Click(sender As Object, e As EventArgs) Handles changeDirc.Click
        Form2.txtPollRate.Value = PollRate / 1000
        Form2.chkMuted.Checked = Muted
        Form2.chkStartMin.Checked = StartMin
        Form2.Visible = True
    End Sub

    Public Sub LoadConfig()
        dir = GetSetting("CCTV Monitor", "Config", "DefaultLocation", "")
        PollRate = GetSetting("CCTV Monitor", "Config", "PollRate", 1000)
        Muted = GetSetting("CCTV Monitor", "Config", "Mute", False)
        StartMin = GetSetting("CCTV Monitor", "Config", "StartMinimised", False)
        CheckNew.Interval = PollRate

    End Sub

End Class
