Imports System.Data.SqlClient
Public Class Class_Empleados
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

    Public Property id_emp() As String
        Get
            id_emp = int_id_emp
        End Get
        Set(ByVal value As String)
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
        SenteciaSQL = "SELECT MAX(id_emp) FROM empleados"
        Try
            If Not tabla_vacia() Then
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
    Public Function tabla_vacia() As Boolean
        Dim cont As Integer
        SenteciaSQL = "SELECT COUNT(*) FROM empleados"
        Try
            Comando = New SqlCommand(SenteciaSQL, ocCon)
            cont = comando.ExecuteScalar
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
            SenteciaSQL = "insert into " & NOMBRE_TABLA & " values (" & int_id_emp & ", '" & Nombre & "', '" & Apellido1 & "', '" & Apellido2 & "', '" & Direccion & "', " & AñosEnLaEmpresa & ", '" & TipoPlataforma & "')"
            Comando = New SqlCommand(SenteciaSQL, ocCon)
            Comando.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
#End Region
End Class
