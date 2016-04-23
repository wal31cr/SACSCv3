Imports System.Data.SqlClient

Public Class DistribuidoresAgregar
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Distribuidores.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim comm As New SqlCommand("insert into distribuidor(empresa,contacto,telefono,direccion) values('" + Trim(txtEmp.Text) + "','" + Trim(txtNom.Text) + "','" + Trim(txtTelf.Text) + "','" + Trim(txtDir.Text) + "')", oconexion)
        Dim res As Integer
        Try
            res = comm.ExecuteNonQuery
            If res = 1 Then
                MsgBox("Datos ingresados exitosamente", MsgBoxStyle.Information, "Agregar distribuidor")

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Agregar distribuidor")
        End Try
        Me.Close()
        Distribuidores.Show()
    End Sub
End Class