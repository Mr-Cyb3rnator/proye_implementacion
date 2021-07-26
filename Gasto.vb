Imports System.Data.SqlClient

Public Class Gasto

    Dim totald As Integer
    Dim data As New DataSet

    Private Sub Gasto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conecta()

        'Carga de Codigo de Grupo en Combobox'
        Try
            data = ObtenerDataSet("exec MostrarGrupos_NoVendidos")
            cbGrupo.DataSource = data.Tables(0)
            cbGrupo.SelectedIndex = -1
            cbGrupo.DisplayMember = "Grupo"

        Catch ex As Exception
            MsgBox("Revisar conexion a la BD y/o procedimiento")
        End Try

        ' Esto Llena el ComboBox de ingredientes

        Try
            data = ObtenerDataSet("exec ListaIngredientes")
            cbIngredientes.DataSource = data.Tables(0)
            cbIngredientes.DisplayMember = "descripcion"
            cbIngredientes.SelectedIndex = -1

        Catch ex As Exception
            MsgBox("Revisar conexion a la BD y/o procedimiento")
        End Try

        CerrarConexion()


    End Sub

#Region "EventosBotones"

    Private Sub btcrear_Click(sender As Object, e As EventArgs) Handles btnFacturar.Click

        Dim recuperar As SqlDataReader
        Dim estado As String
        Dim num_factura As String
        Dim fila As DataGridViewRow = New DataGridViewRow()

        conecta()

        'Inserta los campos para la tabla de Gastos en BD
        Try
            ModificarBD("exec InsertarGastosxGrupo " & Convert.ToInt32(cbGrupo.Text) & ",'" & dtFecha.Value.Date.ToString("yyyy-MM-dd") & "'")
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
                For Each fila In dgvIngredientesUtilizados.Rows

                    ModificarBD("exec InsertarDetalleGastoxGrupo " & num_factura & "," & fila.Cells("ccodigo").Value & "," & fila.Cells("ccantidad").Value & "," & fila.Cells("cprecio").Value & "," & fila.Cells("csubtotal").Value)

                Next

            End If



        Catch ex As Exception
            MsgBox("Revisar Conexion a BD y/o Instruccion")
        End Try




        CerrarConexion()
        dgvIngredientesUtilizados.Rows.Clear()
        cbGrupo.SelectedIndex = -1
        cbIngredientes.SelectedIndex = -1
        txtcodIngre.Text = ""
        txtCantidad.Text = ""
        txtPrecio.Text = ""
        txtTotal.Text = ""



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim subtotal As Integer

        If (txtCantidad.Text IsNot "" And txtPrecio.Text IsNot "") Then
            subtotal = Val(txtPrecio.Text) * Val(txtCantidad.Text)

            'Agregar el costo de ingrediente al Data Grid View
            dgvIngredientesUtilizados.Rows.Add(txtcodIngre.Text, txtCantidad.Text, txtPrecio.Text, subtotal)
            totald = totald + subtotal
            txtTotal.Text = totald

            'Limpieza de Campos
            cbIngredientes.SelectedIndex = -1
            txtPrecio.Enabled = False
            txtCantidad.Enabled = False
            btnAgregar.Enabled = False
            txtCantidad.Text = ""
            txtcodIngre.Text = ""
            txtPrecio.Text = ""

        Else
            MsgBox("Rellene todos los campos")
        End If


    End Sub

    Private Sub b_Eliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Dim indiceseleccion As Integer
        Dim valor As Integer

        indiceseleccion = dgvIngredientesUtilizados.CurrentRow.Index
        valor = dgvIngredientesUtilizados.Rows(indiceseleccion).Cells("csubtotal").Value

        dgvIngredientesUtilizados.Rows.RemoveAt(indiceseleccion)

        If (dgvIngredientesUtilizados.RowCount <= 0) Then
            btnEliminar.Enabled = False
            btnFacturar.Enabled = False
            txtTotal.Text = ""
            totald = 0
        Else
            btnEliminar.Enabled = True
            totald = totald - valor
            txtTotal.Text = totald

        End If

    End Sub

    Private Sub btnatras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Close()
        frmMenu.Show()
    End Sub
#End Region

#Region "ActivacionBotones"
    Private Sub cb_Grupo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGrupo.SelectedIndexChanged
        cbIngredientes.Enabled = True
    End Sub

    Private Sub txtcantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        Dim valor As Integer
        'Validación de Campo no Vacío
        If (txtCantidad.Text IsNot "") Then
            btnAgregar.Enabled = True

            'Conversión de Dato en valor numérico
            Try
                valor = Convert.ToInt32(txtCantidad.Text)
                If (valor <= 0) Then
                    btnAgregar.Enabled = False
                Else
                    btnAgregar.Enabled = True

                End If
            Catch ex As Exception
                MsgBox("Revisar el valor ingresado sea numerico")
            End Try
        Else
            btnAgregar.Enabled = False
        End If

    End Sub

    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvIngredientesUtilizados.RowsAdded
        btnFacturar.Enabled = True
        btnEliminar.Enabled = True
    End Sub


    Private Sub txtprecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged
        If (txtPrecio.Text IsNot "") Then
            btnAgregar.Enabled = True
        Else
            btnAgregar.Enabled = False
        End If

        Dim valor As Integer
        Try
            valor = Convert.ToInt32(txtPrecio.Text)
            If (valor <= 0) Then
                btnAgregar.Enabled = False
            Else
                btnAgregar.Enabled = True

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cb_Ingredientes_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbIngredientes.SelectionChangeCommitted

        Dim mostrar_ingre As SqlDataReader
        txtCantidad.Enabled = True
        txtPrecio.Enabled = True

        conecta()
        mostrar_ingre = LecturaBD("select * from ingredientes where descripcion = '" & cbIngredientes.Text & "'")

        Dim estado As String
        estado = mostrar_ingre.Read

        If (estado = True) Then

            txtcodIngre.Text = mostrar_ingre(0)
            txtPrecio.Text = mostrar_ingre(2)

        End If


        mostrar_ingre.Close()

        CerrarConexion()

    End Sub

#End Region

    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        CampoValidacionNumeros(e)
    End Sub
End Class
