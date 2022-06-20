Module soloLetras
    Public Sub soloLetrasTxt(ByRef e As System.Windows.Forms.KeyPressEventArgs)

        If (Char.IsDigit(e.KeyChar)) Then 'Aca verificamos si es una letra, si es asi lo incluya
            e.Handled = True 'Aca le decimos que lo incluya
        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False
        Else        'En este caso es porque ingreso un numero
            e.Handled = False    'lo incluye
        End If
    End Sub
End Module
