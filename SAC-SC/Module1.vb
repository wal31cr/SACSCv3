Imports System.Data
Imports System.Data.SqlClient
Module Module1
    Public oconexion As New SqlConnection()
    Public Sub conx()
        Try
            Dim serv = ".\SQLEXPRESS"
            'Dim serv = "."
            oconexion.ConnectionString = "Data Source= " & serv & "; Initial Catalog=SACSC; Integrated Security=True;User Id=SACSC; Password=SACSC;"
            oconexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally

        End Try
    End Sub
End Module
