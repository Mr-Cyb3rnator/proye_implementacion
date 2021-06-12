Imports System.Data.SqlClient

Public Class Ingredientes

    Private Sub cargargrid()

        conecta()
        Dim cargar_datos_clientes As String = "select * from ingredientes "
        Dim mostrar As New DataTable

        Using adpmostrar As New SqlDataAdapter(cargar_datos_clientes, conectar)

            adpmostrar.Fill(mostrar)

        End Using
        dgingredientes.DataSource = mostrar
        conectar.Close()


    End Sub



    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click




        conecta()
        Dim insertar_ingredientes As String = "insert into ingredientes(descripcion,costo,cod_dieta)values(@descripcion,@costo,@cod_dieta)"
        Dim insertar As New SqlCommand(insertar_ingredientes, conectar)
        insertar.Parameters.AddWithValue("@descripcion", txtdescripingre.Text)
        insertar.Parameters.AddWithValue("@costo", txtcosto.Text)
        insertar.Parameters.AddWithValue("@cod_dieta", txtcoddieta.Text)

        insertar.ExecuteNonQuery()



        conectar.Close()
        cargargrid()



        'dgingredientes.Rows.Add(txtcodingre.Text, txtdescripingre.Text, txtcoddieta.Text, txtcosto.Text)
        'txtcodingre.Text = ""
        'txtdescripingre.Text = ""
        'txtcoddieta.Text = ""
        'txtcosto.Text = ""

    End Sub

    Private Sub Ingredientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargargrid()





        'dgingredientes.Columns.Add("Cod.Ingrediente", "Cod.Ingrediente")
        'dgingredientes.Columns.Add("Descripcion", "Descripcion")
        'dgingredientes.Columns.Add("Cod.Dieta", "Cod.Dieta")
        'dgingredientes.Columns.Add("Costo", "Costo")

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click

        conecta()
        Dim eliminar As String = "delete from ingredientes  where cod_ingredientes=@cod_ingredientes"
        Dim procesar As New SqlCommand(eliminar, conectar)
        procesar.Parameters.AddWithValue("@cod_ingredientes", txtcodingre.Text)
        procesar.ExecuteNonQuery()
        conectar.Close()
        cargargrid()



        'dgingredientes.Rows.Remove(dgingredientes.CurrentRow)
    End Sub

    Private Sub bteditar_Click(sender As Object, e As EventArgs) Handles bteditar.Click

        conecta()

        Dim datos_ingredientes As String = "update ingredientes set descripcion=@descripcion,costo=@costo,cod_dieta=@cod_dieta where cod_ingredientes=@cod_ingredientes"
        Dim actualizar As New SqlCommand(datos_ingredientes, conectar)
        actualizar.Parameters.AddWithValue("@cod_ingredientes", txtcodingre.Text)
        actualizar.Parameters.AddWithValue("@descripcion", txtdescripingre.Text)
        actualizar.Parameters.AddWithValue("@costo", txtcosto.Text)
        actualizar.Parameters.AddWithValue("@cod_dieta", txtcoddieta.Text)

        actualizar.ExecuteNonQuery()
        conectar.Close()
        cargargrid()



    End Sub


    Private Sub dgingredientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgingredientes.CellContentClick
        ' Dim row As DataGridViewRow = dgingredientes.CurrentRow
    End Sub



    Private Sub btnatras_Click(sender As Object, e As EventArgs) Handles btnatras.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub txtcodingre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodingre.KeyPress
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

    Private Sub txtcosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcosto.KeyPress
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

    Private Sub txtdescripingre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdescripingre.KeyPress
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
End Class