Module Validaciones

    'Funcion para validar que los campos solo aceptan numeros
    Public Function CampoValidacionNumeros(e As KeyPressEventArgs) As Boolean
        Dim state As Boolean

        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If

        state = e.Handled
        Return state
    End Function

    'Funcion para validar los campos que solo aceptan letras
    Public Function CampoValidacionLetras(e As KeyPressEventArgs) As Boolean
        Dim state As Boolean

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If

        state = e.Handled
        Return state
    End Function

End Module
