Imports System.Data
Imports System.Data.SqlClient
Public Class FacturacionFactura
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        FacturacionCliente.TextBox1.Clear()
        Facturacion.ListView1.Items.Clear()
        Facturacion.TextBox4.Clear()
        FacturacionCliente.TextBox2.Clear()

        Dim count As Integer
        For count = 0 To ListView1.Items.Count - 1
            Dim comd As New SqlCommand("update dbo.producto set stock = stock - 1 where id_producto = '" & ListView1.Items().Item(count).Text & "'", oconexion)
            Try
                comd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
            'Revisar stock_min
        Next

        Me.ListView1.Items.Clear()
        MenuPrincipal.Show()
    End Sub

    Private Sub FacturacionFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.GridLines = True
        Me.ListView1.TabIndex = 0
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
End Class