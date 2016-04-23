Imports System.Data
Imports System.Data.SqlClient
Public Class UsuariosModificar
    Private sql_usuarios As String = "SELECT [id_empleado], empleado.[nombre], [apellidos], departamento.[nombre] as departamentos," &
                                    " [email], [limite_credito], [deuda] FROM [dbo].[empleado], [dbo].departamento" &
                                    " WHERE empleado.departamento = departamento.id_departamento"
    Private sql_Departamentos As String = "SELECT id_departamento,nombre FROM dbo.departamento ORDER BY id_departamento"

    Dim apellidos As String
    Dim flagCambios As Boolean = False
    'Dim limite As Double
    'Dim email As String
    Dim departamento As Integer
    Dim estado As Boolean 'True = disponible, False = bloqueado
    Dim deuda As Decimal
    'Public Sub New(identificacion As String, nombre As String, apellidos As String, limite As Double, email As String,
    '                departamento As Integer, estado As Boolean)

    '    Me.identificacion = identificacion
    '    Me.nombre = nombre
    '    Me.apellidos = apellidos
    '    Me.limite = limite
    '    Me.email = email
    '    Me.departamento = departamento
    '    Me.estado = estado
    'End Sub
    Private Sub UsuariosModificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarComboBox()
        buscarID()
        Btn_guardar.Enabled = False
        flagCambios = False
    End Sub

    Private Sub buscarID()
        Dim cmd As New SqlCommand
        cmd.Connection = Module1.oconexion
        cmd.CommandText = "exec dbo.buscarEmpleado_ID '" + Module2.Id_usuario_Seleccionado + "'"
        Dim lrd As SqlDataReader = cmd.ExecuteReader()
        Dim count As Integer = 0
        While lrd.Read()

            Lb_identificacion.Text = Module2.Id_usuario_Seleccionado
            TextBox_apellidos.Text = lrd("apellidos")
            TextBox_nombre.Text = lrd("nombre") + " " + apellidos
            TextBox_email.Text = lrd("email")

            departamento = lrd("departamento_id")

            TextBox_limite.Text = lrd("limite_credito")
            TextBox_limite.Text = Format(CDbl(TextBox_limite.Text), "C")
            deuda = lrd("deuda")


            Lb_notas.Text = IIf(lrd("nota_detalle") Is DBNull.Value, "Sin Notas", lrd("nota_detalle"))

            estado = (deuda) < CDbl(TextBox_limite.Text)
            CambiarEstadoImagen()

        End While
        lrd.Close()
        ComboBox_departamentos.SelectedIndex = departamento - 1
        cambiarBoton()
        flagCambios = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Btn_cancelar.Click
        flagCambios = False
        MessageBox.Show("No se realizó ningún cambio", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.Close()
        UsuariosDetalle.Show()
    End Sub

    Private Sub GuardarCambios()
        Dim comd As New SqlCommand("update dbo.empleado set nombre = '" & TextBox_nombre.Text & "',apellidos = '" &
                                  TextBox_apellidos.Text & "',departamento = " & ComboBox_departamentos.SelectedIndex + 1 &
                                  " , email = '" & TextBox_email.Text & "', limite_credito = " & CDbl(TextBox_limite.Text) &
                                  ", nota_detalle = '" & Lb_notas.Text & "' " &
                                  " where id_empleado = '" & Module2.Id_usuario_Seleccionado & "'", oconexion)
        Try


            comd.ExecuteNonQuery()
            MsgBox("¡Usuario Modificado!", MsgBoxStyle.Exclamation, "Usuario Modificar")

            TextBox_nombre.Clear()
            TextBox_apellidos.Clear()
            'TextBox_departamento.Clear()
            'Usuarios.updateUsuarios("select * from dbo.empleado")
            UsuariosDetalle.inicializarCliente()
            UsuariosDetalle.Show()
            flagCambios = False
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btn_guardar.Click
        GuardarCambios()
    End Sub

    Private Sub llenarComboBox()
        ComboBox_departamentos.DropDownStyle = 2

        Dim cmd As New SqlCommand
        cmd.Connection = Module1.oconexion
        cmd.CommandText = sql_Departamentos
        Dim lrd As SqlDataReader = cmd.ExecuteReader()

        While lrd.Read()
            ComboBox_departamentos.Items.Add(lrd("id_departamento") & " - " & lrd("nombre"))
        End While
        lrd.Close()
    End Sub

    Private Sub TextBox_limite_Leave(sender As Object, e As EventArgs) Handles TextBox_limite.Leave
        Try
            TextBox_limite.Text = Format(CDbl(TextBox_limite.Text), "C")
        Catch
            MsgBox("El campo limite solo acepta valores numericos, Utilice '.' (punto) para separacion de decimales", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cambiarBoton()
        If estado Then
            ' Btn_bloq_desbloq.BackgroundImage = Image.FromFile(Environment.CurrentDirectory & "\Recursos\bloqueado.png")
            Btn_bloq_desbloq.Text = "Bloquear"
        Else
            ' Btn_bloq_desbloq.BackgroundImage = Image.FromFile(Environment.CurrentDirectory & "\Recursos\disponible.png")
            Btn_bloq_desbloq.Text = "Desbloquear"
        End If
    End Sub

    Private Sub UsuariosModificar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing
        If flagCambios = True Then
            If (MessageBox.Show(" *Aun no ha guardado los cambios realizados*
          ¿ Desea guardar los cambios ahora? ", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = 1) Then
                GuardarCambios()
            Else
                Me.Hide()
                UsuariosDetalle.Show()
            End If
        Else
            Me.Hide()
            UsuariosDetalle.Show()
        End If

    End Sub

    Private Sub TextBox_nombre_TextChanged(sender As Object, e As EventArgs) Handles TextBox_nombre.TextChanged
        Btn_guardar.Enabled = True
        flagCambios = True
    End Sub

    Private Sub TextBox_apellidos_TextChanged(sender As Object, e As EventArgs) Handles TextBox_apellidos.TextChanged
        Btn_guardar.Enabled = True
        flagCambios = True
    End Sub

    Private Sub TextBox_email_TextChanged(sender As Object, e As EventArgs) Handles TextBox_email.TextChanged
        Btn_guardar.Enabled = True
        flagCambios = True
    End Sub

    Private Sub TextBox_limite_TextChanged(sender As Object, e As EventArgs) Handles TextBox_limite.TextChanged
        Btn_guardar.Enabled = True
        flagCambios = True

    End Sub

    Private Sub ComboBox_departamentos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_departamentos.SelectedIndexChanged
        Btn_guardar.Enabled = True
        flagCambios = True
    End Sub

    Private Sub Lb_notas_TextChanged(sender As Object, e As EventArgs) Handles Lb_notas.TextChanged
        Btn_guardar.Enabled = True
        flagCambios = True
    End Sub

    Private Sub CambiarEstadoImagen()
        If estado Then
            Pb_estado.Image = Image.FromFile(Environment.CurrentDirectory & "\Recursos\disponible.png")
            'estado = True
        Else
            Pb_estado.Image = Image.FromFile(Environment.CurrentDirectory & "\Recursos\bloqueado.png")
            'estado = False
        End If
    End Sub


    Private Sub Bloquear()
        'If Lb_notas.Text <> "Sin notas" Then
        'Lb_notas.Text = vbCrLf & "Bloqueado Manualmente el " & FormatDateTime(Date.Today, DateFormat.ShortDate) &
        '  " Limite anterior: " & TextBox_limite.Text + Lb_notas.Text
        'Else
        Lb_notas.Text = "Bloqueado Manualmente el " & FormatDateTime(Date.Today, DateFormat.ShortDate) &
          " Limite anterior: " & TextBox_limite.Text
        'End If

        Dim nuevoLimite As Decimal = CDbl(deuda)
        TextBox_limite.Text = Format(nuevoLimite, "C")
        CambiarEstadoImagen()
        cambiarBoton()
        flagCambios = True
    End Sub

    Private Sub Desbloquear()
        ' If Lb_notas.Text <> "Sin Notas" Then
        'Lb_notas.Text = vbCrLf & "Desbloqueado Manualmente el " & FormatDateTime(Date.Today, DateFormat.ShortDate) &
        ' " Limite anterior: " & TextBox_limite.Text + Lb_notas.Text
        'Else
        Lb_notas.Text = "Desbloqueado Manualmente el " & FormatDateTime(Date.Today, DateFormat.ShortDate) &
          " Limite anterior: " & TextBox_limite.Text
        'End If
        Dim nuevoLimite As Decimal = CDbl(TextBox_limite.Text) + 5000
        TextBox_limite.Text = Format(nuevoLimite, "C")
        CambiarEstadoImagen()
        cambiarBoton()
        flagCambios = True
    End Sub
    Private Sub Btn_bloq_desbloq_Click(sender As Object, e As EventArgs) Handles Btn_bloq_desbloq.Click
        Btn_guardar.Enabled = True
        If estado Then
            estado = False
            Bloquear()
            Btn_guardar.Focus()

        Else
            estado = True
            Desbloquear()
            Btn_guardar.Focus()
        End If
    End Sub
End Class