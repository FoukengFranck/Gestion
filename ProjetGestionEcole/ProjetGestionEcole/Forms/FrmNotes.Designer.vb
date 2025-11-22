<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNotes
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
        Me.dgvNotes = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        Me.btnActualiser = New System.Windows.Forms.Button()
        CType(Me.dgvNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvNotes
        '
        Me.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNotes.Location = New System.Drawing.Point(12, 202)
        Me.dgvNotes.Name = "dgvNotes"
        Me.dgvNotes.RowTemplate.Height = 28
        Me.dgvNotes.Size = New System.Drawing.Size(2716, 881)
        Me.dgvNotes.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-7, -15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2752, 115)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1101, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(567, 60)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GESTION DES NOTES"
        '
        'btnAjouter
        '
        Me.btnAjouter.BackColor = System.Drawing.Color.Lime
        Me.btnAjouter.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjouter.Location = New System.Drawing.Point(760, 1246)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(199, 67)
        Me.btnAjouter.TabIndex = 2
        Me.btnAjouter.Text = "➕ Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = False
        '
        'btnModifier
        '
        Me.btnModifier.BackColor = System.Drawing.Color.Yellow
        Me.btnModifier.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifier.Location = New System.Drawing.Point(1143, 1246)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(199, 67)
        Me.btnModifier.TabIndex = 3
        Me.btnModifier.Text = "✏️ Modifier"
        Me.btnModifier.UseVisualStyleBackColor = False
        '
        'btnSupprimer
        '
        Me.btnSupprimer.BackColor = System.Drawing.Color.Red
        Me.btnSupprimer.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupprimer.Location = New System.Drawing.Point(1578, 1246)
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Size = New System.Drawing.Size(199, 67)
        Me.btnSupprimer.TabIndex = 4
        Me.btnSupprimer.Text = "🗑️ Supprimer"
        Me.btnSupprimer.UseVisualStyleBackColor = False
        '
        'btnActualiser
        '
        Me.btnActualiser.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnActualiser.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualiser.Location = New System.Drawing.Point(2051, 1246)
        Me.btnActualiser.Name = "btnActualiser"
        Me.btnActualiser.Size = New System.Drawing.Size(199, 67)
        Me.btnActualiser.TabIndex = 5
        Me.btnActualiser.Text = "🔄 Actualiser"
        Me.btnActualiser.UseVisualStyleBackColor = False
        '
        'FrmNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(2740, 1794)
        Me.Controls.Add(Me.btnActualiser)
        Me.Controls.Add(Me.btnSupprimer)
        Me.Controls.Add(Me.btnModifier)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvNotes)
        Me.Name = "FrmNotes"
        Me.Text = "FrmNotes"
        CType(Me.dgvNotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvNotes As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAjouter As Button
    Friend WithEvents btnModifier As Button
    Friend WithEvents btnSupprimer As Button
    Friend WithEvents btnActualiser As Button
End Class
