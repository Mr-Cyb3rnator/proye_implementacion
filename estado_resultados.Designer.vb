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
        Me.txtgrupo = New System.Windows.Forms.TextBox()
        Me.txt_cod_gastos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btcargar_gastos = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView_venta = New System.Windows.Forms.DataGridView()
        Me.txt_total_gastos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcod_venta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btcargar_venta = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView_animales = New System.Windows.Forms.DataGridView()
        Me.txt_totalventa = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_costo_compra = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtganacia = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btcalcular = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView_venta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView_animales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Grupo"
        '
        'txtgrupo
        '
        Me.txtgrupo.Location = New System.Drawing.Point(123, 22)
        Me.txtgrupo.Name = "txtgrupo"
        Me.txtgrupo.Size = New System.Drawing.Size(88, 23)
        Me.txtgrupo.TabIndex = 1
        '
        'txt_cod_gastos
        '
        Me.txt_cod_gastos.Location = New System.Drawing.Point(348, 22)
        Me.txt_cod_gastos.Name = "txt_cod_gastos"
        Me.txt_cod_gastos.Size = New System.Drawing.Size(88, 23)
        Me.txt_cod_gastos.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(250, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Codigo Gastos"
        '
        'btcargar_gastos
        '
        Me.btcargar_gastos.Location = New System.Drawing.Point(482, 17)
        Me.btcargar_gastos.Name = "btcargar_gastos"
        Me.btcargar_gastos.Size = New System.Drawing.Size(86, 44)
        Me.btcargar_gastos.TabIndex = 4
        Me.btcargar_gastos.Text = "Cargar Gastos"
        Me.btcargar_gastos.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(570, 242)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gastos"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(5, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(560, 217)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView_venta)
        Me.GroupBox2.Location = New System.Drawing.Point(606, 80)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(570, 242)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Venta"
        '
        'DataGridView_venta
        '
        Me.DataGridView_venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_venta.Location = New System.Drawing.Point(5, 19)
        Me.DataGridView_venta.Name = "DataGridView_venta"
        Me.DataGridView_venta.RowHeadersWidth = 51
        Me.DataGridView_venta.RowTemplate.Height = 24
        Me.DataGridView_venta.Size = New System.Drawing.Size(560, 217)
        Me.DataGridView_venta.TabIndex = 7
        '
        'txt_total_gastos
        '
        Me.txt_total_gastos.Location = New System.Drawing.Point(103, 327)
        Me.txt_total_gastos.Name = "txt_total_gastos"
        Me.txt_total_gastos.Size = New System.Drawing.Size(88, 23)
        Me.txt_total_gastos.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 327)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Total gasto"
        '
        'txtcod_venta
        '
        Me.txtcod_venta.Location = New System.Drawing.Point(792, 32)
        Me.txtcod_venta.Name = "txtcod_venta"
        Me.txtcod_venta.Size = New System.Drawing.Size(88, 23)
        Me.txtcod_venta.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(694, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 15)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Codigo venta"
        '
        'btcargar_venta
        '
        Me.btcargar_venta.Location = New System.Drawing.Point(992, 20)
        Me.btcargar_venta.Name = "btcargar_venta"
        Me.btcargar_venta.Size = New System.Drawing.Size(86, 44)
        Me.btcargar_venta.TabIndex = 29
        Me.btcargar_venta.Text = "Cargar Venta"
        Me.btcargar_venta.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView_animales)
        Me.GroupBox3.Location = New System.Drawing.Point(20, 377)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(570, 242)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Grupo"
        '
        'DataGridView_animales
        '
        Me.DataGridView_animales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_animales.Location = New System.Drawing.Point(5, 21)
        Me.DataGridView_animales.Name = "DataGridView_animales"
        Me.DataGridView_animales.RowHeadersWidth = 51
        Me.DataGridView_animales.RowTemplate.Height = 24
        Me.DataGridView_animales.Size = New System.Drawing.Size(555, 208)
        Me.DataGridView_animales.TabIndex = 7
        '
        'txt_totalventa
        '
        Me.txt_totalventa.Location = New System.Drawing.Point(710, 327)
        Me.txt_totalventa.Name = "txt_totalventa"
        Me.txt_totalventa.Size = New System.Drawing.Size(88, 23)
        Me.txt_totalventa.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(625, 327)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 15)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Total venta"
        '
        'txt_costo_compra
        '
        Me.txt_costo_compra.Location = New System.Drawing.Point(176, 622)
        Me.txt_costo_compra.Name = "txt_costo_compra"
        Me.txt_costo_compra.Size = New System.Drawing.Size(88, 23)
        Me.txt_costo_compra.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 625)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 15)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Total Costo de compra"
        '
        'txtganacia
        '
        Me.txtganacia.Location = New System.Drawing.Point(809, 488)
        Me.txtganacia.Name = "txtganacia"
        Me.txtganacia.Size = New System.Drawing.Size(88, 23)
        Me.txtganacia.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(773, 470)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 15)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Total Ganancia o perdida"
        '
        'btcalcular
        '
        Me.btcalcular.Location = New System.Drawing.Point(809, 525)
        Me.btcalcular.Name = "btcalcular"
        Me.btcalcular.Size = New System.Drawing.Size(86, 44)
        Me.btcalcular.TabIndex = 37
        Me.btcalcular.Text = "Calcular"
        Me.btcalcular.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(954, 525)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 44)
        Me.Button1.TabIndex = 38
        Me.Button1.UseVisualStyleBackColor = False
        '
        'estado_resultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1187, 562)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btcalcular)
        Me.Controls.Add(Me.txtganacia)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_costo_compra)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_totalventa)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btcargar_venta)
        Me.Controls.Add(Me.txtcod_venta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_total_gastos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btcargar_gastos)
        Me.Controls.Add(Me.txt_cod_gastos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtgrupo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "estado_resultados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "estado_resultados"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView_venta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView_animales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtgrupo As TextBox
    Friend WithEvents txt_cod_gastos As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btcargar_gastos As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView_venta As DataGridView
    Friend WithEvents txt_total_gastos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcod_venta As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btcargar_venta As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataGridView_animales As DataGridView
    Friend WithEvents txt_totalventa As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_costo_compra As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtganacia As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btcalcular As Button
    Friend WithEvents Button1 As Button
End Class
