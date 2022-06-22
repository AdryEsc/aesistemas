<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppAESistemas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppAESistemas))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GestionDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AMBClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDeProductosToolStripMenuItem, Me.GestionDeClientesToolStripMenuItem, Me.GestionDeEmpleadosToolStripMenuItem, Me.GestionDeProveedoresToolStripMenuItem, Me.GestionDeVentasToolStripMenuItem, Me.GestionDeUsuariosToolStripMenuItem, Me.InformesToolStripMenuItem, Me.SALIR})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1009, 24)
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
        Me.GestionDeClientesToolStripMenuItem.Name = "GestionDeClientesToolStripMenuItem"
        Me.GestionDeClientesToolStripMenuItem.Size = New System.Drawing.Size(118, 20)
        Me.GestionDeClientesToolStripMenuItem.Text = "Gestion de clientes"
        '
        'AMBClientesToolStripMenuItem
        '
        Me.AMBClientesToolStripMenuItem.Name = "AMBClientesToolStripMenuItem"
        Me.AMBClientesToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.AMBClientesToolStripMenuItem.Text = "AMB Clientes"
        '
        'GestionDeEmpleadosToolStripMenuItem
        '
        Me.GestionDeEmpleadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMEmpleadosToolStripMenuItem})
        Me.GestionDeEmpleadosToolStripMenuItem.Name = "GestionDeEmpleadosToolStripMenuItem"
        Me.GestionDeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(136, 20)
        Me.GestionDeEmpleadosToolStripMenuItem.Text = "Gestion de empleados"
        '
        'ABMEmpleadosToolStripMenuItem
        '
        Me.ABMEmpleadosToolStripMenuItem.Name = "ABMEmpleadosToolStripMenuItem"
        Me.ABMEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ABMEmpleadosToolStripMenuItem.Text = "ABM Empleados"
        '
        'GestionDeProveedoresToolStripMenuItem
        '
        Me.GestionDeProveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMProveedoresToolStripMenuItem})
        Me.GestionDeProveedoresToolStripMenuItem.Name = "GestionDeProveedoresToolStripMenuItem"
        Me.GestionDeProveedoresToolStripMenuItem.Size = New System.Drawing.Size(143, 20)
        Me.GestionDeProveedoresToolStripMenuItem.Text = "Gestion de proveedores"
        '
        'ABMProveedoresToolStripMenuItem
        '
        Me.ABMProveedoresToolStripMenuItem.Name = "ABMProveedoresToolStripMenuItem"
        Me.ABMProveedoresToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ABMProveedoresToolStripMenuItem.Text = "ABM Proveedores"
        '
        'GestionDeVentasToolStripMenuItem
        '
        Me.GestionDeVentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMVentasToolStripMenuItem})
        Me.GestionDeVentasToolStripMenuItem.Name = "GestionDeVentasToolStripMenuItem"
        Me.GestionDeVentasToolStripMenuItem.Size = New System.Drawing.Size(112, 20)
        Me.GestionDeVentasToolStripMenuItem.Text = "Gestion de ventas"
        '
        'ABMVentasToolStripMenuItem
        '
        Me.ABMVentasToolStripMenuItem.Name = "ABMVentasToolStripMenuItem"
        Me.ABMVentasToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ABMVentasToolStripMenuItem.Text = "ABM Ventas"
        '
        'GestionDeUsuariosToolStripMenuItem
        '
        Me.GestionDeUsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMUsuariosToolStripMenuItem})
        Me.GestionDeUsuariosToolStripMenuItem.Name = "GestionDeUsuariosToolStripMenuItem"
        Me.GestionDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.GestionDeUsuariosToolStripMenuItem.Text = "Gestion de usuarios"
        '
        'ABMUsuariosToolStripMenuItem
        '
        Me.ABMUsuariosToolStripMenuItem.Name = "ABMUsuariosToolStripMenuItem"
        Me.ABMUsuariosToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.ABMUsuariosToolStripMenuItem.Text = "ABM Usuarios"
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.ProveedoresToolStripMenuItem})
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
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
        Me.SALIR.Name = "SALIR"
        Me.SALIR.Size = New System.Drawing.Size(41, 20)
        Me.SALIR.Text = "Salir"
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Enabled = False
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(918, 36)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(91, 20)
        Me.dtp_fecha.TabIndex = 1
        '
        'AppAESistemas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1009, 561)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AppAESistemas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AE SISTEMAS"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As Windows.Forms.MenuStrip
    Friend WithEvents GestionDeProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABMDeProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIR As ToolStripMenuItem
    Friend WithEvents AMBClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABMEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABMUsuariosToolStripMenuItem As ToolStripMenuItem
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
End Class
