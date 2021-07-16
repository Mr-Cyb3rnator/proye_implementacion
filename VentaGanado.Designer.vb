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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentaGanado))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcodcliente = New System.Windows.Forms.TextBox()
        Me.txtlibras_totales = New System.Windows.Forms.TextBox()
        Me.txtcodgrupo = New System.Windows.Forms.TextBox()
        Me.txt_preciolibra = New System.Windows.Forms.TextBox()
        Me.dgventaganado = New System.Windows.Forms.DataGridView()
        Me.btcargar_grupo = New System.Windows.Forms.Button()
        Me.btnVender = New System.Windows.Forms.Button()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.btnatras = New System.Windows.Forms.Button()
        Me.txttotalventa = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lb_Grupos = New System.Windows.Forms.Label()
        Me.dgvGrupos = New System.Windows.Forms.DataGridView()
        Me.lb_Animales = New System.Windows.Forms.Label()
        CType(Me.dgventaganado, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'txtcodcliente
        '
        Me.txtcodcliente.Enabled = False
        Me.txtcodcliente.Location = New System.Drawing.Point(251, 306)
        Me.txtcodcliente.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtcodcliente.Name = "txtcodcliente"
        Me.txtcodcliente.Size = New System.Drawing.Size(132, 32)
        Me.txtcodcliente.TabIndex = 7
        '
        'txtlibras_totales
        '
        Me.txtlibras_totales.Enabled = False
        Me.txtlibras_totales.Location = New System.Drawing.Point(251, 131)
        Me.txtlibras_totales.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtlibras_totales.Name = "txtlibras_totales"
        Me.txtlibras_totales.Size = New System.Drawing.Size(132, 32)
        Me.txtlibras_totales.TabIndex = 8
        '
        'txtcodgrupo
        '
        Me.txtcodgrupo.Location = New System.Drawing.Point(251, 70)
        Me.txtcodgrupo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtcodgrupo.MaxLength = 7
        Me.txtcodgrupo.Name = "txtcodgrupo"
        Me.txtcodgrupo.Size = New System.Drawing.Size(132, 32)
        Me.txtcodgrupo.TabIndex = 9
        '
        'txt_preciolibra
        '
        Me.txt_preciolibra.Enabled = False
        Me.txt_preciolibra.Location = New System.Drawing.Point(251, 185)
        Me.txt_preciolibra.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_preciolibra.Name = "txt_preciolibra"
        Me.txt_preciolibra.Size = New System.Drawing.Size(132, 32)
        Me.txt_preciolibra.TabIndex = 10
        '
        'dgventaganado
        '
        Me.dgventaganado.AllowUserToAddRows = False
        Me.dgventaganado.AllowUserToDeleteRows = False
        Me.dgventaganado.AllowUserToResizeColumns = False
        Me.dgventaganado.AllowUserToResizeRows = False
        Me.dgventaganado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgventaganado.Location = New System.Drawing.Point(777, 103)
        Me.dgventaganado.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgventaganado.MultiSelect = False
        Me.dgventaganado.Name = "dgventaganado"
        Me.dgventaganado.ReadOnly = True
        Me.dgventaganado.RowHeadersVisible = False
        Me.dgventaganado.RowHeadersWidth = 51
        Me.dgventaganado.RowTemplate.Height = 28
        Me.dgventaganado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgventaganado.Size = New System.Drawing.Size(317, 204)
        Me.dgventaganado.TabIndex = 19
        '
        'btcargar_grupo
        '
        Me.btcargar_grupo.BackColor = System.Drawing.Color.BurlyWood
        Me.btcargar_grupo.Enabled = False
        Me.btcargar_grupo.Location = New System.Drawing.Point(508, 313)
        Me.btcargar_grupo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btcargar_grupo.Name = "btcargar_grupo"
        Me.btcargar_grupo.Size = New System.Drawing.Size(160, 70)
        Me.btcargar_grupo.TabIndex = 22
        Me.btcargar_grupo.Text = "Cargar Grupo"
        Me.btcargar_grupo.UseVisualStyleBackColor = False
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
        'dtpfecha
        '
        Me.dtpfecha.Enabled = False
        Me.dtpfecha.Location = New System.Drawing.Point(173, 391)
        Me.dtpfecha.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(265, 32)
        Me.dtpfecha.TabIndex = 24
        '
        'btnatras
        '
        Me.btnatras.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnatras.Image = CType(resources.GetObject("btnatras.Image"), System.Drawing.Image)
        Me.btnatras.Location = New System.Drawing.Point(681, 403)
        Me.btnatras.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(153, 61)
        Me.btnatras.TabIndex = 25
        Me.btnatras.UseVisualStyleBackColor = False
        '
        'txttotalventa
        '
        Me.txttotalventa.Enabled = False
        Me.txttotalventa.Location = New System.Drawing.Point(251, 244)
        Me.txttotalventa.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txttotalventa.Name = "txttotalventa"
        Me.txttotalventa.Size = New System.Drawing.Size(132, 32)
        Me.txttotalventa.TabIndex = 27
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
        Me.Controls.Add(Me.txttotalventa)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.dtpfecha)
        Me.Controls.Add(Me.btcargar_grupo)
        Me.Controls.Add(Me.btnVender)
        Me.Controls.Add(Me.dgventaganado)
        Me.Controls.Add(Me.txt_preciolibra)
        Me.Controls.Add(Me.txtcodgrupo)
        Me.Controls.Add(Me.txtlibras_totales)
        Me.Controls.Add(Me.txtcodcliente)
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
        CType(Me.dgventaganado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcodcliente As TextBox
    Friend WithEvents txtlibras_totales As TextBox
    Friend WithEvents txtcodgrupo As TextBox
    Friend WithEvents txt_preciolibra As TextBox
    Friend WithEvents dgventaganado As DataGridView
    Friend WithEvents btcargar_grupo As Button
    Friend WithEvents btnVender As Button
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents btnatras As Button
    Friend WithEvents txttotalventa As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lb_Grupos As Label
    Friend WithEvents dgvGrupos As DataGridView
    Friend WithEvents lb_Animales As Label
End Class
