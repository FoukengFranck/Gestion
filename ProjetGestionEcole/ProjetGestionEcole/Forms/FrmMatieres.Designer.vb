<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMatieres
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
        Me.dgvMatieres = New System.Windows.Forms.DataGridView()
        Me.btnActualiser = New System.Windows.Forms.Button()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvMatieres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvMatieres
        '
        Me.dgvMatieres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMatieres.Location = New System.Drawing.Point(12, 196)
        Me.dgvMatieres.Name = "dgvMatieres"
        Me.dgvMatieres.RowTemplate.Height = 28
        Me.dgvMatieres.Size = New System.Drawing.Size(2716, 469)
        Me.dgvMatieres.TabIndex = 0
        '
        'btnActualiser
        '
        Me.btnActualiser.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnActualiser.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualiser.Location = New System.Drawing.Point(1804, 867)
        Me.btnActualiser.Name = "btnActualiser"
        Me.btnActualiser.Size = New System.Drawing.Size(199, 67)
        Me.btnActualiser.TabIndex = 9
        Me.btnActualiser.Text = "🔄 Actualiser"
        Me.btnActualiser.UseVisualStyleBackColor = False
        '
        'btnSupprimer
        '
        Me.btnSupprimer.BackColor = System.Drawing.Color.Red
        Me.btnSupprimer.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupprimer.Location = New System.Drawing.Point(1331, 867)
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Size = New System.Drawing.Size(199, 67)
        Me.btnSupprimer.TabIndex = 8
        Me.btnSupprimer.Text = "🗑️ Supprimer"
        Me.btnSupprimer.UseVisualStyleBackColor = False
        '
        'btnModifier
        '
        Me.btnModifier.BackColor = System.Drawing.Color.Yellow
        Me.btnModifier.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifier.Location = New System.Drawing.Point(896, 867)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(199, 67)
        Me.btnModifier.TabIndex = 7
        Me.btnModifier.Text = "✏️ Modifier"
        Me.btnModifier.UseVisualStyleBackColor = False
        '
        'btnAjouter
        '
        Me.btnAjouter.BackColor = System.Drawing.Color.Lime
        Me.btnAjouter.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjouter.Location = New System.Drawing.Point(513, 867)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(199, 67)
        Me.btnAjouter.TabIndex = 6
        Me.btnAjouter.Text = "➕ Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, -10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2752, 147)
        Me.Panel1.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(978, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(665, 60)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GESTION DES MATIERES"
        '
        'FrmMatieres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(2740, 1794)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnActualiser)
        Me.Controls.Add(Me.btnSupprimer)
        Me.Controls.Add(Me.btnModifier)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.dgvMatieres)
        Me.Name = "FrmMatieres"
        Me.Text = "FrmMatieres"
        CType(Me.dgvMatieres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvMatieres As DataGridView
    Friend WithEvents btnActualiser As Button
    Friend WithEvents btnSupprimer As Button
    Friend WithEvents btnModifier As Button
    Friend WithEvents btnAjouter As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
