Imports System.Data.SqlClient

Public Class ProductoModificar

    Dim sqlCategorias As String = "SELECT codigo_categoria, descripcion FROM dbo.categoria"
    Dim sqlBuscaCategoria As String = "SELECT codigo_categoria  FROM dbo.categoria  WHERE categoria.descripcion = '"
    Dim sqlUpdateProducto As String = "UPDATE dbo.producto SET  descripcion = @descripcion," +
    "precio = @precio, min_stock = @min_stock, categoria = @categoria WHERE id_producto = @id_producto"
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
        TextBox_porcentaje.Text = "25"
        'Falta ponerle el format
        'Label_costo.Text = Format(CDbl(Me.precio), "C")
        'Label_cantidad.Text = Me.cantidad
        'Label_precioSugerido.Text = Format((CDbl(Me.precio) + (CDbl(Me.precio) * 0.2)), "C")
        llenarCategorias()
        categoriaId = buscaCategoria()
        ComboBox_categoria.SelectedIndex = (categoriaId - 1)

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
            'ComboBox_categoria.Items.Add(lrd("codigo_categoria"))
        End If
        lrd.Close()
        Return -1
    End Function

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
    'Private Sub TextBox_stock_TextChanged(sender As Object, e As EventArgs) Handles TextBox_stock.TextChanged
    '    Try
    '        Dim var As Integer = CInt(TextBox_stock.Text)
    '    Catch ex As Exception
    '        TextBox_stock.Text = ""
    '    End Try
    'End Sub
    Private Sub TextBox_porcentaje_TextChanged(sender As Object, e As EventArgs) Handles TextBox_porcentaje.TextChanged
        Try
            Dim var As Integer = CInt(TextBox_porcentaje.Text)
        Catch ex As Exception
            TextBox_porcentaje.Text = ""
        End Try
    End Sub

    Private Sub GuardarCambios()

    End Sub

    Private Sub ProductosModificar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing
        If flagCambios = True Then
            If (MessageBox.Show(" *Aun no ha guardado los cambios realizados*
          ¿ Desea guardar los cambios ahora? ", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = 1) Then
                GuardarCambios()
            Else
                'Me.Close()

                'UsuariosDetalle.Show()
            End If
        Else
            'Me.Close()
            'UsuariosDetalle.Show()
        End If

    End Sub

End Class