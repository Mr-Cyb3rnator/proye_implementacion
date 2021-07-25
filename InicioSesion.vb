Imports System.Data.SqlClient
Imports proye.Encriptacion
Public Class frmInicioSesion

    Dim nombreusuario As String


    Private Sub btncrear_Click(sender As Object, e As EventArgs) Handles btncrear.Click
        'Se hace la comprobacion de que el usuario existe y que tiene los privilegios para poder
        'tener acceso a la parte de administracion
        If (ComprobacionUsuario()) Then
            If (nivel = 1) Then
                Me.Hide()
                CrearUsuario.Show()
            Else
                MsgBox("No tiene los privilegios necesarios, ponganse en contacto con el ADMIN", MsgBoxResult.Ok)
            End If

        End If



    End Sub

    Private Sub btnentrar_Click(sender As Object, e As EventArgs) Handles btnentrar.Click

        'Se hace el llamado a la funcion que valida si existe o no el usuario en la BD
        If (ComprobacionUsuario()) Then
            frmMenu.lb_Usuario.Text = nombreusuario
            MessageBox.Show("BIENVENIDO AL SISTEMA")
            Me.Hide()
            frmMenu.Show()
        End If


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

    Private Function ComprobacionUsuario() As Integer
        Dim dr As SqlDataReader

        Dim estado As String
        Dim token As New Encriptacion()
        Dim cifrado As String
        Dim validacion As Boolean

        conecta()
        'Uso de la funcion encriptacion de la Clase Encriptacion, la clave de llave es "Implementacion"
        cifrado = token.encriptar128BitRijndael(txtpass.Text, "Implementacion")

        If (txtusu1.Text <> "") Then


            Try
                'Busqueda de que el usuario existe en la BD
                dr = LecturaBD("exec LecturaUsuarios_BD " & txtusu1.Text)
                estado = dr.Read

                'Comprobacion de que el Password introducido es el mismo que el BD
                If (estado) And (dr("Password") = cifrado) Then


                    nivel = dr("Nivel")
                    nombreusuario = dr("Usuario")
                    validacion = True

                Else
                    validacion = False
                    MsgBox("Usuario y/o Pass no existe y/o incorrecto")
                End If

            Catch ex As Exception
                MsgBox("Revisar conexion a BD y/o Procedimiento con sus parametros ingresados correctamente")
            End Try
        Else
            MsgBox("Campos no pueden quedar vacios")
        End If
        txtpass.Text = ""
        txtusu1.Text = ""
        CerrarConexion()

        Return validacion
    End Function

End Class
