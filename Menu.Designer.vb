<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.lb_Usuario = New System.Windows.Forms.Label()
        Me.btnIngredientes = New System.Windows.Forms.Button()
        Me.btnDietas = New System.Windows.Forms.Button()
        Me.btnCabezaGanado = New System.Windows.Forms.Button()
        Me.btnGrupo = New System.Windows.Forms.Button()
        Me.btnVentaGanado = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnBalance = New System.Windows.Forms.Button()
        Me.btnGasto = New System.Windows.Forms.Button()
        Me.btnCompra = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnReportes = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lb_Usuario
        '
        Me.lb_Usuario.AutoSize = True
        Me.lb_Usuario.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lb_Usuario.Location = New System.Drawing.Point(337, 7)
        Me.lb_Usuario.Name = "lb_Usuario"
        Me.lb_Usuario.Size = New System.Drawing.Size(83, 30)
        Me.lb_Usuario.TabIndex = 9
        Me.lb_Usuario.Text = "MENU"
        Me.lb_Usuario.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnIngredientes
        '
        Me.btnIngredientes.BackColor = System.Drawing.Color.BurlyWood
        Me.btnIngredientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngredientes.Image = CType(resources.GetObject("btnIngredientes.Image"), System.Drawing.Image)
        Me.btnIngredientes.Location = New System.Drawing.Point(32, 253)
        Me.btnIngredientes.Name = "btnIngredientes"
        Me.btnIngredientes.Size = New System.Drawing.Size(145, 147)
        Me.btnIngredientes.TabIndex = 8
        Me.btnIngredientes.UseVisualStyleBackColor = False
        '
        'btnDietas
        '
        Me.btnDietas.BackColor = System.Drawing.Color.BurlyWood
        Me.btnDietas.BackgroundImage = Global.proye.My.Resources.Resources.dieta
        Me.btnDietas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnDietas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDietas.Location = New System.Drawing.Point(537, 55)
        Me.btnDietas.Name = "btnDietas"
        Me.btnDietas.Size = New System.Drawing.Size(145, 147)
        Me.btnDietas.TabIndex = 7
        Me.btnDietas.UseVisualStyleBackColor = False
        '
        'btnCabezaGanado
        '
        Me.btnCabezaGanado.BackColor = System.Drawing.Color.BurlyWood
        Me.btnCabezaGanado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCabezaGanado.Image = Global.proye.My.Resources.Resources.icons8_año_del_buey_48
        Me.btnCabezaGanado.Location = New System.Drawing.Point(283, 55)
        Me.btnCabezaGanado.Name = "btnCabezaGanado"
        Me.btnCabezaGanado.Size = New System.Drawing.Size(145, 147)
        Me.btnCabezaGanado.TabIndex = 6
        Me.btnCabezaGanado.UseVisualStyleBackColor = False
        '
        'btnGrupo
        '
        Me.btnGrupo.BackColor = System.Drawing.Color.BurlyWood
        Me.btnGrupo.BackgroundImage = Global.proye.My.Resources.Resources.vaca__6_
        Me.btnGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrupo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGrupo.Location = New System.Drawing.Point(32, 55)
        Me.btnGrupo.Name = "btnGrupo"
        Me.btnGrupo.Size = New System.Drawing.Size(145, 147)
        Me.btnGrupo.TabIndex = 5
        Me.btnGrupo.UseVisualStyleBackColor = False
        '
        'btnVentaGanado
        '
        Me.btnVentaGanado.BackColor = System.Drawing.Color.BurlyWood
        Me.btnVentaGanado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentaGanado.Image = Global.proye.My.Resources.Resources.ventas
        Me.btnVentaGanado.Location = New System.Drawing.Point(283, 253)
        Me.btnVentaGanado.Name = "btnVentaGanado"
        Me.btnVentaGanado.Size = New System.Drawing.Size(145, 147)
        Me.btnVentaGanado.TabIndex = 10
        Me.btnVentaGanado.UseVisualStyleBackColor = False
        '
        'btnClientes
        '
        Me.btnClientes.BackColor = System.Drawing.Color.BurlyWood
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Image = CType(resources.GetObject("btnClientes.Image"), System.Drawing.Image)
        Me.btnClientes.Location = New System.Drawing.Point(537, 253)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(145, 147)
        Me.btnClientes.TabIndex = 11
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'btnBalance
        '
        Me.btnBalance.BackColor = System.Drawing.Color.BurlyWood
        Me.btnBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBalance.Image = CType(resources.GetObject("btnBalance.Image"), System.Drawing.Image)
        Me.btnBalance.Location = New System.Drawing.Point(32, 452)
        Me.btnBalance.Name = "btnBalance"
        Me.btnBalance.Size = New System.Drawing.Size(145, 147)
        Me.btnBalance.TabIndex = 12
        Me.btnBalance.UseVisualStyleBackColor = False
        '
        'btnGasto
        '
        Me.btnGasto.BackColor = System.Drawing.Color.BurlyWood
        Me.btnGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGasto.Image = CType(resources.GetObject("btnGasto.Image"), System.Drawing.Image)
        Me.btnGasto.Location = New System.Drawing.Point(283, 452)
        Me.btnGasto.Name = "btnGasto"
        Me.btnGasto.Size = New System.Drawing.Size(145, 147)
        Me.btnGasto.TabIndex = 13
        Me.btnGasto.UseVisualStyleBackColor = False
        '
        'btnCompra
        '
        Me.btnCompra.BackColor = System.Drawing.Color.BurlyWood
        Me.btnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompra.Image = Global.proye.My.Resources.Resources.pagar1
        Me.btnCompra.Location = New System.Drawing.Point(537, 452)
        Me.btnCompra.Name = "btnCompra"
        Me.btnCompra.Size = New System.Drawing.Size(145, 147)
        Me.btnCompra.TabIndex = 14
        Me.btnCompra.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.GroupBox1.Controls.Add(Me.btnHelp)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btnReportes)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnCompra)
        Me.GroupBox1.Controls.Add(Me.btnGrupo)
        Me.GroupBox1.Controls.Add(Me.btnClientes)
        Me.GroupBox1.Controls.Add(Me.btnGasto)
        Me.GroupBox1.Controls.Add(Me.btnCabezaGanado)
        Me.GroupBox1.Controls.Add(Me.btnBalance)
        Me.GroupBox1.Controls.Add(Me.btnVentaGanado)
        Me.GroupBox1.Controls.Add(Me.btnDietas)
        Me.GroupBox1.Controls.Add(Me.btnIngredientes)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(900, 615)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'btnHelp
        '
        Me.btnHelp.BackgroundImage = Global.proye.My.Resources.Resources.Question_Block
        Me.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Location = New System.Drawing.Point(730, 55)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(134, 125)
        Me.btnHelp.TabIndex = 26
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(762, 215)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 23)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Reportes"
        '
        'btnReportes
        '
        Me.btnReportes.BackColor = System.Drawing.Color.BurlyWood
        Me.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportes.Image = Global.proye.My.Resources.Resources.granja
        Me.btnReportes.Location = New System.Drawing.Point(730, 253)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(145, 147)
        Me.btnReportes.TabIndex = 24
        Me.btnReportes.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(569, 417)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 23)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Compras"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(323, 417)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 23)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Gasto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(65, 417)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 23)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Balance"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(569, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 23)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Clientes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(318, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 23)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Ventas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(48, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 23)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Ingredientes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(574, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 23)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Dietas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(269, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 23)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Cabeza de ganado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(65, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Grupos"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(926, 670)
        Me.Controls.Add(Me.lb_Usuario)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb_Usuario As Label
    Friend WithEvents btnIngredientes As Button
    Friend WithEvents btnDietas As Button
    Friend WithEvents btnCabezaGanado As Button
    Friend WithEvents btnGrupo As Button
    Friend WithEvents btnVentaGanado As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnBalance As Button
    Friend WithEvents btnGasto As Button
    Friend WithEvents btnCompra As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnReportes As Button
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents btnHelp As Button
End Class
