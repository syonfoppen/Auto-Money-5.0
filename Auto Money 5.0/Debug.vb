Public Class Debug
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label23.Text = My.Settings.Timer
        Label24.Text = My.Settings.Key
        Label25.Text = My.Settings.Money_Total
        Label26.Text = My.Settings.Procces
        Label27.Text = My.Settings.Money_limit
        Label28.Text = My.Settings.RadomTimer
        Label29.Text = My.Settings.Randomtimer_time_Max
        Label30.Text = My.Settings.RandomTimer_time_Min
        Label31.Text = My.Settings.Anti_afk_key
        Label32.Text = My.Settings.Anti_afk_Time
        Label33.Text = My.Settings.Money_Limit_toggle
        Label35.Text = My.Settings.Timer_option
        Label36.Text = My.Settings.Overlay

        Label37.Text = Form1.status
        Label38.Text = Form1.time
        Label39.Text = Form1.running
        Label40.Text = Form1.session_money
        Label41.Text = Form1.Total_money
        Label42.Text = Form1.option_status
        Label43.Text = Form1.anti_afk
        Label44.Text = Form1.Money_limit
        Label34.Text = Form1.gta_status





    End Sub

    Private Sub Debug_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class