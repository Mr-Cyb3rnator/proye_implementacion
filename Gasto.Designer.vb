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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbGrupo = New System.Windows.Forms.ComboBox()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.cbIngredientes = New System.Windows.Forms.ComboBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtcodIngre = New System.Windows.Forms.TextBox()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnFacturar = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvIngredientesUtilizados = New System.Windows.Forms.DataGridView()
        Me.ccodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ccantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cprecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.csubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvIngredientesUtilizados, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Controls.Add(Me.cbGrupo)
        Me.GroupBox1.Controls.Add(Me.dtFecha)
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
        'cbGrupo
        '
        Me.cbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGrupo.FormattingEnabled = True
        Me.cbGrupo.Location = New System.Drawing.Point(159, 40)
        Me.cbGrupo.Name = "cbGrupo"
        Me.cbGrupo.Size = New System.Drawing.Size(135, 31)
        Me.cbGrupo.TabIndex = 7
        '
        'dtFecha
        '
        Me.dtFecha.Enabled = False
        Me.dtFecha.Location = New System.Drawing.Point(447, 39)
        Me.dtFecha.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(373, 32)
        Me.dtFecha.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtPrecio)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.btnAgregar)
        Me.GroupBox2.Controls.Add(Me.cbIngredientes)
        Me.GroupBox2.Controls.Add(Me.txtCantidad)
        Me.GroupBox2.Controls.Add(Me.txtcodIngre)
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
        'txtPrecio
        '
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Location = New System.Drawing.Point(482, 108)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(116, 32)
        Me.txtPrecio.TabIndex = 30
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
        'btnAgregar
        '
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.Location = New System.Drawing.Point(688, 36)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(112, 98)
        Me.btnAgregar.TabIndex = 10
        Me.btnAgregar.Text = "Agregar "
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'cbIngredientes
        '
        Me.cbIngredientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbIngredientes.Enabled = False
        Me.cbIngredientes.FormattingEnabled = True
        Me.cbIngredientes.Location = New System.Drawing.Point(159, 31)
        Me.cbIngredientes.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbIngredientes.Name = "cbIngredientes"
        Me.cbIngredientes.Size = New System.Drawing.Size(135, 31)
        Me.cbIngredientes.TabIndex = 28
        '
        'txtCantidad
        '
        Me.txtCantidad.Enabled = False
        Me.txtCantidad.Location = New System.Drawing.Point(482, 36)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(116, 32)
        Me.txtCantidad.TabIndex = 8
        '
        'txtcodIngre
        '
        Me.txtcodIngre.Enabled = False
        Me.txtcodIngre.Location = New System.Drawing.Point(159, 102)
        Me.txtcodIngre.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtcodIngre.Name = "txtcodIngre"
        Me.txtcodIngre.Size = New System.Drawing.Size(116, 32)
        Me.txtcodIngre.TabIndex = 7
        '
        'btnAtras
        '
        Me.btnAtras.BackColor = System.Drawing.Color.BurlyWood
        Me.btnAtras.Image = Global.proye.My.Resources.Resources.atras__2_
        Me.btnAtras.Location = New System.Drawing.Point(753, 464)
        Me.btnAtras.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(109, 73)
        Me.btnAtras.TabIndex = 26
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'btnFacturar
        '
        Me.btnFacturar.Enabled = False
        Me.btnFacturar.Location = New System.Drawing.Point(594, 388)
        Me.btnFacturar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnFacturar.Name = "btnFacturar"
        Me.btnFacturar.Size = New System.Drawing.Size(109, 84)
        Me.btnFacturar.TabIndex = 27
        Me.btnFacturar.Text = "Facturar"
        Me.btnFacturar.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(728, 399)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(148, 32)
        Me.txtTotal.TabIndex = 29
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
        'dgvIngredientesUtilizados
        '
        Me.dgvIngredientesUtilizados.AllowUserToAddRows = False
        Me.dgvIngredientesUtilizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIngredientesUtilizados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ccodigo, Me.ccantidad, Me.cprecio, Me.csubtotal})
        Me.dgvIngredientesUtilizados.Location = New System.Drawing.Point(26, 334)
        Me.dgvIngredientesUtilizados.Name = "dgvIngredientesUtilizados"
        Me.dgvIngredientesUtilizados.ReadOnly = True
        Me.dgvIngredientesUtilizados.RowHeadersWidth = 51
        Me.dgvIngredientesUtilizados.RowTemplate.Height = 29
        Me.dgvIngredientesUtilizados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvIngredientesUtilizados.Size = New System.Drawing.Size(555, 240)
        Me.dgvIngredientesUtilizados.TabIndex = 30
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
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(594, 478)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(109, 88)
        Me.btnEliminar.TabIndex = 31
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Gasto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(911, 601)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dgvIngredientesUtilizados)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnFacturar)
        Me.Controls.Add(Me.btnAtras)
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
        CType(Me.dgvIngredientesUtilizados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtcodIngre As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnFacturar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents cbIngredientes As ComboBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dtFecha As DateTimePicker
    Friend WithEvents cbGrupo As ComboBox
    Friend WithEvents dgvIngredientesUtilizados As DataGridView
    Friend WithEvents btnEliminar As Button
    Friend WithEvents ccodigo As DataGridViewTextBoxColumn
    Friend WithEvents ccantidad As DataGridViewTextBoxColumn
    Friend WithEvents cprecio As DataGridViewTextBoxColumn
    Friend WithEvents csubtotal As DataGridViewTextBoxColumn
End Class
