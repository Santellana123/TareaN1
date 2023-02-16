Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As String = NUMERO1.Text
        Dim b As String = NUMERO2.Text
        Dim fechaNacimiento As DateTime
        fechaNacimiento = DateTime.Parse("2003/01/01")
        Dim edad As String = (DateTime.Now.Year - fechaNacimiento.Year)
        MsgBox(a + " " + b + " " + edad)

    End Sub
End Class
