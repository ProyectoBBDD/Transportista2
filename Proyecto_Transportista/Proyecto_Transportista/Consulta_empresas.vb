﻿Public Class Consulta_empresas

    Private Sub Consulta_empresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If castellano Then
            Me.Text = "Consulta de empresas"
        ElseIf english Then
            traducirIngles()
        ElseIf euskera Then
            traducirEuskera()
        End If
    End Sub

    Public Sub traducirIngles()
        Me.Text = "Companies query"
    End Sub

    Public Sub traducirEuskera()
        Me.Text = "Langileen kontsultak"
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class