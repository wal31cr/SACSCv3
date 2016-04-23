Public Class InventarioCompras

    Private Sub InventarioCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlInventario.BackgroundImage = Image.FromFile(Environment.CurrentDirectory & "\Recursos\inventarios.png")
        Me.Facturacion.BackgroundImage = Image.FromFile(Environment.CurrentDirectory & "\Recursos\compras.png")
        ControlInventario.Focus()

    End Sub


    Private Sub ControlInventario_Click(sender As Object, e As EventArgs) Handles ControlInventario.Click
        Inventario.Show()
        MenuPrincipal.Hide()
        Me.Close()
    End Sub

    Private Sub Facturacion_Click(sender As Object, e As EventArgs) Handles Facturacion.Click
        ComprasInventario.Show()
        MenuPrincipal.Hide()
        Me.Close()
    End Sub
End Class