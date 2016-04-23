Imports System.Data
Imports System.Data.SqlClient
Public Class Facturacion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MenuPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        FacturacionProducto.Show()
    End Sub

    Sub Facturacion_KeyPress(ByVal sender As Object,
            ByVal e As KeyPressEventArgs) Handles Me.KeyPress

        TextBox5.Text += e.KeyChar.ToString()
        Dim codigo As String = " "
        Dim descripcion As String = " "
        Dim precio As String = " "
        Dim cmd As New SqlCommand
        cmd.Connection = Module1.oconexion
        cmd.CommandText = "select * from dbo.producto where id_producto =" + TextBox5.Text
        Dim lrd As SqlDataReader = cmd.ExecuteReader()
        Dim count As Integer = 0
        While lrd.Read()
            codigo = lrd("id_producto")
            precio = lrd("precio")
            descripcion = lrd("descripcion")
        End While
        lrd.Close()
        updateFactura(codigo, descripcion, precio)
        TextBox5.Clear()
        Dim count2 As Integer
        Dim total As Integer = 0
        For count2 = 0 To ListView1.Items.Count - 1
            total += ListView1.Items().Item(count2).SubItems(2).Text
        Next
        TextBox4.Text = total
    End Sub

    Private Sub Facturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.GridLines = True
        Me.ListView1.TabIndex = 0
        Me.KeyPreview = True
        Me.ListView1.View = System.Windows.Forms.View.Details
        Me.ListView1.MultiSelect = True
        Me.ListView1.HideSelection = False
        ListView1.HeaderStyle = ColumnHeaderStyle.Nonclickable
        Dim columnHeader1 As New ColumnHeader
        With columnHeader1
            .Text = "Código"
            .TextAlign = HorizontalAlignment.Left
            .Width = 130
        End With
        Dim columnHeader2 As New ColumnHeader
        With columnHeader2
            .Text = "Descripción"
            .TextAlign = HorizontalAlignment.Center
            .Width = 142
        End With
        Dim columnHeader3 As New ColumnHeader
        With columnHeader3
            .Text = "Precio(¢)"
            .TextAlign = HorizontalAlignment.Center
            .Width = 142
        End With
        Me.ListView1.Columns.Add(columnHeader1)
        Me.ListView1.Columns.Add(columnHeader2)
        Me.ListView1.Columns.Add(columnHeader3)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        FacturacionCliente.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        FacturacionEfectivo.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Dim count As Integer
        Dim total As Integer = 0
        For count = 0 To Me.ListView1.Items.Count - 1
            total += Me.ListView1.Items().Item(count).SubItems(2).Text
        Next

        FacturacionFactura.TextBox1.Text = Me.TextBox3.Text
        FacturacionFactura.TextBox2.Text = "Verificar al iniciar sesión"
        FacturacionFactura.TextBox3.Text = "Especial"
        FacturacionFactura.TextBox4.Text = "¢ " & total
        FacturacionFactura.TextBox5.Text = "Especial"
        FacturacionFactura.TextBox6.Text = "Especial"

        Dim Items(ListView1.Items.Count - 1) As ListViewItem
        For i As Integer = 0 To ListView1.Items.Count - 1
            Items(i) = CType(ListView1.Items(i).Clone, ListViewItem)
        Next
        FacturacionFactura.ListView1.Items.AddRange(Items)

        FacturacionFactura.Show()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Function updateFactura(codigo As String, descripcion As String, precio As String)
        Dim listItem As New ListViewItem(codigo)
        listItem.SubItems.Add(descripcion)
        listItem.SubItems.Add(precio)
        ListView1.Items.Add(listItem)
        Return 0
    End Function

End Class