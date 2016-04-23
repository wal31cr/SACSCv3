Public Class AbonosExito
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Abonos.TextBox1.Clear()
        Abonos.TextBox2.Clear()
        Abonos.TextBox3.Clear()
        Abonos.TextBox4.Clear()
        Abonos.TextBox5.Clear()
        Abonos.TextBox6.Clear()
        Abonos.TextBox7.Clear()
        MenuPrincipal.Show()
    End Sub
End Class