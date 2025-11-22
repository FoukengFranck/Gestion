Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Collections.Generic

Public Class Absence
    Public Property Id As Integer
    Public Property EleveId As Integer
    Public Property DateAbsence As Date
    Public Property Justifiee As Boolean
    Public Property Duree As Integer  ' En demi-journées

    Public Shared Function GetAll() As List(Of Absence)
        Dim absences As New List(Of Absence)
        Using conn As MySqlConnection = DBConnection.GetConnection()
            Dim query As String = "SELECT Id, EleveId, DateAbsence, Justifiee, Duree FROM Absences"
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim absence As New Absence()
                        absence.Id = Convert.ToInt32(reader("Id"))
                        absence.EleveId = Convert.ToInt32(reader("EleveId"))
                        absence.DateAbsence = Convert.ToDateTime(reader("DateAbsence"))
                        absence.Justifiee = Convert.ToBoolean(reader("Justifiee"))
                        absence.Duree = Convert.ToInt32(reader("Duree"))
                        absences.Add(absence)
                    End While
                End Using
            End Using
        End Using
        Return absences
    End Function

    Public Sub Add()
        Using conn As MySqlConnection = DBConnection.GetConnection()
            Dim query As String = "INSERT INTO Absences (EleveId, DateAbsence, Justifiee, Duree) VALUES (@EleveId, @DateAbsence, @Justifiee, @Duree)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@EleveId", EleveId)
                cmd.Parameters.AddWithValue("@DateAbsence", DateAbsence)
                cmd.Parameters.AddWithValue("@Justifiee", If(Justifiee, 1, 0))  ' MySQL utilise 1/0 pour bool
                cmd.Parameters.AddWithValue("@Duree", Duree)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub Update()
        Using conn As MySqlConnection = DBConnection.GetConnection()
            Dim query As String = "UPDATE Absences SET EleveId=@EleveId, DateAbsence=@DateAbsence, Justifiee=@Justifiee, Duree=@Duree WHERE Id=@Id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Id", Id)
                cmd.Parameters.AddWithValue("@EleveId", EleveId)
                cmd.Parameters.AddWithValue("@DateAbsence", DateAbsence)
                cmd.Parameters.AddWithValue("@Justifiee", If(Justifiee, 1, 0))
                cmd.Parameters.AddWithValue("@Duree", Duree)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Shared Sub Delete(id As Integer)
        Using conn As MySqlConnection = DBConnection.GetConnection()
            Dim query As String = "DELETE FROM Absences WHERE Id=@Id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Id", id)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class