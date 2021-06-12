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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcodcliente = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGclientes = New System.Windows.Forms.DataGridView()
        Me.bteliminar = New System.Windows.Forms.Button()
        Me.btagregar = New System.Windows.Forms.Button()
        Me.btnatras = New System.Windows.Forms.Button()
        Me.bteditar = New System.Windows.Forms.Button()
        CType(Me.DGclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo cliente"
        '
        'txtcodcliente
        '
        Me.txtcodcliente.Location = New System.Drawing.Point(169, 52)
        Me.txtcodcliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtcodcliente.Name = "txtcodcliente"
        Me.txtcodcliente.Size = New System.Drawing.Size(100, 27)
        Me.txtcodcliente.TabIndex = 1
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(169, 112)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(100, 27)
        Me.txtnombre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(169, 188)
        Me.txtdireccion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(100, 27)
        Me.txtdireccion.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Direccion"
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(169, 256)
        Me.txttelefono.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(100, 27)
        Me.txttelefono.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Teléfono"
        '
        'DGclientes
        '
        Me.DGclientes.AllowUserToAddRows = False
        Me.DGclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGclientes.Location = New System.Drawing.Point(320, 49)
        Me.DGclientes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DGclientes.Name = "DGclientes"
        Me.DGclientes.RowHeadersWidth = 51
        Me.DGclientes.RowTemplate.Height = 24
        Me.DGclientes.Size = New System.Drawing.Size(594, 329)
        Me.DGclientes.TabIndex = 8
        '
        'bteliminar
        '
        Me.bteliminar.Location = New System.Drawing.Point(331, 437)
        Me.bteliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bteliminar.Name = "bteliminar"
        Me.bteliminar.Size = New System.Drawing.Size(113, 69)
        Me.bteliminar.TabIndex = 28
        Me.bteliminar.Text = "Eliminar"
        Me.bteliminar.UseVisualStyleBackColor = True
        '
        'btagregar
        '
        Me.btagregar.Location = New System.Drawing.Point(187, 437)
        Me.btagregar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btagregar.Name = "btagregar"
        Me.btagregar.Size = New System.Drawing.Size(113, 69)
        Me.btagregar.TabIndex = 27
        Me.btagregar.Text = "Agregar "
        Me.btagregar.UseVisualStyleBackColor = True
        '
        'btnatras
        '
        Me.btnatras.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnatras.Image = CType(resources.GetObject("btnatras.Image"), System.Drawing.Image)
        Me.btnatras.Location = New System.Drawing.Point(834, 437)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(107, 69)
        Me.btnatras.TabIndex = 29
        Me.btnatras.UseVisualStyleBackColor = False
        '
        'bteditar
        '
        Me.bteditar.Location = New System.Drawing.Point(41, 437)
        Me.bteditar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bteditar.Name = "bteditar"
        Me.bteditar.Size = New System.Drawing.Size(113, 69)
        Me.bteditar.TabIndex = 30
        Me.bteditar.Text = "Editar"
        Me.bteditar.UseVisualStyleBackColor = True
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(954, 563)
        Me.Controls.Add(Me.bteditar)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.bteliminar)
        Me.Controls.Add(Me.btagregar)
        Me.Controls.Add(Me.DGclientes)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcodcliente)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        CType(Me.DGclientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtcodcliente As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DGclientes As DataGridView
    Friend WithEvents bteliminar As Button
    Friend WithEvents btagregar As Button
    Friend WithEvents btnatras As Button
    Friend WithEvents bteditar As Button
End Class
