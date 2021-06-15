﻿Imports System.Data.SqlClient
Public Class VentaGanado


    Private Sub cargargrid_grupo()

        '/// Esto Carga el detalle de la factura 
        conecta()


        Dim cargar_datos_detalle As String = "select cod_grupo AS 'Grupo', cod_animal AS 'Codigo Animal', peso_4 AS 'Peso Final' from animales where cod_grupo =" & txtcodgrupo.Text
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

        conecta()

        Dim Cargar_Grupos As String = "SELECT DISTINCT cod_grupo AS 'Grupos', raza AS 'Raza' from animales where estado is null and peso_4 is not null"
        Dim mostrar As New DataTable

        Using adpmostrar As New SqlDataAdapter(Cargar_Grupos, conectar)

            adpmostrar.Fill(mostrar)

        End Using
        dgvGrupos.DataSource = mostrar

        conectar.Close()

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

        MsgBox("Venta Efectuada", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Venta Ganado")
        txtcodgrupo.Text = ""
        txtlibras_totales.Text = ""
        txt_preciolibra.Text = ""
        txttotalventa.Text = ""
        txtcodcliente.Text = " "
        dgventaganado.DataSource = Nothing

        Dim Cargar_Grupos As String = "SELECT DISTINCT cod_grupo AS 'Grupos', raza AS 'Raza' from animales where estado is null and peso_4 is not null"
        Dim mostrar As New DataTable

        Using adpmostrar As New SqlDataAdapter(Cargar_Grupos, conectar)

            adpmostrar.Fill(mostrar)

        End Using
        dgvGrupos.DataSource = mostrar





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



        'Recorrer el Data Grid View Cargado de Grupos'
        'Dim getValue As String'
        Dim grupopresente As Boolean

        For Each row As DataGridViewRow In dgvGrupos.Rows
            If row.Cells("Grupos").Value = txtcodgrupo.Text Then

                'getValue = "Todo normal"'
                grupopresente = 1
                Exit For
            Else
                'getValue = "No Existe"'
                grupopresente = 0

            End If
        Next
        'MsgBox(getValue)'
        If (grupopresente) Then
            cargar_peso_total()
            cargargrid_grupo()

            txt_preciolibra.Enabled = True
            txt_preciolibra.Select()

        Else
            MsgBox("Grupo No Forma Parte de la Lista")

            txtcodgrupo.Text = ""
            txtcodgrupo.Select()


        End If





    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnatras.Click
        Me.Close()

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
            e.Handled = True
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
        ElseIf Char.IsPunctuation(e.KeyChar) And txt_preciolibra.Text.IndexOf(".") <= 0 Then

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

    Private Sub txtcodgrupo_TextChanged(sender As Object, e As EventArgs) Handles txtcodgrupo.TextChanged
        btcargar_grupo.Enabled = True

        If (txtcodgrupo.Text = "") Then
            btcargar_grupo.Enabled = False
        End If

    End Sub

    Private Sub txt_preciolibra_TextChanged(sender As Object, e As EventArgs) Handles txt_preciolibra.TextChanged
        Dim total_venta As Integer

        If (txt_preciolibra.Text IsNot "") Then

            total_venta = Val(txtlibras_totales.Text) * Val(txt_preciolibra.Text)
            txttotalventa.Text = total_venta

            txtcodcliente.Enabled = True

        Else
            txttotalventa.Text = ""
            txtcodcliente.Enabled = False
        End If

    End Sub

    Private Sub txtcodcliente_TextChanged(sender As Object, e As EventArgs) Handles txtcodcliente.TextChanged
        If (txtcodcliente.Text IsNot "") Then
            btnguardar.Enabled = True
        Else
            btnguardar.Enabled = False
        End If
    End Sub
End Class