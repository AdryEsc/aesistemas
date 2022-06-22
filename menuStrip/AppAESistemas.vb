Public Class AppAESistemas
    Private Sub ABMDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMDeProductosToolStripMenuItem.Click
        abmProductos.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIR.Click
        Dim salir As MsgBoxResult
        salir = MsgBox("¿Esta seguro que desea salir?", MsgBoxStyle.OkCancel, "SALIR")
        If (salir = MsgBoxResult.Ok) Then
            Me.Close()


        End If
        inicioSesion.Activate()
        inicioSesion.txtUsuario.Clear()
        inicioSesion.txtContrasena.Clear()

    End Sub

    Private Sub AMBClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AMBClientesToolStripMenuItem.Click
        abmClientes.ShowDialog()
    End Sub

    Private Sub ABMEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMEmpleadosToolStripMenuItem.Click
        abmEmpleados.ShowDialog()
    End Sub

    Private Sub ABMUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMUsuariosToolStripMenuItem.Click
        abmUsuarios.ShowDialog()
    End Sub

    Private Sub ABMVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMVentasToolStripMenuItem.Click
        abmVentas.ShowDialog()
    End Sub

    Private Sub ABMProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMProveedoresToolStripMenuItem.Click
        abmProveedores.ShowDialog()
    End Sub

    Private Sub AppAESistemas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp_fecha.Refresh()
        dtp_fecha.Format = DateTimePickerFormat.Custom
        dtp_fecha.CustomFormat = "dd/MM/yyyy"
        dtp_fecha.Value = DateTime.Now
        dtp_fecha.ShowUpDown = False
    End Sub
End Class
