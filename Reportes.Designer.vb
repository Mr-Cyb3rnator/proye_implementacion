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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(690, 123)
        Me.txtFiltro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(216, 32)
        Me.txtFiltro.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(632, 125)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Filtro"
        '
        'dgvDatos
        '
        Me.dgvDatos.ColumnHeadersHeight = 29
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvDatos.Location = New System.Drawing.Point(45, 190)
        Me.dgvDatos.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgvDatos.MultiSelect = False
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.RowHeadersWidth = 51
        Me.dgvDatos.RowTemplate.Height = 29
        Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatos.Size = New System.Drawing.Size(861, 283)
        Me.dgvDatos.TabIndex = 2
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.Color.BurlyWood
        Me.btnRegresar.Image = Global.proye.My.Resources.Resources.atras__2_
        Me.btnRegresar.Location = New System.Drawing.Point(641, 648)
        Me.btnRegresar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(141, 89)
        Me.btnRegresar.TabIndex = 3
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbVenta)
        Me.GroupBox1.Controls.Add(Me.rbCompra)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(45, 29)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(261, 130)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transaccion Animales"
        '
        'rbVenta
        '
        Me.rbVenta.AutoSize = True
        Me.rbVenta.Location = New System.Drawing.Point(34, 76)
        Me.rbVenta.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rbVenta.Name = "rbVenta"
        Me.rbVenta.Size = New System.Drawing.Size(92, 27)
        Me.rbVenta.TabIndex = 1
        Me.rbVenta.Text = "Venta"
        Me.rbVenta.UseVisualStyleBackColor = True
        '
        'rbCompra
        '
        Me.rbCompra.AutoSize = True
        Me.rbCompra.Checked = True
        Me.rbCompra.Location = New System.Drawing.Point(34, 31)
        Me.rbCompra.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rbCompra.Name = "rbCompra"
        Me.rbCompra.Size = New System.Drawing.Size(113, 27)
        Me.rbCompra.TabIndex = 0
        Me.rbCompra.TabStop = True
        Me.rbCompra.Text = "Compra"
        Me.rbCompra.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 45)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Grupo"
        '
        'txtGrupo
        '
        Me.txtGrupo.Enabled = False
        Me.txtGrupo.Location = New System.Drawing.Point(148, 45)
        Me.txtGrupo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.Size = New System.Drawing.Size(264, 32)
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
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(59, 507)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(490, 256)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Grupo General"
        '
        'txtTotalPrecio
        '
        Me.txtTotalPrecio.Enabled = False
        Me.txtTotalPrecio.Location = New System.Drawing.Point(148, 207)
        Me.txtTotalPrecio.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtTotalPrecio.Name = "txtTotalPrecio"
        Me.txtTotalPrecio.Size = New System.Drawing.Size(264, 32)
        Me.txtTotalPrecio.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 207)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 23)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Total"
        '
        'txtLibras
        '
        Me.txtLibras.Enabled = False
        Me.txtLibras.Location = New System.Drawing.Point(148, 156)
        Me.txtLibras.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtLibras.Name = "txtLibras"
        Me.txtLibras.Size = New System.Drawing.Size(264, 32)
        Me.txtLibras.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 156)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 23)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Libras"
        '
        'txtCliente
        '
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(148, 102)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(264, 32)
        Me.txtCliente.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 102)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cliente"
        '
        'cbTipo
        '
        Me.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Location = New System.Drawing.Point(428, 122)
        Me.cbTipo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(134, 31)
        Me.cbTipo.TabIndex = 8
        '
        'dtpFinal
        '
        Me.dtpFinal.Checked = False
        Me.dtpFinal.CustomFormat = "yyyy - MMM - dd"
        Me.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFinal.Location = New System.Drawing.Point(690, 40)
        Me.dtpFinal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dtpFinal.Name = "dtpFinal"
        Me.dtpFinal.Size = New System.Drawing.Size(216, 32)
        Me.dtpFinal.TabIndex = 9
        '
        'dtpInicio
        '
        Me.dtpInicio.CustomFormat = "yyyy - MMM - dd"
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpInicio.Location = New System.Drawing.Point(367, 40)
        Me.dtpInicio.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dtpInicio.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(233, 32)
        Me.dtpInicio.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(356, 126)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 23)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Tipo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(435, 9)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 23)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Fecha Inicio"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(739, 9)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 23)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Fecha Final"
        '
        'btn_ReportGenerator
        '
        Me.btn_ReportGenerator.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_ReportGenerator.Location = New System.Drawing.Point(600, 494)
        Me.btn_ReportGenerator.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_ReportGenerator.Name = "btn_ReportGenerator"
        Me.btn_ReportGenerator.Size = New System.Drawing.Size(234, 102)
        Me.btn_ReportGenerator.TabIndex = 14
        Me.btn_ReportGenerator.Text = "Generador" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reporte"
        Me.btn_ReportGenerator.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(396, 246)
        Me.ReportViewer1.TabIndex = 0
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1022, 788)
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
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Reportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
