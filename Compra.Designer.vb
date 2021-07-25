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
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtPesoIni = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.dgvCompra = New System.Windows.Forms.DataGridView()
        Me.cPesoini = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.craza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cprecio_compra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.lb_CodigoCliente = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.toolTipCompra = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.cbRaza = New System.Windows.Forms.ComboBox()
        Me.btnAtras = New System.Windows.Forms.Button()
        CType(Me.dgvCompra, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label8.Location = New System.Drawing.Point(54, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 23)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Peso Inicial"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.BurlyWood
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAgregar.Location = New System.Drawing.Point(14, 446)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(104, 48)
        Me.btnAgregar.TabIndex = 32
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'txtPrecio
        '
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Location = New System.Drawing.Point(54, 375)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPrecio.MaxLength = 7
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(119, 27)
        Me.txtPrecio.TabIndex = 30
        '
        'txtEdad
        '
        Me.txtEdad.Enabled = False
        Me.txtEdad.Location = New System.Drawing.Point(54, 230)
        Me.txtEdad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEdad.MaxLength = 2
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(119, 27)
        Me.txtEdad.TabIndex = 28
        '
        'txtPesoIni
        '
        Me.txtPesoIni.Enabled = False
        Me.txtPesoIni.Location = New System.Drawing.Point(54, 160)
        Me.txtPesoIni.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPesoIni.MaxLength = 4
        Me.txtPesoIni.Name = "txtPesoIni"
        Me.txtPesoIni.Size = New System.Drawing.Size(119, 27)
        Me.txtPesoIni.TabIndex = 27
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(445, 476)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(119, 27)
        Me.txtTotal.TabIndex = 26
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
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.BurlyWood
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnGuardar.Location = New System.Drawing.Point(805, 138)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(166, 72)
        Me.btnGuardar.TabIndex = 23
        Me.btnGuardar.Text = "Comprar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'dgvCompra
        '
        Me.dgvCompra.AllowUserToAddRows = False
        Me.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cPesoini, Me.cedad, Me.craza, Me.cprecio_compra, Me.Obs})
        Me.dgvCompra.Location = New System.Drawing.Point(245, 138)
        Me.dgvCompra.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvCompra.Name = "dgvCompra"
        Me.dgvCompra.ReadOnly = True
        Me.dgvCompra.RowHeadersWidth = 51
        Me.dgvCompra.RowTemplate.Height = 24
        Me.dgvCompra.Size = New System.Drawing.Size(554, 277)
        Me.dgvCompra.TabIndex = 22
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
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.txtCodCliente)
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
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dtpFecha.Location = New System.Drawing.Point(346, 36)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(276, 32)
        Me.dtpFecha.TabIndex = 14
        '
        'txtCodCliente
        '
        Me.txtCodCliente.Location = New System.Drawing.Point(122, 40)
        Me.txtCodCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.Size = New System.Drawing.Size(119, 32)
        Me.txtCodCliente.TabIndex = 11
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
        'toolTipCompra
        '
        Me.toolTipCompra.IsBalloon = True
        Me.toolTipCompra.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.toolTipCompra.ToolTipTitle = "Tipo Datos"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.BurlyWood
        Me.btnLimpiar.Enabled = False
        Me.btnLimpiar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLimpiar.Location = New System.Drawing.Point(124, 447)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(105, 48)
        Me.btnLimpiar.TabIndex = 40
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'cbRaza
        '
        Me.cbRaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRaza.Enabled = False
        Me.cbRaza.FormattingEnabled = True
        Me.cbRaza.Items.AddRange(New Object() {"Brahman", "Holstein", "Jersey", "Pardo Suizo"})
        Me.cbRaza.Location = New System.Drawing.Point(52, 310)
        Me.cbRaza.Margin = New System.Windows.Forms.Padding(2)
        Me.cbRaza.Name = "cbRaza"
        Me.cbRaza.Size = New System.Drawing.Size(122, 29)
        Me.cbRaza.TabIndex = 41
        '
        'btnAtras
        '
        Me.btnAtras.BackColor = System.Drawing.Color.BurlyWood
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.Image = Global.proye.My.Resources.Resources.atras__2_
        Me.btnAtras.Location = New System.Drawing.Point(877, 429)
        Me.btnAtras.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(94, 74)
        Me.btnAtras.TabIndex = 42
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'Compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(991, 532)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.cbRaza)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.txtPesoIni)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.dgvCompra)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Compra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compra Ganado"
        CType(Me.dgvCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtPesoIni As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents dgvCompra As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCodCliente As TextBox
    Friend WithEvents lb_CodigoCliente As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents cPesoini As DataGridViewTextBoxColumn
    Friend WithEvents cedad As DataGridViewTextBoxColumn
    Friend WithEvents craza As DataGridViewTextBoxColumn
    Friend WithEvents cprecio_compra As DataGridViewTextBoxColumn
    Friend WithEvents Obs As DataGridViewTextBoxColumn
    Friend WithEvents toolTipCompra As ToolTip
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents cbRaza As ComboBox
    Friend WithEvents btnAtras As Button
End Class
