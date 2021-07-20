<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrearUsuario))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.txtcontra = New System.Windows.Forms.TextBox()
        Me.dtgcrear = New System.Windows.Forms.DataGridView()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.txttipo = New System.Windows.Forms.TextBox()
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dtgcrear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(30, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(24, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(30, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tipo:"
        '
        'txtusuario
        '
        Me.txtusuario.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtusuario.Location = New System.Drawing.Point(153, 115)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(125, 32)
        Me.txtusuario.TabIndex = 3
        '
        'txtcontra
        '
        Me.txtcontra.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtcontra.Location = New System.Drawing.Point(153, 196)
        Me.txtcontra.Name = "txtcontra"
        Me.txtcontra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcontra.Size = New System.Drawing.Size(125, 32)
        Me.txtcontra.TabIndex = 4
        '
        'dtgcrear
        '
        Me.dtgcrear.AllowUserToAddRows = False
        Me.dtgcrear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgcrear.Location = New System.Drawing.Point(297, 39)
        Me.dtgcrear.Name = "dtgcrear"
        Me.dtgcrear.RowHeadersWidth = 51
        Me.dtgcrear.RowTemplate.Height = 29
        Me.dtgcrear.Size = New System.Drawing.Size(499, 264)
        Me.dtgcrear.TabIndex = 6
        '
        'btn_Guardar
        '
        Me.btn_Guardar.BackColor = System.Drawing.Color.BurlyWood
        Me.btn_Guardar.BackgroundImage = Global.proye.My.Resources.Resources.icons8_añadir_a_la_cesta_de_compra_48
        Me.btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Guardar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_Guardar.Location = New System.Drawing.Point(829, 35)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(135, 61)
        Me.btn_Guardar.TabIndex = 7
        Me.btn_Guardar.Text = "     Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.UseVisualStyleBackColor = False
        '
        'btn_Modificar
        '
        Me.btn_Modificar.BackColor = System.Drawing.Color.BurlyWood
        Me.btn_Modificar.BackgroundImage = Global.proye.My.Resources.Resources.iconfinder_185042_edit_modify_icon_32px
        Me.btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Modificar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_Modificar.Location = New System.Drawing.Point(829, 104)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(135, 61)
        Me.btn_Modificar.TabIndex = 8
        Me.btn_Modificar.Text = "   Modificar"
        Me.btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Modificar.UseVisualStyleBackColor = False
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.BackColor = System.Drawing.Color.BurlyWood
        Me.btn_Eliminar.BackgroundImage = Global.proye.My.Resources.Resources.icons8_borrar_para_siempre_32
        Me.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Eliminar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Eliminar.Location = New System.Drawing.Point(829, 171)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(135, 61)
        Me.btn_Eliminar.TabIndex = 9
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Eliminar.UseVisualStyleBackColor = False
        '
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.Color.BurlyWood
        Me.btn_Salir.BackgroundImage = Global.proye.My.Resources.Resources.iconfinder_4781838_cancel_close_delete_exit_logout_icon_32px
        Me.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Salir.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_Salir.Location = New System.Drawing.Point(829, 237)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(135, 65)
        Me.btn_Salir.TabIndex = 10
        Me.btn_Salir.Text = "   Salir"
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'txttipo
        '
        Me.txttipo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txttipo.Location = New System.Drawing.Point(153, 267)
        Me.txttipo.Name = "txttipo"
        Me.txttipo.Size = New System.Drawing.Size(125, 32)
        Me.txttipo.TabIndex = 11
        '
        'txtcod
        '
        Me.txtcod.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtcod.Location = New System.Drawing.Point(153, 39)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(125, 32)
        Me.txtcod.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(30, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 23)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Código:"
        '
        'CrearUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(977, 348)
        Me.Controls.Add(Me.txtcod)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txttipo)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Modificar)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.dtgcrear)
        Me.Controls.Add(Me.txtcontra)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CrearUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Usuario"
        CType(Me.dtgcrear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents txtcontra As TextBox
    Friend WithEvents dtgcrear As DataGridView
    Friend WithEvents btn_Guardar As Button
    Friend WithEvents btn_Modificar As Button
    Friend WithEvents btn_Eliminar As Button
    Friend WithEvents btn_Salir As Button
    Friend WithEvents txttipo As TextBox
    Friend WithEvents txtcod As TextBox
    Friend WithEvents Label4 As Label
End Class
