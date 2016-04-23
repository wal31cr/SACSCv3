Imports System.Data
Imports System.Data.SqlClient
Public Class Abonos
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()

        Dim localDate = Date.Now.ToString("MM-dd-yyyy")
        Dim comd As New SqlCommand("insert into dbo.abono(empleado,pago,fecha) values ('" & TextBox5.Text & "','" & TextBox4.Text & "','" & localDate & "')", oconexion)
        Try
            comd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

        AbonosExito.TextBox1.Text = Me.TextBox4.Text
        AbonosExito.TextBox2.Text = Integer.Parse(TextBox3.Text) - Integer.Parse(TextBox4.Text)

        comd.CommandText = "update dbo.empleado set deuda = deuda - " + AbonosExito.TextBox1.Text + " where id_empleado = " + TextBox5.Text
        Try
            comd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        AbonosExito.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        MenuPrincipal.Show()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        Dim nombre As String
        Dim apellidos As String
        Dim deuda As String
        Dim estado As String
        Dim departamento As Integer
        Dim limite As Integer

        Dim cmd As New SqlCommand
        cmd.Connection = Module1.oconexion
        cmd.CommandText = " Select * From dbo.empleado Where id_empleado Like " + "'%" + TextBox5.Text + "%'"
        Dim lrd As SqlDataReader = cmd.ExecuteReader()
        While lrd.Read()
            nombre = lrd("nombre") + " " + lrd("apellidos")
            departamento = lrd("departamento")
            limite = lrd("limite_credito")
        End While
        TextBox2.Text = nombre
        TextBox1.Text = departamento
        lrd.Close()

        Dim cmd2 As New SqlCommand
        cmd.Connection = Module1.oconexion
        cmd.CommandText = " Select * From dbo.empleado Where id_empleado Like " + "'%" + TextBox5.Text + "%'"
        Dim lrd2 As SqlDataReader = cmd.ExecuteReader()
        Dim coun As Integer = 0
        While lrd2.Read()
            deuda = lrd2("deuda")
            If deuda.Equals(0) Then
                estado = "Inhabilitado"
            Else
                estado = "Habilitado"
            End If
            coun += 1
        End While
        lrd2.Close()
        TextBox7.Text = limite - deuda
        TextBox3.Text = deuda
        TextBox6.Text = estado
    End Sub

    Private Sub Abonos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class