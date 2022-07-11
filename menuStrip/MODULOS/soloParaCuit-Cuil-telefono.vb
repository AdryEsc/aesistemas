Module soloParaCuit_Cuil_telefono
    Public Sub soloNumerosControl(ByRef e As System.Windows.Forms.KeyPressEventArgs)

        If (e.KeyChar = "-") Then 'Aca verificamos si es una letra, si es asi lo incluya
            e.Handled = False 'Aca le decimos que lo incluya
        ElseIf (Char.IsNumber(e.KeyChar)) Then
            e.Handled = False
        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False
        Else        'En este caso es porque ingreso un numero
            e.Handled = True   'lo incluye
        End If
    End Sub

    Public Sub soloNumerosDecimal(ByRef e As System.Windows.Forms.KeyPressEventArgs)

        If (e.KeyChar = ".") Then 'Aca verificamos si es una letra, si es asi lo incluya
            e.Handled = False 'Aca le decimos que lo incluya
        ElseIf (Char.IsNumber(e.KeyChar)) Then
            e.Handled = False
        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False
        Else        'En este caso es porque ingreso un numero
            e.Handled = True   'lo incluye
        End If
    End Sub

End Module
