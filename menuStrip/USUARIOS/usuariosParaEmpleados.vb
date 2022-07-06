Imports System.Data.SqlClient

Public Class usuariosParaEmpleados

    Dim user As New usuarios()
    Dim resp As DialogResult
    Private Sub usuariosParaEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = vbNull
        DataGridView1.DataSource = user.listarUsuariosParaEmpleados()
        DataGridView1.Columns(2).Visible = False
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtId.Text = DataGridView1.Item(0, e.RowIndex).Value

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        abmEmpleados.txtIdUsuario.Text = txtId.Text
        Me.Close()
    End Sub
End Class