﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cabeza_ganado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cabeza_ganado))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcodigoanimal = New System.Windows.Forms.TextBox()
        Me.txtpesoini = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpeso1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtpeso2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtpeso3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtpeso4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtpesoobj = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtedad = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtraza = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtcod_grup = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DGcabezas = New System.Windows.Forms.DataGridView()
        Me.btagregar = New System.Windows.Forms.Button()
        Me.bteliminar = New System.Windows.Forms.Button()
        Me.btnatras = New System.Windows.Forms.Button()
        Me.bteditar = New System.Windows.Forms.Button()
        Me.rtxtobs = New System.Windows.Forms.RichTextBox()
        Me.combo_grupos = New System.Windows.Forms.ComboBox()
        CType(Me.DGcabezas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(213, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo animal"
        '
        'txtcodigoanimal
        '
        Me.txtcodigoanimal.Enabled = False
        Me.txtcodigoanimal.Location = New System.Drawing.Point(374, 55)
        Me.txtcodigoanimal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtcodigoanimal.Name = "txtcodigoanimal"
        Me.txtcodigoanimal.Size = New System.Drawing.Size(100, 27)
        Me.txtcodigoanimal.TabIndex = 1
        '
        'txtpesoini
        '
        Me.txtpesoini.Location = New System.Drawing.Point(647, 55)
        Me.txtpesoini.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpesoini.Name = "txtpesoini"
        Me.txtpesoini.Size = New System.Drawing.Size(100, 27)
        Me.txtpesoini.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(534, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Peso inicial"
        '
        'txtpeso1
        '
        Me.txtpeso1.Location = New System.Drawing.Point(647, 101)
        Me.txtpeso1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpeso1.Name = "txtpeso1"
        Me.txtpeso1.Size = New System.Drawing.Size(100, 27)
        Me.txtpeso1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(534, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Peso 1"
        '
        'txtpeso2
        '
        Me.txtpeso2.Location = New System.Drawing.Point(647, 148)
        Me.txtpeso2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpeso2.Name = "txtpeso2"
        Me.txtpeso2.Size = New System.Drawing.Size(100, 27)
        Me.txtpeso2.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(534, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Peso 2"
        '
        'txtpeso3
        '
        Me.txtpeso3.Location = New System.Drawing.Point(647, 203)
        Me.txtpeso3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpeso3.Name = "txtpeso3"
        Me.txtpeso3.Size = New System.Drawing.Size(100, 27)
        Me.txtpeso3.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(534, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 23)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Peso 3"
        '
        'txtpeso4
        '
        Me.txtpeso4.Location = New System.Drawing.Point(647, 264)
        Me.txtpeso4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpeso4.Name = "txtpeso4"
        Me.txtpeso4.Size = New System.Drawing.Size(100, 27)
        Me.txtpeso4.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(534, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 23)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Peso 4"
        '
        'txtpesoobj
        '
        Me.txtpesoobj.Location = New System.Drawing.Point(374, 124)
        Me.txtpesoobj.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpesoobj.Name = "txtpesoobj"
        Me.txtpesoobj.Size = New System.Drawing.Size(100, 27)
        Me.txtpesoobj.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(213, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 23)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Peso Objetivo"
        '
        'txtedad
        '
        Me.txtedad.Location = New System.Drawing.Point(374, 199)
        Me.txtedad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtedad.Name = "txtedad"
        Me.txtedad.Size = New System.Drawing.Size(100, 27)
        Me.txtedad.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(261, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 23)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Edad"
        '
        'txtraza
        '
        Me.txtraza.Location = New System.Drawing.Point(374, 275)
        Me.txtraza.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtraza.Name = "txtraza"
        Me.txtraza.Size = New System.Drawing.Size(100, 27)
        Me.txtraza.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(261, 277)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 23)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Raza"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(789, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(157, 23)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Observaciones"
        '
        'txtcod_grup
        '
        Me.txtcod_grup.Location = New System.Drawing.Point(17, 13)
        Me.txtcod_grup.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtcod_grup.Name = "txtcod_grup"
        Me.txtcod_grup.Size = New System.Drawing.Size(100, 27)
        Me.txtcod_grup.TabIndex = 21
        Me.txtcod_grup.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(170, 333)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(183, 23)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Codigo de Grupo"
        '
        'DGcabezas
        '
        Me.DGcabezas.AllowUserToAddRows = False
        Me.DGcabezas.AllowUserToDeleteRows = False
        Me.DGcabezas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGcabezas.Location = New System.Drawing.Point(17, 373)
        Me.DGcabezas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DGcabezas.Name = "DGcabezas"
        Me.DGcabezas.ReadOnly = True
        Me.DGcabezas.RowHeadersWidth = 51
        Me.DGcabezas.RowTemplate.Height = 24
        Me.DGcabezas.Size = New System.Drawing.Size(1373, 509)
        Me.DGcabezas.TabIndex = 22
        '
        'btagregar
        '
        Me.btagregar.BackColor = System.Drawing.Color.BurlyWood
        Me.btagregar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btagregar.Location = New System.Drawing.Point(867, 231)
        Me.btagregar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btagregar.Name = "btagregar"
        Me.btagregar.Size = New System.Drawing.Size(113, 69)
        Me.btagregar.TabIndex = 23
        Me.btagregar.Text = "Agregar "
        Me.btagregar.UseVisualStyleBackColor = False
        '
        'bteliminar
        '
        Me.bteliminar.BackColor = System.Drawing.Color.BurlyWood
        Me.bteliminar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bteliminar.Location = New System.Drawing.Point(1043, 231)
        Me.bteliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bteliminar.Name = "bteliminar"
        Me.bteliminar.Size = New System.Drawing.Size(113, 69)
        Me.bteliminar.TabIndex = 24
        Me.bteliminar.Text = "Eliminar"
        Me.bteliminar.UseVisualStyleBackColor = False
        '
        'btnatras
        '
        Me.btnatras.Image = CType(resources.GetObject("btnatras.Image"), System.Drawing.Image)
        Me.btnatras.Location = New System.Drawing.Point(1390, 933)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(107, 69)
        Me.btnatras.TabIndex = 26
        Me.btnatras.UseVisualStyleBackColor = True
        '
        'bteditar
        '
        Me.bteditar.BackColor = System.Drawing.Color.BurlyWood
        Me.bteditar.Cursor = System.Windows.Forms.Cursors.Default
        Me.bteditar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bteditar.Location = New System.Drawing.Point(1205, 231)
        Me.bteditar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bteditar.Name = "bteditar"
        Me.bteditar.Size = New System.Drawing.Size(113, 69)
        Me.bteditar.TabIndex = 27
        Me.bteditar.Text = "Editar"
        Me.bteditar.UseVisualStyleBackColor = False
        '
        'rtxtobs
        '
        Me.rtxtobs.Location = New System.Drawing.Point(952, 59)
        Me.rtxtobs.Name = "rtxtobs"
        Me.rtxtobs.Size = New System.Drawing.Size(125, 120)
        Me.rtxtobs.TabIndex = 28
        Me.rtxtobs.Text = ""
        '
        'combo_grupos
        '
        Me.combo_grupos.FormattingEnabled = True
        Me.combo_grupos.Location = New System.Drawing.Point(374, 328)
        Me.combo_grupos.Name = "combo_grupos"
        Me.combo_grupos.Size = New System.Drawing.Size(151, 28)
        Me.combo_grupos.TabIndex = 29
        '
        'Cabeza_ganado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1409, 749)
        Me.Controls.Add(Me.combo_grupos)
        Me.Controls.Add(Me.rtxtobs)
        Me.Controls.Add(Me.bteditar)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.bteliminar)
        Me.Controls.Add(Me.btagregar)
        Me.Controls.Add(Me.DGcabezas)
        Me.Controls.Add(Me.txtcod_grup)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtraza)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtedad)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtpesoobj)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtpeso4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtpeso3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtpeso2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtpeso1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtpesoini)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcodigoanimal)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Cabeza_ganado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cabezas de ganado"
        CType(Me.DGcabezas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtcodigoanimal As TextBox
    Friend WithEvents txtpesoini As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtpeso1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtpeso2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtpeso3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtpeso4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtpesoobj As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtedad As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtraza As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtcod_grup As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents DGcabezas As DataGridView
    Friend WithEvents btagregar As Button
    Friend WithEvents bteliminar As Button
    Friend WithEvents btnatras As Button
    Friend WithEvents bteditar As Button
    Friend WithEvents rtxtobs As RichTextBox
    Friend WithEvents combo_grupos As ComboBox
End Class
