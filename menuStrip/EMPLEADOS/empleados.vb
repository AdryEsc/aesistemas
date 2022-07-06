Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration

Public Class empleados
    Dim c_idEmpleado As Integer
    Dim c_dni As Integer
    Dim c_nombres As String
    Dim c_apellidos As String
    Dim c_fechaNac As Date
    Dim c_direccion As String
    Dim c_email As String
    Dim c_telefono As String
    Dim c_fechaIng As Date
    Dim c_fechaSal As Date
    Dim c_activo As String
    Dim c_idUsuario As Integer
    Dim c_cargo As String

    Dim conx As New conexionBD()
    Dim consulta As SqlCommand

    Public Property Nro_Empleado() As Integer
        Get
            Return Me.c_idEmpleado
        End Get
        Set(value As Integer)
            Me.c_idEmpleado = value
        End Set
    End Property

    Public Property Dni() As Integer
        Get
            Return Me.c_dni
        End Get
        Set(value As Integer)
            Me.c_dni = value
        End Set
    End Property

    Public Property Nombres() As String
        Get
            Return Me.c_nombres
        End Get
        Set(value As String)
            Me.c_nombres = value
        End Set
    End Property

    Public Property Apellidos() As String
        Get
            Return Me.c_apellidos
        End Get
        Set(value As String)
            Me.c_apellidos = value
        End Set
    End Property

    Public Property Fecha_Nacimiento() As Date
        Get
            Return Me.c_fechaNac
        End Get
        Set(value As Date)
            Me.c_fechaNac = value
        End Set
    End Property

    Public Property Direccion() As String
        Get
            Return Me.c_direccion
        End Get
        Set(value As String)
            Me.c_direccion = value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return Me.c_email
        End Get
        Set(value As String)
            Me.c_email = value
        End Set
    End Property

    Public Property Telefono() As String
        Get
            Return Me.c_telefono
        End Get
        Set(value As String)
            Me.c_telefono = value
        End Set
    End Property

    Public Property Fecha_Ingreso() As Date
        Get
            Return Me.c_fechaIng
        End Get
        Set(value As Date)
            Me.c_fechaIng = value
        End Set
    End Property

    Public Property Fecha_Salida() As Date
        Get
            Return Me.c_fechaSal
        End Get
        Set(value As Date)
            Me.c_fechaSal = value
        End Set
    End Property

    Public Property Activo() As String
        Get
            Return Me.c_activo
        End Get
        Set(value As String)
            Me.c_activo = value
        End Set
    End Property

    Public Property ID_Usuario() As Integer
        Get
            Return Me.c_idUsuario
        End Get
        Set(value As Integer)
            Me.c_idUsuario = value
        End Set
    End Property

    Public Property Cargo() As String
        Get
            Return Me.c_cargo
        End Get
        Set(value As String)
            Me.c_cargo = value
        End Set
    End Property


    Public Sub insertarEmpleado(p_dni As Integer, p_nombres As String, p_apellidos As String, p_fechaNac As Date, p_direccion As String, p_email As String, p_telefono As String, p_fechaIng As Date, p_fechaSal As Date, p_idUsuario As Integer)

        Try
            conx.conectarBD()

            consulta = New SqlCommand("insert into empleados (dni,nombre,apellido,fechaNacimiento,direccion,email,telefono,fechaAlta,fechaBaja,idUsuario) values(" & p_dni & ",'" & p_nombres & "','" & p_apellidos & "','" & p_fechaNac & "','" & p_direccion & "','" & p_email & "','" & p_telefono & "','" & p_fechaIng & "','" & p_fechaSal & "'," & p_idUsuario & ")", conx.conexion)
            consulta.ExecuteNonQuery()
            MessageBox.Show("!El empleado: " + p_nombres.ToString + " " + p_apellidos.ToString + " DNI: " + p_dni.ToString + " fue cargado exitosamente¡", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conx.desconectarBD()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        conx.desconectarBD()
    End Sub

    Public Function buscarEmpleado(p_dni As Integer, p_email As String) As Boolean
        Dim busqueda As Boolean = False
        conx.conectarBD()
        consulta = conx.conexion.CreateCommand()
        consulta.CommandText = "select * from empleados"
        Dim lector As SqlDataReader = consulta.ExecuteReader()

        While (lector.Read())

            If (p_dni = lector.GetInt32(1) Or p_email = lector.GetString(6)) Then
                busqueda = True
            End If

        End While
        conx.desconectarBD()
        Return busqueda
    End Function

    Public Function listarEmpleados() As List(Of empleados)
        conx.conectarBD()
        consulta = conx.conexion.CreateCommand()
        consulta.CommandText = "select e.idEmpleado,e.dni,e.nombre,e.apellido,e.fechaNacimiento,e.direccion,e.email,e.telefono,e.fechaAlta,e.fechaBaja,e.activo,e.idUsuario,c.nombre from empleados as e join usuarios as u on e.idUsuario=u.idUsuario join cargos as c on u.idCargo=c.idCargo order by e.nombre"
        Dim lector As SqlDataReader = consulta.ExecuteReader()
        Dim lista As New List(Of empleados)
        Dim emp As empleados
        Dim aux As Integer = 0
        'Dim i As Nullable(Of DateTime)

        While (lector.Read())
            emp = New empleados

            emp.Nro_Empleado = lector.GetInt32(0)
            emp.Dni = lector.GetInt32(1)
            emp.Nombres = lector.GetString(2)
            emp.Apellidos = lector.GetString(3)
            emp.Fecha_Nacimiento = lector.GetDateTime(4)
            emp.Direccion = lector.GetString(5)
            emp.Email = lector.GetString(6)
            emp.Telefono = lector.GetString(7)
            emp.Fecha_Ingreso = lector.GetDateTime(8)
            emp.Fecha_Salida = lector.GetDateTime(9)
            aux = lector.GetInt32(10)
            If (aux = 0) Then
                emp.Activo = "SI"
            Else
                emp.Activo = "No"
            End If
            emp.ID_Usuario = lector.GetInt32(11)
            emp.Cargo = lector.GetString(12)

            lista.Add(emp)

        End While
        conx.desconectarBD()
        Return lista

    End Function

    Public Function listarEmpleadosActivos() As List(Of empleados)
        conx.conectarBD()
        consulta = conx.conexion.CreateCommand()
        consulta.CommandText = "select e.idEmpleado,e.dni,e.nombre,e.apellido,e.fechaNacimiento,e.direccion,e.email,e.telefono,e.fechaAlta,e.fechaBaja,e.activo,e.idUsuario,c.nombre from empleados as e join usuarios as u on e.idUsuario=u.idUsuario join cargos as c on u.idCargo=c.idCargo where activo=0 order by e.nombre"
        Dim lector As SqlDataReader = consulta.ExecuteReader()
        Dim lista As New List(Of empleados)
        Dim emp As empleados
        Dim aux As Integer = 0
        'Dim i As Nullable(Of DateTime)

        While (lector.Read())
            emp = New empleados

            emp.Nro_Empleado = lector.GetInt32(0)
            emp.Dni = lector.GetInt32(1)
            emp.Nombres = lector.GetString(2)
            emp.Apellidos = lector.GetString(3)
            emp.Fecha_Nacimiento = lector.GetDateTime(4)
            emp.Direccion = lector.GetString(5)
            emp.Email = lector.GetString(6)
            emp.Telefono = lector.GetString(7)
            emp.Fecha_Ingreso = lector.GetDateTime(8)
            emp.Fecha_Salida = lector.GetDateTime(9)
            aux = lector.GetInt32(10)
            If (aux = 0) Then
                emp.Activo = "SI"
            Else
                emp.Activo = "No"
            End If
            emp.ID_Usuario = lector.GetInt32(11)
            emp.Cargo = lector.GetString(12)

            lista.Add(emp)

        End While
        conx.desconectarBD()
        Return lista

    End Function

    Public Function listarEmpleadosNoActivos() As List(Of empleados)
        conx.conectarBD()
        consulta = conx.conexion.CreateCommand()
        consulta.CommandText = "select e.idEmpleado,e.dni,e.nombre,e.apellido,e.fechaNacimiento,e.direccion,e.email,e.telefono,e.fechaAlta,e.fechaBaja,e.activo,e.idUsuario,c.nombre from empleados as e join usuarios as u on e.idUsuario=u.idUsuario join cargos as c on u.idCargo=c.idCargo where activo=1 order by e.nombre"
        Dim lector As SqlDataReader = consulta.ExecuteReader()
        Dim lista As New List(Of empleados)
        Dim emp As empleados
        Dim aux As Integer = 0
        'Dim i As Nullable(Of DateTime)

        While (lector.Read())
            emp = New empleados

            emp.Nro_Empleado = lector.GetInt32(0)
            emp.Dni = lector.GetInt32(1)
            emp.Nombres = lector.GetString(2)
            emp.Apellidos = lector.GetString(3)
            emp.Fecha_Nacimiento = lector.GetDateTime(4)
            emp.Direccion = lector.GetString(5)
            emp.Email = lector.GetString(6)
            emp.Telefono = lector.GetString(7)
            emp.Fecha_Ingreso = lector.GetDateTime(8)
            emp.Fecha_Salida = lector.GetDateTime(9)
            aux = lector.GetInt32(10)
            If (aux = 0) Then
                emp.Activo = "SI"
            Else
                emp.Activo = "No"
            End If
            emp.ID_Usuario = lector.GetInt32(11)
            emp.Cargo = lector.GetString(12)

            lista.Add(emp)

        End While
        conx.desconectarBD()
        Return lista

    End Function

    Public Sub actualizarEmpleado(p_idEmpleado As Integer, p_nombres As String, p_apellidos As String, p_fechaNac As Date, p_direccion As String, p_telefono As String, p_fechaIng As Date, p_fechaSal As Date, p_idUsuario As Integer)
        Try
            conx.conectarBD()

            consulta = New SqlCommand("update empleados set nombre='" & p_nombres & "', apellido='" & p_apellidos & "', fechaNacimiento='" & p_fechaNac & "', direccion='" & p_direccion & "', telefono='" & p_telefono & "', fechaAlta='" & p_fechaIng & "', fechaBaja='" & p_fechaSal & "', idUsuario=" & p_idUsuario & " where idEmpleado=" & p_idEmpleado & "", conx.conexion)
            consulta.ExecuteNonQuery()
            conx.desconectarBD()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub eliminarEmpleado(p_idEmpleado As Integer, p_fechaBaja As Date)
        'Solo da de baja a el empleado (inactivo)
        Try
            conx.conectarBD()

            consulta = New SqlCommand("update empleados set activo=1, fechaBaja='" & p_fechaBaja & "' where idEmpleado=" & p_idEmpleado & "", conx.conexion)
            consulta.ExecuteNonQuery()

            conx.desconectarBD()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Function busquedaRapida(caracter As String) As List(Of empleados)
        conx.conectarBD()
        consulta = conx.conexion.CreateCommand()
        consulta.CommandText = "select e.idEmpleado,e.dni,e.nombre,e.apellido,e.fechaNacimiento,e.direccion,e.email,e.telefono,e.fechaAlta,e.fechaBaja,e.activo,e.idUsuario,c.nombre from empleados as e join usuarios as u on e.idUsuario=u.idUsuario join cargos as c on u.idCargo=c.idCargo where e.nombre like '%" + caracter + "%' order by e.nombre"
        Dim lector As SqlDataReader = consulta.ExecuteReader()
        Dim lista As New List(Of empleados)
        Dim emp As empleados
        Dim aux As Integer = 0
        'Dim i As Nullable(Of DateTime)

        While (lector.Read())

            emp = New empleados

            emp.Nro_Empleado = lector.GetInt32(0)
            emp.Dni = lector.GetInt32(1)
            emp.Nombres = lector.GetString(2)
            emp.Apellidos = lector.GetString(3)
            emp.Fecha_Nacimiento = lector.GetDateTime(4)
            emp.Direccion = lector.GetString(5)
            emp.Email = lector.GetString(6)
            emp.Telefono = lector.GetString(7)
            emp.Fecha_Ingreso = lector.GetDateTime(8)
            emp.Fecha_Salida = lector.GetDateTime(9)
            aux = lector.GetInt32(10)
            If (aux = 0) Then
                emp.Activo = "SI"
            Else
                emp.Activo = "No"
            End If
            emp.ID_Usuario = lector.GetInt32(11)
            emp.Cargo = lector.GetString(12)

            lista.Add(emp)

        End While
        conx.desconectarBD()
        Return lista

    End Function


End Class
