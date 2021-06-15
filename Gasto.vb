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
        Me.Close()
        Form3.Show()
    End Sub

    Private Sub Gasto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '/////////////////////////////////// Esto Llena el ComboBox de ingredientes
        cargar_combo()
        Try
            cb_Ingredientes.DataSource = ds.Tables(0)
            cb_Ingredientes.DisplayMember = "descripcion"
            cb_Ingredientes.SelectedIndex = "cod_ingredientes"

        Catch ex As Exception

        End Try


        'Carga de Codigo de Grupo en Combobox'
        sql = "SELECT distinct cod_grupo AS 'Grupo' FROM animales where estado is null"
        adt = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        adt.Fill(ds)

        'Combobox'
        cb_Grupo.DataSource = ds.Tables(0)
        cb_Grupo.SelectedIndex = -1
        cb_Grupo.DisplayMember = "Grupo"
        cn.Close()






    End Sub

    Private Sub btcrear_Click(sender As Object, e As EventArgs) Handles btcrear.Click


        conecta()
        Dim datos_gasto As String = "insert into gastos(cod_grupo,fecha)values(@cod_grupo,@fecha)"
        Dim registrar_gasto As New SqlCommand(datos_gasto, conectar)
        registrar_gasto.Parameters.AddWithValue("@cod_grupo", Convert.ToInt32(cb_Grupo.Text))
        registrar_gasto.Parameters.AddWithValue("@fecha", dt_fecha.Value)
        registrar_gasto.ExecuteNonQuery()


        Dim recuperar_cod As String = "select top 1 cod_gastos from gastos order by cod_gastos desc"
        Dim recuperar As SqlDataReader
        Dim ejecutar As New SqlCommand

        ejecutar = New SqlCommand(recuperar_cod, conectar)
        recuperar = ejecutar.ExecuteReader

        Dim estado As String
        Dim num_factura As String
        estado = recuperar.Read

        If (estado = True) Then

            num_factura = recuperar(0)

        End If

        recuperar.Close()


        'codigofactura = Val(txtgasto.Text)

        Dim datosfacturad As String = "insert into detalle_gastos(cod_gastos,cod_ingrediente,cantidad,precio, subtotal) values(@cod_gastos,@cod_ingrediente,@cantidad,@precio, @subtotal)"
        Dim registrard As New SqlCommand(datosfacturad, conectar)

        Dim fila As DataGridViewRow = New DataGridViewRow()

        For Each fila In DataGridView1.Rows

            registrard.Parameters.Clear()
            'registrard.Parameters.AddWithValue("@cod_detalle_gastos", txtgasto.Text)
            registrard.Parameters.AddWithValue("@cod_gastos", num_factura)
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




        'datos_factura_venta.cod_fact = codigofactura

        conectar.Close()
        DataGridView1.Rows.Clear()
        cb_Grupo.SelectedIndex = -1
        cb_Ingredientes.SelectedIndex = -1
        txtcod_ingre.Text = ""
        txtcantidad.Text = ""
        txtprecio.Text = ""
        txttotal.Text = ""



        'Dim fac As New factura()
        'fac.Show()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btagregar.Click

        Dim subtotal As Integer

        If (txtcantidad.Text IsNot "" And txtprecio.Text IsNot "") Then
            subtotal = Val(txtprecio.Text) * Val(txtcantidad.Text)


            DataGridView1.Rows.Add(txtcod_ingre.Text, txtcantidad.Text, txtprecio.Text, subtotal)
            totald = totald + subtotal
            txttotal.Text = totald

            cb_Ingredientes.SelectedIndex = -1
            txtprecio.Enabled = False
            txtcantidad.Enabled = False
            btagregar.Enabled = False
            txtcantidad.Text = ""
            txtcod_ingre.Text = ""
            txtprecio.Text = ""

        Else
            MsgBox("Rellene toodos los campos")
        End If






    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Ingredientes.SelectedIndexChanged

        txtcod_ingre.Text = (cb_Ingredientes.SelectedIndex) + 1
        txtcantidad.Enabled = True
        txtprecio.Enabled = True

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

        End If


        mostrar_ingre.Close()

        conectar.Close()




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

    Private Sub txtgasto_KeyPress(sender As Object, e As KeyPressEventArgs)
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

    Private Sub txtgrupo_KeyPress(sender As Object, e As KeyPressEventArgs)
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

    Private Sub cb_Grupo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Grupo.SelectedIndexChanged
        cb_Ingredientes.Enabled = True
    End Sub

    Private Sub txtcantidad_TextChanged(sender As Object, e As EventArgs) Handles txtcantidad.TextChanged
        If (txtcantidad.Text IsNot "") Then
            btagregar.Enabled = True
        Else
            btagregar.Enabled = False
        End If

        Dim valor As Integer
        Try
            valor = Convert.ToInt32(txtcantidad.Text)
            If (valor <= 0) Then
                btagregar.Enabled = False
            Else
                btagregar.Enabled = True

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        btcrear.Enabled = True
        b_Eliminar.Enabled = True
    End Sub

    Private Sub b_Eliminar_Click(sender As Object, e As EventArgs) Handles b_Eliminar.Click

        Dim indiceseleccion As Integer
        Dim valor As Integer

        indiceseleccion = DataGridView1.CurrentRow.Index
        valor = DataGridView1.Rows(indiceseleccion).Cells("csubtotal").Value

        DataGridView1.Rows.RemoveAt(indiceseleccion)

        If (DataGridView1.RowCount <= 0) Then
            b_Eliminar.Enabled = False
            btcrear.Enabled = False
            txttotal.Text = ""
            totald = 0
        Else
            b_Eliminar.Enabled = True
            totald = totald - valor
            txttotal.Text = totald

        End If




    End Sub

    Private Sub txtprecio_TextChanged(sender As Object, e As EventArgs) Handles txtprecio.TextChanged
        If (txtprecio.Text IsNot "") Then
            btagregar.Enabled = True
        Else
            btagregar.Enabled = False
        End If

        Dim valor As Integer
        Try
            valor = Convert.ToInt32(txtprecio.Text)
            If (valor <= 0) Then
                btagregar.Enabled = False
            Else
                btagregar.Enabled = True

            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
