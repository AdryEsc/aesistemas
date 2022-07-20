Public Class realizarVenta
    Dim cliente As New clientes()
    Dim producto As New productos()
    Dim vent As New ventas()
    Dim resp As DialogResult
    Dim dniCliente As Integer
    Dim nombyapeCliente As String
    Dim cantidadProd As Decimal
    Dim total As Decimal
    Dim idEmp As Integer


    Dim linea As DataGridViewRow
    Dim suma As Decimal

    Dim idP As Integer
    Dim dc As String
    Dim vt As Decimal
    Dim ct As Decimal
    Dim sbt As Decimal

    Private Sub txtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusqueda.KeyPress
        soloLetrasTxt(e)
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        Dim filtro As String = CType(sender, TextBox).Text
        dtgProd.DataSource = producto.busquedaRapidaParaFactura(filtro)
        'optimizar()
    End Sub

    Private Sub realizarVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtNroVenta.Text = vent.buscarIdVenta()
        Me.txtIdEmp.Text = AppAESistemas.txtIdEmp.Text
        Me.txtNombVen.Text = AppAESistemas.txtNomApe.Text
        dtgProd.DataSource = vbNull
        dtgProd.DataSource = producto.listarProductosActivos()
        Me.encabezadoTablaProducto()
    End Sub

    Public Sub encabezadoTablaProducto()
        dtgProd.Columns(0).HeaderText = "CODIGO DE PRODUCTO"
        dtgProd.Columns(1).HeaderText = "DESCRIPCION"
        dtgProd.Columns(1).Width = 200
        dtgProd.Columns(2).HeaderText = "PRECIO DE COSTO"
        dtgProd.Columns(2).Visible = False
        dtgProd.Columns(3).HeaderText = "PRECIO DE VENTA"
        dtgProd.Columns(4).HeaderText = "STOCK"
        dtgProd.Columns(5).Visible = False
        dtgProd.Columns(6).Visible = False
        dtgProd.Columns(7).Visible = False
        dtgProd.Columns(8).Visible = False

    End Sub

    Private Sub dtgProd_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgProd.CellClick
        idP = Convert.ToInt32(dtgProd.Item(0, e.RowIndex).Value)
        dc = dtgProd.Item(1, e.RowIndex).Value
        vt = Convert.ToDecimal(dtgProd.Item(2, e.RowIndex).Value)
    End Sub

    Private Sub btnAgregarProd_Click(sender As Object, e As EventArgs) Handles btnAgregarProd.Click
        dtgVentaProd.Rows.Add(idP, dc, vt)

    End Sub

    Private Sub dtgVentaProd_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgVentaProd.CellContentClick
        dtgVentaProd.Rows.RemoveAt(dtgVentaProd.CurrentRow.Index)

    End Sub

    Private Sub dtgVentaProd_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dtgVentaProd.CellEndEdit
        Try
            Dim linea As DataGridViewRow
            Dim linea2 As DataGridViewRow
            Dim cantidad As Decimal
            Dim sumaTotal As Decimal

            vt = Convert.ToDecimal(dtgVentaProd.Item(2, e.RowIndex).Value)
            ct = Convert.ToDecimal(dtgVentaProd.Item(3, e.RowIndex).Value)
            sbt = Convert.ToDecimal(vt * ct)
            dtgVentaProd.Item(4, e.RowIndex).Value = Convert.ToDecimal(sbt)

            For Each linea In dtgVentaProd.Rows
                cantidad = cantidad + linea.Cells(3).Value
            Next
            txtCantidadProd.Text = Convert.ToDecimal(cantidad)



            For Each linea2 In dtgVentaProd.Rows
                sumaTotal = sumaTotal + linea2.Cells(4).Value
            Next
            txtTotal.Text = Convert.ToDecimal(sumaTotal)
        Catch ex As Exception
            MessageBox.Show("Nada para seleccionar")
        End Try
    End Sub

    Private Sub dtgVentaProd_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dtgVentaProd.RowsRemoved
        Try
            Dim linea As DataGridViewRow
            Dim linea2 As DataGridViewRow
            Dim cantidad As Decimal
            Dim sumaTotal As Decimal

            'vt = Convert.ToDecimal(dtgVentaProd.Item(2, e.RowIndex).Value)
            'ct = Convert.ToDecimal(dtgVentaProd.Item(3, e.RowIndex).Value)
            'sbt = Convert.ToDecimal(vt * ct)
            'dtgVentaProd.Item(4, e.RowIndex).Value = Convert.ToDecimal(sbt)

            For Each linea In dtgVentaProd.Rows
                cantidad = cantidad + linea.Cells(3).Value
            Next
            txtCantidadProd.Text = Convert.ToDecimal(cantidad)



            For Each linea2 In dtgVentaProd.Rows
                sumaTotal = sumaTotal + linea2.Cells(4).Value
            Next
            txtTotal.Text = Convert.ToDecimal(sumaTotal)
        Catch ex As Exception
            MessageBox.Show("Nada para seleccionar")
        End Try
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        clientesParaVenta.ShowDialog()
    End Sub

    Private Sub btnConfVenta_Click(sender As Object, e As EventArgs) Handles btnConfVenta.Click
        Dim idP As Integer
        Dim dc As String
        Dim vt As Decimal
        Dim ct As Decimal
        Dim sbt As Decimal
        Dim idVenta As Integer
        idVenta = Convert.ToInt32(txtNroVenta.Text)

        If (txtCantidadProd.Text = Nothing Or txtTotal.Text = Nothing) Then
            MessageBox.Show("!Debe cargar por lo menos un producto para la venta¡", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        resp = MessageBox.Show("¿Desea confirmar la venta?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If (resp = DialogResult.Yes) Then
            dniCliente = Convert.ToInt32(txtDniCliente.Text)
            nombyapeCliente = txtNombCliente.Text
            cantidadProd = Convert.ToDecimal(txtCantidadProd.Text)
            total = Convert.ToDecimal(txtTotal.Text)
            idEmp = Convert.ToInt32(txtIdEmp.Text)
            vent.insertarVentaEncabezado(dtpFecha.Value.Date, dniCliente, nombyapeCliente, cantidadProd, total, idEmp)

            For Each linea In dtgVentaProd.Rows
                idP = Convert.ToInt32(linea.Cells(0).Value)
                dc = Convert.ToString(linea.Cells(1).Value)
                vt = Convert.ToDecimal(linea.Cells(2).Value)
                ct = Convert.ToDecimal(linea.Cells(3).Value)
                sbt = Convert.ToDecimal(linea.Cells(4).Value)
                vent.insertarVentaDetalle(idP, dc, vt, ct, sbt, idVenta)
                vent.actualizarStock(idP, ct)
            Next

            MessageBox.Show("¡La venta se realizo con exito!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtgProd.DataSource = vbNull
            dtgProd.DataSource = producto.listarProductosActivos()
            encabezadoTablaProducto()
            dtgVentaProd.DataSource = vbNull
            txtIdCliente.Clear()
            txtDniCliente.Clear()
            txtNombCliente.Clear()
            txtNroVenta.Text = vent.buscarIdVenta()
            txtCantidadProd.Clear()
            txtTotal.Clear()
            txtPagaCon.Clear()
            txtCambio.Clear()

        Else
            MessageBox.Show("¡No se realizo ningun cambio!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If





    End Sub

    Private Sub txtPagaCon_Enter(sender As Object, e As EventArgs) Handles txtPagaCon.Enter
        'Dim pagacon As Decimal
        'Dim total As Decimal

        'total = Convert.ToDecimal(txtTotal.Text)
        'pagacon = Convert.ToDecimal(txtPagaCon.Text)

        'If (pagacon < total) Then
        '    MsgBox("El monto a pagar debe ser mayor que el monto total")
        'End If

        'txtCambio.Text = total - pagacon

    End Sub

    Private Sub txtPagaCon_TextChanged(sender As Object, e As EventArgs) Handles txtPagaCon.TextChanged

    End Sub

    Private Sub txtPagaCon_Leave(sender As Object, e As EventArgs) Handles txtPagaCon.Leave
        Dim pagacon As Decimal
        Dim total As Decimal

        total = Convert.ToDecimal(txtTotal.Text)
        pagacon = Convert.ToDecimal(txtPagaCon.Text)

        If (pagacon < total) Then
            MsgBox("El monto a pagar debe ser mayor que el monto total")
        End If

        txtCambio.Text = pagacon - total

    End Sub
End Class