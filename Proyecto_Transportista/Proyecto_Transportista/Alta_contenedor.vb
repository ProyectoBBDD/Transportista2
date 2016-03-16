Public Class Alta_contenedor

    Private ClsContenedor As New Class_Contenedores

    Private Sub Alta_contenedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If castellano Then
            Me.Text = "Dar de alta contenedor"
        ElseIf english Then
            traducirIngles()
        ElseIf euskera Then
            traducirEuskera()
        End If
    End Sub

    Public Sub traducirIngles()
        Me.Text = "Enlist container"
        btnAlta.Text = "Enlist"
        btnSalir.Text = "Back"
        lblTipo.Text = "Kind"
    End Sub

    Public Sub traducirEuskera()
        Me.Text = "Alta eman kontainerra"
        btnAlta.Text = "Alta eman"
        btnSalir.Text = "Atzera"
        lblTipo.Text = "Mota"
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        If comprobarCampos() Then
            ClsContenedor.tipo = txtTipo.Text
            If ClsContenedor.crearContenedor Then
                If castellano Then
                    MessageBox.Show("Contenedor dado de alta correctamente")
                ElseIf english Then
                    MessageBox.Show("Container enlist corrrectly")
                ElseIf euskera Then
                    MessageBox.Show("Kontainerrari alta emanda zuzenki")
                End If
            Else
                If castellano Then
                    MessageBox.Show("Error al dar de alta")
                ElseIf english Then
                    MessageBox.Show("Error when to enlist")
                ElseIf euskera Then
                    MessageBox.Show("Errorea alta ematean")
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
            Return True
        End If
        Return False
    End Function

End Class