Imports System.Windows.Forms

Public Class FrmDashboard
    Private Sub FrmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Gestion de l'École - Dashboard"
        ' Optionnel : Afficher un aperçu des élèves ici
        ' Dim eleves As List(Of Eleve) = Eleve.GetAll()
        ' DataGridView1.DataSource = eleves
    End Sub

    Private Sub btnNotes_Click(sender As Object, e As EventArgs) Handles btnNotes.Click
        Dim frmNotes As New FrmNotes()
        frmNotes.ShowDialog()
    End Sub

    Private Sub btnAbsences_Click(sender As Object, e As EventArgs) Handles btnAbsences.Click
        Dim frmAbsences As New FrmAbsences()
        frmAbsences.ShowDialog()
    End Sub

    Private Sub btnBulletins_Click(sender As Object, e As EventArgs) Handles btnBulletins.Click
        Dim frmBulletins As New FrmBulletins()
        frmBulletins.ShowDialog()
    End Sub

    Private Sub btnEleves_Click(sender As Object, e As EventArgs) Handles btnEleves.Click
        Dim frmEleves As New FrmEleves()
        frmEleves.ShowDialog()
    End Sub

    Private Sub btnMatieres_Click(sender As Object, e As EventArgs) Handles btnMatieres.Click
        Dim frmMatieres As New FrmMatieres()
        frmMatieres.ShowDialog()
    End Sub

    'Private Sub btnEleves_Click(sender As Object, e As EventArgs) Handles btnEleves.Click  ' À ajouter si tu crées un btnEleves
    '    Dim frmEleves As New FrmEleves()  ' On créera ce form plus tard si besoin
    '    frmEleves.ShowDialog()
    'End Sub
End Class