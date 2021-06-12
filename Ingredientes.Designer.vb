<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingredientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingredientes))
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.dgingredientes = New System.Windows.Forms.DataGridView()
        Me.txtcodingre = New System.Windows.Forms.TextBox()
        Me.txtcosto = New System.Windows.Forms.TextBox()
        Me.txtdescripingre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcoddieta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnatras = New System.Windows.Forms.Button()
        Me.bteditar = New System.Windows.Forms.Button()
        CType(Me.dgingredientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(138, 176)
        Me.btneliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(70, 30)
        Me.btneliminar.TabIndex = 20
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(35, 176)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(80, 30)
        Me.btnguardar.TabIndex = 19
        Me.btnguardar.Text = "Guardaaar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'dgingredientes
        '
        Me.dgingredientes.AllowUserToAddRows = False
        Me.dgingredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgingredientes.Location = New System.Drawing.Point(227, 46)
        Me.dgingredientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgingredientes.Name = "dgingredientes"
        Me.dgingredientes.RowHeadersWidth = 51
        Me.dgingredientes.RowTemplate.Height = 28
        Me.dgingredientes.Size = New System.Drawing.Size(508, 160)
        Me.dgingredientes.TabIndex = 18
        '
        'txtcodingre
        '
        Me.txtcodingre.Location = New System.Drawing.Point(138, 46)
        Me.txtcodingre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodingre.Name = "txtcodingre"
        Me.txtcodingre.Size = New System.Drawing.Size(78, 23)
        Me.txtcodingre.TabIndex = 17
        '
        'txtcosto
        '
        Me.txtcosto.Location = New System.Drawing.Point(138, 143)
        Me.txtcosto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcosto.Name = "txtcosto"
        Me.txtcosto.Size = New System.Drawing.Size(78, 23)
        Me.txtcosto.TabIndex = 16
        '
        'txtdescripingre
        '
        Me.txtdescripingre.Location = New System.Drawing.Point(138, 79)
        Me.txtdescripingre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtdescripingre.Name = "txtdescripingre"
        Me.txtdescripingre.Size = New System.Drawing.Size(78, 23)
        Me.txtdescripingre.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Costo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Descripcion:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Codigo Ingrediente:"
        '
        'txtcoddieta
        '
        Me.txtcoddieta.Location = New System.Drawing.Point(138, 111)
        Me.txtcoddieta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcoddieta.Name = "txtcoddieta"
        Me.txtcoddieta.Size = New System.Drawing.Size(78, 23)
        Me.txtcoddieta.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 15)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Codigo Dieta:"
        '
        'btnatras
        '
        Me.btnatras.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnatras.Image = CType(resources.GetObject("btnatras.Image"), System.Drawing.Image)
        Me.btnatras.Location = New System.Drawing.Point(662, 223)
        Me.btnatras.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(94, 33)
        Me.btnatras.TabIndex = 26
        Me.btnatras.UseVisualStyleBackColor = False
        '
        'bteditar
        '
        Me.bteditar.Location = New System.Drawing.Point(35, 210)
        Me.bteditar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bteditar.Name = "bteditar"
        Me.bteditar.Size = New System.Drawing.Size(80, 30)
        Me.bteditar.TabIndex = 27
        Me.bteditar.Text = "Editar"
        Me.bteditar.UseVisualStyleBackColor = True
        '
        'Ingredientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(766, 265)
        Me.Controls.Add(Me.bteditar)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.txtcoddieta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.dgingredientes)
        Me.Controls.Add(Me.txtcodingre)
        Me.Controls.Add(Me.txtcosto)
        Me.Controls.Add(Me.txtdescripingre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Ingredientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingredientes"
        CType(Me.dgingredientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btneliminar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents dgingredientes As DataGridView
    Friend WithEvents txtcodingre As TextBox
    Friend WithEvents txtcosto As TextBox
    Friend WithEvents txtdescripingre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcoddieta As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnatras As Button
    Friend WithEvents bteditar As Button
End Class
