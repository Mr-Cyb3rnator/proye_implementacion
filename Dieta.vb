Imports System.Data.SqlClient
Public Class Dieta

    Private Sub cargargrid()

        conecta()
        Dim cargar_datos_clientes As String = "select * from dieta "
        Dim mostrar As New DataTable

        Using adpmostrar As New SqlDataAdapter(cargar_datos_clientes, conectar)

            adpmostrar.Fill(mostrar)

        End Using
        dgdieta.DataSource = mostrar
        conectar.Close()


    End Sub

    Private Sub cargargrid_dieta()

        conecta()

        Dim cod_dieta As Integer

        cod_dieta = Val(txtcoddieta.Text)
        Dim cargar_datos As String = "select descripcion,costo from ingredientes where cod_dieta=" & Val(txtcoddieta.Text)
        Dim mostrar As New DataTable

        Using adpmostrar As New SqlDataAdapter(cargar_datos, conectar)

            adpmostrar.Fill(mostrar)

        End Using
        dgingredientes_dieta.DataSource = mostrar
        conectar.Close()


    End Sub


    Private Sub Dieta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargargrid()


        'dgdieta.Columns.Add("Cod.Dieta", "Cod.Dieta")
        'dgdieta.Columns.Add("Cod.Ingredientes", "Cod.Ingredientes")
        'dgdieta.Columns.Add("Cantidad", "Cantidad")
        'dgdieta.Columns.Add("Comidas por dia", "Comidas_por_dia")
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click



        conecta()
        Dim insertar_dieta As String = "insert into dieta(cod_dieta,cantidad_libras,comidas_al_dia)values(@cod_dieta,@cantidad_libras,@comidas_al_dia)"
        Dim insertar As New SqlCommand(insertar_dieta, conectar)
        insertar.Parameters.AddWithValue("@cod_dieta", txtcoddieta.Text)
        insertar.Parameters.AddWithValue("@cantidad_libras", txtcantidad.Text)
        insertar.Parameters.AddWithValue("@comidas_al_dia", txtcomidaxdia.Text)

        insertar.ExecuteNonQuery()



        conectar.Close()
        cargargrid()






        'dgdieta.Rows.Add(txtcoddieta.Text, txtcodingre.Text, Val(txtcantidad.Text), Val(txtcomidaxdia.Text))
        'txtcantidad.Text = ""
        'txtcoddieta.Text = ""
        'txtcodingre.Text = ""
        'txtcomidaxdia.Text = ""
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        dgdieta.Rows.Remove(dgdieta.CurrentRow)
    End Sub

    Private Sub dgdieta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgdieta.CellContentClick
        Dim row As DataGridViewRow = dgdieta.CurrentRow
    End Sub

    Private Sub btnatras_Click(sender As Object, e As EventArgs) Handles btnatras.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub txtcoddieta_TextChanged(sender As Object, e As EventArgs) Handles txtcoddieta.TextChanged



        conecta()




        Dim recuperar As String = "select * from dieta where cod_dieta=' " & txtcoddieta.Text & " ' "
        Dim mostrar As SqlDataReader
        Dim ejecutar As New SqlCommand

        ejecutar = New SqlCommand(recuperar, conectar)
        mostrar = ejecutar.ExecuteReader

        Dim estado As String



        estado = mostrar.Read

        If (estado = True) Then

            txtcantidad.Text = mostrar(1)
            txtcomidaxdia.Text = mostrar(2)




        Else

            txtcantidad.Text = ""
            txtcomidaxdia.Text = ""



        End If

        mostrar.Close()
        conectar.Close()



    End Sub

    Private Sub btagregar_Click(sender As Object, e As EventArgs) Handles btagregar.Click


        conecta()

        Dim datos As String = "update ingredientes set cod_dieta=@cod_dieta where cod_ingredientes=@cod_ingredientes "
        Dim actualizar As New SqlCommand(datos, conectar)
        actualizar.Parameters.AddWithValue("@cod_ingredientes", txtcodingre.Text)
        actualizar.Parameters.AddWithValue("@cod_dieta", txtcoddieta.Text)

        actualizar.ExecuteNonQuery()
        conectar.Close()
        cargargrid_dieta()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btselecionar_dierta.Click

        cargargrid_dieta()

    End Sub

    Private Sub txtcoddieta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcoddieta.KeyPress
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

    Private Sub txtcodingre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodingre.KeyPress
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

    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
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

    Private Sub txtcomidaxdia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcomidaxdia.KeyPress
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
