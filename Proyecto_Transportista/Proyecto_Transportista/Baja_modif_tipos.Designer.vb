<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Baja_modif_tipos
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
        Me.lblGanancia = New System.Windows.Forms.Label()
        Me.txtGanancia = New System.Windows.Forms.TextBox()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.lblTamaino = New System.Windows.Forms.Label()
        Me.txtTamaino = New System.Windows.Forms.TextBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.cbxEmpresa = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblGanancia
        '
        Me.lblGanancia.AutoSize = True
        Me.lblGanancia.Location = New System.Drawing.Point(288, 134)
        Me.lblGanancia.Name = "lblGanancia"
        Me.lblGanancia.Size = New System.Drawing.Size(88, 13)
        Me.lblGanancia.TabIndex = 27
        Me.lblGanancia.Text = "Ganancia por km"
        '
        'txtGanancia
        '
        Me.txtGanancia.Location = New System.Drawing.Point(400, 130)
        Me.txtGanancia.Name = "txtGanancia"
        Me.txtGanancia.Size = New System.Drawing.Size(122, 20)
        Me.txtGanancia.TabIndex = 26
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Location = New System.Drawing.Point(288, 92)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(69, 13)
        Me.lblPeso.TabIndex = 25
        Me.lblPeso.Text = "Peso maximo"
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(400, 88)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(122, 20)
        Me.txtPeso.TabIndex = 24
        '
        'lblTamaino
        '
        Me.lblTamaino.AutoSize = True
        Me.lblTamaino.Location = New System.Drawing.Point(40, 140)
        Me.lblTamaino.Name = "lblTamaino"
        Me.lblTamaino.Size = New System.Drawing.Size(46, 13)
        Me.lblTamaino.TabIndex = 23
        Me.lblTamaino.Text = "Tamaño"
        '
        'txtTamaino
        '
        Me.txtTamaino.Location = New System.Drawing.Point(112, 137)
        Me.txtTamaino.Name = "txtTamaino"
        Me.txtTamaino.Size = New System.Drawing.Size(122, 20)
        Me.txtTamaino.TabIndex = 22
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(58, 91)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(28, 13)
        Me.lblTipo.TabIndex = 21
        Me.lblTipo.Text = "Tipo"
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(112, 89)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(122, 20)
        Me.txtTipo.TabIndex = 20
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(428, 182)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(94, 36)
        Me.btnSalir.TabIndex = 19
        Me.btnSalir.Text = "Volver"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnBaja
        '
        Me.btnBaja.Location = New System.Drawing.Point(312, 182)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(94, 36)
        Me.btnBaja.TabIndex = 18
        Me.btnBaja.Text = "Dar de baja"
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(25, 34)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(38, 13)
        Me.lblID.TabIndex = 46
        Me.lblID.Text = "ID tipo"
        '
        'cbxEmpresa
        '
        Me.cbxEmpresa.FormattingEnabled = True
        Me.cbxEmpresa.Location = New System.Drawing.Point(124, 26)
        Me.cbxEmpresa.Name = "cbxEmpresa"
        Me.cbxEmpresa.Size = New System.Drawing.Size(178, 21)
        Me.cbxEmpresa.TabIndex = 45
        '
        'Baja_modif_tipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 259)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.cbxEmpresa)
        Me.Controls.Add(Me.lblGanancia)
        Me.Controls.Add(Me.txtGanancia)
        Me.Controls.Add(Me.lblPeso)
        Me.Controls.Add(Me.txtPeso)
        Me.Controls.Add(Me.lblTamaino)
        Me.Controls.Add(Me.txtTamaino)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBaja)
        Me.Name = "Baja_modif_tipos"
        Me.Text = "Baja_tipos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGanancia As System.Windows.Forms.Label
    Friend WithEvents txtGanancia As System.Windows.Forms.TextBox
    Friend WithEvents lblPeso As System.Windows.Forms.Label
    Friend WithEvents txtPeso As System.Windows.Forms.TextBox
    Friend WithEvents lblTamaino As System.Windows.Forms.Label
    Friend WithEvents txtTamaino As System.Windows.Forms.TextBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnBaja As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents cbxEmpresa As System.Windows.Forms.ComboBox
End Class
