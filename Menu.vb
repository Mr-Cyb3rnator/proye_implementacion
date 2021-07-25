Public Class frmMenu

    Dim strHelpPath As String = System.IO.Path.Combine(Application.StartupPath, “HelpGanado.chm”)
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (nivel = 1) Then
            btnGrupo.Enabled = True
            btnDietas.Enabled = True
            btnIngredientes.Enabled = True
            btnVentaGanado.Enabled = True
            btnClientes.Enabled = True
            btnBalance.Enabled = True
            btnGasto.Enabled = True
            btnCompra.Enabled = True
            btnCabezaGanado.Enabled = True

        Else
            btnGrupo.Enabled = True
            btnDietas.Enabled = True
            btnCabezaGanado.Enabled = True
            btnIngredientes.Enabled = False
            btnVentaGanado.Enabled = False
            btnClientes.Enabled = False
            btnBalance.Enabled = False
            btnGasto.Enabled = False
            btnCompra.Enabled = False
        End If
        HelpProvider1.HelpNamespace = strHelpPath
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGrupo.Click
        Me.Hide()
        Grupos.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnDietas.Click
        Me.Hide()
        Dieta.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnIngredientes.Click
        Me.Hide()
        Ingredientes.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnVentaGanado.Click
        Me.Hide()
        VentaGanado.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Me.Hide()
        Clientes.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnBalance.Click
        Me.Hide()
        estado_resultados.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCabezaGanado.Click
        Me.Hide()
        Cabeza_ganado.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnGasto.Click
        Me.Hide()
        Gasto.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnCompra.Click
        Me.Hide()
        Compra.Show()
    End Sub

    Private Sub btn_Reportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        Me.Hide()
        Reportes.Show()
    End Sub


    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If MsgBox("Deseas terminar la aplicación?", vbYesNo Or vbQuestion) = vbYes Then
            End
        Else

            Me.Show()
        End If

    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Help.ShowHelp(Me, HelpProvider1.HelpNamespace, HelpNavigator.TableOfContents)

    End Sub
End Class