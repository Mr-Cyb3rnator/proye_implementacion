<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Compra
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btagregar = New System.Windows.Forms.Button()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.txtraza = New System.Windows.Forms.TextBox()
        Me.txtedad = New System.Windows.Forms.TextBox()
        Me.txtpesoini = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btsalir = New System.Windows.Forms.Button()
        Me.btguardar = New System.Windows.Forms.Button()
        Me.dgv_Compra = New System.Windows.Forms.DataGridView()
        Me.cPesoini = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.craza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cprecio_compra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtcod_cliente = New System.Windows.Forms.TextBox()
        Me.lb_CodigoCliente = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcompra = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcodgrupo = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgv_Compra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(48, 435)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(191, 23)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Precio de Compra"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(112, 345)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 23)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Raza"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(112, 256)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 23)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Edad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(82, 170)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 23)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Peso Inicial"
        '
        'btagregar
        '
        Me.btagregar.Location = New System.Drawing.Point(60, 551)
        Me.btagregar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btagregar.Name = "btagregar"
        Me.btagregar.Size = New System.Drawing.Size(164, 59)
        Me.btagregar.TabIndex = 32
        Me.btagregar.Text = "Agregar"
        Me.btagregar.UseVisualStyleBackColor = True
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(68, 463)
        Me.txtprecio.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(148, 32)
        Me.txtprecio.TabIndex = 30
        '
        'txtraza
        '
        Me.txtraza.Location = New System.Drawing.Point(68, 373)
        Me.txtraza.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtraza.Name = "txtraza"
        Me.txtraza.Size = New System.Drawing.Size(148, 32)
        Me.txtraza.TabIndex = 29
        '
        'txtedad
        '
        Me.txtedad.Location = New System.Drawing.Point(68, 284)
        Me.txtedad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtedad.Name = "txtedad"
        Me.txtedad.Size = New System.Drawing.Size(148, 32)
        Me.txtedad.TabIndex = 28
        '
        'txtpesoini
        '
        Me.txtpesoini.Location = New System.Drawing.Point(68, 198)
        Me.txtpesoini.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtpesoini.Name = "txtpesoini"
        Me.txtpesoini.Size = New System.Drawing.Size(148, 32)
        Me.txtpesoini.TabIndex = 27
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(548, 537)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(148, 32)
        Me.txttotal.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(445, 544)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 23)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "TOTAL"
        '
        'btsalir
        '
        Me.btsalir.Location = New System.Drawing.Point(893, 343)
        Me.btsalir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btsalir.Name = "btsalir"
        Me.btsalir.Size = New System.Drawing.Size(208, 89)
        Me.btsalir.TabIndex = 24
        Me.btsalir.Text = "Salir"
        Me.btsalir.UseVisualStyleBackColor = True
        '
        'btguardar
        '
        Me.btguardar.Location = New System.Drawing.Point(893, 211)
        Me.btguardar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btguardar.Name = "btguardar"
        Me.btguardar.Size = New System.Drawing.Size(208, 89)
        Me.btguardar.TabIndex = 23
        Me.btguardar.Text = "Guardar"
        Me.btguardar.UseVisualStyleBackColor = True
        '
        'dgv_Compra
        '
        Me.dgv_Compra.AllowUserToAddRows = False
        Me.dgv_Compra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Compra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cPesoini, Me.cedad, Me.craza, Me.cprecio_compra, Me.Obs})
        Me.dgv_Compra.Location = New System.Drawing.Point(306, 170)
        Me.dgv_Compra.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgv_Compra.Name = "dgv_Compra"
        Me.dgv_Compra.RowHeadersWidth = 51
        Me.dgv_Compra.RowTemplate.Height = 24
        Me.dgv_Compra.Size = New System.Drawing.Size(554, 342)
        Me.dgv_Compra.TabIndex = 22
        '
        'cPesoini
        '
        Me.cPesoini.HeaderText = "Peso Inicial"
        Me.cPesoini.MinimumWidth = 6
        Me.cPesoini.Name = "cPesoini"
        Me.cPesoini.Width = 125
        '
        'cedad
        '
        Me.cedad.HeaderText = "Edad"
        Me.cedad.MinimumWidth = 6
        Me.cedad.Name = "cedad"
        Me.cedad.Width = 125
        '
        'craza
        '
        Me.craza.HeaderText = "Raza"
        Me.craza.MinimumWidth = 6
        Me.craza.Name = "craza"
        Me.craza.Width = 125
        '
        'cprecio_compra
        '
        Me.cprecio_compra.HeaderText = "Precio Compra"
        Me.cprecio_compra.MinimumWidth = 6
        Me.cprecio_compra.Name = "cprecio_compra"
        Me.cprecio_compra.Width = 125
        '
        'Obs
        '
        Me.Obs.HeaderText = "obs"
        Me.Obs.MinimumWidth = 6
        Me.Obs.Name = "Obs"
        Me.Obs.Visible = False
        Me.Obs.Width = 125
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.txtcod_cliente)
        Me.GroupBox1.Controls.Add(Me.lb_CodigoCliente)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtcompra)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(58, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1052, 113)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Encabezado"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(650, 49)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(344, 32)
        Me.DateTimePicker1.TabIndex = 14
        '
        'txtcod_cliente
        '
        Me.txtcod_cliente.Location = New System.Drawing.Point(402, 49)
        Me.txtcod_cliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtcod_cliente.Name = "txtcod_cliente"
        Me.txtcod_cliente.Size = New System.Drawing.Size(148, 32)
        Me.txtcod_cliente.TabIndex = 11
        '
        'lb_CodigoCliente
        '
        Me.lb_CodigoCliente.AutoSize = True
        Me.lb_CodigoCliente.Location = New System.Drawing.Point(267, 53)
        Me.lb_CodigoCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_CodigoCliente.Name = "lb_CodigoCliente"
        Me.lb_CodigoCliente.Size = New System.Drawing.Size(133, 23)
        Me.lb_CodigoCliente.TabIndex = 10
        Me.lb_CodigoCliente.Text = "Cod. Cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(578, 52)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha"
        '
        'txtcompra
        '
        Me.txtcompra.Enabled = False
        Me.txtcompra.Location = New System.Drawing.Point(97, 49)
        Me.txtcompra.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtcompra.Name = "txtcompra"
        Me.txtcompra.Size = New System.Drawing.Size(148, 32)
        Me.txtcompra.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Factura"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(345, 587)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 23)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Grupo Asignado"
        '
        'txtcodgrupo
        '
        Me.txtcodgrupo.Location = New System.Drawing.Point(547, 579)
        Me.txtcodgrupo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtcodgrupo.Name = "txtcodgrupo"
        Me.txtcodgrupo.Size = New System.Drawing.Size(148, 32)
        Me.txtcodgrupo.TabIndex = 37
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(853, 544)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 59)
        Me.Button1.TabIndex = 39
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1165, 645)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcodgrupo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btagregar)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.txtraza)
        Me.Controls.Add(Me.txtedad)
        Me.Controls.Add(Me.txtpesoini)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btsalir)
        Me.Controls.Add(Me.btguardar)
        Me.Controls.Add(Me.dgv_Compra)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Compra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "compra"
        CType(Me.dgv_Compra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btagregar As Button
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents txtraza As TextBox
    Friend WithEvents txtedad As TextBox
    Friend WithEvents txtpesoini As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btsalir As Button
    Friend WithEvents btguardar As Button
    Friend WithEvents dgv_Compra As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtcod_cliente As TextBox
    Friend WithEvents lb_CodigoCliente As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcompra As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcodgrupo As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents cPesoini As DataGridViewTextBoxColumn
    Friend WithEvents cedad As DataGridViewTextBoxColumn
    Friend WithEvents craza As DataGridViewTextBoxColumn
    Friend WithEvents cprecio_compra As DataGridViewTextBoxColumn
    Friend WithEvents Obs As DataGridViewTextBoxColumn
End Class
