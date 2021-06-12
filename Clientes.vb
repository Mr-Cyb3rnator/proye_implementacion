Imports System.Data.SqlClient

Public Class Clientes

    Private Sub cargargrid()

        conecta()
        Dim cargar_datos_clientes As String = "select * from clientes "
        Dim mostrar As New DataTable

        Using adpmostrar As New SqlDataAdapter(cargar_datos_clientes, conectar)

            adpmostrar.Fill(mostrar)

        End Using
        DGclientes.DataSource = mostrar
        conectar.Close()


    End Sub


    Private Sub btagregar_Click(sender As Object, e As EventArgs) Handles btagregar.Click
        'DGclientes.Rows.Add(txtcodcliente.Text, txtnombre.Text, txtdireccion.Text, txttelefono.Text)


        conecta()
        Dim insertar_clientes As String = "insert into clientes(nombre,direcion,telefono)values(@nombre,@direcion,@telefono)"
        Dim insertar As New SqlCommand(insertar_clientes, conectar)
        insertar.Parameters.AddWithValue("@nombre", txtnombre.Text)
        insertar.Parameters.AddWithValue("@direcion", txtdireccion.Text)
        insertar.Parameters.AddWithValue("@telefono", txttelefono.Text)

        insertar.ExecuteNonQuery()



        conectar.Close()
        cargargrid()

    End Sub

    Private Sub bteliminar_Click(sender As Object, e As EventArgs) Handles bteliminar.Click
        'DGclientes.Rows.Remove(DGclientes.CurrentRow)

        conecta()
        Dim eliminar As String = "delete from clientes where cod_cliente=@cod_cliente "
        Dim procesar As New SqlCommand(eliminar, conectar)
        procesar.Parameters.AddWithValue("@cod_cliente", txtcodcliente.Text)
        procesar.ExecuteNonQuery()
        conectar.Close()
        cargargrid()




    End Sub


    Private Sub bteditar_Click(sender As Object, e As EventArgs) Handles bteditar.Click

        conecta()

        Dim datos As String = "update clientes set nombre=@nombre,telefono=@telefono where cod_cliente=@cod_cliente "
        Dim actualizar As New SqlCommand(datos, conectar)
        actualizar.Parameters.AddWithValue("@cod_cliente", txtcodcliente.Text)
        actualizar.Parameters.AddWithValue("@nombre", txtnombre.Text)
        actualizar.Parameters.AddWithValue("@Telefono", txttelefono.Text)

        actualizar.ExecuteNonQuery()
        conectar.Close()
        cargargrid()

    End Sub

    Private Sub btnatras_Click(sender As Object, e As EventArgs) Handles btnatras.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargargrid()

    End Sub

    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
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

    Private Sub txtdireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdireccion.KeyPress
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

    Private Sub txttelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelefono.KeyPress
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
End Class