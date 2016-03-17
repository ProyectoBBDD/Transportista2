Public Class FormMain

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If castellano Then
            Me.Text = "Bienvenido"
        ElseIf english Then
            traducirIngles()
        ElseIf euskera Then
            traducirEuskera()
        End If
    End Sub


    Public Sub traducirIngles()
        Me.Text = "Welcome"
        BusquedaToolStripMenuItem.Text = "Search"
        AltasToolStripMenuItem.Text = "Register"
        BajasToolStripMenuItem.Text = "Unregister"
        ModificacionesToolStripMenuItem.Text = "Modifications"
        EstadisticToolStripMenuItem.Text = "Exit"

        EmpleadosToolStripMenuItem1.Text = "Employees"
        EmpleadosToolStripMenuItem2.Text = "Employees"
        EmpleadosToolStripMenuItem3.Text = "Employees"
        EmpleadosToolStripMenuItem4.Text = "Employees"
        EmpresasToolStripMenuItem1.Text = "Companies"
        EmpresasToolStripMenuItem2.Text = "Companies"
        EmpresasToolStripMenuItem3.Text = "Companies"
        EmpresasToolStripMenuItem4.Text = "Companies"
        CargosToolStripMenuItem1.Text = "Position"
        CargosToolStripMenuItem2.Text = "Position"
        CargosToolStripMenuItem3.Text = "Position"
        CargosToolStripMenuItem4.Text = "Position"
        ContenedoresToolStripMenuItem1.Text = "Containers"
        ContenedoresToolStripMenuItem2.Text = "Containers"
        ContenedoresToolStripMenuItem3.Text = "Containers"
        ContenedoresToolStripMenuItem4.Text = "Containers"
        TiposToolStripMenuItem.Text = "Kinds"
        TiposToolStripMenuItem1.Text = "Kinds"
        TiposToolStripMenuItem2.Text = "Kinds"
        TiposToolStripMenuItem3.Text = "Kinds"
        ViajesToolStripMenuItem.Text = "Trips"
        ViajesToolStripMenuItem1.Text = "Trips"
        ViajesToolStripMenuItem2.Text = "Trips"
        ViajesToolStripMenuItem3.Text = "Trips"
        HistoricoSalariosToolStripMenuItem.Text = "Historical Wage"

    End Sub

    Public Sub traducirEuskera()
        Me.Text = "Ongi Etorri"
        BusquedaToolStripMenuItem.Text = "Kontsultak"
        AltasToolStripMenuItem.Text = "Alta"
        BajasToolStripMenuItem.Text = "Baja"
        ModificacionesToolStripMenuItem.Text = "Aldaketak"
        EstadisticToolStripMenuItem.Text = "Irten"

        EmpleadosToolStripMenuItem1.Text = "Langileak"
        EmpleadosToolStripMenuItem2.Text = "Langileak"
        EmpleadosToolStripMenuItem3.Text = "Langileak"
        EmpleadosToolStripMenuItem4.Text = "Langileak"
        EmpresasToolStripMenuItem1.Text = "Enpresak"
        EmpresasToolStripMenuItem2.Text = "Enpresak"
        EmpresasToolStripMenuItem3.Text = "Enpresak"
        EmpresasToolStripMenuItem4.Text = "Enpresak"
        CargosToolStripMenuItem1.Text = "Kargua"
        CargosToolStripMenuItem2.Text = "Kargua"
        CargosToolStripMenuItem3.Text = "Kargua"
        CargosToolStripMenuItem4.Text = "Kargua"
        ContenedoresToolStripMenuItem1.Text = "Kontainerra"
        ContenedoresToolStripMenuItem2.Text = "Kontainerra"
        ContenedoresToolStripMenuItem3.Text = "Kontainerra"
        ContenedoresToolStripMenuItem4.Text = "Kontainerra"
        TiposToolStripMenuItem.Text = "Motak"
        TiposToolStripMenuItem1.Text = "Motak"
        TiposToolStripMenuItem2.Text = "Motak"
        TiposToolStripMenuItem3.Text = "Motak"
        ViajesToolStripMenuItem.Text = "Bidaiak"
        ViajesToolStripMenuItem1.Text = "Bidaiak"
        ViajesToolStripMenuItem2.Text = "Bidaiak"
        ViajesToolStripMenuItem3.Text = "Bidaiak"
        HistoricoSalariosToolStripMenuItem.Text = "Irabazien Historikoa"
    End Sub

    Private Sub EmpleadosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem1.Click
        Consulta_empleados.Show()
    End Sub

    Private Sub EmpresasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmpresasToolStripMenuItem1.Click
        Consulta_empresas.Show()
    End Sub

    Private Sub CargosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CargosToolStripMenuItem1.Click
        Consulta_cargos.Show()
    End Sub

    Private Sub ContenedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ContenedoresToolStripMenuItem1.Click
        Consulta_contenedores.Show()
    End Sub

    Private Sub TiposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposToolStripMenuItem.Click
        Consulta_tipos.Show()
    End Sub

    Private Sub ViajesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViajesToolStripMenuItem.Click
        Consulta_viajes.Show()
    End Sub

    Private Sub HistoricoSalariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoricoSalariosToolStripMenuItem.Click
        Consulta_historico_salarios.Show()
    End Sub

    Private Sub EmpleadosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem2.Click
        Alta_empleado.Show()
    End Sub

    Private Sub EmpresasToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EmpresasToolStripMenuItem2.Click
        Alta_empresa.Show()
    End Sub

    Private Sub CargosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CargosToolStripMenuItem2.Click
        Alta_cargo.Show()
    End Sub

    Private Sub ContenedoresToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ContenedoresToolStripMenuItem2.Click
        Alta_contenedor.Show()
    End Sub

    Private Sub TiposToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TiposToolStripMenuItem1.Click
        Alta_tipos.Show()
    End Sub

    Private Sub ViajesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViajesToolStripMenuItem1.Click
        Alta_viajes.Show()
    End Sub

    Private Sub EmpleadosToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem3.Click
        Baja_modif_empleado.Show()
    End Sub

    Private Sub EmpresasToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles EmpresasToolStripMenuItem3.Click
        Baja_modif_empresa.Show()
    End Sub

    Private Sub CargosToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles CargosToolStripMenuItem3.Click
        Baja_modif_cargo.Show()
    End Sub

    Private Sub ContenedoresToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ContenedoresToolStripMenuItem3.Click
        Baja_modif_contenedor.Show()
    End Sub

    Private Sub TiposToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles TiposToolStripMenuItem2.Click
        Baja_modif_tipos.Show()
    End Sub

    Private Sub ViajesToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ViajesToolStripMenuItem2.Click
        Baja_modif_viajes.Show()
    End Sub

    Private Sub EmpleadosToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem4.Click
        Baja_modif_empleado.Show()
    End Sub

    Private Sub EmpresasToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles EmpresasToolStripMenuItem4.Click
        Baja_modif_empresa.Show()
    End Sub

    Private Sub CargosToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles CargosToolStripMenuItem4.Click
        Baja_modif_cargo.Show()
    End Sub

    Private Sub ContenedoresToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ContenedoresToolStripMenuItem4.Click
        Baja_modif_contenedor.Show()
    End Sub

    Private Sub TiposToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles TiposToolStripMenuItem3.Click
        Baja_modif_tipos.Show()
    End Sub

    Private Sub ViajesToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ViajesToolStripMenuItem3.Click
        Baja_modif_viajes.Show()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        dispose()
    End Sub

    Private Sub EstadisticToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadisticToolStripMenuItem.Click

    End Sub
End Class