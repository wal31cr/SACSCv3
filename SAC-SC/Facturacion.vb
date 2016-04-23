Imports System.Data
Imports System.Data.SqlClient
Public Class Facturacion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MenuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        FacturacionProducto.Show()
    End Sub

    Sub Texbox5_KeyPress(ByVal sender As Object,
            ByVal e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Dim codigo As String = " "
            Dim descripcion As String = " "
            Dim precio As String = " "
            Dim cmd As New SqlCommand
            cmd.Connection = Module1.oconexion
            cmd.CommandText = "select * from dbo.producto where id_producto = '" + TextBox5.Text + "'"
            Dim lrd As SqlDataReader = cmd.ExecuteReader()
            Dim count As Integer = 0
            While lrd.Read()
                codigo = lrd("id_producto")
                precio = lrd("precio")
                descripcion = lrd("descripcion")
            End While
            lrd.Close()
            Dim count2 As Integer
            Dim total As Integer = 0
            For count2 = 0 To ListView1.Items.Count - 1
                total += (ListView1.Items().Item(count2).SubItems(2).Text * ListView1.Items().Item(count2).SubItems(3).Text)
            Next
            total += precio
            If FacturacionTipo.tipo = "CREDITO" Then
                If total > FacturacionCliente.disponible Then
                    MsgBox("¡Imposible agregar este producto ya que sobrepasa su limite de crédito!", vbCritical, "Límite de crédito excedido")
                    TextBox5.Clear()
                Else
                    updateFactura(codigo, descripcion, precio)
                    TextBox5.Clear()
                    TextBox4.Text = total
                End If
            Else
                updateFactura(codigo, descripcion, precio)
                TextBox5.Clear()
                TextBox4.Text = total
            End If
        End If
    End Sub

    Private Sub Facturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.GridLines = True
        Me.ListView1.TabIndex = 0
        'Me.TextBox5.Focus()
        Me.TextBox5.Select()
        Me.KeyPreview = True
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

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        TextBox4.Text -= CDbl(ListView1.SelectedItems.Item(0).SubItems(2).Text)

        If ListView1.SelectedItems.Item(0).SubItems(3).Text = 1 Then
            ListView1.Items.Remove(ListView1.SelectedItems.Item(0))
        Else
            ListView1.SelectedItems.Item(0).SubItems(3).Text -= 1
        End If

    End Sub

    Function updateFactura(codigo As String, descripcion As String, precio As String)
        Dim flag As Integer = 0
        Dim count As Integer
        For count = 0 To ListView1.Items.Count - 1
            If ListView1.Items().Item(count).Text = codigo Then
                ListView1.Items().Item(count).SubItems(3).Text += 1
                flag = 1
            End If
        Next
        If flag = 0 Then
            Dim listItem As New ListViewItem(codigo)
            listItem.SubItems.Add(descripcion)
            listItem.SubItems.Add(precio)
            listItem.SubItems.Add(1)
            ListView1.Items.Add(listItem)
        End If
        Return 0
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        If FacturacionTipo.tipo = "CREDITO" Then
            Dim count As Integer
            Dim total As Integer = 0
            For count = 0 To ListView1.Items.Count - 1
                total += (ListView1.Items().Item(count).SubItems(2).Text * ListView1.Items().Item(count).SubItems(3).Text)
            Next
            Dim comd As New SqlCommand("update dbo.empleado set deuda = deuda +" & total & " where id_empleado = '" & FacturacionCliente.TextBox1.Text & "'", oconexion)
            Try
                comd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try

            FacturacionFactura.TextBox1.Text = FacturacionCliente.TextBox2.Text
            FacturacionFactura.TextBox2.Text = "Verificar al iniciar sesión"
            FacturacionFactura.TextBox3.Text = "Crédito"
            FacturacionFactura.TextBox4.Text = "¢ " & total
            FacturacionFactura.TextBox5.Text = "Crédito"
            FacturacionFactura.TextBox6.Text = "Crédito"

            FacturacionCliente.TextBox2.Clear()

            Dim Items(ListView1.Items.Count - 1) As ListViewItem
            For i As Integer = 0 To ListView1.Items.Count - 1
                Items(i) = CType(ListView1.Items(i).Clone, ListViewItem)
            Next
            FacturacionFactura.ListView1.Items.AddRange(Items)
            FacturacionFactura.Show()

        ElseIf FacturacionTipo.tipo = "CONTADO" Then
            Me.Hide()
            FacturacionEfectivo.Show()
        Else
            Me.Hide()
            Dim count As Integer
            Dim total As Integer = 0
            For count = 0 To Me.ListView1.Items.Count - 1
                total += Me.ListView1.Items().Item(count).SubItems(2).Text
            Next

            FacturacionFactura.TextBox1.Text = "Invitado"
            FacturacionFactura.TextBox2.Text = "Verificar al iniciar sesión"
            FacturacionFactura.TextBox3.Text = "Invitado"
            FacturacionFactura.TextBox4.Text = "¢ " & total
            FacturacionFactura.TextBox5.Text = "Invitado"
            FacturacionFactura.TextBox6.Text = "Invitado"

            Dim Items(ListView1.Items.Count - 1) As ListViewItem
            For i As Integer = 0 To ListView1.Items.Count - 1
                Items(i) = CType(ListView1.Items(i).Clone, ListViewItem)
            Next
            FacturacionFactura.ListView1.Items.AddRange(Items)

            FacturacionFactura.Show()
        End If
    End Sub
End Class