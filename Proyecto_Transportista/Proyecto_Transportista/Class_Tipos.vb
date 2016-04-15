Imports System.Data.SqlClient

Public Class Class_Tipos
#Region "Declaracion de variables"

    Private Const NOMBRE_TABLA As String = "tipos"


    Private str_tipo As String
    Private str_tamaino As String
    Private dou_peso_maximo As Double
    Private dou_ganancia As Double

    Private SenteciaSQL As String
    Private contador As Integer
    Private Comando As New SqlCommand
    Private adaptador As New SqlDataAdapter
#End Region

#Region "Encapsulamiento"

    Public Property tipo() As String
        Get
            tipo = str_tipo
        End Get
        Set(ByVal value As String)
            str_tipo = value
        End Set
    End Property
    Public Property tamaino() As String
        Get
            tamaino = str_tamaino
        End Get
        Set(ByVal value As String)
            str_tamaino = value
        End Set
    End Property
    Public Property peso_maximo() As Double
        Get
            peso_maximo = dou_peso_maximo
        End Get
        Set(ByVal value As Double)
            dou_peso_maximo = value
        End Set
    End Property
    Public Property ganancia() As Double
        Get
            ganancia = dou_ganancia
        End Get
        Set(ByVal value As Double)
            dou_ganancia = value
        End Set
    End Property

#End Region

#Region "Funciones"

    Public Function crearTipo()
        Try
            SenteciaSQL = "insert into " & NOMBRE_TABLA & " values ('" & str_tipo & "', '" & str_tamaino & "', " & dou_peso_maximo & ", " & dou_ganancia & ")"
            Comando = New SqlCommand(SenteciaSQL, ocCon)
            Comando.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Function borrarTipo()
        Try
            SenteciaSQL = "DELETE FROM " & NOMBRE_TABLA
            SenteciaSQL = SenteciaSQL & " WHERE tipo like %" & str_tipo & "%"
            Comando = New SqlCommand(SenteciaSQL, ocCon)
            Comando.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Function modificarTipo()
        Try
            SenteciaSQL = "update  " & NOMBRE_TABLA & " set tipo ='" & str_tipo &
               "', tamaino ='" & str_tamaino &
               "', peso_maximo ='" & dou_peso_maximo &
               "', ganancia ='" & dou_ganancia &
                "' WHERE tipo like %" & str_tipo & "%"
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
