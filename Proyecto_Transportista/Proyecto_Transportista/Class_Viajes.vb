Imports System.Data.SqlClient

Public Class Class_Viajes

#Region "Declaracion de variables"

    Private Const NOMBRE_TABLA As String = "viajes"

    Private int_id_viaje As Integer
    Private int_id_emp As Integer
    Private int_id_empresa As Integer
    Private int_id_contenedor As Integer
    Private date_fecha_entrega As String
    Private double_precio_viaje As Double

    Private SenteciaSQL As String
    Private contador As Integer
    Private Comando As New SqlCommand
    Private adaptador As New SqlDataAdapter
#End Region

#Region "Encapsulamiento"

    Public Property id_viaje() As Integer
        Get
            id_viaje = int_id_viaje
        End Get
        Set(ByVal value As Integer)
            int_id_viaje = value
        End Set
    End Property
    Public Property id_emp() As Integer
        Get
            id_emp = int_id_emp
        End Get
        Set(ByVal value As Integer)
            int_id_emp = value
        End Set
    End Property
    Public Property id_empresa() As Integer
        Get
            id_empresa = int_id_empresa
        End Get
        Set(ByVal value As Integer)
            int_id_empresa = value
        End Set
    End Property
    Public Property id_contenedor() As Integer
        Get
            id_contenedor = int_id_contenedor
        End Get
        Set(ByVal value As Integer)
            int_id_contenedor = value
        End Set
    End Property
    Public Property fecha_entrega() As String
        Get
            fecha_entrega = date_fecha_entrega
        End Get
        Set(ByVal value As String)
            date_fecha_entrega = value
        End Set
    End Property
    Public Property precio_viaje() As Double
        Get
            precio_viaje = double_precio_viaje
        End Get
        Set(ByVal value As Double)
            double_precio_viaje = value
        End Set
    End Property

#End Region

#Region "Funciones"

    Public Function generar_idViaje() As Integer
        Dim max As Integer
        SenteciaSQL = "SELECT MAX(id_viaje) FROM " & NOMBRE_TABLA
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

    Public Function crearViaje()
        int_id_emp = generar_idViaje()
        Try
            SenteciaSQL = "insert into " & NOMBRE_TABLA & " values (" & int_id_viaje & ", " & int_id_emp & ", " & int_id_empresa & ", " & int_id_contenedor & ", '" & date_fecha_entrega & "', " & double_precio_viaje & ")"
            Comando = New SqlCommand(SenteciaSQL, ocCon)
            Comando.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Function borrarViaje()
        Try
            SenteciaSQL = "DELETE FROM " & NOMBRE_TABLA
            SenteciaSQL = SenteciaSQL & " WHERE id_viaje =" & int_id_viaje
            Comando = New SqlCommand(SenteciaSQL, ocCon)
            Comando.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Function modificarViaje()
        Try
            SenteciaSQL = "update  " & NOMBRE_TABLA & " set id_viaje ='" & int_id_viaje &
               "', id_emp ='" & int_id_emp & "', id_empresa ='" & int_id_empresa &
               "', id_contenedor ='" & int_id_contenedor & "', fecha_entrega = " & date_fecha_entrega &
               "', precio_viaje ='" & double_precio_viaje &
                "' where id_viaje = " & int_id_viaje
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
