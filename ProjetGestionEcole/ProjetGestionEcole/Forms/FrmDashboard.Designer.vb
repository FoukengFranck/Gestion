<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnNotes = New System.Windows.Forms.Button()
        Me.btnBulletins = New System.Windows.Forms.Button()
        Me.btnAbsences = New System.Windows.Forms.Button()
        Me.btnEleves = New System.Windows.Forms.Button()
        Me.btnMatieres = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1036, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(734, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gestion de l'École - Tableau de Bord"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-7, -33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2749, 147)
        Me.Panel1.TabIndex = 1
        '
        'btnNotes
        '
        Me.btnNotes.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnNotes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNotes.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnNotes.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnNotes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnNotes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnNotes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNotes.Font = New System.Drawing.Font("Roboto Flex Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotes.ForeColor = System.Drawing.Color.White
        Me.btnNotes.Location = New System.Drawing.Point(33, 43)
        Me.btnNotes.Name = "btnNotes"
        Me.btnNotes.Size = New System.Drawing.Size(196, 81)
        Me.btnNotes.TabIndex = 2
        Me.btnNotes.Text = "✍️  Gestion des Notes"
        Me.btnNotes.UseVisualStyleBackColor = False
        '
        'btnBulletins
        '
        Me.btnBulletins.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnBulletins.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBulletins.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBulletins.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnBulletins.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnBulletins.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnBulletins.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBulletins.Font = New System.Drawing.Font("Roboto Flex Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBulletins.ForeColor = System.Drawing.Color.White
        Me.btnBulletins.Location = New System.Drawing.Point(33, 388)
        Me.btnBulletins.Name = "btnBulletins"
        Me.btnBulletins.Size = New System.Drawing.Size(196, 79)
        Me.btnBulletins.TabIndex = 3
        Me.btnBulletins.Text = "📑 Génération des Bulletins"
        Me.btnBulletins.UseVisualStyleBackColor = False
        '
        'btnAbsences
        '
        Me.btnAbsences.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnAbsences.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbsences.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAbsences.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnAbsences.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnAbsences.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnAbsences.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAbsences.Font = New System.Drawing.Font("Roboto Flex Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbsences.ForeColor = System.Drawing.Color.White
        Me.btnAbsences.Location = New System.Drawing.Point(33, 222)
        Me.btnAbsences.Name = "btnAbsences"
        Me.btnAbsences.Size = New System.Drawing.Size(196, 78)
        Me.btnAbsences.TabIndex = 4
        Me.btnAbsences.Text = "🕒 Gestion des Absences"
        Me.btnAbsences.UseVisualStyleBackColor = False
        '
        'btnEleves
        '
        Me.btnEleves.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnEleves.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEleves.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEleves.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnEleves.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnEleves.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnEleves.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEleves.Font = New System.Drawing.Font("Roboto Flex Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEleves.ForeColor = System.Drawing.Color.White
        Me.btnEleves.Location = New System.Drawing.Point(33, 551)
        Me.btnEleves.Name = "btnEleves"
        Me.btnEleves.Size = New System.Drawing.Size(196, 80)
        Me.btnEleves.TabIndex = 5
        Me.btnEleves.Text = "👥 Gestion des Élèves"
        Me.btnEleves.UseVisualStyleBackColor = False
        '
        'btnMatieres
        '
        Me.btnMatieres.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnMatieres.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMatieres.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnMatieres.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnMatieres.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnMatieres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnMatieres.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMatieres.Font = New System.Drawing.Font("Roboto Flex Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMatieres.ForeColor = System.Drawing.Color.White
        Me.btnMatieres.Location = New System.Drawing.Point(33, 714)
        Me.btnMatieres.Name = "btnMatieres"
        Me.btnMatieres.Size = New System.Drawing.Size(196, 80)
        Me.btnMatieres.TabIndex = 6
        Me.btnMatieres.Text = "📚 Gestion des Matières"
        Me.btnMatieres.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnEleves)
        Me.Panel2.Controls.Add(Me.btnMatieres)
        Me.Panel2.Controls.Add(Me.btnNotes)
        Me.Panel2.Controls.Add(Me.btnBulletins)
        Me.Panel2.Controls.Add(Me.btnAbsences)
        Me.Panel2.Location = New System.Drawing.Point(-7, 113)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(285, 1701)
        Me.Panel2.TabIndex = 7
        '
        'FrmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2740, 1794)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmDashboard"
        Me.Text = "FrmDashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnNotes As Button
    Friend WithEvents btnBulletins As Button
    Friend WithEvents btnAbsences As Button
    Friend WithEvents btnEleves As Button
    Friend WithEvents btnMatieres As Button
    Friend WithEvents Panel2 As Panel
End Class
