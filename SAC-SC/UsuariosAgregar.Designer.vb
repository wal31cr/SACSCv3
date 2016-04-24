<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsuariosAgregar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsuariosAgregar))
        Me.Txb_email = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txb_nombre = New System.Windows.Forms.TextBox()
        Me.Btn_cancelar = New System.Windows.Forms.Button()
        Me.Btn_enviar = New System.Windows.Forms.Button()
        Me.Txb_apellido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txb_limite = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Comb_departamento = New System.Windows.Forms.ComboBox()
        Me.Txb_identificacion = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SkinEngine1 = New Sunisoft.IrisSkin.SkinEngine(CType(Me, System.ComponentModel.Component))
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txb_email
        '
        Me.Txb_email.Location = New System.Drawing.Point(178, 225)
        Me.Txb_email.Name = "Txb_email"
        Me.Txb_email.Size = New System.Drawing.Size(227, 20)
        Me.Txb_email.TabIndex = 73
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 226)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Email: "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(57, 141)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 16)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "Cédula: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(57, 170)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 16)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Nombre: "
        '
        'Txb_nombre
        '
        Me.Txb_nombre.Location = New System.Drawing.Point(178, 170)
        Me.Txb_nombre.Name = "Txb_nombre"
        Me.Txb_nombre.Size = New System.Drawing.Size(227, 20)
        Me.Txb_nombre.TabIndex = 71
        '
        'Btn_cancelar
        '
        Me.Btn_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_cancelar.Location = New System.Drawing.Point(178, 359)
        Me.Btn_cancelar.Name = "Btn_cancelar"
        Me.Btn_cancelar.Size = New System.Drawing.Size(116, 46)
        Me.Btn_cancelar.TabIndex = 77
        Me.Btn_cancelar.Text = "Cancelar"
        Me.Btn_cancelar.UseVisualStyleBackColor = True
        '
        'Btn_enviar
        '
        Me.Btn_enviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_enviar.Location = New System.Drawing.Point(300, 359)
        Me.Btn_enviar.Name = "Btn_enviar"
        Me.Btn_enviar.Size = New System.Drawing.Size(116, 46)
        Me.Btn_enviar.TabIndex = 76
        Me.Btn_enviar.Text = "Enviar"
        Me.Btn_enviar.UseVisualStyleBackColor = True
        '
        'Txb_apellido
        '
        Me.Txb_apellido.Location = New System.Drawing.Point(178, 197)
        Me.Txb_apellido.Name = "Txb_apellido"
        Me.Txb_apellido.Size = New System.Drawing.Size(227, 20)
        Me.Txb_apellido.TabIndex = 72
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Apellidos: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(57, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Departamento: "
        '
        'Txb_limite
        '
        Me.Txb_limite.Location = New System.Drawing.Point(178, 277)
        Me.Txb_limite.Name = "Txb_limite"
        Me.Txb_limite.Size = New System.Drawing.Size(227, 20)
        Me.Txb_limite.TabIndex = 75
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(57, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 16)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "Limite Crédito: "
        '
        'Comb_departamento
        '
        Me.Comb_departamento.FormattingEnabled = True
        Me.Comb_departamento.Location = New System.Drawing.Point(178, 250)
        Me.Comb_departamento.Name = "Comb_departamento"
        Me.Comb_departamento.Size = New System.Drawing.Size(227, 21)
        Me.Comb_departamento.TabIndex = 74
        '
        'Txb_identificacion
        '
        Me.Txb_identificacion.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.Txb_identificacion.Location = New System.Drawing.Point(178, 137)
        Me.Txb_identificacion.Mask = "9 - 9999 - 9999"
        Me.Txb_identificacion.Name = "Txb_identificacion"
        Me.Txb_identificacion.Size = New System.Drawing.Size(227, 20)
        Me.Txb_identificacion.TabIndex = 70
        Me.Txb_identificacion.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(199, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 59)
        Me.Label5.TabIndex = 151
        Me.Label5.Text = "Agregar"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(204, 102)
        Me.PictureBox2.TabIndex = 150
        Me.PictureBox2.TabStop = False
        '
        'SkinEngine1
        '
        Me.SkinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA=="
        Me.SkinEngine1.SkinFile = "C:\Users\Mao\Source\Repos\SACSCv3\MidsummerColor1.ssk"
        Me.SkinEngine1.SkinStreamMain = CType(resources.GetObject("SkinEngine1.SkinStreamMain"), System.IO.Stream)
        '
        'UsuariosAgregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 461)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Txb_identificacion)
        Me.Controls.Add(Me.Comb_departamento)
        Me.Controls.Add(Me.Txb_limite)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Txb_apellido)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txb_email)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Txb_nombre)
        Me.Controls.Add(Me.Btn_cancelar)
        Me.Controls.Add(Me.Btn_enviar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UsuariosAgregar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios Agregar"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txb_email As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Txb_nombre As TextBox
    Friend WithEvents Btn_cancelar As Button
    Friend WithEvents Btn_enviar As Button
    Friend WithEvents Txb_apellido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Txb_limite As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Comb_departamento As ComboBox
    Friend WithEvents Txb_identificacion As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents SkinEngine1 As Sunisoft.IrisSkin.SkinEngine
End Class
