Imports System.Data.SqlClient
Public Class Compra
    Public contador2 As Integer
    Dim totalf As Integer

    Private Sub btagregar_Click(sender As Object, e As EventArgs) Handles btagregar.Click

        Dim subtotal As Integer


        If (txtpesoini.Text IsNot "" And txtedad.Text IsNot "" And txtprecio.Text IsNot "") Then


            contador2 = contador2 + 1
            subtotal = (Val(txtprecio.Text))


            dgv_Compra.Rows.Add(txtpesoini.Text, txtedad.Text, cb_Raza.SelectedItem.ToString, subtotal)
            totalf = totalf + subtotal
            txttotal.Text = totalf
            txtpesoini.Clear()
            txtedad.Clear()
            cb_Raza.SelectedIndex = -1
            txtprecio.Clear()
        Else
            MsgBox("Llene todos los campos")

        End If


    End Sub

    Private Sub btguardar_Click(sender As Object, e As EventArgs) Handles btguardar.Click

        Dim contador As Integer


        If (txtcod_cliente.Text IsNot "") Then


            conecta()

            'Insertando en tabla Compra Animales los animales que se compraron
            ModificarBD("exec InsertarCompraAnimales " & txtcod_cliente.Text & "," & txttotal.Text & ",'" & dtp_fecha.Value.Date.ToString("yyyy-MM-dd") & "'," & contador2)

            'Se obtienen los datos del ultimo grupo generado por la compra de animales
            Dim recuperar As SqlDataReader
            Dim num_Grupo As String
            Dim num_Factura As String ' por qué el número de grupo es el el número de factura también

            Try
                recuperar = LecturaBD("select top 1 cod_compra from compra_animales order by cod_compra desc")
                recuperar.Read()
                num_Grupo = recuperar(0)
                num_Factura = recuperar(0)
                MsgBox("Compra Efectuada Grupo# " + num_Grupo, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Compra Ganado #" + num_Factura)
                recuperar.Close()
            Catch ex As Exception
                MsgBox("Revisar si se hizo lectura de la BD")
            End Try

            'Insertar los datos del Grupo en BD
            Try
                ModificarBD("exec InsertarGrupos " + num_Grupo)
            Catch ex As Exception
                MsgBox("Revisar la conexión a la BD o si se asignó un número de Grupo")

            End Try


            'Insertar los detalles de compra de animales en la BD
            'Se recorre el data grid view donde esta agrupada toda la compra de los animales
            Dim fila As DataGridViewRow = New DataGridViewRow()
            For Each fila In dgv_Compra.Rows

                Try
                    ModificarBD("exec InsertarDetalleCompraAnimales " + num_Grupo + "," & fila.Cells("cpesoini").Value & "," & fila.Cells("craza").Value & "," & fila.Cells("cprecio_compra").Value)
                Catch ex As Exception
                    MsgBox("Revisar Conexion BD y/o Procedimiento para insertar detalles junto a sus parametros")
                End Try

                Try
                    ModificarBD("exec InsertarAnimales " & fila.Cells("cpesoini").Value & "," & fila.Cells("craza").Value & "," & num_Grupo & "," & fila.Cells("cprecio_compra").Value & "," & fila.Cells("cedad").Value)

                Catch ex As Exception
                    MsgBox("Revisar Conexion BD y/o Procedimiento para insertar Animales junto a sus parametros")
                End Try


                contador = contador + 1

            Next

            Try
                ModificarBD("exec ActualizarGrupos " & contador & "," & num_Grupo)
            Catch ex As Exception
                MsgBox("Revisar Conexion BD y/o Procedimiento para Actualizar los grupos junto a sus parametros")
            End Try


            conectar.Close()
            dgv_Compra.Rows.Clear()
            txttotal.Text = ""
            txtcod_cliente.Text = ""
        Else
            MsgBox("Revise Todos Los Campos esten llenos")

        End If

    End Sub


    Private Sub b_Limpiar_Click(sender As Object, e As EventArgs) Handles b_Limpiar.Click
        txtpesoini.Text = ""
        txtedad.Text = ""
        cb_Raza.SelectedIndex = -1
        txtprecio.Text = ""
        b_Limpiar.Enabled = False

    End Sub


    Private Sub txtcod_cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcod_cliente.KeyPress
        CampoValidacionNumeros(e)

        'If Char.IsNumber(e.KeyChar) Then
        'e.Handled = False
        'ElseIf Char.IsControl(e.KeyChar) Then
        'e.Handled = False
        'ElseIf Char.IsSeparator(e.KeyChar) Then
        'e.Handled = False
        'Else
        'e.Handled = True

        'End If
    End Sub

#Region "EventoValidacion"
    Private Sub txtpesoini_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpesoini.KeyPress
        Dim estado As Boolean
        estado = CampoValidacionNumeros(e)

        If (estado) Then
            tooltip_Compra.SetToolTip(txtpesoini, "Solo Permite Numeros, máximo 4 digitos")
        End If
    End Sub

    Private Sub txtedad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtedad.KeyPress
        Dim estado As Boolean
        estado = CampoValidacionNumeros(e)

        If (estado) Then
            tooltip_Compra.SetToolTip(txtedad, "Solo Permite Numeros, máximo 2 digitos")
        End If
    End Sub



    Private Sub txtprecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecio.KeyPress
        CampoValidacionNumeros(e)
    End Sub
#End Region




#Region "HabiltandoBotones"
    Private Sub txtcodp_TextChanged(sender As Object, e As EventArgs) Handles txtpesoini.TextChanged

        If (txtpesoini.Text IsNot "") Then
            txtedad.Enabled = True
            b_Limpiar.Enabled = True
        Else
            txtedad.Enabled = False
            b_Limpiar.Enabled = False

        End If

    End Sub

    Private Sub txtcod_cliente_TextChanged(sender As Object, e As EventArgs) Handles txtcod_cliente.TextChanged

        If (txtcod_cliente.Text IsNot "") Then
            txtpesoini.Enabled = True
        Else
            txtpesoini.Enabled = False
        End If

    End Sub
    Private Sub txtedad_TextChanged(sender As Object, e As EventArgs) Handles txtedad.TextChanged
        If (txtedad.Text IsNot "") Then
            cb_Raza.Enabled = True
            cb_Raza.SelectedIndex = 0
        Else
            cb_Raza.Enabled = False
            cb_Raza.SelectedIndex = -1
        End If
    End Sub

    Private Sub cb_Raza_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Raza.SelectedIndexChanged
        If (cb_Raza.SelectedIndex <> -1) Then
            txtprecio.Enabled = True
        Else
            txtprecio.Enabled = False
        End If
    End Sub

    Private Sub txtprecio_TextChanged(sender As Object, e As EventArgs) Handles txtprecio.TextChanged
        If (txtprecio.Text IsNot "") Then
            btagregar.Enabled = True
        Else
            btagregar.Enabled = False
        End If
    End Sub

    Private Sub txttotal_TextChanged(sender As Object, e As EventArgs) Handles txttotal.TextChanged
        If (txttotal.Text IsNot "") Then
            btguardar.Enabled = True
        Else
            btguardar.Enabled = False
        End If
    End Sub

#End Region

    Private Sub btnatras_Click(sender As Object, e As EventArgs) Handles btnatras.Click
        Me.Close()
        Form3.Show()

    End Sub
End Class