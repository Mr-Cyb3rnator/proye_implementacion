Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Clientes
    Dim loadingForm As Boolean

    Private Sub cargargrid()

        conecta()

        Dim mostrar As New DataTable

        mostrar = CargarDatosGrid("select cod_cliente as 'Código cliente' , nombre as 'Nombre' , apellido as 'Apellido', identidad as 'Identidad' , direcion as 'Dirección', telefono as 'Teléfono' from clientes")

        'Using adpmostrar As New SqlDataAdapter(cargar_datos_clientes, conectar)

        '    adpmostrar.Fill(mostrar)

        'End Using


        dvgClientes.DataSource = mostrar
        CerrarConexion()



    End Sub


    Private Sub btagregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        conecta()


        Try


            ModificarBD("exec insertarClientes ' " & txtNombre.Text & " ', '" & txtApellido.Text & "','" & txtIdentidad.Text & "','" & txtDireccion.Text & "','" & txtTelefono.Text & "'")
            MsgBox("Datos del Usuario Ingresados Correctamente", MsgBoxResult.Ok, "Estado")


        Catch ex As Exception
            MsgBox("Revisar Conexion a la BD y/o Procedimiento junto a sus parametros")
        End Try

        CerrarConexion()

        RefrescarDataGrid()


        LimpiarCampos()

        'If (txtNombre.Text IsNot "" And txtTelefono.Text IsNot "" And txtDireccion.Text IsNot "") Then

        '    Try
        '        conecta()
        '        Dim insertar_cliente As String = "insert into clientes (nombre,telefono,direcion)values(@nombre,@telefono,@direcion)"
        '        Dim insertar As New SqlCommand(insertar_cliente, conectar)
        '        insertar.Parameters.AddWithValue("@nombre", txtNombre.Text)
        '        insertar.Parameters.AddWithValue("@telefono", txtTelefono.Text)
        '        insertar.Parameters.AddWithValue("@direcion", txtDireccion.Text)
        '        insertar.ExecuteNonQuery()

        '        conectar.Close()

        '    Catch ex As Exception
        '        MsgBox("Revise los Valores")
        '        conectar.Close()

        '    End Try


        '    loadingForm = False
        '    cargargrid()

        '    dvgClientes.ClearSelection()
        '    txtCodigoCliente.Text = ""
        '    txtNombre.Text = ""
        '    txtDireccion.Text = ""
        '    txtTelefono.Text = ""
        '    loadingForm = True
        'Else
        '    MsgBox("Campos no pueden quedar vacios")
        'End If








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

    Private Sub LimpiarCampos()
        txtCodigoCliente.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtIdentidad.Clear()
        txtDireccion.Clear()
        txtTelefono.Clear()

    End Sub


    Private Sub RefrescarDataGrid()
        Dim datocliente As New DataTable
        conecta()
        Try
            datocliente = CargarDatosGrid("exec ListaClientes")
            dvgClientes.DataSource = datocliente
        Catch ex As Exception
            MsgBox("Revisar Conexion a la BD y/o Procedimiento junto a sus parametros")
        End Try

        CerrarConexion()
    End Sub

    Private Sub bteliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        dvgClientes.Rows.Remove(dvgClientes.CurrentRow)

        LimpiarCampos()

        'conecta()
        'Dim eliminar As String = "delete from clientes where cod_cliente=@cod_cliente "
        'Dim procesar As New SqlCommand(eliminar, conectar)
        'procesar.Parameters.AddWithValue("@cod_cliente", txtCodigoCliente.Text)
        'procesar.ExecuteNonQuery()
        'conectar.Close()
        'cargargrid()

        'loadingForm = False
        'cargargrid()
        'dvgClientes.ClearSelection()

        'txtCodigoCliente.Text = ""
        'txtNombre.Text = ""
        'txtDireccion.Text = ""
        'txtTelefono.Text = ""

        'loadingForm = True

        'btnEliminar.Enabled = True
        'btnEditar.Enabled = True

        conecta()

        'Try
        '    ModificarBD("exec EliminarClientes " & txtCodigoCliente.Text)
        'Catch ex As Exception
        '    MsgBox("Revisar Conexion a la BD y/o Procedimiento junto a sus parametros")
        'End Try
        'CerrarConexion()

        'RefrescarDataGrid()
        'LimpiarCampos()



    End Sub


    Private Sub bteditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        'tt_cliente.SetToolTip(btnEditar, "")

        'btnEditar.Enabled = True
        'btnEliminar.Enabled = True


        'Try
        '    ModificarBD("exec ActualizarClientes  " & txtCodigoCliente.Text & " , '" & txtNombre.Text & " ', '" & txtApellido.Text & "','" & txtIdentidad.Text & "','" & txtDireccion.Text & "','" & txtTelefono.Text & "'")


        'Catch ex As Exception
        '    MsgBox("Revisar Conexion a la BD y/o Procedimiento junto a sus parametros")
        'End Try

        'CerrarConexion()

        'RefrescarDataGrid()

        'LimpiarCampos()

        'conecta()
        dvgClientes.Item(0, dvgClientes.CurrentRow.Index).Value = txtCodigoCliente.Text
        dvgClientes.Item(1, dvgClientes.CurrentRow.Index).Value = txtNombre.Text
        dvgClientes.Item(2, dvgClientes.CurrentRow.Index).Value = txtApellido.Text
        dvgClientes.Item(3, dvgClientes.CurrentRow.Index).Value = txtIdentidad.Text
        dvgClientes.Item(4, dvgClientes.CurrentRow.Index).Value = txtDireccion.Text
        dvgClientes.Item(5, dvgClientes.CurrentRow.Index).Value = txtTelefono.Text

        LimpiarCampos()




        'Dim datos_clientes As String = "update clientes set nombre=@nombre,telefono=@telefono,direccion=@direccion where cod_cliente=@cod_cliente"
        'Dim actualizar As New SqlCommand(datos_clientes, conectar)
        'actualizar.Parameters.AddWithValue("@cod_cliente", txtCodigoCliente.Text)
        'actualizar.Parameters.AddWithValue("@nombre", txtNombre.Text)
        'actualizar.Parameters.AddWithValue("@telefono", txtTelefono.Text)
        'actualizar.Parameters.AddWithValue("@direccion", txtDireccion.Text)

        'actualizar.ExecuteNonQuery()
        'conectar.Close()

        'loadingForm = False
        'cargargrid()
        'dvgClientes.ClearSelection()

        'txtCodigoCliente.Text = ""
        'txtNombre.Text = ""
        'txtTelefono.Text = ""
        'txtDireccion.Text = ""

        'loadingForm = True




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
        frmMenu.Show()
    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
<<<<<<< Updated upstream
        'loadingForm = False
        'cargargrid()
        'dvgClientes.ClearSelection()
        'loadingForm = True

        'tt_cliente.SetToolTip(btnEditar, "Seleccione una Fila para Editar")
        'tt_cliente.SetToolTip(btnEliminar, "Seleccione una Fila para Eliminar")

        RefrescarDataGrid()
=======
        cargargrid()
        bteditar.Enabled = False
        btagregar.Enabled = False
        bteliminar.Enabled = False

        If Not (txtcodcliente.Text = "" And Not txtnombre.Text = "" And Not txtdireccion.Text = "" And Not Val(txttelefono.Text = "")) Then
            btagregar.Enabled = True
        End If


>>>>>>> Stashed changes

    End Sub

    'Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
    '    If Char.IsLetter(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsSeparator(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True

    '    End If
    'End Sub

    'Private Sub txtdireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDireccion.KeyPress
    '    If Char.IsLetter(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsSeparator(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '        tt_cliente.SetToolTip(txtDireccion, "Acepta Caracteres")

    '    End If
    'End Sub

    'Private Sub txttelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
    '    If Char.IsNumber(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsSeparator(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '        tt_cliente.SetToolTip(txtTelefono, "Solo Acepta Numeros")

    '    End If
    'End Sub

    'Private Sub txtcodcliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoCliente.KeyPress
    '    If Char.IsNumber(e.KeyChar) Then
    '        e.Handled = False
    '        tt_cliente.SetToolTip(txtCodigoCliente, "")
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '        tt_cliente.SetToolTip(txtCodigoCliente, "")
    '    ElseIf Char.IsSeparator(e.KeyChar) Then
    '        e.Handled = False
    '        tt_cliente.SetToolTip(txtCodigoCliente, "")
    '    Else
    '        e.Handled = True
    '        tt_cliente.SetToolTip(txtCodigoCliente, "Solo Acepta Numeros")


    '    End If




    '    'If Char.IsNumber(e.KeyChar) Then
    '    '    e.Handled = False
    '    'ElseIf Char.IsControl(e.KeyChar) Then
    '    '    e.Handled = False
    '    'ElseIf Char.IsSeparator(e.KeyChar) Then
    '    '    e.Handled = False
    '    'Else
    '    '    e.Handled = True

    '    'End If

    'End Sub

    'Private Sub txtcodcliente_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoCliente.TextChanged

    'End Sub


    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        CampoValidacionLetras(e)

    End Sub
    Private Sub txtdapellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        CampoValidacionLetras(e)

    End Sub
    Private Sub txtidentidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdentidad.KeyPress
        CampoValidacionNumeros(e)

    End Sub
    Private Sub txtdireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDireccion.KeyPress
        CampoValidacionLetras(e)

    End Sub

    Private Sub txttelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        CampoValidacionNumeros(e)
    End Sub

    Private Sub txtcod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoCliente.KeyPress
        CampoValidacionNumeros(e)
    End Sub

<<<<<<< Updated upstream
    Private Sub CrearCliente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MsgBox("Deseas terminar la aplicación?", vbYesNo Or vbQuestion) = vbYes Then
            End
        Else

            Me.Show()
=======
    Private Sub txtcodcliente_TextChanged(sender As Object, e As EventArgs) Handles txtcodcliente.TextChanged
        If (bteditar.Text = "") Then
            btagregar.Enabled = False
>>>>>>> Stashed changes
        End If
    End Sub


    'Private Sub dvgClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgClientes.CellContentClick




    '    'txtCodigoCliente.Text = dvgClientes(0, i).Value.ToString()
    '    'txtNombre.Text = dvgClientes(1, fila).Value.ToString()
    '    'txtDireccion.Text = dvgClientes(2, fila).Value.ToString()
    '    'txtTelefono.Text = dvgClientes(3, fila).Value.ToString()
    'End Sub

    Private Sub dvgClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgClientes.CellClick

        Dim i As Integer = dvgClientes.CurrentRow.Index

        txtCodigoCliente.Text = dvgClientes(0, i).Value
        txtNombre.Text = dvgClientes(1, i).Value
        txtApellido.Text = dvgClientes(2, i).Value
        txtIdentidad.Text = dvgClientes(3, i).Value
        txtDireccion.Text = dvgClientes(4, i).Value
        txtTelefono.Text = dvgClientes(5, i).Value

    End Sub





<<<<<<< Updated upstream
    'End Sub

    'Private Sub DGclientes_SelectionChanged(sender As Object, e As EventArgs) Handles dvgClientes.SelectionChanged
    '    If (loadingForm) Then

    '        Dim fila As Integer
    '        fila = dvgClientes.CurrentRow.Index


    '        btnEditar.Enabled = True
    '        btnEliminar.Enabled = True

    '        txtCodigoCliente.Text = dvgClientes.Rows(fila).Cells(0).Value
    '        txtNombre.Text = dvgClientes.Rows(fila).Cells(1).Value
    '        txtTelefono.Text = dvgClientes.Rows(fila).Cells(2).Value
    '        txtDireccion.Text = dvgClientes.Rows(fila).Cells(3).Value

    '        btnAgregar.Enabled = False
    '        txtNombre.Enabled = True
    '        txtTelefono.Enabled = True
    '        txtDireccion.Enabled = True


    '    End If


    'End Sub

    'Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
    '    If (txtNombre.Text IsNot "") Then
    '        txtApellido.Enabled = True
    '    Else
    '        txtApellido.Enabled = False
    '    End If
    'End Sub

    'Private Sub txtapellido_TextChanged(sender As Object, e As EventArgs) Handles txtApellido.TextChanged
    '    If (txtApellido.Text IsNot "") Then
    '        txtIdentidad.Enabled = True
    '    Else
    '        txtIdentidad.Enabled = False
    '    End If
    'End Sub

    'Private Sub txtidentidad_TextChanged(sender As Object, e As EventArgs) Handles txtIdentidad.TextChanged
    '    If (txtIdentidad.Text IsNot "") Then
    '        txtDireccion.Enabled = True
    '    Else
    '        txtDireccion.Enabled = False
    '    End If
    'End Sub

    'Private Sub txtdireccion_TextChanged(sender As Object, e As EventArgs) Handles txtDireccion.TextChanged
    '    If (txtDireccion.Text IsNot "") Then
    '        txtTelefono.Enabled = True
    '    Else
    '        txtTelefono.Enabled = False
    '    End If
    'End Sub
    'Private Sub txttelefono_TextChanged(sender As Object, e As EventArgs) Handles txtTelefono.TextChanged
    '    If (txtTelefono.Text IsNot "") Then
    '        btnAgregar.Enabled = True
    '    Else
    '        btnAgregar.Enabled = False
    '    End If
    'End Sub

    'Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
    '    If DirectCast(sender, TextBox).Text.Length > 0 Then
    '        Me.erroricono.SetError(sender, "")
    '    Else
    '        Me.erroricono.SetError(sender, "Ingrese el nombre")
    '    End If
    'End Sub
    'Private Sub txtApellido_Validating(sender As Object, e As CancelEventArgs) Handles txtApellido.Validating
    '    If DirectCast(sender, TextBox).Text.Length > 0 Then
    '        Me.erroricono.SetError(sender, "")
    '    Else
    '        Me.erroricono.SetError(sender, "Ingrese el Apellido")
    '    End If
    'End Sub
    'Private Sub txtidentidad_Validating(sender As Object, e As CancelEventArgs) Handles txtIdentidad.Validating
    '    If DirectCast(sender, TextBox).Text.Length > 0 Then
    '        Me.erroricono.SetError(sender, "")
    '    Else
    '        Me.erroricono.SetError(sender, "Ingrese la identidad")
    '    End If
    'End Sub

    'Private Sub txtDireccion_Validating(sender As Object, e As CancelEventArgs) Handles txtDireccion.Validating
    '    If DirectCast(sender, TextBox).Text.Length > 0 Then
    '        Me.erroricono.SetError(sender, "")
    '    Else
    '        Me.erroricono.SetError(sender, "Ingrese la direccion")
    '    End If
    'End Sub

    'Private Sub txtTelefono_Validating(sender As Object, e As CancelEventArgs) Handles txtTelefono.Validating
    '    If DirectCast(sender, TextBox).Text.Length > 0 Then
    '        Me.erroricono.SetError(sender, "")
    '    Else
    '        Me.erroricono.SetError(sender, "Ingrese el Telefono")
    '    End If
    'End Sub

    'Private Sub bteditar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnEditar.MouseMove
    '    If (btnEditar.Enabled <> True) Then
    '        tt_cliente.SetToolTip(btnEditar, "Seleccione una Fila para Editar")
    '    Else
    '        tt_cliente.SetToolTip(btnEditar, "")
    '    End If
    'End Sub

    'Private Sub bteditar_MouseUp(sender As Object, e As MouseEventArgs) Handles btnEditar.MouseUp
    '    If (btnEditar.Enabled <> True) Then
    '        tt_cliente.SetToolTip(btnEditar, "Seleccione una Fila para Editar")
    '    Else
    '        tt_cliente.SetToolTip(btnEditar, "")
    '    End If
    'End Sub
=======
    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged
        If (txtnombre.Text = "") Then
            btagregar.Enabled = False
        End If
    End Sub

    Private Sub txtdireccion_TextChanged(sender As Object, e As EventArgs) Handles txtdireccion.TextChanged
        If (txtdireccion.Text = "") Then
            btagregar.Enabled = False
        End If
    End Sub

    Private Sub txttelefono_TextChanged(sender As Object, e As EventArgs) Handles txttelefono.TextChanged
        If (txttelefono.Text = "") Then
            btagregar.Enabled = False
        End If
    End Sub
>>>>>>> Stashed changes
End Class