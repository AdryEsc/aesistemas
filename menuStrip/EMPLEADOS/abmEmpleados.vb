Public Class abmEmpleados
    Dim empleado As New empleados()
    Dim usuario As New usuarios()
    Dim resp As DialogResult

    Dim idEmpleado As Integer
    Dim dni As Integer
    Dim nombres As String
    Dim apellidos As String
    Dim telefono As String
    Dim direccion As String
    Dim email As String
    Dim fechaNac As Date
    Dim fechaIng As Date
    Dim fechaSal As Date
    Dim idUsuario As Integer


    Private Sub abmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDni.TabIndex = 0
        rbtTodos.Checked = True

    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click

        If (txtDni.Text = Nothing Or txtNombres.Text = Nothing Or txtApellidos.Text = Nothing Or txtTelefono.Text = Nothing Or txtDireccion.Text = Nothing Or txtEmail.Text = Nothing Or txtIdUsuario.Text = Nothing) Then
            MessageBox.Show("!Para agregar un empleado debe cargar todos los datos¡", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        dni = Convert.ToInt32(txtDni.Text)
        nombres = txtNombres.Text
        apellidos = txtApellidos.Text
        telefono = txtTelefono.Text
        direccion = txtDireccion.Text
        email = txtEmail.Text
        fechaNac = dtpFecNac.Value.Date
        fechaIng = dtpFecIng.Value.Date
        fechaSal = dtpFecSal.Value.Date
        idUsuario = Convert.ToInt32(txtIdUsuario.Text)

        Dim busqueda As Boolean = False
        busqueda = empleado.buscarEmpleado(dni, email)

        If (busqueda = True) Then
            MessageBox.Show("El DNI o el EMAIL a ingresar ya existe en la base de datos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        empleado.insertarEmpleado(dni, nombres, apellidos, fechaNac, direccion, email, telefono, fechaIng, fechaSal, idUsuario)
        usuario.actualizarOcupado(idUsuario)
        dtgEmpleados.DataSource = vbNull
        dtgEmpleados.DataSource = empleado.listarEmpleados()
        optimizar()

    End Sub

    Public Sub optimizar()
        txtIdEmpleado.Clear()
        txtDni.Clear()
        txtNombres.Clear()
        txtApellidos.Clear()
        txtTelefono.Clear()
        txtDireccion.Clear()
        txtEmail.Clear()
        dtpFecNac.Value = Date.Today
        dtpFecIng.Value = Date.Today
        dtpFecSal.Value = Date.Today
        txtIdUsuario.Clear()

        dtgEmpleados.Columns(0).Width = 80
        dtgEmpleados.Columns(1).Width = 60
        dtgEmpleados.Columns(2).Width = 130
        dtgEmpleados.Columns(3).Width = 130
        dtgEmpleados.Columns(4).Width = 100
        dtgEmpleados.Columns(5).Width = 150
        dtgEmpleados.Columns(6).Width = 170
        dtgEmpleados.Columns(7).Width = 75
        dtgEmpleados.Columns(8).Width = 80
        dtgEmpleados.Columns(9).Width = 75
        dtgEmpleados.Columns(10).Width = 40
        dtgEmpleados.Columns(11).Width = 50
        dtgEmpleados.Columns(11).Width = 70

        txtDni.Enabled = True
        txtEmail.Enabled = True

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        dtgEmpleados.DataSource = vbNull
        dtgEmpleados.DataSource = empleado.listarEmpleados()
        optimizar()

    End Sub

    Private Sub rbtActivos_CheckedChanged(sender As Object, e As EventArgs) Handles rbtActivos.CheckedChanged
        dtgEmpleados.DataSource = vbNull
        dtgEmpleados.DataSource = empleado.listarEmpleadosActivos()
        optimizar()
    End Sub

    Private Sub rbtNoactivos_CheckedChanged(sender As Object, e As EventArgs) Handles rbtNoactivos.CheckedChanged
        dtgEmpleados.DataSource = vbNull
        dtgEmpleados.DataSource = empleado.listarEmpleadosNoActivos()
        optimizar()
    End Sub

    Private Sub rbtTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rbtTodos.CheckedChanged
        dtgEmpleados.DataSource = vbNull
        dtgEmpleados.DataSource = empleado.listarEmpleados()
        optimizar()
    End Sub

    Private Sub txtNombres_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombres.KeyPress
        soloLetrasTxt(e)
    End Sub

    Private Sub txtApellidos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellidos.KeyPress
        soloLetrasTxt(e)
    End Sub

    Private Sub txtDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDni.KeyPress
        soloNumerosTxt(e)
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        soloNumerosControl(e)
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        usuariosParaEmpleados.ShowDialog()
    End Sub

    Private Sub dtgEmpleados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgEmpleados.CellClick
        txtDni.Enabled = False
        txtEmail.Enabled = False

        txtIdEmpleado.Text = dtgEmpleados.Item(0, e.RowIndex).Value
        txtDni.Text = dtgEmpleados.Item(1, e.RowIndex).Value
        txtNombres.Text = dtgEmpleados.Item(2, e.RowIndex).Value
        txtApellidos.Text = dtgEmpleados.Item(3, e.RowIndex).Value
        dtpFecNac.Value = dtgEmpleados.Item(4, e.RowIndex).Value
        txtDireccion.Text = dtgEmpleados.Item(5, e.RowIndex).Value
        txtEmail.Text = dtgEmpleados.Item(6, e.RowIndex).Value
        txtTelefono.Text = dtgEmpleados.Item(7, e.RowIndex).Value
        dtpFecIng.Value = dtgEmpleados.Item(8, e.RowIndex).Value
        dtpFecSal.Value = dtgEmpleados.Item(9, e.RowIndex).Value
        txtIdUsuario.Text = dtgEmpleados.Item(11, e.RowIndex).Value
        'txtIdEmpleado.Text = dtgEmpleados.Item(9, e.RowIndex).Value
        'txtIdEmpleado.Text = dtgEmpleados.Item(10, e.RowIndex).Value
        'MsgBox(dtpFecNac.Value)
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        'idEmpleado = Convert.ToInt32(txtIdEmpleado.Text)
        'dni = Convert.ToInt32(txtDni.Text)
        nombres = txtNombres.Text
        apellidos = txtApellidos.Text
        telefono = txtTelefono.Text
        direccion = txtDireccion.Text
        'email = txtEmail.Text
        fechaNac = dtpFecNac.Value.Date
        fechaIng = dtpFecIng.Value.Date
        fechaSal = dtpFecSal.Value.Date
        'idUsuario = Convert.ToInt32(txtIdUsuario.Text)

        If (txtNombres.Text = Nothing Or txtApellidos.Text = Nothing Or txtTelefono.Text = Nothing Or txtDireccion.Text = Nothing) Then
            MessageBox.Show("!Para actualizar un empleado debe cargar todos los datos¡", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        idEmpleado = Convert.ToInt32(txtIdEmpleado.Text)
        dni = Convert.ToInt32(txtDni.Text)
        idUsuario = Convert.ToInt32(txtIdUsuario.Text)

        resp = MessageBox.Show("¿Esta seguro que desea modificar al empleado: " + nombres.ToString + " " + apellidos.ToString + ", DNI: " + dni.ToString + "?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If (resp = DialogResult.Yes) Then
            empleado.actualizarEmpleado(idEmpleado, nombres, apellidos, fechaNac, direccion, telefono, fechaIng, fechaSal, idUsuario)
            MessageBox.Show("¡El empleado: " + nombres.ToString + " " + apellidos.ToString + ", DNI: " + dni.ToString + ", se actualizo con exito!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("¡No se realizo ningun cambio!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        dtgEmpleados.DataSource = vbNull
        dtgEmpleados.DataSource = empleado.listarEmpleados()
        optimizar()

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click

        nombres = txtNombres.Text
        apellidos = txtApellidos.Text
        telefono = txtTelefono.Text
        direccion = txtDireccion.Text
        email = txtEmail.Text
        fechaNac = dtpFecNac.Value.Date
        fechaIng = dtpFecIng.Value.Date
        fechaSal = dtpFecSal.Value.Date

        If (txtNombres.Text = Nothing Or txtApellidos.Text = Nothing Or txtTelefono.Text = Nothing Or txtDireccion.Text = Nothing) Then
            MessageBox.Show("!Para eliminar un empleado primero debe hacerlo click en la tabla¡", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'fechaActual.CustomFormat = "yyyy-mm-dd"
        'Dim fechaSistema As String = 'Convert.ToString(fechaActual.Value)

        idEmpleado = Convert.ToInt32(txtIdEmpleado.Text)
        dni = Convert.ToInt32(txtDni.Text)
        idUsuario = Convert.ToInt32(txtIdUsuario.Text)

        Dim busqueda As Boolean = False
        'Dim aux_dni As Integer = Integer.Parse(dni)
        busqueda = empleado.buscarEmpleado(dni, email)

        If (busqueda = False) Then
            MessageBox.Show("El DNI ingresado no existe en nuestra base de datos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        resp = MessageBox.Show("Esta accion solo dejara inactivo al empleado: " + nombres.ToString + " " + apellidos.ToString + ", DNI: " + dni.ToString + ", ¿Desea continuar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If (resp = DialogResult.Yes) Then
            empleado.eliminarEmpleado(idEmpleado, fechaActual.Value.Date)
            MessageBox.Show("¡El empleado: " + nombres.ToString + " " + apellidos.ToString + ", DNI: " + dni.ToString + ", quedo inactivo!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtgEmpleados.DataSource = vbNull
            dtgEmpleados.DataSource = empleado.listarEmpleados()
            optimizar()
        Else
            MessageBox.Show("¡No se realizo ningun cambio!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtgEmpleados.DataSource = vbNull
            dtgEmpleados.DataSource = empleado.listarEmpleados()
            optimizar()
            Exit Sub
        End If

    End Sub

    Private Sub txtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusqueda.KeyPress
        soloLetrasTxt(e)
    End Sub

    Private Sub btnBusquedaRapida_Click(sender As Object, e As EventArgs) Handles btnBusquedaRapida.Click
        dtgEmpleados.DataSource = vbNull
        dtgEmpleados.DataSource = empleado.busquedaRapida(txtBusqueda.Text)
        optimizar()
    End Sub
End Class