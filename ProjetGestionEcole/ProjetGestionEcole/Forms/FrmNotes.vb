Imports System.Windows.Forms
Imports System.Collections.Generic

Public Class FrmNotes
    Private Sub FrmNotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Gestion des Notes"
        ActualiserNotes()
    End Sub

    Private Sub ActualiserNotes()
        Dim notes As List(Of Note) = Note.GetAll()
        dgvNotes.DataSource = notes
        dgvNotes.Columns("Id").Visible = False  ' Cacher l'ID
        dgvNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub btnActualiser_Click(sender As Object, e As EventArgs) Handles btnActualiser.Click
        ActualiserNotes()
    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        ' Ici, on pourrait ouvrir un sous-form pour saisir les détails
        ' Pour simplicité : Utilise InputBox (débutant-friendly)
        Dim eleveId As String = InputBox("ID Élève :")
        If String.IsNullOrEmpty(eleveId) Then Return
        Dim matiereId As String = InputBox("ID Matière :")
        If String.IsNullOrEmpty(matiereId) Then Return
        Dim valeur As String = InputBox("Valeur (ex. 15.5) :")
        If String.IsNullOrEmpty(valeur) Then Return
        Dim dateNote As String = InputBox("Date (YYYY-MM-DD) :")
        If String.IsNullOrEmpty(dateNote) Then Return

        Dim newNote As New Note()
        newNote.EleveId = Integer.Parse(eleveId)
        newNote.MatiereId = Integer.Parse(matiereId)
        newNote.Valeur = Decimal.Parse(valeur)
        newNote.DateNote = Date.Parse(dateNote)
        newNote.Commentaire = InputBox("Commentaire (optionnel) :")
        newNote.Add()
        ActualiserNotes()
        MessageBox.Show("Note ajoutée !")
    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        If dgvNotes.SelectedRows.Count = 0 Then
            MessageBox.Show("Sélectionnez une note !")
            Return
        End If
        Dim selected As Note = CType(dgvNotes.SelectedRows(0).DataBoundItem, Note)
        ' Même logique que Ajouter, mais pré-rempli
        selected.Valeur = Decimal.Parse(InputBox("Nouvelle valeur :", "", selected.Valeur.ToString()))
        selected.Commentaire = InputBox("Nouveau commentaire :", "", selected.Commentaire)
        selected.Update()
        ActualiserNotes()
        MessageBox.Show("Note modifiée !")
    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        If dgvNotes.SelectedRows.Count = 0 Then
            MessageBox.Show("Sélectionnez une note !")
            Return
        End If
        If MessageBox.Show("Supprimer ?", "Confirmer", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim selected As Note = CType(dgvNotes.SelectedRows(0).DataBoundItem, Note)
            Note.Delete(selected.Id)
            ActualiserNotes()
            MessageBox.Show("Note supprimée !")
        End If
    End Sub
End Class