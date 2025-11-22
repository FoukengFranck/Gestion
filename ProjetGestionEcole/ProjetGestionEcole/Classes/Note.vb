Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Collections.Generic

Public Class Note
    Public Property Id As Integer
    Public Property EleveId As Integer
    Public Property MatiereId As Integer
    Public Property Valeur As Decimal
    Public Property DateNote As Date
    Public Property Commentaire As String

    Public Shared Function GetAll() As List(Of Note)
        Dim notes As New List(Of Note)
        Using conn As MySqlConnection = DBConnection.GetConnection()
            Dim query As String = "SELECT Id, EleveId, MatiereId, Valeur, DateNote, Commentaire FROM Notes"
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim note As New Note()
                        note.Id = Convert.ToInt32(reader("Id"))
                        note.EleveId = Convert.ToInt32(reader("EleveId"))
                        note.MatiereId = Convert.ToInt32(reader("MatiereId"))
                        note.Valeur = Convert.ToDecimal(reader("Valeur"))
                        note.DateNote = Convert.ToDateTime(reader("DateNote"))
                        note.Commentaire = reader("Commentaire").ToString()
                        notes.Add(note)
                    End While
                End Using
            End Using
        End Using
        Return notes
    End Function

    Public Sub Add()
        Using conn As MySqlConnection = DBConnection.GetConnection()
            Dim query As String = "INSERT INTO Notes (EleveId, MatiereId, Valeur, DateNote, Commentaire) VALUES (@EleveId, @MatiereId, @Valeur, @DateNote, @Commentaire)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@EleveId", EleveId)
                cmd.Parameters.AddWithValue("@MatiereId", MatiereId)
                cmd.Parameters.AddWithValue("@Valeur", Valeur)
                cmd.Parameters.AddWithValue("@DateNote", DateNote)
                cmd.Parameters.AddWithValue("@Commentaire", Commentaire)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub Update()
        Using conn As MySqlConnection = DBConnection.GetConnection()
            Dim query As String = "UPDATE Notes SET EleveId=@EleveId, MatiereId=@MatiereId, Valeur=@Valeur, DateNote=@DateNote, Commentaire=@Commentaire WHERE Id=@Id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Id", Id)
                cmd.Parameters.AddWithValue("@EleveId", EleveId)
                cmd.Parameters.AddWithValue("@MatiereId", MatiereId)
                cmd.Parameters.AddWithValue("@Valeur", Valeur)
                cmd.Parameters.AddWithValue("@DateNote", DateNote)
                cmd.Parameters.AddWithValue("@Commentaire", Commentaire)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Shared Sub Delete(id As Integer)
        Using conn As MySqlConnection = DBConnection.GetConnection()
            Dim query As String = "DELETE FROM Notes WHERE Id=@Id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Id", id)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class