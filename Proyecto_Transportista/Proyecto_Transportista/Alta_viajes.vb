Public Class Alta_viajes

    Private ClsViajes As New Class_Viajes

    Private Sub Alta_viajes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If castellano Then
            Me.Text = "Dar de alta viaje"
        ElseIf english Then
            traducirIngles()
        ElseIf euskera Then
            traducirEuskera()
        End If
    End Sub

    Public Sub traducirIngles()
        Me.Text = "Enlist trip"
        btnAlta.Text = "Enlist"
        btnSalir.Text = "Back"
        lblEmpleado.Text = "Employee ID"
        lblEmpresa.Text = "Company ID"
        lblContenedor.Text = "Container ID"
        lblEntrega.Text = "Date of delivery"
        lblGanancia.Text = "Profit basis"
    End Sub

    Public Sub traducirEuskera()
        Me.Text = "Alta eman bidaia"
        btnAlta.Text = "Alta eman"
        btnSalir.Text = "Atzera"
        lblEmpleado.Text = "Langilearen ID"
        lblEmpresa.Text = "Enpresaren ID"
        lblContenedor.Text = "Kontainerraren ID"
        lblEntrega.Text = "Entregatze data"
        lblGanancia.Text = "Irabazi finkoak"
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        If comprobarCampos() Then
            ClsViajes.id_emp = txtEmpleado.Text
            ClsViajes.id_empresa = txtEmpresa.Text
            ClsViajes.id_contenedor = txtContenedor.Text
            ClsViajes.fecha_entrega = txtEntrega.Text
            ClsViajes.precio_viaje = txtGanancia.Text
            If ClsViajes.crearViaje() Then
                If castellano Then
                    MessageBox.Show("Viaje dado de alta correctamente")
                ElseIf english Then
                    MessageBox.Show("Travel enlist corrrectly")
                ElseIf euskera Then
                    MessageBox.Show("Bidaiari alta emanda zuzenki")
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
        If txtEmpleado.Text <> vbNullString Then
            If txtEmpresa.Text <> vbNullString Then
                If txtContenedor.Text <> vbNullString Then
                    If txtEntrega.Text <> vbNullString Then
                        If txtGanancia.Text <> vbNullString Then
                            Return True
                        End If
                    End If
                End If
            End If
        End If
        Return False
    End Function
End Class