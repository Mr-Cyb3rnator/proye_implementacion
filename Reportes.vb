Imports System.Data.SqlClient
Public Class Reportes
    Private Sub btn_Regresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
        frm_Menu.Show()
    End Sub

    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim datos As New DataTable

        'Estableciendo fecha maxima de seleccion para dtp final

        dtpFinal.MaxDate = DateTime.Now
        dtpInicio.Value = DateTime.Now.AddMonths(-1)




        conecta()
        Try

            datos = CargarDatosGrid("exec HistoricoCompra_General")
            dgvDatos.DataSource = datos
        Catch ex As Exception
            MsgBox("Revisar Conexion a la BD y/o Procedimiento junto a sus parametrosLOAD")
        End Try

        CerrarConexion()
    End Sub



    Private Sub dgv_Datos_Click(sender As Object, e As EventArgs) Handles dgvDatos.Click
        Dim resultado As SqlDataReader
        Dim estado As String
        conecta()


        If (rbCompra.Checked) Then
            Try

                resultado = LecturaBD("exec HistoricoCompraxGrupo " & dgvDatos.SelectedRows(0).Cells("Grupo").Value.ToString)

                estado = resultado.Read

                txtGrupo.Text = resultado("Grupo").ToString()
                txtCliente.Text = resultado("Cliente").ToString()
                txtLibras.Text = resultado("Peso Inicial").ToString()
                txtTotalPrecio.Text = resultado("Total Precio").ToString()

            Catch ex As Exception
                MsgBox("Error de Conexion")
            End Try
        Else
            Try

                resultado = LecturaBD("exec HistoricoVentasxGrupo " & dgvDatos.SelectedRows(0).Cells("Grupo").Value.ToString)

                estado = resultado.Read

                txtGrupo.Text = resultado("Grupo").ToString()
                txtCliente.Text = resultado("Cliente").ToString()
                txtLibras.Text = resultado("Total Lbs").ToString()
                txtTotalPrecio.Text = resultado("Total").ToString()

            Catch ex As Exception
                MsgBox("Error de Conexion")
            End Try

        End If

        CerrarConexion()
    End Sub

    Private Sub rb_Compra_CheckedChanged(sender As Object, e As EventArgs) Handles rbCompra.CheckedChanged
        Dim datos As New DataTable
        conecta()

        cbTipo.Items.Clear()
        cbTipo.Items.Add("Cliente")
        cbTipo.Items.Add("Raza")
        cbTipo.SelectedIndex = 0
        Try

            datos = CargarDatosGrid("exec HistoricoCompra_General")
            dgvDatos.DataSource = datos
        Catch ex As Exception
            MsgBox("Revisar Conexion a la BD y/o Procedimiento junto a sus parametros")
        End Try

        CerrarConexion()
        LimpiezaCampos()
        dgvDatos.ClearSelection()
    End Sub

    Private Sub rb_Venta_CheckedChanged(sender As Object, e As EventArgs) Handles rbVenta.CheckedChanged
        Dim datos As New DataTable
        conecta()

        'Llenado de ComboBox para el filtrado
        cbTipo.Items.Clear()
        cbTipo.Items.Add("Cliente")
        cbTipo.Items.Add("Peso Menor")
        cbTipo.Items.Add("Peso Mayor")
        cbTipo.SelectedIndex = 0
        Try

            datos = CargarDatosGrid("exec HistorioVentas_General")
            dgvDatos.DataSource = datos
        Catch ex As Exception
            MsgBox("Revisar Conexion a la BD y/o Procedimiento junto a sus parametros")
        End Try
        CerrarConexion()
        LimpiezaCampos()
        dgvDatos.ClearSelection()
    End Sub

    Private Sub LimpiezaCampos()
        txtGrupo.Clear()
        txtCliente.Clear()
        txtLibras.Clear()
        txtTotalPrecio.Clear()


    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        Dim datos As New DataTable
        Dim instruccion As String
        Dim fechaInicial As String
        Dim fechaFinal As String


        fechaInicial = dtpInicio.Value.Date.ToString("yyyy-MM-dd")
        fechaFinal = dtpFinal.Value.Date.ToString("yyyy-MM-dd")


        If (txtFiltro.Text = "") Then
            fechaInicial = DateTime.Now.AddYears(-1).ToString("yyyy-MM-dd")

            dtpInicio.Value = Convert.ToDateTime(fechaInicial)

        End If

        conecta()
        'Parametros de filtrado, dependiendo de la seleccion del combobox y transaccion animal
        'compra o venta de animal sera el historico que estara mostrando
        If (rbCompra.Checked) Then
            Select Case (cbTipo.SelectedIndex)
                Case 0
                    instruccion = "exec HistoricoCompraFiltradoCliente '" & txtFiltro.Text & "','" & fechaInicial & "','" & fechaFinal & "'"

                Case 1
                    instruccion = "exec HistoricoCompraFiltradoRaza '" & txtFiltro.Text & "'"
            End Select
        Else
            Select Case (cbTipo.SelectedIndex)
                Case 0
                    instruccion = "exec HistoricoVentas_FiltradoCliente '" & txtFiltro.Text & "'"
                Case 1
                    instruccion = "exec HistoricoVentas_FiltradoPesoMenor " & txtFiltro.Text
                Case 2
                    instruccion = "exec HistoricoVentas_FiltradoPesoMayor " & txtFiltro.Text
            End Select
        End If


        Try

            datos = CargarDatosGrid(instruccion)
            dgvDatos.DataSource = datos
        Catch ex As Exception
            MsgBox("Revisar Conexion a la BD y/o Procedimiento junto a sus parametros")
        End Try
        CerrarConexion()
    End Sub

    Private Sub btn_ReportGenerator_Click(sender As Object, e As EventArgs) Handles btn_ReportGenerator.Click

        Me.Hide()
        ReporteHistorico.Show()
        'Dim dt As New DataTable
        'Dim ch As New List(Of String)

        'Capturando las cabeceras del Data Grid View
        'For Each header As DataGridViewColumn In dgvDatos.Columns
        'ch.Add(header.HeaderText)
        'Next


        'For i = 0 To ch.Count - 1 Step 1
        'MsgBox(ch(i))
        'dt.Columns.Add(ch(i))
        'Next i

        'For Each row As DataGridViewRow In dgvDatos.Rows

        'For i = 0 To ch.Count - 1 Step 1
        'dt.Rows.Add(row.Cells(i).Value)
        'Next
        'Next



        'ReportViewer1.LocalReport.DataSources.Clear();
        'ReportViewer1.LocalReport.DataSources.Add(datasource);
        'ReportViewer1.LocalReport.Refresh();

    End Sub
End Class