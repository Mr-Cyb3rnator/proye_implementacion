
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

        DGcabezas.DataSource = CargarDatosGrid("select cod_animal as 'Código', peso_inicial as 'Peso incial', peso_1 as 'Peso 1', peso_2 as 'Peso 2', peso_3 as 'Peso 3', peso_4 as 'Peso final', peso_objetivo as 'Peso Objetivo', edad as 'Edad', raza as 'Raza', observaciones as 'Observaciones', cod_grupo as 'Código Grupo',precio_compra as 'Precio de compra', estado as 'Estado' from animales ")

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

        If (txtpesoini.Text IsNot "" And txtedad.Text IsNot "" And cb_Raza.Text IsNot "" And combo_grupos.Text IsNot "" And txtpesoini IsNot "" And rtxtobs IsNot "" And txtprecio IsNot "") Then

            conecta()


            ModificarBD("exec InsertarAnimalesFormCabezas " & Val(txtpesoini.Text) & "," & "'" & cb_Raza.Text & "'" & "," & Val(combo_grupos.Text) & "," & Val(txtprecio.Text) & "," & Val(txtedad.Text))

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

        Dim pesoini, pesoboj As Integer
        pesoini = (Val(txtpesoini.Text))
        pesoboj = (Val(txtpesoobj.Text))

        If (pesoboj < Val(txtpesoini.Text)) Then

            MsgBox("Peso objetivo no puede ser mas bajo que el inical ", Title:="Error")

        Else

            If (Val(txtpeso1.Text) >= 0 And Val(txtpeso1.Text) <= 5000) Then
                conecta()

                ModificarBD("exec ActualizarAnimales " & Val(txtcodigoanimal.Text) & "," & Val(txtpesoini.Text) & "," & "'" & cb_Raza.Text & "'" & "," & Val(combo_grupos.Text) & "," & Val(txtprecio.Text) & "," & Val(txtedad.Text) & "," & Val(txtpesoobj.Text) & "," & Val(txtpeso1.Text) & "," & Val(txtpeso2.Text) & "," & Val(txtpeso3.Text) & "," & Val(txtpeso4.Text) & "," & "'" & rtxtobs.Text & "'")

                conectar.Close()
                cargargrid()
            Else
                MsgBox("Peso 1 no puede ser mas alto de 5000 ", Title:="Error")
            End If



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


        CampoValidacionNumeros(e)

    End Sub

    Private Sub txtedad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtedad.KeyPress

        CampoValidacionNumeros(e)

    End Sub

    Private Sub txtpesoini_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpesoini.KeyPress

        CampoValidacionNumeros(e)

    End Sub

    Private Sub txtpeso1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpeso1.KeyPress

        CampoValidacionNumeros(e)


    End Sub

    Private Sub txtpeso2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpeso2.KeyPress

        CampoValidacionNumeros(e)

    End Sub

    Private Sub txtpeso3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpeso3.KeyPress

        CampoValidacionNumeros(e)

    End Sub

    Private Sub txtpeso4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpeso4.KeyPress

        CampoValidacionNumeros(e)

    End Sub

    Private Sub txtcod_grup_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcod_grup.KeyPress

        CampoValidacionNumeros(e)

    End Sub

    Private Sub txtraza_KeyPress(sender As Object, e As KeyPressEventArgs)

        CampoValidacionLetras(e)

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
            cb_Raza.SelectedItem = mostrar(8)
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

    Private Sub txtprecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecio.KeyPress

        CampoValidacionNumeros(e)

    End Sub
End Class
