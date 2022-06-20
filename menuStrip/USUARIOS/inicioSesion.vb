Public Class inicioSesion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AppAESistemas.ShowDialog()

    End Sub

    Private Sub inicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        MsgBox("Hemos mandado un mje a tu correo.", MsgBoxStyle.Exclamation)
    End Sub
End Class