Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Collections.Generic

Public Class Matiere
    Public Property Id As Integer
    Public Property Nom As String
    Public Property Coefficient As Decimal

    Public Shared Function GetAll() As List(Of Matiere)
        Dim matieres As New List(Of Matiere)
        Using conn As MySqlConnection = DBConnection.GetConnection()
            Dim query As String = "SELECT Id, Nom, Coefficient FROM Matieres"
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim matiere As New Matiere()
                        matiere.Id = Convert.ToInt32(reader("Id"))
                        matiere.Nom = reader("Nom").ToString()
                        matiere.Coefficient = Convert.ToDecimal(reader("Coefficient"))
                        matieres.Add(matiere)
                    End While
                End Using
            End Using
        End Using
        Return matieres
    End Function

    Public Sub Add()
        Using conn As MySqlConnection = DBConnection.GetConnection()
            Dim query As String = "INSERT INTO Matieres (Nom, Coefficient) VALUES (@Nom, @Coefficient)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Nom", Nom)
                cmd.Parameters.AddWithValue("@Coefficient", Coefficient)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub Update()
        Using conn As MySqlConnection = DBConnection.GetConnection()
            Dim query As String = "UPDATE Matieres SET Nom=@Nom, Coefficient=@Coefficient WHERE Id=@Id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Id", Id)
                cmd.Parameters.AddWithValue("@Nom", Nom)
                cmd.Parameters.AddWithValue("@Coefficient", Coefficient)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Shared Sub Delete(id As Integer)
        Using conn As MySqlConnection = DBConnection.GetConnection()
            Dim query As String = "DELETE FROM Matieres WHERE Id=@Id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Id", id)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Récupéreration d'une matière par ID
    Public Shared Function GetById(id As Integer) As Matiere
        Dim matiere As New Matiere()
        Using conn As MySqlConnection = DBConnection.GetConnection()
            Dim query As String = "SELECT Id, Nom, Coefficient FROM Matieres WHERE Id=@Id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Id", id)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        matiere.Id = Convert.ToInt32(reader("Id"))
                        matiere.Nom = reader("Nom").ToString()
                        matiere.Coefficient = Convert.ToDecimal(reader("Coefficient"))
                    End If
                End Using
            End Using
        End Using
        Return matiere
    End Function
End Class