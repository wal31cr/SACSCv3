Imports System.Data
Imports System.Data.SqlClient
Public Class FacturacionInsertarCodigo
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim count As Integer
        Dim total As Integer = 0
        For count = 0 To Facturacion.ListView1.Items.Count - 1
            total += Facturacion.ListView1.Items().Item(count).SubItems(2).Text
        Next
        Facturacion.TextBox4.Text = total
        Facturacion.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim codigo As String
        codigo = TextBox1.Text
        ' Facturacion.updateFactura()
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub FacturacionInsertarCodigo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim nombre As String
        Dim precio As Integer
        Dim cmd As New SqlCommand
        cmd.Connection = Module1.oconexion
        cmd.CommandText = "Select * From dbo.inventario Where codigo Like " + "'%" + TextBox1.Text + "%'"
        Dim lrd As SqlDataReader = cmd.ExecuteReader()
        While lrd.Read()
            nombre = lrd("nombre")
            precio = lrd("precio")
        End While
        TextBox2.Text = nombre
        TextBox3.Text = precio
        lrd.Close()
    End Sub
End Class