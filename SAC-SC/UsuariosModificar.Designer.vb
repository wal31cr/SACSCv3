<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsuariosModificar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsuariosModificar))
        Me.TextBox_nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Btn_cancelar = New System.Windows.Forms.Button()
        Me.Btn_guardar = New System.Windows.Forms.Button()
        Me.TextBox_apellidos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Lb_identificacion = New System.Windows.Forms.Label()
        Me.ComboBox_departamentos = New System.Windows.Forms.ComboBox()
        Me.TextBox_email = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_limite = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Btn_bloq_desbloq = New System.Windows.Forms.Button()
        Me.Lb_notas = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Pb_estado = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SkinEngine1 = New Sunisoft.IrisSkin.SkinEngine(CType(Me, System.ComponentModel.Component))
        CType(Me.Pb_estado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox_nombre
        '
        Me.TextBox_nombre.Location = New System.Drawing.Point(226, 159)
        Me.TextBox_nombre.Name = "TextBox_nombre"
        Me.TextBox_nombre.Size = New System.Drawing.Size(260, 20)
        Me.TextBox_nombre.TabIndex = 80
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 304)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Departamento: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(78, 159)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 16)
        Me.Label9.TabIndex = 85
        Me.Label9.Text = "Nombre: "
        '
        'Btn_cancelar
        '
        Me.Btn_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_cancelar.Location = New System.Drawing.Point(316, 546)
        Me.Btn_cancelar.Name = "Btn_cancelar"
        Me.Btn_cancelar.Size = New System.Drawing.Size(116, 46)
        Me.Btn_cancelar.TabIndex = 88
        Me.Btn_cancelar.Text = "Cancelar"
        Me.Btn_cancelar.UseVisualStyleBackColor = True
        '
        'Btn_guardar
        '
        Me.Btn_guardar.Enabled = False
        Me.Btn_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_guardar.Location = New System.Drawing.Point(438, 546)
        Me.Btn_guardar.Name = "Btn_guardar"
        Me.Btn_guardar.Size = New System.Drawing.Size(116, 46)
        Me.Btn_guardar.TabIndex = 87
        Me.Btn_guardar.Text = "Guardar"
        Me.Btn_guardar.UseVisualStyleBackColor = True
        '
        'TextBox_apellidos
        '
        Me.TextBox_apellidos.Location = New System.Drawing.Point(226, 194)
        Me.TextBox_apellidos.Name = "TextBox_apellidos"
        Me.TextBox_apellidos.Size = New System.Drawing.Size(260, 20)
        Me.TextBox_apellidos.TabIndex = 81
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(77, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Apellidos: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(77, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "Cédula: "
        '
        'Lb_identificacion
        '
        Me.Lb_identificacion.AutoSize = True
        Me.Lb_identificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_identificacion.Location = New System.Drawing.Point(224, 123)
        Me.Lb_identificacion.Name = "Lb_identificacion"
        Me.Lb_identificacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lb_identificacion.Size = New System.Drawing.Size(0, 17)
        Me.Lb_identificacion.TabIndex = 95
        '
        'ComboBox_departamentos
        '
        Me.ComboBox_departamentos.FormattingEnabled = True
        Me.ComboBox_departamentos.Location = New System.Drawing.Point(226, 305)
        Me.ComboBox_departamentos.Name = "ComboBox_departamentos"
        Me.ComboBox_departamentos.Size = New System.Drawing.Size(260, 21)
        Me.ComboBox_departamentos.TabIndex = 84
        '
        'TextBox_email
        '
        Me.TextBox_email.Location = New System.Drawing.Point(227, 230)
        Me.TextBox_email.Name = "TextBox_email"
        Me.TextBox_email.Size = New System.Drawing.Size(259, 20)
        Me.TextBox_email.TabIndex = 82
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(78, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 16)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Email"
        '
        'TextBox_limite
        '
        Me.TextBox_limite.Location = New System.Drawing.Point(227, 266)
        Me.TextBox_limite.Name = "TextBox_limite"
        Me.TextBox_limite.Size = New System.Drawing.Size(259, 20)
        Me.TextBox_limite.TabIndex = 83
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(78, 266)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 16)
        Me.Label10.TabIndex = 99
        Me.Label10.Text = "Limite Crédito"
        '
        'Btn_bloq_desbloq
        '
        Me.Btn_bloq_desbloq.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_bloq_desbloq.Location = New System.Drawing.Point(80, 465)
        Me.Btn_bloq_desbloq.Name = "Btn_bloq_desbloq"
        Me.Btn_bloq_desbloq.Size = New System.Drawing.Size(117, 50)
        Me.Btn_bloq_desbloq.TabIndex = 79
        Me.Btn_bloq_desbloq.UseVisualStyleBackColor = True
        '
        'Lb_notas
        '
        Me.Lb_notas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lb_notas.HideSelection = False
        Me.Lb_notas.Location = New System.Drawing.Point(227, 343)
        Me.Lb_notas.MaxLength = 500
        Me.Lb_notas.Multiline = True
        Me.Lb_notas.Name = "Lb_notas"
        Me.Lb_notas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Lb_notas.Size = New System.Drawing.Size(260, 58)
        Me.Lb_notas.TabIndex = 85
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(77, 376)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 16)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "Notas:  "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(224, 482)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 16)
        Me.Label11.TabIndex = 104
        Me.Label11.Text = "Estado: "
        '
        'Pb_estado
        '
        Me.Pb_estado.Location = New System.Drawing.Point(292, 465)
        Me.Pb_estado.Name = "Pb_estado"
        Me.Pb_estado.Size = New System.Drawing.Size(50, 50)
        Me.Pb_estado.TabIndex = 105
        Me.Pb_estado.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 28.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(199, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(366, 46)
        Me.Label6.TabIndex = 155
        Me.Label6.Text = "Modificar Distribuidor"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(204, 102)
        Me.PictureBox2.TabIndex = 154
        Me.PictureBox2.TabStop = False
        '
        'SkinEngine1
        '
        Me.SkinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA=="
        Me.SkinEngine1.SkinFile = "C:\Users\Mao\Source\Repos\SACSCv3\MidsummerColor1.ssk"
        Me.SkinEngine1.SkinStreamMain = CType(resources.GetObject("SkinEngine1.SkinStreamMain"), System.IO.Stream)
        '
        'UsuariosModificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 617)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Pb_estado)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Lb_notas)
        Me.Controls.Add(Me.Btn_bloq_desbloq)
        Me.Controls.Add(Me.TextBox_limite)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox_email)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox_departamentos)
        Me.Controls.Add(Me.Lb_identificacion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox_apellidos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox_nombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Btn_cancelar)
        Me.Controls.Add(Me.Btn_guardar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UsuariosModificar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios Modificar"
        CType(Me.Pb_estado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox_nombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Btn_cancelar As Button
    Friend WithEvents Btn_guardar As Button
    Friend WithEvents TextBox_apellidos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Lb_identificacion As Label
    Friend WithEvents ComboBox_departamentos As ComboBox
    Friend WithEvents TextBox_email As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_limite As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Btn_bloq_desbloq As Button
    Friend WithEvents Lb_notas As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Pb_estado As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents SkinEngine1 As Sunisoft.IrisSkin.SkinEngine
End Class
