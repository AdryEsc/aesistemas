<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class abmProductos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(abmProductos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn50porc = New System.Windows.Forms.Button()
        Me.btn40porc = New System.Windows.Forms.Button()
        Me.btn30porc = New System.Windows.Forms.Button()
        Me.btn20porc = New System.Windows.Forms.Button()
        Me.btn10porc = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbCatProd = New System.Windows.Forms.ComboBox()
        Me.cmbProveedor = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtVenta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtIdProducto = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFecAlta = New System.Windows.Forms.DateTimePicker()
        Me.txtDescipcion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.fechaActual = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbtNoactivos = New System.Windows.Forms.RadioButton()
        Me.rbtActivos = New System.Windows.Forms.RadioButton()
        Me.rbtTodos = New System.Windows.Forms.RadioButton()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.dtgProductos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.btn50porc)
        Me.GroupBox1.Controls.Add(Me.btn40porc)
        Me.GroupBox1.Controls.Add(Me.btn30porc)
        Me.GroupBox1.Controls.Add(Me.btn20porc)
        Me.GroupBox1.Controls.Add(Me.btn10porc)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbCatProd)
        Me.GroupBox1.Controls.Add(Me.cmbProveedor)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtVenta)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCosto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtIdProducto)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtStock)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpFecAlta)
        Me.GroupBox1.Controls.Add(Me.txtDescipcion)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtBusqueda)
        Me.GroupBox1.Controls.Add(Me.fechaActual)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.rbtNoactivos)
        Me.GroupBox1.Controls.Add(Me.rbtActivos)
        Me.GroupBox1.Controls.Add(Me.rbtTodos)
        Me.GroupBox1.Controls.Add(Me.btn_eliminar)
        Me.GroupBox1.Controls.Add(Me.btn_actualizar)
        Me.GroupBox1.Controls.Add(Me.btn_agregar)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1307, 195)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos para agregar/actualizar productos"
        '
        'btn50porc
        '
        Me.btn50porc.BackColor = System.Drawing.Color.Transparent
        Me.btn50porc.Location = New System.Drawing.Point(747, 65)
        Me.btn50porc.Name = "btn50porc"
        Me.btn50porc.Size = New System.Drawing.Size(39, 23)
        Me.btn50porc.TabIndex = 71
        Me.btn50porc.Text = "50%"
        Me.btn50porc.UseVisualStyleBackColor = False
        '
        'btn40porc
        '
        Me.btn40porc.BackColor = System.Drawing.Color.Transparent
        Me.btn40porc.Location = New System.Drawing.Point(700, 65)
        Me.btn40porc.Name = "btn40porc"
        Me.btn40porc.Size = New System.Drawing.Size(39, 23)
        Me.btn40porc.TabIndex = 70
        Me.btn40porc.Text = "40%"
        Me.btn40porc.UseVisualStyleBackColor = False
        '
        'btn30porc
        '
        Me.btn30porc.BackColor = System.Drawing.Color.Transparent
        Me.btn30porc.Location = New System.Drawing.Point(655, 65)
        Me.btn30porc.Name = "btn30porc"
        Me.btn30porc.Size = New System.Drawing.Size(39, 23)
        Me.btn30porc.TabIndex = 69
        Me.btn30porc.Text = "30%"
        Me.btn30porc.UseVisualStyleBackColor = False
        '
        'btn20porc
        '
        Me.btn20porc.BackColor = System.Drawing.Color.Transparent
        Me.btn20porc.Location = New System.Drawing.Point(610, 65)
        Me.btn20porc.Name = "btn20porc"
        Me.btn20porc.Size = New System.Drawing.Size(39, 23)
        Me.btn20porc.TabIndex = 68
        Me.btn20porc.Text = "20%"
        Me.btn20porc.UseVisualStyleBackColor = False
        '
        'btn10porc
        '
        Me.btn10porc.BackColor = System.Drawing.Color.Transparent
        Me.btn10porc.Location = New System.Drawing.Point(565, 65)
        Me.btn10porc.Name = "btn10porc"
        Me.btn10porc.Size = New System.Drawing.Size(39, 23)
        Me.btn10porc.TabIndex = 67
        Me.btn10porc.Text = "10%"
        Me.btn10porc.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(101, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "CATEGORIA"
        '
        'cmbCatProd
        '
        Me.cmbCatProd.FormattingEnabled = True
        Me.cmbCatProd.Location = New System.Drawing.Point(11, 168)
        Me.cmbCatProd.Name = "cmbCatProd"
        Me.cmbCatProd.Size = New System.Drawing.Size(290, 21)
        Me.cmbCatProd.TabIndex = 65
        '
        'cmbProveedor
        '
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(11, 115)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(290, 21)
        Me.cmbProveedor.TabIndex = 64
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(562, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(224, 13)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Seleccione el margen para el precio de venta:"
        '
        'txtVenta
        '
        Me.txtVenta.Location = New System.Drawing.Point(439, 67)
        Me.txtVenta.Name = "txtVenta"
        Me.txtVenta.Size = New System.Drawing.Size(100, 20)
        Me.txtVenta.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(436, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "PRECIO DE VENTA"
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(320, 67)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(100, 20)
        Me.txtCosto.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(317, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "PRECIO DE COSTO"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(113, 13)
        Me.Label16.TabIndex = 51
        Me.Label16.Text = "NRO DE PRODUCTO"
        '
        'txtIdProducto
        '
        Me.txtIdProducto.Enabled = False
        Me.txtIdProducto.Location = New System.Drawing.Point(129, 22)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.Size = New System.Drawing.Size(41, 20)
        Me.txtIdProducto.TabIndex = 50
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(100, 99)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 13)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "PROVEEDOR"
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(319, 115)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(101, 20)
        Me.txtStock.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(337, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "STOCK"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(317, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "FECHA DE ALTA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(100, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "DESCRIPCION"
        '
        'dtpFecAlta
        '
        Me.dtpFecAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecAlta.Location = New System.Drawing.Point(320, 169)
        Me.dtpFecAlta.Name = "dtpFecAlta"
        Me.dtpFecAlta.Size = New System.Drawing.Size(100, 20)
        Me.dtpFecAlta.TabIndex = 32
        '
        'txtDescipcion
        '
        Me.txtDescipcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescipcion.Location = New System.Drawing.Point(11, 67)
        Me.txtDescipcion.Name = "txtDescipcion"
        Me.txtDescipcion.Size = New System.Drawing.Size(290, 20)
        Me.txtDescipcion.TabIndex = 30
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(468, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(339, 15)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Ingrese iniciales del nombre para busqueda rapida:"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(813, 18)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(100, 20)
        Me.txtBusqueda.TabIndex = 26
        '
        'fechaActual
        '
        Me.fechaActual.Location = New System.Drawing.Point(544, 169)
        Me.fechaActual.Name = "fechaActual"
        Me.fechaActual.Size = New System.Drawing.Size(56, 20)
        Me.fechaActual.TabIndex = 25
        Me.fechaActual.Visible = False
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(849, 165)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(424, 15)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "*Para actualizar o eliminar, haga click en la tabla en el producto."
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(849, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(444, 15)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "*Para agregar un producto, deben estar cargados todos los campos."
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.Location = New System.Drawing.Point(483, 129)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(55, 51)
        Me.btnLimpiar.TabIndex = 22
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1017, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 20)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Listar:"
        '
        'rbtNoactivos
        '
        Me.rbtNoactivos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtNoactivos.AutoSize = True
        Me.rbtNoactivos.Location = New System.Drawing.Point(1218, 45)
        Me.rbtNoactivos.Name = "rbtNoactivos"
        Me.rbtNoactivos.Size = New System.Drawing.Size(77, 17)
        Me.rbtNoactivos.TabIndex = 20
        Me.rbtNoactivos.TabStop = True
        Me.rbtNoactivos.Text = "No Activos"
        Me.rbtNoactivos.UseVisualStyleBackColor = True
        '
        'rbtActivos
        '
        Me.rbtActivos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtActivos.AutoSize = True
        Me.rbtActivos.Location = New System.Drawing.Point(1152, 45)
        Me.rbtActivos.Name = "rbtActivos"
        Me.rbtActivos.Size = New System.Drawing.Size(60, 17)
        Me.rbtActivos.TabIndex = 19
        Me.rbtActivos.TabStop = True
        Me.rbtActivos.Text = "Activos"
        Me.rbtActivos.UseVisualStyleBackColor = True
        '
        'rbtTodos
        '
        Me.rbtTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtTodos.AutoSize = True
        Me.rbtTodos.Location = New System.Drawing.Point(1082, 45)
        Me.rbtTodos.Name = "rbtTodos"
        Me.rbtTodos.Size = New System.Drawing.Size(55, 17)
        Me.rbtTodos.TabIndex = 18
        Me.rbtTodos.TabStop = True
        Me.rbtTodos.Text = "Todos"
        Me.rbtTodos.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_eliminar.Location = New System.Drawing.Point(1169, 90)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(115, 50)
        Me.btn_eliminar.TabIndex = 17
        Me.btn_eliminar.Text = "ELIMINAR"
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_actualizar
        '
        Me.btn_actualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_actualizar.Image = CType(resources.GetObject("btn_actualizar.Image"), System.Drawing.Image)
        Me.btn_actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_actualizar.Location = New System.Drawing.Point(1021, 90)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(128, 50)
        Me.btn_actualizar.TabIndex = 16
        Me.btn_actualizar.Text = "ACTUALIZAR"
        Me.btn_actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_actualizar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_agregar.Image = CType(resources.GetObject("btn_agregar.Image"), System.Drawing.Image)
        Me.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_agregar.Location = New System.Drawing.Point(882, 90)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(116, 50)
        Me.btn_agregar.TabIndex = 15
        Me.btn_agregar.Text = "AGREGAR"
        Me.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'dtgProductos
        '
        Me.dtgProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgProductos.Location = New System.Drawing.Point(12, 204)
        Me.dtgProductos.Name = "dtgProductos"
        Me.dtgProductos.Size = New System.Drawing.Size(1285, 367)
        Me.dtgProductos.TabIndex = 1
        '
        'abmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1309, 576)
        Me.Controls.Add(Me.dtgProductos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "abmProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRODUCTOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtgProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_actualizar As Button
    Friend WithEvents btn_agregar As Button
    Friend WithEvents dtgProductos As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents rbtNoactivos As RadioButton
    Friend WithEvents rbtActivos As RadioButton
    Friend WithEvents rbtTodos As RadioButton
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents fechaActual As DateTimePicker
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFecAlta As DateTimePicker
    Friend WithEvents txtDescipcion As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtIdProducto As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtVenta As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbCatProd As ComboBox
    Friend WithEvents cmbProveedor As ComboBox
    Friend WithEvents btn50porc As Button
    Friend WithEvents btn40porc As Button
    Friend WithEvents btn30porc As Button
    Friend WithEvents btn20porc As Button
    Friend WithEvents btn10porc As Button
End Class
