Imports System.Data.SqlClient

Public Class ComprasInventario
    Dim sql_Distribuidores As String = "SELECT id_distribuidor, empresa FROM dbo.distribuidor ORDER BY id_distribuidor"
    Dim sql_ProductoExistente As String = "Select id_producto FROM dbo.producto WHERE id_producto = '"
    Dim sql_GuardarFac As String = "INSERT INTO dbo.compra(factura_compra, distribuidor, total, fecha_compra, anotaciones) VALUES" +
           " (@factura_compra, @distribuidor, @total , @fecha_compra, @anotaciones)"
    Dim sql_DetallesFac As String = "INSERT INTO dbo.detalle_compra(compra, producto, cantidad, costo) VALUES " +
           " (@compra, @producto, @cantidad, @costo)"
    Dim sql_ultimoCosto = "exec ultimoCosto '"
    Dim cambiarNombre As Boolean = True
    Dim montoTotal As Decimal = 0
    Dim cambioPrecio As Boolean = False
    Dim productoNuevo As Boolean = False
    Dim lockThis As New Object

    'Dim Sql_ProductoID As String = "Select TOP 1 [descripcion] FROM [SACSC].[dbo].[producto] WHERE producto.id_producto = '0000000020'"
    Private Sub ComprasInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarComboBox()
        inicializarFecha()
        inicializarListViewFlotante()
        inicializarListView_Detalles()
    End Sub

    Private Sub llenarComboBox()
        ComboBox_distribuidor.DropDownStyle = 2

        Dim cmd As New SqlCommand
        cmd.Connection = Module1.oconexion
        cmd.CommandText = sql_Distribuidores
        Dim lrd As SqlDataReader = cmd.ExecuteReader()

        While lrd.Read()
            ComboBox_distribuidor.Items.Add(lrd("id_distribuidor") & " " & lrd("empresa"))
        End While
        lrd.Close()

        ComboBox_tipoFactura.DropDownStyle = 2
        ComboBox_tipoFactura.Items.Add("Detallada")
        ComboBox_tipoFactura.Items.Add("Sin detalle")
    End Sub

    Private Sub inicializarFecha()
        Date_Fecha.MaxDate = Date.Today
        Date_Fecha.Format = DateTimePickerFormat.Short
        Date_Fecha.Value = Date.Today
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

        Dim columnHeader1 As New ColumnHeader
        With columnHeader1
            .Text = "Código"
            .TextAlign = HorizontalAlignment.Center
            .Width = 120
        End With
        Dim columnHeader2 As New ColumnHeader
        With columnHeader2
            .Text = "Nombre"
            .TextAlign = HorizontalAlignment.Left
            .Width = 220
        End With
        Dim columnHeader3 As New ColumnHeader
        With columnHeader3
            .Text = "Cantidad"
            .TextAlign = HorizontalAlignment.Left
            .Width = 78
        End With
        Dim columnHeader4 As New ColumnHeader
        With columnHeader4
            .Text = "Precio Unitario"
            .TextAlign = HorizontalAlignment.Left
            .Width = 110
        End With
        Dim columnHeader5 As New ColumnHeader
        With columnHeader5
            .Text = "I.V"
            .TextAlign = HorizontalAlignment.Left
            .Width = 40
        End With
        Dim columnHeader6 As New ColumnHeader
        With columnHeader6
            .Text = "Total"
            .TextAlign = HorizontalAlignment.Left
            .Width = 100
        End With
        Dim columnHeader7 As New ColumnHeader
        With columnHeader7
            .Text = "Total + I.V"
            .TextAlign = HorizontalAlignment.Left
            .Width = 110
        End With


        Me.ListView_Detalles.Columns.Add(columnHeader1)
        Me.ListView_Detalles.Columns.Add(columnHeader2)
        Me.ListView_Detalles.Columns.Add(columnHeader3)
        Me.ListView_Detalles.Columns.Add(columnHeader4)
        Me.ListView_Detalles.Columns.Add(columnHeader6)
        Me.ListView_Detalles.Columns.Add(columnHeader7)
        Me.ListView_Detalles.Columns.Add(columnHeader5)

    End Sub
    Private Sub mostrar_facturaDetallada()
        inicializarListView_Detalles()
        ocultar_facturaSinDetalle()
        Label_CodigoP.Visible = True
        TextBox_codigoP.Visible = True
        Label_NombreP.Visible = True
        TextBox_NombreP.Visible = True
        Label1_cantidad.Visible = True
        TextBox_cantidad.Visible = True
        Label_excento.Visible = True
        CheckBox_excento.Visible = True
        Label_costo.Visible = True

        TextBox_costo.Visible = True
        Label_TotalDetalle.Visible = True
        Label_MontoTotalDetalle.Visible = True
        ListView_Detalles.Visible = True
        Btn_guardarF.Visible = True
    End Sub
    Private Sub ocultar_facturaDetallada()
        ListView_Detalles.Clear()
        ListView_Detalles.Visible = False
        Btn_guardarF.Visible = False
        limpiarFacturaDetalles()
        Label_CodigoP.Visible = False
        TextBox_codigoP.Visible = False
        Label_NombreP.Visible = False
        TextBox_NombreP.Visible = False
        Label1_cantidad.Visible = False
        TextBox_cantidad.Visible = False
        Label_TotalDetalle.Visible = False
        Label_MontoTotalDetalle.Visible = False
        Label_costo.Visible = False
        TextBox_costo.Visible = False
        Label_excento.Visible = False
        CheckBox_excento.Visible = False
        cambioPrecio = False
        productoNuevo = False

    End Sub
    Private Sub mostrar_facturaSinDetalle()
        ocultar_facturaDetallada()
        Label_Descripcion.Visible = True
        TextBox_descripcion.Visible = True
        Label_total_FSD.Visible = True
        TextBox_totalFSD.Visible = True
        Btn_guardarF.Visible = True
    End Sub
    Private Sub ocultar_facturaSinDetalle()
        Label_Descripcion.Visible = False
        TextBox_descripcion.Visible = False
        Label_total_FSD.Visible = False
        TextBox_totalFSD.Visible = False
        TextBox_descripcion.Clear()
        Btn_guardarF.Visible = False
        cambioPrecio = False
    End Sub
    Private Sub limpiar()
        limpiarFacturaDetalles()
        TextBox_descripcion.Clear()
        TextBox_totalFSD.Clear()
    End Sub
    Private Sub limpiarFacturaDetalles()
        cambiarNombre = False
        TextBox_codigoP.Clear()
        TextBox_NombreP.Clear()
        TextBox_cantidad.Clear()
        TextBox_costo.Clear()
        TextBox_totalFSD.Clear()
        Label_MontoTotalDetalle.Text = ""
        cambiarNombre = True
        CheckBox_excento.Checked = False
        cambioPrecio = False

    End Sub
    Private Sub Btn_menuPrincipal_Click(sender As Object, e As EventArgs) Handles Btn_menuPrincipal.Click
        MenuPrincipal.Show()
        Me.Close()
    End Sub
    Private Sub ComprasInventario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing
        MenuPrincipal.Show()
        Me.Hide()
    End Sub
    Private Sub ComboBox_tipoFactura_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_tipoFactura.SelectedIndexChanged
        If ComboBox_tipoFactura.SelectedIndex = 1 Then
            mostrar_facturaSinDetalle()
        Else
            mostrar_facturaDetallada()
            montoTotal = 0
        End If
    End Sub
    Private Sub TextBox_codigoP_TextChanged(sender As Object, e As EventArgs) Handles TextBox_codigoP.TextChanged
        ComboBox_tipoFactura.Enabled = False
        Dim sqlProductoID As String = "SELECT TOP 1 [descripcion] FROM [SACSC].[dbo].[producto] WHERE producto.id_producto = '" & TextBox_codigoP.Text & "'"
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
    Private Sub TextBox_NombreP_Enter(sender As Object, e As EventArgs) Handles TextBox_NombreP.Enter
        TextBox_NombreP.Text = ""
        ListView_Flotante.Clear()
        ListView_Flotante.Visible = False
        ListView_Detalles.Visible = True
    End Sub
    Private Sub TextBox_NombreP_TextChanged(sender As Object, e As EventArgs) Handles TextBox_NombreP.TextChanged
        If cambiarNombre And TextBox_codigoP.Text = "" And TextBox_NombreP.Text <> "" Then
            ComboBox_tipoFactura.Enabled = False
            Dim sqlProductoNombre As String = "Select id_producto, descripcion From [SACSC].[dbo].[producto] Where producto.descripcion LIKE '%" & TextBox_NombreP.Text & "%' AND producto.stock > -1"
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
        Else
            ListView_Flotante.Clear()
            ListView_Flotante.Visible = False
            ListView_Detalles.Visible = True
        End If
    End Sub
    Private Sub ListView_Flotante_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView_Flotante.DoubleClick
        Me.cambiarNombre = False
        Dim codigo As String = ListView_Flotante.SelectedItems.Item(0).SubItems(0).Text
        Dim nombre As String = ListView_Flotante.SelectedItems.Item(0).SubItems(1).Text
        TextBox_codigoP.Text = codigo
        TextBox_descripcion.Text = nombre
        ListView_Flotante.Clear()
        ListView_Flotante.Visible = False
        ListView_Detalles.Visible = True
        TextBox_cantidad.Focus()
        Me.cambiarNombre = True

    End Sub

    'revisaaaar'
    Private Sub ListView_Detalles_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView_Detalles.DoubleClick
        montoTotal -= CDbl(ListView_Detalles.SelectedItems.Item(0).SubItems(4).Text)
        ListView_Detalles.Items.Remove(ListView_Detalles.SelectedItems.Item(0))
        Label_MontoTotalDetalle.Text = Format(CDbl(montoTotal), "C3")
    End Sub
    Private Sub TextBox_costoKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox_costo.KeyDown

        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            If estanLlenosCamposDetalles() Then
                IngresarDatosListViewDetalles()
            End If
        End If
    End Sub
    Private Function encontroProducto(id As String) As Boolean
        Dim cmd As New SqlCommand
        cmd.Connection = Module1.oconexion
        cmd.CommandText = sql_ProductoExistente + id + "'"
        Dim lrd As SqlDataReader = cmd.ExecuteReader()
        Dim count As Integer = 0

        If lrd.Read() Then
            Dim lala As String = IIf(lrd("id_producto") Is DBNull.Value, "vacio", "esta")
            lrd.Close()
            Return (lala.Equals("esta"))
        End If
        lrd.Close()
        Return False

    End Function
    ''
    Private Sub IngresarDatosListViewDetalles()
        Dim codigo() As String = New String() {""}
        Dim nombre() As String = New String() {""}
        Dim cantidad() As String = New String() {""}
        Dim costo() As String = New String() {""}
        Dim contador As Integer = 0
        Dim excento() As String = New String() {""}
        Dim total() As String = New String() {""}
        Dim totalIV() As String = New String() {""}

        codigo(contador) = TextBox_codigoP.Text
        nombre(contador) = TextBox_NombreP.Text.ToUpper()
        cantidad(contador) = CInt(TextBox_cantidad.Text)
        total(contador) = TextBox_costo.Text
        totalIV(contador) = TextBox_costo.Text
        'Dim monto As Decimal = CDbl(TextBox_costo.Text)

        If Not CheckBox_excento.Checked Then
            totalIV(contador) += Math.Round(CDbl(totalIV(contador)) * 0.13, 3)
        End If

        montoTotal += totalIV(contador)
        Dim precio As Decimal = (CDbl(totalIV(contador)) / CDbl(cantidad(contador)))
        costo(contador) = Format(precio, "C3")
        ' costo(contador) = monto
        If CheckBox_excento.Checked Then
            excento(contador) = "E"
        Else
            excento(contador) = "G"
        End If
        '  excento(contador) = CheckBox_excento.Checked

        'contador += 1

        total(contador) = Format(CDbl(total(contador)), "C3")
        totalIV(contador) = Format(CDbl(totalIV(contador)), "C3")
        ReDim Preserve codigo(codigo.Length)
        ReDim Preserve nombre(nombre.Length)
        ReDim Preserve cantidad(cantidad.Length)
        ReDim Preserve costo(costo.Length)
        ReDim Preserve total(total.Length)
        ReDim Preserve totalIV(totalIV.Length)
        ReDim Preserve excento(excento.Length)

        For count2 = 0 To codigo.Length - 2
            Dim listItem As New ListViewItem(codigo(count2))
            listItem.SubItems.Add(nombre(count2))
            listItem.SubItems.Add(cantidad(count2))
            listItem.SubItems.Add(costo(count2))
            listItem.SubItems.Add(total(count2))
            listItem.SubItems.Add(totalIV(count2))
            listItem.SubItems.Add(excento(count2))
            ListView_Detalles.Items.Add(listItem)
        Next
        limpiarFacturaDetalles()
        TextBox_codigoP.Focus()
        ListView_Detalles.Visible = True
        Label_MontoTotalDetalle.Text = Format(CDbl(montoTotal), "C3")
        If Not encontroProducto(codigo(0)) Then
            ListView_Detalles.Items(ListView_Detalles.Items.Count - 1).BackColor = Color.FromArgb(229, 255, 204)
        End If
        If ultimoCostoIgual(codigo(0)) Then
            ListView_Detalles.Items(ListView_Detalles.Items.Count - 1).BackColor = Color.FromArgb(255, 140, 140)
        End If


    End Sub

    Private Function ultimoCostoIgual(id As String)
        Dim cmd As New SqlCommand
        cmd.Connection = Module1.oconexion
        Dim sql As String = sql_ultimoCosto & id & "'"
        cmd.CommandText = sql
        Dim lrd As SqlDataReader = cmd.ExecuteReader()
        If lrd.Read() Then
            Dim costoP As String = IIf(lrd("costo") Is DBNull.Value, "vacio", "esta")
            If (costoP.Equals("esta")) Then
                Dim flag As Boolean = (CDbl(lrd("costo")) < CDbl(ListView_Detalles.Items(ListView_Detalles.Items.Count - 1).Text) Or
                    CDbl(lrd("costo")) > CDbl(ListView_Detalles.Items(ListView_Detalles.Items.Count - 1).Text))
                cambioPrecio = flag
                lrd.Close()
                Return flag
            End If
            lrd.Close()
        End If
        lrd.Close()
        Return False
    End Function

    Private Sub TextBox_cantidad_TextChanged(sender As Object, e As EventArgs) Handles TextBox_cantidad.TextChanged
        Try
            Dim var As Integer = CInt(TextBox_cantidad.Text)
        Catch ex As Exception
            TextBox_cantidad.Text = ""
            ' MsgBox("El campo solo acepta valores numericos", MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub TextBox_costo_TextChanged(sender As Object, e As EventArgs) Handles TextBox_costo.TextChanged
        Try
            Dim var As Integer = CDbl(TextBox_costo.Text)
            'TextBox_costo.Text = Format(CDbl(TextBox_costo.Text), "C")
        Catch ex As Exception
            TextBox_costo.Text = ""
            ' MsgBox("El campo solo acepta valores numericos", MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub TextBox_totalFSD_TextChanged(sender As Object, e As EventArgs) Handles TextBox_totalFSD.TextChanged
        Try
            Dim var As Integer = CDbl(TextBox_totalFSD.Text)
            'TextBox_totalFSD.Text = Format(CDbl(TextBox_totalFSD.Text), "C")
        Catch ex As Exception
            TextBox_totalFSD.Text = ""
            ' MsgBox("El campo solo acepta valores numericos", MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub CheckBox_excento_Leave(sender As Object, e As EventArgs) Handles CheckBox_excento.Leave
        If estanLlenosCamposDetalles() Then
            IngresarDatosListViewDetalles()
        End If
    End Sub
    ' Private Sub TextBox_costo_Leave(sender As Object, e As EventArgs) Handles TextBox_costo.Leave
    'If estanLlenosCamposDetalles() Then
    '       IngresarDatosListViewDetalles()
    'End If
    'End Sub
    Private Function estanLlenosCamposDetalles()
        Return (TextBox_codigoP.Text <> "" And TextBox_NombreP.Text <> "" And TextBox_cantidad.Text <> "" And
                TextBox_costo.Text <> "")

    End Function

    Private Function InformacionFacturaLlena()
        If (ComboBox_tipoFactura.SelectedIndex = 0) Then
            Return (TextBox_factura.Text <> "" And ComboBox_distribuidor.SelectedIndex > -1 And ComboBox_tipoFactura.SelectedIndex > -1 And
                          ListView_Detalles.Items.Count > 0)
        Else
            Return ((TextBox_factura.Text <> "" And ComboBox_distribuidor.SelectedIndex > -1 And ComboBox_tipoFactura.SelectedIndex > -1 And
                TextBox_descripcion.Text <> "" And TextBox_totalFSD.Text <> ""))
        End If
    End Function


    Private Sub guardarProductosNuevos()
        'Dim transaccion1 As SqlTransaction
        Try

            'com1.Connection = Module1.oconexion
            'transaccion1 = com1.Connection.BeginTransaction("SampleTransaction")
            'com1.Transaction = transaccion1
            For count2 = 0 To (ListView_Detalles.Items.Count - 1)
                'Dim com1 As New SqlCommand(sql_DetallesFac, oconexion)
                If (Not (encontroProducto(ListView_Detalles.Items(count2).SubItems(0).Text))) Then

                    SyncLock lockThis
                        Dim desc As String = ListView_Detalles.Items(count2).SubItems(1).Text
                        Dim cogP As String = ListView_Detalles.Items(count2).SubItems(0).Text
                        Dim prec As Decimal = ListView_Detalles.Items(count2).SubItems(3).Text
                        'prec += prec * 0.2
                        Dim cantidad As String = ListView_Detalles.Items(count2).SubItems(2).Text
                        Dim minStock As String = cantidad

                        Dim formM As New nuevoProductoFactura(cogP, desc, prec, cantidad)
                        If (formM.ShowDialog() = DialogResult.OK) Then
                            MsgBox("SI")
                        Else
                            count2 -= 1
                        End If
                        '         Dim insertarProducto As String = "INSERT INTO dbo.producto(id_producto, descripcion, precio, stock, min_stock, categoria) VALUES" +
                        '"(" & cogP & "," & desc & ", " & prec & ", " & cantidad & ", " & minStock & ", " & 1 & ")"

                    End SyncLock
                    'Process(count2)
                    'Dim desc As String = ListView_Detalles.Items(count2).SubItems(1).Text
                    'Dim cogP As String = ListView_Detalles.Items(count2).SubItems(0).Text
                    'Dim prec As String
                    'Dim minStock As String
                    'Dim cantidad As String = ListView_Detalles.Items(count2).SubItems(2).Text

                    'Dim ingresar As New nuevoProductoFactura(cogP, desc, prec, cantidad)
                    'ingresar.Show()




                    '         Dim insertarProducto As String = "INSERT INTO dbo.producto( id_producto, descripcion, precio, stock, min_stock, categoria) VALUES" +
                    '"(" + TextBox_factura.Text +
                    '"," + + "<descripcion, varchar(200),>
                    ',<precio, float,>
                    ',<stock, int,>
                    ',<min_stock, int,>
                    ',<categoria, int,>)"
                    'Else
                    '    Dim com1 As New SqlCommand(sql_DetallesFac, oconexion)
                    '    com1.Parameters.AddWithValue("@compra", TextBox_factura.Text)
                    '    com1.Parameters.AddWithValue("@producto", ListView_Detalles.Items(count2).SubItems(0).Text)
                    '    com1.Parameters.AddWithValue("@cantidad", ListView_Detalles.Items(count2).SubItems(2).Text)
                    '    com1.Parameters.AddWithValue("@costo", CDbl(ListView_Detalles.Items(count2).SubItems(3).Text))
                    '    com1.ExecuteNonQuery()
                End If
            Next
        Catch ex As Exception
            MsgBox("ERROR AL INGRESAR DETALLES DE FACTURA")
            'transaccion1.Rollback()

        End Try
    End Sub

    Private Sub guardarDetallesFactura()
        For count2 = 0 To (ListView_Detalles.Items.Count - 1)
            Dim com1 As New SqlCommand(sql_DetallesFac, oconexion)
            com1.Parameters.AddWithValue("@compra", TextBox_factura.Text)
            com1.Parameters.AddWithValue("@producto", ListView_Detalles.Items(count2).SubItems(0).Text)
            com1.Parameters.AddWithValue("@cantidad", ListView_Detalles.Items(count2).SubItems(2).Text)
            com1.Parameters.AddWithValue("@costo", CDbl(ListView_Detalles.Items(count2).SubItems(3).Text))
            com1.ExecuteNonQuery()
        Next
    End Sub
    Private Sub guardarFactura()
        '@factura_compra, @distribuidor, @total , @fecha_compra, @anotaciones
        Dim comd As New SqlCommand(sql_GuardarFac, oconexion)
        comd.Parameters.AddWithValue("@factura_compra", TextBox_factura.Text)
        comd.Parameters.AddWithValue("@distribuidor", (ComboBox_distribuidor.SelectedIndex + 1))
        comd.Parameters.AddWithValue("@fecha_compra", Date_Fecha.Value)

        'Dim transaccion As SqlTransaction
        'comd.Connection = Module1.oconexion
        'transaccion = comd.Connection.BeginTransaction("SampleTransaction")
        'comd.Transaction = transaccion
        If ComboBox_tipoFactura.SelectedIndex = 0 Then
            comd.Parameters.AddWithValue("@total", montoTotal)
            comd.Parameters.AddWithValue("@anotaciones", "null")
        Else
            comd.Parameters.AddWithValue("@anotaciones", TextBox_descripcion.Text)
            comd.Parameters.AddWithValue("@total", CDbl(TextBox_totalFSD.Text))
        End If
        Try
            comd.ExecuteNonQuery()

        Catch exc As SqlException
            MsgBox("Este numero de factura ya se encuentra registrado en la base de datos ", MsgBoxStyle.Critical)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
    Private Sub Btn_guardarF_Click(sender As Object, e As EventArgs) Handles Btn_guardarF.Click
        If InformacionFacturaLlena() Then
            If ComboBox_tipoFactura.SelectedIndex = 0 Then
                guardarFactura()
                guardarProductosNuevos()
                guardarDetallesFactura()
            Else
                guardarFactura()
            End If


            If cambioPrecio Then
                MsgBox("Los productos resaltados en rojo cambiaron de costo respecto a la ultima compra, por favor" +
                       " revise los precios de venta", MsgBoxStyle.Exclamation)
            End If
            If (MessageBox.Show("¿Desea ingresar otra factura?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
                limpiar()
                ComboBox_tipoFactura.Enabled = True
                ComboBox_tipoFactura.SelectedIndex = -1
                ComboBox_distribuidor.SelectedIndex = -1
                ocultar_facturaDetallada()
                ocultar_facturaSinDetalle()
                inicializarListViewFlotante()
                inicializarListView_Detalles()
                TextBox_factura.Text = ""

            Else
                MenuPrincipal.Show()
                Me.Close()
            End If

        Else
            If ComboBox_tipoFactura.SelectedIndex = 0 Then
                MsgBox("Complete todos los campos solicitados, debe de existir al menos un articulo en la lista de detalles de compra", MsgBoxStyle.Critical)
            Else
                MsgBox("Complete todos los campos solicitados", MsgBoxStyle.Critical)
            End If
        End If

    End Sub
    Private Sub CheckBox_excento_keyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CheckBox_excento.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            If CheckBox_excento.Checked Then
                CheckBox_excento.Checked = False
            Else
                CheckBox_excento.Checked = True
            End If
        End If
    End Sub

    Private Sub ListView_Flotante_keyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListView_Flotante.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.cambiarNombre = False
            Dim codigo As String = ListView_Flotante.SelectedItems.Item(0).SubItems(0).Text
            Dim nombre As String = ListView_Flotante.SelectedItems.Item(0).SubItems(1).Text
            TextBox_codigoP.Text = codigo
            TextBox_descripcion.Text = nombre
            ListView_Flotante.Clear()
            ListView_Flotante.Visible = False
            ListView_Detalles.Visible = True
            TextBox_cantidad.Focus()
            Me.cambiarNombre = True
        End If
    End Sub
    'REVISAR ----------------------------------------------------
    ' -----------------------------------------------------------'
    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        If ListView_Detalles.SelectedItems.Count > 0 Then
            Dim cant As Integer = CInt(ListView_Detalles.SelectedItems.Item(0).SubItems(2).Text)
            Dim preciounitario As Decimal = CDbl(CDbl(ListView_Detalles.SelectedItems.Item(0).SubItems(3).Text))

            TextBox_cantidad.Text = cant
            TextBox_codigoP.Text = ListView_Detalles.SelectedItems.Item(0).SubItems(0).Text
            TextBox_NombreP.Text = ListView_Detalles.SelectedItems.Item(0).SubItems(1).Text
            If ListView_Detalles.SelectedItems.Item(0).SubItems(6).Text = "E" Then
                CheckBox_excento.Checked = True
                ' TextBox_costo.Text = ListView_Detalles.SelectedItems.Item(0).SubItems(5).Text
            Else
                CheckBox_excento.Checked = False
                ' TextBox_costo.Text = (cant * preciounitario) / 1.13
            End If
            TextBox_costo.Text = ListView_Detalles.SelectedItems.Item(0).SubItems(4).Text
            montoTotal -= CDbl(ListView_Detalles.SelectedItems.Item(0).SubItems(5).Text)
            ListView_Detalles.Items.Remove(ListView_Detalles.SelectedItems.Item(0))
            Label_MontoTotalDetalle.Text = Format(CDbl(montoTotal), "C3")
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


End Class