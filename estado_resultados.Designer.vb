﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btcargar_gastos = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txt_total_gastos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_costo_compra = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView_venta = New System.Windows.Forms.DataGridView()
        Me.txt_totalventa = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView_animales = New System.Windows.Forms.DataGridView()
        Me.txtganacia = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btcalcular = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnatras = New System.Windows.Forms.Button()
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
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(66, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código del grupo:"
        '
        'txtgrupo
        '
        Me.txtgrupo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtgrupo.Location = New System.Drawing.Point(234, 72)
        Me.txtgrupo.Name = "txtgrupo"
        Me.txtgrupo.Size = New System.Drawing.Size(88, 27)
        Me.txtgrupo.TabIndex = 1
        '
        'btcargar_gastos
        '
        Me.btcargar_gastos.BackColor = System.Drawing.Color.BurlyWood
        Me.btcargar_gastos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btcargar_gastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btcargar_gastos.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btcargar_gastos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btcargar_gastos.Location = New System.Drawing.Point(349, 43)
        Me.btcargar_gastos.Name = "btcargar_gastos"
        Me.btcargar_gastos.Size = New System.Drawing.Size(102, 60)
        Me.btcargar_gastos.TabIndex = 4
        Me.btcargar_gastos.Text = "Cargar Gastos"
        Me.btcargar_gastos.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.txt_total_gastos)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(711, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(475, 373)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gastos"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.Location = New System.Drawing.Point(13, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(449, 217)
        Me.DataGridView1.TabIndex = 0
        '
        'txt_total_gastos
        '
        Me.txt_total_gastos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_total_gastos.Enabled = False
        Me.txt_total_gastos.Location = New System.Drawing.Point(268, 287)
        Me.txt_total_gastos.Name = "txt_total_gastos"
        Me.txt_total_gastos.Size = New System.Drawing.Size(87, 20)
        Me.txt_total_gastos.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(150, 289)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Total gastos:"
        '
        'txt_costo_compra
        '
        Me.txt_costo_compra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_costo_compra.Enabled = False
        Me.txt_costo_compra.Location = New System.Drawing.Point(587, 114)
        Me.txt_costo_compra.Name = "txt_costo_compra"
        Me.txt_costo_compra.Size = New System.Drawing.Size(87, 20)
        Me.txt_costo_compra.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(377, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(191, 21)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Total costo de compra:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView_venta)
        Me.GroupBox2.Controls.Add(Me.txt_totalventa)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 346)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(683, 250)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Venta"
        '
        'DataGridView_venta
        '
        Me.DataGridView_venta.AllowUserToResizeColumns = False
        Me.DataGridView_venta.AllowUserToResizeRows = False
        Me.DataGridView_venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_venta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView_venta.Location = New System.Drawing.Point(13, 24)
        Me.DataGridView_venta.Name = "DataGridView_venta"
        Me.DataGridView_venta.ReadOnly = True
        Me.DataGridView_venta.RowHeadersWidth = 51
        Me.DataGridView_venta.RowTemplate.Height = 24
        Me.DataGridView_venta.Size = New System.Drawing.Size(352, 209)
        Me.DataGridView_venta.TabIndex = 7
        '
        'txt_totalventa
        '
        Me.txt_totalventa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_totalventa.Enabled = False
        Me.txt_totalventa.Location = New System.Drawing.Point(587, 113)
        Me.txt_totalventa.Name = "txt_totalventa"
        Me.txt_totalventa.Size = New System.Drawing.Size(87, 20)
        Me.txt_totalventa.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(473, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 21)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Total venta:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView_animales)
        Me.GroupBox3.Controls.Add(Me.txt_costo_compra)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox3.Location = New System.Drawing.Point(22, 98)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(683, 242)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Grupo"
        '
        'DataGridView_animales
        '
        Me.DataGridView_animales.AllowUserToResizeColumns = False
        Me.DataGridView_animales.AllowUserToResizeRows = False
        Me.DataGridView_animales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_animales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView_animales.Location = New System.Drawing.Point(13, 20)
        Me.DataGridView_animales.Name = "DataGridView_animales"
        Me.DataGridView_animales.ReadOnly = True
        Me.DataGridView_animales.RowHeadersWidth = 51
        Me.DataGridView_animales.RowTemplate.Height = 24
        Me.DataGridView_animales.Size = New System.Drawing.Size(352, 208)
        Me.DataGridView_animales.TabIndex = 7
        '
        'txtganacia
        '
        Me.txtganacia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtganacia.Enabled = False
        Me.txtganacia.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtganacia.Location = New System.Drawing.Point(979, 489)
        Me.txtganacia.Name = "txtganacia"
        Me.txtganacia.Size = New System.Drawing.Size(87, 20)
        Me.txtganacia.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(748, 489)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(214, 21)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Total ganancia o perdida:"
        '
        'btcalcular
        '
        Me.btcalcular.BackColor = System.Drawing.Color.BurlyWood
        Me.btcalcular.Enabled = False
        Me.btcalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btcalcular.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btcalcular.Location = New System.Drawing.Point(862, 536)
        Me.btcalcular.Name = "btcalcular"
        Me.btcalcular.Size = New System.Drawing.Size(102, 44)
        Me.btcalcular.TabIndex = 37
        Me.btcalcular.Text = "Calcular"
        Me.btcalcular.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(427, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Estado de Resultado"
        '
        'btnatras
        '
        Me.btnatras.BackColor = System.Drawing.Color.BurlyWood
        Me.btnatras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnatras.Image = Global.proye.My.Resources.Resources.atras__2_
        Me.btnatras.Location = New System.Drawing.Point(1096, 536)
        Me.btnatras.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(90, 51)
        Me.btnatras.TabIndex = 38
        Me.btnatras.UseVisualStyleBackColor = False
        '
        'estado_resultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1210, 618)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.txtgrupo)
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
        Me.Name = "estado_resultados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balance"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView_venta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView_animales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtgrupo As TextBox
    Friend WithEvents btcargar_gastos As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView_venta As DataGridView
    Friend WithEvents txt_total_gastos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataGridView_animales As DataGridView
    Friend WithEvents txt_totalventa As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_costo_compra As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtganacia As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btcalcular As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnatras As Button
End Class
