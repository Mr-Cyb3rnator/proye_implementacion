Imports System.Data.SqlClient
Public Class estado_resultados
    Public venta, costo_g, gastos_g As Integer
    Private Sub cargargrid_venta()
        Dim precio, libras As Integer
        '/// Esto Carga el datagridview de Venta 
        Try
            conecta()
            dgvVenta.DataSource = CargarDatosGrid("exec CargarVentasBalance " & txtGrupo.Text)
            Dim recuperar As SqlDataReader
            recuperar = LecturaBD("exec CargarVentasBalance " & txtGrupo.Text)
            Dim estado As String
            estado = recuperar.Read
            If (estado = True) Then
                libras = recuperar(2)
                precio = recuperar(3)
            Else
            End If
            txtTotalVenta.Text = libras * precio
            venta = Val(txtTotalVenta.Text)
            recuperar.Close()
            '/// Esto Carga el Total del costo de compra
            Dim recuperar_g As SqlDataReader
            recuperar_g = LecturaBD("exec TotalCostoCompra " & txtGrupo.Text)
            Dim estado_g As String
            estado_g = recuperar_g.Read
            If (estado = True) Then
                txtCostoCompra.Text = recuperar_g(0)
            Else
            End If
            recuperar.Close()
            CerrarConexion()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cargargrid_detalle()
        '/// Esto Carga el datagridview de Gastos 
        Try
            conecta()
            dgvGastos.DataSource = CargarDatosGrid("exec CargarGastos " & txtGrupo.Text)
            CerrarConexion()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cargargrid_grupo()
        '/// Esto Carga el datagridview de Grupo 
        Try
            conecta()
            dgvAnimales.DataSource = CargarDatosGrid("exec CargarGrupos " & txtGrupo.Text)
            CerrarConexion()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cargar_gasto_total()
        '/// Esto Carga el Gasto total
        Try
            conecta()
            Dim recuperar_total As String = "select sum(subtotal) from detalle_gastos a join  gastos b on a.cod_gastos = b.cod_gastos where cod_grupo=" & txtGrupo.Text
            Dim recuperar As SqlDataReader
            Dim ejecutar As New SqlCommand
            ejecutar = New SqlCommand(recuperar_total, conectar)
            recuperar = ejecutar.ExecuteReader
            Dim estado As String
            estado = recuperar.Read
            If (estado = True) Then
                If IsDBNull(recuperar(0)) Then
                    MsgBox("este grupo no tiene gastos")
                Else
                    txtTotalGastos.Text = recuperar(0)
                End If
            End If
            gastos_g = Val(txtTotalGastos.Text)
            recuperar.Close()
            conectar.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnatras_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frm_Menu.Show()
    End Sub
    Private Sub btcalcular_Click(sender As Object, e As EventArgs) Handles btcalcular.Click
        txtganacia.Text = Val(txtTotalVenta.Text) - Val(txtTotalGastos.Text) - Val(txtCostoCompra.Text)
    End Sub
    Private Sub txtgrupo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGrupo.KeyPress
        CampoValidacionNumeros(e)
    End Sub
    Private Sub txt_cod_gastos_KeyPress(sender As Object, e As KeyPressEventArgs)
        CampoValidacionNumeros(e)
    End Sub
    Private Sub txtcod_venta_KeyPress(sender As Object, e As KeyPressEventArgs)
        CampoValidacionNumeros(e)
    End Sub
    Private Sub txt_total_gastos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotalGastos.KeyPress
        CampoValidacionNumeros(e)
    End Sub
    Private Sub txt_totalventa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotalVenta.KeyPress
        CampoValidacionNumeros(e)
    End Sub
    Private Sub txt_costo_compra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCostoCompra.KeyPress
        CampoValidacionNumeros(e)
    End Sub
    Private Sub btnatras_Click_1(sender As Object, e As EventArgs) Handles btnatras.Click
        Me.Close()
        frm_Menu.Show()
    End Sub
    Private Sub btcargar_gastos_Click(sender As Object, e As EventArgs) Handles btcargar_gastos.Click
        btcalcular.Enabled = True
        cargar_gasto_total()
        cargargrid_detalle()
        cargargrid_grupo()
        cargargrid_venta()
    End Sub
End Class