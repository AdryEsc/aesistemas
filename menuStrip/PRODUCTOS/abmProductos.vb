Public Class abmProductos
    Dim producto As New productos()
    'Dim producto2 As New productos()

    Dim resp As DialogResult

    Dim idProducto As Integer
    Dim descripcion As String
    Dim costo As Decimal
    Dim venta As Decimal
    Dim stock As Decimal
    Dim idProveedor As Integer
    Dim idCatProd As Integer


    Private Sub abmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDescipcion.TabIndex = 0
        rbtTodos.Checked = True
        'rbtAux.Checked = True
        producto.comboboxProveedores(cmbProveedor)
        producto.comboboxCatProd(cmbCatProd)

    End Sub

    Public Sub optimizar()
        txtIdProducto.Clear()
        txtDescipcion.Clear()
        txtCosto.Clear()
        txtVenta.Clear()
        dtpFecAlta.Enabled = True
        dtpFecAlta.Value = Date.Today
        txtStock.Clear()

        producto.comboboxProveedores(cmbProveedor)
        producto.comboboxCatProd(cmbCatProd)

        btn10porc.BackColor = Color.Transparent
        btn20porc.BackColor = Color.Transparent
        btn30porc.BackColor = Color.Transparent
        btn40porc.BackColor = Color.Transparent
        btn50porc.BackColor = Color.Transparent

        dtgProductos.Columns(0).Width = 90
        dtgProductos.Columns(1).Width = 300
        dtgProductos.Columns(2).Width = 90
        dtgProductos.Columns(3).Width = 90
        dtgProductos.Columns(4).Width = 90
        dtgProductos.Columns(5).Width = 300
        dtgProductos.Columns(6).Width = 170
        dtgProductos.Columns(7).Width = 70
        dtgProductos.Columns(8).Width = 50
        'dtgEmpleados.Columns(9).Width = 75
        'dtgEmpleados.Columns(10).Width = 40
        'dtgEmpleados.Columns(11).Width = 50
        'dtgEmpleados.Columns(11).Width = 70


    End Sub

    Private Sub rbtTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rbtTodos.CheckedChanged
        dtgProductos.DataSource = vbNull
        dtgProductos.DataSource = producto.listarProductos()
        optimizar()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        dtgProductos.DataSource = vbNull
        dtgProductos.DataSource = producto.listarProductos()
        optimizar()
    End Sub

    Private Sub txtCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCosto.KeyPress
        soloNumerosDecimal(e)

    End Sub

    Private Sub txtVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVenta.KeyPress
        soloNumerosDecimal(e)
    End Sub

    Private Sub txtStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStock.KeyPress
        soloNumerosDecimal(e)
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click

        If (txtDescipcion.Text = Nothing Or txtCosto.Text = Nothing Or txtVenta.Text = Nothing Or txtStock.Text = Nothing) Then
            MessageBox.Show("!Para agregar un usuario debe cargar todos los datos¡", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        descripcion = txtDescipcion.Text

        costo = Convert.ToDecimal(txtCosto.Text)
        venta = Convert.ToDecimal(txtVenta.Text)
        stock = Convert.ToDecimal(txtStock.Text)


        idProveedor = Convert.ToInt32(cmbProveedor.SelectedValue)
        idCatProd = Convert.ToInt32(cmbCatProd.SelectedValue)

        Dim busqueda As Boolean = False
        busqueda = producto.buscarProducto(descripcion)

        If (busqueda = True) Then
            MessageBox.Show("Ya existe en la base de datos un producto con esta descripcion", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        producto.insertarProducto(descripcion, costo, venta, idProveedor, stock, dtpFecAlta.Value.Date, idCatProd)
        dtgProductos.DataSource = vbNull
        dtgProductos.DataSource = producto.listarProductos()
        optimizar()
    End Sub

    Private Sub rbtActivos_CheckedChanged(sender As Object, e As EventArgs) Handles rbtActivos.CheckedChanged
        dtgProductos.DataSource = vbNull
        dtgProductos.DataSource = producto.listarProductosActivos()
        optimizar()
    End Sub

    Private Sub rbtNoactivos_CheckedChanged(sender As Object, e As EventArgs) Handles rbtNoactivos.CheckedChanged
        dtgProductos.DataSource = vbNull
        dtgProductos.DataSource = producto.listarProductosInactivos()
        optimizar()
    End Sub

    Private Sub dtgProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgProductos.CellClick
        dtpFecAlta.Enabled = False
        'rbtAux.Checked = True
        txtIdProducto.Text = dtgProductos.Item(0, e.RowIndex).Value
        txtDescipcion.Text = dtgProductos.Item(1, e.RowIndex).Value
        txtCosto.Text = dtgProductos.Item(2, e.RowIndex).Value
        txtVenta.Text = dtgProductos.Item(3, e.RowIndex).Value
        txtStock.Text = dtgProductos.Item(4, e.RowIndex).Value
        cmbProveedor.Text = dtgProductos.Item(5, e.RowIndex).Value
        cmbCatProd.Text = dtgProductos.Item(6, e.RowIndex).Value
        dtpFecAlta.Value = dtgProductos.Item(7, e.RowIndex).Value

        '    dtpFecIng.Value = dtgEmpleados.Item(8, e.RowIndex).Value
        '    dtpFecSal.Value = dtgEmpleados.Item(9, e.RowIndex).Value
        '    txtIdUsuario.Text = dtgEmpleados.Item(11, e.RowIndex).Value
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click


        If (txtDescipcion.Text = Nothing Or txtCosto.Text = Nothing Or txtVenta.Text = Nothing Or txtStock.Text = Nothing) Then
            MessageBox.Show("!Para actualizar un producto debe cargar todos los datos¡", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        idProducto = Convert.ToInt32(txtIdProducto.Text)
        descripcion = txtDescipcion.Text

        costo = Convert.ToDecimal(txtCosto.Text)
        venta = Convert.ToDecimal(txtVenta.Text)
        stock = Convert.ToDecimal(txtStock.Text)


        idProveedor = Convert.ToInt32(cmbProveedor.SelectedValue)
        idCatProd = Convert.ToInt32(cmbCatProd.SelectedValue)

        resp = MessageBox.Show("¿Esta seguro que desea modificar el producto: " + descripcion.ToString + "?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If (resp = DialogResult.Yes) Then
            producto.actualizarProducto(idProducto, descripcion, costo, venta, idProveedor, stock, idCatProd)
            MessageBox.Show("¡El producto: " + descripcion.ToString + ", se actualizo con exito!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("¡No se realizo ningun cambio!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        dtgProductos.DataSource = vbNull
        dtgProductos.DataSource = producto.listarProductos()
        optimizar()
    End Sub

    Private Sub btn10porc_Click(sender As Object, e As EventArgs) Handles btn10porc.Click
        If (txtCosto.Text = Nothing) Then
            MsgBox("Primero ingrese el costo del producto")
            Exit Sub
        End If
        Dim aux As Decimal
        aux = Convert.ToDecimal(txtCosto.Text)
        txtVenta.Text = aux * 1.1
        btn10porc.BackColor = Color.Yellow
        btn20porc.BackColor = Color.Transparent
        btn30porc.BackColor = Color.Transparent
        btn40porc.BackColor = Color.Transparent
        btn50porc.BackColor = Color.Transparent
    End Sub

    Private Sub btn20porc_Click(sender As Object, e As EventArgs) Handles btn20porc.Click
        If (txtCosto.Text = Nothing) Then
            MsgBox("Primero ingrese el costo del producto")
            Exit Sub
        End If
        Dim aux As Decimal
        aux = Convert.ToDecimal(txtCosto.Text)
        txtVenta.Text = aux * 1.2
        btn10porc.BackColor = Color.Transparent
        btn20porc.BackColor = Color.Yellow
        btn30porc.BackColor = Color.Transparent
        btn40porc.BackColor = Color.Transparent
        btn50porc.BackColor = Color.Transparent
    End Sub

    Private Sub btn30porc_Click(sender As Object, e As EventArgs) Handles btn30porc.Click
        If (txtCosto.Text = Nothing) Then
            MsgBox("Primero ingrese el costo del producto")
            Exit Sub
        End If
        Dim aux As Decimal
        aux = Convert.ToDecimal(txtCosto.Text)
        txtVenta.Text = aux * 1.3
        btn10porc.BackColor = Color.Transparent
        btn20porc.BackColor = Color.Transparent
        btn30porc.BackColor = Color.Yellow
        btn40porc.BackColor = Color.Transparent
        btn50porc.BackColor = Color.Transparent
    End Sub

    Private Sub btn40porc_Click(sender As Object, e As EventArgs) Handles btn40porc.Click
        If (txtCosto.Text = Nothing) Then
            MsgBox("Primero ingrese el costo del producto")
            Exit Sub
        End If
        Dim aux As Decimal
        aux = Convert.ToDecimal(txtCosto.Text)
        txtVenta.Text = aux * 1.4
        btn10porc.BackColor = Color.Transparent
        btn20porc.BackColor = Color.Transparent
        btn30porc.BackColor = Color.Transparent
        btn40porc.BackColor = Color.Yellow
        btn50porc.BackColor = Color.Transparent
    End Sub

    Private Sub btn50porc_Click(sender As Object, e As EventArgs) Handles btn50porc.Click
        If (txtCosto.Text = Nothing) Then
            MsgBox("Primero ingrese el costo del producto")
            Exit Sub
        End If
        Dim aux As Decimal
        aux = Convert.ToDecimal(txtCosto.Text)
        txtVenta.Text = aux * 1.5
        btn10porc.BackColor = Color.Transparent
        btn20porc.BackColor = Color.Transparent
        btn30porc.BackColor = Color.Transparent
        btn40porc.BackColor = Color.Transparent
        btn50porc.BackColor = Color.Yellow
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If (txtDescipcion.Text = Nothing Or txtCosto.Text = Nothing Or txtVenta.Text = Nothing Or txtStock.Text = Nothing) Then
            MessageBox.Show("!Para eliminar un producto debe seleccionarlo haciendo click en la tabla¡", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        descripcion = txtDescipcion.Text
        idProducto = Convert.ToInt32(txtIdProducto.Text)

        resp = MessageBox.Show("Esta accion solo dejara inactivo al producto: " + descripcion.ToString + ", ¿Desea continuar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If (resp = DialogResult.Yes) Then
            producto.eliminarProducto(idProducto)
            MessageBox.Show("¡El producto: " + descripcion.ToString + ", quedo inactivo!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtgProductos.DataSource = vbNull
            dtgProductos.DataSource = producto.listarProductos()
            optimizar()
        Else
            MessageBox.Show("¡No se realizo ningun cambio!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtgProductos.DataSource = vbNull
            dtgProductos.DataSource = producto.listarProductos()
            optimizar()
            Exit Sub
        End If

    End Sub

    Private Sub txtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusqueda.KeyPress
        soloLetrasTxt(e)
    End Sub



    ''Private Sub btnBusquedaRapida_Click(sender As Object, e As EventArgs)
    ''    dtgEmpleados.DataSource = vbNull
    ''    dtgEmpleados.DataSource = empleado.busquedaRapida(txtBusqueda.Text)
    ''    optimizar()
    ''End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        Dim filtro As String = CType(sender, TextBox).Text
        dtgProductos.DataSource = producto.busquedaRapida(filtro)
        optimizar()
    End Sub


End Class