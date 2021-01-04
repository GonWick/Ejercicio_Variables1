Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Nombre As String
        Nombre = "Brenda"
        LblString.Text = Nombre
        MsgBox(Nombre,, "Nombre")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Edad As Integer
        Edad = 90
        LblInteger.Text = Edad
        MsgBox(Edad,, "Edad")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Estatura As Single
        Estatura = 1.6225
        LblSingle.Text = Estatura
        MsgBox(Estatura,, "Estatura")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Resultado As Boolean
        Resultado = True
        LblBoolean.Text = Resultado
        MsgBox(Resultado,, "Resultado")
    End Sub
End Class
