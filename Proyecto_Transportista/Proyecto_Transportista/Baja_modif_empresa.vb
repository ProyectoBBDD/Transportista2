Public Class Baja_modif_empresa

    Private ClsEmpresa As New Class_Empresa

    Private Sub Baja_modif_empresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If castellano Then
            Me.Text = "Dar de baja empresa"
        ElseIf english Then
            traducirIngles()
        ElseIf euskera Then
            traducirEuskera()
        End If

    End Sub

    Public Sub traducirIngles()
        Me.Text = "Unsubscribe company"
        btnBaja.Text = "Unsubscribe"
        btnSalir.Text = "Back"
        lblID.Text = "Company ID"
        lblNombre.Text = "First Name"
        lblDireccion.Text = "Address"
        lblTelefono.Text = "Landline number"
        lblDistancia.Text = "Distance"
    End Sub

    Public Sub traducirEuskera()
        Me.Text = "Baja eman enpresa"
        btnBaja.Text = "Baja eman"
        lblID.Text = "Enpresako ID"
        lblNombre.Text = "Izena"
        lblDireccion.Text = "Helbidea"
        lblTelefono.Text = "Telefono zenbakia"
        lblDistancia.Text = "Distantzia"
    End Sub

    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        If ClsEmpresa.borrarEmpresa() Then
            If castellano Then
                MessageBox.Show("Empresa dada de alta correctamente")
            ElseIf english Then
                MessageBox.Show("Company enlist corrrectly")
            ElseIf euskera Then
                MessageBox.Show("Enpresari alta emanda zuzenki")
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
End Class