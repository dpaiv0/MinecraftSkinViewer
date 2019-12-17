Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim UserChar As String = TextBox1.Text

        PictureBox1.Load("https://minotar.net/armor/body/" & UserChar & "/233.png")
    End Sub
End Class
