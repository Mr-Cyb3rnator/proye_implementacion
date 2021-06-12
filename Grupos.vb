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
        conecta()
        Dim insertar_grupos As String = "insert into grupos(cod_grupo,numero_animales,cod_dieta,fecha_inicial,fecha_final,observaciones) values(@cod_grup,@nanimal,@cod_dieta,@fecha1,@fecha2,@obser)"
        Dim insertar_gr As New SqlCommand(insertar_grupos, conectar)
        insertar_gr.Parameters.AddWithValue("@cod_grup", txtcodgrup.Text)
        insertar_gr.Parameters.AddWithValue("@nanimal", txtnumanimales.Text)
        insertar_gr.Parameters.AddWithValue("@cod_dieta", txtcodigodieta.Text)
        insertar_gr.Parameters.AddWithValue("@fecha1", DTfechaini.Value)
        insertar_gr.Parameters.AddWithValue("@fecha2", DTfechaini.Value)
        insertar_gr.Parameters.AddWithValue("@obser", rtxtobs.Text)

        insertar_gr.ExecuteNonQuery()



        conectar.Close()
        cargargrid()

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

    End Sub

    Private Sub btnatras_Click(sender As Object, e As EventArgs) Handles btnatras.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Grupos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargargrid()

    End Sub

    Private Sub btnedi_Click(sender As Object, e As EventArgs) Handles btnedi.Click
        conecta()

        Dim datos As String = "update grupos set numero_animales=@nanimal,cod_dieta=@dieta,observaciones=@obser where cod_grupo=@cod_gr "
        Dim actualizar As New SqlCommand(datos, conectar)
        actualizar.Parameters.AddWithValue("@cod_gr", txtcodgrup.Text)
        actualizar.Parameters.AddWithValue("@nanimal", txtnumanimales.Text)
        actualizar.Parameters.AddWithValue("@obser", rtxtobs.Text)
        actualizar.Parameters.AddWithValue("@dieta", txtcodigodieta.Text)

        actualizar.ExecuteNonQuery()
        conectar.Close()
        cargargrid()
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
End Class