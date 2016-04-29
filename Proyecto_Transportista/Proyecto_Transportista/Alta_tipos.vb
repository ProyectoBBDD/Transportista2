Public Class Alta_tipos

    Private ClsTipos As New Class_Tipos

    Private Sub Alta_tipos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If castellano Then
            Me.Text = "Dar de alta tipo"
        ElseIf english Then
            traducirIngles()
        ElseIf euskera Then
            traducirEuskera()
        End If
    End Sub

    Public Sub traducirIngles()
        Me.Text = "Enlist kind"
        btnAlta.Text = "Enlist"
        btnSalir.Text = "Back"
        lblTipo.Text = "Kind"
        lblTamaino.Text = "Size"
        lblPeso.Text = "Maximun weight"
        lblGanancia.Text = "Gain per km"
    End Sub

    Public Sub traducirEuskera()
        Me.Text = "Alta eman mota"
        btnAlta.Text = "Alta eman"
        btnSalir.Text = "Atzera"
        lblTipo.Text = "Mota"
        lblTamaino.Text = "Tamaina"
        lblPeso.Text = "Gehiengo pisua"
        lblGanancia.Text = "Irabaziak km-ko"
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        If comprobarCampos() Then
            ClsTipos.id_tipo = txtTipo.Text
            ClsTipos.tamaino = txtTamaino.Text
            ClsTipos.peso_maximo = txtPeso.Text
            ClsTipos.ganancia = txtGanancia.Text
            If ClsTipos.crearTipo() Then
                If castellano Then
                    MessageBox.Show("Tipo dado de alta correctamente")
                ElseIf english Then
                    MessageBox.Show("Kind enlist corrrectly")
                ElseIf euskera Then
                    MessageBox.Show("Motari alta emanda zuzenki")
                End If
            Else
                If castellano Then
                    MessageBox.Show("Error al dar de alta")
                ElseIf english Then
                    MessageBox.Show("Error when to enlist")
                ElseIf euskera Then
                    MessageBox.Show("Erroreaalta ematean")
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
        If txtTipo.Text <> vbNullString Then
            If txtTamaino.Text <> vbNullString Then
                If txtPeso.Text <> vbNullString Then
                    If txtGanancia.Text <> vbNullString Then
                        Return True
                    End If
                End If
            End If
        End If
        Return False
    End Function
End Class