Imports System.Data
Imports System.Data.SqlClient
Public Class Inventario
    Dim sortColumn As Integer = -1
    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.Items.Add("Consumibles")
        ComboBox1.Items.Add("Preparados")
        ComboBox1.Items.Add("Más vendidos")
        ComboBox1.Items.Add("Menos vendidos")
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
        ComboBox1.SelectedIndex = 0
      '  updateProductos("EXEC productos_categorias")
    End Sub
    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        SaveFileDialog1.Filter = "Archivos CSV (*.csv)|*.csv|Todos los archivos (*.*)|*.*"
        SaveFileDialog1.FilterIndex = 1
        SaveFileDialog1.DefaultExt = "csv"
        Dim todaysdate As String = String.Format("{0:dd.MM.yyyy}", DateTime.Now)
        SaveFileDialog1.FileName = Me.Text + todaysdate
        SaveFileDialog1.OverwritePrompt = True
        SaveFileDialog1.Title = "Guardar eventos Google Calendar"
        If SaveFileDialog1.ShowDialog Then
            exportarListViewCSV(ListView1, SaveFileDialog1.FileName)
        End If
    End Sub

    'Exportar contenido ListView a formato CSV 
    'para abrir con Microsoft Office Excel, OppenOffice Calc o con 
    Private Sub exportarListViewCSV(ByVal lstview As ListView, ByVal ficheroCSV As String)
        Dim lineasCSV As New System.Text.StringBuilder
        Dim lineaActual As String = String.Empty

        'Escribir nombre de columnas y encabezados en la variable temporal
        For columnIndex As Int32 = 0 To lstview.Columns.Count - 1
            lineaActual &= (String.Format("{0};", lstview.Columns(columnIndex).Text))
        Next

        'Quitar la coma final
        lineasCSV.AppendLine(lineaActual.Substring(0, lineaActual.Length - 1))
        lineaActual = String.Empty

        'Escribir los datos del ListView en la variable temporal
        For Each item As ListViewItem In lstview.Items
            For Each subItem As ListViewItem.ListViewSubItem In item.SubItems
                lineaActual &= (String.Format("{0};", subItem.Text))
            Next

            'Quitar coma final
            lineasCSV.AppendLine(lineaActual.Substring(0, lineaActual.Length - 1))
            lineaActual = String.Empty
        Next

        'Guardar datos variable temporal a fichero CSV
        Dim Sys As New System.IO.StreamWriter(ficheroCSV)
        Sys.WriteLine(lineasCSV.ToString)
        Sys.Flush()
        Sys.Dispose()
    End Sub
    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        TextBox1.Clear()
        If ComboBox1.SelectedIndex = 0 Then
            updateProductos("EXEC productos_categorias 0,2")
        Else
            updateProductos("EXEC productos_categorias 0, 1")
        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If TextBox1.Text = "" Then
            TextBox1.Text = "Buscar producto"
            If ComboBox1.SelectedIndex = 0 Then
                updateProductos("EXEC productos_categorias 0,2")
            Else
                updateProductos("EXEC productos_categorias 0, 1")
            End If
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
        If ComboBox1.SelectedIndex = 0 Then
            updateProductos("EXEC productos_categorias 0,2")
        Else
            updateProductos("EXEC productos_categorias 0, 1")
        End If
    End Sub
End Class
