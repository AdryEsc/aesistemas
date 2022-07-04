Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration

Public Class abmUsuarios
    Dim user As New usuarios()
    Dim resp As DialogResult
    Dim strComando As String
    Dim conexion As String
    Dim adapter As SqlDataAdapter
    Dim data As DataSet

    Dim aux_cargo As Integer

    Private Sub abmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'txtDni.TabIndex = 0
        rbtTodos.Checked = True
        'dtgUsuarios.DataSource = vbNull
        'dtgUsuarios.DataSource = user.listarUsuarios()

        conexion = "Data Source=COVID\SQLEXPRESS;Initial Catalog=AESistemas;Persist Security Info=True;User ID=sa;Password=Adry-49686"
        strComando = "Select * from cargos"
        adapter = New System.Data.SqlClient.SqlDataAdapter(strComando, conexion)
        data = New DataSet
        adapter.Fill(data)
        cmbCargos.DataSource = data.Tables(0)
        cmbCargos.DisplayMember = "nombre"
        cmbCargos.ValueMember = "idCargo"

        'Dim value As Object = cmbCargos.SelectedValue

        'If (value IsNot Nothing) Then
        '    aux_cargo = Convert.ToInt32(value)
        'End If

        'MsgBox(aux_cargo)

    End Sub

    Private Sub txtDni_KeyPress(sender As Object, e As KeyPressEventArgs)
        soloNumerosTxt(e)
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs)
        soloLetrasTxt(e)
    End Sub

    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs)
        soloLetrasTxt(e)
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        'Dim dni As String = txtDni.Text
        'Dim nombre As String = txtNombre.Text
        'Dim apellido As String = txtApellido.Text
        'Dim email As String = txtEmail.Text
        Dim usuario As String = txtUsuario.Text
        Dim contrasena As String = txtContrasena.Text
        Dim value As Object = cmbCargos.SelectedValue
        If (value IsNot Nothing) Then
            aux_cargo = Convert.ToInt32(value)
        End If

        If (usuario = Nothing Or contrasena = Nothing) Then
            MessageBox.Show("!Para agregar un usuario debe cargar todos los datos¡", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        Dim busqueda As Boolean = False
        'Dim aux_dni As Integer = Integer.Parse(dni)
        busqueda = user.buscarUsuario(usuario, contrasena)

        If (busqueda = True) Then
            MessageBox.Show("El usuario y/o la contraseña a ingresar ya existe en la base de datos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        user.insertarUsuario(usuario, contrasena, aux_cargo)
        dtgUsuarios.DataSource = vbNull
        dtgUsuarios.DataSource = user.listarUsuarios()
        optimizar()

    End Sub

    Public Sub optimizar()

        txtIdusuario.Clear()
        txtUsuario.Clear()
        txtContrasena.Clear()
        cmbCargos.Refresh()


        'dtgUsuarios.Columns(0).Width = 70
        'dtgUsuarios.Columns(1).Width = 70
        'dtgUsuarios.Columns(2).Width = 150
        'dtgUsuarios.Columns(3).Width = 150
        'dtgUsuarios.Columns(4).Width = 100
        'dtgUsuarios.Columns(5).Width = 100
        'dtgUsuarios.Columns(6).Width = 170
        'dtgUsuarios.Columns(7).Width = 80
        'dtgUsuarios.Columns(8).Width = 80
        'dtgUsuarios.Columns(9).Width = 50
    End Sub

    Private Sub dtgUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgUsuarios.CellContentClick

        'txtIdusuario.Text = dtgUsuarios.Item(0, e.RowIndex).Value
        'txtUsuario.Text = dtgUsuarios.Item(1, e.RowIndex).Value
        'txtContrasena.Text = dtgUsuarios.Item(2, e.RowIndex).Value


    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        dtgUsuarios.DataSource = vbNull
        dtgUsuarios.DataSource = user.listarUsuarios()
        optimizar()

    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        'Dim dni As String = txtDni.Text
        'Dim nombre As String = txtNombre.Text
        'Dim apellido As String = txtApellido.Text
        'Dim email As String = txtEmail.Text

        Dim usuario As String = txtUsuario.Text
        Dim contrasena As String = txtContrasena.Text
        Dim value As Object = cmbCargos.SelectedValue

        If (value IsNot Nothing) Then
            aux_cargo = Convert.ToInt32(value)
        End If

        If (usuario = Nothing Or contrasena = Nothing) Then
            MessageBox.Show("!Para actualizar un usuario debe cargar todos los datos¡", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        Dim idUsuario As Integer = Convert.ToInt32(txtIdusuario.Text)

        resp = MessageBox.Show("¿Esta seguro que desea modificar al usuario: " + usuario.ToString + "?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If (resp = DialogResult.Yes) Then
            user.actualizarUsuario(idUsuario, usuario, contrasena, aux_cargo)
            MessageBox.Show("¡El usuario: " + usuario.ToString + ", se actualizo con exito!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("¡No se realizo ningun cambio!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        dtgUsuarios.DataSource = vbNull
        dtgUsuarios.DataSource = user.listarUsuarios()
        optimizar()

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click

        Dim usuario As String = txtUsuario.Text
        Dim contrasena As String = txtContrasena.Text
        'Dim idCargo As Integer = cmbCargos.ValueMember


        'fechaActual.CustomFormat = "yyyy-mm-dd"
        'Dim fechaSistema As String = Convert.ToString(fechaActual.Value)


        If (usuario = Nothing Or contrasena = Nothing) Then
            MessageBox.Show("!Para eliminar un usuario debe hacer click en la tabla¡", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        Dim busqueda As Boolean = False
        Dim busqueda2 As Boolean = False
        'Dim aux_dni As Integer = Integer.Parse(dni)
        busqueda = user.buscarUsuario(usuario, contrasena)

        If (busqueda = False) Then
            MessageBox.Show("El usuario ingresado no existe en nuestra base de datos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        busqueda2 = user.buscarSiEsOcupado(usuario, contrasena)
        'MsgBox(busqueda2)
        'Exit Sub
        If (busqueda2 = True) Then
            resp = MessageBox.Show("¿Este usuario esta OCUPADO, esta seguro que desea elimiarlo?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            If (resp = DialogResult.Yes) Then
                Dim idUsuario As Integer = Convert.ToInt32(txtIdusuario.Text)
                user.eliminarUsuario(idUsuario)
                MessageBox.Show("¡El usuario: " + usuario.ToString + ", fue elimiado co exito!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtgUsuarios.DataSource = vbNull
                dtgUsuarios.DataSource = user.listarUsuarios()
                optimizar()
                Exit Sub
            Else
                dtgUsuarios.DataSource = vbNull
                dtgUsuarios.DataSource = user.listarUsuarios()
                optimizar()
                Exit Sub
            End If
        End If

        resp = MessageBox.Show("¿Esta seguro que desea eliminar al usuario: " + usuario.ToString + "?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If (resp = DialogResult.Yes) Then
            Dim idUsuario As Integer = Convert.ToInt32(txtIdusuario.Text)
            user.eliminarUsuario(idUsuario)
            MessageBox.Show("¡El usuario: " + usuario.ToString + ", fue elimiado co exito!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtgUsuarios.DataSource = vbNull
            dtgUsuarios.DataSource = user.listarUsuarios()
            optimizar()
        Else
            dtgUsuarios.DataSource = vbNull
            dtgUsuarios.DataSource = user.listarUsuarios()
            optimizar()
            Exit Sub
        End If



    End Sub

    Private Sub txtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusqueda.KeyPress
        soloLetrasTxt(e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dtgUsuarios.DataSource = vbNull
        dtgUsuarios.DataSource = user.busquedaRapida(txtBusqueda.Text)
        optimizar()
    End Sub

    Private Sub dtgUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgUsuarios.CellClick
        txtIdusuario.Text = dtgUsuarios.Item(0, e.RowIndex).Value
        txtUsuario.Text = dtgUsuarios.Item(1, e.RowIndex).Value
        txtContrasena.Text = dtgUsuarios.Item(2, e.RowIndex).Value
    End Sub

    Private Sub rbtTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rbtTodos.CheckedChanged
        dtgUsuarios.DataSource = vbNull
        dtgUsuarios.DataSource = user.listarUsuarios()
    End Sub

    Private Sub rbtOcupados_CheckedChanged(sender As Object, e As EventArgs) Handles rbtOcupados.CheckedChanged
        dtgUsuarios.DataSource = vbNull
        dtgUsuarios.DataSource = user.listarUsuariosOcupados()
    End Sub

    Private Sub rbtLibres_CheckedChanged(sender As Object, e As EventArgs) Handles rbtLibres.CheckedChanged
        dtgUsuarios.DataSource = vbNull
        dtgUsuarios.DataSource = user.listarUsuariosNoOcupados()
    End Sub
End Class