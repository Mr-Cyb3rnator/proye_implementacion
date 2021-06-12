Imports System.Data.SqlClient
Public Class VentaGanado


    Private Sub cargargrid_grupo()

        '/// Esto Carga el detalle de la factura 
        conecta()


        Dim cargar_datos_detalle As String = "select  cod_animal,peso_4  from animales where cod_grupo =" & txtcodgrupo.Text
        Dim mostrar As New DataTable

        Using adpmostrar As New SqlDataAdapter(cargar_datos_detalle, conectar)

            adpmostrar.Fill(mostrar)

        End Using
        dgventaganado.DataSource = mostrar

        conectar.Close()





    End Sub



    Private Sub cargar_peso_total()

        conecta()

        Dim recuperar_total As String = "select sum(peso_4) from animales where cod_grupo =" & txtcodgrupo.Text
        Dim recuperar As SqlDataReader
        Dim ejecutar As New SqlCommand

        ejecutar = New SqlCommand(recuperar_total, conectar)
        recuperar = ejecutar.ExecuteReader

        Dim estado As String
        estado = recuperar.Read

        If (estado = True) Then

            txtlibras_totales.Text = recuperar(0)



        Else




        End If

        recuperar.Close()

        conectar.Close()


    End Sub



    Private Sub VentaGanado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'dgventaganado.Columns.Add("Cod.Venta", "Cod.Venta")
        'dgventaganado.Columns.Add("Cod.Cliente", "Cod.Cliente")
        'dgventaganado.Columns.Add("Cod.Animal", "Cod.Animal")
        'dgventaganado.Columns.Add("Cod.Grupo", "Cod.Grupo")
        'dgventaganado.Columns.Add("Costo", "Costo")
        'dgventaganado.Columns.Add("Fecha", "Fecha")


    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click

        Dim estado As String

        estado = "vendido"

        conecta()
        Dim datosfactura_venta As String = "insert into venta_animales(cod_cliente,fecha,cantidad_libras,precio_libra,cod_grupo)values(@cod_cliente,@fecha,@cantidad_libras,@precio_libra,@cod_grupo)"
        Dim registrar As New SqlCommand(datosfactura_venta, conectar)
        registrar.Parameters.AddWithValue("@cod_cliente", txtcodcliente.Text)
        registrar.Parameters.AddWithValue("@fecha", dtpfecha.Value)
        registrar.Parameters.AddWithValue("@cantidad_libras", txtlibras_totales.Text)
        registrar.Parameters.AddWithValue("@precio_libra", txt_preciolibra.Text)
        registrar.Parameters.AddWithValue("@cod_grupo", txtcodgrupo.Text)

        registrar.ExecuteNonQuery()

        Dim actualizar_estado As String = "update animales set estado=@estado where cod_grupo= " & txtcodgrupo.Text
        Dim registrar_estado As New SqlCommand(actualizar_estado, conectar)
        registrar_estado.Parameters.AddWithValue("@cod_grupo", txtcodgrupo.Text)
        registrar_estado.Parameters.AddWithValue("@estado", estado)
        registrar_estado.ExecuteNonQuery()




        conectar.Close()

        'dgventaganado.Rows.Add(txtcodventa.Text, txtcodcliente.Text, txtcodanimal.Text, txtcodgrupo.Text, Val(txt_preciolibra.Text), dtpfecha.Text)
        'txtcodventa.Text = ""
        'txtcodcliente.Text = ""
        'txtcodanimal.Text = ""
        'txtcodgrupo.Text = ""
        'txt_preciolibra.Text = ""
    End Sub

    Private Sub dgventaganado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgventaganado.CellContentClick
        'Dim row As DataGridViewRow = dgventaganado.CurrentRow
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btcargar_grupo.Click
        'dgventaganado.Rows.Remove(dgventaganado.CurrentRow)
        Dim total_venta As Integer

        cargar_peso_total()
        cargargrid_grupo()

        total_venta = Val(txtlibras_totales.Text) * Val(txt_preciolibra.Text)
        txttotalventa.Text = total_venta





    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnatras.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub txtcodventa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodventa.KeyPress
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

    Private Sub txtcodcliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodcliente.KeyPress
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

    Private Sub txtcodgrupo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodgrupo.KeyPress
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

    Private Sub txtlibras_totales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtlibras_totales.KeyPress
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

    Private Sub txt_preciolibra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_preciolibra.KeyPress
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

    Private Sub txttotalventa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttotalventa.KeyPress
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