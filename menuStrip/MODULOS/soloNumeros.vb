Module soloNumeros
    Public Sub soloNumerosTxt(ByRef e As System.Windows.Forms.KeyPressEventArgs)

        If (Char.IsDigit(e.KeyChar)) Then 'Aca verificamos si es una letra, si es asi lo excluye
            e.Handled = False 'Aca le decimos que lo excluya
        ElseIf (Char.IsControl(e.KeyChar)) Then  'Aca preguntamos si es una tecla de control
            e.Handled = False
        Else        'En este caso es porque ingreso un numero
            e.Handled = True    'lo incluye
        End If
    End Sub

    'Public Function sumar(x As Integer, y As Integer)
    'Dim suma As Double
    'suma = x + y
    'Return suma
    'End Function


End Module
