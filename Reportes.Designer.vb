<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reportes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbVenta = New System.Windows.Forms.RadioButton()
        Me.rbCompra = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGrupo = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTotalPrecio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLibras = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.dtpFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_ReportGenerator = New System.Windows.Forms.Button()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(291, 37)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(242, 27)
        Me.txtFiltro.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(227, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Filtro"
        '
        'dgvDatos
        '
        Me.dgvDatos.ColumnHeadersHeight = 29
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvDatos.Location = New System.Drawing.Point(30, 165)
        Me.dgvDatos.MultiSelect = False
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.RowHeadersWidth = 51
        Me.dgvDatos.RowTemplate.Height = 29
        Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatos.Size = New System.Drawing.Size(800, 246)
        Me.dgvDatos.TabIndex = 2
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.Color.BurlyWood
        Me.btnRegresar.Image = Global.proye.My.Resources.Resources.atras__2_
        Me.btnRegresar.Location = New System.Drawing.Point(736, 441)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(94, 77)
        Me.btnRegresar.TabIndex = 3
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbVenta)
        Me.GroupBox1.Controls.Add(Me.rbCompra)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(170, 113)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transaccion Animales"
        '
        'rbVenta
        '
        Me.rbVenta.AutoSize = True
        Me.rbVenta.Location = New System.Drawing.Point(23, 66)
        Me.rbVenta.Name = "rbVenta"
        Me.rbVenta.Size = New System.Drawing.Size(67, 24)
        Me.rbVenta.TabIndex = 1
        Me.rbVenta.Text = "Venta"
        Me.rbVenta.UseVisualStyleBackColor = True
        '
        'rbCompra
        '
        Me.rbCompra.AutoSize = True
        Me.rbCompra.Checked = True
        Me.rbCompra.Location = New System.Drawing.Point(23, 27)
        Me.rbCompra.Name = "rbCompra"
        Me.rbCompra.Size = New System.Drawing.Size(83, 24)
        Me.rbCompra.TabIndex = 0
        Me.rbCompra.TabStop = True
        Me.rbCompra.Text = "Compra"
        Me.rbCompra.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Grupo"
        '
        'txtGrupo
        '
        Me.txtGrupo.Location = New System.Drawing.Point(99, 39)
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.Size = New System.Drawing.Size(125, 27)
        Me.txtGrupo.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTotalPrecio)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtLibras)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtCliente)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtGrupo)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(39, 459)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(381, 223)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Grupo General"
        '
        'txtTotalPrecio
        '
        Me.txtTotalPrecio.Location = New System.Drawing.Point(99, 180)
        Me.txtTotalPrecio.Name = "txtTotalPrecio"
        Me.txtTotalPrecio.Size = New System.Drawing.Size(125, 27)
        Me.txtTotalPrecio.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Total"
        '
        'txtLibras
        '
        Me.txtLibras.Location = New System.Drawing.Point(99, 136)
        Me.txtLibras.Name = "txtLibras"
        Me.txtLibras.Size = New System.Drawing.Size(125, 27)
        Me.txtLibras.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Libras"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(99, 89)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(125, 27)
        Me.txtCliente.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cliente"
        '
        'cbTipo
        '
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Location = New System.Drawing.Point(605, 36)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(151, 28)
        Me.cbTipo.TabIndex = 8
        '
        'dtpFinal
        '
        Me.dtpFinal.Checked = False
        Me.dtpFinal.CustomFormat = "yyyy - MMM - dd"
        Me.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFinal.Location = New System.Drawing.Point(506, 111)
        Me.dtpFinal.Name = "dtpFinal"
        Me.dtpFinal.Size = New System.Drawing.Size(250, 27)
        Me.dtpFinal.TabIndex = 9
        '
        'dtpInicio
        '
        Me.dtpInicio.CustomFormat = "yyyy - MMM - dd"
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpInicio.Location = New System.Drawing.Point(227, 112)
        Me.dtpInicio.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(250, 27)
        Me.dtpInicio.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(557, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Tipo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(321, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Fecha Inicio"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(592, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Fecha Final"
        '
        'btn_ReportGenerator
        '
        Me.btn_ReportGenerator.Location = New System.Drawing.Point(524, 526)
        Me.btn_ReportGenerator.Name = "btn_ReportGenerator"
        Me.btn_ReportGenerator.Size = New System.Drawing.Size(94, 89)
        Me.btn_ReportGenerator.TabIndex = 14
        Me.btn_ReportGenerator.Text = "Generador" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reporte"
        Me.btn_ReportGenerator.UseVisualStyleBackColor = True
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(911, 724)
        Me.Controls.Add(Me.btn_ReportGenerator)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpInicio)
        Me.Controls.Add(Me.dtpFinal)
        Me.Controls.Add(Me.cbTipo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFiltro)
        Me.Name = "Reportes"
        Me.Text = "Reportes"
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDatos As DataGridView
    Friend WithEvents btnRegresar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbVenta As RadioButton
    Friend WithEvents rbCompra As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGrupo As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtTotalPrecio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLibras As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbTipo As ComboBox
    Friend WithEvents dtpFinal As DateTimePicker
    Friend WithEvents dtpInicio As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_ReportGenerator As Button
End Class
