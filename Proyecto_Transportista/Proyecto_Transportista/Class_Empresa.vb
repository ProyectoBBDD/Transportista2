Imports System.Data.SqlClient

Public Class Class_Empresa

#Region "Declaracion de variables"

    Private Const NOMBRE_TABLA As String = "empresas"

    Private int_id_empresa As Integer
    Private str_nombre_empresa As String
    Private str_direccion_empresa As String
    Private str_email_empresa As String
    Private str_telefono_empresa As String
    Private dou_distancia As Double

    Private SenteciaSQL As String
    Private contador As Integer
    Private Comando As New SqlCommand
    Private adaptador As New SqlDataAdapter
#End Region

#Region "Encapsulamiento"

    Public Property id_empresa() As Integer
        Get
            id_empresa = int_id_empresa
        End Get
        Set(ByVal value As Integer)
            int_id_empresa = value
        End Set
    End Property
    Public Property nombre_empresa() As String
        Get
            nombre_empresa = str_nombre_empresa
        End Get
        Set(ByVal value As String)
            str_nombre_empresa = value
        End Set
    End Property
    Public Property direccion_empresa() As String
        Get
            direccion_empresa = str_direccion_empresa
        End Get
        Set(ByVal value As String)
            str_direccion_empresa = value
        End Set
    End Property
    Public Property email_empresa() As String
        Get
            email_empresa = str_email_empresa
        End Get
        Set(ByVal value As String)
            str_email_empresa = value
        End Set
    End Property
    Public Property telefono_empresa() As String
        Get
            telefono_empresa = str_telefono_empresa
        End Get
        Set(ByVal value As String)
            str_telefono_empresa = value
        End Set
    End Property
    Public Property distancia() As Double
        Get
            distancia = dou_distancia
        End Get
        Set(ByVal value As Double)
            dou_distancia = value
        End Set
    End Property
    
#End Region

#Region "Funciones"

    Public Function generar_idEmpresa() As Integer
        Dim max As Integer
        SenteciaSQL = "SELECT MAX(id_empresa) FROM " & NOMBRE_TABLA
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

    Public Function crearEmpresa()
        int_id_empresa = generar_idEmpresa()
        Try
            SenteciaSQL = "insert into " & NOMBRE_TABLA & " values (" & int_id_empresa & ", '" & str_nombre_empresa & "', '" & str_direccion_empresa & "', '" & str_email_empresa & "', '" & str_telefono_empresa & "', " & dou_distancia & ")"
            Comando = New SqlCommand(SenteciaSQL, ocCon)
            Comando.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Function borrarEmpresa()
        Try
            SenteciaSQL = "DELETE FROM " & NOMBRE_TABLA
            SenteciaSQL = SenteciaSQL & " WHERE id_empresa =" & int_id_empresa
            Comando = New SqlCommand(SenteciaSQL, ocCon)
            Comando.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Function modificarEmpresa()
        Try
            SenteciaSQL = "update  " & NOMBRE_TABLA & " set id_empresa ='" & int_id_empresa &
               "', nombre_empresa ='" & str_nombre_empresa & "', direccion_empresa ='" & str_direccion_empresa &
               "', email_empresa ='" & str_email_empresa & "', telefono_empresa = " & str_telefono_empresa &
               "', distancia ='" & dou_distancia &
                "' where id_empresa = " & int_id_empresa
            Comando = New SqlCommand(SenteciaSQL, ocCon)
            Comando.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
        Return True
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
#End Region

End Class
