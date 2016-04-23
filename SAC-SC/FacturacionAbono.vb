Imports System.Data
Imports System.Data.SqlClient
Public Class FacturacionAbono
    Private Sub FacturacionAbono_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nombre As String
        Dim apellidos As String
        Dim deuda As String
        Dim estado As String
        Dim departamento As Integer
        Dim limite As Integer
        Dim cmd As New SqlCommand
        cmd.Connection = Module1.oconexion
        cmd.CommandText = " Select * From dbo.empleado Where id_empleado = " + "'" + FacturacionCliente.TextBox1.Text + "'"
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
        cmd.CommandText = " Select * From dbo.empleado Where id_empleado =" + "'" + FacturacionCliente.TextBox1.Text + "'"
        Dim lrd2 As SqlDataReader = cmd.ExecuteReader()
        Dim coun As Integer = 0
        While lrd2.Read()
            deuda = lrd2("deuda")
            If deuda.Equals(limite) Then
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim abono As Integer = TextBox4.Text
        Dim vuelto As Integer = 0
        If abono > TextBox3.Text Then
            vuelto = abono - TextBox3.Text
            abono = TextBox3.Text
        End If
        Dim localDate = Date.Now.ToString("MM-dd-yyyy")
        Dim comd As New SqlCommand("insert into dbo.abono(empleado,pago,fecha) values ('" & FacturacionCliente.TextBox1.Text & "','" & abono & "','" & localDate & "')", oconexion)
        Try
            comd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        MsgBox("¡Abono realizado exitosamente! Cambio: " & vuelto & " colones", vbInformation, "Abono Exitoso")
        comd.CommandText = "update dbo.empleado set deuda = deuda - " & abono & " where id_empleado = '" & FacturacionCliente.TextBox1.Text & "'"
        Try
            comd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Me.Close()
    End Sub
End Class