Public Class FacturacionEfectivo
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Facturacion.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim count As Integer
        Dim total As Integer = 0
        For count = 0 To Facturacion.ListView1.Items.Count - 1
            total += (Facturacion.ListView1.Items().Item(count).SubItems(2).Text * Facturacion.ListView1.Items().Item(count).SubItems(3).Text)
        Next
        If Integer.Parse(Me.TextBox2.Text) >= total Then
            Me.Hide()
            FacturacionFactura.TextBox1.Text = "Contado"
            FacturacionFactura.TextBox2.Text = "Verificar al iniciar sesión"
            FacturacionFactura.TextBox3.Text = "Contado"
            FacturacionFactura.TextBox4.Text = "¢ " & total
            FacturacionFactura.TextBox5.Text = "¢ " & Me.TextBox2.Text
            FacturacionFactura.TextBox6.Text = "¢ " & Me.TextBox2.Text - total
            FacturacionFactura.Show()

            Dim Items(Facturacion.ListView1.Items.Count - 1) As ListViewItem
            For i As Integer = 0 To Facturacion.ListView1.Items.Count - 1
                Items(i) = CType(Facturacion.ListView1.Items(i).Clone, ListViewItem)
            Next
            FacturacionFactura.ListView1.Items.AddRange(Items)

        Else
            MsgBox("Fondos Insuficientes", MsgBoxStyle.Critical, "Efectivo Insuficiente")
            Me.TextBox2.Clear()
        End If
    End Sub

    Private Sub FacturacionEfectivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Facturacion.TextBox4.Text
        TextBox2.Show()
    End Sub

End Class