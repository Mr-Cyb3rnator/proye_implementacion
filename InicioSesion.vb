Imports System.Data.SqlClient
Public Class Form1
    Dim pri As String
    Private Sub btncrear_Click(sender As Object, e As EventArgs) Handles btncrear.Click
        Me.Hide()
        CrearUsuario.Show()
    End Sub

    Private Sub btnentrar_Click(sender As Object, e As EventArgs) Handles btnentrar.Click
        Dim conc As New SqlClient.SqlConnection
        conc.ConnectionString = "Data Source=localhost;Initial Catalog=base_proyecto;Integrated Security=True "
        conc.Open()

        Dim sql As String = "select * from usuarios where usuario='" & txtusu1.Text & "'and contrasenia='" & txtpass.Text & "'"

        Dim cmd As New SqlCommand(sql, conc)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader

        If txtusu1.Text = "luis" And txtpass.Text = "123" Then
            MessageBox.Show("BIENVENIDO AL SISTEMA")
            pri = txtusu1.Text
            Form3.lblprivilegio.Text = pri
            Me.Hide()
            Form3.Show()
        ElseIf txtusu1.Text = "Dilcia" And txtpass.Text = "123" Then
            MessageBox.Show("BIENVENIDO AL SISTEMA")
            pri = txtusu1.Text
            Form3.lblprivilegio.Text = pri
            Me.Hide()
            Form3.Show()

        ElseIf txtusu1.Text = "eduar" And txtpass.Text = "12" Then
            MessageBox.Show("BIENVENIDO AL SISTEMA USUARIO")
            pri = txtusu1.Text
            Form3.lblprivilegio.Text = pri
            Me.Hide()
            Form3.Show()
        Else
            MessageBox.Show("Error")
            txtusu1.Text = ""
            txtpass.Text = ""
            txtusu1.Text = ""
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conc As New SqlClient.SqlConnection
        conc.ConnectionString = " Data Source = localhost;Initial Catalog=base_proyecto;Integrated Security=True "
        conc.Open()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub txtusu1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtusu1.KeyPress

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

    Private Sub txtpass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpass.KeyPress

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

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtpass_TextChanged(sender As Object, e As EventArgs) Handles txtpass.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
