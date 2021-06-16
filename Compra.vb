Imports System.Data.SqlClient
Public Class Compra
    Public contador2 As Integer
    Dim totalf As Integer


    Private Sub txtcodp_TextChanged(sender As Object, e As EventArgs) Handles txtpesoini.TextChanged

        If (txtpesoini.Text IsNot "") Then
            txtedad.Enabled = True
            b_Limpiar.Enabled = True
        Else
            txtedad.Enabled = False
            b_Limpiar.Enabled = False

        End If


        'conecta()

        'Dim recuperar As String = "select * from inventario where codproducto=' " & txtcodp.Text & " ' "
        'Dim mostrar As SqlDataReader
        'Dim ejecutar As New SqlCommand

        'ejecutar = New SqlCommand(recuperar, conectar)
        'mostrar = ejecutar.ExecuteReader

        'Dim estado As String
        'estado = mostrar.Read

        'If (estado = True) Then

        '    txtnombrep.Text = mostrar(1)
        '    txtprecio.Text = mostrar(2)
        '    txtexistencia.Text = mostrar(3)


        'Else

        '    txtnombrep.Text = ""
        '    txtprecio.Text = ""
        '    txtexistencia.Text = ""

        'End If

        'mostrar.Close()
        'conectar.Close()
    End Sub

    Private Sub txtcod_empleado_TextChanged(sender As Object, e As EventArgs)
        'conecta()

        'Dim recuperar As String = "select * from empleados where codempleado=' " & txtcod_empleado.Text & " ' "
        'Dim mostrar As SqlDataReader
        'Dim ejecutar As New SqlCommand

        'ejecutar = New SqlCommand(recuperar, conectar)
        'mostrar = ejecutar.ExecuteReader

        'Dim estado As String
        'estado = mostrar.Read

        'If (estado = True) Then

        '    txtnombre_empleado.Text = mostrar(1)



        'Else

        '    txtnombre_empleado.Text = " "


        'End If

        'mostrar.Close()
        'conectar.Close()
    End Sub

    Private Sub txtcod_cliente_TextChanged(sender As Object, e As EventArgs) Handles txtcod_cliente.TextChanged

        If (txtcod_cliente.Text IsNot "") Then
            txtpesoini.Enabled = True
        Else
            txtpesoini.Enabled = False
        End If

        'conecta()

        'Dim recuperar As String = "select * from clientes where codcliente=' " & txtcod_cliente.Text & " ' "
        'Dim mostrar As SqlDataReader
        'Dim ejecutar As New SqlCommand

        'ejecutar = New SqlCommand(recuperar, conectar)
        'mostrar = ejecutar.ExecuteReader

        'Dim estado As String
        'estado = mostrar.Read

        'If (estado = True) Then

        '    txtnombre_cliente.Text = mostrar(1)



        'Else

        '    txtnombre_empleado.Text = ""


        'End If

        'mostrar.Close()
        'conectar.Close()

    End Sub


    Private Sub btagregar_Click(sender As Object, e As EventArgs) Handles btagregar.Click

        Dim subtotal As Integer


        If (txtpesoini.Text IsNot "" And txtedad.Text IsNot "" And txtprecio.Text IsNot "") Then


            contador2 = contador2 + 1
            subtotal = (Val(txtprecio.Text))


            dgv_Compra.Rows.Add(txtpesoini.Text, txtedad.Text, cb_Raza.SelectedItem.ToString, subtotal)
            totalf = totalf + subtotal
            txttotal.Text = totalf
            txtpesoini.Clear()
            txtedad.Clear()
            cb_Raza.SelectedIndex = -1
            txtprecio.Clear()
        Else
            MsgBox("Llene todos los campos")

        End If




    End Sub

    Private Sub btguardar_Click(sender As Object, e As EventArgs) Handles btguardar.Click

        Dim codigofactura, contador As Integer

        If (txtcod_cliente.Text IsNot "") Then


            conecta()
            Dim datosfactura As String = "insert into compra_animales(cod_cliente,total,fecha,cantidad_animales)values(@cod_cliente,@total,@fecha,@cantidad_animales)"
            Dim registrar As New SqlCommand(datosfactura, conectar)
            registrar.Parameters.AddWithValue("@cod_cliente", txtcod_cliente.Text)
            registrar.Parameters.AddWithValue("@total", txttotal.Text)
            registrar.Parameters.AddWithValue("@fecha", DateTimePicker1.Value)
            registrar.Parameters.AddWithValue("@cantidad_animales", contador2)

            registrar.ExecuteNonQuery()

            Dim recuperar_cod As String = "select top 1 cod_compra from compra_animales order by cod_compra desc"
            Dim recuperar As SqlDataReader
            Dim ejecutar As New SqlCommand

            ejecutar = New SqlCommand(recuperar_cod, conectar)
            recuperar = ejecutar.ExecuteReader

            Dim estado As String
            Dim num_Grupo As String
            Dim num_Factura As String

            estado = recuperar.Read

            If (estado = True) Then

                'txtcompra.Text = recuperar(0)
                'txtcodgrupo.Text = recuperar(0)
                num_Grupo = recuperar(0)
                num_Factura = recuperar(0)
                MsgBox("Compra Efectuada Grupo# " + num_Grupo, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Compra Ganado #" + num_Factura)


            Else

                'txtcompra.Text = ""


            End If

            recuperar.Close()


            Dim grupo_asinado As String = "insert into grupos(cod_grupo) values(@cod_grupo)"
            Dim registrar_grupo As New SqlCommand(grupo_asinado, conectar)
            registrar_grupo.Parameters.AddWithValue("@cod_grupo", num_Grupo)
            registrar_grupo.ExecuteNonQuery()

            Dim datosfacturad As String = "insert into detalle_compra_animal(cod_detalle_compra,peso_inicial,raza,precio_compra) values(@cod_detalle_compra,@peso_inicial,@raza,@precio_compra)"
            Dim registrard As New SqlCommand(datosfacturad, conectar)

            Dim fila As DataGridViewRow = New DataGridViewRow()

            Dim datos_animales As String = "insert into animales(peso_inicial,raza,cod_grupo,precio_compra,edad) values(@peso_inicial,@raza,@cod_grupo,@precio_compra,@edad)"
            Dim registrar_a As New SqlCommand(datos_animales, conectar)

            Dim fila_a As DataGridViewRow = New DataGridViewRow()


            For Each fila In dgv_Compra.Rows

                registrard.Parameters.Clear()
                registrard.Parameters.AddWithValue("@cod_detalle_compra", num_Grupo)
                registrard.Parameters.AddWithValue("@peso_inicial", fila.Cells("cpesoini").Value)
                registrard.Parameters.AddWithValue("@raza", fila.Cells("craza").Value)
                registrard.Parameters.AddWithValue("@precio_compra", fila.Cells("cprecio_compra").Value)

                registrard.ExecuteNonQuery()

                registrar_a.Parameters.Clear()
                registrar_a.Parameters.AddWithValue("@peso_inicial", fila.Cells("cpesoini").Value)
                registrar_a.Parameters.AddWithValue("@edad", fila.Cells("cedad").Value)
                registrar_a.Parameters.AddWithValue("@raza", fila.Cells("craza").Value)
                registrar_a.Parameters.AddWithValue("@cod_grupo", num_Grupo)
                registrar_a.Parameters.AddWithValue("@precio_compra", fila.Cells("cprecio_compra").Value)
                'registrar_a.Parameters.AddWithValue("@observaciones", co)
                registrar_a.ExecuteNonQuery()

                contador = contador + 1

            Next

            codigofactura = Val(num_Factura)


            Dim grupo_cantidad As String = "update grupos set numero_animales=@numero_animales where cod_grupo=" & num_Grupo
            Dim registrar_cantidad As New SqlCommand(grupo_cantidad, conectar)
            registrar_cantidad.Parameters.AddWithValue("@numero_animales", contador)
            registrar_cantidad.ExecuteNonQuery()



            '   TODO ESTE CODIGO PUEDE SERVIR PARA OTRA COSA POR ESO NO LO HE BORRADO 
            'Dim registrar_cantidad As String = "select count(cod_animal) from detalle_compra_animal where cod_detalle_compra=" & txtcompra.Text
            'Dim recuperar_cantidad As SqlDataReader
            'Dim ejecutar_cantidad As New SqlCommand

            'ejecutar_cantidad = New SqlCommand(registrar_cantidad, conectar)
            'recuperar_cantidad = ejecutar_cantidad.ExecuteReader

            'Dim estado1 As String
            'estado1 = recuperar.Read

            'If (estado1 = True) Then

            '    contador = recuperar_cantidad(0)



            'Else

            '    ' txtcompra.Text = ""


            'End If

            'recuperar.Close()






            'datos_factura_venta.cod_fact = codigofactura

            conectar.Close()
            dgv_Compra.Rows.Clear()
            txttotal.Text = ""
            txtcod_cliente.Text = ""
        Else
            MsgBox("Revise Todos Los Campos esten llenos")

        End If

        'Dim fac As New factura()
        'fac.Show()




    End Sub



    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtcompra_KeyPress(sender As Object, e As KeyPressEventArgs)
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

    Private Sub txtcod_cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcod_cliente.KeyPress
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

    Private Sub txtpesoini_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpesoini.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            tooltip_Compra.SetToolTip(txtpesoini, "Solo Permite Numeros, máximo 4 digitos")

        End If
    End Sub

    Private Sub txtedad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtedad.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            tooltip_Compra.SetToolTip(txtedad, "Solo Permite Numeros, máximo 2 digitos")

        End If
    End Sub

    Private Sub txtraza_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
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

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
        Form3.Show()
    End Sub

    Private Sub b_Limpiar_Click(sender As Object, e As EventArgs) Handles b_Limpiar.Click
        txtpesoini.Text = ""
        txtedad.Text = ""
        cb_Raza.SelectedIndex = -1
        txtprecio.Text = ""
        b_Limpiar.Enabled = False

    End Sub

    Private Sub txtedad_TextChanged(sender As Object, e As EventArgs) Handles txtedad.TextChanged
        If (txtedad.Text IsNot "") Then
            cb_Raza.Enabled = True
            cb_Raza.SelectedIndex = 0
        Else
            cb_Raza.Enabled = False
            cb_Raza.SelectedIndex = -1



        End If
    End Sub

    Private Sub cb_Raza_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Raza.SelectedIndexChanged
        If (cb_Raza.SelectedIndex <> -1) Then
            txtprecio.Enabled = True

        Else
            txtprecio.Enabled = False
        End If
    End Sub

    Private Sub txtprecio_TextChanged(sender As Object, e As EventArgs) Handles txtprecio.TextChanged
        If (txtprecio.Text IsNot "") Then
            btagregar.Enabled = True
        Else
            btagregar.Enabled = False
        End If


    End Sub

    Private Sub txttotal_TextChanged(sender As Object, e As EventArgs) Handles txttotal.TextChanged
        If (txttotal.Text IsNot "") Then
            btguardar.Enabled = True
        Else
            btguardar.Enabled = False
        End If

    End Sub


End Class