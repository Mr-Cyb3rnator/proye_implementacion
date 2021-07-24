<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ingredientes
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingredientes))
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dvgIngredientes = New System.Windows.Forms.DataGridView()
        Me.txtCodIngredientes = New System.Windows.Forms.TextBox()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.tt_Ingrediente = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtCodDieta = New System.Windows.Forms.TextBox()
        Me.ep_Ingredientes = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnAtras = New System.Windows.Forms.Button()
        CType(Me.dvgIngredientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ep_Ingredientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.BurlyWood
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEliminar.Image = Global.proye.My.Resources.Resources.iconfinder_4781838_cancel_close_delete_exit_logout_icon_32px1
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(328, 224)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(118, 49)
        Me.btnEliminar.TabIndex = 20
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.BurlyWood
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAgregar.Image = Global.proye.My.Resources.Resources.iconfinder_1031520_arrow_download_save_guardar_icon_32px1
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(80, 224)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(118, 49)
        Me.btnAgregar.TabIndex = 19
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'dvgIngredientes
        '
        Me.dvgIngredientes.AllowUserToAddRows = False
        Me.dvgIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgIngredientes.Location = New System.Drawing.Point(376, 44)
        Me.dvgIngredientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dvgIngredientes.MultiSelect = False
        Me.dvgIngredientes.Name = "dvgIngredientes"
        Me.dvgIngredientes.ReadOnly = True
        Me.dvgIngredientes.RowHeadersWidth = 51
        Me.dvgIngredientes.RowTemplate.Height = 28
        Me.dvgIngredientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvgIngredientes.Size = New System.Drawing.Size(433, 160)
        Me.dvgIngredientes.TabIndex = 18
        '
        'txtCodIngredientes
        '
        Me.txtCodIngredientes.Enabled = False
        Me.txtCodIngredientes.Location = New System.Drawing.Point(186, 44)
        Me.txtCodIngredientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCodIngredientes.Name = "txtCodIngredientes"
        Me.txtCodIngredientes.Size = New System.Drawing.Size(107, 23)
        Me.txtCodIngredientes.TabIndex = 17
        '
        'txtCosto
        '
        Me.txtCosto.Enabled = False
        Me.txtCosto.Location = New System.Drawing.Point(182, 166)
        Me.txtCosto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(111, 23)
        Me.txtCosto.TabIndex = 16
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(186, 83)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(107, 23)
        Me.txtDescripcion.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(12, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 21)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Costo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 21)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 21)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Código Ingrediente:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(12, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 21)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Código Dieta:"
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.BurlyWood
        Me.btnEditar.Enabled = False
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEditar.Image = Global.proye.My.Resources.Resources.iconfinder_185042_edit_modify_icon_32px1
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(204, 224)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(118, 49)
        Me.btnEditar.TabIndex = 27
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'tt_Ingrediente
        '
        Me.tt_Ingrediente.IsBalloon = True
        Me.tt_Ingrediente.ShowAlways = True
        Me.tt_Ingrediente.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.tt_Ingrediente.ToolTipTitle = "Tipo Datos"
        '
        'txtCodDieta
        '
        Me.txtCodDieta.Enabled = False
        Me.txtCodDieta.Location = New System.Drawing.Point(186, 125)
        Me.txtCodDieta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCodDieta.Name = "txtCodDieta"
        Me.txtCodDieta.Size = New System.Drawing.Size(107, 23)
        Me.txtCodDieta.TabIndex = 22
        '
        'ep_Ingredientes
        '
        Me.ep_Ingredientes.ContainerControl = Me
        '
        'btnAtras
        '
        Me.btnAtras.BackgroundImage = Global.proye.My.Resources.Resources.icons8_flecha_responder_a_todos_48
        Me.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAtras.Location = New System.Drawing.Point(572, 224)
        Me.btnAtras.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(82, 47)
        Me.btnAtras.TabIndex = 28
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'Ingredientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(844, 309)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.txtCodDieta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dvgIngredientes)
        Me.Controls.Add(Me.txtCodIngredientes)
        Me.Controls.Add(Me.txtCosto)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Ingredientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingredientes"
        CType(Me.dvgIngredientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ep_Ingredientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents dvgIngredientes As DataGridView
    Friend WithEvents txtCodIngredientes As TextBox
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnEditar As Button
    Friend WithEvents tt_Ingrediente As ToolTip
    Friend WithEvents txtCodDieta As TextBox
    Friend WithEvents ep_Ingredientes As ErrorProvider
    Friend WithEvents btnAtras As Button
End Class
