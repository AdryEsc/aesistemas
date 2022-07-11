Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration

Public Class productos
    Dim c_idProducto As Integer
    Dim c_descripcion As String
    Dim c_costo As Decimal
    Dim c_venta As Decimal
    Dim c_stock As Decimal
    Dim c_proveedor As String
    Dim c_categoria As String
    Dim c_fechaAlta As Date
    Dim c_activo As String

    Dim conx As New conexionBD()
    Dim consulta As SqlCommand
    Dim adapter As SqlDataAdapter
    Dim data As DataSet

    Public Property Nro_Producto() As Integer
        Get
            Return Me.c_idProducto
        End Get
        Set(value As Integer)
            Me.c_idProducto = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return Me.c_descripcion
        End Get
        Set(value As String)
            Me.c_descripcion = value
        End Set
    End Property

    Public Property Precio_Costo() As Decimal
        Get
            Return Me.c_costo
        End Get
        Set(value As Decimal)
            Me.c_costo = value
        End Set
    End Property

    Public Property Precio_Venta() As Decimal
        Get
            Return Me.c_venta
        End Get
        Set(value As Decimal)
            Me.c_venta = value
        End Set
    End Property

    Public Property Stock() As Decimal
        Get
            Return Me.c_stock
        End Get
        Set(value As Decimal)
            Me.c_stock = value
        End Set
    End Property

    Public Property Proveedor() As String
        Get
            Return Me.c_proveedor
        End Get
        Set(value As String)
            Me.c_proveedor = value
        End Set
    End Property

    Public Property Categoria() As String
        Get
            Return Me.c_categoria
        End Get
        Set(value As String)
            Me.c_categoria = value
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

    Public Function listarProductos() As List(Of productos)
        conx.conectarBD()
        consulta = conx.conexion.CreateCommand()
        consulta.CommandText = "select p.idProducto, p.descripcion, p.costo, p.venta, pv.nombre, p.fechaAlta, p.activo, p.stock, cp.descripcion from Productos as p join Proveedores as pv on p.idProveedor=pv.idProveedor join Categorias_Productos as cp on p.idCategoria=cp.idCategoria order by p.descripcion"
        Dim lector As SqlDataReader = consulta.ExecuteReader()
        Dim lista As New List(Of productos)
        Dim producto As productos
        Dim aux As Integer = 0
        'Dim i As Nullable(Of DateTime)

        While (lector.Read())
            producto = New productos

            producto.Nro_Producto = lector.GetInt32(0)
            producto.Descripcion = lector.GetString(1)
            producto.Precio_Costo = lector.GetDecimal(2)
            producto.Precio_Venta = lector.GetDecimal(3)
            producto.Proveedor = lector.GetString(4)
            producto.Fecha_Alta = lector.GetDateTime(5)
            aux = Convert.ToInt32(lector.GetString(6))
            If (aux = 0) Then
                producto.Activo = "SI"
            Else
                producto.Activo = "No"
            End If
            producto.Stock = lector.GetDecimal(7)
            producto.Categoria = lector.GetString(8)


            lista.Add(producto)

        End While
        conx.desconectarBD()
        Return lista

    End Function

    Public Function listarProductosActivos() As List(Of productos)
        conx.conectarBD()
        consulta = conx.conexion.CreateCommand()
        consulta.CommandText = "select p.idProducto, p.descripcion, p.costo, p.venta, pv.nombre, p.fechaAlta, p.activo, p.stock, cp.descripcion from Productos as p join Proveedores as pv on p.idProveedor=pv.idProveedor join Categorias_Productos as cp on p.idCategoria=cp.idCategoria where p.activo=0 order by p.descripcion"
        Dim lector As SqlDataReader = consulta.ExecuteReader()
        Dim lista As New List(Of productos)
        Dim producto As productos
        Dim aux As Integer = 0
        'Dim i As Nullable(Of DateTime)

        While (lector.Read())
            producto = New productos

            producto.Nro_Producto = lector.GetInt32(0)
            producto.Descripcion = lector.GetString(1)
            producto.Precio_Costo = lector.GetDecimal(2)
            producto.Precio_Venta = lector.GetDecimal(3)
            producto.Proveedor = lector.GetString(4)
            producto.Fecha_Alta = lector.GetDateTime(5)
            aux = Convert.ToInt32(lector.GetString(6))
            If (aux = 0) Then
                producto.Activo = "SI"
            Else
                producto.Activo = "No"
            End If
            producto.Stock = lector.GetDecimal(7)
            producto.Categoria = lector.GetString(8)


            lista.Add(producto)

        End While
        conx.desconectarBD()
        Return lista

    End Function

    Public Function listarProductosInactivos() As List(Of productos)
        conx.conectarBD()
        consulta = conx.conexion.CreateCommand()
        consulta.CommandText = "select p.idProducto, p.descripcion, p.costo, p.venta, pv.nombre, p.fechaAlta, p.activo, p.stock, cp.descripcion from Productos as p join Proveedores as pv on p.idProveedor=pv.idProveedor join Categorias_Productos as cp on p.idCategoria=cp.idCategoria where p.activo=1 order by p.descripcion"
        Dim lector As SqlDataReader = consulta.ExecuteReader()
        Dim lista As New List(Of productos)
        Dim producto As productos
        Dim aux As Integer = 0
        'Dim i As Nullable(Of DateTime)

        While (lector.Read())
            producto = New productos

            producto.Nro_Producto = lector.GetInt32(0)
            producto.Descripcion = lector.GetString(1)
            producto.Precio_Costo = lector.GetDecimal(2)
            producto.Precio_Venta = lector.GetDecimal(3)
            producto.Proveedor = lector.GetString(4)
            producto.Fecha_Alta = lector.GetDateTime(5)
            aux = Convert.ToInt32(lector.GetString(6))
            If (aux = 0) Then
                producto.Activo = "SI"
            Else
                producto.Activo = "No"
            End If
            producto.Stock = lector.GetDecimal(7)
            producto.Categoria = lector.GetString(8)


            lista.Add(producto)

        End While
        conx.desconectarBD()
        Return lista

    End Function

    Public Sub insertarProducto(ByVal p_descripcion As String, ByVal p_costo As Decimal, ByVal p_venta As Decimal, ByVal p_idProveedor As Integer, ByVal p_stock As Decimal, ByVal p_fechaAlta As Date, ByVal p_idCatProd As Integer)

        Try
            conx.conectarBD()

            consulta = New SqlCommand("insert into productos (descripcion,costo,venta,idProveedor,fechaAlta,stock,idCategoria) values('" & p_descripcion & "'," & p_costo & "," & p_venta & "," & p_idProveedor & ",'" & p_fechaAlta & "'," & p_stock & "," & p_idCatProd & ")", conx.conexion)
            'MsgBox(consulta.ToString)
            consulta.ExecuteNonQuery()
            MessageBox.Show("!El producto: " + p_descripcion.ToString + " fue cargado exitosamente¡", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conx.desconectarBD()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        conx.desconectarBD()
    End Sub

    Public Function buscarProducto(ByVal p_descripcion As String) As Boolean
        Dim busqueda As Boolean = False
        conx.conectarBD()
        consulta = conx.conexion.CreateCommand()
        consulta.CommandText = "select * from productos"
        Dim lector As SqlDataReader = consulta.ExecuteReader()

        While (lector.Read())

            If (p_descripcion = lector.GetString(1)) Then
                busqueda = True
            End If

        End While
        conx.desconectarBD()
        Return busqueda
    End Function

    Public Sub actualizarProducto(ByVal p_idProducto As Integer, ByVal p_descripcion As String, ByVal p_costo As Decimal, ByVal p_venta As Decimal, ByVal p_idProveedor As Integer, ByVal p_stock As Decimal, ByVal p_idCategoria As Integer)
        Try
            conx.conectarBD()

            consulta = New SqlCommand("update productos set descripcion='" & p_descripcion & "', costo=" & p_costo & ", venta=" & p_venta & ", idProveedor=" & p_idProveedor & ", stock=" & p_stock & ", idCategoria=" & p_idCategoria & " where idProducto=" & p_idProducto & "", conx.conexion)
            consulta.ExecuteNonQuery()

            conx.desconectarBD()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub eliminarProducto(ByVal p_idProducto As Integer)
        Try
            conx.conectarBD()

            consulta = New SqlCommand("update productos set activo=1 where idProducto=" & p_idProducto & "", conx.conexion)
            consulta.ExecuteNonQuery()

            conx.desconectarBD()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Function busquedaRapida(ByVal caracter As String) As List(Of productos)
        conx.conectarBD()
        consulta = conx.conexion.CreateCommand()
        consulta.CommandText = "select p.idProducto, p.descripcion, p.costo, p.venta, pv.nombre, p.fechaAlta, p.activo, p.stock, cp.descripcion from Productos as p join Proveedores as pv on p.idProveedor=pv.idProveedor join Categorias_Productos as cp on p.idCategoria=cp.idCategoria where p.descripcion like '%" + caracter + "%' order by p.descripcion"
        Dim lector As SqlDataReader = consulta.ExecuteReader()
        Dim lista As New List(Of productos)
        Dim producto As productos
        Dim aux As Integer = 0
        'Dim i As Nullable(Of DateTime)

        While (lector.Read())
            producto = New productos

            producto.Nro_Producto = lector.GetInt32(0)
            producto.Descripcion = lector.GetString(1)
            producto.Precio_Costo = lector.GetDecimal(2)
            producto.Precio_Venta = lector.GetDecimal(3)
            producto.Proveedor = lector.GetString(4)
            producto.Fecha_Alta = lector.GetDateTime(5)
            aux = Convert.ToInt32(lector.GetString(6))
            If (aux = 0) Then
                producto.Activo = "SI"
            Else
                producto.Activo = "No"
            End If
            producto.Stock = lector.GetDecimal(7)
            producto.Categoria = lector.GetString(8)


            lista.Add(producto)

        End While
        conx.desconectarBD()
        Return lista

    End Function

    Public Sub comboboxProveedores(ByVal cmb As ComboBox)
        conx.conectarBD()
        consulta = conx.conexion.CreateCommand()
        consulta.CommandText = "select * from proveedores"
        adapter = New System.Data.SqlClient.SqlDataAdapter(consulta.CommandText, conx.conexion)
        data = New DataSet
        adapter.Fill(data)
        cmb.DataSource = data.Tables(0)
        cmb.DisplayMember = "nombre"
        cmb.ValueMember = "idProveedor"
        conx.desconectarBD()
    End Sub

    Public Sub comboboxCatProd(ByVal cmb As ComboBox)
        conx.conectarBD()
        consulta = conx.conexion.CreateCommand()
        consulta.CommandText = "select * from categorias_productos"
        adapter = New System.Data.SqlClient.SqlDataAdapter(consulta.CommandText, conx.conexion)
        data = New DataSet
        adapter.Fill(data)
        cmb.DataSource = data.Tables(0)
        cmb.DisplayMember = "descripcion"
        cmb.ValueMember = "idCategoria"
        conx.desconectarBD()
    End Sub

















End Class
