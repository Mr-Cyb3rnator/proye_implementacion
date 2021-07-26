Imports System.Data.SqlClient
Public Class Grupos
    Private Sub cargargrid()

        conecta()

        dgvGrupos.DataSource = CargarDatosGrid("select cod_grupo as 'Codigo de grupo', numero_animales as 'Cantidad animales', cod_dieta as 'Dieta', fecha_inicial as 'Fecha de inicio', fecha_final as 'Fecha final', observaciones as 'Observaciones'  from grupos ")

        conectar.Close()


    End Sub
    Private Sub btagregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click




        If (txtNumAnimales.Text = "" And txtCodigoDieta.Text = "" And rtxtObs.Text = "") Then
            btnAgregar.Enabled = False
        End If

        conecta()
        Dim insertar_grupos As String = "insert into grupos(numero_animales,cod_dieta,fecha_inicial,fecha_final,observaciones) values(@nanimal,@cod_dieta,@fecha1,@fecha2,@obser)"
        Dim insertar_gr As New SqlCommand(insertar_grupos, conectar)
        insertar_gr.Parameters.AddWithValue("@cod_grup", txtCodGrup.Text)
        insertar_gr.Parameters.AddWithValue("@nanimal", txtNumAnimales.Text)
        insertar_gr.Parameters.AddWithValue("@cod_dieta", txtCodigoDieta.Text)
        insertar_gr.Parameters.AddWithValue("@fecha1", DTfechaini.Value.Date.ToString("yyyy-MM-dd"))
        insertar_gr.Parameters.AddWithValue("@fecha2", DTfechafin.Value.Date.ToString("yyyy-MM-dd"))
        insertar_gr.Parameters.AddWithValue("@obser", rtxtObs.Text)


        insertar_gr.ExecuteNonQuery()


        Dim recuperar_cod As String = "select top 1 cod_grupo from grupos order by cod_grupo desc"
        Dim recuperar As SqlDataReader
        Dim ejecutar As New SqlCommand

        ejecutar = New SqlCommand(recuperar_cod, conectar)
        recuperar = ejecutar.ExecuteReader

        Dim estado As String
        estado = recuperar.Read

        If (estado = True) Then

            txtCodGrup.Text = recuperar(0)


        Else

            txtCodGrup.Text = ""


        End If

        recuperar.Close()






        conectar.Close()
        cargargrid()
        MsgBox("Grupo creado satisfactoriamente ")




    End Sub

    Private Sub bteliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        conecta()
        Dim eliminar_gr As String = "delete from grupos where cod_grupo=@cod_gr "
        Dim procesar_gr As New SqlCommand(eliminar_gr, conectar)
        procesar_gr.Parameters.AddWithValue("@cod_gr", txtCodGrup.Text)
        procesar_gr.ExecuteNonQuery()
        conectar.Close()
        cargargrid()
        txtCodGrup.Clear()
        txtNumAnimales.Clear()
        txtCodigoDieta.Clear()

    End Sub

    Private Sub DGgrupos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGrupos.CellContentClick

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
        cargargrid()
<<<<<<< Updated upstream
=======

        txtcodgrup.Enabled = False
>>>>>>> Stashed changes

        DTfechaini.Value = Date.Now
        DTfechafin.Value = DTfechaini.Value.AddMonths(3)
        txtCodGrup.Enabled = False

        btnEdi.Enabled = False
        btnEliminar.Enabled = False
        btnAgregar.Enabled = False





    End Sub

    Private Sub btnedi_Click(sender As Object, e As EventArgs) Handles btnEdi.Click

        If ((DTfechaini.Value < Date.Now) And txtCodigoDieta.Text Is "" And rtxtObs.Text Is "") Then

            MsgBox("ERROR La fecha de inicio no puede ser menor de la fecha actual")
            If (rtxtObs.Text Is "") Then
                MsgBox("Ingrese una observacion ")
            End If


        Else

            conecta()

            ModificarBD("exec ActualizarGruposFormGrupos " & Val(txtCodGrup.Text) & "," & "'" & DTfechaini.Value.Date.ToString("yyyy-MM-dd") & "'" & "," & "'" & DTfechafin.Value.Date.ToString("yyyy-MM-dd") & "'" & "," & Val(txtCodigoDieta.Text) & "," & "'" & rtxtObs.Text & "'")

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

    Private Sub txtcodgrup_TextChanged(sender As Object, e As EventArgs) Handles txtCodGrup.TextChanged



    End Sub

    Private Sub txtnumanimales_TextChanged(sender As Object, e As EventArgs) Handles txtNumAnimales.TextChanged

        If (txtNumAnimales.Text = "") Then
            btnAgregar.Enabled = False
        End If

    End Sub

    Private Sub txtcodigodieta_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoDieta.TextChanged
        If (txtCodigoDieta.Text = "") Then
            btnAgregar.Enabled = False
        End If
    End Sub

    Private Sub rtxtobs_TextChanged(sender As Object, e As EventArgs) Handles rtxtObs.TextChanged
        btnAgregar.Enabled = True

        If (rtxtObs.Text = "") Then
            btnAgregar.Enabled = False
        End If

    End Sub

    Private Sub DTfechaini_ValueChanged(sender As Object, e As EventArgs) Handles DTfechaini.ValueChanged

        DTfechafin.Value = DTfechaini.Value.AddMonths(3)

    End Sub
End Class