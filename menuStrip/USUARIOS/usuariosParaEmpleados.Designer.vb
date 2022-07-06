<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usuariosParaEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usuariosParaEmpleados))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(649, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione de la tabla el usuario que sera asignado al empleado y luego click en " &
    """Agregar""."
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(25, 44)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(469, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Image = Global.menuStrip.My.Resources.Resources.descarga1
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(524, 94)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 49)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "AGREGAR"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(538, 165)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 3
        Me.txtId.Visible = False
        '
        'usuariosParaEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 450)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "usuariosParaEmpleados"
        Me.Text = "USUARIOS"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents txtId As TextBox
End Class
