Imports System.Data.SqlClient

Public Class Class_Contenedores

#Region "Declaracion de variables"

    Private Const NOMBRE_TABLA As String = "contenedores"


    Private int_id_contenedor As Integer
    Private str_tipo As String

    Private SenteciaSQL As String
    Private contador As Integer
    Private Comando As New SqlCommand
    Private adaptador As New SqlDataAdapter
#End Region

#Region "Encapsulamiento"

    Public Property id_contenedor() As Integer
        Get
            id_contenedor = int_id_contenedor
        End Get
        Set(ByVal value As Integer)
            int_id_contenedor = value
        End Set
    End Property
    Public Property tipo() As String
        Get
            tipo = str_tipo
        End Get
        Set(ByVal value As String)
            str_tipo = value
        End Set
    End Property

#End Region

#Region "Funciones"

    Public Function crearContenedor()
        Try
            SenteciaSQL = "insert into " & NOMBRE_TABLA & " values (" & int_id_contenedor & ", '" & str_tipo & ")"
            Comando = New SqlCommand(SenteciaSQL, ocCon)
            Comando.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Function borrarContenedor()
        Try
            SenteciaSQL = "DELETE FROM " & NOMBRE_TABLA
            SenteciaSQL = SenteciaSQL & " WHERE id_contenedor=" & int_id_contenedor
            Comando = New SqlCommand(SenteciaSQL, ocCon)
            Comando.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Function modificarContenedor()
        Try
            SenteciaSQL = "update  " & NOMBRE_TABLA & " set id_contenedor =" & int_id_contenedor &
               ", tipo ='" & str_tipo &
                "' WHERE id_contenedor=" & int_id_contenedor
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
