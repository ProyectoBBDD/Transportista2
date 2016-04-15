<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnCastellano = New System.Windows.Forms.Button()
        Me.btnEuskera = New System.Windows.Forms.Button()
        Me.btnEnglish = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCastellano
        '
        Me.btnCastellano.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCastellano.Location = New System.Drawing.Point(27, 339)
        Me.btnCastellano.Name = "btnCastellano"
        Me.btnCastellano.Size = New System.Drawing.Size(192, 49)
        Me.btnCastellano.TabIndex = 0
        Me.btnCastellano.Text = "BIENVENIDO"
        Me.btnCastellano.UseVisualStyleBackColor = True
        '
        'btnEuskera
        '
        Me.btnEuskera.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEuskera.Location = New System.Drawing.Point(217, 435)
        Me.btnEuskera.Name = "btnEuskera"
        Me.btnEuskera.Size = New System.Drawing.Size(192, 49)
        Me.btnEuskera.TabIndex = 1
        Me.btnEuskera.Text = "ONGI ETORRI"
        Me.btnEuskera.UseVisualStyleBackColor = True
        '
        'btnEnglish
        '
        Me.btnEnglish.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnglish.Location = New System.Drawing.Point(406, 339)
        Me.btnEnglish.Name = "btnEnglish"
        Me.btnEnglish.Size = New System.Drawing.Size(192, 49)
        Me.btnEnglish.TabIndex = 2
        Me.btnEnglish.Text = "WELCOME"
        Me.btnEnglish.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(619, 531)
        Me.Controls.Add(Me.btnEnglish)
        Me.Controls.Add(Me.btnEuskera)
        Me.Controls.Add(Me.btnCastellano)
        Me.Name = "Form1"
        Me.Text = "Transportista"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCastellano As System.Windows.Forms.Button
    Friend WithEvents btnEuskera As System.Windows.Forms.Button
    Friend WithEvents btnEnglish As System.Windows.Forms.Button

End Class
