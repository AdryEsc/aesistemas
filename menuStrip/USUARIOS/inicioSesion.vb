Public Class inicioSesion
    Dim user As New usuarios()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim encontrado As Boolean = False
        Dim rol As String = ""
        Dim usuario As String = txtUsuario.Text
        Dim contrasena As String = txtContrasena.Text

        If (usuario = "" Or contrasena = "") Then
            MessageBox.Show("¡Por favor ingrese usuario y contraseña!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        encontrado = user.inicioSesion(usuario, contrasena)

        If (encontrado = True) Then
            'rol = user.obtenerRol(usuario, contrasena)
            If (rol = "Administrador") Then
                AppAESistemas.ShowDialog()
                txtUsuario.Clear()
                txtContrasena.Clear()
            Else

                AppAESistemasEmp.ShowDialog()
                txtUsuario.Clear()
                txtContrasena.Clear()
            End If
        Else
                MessageBox.Show("¡Usuario o contraseña incorrectos!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If



    End Sub

    Private Sub inicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp_fechaSistema.Refresh()
        dtp_fechaSistema.Format = DateTimePickerFormat.Custom
        dtp_fechaSistema.CustomFormat = "dd/MM/yyyy HH:mm tt"
        dtp_fechaSistema.Value = DateTime.Now
        dtp_fechaSistema.ShowUpDown = False


    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim correo As String
        correo = InputBox("Por favor, ingrese su correo electronico para recibir su contraseña")
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        txtContrasena.UseSystemPasswordChar = False
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtp_fechaSistema.ValueChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class