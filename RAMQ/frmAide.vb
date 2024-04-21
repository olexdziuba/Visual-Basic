'Nom du Programme: Generateur RAMQ ver.1.00, Crée par Oleksandr Dziuba gr. 1653, Tous droits réservés. © 2018
' Concepteur : Oleksandr Dziuba gr.1653
' Date de creation 20.12.2017
' Date de fin 16.01.2018
' Description : Ce programme affiche  admissibilité au régime d'assurance maladie  
Public Class frmAide3
    Dim strUrl As String = "http://www.ramq.gouv.qc.ca/fr/citoyens/assurance-maladie/inscription/Pages/admissibilite.aspx"


    Private Sub btnQuitterAide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitterAide.Click
        ' aller au formular 1 
        frmForm1.Show()
        Me.Hide()
    End Sub



    Private Sub LinkLabel1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LinkLabel1.MouseClick
        ' aller au URL
        Process.Start(strUrl)

    End Sub

End Class
' maximum size de Label = 250