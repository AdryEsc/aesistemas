Public Class inicioSesion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AppAESistemas.ShowDialog()

    End Sub

    Private Sub inicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp_fechaSistema.Refresh()
        dtp_fechaSistema.Format = DateTimePickerFormat.Custom
        dtp_fechaSistema.CustomFormat = "dd/MM/yyyy HH:mm tt"
        dtp_fechaSistema.Value = DateTime.Now
        dtp_fechaSistema.ShowUpDown = False

        'dtpFechaIngreso.Refresh();
        '    dtpFechaIngreso.Format = DateTimePickerFormat.Custom;
        '    dtpFechaIngreso.CustomFormat = "dd/MM/yy HH:mm:ss tt";
        '    dtpFechaIngreso.Value = DateTime.Now;
        '    dtpFechaIngreso.ShowUpDown = False;
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        MsgBox("Hemos mandado un mje a tu correo.", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        txtContrasena.UseSystemPasswordChar = False
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtp_fechaSistema.ValueChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class