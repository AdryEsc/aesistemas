Public Class abmClientes
    Dim cliente As New clientes()
    Dim resp As DialogResult

    Private Sub abmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDni.TabIndex = 0
        rbtTodos.Checked = True
        dtgCLientes.DataSource = cliente.listarClientes()
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
        Dim telefono As String = txtTelefono.Text



        If (dni = Nothing Or nombre = Nothing Or apellido = Nothing Or email = Nothing Or telefono = Nothing) Then
            MessageBox.Show("!Para agregar un cliente debe cargar todos los datos¡", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        Dim busqueda As Boolean = False
        Dim aux_dni As Integer = Integer.Parse(dni)
        busqueda = cliente.buscarCliente(aux_dni, email)

        If (busqueda = True) Then
            MessageBox.Show("El DNI o el EMAIL a ingresar ya existe en la base de datos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        cliente.insertarCliente(dni, nombre, apellido, email, telefono)
        dtgCLientes.DataSource = vbNull
        dtgCLientes.DataSource = cliente.listarClientes()
        optimizar()

    End Sub

    Public Sub optimizar()
        txtDni.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtEmail.Clear()
        txtTelefono.Clear()

        txtDni.Enabled = True
        txtEmail.Enabled = True

        'dtgCLientes.Columns(0).Width = 70
        'dtgCLientes.Columns(1).Width = 70
        'dtgCLientes.Columns(2).Width = 150
        'dtgCLientes.Columns(3).Width = 150
        'dtgCLientes.Columns(4).Width = 170
        'dtgCLientes.Columns(5).Width = 80
        'dtgCLientes.Columns(6).Width = 80
        'dtgCLientes.Columns(7).Width = 80

    End Sub

    Private Sub dtgUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgCLientes.CellContentClick
        txtDni.Text = dtgCLientes.Item(1, e.RowIndex).Value
        txtNombre.Text = dtgCLientes.Item(2, e.RowIndex).Value
        txtApellido.Text = dtgCLientes.Item(3, e.RowIndex).Value
        txtEmail.Text = dtgCLientes.Item(4, e.RowIndex).Value
        txtTelefono.Text = dtgCLientes.Item(5, e.RowIndex).Value


        txtDni.Enabled = False
        txtEmail.Enabled = False

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        dtgCLientes.DataSource = vbNull
        dtgCLientes.DataSource = cliente.listarClientes()
        optimizar()

    End Sub

    Private Sub rbtActivos_CheckedChanged(sender As Object, e As EventArgs) Handles rbtActivos.CheckedChanged
        dtgCLientes.DataSource = vbNull
        dtgCLientes.DataSource = cliente.listarClientesActivos()
        optimizar()
    End Sub

    Private Sub rbtTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rbtTodos.CheckedChanged
        dtgCLientes.DataSource = vbNull
        dtgCLientes.DataSource = cliente.listarClientes()
        optimizar()
    End Sub

    Private Sub rbtNoactivos_CheckedChanged(sender As Object, e As EventArgs) Handles rbtNoactivos.CheckedChanged
        dtgCLientes.DataSource = vbNull
        dtgCLientes.DataSource = cliente.listarClientesInactivos()
        optimizar()
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        Dim dni As String = txtDni.Text
        Dim nombre As String = txtNombre.Text
        Dim apellido As String = txtApellido.Text
        Dim email As String = txtEmail.Text
        Dim telefono As String = txtTelefono.Text


        If (dni = Nothing Or nombre = Nothing Or apellido = Nothing Or email = Nothing Or telefono = Nothing) Then
            MessageBox.Show("!Para actualizar un cliente debe cargar todos los datos¡", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        resp = MessageBox.Show("¿Esta seguro que desea modificar al cliente: " + nombre.ToString + " " + apellido.ToString + ", DNI: " + dni.ToString + "?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If (resp = DialogResult.Yes) Then
            cliente.actualizarCliente(dni, nombre, apellido, email, telefono)
            MessageBox.Show("¡El cliente: " + nombre.ToString + " " + apellido.ToString + ", DNI: " + dni.ToString + ", se actualizo con exito!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("¡No se realizo ningun cambio!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        dtgCLientes.DataSource = vbNull
        dtgCLientes.DataSource = cliente.listarClientes()
        optimizar()

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim dni As String = txtDni.Text
        Dim nombre As String = txtNombre.Text
        Dim apellido As String = txtApellido.Text
        Dim email As String = txtEmail.Text
        Dim telefono As String = txtTelefono.Text


        fechaActual.CustomFormat = "yyyy-mm-dd"
        Dim fechaSistema As String = Convert.ToString(fechaActual.Value)


        If (dni = Nothing Or email = Nothing) Then
            MessageBox.Show("!Para eliminar un cliente debe hacer click en el DNI¡", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim busqueda As Boolean = False
        Dim aux_dni As Integer = Integer.Parse(dni)
        busqueda = cliente.buscarCliente(aux_dni, email)

        If (busqueda = False) Then
            MessageBox.Show("El DNI ingresado no existe en nuestra base de datos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        resp = MessageBox.Show("¿Esta seguro que desea eliminar al cliente: " + nombre.ToString + " " + apellido.ToString + ", DNI: " + dni.ToString + "?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If (resp = DialogResult.Yes) Then
            cliente.eliminarCliente(dni, fechaSistema)
            MessageBox.Show("¡El cliente: " + nombre.ToString + " " + apellido.ToString + ", DNI: " + dni.ToString + ", quedo inactivo!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtgCLientes.DataSource = vbNull
            dtgCLientes.DataSource = cliente.listarClientes()
            optimizar()
        Else
            dtgCLientes.DataSource = vbNull
            dtgCLientes.DataSource = cliente.listarClientes()
            optimizar()
            Exit Sub
        End If

    End Sub

    Private Sub txtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusqueda.KeyPress
        soloLetrasTxt(e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dtgCLientes.DataSource = vbNull
        dtgCLientes.DataSource = cliente.busquedaRapida(txtBusqueda.Text)
        optimizar()
    End Sub
End Class