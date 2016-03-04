Imports System.Data.OleDb
Imports System.Data.SqlClient

Module ModuleConexion
#Region "Declaracion de varables"

    Public ocCon As New SqlConnection

#End Region

#Region "Funciones"

    Public Function conection() As Boolean
        Dim baseDeDatos As String
        baseDeDatos = "Data Source=PAUL-GUERRERO;Initial Catalog=Transportista_BBDD;Integrated Security=True"
        Try
            ocCon = New SqlConnection(baseDeDatos)
            ocCon.Open()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function desconection() As Boolean
        Try
            ocCon.Dispose()
            ocCon.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
#End Region
End Module
