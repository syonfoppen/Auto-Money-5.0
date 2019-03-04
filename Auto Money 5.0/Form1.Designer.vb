<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ControlStrip = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MinimizeButton = New System.Windows.Forms.Button()
        Me.Closebutton = New System.Windows.Forms.Button()
        Me.Time_remaining_Label = New System.Windows.Forms.Label()
        Me.Money_added_session_label = New System.Windows.Forms.Label()
        Me.Money_added_total_label = New System.Windows.Forms.Label()
        Me.Remaining_money_label = New System.Windows.Forms.Label()
        Me.Time_label = New System.Windows.Forms.Label()
        Me.Sesstion_Money_label = New System.Windows.Forms.Label()
        Me.Total_money_label = New System.Windows.Forms.Label()
        Me.Money_Remaining = New System.Windows.Forms.Label()
        Me.Fast_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.ToggelButtton = New System.Windows.Forms.Button()
        Me.Option_Button = New System.Windows.Forms.Button()
        Me.Reset_Total_Money = New System.Windows.Forms.Button()
        Me.Reset_Money_This_Session = New System.Windows.Forms.Button()
        Me.Reset_Remaining_Money = New System.Windows.Forms.Button()
        Me.Reset_Timer = New System.Windows.Forms.Button()
        Me.Procces_status_label = New System.Windows.Forms.Label()
        Me.Process_status = New System.Windows.Forms.Label()
        Me.Add_Money_timer = New System.Windows.Forms.Timer(Me.components)
        Me.Random_money_timer = New System.Windows.Forms.Timer(Me.components)
        Me.Every_second_timer = New System.Windows.Forms.Timer(Me.components)
        Me.Anti_afk_timer = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Suspend_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ControlStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ControlStrip
        '
        Me.ControlStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ControlStrip.Controls.Add(Me.PictureBox1)
        Me.ControlStrip.Controls.Add(Me.Label1)
        Me.ControlStrip.Controls.Add(Me.MinimizeButton)
        Me.ControlStrip.Controls.Add(Me.Closebutton)
        Me.ControlStrip.Dock = System.Windows.Forms.DockStyle.Top
        Me.ControlStrip.Location = New System.Drawing.Point(0, 0)
        Me.ControlStrip.Name = "ControlStrip"
        Me.ControlStrip.Size = New System.Drawing.Size(613, 43)
        Me.ControlStrip.TabIndex = 0
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
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(63, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "AUTO MONEY"
        '
        'MinimizeButton
        '
        Me.MinimizeButton.BackgroundImage = Global.Auto_Money_4._0.My.Resources.Resources.minimize_window
        Me.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MinimizeButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.MinimizeButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.MinimizeButton.Location = New System.Drawing.Point(500, 0)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(48, 43)
        Me.MinimizeButton.TabIndex = 1
        Me.MinimizeButton.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.MinimizeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.MinimizeButton.UseVisualStyleBackColor = True
        '
        'Closebutton
        '
        Me.Closebutton.BackgroundImage = Global.Auto_Money_4._0.My.Resources.Resources._52945_200
        Me.Closebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Closebutton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Closebutton.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Closebutton.Location = New System.Drawing.Point(554, 0)
        Me.Closebutton.Name = "Closebutton"
        Me.Closebutton.Size = New System.Drawing.Size(48, 43)
        Me.Closebutton.TabIndex = 0
        Me.Closebutton.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Closebutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Closebutton.UseVisualStyleBackColor = True
        '
        'Time_remaining_Label
        '
        Me.Time_remaining_Label.AutoSize = True
        Me.Time_remaining_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Time_remaining_Label.ForeColor = System.Drawing.Color.White
        Me.Time_remaining_Label.Location = New System.Drawing.Point(12, 57)
        Me.Time_remaining_Label.Name = "Time_remaining_Label"
        Me.Time_remaining_Label.Size = New System.Drawing.Size(159, 25)
        Me.Time_remaining_Label.TabIndex = 3
        Me.Time_remaining_Label.Text = "Time Remaining:"
        '
        'Money_added_session_label
        '
        Me.Money_added_session_label.AutoSize = True
        Me.Money_added_session_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money_added_session_label.ForeColor = System.Drawing.Color.White
        Me.Money_added_session_label.Location = New System.Drawing.Point(12, 94)
        Me.Money_added_session_label.Name = "Money_added_session_label"
        Me.Money_added_session_label.Size = New System.Drawing.Size(260, 25)
        Me.Money_added_session_label.TabIndex = 4
        Me.Money_added_session_label.Text = "Money Added This Session:"
        '
        'Money_added_total_label
        '
        Me.Money_added_total_label.AutoSize = True
        Me.Money_added_total_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money_added_total_label.ForeColor = System.Drawing.Color.White
        Me.Money_added_total_label.Location = New System.Drawing.Point(12, 133)
        Me.Money_added_total_label.Name = "Money_added_total_label"
        Me.Money_added_total_label.Size = New System.Drawing.Size(203, 25)
        Me.Money_added_total_label.TabIndex = 5
        Me.Money_added_total_label.Text = "Money Added In total:"
        '
        'Remaining_money_label
        '
        Me.Remaining_money_label.AutoSize = True
        Me.Remaining_money_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Remaining_money_label.ForeColor = System.Drawing.Color.White
        Me.Remaining_money_label.Location = New System.Drawing.Point(12, 170)
        Me.Remaining_money_label.Name = "Remaining_money_label"
        Me.Remaining_money_label.Size = New System.Drawing.Size(168, 25)
        Me.Remaining_money_label.TabIndex = 6
        Me.Remaining_money_label.Text = "Money remaining:"
        '
        'Time_label
        '
        Me.Time_label.AutoSize = True
        Me.Time_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Time_label.ForeColor = System.Drawing.Color.White
        Me.Time_label.Location = New System.Drawing.Point(177, 57)
        Me.Time_label.Name = "Time_label"
        Me.Time_label.Size = New System.Drawing.Size(106, 25)
        Me.Time_label.TabIndex = 7
        Me.Time_label.Text = "0 Seconds"
        '
        'Sesstion_Money_label
        '
        Me.Sesstion_Money_label.AutoSize = True
        Me.Sesstion_Money_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sesstion_Money_label.ForeColor = System.Drawing.Color.White
        Me.Sesstion_Money_label.Location = New System.Drawing.Point(278, 94)
        Me.Sesstion_Money_label.Name = "Sesstion_Money_label"
        Me.Sesstion_Money_label.Size = New System.Drawing.Size(34, 25)
        Me.Sesstion_Money_label.TabIndex = 8
        Me.Sesstion_Money_label.Text = "$0"
        '
        'Total_money_label
        '
        Me.Total_money_label.AutoSize = True
        Me.Total_money_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_money_label.ForeColor = System.Drawing.Color.White
        Me.Total_money_label.Location = New System.Drawing.Point(221, 133)
        Me.Total_money_label.Name = "Total_money_label"
        Me.Total_money_label.Size = New System.Drawing.Size(34, 25)
        Me.Total_money_label.TabIndex = 9
        Me.Total_money_label.Text = "$0"
        '
        'Money_Remaining
        '
        Me.Money_Remaining.AutoSize = True
        Me.Money_Remaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money_Remaining.ForeColor = System.Drawing.Color.White
        Me.Money_Remaining.Location = New System.Drawing.Point(181, 172)
        Me.Money_Remaining.Name = "Money_Remaining"
        Me.Money_Remaining.Size = New System.Drawing.Size(34, 25)
        Me.Money_Remaining.TabIndex = 10
        Me.Money_Remaining.Text = "$0"
        '
        'Fast_Timer
        '
        '
        'ToggelButtton
        '
        Me.ToggelButtton.BackColor = System.Drawing.Color.Red
        Me.ToggelButtton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ToggelButtton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToggelButtton.ForeColor = System.Drawing.Color.Black
        Me.ToggelButtton.Location = New System.Drawing.Point(414, 267)
        Me.ToggelButtton.Name = "ToggelButtton"
        Me.ToggelButtton.Size = New System.Drawing.Size(188, 48)
        Me.ToggelButtton.TabIndex = 11
        Me.ToggelButtton.Text = "START"
        Me.ToggelButtton.UseVisualStyleBackColor = False
        '
        'Option_Button
        '
        Me.Option_Button.BackColor = System.Drawing.Color.White
        Me.Option_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Option_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Option_Button.ForeColor = System.Drawing.Color.Black
        Me.Option_Button.Location = New System.Drawing.Point(17, 270)
        Me.Option_Button.Name = "Option_Button"
        Me.Option_Button.Size = New System.Drawing.Size(117, 43)
        Me.Option_Button.TabIndex = 12
        Me.Option_Button.Text = "OPTIONS"
        Me.Option_Button.UseVisualStyleBackColor = False
        '
        'Reset_Total_Money
        '
        Me.Reset_Total_Money.BackColor = System.Drawing.Color.White
        Me.Reset_Total_Money.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Reset_Total_Money.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset_Total_Money.ForeColor = System.Drawing.Color.Black
        Me.Reset_Total_Money.Location = New System.Drawing.Point(413, 172)
        Me.Reset_Total_Money.Name = "Reset_Total_Money"
        Me.Reset_Total_Money.Size = New System.Drawing.Size(188, 31)
        Me.Reset_Total_Money.TabIndex = 13
        Me.Reset_Total_Money.Text = "Reset Total Money"
        Me.Reset_Total_Money.UseVisualStyleBackColor = False
        '
        'Reset_Money_This_Session
        '
        Me.Reset_Money_This_Session.BackColor = System.Drawing.Color.White
        Me.Reset_Money_This_Session.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Reset_Money_This_Session.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset_Money_This_Session.ForeColor = System.Drawing.Color.Black
        Me.Reset_Money_This_Session.Location = New System.Drawing.Point(414, 122)
        Me.Reset_Money_This_Session.Name = "Reset_Money_This_Session"
        Me.Reset_Money_This_Session.Size = New System.Drawing.Size(188, 43)
        Me.Reset_Money_This_Session.TabIndex = 14
        Me.Reset_Money_This_Session.Text = "Reset Money This  session"
        Me.Reset_Money_This_Session.UseVisualStyleBackColor = False
        '
        'Reset_Remaining_Money
        '
        Me.Reset_Remaining_Money.BackColor = System.Drawing.Color.White
        Me.Reset_Remaining_Money.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Reset_Remaining_Money.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset_Remaining_Money.ForeColor = System.Drawing.Color.Black
        Me.Reset_Remaining_Money.Location = New System.Drawing.Point(413, 84)
        Me.Reset_Remaining_Money.Name = "Reset_Remaining_Money"
        Me.Reset_Remaining_Money.Size = New System.Drawing.Size(188, 31)
        Me.Reset_Remaining_Money.TabIndex = 15
        Me.Reset_Remaining_Money.Text = "Reset Remaining Money"
        Me.Reset_Remaining_Money.UseVisualStyleBackColor = False
        '
        'Reset_Timer
        '
        Me.Reset_Timer.BackColor = System.Drawing.Color.White
        Me.Reset_Timer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Reset_Timer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset_Timer.ForeColor = System.Drawing.Color.Black
        Me.Reset_Timer.Location = New System.Drawing.Point(414, 48)
        Me.Reset_Timer.Name = "Reset_Timer"
        Me.Reset_Timer.Size = New System.Drawing.Size(188, 31)
        Me.Reset_Timer.TabIndex = 16
        Me.Reset_Timer.Text = "Reset Timer"
        Me.Reset_Timer.UseVisualStyleBackColor = False
        '
        'Procces_status_label
        '
        Me.Procces_status_label.AutoSize = True
        Me.Procces_status_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Procces_status_label.ForeColor = System.Drawing.Color.White
        Me.Procces_status_label.Location = New System.Drawing.Point(12, 229)
        Me.Procces_status_label.Name = "Procces_status_label"
        Me.Procces_status_label.Size = New System.Drawing.Size(207, 25)
        Me.Procces_status_label.TabIndex = 17
        Me.Procces_status_label.Text = "KIddion`s Mod Status:"
        '
        'Process_status
        '
        Me.Process_status.AutoSize = True
        Me.Process_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Process_status.ForeColor = System.Drawing.Color.White
        Me.Process_status.Location = New System.Drawing.Point(225, 230)
        Me.Process_status.Name = "Process_status"
        Me.Process_status.Size = New System.Drawing.Size(34, 25)
        Me.Process_status.TabIndex = 18
        Me.Process_status.Text = "$0"
        '
        'Add_Money_timer
        '
        '
        'Random_money_timer
        '
        '
        'Every_second_timer
        '
        Me.Every_second_timer.Interval = 1000
        '
        'Anti_afk_timer
        '
        Me.Anti_afk_timer.Enabled = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(186, 268)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(188, 48)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Anti AFK: Off"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(413, 212)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(188, 31)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Make Public Solo Sesion"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Suspend_Timer
        '
        Me.Suspend_Timer.Interval = 10000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 20)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Estimated time:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(138, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "0 "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(613, 335)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Process_status)
        Me.Controls.Add(Me.Procces_status_label)
        Me.Controls.Add(Me.Reset_Timer)
        Me.Controls.Add(Me.Reset_Remaining_Money)
        Me.Controls.Add(Me.Reset_Money_This_Session)
        Me.Controls.Add(Me.Reset_Total_Money)
        Me.Controls.Add(Me.Option_Button)
        Me.Controls.Add(Me.ToggelButtton)
        Me.Controls.Add(Me.Money_Remaining)
        Me.Controls.Add(Me.Total_money_label)
        Me.Controls.Add(Me.Sesstion_Money_label)
        Me.Controls.Add(Me.Time_label)
        Me.Controls.Add(Me.Remaining_money_label)
        Me.Controls.Add(Me.Money_added_total_label)
        Me.Controls.Add(Me.Money_added_session_label)
        Me.Controls.Add(Me.Time_remaining_Label)
        Me.Controls.Add(Me.ControlStrip)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ControlStrip.ResumeLayout(False)
        Me.ControlStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ControlStrip As Panel
    Friend WithEvents Closebutton As Button
    Friend WithEvents MinimizeButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Time_remaining_Label As Label
    Friend WithEvents Money_added_session_label As Label
    Friend WithEvents Money_added_total_label As Label
    Friend WithEvents Remaining_money_label As Label
    Friend WithEvents Time_label As Label
    Friend WithEvents Sesstion_Money_label As Label
    Friend WithEvents Total_money_label As Label
    Friend WithEvents Money_Remaining As Label
    Friend WithEvents Fast_Timer As Timer
    Friend WithEvents ToggelButtton As Button
    Friend WithEvents Option_Button As Button
    Friend WithEvents Reset_Total_Money As Button
    Friend WithEvents Reset_Money_This_Session As Button
    Friend WithEvents Reset_Remaining_Money As Button
    Friend WithEvents Reset_Timer As Button
    Friend WithEvents Procces_status_label As Label
    Friend WithEvents Process_status As Label
    Friend WithEvents Add_Money_timer As Timer
    Friend WithEvents Random_money_timer As Timer
    Friend WithEvents Every_second_timer As Timer
    Friend WithEvents Anti_afk_timer As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Suspend_Timer As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
