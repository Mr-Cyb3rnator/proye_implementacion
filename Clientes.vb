Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Clientes
    Dim loadingForm As Boolean

    Private Sub cargargrid()

        conecta()

        Dim mostrar As New DataTable

        mostrar = CargarDatosGrid("select cod_cliente as 'Código cliente' , nombre as 'Nombre' , apellido as 'Apellido', identidad as 'Identidad' , direcion as 'Dirección', telefono as 'Teléfono' from clientes")


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





    End Sub


    Private Sub bteditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click


        conecta()
        Try
            ModificarBD("exec ActualizarClientes  " & txtCodigoCliente.Text & " , '" & txtNombre.Text & " ', '" & txtApellido.Text & "','" & txtIdentidad.Text & "','" & txtDireccion.Text & "','" & txtTelefono.Text & "'")


        Catch ex As Exception
            MsgBox("Revisar Conexion a la BD y/o Procedimiento junto a sus parametros")
        End Try

        CerrarConexion()

        RefrescarDataGrid()

        LimpiarCampos()



    End Sub

    Private Sub btnatras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        frmMenu.Show()
    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        RefrescarDataGrid()

    End Sub




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

    Private Sub CrearCliente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MsgBox("Deseas terminar la aplicación?", vbYesNo Or vbQuestion) = vbYes Then
            End
        Else

            Me.Show()
        End If
    End Sub



    Private Sub dvgClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgClientes.CellClick

        Dim i As Integer = dvgClientes.CurrentRow.Index

        txtCodigoCliente.Text = dvgClientes(0, i).Value.ToString()
        txtNombre.Text = dvgClientes(1, i).Value.ToString()
        txtApellido.Text = dvgClientes(2, i).Value.ToString()
        txtIdentidad.Text = dvgClientes(3, i).Value.ToString()
        txtDireccion.Text = dvgClientes(4, i).Value.ToString()
        txtTelefono.Text = dvgClientes(5, i).Value.ToString()

    End Sub

End Class