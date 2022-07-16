<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AppAESistemas
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
        Me.SALIR = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtIdEmp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCargo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNomApe = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDeProductosToolStripMenuItem, Me.GestionDeClientesToolStripMenuItem, Me.GestionDeEmpleadosToolStripMenuItem, Me.GestionDeProveedoresToolStripMenuItem, Me.GestionDeVentasToolStripMenuItem, Me.GestionDeUsuariosToolStripMenuItem, Me.InformesToolStripMenuItem, Me.SALIR})
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
        'GestionDeEmpleadosToolStripMenuItem
        '
        Me.GestionDeEmpleadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMEmpleadosToolStripMenuItem})
        Me.GestionDeEmpleadosToolStripMenuItem.Image = Global.menuStrip.My.Resources.Resources.empleado
        Me.GestionDeEmpleadosToolStripMenuItem.Name = "GestionDeEmpleadosToolStripMenuItem"
        Me.GestionDeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(152, 20)
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
        Me.GestionDeProveedoresToolStripMenuItem.Image = Global.menuStrip.My.Resources.Resources.provvedor
        Me.GestionDeProveedoresToolStripMenuItem.Name = "GestionDeProveedoresToolStripMenuItem"
        Me.GestionDeProveedoresToolStripMenuItem.Size = New System.Drawing.Size(159, 20)
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
        Me.GestionDeVentasToolStripMenuItem.Image = Global.menuStrip.My.Resources.Resources.ventas
        Me.GestionDeVentasToolStripMenuItem.Name = "GestionDeVentasToolStripMenuItem"
        Me.GestionDeVentasToolStripMenuItem.Size = New System.Drawing.Size(128, 20)
        Me.GestionDeVentasToolStripMenuItem.Text = "Gestion de ventas"
        '
        'ABMVentasToolStripMenuItem
        '
        Me.ABMVentasToolStripMenuItem.Name = "ABMVentasToolStripMenuItem"
        Me.ABMVentasToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.ABMVentasToolStripMenuItem.Text = "Realizar Venta"
        '
        'GestionDeUsuariosToolStripMenuItem
        '
        Me.GestionDeUsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMUsuariosToolStripMenuItem})
        Me.GestionDeUsuariosToolStripMenuItem.Image = Global.menuStrip.My.Resources.Resources.images__1_
        Me.GestionDeUsuariosToolStripMenuItem.Name = "GestionDeUsuariosToolStripMenuItem"
        Me.GestionDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(138, 20)
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
        Me.InformesToolStripMenuItem.Image = Global.menuStrip.My.Resources.Resources.descarga
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.InformesToolStripMenuItem.Text = "Informes"
        '
        'SALIR
        '
        Me.SALIR.Image = Global.menuStrip.My.Resources.Resources.depositphotos_62939741_stock_photo_exit_icon
        Me.SALIR.Name = "SALIR"
        Me.SALIR.Size = New System.Drawing.Size(57, 20)
        Me.SALIR.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(244, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(645, 114)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "AE Sistemas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.menuStrip.My.Resources.Resources.imagen_4
        Me.PictureBox6.Location = New System.Drawing.Point(881, 484)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(240, 139)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 10
        Me.PictureBox6.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.menuStrip.My.Resources.Resources.imagen_6
        Me.PictureBox3.Location = New System.Drawing.Point(449, 484)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(240, 139)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.menuStrip.My.Resources.Resources.imagen_1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 484)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(240, 139)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.txtIdEmp)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtCargo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNomApe)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtUsuario)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(247, 164)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'txtIdEmp
        '
        Me.txtIdEmp.Enabled = False
        Me.txtIdEmp.Location = New System.Drawing.Point(114, 135)
        Me.txtIdEmp.Name = "txtIdEmp"
        Me.txtIdEmp.Size = New System.Drawing.Size(126, 20)
        Me.txtIdEmp.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "ID DE EMPLEADO:"
        '
        'txtCargo
        '
        Me.txtCargo.Enabled = False
        Me.txtCargo.Location = New System.Drawing.Point(73, 97)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(167, 20)
        Me.txtCargo.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "CARGO:"
        '
        'txtNomApe
        '
        Me.txtNomApe.Enabled = False
        Me.txtNomApe.Location = New System.Drawing.Point(74, 58)
        Me.txtNomApe.Name = "txtNomApe"
        Me.txtNomApe.Size = New System.Drawing.Size(166, 20)
        Me.txtNomApe.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NOMBRE:"
        '
        'txtUsuario
        '
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(73, 18)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(167, 20)
        Me.txtUsuario.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "USUARIO:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(1021, 47)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(88, 20)
        Me.DateTimePicker1.TabIndex = 13
        '
        'AppAESistemas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1121, 624)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AppAESistemas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AE SISTEMAS"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtIdEmp As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCargo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNomApe As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
