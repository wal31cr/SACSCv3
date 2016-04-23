<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsuariosDetalle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsuariosDetalle))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Date_Final = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Date_Inicio = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Lb_disponible = New System.Windows.Forms.Label()
        Me.Lb_deuda = New System.Windows.Forms.Label()
        Me.Lb_departamento = New System.Windows.Forms.Label()
        Me.Lb_id = New System.Windows.Forms.Label()
        Me.Lb_email = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Lb_limite = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Lb_NombreP = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Lb_notas = New System.Windows.Forms.TextBox()
        Me.Btn_Modificar = New System.Windows.Forms.Button()
        Me.Pb_estado = New System.Windows.Forms.PictureBox()
        Me.Btn_menuPrincipal = New System.Windows.Forms.Button()
        CType(Me.Pb_estado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(344, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 55)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "SAC-SC"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(223, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(470, 24)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Sistema Administrador de Comedores del Servicio Civil"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(544, 158)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(303, 365)
        Me.ListView1.TabIndex = 59
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Date_Final
        '
        Me.Date_Final.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Date_Final.Location = New System.Drawing.Point(748, 122)
        Me.Date_Final.MaxDate = New Date(9998, 3, 12, 0, 0, 0, 0)
        Me.Date_Final.Name = "Date_Final"
        Me.Date_Final.Size = New System.Drawing.Size(99, 20)
        Me.Date_Final.TabIndex = 61
        Me.Date_Final.Value = New Date(2016, 3, 10, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(699, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 15)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "hasta: "
        '
        'Date_Inicio
        '
        Me.Date_Inicio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Date_Inicio.Location = New System.Drawing.Point(594, 122)
        Me.Date_Inicio.Name = "Date_Inicio"
        Me.Date_Inicio.Size = New System.Drawing.Size(99, 20)
        Me.Date_Inicio.TabIndex = 63
        Me.Date_Inicio.Value = New Date(2016, 3, 12, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(541, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 15)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "desde: "
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(644, 78)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(155, 21)
        Me.ComboBox1.TabIndex = 65
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(32, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 16)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Credito disponible:"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 404)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 16)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "Estado del crédito: "
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(33, 360)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 16)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "Deuda: "
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 16)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Departamento: "
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(32, 173)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 16)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "Identificación:"
        '
        'Lb_disponible
        '
        Me.Lb_disponible.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lb_disponible.AutoSize = True
        Me.Lb_disponible.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_disponible.Location = New System.Drawing.Point(194, 286)
        Me.Lb_disponible.Name = "Lb_disponible"
        Me.Lb_disponible.Size = New System.Drawing.Size(0, 20)
        Me.Lb_disponible.TabIndex = 82
        '
        'Lb_deuda
        '
        Me.Lb_deuda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lb_deuda.AutoSize = True
        Me.Lb_deuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_deuda.Location = New System.Drawing.Point(191, 360)
        Me.Lb_deuda.Name = "Lb_deuda"
        Me.Lb_deuda.Size = New System.Drawing.Size(0, 22)
        Me.Lb_deuda.TabIndex = 80
        '
        'Lb_departamento
        '
        Me.Lb_departamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lb_departamento.AutoSize = True
        Me.Lb_departamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_departamento.Location = New System.Drawing.Point(194, 249)
        Me.Lb_departamento.Name = "Lb_departamento"
        Me.Lb_departamento.Size = New System.Drawing.Size(10, 13)
        Me.Lb_departamento.TabIndex = 79
        Me.Lb_departamento.Text = " "
        '
        'Lb_id
        '
        Me.Lb_id.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lb_id.AutoSize = True
        Me.Lb_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_id.Location = New System.Drawing.Point(194, 173)
        Me.Lb_id.Name = "Lb_id"
        Me.Lb_id.Size = New System.Drawing.Size(0, 17)
        Me.Lb_id.TabIndex = 77
        '
        'Lb_email
        '
        Me.Lb_email.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lb_email.AutoSize = True
        Me.Lb_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_email.Location = New System.Drawing.Point(194, 213)
        Me.Lb_email.Name = "Lb_email"
        Me.Lb_email.Size = New System.Drawing.Size(0, 17)
        Me.Lb_email.TabIndex = 84
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(33, 213)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 16)
        Me.Label12.TabIndex = 83
        Me.Label12.Text = "Email: "
        '
        'Lb_limite
        '
        Me.Lb_limite.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lb_limite.AutoSize = True
        Me.Lb_limite.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_limite.Location = New System.Drawing.Point(194, 322)
        Me.Lb_limite.Name = "Lb_limite"
        Me.Lb_limite.Size = New System.Drawing.Size(0, 20)
        Me.Lb_limite.TabIndex = 86
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(33, 322)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 16)
        Me.Label13.TabIndex = 85
        Me.Label13.Text = "Limite Credito:"
        '
        'Lb_NombreP
        '
        Me.Lb_NombreP.AutoSize = True
        Me.Lb_NombreP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Lb_NombreP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Lb_NombreP.Location = New System.Drawing.Point(32, 104)
        Me.Lb_NombreP.Name = "Lb_NombreP"
        Me.Lb_NombreP.Size = New System.Drawing.Size(0, 24)
        Me.Lb_NombreP.TabIndex = 87
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(33, 445)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 16)
        Me.Label11.TabIndex = 88
        Me.Label11.Text = "Notas: "
        '
        'Lb_notas
        '
        Me.Lb_notas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lb_notas.HideSelection = False
        Me.Lb_notas.Location = New System.Drawing.Point(197, 440)
        Me.Lb_notas.Multiline = True
        Me.Lb_notas.Name = "Lb_notas"
        Me.Lb_notas.ReadOnly = True
        Me.Lb_notas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Lb_notas.Size = New System.Drawing.Size(260, 83)
        Me.Lb_notas.TabIndex = 89
        '
        'Btn_Modificar
        '
        Me.Btn_Modificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Modificar.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen
        Me.Btn_Modificar.FlatAppearance.BorderSize = 3
        Me.Btn_Modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Modificar.Location = New System.Drawing.Point(35, 44)
        Me.Btn_Modificar.Name = "Btn_Modificar"
        Me.Btn_Modificar.Size = New System.Drawing.Size(126, 45)
        Me.Btn_Modificar.TabIndex = 90
        Me.Btn_Modificar.Text = "Modificar Información"
        Me.Btn_Modificar.UseVisualStyleBackColor = False
        '
        'Pb_estado
        '
        Me.Pb_estado.Location = New System.Drawing.Point(194, 384)
        Me.Pb_estado.Name = "Pb_estado"
        Me.Pb_estado.Size = New System.Drawing.Size(50, 50)
        Me.Pb_estado.TabIndex = 91
        Me.Pb_estado.TabStop = False
        '
        'Btn_menuPrincipal
        '
        Me.Btn_menuPrincipal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_menuPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Btn_menuPrincipal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_menuPrincipal.Location = New System.Drawing.Point(724, 535)
        Me.Btn_menuPrincipal.Name = "Btn_menuPrincipal"
        Me.Btn_menuPrincipal.Size = New System.Drawing.Size(123, 42)
        Me.Btn_menuPrincipal.TabIndex = 92
        Me.Btn_menuPrincipal.Text = "Menú Principal"
        Me.Btn_menuPrincipal.UseVisualStyleBackColor = True
        '
        'UsuariosDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 589)
        Me.Controls.Add(Me.Btn_menuPrincipal)
        Me.Controls.Add(Me.Pb_estado)
        Me.Controls.Add(Me.Btn_Modificar)
        Me.Controls.Add(Me.Lb_notas)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Lb_NombreP)
        Me.Controls.Add(Me.Lb_limite)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Lb_email)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Lb_disponible)
        Me.Controls.Add(Me.Lb_deuda)
        Me.Controls.Add(Me.Lb_departamento)
        Me.Controls.Add(Me.Lb_id)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Date_Inicio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Date_Final)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(882, 554)
        Me.Name = "UsuariosDetalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalles de Usuario"
        CType(Me.Pb_estado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Date_Final As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Date_Inicio As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Lb_disponible As Label
    Friend WithEvents Lb_deuda As Label
    Friend WithEvents Lb_departamento As Label
    Friend WithEvents Lb_id As Label
    Friend WithEvents Lb_email As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Lb_limite As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Lb_NombreP As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Lb_notas As TextBox
    Friend WithEvents Btn_Modificar As Button
    Friend WithEvents Pb_estado As PictureBox
    Friend WithEvents Btn_menuPrincipal As Button
End Class
