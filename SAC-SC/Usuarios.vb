Imports System.Data
Imports System.Data.SqlClient


Public Class Usuarios
    Dim sortColumn As Integer = -1

    Private sql_abonos_usuario As String = "Select Top 1 abono.fecha as fech FROM dbo.abono WHERE abono.empleado = @usuario ORDER BY fecha desc"
    Private sql_usuarios As String = "SELECT [id_empleado], empleado.[nombre], [apellidos], departamento.[nombre] as departamentos, [email], [limite_credito], [deuda] FROM [dbo].[empleado], [dbo].departamento WHERE empleado.departamento = departamento.id_departamento"

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        TextBox1.Clear()
        updateUsuarios("exec dbo.EmpleadosDepa")
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If TextBox1.Text = "" Then
            TextBox1.Text = "Buscar usuario"
            updateUsuarios("exec dbo.EmpleadosDepa")

        Else
            TextBox1.Text = TextBox1.Text
        End If
    End Sub

    'Private Sub MaskedTextBox1_Enter(sender As Object, e As EventArgs) Handles MaskedTextBox1.Click
    '    MaskedTextBox1.Clear()
    '    MaskedTextBox1.SelectionStart = 0

    '    updateUsuarios("exec dbo.EmpleadosDepa")
    'End Sub



    'Private Sub MaskedTextBox1_Leave(sender As Object, e As EventArgs) Handles MaskedTextBox1.Leave
    '    If MaskedTextBox1.Text = "" Then
    '        MaskedTextBox1.Text = "Buscar usuario"
    '        updateUsuarios("exec dbo.EmpleadosDepa")

    '    Else
    '        MaskedTextBox1.Text = MaskedTextBox1.Text
    '    End If
    'End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        Module2.Id_usuario_Seleccionado = ListView1.SelectedItems.Item(0).SubItems(0).Text
        Me.Hide()
        UsuariosDetalle.Show()
    End Sub

    Private Sub ListView1_ClickColumn(ByVal sender As Object, ByVal e As ColumnClickEventArgs) Handles ListView1.ColumnClick
        If e.Column <> sortColumn Then
            sortColumn = e.Column
            ListView1.Sorting = SortOrder.Ascending
        Else
            If ListView1.Sorting = SortOrder.Ascending Then
                ListView1.Sorting = SortOrder.Descending
            Else
                ListView1.Sorting = SortOrder.Ascending
            End If
        End If
        ListView1.Sort()
        If e.Column = 3 Or e.Column = 4 Then
            ListView1.ListViewItemSorter = New ListViewItemComparer(e.Column, ListView1.Sorting, False)
        Else
            ListView1.ListViewItemSorter = New ListViewItemComparer(e.Column, ListView1.Sorting, True)
        End If


    End Sub


    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.GridLines = True
        ListView1.Activation = ItemActivation.OneClick


        Me.ListView1.TabIndex = 0
        Me.ListView1.View = System.Windows.Forms.View.Details
        Me.ListView1.MultiSelect = False
        Me.ListView1.HideSelection = False
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = ColumnHeaderStyle.Clickable
        Me.ListView1.AllowColumnReorder = True


        Dim columnHeader1 As New ColumnHeader
        With columnHeader1
            .Text = "Identificación"
            .TextAlign = HorizontalAlignment.Center
            .Width = 100
        End With
        Dim columnHeader2 As New ColumnHeader
        With columnHeader2
            .Text = "Nombre"
            .TextAlign = HorizontalAlignment.Left
            .Width = 200
        End With
        Dim columnHeader3 As New ColumnHeader
        With columnHeader3
            .Text = "Departamento"
            .TextAlign = HorizontalAlignment.Left
            .Width = 200
        End With
        Dim columnHeader4 As New ColumnHeader
        With columnHeader4
            .Text = "Último pago"
            .TextAlign = HorizontalAlignment.Center
            .Width = 100
        End With

        Dim columnHeader5 As New ColumnHeader
        With columnHeader5
            .Text = "Limite"
            .TextAlign = HorizontalAlignment.Center
            .Width = 100
        End With

        Dim columnHeader6 As New ColumnHeader
        With columnHeader6
            .Text = "Deuda"
            .TextAlign = HorizontalAlignment.Center
            .Width = 140
        End With
        Dim columnHeader7 As New ColumnHeader
        With columnHeader7
            .Text = "Estado"
            .TextAlign = HorizontalAlignment.Center
            .Width = 100
        End With
        Dim columnHeader8 As New ColumnHeader
        With columnHeader8
            .Text = "Email"
            .TextAlign = HorizontalAlignment.Left
            .Width = 200
        End With
        Me.ListView1.Columns.Add(columnHeader1)
        Me.ListView1.Columns.Add(columnHeader2)
        Me.ListView1.Columns.Add(columnHeader4)
        Me.ListView1.Columns.Add(columnHeader5)
        Me.ListView1.Columns.Add(columnHeader6)
        Me.ListView1.Columns.Add(columnHeader7)
        Me.ListView1.Columns.Add(columnHeader3)
        Me.ListView1.Columns.Add(columnHeader8)
        updateUsuarios(sql_usuarios)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_menuPrincipal.Click
        MenuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Btn_agregar.Click
        Me.Hide()
        UsuariosAgregar.Show()
    End Sub

    Function updateUsuarios(cmdText As String)
        ListView1.Items.Clear()
        Dim id_empleado() As String = New String() {" "}
        Dim nombre() As String = New String() {" "}
        Dim apellidos() As String = New String() {" "}
        Dim departamento() As String = New String() {""}
        Dim deuda() As String = New String() {""} 'deuda = limite_credito -disponible_credito"
        Dim limite_credito() As String = New String() {""}
        'Dim disponible_credito() As Decimal = New Decimal() {0}
        Dim ultimo_pago() As String = New String() {" "}
        Dim estado() As String = New String() {"BLOCK"}
        Dim cmd As New SqlCommand
        Dim email() As String = New String() {""}

        cmd.Connection = Module1.oconexion
        cmd.CommandText = cmdText
        Dim lrd As SqlDataReader = cmd.ExecuteReader()
        Dim count As Integer = 0
        While lrd.Read()
            id_empleado(count) = lrd("id_empleado")
            nombre(count) = lrd("nombre") + "  " + lrd("apellidos")
            departamento(count) = lrd("departamentos")
            limite_credito(count) = Format(CDbl(lrd("limite_credito")), "C")
            deuda(count) = Format(CDbl(lrd("deuda")), "C")
            email(count) = lrd("email")

            If deuda(count) < CDbl(limite_credito(count)) Then
                estado(count) = "Habilitado"
            Else
                estado(count) = "Bloqueado"
            End If



            count += 1
            ReDim Preserve id_empleado(id_empleado.Length)
            ReDim Preserve nombre(nombre.Length)
            ReDim Preserve deuda(deuda.Length)
            ReDim Preserve ultimo_pago(ultimo_pago.Length)
            ReDim Preserve limite_credito(limite_credito.Length)
            ReDim Preserve estado(estado.Length)
            ReDim Preserve departamento(departamento.Length)
            ReDim Preserve email(email.Length)

        End While
        lrd.Close()

        Dim count2 As Integer
        For count2 = 0 To id_empleado.Length - 2
            Dim pago As String = ""
            Dim comando As New SqlCommand
            comando.Connection = Module1.oconexion
            'Dim lala As String = id_empleado(count2)
            comando.Parameters.AddWithValue("@usuario", id_empleado(count2))
            comando.CommandText = sql_abonos_usuario
            Dim lrd2 As SqlDataReader = comando.ExecuteReader()
            If lrd2.Read() Then
                pago = lrd2("fech")
            Else
                pago = "Sin Pagos"

            End If
            lrd2.Close()
            ultimo_pago(count2) = pago
        Next

        For count2 = 0 To id_empleado.Length - 2
            Dim listItem As New ListViewItem(id_empleado(count2))
            listItem.SubItems.Add(nombre(count2))
            listItem.SubItems.Add(ultimo_pago(count2))
            listItem.SubItems.Add(limite_credito(count2))
            listItem.SubItems.Add(deuda(count2))
            listItem.SubItems.Add(estado(count2))
            listItem.SubItems.Add(departamento(count2))
            listItem.SubItems.Add(email(count2))
            ListView1.Items.Add(listItem)


        Next
        ColorearFilas()
        ListView1.AutoResizeColumn(2,
        ColumnHeaderAutoResizeStyle.HeaderSize)
        Return 0

    End Function

    Private Sub ColorearFilas()
        For count2 = 0 To ListView1.Items.Count - 1
            If CDbl(ListView1.Items(count2).SubItems(4).Text) > (CDbl(ListView1.Items(count2).SubItems(3).Text) * 0.8) Then
                ListView1.Items(count2).BackColor = Color.FromArgb(255, 140, 140)
            End If
            If CDbl(ListView1.Items(count2).SubItems(4).Text) >= CDbl(ListView1.Items(count2).SubItems(3).Text) Then
                ListView1.Items(count2).BackColor = Color.FromArgb(165, 20, 20)
                ListView1.Items(count2).ForeColor = Color.FromArgb(255, 255, 255)
            End If
        Next
    End Sub

    Private Function ultimo_abono(cedula As String)
        Dim pago As String = ""
        Dim comando As New SqlCommand
        comando.Connection = Module1.oconexion
        comando.CommandText = sql_abonos_usuario
        comando.Parameters.AddWithValue("@usuario", cedula)
        Dim lrd2 As SqlDataReader = comando.ExecuteReader()
        lrd2.Read()
        pago = lrd2("fecha")
        If pago = "" Then
            pago = "Sin Pagos"
        End If
        lrd2.Close()
        Return pago
    End Function

    Private Sub Btn_eliminar_Click(sender As Object, e As EventArgs) Handles Btn_eliminar.Click
        Dim id_empleado As String = ListView1.Items(ListView1.FocusedItem.Index).SubItems(0).Text
        Dim nombre_empleado As String = ListView1.Items(ListView1.FocusedItem.Index).SubItems(1).Text
        Dim comd As New SqlCommand("delete from dbo.empleado where id_empleado = '" & id_empleado & "'", oconexion)
        Dim cmd1 As New SqlCommand("SELECT deuda FROM dbo.empleado WHERE id_empleado = '" & id_empleado & "' ", oconexion)
        Try
            If (MessageBox.Show("Se eliminaran todos los datos del usuario " &
                               nombre_empleado, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = 1) Then

                ' Buscar empleado que se va a borrar, si tiene deuda, enviar mensaje de que se eliminara a <nombre> que tiene una deuda de <deuda>
                ' aceptar/cancelar.
                Dim ldr As SqlDataReader = cmd1.ExecuteReader()
                ldr.Read()
                Dim deuda As Decimal = ldr("deuda")
                ldr.Close()
                If deuda > 0 Then
                    If (MessageBox.Show(nombre_empleado & "  posee una deuda de " & Format(CDbl(deuda), "C") & " la cual se perdera si elimina el usuario ", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) = 1) Then
                        comd.ExecuteNonQuery()
                        updateUsuarios(sql_usuarios)
                    End If
                Else
                    comd.ExecuteNonQuery()
                    updateUsuarios(sql_usuarios)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try


        '      updateUsuarios("SELECT [id_empleado]
        '    ,empleado.[nombre]
        '    ,[apellidos]
        '    ,departamento.[nombre] as departamentos
        '    ,[email]
        '    ,[limite_credito]
        '    ,[deuda]
        'FROM [dbo].[empleado], [dbo].departamento
        'WHERE empleado.departamento = departamento.id_departamento")
    End Sub

    Private Function casillaChekeada() As Boolean
        For i = 0 To ListView1.Items.Count - 1 ' Count entrega la de Items que tiene el control
            If ListView1.Items(i).Checked Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Enviar_correo.Click

        If casillaChekeada() Then
            Dim enviar As New EnviarCorreo(Correos())
            enviar.ShowDialog()
        End If

    End Sub

    Public Function Correos() As DataTable

        Dim dt As DataTable = New DataTable()
        dt.Columns.Add("Nombre")
        dt.Columns.Add("Email")
        dt.Columns.Add("Deuda")
        dt.Columns.Add("Limite")
        dt.Columns.Add("Estado")


        For count = 0 To ListView1.Items.Count - 1
            If ListView1.Items(count).Checked Then
                Dim Renglon As DataRow = dt.NewRow()
                Renglon("Nombre") = ListView1.Items(count).SubItems(1).Text
                Renglon("Email") = ListView1.Items(count).SubItems(7).Text
                Renglon("Deuda") = ListView1.Items(count).SubItems(4).Text
                Renglon("Limite") = ListView1.Items(count).SubItems(3).Text
                Renglon("Estado") = ListView1.Items(count).SubItems(5).Text
                dt.Rows.Add(Renglon)
            End If
        Next
        Return dt
        'foreach(ListViewItem item In lvVentas.Items)
        '    {
        '        dt.Rows.Add(New Object[] { item.SubItems[2], item.SubItems[1].Text, item.SubItems[3].Text });

        '    }
        '    Return dt;
    End Function
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If TextBox1.Text <> "" And TextBox1.Text <> " " Then
            updateUsuarios("SELECT [id_empleado], empleado.[nombre], [apellidos], departamento.[nombre] as departamentos, 
                        [email], [limite_credito], [deuda] FROM [dbo].[empleado], 
                        [dbo].departamento  
                        WHERE empleado.departamento = departamento.id_departamento AND 
                        (id_empleado Like " + "'%" + TextBox1.Text + "%'" + "or empleado.nombre LIKE" + "'%" + TextBox1.Text + "%')")
        End If
    End Sub

    Private Sub Usuarios_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing
        Me.Hide()
        MenuPrincipal.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim seleccionar As Boolean = CheckBox1.Checked
        For i = 0 To ListView1.Items.Count - 1
            ListView1.Items(i).Checked = seleccionar
        Next
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        SaveFileDialog1.Filter = "Archivos CSV (*.csv)|*.csv|Todos los archivos (*.*)|*.*"
        SaveFileDialog1.FilterIndex = 1
        SaveFileDialog1.DefaultExt = "csv"
        Dim todaysdate As String = String.Format("{0:dd.MM.yyyy}", DateTime.Now)
        SaveFileDialog1.FileName = Me.Text + todaysdate
        SaveFileDialog1.OverwritePrompt = True
        SaveFileDialog1.Title = "Guardar eventos Google Calendar"
        If SaveFileDialog1.ShowDialog Then
            exportarListViewCSV(ListView1, SaveFileDialog1.FileName)
        End If
    End Sub

    'Exportar contenido ListView a formato CSV 
    'para abrir con Microsoft Office Excel, OppenOffice Calc o con 
    Private Sub exportarListViewCSV(ByVal lstview As ListView, ByVal ficheroCSV As String)
        Dim lineasCSV As New System.Text.StringBuilder
        Dim lineaActual As String = String.Empty

        'Escribir nombre de columnas y encabezados en la variable temporal
        For columnIndex As Int32 = 0 To lstview.Columns.Count - 1
            lineaActual &= (String.Format("{0};", lstview.Columns(columnIndex).Text))
        Next

        'Quitar la coma final
        lineasCSV.AppendLine(lineaActual.Substring(0, lineaActual.Length - 1))
        lineaActual = String.Empty

        'Escribir los datos del ListView en la variable temporal
        For Each item As ListViewItem In lstview.Items
            For Each subItem As ListViewItem.ListViewSubItem In item.SubItems
                lineaActual &= (String.Format("{0};", subItem.Text))
            Next

            'Quitar coma final
            lineasCSV.AppendLine(lineaActual.Substring(0, lineaActual.Length - 1))
            lineaActual = String.Empty
        Next

        'Guardar datos variable temporal a fichero CSV
        Dim Sys As New System.IO.StreamWriter(ficheroCSV)
        Sys.WriteLine(lineasCSV.ToString)
        Sys.Flush()
        Sys.Dispose()
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        'Release an automation object
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

End Class

Class ListViewItemComparer
    Implements IComparer
    Private col As Integer
    Private order As SortOrder
    Private isString As Boolean
    Public Sub New()
        col = 0
        order = SortOrder.Ascending
    End Sub

    Public Sub New(column As Integer, order As SortOrder, isStrg As Boolean)
        col = column
        Me.order = order
        Me.isString = isStrg
    End Sub

    Public Function Compare(x As Object, y As Object) As Integer _
                        Implements System.Collections.IComparer.Compare
        Dim returnVal As Integer = -1

        If isString Then
            returnVal = [String].Compare(CType(x,
                       ListViewItem).SubItems(col).Text,
                       CType(y, ListViewItem).SubItems(col).Text)
        Else
            returnVal = [Decimal].Compare(CType(x,
                       ListViewItem).SubItems(col).Text,
                       CType(y, ListViewItem).SubItems(col).Text)
        End If

        'If col = 4 And col = 5 Then
        '    returnVal = [Decimal].Compare(CType(x,
        '               ListViewItem).SubItems(col).Text,
        '               CType(y, ListViewItem).SubItems(col).Text)
        'Else
        '    returnVal = [String].Compare(CType(x,
        '                ListViewItem).SubItems(col).Text,
        '                CType(y, ListViewItem).SubItems(col).Text)


        'End If

        If order = SortOrder.Descending Then
            returnVal *= -1
        End If

        Return returnVal
    End Function
End Class