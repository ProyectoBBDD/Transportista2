<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alta_tipos
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
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.lblTamaino = New System.Windows.Forms.Label()
        Me.txtTamaino = New System.Windows.Forms.TextBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(416, 137)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(94, 36)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Volver"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAlta
        '
        Me.btnAlta.Location = New System.Drawing.Point(300, 137)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(94, 36)
        Me.btnAlta.TabIndex = 2
        Me.btnAlta.Text = "Dar de alta"
        Me.btnAlta.UseVisualStyleBackColor = True
        '
        'lblGanancia
        '
        Me.lblGanancia.AutoSize = True
        Me.lblGanancia.Location = New System.Drawing.Point(276, 89)
        Me.lblGanancia.Name = "lblGanancia"
        Me.lblGanancia.Size = New System.Drawing.Size(88, 13)
        Me.lblGanancia.TabIndex = 17
        Me.lblGanancia.Text = "Ganancia por km"
        '
        'txtGanancia
        '
        Me.txtGanancia.Location = New System.Drawing.Point(388, 85)
        Me.txtGanancia.Name = "txtGanancia"
        Me.txtGanancia.Size = New System.Drawing.Size(122, 20)
        Me.txtGanancia.TabIndex = 16
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Location = New System.Drawing.Point(276, 47)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(69, 13)
        Me.lblPeso.TabIndex = 15
        Me.lblPeso.Text = "Peso maximo"
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(388, 43)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(122, 20)
        Me.txtPeso.TabIndex = 14
        '
        'lblTamaino
        '
        Me.lblTamaino.AutoSize = True
        Me.lblTamaino.Location = New System.Drawing.Point(28, 95)
        Me.lblTamaino.Name = "lblTamaino"
        Me.lblTamaino.Size = New System.Drawing.Size(46, 13)
        Me.lblTamaino.TabIndex = 13
        Me.lblTamaino.Text = "Tamaño"
        '
        'txtTamaino
        '
        Me.txtTamaino.Location = New System.Drawing.Point(100, 92)
        Me.txtTamaino.Name = "txtTamaino"
        Me.txtTamaino.Size = New System.Drawing.Size(122, 20)
        Me.txtTamaino.TabIndex = 12
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(28, 47)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(28, 13)
        Me.lblTipo.TabIndex = 11
        Me.lblTipo.Text = "Tipo"
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(100, 44)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(122, 20)
        Me.txtTipo.TabIndex = 10
        '
        'Alta_tipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 206)
        Me.Controls.Add(Me.lblGanancia)
        Me.Controls.Add(Me.txtGanancia)
        Me.Controls.Add(Me.lblPeso)
        Me.Controls.Add(Me.txtPeso)
        Me.Controls.Add(Me.lblTamaino)
        Me.Controls.Add(Me.txtTamaino)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAlta)
        Me.Name = "Alta_tipos"
        Me.Text = "Alta_tipos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAlta As System.Windows.Forms.Button
    Friend WithEvents lblGanancia As System.Windows.Forms.Label
    Friend WithEvents txtGanancia As System.Windows.Forms.TextBox
    Friend WithEvents lblPeso As System.Windows.Forms.Label
    Friend WithEvents txtPeso As System.Windows.Forms.TextBox
    Friend WithEvents lblTamaino As System.Windows.Forms.Label
    Friend WithEvents txtTamaino As System.Windows.Forms.TextBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
End Class
