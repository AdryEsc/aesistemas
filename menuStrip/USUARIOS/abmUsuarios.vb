Public Class abmUsuarios
    Dim user As New usuarios()
    Dim resp As MsgBoxResult

    Private Sub abmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbtTodos.Checked = True
        dtgUsuarios.DataSource = user.listarUsuarios()
        optimizar()
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

        Dim busqueda As Boolean
        Dim aux_dni As Integer = Integer.Parse(dni)
        busqueda = user.buscarUsuario(aux_dni, email)

        If (busqueda = True) Then
            MessageBox.Show("El DNI o el email a ingresar ya existe en la base de datos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        user.insertarUsuario(dni, nombre, apellido, usuario, contrasena, email, cargo)
        dtgUsuarios.DataSource = vbNull
        dtgUsuarios.DataSource = user.listarUsuarios()

    End Sub

    Public Sub optimizar()
        txtDni.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtEmail.Clear()
        txtUsuario.Clear()
        txtContrasena.Clear()
        cmbCargo.Refresh()

        dtgUsuarios.Columns(0).Width = 70
        dtgUsuarios.Columns(1).Width = 70
        dtgUsuarios.Columns(2).Width = 150
        dtgUsuarios.Columns(3).Width = 150
        dtgUsuarios.Columns(4).Width = 100
        dtgUsuarios.Columns(5).Width = 100
        dtgUsuarios.Columns(6).Width = 170
        dtgUsuarios.Columns(7).Width = 80
        dtgUsuarios.Columns(8).Width = 80
        dtgUsuarios.Columns(9).Width = 50
    End Sub

    Private Sub dtgUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgUsuarios.CellContentClick
        txtDni.Text = dtgUsuarios.Item(1, e.RowIndex).Value
        txtNombre.Text = dtgUsuarios.Item(2, e.RowIndex).Value
        txtApellido.Text = dtgUsuarios.Item(3, e.RowIndex).Value
        txtUsuario.Text = dtgUsuarios.Item(4, e.RowIndex).Value
        txtContrasena.Text = dtgUsuarios.Item(5, e.RowIndex).Value
        txtEmail.Text = dtgUsuarios.Item(6, e.RowIndex).Value
        cmbCargo.SelectedItem = dtgUsuarios.Item(7, e.RowIndex).Value

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtDni.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtEmail.Clear()
        txtUsuario.Clear()
        txtContrasena.Clear()

    End Sub

    Private Sub rbtActivos_CheckedChanged(sender As Object, e As EventArgs) Handles rbtActivos.CheckedChanged
        dtgUsuarios.DataSource = vbNull
        dtgUsuarios.DataSource = user.listarUsuariosActivos()
        optimizar()
    End Sub

    Private Sub rbtTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rbtTodos.CheckedChanged
        dtgUsuarios.DataSource = vbNull
        dtgUsuarios.DataSource = user.listarUsuarios()
        optimizar()
    End Sub

    Private Sub rbtNoactivos_CheckedChanged(sender As Object, e As EventArgs) Handles rbtNoactivos.CheckedChanged
        dtgUsuarios.DataSource = vbNull
        dtgUsuarios.DataSource = user.listarUsuariosInactivos()
        optimizar()
    End Sub
End Class