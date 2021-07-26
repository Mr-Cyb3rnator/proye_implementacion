Imports System.Data.SqlClient
Public Class Grupos
    'Todos los procesos que entran en contacto con la base de datos usan procediminetos almacenados para efectuarse
    Private Sub cargargrid()


        conecta()
        Try
            dgvGrupos.DataSource = CargarDatosGrid("select cod_grupo as 'Codigo de grupo', numero_animales as 'Cantidad animales', cod_dieta as 'Dieta', fecha_inicial as 'Fecha de inicio', fecha_final as 'Fecha final', observaciones as 'Observaciones'  from grupos ")
        Catch ex As Exception
            MsgBox("Revisar Conexion BD ")
        End Try
        conectar.Close()


    End Sub

    Private Sub bteliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        conecta()

        Try
            ModificarBD("exec EliminarGrupo " & txtCodGrup.Text)
        Catch ex As Exception
            MsgBox("Error en la BD y/o Revisar Campos de grupo ")
        End Try

        conectar.Close()
        cargargrid()
        txtCodGrup.Clear()
        txtNumAnimales.Clear()
        txtCodigoDieta.Clear()

    End Sub

    Private Sub DGgrupos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGrupos.CellContentClick

        ' este evento rellena de forma automatica los campos para  evitar  escribirlos de forma manual 
        conecta()
        Dim filaActual As Integer
        filaActual = dgvGrupos.CurrentRow.Index
        txtCodGrup.Text = dgvGrupos.Rows(filaActual).Cells(0).Value
        ModificarBD("exec ActualizarCantidadAnimales " & Val(txtCodGrup.Text))
        dgvGrupos.DataSource = CargarDatosGrid("select cod_grupo as 'Codigo de grupo', numero_animales as 'Cantidad animales', cod_dieta as 'Dieta', fecha_inicial as 'Fecha de inicio', fecha_final as 'Fecha final', observaciones as 'Observaciones'  from grupos ")
        Dim recuperar As String = "select * from grupos where cod_grupo=" & txtCodGrup.Text
        Dim mostrar As SqlDataReader
        Dim ejecutar As New SqlCommand

        ejecutar = New SqlCommand(recuperar, conectar)
        mostrar = ejecutar.ExecuteReader

        Dim estado As String

        estado = mostrar.Read

        If (estado = True) Then

            If IsDBNull(mostrar(4)) Then

                MsgBox("este grupo no tiene fecha final de engorde")

                DTfechafin.Value = Date.Now
            Else

                DTfechafin.Value = mostrar(4)

            End If


            If IsDBNull(mostrar(3)) Then

                MsgBox("este grupo no tiene fecha inicial de engorde")
                DTfechaini.Value = Date.Now
                DTfechaini.Enabled = True
            Else

                DTfechaini.Value = mostrar(3)
                DTfechaini.Enabled = False

            End If


            If IsDBNull(mostrar(2)) Then

                MsgBox("este grupo no tiene dieta ")
                txtCodigoDieta.Text = ""
            Else

                txtCodigoDieta.Text = mostrar(2)

            End If

            If IsDBNull(mostrar(5)) Then

                MsgBox("este grupo no observaciones ")
                rtxtObs.Text = ""
            Else

                rtxtObs.Text = mostrar(5)

            End If

            txtNumAnimales.Text = mostrar(1)



        Else

            txtNumAnimales.Text = ""
            txtCodigoDieta.Text = ""
            rtxtObs.Text = ""

        End If

        mostrar.Close()

        conectar.Close()
        btnEdi.Enabled = True
        btnEliminar.Enabled = True

    End Sub

    Private Sub btnatras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Close()
        frmMenu.Show()
    End Sub

    Private Sub Grupos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'este bloque se encarga de poner las fechas adecuadas para el proceso de engorde
        cargargrid()

        DTfechaini.Value = Date.Now
        DTfechafin.Value = DTfechaini.Value.AddMonths(3)
        txtCodGrup.Enabled = False

        btnEdi.Enabled = False
        btnEliminar.Enabled = False
        btnAgregar.Enabled = False


    End Sub

    Private Sub btnedi_Click(sender As Object, e As EventArgs) Handles btnEdi.Click

        'validacion de campos para editar para evitar  campos en blanco
        If ((DTfechaini.Value < Date.Now) And txtCodigoDieta.Text Is "" And rtxtObs.Text Is "") Then

            MsgBox("ERROR La fecha de inicio no puede ser menor de la fecha actual o faltan parametros")
            If (rtxtObs.Text Is "") Then
                MsgBox("Ingrese una observacion ")
            End If

        Else

            conecta()

            Try

                ModificarBD("exec ActualizarGruposFormGrupos " & Val(txtCodGrup.Text) & "," & "'" & DTfechaini.Value.Date.ToString("yyyy-MM-dd") & "'" & "," & "'" & DTfechafin.Value.Date.ToString("yyyy-MM-dd") & "'" & "," & Val(txtCodigoDieta.Text) & "," & "'" & rtxtObs.Text & "'")
            Catch ex As Exception
                MsgBox("Erros en la BD y/o con los parametros necesarios ")
            End Try

            conectar.Close()
            cargargrid()

        End If
    End Sub

    Private Sub txtcodgrup_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodGrup.KeyPress

        CampoValidacionNumeros(e)

    End Sub

    Private Sub txtnumanimales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumAnimales.KeyPress

        CampoValidacionNumeros(e)

    End Sub

    Private Sub txtcodigodieta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoDieta.KeyPress

        CampoValidacionNumeros(e)

    End Sub


    Private Sub DTfechaini_ValueChanged(sender As Object, e As EventArgs) Handles DTfechaini.ValueChanged

        DTfechafin.Value = DTfechaini.Value.AddMonths(3)

    End Sub
End Class