Imports System.Windows.Forms
Imports System.Collections.Generic

Public Class FrmEleves
    Private Sub FrmEleves_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Gestion des Élèves"
        ActualiserEleves()
    End Sub

    Private Sub ActualiserEleves()
        Dim eleves As List(Of Eleve) = Eleve.GetAll()
        dgvEleves.DataSource = eleves
        dgvEleves.Columns("Id").Visible = False
        dgvEleves.Columns("DateNaissance").DefaultCellStyle.Format = "dd/MM/yyyy"  ' Format date
        dgvEleves.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub btnActualiser_Click(sender As Object, e As EventArgs)
        ActualiserEleves()
    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs)
        Dim nom As String = InputBox("Nom :")
        If String.IsNullOrEmpty(nom) Then Return
        Dim prenom As String = InputBox("Prénom :")
        If String.IsNullOrEmpty(prenom) Then Return
        Dim dateNaiss As String = InputBox("Date de naissance (YYYY-MM-DD) :")
        If String.IsNullOrEmpty(dateNaiss) Then Return
        Dim classe As String = InputBox("Classe :")
        If String.IsNullOrEmpty(classe) Then Return

        Dim newEleve As New Eleve()
        newEleve.Nom = nom
        newEleve.Prenom = prenom
        newEleve.DateNaissance = Date.Parse(dateNaiss)
        newEleve.Classe = classe
        newEleve.Add()
        ActualiserEleves()
        MessageBox.Show("Élève ajouté !")
    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs)
        If dgvEleves.SelectedRows.Count = 0 Then
            MessageBox.Show("Sélectionnez un élève !")
            Return
        End If
        Dim selected As Eleve = CType(dgvEleves.SelectedRows(0).DataBoundItem, Eleve)
        selected.Nom = InputBox("Nouveau nom :", "", selected.Nom)
        selected.Prenom = InputBox("Nouveau prénom :", "", selected.Prenom)
        selected.DateNaissance = Date.Parse(InputBox("Nouvelle date (YYYY-MM-DD) :", "", selected.DateNaissance.ToString("yyyy-MM-dd")))
        selected.Classe = InputBox("Nouvelle classe :", "", selected.Classe)
        selected.Update()
        ActualiserEleves()
        MessageBox.Show("Élève modifié !")
    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs)
        If dgvEleves.SelectedRows.Count = 0 Then
            MessageBox.Show("Sélectionnez un élève !")
            Return
        End If
        If MessageBox.Show("Supprimer cet élève ? (Supprimera aussi notes/absences liées)", "Confirmer", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim selected As Eleve = CType(dgvEleves.SelectedRows(0).DataBoundItem, Eleve)
            Eleve.Delete(selected.Id)
            ActualiserEleves()
            MessageBox.Show("Élève supprimé !")
        End If
    End Sub
End Class