Imports System.Data
Imports System.Data.SqlClient
Public Class FacturacionCliente

    Public disponible As Integer = 0

    Private Sub TextBox1_KeyPress(ByVal sender As Object,
            ByVal e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Dim nombre As String
            Dim cmd As New SqlCommand
            cmd.Connection = Module1.oconexion
            cmd.CommandText = " Select * From dbo.empleado Where id_empleado = " + "'" + TextBox1.Text + "'"
            Dim lrd As SqlDataReader = cmd.ExecuteReader()
            While lrd.Read()
                nombre = lrd("nombre") + " " + lrd("apellidos")
            End While
            TextBox2.Text = nombre
            lrd.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        TextBox1.Clear()
        TextBox2.Clear()
        MenuPrincipal.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Facturacion.TextBox5.Select()
        Dim limite As Integer
        Dim deuda As Integer
        Dim answer As Integer
        Dim cmd As New SqlCommand
        cmd.Connection = Module1.oconexion
        cmd.CommandText = " Select * From dbo.empleado Where id_empleado =" + "'" + TextBox1.Text + "'"
        Dim lrd As SqlDataReader = cmd.ExecuteReader()
        While lrd.Read()
            limite = lrd("limite_credito")
            deuda = lrd("deuda")
        End While
        lrd.Close()

        disponible = limite - deuda

        If limite = deuda Or deuda > limite Then
            answer = MsgBox("¡Usuario BLOQUEADO imposible dar credito! ¿Desea realizar abono?", vbYesNo + vbQuestion, "Usuario Bloqueado")
            If answer = vbYes Then
                FacturacionAbono.Show()
            End If
        Else
            Me.Hide()
            Facturacion.Show()
        End If

        If limite - deuda <= 1000 And limite - deuda <> 0 Then
            MsgBox("¡ATENCIÓN! Posee un credito disponible de tan solo: " & limite - deuda & " colones", vbExclamation, "Crédito Disponible")
        End If

    End Sub

    Private Sub FacturacionCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TextBox1.Select()
        Me.KeyPreview = True
    End Sub
End Class