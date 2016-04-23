Public Class FacturacionCreditoBloqueado
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Facturacion.Show() 'Abonar
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Facturacion.Show()
    End Sub
End Class