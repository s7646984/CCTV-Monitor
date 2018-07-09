Public Class Form2
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


    Private Sub btnSaveConfig_Click(sender As Object, e As EventArgs) Handles btnSaveConfig.Click
        'Registry Settings are saved to  'HKEY_CURRENT_USER\SOFTWARE\VB and VBA Program Settings\CCTV Monitor\Config' if possible
        SaveSetting(AppName:="CCTV Monitor", Section:="Config", Key:="DefaultLocation", Setting:=Form1.dir)
        SaveSetting(AppName:="CCTV Monitor", Section:="Config", Key:="Mute", Setting:=chkMuted.Checked)
        SaveSetting(AppName:="CCTV Monitor", Section:="Config", Key:="PollRate", Setting:=txtPollRate.Value * 1000) 'Multiples seconds into miliseconds
        SaveSetting(AppName:="CCTV Monitor", Section:="Config", Key:="StartMinimised", Setting:=chkStartMin.Checked)
        Form1.LoadConfig()
        Me.Visible = False  'Close Settings form
        Form1.Visible = True    'Open Main Dialog

    End Sub


    Private Sub ChangeDirectory_Click(sender As Object, e As EventArgs) Handles ChangeDirectory.Click
        If (PhotoStore.ShowDialog() = DialogResult.OK) Then

            Form1.dir = PhotoStore.SelectedPath

            Dim root As Environment.SpecialFolder = PhotoStore.RootFolder
            Form1.CheckDirectory()
        End If
    End Sub


End Class