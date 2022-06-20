Public Class texboxSoloNumerosOletras
    Private Sub texboxSoloNumerosOletras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero1 As Integer
        Dim numero2 As Integer
        Dim resultado As Double

        If (num1.Text = "" Or num2.Text = "") Then
            MsgBox("Por favor ingrese ambos numeros", MsgBoxStyle.Exclamation)
        Else
            numero1 = num1.Text
            numero2 = num2.Text
            'resultado = sumar(numero1, numero2)
            MsgBox("La suma es: " + resultado.ToString)
            num1.Clear()
            num2.Clear()
        End If

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        soloNumerosTxt(e)
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        soloLetrasTxt(e)
    End Sub
End Class