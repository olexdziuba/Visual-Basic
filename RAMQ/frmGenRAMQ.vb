'Nom du Programme: Generateur RAMQ ver.1.00, Tous droits réservés  © 2018
' Concepteur : Oleksandr Dziuba gr. 1653
' Date de creation 20.12.2017
' Date de fin 16.01.2018
' Description : Ce programme permet de generer le code RAMQ
Public Class frmGenRAMQ
    '@@@@@LES VARIABLES@@@@
    'les variables pour les informations saisies par l'utilisateur
    Dim strNom As String 'pour Nom
    Dim strPrenom As String 'pour prenom
    Dim strAnee As String 'pour Annee
    Dim strMois As String 'pour Mois
    Dim strJour As String 'pour jour
    ' le variable pour code administrativ 
    Dim intAdmin As Integer
    'les variables pour verification de longueur des mots
    Dim intNomLong As Integer
    Dim intPrenomLong As Integer
    'les variables pour verification les symbols dans le Nom et prenoms
    Dim strVerNom As String 'pour Nom
    Dim strVerPrenom As String 'pour prenom
    'les variables pour les lettres acceptables avec lettres acceptables 
    Dim strlistOfLetters As String() = New String() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "-", "É", "È", "Ù", "Ô", " "}
    ' variable pour eviter generation le code si Nom ou Prenom ou date n'est pas valide
    Dim intX As Integer
    'variable pour calculer Bissextile 
    Dim intAnee As Integer
    Dim intBis As Integer


    Private Sub btnGenere_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenere.Click

        '!!!######Generation le code RAMQ####!!!

        ' ######Saisir les donees######
        intNomLong = Len(txtNom.Text) ' saisir longueur de Nom
        intPrenomLong = Len(txtPrenom.Text) ' saisir longueur de Prenom
        strNom = Mid(txtNom.Text, 1, 3) 'saisir 1-3 symbols de Nom
        strPrenom = Mid(txtPrenom.Text, 1, 1) ' saisir 1 simbol de Prenom
        strAnee = updAnee.Value 'saisir Annee
        strMois = updMois.Value 'saisir Mois
        strJour = updJour.Value 'saisir Jour
        intX = 1

        '######Verification des donees######


        ' --verification  Nom--  
        'verification minimum 3 symboles
        If intNomLong < 3 Then
            MsgBox("Vous devez écrire votre nom au complet, Votre nom doit avoir minimum 3 symboles", vbExclamation + vbOKOnly, "Error")
            intX = 2
            'verification si nom a seulement symbols numerique
        ElseIf IsNumeric(strNom) Then
            MsgBox("Votre nom est n'est pas valide. Nom ne doit pas avoir symbol nymerique", vbExclamation + vbOKOnly, "Error")
            intX = 2
        End If

        ''verifier si il y a les chifres en Nom 
        If (txtNom.Text <> "") Then
            strVerNom = txtNom.Text
            For Each letter In strlistOfLetters
                strVerNom = Replace(strVerNom, letter, "")
            Next
            ' parcourir chaque lettre du  'listOfLetters' et remplacer cette lettre par rien Si les symbols restent - ce sont symbols qui ne sont pas accepteble

            If (strVerNom <> "") Then
                MsgBox("Votre nom n'est pas valide. Votre nom  doit  avoir seulement les symboles alphabétiques!", vbExclamation + vbOKOnly, "Error")
                intX = 2
            End If

        End If

        ' --verification   Prenom --
        'verification minimum 3 symboles
        If intPrenomLong < 3 Then
            MsgBox("Vous devez écrire votre prénom au complet, Votre prénom doit avoir minimum 3 symboles", vbExclamation + vbOKOnly, "Error")
            intX = 2
            'verification si prenom a seulement symbols numerique
        ElseIf IsNumeric(strPrenom) Then
            MsgBox("Votre prénom  n'est pas valide. Prénom ne doit pas avoir symbol nymerique", vbExclamation + vbOKOnly, "Error")
            intX = 2
        End If

        ''verifier si il y a les chifres dans le prenom
        If (txtPrenom.Text <> "") Then

            strVerPrenom = txtPrenom.Text



            For Each letter In strlistOfLetters
                strVerPrenom = Replace(strVerPrenom, letter, "")
                ' parcourir chaque lettre du  'listOfLetters' et remplacer cette lettre par rien Si les symbols restent - ce sont symbols qui ne sont pas accepteble
            Next


            If (strVerPrenom <> "") Then
                MsgBox("Votre prénom est n'est pas valide. Votre prénom  doit  avoir seulement les symboles alphabétiques!", vbExclamation + vbOKOnly, "Error")
                intX = 2
            End If

        End If




        '--verification anee--
        If strAnee = 1919 Then
            MsgBox("Votre Anee de naissanse  n'est pas valide. ", vbExclamation + vbOKOnly, "Error")
            intX = 2
        End If
        ''verification si une année donnée est bissextile ou non
        intAnee = strAnee
        If (intAnee Mod 4 = 0) And (intAnee Mod 100 <> 0) Or (intAnee Mod 400 = 0) Then
            intBis = 1 ' annee est bissextile
        Else

            intBis = 2 ' annee n'est pas bissextile
        End If
        '--verification quantite jour en février --
        If intBis = 1 And CInt(strMois) = 2 And CInt(strJour) > 29 Then
            intX = 2
            MsgBox("Votre Jour de naissanse  n'est pas valide. Le mois février doit avoir maximun 29  jours", vbExclamation + vbOKOnly, "Error")
        End If
        If intBis = 2 And CInt(strMois) = 2 And CInt(strJour) > 28 Then

            intX = 2
            MsgBox("Votre Jour de naissanse  n'est pas valide. Le mois février doit avoir maximun 28  jours", vbExclamation + vbOKOnly, "Error")

        End If

        ' verification janvier, Mars, Mai, Juillet, Aout, Octobre, Décembre
        Select Case strMois
            Case 1, 3, 5, 7, 8, 10, 12
                If CInt(strJour) > 31 Then
                    MsgBox("Votre Jour de naissanse  n'est pas valide. Les mois janvier, Mars, Mai, Juillet, Aout, Octobre, Décembre doivent avoir maximum 31 jours", vbExclamation + vbOKOnly, "Error")
                    intX = 2
                End If

                ' verification Avril, Juin, Septembre, Novembre
            Case 4, 6, 9, 11
                If CInt(strJour) > 30 Then
                    intX = 2
                    MsgBox("Votre Jour de naissanse  n'est pas valide. Les mois Avril, Juin, Septembre, Novembre doivent avoir maximum 30 jours ", vbExclamation + vbOKOnly, "Error")
                End If
                ' verification février
            Case 2
                If CInt(strJour) > 29 Then
                    intX = 2
                    MsgBox("Votre Jour de naissanse  n'est pas valide. LLe mois février doit avoir 28  ou  29 jours ", vbExclamation + vbOKOnly, "Error")
                End If

        End Select





        '' -calculation mois pour femme-
        If radFemme.Checked = True Then
            strMois = strMois + 50
        End If
        ''-calculation anee-
        If strAnee < 2000 Then
            strAnee = strAnee - 1900
        Else
            strAnee = strAnee - 2000

        End If





        ' -generation code administrativ-
        intAdmin = Int(Rnd() * 99) + 1
        'si code a 1 chiffre on ajoute 10 pour avoir 2
        If intAdmin < 10 Then
            intAdmin = intAdmin + 10
        End If
        '-Affichage RAMQ-
        'si mois ou jour est <10, on ajout 10

        If intX = 1 Then
            If strJour < 10 And strMois < 10 And strAnee < 10 Then
                txtNumeroAssurance.Text = strNom & strPrenom & "0" & strAnee & "0" & strMois & "0" & strJour & intAdmin
                txtNom.Text = ""
                txtPrenom.Text = ""
                txtPrenom.Text = ""
                updAnee.Value = 1990
                updJour.Value = 1
                updMois.Value = 1
            ElseIf strJour < 10 And strMois < 10 Then
                txtNumeroAssurance.Text = strNom & strPrenom & strAnee & "0" & strMois & "0" & strJour & intAdmin
                txtNom.Text = ""
                txtPrenom.Text = ""
                txtPrenom.Text = ""
                updAnee.Value = 1990
                updJour.Value = 1
                updMois.Value = 1
            ElseIf strJour < 10 And strAnee < 10 Then
                txtNumeroAssurance.Text = strNom & strPrenom & "0" & strAnee & strMois & "0" & strJour & intAdmin
                txtNom.Text = ""
                txtPrenom.Text = ""
                txtPrenom.Text = ""
                updAnee.Value = 1990
                updJour.Value = 1
                updMois.Value = 1
            ElseIf strMois < 10 And strAnee < 10 Then
                txtNumeroAssurance.Text = strNom & strPrenom & "0" & strAnee & "0" & strMois & strJour & intAdmin
                txtNom.Text = ""
                txtPrenom.Text = ""
                txtPrenom.Text = ""
                updAnee.Value = 1990
                updJour.Value = 1
                updMois.Value = 1
            ElseIf strJour < 10 Then
                txtNumeroAssurance.Text = strNom & strPrenom & strAnee & strMois & "0" & strJour & intAdmin
                txtNom.Text = ""
                txtPrenom.Text = ""
                txtPrenom.Text = ""
                updAnee.Value = 1990
                updJour.Value = 1
                updMois.Value = 1
            ElseIf strMois < 10 Then
                txtNumeroAssurance.Text = strNom & strPrenom & strAnee & "0" & strMois & strJour & intAdmin
                txtNom.Text = ""
                txtPrenom.Text = ""
                txtPrenom.Text = ""
                updAnee.Value = 1990
                updJour.Value = 1
                updMois.Value = 1
            ElseIf strAnee < 10 Then
                txtNumeroAssurance.Text = strNom & strPrenom & "0" & strAnee & strMois & strJour & intAdmin
                txtNom.Text = ""
                txtPrenom.Text = ""
                txtPrenom.Text = ""
                updAnee.Value = 1990
                updJour.Value = 1
                updMois.Value = 1
            Else
                txtNumeroAssurance.Text = strNom & strPrenom & strAnee & strMois & strJour & intAdmin
                txtNom.Text = ""
                txtPrenom.Text = ""
                txtPrenom.Text = ""
                updAnee.Value = 1990
                updJour.Value = 1
                updMois.Value = 1
            End If
        Else
            ' effacer les donnees 
            txtNom.Text = ""
            txtPrenom.Text = ""
            txtPrenom.Text = ""

            updAnee.Value = 1990
            updJour.Value = 1
            updMois.Value = 1


        End If




    End Sub



    Private Sub btnQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitter.Click
        ' fermer la programme 
        End
    End Sub



    Private Sub btnEffacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEffacer.Click
        ' effacer les donnees 
        txtNom.Text = ""
        txtPrenom.Text = ""
        txtPrenom.Text = ""
        txtNumeroAssurance.Text = ""
        updAnee.Value = 1990
        updJour.Value = 1
        updMois.Value = 1
    End Sub
End Class