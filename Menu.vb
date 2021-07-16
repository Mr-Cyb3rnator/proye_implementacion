Public Class frm_Menu
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (lblprivilegio.Text <> "luis") Then
            Button1.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
            btn_VentaGanado.Enabled = True
            Button6.Enabled = True
            Button7.Enabled = True
            btn_Gasto.Enabled = True
            btn_Compra.Enabled = True

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Grupos.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Dieta.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Ingredientes.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_VentaGanado.Click
        Me.Hide()
        VentaGanado.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Clientes.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        estado_resultados.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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