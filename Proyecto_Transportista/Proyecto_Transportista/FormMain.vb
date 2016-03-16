Public Class FormMain

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If castellano Then
            Me.Text = "Bienvenido"
        ElseIf english Then
            Me.Text = "Welcome"
            traducirIngles()
        ElseIf euskera Then
            Me.Text = "Ongi Etorri"
            traducirEuskera()
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dispose()
    End Sub

    Public Sub traducirIngles()
        BusquedaToolStripMenuItem.Text = "Search"
        AltasToolStripMenuItem.Text = "Register"
        BajasToolStripMenuItem.Text = "Unregister"
        ModificacionesToolStripMenuItem.Text = "Modifications"
        SalirToolStripMenuItem.Text = "Exit"

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


    End Sub

    Public Sub traducirEuskera()
        BusquedaToolStripMenuItem.Text = "Kontsultak"
        AltasToolStripMenuItem.Text = "Alta"
        BajasToolStripMenuItem.Text = "Baja"
        ModificacionesToolStripMenuItem.Text = "Aldaketak"
        SalirToolStripMenuItem.Text = "Irten"

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
        ContenedoresToolStripMenuItem1.Text = "Kontainer"
        ContenedoresToolStripMenuItem2.Text = "Kontainer"
        ContenedoresToolStripMenuItem3.Text = "Kontainer"
        ContenedoresToolStripMenuItem4.Text = "Kontainer"
        TiposToolStripMenuItem.Text = "Motak"
        TiposToolStripMenuItem1.Text = "Motak"
        TiposToolStripMenuItem2.Text = "Motak"
        TiposToolStripMenuItem3.Text = "Motak"
        ViajesToolStripMenuItem.Text = "Bidaiak"
        ViajesToolStripMenuItem1.Text = "Bidaiak"
        ViajesToolStripMenuItem2.Text = "Bidaiak"
        ViajesToolStripMenuItem3.Text = "Bidaiak"
    End Sub
End Class