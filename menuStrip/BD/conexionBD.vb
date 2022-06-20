Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO

Public Class conexionBD
    Public conexion As New SqlConnection()
    Dim direccion As ConnectionStringSettings

    Public Sub conectarBD()
        Try
            direccion = ConfigurationManager.ConnectionStrings("conexionBaseDatos")
            conexion.ConnectionString = direccion.ConnectionString
            conexion.Open()
            MessageBox.Show("Conectado", "BD", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Public Sub desconectarBD()
        Try
            conexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


End Class
