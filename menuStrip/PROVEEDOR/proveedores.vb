Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration

Public Class proveedores
    Dim c_idProveedor As Integer
    Dim c_nombre As String
    Dim c_cuit As String
    Dim c_direccion As String
    Dim c_telefono As String
    Dim c_email As String
    Dim c_fechaAlta As Date
    Dim c_activo As String
    'Dim c_fecheBaja As Date

    Dim conx As New conexionBD()
    Dim consulta As SqlCommand

    Public Property Nro_Proveedor() As Integer
        Get
            Return Me.c_idProveedor
        End Get
        Set(value As Integer)
            Me.c_idProveedor = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return Me.c_nombre
        End Get
        Set(value As String)
            Me.c_nombre = value
        End Set
    End Property

    Public Property Cuit() As String
        Get
            Return Me.c_cuit
        End Get
        Set(value As String)
            Me.c_cuit = value
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

    Public Property Telefono() As String
        Get
            Return Me.c_telefono
        End Get
        Set(value As String)
            Me.c_telefono = value
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

    Public Sub insertarProveedor(p_nombre As String, p_cuit As String, p_direccion As String, p_telefono As String, p_email As String)
        'Dim busqueda As Boolean
        'Dim aux_dni As Integer = Integer.Parse(p_dni)
        'busqueda = buscarUsuario(aux_dni, p_email)
        Try
            conx.conectarBD()

            'If (busqueda = True) Then
            '    MessageBox.Show("El DNI o el email a ingresar ya existe en la base de datos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            '    Exit Try
            'End If

            consulta = New SqlCommand("insert into proveedores (nombre,cuit,direccion,telefono,email) values('" & p_nombre & "','" & p_cuit & "','" & p_direccion & "','" & p_telefono & "','" & p_email & "')", conx.conexion)
            consulta.ExecuteNonQuery()
            MessageBox.Show("!El proveedor: " + p_nombre.ToString + " , CUIT: " + p_cuit + " fue cargado exitosamente¡", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conx.desconectarBD()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        conx.desconectarBD()
    End Sub

    Public Function listarProveedores() As List(Of proveedores)
        conx.conectarBD()
        consulta = conx.conexion.CreateCommand()
        consulta.CommandText = "select * from proveedores where idProveedor <> 4 order by nombre"
        Dim lector As SqlDataReader = consulta.ExecuteReader()
        Dim lista As New List(Of proveedores)
        Dim proveedor As proveedores
        Dim aux As Integer = 0
        'Dim i As Nullable(Of DateTime)

        While (lector.Read())
            proveedor = New proveedores

            proveedor.Nro_Proveedor = lector.GetInt32(0)
            proveedor.Nombre = lector.GetString(1)
            proveedor.Cuit = lector.GetString(2)
            proveedor.Direccion = lector.GetString(3)
            proveedor.Telefono = lector.GetString(4)
            proveedor.Email = lector.GetString(5)
            proveedor.Fecha_Alta = lector.GetDateTime(6)
            aux = Convert.ToInt32(lector.GetString(7))
            'cliente.Fecha_Baja = Convert.ToString(lector.GetDateTime(9))

            If (aux = 0) Then
                proveedor.Activo = "Si"
            Else
                proveedor.Activo = "No"
            End If
            lista.Add(proveedor)

        End While
        conx.desconectarBD()
        Return lista

    End Function

    Public Function listarProveedoresActivos() As List(Of proveedores)
        conx.conectarBD()
        consulta = conx.conexion.CreateCommand()
        consulta.CommandText = "select * from proveedores where activo=0 and idProveedor <> 4 order by nombre"
        Dim lector As SqlDataReader = consulta.ExecuteReader()
        Dim lista As New List(Of proveedores)
        Dim proveedor As proveedores
        Dim aux As Integer = 0
        'Dim i As Nullable(Of DateTime)

        While (lector.Read())
            proveedor = New proveedores

            proveedor.Nro_Proveedor = lector.GetInt32(0)
            proveedor.Nombre = lector.GetString(1)
            proveedor.Cuit = lector.GetString(2)
            proveedor.Direccion = lector.GetString(3)
            proveedor.Telefono = lector.GetString(4)
            proveedor.Email = lector.GetString(5)
            proveedor.Fecha_Alta = lector.GetDateTime(6)
            aux = Convert.ToInt32(lector.GetString(7))
            'cliente.Fecha_Baja = Convert.ToString(lector.GetDateTime(9))

            If (aux = 0) Then
                proveedor.Activo = "Si"
            Else
                proveedor.Activo = "No"
            End If
            lista.Add(proveedor)

        End While
        conx.desconectarBD()
        Return lista

    End Function

    Public Function listarProveedoresInactivos() As List(Of proveedores)
        conx.conectarBD()
        consulta = conx.conexion.CreateCommand()
        consulta.CommandText = "select * from proveedores where activo=1 and idProveedor <> 4 order by nombre"
        Dim lector As SqlDataReader = consulta.ExecuteReader()
        Dim lista As New List(Of proveedores)
        Dim proveedor As proveedores
        Dim aux As Integer = 0
        'Dim i As Nullable(Of DateTime)

        While (lector.Read())
            proveedor = New proveedores

            proveedor.Nro_Proveedor = lector.GetInt32(0)
            proveedor.Nombre = lector.GetString(1)
            proveedor.Cuit = lector.GetString(2)
            proveedor.Direccion = lector.GetString(3)
            proveedor.Telefono = lector.GetString(4)
            proveedor.Email = lector.GetString(5)
            proveedor.Fecha_Alta = lector.GetDateTime(6)
            aux = Convert.ToInt32(lector.GetString(7))
            'cliente.Fecha_Baja = Convert.ToString(lector.GetDateTime(9))

            If (aux = 0) Then
                proveedor.Activo = "Si"
            Else
                proveedor.Activo = "No"
            End If
            lista.Add(proveedor)

        End While
        conx.desconectarBD()
        Return lista

    End Function

    Public Function buscarProveedor(p_cuit As String, p_email As String) As Boolean
        Dim busqueda As Boolean = False
        conx.conectarBD()
        consulta = conx.conexion.CreateCommand()
        consulta.CommandText = "select * from proveedores where idProveedor <> 4"
        Dim lector As SqlDataReader = consulta.ExecuteReader()
        'Dim lista As New List(Of proveedores)
        'Dim proveedor As proveedores
        'Dim aux As Integer = 0
        'Dim i As Nullable(Of DateTime)

        While (lector.Read())
            'usuario = New usuarios

            'proveedor.Nro_Proveedor = lector.GetInt32(0)
            'proveedor.Nombre = lector.GetString(1)
            'proveedor.Cuit = lector.GetString(2)
            'proveedor.Direccion = lector.GetString(3)
            'proveedor.Telefono = lector.GetString(4)
            'proveedor.Email = lector.GetString(5)
            'proveedor.Fecha_Alta = lector.GetDateTime(6)
            'aux = Convert.ToInt32(lector.GetString(7))
            ''cliente.Fecha_Baja = Convert.ToString(lector.GetDateTime(9))


            If (p_cuit = lector.GetString(2) Or p_email = lector.GetString(5)) Then
                busqueda = True
            End If
            'lista.Add(usuario)

        End While
        conx.desconectarBD()
        Return busqueda
    End Function

    Public Sub actualizarProveedor(p_idProveedor As Integer, p_nombre As String, p_cuit As String, p_direccion As String, p_telefono As String, p_email As String)
        Try
            conx.conectarBD()

            consulta = New SqlCommand("update proveedores set nombre='" & p_nombre & "',cuit='" & p_cuit & "', direccion='" & p_direccion & "', telefono='" & p_telefono & "', email='" & p_email & "' where idProveedor=" & p_idProveedor & "", conx.conexion)
            consulta.ExecuteNonQuery()

            conx.desconectarBD()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub eliminarProveedor(p_idProveedor As Integer, p_fecha As Date)
        Try
            conx.conectarBD()

            consulta = New SqlCommand("update proveedores set fechaBaja = '" & p_fecha & "',activo=1 where idProveedor=" & p_idProveedor & "", conx.conexion)
            consulta.ExecuteNonQuery()

            conx.desconectarBD()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Function busquedaRapida(ByVal caracter As String) As List(Of proveedores)
        conx.conectarBD()
        consulta = conx.conexion.CreateCommand()
        consulta.CommandText = "select * from proveedores where nombre like '%" + caracter + "%' and idProveedor <> 4 order by nombre"
        Dim lector As SqlDataReader = consulta.ExecuteReader()
        Dim lista As New List(Of proveedores)
        Dim proveedor As proveedores
        Dim aux As Integer = 0
        'Dim i As Nullable(Of DateTime)

        While (lector.Read())
            proveedor = New proveedores

            proveedor.Nro_Proveedor = lector.GetInt32(0)
            proveedor.Nombre = lector.GetString(1)
            proveedor.Cuit = lector.GetString(2)
            proveedor.Direccion = lector.GetString(3)
            proveedor.Telefono = lector.GetString(4)
            proveedor.Email = lector.GetString(5)
            proveedor.Fecha_Alta = lector.GetDateTime(6)
            aux = Convert.ToInt32(lector.GetString(7))
            'cliente.Fecha_Baja = Convert.ToString(lector.GetDateTime(9))

            If (aux = 0) Then
                proveedor.Activo = "Si"
            Else
                proveedor.Activo = "No"
            End If
            lista.Add(proveedor)

        End While
        conx.desconectarBD()
        Return lista

    End Function

End Class
