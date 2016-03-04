Imports System.Data.SqlClient

Public Class Class_Historico_Salario
    Private Const NOMBRE_TABLA As String = "historico_salario"


    Private str_mes As String
    Private int_id_emp As Integer
    Private dou_ganancias As Double
    Private SenteciaSQL As String
    Private contador As Integer
    Private Comando As New SqlCommand
    Private adaptador As New SqlDataAdapter



#Region "Encapsulamiento"

    Public Property id_emp() As Integer
        Get
            id_emp = int_id_emp
        End Get
        Set(ByVal value As Integer)
            int_id_emp = value
        End Set
    End Property
    Public Property mes() As String
        Get
            mes = str_mes
        End Get
        Set(ByVal value As String)
            str_mes = value
        End Set
    End Property
    Public Property ganancias() As Double
        Get
            ganancias = dou_ganancias
        End Get
        Set(ByVal value As Double)
            dou_ganancias = value
        End Set
    End Property

#End Region

#Region "Funciones"

    Public Function crearHistorico_Salario()
        Try
            SenteciaSQL = "insert into " & NOMBRE_TABLA & " values ('" & str_mes & "', " & int_id_emp & ", " & dou_ganancias & ")"
            Comando = New SqlCommand(SenteciaSQL, ocCon)
            Comando.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Function borrarHistorico_Salario()
        Try
            SenteciaSQL = "DELETE FROM " & NOMBRE_TABLA & " where 1=1"

            If int_id_emp <> vbNull Then
                SenteciaSQL += " AND id_emp = " & int_id_emp & ""
            End If
            If str_mes <> vbNullString Then
                SenteciaSQL += " AND mes = '" & str_mes & "'"
            End If
            Comando = New SqlCommand(SenteciaSQL, ocCon)
            Comando.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Function modificarHistorico_Salario()
        Try
            SenteciaSQL = "UPDATE  " & NOMBRE_TABLA & " set mes '" & str_mes &
                "', id_emp =" & int_id_emp & ", ganancias = " & dou_ganancias & " where 1=1"

            If int_id_emp <> vbNull Then
                SenteciaSQL += " AND id_emp = " & int_id_emp & ""
            End If
            If str_mes <> vbNullString Then
                SenteciaSQL += " AND mes = '" & str_mes & "'"
            End If
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
