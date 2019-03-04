<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Options
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Options))
        Me.ControlStrip = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Time_remaining_Label = New System.Windows.Forms.Label()
        Me.Keyboard_option = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Time_Option = New System.Windows.Forms.TextBox()
        Me.Random_time_min = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Random_Time_max = New System.Windows.Forms.TextBox()
        Me.Procces_option = New System.Windows.Forms.TextBox()
        Me.Ignore_Option = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Money_Limit_Option = New System.Windows.Forms.TextBox()
        Me.Limit_toggle = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.AFK_Key = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Random_timer_option = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.AFK_Timer = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Overlay_Option = New System.Windows.Forms.CheckBox()
        Me.cancel_button = New System.Windows.Forms.Button()
        Me.Reset_button = New System.Windows.Forms.Button()
        Me.Apply_Button = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ControlStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'ControlStrip
        '
        Me.ControlStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ControlStrip.Controls.Add(Me.PictureBox1)
        Me.ControlStrip.Controls.Add(Me.Label1)
        Me.ControlStrip.Dock = System.Windows.Forms.DockStyle.Top
        Me.ControlStrip.Location = New System.Drawing.Point(0, 0)
        Me.ControlStrip.Name = "ControlStrip"
        Me.ControlStrip.Size = New System.Drawing.Size(1114, 48)
        Me.ControlStrip.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Auto_Money_4._0.My.Resources.Resources.coin_money_1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(6, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(54, 40)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(63, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(342, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "AUTO MONEY - OPTIONS"
        '
        'Time_remaining_Label
        '
        Me.Time_remaining_Label.AutoSize = True
        Me.Time_remaining_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Time_remaining_Label.ForeColor = System.Drawing.Color.White
        Me.Time_remaining_Label.Location = New System.Drawing.Point(12, 20)
        Me.Time_remaining_Label.Name = "Time_remaining_Label"
        Me.Time_remaining_Label.Size = New System.Drawing.Size(137, 25)
        Me.Time_remaining_Label.TabIndex = 4
        Me.Time_remaining_Label.Text = "Key To Press:"
        '
        'Keyboard_option
        '
        Me.Keyboard_option.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Keyboard_option.Location = New System.Drawing.Point(155, 17)
        Me.Keyboard_option.Name = "Keyboard_option"
        Me.Keyboard_option.Size = New System.Drawing.Size(65, 30)
        Me.Keyboard_option.TabIndex = 11
        Me.Keyboard_option.Text = "120"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(4, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(322, 25)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Time Between Presses in Seconds:"
        '
        'Time_Option
        '
        Me.Time_Option.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Time_Option.Location = New System.Drawing.Point(332, 19)
        Me.Time_Option.Name = "Time_Option"
        Me.Time_Option.Size = New System.Drawing.Size(65, 30)
        Me.Time_Option.TabIndex = 14
        Me.Time_Option.Text = "30"
        '
        'Random_time_min
        '
        Me.Random_time_min.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Random_time_min.Location = New System.Drawing.Point(251, 17)
        Me.Random_time_min.Name = "Random_time_min"
        Me.Random_time_min.Size = New System.Drawing.Size(65, 30)
        Me.Random_time_min.TabIndex = 14
        Me.Random_time_min.Text = "30"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(233, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Minimal Time in seconds:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(251, 25)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Maximum Time in seconds:"
        '
        'Random_Time_max
        '
        Me.Random_Time_max.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Random_Time_max.Location = New System.Drawing.Point(269, 49)
        Me.Random_Time_max.Name = "Random_Time_max"
        Me.Random_Time_max.Size = New System.Drawing.Size(65, 30)
        Me.Random_Time_max.TabIndex = 16
        Me.Random_Time_max.Text = "60"
        '
        'Procces_option
        '
        Me.Procces_option.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Procces_option.Location = New System.Drawing.Point(16, 48)
        Me.Procces_option.Name = "Procces_option"
        Me.Procces_option.Size = New System.Drawing.Size(482, 30)
        Me.Procces_option.TabIndex = 26
        Me.Procces_option.Text = "refund_[unknowncheats.me]_"
        '
        'Ignore_Option
        '
        Me.Ignore_Option.AutoSize = True
        Me.Ignore_Option.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ignore_Option.ForeColor = System.Drawing.Color.White
        Me.Ignore_Option.Location = New System.Drawing.Point(19, 95)
        Me.Ignore_Option.Name = "Ignore_Option"
        Me.Ignore_Option.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Ignore_Option.Size = New System.Drawing.Size(274, 29)
        Me.Ignore_Option.TabIndex = 27
        Me.Ignore_Option.Text = "Ignore Process Not Running"
        Me.Ignore_Option.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(14, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 25)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Money Limit:"
        '
        'Money_Limit_Option
        '
        Me.Money_Limit_Option.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money_Limit_Option.Location = New System.Drawing.Point(143, 15)
        Me.Money_Limit_Option.Name = "Money_Limit_Option"
        Me.Money_Limit_Option.Size = New System.Drawing.Size(274, 30)
        Me.Money_Limit_Option.TabIndex = 29
        Me.Money_Limit_Option.Text = "750000"
        '
        'Limit_toggle
        '
        Me.Limit_toggle.AutoSize = True
        Me.Limit_toggle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Limit_toggle.ForeColor = System.Drawing.Color.White
        Me.Limit_toggle.Location = New System.Drawing.Point(16, 53)
        Me.Limit_toggle.Name = "Limit_toggle"
        Me.Limit_toggle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Limit_toggle.Size = New System.Drawing.Size(202, 29)
        Me.Limit_toggle.TabIndex = 30
        Me.Limit_toggle.Text = "Enable Money Limit"
        Me.Limit_toggle.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DimGray
        Me.Panel3.Controls.Add(Me.AFK_Key)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Time_remaining_Label)
        Me.Panel3.Controls.Add(Me.Keyboard_option)
        Me.Panel3.Location = New System.Drawing.Point(21, 94)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(481, 106)
        Me.Panel3.TabIndex = 31
        '
        'AFK_Key
        '
        Me.AFK_Key.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AFK_Key.Location = New System.Drawing.Point(241, 60)
        Me.AFK_Key.Name = "AFK_Key"
        Me.AFK_Key.Size = New System.Drawing.Size(65, 30)
        Me.AFK_Key.TabIndex = 13
        Me.AFK_Key.Text = "87"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(12, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(223, 25)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Anti-AFK Key To Press:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(24, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(171, 31)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "key settings"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DimGray
        Me.Panel4.Controls.Add(Me.Random_timer_option)
        Me.Panel4.Location = New System.Drawing.Point(21, 269)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(481, 56)
        Me.Panel4.TabIndex = 33
        '
        'Random_timer_option
        '
        Me.Random_timer_option.AutoSize = True
        Me.Random_timer_option.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Random_timer_option.ForeColor = System.Drawing.Color.White
        Me.Random_timer_option.Location = New System.Drawing.Point(9, 12)
        Me.Random_timer_option.Name = "Random_timer_option"
        Me.Random_timer_option.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Random_timer_option.Size = New System.Drawing.Size(225, 29)
        Me.Random_timer_option.TabIndex = 31
        Me.Random_timer_option.Text = "Enable Random Timer"
        Me.Random_timer_option.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(16, 343)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(282, 31)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Fixed Timer Settings"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(15, 213)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(203, 31)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Timer Settings"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(16, 476)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(319, 31)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Random Timer Settings"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Time_Option)
        Me.Panel1.Location = New System.Drawing.Point(21, 393)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(481, 68)
        Me.Panel1.TabIndex = 37
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Random_time_min)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Random_Time_max)
        Me.Panel2.Location = New System.Drawing.Point(21, 516)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(481, 107)
        Me.Panel2.TabIndex = 38
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DimGray
        Me.Panel5.Controls.Add(Me.AFK_Timer)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Location = New System.Drawing.Point(560, 94)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(512, 63)
        Me.Panel5.TabIndex = 39
        '
        'AFK_Timer
        '
        Me.AFK_Timer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AFK_Timer.Location = New System.Drawing.Point(381, 20)
        Me.AFK_Timer.Name = "AFK_Timer"
        Me.AFK_Timer.Size = New System.Drawing.Size(65, 30)
        Me.AFK_Timer.TabIndex = 15
        Me.AFK_Timer.Text = "20"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(14, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(361, 25)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Time Between Key presses in seconds: "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(554, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(340, 31)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "ANTI-AFK timer settings:"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DimGray
        Me.Panel6.Controls.Add(Me.Label13)
        Me.Panel6.Controls.Add(Me.Procces_option)
        Me.Panel6.Controls.Add(Me.Ignore_Option)
        Me.Panel6.Location = New System.Drawing.Point(560, 213)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(512, 146)
        Me.Panel6.TabIndex = 41
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(14, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(232, 25)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Process name to look for:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(554, 170)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(314, 31)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "Kiddion`s Mod Settings"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(554, 384)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(215, 31)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "Money Settings"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DimGray
        Me.Panel7.Controls.Add(Me.Label6)
        Me.Panel7.Controls.Add(Me.Money_Limit_Option)
        Me.Panel7.Controls.Add(Me.Limit_toggle)
        Me.Panel7.Location = New System.Drawing.Point(560, 435)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(512, 98)
        Me.Panel7.TabIndex = 44
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(554, 551)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(230, 31)
        Me.Label17.TabIndex = 45
        Me.Label17.Text = "Overlay Settings"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.DimGray
        Me.Panel8.Controls.Add(Me.Overlay_Option)
        Me.Panel8.Location = New System.Drawing.Point(560, 597)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(512, 72)
        Me.Panel8.TabIndex = 46
        '
        'Overlay_Option
        '
        Me.Overlay_Option.AutoSize = True
        Me.Overlay_Option.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Overlay_Option.ForeColor = System.Drawing.Color.White
        Me.Overlay_Option.Location = New System.Drawing.Point(19, 17)
        Me.Overlay_Option.Name = "Overlay_Option"
        Me.Overlay_Option.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Overlay_Option.Size = New System.Drawing.Size(165, 29)
        Me.Overlay_Option.TabIndex = 30
        Me.Overlay_Option.Text = "Enable Overlay"
        Me.Overlay_Option.UseVisualStyleBackColor = True
        '
        'cancel_button
        '
        Me.cancel_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel_button.Location = New System.Drawing.Point(22, 648)
        Me.cancel_button.Name = "cancel_button"
        Me.cancel_button.Size = New System.Drawing.Size(139, 55)
        Me.cancel_button.TabIndex = 48
        Me.cancel_button.Text = "cancel"
        Me.cancel_button.UseVisualStyleBackColor = True
        '
        'Reset_button
        '
        Me.Reset_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset_button.Location = New System.Drawing.Point(167, 648)
        Me.Reset_button.Name = "Reset_button"
        Me.Reset_button.Size = New System.Drawing.Size(189, 55)
        Me.Reset_button.TabIndex = 49
        Me.Reset_button.Text = "Reset To Default"
        Me.Reset_button.UseVisualStyleBackColor = True
        '
        'Apply_Button
        '
        Me.Apply_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Apply_Button.Location = New System.Drawing.Point(363, 648)
        Me.Apply_Button.Name = "Apply_Button"
        Me.Apply_Button.Size = New System.Drawing.Size(139, 55)
        Me.Apply_Button.TabIndex = 50
        Me.Apply_Button.Text = "Apply"
        Me.Apply_Button.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(965, 680)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 23)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "Debug Screen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1114, 743)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Apply_Button)
        Me.Controls.Add(Me.Reset_button)
        Me.Controls.Add(Me.cancel_button)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.ControlStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Options"
        Me.ShowInTaskbar = False
        Me.ControlStrip.ResumeLayout(False)
        Me.ControlStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ControlStrip As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Time_remaining_Label As Label
    Friend WithEvents Keyboard_option As TextBox
    Friend WithEvents Random_time_min As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Time_Option As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Random_Time_max As TextBox
    Friend WithEvents Procces_option As TextBox
    Friend WithEvents Money_Limit_Option As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Ignore_Option As CheckBox
    Friend WithEvents Limit_toggle As CheckBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents AFK_Key As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents AFK_Timer As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Overlay_Option As CheckBox
    Friend WithEvents cancel_button As Button
    Friend WithEvents Reset_button As Button
    Friend WithEvents Apply_Button As Button
    Friend WithEvents Random_timer_option As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
End Class
