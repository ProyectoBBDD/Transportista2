﻿Public Class Form1

    Private Sub btnCastellano_Click(sender As Object, e As EventArgs) Handles btnCastellano.Click
        castellano = True
        euskera = False
        english = False
        FormMain.Show()
    End Sub

    Private Sub btnEuskera_Click(sender As Object, e As EventArgs) Handles btnEuskera.Click
        castellano = False
        euskera = True
        english = False
        FormMain.Show()
    End Sub

    Private Sub btnEnglish_Click(sender As Object, e As EventArgs) Handles btnEnglish.Click
        castellano = False
        euskera = False
        english = True
        FormMain.Show()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Not conection() Then
            MessageBox.Show("Error al conectarse a la base de datos")
        End If
    End Sub
End Class
