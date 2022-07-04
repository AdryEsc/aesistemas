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
    Dim c_ocupado As String
    'Dim c_fecheBaja As Date
    Dim c_cargo As String

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

    'Public Property Dni() As Integer
    '    Get
    '        Return Me.c_dni
    '    End Get
    '    Set(value As Integer)
    '        Me.c_dni = value
    '    End Set
    'End Property

    'Public Property Nombres() As String
    '    Get
    '        Return Me.c_nombre
    '    End Get
    '    Set(value As String)
    '        Me.c_nombre = value
    '    End Set
    'End Property

    'Public Property Apellidos() As String
    '    Get
    '        Return Me.c_apellido
    '    End Get
    '    Set(value As String)
    '        Me.c_apellido = value
    '    End Set
    'End Property

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

    'Public Property Email() As String
    '    Get
    '        Return Me.c_email
    '    End Get
    '    Set(value As String)
    '        Me.c_email = value
    '    End Set
    'End Property

    'Public Property Cargo() As String
    '    Get
    '        Return Me.c_rol
    '    End Get
    '    Set(value As String)
    '        Me.c_rol = value
    '    End Set
    'End Property

    'Public Property Fecha_Alta() As Date
    '    Get
    '        Return Me.c_fechaAlta
    '    End Get
    '    Set(value As Date)
    '        Me.c_fechaAlta = value
    '    End Set
    'End Property

    'Public Property Activo() As String
    '    Get
    '        Return Me.c_activo
    '    End Get
    '    Set(value As String)
    '        Me.c_activo = value
    '    End Set
    'End Property

    'Public Property Fecha_Baja() As Date
    '    Get
    '        Return Me.c_fecheBaja
    '    End Get
    '    Set(value As Date)
    '        Me.c_fecheBaja = value
    '    End Set
    'End Property

    Public Property Cargo() As String
        Get
            Return Me.c_cargo
        End Get
        Set(value As String)
            Me.c_cargo = value
        End Set
    End Property

    Public Property Ocupado() As String
        Get
            Return Me.c_ocupado
        End Get
        Set(value As String)
            Me.c_ocupado = value
        End Set
    End Property

    Public Sub insertarUsuario(p_usuario As String, p_contrasena As String, p_idCargo As Integer)

        Try
            conx.conectarBD()

            consulta = New SqlCommand("insert into usuarios (usuario,contrasena,idCargo) values('" & p_usuario & "','" & p_contrasena & "'," & p_idCargo & ")", conx.conexion)
            consulta.ExecuteNonQuery()
            MessageBox.Show("!El usuario: " + p_usuario.ToString + " fue cargado exitosamente¡", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conx.desconectarBD()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        conx.desconectarBD()
    End Sub

    Public Function listarUsuarios() As List(Of usuarios)
        conx.conectarBD()
        consulta = conx.conexion.CreateCommand()
        consulta.CommandText = "select u.idUsuario,u.usuario,u.contrasena,c.nombre, u.ocupado from usuarios as u inner join cargos as c on u.idCargo=c.idCargo"
        Dim lector As SqlDataReader = consulta.ExecuteReader()
        Dim lista As New List(Of usuarios)
        Dim usuario As usuarios
        Dim aux As Integer = 0
        'Dim i As Nullable(Of DateTime)

        While (lector.Read())
            usuario = New usuarios

            usuario.Nro_Usuario = lector.GetInt32(0)
            usuario.Usuario = lector.GetString(1)
            usuario.Contraseña = lector.GetString(2)
            usuario.Cargo = lector.GetString(3)
            aux = Integer.Parse(lector.GetString(4))


            If (aux = 0) Then
                usuario.Ocupado = "No"
            Else
                usuario.Ocupado = "SI"
            End If
            lista.Add(usuario)

        End While
        conx.desconectarBD()
        Return lista

    End Function

    Public Function listarUsuariosOcupados() As List(Of usuarios)
        conx.conectarBD()
        consulta = conx.conexion.CreateCommand()
        consulta.CommandText = "select u.idUsuario,u.usuario,u.contrasena,c.nombre, u.ocupado from usuarios as u inner join cargos as c on u.idCargo=c.idCargo where ocupado = 1"
        Dim lector As SqlDataReader = consulta.ExecuteReader()
        Dim lista As New List(Of usuarios)
        Dim usuario As usuarios
        Dim aux As Integer = 0
        'Dim i As Nullable(Of DateTime)

        While (lector.Read())
            usuario = New usuarios

            usuario.Nro_Usuario = lector.GetInt32(0)
            usuario.Usuario = lector.GetString(1)
            usuario.Contraseña = lector.GetString(2)
            usuario.Cargo = lector.GetString(3)
            aux = Integer.Parse(lector.GetString(4))


            If (aux = 0) Then
                usuario.Ocupado = "No"
            Else
                usuario.Ocupado = "SI"
            End If
            lista.Add(usuario)

        End While
        conx.desconectarBD()
        Return lista

    End Function

    Public Function listarUsuariosNoOcupados() As List(Of usuarios)
        conx.conectarBD()
        consulta = conx.conexion.CreateCommand()
        consulta.CommandText = "select u.idUsuario,u.usuario,u.contrasena,c.nombre, u.ocupado from usuarios as u inner join cargos as c on u.idCargo=c.idCargo where ocupado = 0"
        Dim lector As SqlDataReader = consulta.ExecuteReader()
        Dim lista As New List(Of usuarios)
        Dim usuario As usuarios
        Dim aux As Integer = 0
        'Dim i As Nullable(Of DateTime)

        While (lector.Read())
            usuario = New usuarios

            usuario.Nro_Usuario = lector.GetInt32(0)
            usuario.Usuario = lector.GetString(1)
            usuario.Contraseña = lector.GetString(2)
            usuario.Cargo = lector.GetString(3)
            aux = Integer.Parse(lector.GetString(4))


            If (aux = 0) Then
                usuario.Ocupado = "No"
            Else
                usuario.Ocupado = "SI"
            End If
            lista.Add(usuario)

        End While
        conx.desconectarBD()
        Return lista

    End Function

    Public Function buscarUsuario(p_usuario As String, p_contrasena As String) As Boolean
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

            If (p_usuario = lector.GetString(1) Or p_contrasena = lector.GetString(2)) Then
                busqueda = True
            End If
            'lista.Add(usuario)

        End While
        conx.desconectarBD()
        Return busqueda
    End Function

    Public Function buscarSiEsOcupado(p_usuario As String, p_contrasena As String) As Boolean
        Dim busqueda As Boolean = False
        conx.conectarBD()
        consulta = conx.conexion.CreateCommand()
        consulta.CommandText = "select * from usuarios"
        Dim lector As SqlDataReader = consulta.ExecuteReader()
        'Dim lista As New List(Of usuarios)
        'Dim usuario As usuarios
        Dim aux As Integer = 0
        'Dim i As Nullable(Of DateTime)

        While (lector.Read())

            If (p_usuario = lector.GetString(1) And p_contrasena = lector.GetString(2)) Then
                aux = Integer.Parse(lector.GetString(4))
                If (aux = 1) Then
                    busqueda = True
                End If
            End If
            'lista.Add(usuario)

        End While
        conx.desconectarBD()
        Return busqueda
    End Function

    Public Sub actualizarUsuario(p_idUsuario As Integer, p_usuario As String, p_contrasena As String, p_idCargo As Integer)
        Try
            conx.conectarBD()

            consulta = New SqlCommand("update usuarios set usuario='" & p_usuario & "', contrasena='" & p_contrasena & "', idCargo=" & p_idCargo & " where idUsuario=" & p_idUsuario & "", conx.conexion)
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

    Public Sub eliminarUsuario(p_idUsuario As Integer)
        Try
            conx.conectarBD()

            consulta = New SqlCommand("delete from usuarios where idUsuario=" & p_idUsuario & "", conx.conexion)
            consulta.ExecuteNonQuery()

            conx.desconectarBD()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Function busquedaRapida(caracter As String) As List(Of usuarios)
        conx.conectarBD()
        consulta = conx.conexion.CreateCommand()
        consulta.CommandText = "select u.idUsuario,u.usuario,u.contrasena,c.nombre, u.ocupado from usuarios as u inner join cargos as c on u.idCargo=c.idCargo where u.usuario like '%" + caracter + "%' order by nombre"
        Dim lector As SqlDataReader = consulta.ExecuteReader()
        Dim lista As New List(Of usuarios)
        Dim usuario As usuarios
        Dim aux As Integer = 0
        'Dim i As Nullable(Of DateTime)

        While (lector.Read())
            usuario = New usuarios

            usuario.Nro_Usuario = lector.GetInt32(0)
            usuario.Usuario = lector.GetString(1)
            usuario.Contraseña = lector.GetString(2)
            usuario.Cargo = lector.GetString(3)
            aux = Integer.Parse(lector.GetString(4))


            If (aux = 0) Then
                usuario.Ocupado = "No"
            Else
                usuario.Ocupado = "SI"
            End If
            lista.Add(usuario)

        End While
        conx.desconectarBD()
        Return lista

    End Function

End Class
