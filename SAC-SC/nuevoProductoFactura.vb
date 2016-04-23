Imports System.Data.SqlClient

Public Class nuevoProductoFactura

    Dim sqlCategorias As String = "SELECT codigo_categoria, descripcion FROM dbo.categoria"
    Dim lockThis As New Object
    Dim producto As String
    Dim descripcion As String
    Dim precio As String
    Dim minStock As String
    Dim cantidad As String

    Public Sub New(producto As String, descripcion As String, precio As String, cantidad As String)

        Me.producto = producto
        Me.descripcion = descripcion
        Me.precio = precio
        Me.cantidad = cantidad
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub nuevoProductoFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SyncLock lockThis
            Label_codigoProducto.Text = Me.producto
            TextBox_NombreP.Text = Me.descripcion
            'Falta ponerle el format
            Label_costo.Text = Format(CDbl(Me.precio), "C")
            Label_cantidad.Text = Me.cantidad
            Label_precioSugerido.Text = Format((CDbl(Me.precio) + (CDbl(Me.precio) * 0.2)), "C")
            llenarCategorias()
        End SyncLock
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
        Return (TextBox_minStock.Text <> "" And TextBox_precioVenta.Text <> "" And ComboBox_categoria.SelectedIndex > -1)
    End Function

    Private Sub Button_guardar_Click(sender As Object, e As EventArgs) Handles Button_guardar.Click

        If camposllenos() Then
            Dim insertarProducto As String = "INSERT INTO dbo.producto(id_producto, descripcion, precio, stock, min_stock, categoria) VALUES" +
                        "( '" & producto & "' ,'" & descripcion & "' , " & CDbl(TextBox_precioVenta.Text) & ", " & cantidad & ", " & TextBox_minStock.Text & ", " & (ComboBox_categoria.SelectedIndex + 1) & ")"
            Dim comd As New SqlCommand(insertarProducto, oconexion)

            Try
                comd.ExecuteNonQuery()
                Button_guardar.DialogResult = DialogResult.OK
                Me.Close()
                ' Catch exc As SqlException
                'MsgBox("ERROR FATAL ", MsgBoxStyle.Critical)

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        Else
            MsgBox("¡Por favor llene los campos correspondientes para continuar!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub TextBox_minStock_TextChanged(sender As Object, e As EventArgs) Handles TextBox_minStock.TextChanged
        Try
            Dim var As Integer = CInt(TextBox_minStock.Text)
        Catch ex As Exception
            TextBox_minStock.Text = ""
        End Try
    End Sub

    Private Sub TextBox_precioVenta_TextChanged(sender As Object, e As EventArgs) Handles TextBox_precioVenta.TextChanged
        Try
            Dim var As Decimal = CDbl(TextBox_precioVenta.Text)
        Catch ex As Exception
            TextBox_precioVenta.Text = ""
        End Try
    End Sub
End Class