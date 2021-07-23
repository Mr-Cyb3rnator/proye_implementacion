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
        Try
            conecta()
            dgvDieta.DataSource = CargarDatosGrid("exec ListaDietas")
            CerrarConexion()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cargargrid_dieta()
        'cargar los ingredientes de la dieta seleccionada por el codigo
        Try
            conecta()
            Dim cod_dieta As Integer
            Dim fila As DataGridViewRow = New DataGridViewRow()
            cod_dieta = Val(txtCodDieta.Text)
            dgvIngredientesDieta.DataSource = CargarDatosGrid("exec ListaIngredientesxDieta " & Val(txtCodDieta.Text))
            CerrarConexion()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Dieta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvDieta.ClearSelection()
        cargargrid()
        cargargrid_dieta()
        cargarcmb()
        btneliminar.Enabled = False
        Try
            cmbcodingre.DataSource = ds.Tables(0)
            cmbCodIngre.ValueMember = "cod_ingredientes"
            cmbCodIngre.DisplayMember = "descripcion"
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        '-----aqui se guarda una nueva dieta en la base de datos 
        If txtCantidad.Text = "" Or txtComidaXDia.Text = "" Then
            MessageBox.Show("Llene todos los campos", "Error")
        Else
            Try
                conecta()
                ModificarBD("exec InsertarDietas " & txtCantidad.Text & ", " & txtComidaXDia.Text)
                conectar.Close()
                cargargrid()
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
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
    Private Sub txtcoddieta_TextChanged(sender As Object, e As EventArgs) Handles txtCodDieta.TextChanged
        '-------buscador de la dieta por medio del codigo de la dieta en el textbox
        Try
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
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        '-------activa y desactiva los textbox
        Label1.Enabled = False
        txtCodDieta.Enabled = False
        btnSelecionarDierta.Enabled = False
        txtCantidad.Enabled = True
        txtComidaXDia.Enabled = True
        btnGuardar.Enabled = True
        '--------actualiza la tabla ingredientes
        Try
            conecta()
            Dim datos As String = "update ingredientes set cod_dieta=@cod_dieta where cod_ingredientes=@cod_ingredientes "
            Dim actualizar As New SqlCommand(datos, conectar)
            actualizar.Parameters.AddWithValue("@cod_ingredientes", lblCodIngre.Text)
            actualizar.Parameters.AddWithValue("@cod_dieta", txtCodDieta.Text)
            cmbCodIngre.Text = 0
            actualizar.ExecuteNonQuery()
            conectar.Close()
            cargargrid_dieta()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSelecionarDierta.Click
        GroupBox1.Enabled = True
        cargargrid_dieta()
    End Sub
    '---------validaciones de los textbox
    Private Sub txtcoddieta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodDieta.KeyPress
        CampoValidacionNumeros(e)
    End Sub
    Private Sub txtcodingre_KeyPress(sender As Object, e As KeyPressEventArgs)
        CampoValidacionNumeros(e)
    End Sub
    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
        CampoValidacionNumeros(e)
    End Sub
    Private Sub txtcomidaxdia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcomidaxdia.KeyPress
        CampoValidacionNumeros(e)
    End Sub
    Private Sub cmbcodingre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcodingre.SelectedIndexChanged
        'lblcodingre.Text = cmbcodingre.SelectedIndex
        lblCodIngre.Text = cmbCodIngre.SelectedIndex + 1
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Label1.Enabled = True
        txtCodDieta.Enabled = True
        txtCodDieta.Text = ""
        btnSelecionarDierta.Enabled = True
        txtcomidaxdia.Enabled = False
        txtcantidad.Enabled = False
        btnguardar.Enabled = False
        btneliminar.Enabled = True
    End Sub
    '=======boton para regresar al menu
    Private Sub btnAtras_Click_1(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Close()
        frm_Menu.Show()
    End Sub
End Class