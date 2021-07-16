Imports System.Data.SqlClient
Public Class VentaGanado


#Region "Funciones"

    Private Sub cargargrid_grupo()

        conecta()

        'Listar los animales listos para la venta de acuerdo al grupo
        dgventaganado.DataSource = CargarDatosGrid("exec MostrarAnimales_GrupoListos " & txtcodgrupo.Text)

        conectar.Close()

    End Sub

    Private Sub cargar_peso_total()

        conecta()


        Dim recuperar As SqlDataReader
        Dim estado As String

        'Procedimiento que calcula el peso total del grupo de animales escogido para la venta
        recuperar = LecturaBD("exec CalcularPesoTotalAnimales " & txtcodgrupo.Text)

        estado = recuperar.Read

        If (estado = True) Then

            txtlibras_totales.Text = recuperar(0)
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
            ModificarBD("exec InsertarVentaAnimales " & txtcodcliente.Text & ",'" & dtpfecha.Value.Date.ToString("yyyy-MM-dd") & "'," & txtlibras_totales.Text & "," & txt_preciolibra.Text & "," & txtcodgrupo.Text)
        Catch ex As Exception
            MsgBox("Revisar la conexión a la BD y/o el procedimiento de ventas junto a sus parametros")
        End Try


        'Procedimiento para actualizar el estado de los diferentes animales de un grupo determinado'
        Try
            ModificarBD("exec ActualizacionAnimalesVendidos " & "vendido" & "," & txtcodgrupo.Text)
            MsgBox("Venta Efectuada", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Venta Ganado")
        Catch ex As Exception
            MsgBox("Revisar la conexión a la BD y/o el procedimiento de actualizacion de animales junto a sus parametros")
        End Try

        'Limpieza de Campos'
        txtcodgrupo.Text = ""
        txtlibras_totales.Text = ""
        txt_preciolibra.Text = ""
        txttotalventa.Text = ""
        txtcodcliente.Text = " "
        dgventaganado.DataSource = Nothing

        'Muestra todos los grupos listos para la venta
        dgvGrupos.DataSource = CargarDatosGrid("exec MostrarAnimales_DistintosGrupos")

        CerrarConexion()

    End Sub

    Private Sub btnCargarGrupo_Click(sender As Object, e As EventArgs) Handles btcargar_grupo.Click

        'Recorrer el Data Grid View Cargado de Grupos'
        'Dim getValue As String'
        Dim grupopresente As Boolean

        For Each row As DataGridViewRow In dgvGrupos.Rows
            If row.Cells("Grupos").Value = txtcodgrupo.Text Then

                'getValue = "Todo normal"'
                grupopresente = 1
                Exit For
            Else
                'getValue = "No Existe"'
                grupopresente = 0

            End If
        Next
        'MsgBox(getValue)'
        If (grupopresente) Then
            cargar_peso_total()
            cargargrid_grupo()

            txt_preciolibra.Enabled = True
            txt_preciolibra.Select()

        Else
            MsgBox("Grupo No Forma Parte de la Lista")

            txtcodgrupo.Text = ""
            txtcodgrupo.Select()

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnatras.Click
        Me.Close()
        frm_Menu.Show()
    End Sub

#End Region

#Region "Validaciones"
    Private Sub txtcodcliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodcliente.KeyPress
        CampoValidacionNumeros(e)
    End Sub

    Private Sub txtcodgrupo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodgrupo.KeyPress
        CampoValidacionNumeros(e)

    End Sub

    Private Sub txt_preciolibra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_preciolibra.KeyPress
        CampoValidacionNumeros(e)
    End Sub

#End Region

#Region "HabilitandoBotones"
    Private Sub txtcodgrupo_TextChanged(sender As Object, e As EventArgs) Handles txtcodgrupo.TextChanged
        btcargar_grupo.Enabled = True

        If (txtcodgrupo.Text = "") Then
            btcargar_grupo.Enabled = False
        End If

    End Sub

    Private Sub txt_preciolibra_TextChanged(sender As Object, e As EventArgs) Handles txt_preciolibra.TextChanged
        Dim total_venta As Integer

        If (txt_preciolibra.Text IsNot "") Then

            total_venta = Val(txtlibras_totales.Text) * Val(txt_preciolibra.Text)
            txttotalventa.Text = total_venta

            txtcodcliente.Enabled = True

        Else
            txttotalventa.Text = ""
            txtcodcliente.Enabled = False
        End If

    End Sub

    Private Sub txtcodcliente_TextChanged(sender As Object, e As EventArgs) Handles txtcodcliente.TextChanged
        If (txtcodcliente.Text IsNot "") Then
            btnVender.Enabled = True
        Else
            btnVender.Enabled = False
        End If
    End Sub
#End Region

End Class