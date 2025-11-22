Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports System.Data

Public Class DBConnection
    Private Shared ReadOnly connectionString As String = "Server=localhost;Database=gestion_ecole;Uid=root;Pwd=;Convert Zero Datetime=True;"

    Public Shared Function GetConnection() As MySqlConnection
        Dim conn As New MySqlConnection(connectionString)
        conn.Open()
        Return conn
    End Function

    Public Shared Sub CloseConnection(conn As MySqlConnection)
        If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub
End Class