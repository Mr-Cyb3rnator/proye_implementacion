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
        Me.components = New System.ComponentModel.Container()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btagregar = New System.Windows.Forms.Button()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.txtedad = New System.Windows.Forms.TextBox()
        Me.txtpesoini = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btguardar = New System.Windows.Forms.Button()
        Me.dgv_Compra = New System.Windows.Forms.DataGridView()
        Me.cPesoini = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.craza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cprecio_compra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.txtcod_cliente = New System.Windows.Forms.TextBox()
        Me.lb_CodigoCliente = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tooltip_Compra = New System.Windows.Forms.ToolTip(Me.components)
        Me.b_Limpiar = New System.Windows.Forms.Button()
        Me.cb_Raza = New System.Windows.Forms.ComboBox()
        Me.btnatras = New System.Windows.Forms.Button()
        CType(Me.dgv_Compra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(38, 352)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(191, 23)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Precio de Compra"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(90, 279)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 23)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Raza"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(90, 207)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 23)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Edad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(66, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 23)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Peso Inicial"
        '
        'btagregar
        '
        Me.btagregar.BackColor = System.Drawing.Color.BurlyWood
        Me.btagregar.Enabled = False
        Me.btagregar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btagregar.Location = New System.Drawing.Point(14, 446)
        Me.btagregar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btagregar.Name = "btagregar"
        Me.btagregar.Size = New System.Drawing.Size(92, 48)
        Me.btagregar.TabIndex = 32
        Me.btagregar.Text = "Agregar"
        Me.btagregar.UseVisualStyleBackColor = False
        '
        'txtprecio
        '
        Me.txtprecio.Enabled = False
        Me.txtprecio.Location = New System.Drawing.Point(54, 375)
        Me.txtprecio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtprecio.MaxLength = 7
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(119, 27)
        Me.txtprecio.TabIndex = 30
        '
        'txtedad
        '
        Me.txtedad.Enabled = False
        Me.txtedad.Location = New System.Drawing.Point(54, 230)
        Me.txtedad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtedad.MaxLength = 2
        Me.txtedad.Name = "txtedad"
        Me.txtedad.Size = New System.Drawing.Size(119, 27)
        Me.txtedad.TabIndex = 28
        '
        'txtpesoini
        '
        Me.txtpesoini.Enabled = False
        Me.txtpesoini.Location = New System.Drawing.Point(54, 160)
        Me.txtpesoini.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpesoini.MaxLength = 4
        Me.txtpesoini.Name = "txtpesoini"
        Me.txtpesoini.Size = New System.Drawing.Size(119, 27)
        Me.txtpesoini.TabIndex = 27
        '
        'txttotal
        '
        Me.txttotal.Enabled = False
        Me.txttotal.Location = New System.Drawing.Point(437, 471)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(119, 27)
        Me.txttotal.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(376, 478)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 23)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "TOTAL"
        '
        'btguardar
        '
        Me.btguardar.BackColor = System.Drawing.Color.BurlyWood
        Me.btguardar.Enabled = False
        Me.btguardar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btguardar.Location = New System.Drawing.Point(805, 138)
        Me.btguardar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btguardar.Name = "btguardar"
        Me.btguardar.Size = New System.Drawing.Size(166, 72)
        Me.btguardar.TabIndex = 23
        Me.btguardar.Text = "Comprar"
        Me.btguardar.UseVisualStyleBackColor = False
        '
        'dgv_Compra
        '
        Me.dgv_Compra.AllowUserToAddRows = False
        Me.dgv_Compra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Compra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cPesoini, Me.cedad, Me.craza, Me.cprecio_compra, Me.Obs})
        Me.dgv_Compra.Location = New System.Drawing.Point(245, 138)
        Me.dgv_Compra.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgv_Compra.Name = "dgv_Compra"
        Me.dgv_Compra.ReadOnly = True
        Me.dgv_Compra.RowHeadersWidth = 51
        Me.dgv_Compra.RowTemplate.Height = 24
        Me.dgv_Compra.Size = New System.Drawing.Size(554, 277)
        Me.dgv_Compra.TabIndex = 22
        '
        'cPesoini
        '
        Me.cPesoini.HeaderText = "Peso Inicial"
        Me.cPesoini.MinimumWidth = 6
        Me.cPesoini.Name = "cPesoini"
        Me.cPesoini.ReadOnly = True
        Me.cPesoini.Width = 125
        '
        'cedad
        '
        Me.cedad.HeaderText = "Edad"
        Me.cedad.MinimumWidth = 6
        Me.cedad.Name = "cedad"
        Me.cedad.ReadOnly = True
        Me.cedad.Width = 125
        '
        'craza
        '
        Me.craza.HeaderText = "Raza"
        Me.craza.MinimumWidth = 6
        Me.craza.Name = "craza"
        Me.craza.ReadOnly = True
        Me.craza.Width = 125
        '
        'cprecio_compra
        '
        Me.cprecio_compra.HeaderText = "Precio Compra"
        Me.cprecio_compra.MinimumWidth = 6
        Me.cprecio_compra.Name = "cprecio_compra"
        Me.cprecio_compra.ReadOnly = True
        Me.cprecio_compra.Width = 125
        '
        'Obs
        '
        Me.Obs.HeaderText = "obs"
        Me.Obs.MinimumWidth = 6
        Me.Obs.Name = "Obs"
        Me.Obs.ReadOnly = True
        Me.Obs.Visible = False
        Me.Obs.Width = 125
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtp_fecha)
        Me.GroupBox1.Controls.Add(Me.txtcod_cliente)
        Me.GroupBox1.Controls.Add(Me.lb_CodigoCliente)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(46, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(649, 91)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Encabezado"
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Enabled = False
        Me.dtp_fecha.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dtp_fecha.Location = New System.Drawing.Point(346, 36)
        Me.dtp_fecha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(276, 32)
        Me.dtp_fecha.TabIndex = 14
        '
        'txtcod_cliente
        '
        Me.txtcod_cliente.Location = New System.Drawing.Point(122, 40)
        Me.txtcod_cliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtcod_cliente.Name = "txtcod_cliente"
        Me.txtcod_cliente.Size = New System.Drawing.Size(119, 32)
        Me.txtcod_cliente.TabIndex = 11
        '
        'lb_CodigoCliente
        '
        Me.lb_CodigoCliente.AutoSize = True
        Me.lb_CodigoCliente.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lb_CodigoCliente.Location = New System.Drawing.Point(14, 43)
        Me.lb_CodigoCliente.Name = "lb_CodigoCliente"
        Me.lb_CodigoCliente.Size = New System.Drawing.Size(133, 23)
        Me.lb_CodigoCliente.TabIndex = 10
        Me.lb_CodigoCliente.Text = "Cod. Cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(289, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha"
        '
        'tooltip_Compra
        '
        Me.tooltip_Compra.IsBalloon = True
        Me.tooltip_Compra.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.tooltip_Compra.ToolTipTitle = "Tipo Datos"
        '
        'b_Limpiar
        '
        Me.b_Limpiar.BackColor = System.Drawing.Color.BurlyWood
        Me.b_Limpiar.Enabled = False
        Me.b_Limpiar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.b_Limpiar.Location = New System.Drawing.Point(124, 447)
        Me.b_Limpiar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.b_Limpiar.Name = "b_Limpiar"
        Me.b_Limpiar.Size = New System.Drawing.Size(92, 48)
        Me.b_Limpiar.TabIndex = 40
        Me.b_Limpiar.Text = "Limpiar"
        Me.b_Limpiar.UseVisualStyleBackColor = False
        '
        'cb_Raza
        '
        Me.cb_Raza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Raza.Enabled = False
        Me.cb_Raza.FormattingEnabled = True
        Me.cb_Raza.Items.AddRange(New Object() {"Brahman", "Holstein", "Jersey", "Pardo Suizo"})
        Me.cb_Raza.Location = New System.Drawing.Point(52, 310)
        Me.cb_Raza.Margin = New System.Windows.Forms.Padding(2)
        Me.cb_Raza.Name = "cb_Raza"
        Me.cb_Raza.Size = New System.Drawing.Size(122, 29)
        Me.cb_Raza.TabIndex = 41
        '
        'btnatras
        '
        Me.btnatras.BackColor = System.Drawing.Color.BurlyWood
        Me.btnatras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnatras.Image = Global.proye.My.Resources.Resources.atras__2_
        Me.btnatras.Location = New System.Drawing.Point(877, 429)
        Me.btnatras.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(94, 50)
        Me.btnatras.TabIndex = 42
        Me.btnatras.UseVisualStyleBackColor = False
        '
        'Compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(991, 532)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.cb_Raza)
        Me.Controls.Add(Me.b_Limpiar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btagregar)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.txtedad)
        Me.Controls.Add(Me.txtpesoini)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btguardar)
        Me.Controls.Add(Me.dgv_Compra)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Compra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compra Ganado"
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
    Friend WithEvents txtedad As TextBox
    Friend WithEvents txtpesoini As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btguardar As Button
    Friend WithEvents dgv_Compra As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtcod_cliente As TextBox
    Friend WithEvents lb_CodigoCliente As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtp_fecha As DateTimePicker
    Friend WithEvents cPesoini As DataGridViewTextBoxColumn
    Friend WithEvents cedad As DataGridViewTextBoxColumn
    Friend WithEvents craza As DataGridViewTextBoxColumn
    Friend WithEvents cprecio_compra As DataGridViewTextBoxColumn
    Friend WithEvents Obs As DataGridViewTextBoxColumn
    Friend WithEvents tooltip_Compra As ToolTip
    Friend WithEvents b_Limpiar As Button
    Friend WithEvents cb_Raza As ComboBox
    Friend WithEvents btnatras As Button
End Class
