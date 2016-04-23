Imports System.Data.SqlClient

Public Class UsuariosDetalle
    Private sql_usuarios As String = "SELECT [id_empleado], empleado.[nombre], [apellidos], departamento.[nombre] as departamentos, [email], [limite_credito], [deuda] FROM [dbo].[empleado], [dbo].departamento WHERE empleado.departamento = departamento.id_departamento"
    Dim usuario As String = ""
    Dim apellidos As String
    'Dim departamento_id As Integer
    Dim estado As Boolean
    Private Sub UsuariosDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Date_Final.MaxDate = Date.Today
        Date_Final.Format = DateTimePickerFormat.Short
        Date_Final.Value = Date.Today
        Date_Inicio.MaxDate = Date.Today
        Date_Inicio.Format = DateTimePickerFormat.Short
        Date_Inicio.Value = Date.Today.Subtract(TimeSpan.FromDays(30))

        ComboBox1.Items.Add("Compras")
        ComboBox1.Items.Add("Abonos")
        ComboBox1.DropDownStyle = 2
        ComboBox1.SelectedIndex = 1

        usuario = Module2.Id_usuario_Seleccionado
        inicializarCliente()
        inicializarListaAbonos()


    End Sub

    Public Sub inicializarCliente()
        Lb_id.Text = usuario
        buscarID()
    End Sub


    Private Sub UsuariosDetalle_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing
        Usuarios.updateUsuarios(sql_usuarios)
        Me.Hide()
        Usuarios.Show()
    End Sub

    Private Sub buscarID()
        Dim cmd As New SqlCommand
        cmd.Connection = Module1.oconexion
        cmd.CommandText = "exec dbo.buscarEmpleado_ID '" + usuario + "'"
        Dim nota As String
        Dim lrd As SqlDataReader = cmd.ExecuteReader()
        Dim count As Integer = 0
        While lrd.Read()

            Lb_id.Text = usuario
            apellidos = lrd("apellidos")
            Lb_NombreP.Text = lrd("nombre") + " " + apellidos
            Lb_email.Text = lrd("email")
            Lb_departamento.Text = lrd("departamentos")
            'departamento_id = lrd("departamento_id")


            Lb_limite.Text = lrd("limite_credito")
            Lb_limite.Text = Format(CDbl(Lb_limite.Text), "C")

            Lb_deuda.Text = lrd("deuda")
            Lb_deuda.Text = Format(CDbl(Lb_deuda.Text), "C")

            Lb_disponible.Text = Format(CDbl((CInt(Lb_limite.Text) - CInt(Lb_deuda.Text))), "C")

            Lb_notas.Text = IIf(lrd("nota_detalle") Is DBNull.Value, "Sin Notas", lrd("nota_detalle"))
            If (CInt(Lb_deuda.Text) < CInt(Lb_limite.Text)) Then
                Pb_estado.Image = Image.FromFile(Environment.CurrentDirectory & "\Recursos\disponible.png")
                estado = True
            Else
                Pb_estado.Image = Image.FromFile(Environment.CurrentDirectory & "\Recursos\bloqueado.png")
                estado = False
            End If


        End While
        lrd.Close()
    End Sub

    Private Sub inicializarListaAbonos()
        ListView1.Clear()

        ListView1.GridLines = True
        ListView1.Activation = ItemActivation.OneClick

        Me.ListView1.TabIndex = 0
        Me.ListView1.View = System.Windows.Forms.View.Details
        Me.ListView1.MultiSelect = False
        Me.ListView1.HideSelection = False
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = ColumnHeaderStyle.Clickable

        Dim columnHeader1 As New ColumnHeader
        With columnHeader1
            .Text = "Fecha"
            .TextAlign = HorizontalAlignment.Center
            .Width = 180
        End With
        Dim columnHeader2 As New ColumnHeader
        With columnHeader2
            .Text = "Abono"
            .TextAlign = HorizontalAlignment.Left
            .Width = 118
        End With

        Me.ListView1.Columns.Add(columnHeader1)
        Me.ListView1.Columns.Add(columnHeader2)

        llenarAbonos()

    End Sub


    Private Sub llenarAbonos()
        ListView1.Items.Clear()
        Dim fecha() As String = New String() {" "}
        Dim pago() As String = New String() {""}
        Dim pag As String
        Dim cmd As New SqlCommand
        cmd.Connection = Module1.oconexion
        cmd.CommandText = "exec Abonos_de_Usuario '" + String.Format("{0:yyyy-MM-dd}", Date_Inicio.Value) +
            "','" + String.Format("{0:yyyy-MM-dd}", Date_Final.Value) + "','" + usuario + "'"

        'Dim a As String = String.Format("{0:yyyy-MM-dd}", Date_Inicio.Value)
        'Dim b As String = String.Format("{0:yyyy-MM-dd}", Date_Final.Value)


        'cmd.Parameters.AddWithValue("@fecha1", a)
        'cmd.Parameters.AddWithValue("@fecha2", String.Format("{0:yyyy-MM-dd}", Date_Final.Value))
        'cmd.Parameters.AddWithValue("@id_empleado", usuario)


        ' Dim Inicio As String = String.Format(Date_Inicio.Value, "yyyy/MM/dd")
        ' Dim Final As String = String.Format(Date_Final.Value, "yyyy-MM-dd")


        '.CommandText = "INSERT INTO pagos(No_pago,No_socio,fecha_pago)" & "VALUES" & "(@No_pago,@No_socio,@fecha_p)"
        '.Parameters.AddWithValue("@No_pago", lbl_no.Text)
        '.Parameters.AddWithValue("@No_socio", lblno_socio.Text)
        '.Parameters.AddWithValue("@fecha_p", Datetimepicker1.Value.ToShortDateString))

        Dim lrd As SqlDataReader = cmd.ExecuteReader()
        Dim count As Integer = 0
        While lrd.Read()
            fecha(count) = lrd("fecha")
            pag = lrd("pago")
            pago(count) = Format(CDbl(pag), "C")
            count += 1
            ReDim Preserve fecha(fecha.Length)
            ReDim Preserve pago(pago.Length)

        End While
        lrd.Close()

        Dim count2 As Integer
        For count2 = 0 To fecha.Length - 2
            Dim listItem As New ListViewItem(fecha(count2))
            listItem.SubItems.Add(pago(count2))
            ListView1.Items.Add(listItem)
        Next

    End Sub

    Private Sub InicializarOrdenes()
        ListView1.Clear()
        ListView1.GridLines = True
        ListView1.Activation = ItemActivation.OneClick

        Me.ListView1.TabIndex = 0
        Me.ListView1.View = System.Windows.Forms.View.Details
        Me.ListView1.MultiSelect = False
        Me.ListView1.HideSelection = False
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = ColumnHeaderStyle.Clickable

        Dim columnHeader1 As New ColumnHeader
        With columnHeader1
            .Text = "Numero"
            .TextAlign = HorizontalAlignment.Center
            .Width = 79
        End With
        Dim columnHeader2 As New ColumnHeader
        With columnHeader2
            .Text = "Fecha"
            .TextAlign = HorizontalAlignment.Left
            .Width = 140
        End With

        Dim columnHeader3 As New ColumnHeader
        With columnHeader3
            .Text = "Total"
            .TextAlign = HorizontalAlignment.Left
            .Width = 80
        End With

        Me.ListView1.Columns.Add(columnHeader1)
        Me.ListView1.Columns.Add(columnHeader2)
        Me.ListView1.Columns.Add(columnHeader3)

        llenarOrdenes()
    End Sub

    Private Sub llenarOrdenes()
        ListView1.Items.Clear()
        Dim fecha() As String = New String() {" "}
        Dim pago() As String = New String() {""}
        Dim numero() As Integer = New Integer() {0}
        Dim pag As String
        Dim cmd As New SqlCommand
        cmd.Connection = Module1.oconexion
        cmd.CommandText = "exec Ordenes_Usuario  '" + usuario + "','" + String.Format("{0:yyyy-MM-dd}", Date_Inicio.Value) +
            "','" + String.Format("{0:yyyy-MM-dd}", Date_Final.Value) + "'"

        Dim lrd As SqlDataReader = cmd.ExecuteReader()
        Dim count As Integer = 0
        While lrd.Read()
            fecha(count) = lrd("fecha")
            pag = lrd("total")
            pago(count) = Format(CDbl(pag), "C")
            numero(count) = lrd("num_orden")
            count += 1
            ReDim Preserve fecha(fecha.Length)
            ReDim Preserve pago(pago.Length)
            ReDim Preserve numero(numero.Length)

        End While
        lrd.Close()

        Dim count2 As Integer
        For count2 = 0 To fecha.Length - 2
            Dim listItem As New ListViewItem(numero(count2))
            listItem.SubItems.Add(fecha(count2))
            listItem.SubItems.Add(pago(count2))
            ListView1.Items.Add(listItem)

        Next
    End Sub

    Private Sub Date_Inicio_ValueChanged(sender As Object, e As EventArgs) Handles Date_Inicio.ValueChanged
        ListView1.Clear()
        If (ComboBox1.SelectedIndex = 0) Then
            InicializarOrdenes()

        Else
            inicializarListaAbonos()
        End If
    End Sub

    Private Sub Date_Final_ValueChanged(sender As Object, e As EventArgs) Handles Date_Final.ValueChanged
        ListView1.Clear()
        If (ComboBox1.SelectedIndex = 0) Then
            InicializarOrdenes()

        Else
            inicializarListaAbonos()
        End If
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ListView1.Clear()
        If (ComboBox1.SelectedIndex = 0) Then
            InicializarOrdenes()

        Else
            inicializarListaAbonos()
        End If


    End Sub

    Private Sub Btn_Modificar_Click(sender As Object, e As EventArgs) Handles Btn_Modificar.Click
        Me.Hide()
        ' Dim UsuariosM As UsuariosModificar = New UsuariosModificar(usuario, Lb_NombreP.Text, apellidos, CDbl(Lb_limite.Text), Lb_email.Text,
        'departamento_id, estado)

        UsuariosModificar.Show()
    End Sub
    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick

        If ComboBox1.SelectedIndex = 0 Then
            Dim compras As New ModificarOrdenCliente(ListView1.SelectedItems.Item(0).SubItems(0).Text, Lb_NombreP.Text)
            compras.ShowDialog()

        End If
    End Sub

    Private Sub Btn_menuPrincipal_Click(sender As Object, e As EventArgs) Handles Btn_menuPrincipal.Click
        Usuarios.Show()
        Me.Close()
    End Sub
    Public Sub Refrescar()
        Me.Refresh()
    End Sub
End Class