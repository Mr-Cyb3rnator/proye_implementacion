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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_Grupo = New System.Windows.Forms.ComboBox()
        Me.dt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btagregar = New System.Windows.Forms.Button()
        Me.cb_Ingredientes = New System.Windows.Forms.ComboBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.txtcod_ingre = New System.Windows.Forms.TextBox()
        Me.btnatras = New System.Windows.Forms.Button()
        Me.btcrear = New System.Windows.Forms.Button()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ccodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ccantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cprecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.csubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b_Eliminar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "# Grupo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(336, 46)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(336, 39)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cantidad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 88)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 46)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Código " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ingrediente:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb_Grupo)
        Me.GroupBox1.Controls.Add(Me.dt_fecha)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 22)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(836, 95)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gastos"
        '
        'cb_Grupo
        '
        Me.cb_Grupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Grupo.FormattingEnabled = True
        Me.cb_Grupo.Location = New System.Drawing.Point(159, 40)
        Me.cb_Grupo.Name = "cb_Grupo"
        Me.cb_Grupo.Size = New System.Drawing.Size(135, 31)
        Me.cb_Grupo.TabIndex = 7
        '
        'dt_fecha
        '
        Me.dt_fecha.Enabled = False
        Me.dt_fecha.Location = New System.Drawing.Point(447, 39)
        Me.dt_fecha.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dt_fecha.Name = "dt_fecha"
        Me.dt_fecha.Size = New System.Drawing.Size(373, 32)
        Me.dt_fecha.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtprecio)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.btagregar)
        Me.GroupBox2.Controls.Add(Me.cb_Ingredientes)
        Me.GroupBox2.Controls.Add(Me.txtcantidad)
        Me.GroupBox2.Controls.Add(Me.txtcod_ingre)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 140)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(836, 163)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles"
        '
        'txtprecio
        '
        Me.txtprecio.Enabled = False
        Me.txtprecio.Location = New System.Drawing.Point(482, 108)
        Me.txtprecio.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(116, 32)
        Me.txtprecio.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(336, 111)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 23)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Precio"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 39)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 23)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Ingrediente"
        '
        'btagregar
        '
        Me.btagregar.Enabled = False
        Me.btagregar.Location = New System.Drawing.Point(688, 36)
        Me.btagregar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btagregar.Name = "btagregar"
        Me.btagregar.Size = New System.Drawing.Size(112, 98)
        Me.btagregar.TabIndex = 10
        Me.btagregar.Text = "Agregar "
        Me.btagregar.UseVisualStyleBackColor = True
        '
        'cb_Ingredientes
        '
        Me.cb_Ingredientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Ingredientes.Enabled = False
        Me.cb_Ingredientes.FormattingEnabled = True
        Me.cb_Ingredientes.Location = New System.Drawing.Point(159, 31)
        Me.cb_Ingredientes.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cb_Ingredientes.Name = "cb_Ingredientes"
        Me.cb_Ingredientes.Size = New System.Drawing.Size(135, 31)
        Me.cb_Ingredientes.TabIndex = 28
        '
        'txtcantidad
        '
        Me.txtcantidad.Enabled = False
        Me.txtcantidad.Location = New System.Drawing.Point(482, 36)
        Me.txtcantidad.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(116, 32)
        Me.txtcantidad.TabIndex = 8
        '
        'txtcod_ingre
        '
        Me.txtcod_ingre.Enabled = False
        Me.txtcod_ingre.Location = New System.Drawing.Point(159, 102)
        Me.txtcod_ingre.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtcod_ingre.Name = "txtcod_ingre"
        Me.txtcod_ingre.Size = New System.Drawing.Size(116, 32)
        Me.txtcod_ingre.TabIndex = 7
        '
        'btnatras
        '
        Me.btnatras.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnatras.Image = CType(resources.GetObject("btnatras.Image"), System.Drawing.Image)
        Me.btnatras.Location = New System.Drawing.Point(753, 464)
        Me.btnatras.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(109, 73)
        Me.btnatras.TabIndex = 26
        Me.btnatras.UseVisualStyleBackColor = False
        '
        'btcrear
        '
        Me.btcrear.Enabled = False
        Me.btcrear.Location = New System.Drawing.Point(594, 388)
        Me.btcrear.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btcrear.Name = "btcrear"
        Me.btcrear.Size = New System.Drawing.Size(109, 84)
        Me.btcrear.TabIndex = 27
        Me.btcrear.Text = "Facturar"
        Me.btcrear.UseVisualStyleBackColor = True
        '
        'txttotal
        '
        Me.txttotal.Enabled = False
        Me.txttotal.Location = New System.Drawing.Point(728, 399)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(148, 32)
        Me.txttotal.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(759, 357)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 23)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "TOTAL"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ccodigo, Me.ccantidad, Me.cprecio, Me.csubtotal})
        Me.DataGridView1.Location = New System.Drawing.Point(26, 334)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(555, 240)
        Me.DataGridView1.TabIndex = 30
        '
        'ccodigo
        '
        Me.ccodigo.HeaderText = "Código Ingrediente"
        Me.ccodigo.MinimumWidth = 6
        Me.ccodigo.Name = "ccodigo"
        Me.ccodigo.ReadOnly = True
        Me.ccodigo.Width = 125
        '
        'ccantidad
        '
        Me.ccantidad.HeaderText = "Cantidad"
        Me.ccantidad.MinimumWidth = 6
        Me.ccantidad.Name = "ccantidad"
        Me.ccantidad.ReadOnly = True
        Me.ccantidad.Width = 125
        '
        'cprecio
        '
        Me.cprecio.HeaderText = "Precio"
        Me.cprecio.MinimumWidth = 6
        Me.cprecio.Name = "cprecio"
        Me.cprecio.ReadOnly = True
        Me.cprecio.Width = 125
        '
        'csubtotal
        '
        Me.csubtotal.HeaderText = "Subtotal"
        Me.csubtotal.MinimumWidth = 6
        Me.csubtotal.Name = "csubtotal"
        Me.csubtotal.ReadOnly = True
        Me.csubtotal.Width = 125
        '
        'b_Eliminar
        '
        Me.b_Eliminar.Enabled = False
        Me.b_Eliminar.Location = New System.Drawing.Point(594, 478)
        Me.b_Eliminar.Name = "b_Eliminar"
        Me.b_Eliminar.Size = New System.Drawing.Size(109, 88)
        Me.b_Eliminar.TabIndex = 31
        Me.b_Eliminar.Text = "Eliminar"
        Me.b_Eliminar.UseVisualStyleBackColor = True
        '
        'Gasto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(911, 601)
        Me.Controls.Add(Me.b_Eliminar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btcrear)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents txtcod_ingre As TextBox
    Friend WithEvents btagregar As Button
    Friend WithEvents btnatras As Button
    Friend WithEvents btcrear As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents cb_Ingredientes As ComboBox
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dt_fecha As DateTimePicker
    Friend WithEvents cb_Grupo As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents b_Eliminar As Button
    Friend WithEvents ccodigo As DataGridViewTextBoxColumn
    Friend WithEvents ccantidad As DataGridViewTextBoxColumn
    Friend WithEvents cprecio As DataGridViewTextBoxColumn
    Friend WithEvents csubtotal As DataGridViewTextBoxColumn
End Class
