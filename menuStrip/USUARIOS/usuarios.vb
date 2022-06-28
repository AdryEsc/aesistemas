Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration

Public Class usuarios
    Dim c_idUsuario As Integer
    Dim c_dni As Integer
    Dim c_nombre As String
    Dim c_apellido As String
    Dim c_usuario As String
    Dim c_contrasena As String
    Dim c_email As String
    Dim c_rol As String
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

    Public Property Usuario() As String
        Get
            Return Me.c_usuario
        End Get
        Set(value As String)
            Me.c_usuario = value
        End Set
    End Property

    Public Property Contraseña() As String
        Get
            Return Me.c_contrasena
        End Get
        Set(value As String)
            Me.c_contrasena = value
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

    Public Property Cargo() As String
        Get
            Return Me.c_rol
        End Get
        Set(value As String)
            Me.c_rol = value
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

    Public Sub insertarUsuario(p_dni As String, p_nombre As String, p_apellido As String, p_usuario As String, p_contrasena As String, p_email As String, p_rol As String)
        'Dim busqueda As Boolean
        'Dim aux_dni As Integer = Integer.Parse(p_dni)
        'busqueda = buscarUsuario(aux_dni, p_email)
        Try
            conx.conectarBD()

            'If (busqueda = True) Then
            '    MessageBox.Show("El DNI o el email a ingresar ya existe en la base de datos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            '    Exit Try
            'End If

            consulta = New SqlCommand("insert into usuarios (dni,nombre,apellido,usuario,contrasena,email,rol) values(" + p_dni + ",'" + p_nombre + "','" + p_apellido + "','" + p_usuario + "','" + p_contrasena + "','" + p_email + "','" + p_rol + "')", conx.conexion)
            consulta.ExecuteNonQuery()
            MessageBox.Show("!El usuario: " + p_usuario.ToString + " con cargo: " + p_rol + " fue cargado exitosamente¡", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conx.desconectarBD()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        conx.desconectarBD()
    End Sub

    Public Function listarUsuarios() As List(Of usuarios)
        conx.conectarBD()
        consulta = conx.conexion.CreateCommand()
        consulta.CommandText = "select * from usuarios order by nombre"
        Dim lector As SqlDataReader = consulta.ExecuteReader()
        Dim lista As New List(Of usuarios)
        Dim usuario As usuarios
        Dim aux As Integer = 0
        'Dim i As Nullable(Of DateTime)

        While (lector.Read())
            usuario = New usuarios

            usuario.Nro_Usuario = lector.GetInt32(0)
            usuario.Dni = lector.GetInt32(1)
            usuario.Nombres = lector.GetString(2)
            usuario.Apellidos = lector.GetString(3)
            usuario.Usuario = lector.GetString(4)
            usuario.Contraseña = lector.GetString(5)
            usuario.Email = lector.GetString(6)
            usuario.Cargo = lector.GetString(7)
            usuario.Fecha_Alta = lector.GetDateTime(8)
            'cliente.Fecha_Baja = Convert.ToString(lector.GetDateTime(7))
            aux = Convert.ToInt32(lector.GetString(9))

            If (aux = 0) Then
                usuario.Activo = "Si"
            Else
                usuario.Activo = "No"
            End If
            lista.Add(usuario)

        End While
        conx.desconectarBD()
        Return lista

    End Function

    Public Function listarUsuariosActivos() As List(Of usuarios)
        conx.conectarBD()
        consulta = conx.conexion.CreateCommand()
        consulta.CommandText = "select * from usuarios where activo=0 order by nombre"
        Dim lector As SqlDataReader = consulta.ExecuteReader()
        Dim lista As New List(Of usuarios)
        Dim usuario As usuarios
        Dim aux As Integer = 0
        'Dim i As Nullable(Of DateTime)

        While (lector.Read())
            usuario = New usuarios

            usuario.Nro_Usuario = lector.GetInt32(0)
            usuario.Dni = lector.GetInt32(1)
            usuario.Nombres = lector.GetString(2)
            usuario.Apellidos = lector.GetString(3)
            usuario.Usuario = lector.GetString(4)
            usuario.Contraseña = lector.GetString(5)
            usuario.Email = lector.GetString(6)
            usuario.Cargo = lector.GetString(7)
            usuario.Fecha_Alta = lector.GetDateTime(8)
            'cliente.Fecha_Baja = Convert.ToString(lector.GetDateTime(7))
            aux = Convert.ToInt32(lector.GetString(9))

            If (aux = 0) Then
                usuario.Activo = "Si"
            Else
                usuario.Activo = "No"
            End If
            lista.Add(usuario)

        End While
        conx.desconectarBD()
        Return lista

    End Function

    Public Function listarUsuariosInactivos() As List(Of usuarios)
        conx.conectarBD()
        consulta = conx.conexion.CreateCommand()
        consulta.CommandText = "select * from usuarios where activo=1 order by nombre"
        Dim lector As SqlDataReader = consulta.ExecuteReader()
        Dim lista As New List(Of usuarios)
        Dim usuario As usuarios
        Dim aux As Integer = 0
        'Dim i As Nullable(Of DateTime)

        While (lector.Read())
            usuario = New usuarios

            usuario.Nro_Usuario = lector.GetInt32(0)
            usuario.Dni = lector.GetInt32(1)
            usuario.Nombres = lector.GetString(2)
            usuario.Apellidos = lector.GetString(3)
            usuario.Usuario = lector.GetString(4)
            usuario.Contraseña = lector.GetString(5)
            usuario.Email = lector.GetString(6)
            usuario.Cargo = lector.GetString(7)
            usuario.Fecha_Alta = lector.GetDateTime(8)
            'cliente.Fecha_Baja = Convert.ToString(lector.GetDateTime(7))
            aux = Convert.ToInt32(lector.GetString(9))

            If (aux = 0) Then
                usuario.Activo = "Si"
            Else
                usuario.Activo = "No"
            End If
            lista.Add(usuario)

        End While
        conx.desconectarBD()
        Return lista

    End Function

    Public Function buscarUsuario(p_dni As Integer, p_email As String) As Boolean
        Dim busqueda As Boolean = False
        conx.conectarBD()
        consulta = conx.conexion.CreateCommand()
        consulta.CommandText = "select * from usuarios"
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

            If (p_dni = lector.GetInt32(1) Or p_email = lector.GetString(6)) Then
                busqueda = True
            End If
            'lista.Add(usuario)

        End While
        conx.desconectarBD()
        Return busqueda
    End Function

    Public Sub actualizarUsuario(p_dni As String, p_nombre As String, p_apellido As String, p_usuario As String, p_contrasena As String, p_cargo As String)
        Try
            conx.conectarBD()

            consulta = New SqlCommand("update usuarios set nombre='" + p_nombre + "',apellido='" + p_apellido + "',usuario='" + p_usuario + "', contrasena='" + p_contrasena + "', rol='" + p_cargo + "' where dni='" + p_dni + "'", conx.conexion)
            consulta.ExecuteNonQuery()

            conx.desconectarBD()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Public Function inicioSesion(p_usuario As String, p_contrasena As String) As Boolean
        Dim busqueda As Boolean = False
        conx.conectarBD()
        consulta = conx.conexion.CreateCommand()
        consulta.CommandText = "select * from usuarios"
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

            If (p_usuario = lector.GetString(4) And p_contrasena = lector.GetString(5)) Then
                busqueda = True
            End If
            'lista.Add(usuario)

        End While
        conx.desconectarBD()
        Return busqueda
    End Function

    Public Function obtenerRol(p_usuario As String, p_contrasena As String) As String
        Dim rol As String = ""
        conx.conectarBD()
        consulta = conx.conexion.CreateCommand()
        consulta.CommandText = "select * from usuarios"
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

            If (p_usuario = lector.GetString(4) And p_contrasena = lector.GetString(5)) Then
                rol = lector.GetString(7)
            End If
            'lista.Add(usuario)

        End While
        conx.desconectarBD()
        Return rol
    End Function

    Public Sub eliminarUsuario(p_dni As String, p_fecha As String)
        Try
            conx.conectarBD()

            consulta = New SqlCommand("update usuarios set fechaBaja = '" + p_fecha + "',activo=1 where dni='" + p_dni + "'", conx.conexion)
            consulta.ExecuteNonQuery()

            conx.desconectarBD()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Function busquedaRapida(caracter As String) As List(Of usuarios)
        conx.conectarBD()
        consulta = conx.conexion.CreateCommand()
        consulta.CommandText = "select * from usuarios where nombre like '%" + caracter + "%' order by nombre"
        Dim lector As SqlDataReader = consulta.ExecuteReader()
        Dim lista As New List(Of usuarios)
        Dim usuario As usuarios
        Dim aux As Integer = 0
        'Dim i As Nullable(Of DateTime)

        While (lector.Read())
            usuario = New usuarios

            usuario.Nro_Usuario = lector.GetInt32(0)
            usuario.Dni = lector.GetInt32(1)
            usuario.Nombres = lector.GetString(2)
            usuario.Apellidos = lector.GetString(3)
            usuario.Usuario = lector.GetString(4)
            usuario.Contraseña = lector.GetString(5)
            usuario.Email = lector.GetString(6)
            usuario.Cargo = lector.GetString(7)
            usuario.Fecha_Alta = lector.GetDateTime(8)
            'cliente.Fecha_Baja = Convert.ToString(lector.GetDateTime(7))
            aux = Convert.ToInt32(lector.GetString(9))

            If (aux = 0) Then
                usuario.Activo = "Si"
            Else
                usuario.Activo = "No"
            End If
            lista.Add(usuario)

        End While
        conx.desconectarBD()
        Return lista

    End Function

End Class
