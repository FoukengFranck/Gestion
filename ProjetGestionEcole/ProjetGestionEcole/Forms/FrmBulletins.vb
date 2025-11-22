Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.Linq  ' Pour les agrégations (dispo en VB.NET)

Public Class FrmBulletins
    Private Sub FrmBulletins_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Génération des Bulletins"
        ChargerEleves()
    End Sub

    Private Sub ChargerEleves()
        Dim eleves As List(Of Eleve) = Eleve.GetAll()
        cbEleve.DataSource = eleves
        cbEleve.DisplayMember = "Nom"  ' Affiche Nom + Prenom si tu ajoutes une prop FullName
        cbEleve.ValueMember = "Id"
    End Sub

    Private Sub btnGenerer_Click(sender As Object, e As EventArgs) Handles btnGenerer.Click
        If cbEleve.SelectedIndex = -1 Then
            MessageBox.Show("Sélectionnez un élève !")
            Return
        End If

        Dim eleveId As Integer = Convert.ToInt32(cbEleve.SelectedValue)
        MessageBox.Show("Élève sélectionné : ID = " & eleveId & " (Nom : " & cbEleve.Text & ")")  ' DEBUG : Vérifie l'ID

        Dim toutesNotes As List(Of Note) = Note.GetAll()
        MessageBox.Show("Total notes en base : " & toutesNotes.Count)  ' DEBUG : Vérifie si y'a des notes du tout

        Dim notes As List(Of Note) = toutesNotes.Where(Function(n) n.EleveId = eleveId).ToList()
        MessageBox.Show("Notes pour cet élève (ID " & eleveId & ") : " & notes.Count)  ' DEBUG : Vérifie le filtre

        If notes.Count = 0 Then
            txtBulletin.Text = "Aucune note pour cet élève. Ajoutez-en d'abord via 'Gestion des Notes'."
            Return
        End If

        ' Le reste du code (génération bulletin) – inchangé
        Dim bulletin As String = "Bulletin pour " & cbEleve.Text & " :" & vbCrLf

        Dim totalPondere As Decimal = 0
        Dim totalCoef As Decimal = 0
        For Each note In notes
            Dim matiere As Matiere = Matiere.GetById(note.MatiereId)
            totalPondere += note.Valeur * matiere.Coefficient
            totalCoef += matiere.Coefficient
            bulletin = bulletin & "- " & note.Valeur.ToString() & "/20 en " & matiere.Nom & " (coef " & matiere.Coefficient.ToString() & ") le " & note.DateNote.ToString("dd/MM/yyyy") & vbCrLf
        Next
        Dim moyenne As Decimal = If(totalCoef > 0, totalPondere / totalCoef, 0)

        bulletin = bulletin & "Moyenne : " & moyenne.ToString("F2") & "/20"

        txtBulletin.Text = bulletin
        MessageBox.Show("Bulletin généré !")  ' DEBUG : Confirme
    End Sub
End Class