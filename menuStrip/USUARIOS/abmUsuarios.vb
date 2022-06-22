Public Class abmUsuarios
    Dim user As New usuarios()
    Dim resp As MsgBoxResult

    Private Sub abmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDni.KeyPress
        soloNumerosTxt(e)
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        soloLetrasTxt(e)
    End Sub

    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        soloLetrasTxt(e)
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Dim dni As String = txtDni.Text
        Dim nombre As String = txtNombre.Text
        Dim apellido As String = txtApellido.Text
        Dim email As String = txtEmail.Text
        Dim usuario As String = txtUsuario.Text
        Dim contrasena As String = txtContrasena.Text
        Dim cargo As String = cmbCargo.SelectedItem

        If (dni = "" Or nombre = "" Or apellido = "" Or email = "" Or usuario = "" Or contrasena = "" Or cargo = "") Then
            MessageBox.Show("!Para agregar un usuario debe cargar todos los datos¡", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        user.insertarUsuario(dni, nombre, apellido, usuario, contrasena, email, cargo)

    End Sub

End Class