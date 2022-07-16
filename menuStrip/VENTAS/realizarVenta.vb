Public Class realizarVenta
    Dim cliente As New clientes()
    Dim producto As New productos()
    Dim resp As DialogResult
    Dim idCliente As Integer

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
        'dtgVentaProd.Rows.RemoveAt(dtgVentaProd.CurrentRow.Index)

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
        txtCantidad.Text = Convert.ToDecimal(cantidad)



        For Each linea2 In dtgVentaProd.Rows
            sumaTotal = sumaTotal + linea2.Cells(4).Value
        Next
        txtTotal.Text = Convert.ToDecimal(sumaTotal)

    End Sub

    Private Sub dtgVentaProd_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgVentaProd.CellClick
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
            txtCantidad.Text = Convert.ToDecimal(cantidad)



            For Each linea2 In dtgVentaProd.Rows
                sumaTotal = sumaTotal + linea2.Cells(4).Value
            Next
            txtTotal.Text = Convert.ToDecimal(sumaTotal)
        Catch ex As Exception
            MessageBox.Show("Nada para seleccionar")
        End Try

    End Sub
End Class