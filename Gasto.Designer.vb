<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gasto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gasto))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.txtgrupo = New System.Windows.Forms.TextBox()
        Me.txtgasto = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btagregar = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.txtcod_ingre = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnatras = New System.Windows.Forms.Button()
        Me.btcrear = New System.Windows.Forms.Button()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btcargar = New System.Windows.Forms.Button()
        Me.btactualizar = New System.Windows.Forms.Button()
        Me.ccodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ccantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cprecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.csubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código de Gastos:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 107)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Código de Grupo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(442, 46)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 79)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cantidad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 43)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(245, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Código de Ingredientes:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dt_fecha)
        Me.GroupBox1.Controls.Add(Me.txtgrupo)
        Me.GroupBox1.Controls.Add(Me.txtgasto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 22)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(932, 144)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gastos"
        '
        'dt_fecha
        '
        Me.dt_fecha.Location = New System.Drawing.Point(536, 43)
        Me.dt_fecha.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dt_fecha.Name = "dt_fecha"
        Me.dt_fecha.Size = New System.Drawing.Size(373, 32)
        Me.dt_fecha.TabIndex = 6
        '
        'txtgrupo
        '
        Me.txtgrupo.Location = New System.Drawing.Point(227, 98)
        Me.txtgrupo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtgrupo.Name = "txtgrupo"
        Me.txtgrupo.Size = New System.Drawing.Size(186, 32)
        Me.txtgrupo.TabIndex = 4
        '
        'txtgasto
        '
        Me.txtgasto.Location = New System.Drawing.Point(227, 43)
        Me.txtgasto.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtgasto.Name = "txtgasto"
        Me.txtgasto.Size = New System.Drawing.Size(186, 32)
        Me.txtgasto.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtprecio)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.btagregar)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.txtcantidad)
        Me.GroupBox2.Controls.Add(Me.txtcod_ingre)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 205)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(932, 201)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles"
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(659, 76)
        Me.txtprecio.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(224, 32)
        Me.txtprecio.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(512, 88)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 23)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Precio"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(512, 43)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 23)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Descripción"
        '
        'btagregar
        '
        Me.btagregar.Location = New System.Drawing.Point(358, 132)
        Me.btagregar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btagregar.Name = "btagregar"
        Me.btagregar.Size = New System.Drawing.Size(156, 63)
        Me.btagregar.TabIndex = 10
        Me.btagregar.Text = "Agregar "
        Me.btagregar.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(659, 35)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(224, 31)
        Me.ComboBox1.TabIndex = 28
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(259, 79)
        Me.txtcantidad.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(224, 32)
        Me.txtcantidad.TabIndex = 8
        '
        'txtcod_ingre
        '
        Me.txtcod_ingre.Location = New System.Drawing.Point(259, 34)
        Me.txtcod_ingre.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtcod_ingre.Name = "txtcod_ingre"
        Me.txtcod_ingre.Size = New System.Drawing.Size(224, 32)
        Me.txtcod_ingre.TabIndex = 7
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ccodigo, Me.ccantidad, Me.cprecio, Me.csubtotal})
        Me.DataGridView1.Enabled = False
        Me.DataGridView1.Location = New System.Drawing.Point(26, 435)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(560, 216)
        Me.DataGridView1.TabIndex = 9
        '
        'btnatras
        '
        Me.btnatras.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnatras.Image = CType(resources.GetObject("btnatras.Image"), System.Drawing.Image)
        Me.btnatras.Location = New System.Drawing.Point(685, 553)
        Me.btnatras.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(141, 55)
        Me.btnatras.TabIndex = 26
        Me.btnatras.UseVisualStyleBackColor = False
        '
        'btcrear
        '
        Me.btcrear.Location = New System.Drawing.Point(64, 751)
        Me.btcrear.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btcrear.Name = "btcrear"
        Me.btcrear.Size = New System.Drawing.Size(159, 49)
        Me.btcrear.TabIndex = 27
        Me.btcrear.Text = "Crear"
        Me.btcrear.UseVisualStyleBackColor = True
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(760, 482)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(148, 32)
        Me.txttotal.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(656, 487)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 23)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "TOTAL"
        '
        'btcargar
        '
        Me.btcargar.Location = New System.Drawing.Point(1027, 65)
        Me.btcargar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btcargar.Name = "btcargar"
        Me.btcargar.Size = New System.Drawing.Size(146, 61)
        Me.btcargar.TabIndex = 30
        Me.btcargar.Text = "Cargar Factura"
        Me.btcargar.UseVisualStyleBackColor = True
        '
        'btactualizar
        '
        Me.btactualizar.Location = New System.Drawing.Point(1027, 255)
        Me.btactualizar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btactualizar.Name = "btactualizar"
        Me.btactualizar.Size = New System.Drawing.Size(146, 61)
        Me.btactualizar.TabIndex = 31
        Me.btactualizar.Text = "Actualizar Factura"
        Me.btactualizar.UseVisualStyleBackColor = True
        '
        'ccodigo
        '
        Me.ccodigo.HeaderText = "Código Ingrediente"
        Me.ccodigo.MinimumWidth = 6
        Me.ccodigo.Name = "ccodigo"
        Me.ccodigo.Width = 125
        '
        'ccantidad
        '
        Me.ccantidad.HeaderText = "Cantidad"
        Me.ccantidad.MinimumWidth = 6
        Me.ccantidad.Name = "ccantidad"
        Me.ccantidad.Width = 125
        '
        'cprecio
        '
        Me.cprecio.HeaderText = "Precio"
        Me.cprecio.MinimumWidth = 6
        Me.cprecio.Name = "cprecio"
        Me.cprecio.Width = 125
        '
        'csubtotal
        '
        Me.csubtotal.HeaderText = "Subtotal"
        Me.csubtotal.MinimumWidth = 6
        Me.csubtotal.Name = "csubtotal"
        Me.csubtotal.Width = 125
        '
        'Gasto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1316, 675)
        Me.Controls.Add(Me.btactualizar)
        Me.Controls.Add(Me.btcargar)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btcrear)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Gasto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gasto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtgrupo As TextBox
    Friend WithEvents txtgasto As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents txtcod_ingre As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btagregar As Button
    Friend WithEvents btnatras As Button
    Friend WithEvents btcrear As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dt_fecha As DateTimePicker
    Friend WithEvents btcargar As Button
    Friend WithEvents btactualizar As Button
    Friend WithEvents ccodigo As DataGridViewTextBoxColumn
    Friend WithEvents ccantidad As DataGridViewTextBoxColumn
    Friend WithEvents cprecio As DataGridViewTextBoxColumn
    Friend WithEvents csubtotal As DataGridViewTextBoxColumn
End Class
