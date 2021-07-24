Imports System.Data.SqlClient

Public Class Ingredientes

    Dim loadingForm As Boolean
    Dim fillingtxt As Boolean



    Private Sub cargargrid()

        conecta()
        Dim cargar_datos_ingredientes As String = "SELECT cod_ingredientes AS 'Código', descripcion AS 'Ingrediente', costo AS 'Costo', cod_dieta AS '# Dieta' FROM ingredientes "
        Dim mostrar As New DataTable

        Using adpmostrar As New SqlDataAdapter(cargar_datos_ingredientes, conectar)
            adpmostrar.Fill(mostrar)

        End Using
        dvgIngredientes.DataSource = mostrar
        conectar.Close()


    End Sub



    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If (txtDescripcion.Text IsNot "" And txtCosto.Text IsNot "" And txtCodDieta.Text IsNot "") Then

            Try
                conecta()
                Dim insertar_ingredientes As String = "insert into ingredientes(descripcion,costo,cod_dieta)values(@descripcion,@costo,@cod_dieta)"
                Dim insertar As New SqlCommand(insertar_ingredientes, conectar)
                insertar.Parameters.AddWithValue("@descripcion", txtDescripcion.Text)
                insertar.Parameters.AddWithValue("@costo", txtCosto.Text)
                insertar.Parameters.AddWithValue("@cod_dieta", txtCodDieta.Text)
                insertar.ExecuteNonQuery()

                conectar.Close()
            Catch ex As Exception
                MsgBox("Revise los Valores del Campo Dieta")
                conectar.Close()
            End Try


            loadingForm = False
            cargargrid()

            dvgIngredientes.ClearSelection()
            txtCodIngredientes.Text = ""
            txtDescripcion.Text = ""
            txtCodDieta.Text = ""
            txtCosto.Text = ""

            btnEditar.Enabled = False
            btnEliminar.Enabled = False


            'loadingForm = True
        Else
            MsgBox("Campos no pueden quedar vacios")
        End If



    End Sub

    Private Sub Ingredientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadingForm = True

        cargargrid()
        dvgIngredientes.ClearSelection()
        loadingForm = False

        tt_Ingrediente.SetToolTip(btnEditar, "Seleccione una Fila para Editar")
        tt_Ingrediente.SetToolTip(btnEliminar, "Seleccione una Fila para Eliminar")





        'dgingredientes.Columns.Add("Cod.Ingrediente", "Cod.Ingrediente")
        'dgingredientes.Columns.Add("Descripcion", "Descripcion")
        'dgingredientes.Columns.Add("Cod.Dieta", "Cod.Dieta")
        'dgingredientes.Columns.Add("Costo", "Costo")

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        'tt_Ingrediente.SetToolTip(btneliminar, "")
        conecta()
        Dim eliminar As String = "delete from ingredientes  where cod_ingredientes=@cod_ingredientes"
        Dim procesar As New SqlCommand(eliminar, conectar)
        procesar.Parameters.AddWithValue("@cod_ingredientes", txtCodIngredientes.Text)
        procesar.ExecuteNonQuery()
        conectar.Close()


        loadingForm = True
        cargargrid()
        dvgIngredientes.ClearSelection()

        txtCodIngredientes.Text = ""
        txtDescripcion.Text = ""
        txtCodDieta.Text = ""
        txtCosto.Text = ""

        loadingForm = False

        btnEliminar.Enabled = False
        btnEditar.Enabled = False

        'dgingredientes.Rows.Remove(dgingredientes.CurrentRow)
    End Sub

    Private Sub bteditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        'tt_Ingrediente.SetToolTip(bteditar, "")
        conecta()

        Dim datos_ingredientes As String = "update ingredientes set descripcion=@descripcion,costo=@costo,cod_dieta=@cod_dieta where cod_ingredientes=@cod_ingredientes"
        Dim actualizar As New SqlCommand(datos_ingredientes, conectar)
        actualizar.Parameters.AddWithValue("@cod_ingredientes", txtCodIngredientes.Text)
        actualizar.Parameters.AddWithValue("@descripcion", txtDescripcion.Text)
        actualizar.Parameters.AddWithValue("@costo", txtCosto.Text)
        actualizar.Parameters.AddWithValue("@cod_dieta", txtCodDieta.Text)

        actualizar.ExecuteNonQuery()
        conectar.Close()

        loadingForm = True
        cargargrid()
        dvgIngredientes.ClearSelection()

        txtCodIngredientes.Text = ""
        txtDescripcion.Text = ""
        txtCodDieta.Text = ""
        txtCosto.Text = ""

        loadingForm = False


        btnEditar.Enabled = False
        btnEliminar.Enabled = False




    End Sub


    Private Sub dgingredientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgIngredientes.CellContentClick

        ' Dim row As DataGridViewRow = dgingredientes.CurrentRow

        Dim fila As Integer = dvgIngredientes.CurrentCell.RowIndex

        txtCodIngredientes.Text = dvgIngredientes(0, fila).Value.ToString()
        txtDescripcion.Text = dvgIngredientes(1, fila).Value.ToString()
        txtCodDieta.Text = dvgIngredientes(2, fila).Value.ToString()
        txtCosto.Text = dvgIngredientes(3, fila).Value.ToString()


    End Sub





    Private Sub txtcodingre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodIngredientes.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
            tt_Ingrediente.SetToolTip(txtCodIngredientes, "")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            tt_Ingrediente.SetToolTip(txtCodIngredientes, "")
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
            tt_Ingrediente.SetToolTip(txtCodIngredientes, "")
        Else
            e.Handled = True
            tt_Ingrediente.SetToolTip(txtCodIngredientes, "Solo Acepta Numeros")


        End If
    End Sub

    Private Sub txtcoddieta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodDieta.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
            tt_Ingrediente.SetToolTip(txtCodDieta, "")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            tt_Ingrediente.SetToolTip(txtCodDieta, "")
        ElseIf Char.IsSeparator(e.KeyChar) Then
            tt_Ingrediente.SetToolTip(txtCodDieta, "")
            e.Handled = False
        Else
            e.Handled = True
            tt_Ingrediente.SetToolTip(txtCodDieta, "Solo Acepta Numeros")

        End If
    End Sub

    Private Sub txtcosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCosto.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
            tt_Ingrediente.SetToolTip(txtCosto, "")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            tt_Ingrediente.SetToolTip(txtCosto, "")
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
            tt_Ingrediente.SetToolTip(txtCosto, "")
        Else
            e.Handled = True
            tt_Ingrediente.SetToolTip(txtCosto, "Solo Acepta Numeros")
        End If
    End Sub

    Private Sub txtdescripingre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
            tt_Ingrediente.SetToolTip(txtDescripcion, "")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            tt_Ingrediente.SetToolTip(txtDescripcion, "")
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
            tt_Ingrediente.SetToolTip(txtDescripcion, "")
        Else
            e.Handled = True
            tt_Ingrediente.SetToolTip(txtDescripcion, "Solo Acepta Caracteres")

        End If
    End Sub



    Private Sub btnatras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click

        Me.Close()
        frm_Menu.Show()
    End Sub


    Private Sub txtdescripingre_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged
        If (txtDescripcion.Text IsNot "") Then
            txtCodDieta.Enabled = True
            ep_Ingredientes.SetError(txtDescripcion, "")
        Else
            txtCodDieta.Enabled = False

            If (Not btnEditar.Enabled) Then

                ep_Ingredientes.SetError(txtDescripcion, "Campo No Puede Quedar Vacio")
            End If
        End If

    End Sub

    Private Sub txtcoddieta_TextChanged(sender As Object, e As EventArgs) Handles txtCodDieta.TextChanged
        If (txtCodDieta.Text IsNot "") Then
            txtCosto.Enabled = True
            ep_Ingredientes.SetError(txtCodDieta, "")
        Else
            txtCosto.Enabled = False
            If (Not btnEditar.Enabled) Then
                ep_Ingredientes.SetError(txtCodDieta, "Campo No Puede Quedar Vacio")
            End If
        End If

    End Sub

    Private Sub txtcosto_TextChanged(sender As Object, e As EventArgs) Handles txtCosto.TextChanged
        If (txtCosto.Text IsNot "") Then
            btnAgregar.Enabled = True
            ep_Ingredientes.SetError(txtCosto, "")
        Else
            btnAgregar.Enabled = False
            If (Not btnEditar.Enabled) Then
                ep_Ingredientes.SetError(txtCosto, "Campo No Puede Quedar Vacio")
            End If
        End If

    End Sub







    Private Sub dgingredientes_SelectionChanged(sender As Object, e As EventArgs) Handles dvgIngredientes.SelectionChanged

        If (Not loadingForm) Then

            Dim fila As Integer

            fila = dvgIngredientes.CurrentRow.Index


            btnEditar.Enabled = True
            btnEliminar.Enabled = True


            ' fillingtxt = True
            txtCodIngredientes.Text = dvgIngredientes.Rows(fila).Cells(0).Value
            txtDescripcion.Text = dvgIngredientes.Rows(fila).Cells(1).Value
            txtCosto.Text = dvgIngredientes.Rows(fila).Cells(2).Value
            txtCodDieta.Text = dvgIngredientes.Rows(fila).Cells(3).Value
            'fillingtxt = False


            btnAgregar.Enabled = False
            txtDescripcion.Enabled = True
            txtCosto.Enabled = True
            txtCodDieta.Enabled = True


        End If


    End Sub



    Private Sub txtdescripingre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDescripcion.Validating
        Dim estado As Boolean

        estado = String.IsNullOrEmpty(txtDescripcion.Text)
        If (estado And Not fillingtxt) Then

            e.Cancel = True
            ep_Ingredientes.SetError(txtDescripcion, "Campo No Puede Quedar Vacio")
        Else
            e.Cancel = False
            ep_Ingredientes.SetError(txtDescripcion, "")
        End If
    End Sub

    Private Sub txtcoddieta_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCodDieta.Validating
        Dim estado As Boolean

        estado = String.IsNullOrEmpty(txtCodDieta.Text)
        If (estado And Not fillingtxt) Then

            e.Cancel = True
            ep_Ingredientes.SetError(txtCodDieta, "Campo No Puede Quedar Vacio")
        Else
            e.Cancel = False
            ep_Ingredientes.SetError(txtCodDieta, "")
        End If
    End Sub

    Private Sub txtcosto_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCosto.Validating
        Dim estado As Boolean

        estado = String.IsNullOrEmpty(txtCosto.Text)
        If (estado And Not fillingtxt) Then

            e.Cancel = True
            ep_Ingredientes.SetError(txtCosto, "Campo No Puede Quedar Vacio")
        Else
            e.Cancel = False
            ep_Ingredientes.SetError(txtCosto, "")
        End If
    End Sub

End Class