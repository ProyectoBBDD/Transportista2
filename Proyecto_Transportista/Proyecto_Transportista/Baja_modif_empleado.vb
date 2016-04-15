Public Class Baja_modif_empleado

    Private ClsEmpleados As New Class_Empleado
    Private primeraVez As New Boolean
    Private Sub Baja_modif_empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        primeraVez = True
        cbEmple.DataSource = ClsEmpleados.llenarComboBoxTrab
        cbEmple.ValueMember = "id_emp"
        cbEmple.DisplayMember = "id_emp"
        If castellano Then
            Me.Text = "Dar de baja empleado"
        ElseIf english Then
            traducirIngles()
        ElseIf euskera Then
            traducirEuskera()
        End If
        primeraVez = False
    End Sub

    Public Sub traducirIngles()
        Me.Text = "Unsubscribe employee"
        btnBaja.Text = "Unsubscribe"
        btnSalir.Text = "Back"
        lblID.Text = "Employee ID"
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
        Me.Text = "Baja eman langilea"
        btnBaja.Text = "Baja eman"
        btnSalir.Text = "Atzera"
        lblID.Text = "Langilearen ID"
        lblNombre.Text = "Izena"
        lblApellido1.Text = "Abizena1"
        lblApellido2.Text = "Abizena2"
        lblDireccion.Text = "Helbidea"
        lblNacimiento.Text = "Jaoitze-data (ee/hh/uuuu)"
        lblCargo.Text = "Kargua"
        lblTelFijo.Text = "Etxeko telefonoa"
        lblTelMovil.Text = "Mugikorra"
    End Sub

    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        If ClsEmpleados.borrarEmpleado() Then
            If castellano Then
                MessageBox.Show("Empleado dado de baja correctamente")
            ElseIf english Then
                MessageBox.Show("Employee unsubscribe corrrectly")
            ElseIf euskera Then
                MessageBox.Show("Langileari baja emanda zuzenki")
            End If
        Else
            If castellano Then
                MessageBox.Show("Error al dar de baja")
            ElseIf english Then
                MessageBox.Show("Error when unsubscribe")
            ElseIf euskera Then
                MessageBox.Show("Errorea baja ematean")
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dispose()
    End Sub

    Public Sub recogerDatos()
        Dim busqueda As New DataTable
        If primeraVez Then
            busqueda = ClsEmpleados.refrescar
            If busqueda.Rows.Count <> 0 Then
                txtNombre.Text = busqueda.Rows(0).Item(1)
                txtApellido1.Text = busqueda.Rows(0).Item(2)
                txtApellido2.Text = busqueda.Rows(0).Item(3)
                txtDireccion.Text = busqueda.Rows(0).Item(4)
                txtNacimiento.Text = busqueda.Rows(0).Item(5)
                txtEmail.Text = busqueda.Rows(0).Item(6)
                txtCargo.Text = busqueda.Rows(0).Item(7)
                txtTelFijo.Text = busqueda.Rows(0).Item(8)
                txtTelMovil.Text = busqueda.Rows(0).Item(9)
            End If
        Else
            busqueda = ClsEmpleados.recogerDatos
            If busqueda.Rows.Count <> 0 Then
                txtNombre.Text = busqueda.Rows(0).Item(1)
                txtApellido1.Text = busqueda.Rows(0).Item(2)
                txtApellido2.Text = busqueda.Rows(0).Item(3)
                txtDireccion.Text = busqueda.Rows(0).Item(4)
                txtNacimiento.Text = busqueda.Rows(0).Item(5)
                txtEmail.Text = busqueda.Rows(0).Item(6)
                txtCargo.Text = busqueda.Rows(0).Item(7)
                txtTelFijo.Text = busqueda.Rows(0).Item(8)
                txtTelMovil.Text = busqueda.Rows(0).Item(9)
            End If
        End If

    End Sub

    Private Sub cbEmple_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbEmple.SelectedIndexChanged
        If primeraVez Then
            recogerDatos()
        Else
            ClsEmpleados.id_emp = cbEmple.SelectedValue.ToString
            recogerDatos()
        End If
    End Sub
End Class
