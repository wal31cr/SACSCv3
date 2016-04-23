Public Class FacturacionTipo
    Public tipo As String
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tipo = "CREDITO"
        Me.Hide()
        FacturacionCliente.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        tipo = "CONTADO"
        Me.Hide()
        Facturacion.TextBox5.Select()
        'FacturacionEfectivo.TextBox1.Text = TextBox4.Text
        Facturacion.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        tipo = "ESPECIAL"
        Me.Hide()
        Facturacion.TextBox5.Select()
        Facturacion.Show()
    End Sub
End Class