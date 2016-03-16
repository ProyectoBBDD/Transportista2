Public Class Baja_modif_viajes

    Private ClsViajes As New Class_Viajes

    Private Sub Baja_modif_viajes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If castellano Then
            Me.Text = "Dar de baja viaje"
        ElseIf english Then
            traducirIngles()
        ElseIf euskera Then
            traducirEuskera()
        End If
    End Sub

    Public Sub traducirIngles()
        Me.Text = "Unsubscribe trip"
        btnBaja.Text = "Unsubscribe"
        btnSalir.Text = "Back"
        lblID.Text = "Trip ID"
        lblEmpleado.Text = "Employee ID"
        lblEmpresa.Text = "Company ID"
        lblContenedor.Text = "Container ID"
        lblEntrega.Text = "Date of delivery"
        lblGanancia.Text = "Profit basis"
    End Sub

    Public Sub traducirEuskera()
        Me.Text = "Baja eman bidaia"
        btnBaja.Text = "Baja eman"
        btnSalir.Text = "Atzera"
        lblID.Text = "Bidaiaren ID"
        lblEmpleado.Text = "Langilearen ID"
        lblEmpresa.Text = "Enpresaren ID"
        lblContenedor.Text = "Kontainerraren ID"
        lblEntrega.Text = "Entregatze data"
        lblGanancia.Text = "Irabazi finkoak"
    End Sub

    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        If ClsViajes.borrarViaje() Then
            If castellano Then
                MessageBox.Show("Viaje dado de baja correctamente")
            ElseIf english Then
                MessageBox.Show("Travel unsubscribe corrrectly")
            ElseIf euskera Then
                MessageBox.Show("Bidaiari baja emanda zuzenki")
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