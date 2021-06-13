Imports System.Data.SqlClient
Public Class Dieta
    Private Sub cargarcmb()
        Try
            sql = "SELECT * FROM ingredientes"
            adt = New SqlDataAdapter(sql, cn)
            ds = New DataSet
            adt.Fill(ds)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub cargargrid()

        conecta()
        Dim cargar_datos_clientes As String = "select cod_dieta 'Código Dieta',cantidad_libras 'Cantidad en libras',comidas_al_dia 'Comidas al día' from dieta "
        Dim mostrar As New DataTable

        Using adpmostrar As New SqlDataAdapter(cargar_datos_clientes, conectar)

            adpmostrar.Fill(mostrar)

        End Using
        dgdieta.DataSource = mostrar
        conectar.Close()


    End Sub

    Private Sub cargargrid_dieta()

        conecta()

        Dim cod_dieta As Integer
        Dim fila As DataGridViewRow = New DataGridViewRow()
        cod_dieta = Val(txtcoddieta.Text)
        Dim cargar_datos As String = "select descripcion Descripción,costo Precio from ingredientes where cod_dieta=" & Val(txtcoddieta.Text)
        Dim mostrar As New DataTable

        Using adpmostrar As New SqlDataAdapter(cargar_datos, conectar)

            adpmostrar.Fill(mostrar)

        End Using
        dgingredientes_dieta.DataSource = mostrar
        conectar.Close()


    End Sub


    Private Sub Dieta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgdieta.ClearSelection()
        GroupBox1.Enabled = False

        cargargrid()
        cargargrid_dieta()


        cargarcmb()
        Try
            cmbcodingre.DataSource = ds.Tables(0)
            cmbcodingre.ValueMember = "cod_ingredientes"
        Catch ex As Exception

        End Try

        'dgdieta.Columns.Add("Cod.Dieta", "Cod.Dieta")
        'dgdieta.Columns.Add("Cod.Ingredientes", "Cod.Ingredientes")
        'dgdieta.Columns.Add("Cantidad", "Cantidad")
        'dgdieta.Columns.Add("Comidas por dia", "Comidas_por_dia")
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click


        If txtcoddieta.Text = "" Or txtcantidad.Text = "" Or txtcomidaxdia.Text = "" Then

            MessageBox.Show("Llene todos los campos", "Error")


        Else

            conecta()
            Dim insertar_dieta As String = "insert into dieta(cod_dieta,cantidad_libras,comidas_al_dia)values(@cod_dieta,@cantidad_libras,@comidas_al_dia)"
            Dim insertar As New SqlCommand(insertar_dieta, conectar)

            'insertar.Parameters.AddWithValue("@cod_dieta", fila.Cells("ccodigod").Value)
            insertar.Parameters.AddWithValue("@cod_dieta", txtcoddieta.Text)
            insertar.Parameters.AddWithValue("@cantidad_libras", txtcantidad.Text)
            insertar.Parameters.AddWithValue("@comidas_al_dia", txtcomidaxdia.Text)

            insertar.ExecuteNonQuery()

            conectar.Close()
            cargargrid()



        End If






    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        dgdieta.Rows.Remove(dgdieta.CurrentRow)
    End Sub

    Private Sub dgdieta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgdieta.CellContentClick
        Dim row As DataGridViewRow = dgdieta.CurrentRow

    End Sub

    Private Sub btnatras_Click(sender As Object, e As EventArgs) Handles btnatras.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub txtcoddieta_TextChanged(sender As Object, e As EventArgs) Handles txtcoddieta.TextChanged



        conecta()

        Dim recuperar As String = "select * from dieta where cod_dieta=' " & txtcoddieta.Text & " ' "
        Dim mostrar As SqlDataReader
        Dim ejecutar As New SqlCommand

        ejecutar = New SqlCommand(recuperar, conectar)
        mostrar = ejecutar.ExecuteReader

        Dim estado As String



        estado = mostrar.Read

        If (estado = True) Then

            txtcantidad.Text = mostrar(1)
            txtcomidaxdia.Text = mostrar(2)

        Else

            txtcantidad.Text = ""
            txtcomidaxdia.Text = ""



        End If

        mostrar.Close()
        conectar.Close()



    End Sub

    Private Sub btagregar_Click(sender As Object, e As EventArgs) Handles btagregar.Click



        If cmbcodingre.Text = 0 Then
            MessageBox.Show("No puede ser 0", "Error")
        Else
            conecta()

            Dim datos As String = "update ingredientes set cod_dieta=@cod_dieta where cod_ingredientes=@cod_ingredientes "
            Dim actualizar As New SqlCommand(datos, conectar)
            actualizar.Parameters.AddWithValue("@cod_ingredientes", cmbcodingre.Text)
            actualizar.Parameters.AddWithValue("@cod_dieta", txtcoddieta.Text)
            cmbcodingre.Text = 0
            actualizar.ExecuteNonQuery()
            conectar.Close()
            cargargrid_dieta()
        End If





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btselecionar_dierta.Click
        GroupBox1.Enabled = True

        cargargrid_dieta()

    End Sub

    Private Sub txtcoddieta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcoddieta.KeyPress
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

    Private Sub txtcodingre_KeyPress(sender As Object, e As KeyPressEventArgs) 
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

    Private Sub txtcomidaxdia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcomidaxdia.KeyPress
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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtcodingre_TextChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cmbcodingre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcodingre.SelectedIndexChanged

    End Sub
End Class
