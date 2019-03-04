Public Class Overlay
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label2.Text = Form1.Time_label.Text
        Label4.Text = Form1.Sesstion_Money_label.Text
        Label7.Text = Form1.Total_money_label.Text
        Label8.Text = Form1.Money_Remaining.Text

        If Form1.status = True Then
            Label10.Text = "Running"
        Else
            Label10.Text = "Not Running"
        End If



    End Sub

    Private Sub Overlay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class