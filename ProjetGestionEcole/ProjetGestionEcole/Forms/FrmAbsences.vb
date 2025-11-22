Imports System.Windows.Forms
Imports System.Collections.Generic

Public Class FrmAbsences
    Private Sub FrmAbsences_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Gestion des Absences"
        ActualiserAbsences()
    End Sub

    Private Sub ActualiserAbsences()
        Dim absences As List(Of Absence) = Absence.GetAll()
        dgvAbsences.DataSource = absences
        dgvAbsences.Columns("Id").Visible = False
        dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub btnActualiser_Click(sender As Object, e As EventArgs)
        ActualiserAbsences()
    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs)
        Dim eleveId As String = InputBox("ID Élève :")
        If String.IsNullOrEmpty(eleveId) Then Return
        Dim dateAbs As String = InputBox("Date (YYYY-MM-DD) :")
        If String.IsNullOrEmpty(dateAbs) Then Return
        Dim justifiee As String = InputBox("Justifiée ? (oui/non) :")
        Dim duree As String = InputBox("Durée (demi-journées) :")
        If String.IsNullOrEmpty(duree) Then Return

        Dim newAbs As New Absence()
        newAbs.EleveId = Integer.Parse(eleveId)
        newAbs.DateAbsence = Date.Parse(dateAbs)
        newAbs.Justifiee = (justifiee.ToLower() = "oui")
        newAbs.Duree = Integer.Parse(duree)
        newAbs.Add()
        ActualiserAbsences()
        MessageBox.Show("Absence ajoutée !")
    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs)
        If dgvAbsences.SelectedRows.Count = 0 Then
            MessageBox.Show("Sélectionnez une absence !")
            Return
        End If
        Dim selected As Absence = CType(dgvAbsences.SelectedRows(0).DataBoundItem, Absence)
        selected.Justifiee = (InputBox("Justifiée ? (oui/non) :", "", If(selected.Justifiee, "oui", "non")).ToLower() = "oui")
        selected.Duree = Integer.Parse(InputBox("Nouvelle durée :", "", selected.Duree.ToString()))
        selected.Update()
        ActualiserAbsences()
        MessageBox.Show("Absence modifiée !")
    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs)
        If dgvAbsences.SelectedRows.Count = 0 Then
            MessageBox.Show("Sélectionnez une absence !")
            Return
        End If
        If MessageBox.Show("Supprimer ?", "Confirmer", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim selected As Absence = CType(dgvAbsences.SelectedRows(0).DataBoundItem, Absence)
            Absence.Delete(selected.Id)
            ActualiserAbsences()
            MessageBox.Show("Absence supprimée !")
        End If
    End Sub
End Class