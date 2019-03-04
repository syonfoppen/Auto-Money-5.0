
Public Class Form1
    'Startup settings
    'initialize Values
    Public status As Boolean = False
    Public time = 30
    Public running As Boolean = False
    Public session_money = 0
    Public Total_money = 0
    Public option_status As Boolean = False
    Public anti_afk As Boolean = False
    Public Money_limit = 750000
    Private p_oRandom As Random
    Public gta_status As Boolean = False
    Public p() As Process
    Public Limit_Time_Left = 0


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        p_oRandom = New Random
        update_timer()
        Sesstion_Money_label.Text = "$" & session_money
        Total_money_label.Text = "$" & Total_money
        Money_Remaining.Text = "$" & Money_limit

        Add_Money_timer.Interval = My.Settings.Timer * 1000
        Anti_afk_timer.Interval = My.Settings.Anti_afk_Time * 1000

        If My.Settings.RadomTimer = True Then
            time = Random_money_timer.Interval / 1000
        Else
            time = My.Settings.Timer
        End If

        Time_label.Text = time & " seconds"

        Total_money = My.Settings.Money_Total
        Money_limit = My.Settings.Money_limit

        Fast_Timer.Start()
        CheckIfRunning()
        Limit_Time_Left = My.Settings.Timer * (My.Settings.Money_limit / 750000)
        If running = False Then
            MsgBox(My.Settings.Procces & " procces not found!", 48, "Auto Money")
        End If

        Options.Time_Option.Text = My.Settings.Timer
        Options.Keyboard_option.Text = My.Settings.Key
        Options.Procces_option.Text = My.Settings.Procces
        Options.Money_Limit_Option.Text = My.Settings.Money_limit
        Options.Random_Time_max.Text = My.Settings.Randomtimer_time_Max
        Options.Random_time_min.Text = My.Settings.RandomTimer_time_Min
        Options.AFK_Key.Text = My.Settings.Anti_afk_key
        Options.AFK_Timer.Text = My.Settings.Anti_afk_Time


        If My.Settings.Ignore = True Then
            Options.Ignore_Option.CheckState = CheckState.Checked
        Else
            Options.Ignore_Option.CheckState = CheckState.Unchecked
        End If

        If My.Settings.Money_Limit_toggle = True Then
            Options.Limit_toggle.CheckState = CheckState.Checked
        Else
            Options.Limit_toggle.CheckState = CheckState.Unchecked
        End If

        If My.Settings.Overlay = True Then
            Options.Overlay_Option.CheckState = CheckState.Checked
            Overlay.Show()
        Else
            Options.Overlay_Option.CheckState = CheckState.Unchecked
        End If

        If My.Settings.RadomTimer = True Then
            Options.Random_timer_option.CheckState = CheckState.Checked
        Else
            Options.Random_timer_option.CheckState = CheckState.Unchecked
        End If

    End Sub

    'Config ControlBox
    Dim loc As Point
    Private Sub ControlStrip_MouseMove(sender As Object, e As MouseEventArgs) Handles ControlStrip.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += e.Location - loc
        End If
    End Sub

    Private Sub ControlStrip_MouseDown(sender As Object, e As MouseEventArgs) Handles ControlStrip.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            loc = e.Location
        End If
    End Sub

    Private Sub Closebutton_Click(sender As Object, e As EventArgs) Handles Closebutton.Click
        Close()
    End Sub

    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    'Check if Kiddions mod is running
    Private Sub CheckIfRunning()
        p = Process.GetProcessesByName(My.Settings.Procces)
        If p.Count > 0 Then
            running = True
        Else
            running = False
        End If

        If My.Settings.Ignore = False Then

            If running = False Then
                Process_status.Text = "Not Running!"
                Process_status.ForeColor = Color.Red
            Else
                Process_status.Text = "Running!"
                Process_status.ForeColor = Color.Green

            End If
        Else
            running = True
            Process_status.Text = "Ignored!"
            Process_status.ForeColor = Color.Orange
        End If
    End Sub

    'Timer Config
    Private Sub Fast_Timer_Tick(sender As Object, e As EventArgs) Handles Fast_Timer.Tick
        CheckIfRunning()
        Check_gta()
        Time_label.Text = time & " seconds"
        Sesstion_Money_label.Text = "$" & session_money
        Total_money_label.Text = "$" & Total_money

        If My.Settings.Money_Limit_toggle = True Then
            If My.Settings.RadomTimer = False Then

                Label3.ForeColor = Color.White
                If Limit_Time_Left < 60 Then
                    Label3.Text = Limit_Time_Left & " seconds"
                Else
                    Label3.Text = Math.Round(Limit_Time_Left / 60, 1, MidpointRounding.AwayFromZero) & " Minutes"
                End If
            Else
                Label3.ForeColor = Color.Red
                Label3.Text = "not available!"
            End If
        Else
            Label3.ForeColor = Color.Red
            Label3.Text = "not available!"
        End If

        If My.Settings.Money_Limit_toggle = True Then
            Money_Remaining.Text = "$" & Money_limit
            Money_Remaining.ForeColor = Color.White

        Else
            Money_Remaining.Text = "Disabeld"
            Money_Remaining.ForeColor = Color.Red

        End If


        If running = False Then
            Reset_values()
        End If

        My.Settings.Money_Total = Total_money


        If anti_afk = True Then
            Button1.BackColor = Color.Green
            Button1.Text = "Anti AFK: ON"
        Else
            Button1.BackColor = Color.Red
            Button1.Text = "Anti AFK: OFF"
        End If

    End Sub

    Private Sub Add_Money_timer_Tick(sender As Object, e As EventArgs) Handles Add_Money_timer.Tick


        Total_money += 750000
        session_money += 750000
        Money_limit -= 750000

        If My.Settings.RadomTimer = True Then
            time = Random_money_timer.Interval / 1000
        Else
            time = My.Settings.Timer
        End If
        HoldKeyDown(My.Settings.Key, 1)

    End Sub

    Private Sub Every_Second_timer_Tick(sender As Object, e As EventArgs) Handles Every_second_timer.Tick
        time -= 1
        Limit_Time_Left -= 1

        If My.Settings.Money_Limit_toggle = True Then
            If session_money >= My.Settings.Money_limit Then
                Reset_values()
                Console.Beep()
                MsgBox(" Money Limit Reached!", 48, "Auto Money")

            End If

        End If
    End Sub

    Private Sub Anti_afk_timer_Tick(sender As Object, e As EventArgs) Handles Anti_afk_timer.Tick
        HoldKeyDown(My.Settings.Anti_afk_key, 2)
    End Sub

    Private Sub Random_money_timer_Tick(sender As Object, e As EventArgs) Handles Random_money_timer.Tick
        update_timer()
        time = Random_money_timer.Interval / 1000

        Total_money += 750000
        session_money += 750000
        Money_limit -= 750000

        HoldKeyDown(My.Settings.Key, 1)
    End Sub

    'Reset Valaus
    Private Sub Reset_values()
        'stop timers
        Add_Money_timer.Stop()
        Random_money_timer.Stop()
        Every_second_timer.Stop()
        Anti_afk_timer.Stop()
        Limit_Time_Left = My.Settings.Timer * (My.Settings.Money_limit / 750000)
        'reset time
        If My.Settings.RadomTimer = True Then
            time = Random_money_timer.Interval / 1000
        Else
            time = My.Settings.Timer
        End If

        'reset button
        ToggelButtton.Text = "START"
        ToggelButtton.BackColor = Color.Red

        anti_afk = False

        'reset status
        status = False

    End Sub

    'Setup Key Pressing System
    Private Declare Sub keybd_event Lib "user32.dll" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Integer, ByVal dwExtraInfo As Integer)
    Private Declare Function MapVirtualKey Lib "user32" Alias "MapVirtualKeyA" (ByVal wCode As Integer, ByVal wMapType As Integer) As Integer

    Public Sub HoldKeyDown(ByVal key As Byte, ByVal durationInSeconds As Integer)
        Dim targetTime As DateTime = DateTime.Now().AddSeconds(durationInSeconds)
        keybd_event(key, MapVirtualKey(key, 0), 0, 0) ' Down
        While targetTime.Subtract(DateTime.Now()).TotalSeconds > 0
            Application.DoEvents()
        End While
        keybd_event(key, MapVirtualKey(key, 0), 2, 0) ' Up
    End Sub


    'Button Config
    Private Sub Reset_Timer_Click(sender As Object, e As EventArgs) Handles Reset_Timer.Click
        If My.Settings.RadomTimer = True Then
            update_timer()
            time = Random_money_timer.Interval / 1000

        Else
            time = My.Settings.Timer
        End If

    End Sub

    Private Sub Reset_Remaining_Money_Click(sender As Object, e As EventArgs) Handles Reset_Remaining_Money.Click
        Money_limit = My.Settings.Money_limit
    End Sub

    Private Sub Reset_Money_This_Session_Click(sender As Object, e As EventArgs) Handles Reset_Money_This_Session.Click
        session_money = 0
    End Sub

    Private Sub Reset_Total_Money_Click(sender As Object, e As EventArgs) Handles Reset_Total_Money.Click
        My.Settings.Money_Total = 0
        Total_money = 0

    End Sub

    Private Sub ToggelButtton_Click(sender As Object, e As EventArgs) Handles ToggelButtton.Click
        If option_status = False Then
            If running = True Then
                If status = True Then
                    Reset_values()
                Else
                    status = True
                    Limit_Time_Left = My.Settings.Timer * (My.Settings.Money_limit / 750000)
                    Every_second_timer.Start()
                    ToggelButtton.Text = "Stop"
                    ToggelButtton.BackColor = Color.Green
                    If My.Settings.RadomTimer = True Then
                        Random_money_timer.Start()
                        Add_Money_timer.Stop()
                        update_timer()
                        time = Random_money_timer.Interval / 1000
                    Else
                        Add_Money_timer.Start()
                        Random_money_timer.Stop()
                        update_timer()
                    End If
                End If
            Else
                If My.Settings.Ignore = False Then
                    MsgBox(My.Settings.Procces & " procces not found!", 48, "Auto Money")
                End If
            End If
        End If
    End Sub

    Private Sub Option_Button_Click(sender As Object, e As EventArgs) Handles Option_Button.Click
        Options.Show()
        Reset_values()
        option_status = True
        Me.Enabled = False
    End Sub

    Public Sub update_timer()
        Random_money_timer.Interval = p_oRandom.Next(My.Settings.RandomTimer_time_Min, My.Settings.Randomtimer_time_Max) * 1000
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If anti_afk = True Then
            anti_afk = False
        Else
            anti_afk = True
            Anti_afk_timer.Interval = My.Settings.Anti_afk_Time * 1000
            Anti_afk_timer.Start()
        End If
    End Sub

    Private Sub Check_gta()
        p = Process.GetProcessesByName("GTA5")
        If p.Count > 0 Then
            gta_status = True
        Else
            gta_status = False
        End If

    End Sub

    Private Sub SuspendProcess(ByVal process As System.Diagnostics.Process)
        For Each t As ProcessThread In process.Threads
            Dim th As IntPtr
            th = OpenThread(ThreadAccess.SUSPEND_RESUME, False, t.Id)
            If th <> IntPtr.Zero Then
                SuspendThread(th)
                CloseHandle(th)
            End If
        Next
    End Sub

    Private Sub ResumeProcess(ByVal process As System.Diagnostics.Process)
        For Each t As ProcessThread In process.Threads
            Dim th As IntPtr
            th = OpenThread(ThreadAccess.SUSPEND_RESUME, False, t.Id)
            If th <> IntPtr.Zero Then
                ResumeThread(th)
                CloseHandle(th)
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Check_gta()

        If gta_status = True Then


            Dim game As Process() = Process.GetProcessesByName("GTA5")
            SuspendProcess(game(0))
            Suspend_Timer.Start()
        Else
            MsgBox("Gta 5 is not running!", 48, "Auto Money")
        End If
    End Sub

    Private Sub Suspend_Timer_Tick(sender As Object, e As EventArgs) Handles Suspend_Timer.Tick
        Dim game As Process() = Process.GetProcessesByName("GTA5")
        ResumeProcess(game(0))
        Suspend_Timer.Stop()
    End Sub

End Class
