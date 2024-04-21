'Nom du Programme: Generateur RAMQ ver.1.00, Crée par Oleksandr Dziuba gr. 1653, Tous droits réservés. © 2018
' Concepteur : Oleksandr Dziuba gr.1653
' Date de creation 20.12.2017
' Date de fin 16.01.2018
' Description : Acceptation la Loi sur l'assurance maladie et Menu avec aide

Public Class frmForm1
    ' maximum size de Label = 350

    Private Sub mnuQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuitter.Click
        ' fermer le programme
        End
    End Sub

    Private Sub mnuAPropos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAPropos.Click
        ' aller au frmApropos pour afficher information a propos de programme
        frmApropos.Show()
    End Sub

    Private Sub btnAccepte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccepte.Click
        ' aller au frmGenRAMQ
        frmGenRAMQ.Show()
        Me.Hide()
    End Sub

    Private Sub mnuAide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAide.Click
        ' aller au frmAide3 
        frmAide3.Show()
        Me.Hide()
    End Sub
End Class

