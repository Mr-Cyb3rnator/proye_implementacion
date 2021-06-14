﻿
Imports System.Data.SqlClient
Public Class Cabeza_ganado




    Public Sub cargar_combo_grupos()

        Try
            cn.Open()
            sql = "select  cod_grupo from grupos "
            adt = New SqlDataAdapter(sql, cn)
            ds = New DataSet
            adt.Fill(ds)

        Catch ex As Exception

        End Try


    End Sub


    Private Sub cargargrid()

        conecta()
        Dim cargar_datos_clientes As String = "select * from animales "
        Dim mostrar As New DataTable

        Using adpmostrar As New SqlDataAdapter(cargar_datos_clientes, conectar)

            adpmostrar.Fill(mostrar)

        End Using
        DGcabezas.DataSource = mostrar
        conectar.Close()


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bteditar.Enabled = False
        bteliminar.Enabled = False

        cargargrid()

    End Sub

    Private Sub btagregar_Click(sender As Object, e As EventArgs) Handles btagregar.Click
        'DGcabezas.Rows.Add(txtcodigoanimal.Text, txtpesoini.Text, txtpeso1.Text, txtpeso2.Text, txtpeso3.Text, txtpeso4.Text, txtpesoobj.Text, txtedad.Text, txtraza.Text, txtobs.Text, txtcod_grup.Text)

        conecta()
        Dim insertar_cabezas As String = "insert into animales(peso_inicial,peso_1,peso_2,peso_3,peso_4,peso_objetivo,edad,raza,observaciones,cod_grupo)values(@peso_inicial,@peso_1,@peso_2,@peso_3,@peso_4,@peso_objetivo,@edad,@raza,@observaciones,@cod_grupo)"
        Dim insertar As New SqlCommand(insertar_cabezas, conectar)
        insertar.Parameters.AddWithValue("@peso_inicial", txtpesoini.Text)
        insertar.Parameters.AddWithValue("@peso_1", txtpeso1.Text)
        insertar.Parameters.AddWithValue("@peso_2", txtpeso2.Text)
        insertar.Parameters.AddWithValue("@peso_3", txtpeso3.Text)
        insertar.Parameters.AddWithValue("@peso_4", txtpeso4.Text)
        insertar.Parameters.AddWithValue("@peso_objetivo", txtpesoobj.Text)
        insertar.Parameters.AddWithValue("@edad", txtedad.Text)
        insertar.Parameters.AddWithValue("@raza", txtraza.Text)
        insertar.Parameters.AddWithValue("@observaciones", rtxtobs.Text)
        insertar.Parameters.AddWithValue("@cod_grupo", txtcod_grup.Text)


        insertar.ExecuteNonQuery()



        conectar.Close()
        cargargrid()



    End Sub

    Private Sub bteliminar_Click(sender As Object, e As EventArgs) Handles bteliminar.Click
        'DGcabezas.Rows.Remove(DGcabezas.CurrentRow)

        conecta()
        Dim eliminar As String = "delete from animales where cod_animal=@cod_animal "
        Dim procesar As New SqlCommand(eliminar, conectar)
        procesar.Parameters.AddWithValue("@cod_animal", txtcodigoanimal.Text)
        procesar.ExecuteNonQuery()
        conectar.Close()
        cargargrid()



    End Sub

    Private Sub btnatras_Click(sender As Object, e As EventArgs) Handles btnatras.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub bteditar_Click(sender As Object, e As EventArgs) Handles bteditar.Click

        conecta()

        Dim datos_animales As String = "update animales set peso_inicial=@peso_inicial,peso_1=@peso_1,peso_2=@peso_2,peso_3=@peso_3,peso_4=@peso_4,peso_objetivo=@peso_objetivo,edad=@edad,raza=@raza,observaciones=@observaciones,cod_grupo=@cod_grupo where cod_animal=@cod_animal"
        Dim actualizar As New SqlCommand(datos_animales, conectar)
        actualizar.Parameters.AddWithValue("@cod_animal", txtcodigoanimal.Text)
        actualizar.Parameters.AddWithValue("@peso_inicial", txtpesoini.Text)
        actualizar.Parameters.AddWithValue("@peso_1", txtpeso1.Text)
        actualizar.Parameters.AddWithValue("@peso_2", txtpeso2.Text)
        actualizar.Parameters.AddWithValue("@peso_3", txtpeso3.Text)
        actualizar.Parameters.AddWithValue("@peso_4", txtpeso4.Text)
        actualizar.Parameters.AddWithValue("@peso_objetivo", txtpesoobj.Text)
        actualizar.Parameters.AddWithValue("@edad", txtedad.Text)
        actualizar.Parameters.AddWithValue("@raza", txtraza.Text)
        actualizar.Parameters.AddWithValue("@observaciones", rtxtobs.Text)
        actualizar.Parameters.AddWithValue("@cod_grupo", combo_grupos.Text)
        actualizar.ExecuteNonQuery()
        conectar.Close()
        cargargrid()


    End Sub

    Private Sub txtcodigoanimal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodigoanimal.KeyPress
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

    Private Sub txtpesoobj_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpesoobj.KeyPress
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

    Private Sub txtedad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtedad.KeyPress
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

        End If
    End Sub

    Private Sub txtpeso1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpeso1.KeyPress
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

    Private Sub txtpeso2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpeso2.KeyPress
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

    Private Sub txtpeso3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpeso3.KeyPress
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

    Private Sub txtpeso4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpeso4.KeyPress
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

    Private Sub txtcod_grup_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcod_grup.KeyPress
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

    Private Sub txtraza_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtraza.KeyPress
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

    Private Sub txtobs_KeyPress(sender As Object, e As KeyPressEventArgs)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub rtxtobs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rtxtobs.KeyPress

    End Sub

    Private Sub DGcabezas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGcabezas.CellContentClick

        conecta()
        Dim fila_actual As Integer
        fila_actual = DGcabezas.CurrentRow.Index
        txtcodigoanimal.Text = DGcabezas.Rows(fila_actual).Cells(0).Value
        'txtcodgrup.Text = DGgrupos.CurrentRow.Cells(0).Value
        Dim recuperar As String = "select * from animales where cod_animal=" & txtcodigoanimal.Text
        Dim mostrar As SqlDataReader
        Dim ejecutar As New SqlCommand

        ejecutar = New SqlCommand(recuperar, conectar)
        mostrar = ejecutar.ExecuteReader

        Dim estado As String

        estado = mostrar.Read

        If (estado = True) Then

            txtcodigoanimal.Text = mostrar(0)
            txtpesoini.Text = mostrar(1)
            txtpeso1.Text = mostrar(2)
            txtpeso2.Text = mostrar(3)
            txtpeso3.Text = mostrar(4)
            txtpeso4.Text = mostrar(5)
            txtpesoobj.Text = mostrar(6)
            txtedad.Text = mostrar(7)
            txtraza.Text = mostrar(8)

            combo_grupos.Text = mostrar(10)
            rtxtobs.Text = mostrar(9)

        Else




        End If

        mostrar.Close()
        conectar.Close()
        bteditar.Enabled = True
        bteliminar.Enabled = True



    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_grupos.SelectedIndexChanged
        txtcod_grup.Text = combo_grupos.Text





    End Sub

    Private Sub combo_grupos_Click(sender As Object, e As EventArgs) Handles combo_grupos.Click


        cargar_combo_grupos()

        Try
            combo_grupos.DataSource = ds.Tables(0)
            combo_grupos.DisplayMember = "cod_grupo"




        Catch ex As Exception

        End Try

    End Sub
End Class
