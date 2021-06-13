<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dieta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dieta))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.txtcomidaxdia = New System.Windows.Forms.TextBox()
        Me.txtcoddieta = New System.Windows.Forms.TextBox()
        Me.dgdieta = New System.Windows.Forms.DataGridView()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnatras = New System.Windows.Forms.Button()
        Me.btagregar = New System.Windows.Forms.Button()
        Me.dgingredientes_dieta = New System.Windows.Forms.DataGridView()
        Me.btselecionar_dierta = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblcodingre = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbcodingre = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.dgdieta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgingredientes_dieta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(59, 97)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código Dieta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(1, 145)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cantidad en libras:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(21, 199)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(219, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Comidas por dia:"
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(267, 147)
        Me.txtcantidad.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(110, 37)
        Me.txtcantidad.TabIndex = 3
        '
        'txtcomidaxdia
        '
        Me.txtcomidaxdia.Location = New System.Drawing.Point(267, 201)
        Me.txtcomidaxdia.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtcomidaxdia.Name = "txtcomidaxdia"
        Me.txtcomidaxdia.Size = New System.Drawing.Size(110, 37)
        Me.txtcomidaxdia.TabIndex = 4
        '
        'txtcoddieta
        '
        Me.txtcoddieta.Location = New System.Drawing.Point(267, 96)
        Me.txtcoddieta.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtcoddieta.Name = "txtcoddieta"
        Me.txtcoddieta.Size = New System.Drawing.Size(110, 37)
        Me.txtcoddieta.TabIndex = 5
        '
        'dgdieta
        '
        Me.dgdieta.AllowUserToDeleteRows = False
        Me.dgdieta.AllowUserToResizeColumns = False
        Me.dgdieta.AllowUserToResizeRows = False
        Me.dgdieta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdieta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgdieta.EnableHeadersVisualStyles = False
        Me.dgdieta.Location = New System.Drawing.Point(396, 47)
        Me.dgdieta.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgdieta.Name = "dgdieta"
        Me.dgdieta.ReadOnly = True
        Me.dgdieta.RowHeadersVisible = False
        Me.dgdieta.RowHeadersWidth = 51
        Me.dgdieta.RowTemplate.Height = 28
        Me.dgdieta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgdieta.Size = New System.Drawing.Size(469, 442)
        Me.dgdieta.TabIndex = 9
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.BurlyWood
        Me.btnguardar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnguardar.Location = New System.Drawing.Point(7, 348)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(139, 50)
        Me.btnguardar.TabIndex = 10
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btneliminar
        '
        Me.btneliminar.BackColor = System.Drawing.Color.BurlyWood
        Me.btneliminar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btneliminar.Location = New System.Drawing.Point(246, 348)
        Me.btneliminar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(139, 50)
        Me.btneliminar.TabIndex = 11
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(44, 309)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(254, 30)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Código Ingrediente:"
        '
        'btnatras
        '
        Me.btnatras.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnatras.Image = CType(resources.GetObject("btnatras.Image"), System.Drawing.Image)
        Me.btnatras.Location = New System.Drawing.Point(1301, 621)
        Me.btnatras.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(111, 59)
        Me.btnatras.TabIndex = 26
        Me.btnatras.UseVisualStyleBackColor = False
        '
        'btagregar
        '
        Me.btagregar.BackColor = System.Drawing.Color.BurlyWood
        Me.btagregar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btagregar.Location = New System.Drawing.Point(44, 423)
        Me.btagregar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btagregar.Name = "btagregar"
        Me.btagregar.Size = New System.Drawing.Size(378, 50)
        Me.btagregar.TabIndex = 27
        Me.btagregar.Text = "Agregar Ingrediente a dieta"
        Me.btagregar.UseVisualStyleBackColor = False
        '
        'dgingredientes_dieta
        '
        Me.dgingredientes_dieta.AllowUserToDeleteRows = False
        Me.dgingredientes_dieta.AllowUserToResizeColumns = False
        Me.dgingredientes_dieta.AllowUserToResizeRows = False
        Me.dgingredientes_dieta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgingredientes_dieta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgingredientes_dieta.EnableHeadersVisualStyles = False
        Me.dgingredientes_dieta.Location = New System.Drawing.Point(85, 47)
        Me.dgingredientes_dieta.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgingredientes_dieta.Name = "dgingredientes_dieta"
        Me.dgingredientes_dieta.ReadOnly = True
        Me.dgingredientes_dieta.RowHeadersWidth = 51
        Me.dgingredientes_dieta.RowTemplate.Height = 29
        Me.dgingredientes_dieta.Size = New System.Drawing.Size(367, 230)
        Me.dgingredientes_dieta.TabIndex = 28
        '
        'btselecionar_dierta
        '
        Me.btselecionar_dierta.BackColor = System.Drawing.Color.BurlyWood
        Me.btselecionar_dierta.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btselecionar_dierta.Location = New System.Drawing.Point(7, 266)
        Me.btselecionar_dierta.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btselecionar_dierta.Name = "btselecionar_dierta"
        Me.btselecionar_dierta.Size = New System.Drawing.Size(378, 50)
        Me.btselecionar_dierta.TabIndex = 29
        Me.btselecionar_dierta.Text = "Seleccionar codigo dieta"
        Me.btselecionar_dierta.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(669, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 39)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Dietas "
        '
        'lblcodingre
        '
        Me.lblcodingre.AutoSize = True
        Me.lblcodingre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblcodingre.Location = New System.Drawing.Point(44, 364)
        Me.lblcodingre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcodingre.Name = "lblcodingre"
        Me.lblcodingre.Size = New System.Drawing.Size(36, 30)
        Me.lblcodingre.TabIndex = 32
        Me.lblcodingre.Text = "- -"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbcodingre)
        Me.GroupBox1.Controls.Add(Me.dgingredientes_dieta)
        Me.GroupBox1.Controls.Add(Me.lblcodingre)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btagregar)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(919, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(525, 525)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingredientes en la dieta"
        '
        'cmbcodingre
        '
        Me.cmbcodingre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcodingre.FormattingEnabled = True
        Me.cmbcodingre.Location = New System.Drawing.Point(305, 306)
        Me.cmbcodingre.Name = "cmbcodingre"
        Me.cmbcodingre.Size = New System.Drawing.Size(164, 38)
        Me.cmbcodingre.TabIndex = 35
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgdieta)
        Me.GroupBox2.Controls.Add(Me.txtcomidaxdia)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btselecionar_dierta)
        Me.GroupBox2.Controls.Add(Me.btneliminar)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnguardar)
        Me.GroupBox2.Controls.Add(Me.txtcantidad)
        Me.GroupBox2.Controls.Add(Me.txtcoddieta)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(890, 525)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dietas establecidas"
        '
        'Dieta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1442, 719)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnatras)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Dieta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dieta"
        CType(Me.dgdieta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgingredientes_dieta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents txtcomidaxdia As TextBox
    Friend WithEvents txtcoddieta As TextBox
    Friend WithEvents btnguardar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnatras As Button
    Friend WithEvents btagregar As Button
    Friend WithEvents dgingredientes_dieta As DataGridView
    Friend WithEvents btselecionar_dierta As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lblcodingre As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbcodingre As ComboBox
    Friend WithEvents dgdieta As DataGridView
End Class
