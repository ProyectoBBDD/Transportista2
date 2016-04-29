<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alta_viajes
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.lblGanancia = New System.Windows.Forms.Label()
        Me.txtGanancia = New System.Windows.Forms.TextBox()
        Me.lblContenedor = New System.Windows.Forms.Label()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.lblEmpleado = New System.Windows.Forms.Label()
        Me.lblEntrega = New System.Windows.Forms.Label()
        Me.txtEntrega = New System.Windows.Forms.TextBox()
        Me.cbIdEmple = New System.Windows.Forms.ComboBox()
        Me.cbIdEmpresa = New System.Windows.Forms.ComboBox()
        Me.cbIdContenedor = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(441, 173)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(94, 36)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Volver"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAlta
        '
        Me.btnAlta.Location = New System.Drawing.Point(313, 173)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(94, 36)
        Me.btnAlta.TabIndex = 2
        Me.btnAlta.Text = "Dar de alta"
        Me.btnAlta.UseVisualStyleBackColor = True
        '
        'lblGanancia
        '
        Me.lblGanancia.AutoSize = True
        Me.lblGanancia.Location = New System.Drawing.Point(299, 87)
        Me.lblGanancia.Name = "lblGanancia"
        Me.lblGanancia.Size = New System.Drawing.Size(80, 13)
        Me.lblGanancia.TabIndex = 17
        Me.lblGanancia.Text = "Ganancia Base"
        '
        'txtGanancia
        '
        Me.txtGanancia.Location = New System.Drawing.Point(407, 84)
        Me.txtGanancia.Name = "txtGanancia"
        Me.txtGanancia.Size = New System.Drawing.Size(122, 20)
        Me.txtGanancia.TabIndex = 16
        '
        'lblContenedor
        '
        Me.lblContenedor.AutoSize = True
        Me.lblContenedor.Location = New System.Drawing.Point(12, 139)
        Me.lblContenedor.Name = "lblContenedor"
        Me.lblContenedor.Size = New System.Drawing.Size(92, 13)
        Me.lblContenedor.TabIndex = 15
        Me.lblContenedor.Text = "ID del contenedor"
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.Location = New System.Drawing.Point(12, 91)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(87, 13)
        Me.lblEmpresa.TabIndex = 13
        Me.lblEmpresa.Text = "ID de la empresa"
        '
        'lblEmpleado
        '
        Me.lblEmpleado.AutoSize = True
        Me.lblEmpleado.Location = New System.Drawing.Point(12, 43)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(84, 13)
        Me.lblEmpleado.TabIndex = 11
        Me.lblEmpleado.Text = "ID del empleado"
        '
        'lblEntrega
        '
        Me.lblEntrega.AutoSize = True
        Me.lblEntrega.Location = New System.Drawing.Point(299, 39)
        Me.lblEntrega.Name = "lblEntrega"
        Me.lblEntrega.Size = New System.Drawing.Size(91, 13)
        Me.lblEntrega.TabIndex = 19
        Me.lblEntrega.Text = "Fecha de entrega"
        '
        'txtEntrega
        '
        Me.txtEntrega.Location = New System.Drawing.Point(407, 36)
        Me.txtEntrega.Name = "txtEntrega"
        Me.txtEntrega.Size = New System.Drawing.Size(122, 20)
        Me.txtEntrega.TabIndex = 18
        '
        'cbIdEmple
        '
        Me.cbIdEmple.FormattingEnabled = True
        Me.cbIdEmple.Location = New System.Drawing.Point(141, 43)
        Me.cbIdEmple.Name = "cbIdEmple"
        Me.cbIdEmple.Size = New System.Drawing.Size(121, 21)
        Me.cbIdEmple.TabIndex = 20
        '
        'cbIdEmpresa
        '
        Me.cbIdEmpresa.FormattingEnabled = True
        Me.cbIdEmpresa.Location = New System.Drawing.Point(141, 87)
        Me.cbIdEmpresa.Name = "cbIdEmpresa"
        Me.cbIdEmpresa.Size = New System.Drawing.Size(121, 21)
        Me.cbIdEmpresa.TabIndex = 21
        '
        'cbIdContenedor
        '
        Me.cbIdContenedor.FormattingEnabled = True
        Me.cbIdContenedor.Location = New System.Drawing.Point(141, 136)
        Me.cbIdContenedor.Name = "cbIdContenedor"
        Me.cbIdContenedor.Size = New System.Drawing.Size(121, 21)
        Me.cbIdContenedor.TabIndex = 22
        '
        'Alta_viajes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 234)
        Me.Controls.Add(Me.cbIdContenedor)
        Me.Controls.Add(Me.cbIdEmpresa)
        Me.Controls.Add(Me.cbIdEmple)
        Me.Controls.Add(Me.lblEntrega)
        Me.Controls.Add(Me.txtEntrega)
        Me.Controls.Add(Me.lblGanancia)
        Me.Controls.Add(Me.txtGanancia)
        Me.Controls.Add(Me.lblContenedor)
        Me.Controls.Add(Me.lblEmpresa)
        Me.Controls.Add(Me.lblEmpleado)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAlta)
        Me.Name = "Alta_viajes"
        Me.Text = "Alta_viajes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAlta As System.Windows.Forms.Button
    Friend WithEvents lblGanancia As System.Windows.Forms.Label
    Friend WithEvents txtGanancia As System.Windows.Forms.TextBox
    Friend WithEvents lblContenedor As System.Windows.Forms.Label
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents lblEmpleado As System.Windows.Forms.Label
    Friend WithEvents lblEntrega As System.Windows.Forms.Label
    Friend WithEvents txtEntrega As System.Windows.Forms.TextBox
    Friend WithEvents cbIdEmple As System.Windows.Forms.ComboBox
    Friend WithEvents cbIdEmpresa As System.Windows.Forms.ComboBox
    Friend WithEvents cbIdContenedor As System.Windows.Forms.ComboBox
End Class
