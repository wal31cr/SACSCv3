Imports System.Data
Imports System.Data.SqlClient
Public Class UsuariosAgregar

    Private sql_usuarios As String = "SELECT [id_empleado], empleado.[nombre], [apellidos], departamento.[nombre] as departamentos, [email], [limite_credito], [deuda] FROM [dbo].[empleado], [dbo].departamento WHERE empleado.departamento = departamento.id_departamento"
    Private sql_Departamentos As String = "SELECT id_departamento,nombre FROM dbo.departamento ORDER BY id_departamento"

    Private Sub UsuariosAgregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        llenarComboBox()
    End Sub

    Private Sub Btn_cancelar_Click(sender As Object, e As EventArgs) Handles Btn_cancelar.Click
        limpiar()
        Me.Hide()
        Usuarios.Show()
    End Sub

    Private Sub Btn_enviar_Click(sender As Object, e As EventArgs) Handles Btn_enviar.Click

        ' MessageBox.Show("Desea registrar las notas", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Stop)
        If validarNoVacios() = False Then
            MsgBox("Debe llenar todos los campos", MsgBoxStyle.Critical)
        Else

            'Preguntar a DGSV si desean que aparezca el mensaje
            If (MessageBox.Show("¡Por favor corrobore el número de identificación " & Txb_identificacion.Text & "  que desea insertar en la base de datos, ya que este no se podrá modificar luego! ", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = 1) Then

                Dim comd As New SqlCommand("insert into dbo.empleado (id_empleado,nombre,apellidos,departamento,email,limite_credito, deuda) values ('" &
                                       Txb_identificacion.Text & "','" & Txb_nombre.Text.ToUpper & "','" & Txb_apellido.Text.ToUpper & "'," &
                                       (Comb_departamento.SelectedIndex + 1) & ", '" & Txb_email.Text & "', " & CDbl(Txb_limite.Text) & ", " &
                                       0 & " )", oconexion)
                Try
                    comd.ExecuteNonQuery()
                    limpiar()
                    Usuarios.updateUsuarios(sql_usuarios)
                    Me.Hide()
                    Usuarios.Show()

                Catch exc As SqlException
                    MsgBox("Este numero de identificación ya pertenece a un usuario registrado en la base de datos ", MsgBoxStyle.Critical)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)

                End Try
            End If

        End If


    End Sub


    Private Sub limpiar()
        Txb_identificacion.Clear()
        Txb_nombre.Clear()
        Txb_email.Clear()
        Txb_apellido.Clear()
        Txb_email.Clear()
        Txb_limite.Clear()
        Comb_departamento.SelectedIndex = -1
    End Sub

    Private Sub llenarComboBox()
        Comb_departamento.DropDownStyle = 2

        Dim cmd As New SqlCommand
        cmd.Connection = Module1.oconexion
        cmd.CommandText = sql_Departamentos
        Dim lrd As SqlDataReader = cmd.ExecuteReader()

        While lrd.Read()
            Comb_departamento.Items.Add(lrd("id_departamento") & " - " & lrd("nombre"))
        End While
        lrd.Close()
    End Sub

    Private Sub UsuariosAgregar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing
        Me.Hide()
        Usuarios.Show()
    End Sub

    'Private Sub Comb_departamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Comb_departamento.SelectedIndexChanged
    '     MsgBox(Comb_departamento.SelectedIndex + 1)
    'End Sub

    Private Function validarNoVacios() As Boolean
        Return IIf(Txb_identificacion.Text <> "" And Txb_nombre.Text <> "" And Txb_apellido.Text <> "" And Txb_email.Text <> "" And
            Txb_limite.Text <> "" And Comb_departamento.SelectedIndex > -1, True, False)
    End Function

    Private Sub Txb_identificacion_Enter(sender As Object, e As EventArgs) Handles Txb_identificacion.Click
        Txb_identificacion.SelectionStart = 0

    End Sub

    Private Sub Txb_limite_Leave(sender As Object, e As EventArgs) Handles Txb_limite.Leave
        Try
            Txb_limite.Text = Format(CDbl(Txb_limite.Text), "C")
        Catch
            MsgBox("El campo limite solo acepta valores numericos", MsgBoxStyle.Critical)
        End Try

        'MsgBox(CDbl(Txb_limite.Text))
    End Sub


End Class