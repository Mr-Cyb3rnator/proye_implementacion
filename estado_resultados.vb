Imports System.Data.SqlClient

Public Class estado_resultados

    Public venta, costo_g, gastos_g As Integer

    Private Sub cargargrid_venta()

        Dim precio, libras As Integer

        '/// Esto Carga el detalle de la factura pero se pone bien lenta la pc si se ejecuata
        conecta()


        Dim cargar_datos_venta As String = "select cod_cliente,fecha,cantidad_libras,precio_libra,cod_grupo from venta_animales where cod_grupo=" & txtgrupo.Text
        Dim mostrar As New DataTable

        Using adpmostrar As New SqlDataAdapter(cargar_datos_venta, conectar)

            adpmostrar.Fill(mostrar)

        End Using
        DataGridView_venta.DataSource = mostrar




        Dim recuperar_total As String = "select cod_cliente,fecha,cantidad_libras,precio_libra,cod_grupo from venta_animales where cod_grupo=" & txtgrupo.Text
        Dim recuperar As SqlDataReader
        Dim ejecutar As New SqlCommand

        ejecutar = New SqlCommand(recuperar_total, conectar)
        recuperar = ejecutar.ExecuteReader

        Dim estado As String
        estado = recuperar.Read

        If (estado = True) Then

            libras = recuperar(2)
            precio = recuperar(3)




        Else




        End If

        txt_totalventa.Text = libras * precio

        venta = Val(txt_totalventa.Text)

        recuperar.Close()



        Dim recuperar_grupo As String = "select sum(precio_compra) from animales where cod_grupo=" & txtgrupo.Text
        Dim recuperar_g As SqlDataReader
        Dim ejecutar_g As New SqlCommand

        ejecutar_g = New SqlCommand(recuperar_grupo, conectar)
        recuperar_g = ejecutar_g.ExecuteReader

        Dim estado_g As String
        estado_g = recuperar_g.Read

        If (estado = True) Then

            txt_costo_compra.Text = recuperar_g(0)



        Else




        End If

        recuperar.Close()








        conectar.Close()





    End Sub


    Private Sub cargargrid_detalle()

        '/// Esto Carga el detalle de la factura pero se pone bien lenta la pc si se ejecuata
        conecta()


        Dim cargar_datos_detalle As String = "select  cod_detalle_gastos,b.cod_gastos,cod_ingrediente,cantidad,precio,subtotal from detalle_gastos a join  gastos b on a.cod_gastos = b.cod_gastos where cod_grupo=" & txtgrupo.Text
        Dim mostrar As New DataTable

        Using adpmostrar As New SqlDataAdapter(cargar_datos_detalle, conectar)

            adpmostrar.Fill(mostrar)

        End Using
        DataGridView1.DataSource = mostrar

        conectar.Close()





    End Sub



    Private Sub cargargrid_grupo()

        '/// Esto Carga el detalle de la factura pero se pone bien lenta la pc si se ejecuata
        conecta()


        Dim cargar_datos_detalle As String = "select cod_animal,peso_4,precio_compra from animales where cod_grupo=" & txtgrupo.Text
        Dim mostrar As New DataTable

        Using adpmostrar As New SqlDataAdapter(cargar_datos_detalle, conectar)

            adpmostrar.Fill(mostrar)

        End Using
        DataGridView_animales.DataSource = mostrar

        conectar.Close()





    End Sub


    Private Sub cargar_gasto_total()

        conecta()

        Dim recuperar_total As String = "select sum(subtotal) from detalle_gastos a join  gastos b on a.cod_gastos = b.cod_gastos where cod_grupo=" & txtgrupo.Text
        Dim recuperar As SqlDataReader
        Dim ejecutar As New SqlCommand

        ejecutar = New SqlCommand(recuperar_total, conectar)
        recuperar = ejecutar.ExecuteReader

        Dim estado As String
        estado = recuperar.Read

        If (estado = True) Then

            txt_total_gastos.Text = recuperar(0)



        Else




        End If

        gastos_g = Val(txt_total_gastos.Text)

        recuperar.Close()

        conectar.Close()


    End Sub



    Private Sub estado_resultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnatras_Click(sender As Object, e As EventArgs) 
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub btcalcular_Click(sender As Object, e As EventArgs) Handles btcalcular.Click
        txtganacia.Text = Val(txt_totalventa.Text) - Val(txt_total_gastos.Text) - Val(txt_costo_compra.Text)
    End Sub

    Private Sub txtgrupo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtgrupo.KeyPress
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

    Private Sub txt_cod_gastos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cod_gastos.KeyPress
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

    Private Sub txtcod_venta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcod_venta.KeyPress
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

    Private Sub txt_total_gastos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_total_gastos.KeyPress
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

    Private Sub txt_totalventa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_totalventa.KeyPress
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

    Private Sub txt_costo_compra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_costo_compra.KeyPress
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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub btcargar_gastos_Click(sender As Object, e As EventArgs) Handles btcargar_gastos.Click

        cargar_gasto_total()
        cargargrid_detalle()
        cargargrid_grupo()








    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btcargar_venta.Click

        cargargrid_venta()



    End Sub
End Class