Public Class Baja_modif_tipos

    Private ClsTipos As New Class_Tipos

    Private Sub Baja_modif_tipos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If castellano Then
            Me.Text = "Dar de baja tipo"
        ElseIf english Then
            traducirIngles()
        ElseIf euskera Then
            traducirEuskera()
        End If
    End Sub

    Public Sub traducirIngles()
        Me.Text = "Unsubscribe kind"
        btnBaja.Text = "Unsubscribe"
        btnSalir.Text = "Back"
        lblTipo.Text = "Kind"
        lblTamaino.Text = "Size"
        lblPeso.Text = "Maximun weight"
        lblGanancia.Text = "Gain per km"
    End Sub

    Public Sub traducirEuskera()
        Me.Text = "Baja eman mota"
        btnBaja.Text = "Baja eman"
        btnSalir.Text = "Atzera"
        lblTipo.Text = "Mota"
        lblTamaino.Text = "Tamaina"
        lblPeso.Text = "Gehiengo pisua"
        lblGanancia.Text = "Irabaziak km-ko"
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        If ClsTipos.borrarTipo() Then
            If castellano Then
                MessageBox.Show("Tipo dado de baja correctamente")
            ElseIf english Then
                MessageBox.Show("Kind unsubscribe corrrectly")
            ElseIf euskera Then
                MessageBox.Show("Motari baja emanda zuzenki")
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