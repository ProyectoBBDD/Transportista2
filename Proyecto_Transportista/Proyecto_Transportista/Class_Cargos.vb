﻿Imports System.Data.SqlClient

Public Class Class_Cargos
#Region "Declaracion de variables"

    Private Const NOMBRE_TABLA As String = "cargos"


    Private str_nombre_cargo As String
    Private str_descripcion_cargo As String

    Private SenteciaSQL As String
    Private contador As Integer
    Private Comando As New SqlCommand
    Private adaptador As New SqlDataAdapter
#End Region

#Region "Encapsulamiento"

    Public Property nombre_cargo() As String
        Get
            nombre_cargo = str_nombre_cargo
        End Get
        Set(ByVal value As String)
            str_nombre_cargo = value
        End Set
    End Property
    Public Property descripcion_cargo() As String
        Get
            descripcion_cargo = str_descripcion_cargo
        End Get
        Set(ByVal value As String)
            str_descripcion_cargo = value
        End Set
    End Property

#End Region

#Region "Funciones"

    Public Function crearCargo()
        Try
            SenteciaSQL = "insert into " & NOMBRE_TABLA & " values ('" & str_nombre_cargo & "', '" & str_descripcion_cargo & "')"
            Comando = New SqlCommand(SenteciaSQL, ocCon)
            Comando.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Function borrarCargo()
        Try
            SenteciaSQL = "DELETE FROM " & NOMBRE_TABLA
            SenteciaSQL = SenteciaSQL & " WHERE nombre_cargo like %" & str_descripcion_cargo & "%"
            Comando = New SqlCommand(SenteciaSQL, ocCon)
            Comando.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Function modificarCargo()
        Try
            SenteciaSQL = "update  " & NOMBRE_TABLA & " set nombre_cargo ='" & str_nombre_cargo &
               "', descripcion_cargo ='" & str_descripcion_cargo & 
                "' WHERE nombre_cargo like %" & str_descripcion_cargo & "%"
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
