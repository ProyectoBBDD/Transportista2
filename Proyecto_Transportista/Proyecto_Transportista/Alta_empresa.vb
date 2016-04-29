Public Class Alta_empresa

    Private ClsEmpresa As New Class_Empresa

    Private Sub Alta_empresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If castellano Then
            Me.Text = "Dar de alta empresa"
        ElseIf english Then
            traducirIngles()
        ElseIf euskera Then
            traducirEuskera()
        End If
    End Sub

    Public Sub traducirIngles()
        Me.Text = "Enlist company"
        btnAlta.Text = "Enlist"
        btnSalir.Text = "Back"
        lblNombre.Text = "First Name"
        lblDireccion.Text = "Address"
        lblTelefono.Text = "Landline number"
        lblDistancia.Text = "Distance"
    End Sub

    Public Sub traducirEuskera()
        Me.Text = "Alta eman enpresa"
        btnAlta.Text = "Alta eman"
        lblNombre.Text = "Izena"
        lblDireccion.Text = "Helbidea"
        lblTelefono.Text = "Telefono zenbakia"
        lblDistancia.Text = "Distantzia"
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        If comprobarCampos() Then
            ClsEmpresa.nombre_empresa = txtNombre.Text
            ClsEmpresa.direccion_empresa = txtDireccion.Text
            ClsEmpresa.email_empresa = txtEmail.Text
            ClsEmpresa.telefono_empresa = txtTelefono.Text
            ClsEmpresa.distancia = txtDistancia.Text
            If ClsEmpresa.crearEmpresa() Then
                If castellano Then
                    MessageBox.Show("Empresa dada de alta correctamente")
                ElseIf english Then
                    MessageBox.Show("Company enlist corrrectly")
                ElseIf euskera Then
                    MessageBox.Show("Enpresari alta emanda zuzenki")
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
        If txtNombre.Text <> vbNullString And txtDireccion.Text <> vbNullString And
            txtEmail.Text <> vbNullString And txtTelefono.Text <> vbNullString And
            txtDistancia.Text <> vbNullString Then
            Return True
        End If
        Return False
    End Function
End Class