Public Class Baja_modif_cargo

    Private ClsCargo As New Class_Cargos

    Private Sub Baja_modif_cargo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If castellano Then
            Me.Text = "Dar de alta cargo"
        ElseIf english Then
            traducirIngles()
        ElseIf euskera Then
            traducirEuskera()
        End If
    End Sub

    Public Sub traducirIngles()
        Me.Text = "Unsubscribe position"
        btnBaja.Text = "Unsubscribe"
        btnSalir.Text = "Back"
        lblID.Text = "Position ID"
        lblNombre.Text = "Name"
        lblDescripcion.Text = "Description"
    End Sub

    Public Sub traducirEuskera()
        Me.Text = "Alta eman kargua"
        btnBaja.Text = "Baja eman"
        btnSalir.Text = "Atzera"
        lblID.Text = "Karguaren ID"
        lblNombre.Text = "Izena"
        lblDescripcion.Text = "Deskribapena"
    End Sub

    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        If ClsCargo.borrarCargo Then
            If castellano Then
                MessageBox.Show("Cargo dado de baja correctamente")
            ElseIf english Then
                MessageBox.Show("Position unsubscribe corrrectly")
            ElseIf euskera Then
                MessageBox.Show("Karguari baja emanda zuzenki")
            End If
        Else
            If castellano Then
                MessageBox.Show("Error al dar de baja")
            ElseIf english Then
                MessageBox.Show("Error when to unsubscribe")
            ElseIf euskera Then
                MessageBox.Show("Errorea baja ematean")
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dispose()
    End Sub
End Class