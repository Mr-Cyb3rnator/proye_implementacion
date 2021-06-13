<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class venta
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.txtnombre_cliente = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcod_cliente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnombre_empleado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcod_empleado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtventa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btguardar = New System.Windows.Forms.Button()
        Me.btsalir = New System.Windows.Forms.Button()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcodp = New System.Windows.Forms.TextBox()
        Me.txtnombrep = New System.Windows.Forms.TextBox()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.txtexistencia = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.btagregar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ccodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cnombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cprecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ccantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.csubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpfecha)
        Me.GroupBox1.Controls.Add(Me.txtnombre_cliente)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtcod_cliente)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtnombre_empleado)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtcod_empleado)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtventa)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(54, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(800, 265)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Encabezado"
        '
        'dtpfecha
        '
        Me.dtpfecha.Location = New System.Drawing.Point(473, 58)
        Me.dtpfecha.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(306, 32)
        Me.dtpfecha.TabIndex = 25
        '
        'txtnombre_cliente
        '
        Me.txtnombre_cliente.Location = New System.Drawing.Point(473, 199)
        Me.txtnombre_cliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtnombre_cliente.Name = "txtnombre_cliente"
        Me.txtnombre_cliente.Size = New System.Drawing.Size(148, 32)
        Me.txtnombre_cliente.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(366, 208)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 23)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "# Cliente"
        '
        'txtcod_cliente
        '
        Me.txtcod_cliente.Location = New System.Drawing.Point(473, 132)
        Me.txtcod_cliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtcod_cliente.Name = "txtcod_cliente"
        Me.txtcod_cliente.Size = New System.Drawing.Size(148, 32)
        Me.txtcod_cliente.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(369, 123)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 46)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Código" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(369, 67)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha"
        '
        'txtnombre_empleado
        '
        Me.txtnombre_empleado.Location = New System.Drawing.Point(177, 199)
        Me.txtnombre_empleado.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtnombre_empleado.Name = "txtnombre_empleado"
        Me.txtnombre_empleado.Size = New System.Drawing.Size(148, 32)
        Me.txtnombre_empleado.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 208)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "#Empleado"
        '
        'txtcod_empleado
        '
        Me.txtcod_empleado.Location = New System.Drawing.Point(177, 123)
        Me.txtcod_empleado.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtcod_empleado.Name = "txtcod_empleado"
        Me.txtcod_empleado.Size = New System.Drawing.Size(148, 32)
        Me.txtcod_empleado.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 118)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 46)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Código " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Empleado"
        '
        'txtventa
        '
        Me.txtventa.Location = New System.Drawing.Point(177, 58)
        Me.txtventa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtventa.Name = "txtventa"
        Me.txtventa.Size = New System.Drawing.Size(148, 32)
        Me.txtventa.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Factura"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ccodigo, Me.cnombre, Me.cprecio, Me.ccantidad, Me.csubtotal})
        Me.DataGridView1.Enabled = False
        Me.DataGridView1.Location = New System.Drawing.Point(271, 319)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(680, 513)
        Me.DataGridView1.TabIndex = 4
        '
        'btguardar
        '
        Me.btguardar.Location = New System.Drawing.Point(108, 1068)
        Me.btguardar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btguardar.Name = "btguardar"
        Me.btguardar.Size = New System.Drawing.Size(208, 70)
        Me.btguardar.TabIndex = 5
        Me.btguardar.Text = "guardar"
        Me.btguardar.UseVisualStyleBackColor = True
        '
        'btsalir
        '
        Me.btsalir.Location = New System.Drawing.Point(364, 1068)
        Me.btsalir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btsalir.Name = "btsalir"
        Me.btsalir.Size = New System.Drawing.Size(208, 70)
        Me.btsalir.TabIndex = 6
        Me.btsalir.Text = "salir"
        Me.btsalir.UseVisualStyleBackColor = True
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(1028, 1133)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(148, 32)
        Me.txttotal.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(922, 1137)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 23)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "TOTAL"
        '
        'txtcodp
        '
        Me.txtcodp.Location = New System.Drawing.Point(50, 348)
        Me.txtcodp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtcodp.Name = "txtcodp"
        Me.txtcodp.Size = New System.Drawing.Size(148, 32)
        Me.txtcodp.TabIndex = 10
        '
        'txtnombrep
        '
        Me.txtnombrep.Location = New System.Drawing.Point(50, 435)
        Me.txtnombrep.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtnombrep.Name = "txtnombrep"
        Me.txtnombrep.Size = New System.Drawing.Size(148, 32)
        Me.txtnombrep.TabIndex = 11
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(50, 524)
        Me.txtprecio.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(148, 32)
        Me.txtprecio.TabIndex = 12
        '
        'txtexistencia
        '
        Me.txtexistencia.Location = New System.Drawing.Point(50, 615)
        Me.txtexistencia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtexistencia.Name = "txtexistencia"
        Me.txtexistencia.Size = New System.Drawing.Size(148, 32)
        Me.txtexistencia.TabIndex = 13
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(50, 697)
        Me.txtcantidad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(148, 32)
        Me.txtcantidad.TabIndex = 14
        '
        'btagregar
        '
        Me.btagregar.Location = New System.Drawing.Point(47, 773)
        Me.btagregar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btagregar.Name = "btagregar"
        Me.btagregar.Size = New System.Drawing.Size(164, 59)
        Me.btagregar.TabIndex = 15
        Me.btagregar.Text = "Agregar"
        Me.btagregar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 319)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(178, 23)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Código Producto"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(82, 407)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 23)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Nombre"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(77, 495)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 23)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Precio"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(73, 587)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 23)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Existencia "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(71, 669)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 23)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Cantidad"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Image = Global.proye.My.Resources.Resources.icons8_flecha_responder_a_todos_48
        Me.Button1.Location = New System.Drawing.Point(1334, 1137)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 61)
        Me.Button1.TabIndex = 21
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ccodigo
        '
        Me.ccodigo.HeaderText = "Código"
        Me.ccodigo.MinimumWidth = 6
        Me.ccodigo.Name = "ccodigo"
        Me.ccodigo.Width = 125
        '
        'cnombre
        '
        Me.cnombre.HeaderText = "Nombre"
        Me.cnombre.MinimumWidth = 6
        Me.cnombre.Name = "cnombre"
        Me.cnombre.Width = 125
        '
        'cprecio
        '
        Me.cprecio.HeaderText = "Precio"
        Me.cprecio.MinimumWidth = 6
        Me.cprecio.Name = "cprecio"
        Me.cprecio.Width = 125
        '
        'ccantidad
        '
        Me.ccantidad.HeaderText = "Cantidad"
        Me.ccantidad.MinimumWidth = 6
        Me.ccantidad.Name = "ccantidad"
        Me.ccantidad.Width = 125
        '
        'csubtotal
        '
        Me.csubtotal.HeaderText = "Subtotal"
        Me.csubtotal.MinimumWidth = 6
        Me.csubtotal.Name = "csubtotal"
        Me.csubtotal.Width = 125
        '
        'venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(993, 861)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btagregar)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.txtexistencia)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.txtnombrep)
        Me.Controls.Add(Me.txtcodp)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btsalir)
        Me.Controls.Add(Me.btguardar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "venta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "venta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtnombre_cliente As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtcod_cliente As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnombre_empleado As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcod_empleado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtventa As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btguardar As Button
    Friend WithEvents btsalir As Button
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtcodp As TextBox
    Friend WithEvents txtnombrep As TextBox
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents txtexistencia As TextBox
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents btagregar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents ccodigo As DataGridViewTextBoxColumn
    Friend WithEvents cnombre As DataGridViewTextBoxColumn
    Friend WithEvents cprecio As DataGridViewTextBoxColumn
    Friend WithEvents ccantidad As DataGridViewTextBoxColumn
    Friend WithEvents csubtotal As DataGridViewTextBoxColumn
End Class
