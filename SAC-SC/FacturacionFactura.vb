Imports System.Data
Imports System.Data.SqlClient
Public Class FacturacionFactura
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
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

        Dim empleado As String
        Dim localDate = Date.Now.ToString("MM-dd-yyyy")
        If TextBox1.Text = "Contado" Then
            empleado = "-1"
        Else
            If TextBox1.Text = "Invitado" Then
                empleado = "-2"
            Else
                empleado = FacturacionCliente.TextBox1.Text
                FacturacionCliente.TextBox1.Clear()
            End If
        End If

        Dim comdo As New SqlCommand("insert into orden (empleado,total,fecha) values (" & empleado & ", 0 ,'" & localDate & "')", oconexion)
        Try
            comdo.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

        Dim count2 As Integer
        For count2 = 0 To ListView1.Items.Count - 1
            Dim comd As New SqlCommand("insert into dbo.detalle_orden values(" & TextBox7.Text & ",'" & ListView1.Items().Item(count2).Text & "'," & ListView1.Items().Item(count2).SubItems(3).Text & "," & ListView1.Items().Item(count2).SubItems(3).Text * ListView1.Items().Item(count2).SubItems(2).Text & ")", oconexion)
            Try
                comd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
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
            .Width = 100
        End With
        Dim columnHeader2 As New ColumnHeader
        With columnHeader2
            .Text = "Descripción"
            .TextAlign = HorizontalAlignment.Center
            .Width = 130
        End With
        Dim columnHeader3 As New ColumnHeader
        With columnHeader3
            .Text = "Precio(¢)"
            .TextAlign = HorizontalAlignment.Center
            .Width = 90
        End With
        Dim columnHeader4 As New ColumnHeader
        With columnHeader4
            .Text = "Cant."
            .TextAlign = HorizontalAlignment.Center
            .Width = 70
        End With
        Me.ListView1.Columns.Add(columnHeader1)
        Me.ListView1.Columns.Add(columnHeader2)
        Me.ListView1.Columns.Add(columnHeader3)
        Me.ListView1.Columns.Add(columnHeader4)
    End Sub
End Class