Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration

Public Class ventas
    Dim conx As New conexionBD()
    Dim consulta As SqlCommand

    Dim nroVenta As Integer
    Dim fechaVenta As Date
    Dim dniCliente As Integer
    Dim nombApeCliente As String
    Dim cantidadProd As Decimal
    Dim montoTotal As Decimal
    Dim idEmpleado As Integer

    Public Function buscarIdVenta() As Integer
        Dim idVenta As Integer = 0
        conx.conectarBD()
        consulta = conx.conexion.CreateCommand()
        consulta.CommandText = "select max(idVenta) from ventaEncabezado"
        Dim lector As SqlDataReader = consulta.ExecuteReader()

        While (lector.Read())
            idVenta = lector.GetInt32(0) + 1
        End While
        conx.desconectarBD()
        Return idVenta
    End Function

    Public Sub insertarVentaEncabezado(ByVal p_fecha As Date, ByVal p_dniCliente As Integer, ByVal p_nombyapeCliente As String, ByVal p_cantidadProd As Decimal, ByVal p_montoTotal As Decimal, ByVal p_idEmp As Integer)

        Try
            conx.conectarBD()

            consulta = New SqlCommand("insert into ventaEncabezado (fecha,dniCliente,nombreCliente,cantidadProductos,montoTotal,idEmpleado) values('" & p_fecha & "'," & p_dniCliente & ",'" & p_nombyapeCliente & "'," & p_cantidadProd & "," & p_montoTotal & "," & p_idEmp & ")", conx.conexion)
            'MsgBox(consulta.ToString)
            consulta.ExecuteNonQuery()
            'MessageBox.Show("!Venta Realizada con exito: " + p_descripcion.ToString + " fue cargado exitosamente¡", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conx.desconectarBD()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        conx.desconectarBD()
    End Sub

    Public Sub insertarVentaDetalle(ByVal p_idProducto As Integer, ByVal p_descripcion As String, ByVal p_venta As Decimal, ByVal p_cantidad As Decimal, ByVal p_subTotal As Decimal, ByVal p_idVenta As Integer)

        Try
            conx.conectarBD()

            consulta = New SqlCommand("insert into ventaDetalle (codProducto,descripcion,precioVenta,cantidad,subTotal,idVenta) values(" & p_idProducto & ",'" & p_descripcion & "'," & p_venta & "," & p_cantidad & "," & p_subTotal & "," & p_idVenta & ")", conx.conexion)
            'MsgBox(consulta.ToString)
            consulta.ExecuteNonQuery()
            'MessageBox.Show("!Venta Realizada con exito: " + p_descripcion.ToString + " fue cargado exitosamente¡", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conx.desconectarBD()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        conx.desconectarBD()
    End Sub



    Public Sub actualizarStock(ByVal p_idProducto As Integer, ByVal p_cantidad As Decimal)
        Try
            conx.conectarBD()

            consulta = New SqlCommand("update productos set stock=(select stock from productos where idProducto=" & p_idProducto & ") - " & p_cantidad & " where idProducto=" & p_idProducto & "", conx.conexion)
            consulta.ExecuteNonQuery()

            conx.desconectarBD()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class
