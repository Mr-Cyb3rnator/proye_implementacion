<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInicioSesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicioSesion))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnentrar = New System.Windows.Forms.Button()
        Me.btncrear = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.txtusu1 = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(309, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(309, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña:"
        '
        'btnentrar
        '
        Me.btnentrar.BackColor = System.Drawing.Color.BurlyWood
        Me.btnentrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnentrar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnentrar.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnentrar.Location = New System.Drawing.Point(309, 385)
        Me.btnentrar.Name = "btnentrar"
        Me.btnentrar.Size = New System.Drawing.Size(94, 53)
        Me.btnentrar.TabIndex = 2
        Me.btnentrar.Text = "Entrar"
        Me.btnentrar.UseVisualStyleBackColor = False
        '
        'btncrear
        '
        Me.btncrear.BackColor = System.Drawing.Color.BurlyWood
        Me.btncrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncrear.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btncrear.Location = New System.Drawing.Point(424, 385)
        Me.btncrear.Name = "btncrear"
        Me.btncrear.Size = New System.Drawing.Size(94, 53)
        Me.btncrear.TabIndex = 3
        Me.btncrear.Text = "Crear"
        Me.btncrear.UseVisualStyleBackColor = False
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.BurlyWood
        Me.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalir.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnsalir.Location = New System.Drawing.Point(541, 385)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(94, 53)
        Me.btnsalir.TabIndex = 4
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'txtusu1
        '
        Me.txtusu1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtusu1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtusu1.Location = New System.Drawing.Point(383, 167)
        Me.txtusu1.Name = "txtusu1"
        Me.txtusu1.Size = New System.Drawing.Size(135, 30)
        Me.txtusu1.TabIndex = 5
        '
        'txtpass
        '
        Me.txtpass.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtpass.Location = New System.Drawing.Point(383, 301)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(134, 32)
        Me.txtpass.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(357, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(235, 33)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "INICIO DE SESION"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.proye.My.Resources.Resources.pexels_ave_calvar_martinez_3640086
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -3)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(264, 465)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.proye.My.Resources.Resources.iconfinder_285655_user_icon_512px
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(309, 149)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 49)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.proye.My.Resources.Resources.iconfinder_2305594_access_key_password_privacy_security_icon_512px
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(309, 277)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 59)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'frmInicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(648, 461)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtusu1)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btncrear)
        Me.Controls.Add(Me.btnentrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInicioSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnentrar As Button
    Friend WithEvents btncrear As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents txtusu1 As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
