Imports System.Data
Imports System.Data.SqlClient
Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Globalization
Imports System.Windows.Forms
Public Class FacturacionProducto
    Public codigo As String
    Public descripcion As String
    Public precio As String

    Private Sub FacturacionProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.GridLines = True
        Me.ListView1.TabIndex = 0
        Me.ListView1.View = System.Windows.Forms.View.Details
        Me.ListView1.MultiSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.View = View.Details
        ListView1.HeaderStyle = ColumnHeaderStyle.Nonclickable
        Dim columnHeader1 As New ColumnHeader
        With columnHeader1
            .Text = "Código"
            .TextAlign = HorizontalAlignment.Center
            .Width = ListView1.Width / 2
        End With
        Dim columnHeader2 As New ColumnHeader
        With columnHeader2
            .Text = "Descripción"
            .TextAlign = HorizontalAlignment.Center
            .Width = ListView1.Width / 2
        End With
        Me.ListView1.Columns.Add(columnHeader1)
        Me.ListView1.Columns.Add(columnHeader2)
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        TextBox1.Clear()
    End Sub
    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If TextBox1.Text = "" Then
            TextBox1.Text = "Buscar producto (código/nombre)"
        Else
            TextBox1.Text = TextBox1.Text
        End If
    End Sub

    Function updateProductos(categoria As String)
        ListView1.Items.Clear()
        Dim codigo() As String = New String() {" "}
        Dim descripcion() As String = New String() {" "}
        Dim cmd As New SqlCommand
        cmd.Connection = Module1.oconexion
        cmd.CommandText = "select * from dbo.producto where categoria = " + categoria
        Dim lrd As SqlDataReader = cmd.ExecuteReader()
        Dim count As Integer = 0
        While lrd.Read()
            codigo(count) = lrd("id_producto")
            descripcion(count) = lrd("descripcion")
            count += 1
            ReDim Preserve codigo(codigo.Length)
            ReDim Preserve descripcion(descripcion.Length)
        End While
        lrd.Close()
        Dim count2 As Integer
        For count2 = 0 To codigo.Length - 2
            Dim listItem As New ListViewItem(codigo(count2))
            listItem.SubItems.Add(descripcion(count2))
            ListView1.Items.Add(listItem)
        Next
        Return 0
    End Function

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        ListView1.FullRowSelect = True
        ListView1.HideSelection = False
        If Not ListView1.SelectedItems.Count = 0 Then
            Dim lvi As ListViewItem
            For Each lvi In ListView1.SelectedItems
                lvi.Focused = True
                codigo = ListView1.Items(ListView1.FocusedItem.Index).SubItems(0).Text
                descripcion = ListView1.Items(ListView1.FocusedItem.Index).SubItems(1).Text
                Dim cmd As New SqlCommand
                cmd.Connection = Module1.oconexion
                cmd.CommandText = "select precio from dbo.producto where id_producto = '" + codigo + "'"
                Dim lrd As SqlDataReader = cmd.ExecuteReader()
                Dim count As Integer = 0
                While lrd.Read()
                    precio = lrd("precio")
                End While
                lrd.Close()

                Dim count2 As Integer
                Dim total As Integer = 0
                For count2 = 0 To Facturacion.ListView1.Items.Count - 1
                    total += (Facturacion.ListView1.Items().Item(count2).SubItems(2).Text * Facturacion.ListView1.Items().Item(count2).SubItems(3).Text)
                Next
                total += precio
                If FacturacionTipo.tipo = "CREDITO" Then
                    If total > FacturacionCliente.disponible Then
                        MsgBox("¡Imposible agregar este producto ya que sobrepasa su limite de crédito!", vbCritical, "Límite de crédito excedido")
                    Else
                        Label3.Text = descripcion & " agregado a la factura."
                        Facturacion.updateFactura(codigo, descripcion, precio)
                    End If
                Else
                    Label3.Text = descripcion & " agregado a la factura."
                    Facturacion.updateFactura(codigo, descripcion, precio)
                End If
            Next
        End If
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ListView1.Items.Clear()
        Dim codigo() As String = New String() {" "}
        Dim descripcion() As String = New String() {" "}
        Dim cmd As New SqlCommand
        cmd.Connection = Module1.oconexion
        cmd.CommandText = "select * from dbo.producto Where id_producto Like " + "'%" + TextBox1.Text + "%'" + "or descripcion LIKE" + "'%" + TextBox1.Text + "%'"
        Dim lrd As SqlDataReader = cmd.ExecuteReader()
        Dim count As Integer = 0
        While lrd.Read()
            codigo(count) = lrd("id_producto")
            descripcion(count) = lrd("descripcion")
            count += 1
            ReDim Preserve codigo(codigo.Length)
            ReDim Preserve descripcion(descripcion.Length)
        End While
        lrd.Close()
        Dim count2 As Integer
        For count2 = 0 To codigo.Length - 2
            Dim listItem As New ListViewItem(codigo(count2))
            listItem.SubItems.Add(descripcion(count2))
            ListView1.Items.Add(listItem)
        Next
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Facturacion.TextBox5.Select()
        Me.Hide()
        Dim count As Integer
        Dim total As Integer = 0
        For count = 0 To Facturacion.ListView1.Items.Count - 1
            total += (Facturacion.ListView1.Items().Item(count).SubItems(2).Text * Facturacion.ListView1.Items().Item(count).SubItems(3).Text)
        Next
        Facturacion.TextBox4.Text = total
        Facturacion.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        updateProductos("5")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        updateProductos("1")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        updateProductos("4")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        updateProductos("3")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        updateProductos("2")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        updateProductos("6")
    End Sub
End Class