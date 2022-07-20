Public Class AppAESistemas
    Dim empleado As New empleados()
    Dim idEmpleado As Integer
    Private Sub ABMDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMDeProductosToolStripMenuItem.Click
        abmProductos.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIR.Click
        Dim resp As DialogResult
        resp = MessageBox.Show("¿Esta seguro que desea salir?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If (resp = DialogResult.Yes) Then
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
        realizarVenta.ShowDialog()
    End Sub

    Private Sub ABMProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMProveedoresToolStripMenuItem.Click
        abmProveedores.ShowDialog()
    End Sub

    Private Sub AppAESistemas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idEmpleado = Convert.ToInt32(txtIdEmp.Text)
        empleado.datosInicioDeAppSistemas(idEmpleado)
        inicioSesion.Refresh()
    End Sub

    Private Sub GestionDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeEmpleadosToolStripMenuItem.Click

    End Sub

    Private Sub GestionDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeUsuariosToolStripMenuItem.Click

    End Sub

    Private Sub InformesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformesToolStripMenuItem.Click

    End Sub

    Private Sub RealizarVeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        realizarVenta.ShowDialog()
    End Sub

    Private Sub AppAESistemas_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.GestionDeEmpleadosToolStripMenuItem.Enabled = True
        Me.GestionDeUsuariosToolStripMenuItem.Enabled = True
        inicioSesion.txtContrasena.UseSystemPasswordChar = True
    End Sub
End Class
