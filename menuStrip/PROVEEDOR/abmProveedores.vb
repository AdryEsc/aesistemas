Public Class abmProveedores
    Dim proveedor As New proveedores()
    Dim resp As DialogResult

    Private Sub abmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombre.TabIndex = 0
        rbtTodos.Checked = True


        'dtgProveedores.DataSource = vbNull
        'dtgProveedores.DataSource = proveedor.listarProveedores()

        'dtgProveedores.Columns(0).Width = 80


        'Try
        'dtgProveedores. = 80
        'dtgProveedores.Columns(1).Width = 200
        'dtgProveedores.Columns(2).Width = 90
        'dtgProveedores.Columns(3).Width = 200
        'dtgProveedores.Columns(4).Width = 90
        'dtgProveedores.Columns(5).Width = 200
        'dtgProveedores.Columns(6).Width = 80
        'Catch ex As Exception
        '    MessageBox.Show(e.ToString)
        'End Try

    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Dim nombre As String = txtNombre.Text
        Dim cuit As String = txtCuit.Text
        Dim direccion As String = txtDireccion.Text
        Dim telefono As String = txtTelefono.Text
        Dim email As String = txtEmail.Text



        If (nombre = Nothing Or cuit = Nothing Or direccion = Nothing Or telefono = Nothing Or email = Nothing) Then
            MessageBox.Show("!Para agregar un proveedor debe cargar todos los datos¡", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        Dim busqueda As Boolean = False
        'Dim aux_dni As Integer = Integer.Parse(dni)
        busqueda = proveedor.buscarProveedor(cuit, email)

        If (busqueda = True) Then
            MessageBox.Show("El CUIT o el EMAIL a ingresar ya existe en la base de datos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        proveedor.insertarProveedor(nombre, cuit, direccion, telefono, email)
        dtgProveedores.DataSource = vbNull
        dtgProveedores.DataSource = proveedor.listarProveedores()
        optimizar()

    End Sub

    Public Sub optimizar()
        txtNombre.Clear()
        txtCuit.Clear()
        txtDireccion.Clear()
        txtEmail.Clear()
        txtTelefono.Clear()

        txtCuit.Enabled = True
        txtEmail.Enabled = True

        dtgProveedores.Columns(0).Width = 80
        dtgProveedores.Columns(1).Width = 200
        dtgProveedores.Columns(2).Width = 90
        dtgProveedores.Columns(3).Width = 200
        dtgProveedores.Columns(4).Width = 90
        dtgProveedores.Columns(5).Width = 200
        dtgProveedores.Columns(6).Width = 80
        'dtgProveedores.Columns(6).Width = 80

    End Sub

    Private Sub dtgUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgProveedores.CellContentClick
        txtNombre.Text = dtgProveedores.Item(1, e.RowIndex).Value
        txtCuit.Text = dtgProveedores.Item(2, e.RowIndex).Value
        txtDireccion.Text = dtgProveedores.Item(3, e.RowIndex).Value
        txtTelefono.Text = dtgProveedores.Item(4, e.RowIndex).Value
        txtEmail.Text = dtgProveedores.Item(5, e.RowIndex).Value


        txtCuit.Enabled = False
        txtEmail.Enabled = False

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        dtgProveedores.DataSource = vbNull
        dtgProveedores.DataSource = proveedor.listarProveedores()
        optimizar()

    End Sub

    Private Sub rbtActivos_CheckedChanged(sender As Object, e As EventArgs) Handles rbtActivos.CheckedChanged
        dtgProveedores.DataSource = vbNull
        dtgProveedores.DataSource = proveedor.listarProveedoresActivos()
        optimizar()
    End Sub

    Private Sub rbtTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rbtTodos.CheckedChanged
        dtgProveedores.DataSource = vbNull
        dtgProveedores.DataSource = proveedor.listarProveedores()
        optimizar()
    End Sub

    Private Sub rbtNoactivos_CheckedChanged(sender As Object, e As EventArgs) Handles rbtNoactivos.CheckedChanged
        dtgProveedores.DataSource = vbNull
        dtgProveedores.DataSource = proveedor.listarProveedoresInactivos()
        optimizar()
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        Dim nombre As String = txtNombre.Text
        Dim cuit As String = txtCuit.Text
        Dim direccion As String = txtDireccion.Text
        Dim telefono As String = txtTelefono.Text
        Dim email As String = txtEmail.Text

        If (nombre = Nothing Or cuit = Nothing Or direccion = Nothing Or telefono = Nothing Or email = Nothing) Then
            MessageBox.Show("!Para actualizar un proveedor debe cargar todos los datos¡", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        resp = MessageBox.Show("¿Esta seguro que desea modificar al proveedor: " + nombre.ToString + ", CUIT: " + cuit.ToString + "?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If (resp = DialogResult.Yes) Then
            proveedor.actualizarProveedor(nombre, cuit, direccion, telefono, email)
            MessageBox.Show("¡El proveedor: " + nombre.ToString + ", CUIT: " + cuit.ToString + ", se actualizo con exito!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("¡No se realizo ningun cambio!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        dtgProveedores.DataSource = vbNull
        dtgProveedores.DataSource = proveedor.listarProveedores()
        optimizar()

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim nombre As String = txtNombre.Text
        Dim cuit As String = txtCuit.Text
        Dim apellido As String = txtDireccion.Text
        Dim telefono As String = txtTelefono.Text
        Dim email As String = txtEmail.Text


        fechaActual.CustomFormat = "yyyy-mm-dd"
        Dim fechaSistema As String = Convert.ToString(fechaActual.Value)


        If (cuit = Nothing Or email = Nothing) Then
            MessageBox.Show("!Para eliminar un proveedor debe hacer click en el CUIT¡", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim busqueda As Boolean = False
        'Dim aux_dni As Integer = Integer.Parse(dni)
        busqueda = proveedor.buscarProveedor(cuit, email)

        If (busqueda = False) Then
            MessageBox.Show("El CUIT ingresado no existe en nuestra base de datos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        resp = MessageBox.Show("¿Esta seguro que desea eliminar al proveedor: " + nombre.ToString + ", CUIT: " + cuit.ToString + "?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If (resp = DialogResult.Yes) Then
            proveedor.eliminarProveedor(cuit, fechaSistema)
            MessageBox.Show("¡El proveedor: " + nombre.ToString + ", CUIT: " + cuit.ToString + ", quedo inactivo!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtgProveedores.DataSource = vbNull
            dtgProveedores.DataSource = proveedor.listarProveedores()
            optimizar()
        Else
            MessageBox.Show("¡No se realizo ningun cambio!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtgProveedores.DataSource = vbNull
            dtgProveedores.DataSource = proveedor.listarProveedores()
            optimizar()
            Exit Sub
        End If

    End Sub

    Private Sub txtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusqueda.KeyPress
        soloLetrasTxt(e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dtgProveedores.DataSource = vbNull
        dtgProveedores.DataSource = proveedor.busquedaRapida(txtBusqueda.Text)
        optimizar()
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        soloLetrasTxt(e)
    End Sub

    Private Sub txtCuit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuit.KeyPress
        soloNumerosControl(e)
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        soloNumerosControl(e)
    End Sub

    Private Sub dtgProveedores_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dtgProveedores.CellEndEdit
        'If (e.RowIndex >= 0 AndAlso e.ColumnIndex = decimalcolumn) Then
        '    Dim cell As DataGridViewCell = dtgProveedores.Rows(e.RowIndex).Cells(e.ColumnIndex)
        '    cell.Value = Convert.ToDecimal(cell.Value)
        'End If
    End Sub
End Class