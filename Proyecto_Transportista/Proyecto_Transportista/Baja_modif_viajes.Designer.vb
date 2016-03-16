<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Baja_modif_viajes
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
        Me.lblEntrega = New System.Windows.Forms.Label()
        Me.txtEntrega = New System.Windows.Forms.TextBox()
        Me.lblGanancia = New System.Windows.Forms.Label()
        Me.txtGanancia = New System.Windows.Forms.TextBox()
        Me.lblContenedor = New System.Windows.Forms.Label()
        Me.txtContenedor = New System.Windows.Forms.TextBox()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.txtEmpresa = New System.Windows.Forms.TextBox()
        Me.lblEmpleado = New System.Windows.Forms.Label()
        Me.txtEmpleado = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblEntrega
        '
        Me.lblEntrega.AutoSize = True
        Me.lblEntrega.Location = New System.Drawing.Point(333, 96)
        Me.lblEntrega.Name = "lblEntrega"
        Me.lblEntrega.Size = New System.Drawing.Size(91, 13)
        Me.lblEntrega.TabIndex = 31
        Me.lblEntrega.Text = "Fecha de entrega"
        '
        'txtEntrega
        '
        Me.txtEntrega.Location = New System.Drawing.Point(441, 93)
        Me.txtEntrega.Name = "txtEntrega"
        Me.txtEntrega.Size = New System.Drawing.Size(122, 20)
        Me.txtEntrega.TabIndex = 30
        '
        'lblGanancia
        '
        Me.lblGanancia.AutoSize = True
        Me.lblGanancia.Location = New System.Drawing.Point(333, 144)
        Me.lblGanancia.Name = "lblGanancia"
        Me.lblGanancia.Size = New System.Drawing.Size(80, 13)
        Me.lblGanancia.TabIndex = 29
        Me.lblGanancia.Text = "Ganancia Base"
        '
        'txtGanancia
        '
        Me.txtGanancia.Location = New System.Drawing.Point(441, 141)
        Me.txtGanancia.Name = "txtGanancia"
        Me.txtGanancia.Size = New System.Drawing.Size(122, 20)
        Me.txtGanancia.TabIndex = 28
        '
        'lblContenedor
        '
        Me.lblContenedor.AutoSize = True
        Me.lblContenedor.Location = New System.Drawing.Point(46, 196)
        Me.lblContenedor.Name = "lblContenedor"
        Me.lblContenedor.Size = New System.Drawing.Size(92, 13)
        Me.lblContenedor.TabIndex = 27
        Me.lblContenedor.Text = "ID del contenedor"
        '
        'txtContenedor
        '
        Me.txtContenedor.Location = New System.Drawing.Point(172, 193)
        Me.txtContenedor.Name = "txtContenedor"
        Me.txtContenedor.Size = New System.Drawing.Size(122, 20)
        Me.txtContenedor.TabIndex = 26
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.Location = New System.Drawing.Point(46, 148)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(87, 13)
        Me.lblEmpresa.TabIndex = 25
        Me.lblEmpresa.Text = "ID de la empresa"
        '
        'txtEmpresa
        '
        Me.txtEmpresa.Location = New System.Drawing.Point(172, 145)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(122, 20)
        Me.txtEmpresa.TabIndex = 24
        '
        'lblEmpleado
        '
        Me.lblEmpleado.AutoSize = True
        Me.lblEmpleado.Location = New System.Drawing.Point(46, 100)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(84, 13)
        Me.lblEmpleado.TabIndex = 23
        Me.lblEmpleado.Text = "ID del empleado"
        '
        'txtEmpleado
        '
        Me.txtEmpleado.Location = New System.Drawing.Point(172, 97)
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.Size = New System.Drawing.Size(122, 20)
        Me.txtEmpleado.TabIndex = 22
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(475, 230)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(94, 36)
        Me.btnSalir.TabIndex = 21
        Me.btnSalir.Text = "Volver"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnBaja
        '
        Me.btnBaja.Location = New System.Drawing.Point(347, 230)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(94, 36)
        Me.btnBaja.TabIndex = 20
        Me.btnBaja.Text = "Dar de baja"
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(43, 41)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(60, 13)
        Me.lblID.TabIndex = 44
        Me.lblID.Text = "ID del viaje"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(158, 33)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(178, 21)
        Me.ComboBox1.TabIndex = 43
        '
        'Baja_modif_viajes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 308)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblEntrega)
        Me.Controls.Add(Me.txtEntrega)
        Me.Controls.Add(Me.lblGanancia)
        Me.Controls.Add(Me.txtGanancia)
        Me.Controls.Add(Me.lblContenedor)
        Me.Controls.Add(Me.txtContenedor)
        Me.Controls.Add(Me.lblEmpresa)
        Me.Controls.Add(Me.txtEmpresa)
        Me.Controls.Add(Me.lblEmpleado)
        Me.Controls.Add(Me.txtEmpleado)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBaja)
        Me.Name = "Baja_modif_viajes"
        Me.Text = "Baja_viajesvb"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEntrega As System.Windows.Forms.Label
    Friend WithEvents txtEntrega As System.Windows.Forms.TextBox
    Friend WithEvents lblGanancia As System.Windows.Forms.Label
    Friend WithEvents txtGanancia As System.Windows.Forms.TextBox
    Friend WithEvents lblContenedor As System.Windows.Forms.Label
    Friend WithEvents txtContenedor As System.Windows.Forms.TextBox
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents txtEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents lblEmpleado As System.Windows.Forms.Label
    Friend WithEvents txtEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnBaja As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
