Public Class Consulta_contenedores

    Private Sub Consulta_contenedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If castellano Then
            Me.Text = "Consulta de contenedores"
        ElseIf english Then
            traducirIngles()
        ElseIf euskera Then
            traducirEuskera()
        End If
    End Sub

    Public Sub traducirIngles()
        Me.Text = "Containers query"
    End Sub

    Public Sub traducirEuskera()
        Me.Text = "Kontainerren kontsultak"
    End Sub
End Class