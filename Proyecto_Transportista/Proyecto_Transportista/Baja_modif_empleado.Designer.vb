<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Baja_modif_empleado
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblTelMovil = New System.Windows.Forms.Label()
        Me.txtTelMovil = New System.Windows.Forms.TextBox()
        Me.lblTelFijo = New System.Windows.Forms.Label()
        Me.txtTelFijo = New System.Windows.Forms.TextBox()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.txtCargo = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtNacimiento = New System.Windows.Forms.TextBox()
        Me.lblNacimiento = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblApellido2 = New System.Windows.Forms.Label()
        Me.txtApellido2 = New System.Windows.Forms.TextBox()
        Me.lblApellido1 = New System.Windows.Forms.Label()
        Me.txtApellido1 = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(152, 26)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(178, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'lblTelMovil
        '
        Me.lblTelMovil.AutoSize = True
        Me.lblTelMovil.Location = New System.Drawing.Point(265, 260)
        Me.lblTelMovil.Name = "lblTelMovil"
        Me.lblTelMovil.Size = New System.Drawing.Size(76, 13)
        Me.lblTelMovil.TabIndex = 41
        Me.lblTelMovil.Text = "Telefono movil"
        '
        'txtTelMovil
        '
        Me.txtTelMovil.Enabled = False
        Me.txtTelMovil.Location = New System.Drawing.Point(464, 253)
        Me.txtTelMovil.Name = "txtTelMovil"
        Me.txtTelMovil.Size = New System.Drawing.Size(122, 20)
        Me.txtTelMovil.TabIndex = 40
        '
        'lblTelFijo
        '
        Me.lblTelFijo.AutoSize = True
        Me.lblTelFijo.Location = New System.Drawing.Point(265, 222)
        Me.lblTelFijo.Name = "lblTelFijo"
        Me.lblTelFijo.Size = New System.Drawing.Size(65, 13)
        Me.lblTelFijo.TabIndex = 39
        Me.lblTelFijo.Text = "Telefono fijo"
        '
        'txtTelFijo
        '
        Me.txtTelFijo.Enabled = False
        Me.txtTelFijo.Location = New System.Drawing.Point(464, 215)
        Me.txtTelFijo.Name = "txtTelFijo"
        Me.txtTelFijo.Size = New System.Drawing.Size(122, 20)
        Me.txtTelFijo.TabIndex = 38
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Location = New System.Drawing.Point(265, 180)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(35, 13)
        Me.lblCargo.TabIndex = 37
        Me.lblCargo.Text = "Cargo"
        '
        'txtCargo
        '
        Me.txtCargo.Enabled = False
        Me.txtCargo.Location = New System.Drawing.Point(464, 173)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(122, 20)
        Me.txtCargo.TabIndex = 36
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(265, 138)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 35
        Me.lblEmail.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(464, 131)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(122, 20)
        Me.txtEmail.TabIndex = 34
        '
        'txtNacimiento
        '
        Me.txtNacimiento.Enabled = False
        Me.txtNacimiento.Location = New System.Drawing.Point(464, 89)
        Me.txtNacimiento.Name = "txtNacimiento"
        Me.txtNacimiento.Size = New System.Drawing.Size(122, 20)
        Me.txtNacimiento.TabIndex = 33
        '
        'lblNacimiento
        '
        Me.lblNacimiento.AutoSize = True
        Me.lblNacimiento.Location = New System.Drawing.Point(265, 96)
        Me.lblNacimiento.Name = "lblNacimiento"
        Me.lblNacimiento.Size = New System.Drawing.Size(177, 13)
        Me.lblNacimiento.TabIndex = 32
        Me.lblNacimiento.Text = "Fecha de nacimiento (dd/mm/aaaa)"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(37, 234)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblDireccion.TabIndex = 31
        Me.lblDireccion.Text = "Direccion"
        '
        'txtDireccion
        '
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(109, 231)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(122, 20)
        Me.txtDireccion.TabIndex = 30
        '
        'lblApellido2
        '
        Me.lblApellido2.AutoSize = True
        Me.lblApellido2.Location = New System.Drawing.Point(37, 192)
        Me.lblApellido2.Name = "lblApellido2"
        Me.lblApellido2.Size = New System.Drawing.Size(50, 13)
        Me.lblApellido2.TabIndex = 29
        Me.lblApellido2.Text = "Apellido2"
        '
        'txtApellido2
        '
        Me.txtApellido2.Enabled = False
        Me.txtApellido2.Location = New System.Drawing.Point(109, 189)
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(122, 20)
        Me.txtApellido2.TabIndex = 28
        '
        'lblApellido1
        '
        Me.lblApellido1.AutoSize = True
        Me.lblApellido1.Location = New System.Drawing.Point(37, 144)
        Me.lblApellido1.Name = "lblApellido1"
        Me.lblApellido1.Size = New System.Drawing.Size(50, 13)
        Me.lblApellido1.TabIndex = 27
        Me.lblApellido1.Text = "Apellido1"
        '
        'txtApellido1
        '
        Me.txtApellido1.Enabled = False
        Me.txtApellido1.Location = New System.Drawing.Point(109, 141)
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(122, 20)
        Me.txtApellido1.TabIndex = 26
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(37, 96)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 25
        Me.lblNombre.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(109, 93)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(122, 20)
        Me.txtNombre.TabIndex = 24
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(464, 314)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(94, 36)
        Me.btnSalir.TabIndex = 23
        Me.btnSalir.Text = "Volver"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnBaja
        '
        Me.btnBaja.Location = New System.Drawing.Point(348, 314)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(94, 36)
        Me.btnBaja.TabIndex = 22
        Me.btnBaja.Text = "Dar de baja"
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(37, 34)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(84, 13)
        Me.lblID.TabIndex = 42
        Me.lblID.Text = "ID del empleado"
        '
        'Baja_modif_empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 382)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblTelMovil)
        Me.Controls.Add(Me.txtTelMovil)
        Me.Controls.Add(Me.lblTelFijo)
        Me.Controls.Add(Me.txtTelFijo)
        Me.Controls.Add(Me.lblCargo)
        Me.Controls.Add(Me.txtCargo)
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
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Baja_modif_empleado"
        Me.Text = "Baja_empleado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblTelMovil As System.Windows.Forms.Label
    Friend WithEvents txtTelMovil As System.Windows.Forms.TextBox
    Friend WithEvents lblTelFijo As System.Windows.Forms.Label
    Friend WithEvents txtTelFijo As System.Windows.Forms.TextBox
    Friend WithEvents lblCargo As System.Windows.Forms.Label
    Friend WithEvents txtCargo As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtNacimiento As System.Windows.Forms.TextBox
    Friend WithEvents lblNacimiento As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents lblApellido2 As System.Windows.Forms.Label
    Friend WithEvents txtApellido2 As System.Windows.Forms.TextBox
    Friend WithEvents lblApellido1 As System.Windows.Forms.Label
    Friend WithEvents txtApellido1 As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnBaja As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
End Class
