<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AppAESistemasEmp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppAESistemasEmp))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GestionDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AMBClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductomasVendidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MejorClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasMensualesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIR = New System.Windows.Forms.ToolStripMenuItem()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDeProductosToolStripMenuItem, Me.GestionDeClientesToolStripMenuItem, Me.GestionDeProveedoresToolStripMenuItem, Me.GestionDeVentasToolStripMenuItem, Me.InformesToolStripMenuItem, Me.SALIR})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1121, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GestionDeProductosToolStripMenuItem
        '
        Me.GestionDeProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMDeProductosToolStripMenuItem})
        Me.GestionDeProductosToolStripMenuItem.Image = Global.menuStrip.My.Resources.Resources.icono_producto
        Me.GestionDeProductosToolStripMenuItem.Name = "GestionDeProductosToolStripMenuItem"
        Me.GestionDeProductosToolStripMenuItem.Size = New System.Drawing.Size(148, 20)
        Me.GestionDeProductosToolStripMenuItem.Text = "Gestion de productos"
        '
        'ABMDeProductosToolStripMenuItem
        '
        Me.ABMDeProductosToolStripMenuItem.Name = "ABMDeProductosToolStripMenuItem"
        Me.ABMDeProductosToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ABMDeProductosToolStripMenuItem.Text = "ABM de productos"
        '
        'GestionDeClientesToolStripMenuItem
        '
        Me.GestionDeClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AMBClientesToolStripMenuItem})
        Me.GestionDeClientesToolStripMenuItem.Image = Global.menuStrip.My.Resources.Resources.cliente
        Me.GestionDeClientesToolStripMenuItem.Name = "GestionDeClientesToolStripMenuItem"
        Me.GestionDeClientesToolStripMenuItem.Size = New System.Drawing.Size(134, 20)
        Me.GestionDeClientesToolStripMenuItem.Text = "Gestion de clientes"
        '
        'AMBClientesToolStripMenuItem
        '
        Me.AMBClientesToolStripMenuItem.Name = "AMBClientesToolStripMenuItem"
        Me.AMBClientesToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.AMBClientesToolStripMenuItem.Text = "AMB Clientes"
        '
        'GestionDeProveedoresToolStripMenuItem
        '
        Me.GestionDeProveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMProveedoresToolStripMenuItem})
        Me.GestionDeProveedoresToolStripMenuItem.Image = Global.menuStrip.My.Resources.Resources.provvedor
        Me.GestionDeProveedoresToolStripMenuItem.Name = "GestionDeProveedoresToolStripMenuItem"
        Me.GestionDeProveedoresToolStripMenuItem.Size = New System.Drawing.Size(159, 20)
        Me.GestionDeProveedoresToolStripMenuItem.Text = "Gestion de proveedores"
        '
        'ABMProveedoresToolStripMenuItem
        '
        Me.ABMProveedoresToolStripMenuItem.Name = "ABMProveedoresToolStripMenuItem"
        Me.ABMProveedoresToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ABMProveedoresToolStripMenuItem.Text = "ABM Proveedores"
        '
        'GestionDeVentasToolStripMenuItem
        '
        Me.GestionDeVentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMVentasToolStripMenuItem})
        Me.GestionDeVentasToolStripMenuItem.Image = Global.menuStrip.My.Resources.Resources.ventas
        Me.GestionDeVentasToolStripMenuItem.Name = "GestionDeVentasToolStripMenuItem"
        Me.GestionDeVentasToolStripMenuItem.Size = New System.Drawing.Size(128, 20)
        Me.GestionDeVentasToolStripMenuItem.Text = "Gestion de ventas"
        '
        'ABMVentasToolStripMenuItem
        '
        Me.ABMVentasToolStripMenuItem.Name = "ABMVentasToolStripMenuItem"
        Me.ABMVentasToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ABMVentasToolStripMenuItem.Text = "ABM Ventas"
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.ProveedoresToolStripMenuItem})
        Me.InformesToolStripMenuItem.Image = Global.menuStrip.My.Resources.Resources.descarga
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.InformesToolStripMenuItem.Text = "Informes"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductomasVendidoToolStripMenuItem, Me.MejorClienteToolStripMenuItem, Me.VentasMensualesToolStripMenuItem})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'ProductomasVendidoToolStripMenuItem
        '
        Me.ProductomasVendidoToolStripMenuItem.Name = "ProductomasVendidoToolStripMenuItem"
        Me.ProductomasVendidoToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ProductomasVendidoToolStripMenuItem.Text = "Productomas vendido"
        '
        'MejorClienteToolStripMenuItem
        '
        Me.MejorClienteToolStripMenuItem.Name = "MejorClienteToolStripMenuItem"
        Me.MejorClienteToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.MejorClienteToolStripMenuItem.Text = "Mejor cliente"
        '
        'VentasMensualesToolStripMenuItem
        '
        Me.VentasMensualesToolStripMenuItem.Name = "VentasMensualesToolStripMenuItem"
        Me.VentasMensualesToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.VentasMensualesToolStripMenuItem.Text = "Ventas mensuales"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'SALIR
        '
        Me.SALIR.Image = Global.menuStrip.My.Resources.Resources.depositphotos_62939741_stock_photo_exit_icon
        Me.SALIR.Name = "SALIR"
        Me.SALIR.Size = New System.Drawing.Size(57, 20)
        Me.SALIR.Text = "Salir"
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(1018, 27)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(91, 20)
        Me.dtp_fecha.TabIndex = 0
        Me.dtp_fecha.Value = New Date(2022, 6, 25, 20, 43, 31, 0)
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(247, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(645, 114)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "AE Sistemas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.menuStrip.My.Resources.Resources.imagen_4
        Me.PictureBox6.Location = New System.Drawing.Point(449, 226)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(240, 139)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 10
        Me.PictureBox6.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.menuStrip.My.Resources.Resources.imagen_6
        Me.PictureBox3.Location = New System.Drawing.Point(881, 226)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(240, 139)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.menuStrip.My.Resources.Resources.imagen_3
        Me.PictureBox2.Location = New System.Drawing.Point(0, 226)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(240, 139)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.menuStrip.My.Resources.Resources.imagen_1
        Me.PictureBox1.Location = New System.Drawing.Point(449, 484)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(240, 139)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.menuStrip.My.Resources.Resources.imagen_11
        Me.PictureBox5.Location = New System.Drawing.Point(881, 484)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(240, 139)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 6
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.menuStrip.My.Resources.Resources.imagen_8
        Me.PictureBox4.Location = New System.Drawing.Point(0, 484)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(240, 139)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'AppAESistemasEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1121, 624)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AppAESistemasEmp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AE SISTEMAS"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As Windows.Forms.MenuStrip
    Friend WithEvents GestionDeProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABMDeProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIR As ToolStripMenuItem
    Friend WithEvents AMBClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABMVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABMProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductomasVendidoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MejorClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasMensualesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dtp_fecha As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
End Class
