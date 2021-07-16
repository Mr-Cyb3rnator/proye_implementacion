Imports System.Data.SqlClient

Public Class Gasto

    Dim totald As Integer
    Dim data As New DataSet

    Private Sub Gasto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conecta()

        'Carga de Codigo de Grupo en Combobox'
        Try
            data = ObtenerDataSet("exec MostrarGrupos_NoVendidos")
            cb_Grupo.DataSource = data.Tables(0)
            cb_Grupo.SelectedIndex = -1
            cb_Grupo.DisplayMember = "Grupo"

        Catch ex As Exception
            MsgBox("Revisar conexion a la BD y/o procedimiento")
        End Try

        ' Esto Llena el ComboBox de ingredientes

        Try
            data = ObtenerDataSet("exec ListaIngredientes")
            cb_Ingredientes.DataSource = data.Tables(0)
            cb_Ingredientes.DisplayMember = "descripcion"
            cb_Ingredientes.SelectedIndex = -1

        Catch ex As Exception
            MsgBox("Revisar conexion a la BD y/o procedimiento")
        End Try

        CerrarConexion()


    End Sub

#Region "EventosBotones"

    Private Sub btcrear_Click(sender As Object, e As EventArgs) Handles btn_Facturar.Click

        Dim recuperar As SqlDataReader
        Dim estado As String
        Dim num_factura As String
        Dim fila As DataGridViewRow = New DataGridViewRow()

        conecta()

        'Inserta los campos para la tabla de Gastos en BD
        Try
            ModificarBD("exec InsertarGastosxGrupo " & Convert.ToInt32(cb_Grupo.Text) & ",'" & dt_fecha.Value.Date.ToString("yyyy-MM-dd") & "'")
        Catch ex As Exception
            MsgBox("Revisar Conexion a BD y/o Procedimiento de InsertarGastos y parametros")
        End Try

        'Obtiene el ultimo registro hecho en gastos
        Try
            recuperar = LecturaBD("select top 1 cod_gastos from gastos order by cod_gastos desc")
            estado = recuperar.Read

            If (estado = True) Then

                num_factura = recuperar(0)
                recuperar.Close()

                'Inserta en la BD todos los gastos incurridos para el grupo
                For Each fila In dgv_IngredientesUtilizados.Rows

                    ModificarBD("exec InsertarDetalleGastoxGrupo " & num_factura & "," & fila.Cells("ccodigo").Value & "," & fila.Cells("ccantidad").Value & "," & fila.Cells("cprecio").Value & "," & fila.Cells("csubtotal").Value)

                Next

            End If



        Catch ex As Exception
            MsgBox("Revisar Conexion a BD y/o Instruccion")
        End Try




        CerrarConexion()
        dgv_IngredientesUtilizados.Rows.Clear()
        cb_Grupo.SelectedIndex = -1
        cb_Ingredientes.SelectedIndex = -1
        txtcod_ingre.Text = ""
        txtcantidad.Text = ""
        txtprecio.Text = ""
        txttotal.Text = ""



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btagregar.Click

        Dim subtotal As Integer

        If (txtcantidad.Text IsNot "" And txtprecio.Text IsNot "") Then
            subtotal = Val(txtprecio.Text) * Val(txtcantidad.Text)

            'Agregar el costo de ingrediente al Data Grid View
            dgv_IngredientesUtilizados.Rows.Add(txtcod_ingre.Text, txtcantidad.Text, txtprecio.Text, subtotal)
            totald = totald + subtotal
            txttotal.Text = totald

            'Limpieza de Campos
            cb_Ingredientes.SelectedIndex = -1
            txtprecio.Enabled = False
            txtcantidad.Enabled = False
            btagregar.Enabled = False
            txtcantidad.Text = ""
            txtcod_ingre.Text = ""
            txtprecio.Text = ""

        Else
            MsgBox("Rellene todos los campos")
        End If


    End Sub

    Private Sub b_Eliminar_Click(sender As Object, e As EventArgs) Handles b_Eliminar.Click

        Dim indiceseleccion As Integer
        Dim valor As Integer

        indiceseleccion = dgv_IngredientesUtilizados.CurrentRow.Index
        valor = dgv_IngredientesUtilizados.Rows(indiceseleccion).Cells("csubtotal").Value

        dgv_IngredientesUtilizados.Rows.RemoveAt(indiceseleccion)

        If (dgv_IngredientesUtilizados.RowCount <= 0) Then
            b_Eliminar.Enabled = False
            btn_Facturar.Enabled = False
            txttotal.Text = ""
            totald = 0
        Else
            b_Eliminar.Enabled = True
            totald = totald - valor
            txttotal.Text = totald

        End If

    End Sub

    Private Sub btnatras_Click(sender As Object, e As EventArgs) Handles btnatras.Click
        Me.Close()
        frm_Menu.Show()
    End Sub
#End Region

#Region "ActivacionBotones"
    Private Sub cb_Grupo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Grupo.SelectedIndexChanged
        cb_Ingredientes.Enabled = True
    End Sub

    Private Sub txtcantidad_TextChanged(sender As Object, e As EventArgs) Handles txtcantidad.TextChanged
        Dim valor As Integer
        'Validación de Campo no Vacío
        If (txtcantidad.Text IsNot "") Then
            btagregar.Enabled = True

            'Conversión de Dato en valor numérico
            Try
                valor = Convert.ToInt32(txtcantidad.Text)
                If (valor <= 0) Then
                    btagregar.Enabled = False
                Else
                    btagregar.Enabled = True

                End If
            Catch ex As Exception
                MsgBox("Revisar el valor ingresado sea numerico")
            End Try
        Else
            btagregar.Enabled = False
        End If

    End Sub

    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgv_IngredientesUtilizados.RowsAdded
        btn_Facturar.Enabled = True
        b_Eliminar.Enabled = True
    End Sub


    Private Sub txtprecio_TextChanged(sender As Object, e As EventArgs) Handles txtprecio.TextChanged
        If (txtprecio.Text IsNot "") Then
            btagregar.Enabled = True
        Else
            btagregar.Enabled = False
        End If

        Dim valor As Integer
        Try
            valor = Convert.ToInt32(txtprecio.Text)
            If (valor <= 0) Then
                btagregar.Enabled = False
            Else
                btagregar.Enabled = True

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cb_Ingredientes_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cb_Ingredientes.SelectionChangeCommitted

        Dim mostrar_ingre As SqlDataReader
        txtcantidad.Enabled = True
        txtprecio.Enabled = True

        conecta()
        mostrar_ingre = LecturaBD("select * from ingredientes where descripcion = '" & cb_Ingredientes.Text & "'")

        Dim estado As String
        estado = mostrar_ingre.Read

        If (estado = True) Then

            txtcod_ingre.Text = mostrar_ingre(0)
            txtprecio.Text = mostrar_ingre(2)

        End If


        mostrar_ingre.Close()

        CerrarConexion()

    End Sub

#End Region

    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
        CampoValidacionNumeros(e)
    End Sub
End Class
