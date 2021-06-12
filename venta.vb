Imports System.Data.SqlClient
Public Class venta

    Dim totalf As Integer
    Private Sub txtcodp_TextChanged(sender As Object, e As EventArgs) Handles txtcodp.TextChanged
        conecta()

        Dim recuperar As String = "select * from inventario where codproducto=' " & txtcodp.Text & " ' "
        Dim mostrar As SqlDataReader
        Dim ejecutar As New SqlCommand

        ejecutar = New SqlCommand(recuperar, conectar)
        mostrar = ejecutar.ExecuteReader

        Dim estado As String
        estado = mostrar.Read

        If (estado = True) Then

            txtnombrep.Text = mostrar(1)
            txtprecio.Text = mostrar(2)
            txtexistencia.Text = mostrar(3)


        Else

            txtnombrep.Text = ""
            txtprecio.Text = ""
            txtexistencia.Text = ""

        End If

        mostrar.Close()
        conectar.Close()
    End Sub

    Private Sub txtcod_empleado_TextChanged(sender As Object, e As EventArgs) Handles txtcod_empleado.TextChanged
        conecta()

        Dim recuperar As String = "select * from empleados where codempleado=' " & txtcod_empleado.Text & " ' "
        Dim mostrar As SqlDataReader
        Dim ejecutar As New SqlCommand

        ejecutar = New SqlCommand(recuperar, conectar)
        mostrar = ejecutar.ExecuteReader

        Dim estado As String
        estado = mostrar.Read

        If (estado = True) Then

            txtnombre_empleado.Text = mostrar(1)



        Else

            txtnombre_empleado.Text = " "


        End If

        mostrar.Close()
        conectar.Close()
    End Sub

    Private Sub txtcod_cliente_TextChanged(sender As Object, e As EventArgs) Handles txtcod_cliente.TextChanged
        conecta()

        Dim recuperar As String = "select * from clientes where codcliente=' " & txtcod_cliente.Text & " ' "
        Dim mostrar As SqlDataReader
        Dim ejecutar As New SqlCommand

        ejecutar = New SqlCommand(recuperar, conectar)
        mostrar = ejecutar.ExecuteReader

        Dim estado As String
        estado = mostrar.Read

        If (estado = True) Then

            txtnombre_cliente.Text = mostrar(1)



        Else

            txtnombre_empleado.Text = ""


        End If

        mostrar.Close()
        conectar.Close()

    End Sub


    Private Sub btagregar_Click(sender As Object, e As EventArgs) Handles btagregar.Click

        Dim subtotal, nuevoinv As Integer

        While (Val(txtcantidad.Text > Val(txtexistencia.Text)))

            MessageBox.Show("No hay stock disponible para este producto")
            txtcantidad.Text = InputBox("El Stock es  de " & Val(txtexistencia.Text))

        End While

        subtotal = ((Val(txtprecio.Text)) * Val(txtcantidad.Text))
        nuevoinv = Val(txtexistencia.Text) - Val(txtcantidad.Text)

        conecta()

        Dim restainventario As String = ("update inventario set existencia=" & nuevoinv & " where codproducto=" & Val(txtcodp.Text))
        Dim resta As New SqlCommand(restainventario, conectar)

        resta.ExecuteNonQuery()

        conectar.Close()


        DataGridView1.Rows.Add(txtcodp.Text, txtnombrep.Text, txtprecio.Text, txtcantidad.Text, subtotal)
        totalf = totalf + subtotal
        txttotal.Text = totalf
        txtcodp.Clear()
        txtnombrep.Clear()
        txtprecio.Clear()
        txtexistencia.Clear()
        txtcantidad.Clear()




    End Sub

    Private Sub btguardar_Click(sender As Object, e As EventArgs) Handles btguardar.Click

        Dim codigofactura As Integer

        conecta()
        Dim datosfactura As String = "insert into ventas(codventa,codempleado,codcliente,fechaventa,totalventa)values(@codventa,@codempleado,@codcliente,@fechaventa,@totalventa)"
        Dim registrar As New SqlCommand(datosfactura, conectar)
        registrar.Parameters.AddWithValue("@codventa", txtventa.Text)
        registrar.Parameters.AddWithValue("@codempleado", txtcod_empleado.Text)
        registrar.Parameters.AddWithValue("@codcliente", txtcod_empleado.Text)
        registrar.Parameters.AddWithValue("@fechaventa", dtpfecha.Value)
        registrar.Parameters.AddWithValue("@totalventa", txttotal.Text)

        registrar.ExecuteNonQuery()

        Dim datosfacturad As String = "insert into detalleventa(codventa,codproducto,nombre,precio,cantidad, subtotal) values(@codventa,@codproducto,@nombre,@precio,@cantidad,@subtotal)"
        Dim registrard As New SqlCommand(datosfacturad, conectar)

        Dim fila As DataGridViewRow = New DataGridViewRow()

        For Each fila In DataGridView1.Rows

            registrard.Parameters.Clear()
            registrard.Parameters.AddWithValue("@codventa", txtventa.Text)
            registrard.Parameters.AddWithValue("@codproducto", fila.Cells("ccodigo").Value)
            registrard.Parameters.AddWithValue("@nombre", fila.Cells("cnombre").Value)
            registrard.Parameters.AddWithValue("@precio", fila.Cells("cprecio").Value)
            registrard.Parameters.AddWithValue("@cantidad", fila.Cells("ccantidad").Value)
            registrard.Parameters.AddWithValue("@subtotal", fila.Cells("csubtotal").Value)
            registrard.ExecuteNonQuery()




        Next

        codigofactura = Val(txtventa.Text)


        'datos_factura_venta.cod_fact = codigofactura

        conectar.Close()
        DataGridView1.Rows.Clear()

        'Dim fac As New factura()
        'fac.Show()




    End Sub

    Private Sub venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtventa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtventa.KeyPress
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

    Private Sub txtcod_empleado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcod_empleado.KeyPress
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

    Private Sub txtnombre_empleado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre_empleado.KeyPress
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

    Private Sub txtnombre_cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre_cliente.KeyPress
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

    Private Sub txtcodp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodp.KeyPress
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

    Private Sub txtexistencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtexistencia.KeyPress
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

    Private Sub txtnombrep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombrep.KeyPress
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()
    End Sub
End Class