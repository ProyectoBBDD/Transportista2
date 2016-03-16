Public Class Baja_modif_contenedor

    Private ClsContenedor As New Class_Contenedores

    Private Sub Baja_modif_contenedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If castellano Then
            Me.Text = "Dar de baja contenedor"
        ElseIf english Then
            traducirIngles()
        ElseIf euskera Then
            traducirEuskera()
        End If
    End Sub

    Public Sub traducirIngles()
        Me.Text = "Unsubscribe container"
        btnBaja.Text = "Unsubscribe"
        btnSalir.Text = "Back"
        lblTipo.Text = "Kind"
    End Sub

    Public Sub traducirEuskera()
        Me.Text = "Baja eman kontainerra"
        btnBaja.Text = "Baja eman"
        btnSalir.Text = "Atzera"
        lblTipo.Text = "Mota"
    End Sub

    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        If ClsContenedor.borrarContenedor Then
            If castellano Then
                MessageBox.Show("Contenedor dado de baja correctamente")
            ElseIf english Then
                MessageBox.Show("Container unsubscribe corrrectly")
            ElseIf euskera Then
                MessageBox.Show("Kontainerrari baja emanda zuzenki")
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