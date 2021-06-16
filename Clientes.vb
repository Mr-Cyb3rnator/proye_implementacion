Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Clientes
    Dim loadingForm As Boolean

    Private Sub cargargrid()

        conecta()
        Dim cargar_datos_clientes As String = "select cod_cliente as 'Código cliente' , nombre as 'Nombre' , direcion as 'Dirección', telefono as 'Teléfono' from clientes"
        Dim mostrar As New DataTable

        Using adpmostrar As New SqlDataAdapter(cargar_datos_clientes, conectar)

            adpmostrar.Fill(mostrar)

        End Using
        DGclientes.DataSource = mostrar
        conectar.Close()


    End Sub


    Private Sub btagregar_Click(sender As Object, e As EventArgs) Handles btagregar.Click
        'DGclientes.Rows.Add(txtcodcliente.Text, txtnombre.Text, txtdireccion.Text, txttelefono.Text)
        If (txtnombre.Text IsNot "" And txttelefono.Text IsNot "" And txtdireccion.Text IsNot "") Then

            Try
                conecta()
                Dim insertar_cliente As String = "insert into cliente (nombre,telefono,direccion)values(@nombre,@telefono,@direccion)"
                Dim insertar As New SqlCommand(insertar_cliente, conectar)
                insertar.Parameters.AddWithValue("@nombre", txtnombre.Text)
                insertar.Parameters.AddWithValue("@telefono", txttelefono.Text)
                insertar.Parameters.AddWithValue("@direccion", txtdireccion.Text)
                insertar.ExecuteNonQuery()

                conectar.Close()
            Catch ex As Exception
                MsgBox("Revise los Valores")
                conectar.Close()
            End Try


            loadingForm = False
            cargargrid()

            DGclientes.ClearSelection()
            txtcodcliente.Text = ""
            txtnombre.Text = ""
            txtdireccion.Text = ""
            txttelefono.Text = ""
            loadingForm = True
        Else
            MsgBox("Campos no pueden quedar vacios")
        End If








        'conecta()
        'Dim insertar_clientes As String = "insert into clientes(nombre,direcion,telefono)values(@nombre,@direcion,@telefono)"
        'Dim insertar As New SqlCommand(insertar_clientes, conectar)
        'insertar.Parameters.AddWithValue("@nombre", txtnombre.Text)
        'insertar.Parameters.AddWithValue("@direcion", txtdireccion.Text)
        'insertar.Parameters.AddWithValue("@telefono", txttelefono.Text)

        'insertar.ExecuteNonQuery()



        'conectar.Close()
        'cargargrid()

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

        loadingForm = False
        cargargrid()
        DGclientes.ClearSelection()

        txtcodcliente.Text = ""
        txtnombre.Text = ""
        txtdireccion.Text = ""
        txttelefono.Text = ""

        loadingForm = True

        bteliminar.Enabled = False
        bteditar.Enabled = False




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
        loadingForm = False
        cargargrid()
        DGclientes.ClearSelection()
        loadingForm = True

        tt_cliente.SetToolTip(bteditar, "Seleccione una Fila para Editar")
        tt_cliente.SetToolTip(bteliminar, "Seleccione una Fila para Eliminar")

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
            tt_cliente.SetToolTip(txtdireccion, "Acepta Caracteres")

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
            tt_cliente.SetToolTip(txtdescripingre, "Solo Acepta Numeros")

        End If
    End Sub

    Private Sub txtcodcliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodcliente.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
            tt_cliente.SetToolTip(txtcodcliente, "")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            tt_cliente.SetToolTip(txtcodcliente, "")
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
            tt_cliente.SetToolTip(txtcodcliente, "")
        Else
            e.Handled = True
            tt_cliente.SetToolTip(txtcodcliente, "Solo Acepta Numeros")


        End If




        'If Char.IsNumber(e.KeyChar) Then
        '    e.Handled = False
        'ElseIf Char.IsControl(e.KeyChar) Then
        '    e.Handled = False
        'ElseIf Char.IsSeparator(e.KeyChar) Then
        '    e.Handled = False
        'Else
        '    e.Handled = True

        'End If

    End Sub

    Private Sub txtcodcliente_TextChanged(sender As Object, e As EventArgs) Handles txtcodcliente.TextChanged

    End Sub

    Private Sub DGclientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGclientes.CellContentClick
        Dim fila As Integer = DGclientes.CurrentCell.RowIndex

        txtcodcliente.Text = DGclientes(0, fila).Value.ToString()
        txtnombre.Text = DGclientes(1, fila).Value.ToString()
        txtdireccion.Text = DGclientes(2, fila).Value.ToString()
        txttelefono.Text = DGclientes(3, fila).Value.ToString()




    End Sub
    Private Sub DGclientes_SelectionChanged(sender As Object, e As EventArgs) Handles DGclientes.SelectionChanged
        If (loadingForm) Then

            Dim fila As Integer
            fila = DGclientes.CurrentRow.Index


            bteditar.Enabled = True
            bteliminar.Enabled = True

            txtcodcliente.Text = DGclientes.Rows(fila).Cells(0).Value
            txtnombre.Text = DGclientes.Rows(fila).Cells(1).Value
            txttelefono.Text = DGclientes.Rows(fila).Cells(2).Value
            txtdireccion.Text = DGclientes.Rows(fila).Cells(3).Value

            btagregar.Enabled = False
            txtnombre.Enabled = True
            txttelefono.Enabled = True
            txtdireccion.Enabled = True


        End If


    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged
        If (txtnombre.Text IsNot "") Then
            txtdireccion.Enabled = True
        Else
            txtdireccion.Enabled = False
        End If
    End Sub

    Private Sub txtdireccion_TextChanged(sender As Object, e As EventArgs) Handles txtdireccion.TextChanged
        If (txtdireccion.Text IsNot "") Then
            txttelefono.Enabled = True
        Else
            txttelefono.Enabled = False
        End If
    End Sub

    Private Sub txttelefono_TextChanged(sender As Object, e As EventArgs) Handles txttelefono.TextChanged
        If (txttelefono.Text IsNot "") Then
            btagregar.Enabled = True
        Else
            btagregar.Enabled = False
        End If
    End Sub

    Private Sub txtnombre_Validating(sender As Object, e As CancelEventArgs) Handles txtnombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre")
        End If
    End Sub

    Private Sub txtdireccion_Validating(sender As Object, e As CancelEventArgs) Handles txtdireccion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese la direccion")
        End If
    End Sub

    Private Sub txttelefono_Validating(sender As Object, e As CancelEventArgs) Handles txttelefono.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el Telefono")
        End If
    End Sub
End Class