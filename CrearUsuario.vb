Imports System.Data.SqlClient
Public Class CrearUsuario
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim conc As New SqlClient.SqlConnection
        conc.ConnectionString = " Data Source=DESKTOP-PE4OUB7;Initial Catalog=base_proyecto;Integrated Security=True "
        conc.Open()

        Dim gu As String = "update usuarios set usuario = @usua,contrasenia= @contra,tipo_usuario = @tusua where cod_usuario= @usuario"

        Dim ejecutar As New SqlCommand(gu, conc)
        ejecutar.Parameters.AddWithValue("@usuario", (txtcod.Text))
        ejecutar.Parameters.AddWithValue("@usua", (txtusuario.Text))
        ejecutar.Parameters.AddWithValue("@contra", (txtcontra.Text))
        ejecutar.Parameters.AddWithValue("@tusua", (txttipo.Text))

        ejecutar.ExecuteNonQuery()

        Dim datousuario As New DataTable
        Using adaptador As New SqlDataAdapter("Select * from usuarios", conc)
            adaptador.Fill(datousuario)
        End Using
        dtgcrear.DataSource = datousuario
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conc As New SqlClient.SqlConnection
        conc.ConnectionString = " Data Source=localhost;Initial Catalog=base_proyecto;Integrated Security=True "
        conc.Open()

        Dim gu As String = "insert into usuarios(cod_usuario,usuario,contrasenia,tipo_usuario) values(@cod_usuario,@usuario,@contrasenia,@tipo_usuario)"

        Dim ejecutar As New SqlCommand(gu, conc)
        ejecutar.Parameters.AddWithValue("@cod_usuario", (txtcod.Text))
        ejecutar.Parameters.AddWithValue("@usuario", (txtusuario.Text))
        ejecutar.Parameters.AddWithValue("@contrasenia", (txtcontra.Text))
        ejecutar.Parameters.AddWithValue("@tipo_usuario", (txttipo.Text))

        ejecutar.ExecuteNonQuery()

        Dim datousuario As New DataTable
        Using adaptador As New SqlDataAdapter("Select * from usuarios", conc)
            adaptador.Fill(datousuario)
        End Using
        dtgcrear.DataSource = datousuario
    End Sub

    Private Sub crearusuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conc As New SqlClient.SqlConnection
        conc.ConnectionString = "Data Source=localhost;Initial Catalog=base_proyecto;Integrated Security=True"
        conc.Open()

        Dim datousuario As New DataTable
        Using adaptador As New SqlDataAdapter("Select * from usuarios", conc)
            adaptador.Fill(datousuario)
        End Using
        dtgcrear.DataSource = datousuario
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub txtusuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtusuario.KeyPress
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


    Private Sub txttipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttipo.KeyPress
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

    Private Sub txtcontra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcontra.KeyPress
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

    Private Sub txtcod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcod.KeyPress
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim conc As New SqlClient.SqlConnection
        conc.ConnectionString = " Data Source=DESKTOP-DGNBGM2\SQLEXPRESS;Initial Catalog=base_proyecto;Integrated Security=True "
        conc.Open()

        Dim gu As String = "delete from usuarios where cod_usuario = @usuario "

        Dim ejecutar As New SqlCommand(gu, conc)
        ejecutar.Parameters.AddWithValue("@usuario", (txtcod.Text))

        ejecutar.ExecuteNonQuery()

        Dim datousuario As New DataTable
        Using adaptador As New SqlDataAdapter("Select * from usuarios", conc)
            adaptador.Fill(datousuario)
        End Using
        dtgcrear.DataSource = datousuario
    End Sub
End Class