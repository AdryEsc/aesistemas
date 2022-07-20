Public Class clientesParaVenta
    Dim cliente As New clientes()
    Dim resp As DialogResult
    Dim idCliente As Integer

    Public Sub optimizar()

        dtgClientesParaV.Columns(0).Width = 70
        dtgClientesParaV.Columns(1).Width = 70
        dtgClientesParaV.Columns(2).Width = 150
        dtgClientesParaV.Columns(3).Width = 150
        dtgClientesParaV.Columns(4).Width = 170
        dtgClientesParaV.Columns(5).Width = 80
        dtgClientesParaV.Columns(6).Width = 80
        dtgClientesParaV.Columns(7).Width = 80

    End Sub

    Private Sub txtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusqueda.KeyPress
        soloLetrasTxt(e)
    End Sub



    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        Dim filtro As String = CType(sender, TextBox).Text
        dtgClientesParaV.DataSource = cliente.busquedaRapidaClientesAct(filtro)
        optimizar()
    End Sub

    Private Sub dtgClientesParaV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgClientesParaV.CellClick
        realizarVenta.txtIdCliente.Text = dtgClientesParaV.Item(0, e.RowIndex).Value
        realizarVenta.txtDniCliente.Text = dtgClientesParaV.Item(1, e.RowIndex).Value
        realizarVenta.txtNombCliente.Text = dtgClientesParaV.Item(2, e.RowIndex).Value + " " + dtgClientesParaV.Item(3, e.RowIndex).Value

    End Sub

    Private Sub clientesParaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtgClientesParaV.DataSource = vbNull
        dtgClientesParaV.DataSource = cliente.listarClientesActivos()
        optimizar()
    End Sub

    Private Sub txtBusquedaDni_TextChanged(sender As Object, e As EventArgs) Handles txtBusquedaDni.TextChanged
        Dim filtro As String = CType(sender, TextBox).Text
        dtgClientesParaV.DataSource = cliente.busquedaRapidaClientesActPorDni(filtro)
        optimizar()
    End Sub

    Private Sub txtBusquedaDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusquedaDni.KeyPress
        soloNumerosTxt(e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class