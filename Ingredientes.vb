Imports System.Data.SqlClient

Public Class Ingredientes

    Dim loadingForm As Boolean


    Private Sub cargargrid()

        conecta()
        Dim cargar_datos_clientes As String = "SELECT cod_ingredientes AS 'Código', descripcion AS 'Ingrediente', costo AS 'Costo', cod_dieta AS '# Dieta' FROM ingredientes "
        Dim mostrar As New DataTable

        Using adpmostrar As New SqlDataAdapter(cargar_datos_clientes, conectar)

            adpmostrar.Fill(mostrar)

        End Using
        dgingredientes.DataSource = mostrar
        conectar.Close()


    End Sub



    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click

        If (txtdescripingre.Text IsNot "" And txtcosto.Text IsNot "" And txtcoddieta.Text IsNot "") Then

            Try
                conecta()
                Dim insertar_ingredientes As String = "insert into ingredientes(descripcion,costo,cod_dieta)values(@descripcion,@costo,@cod_dieta)"
                Dim insertar As New SqlCommand(insertar_ingredientes, conectar)
                insertar.Parameters.AddWithValue("@descripcion", txtdescripingre.Text)
                insertar.Parameters.AddWithValue("@costo", txtcosto.Text)
                insertar.Parameters.AddWithValue("@cod_dieta", txtcoddieta.Text)
                insertar.ExecuteNonQuery()

                conectar.Close()
            Catch ex As Exception
                MsgBox("Revise los Valores del Campo Dieta")
                conectar.Close()
            End Try


            loadingForm = False
            cargargrid()

            dgingredientes.ClearSelection()
            txtcodingre.Text = ""
            txtdescripingre.Text = ""
            txtcoddieta.Text = ""
            txtcosto.Text = ""
            loadingForm = True
        Else
            MsgBox("Campos no pueden quedar vacios")
        End If


        'dgingredientes.Rows.Add(txtcodingre.Text, txtdescripingre.Text, txtcoddieta.Text, txtcosto.Text)
        'txtcodingre.Text = ""
        'txtdescripingre.Text = ""
        'txtcoddieta.Text = ""
        'txtcosto.Text = ""

    End Sub

    Private Sub Ingredientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadingForm = False
        cargargrid()
        dgingredientes.ClearSelection()
        loadingForm = True

        tt_Ingrediente.SetToolTip(bteditar, "Seleccione una Fila para Editar")
        tt_Ingrediente.SetToolTip(btneliminar, "Seleccione una Fila para Eliminar")





        'dgingredientes.Columns.Add("Cod.Ingrediente", "Cod.Ingrediente")
        'dgingredientes.Columns.Add("Descripcion", "Descripcion")
        'dgingredientes.Columns.Add("Cod.Dieta", "Cod.Dieta")
        'dgingredientes.Columns.Add("Costo", "Costo")

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        tt_Ingrediente.SetToolTip(btneliminar, "")
        conecta()
        Dim eliminar As String = "delete from ingredientes  where cod_ingredientes=@cod_ingredientes"
        Dim procesar As New SqlCommand(eliminar, conectar)
        procesar.Parameters.AddWithValue("@cod_ingredientes", txtcodingre.Text)
        procesar.ExecuteNonQuery()
        conectar.Close()


        loadingForm = False
        cargargrid()
        dgingredientes.ClearSelection()

        txtcodingre.Text = ""
        txtdescripingre.Text = ""
        txtcoddieta.Text = ""
        txtcosto.Text = ""

        loadingForm = True

        btneliminar.Enabled = False
        bteditar.Enabled = False



        'dgingredientes.Rows.Remove(dgingredientes.CurrentRow)
    End Sub

    Private Sub bteditar_Click(sender As Object, e As EventArgs) Handles bteditar.Click
        tt_Ingrediente.SetToolTip(bteditar, "")
        conecta()

        Dim datos_ingredientes As String = "update ingredientes set descripcion=@descripcion,costo=@costo,cod_dieta=@cod_dieta where cod_ingredientes=@cod_ingredientes"
        Dim actualizar As New SqlCommand(datos_ingredientes, conectar)
        actualizar.Parameters.AddWithValue("@cod_ingredientes", txtcodingre.Text)
        actualizar.Parameters.AddWithValue("@descripcion", txtdescripingre.Text)
        actualizar.Parameters.AddWithValue("@costo", txtcosto.Text)
        actualizar.Parameters.AddWithValue("@cod_dieta", txtcoddieta.Text)

        actualizar.ExecuteNonQuery()
        conectar.Close()

        loadingForm = False
        cargargrid()
        dgingredientes.ClearSelection()

        txtcodingre.Text = ""
        txtdescripingre.Text = ""
        txtcoddieta.Text = ""
        txtcosto.Text = ""

        loadingForm = True


        bteditar.Enabled = False
        btneliminar.Enabled = False




    End Sub


    Private Sub dgingredientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgingredientes.CellContentClick
        ' Dim row As DataGridViewRow = dgingredientes.CurrentRow

    End Sub





    Private Sub txtcodingre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodingre.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
            tt_Ingrediente.SetToolTip(txtcodingre, "")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            tt_Ingrediente.SetToolTip(txtcodingre, "")
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
            tt_Ingrediente.SetToolTip(txtcodingre, "")
        Else
            e.Handled = True
            tt_Ingrediente.SetToolTip(txtcodingre, "Solo Acepta Numeros")


        End If
    End Sub

    Private Sub txtcoddieta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcoddieta.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
            tt_Ingrediente.SetToolTip(txtcoddieta, "")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            tt_Ingrediente.SetToolTip(txtcoddieta, "")
        ElseIf Char.IsSeparator(e.KeyChar) Then
            tt_Ingrediente.SetToolTip(txtcoddieta, "")
            e.Handled = False
        Else
            e.Handled = True
            tt_Ingrediente.SetToolTip(txtcoddieta, "Solo Acepta Numeros")

        End If
    End Sub

    Private Sub txtcosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcosto.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
            tt_Ingrediente.SetToolTip(txtcosto, "")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            tt_Ingrediente.SetToolTip(txtcosto, "")
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
            tt_Ingrediente.SetToolTip(txtcosto, "")
        Else
            e.Handled = True
            tt_Ingrediente.SetToolTip(txtcosto, "Solo Acepta Numeros")
        End If
    End Sub

    Private Sub txtdescripingre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdescripingre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
            tt_Ingrediente.SetToolTip(txtdescripingre, "")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            tt_Ingrediente.SetToolTip(txtdescripingre, "")
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
            tt_Ingrediente.SetToolTip(txtdescripingre, "")
        Else
            e.Handled = True
            tt_Ingrediente.SetToolTip(txtdescripingre, "Solo Acepta Caracteres")

        End If
    End Sub



    Private Sub btnatras_Click(sender As Object, e As EventArgs) Handles btnatras.Click
        Me.Close()
        Form3.Show()
    End Sub

    Private Sub txtcodingre_TextChanged(sender As Object, e As EventArgs) Handles txtcodingre.TextChanged

    End Sub

    Private Sub txtdescripingre_TextChanged(sender As Object, e As EventArgs) Handles txtdescripingre.TextChanged
        If (txtdescripingre.Text IsNot "") Then
            txtcoddieta.Enabled = True
        Else
            txtcoddieta.Enabled = False
        End If
    End Sub

    Private Sub txtcoddieta_TextChanged(sender As Object, e As EventArgs) Handles txtcoddieta.TextChanged
        If (txtcoddieta.Text IsNot "") Then
            txtcosto.Enabled = True
        Else
            txtcosto.Enabled = False
        End If
    End Sub

    Private Sub txtcosto_TextChanged(sender As Object, e As EventArgs) Handles txtcosto.TextChanged
        If (txtcosto.Text IsNot "") Then
            btnguardar.Enabled = True
        Else
            btnguardar.Enabled = False
        End If
    End Sub



    Private Sub txtdescripingre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtdescripingre.Validating
        Dim estado As Boolean

        estado = String.IsNullOrEmpty(txtdescripingre.Text)
        If (estado) Then

            ' e.Cancel = True
            ep_Ingredientes.SetError(txtdescripingre, "Campo No Puede Quedar Vacio")

        Else

            ' e.Cancel = False
            ep_Ingredientes.SetError(txtdescripingre, "")

        End If

    End Sub

    Private Sub txtcoddieta_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtcoddieta.Validating
        Dim estado As Boolean

        estado = String.IsNullOrEmpty(txtcoddieta.Text)
        If (estado) Then
            '  e.Cancel = True
            ep_Ingredientes.SetError(txtcoddieta, "Campo No Puede Quedar Vacio")
        Else
            ' e.Cancel = False
            ep_Ingredientes.SetError(txtcoddieta, "")
        End If
    End Sub

    Private Sub txtcosto_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtcosto.Validating
        Dim estado As Boolean

        estado = String.IsNullOrEmpty(txtcosto.Text)
        If (estado) Then
            ' e.Cancel = True
            ep_Ingredientes.SetError(txtcosto, "Campo No Puede Quedar Vacio")
        Else
            ' e.Cancel = False
            ep_Ingredientes.SetError(txtcosto, "")
        End If
    End Sub

    Private Sub dgingredientes_SelectionChanged(sender As Object, e As EventArgs) Handles dgingredientes.SelectionChanged
        If (loadingForm) Then

            Dim fila As Integer
            fila = dgingredientes.CurrentRow.Index


            bteditar.Enabled = True
            btneliminar.Enabled = True

            txtcodingre.Text = dgingredientes.Rows(fila).Cells(0).Value
            txtdescripingre.Text = dgingredientes.Rows(fila).Cells(1).Value
            txtcosto.Text = dgingredientes.Rows(fila).Cells(2).Value
            txtcoddieta.Text = dgingredientes.Rows(fila).Cells(3).Value

            btnguardar.Enabled = False
            txtdescripingre.Enabled = True
            txtcosto.Enabled = True
            txtcoddieta.Enabled = True


        End If


    End Sub

    Private Sub bteditar_MouseHover(sender As Object, e As EventArgs) Handles bteditar.MouseHover

    End Sub

    Private Sub bteditar_MouseMove(sender As Object, e As MouseEventArgs) Handles bteditar.MouseMove
        If (bteditar.Enabled <> True) Then
            tt_Ingrediente.SetToolTip(bteditar, "Seleccione una Fila para Editar")
        Else
            tt_Ingrediente.SetToolTip(bteditar, "")
        End If
    End Sub

    Private Sub bteditar_MouseUp(sender As Object, e As MouseEventArgs) Handles bteditar.MouseUp
        If (bteditar.Enabled <> True) Then
            tt_Ingrediente.SetToolTip(bteditar, "Seleccione una Fila para Editar")
        Else
            tt_Ingrediente.SetToolTip(bteditar, "")
        End If
    End Sub
End Class