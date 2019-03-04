Public Class Options

    'Config ControlBox
    Dim loc As Point
    Private p_oRandom As Random
    Private Sub ControlStrip_MouseMove(sender As Object, e As MouseEventArgs) Handles ControlStrip.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += e.Location - loc
        End If
    End Sub

    Private Sub ControlStrip_MouseDown(sender As Object, e As MouseEventArgs) Handles ControlStrip.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Loc = e.Location
        End If
    End Sub

    Private Sub Closebutton_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs)
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub


    Private Sub Apply_Button_Click(sender As Object, e As EventArgs) Handles Apply_Button.Click
        If Time_Option.Text >= 30 Then
            If Random_time_min.Text >= 30 Then
                If Money_Limit_Option.Text >= 750000 Then

                    My.Settings.Timer = Time_Option.Text
                    My.Settings.Key = Keyboard_option.Text
                    My.Settings.Procces = Procces_option.Text
                    My.Settings.Money_limit = Money_Limit_Option.Text
                    My.Settings.Randomtimer_time_Max = Random_Time_max.Text
                    My.Settings.RandomTimer_time_Min = Random_time_min.Text
                    My.Settings.Anti_afk_key = AFK_Key.Text
                    My.Settings.Anti_afk_Time = AFK_Timer.Text
                    Form1.Anti_afk_timer.Interval = My.Settings.Anti_afk_Time * 1000
                    Form1.Money_limit = My.Settings.Money_limit

                    If Ignore_Option.Checked Then
                        My.Settings.Ignore = True
                    Else
                        My.Settings.Ignore = False
                    End If

                    If Limit_toggle.Checked Then
                        My.Settings.Money_Limit_toggle = True
                    Else
                        My.Settings.Money_Limit_toggle = False
                    End If

                    If Overlay_Option.Checked Then
                        My.Settings.Overlay = True
                        Overlay.Show()
                    Else
                        My.Settings.Overlay = False
                        Overlay.Close()
                    End If

                    If Random_timer_option.Checked Then
                        My.Settings.RadomTimer = True

                    Else
                        My.Settings.RadomTimer = False

                    End If




                    Form1.option_status = False
                    Form1.Enabled = True
                    Me.Hide()

                    If My.Settings.RadomTimer = True Then
                        ' Form1.update_timer()
                        'Form1.time = Form1.Random_money_timer.Interval / 1000



                    Else
                        Form1.time = My.Settings.Timer
                        Form1.Add_Money_timer.Interval = My.Settings.Timer * 1000

                    End If
                    Form1.Limit_Time_Left = My.Settings.Timer * (My.Settings.Money_limit / 750000)



                Else
                    MsgBox("Money Limit needs to be bigger than 750000!", 48, "Auto Money")
                End If
            Else
                MsgBox("Minimal Time needs to be longer than 30 seconds!", 48, "Auto Money")
            End If
        Else
            MsgBox("Fixd Timmer needs to be longer than 30 seconds!", 48, "Auto Money")
        End If


    End Sub

    Private Sub timer_option_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub Reset_button_Click(sender As Object, e As EventArgs) Handles Reset_button.Click
        If MessageBox.Show("are you sure you want to reset the settings?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            My.Settings.Reset()
            Time_Option.Text = My.Settings.Timer
            Keyboard_option.Text = My.Settings.Key
            Procces_option.Text = My.Settings.Procces
            Money_Limit_Option.Text = My.Settings.Money_limit
            Random_Time_max.Text = My.Settings.Randomtimer_time_Max
            Random_time_min.Text = My.Settings.RandomTimer_time_Min
            AFK_Key.Text = My.Settings.Anti_afk_key
            AFK_Timer.Text = My.Settings.Anti_afk_Time


            If My.Settings.Ignore = True Then
                Ignore_Option.CheckState = CheckState.Checked
            Else
                Ignore_Option.CheckState = CheckState.Unchecked
            End If

            If My.Settings.Money_Limit_toggle = True Then
                Limit_toggle.CheckState = CheckState.Checked
            Else
                Limit_toggle.CheckState = CheckState.Unchecked
            End If

            If My.Settings.Overlay = True Then
                Overlay_Option.CheckState = CheckState.Checked
            Else
                Overlay_Option.CheckState = CheckState.Unchecked
            End If

            If My.Settings.RadomTimer = True Then
                Random_timer_option.CheckState = CheckState.Checked
            Else
                Random_timer_option.CheckState = CheckState.Unchecked
            End If
        End If

    End Sub

    Private Sub cancel_button_Click(sender As Object, e As EventArgs) Handles cancel_button.Click
        If MessageBox.Show("are you sure you want to cancel?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Form1.option_status = False
            Form1.Enabled = True
            Me.Close()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Debug.Show()
    End Sub

    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class