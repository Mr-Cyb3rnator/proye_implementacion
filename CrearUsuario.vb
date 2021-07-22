Imports System.Data.SqlClient
Public Class CrearUsuario
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click
        Dim token As New Encriptacion()
        Dim cifrado As String


        cifrado = token.encriptar128BitRijndael(txtcontra.Text, "Implementacion")
        conecta()
        Try
            ModificarBD("exec ActualizarUsuarios " & txtcod.Text & "," & txtusuario.Text & ",'" & cifrado & "'," & txttipo.Text)
            MsgBox("Datos del Usuario Actualizado Correctamente", MsgBoxResult.Ok, "Estado")
        Catch ex As Exception
            MsgBox("Revisar Conexion a la BD y/o Procedimiento junto a sus parametros")
        End Try
        CerrarConexion()

        RefrescarDataGrid()

        LimpiarCampos()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Guardar.Click
        Dim token As New Encriptacion()
        Dim cifrado As String


        cifrado = token.encriptar128BitRijndael(txtcontra.Text, "Implementacion")

        conecta()


        Try
            ModificarBD("exec Insertar_Usuarios " & txtcod.Text & "," & txtusuario.Text & ",'" & cifrado & "'," & txttipo.Text)
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Me.Close()
        frm_InicioSesion.Show()
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        conecta()

        Try
            ModificarBD("exec EliminarUsuarios " & txtcod.Text)
            MsgBox("Datos del Usuario Eliminados Correctamente", MsgBoxResult.Ok, "Estado")
        Catch ex As Exception
            MsgBox("Revisar Conexion a la BD y/o Procedimiento junto a sus parametros")
        End Try
        CerrarConexion()

        RefrescarDataGrid()
        LimpiarCampos()
    End Sub

    Private Sub LimpiarCampos()
        txtcod.Clear()
        txtusuario.Clear()
        txtcontra.Clear()
        txttipo.Clear()

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
    Private Sub txtusuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtusuario.KeyPress
        CampoValidacionLetras(e)

    End Sub


    Private Sub txttipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttipo.KeyPress
        CampoValidacionNumeros(e)

    End Sub

    Private Sub txtcontra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcontra.KeyPress
        CampoValidacionNumeros(e)
    End Sub

    Private Sub txtcod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcod.KeyPress
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