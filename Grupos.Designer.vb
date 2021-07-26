<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Grupos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodGrup = New System.Windows.Forms.TextBox()
        Me.DTfechaini = New System.Windows.Forms.DateTimePicker()
        Me.DTfechafin = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvGrupos = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rtxtObs = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNumAnimales = New System.Windows.Forms.TextBox()
        Me.txtCodigoDieta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnEdi = New System.Windows.Forms.Button()
        CType(Me.dgvGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(25, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo de grupo:"
        '
        'txtCodGrup
        '
        Me.txtCodGrup.Location = New System.Drawing.Point(260, 55)
        Me.txtCodGrup.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodGrup.Name = "txtCodGrup"
        Me.txtCodGrup.Size = New System.Drawing.Size(100, 27)
        Me.txtCodGrup.TabIndex = 1
        '
        'DTfechaini
        '
        Me.DTfechaini.Location = New System.Drawing.Point(263, 207)
        Me.DTfechaini.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DTfechaini.MaxDate = New Date(4029, 12, 6, 0, 0, 0, 0)
        Me.DTfechaini.MinDate = New Date(2021, 6, 13, 0, 0, 0, 0)
        Me.DTfechaini.Name = "DTfechaini"
        Me.DTfechaini.Size = New System.Drawing.Size(262, 27)
        Me.DTfechaini.TabIndex = 2
        Me.DTfechaini.Value = New Date(2021, 6, 13, 0, 0, 0, 0)
        '
        'DTfechafin
        '
        Me.DTfechafin.Checked = False
        Me.DTfechafin.Enabled = False
        Me.DTfechafin.Location = New System.Drawing.Point(263, 265)
        Me.DTfechafin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DTfechafin.MinDate = New Date(2021, 6, 16, 0, 0, 0, 0)
        Me.DTfechafin.Name = "DTfechafin"
        Me.DTfechafin.Size = New System.Drawing.Size(262, 27)
        Me.DTfechafin.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(-2, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(259, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha inicial de engorde:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(-2, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(250, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha Final de engorde:"
        '
        'dgvGrupos
        '
        Me.dgvGrupos.AllowUserToAddRows = False
        Me.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrupos.Location = New System.Drawing.Point(531, 55)
        Me.dgvGrupos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvGrupos.MultiSelect = False
        Me.dgvGrupos.Name = "dgvGrupos"
        Me.dgvGrupos.ReadOnly = True
        Me.dgvGrupos.RowHeadersWidth = 51
        Me.dgvGrupos.RowTemplate.Height = 24
        Me.dgvGrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGrupos.Size = New System.Drawing.Size(870, 421)
        Me.dgvGrupos.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(16, 365)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Observaciones:"
        '
        'rtxtObs
        '
        Me.rtxtObs.Location = New System.Drawing.Point(179, 365)
        Me.rtxtObs.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rtxtObs.Name = "rtxtObs"
        Me.rtxtObs.Size = New System.Drawing.Size(201, 224)
        Me.rtxtObs.TabIndex = 8
        Me.rtxtObs.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(25, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(226, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Numero  de animales:"
        '
        'txtNumAnimales
        '
        Me.txtNumAnimales.Location = New System.Drawing.Point(260, 96)
        Me.txtNumAnimales.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNumAnimales.MaxLength = 2
        Me.txtNumAnimales.Name = "txtNumAnimales"
        Me.txtNumAnimales.Size = New System.Drawing.Size(100, 27)
        Me.txtNumAnimales.TabIndex = 10
        '
        'txtCodigoDieta
        '
        Me.txtCodigoDieta.Location = New System.Drawing.Point(260, 139)
        Me.txtCodigoDieta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodigoDieta.MaxLength = 2
        Me.txtCodigoDieta.Name = "txtCodigoDieta"
        Me.txtCodigoDieta.Size = New System.Drawing.Size(100, 27)
        Me.txtCodigoDieta.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(25, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 23)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Codigo Dieta:"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.BurlyWood
        Me.btnEliminar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEliminar.Location = New System.Drawing.Point(667, 560)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(113, 69)
        Me.btnEliminar.TabIndex = 26
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.BurlyWood
        Me.btnAgregar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAgregar.Location = New System.Drawing.Point(508, 560)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(113, 69)
        Me.btnAgregar.TabIndex = 25
        Me.btnAgregar.Text = "Agregar "
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnAtras
        '
        Me.btnAtras.BackColor = System.Drawing.Color.BurlyWood
        Me.btnAtras.Image = Global.proye.My.Resources.Resources.atras__2_
        Me.btnAtras.Location = New System.Drawing.Point(983, 560)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(107, 69)
        Me.btnAtras.TabIndex = 27
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'btnEdi
        '
        Me.btnEdi.BackColor = System.Drawing.Color.BurlyWood
        Me.btnEdi.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEdi.Location = New System.Drawing.Point(824, 560)
        Me.btnEdi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEdi.Name = "btnEdi"
        Me.btnEdi.Size = New System.Drawing.Size(113, 69)
        Me.btnEdi.TabIndex = 28
        Me.btnEdi.Text = "Editar"
        Me.btnEdi.UseVisualStyleBackColor = False
        '
        'Grupos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1413, 725)
        Me.Controls.Add(Me.btnEdi)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtCodigoDieta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNumAnimales)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rtxtObs)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvGrupos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DTfechafin)
        Me.Controls.Add(Me.DTfechaini)
        Me.Controls.Add(Me.txtCodGrup)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Grupos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grupos"
        CType(Me.dgvGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodGrup As TextBox
    Friend WithEvents DTfechaini As DateTimePicker
    Friend WithEvents DTfechafin As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvGrupos As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents rtxtObs As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNumAnimales As TextBox
    Friend WithEvents txtCodigoDieta As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnEdi As Button
End Class
