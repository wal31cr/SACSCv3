Imports System.Data
Imports System.Data.SqlClient
Public Class Distribuidores
    Dim oldsel As Integer
    Private Sub Distribuidores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lvDistribuidores.GridLines = True
        lvDistribuidores.Activation = ItemActivation.OneClick
        lvDistribuidores.MultiSelect = False
        oldsel = -1
        Me.lvDistribuidores.TabIndex = 0
        Me.lvDistribuidores.View = System.Windows.Forms.View.Details
        Me.lvDistribuidores.MultiSelect = False
        Me.lvDistribuidores.HideSelection = False
        Me.lvDistribuidores.FullRowSelect = True
        Me.lvDistribuidores.HeaderStyle = ColumnHeaderStyle.Clickable
        Me.lvDistribuidores.AllowColumnReorder = True

        Dim columnHeader00 As New ColumnHeader
        With columnHeader00
            .Text = "  "
            .TextAlign = HorizontalAlignment.Center
        End With

        Dim columnHeader0 As New ColumnHeader
        With columnHeader0
            .Text = "ID"
            .TextAlign = HorizontalAlignment.Center

        End With

        Dim columnHeader1 As New ColumnHeader
        With columnHeader1
            .Text = "Empresa"
            .TextAlign = HorizontalAlignment.Center

        End With
        Dim columnHeader2 As New ColumnHeader
        With columnHeader2
            .Text = "Contacto"
            .TextAlign = HorizontalAlignment.Left


        End With
        Dim columnHeader3 As New ColumnHeader
        With columnHeader3
            .Text = "# de Telefono"
            .TextAlign = HorizontalAlignment.Left


        End With
        Dim columnHeader4 As New ColumnHeader
        With columnHeader4
            .Text = "Direccion"
            .TextAlign = HorizontalAlignment.Center

        End With

        Me.lvDistribuidores.Columns.Add(columnHeader00)
        Me.lvDistribuidores.Columns.Add(columnHeader0)
        Me.lvDistribuidores.Columns.Add(columnHeader1)
        Me.lvDistribuidores.Columns.Add(columnHeader2)
        Me.lvDistribuidores.Columns.Add(columnHeader3)
        Me.lvDistribuidores.Columns.Add(columnHeader4)

        Me.lvDistribuidores.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        Me.lvDistribuidores.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        cmbFiltro.Items.Add("")
        cmbFiltro.Items.Add("Contacto")
        cmbFiltro.Items.Add("Empresa")
        cmbFiltro.Items.Add("Telefono")
        cmbFiltro.DropDownStyle = 2

        cargardgv("empresa", "")
    End Sub

    Private Sub cargardgv(col, filtro)
        lvDistribuidores.Items.Clear()
        Dim query As String = "select * from distribuidor where " & col & " like '%" & filtro & "%' order by id_distribuidor"
        Dim fila(5) As String
        Dim comm As New SqlCommand(query, oconexion)
        Dim datar As SqlDataReader
        datar = comm.ExecuteReader()
        While datar.Read()
            fila(1) = Trim(datar("id_distribuidor"))
            fila(2) = Trim(datar("empresa"))
            fila(3) = Trim(datar("contacto"))
            fila(4) = Trim(datar("telefono"))
            fila(5) = Trim(datar("direccion"))
            lvDistribuidores.Items.Add(New ListViewItem(fila))
        End While
        datar.Close()
        Me.lvDistribuidores.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        Me.lvDistribuidores.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub

    Private Sub txtFiltro_GotFocus(sender As Object, e As EventArgs) Handles txtFiltro.GotFocus
        txtFiltro.ForeColor = Color.Black
        txtFiltro.Clear()

    End Sub

    Private Sub txtFiltro_LostFocus(sender As Object, e As EventArgs) Handles txtFiltro.LostFocus
        txtFiltro.ForeColor = Color.Gray
        txtFiltro.Text = "Buscar distribuidor"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If lvDistribuidores.SelectedItems.Count <> 0 Then
            Dim distModif As New DistribuidoresModificar(lvDistribuidores.SelectedItems.Item(0))
            distModif.Show()
            Me.Close()
        Else
            MsgBox("Debe seleccionar una fila primero", MsgBoxStyle.Exclamation, "SAC-SC Distribuidores")
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        DistribuidoresAgregar.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim cod As String = ""
        If lvDistribuidores.SelectedItems.Count > 0 Then
            cod = Val(lvDistribuidores.SelectedItems.Item(0).SubItems(1).Text)
            Dim msgresp As Integer = MsgBox("Esta seguro que desea eliminar este elemento?", MsgBoxStyle.YesNo, "SAC-SC Distribuidores")
            If msgresp = DialogResult.Yes Then

                Dim comd As New SqlCommand("delete from dbo.distribuidor where id_distribuidor = '" & cod & "'", oconexion)
                Try
                    comd.ExecuteNonQuery()
                    cargardgv("empresa", "")
                    cod = ""
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
        Else
            MsgBox("Debe seleccionar una fila primero", MsgBoxStyle.Exclamation, "SAC-SC Distribuidores")
        End If

    End Sub

    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        If Convert.ToInt32(e.KeyChar) = 13 Then
            If cmbFiltro.SelectedIndex > 0 Then
                cargardgv(cmbFiltro.SelectedItem.ToString().ToLower, Trim(txtFiltro.Text))
                lvDistribuidores.Update()
            Else
                MsgBox("Debe seleccionar un elemento de consulta primero.", MsgBoxStyle.Exclamation, "SAC-SC Distribuidores")
            End If
        End If
    End Sub

    Private Sub lvDistribuidores_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles lvDistribuidores.ItemChecked
        For Each item As ListViewItem In Me.lvDistribuidores.Items
            If item.Checked Then
                If oldsel = -1 Then
                    lvDistribuidores.Items(item.Index).Selected = True
                    lvDistribuidores.Select()
                    oldsel = item.Index
                Else
                    If oldsel <> item.Index And oldsel <> -1 Then
                        Dim var = oldsel
                        lvDistribuidores.Items(var).Checked = False
                        lvDistribuidores.Items(var).Selected = False
                        lvDistribuidores.Items(item.Index).Selected = True
                        lvDistribuidores.Items(item.Index).Selected = True
                        lvDistribuidores.Select()
                        oldsel = item.Index
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub lvDistribuidores_DoubleClick(sender As Object, e As EventArgs) Handles lvDistribuidores.DoubleClick
        If lvDistribuidores.SelectedItems.Count <> 0 Then
            Dim distDet As New DistDetalle(lvDistribuidores.SelectedItems.Item(0))
            distDet.Show()
        End If
    End Sub
End Class