Public Class Alta_empleado

    Private ClsEmpleados As New Class_Empleado

    Private Sub Alta_empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If castellano Then
            Me.Text = "Dar de alta empleado"
        ElseIf english Then
            traducirIngles()
        ElseIf euskera Then
            traducirEuskera()
        End If
    End Sub

    Public Sub traducirIngles()
        Me.Text = "Enlist employee"
        btnAlta.Text = "Enlist"
        btnSalir.Text = "Back"
        lblNombre.Text = "First Name"
        lblApellido1.Text = "Last Name1"
        lblApellido2.Text = "Last Name2"
        lblDireccion.Text = "Address"
        lblNacimiento.Text = "birthdate (dd/mm/yyyy)"
        lblCargo.Text = "Position"
        lblTelFijo.Text = "Landline number"
        lblTelMovil.Text = "Mobile phone"
    End Sub

    Public Sub traducirEuskera()
        Me.Text = "Alta eman langilea"
        btnAlta.Text = "Alta eman"
        btnSalir.Text = "Atzera"
        lblNombre.Text = "Izena"
        lblApellido1.Text = "Abizena1"
        lblApellido2.Text = "Abizena2"
        lblDireccion.Text = "Helbidea"
        lblNacimiento.Text = "Jaoitze-data (ee/hh/uuuu)"
        lblCargo.Text = "Kargua"
        lblTelFijo.Text = "Etxeko telefonoa"
        lblTelMovil.Text = "Mugikorra"
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        If comprobarCampos() Then
            ClsEmpleados.nombre_emp = txtNombre.Text
            ClsEmpleados.apellido1_emp = txtApellido1.Text
            ClsEmpleados.apellido2_emp = txtApellido2.Text
            ClsEmpleados.direccion_emp = txtDireccion.Text
            ClsEmpleados.fecha_nac = txtNacimiento.Text
            ClsEmpleados.email_emp = txtEmail.Text
            ClsEmpleados.cargo_emp = txtCargo.Text
            ClsEmpleados.telefono_fijo_emp = txtTelFijo.Text
            ClsEmpleados.telefono_movil_emp = txtTelMovil.Text
            If ClsEmpleados.crearEmpleado() Then
                If castellano Then
                    MessageBox.Show("Empleado dado de alta correctamente")
                ElseIf english Then
                    MessageBox.Show("Employee enlist corrrectly")
                ElseIf euskera Then
                    MessageBox.Show("Langileari alta emanda zuzenki")
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
        If txtNombre.Text <> vbNullString Then
            If txtApellido1.Text <> vbNullString Then
                If txtApellido2.Text <> vbNullString Then
                    If txtDireccion.Text <> vbNullString Then
                        If txtNacimiento.Text <> vbNullString Then
                            If txtEmail.Text <> vbNullString Then
                                If txtCargo.Text <> vbNullString Then
                                    If txtTelFijo.Text <> vbNullString Then
                                        If txtTelMovil.Text <> vbNullString Then
                                            Return True
                                        End If
                                    End If
                                End If
                            End If
                            Return True
                        End If
                    End If
                End If
            End If
        End If
        Return False
    End Function
End Class