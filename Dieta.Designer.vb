﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.txtcodingre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnatras = New System.Windows.Forms.Button()
        Me.btagregar = New System.Windows.Forms.Button()
        Me.dgingredientes_dieta = New System.Windows.Forms.DataGridView()
        Me.btselecionar_dierta = New System.Windows.Forms.Button()
        CType(Me.dgdieta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgingredientes_dieta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 107)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo Dieta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 207)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cantidad en libras:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 262)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Comidas por dia:"
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(207, 203)
        Me.txtcantidad.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(110, 31)
        Me.txtcantidad.TabIndex = 3
        '
        'txtcomidaxdia
        '
        Me.txtcomidaxdia.Location = New System.Drawing.Point(207, 257)
        Me.txtcomidaxdia.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtcomidaxdia.Name = "txtcomidaxdia"
        Me.txtcomidaxdia.Size = New System.Drawing.Size(110, 31)
        Me.txtcomidaxdia.TabIndex = 4
        '
        'txtcoddieta
        '
        Me.txtcoddieta.Location = New System.Drawing.Point(207, 102)
        Me.txtcoddieta.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtcoddieta.Name = "txtcoddieta"
        Me.txtcoddieta.Size = New System.Drawing.Size(110, 31)
        Me.txtcoddieta.TabIndex = 5
        '
        'dgdieta
        '
        Me.dgdieta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdieta.Location = New System.Drawing.Point(347, 102)
        Me.dgdieta.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgdieta.Name = "dgdieta"
        Me.dgdieta.RowHeadersWidth = 51
        Me.dgdieta.RowTemplate.Height = 28
        Me.dgdieta.Size = New System.Drawing.Size(516, 432)
        Me.dgdieta.TabIndex = 9
        '
        'btnguardar
        '
        Me.btnguardar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnguardar.Location = New System.Drawing.Point(46, 362)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(139, 50)
        Me.btnguardar.TabIndex = 10
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btneliminar.Location = New System.Drawing.Point(46, 306)
        Me.btneliminar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(139, 50)
        Me.btneliminar.TabIndex = 11
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'txtcodingre
        '
        Me.txtcodingre.Location = New System.Drawing.Point(207, 153)
        Me.txtcodingre.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtcodingre.Name = "txtcodingre"
        Me.txtcodingre.Size = New System.Drawing.Size(110, 31)
        Me.txtcodingre.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 157)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 25)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Codigo Ingrediente:"
        '
        'btnatras
        '
        Me.btnatras.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnatras.Image = CType(resources.GetObject("btnatras.Image"), System.Drawing.Image)
        Me.btnatras.Location = New System.Drawing.Point(1231, 583)
        Me.btnatras.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(111, 57)
        Me.btnatras.TabIndex = 26
        Me.btnatras.UseVisualStyleBackColor = False
        '
        'btagregar
        '
        Me.btagregar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btagregar.Location = New System.Drawing.Point(14, 452)
        Me.btagregar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btagregar.Name = "btagregar"
        Me.btagregar.Size = New System.Drawing.Size(325, 82)
        Me.btagregar.TabIndex = 27
        Me.btagregar.Text = "Agregar Ingrediente a dieta"
        Me.btagregar.UseVisualStyleBackColor = True
        '
        'dgingredientes_dieta
        '
        Me.dgingredientes_dieta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgingredientes_dieta.Location = New System.Drawing.Point(936, 102)
        Me.dgingredientes_dieta.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgingredientes_dieta.Name = "dgingredientes_dieta"
        Me.dgingredientes_dieta.RowHeadersWidth = 51
        Me.dgingredientes_dieta.RowTemplate.Height = 29
        Me.dgingredientes_dieta.Size = New System.Drawing.Size(543, 432)
        Me.dgingredientes_dieta.TabIndex = 28
        '
        'btselecionar_dierta
        '
        Me.btselecionar_dierta.Location = New System.Drawing.Point(36, 570)
        Me.btselecionar_dierta.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btselecionar_dierta.Name = "btselecionar_dierta"
        Me.btselecionar_dierta.Size = New System.Drawing.Size(294, 50)
        Me.btselecionar_dierta.TabIndex = 29
        Me.btselecionar_dierta.Text = "Seleccionar dieta"
        Me.btselecionar_dierta.UseVisualStyleBackColor = True
        '
        'Dieta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1581, 653)
        Me.Controls.Add(Me.btselecionar_dierta)
        Me.Controls.Add(Me.dgingredientes_dieta)
        Me.Controls.Add(Me.btagregar)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.txtcodingre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.dgdieta)
        Me.Controls.Add(Me.txtcoddieta)
        Me.Controls.Add(Me.txtcomidaxdia)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Dieta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DIETA"
        CType(Me.dgdieta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgingredientes_dieta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents txtcomidaxdia As TextBox
    Friend WithEvents txtcoddieta As TextBox
    Friend WithEvents dgdieta As DataGridView
    Friend WithEvents btnguardar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents txtcodingre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnatras As Button
    Friend WithEvents btagregar As Button
    Friend WithEvents dgingredientes_dieta As DataGridView
    Friend WithEvents btselecionar_dierta As Button
End Class
