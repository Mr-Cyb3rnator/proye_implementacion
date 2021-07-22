<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class estado_resultados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(estado_resultados))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGrupo = New System.Windows.Forms.TextBox()
        Me.btcargar_gastos = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvGastos = New System.Windows.Forms.DataGridView()
        Me.txtTotalGastos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCostoCompra = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvVenta = New System.Windows.Forms.DataGridView()
        Me.txtTotalVenta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvAnimales = New System.Windows.Forms.DataGridView()
        Me.txtganacia = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btcalcular = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnatras = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvAnimales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(94, 121)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código del grupo:"
        '
        'txtGrupo
        '
        Me.txtGrupo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtGrupo.Location = New System.Drawing.Point(334, 120)
        Me.txtGrupo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.Size = New System.Drawing.Size(124, 37)
        Me.txtGrupo.TabIndex = 1
        '
        'btcargar_gastos
        '
        Me.btcargar_gastos.BackColor = System.Drawing.Color.BurlyWood
        Me.btcargar_gastos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btcargar_gastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btcargar_gastos.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btcargar_gastos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btcargar_gastos.Location = New System.Drawing.Point(499, 71)
        Me.btcargar_gastos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btcargar_gastos.Name = "btcargar_gastos"
        Me.btcargar_gastos.Size = New System.Drawing.Size(146, 100)
        Me.btcargar_gastos.TabIndex = 4
        Me.btcargar_gastos.Text = "Cargar Gastos"
        Me.btcargar_gastos.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvGastos)
        Me.GroupBox1.Controls.Add(Me.txtTotalGastos)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(1016, 164)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(679, 621)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gastos"
        '
        'dgvGastos
        '
        Me.dgvGastos.AllowUserToResizeColumns = False
        Me.dgvGastos.AllowUserToResizeRows = False
        Me.dgvGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGastos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvGastos.Location = New System.Drawing.Point(19, 34)
        Me.dgvGastos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvGastos.Name = "dgvGastos"
        Me.dgvGastos.ReadOnly = True
        Me.dgvGastos.RowHeadersWidth = 51
        Me.dgvGastos.RowTemplate.Height = 24
        Me.dgvGastos.Size = New System.Drawing.Size(641, 361)
        Me.dgvGastos.TabIndex = 0
        '
        'txtTotalGastos
        '
        Me.txtTotalGastos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalGastos.Enabled = False
        Me.txtTotalGastos.Location = New System.Drawing.Point(382, 479)
        Me.txtTotalGastos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTotalGastos.Name = "txtTotalGastos"
        Me.txtTotalGastos.Size = New System.Drawing.Size(124, 30)
        Me.txtTotalGastos.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(214, 481)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 30)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Total gastos:"
        '
        'txtCostoCompra
        '
        Me.txtCostoCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCostoCompra.Enabled = False
        Me.txtCostoCompra.Location = New System.Drawing.Point(839, 190)
        Me.txtCostoCompra.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCostoCompra.Name = "txtCostoCompra"
        Me.txtCostoCompra.Size = New System.Drawing.Size(124, 30)
        Me.txtCostoCompra.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(539, 190)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(291, 30)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Total costo de compra:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvVenta)
        Me.GroupBox2.Controls.Add(Me.txtTotalVenta)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(31, 576)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(976, 416)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Venta"
        '
        'dgvVenta
        '
        Me.dgvVenta.AllowUserToResizeColumns = False
        Me.dgvVenta.AllowUserToResizeRows = False
        Me.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvVenta.Location = New System.Drawing.Point(19, 40)
        Me.dgvVenta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvVenta.Name = "dgvVenta"
        Me.dgvVenta.ReadOnly = True
        Me.dgvVenta.RowHeadersWidth = 51
        Me.dgvVenta.RowTemplate.Height = 24
        Me.dgvVenta.Size = New System.Drawing.Size(502, 349)
        Me.dgvVenta.TabIndex = 7
        '
        'txtTotalVenta
        '
        Me.txtTotalVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalVenta.Enabled = False
        Me.txtTotalVenta.Location = New System.Drawing.Point(839, 189)
        Me.txtTotalVenta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTotalVenta.Name = "txtTotalVenta"
        Me.txtTotalVenta.Size = New System.Drawing.Size(124, 30)
        Me.txtTotalVenta.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(676, 191)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 30)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Total venta:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvAnimales)
        Me.GroupBox3.Controls.Add(Me.txtCostoCompra)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox3.Location = New System.Drawing.Point(31, 164)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Size = New System.Drawing.Size(976, 404)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Grupo"
        '
        'dgvAnimales
        '
        Me.dgvAnimales.AllowUserToResizeColumns = False
        Me.dgvAnimales.AllowUserToResizeRows = False
        Me.dgvAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAnimales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvAnimales.Location = New System.Drawing.Point(19, 34)
        Me.dgvAnimales.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvAnimales.Name = "dgvAnimales"
        Me.dgvAnimales.ReadOnly = True
        Me.dgvAnimales.RowHeadersWidth = 51
        Me.dgvAnimales.RowTemplate.Height = 24
        Me.dgvAnimales.Size = New System.Drawing.Size(502, 346)
        Me.dgvAnimales.TabIndex = 7
        '
        'txtganacia
        '
        Me.txtganacia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtganacia.Enabled = False
        Me.txtganacia.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtganacia.Location = New System.Drawing.Point(1399, 815)
        Me.txtganacia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtganacia.Name = "txtganacia"
        Me.txtganacia.Size = New System.Drawing.Size(124, 30)
        Me.txtganacia.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(1069, 815)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(323, 30)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Total ganancia o perdida:"
        '
        'btcalcular
        '
        Me.btcalcular.BackColor = System.Drawing.Color.BurlyWood
        Me.btcalcular.Enabled = False
        Me.btcalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btcalcular.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btcalcular.Location = New System.Drawing.Point(1231, 894)
        Me.btcalcular.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btcalcular.Name = "btcalcular"
        Me.btcalcular.Size = New System.Drawing.Size(146, 74)
        Me.btcalcular.TabIndex = 37
        Me.btcalcular.Text = "Calcular"
        Me.btcalcular.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(610, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(295, 34)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Estado de Resultado"
        '
        'btnatras
        '
        Me.btnatras.BackColor = System.Drawing.Color.BurlyWood
        Me.btnatras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnatras.Image = Global.proye.My.Resources.Resources.atras__2_
        Me.btnatras.Location = New System.Drawing.Point(1566, 894)
        Me.btnatras.Margin = New System.Windows.Forms.Padding(4)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(129, 85)
        Me.btnatras.TabIndex = 38
        Me.btnatras.UseVisualStyleBackColor = False
        '
        'estado_resultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1729, 1030)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.txtGrupo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btcalcular)
        Me.Controls.Add(Me.txtganacia)
        Me.Controls.Add(Me.btcargar_gastos)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "estado_resultados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balance"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvGastos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvAnimales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtGrupo As TextBox
    Friend WithEvents btcargar_gastos As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvGastos As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvVenta As DataGridView
    Friend WithEvents txtTotalGastos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvAnimales As DataGridView
    Friend WithEvents txtTotalVenta As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCostoCompra As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtganacia As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btcalcular As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnatras As Button
End Class
