Imports System.Data.SqlClient
Imports proye.Encriptacion
Public Class frm_InicioSesion



    Private Sub btncrear_Click(sender As Object, e As EventArgs) Handles btncrear.Click
        Me.Hide()
        CrearUsuario.Show()

    End Sub

    Private Sub btnentrar_Click(sender As Object, e As EventArgs) Handles btnentrar.Click
        Dim dr As SqlDataReader
        Dim nombreusuario As String
        Dim estado As String
        Dim token As New Encriptacion()
        Dim cifrado As String

        conecta()
        'Uso de la funcion encriptacion de la Clase Encriptacion, la clave de llave es "Implementacion"
        cifrado = token.encriptar128BitRijndael(txtpass.Text, "Implementacion")

        Try
            'Busqueda de que el usuario existe en la BD
            dr = LecturaBD("exec LecturaUsuarios_BD " & txtusu1.Text)
            estado = dr.Read

            'Comprobacion de que el Password introducido es el mismo que el BD
            If (estado) And (dr("Password") = cifrado) Then


                nivel = dr("Nivel")
                nombreusuario = dr("Usuario")
                frm_Menu.lb_Usuario.Text = nombreusuario
                MessageBox.Show("BIENVENIDO AL SISTEMA")
                Me.Hide()
                frm_Menu.Show()
            Else

                MsgBox("Usuario y/o Pass no existe y/o incorrecto")
            End If

        Catch ex As Exception
            MsgBox("Revisar conexion a BD y/o Procedimiento con sus parametros")
        End Try

        txtpass.Text = ""
        txtusu1.Text = ""

        CerrarConexion()

    End Sub


    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub txtusu1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtusu1.KeyPress

        CampoValidacionLetras(e)

    End Sub

    Private Sub frm_InicioSesion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MsgBox("Deseas terminar la aplicación?", vbYesNo) = vbYes Then
            End
        Else

            Me.Show()

        End If
    End Sub
End Class
