﻿Imports System.Data
Imports System.Data.SqlClient
Public Class Inventario
    Dim sortColumn As Integer = -1
    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.Items.Add("Mayor existencia")
        ComboBox1.Items.Add("Menor existencia")
        ComboBox1.Items.Add("Más vendidos")
        ComboBox1.Items.Add("Menos vendidos")
        ComboBox1.Items.Add("Más tiempo en bodega")
        ComboBox1.DropDownStyle = 2
        ListView1.GridLines = True
        ListView1.Activation = ItemActivation.OneClick

        Me.ListView1.TabIndex = 0
        Me.ListView1.View = System.Windows.Forms.View.Details
        Me.ListView1.MultiSelect = False
        Me.ListView1.HideSelection = False
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = ColumnHeaderStyle.Clickable
        Me.ListView1.AllowColumnReorder = True

        Dim columnHeader1 As New ColumnHeader
        With columnHeader1
            .Text = "Código"
            .TextAlign = HorizontalAlignment.Center
            .Width = 90
        End With
        Dim columnHeader2 As New ColumnHeader
        With columnHeader2
            .Text = "Nombre"
            .TextAlign = HorizontalAlignment.Left
            .Width = 325
        End With
        Dim columnHeader3 As New ColumnHeader
        With columnHeader3
            .Text = "Precio"
            .TextAlign = HorizontalAlignment.Left
            .Width = 70
        End With
        Dim columnHeader4 As New ColumnHeader
        With columnHeader4
            .Text = "Cantidad Stock"
            .TextAlign = HorizontalAlignment.Left
            .Width = 98
        End With
        Dim columnHeader5 As New ColumnHeader
        With columnHeader5
            .Text = "Cantidad minima"
            .TextAlign = HorizontalAlignment.Left
            .Width = 110
        End With
        Dim columnHeader6 As New ColumnHeader
        With columnHeader6
            .Text = "Categoria"
            .TextAlign = HorizontalAlignment.Center
            .Width = 120
        End With

        Me.ListView1.Columns.Add(columnHeader1)
        Me.ListView1.Columns.Add(columnHeader2)
        Me.ListView1.Columns.Add(columnHeader3)
        Me.ListView1.Columns.Add(columnHeader4)
        Me.ListView1.Columns.Add(columnHeader5)
        Me.ListView1.Columns.Add(columnHeader6)

        updateProductos("EXEC productos_categorias")
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        TextBox1.Clear()
        updateProductos("EXEC productos_categorias")
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If TextBox1.Text = "" Then
            TextBox1.Text = "Buscar producto"
            updateProductos("EXEC productos_categorias ")
        Else
            TextBox1.Text = TextBox1.Text
        End If
    End Sub

    'Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
    '    ' Module2.Id_usuario_Seleccionado = ListView1.SelectedItems.Item(0).SubItems(0).Text
    '    ' Me.Hide()
    '    ' UsuariosDetalle.Show()
    'End Sub

    Private Sub ListView1_ClickColumn(ByVal sender As Object, ByVal e As ColumnClickEventArgs) Handles ListView1.ColumnClick

        If e.Column <> sortColumn Then
            sortColumn = e.Column
            ListView1.Sorting = SortOrder.Ascending
        Else
            If ListView1.Sorting = SortOrder.Ascending Then
                ListView1.Sorting = SortOrder.Descending
            Else
                ListView1.Sorting = SortOrder.Ascending
            End If
        End If
        ListView1.Sort()
        If e.Column = 2 Or e.Column = 3 Or e.Column = 4 Then
            ListView1.ListViewItemSorter = New ListViewItemComparer(e.Column, ListView1.Sorting, False)
        Else
            ListView1.ListViewItemSorter = New ListViewItemComparer(e.Column, ListView1.Sorting, True)
        End If

        'ListView1.ListViewItemSorter = New ListViewItemComparer(e.Column, ListView1.Sorting, True)

    End Sub

    'Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    '    Me.Hide()
    '    InventarioAgregar.Show()
    'End Sub

    Private Sub Btn_menuPrincipal_Click(sender As Object, e As EventArgs) Handles Btn_menuPrincipal.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    Me.Hide()
    '    InventarioModificar.Show()
    'End Sub
    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        'Module2.Id_usuario_Seleccionado = ListView1.SelectedItems.Item(0).SubItems(0).Text
        'Me.Hide()
        Dim codigo As String = ListView1.SelectedItems(0).SubItems(0).Text
        Dim descrip As String = ListView1.SelectedItems(0).SubItems(1).Text
        Dim stock As String = ListView1.SelectedItems.Item(0).SubItems(3).Text
        Dim minStock As String = ListView1.SelectedItems.Item(0).SubItems(4).Text
        Dim precioVenta As String = ListView1.SelectedItems.Item(0).SubItems(2).Text
        Dim categoria As String = ListView1.SelectedItems.Item(0).SubItems(5).Text

        Dim productoF As New ProductoModificar(codigo, descrip, precioVenta, stock, minStock, categoria)
        productoF.Show()

    End Sub

    Sub updateProductos(cmdText As String)
        ListView1.Items.Clear()
        Dim id_producto() As String = New String() {" "}
        Dim nombre() As String = New String() {" "}
        Dim precio() As String = New String() {" "}
        Dim stock() As String = New String() {""}
        Dim minima() As String = New String() {""}
        Dim categoria() As String = New String() {""}

        Dim cmd As New SqlCommand
        cmd.Connection = Module1.oconexion
        cmd.CommandText = cmdText
        Dim lrd As SqlDataReader = cmd.ExecuteReader()
        Dim count As Integer = 0
        While lrd.Read()
            id_producto(count) = lrd("id_producto")
            nombre(count) = lrd("descripcion")
            precio(count) = Format(CDbl(lrd("precio")), "C")
            stock(count) = lrd("stock")
            minima(count) = lrd("min_stock")
            categoria(count) = lrd("descripCategoria")

            count += 1
            ReDim Preserve id_producto(id_producto.Length)
            ReDim Preserve nombre(nombre.Length)
            ReDim Preserve precio(precio.Length)
            ReDim Preserve stock(stock.Length)
            ReDim Preserve minima(minima.Length)
            ReDim Preserve categoria(categoria.Length)

        End While
        lrd.Close()

        Dim count2 As Integer
        For count2 = 0 To id_producto.Length - 2
            Dim listItem As New ListViewItem(id_producto(count2))
            listItem.SubItems.Add(nombre(count2))
            listItem.SubItems.Add(precio(count2))
            listItem.SubItems.Add(stock(count2))
            listItem.SubItems.Add(minima(count2))
            listItem.SubItems.Add(categoria(count2))
            ListView1.Items.Add(listItem)
        Next

        'ColorearFilas()
        'ListView1.AutoResizeColumn(2,
        ' ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub ColorearFilas()
        'For count2 = 0 To ListView1.Items.Count - 1

        '    If ListView1.Items(count2).SubItems(4).Text > (ListView1.Items(count2).SubItems(3).Text * 0.8) Then
        '        ListView1.Items(count2).BackColor = Color.FromArgb(255, 140, 140)
        '    End If

        '    If ListView1.Items(count2).SubItems(4).Text >= ListView1.Items(count2).SubItems(3).Text Then
        '        ListView1.Items(count2).BackColor = Color.FromArgb(165, 20, 20)
        '        ListView1.Items(count2).ForeColor = Color.FromArgb(255, 255, 255)
        '    End If
        'Next
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If TextBox1.Text <> "" And TextBox1.Text <> " " Then
            updateProductos("EXEC productos_categorias '" & TextBox1.Text & "'")
            '    updateUsuarios("SELECT [id_empleado], empleado.[nombre], [apellidos], departamento.[nombre] as departamentos, 
            '                [email], [limite_credito], [deuda] FROM [dbo].[empleado], 
            '                [dbo].departamento  
            '                WHERE empleado.departamento = departamento.id_departamento AND 
            '                (id_empleado Like " + "'%" + TextBox1.Text + "%'" + "or empleado.nombre LIKE" + "'%" + TextBox1.Text + "%')")
        End If
    End Sub

    Private Sub Inventario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing
        Me.Hide()
        MenuPrincipal.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
