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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcodventa = New System.Windows.Forms.TextBox()
        Me.txtcodcliente = New System.Windows.Forms.TextBox()
        Me.txtlibras_totales = New System.Windows.Forms.TextBox()
        Me.txtcodgrupo = New System.Windows.Forms.TextBox()
        Me.txt_preciolibra = New System.Windows.Forms.TextBox()
        Me.dgventaganado = New System.Windows.Forms.DataGridView()
        Me.btcargar_grupo = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.btnatras = New System.Windows.Forms.Button()
        Me.txttotalventa = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dgventaganado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo Venta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Libras del Grupo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Precio Por Libra:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Codigo Cliente: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Codigo Grupo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fecha:"
        '
        'txtcodventa
        '
        Me.txtcodventa.Location = New System.Drawing.Point(160, 61)
        Me.txtcodventa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodventa.Name = "txtcodventa"
        Me.txtcodventa.Size = New System.Drawing.Size(78, 23)
        Me.txtcodventa.TabIndex = 6
        '
        'txtcodcliente
        '
        Me.txtcodcliente.Location = New System.Drawing.Point(160, 101)
        Me.txtcodcliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodcliente.Name = "txtcodcliente"
        Me.txtcodcliente.Size = New System.Drawing.Size(78, 23)
        Me.txtcodcliente.TabIndex = 7
        '
        'txtlibras_totales
        '
        Me.txtlibras_totales.Location = New System.Drawing.Point(163, 163)
        Me.txtlibras_totales.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtlibras_totales.Name = "txtlibras_totales"
        Me.txtlibras_totales.Size = New System.Drawing.Size(78, 23)
        Me.txtlibras_totales.TabIndex = 8
        '
        'txtcodgrupo
        '
        Me.txtcodgrupo.Location = New System.Drawing.Point(160, 136)
        Me.txtcodgrupo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodgrupo.Name = "txtcodgrupo"
        Me.txtcodgrupo.Size = New System.Drawing.Size(78, 23)
        Me.txtcodgrupo.TabIndex = 9
        '
        'txt_preciolibra
        '
        Me.txt_preciolibra.Location = New System.Drawing.Point(163, 195)
        Me.txt_preciolibra.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_preciolibra.Name = "txt_preciolibra"
        Me.txt_preciolibra.Size = New System.Drawing.Size(78, 23)
        Me.txt_preciolibra.TabIndex = 10
        '
        'dgventaganado
        '
        Me.dgventaganado.AllowUserToAddRows = False
        Me.dgventaganado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgventaganado.Location = New System.Drawing.Point(265, 63)
        Me.dgventaganado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgventaganado.Name = "dgventaganado"
        Me.dgventaganado.RowHeadersWidth = 51
        Me.dgventaganado.RowTemplate.Height = 28
        Me.dgventaganado.Size = New System.Drawing.Size(703, 135)
        Me.dgventaganado.TabIndex = 19
        '
        'btcargar_grupo
        '
        Me.btcargar_grupo.Location = New System.Drawing.Point(480, 226)
        Me.btcargar_grupo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btcargar_grupo.Name = "btcargar_grupo"
        Me.btcargar_grupo.Size = New System.Drawing.Size(94, 46)
        Me.btcargar_grupo.TabIndex = 22
        Me.btcargar_grupo.Text = "Cagar Grupo"
        Me.btcargar_grupo.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(328, 224)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(97, 46)
        Me.btnguardar.TabIndex = 21
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'dtpfecha
        '
        Me.dtpfecha.Location = New System.Drawing.Point(109, 251)
        Me.dtpfecha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(156, 23)
        Me.dtpfecha.TabIndex = 24
        '
        'btnatras
        '
        Me.btnatras.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnatras.Image = CType(resources.GetObject("btnatras.Image"), System.Drawing.Image)
        Me.btnatras.Location = New System.Drawing.Point(878, 274)
        Me.btnatras.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(89, 40)
        Me.btnatras.TabIndex = 25
        Me.btnatras.UseVisualStyleBackColor = False
        '
        'txttotalventa
        '
        Me.txttotalventa.Location = New System.Drawing.Point(163, 224)
        Me.txttotalventa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txttotalventa.Name = "txttotalventa"
        Me.txttotalventa.Size = New System.Drawing.Size(78, 23)
        Me.txttotalventa.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 224)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 15)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Total venta"
        '
        'VentaGanado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(978, 322)
        Me.Controls.Add(Me.txttotalventa)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.dtpfecha)
        Me.Controls.Add(Me.btcargar_grupo)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.dgventaganado)
        Me.Controls.Add(Me.txt_preciolibra)
        Me.Controls.Add(Me.txtcodgrupo)
        Me.Controls.Add(Me.txtlibras_totales)
        Me.Controls.Add(Me.txtcodcliente)
        Me.Controls.Add(Me.txtcodventa)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "VentaGanado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VentaGanado"
        CType(Me.dgventaganado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcodventa As TextBox
    Friend WithEvents txtcodcliente As TextBox
    Friend WithEvents txtlibras_totales As TextBox
    Friend WithEvents txtcodgrupo As TextBox
    Friend WithEvents txt_preciolibra As TextBox
    Friend WithEvents dgventaganado As DataGridView
    Friend WithEvents btcargar_grupo As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents btnatras As Button
    Friend WithEvents txttotalventa As TextBox
    Friend WithEvents Label8 As Label
End Class
