Imports System.Data.SqlClient
Public Class Class_Empleado

#Region "Declaracion de variables"

    Private Const NOMBRE_TABLA As String = "empleados"

    Private int_id_emp As Integer
    Private str_nombre_emp As String
    Private str_apellido1_emp As String
    Private str_apellido2_emp As String
    Private str_direccion_emp As String
    Private date_fecha_nac As String
    Private str_email_emp As String
    Private str_cargo_emp As String
    Private str_telefono_fijo_emp As String
    Private str_telefono_movil_emp As String

    Private SenteciaSQL As String
    Private contador As Integer
    Private Comando As New SqlCommand
    Private adaptador As New SqlDataAdapter
#End Region

#Region "Encapsulamiento"

    Public Property id_emp() As Integer
        Get
            id_emp = int_id_emp
        End Get
        Set(ByVal value As Integer)
            int_id_emp = value
        End Set
    End Property
    Public Property nombre_emp() As String
        Get
            nombre_emp = str_nombre_emp
        End Get
        Set(ByVal value As String)
            str_nombre_emp = value
        End Set
    End Property
    Public Property apellido1_emp() As String
        Get
            apellido1_emp = str_apellido1_emp
        End Get
        Set(ByVal value As String)
            str_apellido1_emp = value
        End Set
    End Property
    Public Property apellido2_emp() As String
        Get
            apellido2_emp = str_apellido2_emp
        End Get
        Set(ByVal value As String)
            str_apellido2_emp = value
        End Set
    End Property
    Public Property direccion_emp() As String
        Get
            direccion_emp = str_direccion_emp
        End Get
        Set(ByVal value As String)
            str_direccion_emp = value
        End Set
    End Property
    Public Property fecha_nac() As String
        Get
            fecha_nac = date_fecha_nac
        End Get
        Set(ByVal value As String)
            date_fecha_nac = value
        End Set
    End Property
    Public Property email_emp() As String
        Get
            email_emp = str_email_emp
        End Get
        Set(ByVal value As String)
            str_email_emp = value
        End Set
    End Property
    Public Property cargo_emp() As String
        Get
            cargo_emp = str_cargo_emp
        End Get
        Set(ByVal value As String)
            str_cargo_emp = value
        End Set
    End Property
    Public Property telefono_fijo_emp() As String
        Get
            telefono_fijo_emp = str_telefono_fijo_emp
        End Get
        Set(ByVal value As String)
            str_telefono_fijo_emp = value
        End Set
    End Property
    Public Property telefono_movil_emp() As String
        Get
            telefono_movil_emp = str_telefono_movil_emp
        End Get
        Set(ByVal value As String)
            str_telefono_movil_emp = value
        End Set
    End Property
#End Region

#Region "Funciones"

    Public Function generar_idEmpleado() As Integer
        Dim max As Integer
        Try
            If Not tabla_vacia() Then
                SenteciaSQL = "SELECT MAX(id_emp) FROM " & NOMBRE_TABLA
                Comando = New SqlCommand(SenteciaSQL, ocCon)
                max = Comando.ExecuteScalar
                Return max + 1
            Else
                max = 1
                Return max
            End If
            Return True
        Catch ex As Exception
            Return 1
        End Try

    End Function

    Private Function tabla_vacia() As Boolean
        Dim cont As Integer
        SenteciaSQL = "SELECT COUNT(*) FROM " & NOMBRE_TABLA
        Try
            Comando = New SqlCommand(SenteciaSQL, ocCon)
            cont = Comando.ExecuteScalar
            If cont = 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function crearEmpleado()
        int_id_emp = generar_idEmpleado()
        Try
            SenteciaSQL = "insert into " & NOMBRE_TABLA & " values (" & int_id_emp & ", '" & str_nombre_emp & "', '" & str_apellido1_emp & "', '" & str_apellido2_emp & "', '" & str_direccion_emp & "', '" & date_fecha_nac & "', '" & str_email_emp & "', '" & str_cargo_emp & "', '" & str_telefono_fijo_emp & "', '" & str_telefono_movil_emp & "')"
            Comando = New SqlCommand(SenteciaSQL, ocCon)
            Comando.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Function borrarEmpleado()
        Try
            SenteciaSQL = "DELETE FROM " & NOMBRE_TABLA
            SenteciaSQL = SenteciaSQL & " WHERE id_emp =" & int_id_emp
            Comando = New SqlCommand(SenteciaSQL, ocCon)
            Comando.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Function modificarEmpleado()
        Try
            SenteciaSQL = "update  " & NOMBRE_TABLA & " set id_emp ='" & int_id_emp &
               "', nombre_emp ='" & str_nombre_emp & "', apellido1_emp ='" & str_apellido1_emp &
               "', apellido2_emp ='" & str_apellido2_emp & "', direccion_emp = " & str_direccion_emp &
               "', fecha_nac ='" & date_fecha_nac & "', email_emp = " & str_email_emp &
               "', cargo_emp ='" & str_cargo_emp & "', telefono_fijo_emp = " & str_telefono_fijo_emp &
               "', telefono_movil_emp ='" & str_telefono_movil_emp &
                "' where id_emp = " & int_id_emp
            Comando = New SqlCommand(SenteciaSQL, ocCon)
            Comando.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Function llenarComboBoxTrab() As DataTable
        Dim busqueda As New DataTable
        SenteciaSQL = "select id_emp from empleados"
        Try
            Comando = New SqlCommand(SenteciaSQL, ocCon)
            adaptador = New SqlDataAdapter(Comando)
            busqueda = New DataTable()
            adaptador.Fill(busqueda)
            Return busqueda
        Catch ex As Exception
        End Try
        Return busqueda
    End Function

    Public Function refrescar() As DataTable
        Dim dtTabEmpleados As New DataTable
        SenteciaSQL = "SELECT * FROM " + NOMBRE_TABLA + " WHERE 1=1"
        Try
            Comando = New SqlCommand(SenteciaSQL, ocCon)
            adaptador = New SqlDataAdapter(Comando)
            adaptador.Fill(dtTabEmpleados)
            Return dtTabEmpleados
        Catch ex As Exception
        End Try
        Return dtTabEmpleados
    End Function

    Public Function recogerDatos() As DataTable

        Dim dtTabEmpleados As New DataTable
        Dim Comando As New SqlCommand
        Dim adaptador As New SqlDataAdapter
        SenteciaSQL = "SELECT * FROM " + NOMBRE_TABLA + " WHERE id_emp = " & int_id_emp
        Try
            Comando = New SqlCommand(SenteciaSQL, ocCon)
            adaptador = New SqlDataAdapter(Comando)
            dtTabEmpleados = New DataTable()
            adaptador.Fill(dtTabEmpleados)
            Return dtTabEmpleados
        Catch ex As Exception
        End Try
        Return dtTabEmpleados
    End Function
#End Region

End Class
