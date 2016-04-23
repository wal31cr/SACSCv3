Imports System.Data
Imports System.Data.SqlClient
Module Module1
    Public oconexion As New SqlConnection()
    Public Sub conx()
        Try
            Dim serv = ".\SQLEXPRESS"
            oconexion.ConnectionString = "Data Source= " & serv & "; Initial Catalog=SACSC; Integrated Security=True;User Id=SACSC; Password=SACSC;"
            'oconexion.ConnectionString = "Data Source=JOSE_MARIN;Initial Catalog=SACSC;Integrated Security=True" 'Conexion Gera"
            'oconexion.ConnectionString = "Server=JPABLOGG\SQLEXPRESS;Database=SACSC;User Id=Papu; Password=papu;"
            oconexion.Open()
            'MsgBox("Conectado!")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            'oconexion.Close()
        End Try
    End Sub
End Module
