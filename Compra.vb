Imports System.Data.SqlClient
Public Class Compra
    Public contador2 As Integer
    Dim totalF As Integer

    Private Sub btagregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim subTotal As Integer


        If (txtPesoIni.Text IsNot "" And txtEdad.Text IsNot "" And txtPrecio.Text IsNot "") Then


            contador2 = contador2 + 1
            subTotal = (Val(txtPrecio.Text))


            dgvCompra.Rows.Add(txtPesoIni.Text, txtEdad.Text, cbRaza.SelectedItem.ToString, subTotal)
            totalF = totalF + subTotal
            txtTotal.Text = totalF
            txtPesoIni.Clear()
            txtEdad.Clear()
            cbRaza.SelectedIndex = -1
            txtPrecio.Clear()
        Else
            MsgBox("Llene todos los campos")

        End If


    End Sub

    Private Sub btguardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim contador As Integer


        If (txtCodCliente.Text IsNot "") Then


            conecta()

            'Insertando en tabla Compra Animales los animales que se compraron
            ModificarBD("exec InsertarCompraAnimales " & txtCodCliente.Text & "," & txtTotal.Text & ",'" & dtpFecha.Value.Date.ToString("yyyy-MM-dd") & "'," & contador2)

            'Se obtienen los datos del ultimo grupo generado por la compra de animales
            Dim recuperar As SqlDataReader
            Dim numGrupo As String
            Dim numFactura As String ' por qué el número de grupo es el el número de factura también
            numGrupo = "1"
            Try
                recuperar = LecturaBD("select top 1 cod_compra from compra_animales order by cod_compra desc")
                recuperar.Read()
                numGrupo = recuperar(0)
                numFactura = recuperar(0)
                MsgBox("Compra Efectuada Grupo# " + numGrupo, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Compra Ganado #" + numFactura)
                recuperar.Close()
            Catch ex As Exception
                MsgBox("Revisar si se hizo lectura de la BD")
            End Try

            'Insertar los datos del Grupo en BD
            Try
                ModificarBD("exec InsertarGrupos " + numGrupo)
            Catch ex As Exception
                MsgBox("Revisar la conexión a la BD o si se asignó un número de Grupo")

            End Try


            'Insertar los detalles de compra de animales en la BD
            'Se recorre el data grid view donde esta agrupada toda la compra de los animales
            Dim fila As DataGridViewRow = New DataGridViewRow()
            For Each fila In dgvCompra.Rows

                Try
                    ModificarBD("exec InsertarDetalleCompraAnimales " + numGrupo + "," & fila.Cells("cpesoini").Value & "," & fila.Cells("craza").Value & "," & fila.Cells("cprecio_compra").Value)
                Catch ex As Exception
                    MsgBox("Revisar Conexion BD y/o Procedimiento para insertar detalles junto a sus parametros")
                End Try

                Try
                    ModificarBD("exec InsertarAnimales " & fila.Cells("cpesoini").Value & "," & fila.Cells("craza").Value & "," & numGrupo & "," & fila.Cells("cprecio_compra").Value & "," & fila.Cells("cedad").Value)

                Catch ex As Exception
                    MsgBox("Revisar Conexion BD y/o Procedimiento para insertar Animales junto a sus parametros")
                End Try


                contador = contador + 1

            Next

            Try
                ModificarBD("exec ActualizarGrupos " & contador & "," & numGrupo)
            Catch ex As Exception
                MsgBox("Revisar Conexion BD y/o Procedimiento para Actualizar los grupos junto a sus parametros")
            End Try


            conectar.Close()
            dgvCompra.Rows.Clear()
            txtTotal.Text = ""
            txtCodCliente.Text = ""
        Else
            MsgBox("Revise Todos Los Campos esten llenos")

        End If

    End Sub


    Private Sub b_Limpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtPesoIni.Text = ""
        txtEdad.Text = ""
        cbRaza.SelectedIndex = -1
        txtPrecio.Text = ""
        btnLimpiar.Enabled = False

    End Sub




#Region "EventoValidacion"

    Private Sub txtcod_cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodCliente.KeyPress
        CampoValidacionNumeros(e)
    End Sub
    Private Sub txtpesoini_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPesoIni.KeyPress
        Dim estado As Boolean
        estado = CampoValidacionNumeros(e)

        If (estado) Then
            toolTipCompra.SetToolTip(txtPesoIni, "Solo Permite Numeros, máximo 4 digitos")
        End If
    End Sub

    Private Sub txtedad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEdad.KeyPress
        Dim estado As Boolean
        estado = CampoValidacionNumeros(e)

        If (estado) Then
            toolTipCompra.SetToolTip(txtEdad, "Solo Permite Numeros, máximo 2 digitos")
        End If
    End Sub

    Private Sub txtprecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        CampoValidacionNumeros(e)
    End Sub
#End Region




#Region "HabiltandoBotones"
    Private Sub txtcodp_TextChanged(sender As Object, e As EventArgs) Handles txtPesoIni.TextChanged

        If (txtPesoIni.Text IsNot "") Then
            txtEdad.Enabled = True
            btnLimpiar.Enabled = True
        Else
            txtEdad.Enabled = False
            btnLimpiar.Enabled = False

        End If

    End Sub

    Private Sub txtcod_cliente_TextChanged(sender As Object, e As EventArgs) Handles txtCodCliente.TextChanged

        If (txtCodCliente.Text IsNot "") Then
            txtPesoIni.Enabled = True
        Else
            txtPesoIni.Enabled = False
        End If

    End Sub
    Private Sub txtedad_TextChanged(sender As Object, e As EventArgs) Handles txtEdad.TextChanged
        If (txtEdad.Text IsNot "") Then
            cbRaza.Enabled = True
            cbRaza.SelectedIndex = 0
        Else
            cbRaza.Enabled = False
            cbRaza.SelectedIndex = -1
        End If
    End Sub

    Private Sub cb_Raza_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRaza.SelectedIndexChanged
        If (cbRaza.SelectedIndex <> -1) Then
            txtPrecio.Enabled = True
        Else
            txtPrecio.Enabled = False
        End If
    End Sub

    Private Sub txtprecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged
        If (txtPrecio.Text IsNot "") Then
            btnAgregar.Enabled = True
        Else
            btnAgregar.Enabled = False
        End If
    End Sub

    Private Sub txttotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged
        If (txtTotal.Text IsNot "") Then
            btnGuardar.Enabled = True
        Else
            btnGuardar.Enabled = False
        End If
    End Sub

#End Region

    Private Sub btnatras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Close()
        frmMenu.Show()

    End Sub

    Private Sub Compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class