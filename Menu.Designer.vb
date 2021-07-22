<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Menu))
        Me.lb_Usuario = New System.Windows.Forms.Label()
        Me.btn_Ingredientes = New System.Windows.Forms.Button()
        Me.btn_Dietas = New System.Windows.Forms.Button()
        Me.btn_CabezaGanado = New System.Windows.Forms.Button()
        Me.btn_Grupo = New System.Windows.Forms.Button()
        Me.btn_VentaGanado = New System.Windows.Forms.Button()
        Me.btn_Clientes = New System.Windows.Forms.Button()
        Me.btn_Balance = New System.Windows.Forms.Button()
        Me.btn_Gasto = New System.Windows.Forms.Button()
        Me.btn_Compra = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_Reportes = New System.Windows.Forms.Button()
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
        'btn_Ingredientes
        '
        Me.btn_Ingredientes.BackColor = System.Drawing.Color.BurlyWood
        Me.btn_Ingredientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Ingredientes.Image = CType(resources.GetObject("btn_Ingredientes.Image"), System.Drawing.Image)
        Me.btn_Ingredientes.Location = New System.Drawing.Point(32, 253)
        Me.btn_Ingredientes.Name = "btn_Ingredientes"
        Me.btn_Ingredientes.Size = New System.Drawing.Size(145, 147)
        Me.btn_Ingredientes.TabIndex = 8
        Me.btn_Ingredientes.UseVisualStyleBackColor = False
        '
        'btn_Dietas
        '
        Me.btn_Dietas.BackColor = System.Drawing.Color.BurlyWood
        Me.btn_Dietas.BackgroundImage = Global.proye.My.Resources.Resources.dieta
        Me.btn_Dietas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_Dietas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Dietas.Location = New System.Drawing.Point(537, 55)
        Me.btn_Dietas.Name = "btn_Dietas"
        Me.btn_Dietas.Size = New System.Drawing.Size(145, 147)
        Me.btn_Dietas.TabIndex = 7
        Me.btn_Dietas.UseVisualStyleBackColor = False
        '
        'btn_CabezaGanado
        '
        Me.btn_CabezaGanado.BackColor = System.Drawing.Color.BurlyWood
        Me.btn_CabezaGanado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_CabezaGanado.Image = Global.proye.My.Resources.Resources.icons8_año_del_buey_48
        Me.btn_CabezaGanado.Location = New System.Drawing.Point(283, 55)
        Me.btn_CabezaGanado.Name = "btn_CabezaGanado"
        Me.btn_CabezaGanado.Size = New System.Drawing.Size(145, 147)
        Me.btn_CabezaGanado.TabIndex = 6
        Me.btn_CabezaGanado.UseVisualStyleBackColor = False
        '
        'btn_Grupo
        '
        Me.btn_Grupo.BackColor = System.Drawing.Color.BurlyWood
        Me.btn_Grupo.BackgroundImage = Global.proye.My.Resources.Resources.vaca__6_
        Me.btn_Grupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_Grupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Grupo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Grupo.Location = New System.Drawing.Point(32, 55)
        Me.btn_Grupo.Name = "btn_Grupo"
        Me.btn_Grupo.Size = New System.Drawing.Size(145, 147)
        Me.btn_Grupo.TabIndex = 5
        Me.btn_Grupo.UseVisualStyleBackColor = False
        '
        'btn_VentaGanado
        '
        Me.btn_VentaGanado.BackColor = System.Drawing.Color.BurlyWood
        Me.btn_VentaGanado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_VentaGanado.Image = Global.proye.My.Resources.Resources.ventas
        Me.btn_VentaGanado.Location = New System.Drawing.Point(283, 253)
        Me.btn_VentaGanado.Name = "btn_VentaGanado"
        Me.btn_VentaGanado.Size = New System.Drawing.Size(145, 147)
        Me.btn_VentaGanado.TabIndex = 10
        Me.btn_VentaGanado.UseVisualStyleBackColor = False
        '
        'btn_Clientes
        '
        Me.btn_Clientes.BackColor = System.Drawing.Color.BurlyWood
        Me.btn_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Clientes.Image = CType(resources.GetObject("btn_Clientes.Image"), System.Drawing.Image)
        Me.btn_Clientes.Location = New System.Drawing.Point(537, 253)
        Me.btn_Clientes.Name = "btn_Clientes"
        Me.btn_Clientes.Size = New System.Drawing.Size(145, 147)
        Me.btn_Clientes.TabIndex = 11
        Me.btn_Clientes.UseVisualStyleBackColor = False
        '
        'btn_Balance
        '
        Me.btn_Balance.BackColor = System.Drawing.Color.BurlyWood
        Me.btn_Balance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Balance.Image = CType(resources.GetObject("btn_Balance.Image"), System.Drawing.Image)
        Me.btn_Balance.Location = New System.Drawing.Point(32, 452)
        Me.btn_Balance.Name = "btn_Balance"
        Me.btn_Balance.Size = New System.Drawing.Size(145, 147)
        Me.btn_Balance.TabIndex = 12
        Me.btn_Balance.UseVisualStyleBackColor = False
        '
        'btn_Gasto
        '
        Me.btn_Gasto.BackColor = System.Drawing.Color.BurlyWood
        Me.btn_Gasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Gasto.Image = CType(resources.GetObject("btn_Gasto.Image"), System.Drawing.Image)
        Me.btn_Gasto.Location = New System.Drawing.Point(283, 452)
        Me.btn_Gasto.Name = "btn_Gasto"
        Me.btn_Gasto.Size = New System.Drawing.Size(145, 147)
        Me.btn_Gasto.TabIndex = 13
        Me.btn_Gasto.UseVisualStyleBackColor = False
        '
        'btn_Compra
        '
        Me.btn_Compra.BackColor = System.Drawing.Color.BurlyWood
        Me.btn_Compra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Compra.Image = Global.proye.My.Resources.Resources.pagar1
        Me.btn_Compra.Location = New System.Drawing.Point(537, 452)
        Me.btn_Compra.Name = "btn_Compra"
        Me.btn_Compra.Size = New System.Drawing.Size(145, 147)
        Me.btn_Compra.TabIndex = 14
        Me.btn_Compra.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btn_Reportes)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_Compra)
        Me.GroupBox1.Controls.Add(Me.btn_Grupo)
        Me.GroupBox1.Controls.Add(Me.btn_Clientes)
        Me.GroupBox1.Controls.Add(Me.btn_Gasto)
        Me.GroupBox1.Controls.Add(Me.btn_CabezaGanado)
        Me.GroupBox1.Controls.Add(Me.btn_Balance)
        Me.GroupBox1.Controls.Add(Me.btn_VentaGanado)
        Me.GroupBox1.Controls.Add(Me.btn_Dietas)
        Me.GroupBox1.Controls.Add(Me.btn_Ingredientes)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(900, 615)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
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
        'btn_Reportes
        '
        Me.btn_Reportes.BackColor = System.Drawing.Color.BurlyWood
        Me.btn_Reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Reportes.Image = Global.proye.My.Resources.Resources.granja
        Me.btn_Reportes.Location = New System.Drawing.Point(730, 253)
        Me.btn_Reportes.Name = "btn_Reportes"
        Me.btn_Reportes.Size = New System.Drawing.Size(145, 147)
        Me.btn_Reportes.TabIndex = 24
        Me.btn_Reportes.UseVisualStyleBackColor = False
        '
        'frm_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(926, 670)
        Me.Controls.Add(Me.lb_Usuario)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb_Usuario As Label
    Friend WithEvents btn_Ingredientes As Button
    Friend WithEvents btn_Dietas As Button
    Friend WithEvents btn_CabezaGanado As Button
    Friend WithEvents btn_Grupo As Button
    Friend WithEvents btn_VentaGanado As Button
    Friend WithEvents btn_Clientes As Button
    Friend WithEvents btn_Balance As Button
    Friend WithEvents btn_Gasto As Button
    Friend WithEvents btn_Compra As Button
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
    Friend WithEvents btn_Reportes As Button
End Class
