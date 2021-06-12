Imports System.Data.SqlClient

Public Class Gasto

    Dim totald As Integer

    Public Sub cargar_combo()

        Try
            cn.Open()
            sql = "select  * from ingredientes "
            adt = New SqlDataAdapter(sql, cn)
            ds = New DataSet
            adt.Fill(ds)

        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnatras_Click(sender As Object, e As EventArgs) Handles btnatras.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Gasto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '/////////////////////////////////// Esto Llena el ComboBox de ingredientes



    End Sub

    Private Sub btcrear_Click(sender As Object, e As EventArgs) Handles btcrear.Click
        Dim codigofactura As Integer

        conecta()
        Dim datos_gasto As String = "insert into gastos(cod_grupo,fecha)values(@cod_grupo,@fecha)"
        Dim registrar_gasto As New SqlCommand(datos_gasto, conectar)
        registrar_gasto.Parameters.AddWithValue("@cod_grupo", txtgrupo.Text)
        registrar_gasto.Parameters.AddWithValue("@fecha", dt_fecha.Value)
        registrar_gasto.ExecuteNonQuery()


        Dim recuperar_cod As String = "select top 1 cod_gastos from gastos order by cod_gastos desc"
        Dim recuperar As SqlDataReader
        Dim ejecutar As New SqlCommand

        ejecutar = New SqlCommand(recuperar_cod, conectar)
        recuperar = ejecutar.ExecuteReader

        Dim estado As String
        estado = recuperar.Read

        If (estado = True) Then

            txtgasto.Text = recuperar(0)



        Else




        End If

        recuperar.Close()


        codigofactura = Val(txtgasto.Text)

        Dim datosfacturad As String = "insert into detalle_gastos(cod_gastos,cod_ingrediente,cantidad,precio, subtotal) values(@cod_gastos,@cod_ingrediente,@cantidad,@precio, @subtotal)"
        Dim registrard As New SqlCommand(datosfacturad, conectar)

        Dim fila As DataGridViewRow = New DataGridViewRow()

        For Each fila In DataGridView1.Rows

            registrard.Parameters.Clear()
            'registrard.Parameters.AddWithValue("@cod_detalle_gastos", txtgasto.Text)
            registrard.Parameters.AddWithValue("@cod_gastos", txtgasto.Text)
            registrard.Parameters.AddWithValue("@cod_ingrediente", fila.Cells("ccodigo").Value)
            registrard.Parameters.AddWithValue("@cantidad", fila.Cells("ccantidad").Value)
            registrard.Parameters.AddWithValue("@precio", fila.Cells("cprecio").Value)
            registrard.Parameters.AddWithValue("@subtotal", fila.Cells("csubtotal").Value)
            registrard.ExecuteNonQuery()




        Next



        'Dim datos_detalle_gastos As String = "insert into detalle_gastos(cod_gastos,cod_ingrediente,cantidad,precio,subtotal) values(@cod_gastos,@cod_ingrediente,@cantidad,@precio,@subtotal)"
        'Dim registrar_de As New SqlCommand(datos_detalle_gastos, conectar)

        'Dim fila As DataGridViewRow = New DataGridViewRow()

        'For Each fila In DataGridView1.Rows

        '    registrar_de.Parameters.Clear()
        '    registrar_de.Parameters.AddWithValue("@cod_gastos", txtgasto.Text)
        '    registrar_de.Parameters.AddWithValue("@cod_ingrediente", fila.Cells("ccodigo").Value)
        '    registrar_de.Parameters.AddWithValue("@cantidad", fila.Cells("ccantidad").Value)
        '    registrar_de.Parameters.AddWithValue("@precio", fila.Cells("cprecio").Value)
        '    registrar_de.Parameters.AddWithValue("@subtotal", fila.Cells("csubtotal").Value)
        '    registrar_de.ExecuteNonQuery()




        'Next

        codigofactura = Val(txtgasto.Text)


        'datos_factura_venta.cod_fact = codigofactura

        conectar.Close()
        DataGridView1.Rows.Clear()

        'Dim fac As New factura()
        'fac.Show()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btagregar.Click

        Dim subtotal As Integer

        subtotal = Val(txtprecio.Text) * Val(txtcantidad.Text)

        'cod_detalle_gastos,cod_gastos,cod_ingrediente,cantidad,precio, subtotal

        DataGridView1.Rows.Add(txtcod_ingre.Text, txtcantidad.Text, txtprecio.Text, subtotal)
        totald = totald + subtotal
        txttotal.Text = totald
        txtcod_ingre.Text = ComboBox1.SelectedIndex
        txtcantidad.Clear()
        txtprecio.Clear()

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtcod_ingre.TextChanged


        conecta()
        Dim recuperar_ingrediente As String = "select * from ingredientes where cod_ingredientes= " & txtcod_ingre.Text
        Dim mostrar_ingre As SqlDataReader
        Dim ejecutar As New SqlCommand

        ejecutar = New SqlCommand(recuperar_ingrediente, conectar)
        mostrar_ingre = ejecutar.ExecuteReader

        Dim estado As String
        estado = mostrar_ingre.Read

        If (estado = True) Then

            txtprecio.Text = mostrar_ingre(2)



        Else




        End If


        mostrar_ingre.Close()

        conectar.Close()



    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        txtcod_ingre.Text = ComboBox1.SelectedIndex


        'conecta()
        'Dim recuperar_ingrediente As String = "select * from ingredientes where cod_ingredientes= " & txtcod_ingre.Text
        'Dim mostrar_ingre As SqlDataReader
        'Dim ejecutar As New SqlCommand

        'ejecutar = New SqlCommand(recuperar_ingrediente, conectar)
        'mostrar_ingre = ejecutar.ExecuteReader

        'Dim estado As String
        'estado = mostrar_ingre.Read

        'If (estado = True) Then

        '    txtprecio.Text = mostrar_ingre(2)



        'Else

        '    'txtnombre_empleado.Text = ""


        'End If


        'mostrar_ingre.Close()

        'conectar.Close()

    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click

        cargar_combo()
        Try
            ComboBox1.DataSource = ds.Tables(0)
            ComboBox1.DisplayMember = "descripcion"
            ComboBox1.SelectedIndex = "cod_ingredientes"

        Catch ex As Exception

        End Try


        'conecta()
        'Dim recuperar_ingrediente_combo As String = "select * from ingredientes"
        'Dim adaptador_combo As SqlDataAdapter
        'Dim datos_combo As DataSet


        'adaptador_combo = New System.Data.SqlClient.SqlDataAdapter(recuperar_ingrediente_combo, conectar)
        'datos_combo = New DataSet

        'adaptador_combo.Fill(datos_combo)

        'ComboBox1.DataSource = datos_combo.Tables(0)
        'ComboBox1.DisplayMember = "descripcion"
        'ComboBox1.ValueMember = "cod_ingredientes"



        'conectar.Close()



    End Sub

    Private Sub btcargar_Click(sender As Object, e As EventArgs) Handles btcargar.Click

        conecta()
        Dim recuperar_factura As String = "select * from gastos where cod_gastos= " & txtgasto.Text
        Dim mostrar_factura As SqlDataReader
        Dim ejecutar As New SqlCommand

        ejecutar = New SqlCommand(recuperar_factura, conectar)
        mostrar_factura = ejecutar.ExecuteReader

        Dim estado As String
        estado = mostrar_factura.Read

        If (estado = True) Then

            txtgrupo.Text = mostrar_factura(1)
            dt_fecha.Value = mostrar_factura(2)



        Else




        End If


        mostrar_factura.Close()


        '/// Esto Carga el detalle de la factura pero se pone bien lenta la pc si se ejecuata


        'Dim cargar_datos_detalle As String = "select * from detalle_gastos where cod_gastos=" & txtgasto.Text
        'Dim mostrar As New DataTable

        'Using adpmostrar As New SqlDataAdapter(cargar_datos_detalle, conectar)

        '    adpmostrar.Fill(mostrar)

        'End Using
        'DataGridView1.DataSource = mostrar





        conectar.Close()





    End Sub

    Private Sub btactualizar_Click(sender As Object, e As EventArgs) Handles btactualizar.Click

        conecta()

        Dim datosfacturad As String = "insert into detalle_gastos(cod_gastos,cod_ingrediente,cantidad,precio, subtotal) values(@cod_gastos,@cod_ingrediente,@cantidad,@precio, @subtotal)"
        Dim registrard As New SqlCommand(datosfacturad, conectar)

        Dim fila As DataGridViewRow = New DataGridViewRow()

        For Each fila In DataGridView1.Rows

            registrard.Parameters.Clear()
            'registrard.Parameters.AddWithValue("@cod_detalle_gastos", txtgasto.Text)
            registrard.Parameters.AddWithValue("@cod_gastos", txtgasto.Text)
            registrard.Parameters.AddWithValue("@cod_ingrediente", fila.Cells("ccodigo").Value)
            registrard.Parameters.AddWithValue("@cantidad", fila.Cells("ccantidad").Value)
            registrard.Parameters.AddWithValue("@precio", fila.Cells("cprecio").Value)
            registrard.Parameters.AddWithValue("@subtotal", fila.Cells("csubtotal").Value)
            registrard.ExecuteNonQuery()




        Next

        conectar.Close()

    End Sub

    Private Sub txtgasto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtgasto.KeyPress
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

    Private Sub txtcod_ingre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcod_ingre.KeyPress
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

    Private Sub txtprecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecio.KeyPress
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

    Private Sub txttotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttotal.KeyPress
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
