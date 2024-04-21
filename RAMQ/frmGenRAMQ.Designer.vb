<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenRAMQ
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
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.radHomme = New System.Windows.Forms.RadioButton()
        Me.radFemme = New System.Windows.Forms.RadioButton()
        Me.grbSexe = New System.Windows.Forms.GroupBox()
        Me.updAnee = New System.Windows.Forms.NumericUpDown()
        Me.updMois = New System.Windows.Forms.NumericUpDown()
        Me.updJour = New System.Windows.Forms.NumericUpDown()
        Me.lblAnee = New System.Windows.Forms.Label()
        Me.lblMois = New System.Windows.Forms.Label()
        Me.lblJour = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumeroAssurance = New System.Windows.Forms.TextBox()
        Me.btnGenere = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.btnEffacer = New System.Windows.Forms.Button()
        Me.grbSexe.SuspendLayout()
        CType(Me.updAnee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updMois, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updJour, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNom
        '
        Me.txtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNom.Location = New System.Drawing.Point(45, 46)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(130, 20)
        Me.txtNom.TabIndex = 0
        '
        'txtPrenom
        '
        Me.txtPrenom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrenom.Location = New System.Drawing.Point(45, 94)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(130, 20)
        Me.txtPrenom.TabIndex = 1
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(49, 30)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(29, 13)
        Me.lblNom.TabIndex = 2
        Me.lblNom.Text = "Nom"
        '
        'lblPrenom
        '
        Me.lblPrenom.AutoSize = True
        Me.lblPrenom.Location = New System.Drawing.Point(49, 78)
        Me.lblPrenom.Name = "lblPrenom"
        Me.lblPrenom.Size = New System.Drawing.Size(43, 13)
        Me.lblPrenom.TabIndex = 3
        Me.lblPrenom.Text = "Prenom"
        '
        'radHomme
        '
        Me.radHomme.AutoSize = True
        Me.radHomme.Checked = True
        Me.radHomme.Location = New System.Drawing.Point(25, 26)
        Me.radHomme.Name = "radHomme"
        Me.radHomme.Size = New System.Drawing.Size(61, 17)
        Me.radHomme.TabIndex = 4
        Me.radHomme.TabStop = True
        Me.radHomme.Text = "Homme"
        Me.radHomme.UseVisualStyleBackColor = True
        '
        'radFemme
        '
        Me.radFemme.AutoSize = True
        Me.radFemme.Location = New System.Drawing.Point(96, 26)
        Me.radFemme.Name = "radFemme"
        Me.radFemme.Size = New System.Drawing.Size(59, 17)
        Me.radFemme.TabIndex = 5
        Me.radFemme.Text = "Femme"
        Me.radFemme.UseVisualStyleBackColor = True
        '
        'grbSexe
        '
        Me.grbSexe.Controls.Add(Me.radFemme)
        Me.grbSexe.Controls.Add(Me.radHomme)
        Me.grbSexe.Location = New System.Drawing.Point(21, 130)
        Me.grbSexe.Name = "grbSexe"
        Me.grbSexe.Size = New System.Drawing.Size(175, 68)
        Me.grbSexe.TabIndex = 6
        Me.grbSexe.TabStop = False
        Me.grbSexe.Text = "Sexe"
        '
        'updAnee
        '
        Me.updAnee.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.updAnee.Location = New System.Drawing.Point(117, 217)
        Me.updAnee.Maximum = New Decimal(New Integer() {2018, 0, 0, 0})
        Me.updAnee.Minimum = New Decimal(New Integer() {1920, 0, 0, 0})
        Me.updAnee.Name = "updAnee"
        Me.updAnee.Size = New System.Drawing.Size(47, 20)
        Me.updAnee.TabIndex = 7
        Me.updAnee.Value = New Decimal(New Integer() {1990, 0, 0, 0})
        '
        'updMois
        '
        Me.updMois.Location = New System.Drawing.Point(117, 252)
        Me.updMois.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.updMois.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.updMois.Name = "updMois"
        Me.updMois.Size = New System.Drawing.Size(47, 20)
        Me.updMois.TabIndex = 8
        Me.updMois.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'updJour
        '
        Me.updJour.Location = New System.Drawing.Point(117, 290)
        Me.updJour.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.updJour.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.updJour.Name = "updJour"
        Me.updJour.Size = New System.Drawing.Size(47, 20)
        Me.updJour.TabIndex = 9
        Me.updJour.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblAnee
        '
        Me.lblAnee.AutoSize = True
        Me.lblAnee.Location = New System.Drawing.Point(60, 224)
        Me.lblAnee.Name = "lblAnee"
        Me.lblAnee.Size = New System.Drawing.Size(38, 13)
        Me.lblAnee.TabIndex = 10
        Me.lblAnee.Text = "Année"
        '
        'lblMois
        '
        Me.lblMois.AutoSize = True
        Me.lblMois.Location = New System.Drawing.Point(63, 259)
        Me.lblMois.Name = "lblMois"
        Me.lblMois.Size = New System.Drawing.Size(29, 13)
        Me.lblMois.TabIndex = 11
        Me.lblMois.Text = "Mois"
        '
        'lblJour
        '
        Me.lblJour.AutoSize = True
        Me.lblJour.Location = New System.Drawing.Point(65, 297)
        Me.lblJour.Name = "lblJour"
        Me.lblJour.Size = New System.Drawing.Size(27, 13)
        Me.lblJour.TabIndex = 12
        Me.lblJour.Text = "Jour"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(239, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Votre numéro d'assurance "
        '
        'txtNumeroAssurance
        '
        Me.txtNumeroAssurance.Location = New System.Drawing.Point(242, 94)
        Me.txtNumeroAssurance.MaxLength = 12
        Me.txtNumeroAssurance.Name = "txtNumeroAssurance"
        Me.txtNumeroAssurance.Size = New System.Drawing.Size(150, 20)
        Me.txtNumeroAssurance.TabIndex = 14
        '
        'btnGenere
        '
        Me.btnGenere.Location = New System.Drawing.Point(254, 180)
        Me.btnGenere.Name = "btnGenere"
        Me.btnGenere.Size = New System.Drawing.Size(137, 37)
        Me.btnGenere.TabIndex = 15
        Me.btnGenere.Text = "Généré"
        Me.btnGenere.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(363, 309)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(75, 23)
        Me.btnQuitter.TabIndex = 16
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'btnEffacer
        '
        Me.btnEffacer.Location = New System.Drawing.Point(266, 309)
        Me.btnEffacer.Name = "btnEffacer"
        Me.btnEffacer.Size = New System.Drawing.Size(75, 23)
        Me.btnEffacer.TabIndex = 17
        Me.btnEffacer.Text = "Effacer"
        Me.btnEffacer.UseVisualStyleBackColor = True
        '
        'frmGenRAMQ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 344)
        Me.Controls.Add(Me.btnEffacer)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnGenere)
        Me.Controls.Add(Me.txtNumeroAssurance)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblJour)
        Me.Controls.Add(Me.lblMois)
        Me.Controls.Add(Me.lblAnee)
        Me.Controls.Add(Me.updJour)
        Me.Controls.Add(Me.updMois)
        Me.Controls.Add(Me.updAnee)
        Me.Controls.Add(Me.grbSexe)
        Me.Controls.Add(Me.lblPrenom)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.txtPrenom)
        Me.Controls.Add(Me.txtNom)
        Me.Name = "frmGenRAMQ"
        Me.Text = "Générateur RAMQ"
        Me.grbSexe.ResumeLayout(False)
        Me.grbSexe.PerformLayout()
        CType(Me.updAnee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updMois, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updJour, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents txtPrenom As System.Windows.Forms.TextBox
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents lblPrenom As System.Windows.Forms.Label
    Friend WithEvents radHomme As System.Windows.Forms.RadioButton
    Friend WithEvents radFemme As System.Windows.Forms.RadioButton
    Friend WithEvents grbSexe As System.Windows.Forms.GroupBox
    Friend WithEvents updAnee As System.Windows.Forms.NumericUpDown
    Friend WithEvents updMois As System.Windows.Forms.NumericUpDown
    Friend WithEvents updJour As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblAnee As System.Windows.Forms.Label
    Friend WithEvents lblMois As System.Windows.Forms.Label
    Friend WithEvents lblJour As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroAssurance As System.Windows.Forms.TextBox
    Friend WithEvents btnGenere As System.Windows.Forms.Button
    Friend WithEvents btnQuitter As System.Windows.Forms.Button
    Friend WithEvents btnEffacer As System.Windows.Forms.Button
End Class
