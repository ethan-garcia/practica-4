Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Date_o = DateTime.Now.ToString("dd 'de' MMMM 'del' yyyy")
        Dim Day_o = DateTime.Now.ToString("dddd")
        Dim time_o = DateTime.Now.ToString("HH:mm")

        Dim time_mod = time_o.Split(":")

        Horas.text = time_mod(0)
        Minutos.text = time_mod(1)
        Dia.Text = Day_o
        Fecha.text = Date_o
    End Sub
End Class
