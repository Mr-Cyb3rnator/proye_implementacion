
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
        Dim cargar_datos_clientes As String = "select cod_animal as 'Código', peso_inicial as 'Peso incial', peso_1 as 'Peso 1', peso_2 as 'Peso 2', peso_3 as 'Peso 3', peso_4 as 'Peso final', peso_objetivo as 'Peso Objetivo', edad as 'Edad', raza as 'Raza', observaciones as 'Observaciones', cod_grupo as 'Código Grupo',precio_compra as 'Precio de compra', estado as 'Estado' from animales "
        Dim mostrar As New DataTable

        Using adpmostrar As New SqlDataAdapter(cargar_datos_clientes, conectar)

            adpmostrar.Fill(mostrar)

        End Using
        DGcabezas.DataSource = mostrar
        conectar.Close()


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoSize = True

        Me.AutoScroll = True
        bteditar.Enabled = False
        bteliminar.Enabled = False

        cargargrid()

    End Sub

    Private Sub btagregar_Click(sender As Object, e As EventArgs) Handles btagregar.Click

        If (txtpesoini.Text IsNot "" And txtedad.Text IsNot "" And cb_Raza.Text IsNot "" And combo_grupos.Text IsNot "" And txtpesoini IsNot "") Then

            conecta()
            Dim insertar_cabezas As String = "insert into animales(peso_inicial,peso_1,peso_2,peso_3,peso_4,peso_objetivo,edad,raza,observaciones,cod_grupo,precio_compra)values(@peso_inicial,@peso_1,@peso_2,@peso_3,@peso_4,@peso_objetivo,@edad,@raza,@observaciones,@cod_grupo,@precio_compra)"
            Dim insertar As New SqlCommand(insertar_cabezas, conectar)
            insertar.Parameters.AddWithValue("@peso_inicial", txtpesoini.Text)
            insertar.Parameters.AddWithValue("@peso_1", txtpeso1.Text)
            insertar.Parameters.AddWithValue("@peso_2", txtpeso2.Text)
            insertar.Parameters.AddWithValue("@peso_3", txtpeso3.Text)
            insertar.Parameters.AddWithValue("@peso_4", txtpeso4.Text)
            insertar.Parameters.AddWithValue("@peso_objetivo", txtpesoobj.Text)
            insertar.Parameters.AddWithValue("@edad", txtedad.Text)
            insertar.Parameters.AddWithValue("@raza", cb_Raza.Text)
            insertar.Parameters.AddWithValue("@observaciones", rtxtobs.Text)
            insertar.Parameters.AddWithValue("@cod_grupo", txtcod_grup.Text)
            insertar.Parameters.AddWithValue("@precio_compra", txtprecio.Text)


            insertar.ExecuteNonQuery()



            conectar.Close()
            cargargrid()
        Else
            MsgBox("Rellene toodos los campos")
        End If



    End Sub

    Private Sub bteliminar_Click(sender As Object, e As EventArgs) Handles bteliminar.Click

        conecta()
        Dim eliminar As String = "delete from animales where cod_animal=@cod_animal "
        Dim procesar As New SqlCommand(eliminar, conectar)
        procesar.Parameters.AddWithValue("@cod_animal", txtcodigoanimal.Text)
        procesar.ExecuteNonQuery()
        conectar.Close()
        cargargrid()



    End Sub

    Private Sub btnatras_Click(sender As Object, e As EventArgs)
        Me.Close()
        frm_Menu.Show()

    End Sub

    Private Sub bteditar_Click(sender As Object, e As EventArgs) Handles bteditar.Click

        Dim pesoini, pesofin As Integer
        pesoini = (Val(txtpesoini.Text))
        pesofin = (Val(txtpeso4.Text))

        If (pesofin < pesoini) Then

            MsgBox("Peso final no puede ser mas bajo que el inical", Title:="Error")

        Else
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
            actualizar.Parameters.AddWithValue("@raza", cb_Raza.Text)
            actualizar.Parameters.AddWithValue("@observaciones", rtxtobs.Text)
            actualizar.Parameters.AddWithValue("@cod_grupo", combo_grupos.Text)
            actualizar.ExecuteNonQuery()
            conectar.Close()
            cargargrid()

        End If

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
        frm_Menu.Show()
    End Sub


    Private Sub DGcabezas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGcabezas.CellContentClick

        conecta()
        Dim fila_actual As Integer
        fila_actual = DGcabezas.CurrentRow.Index
        txtcodigoanimal.Text = DGcabezas.Rows(fila_actual).Cells(0).Value
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
            cb_Raza.Text = mostrar(8)
            txtprecio.Text = mostrar(11)

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


    Private Sub btnatras_Click_1(sender As Object, e As EventArgs) Handles btnatras.Click
        Me.Close()
        frm_Menu.Show()

    End Sub
End Class
