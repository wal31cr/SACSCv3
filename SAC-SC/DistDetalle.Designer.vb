<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DistDetalle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DistDetalle))
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Date_Inicio = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Date_Final = New System.Windows.Forms.DateTimePicker()
        Me.lvDetalles = New System.Windows.Forms.ListView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmp = New System.Windows.Forms.TextBox()
        Me.txtCont = New System.Windows.Forms.TextBox()
        Me.txtTelf = New System.Windows.Forms.TextBox()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.lblDetalle = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(13, 397)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 20)
        Me.Label13.TabIndex = 98
        Me.Label13.Text = "Direccion: "
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(-94, 239)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 20)
        Me.Label12.TabIndex = 97
        Me.Label12.Text = "Email: "
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 325)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 20)
        Me.Label7.TabIndex = 96
        Me.Label7.Text = "# de telefono: "
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 260)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 20)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "Contacto: "
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 191)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 20)
        Me.Label10.TabIndex = 94
        Me.Label10.Text = "Empresa: "
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(477, 191)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 18)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "desde: "
        '
        'Date_Inicio
        '
        Me.Date_Inicio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Date_Inicio.CustomFormat = "dd/MM/yyyy"
        Me.Date_Inicio.Location = New System.Drawing.Point(548, 191)
        Me.Date_Inicio.Margin = New System.Windows.Forms.Padding(4)
        Me.Date_Inicio.Name = "Date_Inicio"
        Me.Date_Inicio.Size = New System.Drawing.Size(131, 22)
        Me.Date_Inicio.TabIndex = 91
        Me.Date_Inicio.Value = New Date(2016, 3, 12, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(688, 191)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 18)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "hasta: "
        '
        'Date_Final
        '
        Me.Date_Final.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Date_Final.CustomFormat = "dd/MM/yyyy"
        Me.Date_Final.Location = New System.Drawing.Point(753, 191)
        Me.Date_Final.Margin = New System.Windows.Forms.Padding(4)
        Me.Date_Final.MaxDate = New Date(9998, 3, 12, 0, 0, 0, 0)
        Me.Date_Final.Name = "Date_Final"
        Me.Date_Final.Size = New System.Drawing.Size(131, 22)
        Me.Date_Final.TabIndex = 89
        Me.Date_Final.Value = New Date(2016, 3, 10, 0, 0, 0, 0)
        '
        'lvDetalles
        '
        Me.lvDetalles.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvDetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvDetalles.FullRowSelect = True
        Me.lvDetalles.Location = New System.Drawing.Point(478, 224)
        Me.lvDetalles.Margin = New System.Windows.Forms.Padding(4)
        Me.lvDetalles.Name = "lvDetalles"
        Me.lvDetalles.Size = New System.Drawing.Size(816, 395)
        Me.lvDetalles.TabIndex = 88
        Me.lvDetalles.UseCompatibleStateImageBehavior = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(478, 38)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(262, 69)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "SAC-SC"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(329, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(607, 29)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Sistema Administrador de Comedores del Servicio Civil"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEmp
        '
        Me.txtEmp.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtEmp.Enabled = False
        Me.txtEmp.Location = New System.Drawing.Point(151, 191)
        Me.txtEmp.Name = "txtEmp"
        Me.txtEmp.Size = New System.Drawing.Size(258, 22)
        Me.txtEmp.TabIndex = 99
        '
        'txtCont
        '
        Me.txtCont.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtCont.Enabled = False
        Me.txtCont.Location = New System.Drawing.Point(151, 260)
        Me.txtCont.Name = "txtCont"
        Me.txtCont.Size = New System.Drawing.Size(258, 22)
        Me.txtCont.TabIndex = 100
        '
        'txtTelf
        '
        Me.txtTelf.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtTelf.Enabled = False
        Me.txtTelf.Location = New System.Drawing.Point(151, 325)
        Me.txtTelf.Name = "txtTelf"
        Me.txtTelf.Size = New System.Drawing.Size(258, 22)
        Me.txtTelf.TabIndex = 101
        '
        'txtDir
        '
        Me.txtDir.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtDir.Enabled = False
        Me.txtDir.Location = New System.Drawing.Point(151, 397)
        Me.txtDir.Multiline = True
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(294, 94)
        Me.txtDir.TabIndex = 102
        '
        'lblDetalle
        '
        Me.lblDetalle.AutoSize = True
        Me.lblDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetalle.Location = New System.Drawing.Point(473, 123)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(362, 29)
        Me.lblDetalle.TabIndex = 103
        Me.lblDetalle.Text = "Detalle de compras a distribudor"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(242, 29)
        Me.Label6.TabIndex = 104
        Me.Label6.Text = "Datos del distribuidor"
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnCerrar.Location = New System.Drawing.Point(17, 586)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(143, 58)
        Me.btnCerrar.TabIndex = 105
        Me.btnCerrar.Text = "Volver"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'DistDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1307, 672)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblDetalle)
        Me.Controls.Add(Me.txtDir)
        Me.Controls.Add(Me.txtTelf)
        Me.Controls.Add(Me.txtCont)
        Me.Controls.Add(Me.txtEmp)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Date_Inicio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Date_Final)
        Me.Controls.Add(Me.lvDetalles)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DistDetalle"
        Me.Text = "Detalle Distribuidor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Date_Inicio As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Date_Final As DateTimePicker
    Friend WithEvents lvDetalles As ListView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmp As TextBox
    Friend WithEvents txtCont As TextBox
    Friend WithEvents txtTelf As TextBox
    Friend WithEvents txtDir As TextBox
    Friend WithEvents lblDetalle As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCerrar As Button
End Class
