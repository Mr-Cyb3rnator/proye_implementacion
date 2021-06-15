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
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.dgingredientes = New System.Windows.Forms.DataGridView()
        Me.txtcodingre = New System.Windows.Forms.TextBox()
        Me.txtcosto = New System.Windows.Forms.TextBox()
        Me.txtdescripingre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bteditar = New System.Windows.Forms.Button()
        Me.tt_Ingrediente = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtcoddieta = New System.Windows.Forms.TextBox()
        Me.ep_Ingredientes = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnatras = New System.Windows.Forms.Button()
        CType(Me.dgingredientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ep_Ingredientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btneliminar
        '
        Me.btneliminar.BackColor = System.Drawing.Color.BurlyWood
        Me.btneliminar.Enabled = False
        Me.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneliminar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btneliminar.Image = Global.proye.My.Resources.Resources.iconfinder_4781838_cancel_close_delete_exit_logout_icon_32px1
        Me.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btneliminar.Location = New System.Drawing.Point(328, 224)
        Me.btneliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(118, 49)
        Me.btneliminar.TabIndex = 20
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btneliminar.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.BurlyWood
        Me.btnguardar.Enabled = False
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnguardar.Image = Global.proye.My.Resources.Resources.iconfinder_1031520_arrow_download_save_guardar_icon_32px1
        Me.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnguardar.Location = New System.Drawing.Point(80, 224)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(118, 49)
        Me.btnguardar.TabIndex = 19
        Me.btnguardar.Text = "Agregar"
        Me.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'dgingredientes
        '
        Me.dgingredientes.AllowUserToAddRows = False
        Me.dgingredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgingredientes.Location = New System.Drawing.Point(376, 44)
        Me.dgingredientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgingredientes.MultiSelect = False
        Me.dgingredientes.Name = "dgingredientes"
        Me.dgingredientes.ReadOnly = True
        Me.dgingredientes.RowHeadersWidth = 51
        Me.dgingredientes.RowTemplate.Height = 28
        Me.dgingredientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgingredientes.Size = New System.Drawing.Size(433, 160)
        Me.dgingredientes.TabIndex = 18
        '
        'txtcodingre
        '
        Me.txtcodingre.Enabled = False
        Me.txtcodingre.Location = New System.Drawing.Point(186, 44)
        Me.txtcodingre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodingre.Name = "txtcodingre"
        Me.txtcodingre.Size = New System.Drawing.Size(107, 23)
        Me.txtcodingre.TabIndex = 17
        '
        'txtcosto
        '
        Me.txtcosto.Enabled = False
        Me.txtcosto.Location = New System.Drawing.Point(182, 166)
        Me.txtcosto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcosto.Name = "txtcosto"
        Me.txtcosto.Size = New System.Drawing.Size(111, 23)
        Me.txtcosto.TabIndex = 16
        '
        'txtdescripingre
        '
        Me.txtdescripingre.Location = New System.Drawing.Point(186, 83)
        Me.txtdescripingre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtdescripingre.Name = "txtdescripingre"
        Me.txtdescripingre.Size = New System.Drawing.Size(107, 23)
        Me.txtdescripingre.TabIndex = 15
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
        'bteditar
        '
        Me.bteditar.BackColor = System.Drawing.Color.BurlyWood
        Me.bteditar.Enabled = False
        Me.bteditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bteditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bteditar.Image = Global.proye.My.Resources.Resources.iconfinder_185042_edit_modify_icon_32px1
        Me.bteditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bteditar.Location = New System.Drawing.Point(204, 224)
        Me.bteditar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bteditar.Name = "bteditar"
        Me.bteditar.Size = New System.Drawing.Size(118, 49)
        Me.bteditar.TabIndex = 27
        Me.bteditar.Text = "Editar"
        Me.bteditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bteditar.UseVisualStyleBackColor = False
        '
        'tt_Ingrediente
        '
        Me.tt_Ingrediente.IsBalloon = True
        Me.tt_Ingrediente.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.tt_Ingrediente.ToolTipTitle = "Tipo Datos"
        '
        'txtcoddieta
        '
        Me.txtcoddieta.Enabled = False
        Me.txtcoddieta.Location = New System.Drawing.Point(186, 125)
        Me.txtcoddieta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcoddieta.Name = "txtcoddieta"
        Me.txtcoddieta.Size = New System.Drawing.Size(107, 23)
        Me.txtcoddieta.TabIndex = 22
        '
        'ep_Ingredientes
        '
        Me.ep_Ingredientes.ContainerControl = Me
        '
        'btnatras
        '
        Me.btnatras.BackgroundImage = Global.proye.My.Resources.Resources.icons8_flecha_responder_a_todos_48
        Me.btnatras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnatras.Location = New System.Drawing.Point(572, 224)
        Me.btnatras.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(82, 47)
        Me.btnatras.TabIndex = 28
        Me.btnatras.UseVisualStyleBackColor = True
        '
        'Ingredientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(844, 309)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.bteditar)
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
        CType(Me.ep_Ingredientes, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label4 As Label
    Friend WithEvents bteditar As Button
    Friend WithEvents tt_Ingrediente As ToolTip
    Friend WithEvents txtcoddieta As TextBox
    Friend WithEvents ep_Ingredientes As ErrorProvider
    Friend WithEvents btnatras As Button
End Class
