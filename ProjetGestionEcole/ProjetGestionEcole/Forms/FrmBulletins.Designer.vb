<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBulletins
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
        Me.cbEleve = New System.Windows.Forms.ComboBox()
        Me.btnGenerer = New System.Windows.Forms.Button()
        Me.txtBulletin = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cbEleve
        '
        Me.cbEleve.BackColor = System.Drawing.Color.Black
        Me.cbEleve.Font = New System.Drawing.Font("Georgia", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEleve.ForeColor = System.Drawing.Color.White
        Me.cbEleve.FormattingEnabled = True
        Me.cbEleve.Location = New System.Drawing.Point(831, 207)
        Me.cbEleve.Name = "cbEleve"
        Me.cbEleve.Size = New System.Drawing.Size(955, 40)
        Me.cbEleve.TabIndex = 0
        '
        'btnGenerer
        '
        Me.btnGenerer.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnGenerer.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerer.Location = New System.Drawing.Point(1235, 529)
        Me.btnGenerer.Name = "btnGenerer"
        Me.btnGenerer.Size = New System.Drawing.Size(197, 67)
        Me.btnGenerer.TabIndex = 1
        Me.btnGenerer.Text = "📄 Générer"
        Me.btnGenerer.UseVisualStyleBackColor = False
        '
        'txtBulletin
        '
        Me.txtBulletin.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.txtBulletin.Font = New System.Drawing.Font("Georgia", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBulletin.ForeColor = System.Drawing.Color.White
        Me.txtBulletin.Location = New System.Drawing.Point(831, 415)
        Me.txtBulletin.Name = "txtBulletin"
        Me.txtBulletin.Size = New System.Drawing.Size(955, 39)
        Me.txtBulletin.TabIndex = 2
        '
        'FrmBulletins
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjetGestionEcole.My.Resources.Resources.télécharger__7_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(2740, 1686)
        Me.Controls.Add(Me.txtBulletin)
        Me.Controls.Add(Me.btnGenerer)
        Me.Controls.Add(Me.cbEleve)
        Me.Name = "FrmBulletins"
        Me.Text = "FrmBulletins"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbEleve As ComboBox
    Friend WithEvents btnGenerer As Button
    Friend WithEvents txtBulletin As TextBox
End Class
