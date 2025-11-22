Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Collections.Generic

Public Class Eleve
    Public Property Id As Integer
    Public Property Nom As String
    Public Property Prenom As String
    Public Property DateNaissance As Date
    Public Property Classe As String

    ' Méthode pour récupérer tous les élèves
    Public Shared Function GetAll() As List(Of Eleve)
        Dim eleves As New List(Of Eleve)
        Using conn As MySqlConnection = DBConnection.GetConnection()
            Dim query As String = "SELECT Id, Nom, Prenom, DateNaissance, Classe FROM Eleves"
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim eleve As New Eleve()
                        eleve.Id = Convert.ToInt32(reader("Id"))
                        eleve.Nom = reader("Nom").ToString()
                        eleve.Prenom = reader("Prenom").ToString()
                        eleve.DateNaissance = Convert.ToDateTime(reader("DateNaissance"))
                        eleve.Classe = reader("Classe").ToString()
                        eleves.Add(eleve)
                    End While
                End Using
            End Using
        End Using
        Return eleves
    End Function

    ' Ajouter un élève
    Public Sub Add()
        Using conn As MySqlConnection = DBConnection.GetConnection()
            Dim query As String = "INSERT INTO Eleves (Nom, Prenom, DateNaissance, Classe) VALUES (@Nom, @Prenom, @DateNaissance, @Classe)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Nom", Nom)
                cmd.Parameters.AddWithValue("@Prenom", Prenom)
                cmd.Parameters.AddWithValue("@DateNaissance", DateNaissance)
                cmd.Parameters.AddWithValue("@Classe", Classe)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Mettre à jour un élève
    Public Sub Update()
        Using conn As MySqlConnection = DBConnection.GetConnection()
            Dim query As String = "UPDATE Eleves SET Nom=@Nom, Prenom=@Prenom, DateNaissance=@DateNaissance, Classe=@Classe WHERE Id=@Id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Id", Id)
                cmd.Parameters.AddWithValue("@Nom", Nom)
                cmd.Parameters.AddWithValue("@Prenom", Prenom)
                cmd.Parameters.AddWithValue("@DateNaissance", DateNaissance)
                cmd.Parameters.AddWithValue("@Classe", Classe)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Supprimer un élève par ID
    Public Shared Sub Delete(id As Integer)
        Using conn As MySqlConnection = DBConnection.GetConnection()
            Dim query As String = "DELETE FROM Eleves WHERE Id=@Id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Id", id)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class