Imports System.Data
Imports System.Data.SqlClient

Public Class DistDetalle
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
    Private ID As Integer
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


        Me.lvDetalles.Columns.Add(columnHeader1)
        Me.lvDetalles.Columns.Add(columnHeader2)
        Me.lvDetalles.Columns.Add(columnHeader3)
        Me.lvDetalles.Columns.Add(columnHeader4)
        Me.lvDetalles.Columns.Add(columnHeader5)

        cargarDetalles()
    End Sub
    Private Sub cargarDetalles()
        lvDetalles.Items.Clear()
        Dim fechai As String
        Dim fechaf As String
        fechai = Date_Inicio.Value.ToString("yyyy/MM/dd")
        fechaf = Date_Final.Value.ToString("yyyy/MM/dd")
        Dim query As String = "select c.factura_compra, d.empresa as distribuidor, c.total, c.fecha_compra, c.anotaciones from compra c, distribuidor d where c.distribuidor = d.id_distribuidor and d.id_distribuidor='" & ID & "' and c.fecha_compra between '" & fechai & "' and '" & fechaf & "'"
        Dim fila(5) As String
        Dim comm As New SqlCommand(query, oconexion)
        Dim datar As SqlDataReader
        datar = comm.ExecuteReader()
        While datar.Read()
            fila(0) = Trim(datar("factura_compra"))
            fila(1) = Trim(datar("distribuidor"))
            fila(2) = Trim(datar("total"))
            fila(3) = Date.Parse(Trim(datar("fecha_compra"))).ToString("dd/MM/yyyy")
            fila(4) = Trim(datar("anotaciones"))
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
End Class