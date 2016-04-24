<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductoModificar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductoModificar))
        Me.Label_precioSugerido = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label_costo = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label_codigoProducto = New System.Windows.Forms.Label()
        Me.TextBox_minStock = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button_guardar = New System.Windows.Forms.Button()
        Me.ComboBox_categoria = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_precioVenta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_NombreP = New System.Windows.Forms.TextBox()
        Me.Label_2 = New System.Windows.Forms.Label()
        Me.TextBox_stock = New System.Windows.Forms.TextBox()
        Me.Button_cancelar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox_porcentaje = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox_UltiCompra = New System.Windows.Forms.Label()
        Me.TextBox_PenultCompra = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SkinEngine1 = New Sunisoft.IrisSkin.SkinEngine(CType(Me, System.ComponentModel.Component))
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_precioSugerido
        '
        Me.Label_precioSugerido.AutoSize = True
        Me.Label_precioSugerido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_precioSugerido.Location = New System.Drawing.Point(200, 279)
        Me.Label_precioSugerido.Name = "Label_precioSugerido"
        Me.Label_precioSugerido.Size = New System.Drawing.Size(0, 17)
        Me.Label_precioSugerido.TabIndex = 129
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(81, 279)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 15)
        Me.Label8.TabIndex = 128
        Me.Label8.Text = "Precio sugerido"
        '
        'Label_costo
        '
        Me.Label_costo.AutoSize = True
        Me.Label_costo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_costo.Location = New System.Drawing.Point(363, 321)
        Me.Label_costo.Name = "Label_costo"
        Me.Label_costo.Size = New System.Drawing.Size(0, 17)
        Me.Label_costo.TabIndex = 127
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(50, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 15)
        Me.Label6.TabIndex = 126
        Me.Label6.Text = "Costo última compra"
        '
        'Label_codigoProducto
        '
        Me.Label_codigoProducto.AutoSize = True
        Me.Label_codigoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_codigoProducto.Location = New System.Drawing.Point(200, 91)
        Me.Label_codigoProducto.Name = "Label_codigoProducto"
        Me.Label_codigoProducto.Size = New System.Drawing.Size(0, 17)
        Me.Label_codigoProducto.TabIndex = 125
        '
        'TextBox_minStock
        '
        Me.TextBox_minStock.Location = New System.Drawing.Point(203, 213)
        Me.TextBox_minStock.Name = "TextBox_minStock"
        Me.TextBox_minStock.Size = New System.Drawing.Size(301, 20)
        Me.TextBox_minStock.TabIndex = 101
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(75, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 15)
        Me.Label4.TabIndex = 123
        Me.Label4.Text = "Minimo en Stock"
        '
        'Button_guardar
        '
        Me.Button_guardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_guardar.Location = New System.Drawing.Point(398, 410)
        Me.Button_guardar.Name = "Button_guardar"
        Me.Button_guardar.Size = New System.Drawing.Size(106, 35)
        Me.Button_guardar.TabIndex = 105
        Me.Button_guardar.Text = "Guardar"
        Me.Button_guardar.UseVisualStyleBackColor = False
        '
        'ComboBox_categoria
        '
        Me.ComboBox_categoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_categoria.FormattingEnabled = True
        Me.ComboBox_categoria.Location = New System.Drawing.Point(203, 356)
        Me.ComboBox_categoria.Name = "ComboBox_categoria"
        Me.ComboBox_categoria.Size = New System.Drawing.Size(301, 24)
        Me.ComboBox_categoria.TabIndex = 104
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(120, 359)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 15)
        Me.Label7.TabIndex = 122
        Me.Label7.Text = "Categoria"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(91, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "Codigo Barras"
        '
        'TextBox_precioVenta
        '
        Me.TextBox_precioVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_precioVenta.Location = New System.Drawing.Point(203, 320)
        Me.TextBox_precioVenta.Name = "TextBox_precioVenta"
        Me.TextBox_precioVenta.Size = New System.Drawing.Size(301, 23)
        Me.TextBox_precioVenta.TabIndex = 103
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(103, 321)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 15)
        Me.Label5.TabIndex = 119
        Me.Label5.Text = "Precio venta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(66, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 15)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "Cantidad en Stock"
        '
        'TextBox_NombreP
        '
        Me.TextBox_NombreP.Location = New System.Drawing.Point(203, 147)
        Me.TextBox_NombreP.Name = "TextBox_NombreP"
        Me.TextBox_NombreP.Size = New System.Drawing.Size(301, 20)
        Me.TextBox_NombreP.TabIndex = 100
        '
        'Label_2
        '
        Me.Label_2.AutoSize = True
        Me.Label_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_2.Location = New System.Drawing.Point(70, 147)
        Me.Label_2.Name = "Label_2"
        Me.Label_2.Size = New System.Drawing.Size(119, 15)
        Me.Label_2.TabIndex = 117
        Me.Label_2.Text = "Nombre Producto"
        '
        'TextBox_stock
        '
        Me.TextBox_stock.Enabled = False
        Me.TextBox_stock.Location = New System.Drawing.Point(203, 180)
        Me.TextBox_stock.Name = "TextBox_stock"
        Me.TextBox_stock.Size = New System.Drawing.Size(301, 20)
        Me.TextBox_stock.TabIndex = 130
        '
        'Button_cancelar
        '
        Me.Button_cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.Button_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_cancelar.Location = New System.Drawing.Point(257, 410)
        Me.Button_cancelar.Name = "Button_cancelar"
        Me.Button_cancelar.Size = New System.Drawing.Size(106, 35)
        Me.Button_cancelar.TabIndex = 106
        Me.Button_cancelar.Text = "Cancelar"
        Me.Button_cancelar.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(323, 281)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 15)
        Me.Label9.TabIndex = 133
        Me.Label9.Text = "Con el %"
        '
        'TextBox_porcentaje
        '
        Me.TextBox_porcentaje.Location = New System.Drawing.Point(393, 282)
        Me.TextBox_porcentaje.Name = "TextBox_porcentaje"
        Me.TextBox_porcentaje.Size = New System.Drawing.Size(111, 20)
        Me.TextBox_porcentaje.TabIndex = 102
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(299, 247)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 15)
        Me.Label10.TabIndex = 136
        Me.Label10.Text = "compra anterior"
        '
        'TextBox_UltiCompra
        '
        Me.TextBox_UltiCompra.AutoSize = True
        Me.TextBox_UltiCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_UltiCompra.Location = New System.Drawing.Point(200, 243)
        Me.TextBox_UltiCompra.Name = "TextBox_UltiCompra"
        Me.TextBox_UltiCompra.Size = New System.Drawing.Size(0, 17)
        Me.TextBox_UltiCompra.TabIndex = 138
        '
        'TextBox_PenultCompra
        '
        Me.TextBox_PenultCompra.AutoSize = True
        Me.TextBox_PenultCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_PenultCompra.Location = New System.Drawing.Point(414, 236)
        Me.TextBox_PenultCompra.Name = "TextBox_PenultCompra"
        Me.TextBox_PenultCompra.Size = New System.Drawing.Size(0, 17)
        Me.TextBox_PenultCompra.TabIndex = 139
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(200, 279)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 17)
        Me.Label11.TabIndex = 140
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(204, 102)
        Me.PictureBox2.TabIndex = 146
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label2.Location = New System.Drawing.Point(199, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 59)
        Me.Label2.TabIndex = 147
        Me.Label2.Text = "Modificar"
        '
        'SkinEngine1
        '
        Me.SkinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA=="
        Me.SkinEngine1.SkinFile = "C:\Users\Mao\Source\Repos\SACSCv3\MidsummerColor1.ssk"
        Me.SkinEngine1.SkinStreamMain = CType(resources.GetObject("SkinEngine1.SkinStreamMain"), System.IO.Stream)
        '
        'ProductoModificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 457)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBox_PenultCompra)
        Me.Controls.Add(Me.TextBox_UltiCompra)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox_porcentaje)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button_cancelar)
        Me.Controls.Add(Me.TextBox_stock)
        Me.Controls.Add(Me.Label_precioSugerido)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label_costo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label_codigoProducto)
        Me.Controls.Add(Me.TextBox_minStock)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button_guardar)
        Me.Controls.Add(Me.ComboBox_categoria)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_precioVenta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox_NombreP)
        Me.Controls.Add(Me.Label_2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ProductoModificar"
        Me.Text = "ProductoModificar"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_precioSugerido As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label_costo As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label_codigoProducto As Label
    Friend WithEvents TextBox_minStock As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button_guardar As Button
    Friend WithEvents ComboBox_categoria As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_precioVenta As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_NombreP As TextBox
    Friend WithEvents Label_2 As Label
    Friend WithEvents TextBox_stock As TextBox
    Friend WithEvents Button_cancelar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox_porcentaje As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox_UltiCompra As Label
    Friend WithEvents TextBox_PenultCompra As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents SkinEngine1 As Sunisoft.IrisSkin.SkinEngine
End Class
