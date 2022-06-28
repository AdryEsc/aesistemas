Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration

Public Class clientes

    Dim c_idUsuario As Integer
    Dim c_dni As Integer
    Dim c_nombre As String
    Dim c_apellido As String
    Dim c_email As String
    Dim c_telefono As String
    Dim c_fechaAlta As Date
    Dim c_activo As String
    'Dim c_fecheBaja As Date

    Dim conx As New conexionBD()
    Dim consulta As SqlCommand

    Public Property Nro_Usuario() As Integer
        Get
            Return Me.c_idUsuario
        End Get
        Set(value As Integer)
            Me.c_idUsuario = value
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
            Return Me.c_nombre
        End Get
        Set(value As String)
            Me.c_nombre = value
        End Set
    End Property

    Public Property Apellidos() As String
        Get
            Return Me.c_apellido
        End Get
        Set(value As String)
            Me.c_apellido = value
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

    Public Property Fecha_Alta() As Date
        Get
            Return Me.c_fechaAlta
        End Get
        Set(value As Date)
            Me.c_fechaAlta = value
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

    'Public Property Fecha_Baja() As Date
    '    Get
    '        Return Me.c_fecheBaja
    '    End Get
    '    Set(value As Date)
    '        Me.c_fecheBaja = value
    '    End Set
    'End Property

    Public Sub insertarCliente(p_dni As String, p_nombre As String, p_apellido As String, p_email As String, p_telefono As String)
        'Dim busqueda As Boolean
        'Dim aux_dni As Integer = Integer.Parse(p_dni)
        'busqueda = buscarUsuario(aux_dni, p_email)
        Try
            conx.conectarBD()

            'If (busqueda = True) Then
            '    MessageBox.Show("El DNI o el email a ingresar ya existe en la base de datos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            '    Exit Try
            'End If

            consulta = New SqlCommand("insert into clientes (dni,nombre,apellido,email,telefono) values(" + p_dni + ",'" + p_nombre + "','" + p_apellido + "','" + p_email + "','" + p_telefono + "')", conx.conexion)
            consulta.ExecuteNonQuery()
            MessageBox.Show("!El cliente: " + p_nombre.ToString + " " + p_apellido.ToString + " , DNI: " + p_dni + " fue cargado exitosamente¡", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conx.desconectarBD()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        conx.desconectarBD()
    End Sub

    Public Function listarClientes() As List(Of clientes)
        conx.conectarBD()
        consulta = conx.conexion.CreateCommand()
        consulta.CommandText = "select * from clientes order by nombre"
        Dim lector As SqlDataReader = consulta.ExecuteReader()
        Dim lista As New List(Of clientes)
        Dim cliente As clientes
        Dim aux As Integer = 0
        'Dim i As Nullable(Of DateTime)

        While (lector.Read())
            cliente = New clientes

            cliente.Nro_Usuario = lector.GetInt32(0)
            cliente.Dni = lector.GetInt32(1)
            cliente.Nombres = lector.GetString(2)
            cliente.Apellidos = lector.GetString(3)
            cliente.Email = lector.GetString(4)
            cliente.Telefono = lector.GetString(5)
            cliente.Fecha_Alta = lector.GetDateTime(6)
            aux = Convert.ToInt32(lector.GetString(7))
            'cliente.Fecha_Baja = Convert.ToString(lector.GetDateTime(7))

            If (aux = 0) Then
                cliente.Activo = "Si"
            Else
                cliente.Activo = "No"
            End If
            lista.Add(cliente)

        End While
        conx.desconectarBD()
        Return lista

    End Function

    Public Function listarClientesActivos() As List(Of clientes)
        conx.conectarBD()
        consulta = conx.conexion.CreateCommand()
        consulta.CommandText = "select * from clientes where activo=0 order by nombre"
        Dim lector As SqlDataReader = consulta.ExecuteReader()
        Dim lista As New List(Of clientes)
        Dim cliente As clientes
        Dim aux As Integer = 0
        'Dim i As Nullable(Of DateTime)

        While (lector.Read())
            cliente = New clientes

            cliente.Nro_Usuario = lector.GetInt32(0)
            cliente.Dni = lector.GetInt32(1)
            cliente.Nombres = lector.GetString(2)
            cliente.Apellidos = lector.GetString(3)
            cliente.Email = lector.GetString(4)
            cliente.Telefono = lector.GetString(5)
            cliente.Fecha_Alta = lector.GetDateTime(6)
            aux = Convert.ToInt32(lector.GetString(7))
            'cliente.Fecha_Baja = Convert.ToString(lector.GetDateTime(7))

            If (aux = 0) Then
                cliente.Activo = "Si"
            Else
                cliente.Activo = "No"
            End If
            lista.Add(cliente)

        End While
        conx.desconectarBD()
        Return lista
    End Function

    Public Function listarClientesInactivos() As List(Of clientes)
        conx.conectarBD()
        consulta = conx.conexion.CreateCommand()
        consulta.CommandText = "select * from clientes where activo=1 order by nombre"
        Dim lector As SqlDataReader = consulta.ExecuteReader()
        Dim lista As New List(Of clientes)
        Dim cliente As clientes
        Dim aux As Integer = 0
        'Dim i As Nullable(Of DateTime)

        While (lector.Read())
            cliente = New clientes

            cliente.Nro_Usuario = lector.GetInt32(0)
            cliente.Dni = lector.GetInt32(1)
            cliente.Nombres = lector.GetString(2)
            cliente.Apellidos = lector.GetString(3)
            cliente.Email = lector.GetString(4)
            cliente.Telefono = lector.GetString(5)
            cliente.Fecha_Alta = lector.GetDateTime(6)
            aux = Convert.ToInt32(lector.GetString(7))
            'cliente.Fecha_Baja = Convert.ToString(lector.GetDateTime(7))

            If (aux = 0) Then
                cliente.Activo = "Si"
            Else
                cliente.Activo = "No"
            End If
            lista.Add(cliente)

        End While
        conx.desconectarBD()
        Return lista
    End Function

    Public Function buscarCliente(p_dni As Integer, p_email As String) As Boolean
        Dim busqueda As Boolean = False
        conx.conectarBD()
        consulta = conx.conexion.CreateCommand()
        consulta.CommandText = "select * from clientes"
        Dim lector As SqlDataReader = consulta.ExecuteReader()
        'Dim lista As New List(Of usuarios)
        'Dim usuario As usuarios
        'Dim aux As Integer = 0
        'Dim i As Nullable(Of DateTime)

        While (lector.Read())
            'usuario = New usuarios

            'usuario.Nro_Usuario = lector.GetInt32(0)
            'usuario.Dni = lector.GetInt32(1)
            'usuario.Nombres = lector.GetString(2)
            'usuario.Apellidos = lector.GetString(3)
            'usuario.Usuario = lector.GetString(4)
            'usuario.Contraseña = lector.GetString(5)
            'usuario.Email = lector.GetString(6)
            'usuario.Cargo = lector.GetString(7)
            'usuario.Fecha_Alta = lector.GetDateTime(8)
            ''cliente.Fecha_Baja = Convert.ToString(lector.GetDateTime(7))
            'aux = Convert.ToInt32(lector.GetString(9))

            If (p_dni = lector.GetInt32(1) Or p_email = lector.GetString(4)) Then
                busqueda = True
            End If
            'lista.Add(usuario)

        End While
        conx.desconectarBD()
        Return busqueda
    End Function

    Public Sub actualizarCliente(p_dni As String, p_nombre As String, p_apellido As String, p_email As String, p_telefono As String)
        Try
            conx.conectarBD()

            consulta = New SqlCommand("update clientes set nombre='" + p_nombre + "',apellido='" + p_apellido + "', email='" + p_email + "', telefono='" + p_telefono + "' where dni='" + p_dni + "'", conx.conexion)
            consulta.ExecuteNonQuery()

            conx.desconectarBD()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Public Sub eliminarCliente(p_dni As String, p_fecha As String)
        Try
            conx.conectarBD()

            consulta = New SqlCommand("update clientes set fechaBaja = '" + p_fecha + "',activo=1 where dni='" + p_dni + "'", conx.conexion)
            consulta.ExecuteNonQuery()

            conx.desconectarBD()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Function busquedaRapida(caracter As String) As List(Of clientes)
        conx.conectarBD()
        consulta = conx.conexion.CreateCommand()
        consulta.CommandText = "select * from clientes where nombre like '%" + caracter + "%' order by nombre"
        Dim lector As SqlDataReader = consulta.ExecuteReader()
        Dim lista As New List(Of clientes)
        Dim cliente As clientes
        Dim aux As Integer = 0
        'Dim i As Nullable(Of DateTime)

        While (lector.Read())
            cliente = New clientes

            cliente.Nro_Usuario = lector.GetInt32(0)
            cliente.Dni = lector.GetInt32(1)
            cliente.Nombres = lector.GetString(2)
            cliente.Apellidos = lector.GetString(3)
            cliente.Email = lector.GetString(4)
            cliente.Telefono = lector.GetString(5)
            cliente.Fecha_Alta = lector.GetDateTime(6)
            aux = Convert.ToInt32(lector.GetString(7))
            'cliente.Fecha_Baja = Convert.ToString(lector.GetDateTime(7))

            If (aux = 0) Then
                cliente.Activo = "Si"
            Else
                cliente.Activo = "No"
            End If
            lista.Add(cliente)

        End While
        conx.desconectarBD()
        Return lista

    End Function




End Class
