<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nuevoProductoFactura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(nuevoProductoFactura))
        Me.TextBox_precioVenta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_NombreP = New System.Windows.Forms.TextBox()
        Me.Label_2 = New System.Windows.Forms.Label()
        Me.TextBox_codigoP = New System.Windows.Forms.TextBox()
        Me.Label_CodigoP = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox_categoria = New System.Windows.Forms.ComboBox()
        Me.Button_guardar = New System.Windows.Forms.Button()
        Me.TextBox_minStock = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label_cantidad = New System.Windows.Forms.Label()
        Me.Label_codigoProducto = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label_costo = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label_precioSugerido = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SkinEngine1 = New Sunisoft.IrisSkin.SkinEngine(CType(Me, System.ComponentModel.Component))
        Me.SkinEngine2 = New Sunisoft.IrisSkin.SkinEngine(CType(Me, System.ComponentModel.Component))
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox_precioVenta
        '
        Me.TextBox_precioVenta.Location = New System.Drawing.Point(232, 261)
        Me.TextBox_precioVenta.Name = "TextBox_precioVenta"
        Me.TextBox_precioVenta.Size = New System.Drawing.Size(90, 20)
        Me.TextBox_precioVenta.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(49, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 15)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "Precio venta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 15)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "Cantidad"
        '
        'TextBox_NombreP
        '
        Me.TextBox_NombreP.Enabled = False
        Me.TextBox_NombreP.Location = New System.Drawing.Point(232, 124)
        Me.TextBox_NombreP.Name = "TextBox_NombreP"
        Me.TextBox_NombreP.Size = New System.Drawing.Size(214, 20)
        Me.TextBox_NombreP.TabIndex = 10
        '
        'Label_2
        '
        Me.Label_2.AutoSize = True
        Me.Label_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_2.Location = New System.Drawing.Point(49, 124)
        Me.Label_2.Name = "Label_2"
        Me.Label_2.Size = New System.Drawing.Size(119, 15)
        Me.Label_2.TabIndex = 92
        Me.Label_2.Text = "Nombre Producto"
        '
        'TextBox_codigoP
        '
        Me.TextBox_codigoP.Location = New System.Drawing.Point(-145, 93)
        Me.TextBox_codigoP.Name = "TextBox_codigoP"
        Me.TextBox_codigoP.Size = New System.Drawing.Size(109, 20)
        Me.TextBox_codigoP.TabIndex = 83
        Me.TextBox_codigoP.Visible = False
        '
        'Label_CodigoP
        '
        Me.Label_CodigoP.AutoSize = True
        Me.Label_CodigoP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_CodigoP.Location = New System.Drawing.Point(-148, 65)
        Me.Label_CodigoP.Name = "Label_CodigoP"
        Me.Label_CodigoP.Size = New System.Drawing.Size(113, 15)
        Me.Label_CodigoP.TabIndex = 90
        Me.Label_CodigoP.Text = "Codigo Producto"
        Me.Label_CodigoP.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 15)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "Codigo Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label2.Location = New System.Drawing.Point(199, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(279, 29)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Ingresar Productos Nuevos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(49, 304)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 15)
        Me.Label7.TabIndex = 100
        Me.Label7.Text = "Categoria"
        '
        'ComboBox_categoria
        '
        Me.ComboBox_categoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_categoria.FormattingEnabled = True
        Me.ComboBox_categoria.Location = New System.Drawing.Point(232, 297)
        Me.ComboBox_categoria.Name = "ComboBox_categoria"
        Me.ComboBox_categoria.Size = New System.Drawing.Size(214, 24)
        Me.ComboBox_categoria.TabIndex = 13
        '
        'Button_guardar
        '
        Me.Button_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_guardar.Location = New System.Drawing.Point(195, 348)
        Me.Button_guardar.Name = "Button_guardar"
        Me.Button_guardar.Size = New System.Drawing.Size(106, 35)
        Me.Button_guardar.TabIndex = 14
        Me.Button_guardar.Text = "Guardar"
        Me.Button_guardar.UseVisualStyleBackColor = True
        '
        'TextBox_minStock
        '
        Me.TextBox_minStock.Location = New System.Drawing.Point(232, 194)
        Me.TextBox_minStock.Name = "TextBox_minStock"
        Me.TextBox_minStock.Size = New System.Drawing.Size(214, 20)
        Me.TextBox_minStock.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 15)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "Minimo en Stock"
        '
        'Label_cantidad
        '
        Me.Label_cantidad.AutoSize = True
        Me.Label_cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_cantidad.Location = New System.Drawing.Point(229, 162)
        Me.Label_cantidad.Name = "Label_cantidad"
        Me.Label_cantidad.Size = New System.Drawing.Size(0, 17)
        Me.Label_cantidad.TabIndex = 105
        '
        'Label_codigoProducto
        '
        Me.Label_codigoProducto.AutoSize = True
        Me.Label_codigoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_codigoProducto.Location = New System.Drawing.Point(229, 87)
        Me.Label_codigoProducto.Name = "Label_codigoProducto"
        Me.Label_codigoProducto.Size = New System.Drawing.Size(0, 17)
        Me.Label_codigoProducto.TabIndex = 106
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(343, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 15)
        Me.Label6.TabIndex = 107
        Me.Label6.Text = "Costo"
        '
        'Label_costo
        '
        Me.Label_costo.AutoSize = True
        Me.Label_costo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_costo.Location = New System.Drawing.Point(392, 262)
        Me.Label_costo.Name = "Label_costo"
        Me.Label_costo.Size = New System.Drawing.Size(0, 17)
        Me.Label_costo.TabIndex = 108
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(49, 228)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 15)
        Me.Label8.TabIndex = 110
        Me.Label8.Text = "Precio sugerido (20%)"
        '
        'Label_precioSugerido
        '
        Me.Label_precioSugerido.AutoSize = True
        Me.Label_precioSugerido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_precioSugerido.Location = New System.Drawing.Point(229, 226)
        Me.Label_precioSugerido.Name = "Label_precioSugerido"
        Me.Label_precioSugerido.Size = New System.Drawing.Size(0, 17)
        Me.Label_precioSugerido.TabIndex = 111
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(204, 102)
        Me.PictureBox2.TabIndex = 145
        Me.PictureBox2.TabStop = False
        '
        'SkinEngine1
        '
        Me.SkinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA=="
        Me.SkinEngine1.SkinFile = "C:\Users\Mao\Source\Repos\SACSCv3\Midsummer.ssk"
        Me.SkinEngine1.SkinStreamMain = CType(resources.GetObject("SkinEngine1.SkinStreamMain"), System.IO.Stream)
        '
        'SkinEngine2
        '
        Me.SkinEngine2.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA=="
        Me.SkinEngine2.SkinFile = "C:\Users\Mao\Source\Repos\SACSCv3\MidsummerColor1.ssk"
        Me.SkinEngine2.SkinStreamMain = CType(resources.GetObject("SkinEngine2.SkinStreamMain"), System.IO.Stream)
        '
        'nuevoProductoFactura
        '
        Me.AcceptButton = Me.Button_guardar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 422)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label_precioSugerido)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label_costo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label_codigoProducto)
        Me.Controls.Add(Me.Label_cantidad)
        Me.Controls.Add(Me.TextBox_minStock)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button_guardar)
        Me.Controls.Add(Me.ComboBox_categoria)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_precioVenta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox_NombreP)
        Me.Controls.Add(Me.Label_2)
        Me.Controls.Add(Me.TextBox_codigoP)
        Me.Controls.Add(Me.Label_CodigoP)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "nuevoProductoFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "nuevoProductoFactura"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox_precioVenta As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_NombreP As TextBox
    Friend WithEvents Label_2 As Label
    Friend WithEvents TextBox_codigoP As TextBox
    Friend WithEvents Label_CodigoP As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox_categoria As ComboBox
    Friend WithEvents Button_guardar As Button
    Friend WithEvents TextBox_minStock As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label_cantidad As Label
    Friend WithEvents Label_codigoProducto As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label_costo As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label_precioSugerido As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents SkinEngine1 As Sunisoft.IrisSkin.SkinEngine
    Friend WithEvents SkinEngine2 As Sunisoft.IrisSkin.SkinEngine
End Class
