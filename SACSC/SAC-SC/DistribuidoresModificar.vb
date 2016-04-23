Imports System.Data.SqlClient

Public Class DistribuidoresModificar
    Dim ID As Integer
    Public Sub New(ByVal fila As ListViewItem)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ID = Val(fila.SubItems(1).Text)
        txtNom.Text = fila.SubItems(3).Text
        txtEmp.Text = fila.SubItems(2).Text
        txtTelf.Text = fila.SubItems(4).Text
        txtDir.Text = fila.SubItems(5).Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Distribuidores.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim query As String
        query = "update distribuidor set empresa='" & Trim(txtEmp.Text) &
                                   "', contacto='" & Trim(txtNom.Text) & "', telefono='" &
                                   Trim(txtTelf.Text) & "', direccion='" & Trim(txtDir.Text) &
                                   "' where id_distribuidor='" & ID & "'"
        Dim comm As New SqlCommand(query, oconexion)
        Dim res As Integer
        Try
            res = comm.ExecuteNonQuery
            If res = 1 Then
                MsgBox("Datos actualizados exitosamente", MsgBoxStyle.Information, "Modificar distribuidor")

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Modificar distribuidor")
        End Try
        Me.Close()
        Distribuidores.Show()
    End Sub
End Class