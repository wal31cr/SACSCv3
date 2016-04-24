<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComprasInventario
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ComprasInventario))
        Me.Btn_menuPrincipal = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_factura = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox_distribuidor = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Date_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox_tipoFactura = New System.Windows.Forms.ComboBox()
        Me.ListView_Detalles = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox_codigoP = New System.Windows.Forms.TextBox()
        Me.Label_CodigoP = New System.Windows.Forms.Label()
        Me.Label_NombreP = New System.Windows.Forms.Label()
        Me.TextBox_NombreP = New System.Windows.Forms.TextBox()
        Me.TextBox_cantidad = New System.Windows.Forms.TextBox()
        Me.Label1_cantidad = New System.Windows.Forms.Label()
        Me.TextBox_costo = New System.Windows.Forms.TextBox()
        Me.Label_costo = New System.Windows.Forms.Label()
        Me.Label_Descripcion = New System.Windows.Forms.Label()
        Me.TextBox_descripcion = New System.Windows.Forms.TextBox()
        Me.Btn_guardarF = New System.Windows.Forms.Button()
        Me.ListView_Flotante = New System.Windows.Forms.ListView()
        Me.Label_total_FSD = New System.Windows.Forms.Label()
        Me.TextBox_totalFSD = New System.Windows.Forms.TextBox()
        Me.Label_TotalDetalle = New System.Windows.Forms.Label()
        Me.Label_MontoTotalDetalle = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label_excento = New System.Windows.Forms.Label()
        Me.CheckBox_excento = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SkinEngine1 = New Sunisoft.IrisSkin.SkinEngine(CType(Me, System.ComponentModel.Component))
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_menuPrincipal
        '
        Me.Btn_menuPrincipal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_menuPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Btn_menuPrincipal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_menuPrincipal.Location = New System.Drawing.Point(39, 572)
        Me.Btn_menuPrincipal.Name = "Btn_menuPrincipal"
        Me.Btn_menuPrincipal.Size = New System.Drawing.Size(123, 42)
        Me.Btn_menuPrincipal.TabIndex = 71
        Me.Btn_menuPrincipal.Text = "Menú Principal"
        Me.Btn_menuPrincipal.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "N° Factura"
        '
        'TextBox_factura
        '
        Me.TextBox_factura.Location = New System.Drawing.Point(113, 130)
        Me.TextBox_factura.Name = "TextBox_factura"
        Me.TextBox_factura.Size = New System.Drawing.Size(109, 20)
        Me.TextBox_factura.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(228, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 15)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Distribuidor"
        '
        'ComboBox_distribuidor
        '
        Me.ComboBox_distribuidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_distribuidor.FormattingEnabled = True
        Me.ComboBox_distribuidor.Location = New System.Drawing.Point(309, 130)
        Me.ComboBox_distribuidor.Name = "ComboBox_distribuidor"
        Me.ComboBox_distribuidor.Size = New System.Drawing.Size(320, 24)
        Me.ComboBox_distribuidor.TabIndex = 59
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(635, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 15)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Fecha Compra"
        '
        'Date_Fecha
        '
        Me.Date_Fecha.Location = New System.Drawing.Point(737, 131)
        Me.Date_Fecha.Name = "Date_Fecha"
        Me.Date_Fecha.Size = New System.Drawing.Size(99, 20)
        Me.Date_Fecha.TabIndex = 60
        Me.Date_Fecha.Value = New Date(2016, 3, 12, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(37, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 15)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Tipo Factura"
        '
        'ComboBox_tipoFactura
        '
        Me.ComboBox_tipoFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_tipoFactura.FormattingEnabled = True
        Me.ComboBox_tipoFactura.Location = New System.Drawing.Point(130, 184)
        Me.ComboBox_tipoFactura.Name = "ComboBox_tipoFactura"
        Me.ComboBox_tipoFactura.Size = New System.Drawing.Size(143, 26)
        Me.ComboBox_tipoFactura.TabIndex = 61
        '
        'ListView_Detalles
        '
        Me.ListView_Detalles.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView_Detalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView_Detalles.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView_Detalles.FullRowSelect = True
        Me.ListView_Detalles.Location = New System.Drawing.Point(40, 317)
        Me.ListView_Detalles.Name = "ListView_Detalles"
        Me.ListView_Detalles.Size = New System.Drawing.Size(778, 168)
        Me.ListView_Detalles.TabIndex = 67
        Me.ToolTip1.SetToolTip(Me.ListView_Detalles, " Doble click para eliminar fila" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Click Derecho para modificar")
        Me.ListView_Detalles.UseCompatibleStateImageBehavior = False
        Me.ListView_Detalles.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(126, 26)
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'TextBox_codigoP
        '
        Me.TextBox_codigoP.Location = New System.Drawing.Point(40, 268)
        Me.TextBox_codigoP.Name = "TextBox_codigoP"
        Me.TextBox_codigoP.Size = New System.Drawing.Size(109, 20)
        Me.TextBox_codigoP.TabIndex = 62
        Me.TextBox_codigoP.Visible = False
        '
        'Label_CodigoP
        '
        Me.Label_CodigoP.AutoSize = True
        Me.Label_CodigoP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_CodigoP.Location = New System.Drawing.Point(37, 240)
        Me.Label_CodigoP.Name = "Label_CodigoP"
        Me.Label_CodigoP.Size = New System.Drawing.Size(113, 15)
        Me.Label_CodigoP.TabIndex = 68
        Me.Label_CodigoP.Text = "Codigo Producto"
        Me.Label_CodigoP.Visible = False
        '
        'Label_NombreP
        '
        Me.Label_NombreP.AutoSize = True
        Me.Label_NombreP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_NombreP.Location = New System.Drawing.Point(268, 240)
        Me.Label_NombreP.Name = "Label_NombreP"
        Me.Label_NombreP.Size = New System.Drawing.Size(119, 15)
        Me.Label_NombreP.TabIndex = 70
        Me.Label_NombreP.Text = "Nombre Producto"
        Me.Label_NombreP.Visible = False
        '
        'TextBox_NombreP
        '
        Me.TextBox_NombreP.Location = New System.Drawing.Point(157, 268)
        Me.TextBox_NombreP.Name = "TextBox_NombreP"
        Me.TextBox_NombreP.Size = New System.Drawing.Size(360, 20)
        Me.TextBox_NombreP.TabIndex = 63
        Me.TextBox_NombreP.Visible = False
        '
        'TextBox_cantidad
        '
        Me.TextBox_cantidad.Location = New System.Drawing.Point(523, 268)
        Me.TextBox_cantidad.Name = "TextBox_cantidad"
        Me.TextBox_cantidad.Size = New System.Drawing.Size(80, 20)
        Me.TextBox_cantidad.TabIndex = 65
        Me.TextBox_cantidad.Visible = False
        '
        'Label1_cantidad
        '
        Me.Label1_cantidad.AutoSize = True
        Me.Label1_cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_cantidad.Location = New System.Drawing.Point(530, 240)
        Me.Label1_cantidad.Name = "Label1_cantidad"
        Me.Label1_cantidad.Size = New System.Drawing.Size(68, 15)
        Me.Label1_cantidad.TabIndex = 72
        Me.Label1_cantidad.Text = "Unidades"
        Me.Label1_cantidad.Visible = False
        '
        'TextBox_costo
        '
        Me.TextBox_costo.Location = New System.Drawing.Point(638, 268)
        Me.TextBox_costo.Name = "TextBox_costo"
        Me.TextBox_costo.Size = New System.Drawing.Size(106, 20)
        Me.TextBox_costo.TabIndex = 67
        Me.TextBox_costo.Visible = False
        '
        'Label_costo
        '
        Me.Label_costo.AutoSize = True
        Me.Label_costo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_costo.Location = New System.Drawing.Point(656, 240)
        Me.Label_costo.Name = "Label_costo"
        Me.Label_costo.Size = New System.Drawing.Size(79, 15)
        Me.Label_costo.TabIndex = 74
        Me.Label_costo.Text = "Costo Total"
        Me.Label_costo.Visible = False
        '
        'Label_Descripcion
        '
        Me.Label_Descripcion.AutoSize = True
        Me.Label_Descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Descripcion.Location = New System.Drawing.Point(36, 225)
        Me.Label_Descripcion.Name = "Label_Descripcion"
        Me.Label_Descripcion.Size = New System.Drawing.Size(186, 15)
        Me.Label_Descripcion.TabIndex = 77
        Me.Label_Descripcion.Text = "Descripción Factura (Notas)"
        Me.Label_Descripcion.Visible = False
        '
        'TextBox_descripcion
        '
        Me.TextBox_descripcion.Location = New System.Drawing.Point(40, 258)
        Me.TextBox_descripcion.Multiline = True
        Me.TextBox_descripcion.Name = "TextBox_descripcion"
        Me.TextBox_descripcion.Size = New System.Drawing.Size(414, 164)
        Me.TextBox_descripcion.TabIndex = 68
        Me.TextBox_descripcion.Visible = False
        '
        'Btn_guardarF
        '
        Me.Btn_guardarF.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_guardarF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Btn_guardarF.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_guardarF.Location = New System.Drawing.Point(664, 572)
        Me.Btn_guardarF.Name = "Btn_guardarF"
        Me.Btn_guardarF.Size = New System.Drawing.Size(154, 42)
        Me.Btn_guardarF.TabIndex = 70
        Me.Btn_guardarF.Text = "Guardar Factura"
        Me.Btn_guardarF.UseVisualStyleBackColor = True
        Me.Btn_guardarF.Visible = False
        '
        'ListView_Flotante
        '
        Me.ListView_Flotante.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView_Flotante.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView_Flotante.FullRowSelect = True
        Me.ListView_Flotante.Location = New System.Drawing.Point(157, 290)
        Me.ListView_Flotante.Name = "ListView_Flotante"
        Me.ListView_Flotante.Size = New System.Drawing.Size(360, 121)
        Me.ListView_Flotante.TabIndex = 64
        Me.ToolTip1.SetToolTip(Me.ListView_Flotante, "Doble click para añadir producto a las cajas de texto")
        Me.ListView_Flotante.UseCompatibleStateImageBehavior = False
        Me.ListView_Flotante.Visible = False
        '
        'Label_total_FSD
        '
        Me.Label_total_FSD.AutoSize = True
        Me.Label_total_FSD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_total_FSD.Location = New System.Drawing.Point(600, 225)
        Me.Label_total_FSD.Name = "Label_total_FSD"
        Me.Label_total_FSD.Size = New System.Drawing.Size(69, 15)
        Me.Label_total_FSD.TabIndex = 79
        Me.Label_total_FSD.Text = "Total (IVI)"
        Me.Label_total_FSD.Visible = False
        '
        'TextBox_totalFSD
        '
        Me.TextBox_totalFSD.Location = New System.Drawing.Point(569, 258)
        Me.TextBox_totalFSD.Name = "TextBox_totalFSD"
        Me.TextBox_totalFSD.Size = New System.Drawing.Size(134, 20)
        Me.TextBox_totalFSD.TabIndex = 69
        Me.TextBox_totalFSD.Visible = False
        '
        'Label_TotalDetalle
        '
        Me.Label_TotalDetalle.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label_TotalDetalle.AutoSize = True
        Me.Label_TotalDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TotalDetalle.Location = New System.Drawing.Point(644, 505)
        Me.Label_TotalDetalle.Name = "Label_TotalDetalle"
        Me.Label_TotalDetalle.Size = New System.Drawing.Size(59, 20)
        Me.Label_TotalDetalle.TabIndex = 80
        Me.Label_TotalDetalle.Text = "Total: "
        Me.Label_TotalDetalle.Visible = False
        '
        'Label_MontoTotalDetalle
        '
        Me.Label_MontoTotalDetalle.AutoSize = True
        Me.Label_MontoTotalDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_MontoTotalDetalle.Location = New System.Drawing.Point(706, 505)
        Me.Label_MontoTotalDetalle.Name = "Label_MontoTotalDetalle"
        Me.Label_MontoTotalDetalle.Size = New System.Drawing.Size(0, 20)
        Me.Label_MontoTotalDetalle.TabIndex = 81
        Me.Label_MontoTotalDetalle.Visible = False
        '
        'Label_excento
        '
        Me.Label_excento.AutoSize = True
        Me.Label_excento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_excento.Location = New System.Drawing.Point(752, 240)
        Me.Label_excento.Name = "Label_excento"
        Me.Label_excento.Size = New System.Drawing.Size(84, 15)
        Me.Label_excento.TabIndex = 82
        Me.Label_excento.Text = "Excento (IV)"
        Me.Label_excento.Visible = False
        '
        'CheckBox_excento
        '
        Me.CheckBox_excento.AutoSize = True
        Me.CheckBox_excento.Location = New System.Drawing.Point(766, 270)
        Me.CheckBox_excento.Name = "CheckBox_excento"
        Me.CheckBox_excento.Size = New System.Drawing.Size(54, 17)
        Me.CheckBox_excento.TabIndex = 68
        Me.CheckBox_excento.Text = "Sin IV"
        Me.CheckBox_excento.UseVisualStyleBackColor = True
        Me.CheckBox_excento.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(199, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(415, 59)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Compras Inventario"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(253, 102)
        Me.PictureBox1.TabIndex = 84
        Me.PictureBox1.TabStop = False
        '
        'SkinEngine1
        '
        Me.SkinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA=="
        Me.SkinEngine1.SkinFile = "C:\Users\Mao\Source\Repos\SACSCv3\MidsummerColor1.ssk"
        Me.SkinEngine1.SkinStreamMain = CType(resources.GetObject("SkinEngine1.SkinStreamMain"), System.IO.Stream)
        '
        'ComprasInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 626)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CheckBox_excento)
        Me.Controls.Add(Me.Label_excento)
        Me.Controls.Add(Me.Label_MontoTotalDetalle)
        Me.Controls.Add(Me.Label_TotalDetalle)
        Me.Controls.Add(Me.TextBox_totalFSD)
        Me.Controls.Add(Me.Label_total_FSD)
        Me.Controls.Add(Me.ListView_Flotante)
        Me.Controls.Add(Me.Btn_guardarF)
        Me.Controls.Add(Me.TextBox_descripcion)
        Me.Controls.Add(Me.Label_Descripcion)
        Me.Controls.Add(Me.TextBox_costo)
        Me.Controls.Add(Me.Label_costo)
        Me.Controls.Add(Me.TextBox_cantidad)
        Me.Controls.Add(Me.Label1_cantidad)
        Me.Controls.Add(Me.TextBox_NombreP)
        Me.Controls.Add(Me.Label_NombreP)
        Me.Controls.Add(Me.TextBox_codigoP)
        Me.Controls.Add(Me.Label_CodigoP)
        Me.Controls.Add(Me.ListView_Detalles)
        Me.Controls.Add(Me.ComboBox_tipoFactura)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Date_Fecha)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox_distribuidor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox_factura)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Btn_menuPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ComprasInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ComprasInventario"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_menuPrincipal As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_factura As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox_distribuidor As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Date_Fecha As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox_tipoFactura As ComboBox
    Friend WithEvents ListView_Detalles As ListView
    Friend WithEvents TextBox_codigoP As TextBox
    Friend WithEvents Label_CodigoP As Label
    Friend WithEvents Label_NombreP As Label
    Friend WithEvents TextBox_NombreP As TextBox
    Friend WithEvents TextBox_cantidad As TextBox
    Friend WithEvents Label1_cantidad As Label
    Friend WithEvents TextBox_costo As TextBox
    Friend WithEvents Label_costo As Label
    Friend WithEvents Label_Descripcion As Label
    Friend WithEvents TextBox_descripcion As TextBox
    Friend WithEvents Btn_guardarF As Button
    Friend WithEvents ListView_Flotante As ListView
    Friend WithEvents Label_total_FSD As Label
    Friend WithEvents TextBox_totalFSD As TextBox
    Friend WithEvents Label_TotalDetalle As Label
    Friend WithEvents Label_MontoTotalDetalle As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label_excento As Label
    Friend WithEvents CheckBox_excento As CheckBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SkinEngine1 As Sunisoft.IrisSkin.SkinEngine
End Class
