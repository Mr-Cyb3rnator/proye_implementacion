Imports System.Data.SqlClient
Public Class Grupos
    Private Sub cargargrid()

        conecta()
        Dim cargar_datos_grupos As String = "select * from grupos "
        Dim mostrar As New DataTable

        Using adpmostrar As New SqlDataAdapter(cargar_datos_grupos, conectar)

            adpmostrar.Fill(mostrar)

        End Using
        DGgrupos.DataSource = mostrar
        conectar.Close()


    End Sub
    Private Sub btagregar_Click(sender As Object, e As EventArgs) Handles btagregar.Click




        If (txtnumanimales.Text = "" And txtcodigodieta.Text = "" And rtxtobs.Text = "") Then
            btagregar.Enabled = False
        End If

        conecta()
        Dim insertar_grupos As String = "insert into grupos(numero_animales,cod_dieta,fecha_inicial,fecha_final,observaciones) values(@nanimal,@cod_dieta,@fecha1,@fecha2,@obser)"
        Dim insertar_gr As New SqlCommand(insertar_grupos, conectar)
        insertar_gr.Parameters.AddWithValue("@cod_grup", txtcodgrup.Text)
        insertar_gr.Parameters.AddWithValue("@nanimal", txtnumanimales.Text)
        insertar_gr.Parameters.AddWithValue("@cod_dieta", txtcodigodieta.Text)
        insertar_gr.Parameters.AddWithValue("@fecha1", DTfechaini.Value)
        insertar_gr.Parameters.AddWithValue("@fecha2", DTfechafin.Value)
        insertar_gr.Parameters.AddWithValue("@obser", rtxtobs.Text)

        insertar_gr.ExecuteNonQuery()


        Dim recuperar_cod As String = "select top 1 cod_grupo from grupos order by cod_grupo desc"
        Dim recuperar As SqlDataReader
        Dim ejecutar As New SqlCommand

        ejecutar = New SqlCommand(recuperar_cod, conectar)
        recuperar = ejecutar.ExecuteReader

        Dim estado As String
        estado = recuperar.Read

        If (estado = True) Then

            txtcodgrup.Text = recuperar(0)


        Else

            txtcodgrup.Text = ""


        End If

        recuperar.Close()






        conectar.Close()
        cargargrid()
        MsgBox("Grupo creado satisfactoriamente ")




    End Sub

    Private Sub bteliminar_Click(sender As Object, e As EventArgs) Handles bteliminar.Click
        conecta()
        Dim eliminar_gr As String = "delete from grupos where cod_grupo=@cod_gr "
        Dim procesar_gr As New SqlCommand(eliminar_gr, conectar)
        procesar_gr.Parameters.AddWithValue("@cod_gr", txtcodgrup.Text)
        procesar_gr.ExecuteNonQuery()
        conectar.Close()
        cargargrid()
    End Sub

    Private Sub DGgrupos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGgrupos.CellContentClick


        conecta()
        Dim fila_actual As Integer
        fila_actual = DGgrupos.CurrentRow.Index
        txtcodgrup.Text = DGgrupos.Rows(fila_actual).Cells(0).Value
        'txtcodgrup.Text = DGgrupos.CurrentRow.Cells(0).Value
        Dim recuperar As String = "select * from grupos where cod_grupo=" & txtcodgrup.Text
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
            Else

                DTfechaini.Value = mostrar(3)

            End If


            If IsDBNull(mostrar(2)) Then

                MsgBox("este grupo no tiene dieta ")
                txtcodigodieta.Text = ""
            Else

                txtcodigodieta.Text = mostrar(2)

            End If



            txtnumanimales.Text = mostrar(1)


            'txtcodigodieta.Text = mostrar(2)
            'rtxtobs.Text = mostrar(5)



        Else

            txtnumanimales.Text = ""
            txtcodigodieta.Text = ""
            rtxtobs.Text = ""


        End If

        mostrar.Close()
        conectar.Close()
        btnedi.Enabled = True
        bteliminar.Enabled = True


    End Sub

    Private Sub btnatras_Click(sender As Object, e As EventArgs) Handles btnatras.Click
        Me.Close()
        frmMenu.Show()
    End Sub

    Private Sub Grupos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargargrid()

        DTfechaini.Value = Date.Now
        txtcodgrup.Enabled = False

        btnedi.Enabled = False
        bteliminar.Enabled = False
        btagregar.Enabled = False





    End Sub

    Private Sub btnedi_Click(sender As Object, e As EventArgs) Handles btnedi.Click

        If ((DTfechafin.Value <= DTfechaini.Value) And txtcodigodieta.Text Is "") Then

            MsgBox("ERROR La fecha Final no puede ser la misma que la de inicio")

        Else

            conecta()

            Dim datos As String = "update grupos set numero_animales=@nanimal,fecha_inicial=@fecha1,fecha_final=@fecha2,cod_dieta=@dieta,observaciones=@obser where cod_grupo=@cod_gr "
            Dim actualizar As New SqlCommand(datos, conectar)
            actualizar.Parameters.AddWithValue("@cod_gr", txtcodgrup.Text)
            actualizar.Parameters.AddWithValue("@nanimal", txtnumanimales.Text)
            actualizar.Parameters.AddWithValue("@fecha1", DTfechaini.Value)
            actualizar.Parameters.AddWithValue("@fecha2", DTfechafin.Value)
            actualizar.Parameters.AddWithValue("@obser", rtxtobs.Text)
            actualizar.Parameters.AddWithValue("@dieta", txtcodigodieta.Text)

            actualizar.ExecuteNonQuery()
            conectar.Close()
            cargargrid()


        End If
    End Sub

    Private Sub txtcodgrup_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodgrup.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txtnumanimales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumanimales.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txtcodigodieta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodigodieta.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txtcodgrup_TextChanged(sender As Object, e As EventArgs) Handles txtcodgrup.TextChanged



    End Sub

    Private Sub txtnumanimales_TextChanged(sender As Object, e As EventArgs) Handles txtnumanimales.TextChanged

        'btagregar.Enabled = True

        If (txtnumanimales.Text = "") Then
            btagregar.Enabled = False
        End If

    End Sub

    Private Sub txtcodigodieta_TextChanged(sender As Object, e As EventArgs) Handles txtcodigodieta.TextChanged
        'btagregar.Enabled = True

        If (txtcodigodieta.Text = "") Then
            btagregar.Enabled = False
        End If
    End Sub

    Private Sub rtxtobs_TextChanged(sender As Object, e As EventArgs) Handles rtxtobs.TextChanged
        btagregar.Enabled = True

        If (rtxtobs.Text = "") Then
            btagregar.Enabled = False
        End If

    End Sub
End Class