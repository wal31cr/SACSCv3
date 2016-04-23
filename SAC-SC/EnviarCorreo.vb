Imports System.Net
Imports System.Net.Mail

Public Class EnviarCorreo
    Dim lista As DataTable
    Dim texto As String = " ¡Buenos dias @nombre !
    Le recuerdo cancelar su deuda de @deuda , en estos momentos
    su limite de credito es de @limite , su estado de credito es @estado"
    Public Sub New(lista As DataTable)
        Me.lista = lista
        InitializeComponent()
    End Sub

    Private Sub EnviarCorreo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarListView()
        llenarListView()
        Text_correo.Text = texto

    End Sub

    Private Sub CargarListView()
        ListView1.GridLines = True
        ListView1.Activation = ItemActivation.OneClick


        Me.ListView1.TabIndex = 0
        Me.ListView1.View = System.Windows.Forms.View.Details
        Me.ListView1.MultiSelect = False
        Me.ListView1.HideSelection = False
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = ColumnHeaderStyle.Clickable
        Me.ListView1.AllowColumnReorder = True


        Dim columnHeader1 As New ColumnHeader
        With columnHeader1
            .Text = "Nombre"
            .TextAlign = HorizontalAlignment.Center
            .Width = 300
        End With
        Dim columnHeader2 As New ColumnHeader
        With columnHeader2
            .Text = "Email"
            .TextAlign = HorizontalAlignment.Left
            .Width = 270
        End With
        Dim columnHeader3 As New ColumnHeader
        With columnHeader3
            .Text = "Deuda"
            .TextAlign = HorizontalAlignment.Left
            .Width = 0
        End With
        Dim columnHeader4 As New ColumnHeader
        With columnHeader4
            .Text = "Limite"
            .TextAlign = HorizontalAlignment.Left
            .Width = 0
        End With
        Dim columnHeader5 As New ColumnHeader
        With columnHeader5
            .Text = "Estado"
            .TextAlign = HorizontalAlignment.Left
            .Width = 0
        End With
        Me.ListView1.Columns.Add(columnHeader1)
        Me.ListView1.Columns.Add(columnHeader2)
        Me.ListView1.Columns.Add(columnHeader3)
        Me.ListView1.Columns.Add(columnHeader4)
        Me.ListView1.Columns.Add(columnHeader5)

    End Sub

    Private Sub llenarListView()
        For Each r As DataRow In lista.Rows
            Dim listItem As New ListViewItem(r(0).ToString())
            listItem.SubItems.Add(r(1).ToString())
            listItem.SubItems.Add(r(2).ToString())
            listItem.SubItems.Add(r(3).ToString())
            listItem.SubItems.Add(r(4).ToString())
            ListView1.Items.Add(listItem)
        Next
    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        ListView1.Items.Remove(ListView1.SelectedItems.Item(0))
    End Sub

    Private Sub Button_enviar_Click(sender As Object, e As EventArgs) Handles Button_enviar.Click
        'ENVIAR CORREOS AQUI :D
        Dim texto2 = texto
        'Dim smtpserver As New SmtpClient()
        'Dim mail As New MailMessage()

        'Dim emailTo As New MailAddress("geramarinfer03@gmail.com")
        ''
        'mail.From = emailTo
        'mail.To.Add("geramarinfer03@gmail.com")
        'mail.Subject = "Test by bharat"
        'mail.Body = "hello ooooooooooooooooooooooo"
        'Dim s As New SmtpClient("smtp.gmail.com")
        's.Port = 465
        's.DeliveryMethod = SmtpDeliveryMethod.Network
        's.EnableSsl = True
        's.Credentials = New System.Net.NetworkCredential(emailTo.Address, "gera19952112")
        's.Send(mail)
        'MsgBox("SE ENVIO EL EMAIL")
        For i = 0 To ListView1.Items.Count - 1
            texto2 = texto2.Replace("@nombre", ListView1.Items(i).SubItems(0).Text)
            texto2 = texto2.Replace("@deuda", ListView1.Items(i).SubItems(2).Text)
            texto2 = texto2.Replace("@limite", ListView1.Items(i).SubItems(3).Text)
            texto2 = texto2.Replace("@estado", ListView1.Items(i).SubItems(4).Text)
            MsgBox(texto2)
            'se en envia el correo a la direccion subItems(1) y con el texto texto2
            texto2 = texto
        Next
    End Sub

    Private Sub Text_correo_TextChanged(sender As Object, e As EventArgs) Handles Text_correo.TextChanged
        texto = Text_correo.Text
    End Sub
End Class
