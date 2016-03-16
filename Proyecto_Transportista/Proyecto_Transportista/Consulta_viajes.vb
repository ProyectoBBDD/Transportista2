Public Class Consulta_viajes

    Private Sub Consulta_viajes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If castellano Then
            Me.Text = "Consulta de viajes"
        ElseIf english Then
            traducirIngles()
        ElseIf euskera Then
            traducirEuskera()
        End If
    End Sub

    Public Sub traducirIngles()
        Me.Text = "Trips query"
    End Sub

    Public Sub traducirEuskera()
        Me.Text = "Bidaien kontsultak"
    End Sub
End Class