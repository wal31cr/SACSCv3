<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarOrdenCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarOrdenCliente))
        Me.Label_orden = New System.Windows.Forms.Label()
        Me.TextBox_cantidad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox_NombreP = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label_5 = New System.Windows.Forms.Label()
        Me.TextBox_cod = New System.Windows.Forms.TextBox()
        Me.ListView_Flotante = New System.Windows.Forms.ListView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ListView_Detalles = New System.Windows.Forms.ListView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label_vendedor = New System.Windows.Forms.Label()
        Me.Label_cliente = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label_TotalDetalle = New System.Windows.Forms.Label()
        Me.Button_guardar = New System.Windows.Forms.Button()
        Me.Button_cancelar = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_orden
        '
        Me.Label_orden.AutoSize = True
        Me.Label_orden.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_orden.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label_orden.Location = New System.Drawing.Point(29, 20)
        Me.Label_orden.Name = "Label_orden"
        Me.Label_orden.Size = New System.Drawing.Size(143, 31)
        Me.Label_orden.TabIndex = 122
        Me.Label_orden.Text = "Orden N° "
        '
        'TextBox_cantidad
        '
        Me.TextBox_cantidad.Location = New System.Drawing.Point(525, 192)
        Me.TextBox_cantidad.Name = "TextBox_cantidad"
        Me.TextBox_cantidad.Size = New System.Drawing.Size(80, 20)
        Me.TextBox_cantidad.TabIndex = 133
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(531, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 15)
        Me.Label7.TabIndex = 129
        Me.Label7.Text = "Cantidad"
        '
        'TextBox_NombreP
        '
        Me.TextBox_NombreP.Location = New System.Drawing.Point(159, 192)
        Me.TextBox_NombreP.Name = "TextBox_NombreP"
        Me.TextBox_NombreP.Size = New System.Drawing.Size(360, 20)
        Me.TextBox_NombreP.TabIndex = 131
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(279, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 15)
        Me.Label6.TabIndex = 128
        Me.Label6.Text = "Nombre Producto"
        '
        'Label_5
        '
        Me.Label_5.AutoSize = True
        Me.Label_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_5.Location = New System.Drawing.Point(32, 164)
        Me.Label_5.Name = "Label_5"
        Me.Label_5.Size = New System.Drawing.Size(113, 15)
        Me.Label_5.TabIndex = 127
        Me.Label_5.Text = "Codigo Producto"
        '
        'TextBox_cod
        '
        Me.TextBox_cod.Location = New System.Drawing.Point(35, 192)
        Me.TextBox_cod.Name = "TextBox_cod"
        Me.TextBox_cod.Size = New System.Drawing.Size(117, 20)
        Me.TextBox_cod.TabIndex = 130
        '
        'ListView_Flotante
        '
        Me.ListView_Flotante.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView_Flotante.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView_Flotante.FullRowSelect = True
        Me.ListView_Flotante.Location = New System.Drawing.Point(159, 216)
        Me.ListView_Flotante.Name = "ListView_Flotante"
        Me.ListView_Flotante.Size = New System.Drawing.Size(358, 160)
        Me.ListView_Flotante.TabIndex = 132
        Me.ListView_Flotante.UseCompatibleStateImageBehavior = False
        Me.ListView_Flotante.Visible = False
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(416, 461)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 20)
        Me.Label10.TabIndex = 133
        Me.Label10.Text = "Total: "
        '
        'ListView_Detalles
        '
        Me.ListView_Detalles.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView_Detalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView_Detalles.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView_Detalles.FullRowSelect = True
        Me.ListView_Detalles.Location = New System.Drawing.Point(35, 241)
        Me.ListView_Detalles.Name = "ListView_Detalles"
        Me.ListView_Detalles.Size = New System.Drawing.Size(568, 207)
        Me.ListView_Detalles.TabIndex = 132
        Me.ListView_Detalles.UseCompatibleStateImageBehavior = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 123
        Me.Label3.Text = "Vendedor: "
        '
        'Label_vendedor
        '
        Me.Label_vendedor.AutoSize = True
        Me.Label_vendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_vendedor.Location = New System.Drawing.Point(125, 75)
        Me.Label_vendedor.Name = "Label_vendedor"
        Me.Label_vendedor.Size = New System.Drawing.Size(76, 15)
        Me.Label_vendedor.TabIndex = 124
        Me.Label_vendedor.Text = "Vendedor: "
        '
        'Label_cliente
        '
        Me.Label_cliente.AutoSize = True
        Me.Label_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_cliente.Location = New System.Drawing.Point(125, 116)
        Me.Label_cliente.Name = "Label_cliente"
        Me.Label_cliente.Size = New System.Drawing.Size(60, 15)
        Me.Label_cliente.TabIndex = 135
        Me.Label_cliente.Text = "Cliente: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 15)
        Me.Label4.TabIndex = 134
        Me.Label4.Text = "Cliente: "
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
        'Label_TotalDetalle
        '
        Me.Label_TotalDetalle.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label_TotalDetalle.AutoSize = True
        Me.Label_TotalDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TotalDetalle.Location = New System.Drawing.Point(481, 461)
        Me.Label_TotalDetalle.Name = "Label_TotalDetalle"
        Me.Label_TotalDetalle.Size = New System.Drawing.Size(59, 20)
        Me.Label_TotalDetalle.TabIndex = 136
        Me.Label_TotalDetalle.Text = "Total: "
        '
        'Button_guardar
        '
        Me.Button_guardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_guardar.Location = New System.Drawing.Point(499, 506)
        Me.Button_guardar.Name = "Button_guardar"
        Me.Button_guardar.Size = New System.Drawing.Size(106, 35)
        Me.Button_guardar.TabIndex = 137
        Me.Button_guardar.Text = "Guardar"
        Me.Button_guardar.UseVisualStyleBackColor = False
        '
        'Button_cancelar
        '
        Me.Button_cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.Button_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_cancelar.Location = New System.Drawing.Point(378, 506)
        Me.Button_cancelar.Name = "Button_cancelar"
        Me.Button_cancelar.Size = New System.Drawing.Size(106, 35)
        Me.Button_cancelar.TabIndex = 138
        Me.Button_cancelar.Text = "Cancelar"
        Me.Button_cancelar.UseVisualStyleBackColor = False
        '
        'ModificarOrdenCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 553)
        Me.Controls.Add(Me.Button_cancelar)
        Me.Controls.Add(Me.Button_guardar)
        Me.Controls.Add(Me.Label_TotalDetalle)
        Me.Controls.Add(Me.Label_cliente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ListView_Detalles)
        Me.Controls.Add(Me.ListView_Flotante)
        Me.Controls.Add(Me.TextBox_cod)
        Me.Controls.Add(Me.TextBox_cantidad)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox_NombreP)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label_5)
        Me.Controls.Add(Me.Label_vendedor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label_orden)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ModificarOrdenCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ModificarOrdenCliente"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_orden As Label
    Friend WithEvents TextBox_cantidad As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox_NombreP As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label_5 As Label
    Friend WithEvents TextBox_cod As TextBox
    Friend WithEvents ListView_Flotante As ListView
    Friend WithEvents Label10 As Label
    Friend WithEvents ListView_Detalles As ListView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label_vendedor As Label
    Friend WithEvents Label_cliente As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label_TotalDetalle As Label
    Friend WithEvents Button_guardar As Button
    Friend WithEvents Button_cancelar As Button
End Class
