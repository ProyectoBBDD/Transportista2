<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alta_empleado
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
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido1 = New System.Windows.Forms.Label()
        Me.txtApellido1 = New System.Windows.Forms.TextBox()
        Me.lblApellido2 = New System.Windows.Forms.Label()
        Me.txtApellido2 = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblNacimiento = New System.Windows.Forms.Label()
        Me.txtNacimiento = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.lblTelFijo = New System.Windows.Forms.Label()
        Me.txtTelFijo = New System.Windows.Forms.TextBox()
        Me.lblTelMovil = New System.Windows.Forms.Label()
        Me.txtTelMovil = New System.Windows.Forms.TextBox()
        Me.cbCargo = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnAlta
        '
        Me.btnAlta.Location = New System.Drawing.Point(323, 261)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(94, 36)
        Me.btnAlta.TabIndex = 0
        Me.btnAlta.Text = "Dar de alta"
        Me.btnAlta.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(439, 261)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(94, 36)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Volver"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(84, 40)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(122, 20)
        Me.txtNombre.TabIndex = 2
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(12, 43)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "Nombre"
        '
        'lblApellido1
        '
        Me.lblApellido1.AutoSize = True
        Me.lblApellido1.Location = New System.Drawing.Point(12, 91)
        Me.lblApellido1.Name = "lblApellido1"
        Me.lblApellido1.Size = New System.Drawing.Size(50, 13)
        Me.lblApellido1.TabIndex = 5
        Me.lblApellido1.Text = "Apellido1"
        '
        'txtApellido1
        '
        Me.txtApellido1.Location = New System.Drawing.Point(84, 88)
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(122, 20)
        Me.txtApellido1.TabIndex = 4
        '
        'lblApellido2
        '
        Me.lblApellido2.AutoSize = True
        Me.lblApellido2.Location = New System.Drawing.Point(12, 139)
        Me.lblApellido2.Name = "lblApellido2"
        Me.lblApellido2.Size = New System.Drawing.Size(50, 13)
        Me.lblApellido2.TabIndex = 7
        Me.lblApellido2.Text = "Apellido2"
        '
        'txtApellido2
        '
        Me.txtApellido2.Location = New System.Drawing.Point(84, 136)
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(122, 20)
        Me.txtApellido2.TabIndex = 6
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(12, 181)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblDireccion.TabIndex = 9
        Me.lblDireccion.Text = "Direccion"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(84, 178)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(122, 20)
        Me.txtDireccion.TabIndex = 8
        '
        'lblNacimiento
        '
        Me.lblNacimiento.AutoSize = True
        Me.lblNacimiento.Location = New System.Drawing.Point(240, 43)
        Me.lblNacimiento.Name = "lblNacimiento"
        Me.lblNacimiento.Size = New System.Drawing.Size(177, 13)
        Me.lblNacimiento.TabIndex = 11
        Me.lblNacimiento.Text = "Fecha de nacimiento (dd/mm/aaaa)"
        '
        'txtNacimiento
        '
        Me.txtNacimiento.Location = New System.Drawing.Point(439, 36)
        Me.txtNacimiento.Name = "txtNacimiento"
        Me.txtNacimiento.Size = New System.Drawing.Size(122, 20)
        Me.txtNacimiento.TabIndex = 12
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(240, 85)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 15
        Me.lblEmail.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(439, 78)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(122, 20)
        Me.txtEmail.TabIndex = 14
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Location = New System.Drawing.Point(240, 127)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(35, 13)
        Me.lblCargo.TabIndex = 17
        Me.lblCargo.Text = "Cargo"
        '
        'lblTelFijo
        '
        Me.lblTelFijo.AutoSize = True
        Me.lblTelFijo.Location = New System.Drawing.Point(240, 169)
        Me.lblTelFijo.Name = "lblTelFijo"
        Me.lblTelFijo.Size = New System.Drawing.Size(65, 13)
        Me.lblTelFijo.TabIndex = 19
        Me.lblTelFijo.Text = "Telefono fijo"
        '
        'txtTelFijo
        '
        Me.txtTelFijo.Location = New System.Drawing.Point(439, 162)
        Me.txtTelFijo.Name = "txtTelFijo"
        Me.txtTelFijo.Size = New System.Drawing.Size(122, 20)
        Me.txtTelFijo.TabIndex = 18
        '
        'lblTelMovil
        '
        Me.lblTelMovil.AutoSize = True
        Me.lblTelMovil.Location = New System.Drawing.Point(240, 207)
        Me.lblTelMovil.Name = "lblTelMovil"
        Me.lblTelMovil.Size = New System.Drawing.Size(76, 13)
        Me.lblTelMovil.TabIndex = 21
        Me.lblTelMovil.Text = "Telefono movil"
        '
        'txtTelMovil
        '
        Me.txtTelMovil.Location = New System.Drawing.Point(439, 200)
        Me.txtTelMovil.Name = "txtTelMovil"
        Me.txtTelMovil.Size = New System.Drawing.Size(122, 20)
        Me.txtTelMovil.TabIndex = 20
        '
        'cbCargo
        '
        Me.cbCargo.FormattingEnabled = True
        Me.cbCargo.Location = New System.Drawing.Point(439, 127)
        Me.cbCargo.Name = "cbCargo"
        Me.cbCargo.Size = New System.Drawing.Size(121, 21)
        Me.cbCargo.TabIndex = 22
        '
        'Alta_empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 325)
        Me.Controls.Add(Me.cbCargo)
        Me.Controls.Add(Me.lblTelMovil)
        Me.Controls.Add(Me.txtTelMovil)
        Me.Controls.Add(Me.lblTelFijo)
        Me.Controls.Add(Me.txtTelFijo)
        Me.Controls.Add(Me.lblCargo)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtNacimiento)
        Me.Controls.Add(Me.lblNacimiento)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.lblApellido2)
        Me.Controls.Add(Me.txtApellido2)
        Me.Controls.Add(Me.lblApellido1)
        Me.Controls.Add(Me.txtApellido1)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAlta)
        Me.Name = "Alta_empleado"
        Me.Text = "Alta_empleado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAlta As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblApellido1 As System.Windows.Forms.Label
    Friend WithEvents txtApellido1 As System.Windows.Forms.TextBox
    Friend WithEvents lblApellido2 As System.Windows.Forms.Label
    Friend WithEvents txtApellido2 As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents lblNacimiento As System.Windows.Forms.Label
    Friend WithEvents txtNacimiento As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblCargo As System.Windows.Forms.Label
    Friend WithEvents lblTelFijo As System.Windows.Forms.Label
    Friend WithEvents txtTelFijo As System.Windows.Forms.TextBox
    Friend WithEvents lblTelMovil As System.Windows.Forms.Label
    Friend WithEvents txtTelMovil As System.Windows.Forms.TextBox
    Friend WithEvents cbCargo As System.Windows.Forms.ComboBox
End Class
