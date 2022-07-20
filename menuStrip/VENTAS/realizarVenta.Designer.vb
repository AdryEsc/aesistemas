<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class realizarVenta
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(realizarVenta))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtIdEmp = New System.Windows.Forms.TextBox()
        Me.lblIdEmp = New System.Windows.Forms.Label()
        Me.txtNombCliente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDniCliente = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombVen = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNroVenta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAgregarProd = New System.Windows.Forms.Button()
        Me.dtgProd = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtgVentaProd = New System.Windows.Forms.DataGridView()
        Me.codProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.venta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEliminarProd = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCantidadProd = New System.Windows.Forms.TextBox()
        Me.btnCancVenta = New System.Windows.Forms.Button()
        Me.btnConfVenta = New System.Windows.Forms.Button()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPagaCon = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCambio = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgVentaProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.btnAgregarProd)
        Me.GroupBox1.Controls.Add(Me.dtgProd)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtBusqueda)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1034, 373)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox2.Controls.Add(Me.txtIdEmp)
        Me.GroupBox2.Controls.Add(Me.lblIdEmp)
        Me.GroupBox2.Controls.Add(Me.txtNombCliente)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtDniCliente)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btnBuscarCliente)
        Me.GroupBox2.Controls.Add(Me.txtIdCliente)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtNombVen)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtNroVenta)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.dtpFecha)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1028, 111)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        '
        'txtIdEmp
        '
        Me.txtIdEmp.Location = New System.Drawing.Point(48, 37)
        Me.txtIdEmp.Name = "txtIdEmp"
        Me.txtIdEmp.Size = New System.Drawing.Size(47, 20)
        Me.txtIdEmp.TabIndex = 46
        Me.txtIdEmp.Visible = False
        '
        'lblIdEmp
        '
        Me.lblIdEmp.AutoSize = True
        Me.lblIdEmp.Location = New System.Drawing.Point(6, 42)
        Me.lblIdEmp.Name = "lblIdEmp"
        Me.lblIdEmp.Size = New System.Drawing.Size(36, 13)
        Me.lblIdEmp.TabIndex = 45
        Me.lblIdEmp.Text = "idEmp"
        Me.lblIdEmp.Visible = False
        '
        'txtNombCliente
        '
        Me.txtNombCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombCliente.Location = New System.Drawing.Point(803, 73)
        Me.txtNombCliente.Name = "txtNombCliente"
        Me.txtNombCliente.Size = New System.Drawing.Size(215, 20)
        Me.txtNombCliente.TabIndex = 44
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(675, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 13)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "NOMBRE Y APELLIDO:"
        '
        'txtDniCliente
        '
        Me.txtDniCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDniCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDniCliente.Location = New System.Drawing.Point(803, 42)
        Me.txtDniCliente.Name = "txtDniCliente"
        Me.txtDniCliente.Size = New System.Drawing.Size(115, 20)
        Me.txtDniCliente.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(768, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "DNI:"
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Image = Global.menuStrip.My.Resources.Resources.vector_find_icon
        Me.btnBuscarCliente.Location = New System.Drawing.Point(888, 9)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(30, 27)
        Me.btnBuscarCliente.TabIndex = 40
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'txtIdCliente
        '
        Me.txtIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdCliente.Enabled = False
        Me.txtIdCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCliente.Location = New System.Drawing.Point(803, 11)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(79, 20)
        Me.txtIdCliente.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(697, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "NRO DE CLIENTE:"
        '
        'txtNombVen
        '
        Me.txtNombVen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombVen.Enabled = False
        Me.txtNombVen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombVen.Location = New System.Drawing.Point(108, 62)
        Me.txtNombVen.Name = "txtNombVen"
        Me.txtNombVen.Size = New System.Drawing.Size(264, 20)
        Me.txtNombVen.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "VENDEDOR/A:"
        '
        'txtNroVenta
        '
        Me.txtNroVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroVenta.Enabled = False
        Me.txtNroVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroVenta.Location = New System.Drawing.Point(108, 18)
        Me.txtNroVenta.Name = "txtNroVenta"
        Me.txtNroVenta.Size = New System.Drawing.Size(117, 20)
        Me.txtNroVenta.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "NRO DE VENTA:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(246, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "FECHA:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(297, 19)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(75, 20)
        Me.dtpFecha.TabIndex = 25
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.menuStrip.My.Resources.Resources.images
        Me.PictureBox1.Location = New System.Drawing.Point(803, 118)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(225, 248)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'btnAgregarProd
        '
        Me.btnAgregarProd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarProd.Image = Global.menuStrip.My.Resources.Resources.images__2_
        Me.btnAgregarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarProd.Location = New System.Drawing.Point(677, 118)
        Me.btnAgregarProd.Name = "btnAgregarProd"
        Me.btnAgregarProd.Size = New System.Drawing.Size(111, 49)
        Me.btnAgregarProd.TabIndex = 31
        Me.btnAgregarProd.Text = "AGREGAR"
        Me.btnAgregarProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregarProd.UseVisualStyleBackColor = True
        '
        'dtgProd
        '
        Me.dtgProd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgProd.Location = New System.Drawing.Point(0, 173)
        Me.dtgProd.Name = "dtgProd"
        Me.dtgProd.Size = New System.Drawing.Size(788, 193)
        Me.dtgProd.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 118)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(346, 15)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Ingrese iniciales del producto para busqueda rapida:"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBusqueda.Location = New System.Drawing.Point(363, 117)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(100, 20)
        Me.txtBusqueda.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(625, 15)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "SELECCIONE EN LA TABLA EL PRODUCTO A AGREGAR, LUEGO ELIJA LA CANTIDAD A VENDER."
        '
        'dtgVentaProd
        '
        Me.dtgVentaProd.AllowUserToAddRows = False
        Me.dtgVentaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgVentaProd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codProducto, Me.descripcion, Me.venta, Me.cantidad, Me.subtotal, Me.btnEliminarProd})
        Me.dtgVentaProd.Location = New System.Drawing.Point(1, 381)
        Me.dtgVentaProd.Name = "dtgVentaProd"
        Me.dtgVentaProd.Size = New System.Drawing.Size(843, 237)
        Me.dtgVentaProd.TabIndex = 3
        '
        'codProducto
        '
        Me.codProducto.HeaderText = "CODIGO DE PRODUCTO"
        Me.codProducto.Name = "codProducto"
        Me.codProducto.ReadOnly = True
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "DESCRIPCION"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 300
        '
        'venta
        '
        Me.venta.HeaderText = "PRECIO DE VENTA"
        Me.venta.Name = "venta"
        Me.venta.ReadOnly = True
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "CANTIDAD"
        Me.cantidad.Name = "cantidad"
        '
        'subtotal
        '
        Me.subtotal.HeaderText = "SUBTOTAL"
        Me.subtotal.Name = "subtotal"
        '
        'btnEliminarProd
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red
        Me.btnEliminarProd.DefaultCellStyle = DataGridViewCellStyle1
        Me.btnEliminarProd.HeaderText = ""
        Me.btnEliminarProd.Name = "btnEliminarProd"
        Me.btnEliminarProd.Text = "Borrar"
        Me.btnEliminarProd.UseColumnTextForButtonValue = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(295, 642)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "TOTAL A PAGAR:"
        '
        'txtTotal
        '
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Location = New System.Drawing.Point(396, 639)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 643)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "CANTIDAD DE PRODUCTOS:"
        '
        'txtCantidadProd
        '
        Me.txtCantidadProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidadProd.Enabled = False
        Me.txtCantidadProd.Location = New System.Drawing.Point(180, 640)
        Me.txtCantidadProd.Name = "txtCantidadProd"
        Me.txtCantidadProd.Size = New System.Drawing.Size(62, 20)
        Me.txtCantidadProd.TabIndex = 10
        '
        'btnCancVenta
        '
        Me.btnCancVenta.BackColor = System.Drawing.Color.White
        Me.btnCancVenta.Image = Global.menuStrip.My.Resources.Resources.descarga__1_1
        Me.btnCancVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancVenta.Location = New System.Drawing.Point(860, 482)
        Me.btnCancVenta.Name = "btnCancVenta"
        Me.btnCancVenta.Size = New System.Drawing.Size(159, 51)
        Me.btnCancVenta.TabIndex = 8
        Me.btnCancVenta.Text = "CANCELAR VENTA"
        Me.btnCancVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancVenta.UseVisualStyleBackColor = False
        '
        'btnConfVenta
        '
        Me.btnConfVenta.BackColor = System.Drawing.Color.White
        Me.btnConfVenta.Image = Global.menuStrip.My.Resources.Resources.descarga2
        Me.btnConfVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfVenta.Location = New System.Drawing.Point(860, 381)
        Me.btnConfVenta.Name = "btnConfVenta"
        Me.btnConfVenta.Size = New System.Drawing.Size(159, 47)
        Me.btnConfVenta.TabIndex = 6
        Me.btnConfVenta.Text = "CONFIRMAR VENTA"
        Me.btnConfVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConfVenta.UseVisualStyleBackColor = False
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.menuStrip.My.Resources.Resources.descarga__1_
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(675, 642)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "PAGA CON:"
        '
        'txtPagaCon
        '
        Me.txtPagaCon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPagaCon.Location = New System.Drawing.Point(746, 639)
        Me.txtPagaCon.Name = "txtPagaCon"
        Me.txtPagaCon.Size = New System.Drawing.Size(88, 20)
        Me.txtPagaCon.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(868, 642)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "CAMBIO:"
        '
        'txtCambio
        '
        Me.txtCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCambio.Location = New System.Drawing.Point(925, 639)
        Me.txtCambio.Name = "txtCambio"
        Me.txtCambio.Size = New System.Drawing.Size(80, 20)
        Me.txtCambio.TabIndex = 15
        '
        'realizarVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1031, 684)
        Me.Controls.Add(Me.txtCambio)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtPagaCon)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCantidadProd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancVenta)
        Me.Controls.Add(Me.btnConfVenta)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtgVentaProd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "realizarVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VENTA DE PRODUCTOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgVentaProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents dtgProd As DataGridView
    Friend WithEvents btnAgregarProd As Button
    Friend WithEvents dtgVentaProd As DataGridView
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnConfVenta As Button
    Friend WithEvents btnCancVenta As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCantidadProd As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtNombCliente As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDniCliente As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNombVen As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNroVenta As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIdEmp As TextBox
    Friend WithEvents lblIdEmp As Label
    Friend WithEvents codProducto As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents venta As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents btnEliminarProd As DataGridViewButtonColumn
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPagaCon As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCambio As TextBox
End Class
