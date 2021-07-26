Imports System.Data.SqlClient
Public Class VentaGanado


#Region "Funciones"

    Private Sub cargarGridGrupo()

        conecta()

        'Listar los animales listos para la venta de acuerdo al grupo
        dgvVentaGanado.DataSource = CargarDatosGrid("exec MostrarAnimales_GrupoListos " & txtCodGrupo.Text)

        CerrarConexion()


    End Sub

    Private Sub cargar_peso_total()

        conecta()


        Dim recuperar As SqlDataReader
        Dim estado As String

        'Procedimiento que calcula el peso total del grupo de animales escogido para la venta
        recuperar = LecturaBD("exec CalcularPesoTotalAnimales " & txtCodGrupo.Text)

        estado = recuperar.Read

        If (estado = True) Then

            txtLibrasTotales.Text = recuperar(0)
        Else
            MsgBox("No hay datos que se puedan mostrar")
        End If

        recuperar.Close()
        CerrarConexion()

    End Sub

#End Region

#Region "EventosBotones"
    Private Sub VentaGanado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Muestra todos los grupos listos para la venta
        conecta()

        dgvGrupos.DataSource = CargarDatosGrid("exec MostrarAnimales_DistintosGrupos")

        CerrarConexion()


    End Sub

    Private Sub btnVender_Click(sender As Object, e As EventArgs) Handles btnVender.Click
        conecta()

        'Procedimiento para el registro de la venta de animales
        Try
            ModificarBD("exec InsertarVentaAnimales " & txtCodCliente.Text & ",'" & dtpFecha.Value.Date.ToString("yyyy-MM-dd") & "'," & txtLibrasTotales.Text & "," & txtPrecioLibra.Text & "," & txtCodGrupo.Text)
        Catch ex As Exception
            MsgBox("Revisar la conexión a la BD y/o el procedimiento de ventas junto a sus parametros")
        End Try


        'Procedimiento para actualizar el estado de los diferentes animales de un grupo determinado'
        Try
            ModificarBD("exec ActualizacionAnimalesVendidos " & "vendido" & "," & txtCodGrupo.Text)
            MsgBox("Venta Efectuada", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Venta Ganado")
        Catch ex As Exception
            MsgBox("Revisar la conexión a la BD y/o el procedimiento de actualizacion de animales junto a sus parametros")
        End Try

        'Limpieza de Campos'
        txtCodGrupo.Text = ""
        txtLibrasTotales.Text = ""
        txtPrecioLibra.Text = ""
        txtTotalVenta.Text = ""
        txtCodCliente.Text = " "
        dgvVentaGanado.DataSource = Nothing

        'Muestra todos los grupos listos para la venta
        dgvGrupos.DataSource = CargarDatosGrid("exec MostrarAnimales_DistintosGrupos")

        CerrarConexion()

    End Sub

    Private Sub btnCargarGrupo_Click(sender As Object, e As EventArgs) Handles btnCargarGrupo.Click

        'Recorrer el Data Grid View Cargado de Grupos'

        Dim grupoPresente As Boolean

        For Each row As DataGridViewRow In dgvGrupos.Rows
            If row.Cells("Grupos").Value = txtCodGrupo.Text Then


                grupoPresente = 1
                Exit For
            Else

                grupoPresente = 0

            End If
        Next

        If (grupoPresente) Then
            cargar_peso_total()
            cargarGridGrupo()

            txtPrecioLibra.Enabled = True
            txtPrecioLibra.Select()

        Else
            MsgBox("Grupo No Forma Parte de la Lista")

            txtCodGrupo.Text = ""
            txtCodGrupo.Select()

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Close()
        frmMenu.Show()
    End Sub

#End Region

#Region "Validaciones"
    Private Sub txtcodcliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodCliente.KeyPress
        CampoValidacionNumeros(e)
    End Sub

    Private Sub txtcodgrupo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodGrupo.KeyPress
        CampoValidacionNumeros(e)

    End Sub

    Private Sub txt_preciolibra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioLibra.KeyPress
        CampoValidacionNumeros(e)
    End Sub

#End Region

#Region "HabilitandoBotones"
    Private Sub txtcodgrupo_TextChanged(sender As Object, e As EventArgs) Handles txtCodGrupo.TextChanged
        btnCargarGrupo.Enabled = True

        If (txtCodGrupo.Text = "") Then
            btnCargarGrupo.Enabled = False
        End If

    End Sub

    Private Sub txt_preciolibra_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioLibra.TextChanged
        Dim total_venta As Integer

        If (txtPrecioLibra.Text IsNot "") Then
            'Hace el calculo de la venta a medida se va cambiando el precio de la libra
            total_venta = Val(txtLibrasTotales.Text) * Val(txtPrecioLibra.Text)
            txtTotalVenta.Text = total_venta

            txtCodCliente.Enabled = True

        Else
            txtTotalVenta.Text = ""
            txtCodCliente.Enabled = False
        End If

    End Sub

    Private Sub txtcodcliente_TextChanged(sender As Object, e As EventArgs) Handles txtCodCliente.TextChanged
        If (txtCodCliente.Text IsNot "") Then
            btnVender.Enabled = True
        Else
            btnVender.Enabled = False
        End If
    End Sub
#End Region

End Class