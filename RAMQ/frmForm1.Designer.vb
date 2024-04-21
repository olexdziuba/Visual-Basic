<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForm1
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
        Me.btnAccepte = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAPropos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAide = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuQuitter = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAccepte
        '
        Me.btnAccepte.Location = New System.Drawing.Point(91, 109)
        Me.btnAccepte.Name = "btnAccepte"
        Me.btnAccepte.Size = New System.Drawing.Size(202, 48)
        Me.btnAccepte.TabIndex = 0
        Me.btnAccepte.Text = "J’accepte"
        Me.btnAccepte.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.MaximumSize = New System.Drawing.Size(350, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(348, 45)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pour obtenir code RAMQ vous devez accepter que vous êtes la personne admissible e" & _
            "t emplissez les conditions prévues dans la Loi sur l'assurance maladie"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(377, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuMenuItem
        '
        Me.mnuMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAPropos, Me.mnuAide, Me.mnuQuitter})
        Me.mnuMenuItem.Name = "mnuMenuItem"
        Me.mnuMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.mnuMenuItem.Text = "Menu"
        '
        'mnuAPropos
        '
        Me.mnuAPropos.Name = "mnuAPropos"
        Me.mnuAPropos.Size = New System.Drawing.Size(152, 22)
        Me.mnuAPropos.Text = "?"
        '
        'mnuAide
        '
        Me.mnuAide.Name = "mnuAide"
        Me.mnuAide.Size = New System.Drawing.Size(152, 22)
        Me.mnuAide.Text = "Aide"
        '
        'mnuQuitter
        '
        Me.mnuQuitter.Name = "mnuQuitter"
        Me.mnuQuitter.Size = New System.Drawing.Size(152, 22)
        Me.mnuQuitter.Text = "Quitter"
        '
        'frmForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(377, 188)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAccepte)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmForm1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Générateur RAMQ"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAccepte As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAPropos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAide As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuQuitter As System.Windows.Forms.ToolStripMenuItem

End Class
