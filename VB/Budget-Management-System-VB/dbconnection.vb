Imports MySql.Data.MySqlClient
Imports System.IO

Module dbconnection
    Public conn As MySqlConnection
    Dim result As Boolean
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public dt As New DataTable
    Public i As Integer
    Public Function dbconn() As Boolean
        Try
            If conn Is Nothing Then
                conn = New MySqlConnection("server=localhost;user=root;password=;port=3306;database=db_budget")
            End If

            If conn.State = ConnectionState.Closed Then
                conn.Open()
                result = True
            End If
        Catch ex As Exception
            result = False
            MsgBox("Server not Connected", vbExclamation)
        End Try
        Return result
    End Function

End Module
