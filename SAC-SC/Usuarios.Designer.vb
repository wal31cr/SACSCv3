﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuarios))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Btn_agregar = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Btn_menuPrincipal = New System.Windows.Forms.Button()
        Me.Enviar_correo = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Btn_eliminar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SkinEngine1 = New Sunisoft.IrisSkin.SkinEngine(CType(Me, System.ComponentModel.Component))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'Btn_agregar
        '
        resources.ApplyResources(Me.Btn_agregar, "Btn_agregar")
        Me.Btn_agregar.Name = "Btn_agregar"
        Me.Btn_agregar.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.OneClick
        resources.ApplyResources(Me.ListView1, "ListView1")
        Me.ListView1.CheckBoxes = True
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Name = "ListView1"
        Me.ToolTip1.SetToolTip(Me.ListView1, resources.GetString("ListView1.ToolTip"))
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Btn_menuPrincipal
        '
        resources.ApplyResources(Me.Btn_menuPrincipal, "Btn_menuPrincipal")
        Me.Btn_menuPrincipal.Name = "Btn_menuPrincipal"
        Me.Btn_menuPrincipal.UseVisualStyleBackColor = True
        '
        'Enviar_correo
        '
        resources.ApplyResources(Me.Enviar_correo, "Enviar_correo")
        Me.Enviar_correo.Name = "Enviar_correo"
        Me.Enviar_correo.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.Name = "TextBox1"
        '
        'Btn_eliminar
        '
        resources.ApplyResources(Me.Btn_eliminar, "Btn_eliminar")
        Me.Btn_eliminar.Name = "Btn_eliminar"
        Me.Btn_eliminar.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        resources.ApplyResources(Me.CheckBox1, "CheckBox1")
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'PictureBox2
        '
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'SkinEngine1
        '
        Me.SkinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA=="
        Me.SkinEngine1.SkinFile = "C:\Users\Mao\Source\Repos\SACSCv3\MidsummerColor1.ssk"
        Me.SkinEngine1.SkinStreamMain = CType(resources.GetObject("SkinEngine1.SkinStreamMain"), System.IO.Stream)
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Usuarios
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Enviar_correo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Btn_eliminar)
        Me.Controls.Add(Me.Btn_agregar)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Btn_menuPrincipal)
        Me.Name = "Usuarios"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Btn_agregar As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Btn_menuPrincipal As Button
    Friend WithEvents Enviar_correo As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Btn_eliminar As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents SkinEngine1 As Sunisoft.IrisSkin.SkinEngine
    Friend WithEvents Button1 As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
