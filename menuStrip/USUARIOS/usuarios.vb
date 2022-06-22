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
    Dim c_activo As Integer
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

    Public Property Activo() As Integer
        Get
            Return Me.c_activo
        End Get
        Set(value As Integer)
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
        Try
            conx.conectarBD()

            consulta = New SqlCommand("insert into usuarios (dni,nombre,apellido,usuario,contrasena,email,rol) values(" + p_dni + ",'" + p_nombre + "','" + p_apellido + "','" + p_usuario + "','" + p_contrasena + "','" + p_email + "','" + p_rol + "')", conx.conexion)
            consulta.ExecuteNonQuery()
            MessageBox.Show("!El usuario: " + p_usuario.ToString + " con cargo: " + p_rol + " fue cargado exitosamente¡", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conx.desconectarBD()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


End Class
