Public Class Form2


    Private Sub btnSaveConfig_Click(sender As Object, e As EventArgs) Handles btnSaveConfig.Click
        SaveSetting(AppName:="CCTV Monitor", Section:="Config", Key:="DefaultLocation", Setting:=Form1.dir)
        SaveSetting(AppName:="CCTV Monitor", Section:="Config", Key:="Mute", Setting:=chkMuted.Checked)
        SaveSetting(AppName:="CCTV Monitor", Section:="Config", Key:="PollRate", Setting:=txtPollRate.Value * 1000)
        SaveSetting(AppName:="CCTV Monitor", Section:="Config", Key:="StartMinimised", Setting:=chkStartMin.Checked)
        Form1.LoadConfig()
        Me.Visible = False
        Form1.Visible = True

    End Sub


    Private Sub ChangeDirectory_Click(sender As Object, e As EventArgs) Handles ChangeDirectory.Click
        If (PhotoStore.ShowDialog() = DialogResult.OK) Then

            Form1.dir = PhotoStore.SelectedPath

            Dim root As Environment.SpecialFolder = PhotoStore.RootFolder
            Form1.CheckDirectory()
        End If
    End Sub


End Class