Public Class Consulta_tipos

    Private Sub Consulta_tipos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If castellano Then
            Me.Text = "Consulta de tipos"
        ElseIf english Then
            traducirIngles()
        ElseIf euskera Then
            traducirEuskera()
        End If
    End Sub

    Public Sub traducirIngles()
        Me.Text = "Kinds query"
    End Sub

    Public Sub traducirEuskera()
        Me.Text = "Moten kontsultak"
    End Sub

End Class