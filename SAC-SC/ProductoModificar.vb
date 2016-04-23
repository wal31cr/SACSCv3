Imports System.Data.SqlClient

Public Class ProductoModificar

    Dim sqlCategorias As String = "SELECT codigo_categoria, descripcion FROM dbo.categoria"
    Dim sqlBuscaCategoria As String = "SELECT codigo_categoria  FROM dbo.categoria  WHERE categoria.descripcion = '"
    Dim sqlUpdateProducto As String = "UPDATE dbo.producto SET  descripcion = @descripcion," +
    "precio = @precio, min_stock = @min_stock, categoria = @categoria WHERE id_producto = @id_producto"
    Dim sqlUltimosCostos As String = "	SELECT TOP 2 costo FROM dbo.compra, dbo.detalle_compra " +
                                        "WHERE compra.factura_compra = detalle_compra.compra And " +
                                        "detalle_compra.producto = @id_producto " +
                                        "ORDER BY compra.fecha_compra desc"
    Dim producto As String
    Dim descripcion As String
    Dim precio As String
    Dim minStock As String
    Dim cantidad As String
    Dim categoriaDes As String
    Dim categoriaId As Integer
    Dim flagCambios As Boolean = False

    Public Sub New(producto As String, descripcion As String, precio As String, cantidad As String, minimo As String, categoriaDesc As String)

        Me.producto = producto
        Me.descripcion = descripcion
        Me.precio = precio
        Me.cantidad = cantidad
        Me.minStock = minimo
        Me.categoriaDes = categoriaDesc
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub ProductoModificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_codigoProducto.Text = Me.producto
        TextBox_NombreP.Text = Me.descripcion
        TextBox_stock.Text = Me.cantidad
        TextBox_minStock.Text = Me.minStock
        TextBox_precioVenta.Text = Format(CDbl(Me.precio), "C")
        ultimosCostos()
        TextBox_porcentaje.Text = "25"
        'Falta ponerle el format
        'Label_costo.Text = Format(CDbl(Me.precio), "C")
        'Label_cantidad.Text = Me.cantidad
        'Label_precioSugerido.Text = Format((CDbl(Me.precio) + (CDbl(Me.precio) * 0.2)), "C")
        llenarCategorias()
        categoriaId = buscaCategoria()
        ComboBox_categoria.SelectedIndex = (categoriaId - 1)
        colorearLLenarPrecioSugerido()
        flagCambios = False
        ColorearUltimoCosto()
    End Sub

    Private Function buscaCategoria() As Integer
        Dim cmd As New SqlCommand
        cmd.Connection = Module1.oconexion
        cmd.CommandText = sqlBuscaCategoria + categoriaDes + "'"
        Dim lrd As SqlDataReader = cmd.ExecuteReader()
        If lrd.Read() Then
            Dim id As Integer = CInt(lrd("codigo_categoria"))
            lrd.Close()
            Return id
        End If
        lrd.Close()
        Return -1
    End Function

    Private Sub ultimosCostos()
        Dim cmd As New SqlCommand
        cmd.Connection = Module1.oconexion
        cmd.CommandText = sqlUltimosCostos
        cmd.Parameters.AddWithValue("@id_producto", Me.producto)
        Dim lrd As SqlDataReader = cmd.ExecuteReader()
        If lrd.Read() Then
            TextBox_UltiCompra.Text = Format(CDbl(lrd("costo")), "C")
            If lrd.Read() Then
                TextBox_PenultCompra.Text = Format(CDbl(lrd("costo")), "C")
            Else
                TextBox_PenultCompra.Text = TextBox_UltiCompra.Text
            End If
        Else
            TextBox_UltiCompra.Text = Format(0, "C")
            TextBox_PenultCompra.Text = Format(0, "C")
        End If
        lrd.Close()
    End Sub

    Private Sub llenarCategorias()
        ComboBox_categoria.DropDownStyle = 2
        Dim cmd As New SqlCommand
        cmd.Connection = Module1.oconexion
        cmd.CommandText = sqlCategorias
        Dim lrd As SqlDataReader = cmd.ExecuteReader()
        While lrd.Read()
            ComboBox_categoria.Items.Add(lrd("codigo_categoria") & " - " & lrd("descripcion"))
        End While
        lrd.Close()

    End Sub
    Private Function camposllenos() As Boolean
        Return (TextBox_stock.Text <> "" And TextBox_NombreP.Text <> "" And TextBox_minStock.Text <> "" And TextBox_precioVenta.Text <> "" And ComboBox_categoria.SelectedIndex > -1)
    End Function
    Private Sub Button_guardar_Click(sender As Object, e As EventArgs) Handles Button_guardar.Click
        GuardarCambios()
    End Sub
    Private Sub Button_cancelar_Click(sender As Object, e As EventArgs) Handles Button_cancelar.Click
        MsgBox("No se realizo ningún cambio", MsgBoxStyle.Information)
        Me.Close()
    End Sub
    Private Sub TextBox_minStock_TextChanged(sender As Object, e As EventArgs) Handles TextBox_minStock.TextChanged
        Try
            flagCambios = True
            Dim var As Integer = CInt(TextBox_minStock.Text)
        Catch ex As Exception
            TextBox_minStock.Text = ""
        End Try
    End Sub
    Private Sub TextBox_porcentaje_TextChanged(sender As Object, e As EventArgs) Handles TextBox_porcentaje.TextChanged
        Try
            Dim var As Integer = CInt(TextBox_porcentaje.Text)
            colorearLLenarPrecioSugerido()
        Catch ex As Exception
            TextBox_porcentaje.Text = ""
        End Try
    End Sub
    Private Sub TextBox_precioVenta_TextChanged(sender As Object, e As EventArgs) Handles TextBox_precioVenta.TextChanged
        flagCambios = True
    End Sub
    Private Sub TextBox_NombreP_TextChanged(sender As Object, e As EventArgs) Handles TextBox_NombreP.TextChanged
        flagCambios = True
    End Sub
    Private Sub colorearLLenarPrecioSugerido()
        Dim uCosto As Decimal = CDbl(TextBox_UltiCompra.Text)
        Label_precioSugerido.Text = Format(uCosto + (uCosto * (CDbl(TextBox_porcentaje.Text) / 100)), "C")
        If (CDbl(Label_precioSugerido.Text) > CDbl(TextBox_precioVenta.Text)) Then
            Label_precioSugerido.ForeColor = Color.Red
        Else
            Label_precioSugerido.ForeColor = Color.Black
        End If
    End Sub
    Private Sub GuardarCambios()
        If flagCambios Then
            Dim comd As New SqlCommand(sqlUpdateProducto, oconexion)
            comd.Parameters.AddWithValue("@descripcion", TextBox_NombreP.Text)
            comd.Parameters.AddWithValue("@precio", CDbl(TextBox_precioVenta.Text))
            comd.Parameters.AddWithValue("@min_stock", CInt(TextBox_minStock.Text))
            comd.Parameters.AddWithValue("@categoria", ComboBox_categoria.SelectedIndex + 1)
            comd.Parameters.AddWithValue("@id_producto", Label_codigoProducto.Text)
            Try
                comd.ExecuteNonQuery()
                MsgBox("¡Producto Modificado!", MsgBoxStyle.Exclamation)
                Inventario.updateProductos("EXEC productos_categorias")
                flagCambios = False
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        Else
            MsgBox("No se realizaron cambios", MsgBoxStyle.Information)
            flagCambios = False
            Me.Close()
        End If
    End Sub
    Private Sub ProductosModificar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing
        If flagCambios = True Then
            If (MessageBox.Show(" *Aun no ha guardado los cambios realizados*
          ¿ Desea guardar los cambios ahora? ", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = 1) Then
                GuardarCambios()
            End If
        End If

    End Sub
    Private Sub ColorearUltimoCosto()
        If (CDbl(TextBox_UltiCompra.Text) > CDbl(TextBox_PenultCompra.Text)) Then
            TextBox_UltiCompra.ForeColor = Color.DarkRed
        End If
        If (CDbl(TextBox_UltiCompra.Text) < CDbl(TextBox_PenultCompra.Text)) Then
            TextBox_UltiCompra.ForeColor = Color.DarkGreen
        End If
    End Sub

End Class