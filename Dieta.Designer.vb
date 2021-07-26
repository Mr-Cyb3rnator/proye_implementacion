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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtComidaXDia = New System.Windows.Forms.TextBox()
        Me.txtCodDieta = New System.Windows.Forms.TextBox()
        Me.dgvDieta = New System.Windows.Forms.DataGridView()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvIngredientesDieta = New System.Windows.Forms.DataGridView()
        Me.btnCargarIngredientes = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCodIngre = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_ingrediente = New System.Windows.Forms.Label()
        Me.cmbCodIngre = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvDieta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvIngredientesDieta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(98, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código dieta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 88)
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
        Me.Label3.Location = New System.Drawing.Point(32, 142)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(219, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Comidas por dia:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(279, 91)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txtCantidad.MaxLength = 3
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(110, 37)
        Me.txtCantidad.TabIndex = 3
        '
        'txtComidaXDia
        '
        Me.txtComidaXDia.Location = New System.Drawing.Point(279, 144)
        Me.txtComidaXDia.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txtComidaXDia.MaxLength = 1
        Me.txtComidaXDia.Name = "txtComidaXDia"
        Me.txtComidaXDia.Size = New System.Drawing.Size(110, 37)
        Me.txtComidaXDia.TabIndex = 4
        '
        'txtCodDieta
        '
        Me.txtCodDieta.Enabled = False
        Me.txtCodDieta.Location = New System.Drawing.Point(285, 49)
        Me.txtCodDieta.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txtCodDieta.Name = "txtCodDieta"
        Me.txtCodDieta.Size = New System.Drawing.Size(110, 31)
        Me.txtCodDieta.TabIndex = 5
        '
        'dgvDieta
        '
        Me.dgvDieta.AllowUserToDeleteRows = False
        Me.dgvDieta.AllowUserToResizeColumns = False
        Me.dgvDieta.AllowUserToResizeRows = False
        Me.dgvDieta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDieta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvDieta.EnableHeadersVisualStyles = False
        Me.dgvDieta.Location = New System.Drawing.Point(445, 190)
        Me.dgvDieta.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.dgvDieta.Name = "dgvDieta"
        Me.dgvDieta.ReadOnly = True
        Me.dgvDieta.RowHeadersVisible = False
        Me.dgvDieta.RowHeadersWidth = 51
        Me.dgvDieta.RowTemplate.Height = 28
        Me.dgvDieta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDieta.Size = New System.Drawing.Size(469, 362)
        Me.dgvDieta.TabIndex = 9
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.BurlyWood
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnGuardar.Location = New System.Drawing.Point(95, 205)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(194, 75)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.BurlyWood
        Me.btnEliminar.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEliminar.Location = New System.Drawing.Point(98, 299)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(191, 75)
        Me.btnEliminar.TabIndex = 11
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(46, 304)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(254, 30)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Código Ingrediente:"
        '
        'btnAtras
        '
        Me.btnAtras.BackColor = System.Drawing.Color.BurlyWood
        Me.btnAtras.Image = Global.proye.My.Resources.Resources.atras__2_
        Me.btnAtras.Location = New System.Drawing.Point(1293, 568)
        Me.btnAtras.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(136, 85)
        Me.btnAtras.TabIndex = 26
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.BurlyWood
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAgregar.Location = New System.Drawing.Point(44, 422)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(378, 50)
        Me.btnAgregar.TabIndex = 27
        Me.btnAgregar.Text = "Agregar Ingrediente a dieta"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'dgvIngredientesDieta
        '
        Me.dgvIngredientesDieta.AllowUserToDeleteRows = False
        Me.dgvIngredientesDieta.AllowUserToResizeColumns = False
        Me.dgvIngredientesDieta.AllowUserToResizeRows = False
        Me.dgvIngredientesDieta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIngredientesDieta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvIngredientesDieta.EnableHeadersVisualStyles = False
        Me.dgvIngredientesDieta.Location = New System.Drawing.Point(46, 61)
        Me.dgvIngredientesDieta.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.dgvIngredientesDieta.Name = "dgvIngredientesDieta"
        Me.dgvIngredientesDieta.ReadOnly = True
        Me.dgvIngredientesDieta.RowHeadersWidth = 51
        Me.dgvIngredientesDieta.RowTemplate.Height = 29
        Me.dgvIngredientesDieta.Size = New System.Drawing.Size(434, 230)
        Me.dgvIngredientesDieta.TabIndex = 28
        '
        'btnCargarIngredientes
        '
        Me.btnCargarIngredientes.BackColor = System.Drawing.Color.BurlyWood
        Me.btnCargarIngredientes.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCargarIngredientes.Location = New System.Drawing.Point(410, 39)
        Me.btnCargarIngredientes.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnCargarIngredientes.Name = "btnCargarIngredientes"
        Me.btnCargarIngredientes.Size = New System.Drawing.Size(378, 50)
        Me.btnCargarIngredientes.TabIndex = 29
        Me.btnCargarIngredientes.Text = "Cargar ingredientes"
        Me.btnCargarIngredientes.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(672, 11)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 39)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Dietas "
        '
        'lblCodIngre
        '
        Me.lblCodIngre.AutoSize = True
        Me.lblCodIngre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCodIngre.Location = New System.Drawing.Point(327, 304)
        Me.lblCodIngre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodIngre.Name = "lblCodIngre"
        Me.lblCodIngre.Size = New System.Drawing.Size(36, 30)
        Me.lblCodIngre.TabIndex = 32
        Me.lblCodIngre.Text = "- -"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_ingrediente)
        Me.GroupBox1.Controls.Add(Me.cmbCodIngre)
        Me.GroupBox1.Controls.Add(Me.dgvIngredientesDieta)
        Me.GroupBox1.Controls.Add(Me.lblCodIngre)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(919, 67)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(512, 497)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingredientes en la dieta"
        '
        'lbl_ingrediente
        '
        Me.lbl_ingrediente.AutoSize = True
        Me.lbl_ingrediente.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_ingrediente.Location = New System.Drawing.Point(44, 361)
        Me.lbl_ingrediente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_ingrediente.Name = "lbl_ingrediente"
        Me.lbl_ingrediente.Size = New System.Drawing.Size(157, 30)
        Me.lbl_ingrediente.TabIndex = 36
        Me.lbl_ingrediente.Text = "Ingrediente:"
        '
        'cmbCodIngre
        '
        Me.cmbCodIngre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCodIngre.FormattingEnabled = True
        Me.cmbCodIngre.Location = New System.Drawing.Point(258, 358)
        Me.cmbCodIngre.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbCodIngre.Name = "cmbCodIngre"
        Me.cmbCodIngre.Size = New System.Drawing.Size(164, 38)
        Me.cmbCodIngre.TabIndex = 35
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtComidaXDia)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnGuardar)
        Me.GroupBox2.Controls.Add(Me.txtCantidad)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 178)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(415, 386)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Crear dieta"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnCargarIngredientes)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtCodDieta)
        Me.GroupBox3.Location = New System.Drawing.Point(24, 67)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(890, 106)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        '
        'Dieta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1442, 664)
        Me.Controls.Add(Me.dgvDieta)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnAtras)
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Name = "Dieta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dieta"
        CType(Me.dgvDieta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvIngredientesDieta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtComidaXDia As TextBox
    Friend WithEvents txtCodDieta As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents dgvIngredientesDieta As DataGridView
    Friend WithEvents btnCargarIngredientes As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lblCodIngre As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbCodIngre As ComboBox
    Friend WithEvents dgvDieta As DataGridView
    Friend WithEvents lbl_ingrediente As Label
    Friend WithEvents GroupBox3 As GroupBox
End Class
