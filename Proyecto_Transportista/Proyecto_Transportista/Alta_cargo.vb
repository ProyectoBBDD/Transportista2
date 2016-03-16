Public Class Alta_cargo

    Private ClsCargo As New Class_Cargos

    Private Sub Alta_cargo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If castellano Then
            Me.Text = "Dar de alta cargo"
        ElseIf english Then
            traducirIngles()
        ElseIf euskera Then
            traducirEuskera()
        End If
    End Sub

    Public Sub traducirIngles()
        Me.Text = "Enlist position"
        btnAlta.Text = "Enlist"
        btnSalir.Text = "Back"
        lblNombre.Text = "Name"
        lblDescripcion.Text = "Description"
    End Sub

    Public Sub traducirEuskera()
        Me.Text = "Alta eman kargua"
        btnAlta.Text = "Alta eman"
        btnSalir.Text = "Atzera"
        lblNombre.Text = "Izena"
        lblDescripcion.Text = "Deskribapena"
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        If comprobarCampos() Then
            ClsCargo.nombre_cargo = txtNombre.Text
            ClsCargo.descripcion_cargo = txtDescripcion.Text
            If ClsCargo.crearCargo Then
                If castellano Then
                    MessageBox.Show("Cargo dado de alta correctamente")
                ElseIf english Then
                    MessageBox.Show("Position enlist corrrectly")
                ElseIf euskera Then
                    MessageBox.Show("Karguari alta emanda zuzenki")
                End If
            Else
                If castellano Then
                    MessageBox.Show("Error al dar de alta")
                ElseIf english Then
                    MessageBox.Show("Error when to enlist")
                ElseIf euskera Then
                    MessageBox.Show("Errorea alta ematean")
                End If
            End If
        Else
            If castellano Then
                MessageBox.Show("Rellene todos los campos")
            ElseIf english Then
                MessageBox.Show("Fill in all fields")
            ElseIf euskera Then
                MessageBox.Show("Alor guztiak bete")
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dispose()
    End Sub

    Private Function comprobarCampos()
        If txtNombre.Text <> vbNullString Then
            If txtDescripcion.Text <> vbNullString Then
                Return True
            End If
        End If
        Return False
    End Function
    
End Class