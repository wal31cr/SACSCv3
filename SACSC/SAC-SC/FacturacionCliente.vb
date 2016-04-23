Imports System.Data
Imports System.Data.SqlClient
Public Class FacturacionCliente
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim nombre As String
        Dim cmd As New SqlCommand
        cmd.Connection = Module1.oconexion
        cmd.CommandText = " Select * From dbo.empleado Where id_empleado Like " + "'%" + TextBox1.Text + "%'"
        Dim lrd As SqlDataReader = cmd.ExecuteReader()
        While lrd.Read()
            nombre = lrd("nombre") + " " + lrd("apellidos")
        End While
        TextBox2.Text = nombre
        lrd.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Facturacion.Show()
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Facturacion.Show()
        'Facturacion.TextBox3.Text = TextBox2.Text
        TextBox2.Clear()
        'Verificar si está habilitado
        Dim count As Integer
        Dim total As Integer = 0
        For count = 0 To Facturacion.ListView1.Items.Count - 1
            total += Facturacion.ListView1.Items().Item(count).SubItems(2).Text
        Next
        Dim comd As New SqlCommand("update dbo.empleado set deuda = deuda +" & total & " where id_empleado = '" & Me.TextBox1.Text & "'", oconexion)
        Try
            comd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

        FacturacionFactura.TextBox1.Text = Facturacion.TextBox3.Text
        FacturacionFactura.TextBox2.Text = "Verificar al iniciar sesión"
        FacturacionFactura.TextBox3.Text = "Crédito"
        FacturacionFactura.TextBox4.Text = "¢ " & total
        FacturacionFactura.TextBox5.Text = "Crédito"
        FacturacionFactura.TextBox6.Text = "Crédito"


        Dim Items(Facturacion.ListView1.Items.Count - 1) As ListViewItem
        For i As Integer = 0 To Facturacion.ListView1.Items.Count - 1
            Items(i) = CType(Facturacion.ListView1.Items(i).Clone, ListViewItem)
        Next
        FacturacionFactura.ListView1.Items.AddRange(Items)
        FacturacionFactura.Show()
    End Sub

    Private Sub FacturacionCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class