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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Grupos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcodgrup = New System.Windows.Forms.TextBox()
        Me.DTfechaini = New System.Windows.Forms.DateTimePicker()
        Me.DTfechafin = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGgrupos = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rtxtobs = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnumanimales = New System.Windows.Forms.TextBox()
        Me.txtcodigodieta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bteliminar = New System.Windows.Forms.Button()
        Me.btagregar = New System.Windows.Forms.Button()
        Me.btnatras = New System.Windows.Forms.Button()
        Me.btnedi = New System.Windows.Forms.Button()
        CType(Me.DGgrupos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'txtcodgrup
        '
        Me.txtcodgrup.Location = New System.Drawing.Point(260, 55)
        Me.txtcodgrup.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtcodgrup.Name = "txtcodgrup"
        Me.txtcodgrup.Size = New System.Drawing.Size(100, 27)
        Me.txtcodgrup.TabIndex = 1
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
        'DGgrupos
        '
        Me.DGgrupos.AllowUserToAddRows = False
        Me.DGgrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGgrupos.Location = New System.Drawing.Point(531, 55)
        Me.DGgrupos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DGgrupos.Name = "DGgrupos"
        Me.DGgrupos.RowHeadersWidth = 51
        Me.DGgrupos.RowTemplate.Height = 24
        Me.DGgrupos.Size = New System.Drawing.Size(870, 421)
        Me.DGgrupos.TabIndex = 6
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
        'rtxtobs
        '
        Me.rtxtobs.Location = New System.Drawing.Point(179, 365)
        Me.rtxtobs.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rtxtobs.Name = "rtxtobs"
        Me.rtxtobs.Size = New System.Drawing.Size(201, 224)
        Me.rtxtobs.TabIndex = 8
        Me.rtxtobs.Text = ""
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
        'txtnumanimales
        '
        Me.txtnumanimales.Location = New System.Drawing.Point(260, 96)
        Me.txtnumanimales.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtnumanimales.MaxLength = 2
        Me.txtnumanimales.Name = "txtnumanimales"
        Me.txtnumanimales.Size = New System.Drawing.Size(100, 27)
        Me.txtnumanimales.TabIndex = 10
        '
        'txtcodigodieta
        '
        Me.txtcodigodieta.Location = New System.Drawing.Point(260, 139)
        Me.txtcodigodieta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtcodigodieta.MaxLength = 2
        Me.txtcodigodieta.Name = "txtcodigodieta"
        Me.txtcodigodieta.Size = New System.Drawing.Size(100, 27)
        Me.txtcodigodieta.TabIndex = 12
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
        'bteliminar
        '
        Me.bteliminar.BackColor = System.Drawing.Color.BurlyWood
        Me.bteliminar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bteliminar.Location = New System.Drawing.Point(667, 560)
        Me.bteliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bteliminar.Name = "bteliminar"
        Me.bteliminar.Size = New System.Drawing.Size(113, 69)
        Me.bteliminar.TabIndex = 26
        Me.bteliminar.Text = "Eliminar"
        Me.bteliminar.UseVisualStyleBackColor = False
        '
        'btagregar
        '
        Me.btagregar.BackColor = System.Drawing.Color.BurlyWood
        Me.btagregar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btagregar.Location = New System.Drawing.Point(508, 560)
        Me.btagregar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btagregar.Name = "btagregar"
        Me.btagregar.Size = New System.Drawing.Size(113, 69)
        Me.btagregar.TabIndex = 25
        Me.btagregar.Text = "Agregar "
        Me.btagregar.UseVisualStyleBackColor = False
        '
        'btnatras
        '
        Me.btnatras.BackColor = System.Drawing.SystemColors.Control
        Me.btnatras.Image = CType(resources.GetObject("btnatras.Image"), System.Drawing.Image)
        Me.btnatras.Location = New System.Drawing.Point(983, 560)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(107, 69)
        Me.btnatras.TabIndex = 27
        Me.btnatras.UseVisualStyleBackColor = False
        '
        'btnedi
        '
        Me.btnedi.BackColor = System.Drawing.Color.BurlyWood
        Me.btnedi.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnedi.Location = New System.Drawing.Point(824, 560)
        Me.btnedi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnedi.Name = "btnedi"
        Me.btnedi.Size = New System.Drawing.Size(113, 69)
        Me.btnedi.TabIndex = 28
        Me.btnedi.Text = "Editar"
        Me.btnedi.UseVisualStyleBackColor = False
        '
        'Grupos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1413, 725)
        Me.Controls.Add(Me.btnedi)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.bteliminar)
        Me.Controls.Add(Me.btagregar)
        Me.Controls.Add(Me.txtcodigodieta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtnumanimales)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rtxtobs)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DGgrupos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DTfechafin)
        Me.Controls.Add(Me.DTfechaini)
        Me.Controls.Add(Me.txtcodgrup)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Grupos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grupos"
        CType(Me.DGgrupos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtcodgrup As TextBox
    Friend WithEvents DTfechaini As DateTimePicker
    Friend WithEvents DTfechafin As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DGgrupos As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents rtxtobs As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtnumanimales As TextBox
    Friend WithEvents txtcodigodieta As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents bteliminar As Button
    Friend WithEvents btagregar As Button
    Friend WithEvents btnatras As Button
    Friend WithEvents btnedi As Button
End Class
