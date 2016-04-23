Imports System.Data.SqlClient

Public Class ModificarOrdenCliente
    Dim sqlProducto As String = "EXEC productos_categorias @prod "
    Dim sqlOrden As String = "SELECT(empleado.nombre + empleado.apellidos) as vendedor, total FROM dbo.orden, dbo.empleado " +
                               " where orden.num_orden = '@numOrden' and " +
                               " empleado.id_empleado = orden.vendedor"
    Dim sqlDetalles As String = "SELECT producto, producto.descripcion, producto.precio as precio,detalle_orden.cantidad, subtotal " +
                                "FROM dbo.detalle_orden, dbo.producto " +
                                "WHERE detalle_orden.orden = @orden And " +
                                "producto.id_producto = detalle_orden.producto"
    Dim SqlDeleteDetalles As String = "DELETE FROM detalle_orden WHERE detalle_orden.orden = @orden"
    Dim orden_num As String
    Dim cliente As String
    Dim cambiarNombre As Boolean = True
    Dim totalOrden As Decimal = 0
    Dim montoTotal As Decimal = 0
    Dim flagCambios As Boolean = False

    Public Sub New(orden_num As String, cliente As String)
        Me.orden_num = orden_num
        Me.cliente = cliente
        sqlOrden = sqlOrden.Replace("@numOrden", orden_num)
        SqlDeleteDetalles = SqlDeleteDetalles.Replace("@orden", orden_num)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub limpiarCampos()
        cambiarNombre = False
        TextBox_cod.Clear()
        TextBox_NombreP.Clear()
        TextBox_cantidad.Clear()
        'TextBox_costo.Clear()
        'TextBox_totalFSD.Clear()
        'Label_MontoTotalDetalle.Text = ""
        cambiarNombre = True
        'CheckBox_excento.Checked = False
        'cambioPrecio = False

    End Sub
    Private Sub ModificarOrdenCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_orden.Text += Me.orden_num
        Label_cliente.Text = Me.cliente
        inicializarListViewFlotante()
        inicializarListView_Detalles()
        nombreVendedor_Total()
        Label_TotalDetalle.Text = Format(CDbl(Me.montoTotal), "C")
    End Sub

    Private Sub inicializarListViewFlotante()
        ListView_Flotante.Clear()

        ListView_Flotante.GridLines = True
        ListView_Flotante.Activation = ItemActivation.OneClick

        Me.ListView_Flotante.View = System.Windows.Forms.View.Details
        Me.ListView_Flotante.MultiSelect = False
        Me.ListView_Flotante.HideSelection = False
        Me.ListView_Flotante.FullRowSelect = True
        Me.ListView_Flotante.HeaderStyle = ColumnHeaderStyle.Clickable

        Dim columnHeader1 As New ColumnHeader
        With columnHeader1
            .Text = "Codigo"
            .TextAlign = HorizontalAlignment.Center
            .Width = 90
        End With
        Dim columnHeader2 As New ColumnHeader
        With columnHeader2
            .Text = "Producto"
            .TextAlign = HorizontalAlignment.Center
            .Width = 245
        End With

        Me.ListView_Flotante.Columns.Add(columnHeader1)
        Me.ListView_Flotante.Columns.Add(columnHeader2)

    End Sub
    Private Sub inicializarListView_Detalles()
        ListView_Detalles.Clear()

        ListView_Detalles.GridLines = True
        ListView_Detalles.Activation = ItemActivation.OneClick

        Me.ListView_Detalles.TabIndex = 0
        Me.ListView_Detalles.View = System.Windows.Forms.View.Details
        Me.ListView_Detalles.MultiSelect = False
        Me.ListView_Detalles.HideSelection = False
        Me.ListView_Detalles.FullRowSelect = True
        Me.ListView_Detalles.HeaderStyle = ColumnHeaderStyle.Clickable

        Dim columnHeader0 As New ColumnHeader
        With columnHeader0
            .Text = "Codigo"
            .TextAlign = HorizontalAlignment.Left
            .Width = 0
        End With
        Dim columnHeader1 As New ColumnHeader
        With columnHeader1
            .Text = "Nombre"
            .TextAlign = HorizontalAlignment.Left
            .Width = 200
        End With
        Dim columnHeader2 As New ColumnHeader
        With columnHeader2
            .Text = "Precio"
            .TextAlign = HorizontalAlignment.Left
            .Width = 80
        End With
        Dim columnHeader3 As New ColumnHeader
        With columnHeader3
            .Text = "Cantidad"
            .TextAlign = HorizontalAlignment.Left
            .Width = 110
        End With
        Dim columnHeader4 As New ColumnHeader
        With columnHeader4
            .Text = "Total"
            .TextAlign = HorizontalAlignment.Left
            .Width = 110
        End With
        Me.ListView_Detalles.Columns.Add(columnHeader0)
        Me.ListView_Detalles.Columns.Add(columnHeader1)
        Me.ListView_Detalles.Columns.Add(columnHeader2)
        Me.ListView_Detalles.Columns.Add(columnHeader3)
        Me.ListView_Detalles.Columns.Add(columnHeader4)

        cargarDetalles()
    End Sub

    Private Sub nombreVendedor_Total()
        Dim cmd As New SqlCommand
        cmd.Connection = Module1.oconexion
        cmd.CommandText = sqlOrden
        Dim lrd As SqlDataReader = cmd.ExecuteReader()

        If lrd.Read() Then
            totalOrden = CDbl(lrd("total"))
            Label_vendedor.Text = lrd("vendedor")

        End If
        lrd.Close()
        montoTotal = totalOrden
        ' Label_TotalDetalle.Text = Format(montoTotal, "C3")
    End Sub

    Private Sub cargarDetalles()
        Dim id_producto() As String = New String() {" "}
        Dim nombre() As String = New String() {" "}
        Dim precio() As String = New String() {" "}
        Dim cantidad() As String = New String() {""}
        Dim subtotal() As String = New String() {""}


        Dim cmd As New SqlCommand
        cmd.Connection = Module1.oconexion
        sqlDetalles = sqlDetalles.Replace("@orden", Me.orden_num)
        cmd.CommandText = sqlDetalles
        Dim lrd As SqlDataReader = cmd.ExecuteReader()
        Dim count As Integer = 0
        While lrd.Read()
            id_producto(count) = lrd("producto")
            nombre(count) = lrd("descripcion")
            'precio(count) = Format(CDbl(lrd("precio")), "C")
            cantidad(count) = lrd("cantidad")
            subtotal(count) = Format(lrd("subtotal"),"C")
            precio(count) = Format((CDbl(subtotal(count)) / CDbl(cantidad(count))), "C")
            count += 1
            ReDim Preserve id_producto(id_producto.Length)
            ReDim Preserve nombre(nombre.Length)
            ReDim Preserve precio(precio.Length)
            ReDim Preserve cantidad(cantidad.Length)
            ReDim Preserve subtotal(subtotal.Length)

        End While
        lrd.Close()

        Dim count2 As Integer
        For count2 = 0 To id_producto.Length - 2
            Dim listItem As New ListViewItem(id_producto(count2))
            listItem.SubItems.Add(nombre(count2))
            listItem.SubItems.Add(precio(count2))
            listItem.SubItems.Add(cantidad(count2))
            listItem.SubItems.Add(subtotal(count2))
            ListView_Detalles.Items.Add(listItem)
        Next
    End Sub

    Private Sub TextBox_codigoP_TextChanged(sender As Object, e As EventArgs) Handles TextBox_cod.TextChanged
        Dim sqlProductoID As String = "SELECT TOP 1 [descripcion] FROM [SACSC].[dbo].[producto] WHERE producto.id_producto = '" & TextBox_cod.Text & "'"
        cambiarNombre = False
        TextBox_NombreP.Clear()
        Dim cmd As New SqlCommand
        cmd.Connection = Module1.oconexion
        cmd.CommandText = sqlProductoID
        Dim lrd As SqlDataReader = cmd.ExecuteReader()

        If lrd.Read() Then
            cambiarNombre = False
            TextBox_NombreP.Text = lrd("descripcion")
            cambiarNombre = True
            TextBox_NombreP.Enabled = False

        Else
            TextBox_NombreP.Enabled = True
        End If

        lrd.Close()
        cambiarNombre = True

    End Sub

    Private Sub TextBox_NombreP_TextChanged(sender As Object, e As EventArgs) Handles TextBox_NombreP.TextChanged
        If cambiarNombre And TextBox_cod.Text = "" Then
            'ComboBox_tipoFactura.Enabled = False
            Dim sqlProductoNombre As String = "Select id_producto, descripcion From [SACSC].[dbo].[producto] Where producto.descripcion LIKE '%" & TextBox_NombreP.Text & "%'"
            ListView_Detalles.Visible = False
            inicializarListViewFlotante()
            ListView_Flotante.Visible = True
            Dim cmd As New SqlCommand
            cmd.Connection = Module1.oconexion
            cmd.CommandText = sqlProductoNombre
            Dim lrd As SqlDataReader = cmd.ExecuteReader()
            Dim nombre() As String = New String() {" "}
            Dim id_producto() As String = New String() {" "}
            Dim count As Integer = 0

            While lrd.Read()
                nombre(count) = lrd("descripcion")
                id_producto(count) = lrd("id_producto")
                count += 1
                ReDim Preserve nombre(nombre.Length)
                ReDim Preserve id_producto(id_producto.Length)
            End While
            lrd.Close()

            For count2 = 0 To nombre.Length - 1
                Dim listItem As New ListViewItem(id_producto(count2))
                listItem.SubItems.Add(nombre(count2))
                ListView_Flotante.Items.Add(listItem)
            Next
        End If
    End Sub
    Private Sub ListView_Flotante_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView_Flotante.DoubleClick
        Me.cambiarNombre = False
        Dim codigo As String = ListView_Flotante.SelectedItems.Item(0).SubItems(0).Text
        Dim nombre As String = ListView_Flotante.SelectedItems.Item(0).SubItems(1).Text
        TextBox_cod.Text = codigo
        TextBox_NombreP.Text = nombre
        ListView_Flotante.Clear()
        ListView_Flotante.Visible = False
        ListView_Detalles.Visible = True
        TextBox_cantidad.Focus()
        Me.cambiarNombre = True

    End Sub

    Private Sub TextBox_cantidad_TextChanged(sender As Object, e As EventArgs) Handles TextBox_cantidad.TextChanged
        Try
            Dim var As Integer = CInt(TextBox_cantidad.Text)
        Catch ex As Exception
            TextBox_cantidad.Text = ""
        End Try
    End Sub
    Private Function estanLlenosCamposDetalles()
        Return (TextBox_cod.Text <> "" And TextBox_NombreP.Text <> "" And TextBox_cantidad.Text <> "")
    End Function

    Private Sub TextBox_cantidad_keyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox_cantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            If estanLlenosCamposDetalles() Then
                IngresarDatosListViewDetalles()
            End If
        End If
    End Sub


    Private Sub ListView_Flotante_keyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListView_Flotante.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.cambiarNombre = False
            Dim codigo As String = ListView_Flotante.SelectedItems.Item(0).SubItems(0).Text
            Dim nombre As String = ListView_Flotante.SelectedItems.Item(0).SubItems(1).Text
            TextBox_cod.Text = codigo
            TextBox_NombreP.Text = nombre
            ListView_Flotante.Clear()
            ListView_Flotante.Visible = False
            ListView_Detalles.Visible = True
            TextBox_cantidad.Focus()
            Me.cambiarNombre = True
        End If
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        If ListView_Detalles.SelectedItems.Count > 0 Then
            Dim cant As Integer = CInt(ListView_Detalles.SelectedItems.Item(0).SubItems(3).Text)
            Dim precio As Decimal = CDbl(CDbl(ListView_Detalles.SelectedItems.Item(0).SubItems(4).Text))
            TextBox_cantidad.Text = cant
            TextBox_cod.Text = ListView_Detalles.SelectedItems.Item(0).SubItems(0).Text
            TextBox_NombreP.Text = ListView_Detalles.SelectedItems.Item(0).SubItems(1).Text


            montoTotal -= precio
            ListView_Detalles.Items.Remove(ListView_Detalles.SelectedItems.Item(0))
            Label_TotalDetalle.Text = Format(CDbl(montoTotal), "C")
        End If
    End Sub

    Private Sub ListView_Detalles_MouseClick(sender As Object, e As MouseEventArgs) Handles ListView_Detalles.MouseDown
        If ListView_Detalles.Items.Count > 0 Then
            If e.Button = MouseButtons.Right Then
                If ListView_Detalles.FocusedItem.Bounds.Contains(e.Location) = True Then
                    ContextMenuStrip1.Show(Cursor.Position)
                End If
            End If
        End If
    End Sub

    Private Sub IngresarDatosListViewDetalles()

        Me.flagCambios = True
        Dim codigo() As String = New String() {""}
        Dim nombre() As String = New String() {""}
        Dim cantidad() As String = New String() {""}
        Dim total() As String = New String() {""}
        Dim contador As Integer = 0
        Dim precioU() As String = New String() {""}

        codigo(contador) = TextBox_cod.Text()
        nombre(contador) = TextBox_NombreP.Text.ToUpper()
        cantidad(contador) = CInt(TextBox_cantidad.Text)
        'esto esta malo solo coge el producto '
        total(contador) = Format(CDbl(precioProducto(TextBox_cod.Text(), cantidad(0))), "C")
        precioU(contador) = Format(CDbl(precioProducto(TextBox_cod.Text(), 1)), "C")
        montoTotal += total(contador)

        ReDim Preserve codigo(codigo.Length)
        ReDim Preserve nombre(nombre.Length)
        ReDim Preserve cantidad(cantidad.Length)
        ReDim Preserve total(total.Length)
        ReDim Preserve precioU(precioU.Length)

        Dim listItem As New ListViewItem(codigo(0))
        listItem.SubItems.Add(nombre(0))
        listItem.SubItems.Add(precioU(0))
        listItem.SubItems.Add(cantidad(0))
        listItem.SubItems.Add(total(0))
        ListView_Detalles.Items.Add(listItem)
        limpiarCampos()
        TextBox_cod.Focus()
        ListView_Detalles.Visible = True
        Label_TotalDetalle.Text = Format(CDbl(montoTotal), "C")
    End Sub

    Private Function precioProducto(producto As String, cantidad As Integer) As String
        Dim cmd As New SqlCommand
        Dim precio As Decimal = 0
        cmd.Connection = Module1.oconexion
        sqlProducto = sqlProducto.Replace("@prod", producto)
        cmd.CommandText = sqlProducto
        Dim lrd As SqlDataReader = cmd.ExecuteReader()

        If lrd.Read() Then
            precio = Format(CDbl(lrd("precio")), "C")
        End If
        lrd.Close()
        Return (precio * cantidad)
    End Function


    Private Sub ListView_Detalles_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView_Detalles.DoubleClick
        Me.flagCambios = True
        Dim cant As Integer = CInt(ListView_Detalles.SelectedItems.Item(0).SubItems(3).Text)
        Dim precio As Decimal = CDbl(CDbl(ListView_Detalles.SelectedItems.Item(0).SubItems(4).Text))

        montoTotal -= precio
        ListView_Detalles.Items.Remove(ListView_Detalles.SelectedItems.Item(0))
        Label_TotalDetalle.Text = Format(CDbl(montoTotal), "C")
    End Sub

    Private Sub eliminarLista()
        ' For count2 = 0 To (ListView_Detalles.Items.Count - 1)

        Dim comd As New SqlCommand(SqlDeleteDetalles, oconexion)

        Try
            comd.ExecuteNonQuery()
            ' Button_guardar.DialogResult = DialogResult.OK
            ' Me.Close()
            ' Catch exc As SqlException
            'MsgBox("ERROR FATAL ", MsgBoxStyle.Critical)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        ' Next

    End Sub
    Private Sub salvarListaNueva()
        For count2 = 0 To (ListView_Detalles.Items.Count - 1)
            Dim sqlInsertar As String = "INSERT INTO [dbo].[detalle_orden] VALUES (" & Me.orden_num & " , '" & ListView_Detalles.Items(count2).SubItems(0).Text & "' ," & ListView_Detalles.Items(count2).SubItems(3).Text & "," & CDbl(ListView_Detalles.Items(count2).SubItems(4).Text) & " )"
            Dim comd As New SqlCommand(sqlInsertar, oconexion)

            Try
                comd.ExecuteNonQuery()
                ' Button_guardar.DialogResult = DialogResult.OK
                Me.Close()
                ' Catch exc As SqlException
                'MsgBox("ERROR FATAL ", MsgBoxStyle.Critical)

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        Next
    End Sub

    Private Sub Button_guardar_Click(sender As Object, e As EventArgs) Handles Button_guardar.Click
        If flagCambios Then
            eliminarLista()
            salvarListaNueva()
            UsuariosDetalle.Refrescar()
            MsgBox("Se guardaron los cambios", MsgBoxStyle.Information)
            Me.Close()
        Else
            'sagase'
            MsgBox("No se realizaron cambios", MsgBoxStyle.Information)
        End If
    End Sub
End Class