<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigoCliente = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dvgClientes = New System.Windows.Forms.DataGridView()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.tt_cliente = New System.Windows.Forms.ToolTip(Me.components)
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        CType(Me.dvgClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(31, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código cliente"
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.Enabled = False
        Me.txtCodigoCliente.Location = New System.Drawing.Point(164, 29)
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.Size = New System.Drawing.Size(113, 23)
        Me.txtCodigoCliente.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(164, 64)
        Me.txtNombre.MaxLength = 25
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(113, 23)
        Me.txtNombre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(31, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(164, 176)
        Me.txtDireccion.MaxLength = 50
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(113, 23)
        Me.txtDireccion.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(31, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Dirección"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(164, 207)
        Me.txtTelefono.MaxLength = 8
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(113, 23)
        Me.txtTelefono.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(30, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Teléfono"
        '
        'dvgClientes
        '
        Me.dvgClientes.AllowUserToAddRows = False
        Me.dvgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgClientes.Location = New System.Drawing.Point(359, 39)
        Me.dvgClientes.MultiSelect = False
        Me.dvgClientes.Name = "dvgClientes"
        Me.dvgClientes.ReadOnly = True
        Me.dvgClientes.RowHeadersWidth = 51
        Me.dvgClientes.RowTemplate.Height = 24
        Me.dvgClientes.Size = New System.Drawing.Size(474, 231)
        Me.dvgClientes.TabIndex = 8
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.BurlyWood
        Me.btnEliminar.BackgroundImage = Global.proye.My.Resources.Resources.iconfinder_4781838_cancel_close_delete_exit_logout_icon_32px2
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEliminar.Location = New System.Drawing.Point(241, 263)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(99, 36)
        Me.btnEliminar.TabIndex = 28
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.BurlyWood
        Me.btnAgregar.BackgroundImage = Global.proye.My.Resources.Resources.agregar
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.Location = New System.Drawing.Point(31, 263)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(99, 36)
        Me.btnAgregar.TabIndex = 27
        Me.btnAgregar.Text = "Agregar "
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnAtras
        '
        Me.btnAtras.BackColor = System.Drawing.Color.BurlyWood
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.Image = Global.proye.My.Resources.Resources.atras__2_
        Me.btnAtras.Location = New System.Drawing.Point(743, 275)
        Me.btnAtras.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(90, 51)
        Me.btnAtras.TabIndex = 29
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.BurlyWood
        Me.btnEditar.BackgroundImage = Global.proye.My.Resources.Resources.iconfinder_185042_edit_modify_icon_32px2
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEditar.Location = New System.Drawing.Point(136, 263)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(99, 36)
        Me.btnEditar.TabIndex = 30
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(30, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 21)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Apellido"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(31, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 21)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Identidad"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(164, 103)
        Me.txtApellido.MaxLength = 25
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(113, 23)
        Me.txtApellido.TabIndex = 33
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(164, 143)
        Me.txtIdentidad.MaxLength = 50
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(113, 23)
        Me.txtIdentidad.TabIndex = 34
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(925, 343)
        Me.Controls.Add(Me.txtIdentidad)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dvgClientes)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodigoCliente)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        CType(Me.dvgClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodigoCliente As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dvgClientes As DataGridView
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents tt_cliente As ToolTip
    Friend WithEvents erroricono As ErrorProvider
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtIdentidad As TextBox
End Class
