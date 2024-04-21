<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAide3
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnQuitterAide = New System.Windows.Forms.Button()
        Me.lblAide1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lblAide2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnQuitterAide
        '
        Me.btnQuitterAide.Location = New System.Drawing.Point(42, 203)
        Me.btnQuitterAide.Name = "btnQuitterAide"
        Me.btnQuitterAide.Size = New System.Drawing.Size(182, 50)
        Me.btnQuitterAide.TabIndex = 0
        Me.btnQuitterAide.Text = "Quitter"
        Me.btnQuitterAide.UseVisualStyleBackColor = True
        '
        'lblAide1
        '
        Me.lblAide1.AutoSize = True
        Me.lblAide1.Location = New System.Drawing.Point(39, 24)
        Me.lblAide1.MaximumSize = New System.Drawing.Size(250, 0)
        Me.lblAide1.Name = "lblAide1"
        Me.lblAide1.Size = New System.Drawing.Size(197, 26)
        Me.lblAide1.TabIndex = 1
        Me.lblAide1.Text = "Pour verifier votre admissibilité au régime d'assurance maladie il faut visiter: " & _
            ""
        Me.lblAide1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(64, 69)
        Me.LinkLabel1.MaximumSize = New System.Drawing.Size(250, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(145, 13)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "http://www.ramq.gouv.qc.ca"
        '
        'lblAide2
        '
        Me.lblAide2.AutoSize = True
        Me.lblAide2.Location = New System.Drawing.Point(24, 104)
        Me.lblAide2.MaximumSize = New System.Drawing.Size(250, 0)
        Me.lblAide2.MinimumSize = New System.Drawing.Size(250, 0)
        Me.lblAide2.Name = "lblAide2"
        Me.lblAide2.Size = New System.Drawing.Size(250, 39)
        Me.lblAide2.TabIndex = 3
        Me.lblAide2.Text = "Pour generer le code RAMQ il faut ecrire votre Nom, Prenom et date de naissanse e" & _
            "t cliquer sur boutton Généré"
        '
        'frmAide3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 265)
        Me.Controls.Add(Me.lblAide2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lblAide1)
        Me.Controls.Add(Me.btnQuitterAide)
        Me.Name = "frmAide3"
        Me.Text = "Aide"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnQuitterAide As System.Windows.Forms.Button
    Friend WithEvents lblAide1 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents lblAide2 As System.Windows.Forms.Label
End Class
