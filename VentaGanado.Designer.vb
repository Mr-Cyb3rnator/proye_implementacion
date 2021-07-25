<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentaGanado
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.txtLibrasTotales = New System.Windows.Forms.TextBox()
        Me.txtCodGrupo = New System.Windows.Forms.TextBox()
        Me.txtPrecioLibra = New System.Windows.Forms.TextBox()
        Me.dgvVentaGanado = New System.Windows.Forms.DataGridView()
        Me.btnCargarGrupo = New System.Windows.Forms.Button()
        Me.btnVender = New System.Windows.Forms.Button()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.txtTotalVenta = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lb_Grupos = New System.Windows.Forms.Label()
        Me.dgvGrupos = New System.Windows.Forms.DataGridView()
        Me.lb_Animales = New System.Windows.Forms.Label()
        CType(Me.dgvVentaGanado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 134)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Lbs. del Grupo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 188)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Precio x Libra:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 309)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Código Cliente: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 73)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Código Grupo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 391)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fecha:"
        '
        'txtCodCliente
        '
        Me.txtCodCliente.Enabled = False
        Me.txtCodCliente.Location = New System.Drawing.Point(251, 306)
        Me.txtCodCliente.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.Size = New System.Drawing.Size(132, 32)
        Me.txtCodCliente.TabIndex = 7
        '
        'txtLibrasTotales
        '
        Me.txtLibrasTotales.Enabled = False
        Me.txtLibrasTotales.Location = New System.Drawing.Point(251, 131)
        Me.txtLibrasTotales.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtLibrasTotales.Name = "txtLibrasTotales"
        Me.txtLibrasTotales.Size = New System.Drawing.Size(132, 32)
        Me.txtLibrasTotales.TabIndex = 8
        '
        'txtCodGrupo
        '
        Me.txtCodGrupo.Location = New System.Drawing.Point(251, 70)
        Me.txtCodGrupo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCodGrupo.MaxLength = 7
        Me.txtCodGrupo.Name = "txtCodGrupo"
        Me.txtCodGrupo.Size = New System.Drawing.Size(132, 32)
        Me.txtCodGrupo.TabIndex = 9
        '
        'txtPrecioLibra
        '
        Me.txtPrecioLibra.Enabled = False
        Me.txtPrecioLibra.Location = New System.Drawing.Point(251, 185)
        Me.txtPrecioLibra.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPrecioLibra.Name = "txtPrecioLibra"
        Me.txtPrecioLibra.Size = New System.Drawing.Size(132, 32)
        Me.txtPrecioLibra.TabIndex = 10
        '
        'dgvVentaGanado
        '
        Me.dgvVentaGanado.AllowUserToAddRows = False
        Me.dgvVentaGanado.AllowUserToDeleteRows = False
        Me.dgvVentaGanado.AllowUserToResizeColumns = False
        Me.dgvVentaGanado.AllowUserToResizeRows = False
        Me.dgvVentaGanado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentaGanado.Location = New System.Drawing.Point(777, 103)
        Me.dgvVentaGanado.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgvVentaGanado.MultiSelect = False
        Me.dgvVentaGanado.Name = "dgvVentaGanado"
        Me.dgvVentaGanado.ReadOnly = True
        Me.dgvVentaGanado.RowHeadersVisible = False
        Me.dgvVentaGanado.RowHeadersWidth = 51
        Me.dgvVentaGanado.RowTemplate.Height = 28
        Me.dgvVentaGanado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVentaGanado.Size = New System.Drawing.Size(317, 204)
        Me.dgvVentaGanado.TabIndex = 19
        '
        'btnCargarGrupo
        '
        Me.btnCargarGrupo.BackColor = System.Drawing.Color.BurlyWood
        Me.btnCargarGrupo.Enabled = False
        Me.btnCargarGrupo.Location = New System.Drawing.Point(508, 313)
        Me.btnCargarGrupo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCargarGrupo.Name = "btnCargarGrupo"
        Me.btnCargarGrupo.Size = New System.Drawing.Size(160, 70)
        Me.btnCargarGrupo.TabIndex = 22
        Me.btnCargarGrupo.Text = "Cargar Grupo"
        Me.btnCargarGrupo.UseVisualStyleBackColor = False
        '
        'btnVender
        '
        Me.btnVender.BackColor = System.Drawing.Color.BurlyWood
        Me.btnVender.Enabled = False
        Me.btnVender.Location = New System.Drawing.Point(848, 313)
        Me.btnVender.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnVender.Name = "btnVender"
        Me.btnVender.Size = New System.Drawing.Size(166, 70)
        Me.btnVender.TabIndex = 21
        Me.btnVender.Text = "Vender"
        Me.btnVender.UseVisualStyleBackColor = False
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Location = New System.Drawing.Point(173, 391)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(265, 32)
        Me.dtpFecha.TabIndex = 24
        '
        'btnAtras
        '
        Me.btnAtras.BackColor = System.Drawing.Color.BurlyWood
        Me.btnAtras.Image = Global.proye.My.Resources.Resources.atras__2_
        Me.btnAtras.Location = New System.Drawing.Point(991, 400)
        Me.btnAtras.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(103, 61)
        Me.btnAtras.TabIndex = 25
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'txtTotalVenta
        '
        Me.txtTotalVenta.Enabled = False
        Me.txtTotalVenta.Location = New System.Drawing.Point(251, 244)
        Me.txtTotalVenta.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtTotalVenta.Name = "txtTotalVenta"
        Me.txtTotalVenta.Size = New System.Drawing.Size(132, 32)
        Me.txtTotalVenta.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 247)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 23)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Total Venta"
        '
        'lb_Grupos
        '
        Me.lb_Grupos.AutoSize = True
        Me.lb_Grupos.Location = New System.Drawing.Point(548, 61)
        Me.lb_Grupos.Name = "lb_Grupos"
        Me.lb_Grupos.Size = New System.Drawing.Size(80, 23)
        Me.lb_Grupos.TabIndex = 28
        Me.lb_Grupos.Text = "Grupos"
        '
        'dgvGrupos
        '
        Me.dgvGrupos.AllowUserToAddRows = False
        Me.dgvGrupos.AllowUserToDeleteRows = False
        Me.dgvGrupos.AllowUserToResizeColumns = False
        Me.dgvGrupos.AllowUserToResizeRows = False
        Me.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrupos.Location = New System.Drawing.Point(476, 100)
        Me.dgvGrupos.MultiSelect = False
        Me.dgvGrupos.Name = "dgvGrupos"
        Me.dgvGrupos.ReadOnly = True
        Me.dgvGrupos.RowHeadersVisible = False
        Me.dgvGrupos.RowHeadersWidth = 51
        Me.dgvGrupos.RowTemplate.Height = 29
        Me.dgvGrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGrupos.Size = New System.Drawing.Size(222, 207)
        Me.dgvGrupos.TabIndex = 29
        '
        'lb_Animales
        '
        Me.lb_Animales.AutoSize = True
        Me.lb_Animales.Location = New System.Drawing.Point(837, 59)
        Me.lb_Animales.Name = "lb_Animales"
        Me.lb_Animales.Size = New System.Drawing.Size(200, 23)
        Me.lb_Animales.TabIndex = 30
        Me.lb_Animales.Text = "Animales de Grupo"
        '
        'VentaGanado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1139, 493)
        Me.Controls.Add(Me.lb_Animales)
        Me.Controls.Add(Me.dgvGrupos)
        Me.Controls.Add(Me.lb_Grupos)
        Me.Controls.Add(Me.txtTotalVenta)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.btnCargarGrupo)
        Me.Controls.Add(Me.btnVender)
        Me.Controls.Add(Me.dgvVentaGanado)
        Me.Controls.Add(Me.txtPrecioLibra)
        Me.Controls.Add(Me.txtCodGrupo)
        Me.Controls.Add(Me.txtLibrasTotales)
        Me.Controls.Add(Me.txtCodCliente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "VentaGanado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VentaGanado"
        CType(Me.dgvVentaGanado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCodCliente As TextBox
    Friend WithEvents txtLibrasTotales As TextBox
    Friend WithEvents txtCodGrupo As TextBox
    Friend WithEvents txtPrecioLibra As TextBox
    Friend WithEvents dgvVentaGanado As DataGridView
    Friend WithEvents btnCargarGrupo As Button
    Friend WithEvents btnVender As Button
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents btnAtras As Button
    Friend WithEvents txtTotalVenta As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lb_Grupos As Label
    Friend WithEvents dgvGrupos As DataGridView
    Friend WithEvents lb_Animales As Label
End Class
