Imports System.Data.SqlClient
Public Class CrearUsuario
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Dim token As New Encriptacion()
        Dim cifrado As String


        cifrado = token.encriptar128BitRijndael(txtContra.Text, "Implementacion")
        conecta()
        Try
            ModificarBD("exec ActualizarUsuarios " & txtCodigo.Text & "," & txtUsuario.Text & ",'" & cifrado & "'," & txtTipo.Text)
            MsgBox("Datos del Usuario Actualizado Correctamente", MsgBoxResult.Ok, "Estado")
        Catch ex As Exception
            MsgBox("Revisar Conexion a la BD y/o Procedimiento junto a sus parametros")
        End Try
        CerrarConexion()

        RefrescarDataGrid()

        LimpiarCampos()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim token As New Encriptacion()
        Dim cifrado As String


        cifrado = token.encriptar128BitRijndael(txtContra.Text, "Implementacion")

        conecta()


        Try
            ModificarBD("exec Insertar_Usuarios " & txtCodigo.Text & "," & txtUsuario.Text & ",'" & cifrado & "'," & txtTipo.Text)

            MsgBox("Datos del Usuario Ingresados Correctamente", MsgBoxResult.Ok, "Estado")
        Catch ex As Exception
            MsgBox("Revisar Conexion a la BD y/o Procedimiento junto a sus parametros")
        End Try
        CerrarConexion()
        RefrescarDataGrid()



        LimpiarCampos()

    End Sub

    Private Sub crearusuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RefrescarDataGrid()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        frm_InicioSesion.Show()
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        conecta()

        Try
            ModificarBD("exec EliminarUsuarios " & txtCodigo.Text)
            MsgBox("Datos del Usuario Eliminados Correctamente", MsgBoxResult.Ok, "Estado")
        Catch ex As Exception
            MsgBox("Revisar Conexion a la BD y/o Procedimiento junto a sus parametros")
        End Try
        CerrarConexion()

        RefrescarDataGrid()
        LimpiarCampos()
    End Sub

    Private Sub LimpiarCampos()
        txtCodigo.Clear()
        txtUsuario.Clear()
        txtContra.Clear()
        txtTipo.Clear()

    End Sub


    Private Sub RefrescarDataGrid()
        Dim datousuario As New DataTable
        conecta()
        Try
            datousuario = CargarDatosGrid("exec Lista_Usuarios")
            dtgcrear.DataSource = datousuario
        Catch ex As Exception
            MsgBox("Revisar Conexion a la BD y/o Procedimiento junto a sus parametros")
        End Try

        CerrarConexion()
    End Sub

#Region "Validaciones"
    Private Sub txtusuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuario.KeyPress
        CampoValidacionLetras(e)

    End Sub


    Private Sub txttipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTipo.KeyPress
        CampoValidacionNumeros(e)

    End Sub



    Private Sub txtcod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        CampoValidacionNumeros(e)
    End Sub

    Private Sub CrearUsuario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MsgBox("Deseas terminar la aplicación?", vbYesNo Or vbQuestion) = vbYes Then
            End
        Else

            Me.Show()
        End If
    End Sub


#End Region


End Class