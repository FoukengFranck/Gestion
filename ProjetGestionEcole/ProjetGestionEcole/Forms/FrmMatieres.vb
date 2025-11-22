Imports System.Windows.Forms
Imports System.Collections.Generic

Public Class FrmMatieres
    Private Sub FrmMatieres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Gestion des Matières"
        ActualiserMatieres()
    End Sub

    Private Sub ActualiserMatieres()
        Dim matieres As List(Of Matiere) = Matiere.GetAll()
        dgvMatieres.DataSource = matieres
        dgvMatieres.Columns("Id").Visible = False
        dgvMatieres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub btnActualiser_Click(sender As Object, e As EventArgs)
        ActualiserMatieres()
    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs)
        Dim nom As String = InputBox("Nom de la matière :")
        If String.IsNullOrEmpty(nom) Then Return
        Dim coef As String = InputBox("Coefficient (ex. 2.0) :")
        If String.IsNullOrEmpty(coef) Then Return

        Dim newMatiere As New Matiere()
        newMatiere.Nom = nom
        newMatiere.Coefficient = Decimal.Parse(coef)
        newMatiere.Add()
        ActualiserMatieres()
        MessageBox.Show("Matière ajoutée !")
    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs)
        If dgvMatieres.SelectedRows.Count = 0 Then
            MessageBox.Show("Sélectionnez une matière !")
            Return
        End If
        Dim selected As Matiere = CType(dgvMatieres.SelectedRows(0).DataBoundItem, Matiere)
        selected.Nom = InputBox("Nouveau nom :", "", selected.Nom)
        selected.Coefficient = Decimal.Parse(InputBox("Nouveau coefficient :", "", selected.Coefficient.ToString()))
        selected.Update()
        ActualiserMatieres()
        MessageBox.Show("Matière modifiée !")
    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs)
        If dgvMatieres.SelectedRows.Count = 0 Then
            MessageBox.Show("Sélectionnez une matière !")
            Return
        End If
        If MessageBox.Show("Supprimer cette matière ? (Supprimera aussi les notes liées)", "Confirmer", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim selected As Matiere = CType(dgvMatieres.SelectedRows(0).DataBoundItem, Matiere)
            Matiere.Delete(selected.Id)
            ActualiserMatieres()
            MessageBox.Show("Matière supprimée !")
        End If
    End Sub
End Class