Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Clientes
    Dim loadingForm As Boolean

    Private Sub cargargrid()

        conecta()
        Dim cargar_datos_clientes As String = "select cod_cliente as 'Código cliente' , nombre as 'Nombre' , direcion as 'Dirección', telefono as 'Teléfono' from clientes"
        Dim mostrar As New DataTable
        Using adpmostrar As New SqlDataAdapter(cargar_datos_clientes, conectar)

            adpmostrar.Fill(mostrar)

        End Using
        dvgClientes.DataSource = mostrar
        CerrarConexion()



    End Sub


    Private Sub btagregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        'DGclientes.Rows.Add(txtcodcliente.Text, txtnombre.Text, txtdireccion.Text, txttelefono.Text)
        If (txtNombre.Text IsNot "" And txtTelefono.Text IsNot "" And txtDireccion.Text IsNot "") Then

            Try
                conecta()
                Dim insertar_cliente As String = "insert into clientes (nombre,telefono,direcion)values(@nombre,@telefono,@direcion)"
                Dim insertar As New SqlCommand(insertar_cliente, conectar)
                insertar.Parameters.AddWithValue("@nombre", txtNombre.Text)
                insertar.Parameters.AddWithValue("@telefono", txtTelefono.Text)
                insertar.Parameters.AddWithValue("@direcion", txtDireccion.Text)
                insertar.ExecuteNonQuery()

                conectar.Close()

            Catch ex As Exception
                MsgBox("Revise los Valores")
                conectar.Close()

            End Try


            loadingForm = False
            cargargrid()

            dvgClientes.ClearSelection()
            txtCodCliente.Text = ""
            txtNombre.Text = ""
            txtDireccion.Text = ""
            txtTelefono.Text = ""
            loadingForm = True
        Else
            MsgBox("Campos no pueden quedar vacios")
        End If








        'conecta()
        'Dim insertar_clientes As String = "insert into clientes(nombre,direcion,telefono)values(@nombre,@direcion,@telefono)"
        'Dim insertar As New SqlCommand(insertar_clientes, conectar)
        'insertar.Parameters.AddWithValue("@nombre", txtnombre.Text)
        'insertar.Parameters.AddWithValue("@direcion", txtdireccion.Text)
        'insertar.Parameters.AddWithValue("@telefono", txttelefono.Text)

        'insertar.ExecuteNonQuery()



        'conectar.Close()
        'cargargrid()

    End Sub

    Private Sub bteliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'DGclientes.Rows.Remove(DGclientes.CurrentRow)

        conecta()
        Dim eliminar As String = "delete from clientes where cod_cliente=@cod_cliente "
        Dim procesar As New SqlCommand(eliminar, conectar)
        procesar.Parameters.AddWithValue("@cod_cliente", txtCodCliente.Text)
        procesar.ExecuteNonQuery()
        conectar.Close()
        cargargrid()

        loadingForm = False
        cargargrid()
        dvgClientes.ClearSelection()

        txtCodCliente.Text = ""
        txtNombre.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""

        loadingForm = True

        btnEliminar.Enabled = False
        btnEditar.Enabled = False




    End Sub


    Private Sub bteditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        tt_cliente.SetToolTip(btnEditar, "")
        conecta()

        Dim datos_clientes As String = "update clientes set nombre=@nombre,telefono=@telefono,direccion=@direccion where cod_cliente=@cod_cliente"
        Dim actualizar As New SqlCommand(datos_clientes, conectar)
        actualizar.Parameters.AddWithValue("@cod_cliente", txtCodCliente.Text)
        actualizar.Parameters.AddWithValue("@nombre", txtNombre.Text)
        actualizar.Parameters.AddWithValue("@telefono", txtTelefono.Text)
        actualizar.Parameters.AddWithValue("@direccion", txtDireccion.Text)

        actualizar.ExecuteNonQuery()
        conectar.Close()

        loadingForm = False
        cargargrid()
        dvgClientes.ClearSelection()

        txtCodCliente.Text = ""
        txtNombre.Text = ""
        txtTelefono.Text = ""
        txtDireccion.Text = ""

        loadingForm = True


        btnEditar.Enabled = False
        btnEliminar.Enabled = False

        'conecta()

        'Dim datos As String = "update clientes set nombre=@nombre,telefono=@telefono where cod_cliente=@cod_cliente "
        'Dim actualizar As New SqlCommand(datos, conectar)
        'actualizar.Parameters.AddWithValue("@cod_cliente", txtcodcliente.Text)
        'actualizar.Parameters.AddWithValue("@nombre", txtnombre.Text)
        'actualizar.Parameters.AddWithValue("@Telefono", txttelefono.Text)

        'actualizar.ExecuteNonQuery()
        'conectar.Close()
        'cargargrid()

    End Sub

    Private Sub btnatras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        frm_Menu.Show()
    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadingForm = False
        cargargrid()
        dvgClientes.ClearSelection()
        loadingForm = True

        tt_cliente.SetToolTip(btnEditar, "Seleccione una Fila para Editar")
        tt_cliente.SetToolTip(btnEliminar, "Seleccione una Fila para Eliminar")

    End Sub

    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txtdireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDireccion.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            tt_cliente.SetToolTip(txtDireccion, "Acepta Caracteres")

        End If
    End Sub

    Private Sub txttelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            tt_cliente.SetToolTip(txtTelefono, "Solo Acepta Numeros")

        End If
    End Sub

    Private Sub txtcodcliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodCliente.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
            tt_cliente.SetToolTip(txtCodCliente, "")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            tt_cliente.SetToolTip(txtCodCliente, "")
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
            tt_cliente.SetToolTip(txtCodCliente, "")
        Else
            e.Handled = True
            tt_cliente.SetToolTip(txtCodCliente, "Solo Acepta Numeros")


        End If




        'If Char.IsNumber(e.KeyChar) Then
        '    e.Handled = False
        'ElseIf Char.IsControl(e.KeyChar) Then
        '    e.Handled = False
        'ElseIf Char.IsSeparator(e.KeyChar) Then
        '    e.Handled = False
        'Else
        '    e.Handled = True

        'End If

    End Sub

    Private Sub txtcodcliente_TextChanged(sender As Object, e As EventArgs) Handles txtCodCliente.TextChanged

    End Sub

    Private Sub DGclientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgClientes.CellContentClick
        Dim fila As Integer = dvgClientes.CurrentCell.RowIndex

        txtCodCliente.Text = dvgClientes(0, fila).Value.ToString()
        txtNombre.Text = dvgClientes(1, fila).Value.ToString()
        txtDireccion.Text = dvgClientes(2, fila).Value.ToString()
        txtTelefono.Text = dvgClientes(3, fila).Value.ToString()




    End Sub
    Private Sub DGclientes_SelectionChanged(sender As Object, e As EventArgs) Handles dvgClientes.SelectionChanged
        If (loadingForm) Then

            Dim fila As Integer
            fila = dvgClientes.CurrentRow.Index


            btnEditar.Enabled = True
            btnEliminar.Enabled = True

            txtCodCliente.Text = dvgClientes.Rows(fila).Cells(0).Value
            txtNombre.Text = dvgClientes.Rows(fila).Cells(1).Value
            txtTelefono.Text = dvgClientes.Rows(fila).Cells(2).Value
            txtDireccion.Text = dvgClientes.Rows(fila).Cells(3).Value

            btnAgregar.Enabled = False
            txtNombre.Enabled = True
            txtTelefono.Enabled = True
            txtDireccion.Enabled = True


        End If


    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        If (txtNombre.Text IsNot "") Then
            txtDireccion.Enabled = True
        Else
            txtDireccion.Enabled = False
        End If
    End Sub

    Private Sub txtdireccion_TextChanged(sender As Object, e As EventArgs) Handles txtDireccion.TextChanged
        If (txtDireccion.Text IsNot "") Then
            txtTelefono.Enabled = True
        Else
            txtTelefono.Enabled = False
        End If
    End Sub

    Private Sub txttelefono_TextChanged(sender As Object, e As EventArgs) Handles txtTelefono.TextChanged
        If (txtTelefono.Text IsNot "") Then
            btnAgregar.Enabled = True
        Else
            btnAgregar.Enabled = False
        End If
    End Sub

    Private Sub txtnombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre")
        End If
    End Sub

    Private Sub txtdireccion_Validating(sender As Object, e As CancelEventArgs) Handles txtDireccion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese la direccion")
        End If
    End Sub

    Private Sub txttelefono_Validating(sender As Object, e As CancelEventArgs) Handles txtTelefono.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el Telefono")
        End If
    End Sub

    Private Sub bteditar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnEditar.MouseMove
        If (btnEditar.Enabled <> True) Then
            tt_cliente.SetToolTip(btnEditar, "Seleccione una Fila para Editar")
        Else
            tt_cliente.SetToolTip(btnEditar, "")
        End If
    End Sub

    Private Sub bteditar_MouseUp(sender As Object, e As MouseEventArgs) Handles btnEditar.MouseUp
        If (btnEditar.Enabled <> True) Then
            tt_cliente.SetToolTip(btnEditar, "Seleccione una Fila para Editar")
        Else
            tt_cliente.SetToolTip(btnEditar, "")
        End If
    End Sub
End Class