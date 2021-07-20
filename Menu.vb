Public Class frm_Menu
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (nivel = 1) Then
            btn_Grupo.Enabled = True
            btn_Dietas.Enabled = True
            btn_Ingredientes.Enabled = True
            btn_VentaGanado.Enabled = True
            btn_Clientes.Enabled = True
            btn_Balance.Enabled = True
            btn_Gasto.Enabled = True
            btn_Compra.Enabled = True
            btn_CabezaGanado.Enabled = True

        Else
            btn_Grupo.Enabled = True
            btn_Dietas.Enabled = True
            btn_CabezaGanado.Enabled = True
            btn_Ingredientes.Enabled = False
            btn_VentaGanado.Enabled = False
            btn_Clientes.Enabled = False
            btn_Balance.Enabled = False
            btn_Gasto.Enabled = False
            btn_Compra.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Grupo.Click
        Me.Hide()
        Grupos.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_Dietas.Click
        Me.Hide()
        Dieta.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_Ingredientes.Click
        Me.Hide()
        Ingredientes.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_VentaGanado.Click
        Me.Hide()
        VentaGanado.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btn_Clientes.Click
        Me.Hide()
        Clientes.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btn_Balance.Click
        Me.Hide()
        estado_resultados.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_CabezaGanado.Click
        Me.Hide()
        Cabeza_ganado.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btn_Gasto.Click
        Me.Hide()
        Gasto.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btn_Compra.Click
        Me.Hide()
        Compra.Show()
    End Sub


    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If MsgBox("Deseas terminar la aplicación?", vbYesNo Or vbQuestion) = vbYes Then
            End
        Else

            Me.Show()
        End If

    End Sub
End Class