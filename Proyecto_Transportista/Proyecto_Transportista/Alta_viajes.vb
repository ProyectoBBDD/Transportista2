Public Class Alta_viajes

    Private ClsViajes As New Class_Viajes
    Private ClsEmpleado As New Class_Empleado
    Private ClsEmpresa As New Class_Empresa
    Private ClsContenedor As New Class_Contenedores

    Private Sub Alta_viajes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If castellano Then
            Me.Text = "Dar de alta viaje"
        ElseIf english Then
            traducirIngles()
        ElseIf euskera Then
            traducirEuskera()
        End If

        'Combobox idempleado
        cbIdEmple.ValueMember = "id_emp"
        cbIdEmple.DisplayMember = "apellido1_emp"
        cbIdEmple.DataSource = ClsEmpleado.refrescar()
        'Combobox idempresa
        cbIdEmpresa.ValueMember = "id_empresa"
        cbIdEmpresa.DisplayMember = "nombre_empresa"
        cbIdEmpresa.DataSource = ClsEmpresa.refrescar()
        'Combobox idcontenedor
        cbIdContenedor.ValueMember = "id_contenedor"
        cbIdContenedor.DisplayMember = "tipo"
        cbIdContenedor.DataSource = ClsContenedor.refrescar()

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
            ClsViajes.id_emp = cbIdEmple.Text
            ClsViajes.id_empresa = cbIdEmpresa.Text
            ClsViajes.id_contenedor = cbIdContenedor.Text
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

    Private Function comprobarCampos() As Boolean
        If cbIdEmple.Text <> vbNullString And cbIdEmpresa.Text <> vbNullString And cbIdContenedor.Text <> vbNullString And
            txtEntrega.Text <> vbNullString And txtGanancia.Text <> vbNullString Then
            Return True
        End If
        Return False
    End Function

    Private Sub cbIdEmple_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbIdEmple.SelectedIndexChanged
        ClsEmpleado.id_emp = cbIdEmple.SelectedValue
    End Sub

    Private Sub cbIdEmpresa_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbIdEmpresa.SelectedIndexChanged
        ClsEmpresa.id_empresa = cbIdEmpresa.SelectedValue
    End Sub

    Private Sub cbIdContenedor_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbIdContenedor.SelectedIndexChanged
        ClsContenedor.id_contenedor = cbIdContenedor.SelectedValue
    End Sub
End Class