Imports System.Data
Imports System.Data.SqlClient

Public Class DistDetalle
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
    Dim modCompra As New ComprasInventario()
    Private ID As Integer
    Private oldsel As Integer
    Public Sub New(ByVal fila As ListViewItem)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        ID = Val(fila.SubItems(1).Text)
        txtCont.Text = fila.SubItems(3).Text
        txtEmp.Text = fila.SubItems(2).Text
        txtTelf.Text = fila.SubItems(4).Text
        txtDir.Text = fila.SubItems(5).Text
    End Sub

    Private Sub DistDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oldsel = -1
        Date_Final.Value = Today
        Date_Inicio.MaxDate = Today
        Date_Final.MaxDate = Today
        Date_Inicio.Value = Today.AddMonths(-1)
        Date_Inicio.Format = DateTimePickerFormat.Custom
        Date_Inicio.CustomFormat = "dd/MM/yyyy"
        Date_Final.Format = DateTimePickerFormat.Custom
        Date_Final.CustomFormat = "dd/MM/yyyy"

        lvDetalles.GridLines = True
        lvDetalles.Activation = ItemActivation.OneClick
        lvDetalles.MultiSelect = False
        Me.lvDetalles.TabIndex = 0
        Me.lvDetalles.View = System.Windows.Forms.View.Details
        Me.lvDetalles.MultiSelect = False
        Me.lvDetalles.HideSelection = False
        Me.lvDetalles.FullRowSelect = True
        Me.lvDetalles.HeaderStyle = ColumnHeaderStyle.Clickable
        Me.lvDetalles.AllowColumnReorder = True

        Dim columnHeader0 As New ColumnHeader
        With columnHeader0
            .Text = " "
            .TextAlign = HorizontalAlignment.Center
        End With

        Dim columnHeader1 As New ColumnHeader
        With columnHeader1
            .Text = "Factura Compra"
            .TextAlign = HorizontalAlignment.Center
        End With

        Dim columnHeader2 As New ColumnHeader
        With columnHeader2
            .Text = "Distribuidor"
            .TextAlign = HorizontalAlignment.Center

        End With

        Dim columnHeader3 As New ColumnHeader
        With columnHeader3
            .Text = "Total"
            .TextAlign = HorizontalAlignment.Center

        End With
        Dim columnHeader4 As New ColumnHeader
        With columnHeader4
            .Text = "Fecha de Compra"
            .TextAlign = HorizontalAlignment.Left
        End With
        Dim columnHeader5 As New ColumnHeader
        With columnHeader5
            .Text = "Anotaciones"
            .TextAlign = HorizontalAlignment.Left
        End With

        Me.lvDetalles.Columns.Add(columnHeader0)
        Me.lvDetalles.Columns.Add(columnHeader1)
        Me.lvDetalles.Columns.Add(columnHeader2)
        Me.lvDetalles.Columns.Add(columnHeader3)
        Me.lvDetalles.Columns.Add(columnHeader4)
        Me.lvDetalles.Columns.Add(columnHeader5)

        cargarDetalles()
    End Sub
    Public Sub cargarDetalles()
        lvDetalles.Items.Clear()
        Dim fechai As String
        Dim fechaf As String
        fechai = Date_Inicio.Value.ToString("yyyy/MM/dd")
        fechaf = Date_Final.Value.ToString("yyyy/MM/dd")
        Dim query As String = "select c.factura_compra, d.empresa as distribuidor, c.total, c.fecha_compra, c.anotaciones from compra c, distribuidor d where c.distribuidor = d.id_distribuidor and d.id_distribuidor='" & ID & "' and c.fecha_compra between '" & fechai & "' and '" & fechaf & "' order by fecha_compra"
        Dim fila(5) As String
        Dim comm As New SqlCommand(query, oconexion)
        Dim datar As SqlDataReader
        datar = comm.ExecuteReader()
        While datar.Read()
            fila(1) = Trim(datar("factura_compra"))
            fila(2) = Trim(datar("distribuidor"))
            fila(3) = Trim(datar("total"))
            fila(4) = Date.Parse(Trim(datar("fecha_compra"))).ToString("dd/MM/yyyy")
            fila(5) = Trim(datar("anotaciones"))
            lvDetalles.Items.Add(New ListViewItem(fila))
        End While
        datar.Close()

        Me.lvDetalles.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        Me.lvDetalles.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Date_Inicio_ValueChanged(sender As Object, e As EventArgs) Handles Date_Inicio.ValueChanged
        cargarDetalles()
    End Sub

    Private Sub Date_Final_ValueChanged(sender As Object, e As EventArgs) Handles Date_Final.ValueChanged
        cargarDetalles()
    End Sub

    Private Sub lvDetalles_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles lvDetalles.ItemChecked
        For Each item As ListViewItem In Me.lvDetalles.Items
            If item.Checked Then
                If oldsel = -1 Then
                    lvDetalles.Items(item.Index).Selected = True
                    lvDetalles.Select()
                    oldsel = item.Index
                Else
                    If oldsel <> item.Index And oldsel <> -1 Then
                        Dim var = oldsel
                        lvDetalles.Items(var).Checked = False
                        lvDetalles.Items(var).Selected = False
                        lvDetalles.Items(item.Index).Selected = True
                        lvDetalles.Items(item.Index).Selected = True
                        lvDetalles.Select()
                        oldsel = item.Index
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub lvDetalles_DoubleClick(sender As Object, e As EventArgs) Handles lvDetalles.DoubleClick
        Dim cod As String = ""
        If lvDetalles.SelectedItems.Count > 0 Then
            cod = Val(lvDetalles.SelectedItems.Item(0).SubItems(1).Text)
            Dim msgresp As Integer = MsgBox("Esta seguro que desea eliminar este elemento?", MsgBoxStyle.YesNo, "SAC-SC Distribuidores")
            If msgresp = DialogResult.Yes Then
                eliminarElemento(cod)
            Else
                Dim msgModif As Integer = MsgBox("Desea modificar este elemento? (Tenga en cuenta que debera ingresar todos los detalles de nuevo si se requieren)", MsgBoxStyle.YesNo, "SAC-SC Distribuidores")
                If msgModif = DialogResult.Yes Then
                    Dim filaModif As ListViewItem
                    filaModif = lvDetalles.SelectedItems.Item(0)
                    filaModif.SubItems(2).Text = ID
                    modCompra = New ComprasInventario(filaModif)
                    eliminarElemento(cod)
                    modCompra.Show()
                    Me.Close()
                End If
            End If
        Else
            MsgBox("Debe seleccionar una fila primero", MsgBoxStyle.Exclamation, "SAC-SC Distribuidores")
        End If
    End Sub

    Private Sub eliminarElemento(ByVal cod)
        Dim comd As New SqlCommand("delete from dbo.detalle_compra where  compra= '" & cod & "'; delete from dbo.compra where factura_compra= '" & cod & "';", oconexion)
        Try
            comd.ExecuteNonQuery()
            cargarDetalles()
            cod = ""
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Class