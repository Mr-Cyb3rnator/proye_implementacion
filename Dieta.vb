Imports System.Data.SqlClient
Public Class Dieta
    Private Sub cargarcmb()
        '----funcion que carga los datos al combobox
        Try
            sql = "SELECT * FROM ingredientes"
            adt = New SqlDataAdapter(sql, cn)
            ds = New DataSet
            adt.Fill(ds)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cargargrid()
        '----Carga la lista de ingredientes en el datagrid
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
            cod_dieta = Convert.ToInt32(txtCodDieta.Text)
            dgvIngredientesDieta.DataSource = CargarDatosGrid("select a.cod_ingrediente, b.descripcion from dietas_ingredientes a join  ingredientes b on a.cod_ingrediente = b.cod_ingredientes where a.cod_dieta= " & cod_dieta)
            CerrarConexion()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Dieta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '-----carga lo primero que se ve al abrir el formulario
        dgvDieta.ClearSelection()
        cargargrid()
        'cargargrid_dieta()
        cargarcmb()
        Try
            cmbCodIngre.DataSource = ds.Tables(0)
            cmbCodIngre.ValueMember = "cod_ingredientes"
            cmbCodIngre.DisplayMember = "descripcion"
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        '-----aqui se guarda una nueva dieta en la base de datos 
        If txtCantidad.Text = "" Or txtComidaXDia.Text = "" Then
            MessageBox.Show("Llene todos los campos", "Error")
        Else
            Try
                conecta()
                ModificarBD("exec InsertarDietas " & txtCantidad.Text & ", " & txtComidaXDia.Text)
                CerrarConexion()
                cargargrid()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub dgvDieta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDieta.CellContentClick
        '---permite seleccionar las filas del datagrid y mostrar los datos en los textbox 
        Dim row As DataGridViewRow = dgvDieta.CurrentRow
        Dim fila As Integer = dgvDieta.CurrentCell.RowIndex
        txtCodDieta.Text = dgvDieta(0, fila).Value.ToString()
        txtCantidad.Text = dgvDieta(1, fila).Value.ToString()
        txtComidaXDia.Text = dgvDieta(2, fila).Value.ToString()
    End Sub

    Private Sub btAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        '--------actualiza la tabla ingredientes
        If (lblCodIngre.Text = 0) Then
            MessageBox.Show("El codigo del ingrediente no puede ser 0, seleccione otro ingrediente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                conecta()
                cmbCodIngre.Text = 0
                ModificarBD("exec InsertarIngredientesDietas " & txtCodDieta.Text & ", " & lblCodIngre.Text)
                CerrarConexion()
                cargargrid_dieta()
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCargarIngredientes.Click
        '---boton seleccionar dieta
        btnAgregar.Enabled = True
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
    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        CampoValidacionNumeros(e)
    End Sub
    Private Sub txtcomidaxdia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtComidaXDia.KeyPress
        CampoValidacionNumeros(e)
    End Sub
    Private Sub cmbcodingre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCodIngre.SelectedIndexChanged
        lblCodIngre.Text = cmbCodIngre.SelectedIndex
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtCantidad.Text = ""
        txtCodDieta.Text = ""
        txtComidaXDia.Text = ""
        btnAgregar.Enabled = False
        lblCodIngre.Text = 0
        cmbCodIngre.SelectedIndex = 0
    End Sub
    '=======boton para regresar al menu
    Private Sub btnAtras_Click_1(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Close()
        frmMenu.Show()
    End Sub
    Private Sub btnEliminar_Click_1(sender As Object, e As EventArgs) Handles btnEliminar.Click
        '---------boton eliminar dieta
        Dim opcion As DialogResult
        opcion = MessageBox.Show("Seguro que quiere eliminar el Registro?", "Eliminar Registro", MessageBoxButtons.YesNo)
        If (opcion = Windows.Forms.DialogResult.Yes) Then
            Try
                conecta()
                ModificarBD("exec EliminarDieta " & txtCodDieta.Text)
                CerrarConexion()
                cargargrid()
            Catch ex As Exception
                conectar.Close()
                MessageBox.Show("Ocurrio un error en la coneccion con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class