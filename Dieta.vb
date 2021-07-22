Imports System.Data.SqlClient
Public Class Dieta
    Private Sub cargarcmb()
        Try
            sql = "SELECT * FROM ingredientes"
            adt = New SqlDataAdapter(sql, cn)
            ds = New DataSet
            adt.Fill(ds)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cargargrid()
        conecta()
        dgvDieta.DataSource = CargarDatosGrid("exec ListaDietas")
        conectar.Close()
    End Sub
    Private Sub cargargrid_dieta()
        conecta()
        Dim cod_dieta As Integer
        Dim fila As DataGridViewRow = New DataGridViewRow()
        cod_dieta = Val(txtCodDieta.Text)
        Dim cargar_datos As String = "select descripcion Descripción,costo Precio from ingredientes where cod_dieta=" & Val(txtCodDieta.Text)
        Dim mostrar As New DataTable

        Using adpmostrar As New SqlDataAdapter(cargar_datos, conectar)
            adpmostrar.Fill(mostrar)
        End Using
        dgvIngredientesDieta.DataSource = mostrar
        conectar.Close()
    End Sub
    Private Sub Dieta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvDieta.ClearSelection()
        cargargrid()
        cargargrid_dieta()
        cargarcmb()
        btnEliminar.Enabled = False
        Try
            cmbCodIngre.DataSource = ds.Tables(0)
            cmbCodIngre.ValueMember = "cod_ingredientes"
            cmbCodIngre.DisplayMember = "descripcion"
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtCantidad.Text = "" Or txtComidaXDia.Text = "" Then
            MessageBox.Show("Llene todos los campos", "Error")
        Else
            conecta()
            Dim insertar_dieta As String = "insert into dieta(cantidad_libras,comidas_al_dia)values(@cantidad_libras,@comidas_al_dia)"
            Dim insertar As New SqlCommand(insertar_dieta, conectar)
            insertar.Parameters.AddWithValue("@cantidad_libras", txtCantidad.Text)
            insertar.Parameters.AddWithValue("@comidas_al_dia", txtComidaXDia.Text)
            insertar.ExecuteNonQuery()
            conectar.Close()
            cargargrid()
        End If
    End Sub
    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("Seguro que quiere eliminar el Registro?", "Eliminar Registro", MessageBoxButtons.YesNo)
        If (opcion = Windows.Forms.DialogResult.Yes) Then
            Try
                conecta()
                Dim eliminar As String = "delete from dieta where cod_dieta=@cod_dieta"
                Dim procesar As New SqlCommand(eliminar, conectar)
                procesar.Parameters.AddWithValue("@cod_dieta", txtCodDieta.Text)
                procesar.ExecuteNonQuery()
                CerrarConexion()
                cargargrid()
            Catch ex As Exception
                conectar.Close()
                MessageBox.Show("Ocurrio un error en la coneccion con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub dgdieta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDieta.CellContentClick
        Dim row As DataGridViewRow = dgvDieta.CurrentRow
    End Sub
    Private Sub btnatras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Close()
        frm_Menu.Show()
    End Sub
    Private Sub txtcoddieta_TextChanged(sender As Object, e As EventArgs) Handles txtCodDieta.TextChanged
        conecta()
        Dim recuperar As String = "select * from dieta where cod_dieta=' " & txtCodDieta.Text & " ' "
        Dim mostrar As SqlDataReader
        Dim ejecutar As New SqlCommand
        Dim estado As String
        ejecutar = New SqlCommand(recuperar, conectar)
        mostrar = ejecutar.ExecuteReader
        estado = mostrar.Read
        If (estado = True) Then
            txtCantidad.Text = mostrar(1)
            txtComidaXDia.Text = mostrar(2)
        Else
            txtCantidad.Text = ""
            txtComidaXDia.Text = ""
        End If
        mostrar.Close()
        conectar.Close()
    End Sub
    Private Sub btagregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Label1.Enabled = False
        txtCodDieta.Enabled = False
        btnSelecionarDierta.Enabled = False
        txtCantidad.Enabled = True
        txtComidaXDia.Enabled = True
        btnGuardar.Enabled = True
        If lblCodIngre.Text = 0 Then
            MessageBox.Show("No puede ser 0", "Error")
        Else
            conecta()
            Dim datos As String = "update ingredientes set cod_dieta=@cod_dieta where cod_ingredientes=@cod_ingredientes "
            Dim actualizar As New SqlCommand(datos, conectar)
            actualizar.Parameters.AddWithValue("@cod_ingredientes", lblCodIngre.Text)
            actualizar.Parameters.AddWithValue("@cod_dieta", txtCodDieta.Text)
            cmbCodIngre.Text = 0
            actualizar.ExecuteNonQuery()
            conectar.Close()
            cargargrid_dieta()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSelecionarDierta.Click
        GroupBox1.Enabled = True
        cargargrid_dieta()
    End Sub
    Private Sub txtcoddieta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodDieta.KeyPress
        CampoValidacionNumeros(e)
    End Sub
    Private Sub txtcodingre_KeyPress(sender As Object, e As KeyPressEventArgs)
        CampoValidacionNumeros(e)
    End Sub
    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        CampoValidacionNumeros(e)
    End Sub
    Private Sub txtcomidaxdia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtComidaXDia.KeyPress
        CampoValidacionNumeros(e)
    End Sub
    Private Sub cmbcodingre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCodIngre.SelectedIndexChanged
        lblCodIngre.Text = cmbCodIngre.SelectedIndex
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Label1.Enabled = True
        txtCodDieta.Enabled = True
        txtCodDieta.Text = ""
        btnSelecionarDierta.Enabled = True
        txtComidaXDia.Enabled = False
        txtCantidad.Enabled = False
        btnGuardar.Enabled = False
        btnEliminar.Enabled = True
    End Sub
End Class