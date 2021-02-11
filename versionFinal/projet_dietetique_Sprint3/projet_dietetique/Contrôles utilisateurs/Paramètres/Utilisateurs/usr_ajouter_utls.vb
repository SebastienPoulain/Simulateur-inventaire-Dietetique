Imports MySql.Data.MySqlClient

Public Class usr_ajouter_utls
    'Attributs reliés à la gestion de la bd.'
    Dim strRequete As String
    Dim table As String
    Dim gestionBd As New Connexion
    Dim dataAdapter As New MySqlDataAdapter
    Dim dsUtls As DataSet
    Dim _listeUtls As usr_liste_utls

    Dim animation As New cls_animation_operation


    'Récupère le userControl de la liste d'utilisateur, pour pouvoir la mettre à jour.'
    Public Sub New(listUtls As usr_liste_utls)
        InitializeComponent()
        _listeUtls = listUtls
    End Sub


    'Ajoute les droit de l'admin.'
    Public Sub droit_admin()
        cbo_titre.Items.Clear()

        cbo_titre.Items.Add("Enseignant")
        cbo_titre.Items.Add("Étudiant")
        cbo_titre.Items.Add("Administrateur")
    End Sub

    'Ajoute les droit du prof.'
    Public Sub droit_prof()
        cbo_titre.Items.Clear()
        cbo_titre.Items.Add("Étudiant")
    End Sub




    'Récupère tous les étudiants.'
    Private Sub RecupererUtls()
        strRequete = "SELECT `no_utilisateur`, `nom_personne`, `titre` FROM `tbl_utilisateurs`;"
        table = "tbl_utilisateurs"
        gestionBd.miseAjourDS(dsUtls, dataAdapter, strRequete, table)
    End Sub






    'Ajoute un utilisateur.'
    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        Ajout()
    End Sub
    ''' <summary>
    ''' Méthode qui ajoute un utilisateur, son mot de passe est crypté avant l'insertion dans la bd (ligne 81).
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub Ajout()
        Dim succes As Boolean = True

        strRequete = "INSERT INTO `tbl_utilisateurs`(`no_utilisateur`, `prenom_personne`, `nom_personne`, `mot_de_passe`, `titre`) VALUES ('" & txt_utls.Text.Trim.ToLower &
                     "', '"

        'Ajoute le prénom de la personne s'il est saisie ou non.'
        If txt_pnm.Text.Trim <> "" Then
            strRequete &= StrConv(mod_regex.ConvertirApostrophe(txt_pnm.Text.Trim), VbStrConv.ProperCase) & "', '"
        Else
            strRequete &= txt_utls.Text.Trim & "', '"
        End If

        'Ajoute le nom de la personne s'il est saisie ou non.'
        If txt_nm.Text.Trim <> "" Then
            strRequete &= StrConv(mod_regex.ConvertirApostrophe(txt_nm.Text.Trim), VbStrConv.ProperCase) & "', '"
        Else
            strRequete &= txt_utls.Text.Trim & "', '"
        End If

        strRequete &= GetMd5Hash(txt_mdp.Text) & "', '" & TitreCourt(cbo_titre.SelectedItem) & "');"

        'Ajoute l'utilisateur.'
        Try
            gestionBd.InsDelUpd(strRequete)

        Catch ex As Exception
            succes = False
        End Try


        'Création de l'inventaire du prof.'
        If TitreCourt(cbo_titre.SelectedItem) = "p" Then
            Try
                strRequete = "INSERT INTO `tbl_inventaire` VALUES();"
                gestionBd.InsDelUpd(strRequete)
            Catch e As Exception
                succes = False
            End Try

            Dim no_inventaire As Integer

            Try
                strRequete = "select max(no_inventaire) from tbl_inventaire;"
                no_inventaire = gestionBd.Requete(strRequete)
            Catch e As Exception
                succes = False
            End Try

            Try
                strRequete = "INSERT INTO `tbl_inventaire_prof`(`no_utilisateur`, `no_inventaire`)
                             VALUES ('" & txt_utls.Text &
                             "','" & no_inventaire & "');"
                gestionBd.InsDelUpd(strRequete)
            Catch e As Exception
                succes = False
            End Try

        End If

        If succes Then
            animation.Lancement(timer_succes, lbl_ajoutSucces, "L'utilisateur a été créé.", cls_animation_operation.Reussie)
        Else
            animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de la création de l'utilisateur", cls_animation_operation.Echec)
        End If

        _listeUtls.MAJ()
        effacerTxt()
    End Sub
    '
    '
    '
    '
    '
#Region "Verification"
    'Cas où les vérifications doivent se produire.'
    Private Sub cours_TextChanged(sender As Object, e As EventArgs) Handles txt_utls.TextChanged, txt_mdp.TextChanged, txt_mdp2.TextChanged, cbo_titre.SelectedIndexChanged, txt_nm.TextChanged, txt_pnm.TextChanged
        TourVerification(sender)
    End Sub

    'Cas où les vérifications doivent se produire.'
    Private Sub cours_LostFocus(sender As Object, e As EventArgs) Handles txt_utls.LostFocus, txt_mdp.LostFocus, txt_mdp2.LostFocus, cbo_titre.LostFocus, txt_nm.LostFocus, txt_pnm.LostFocus
        TourVerification(sender)
    End Sub

    'Tour complet des vérifications.'
    Private Sub TourVerification(ctrl As Control)
        Dim verif As Integer

        Select Case ctrl.Tag
            Case "1"
                verif = VerifierUtls()

                If verif = 1 Then
                    lbE_utls.Visible = False
                ElseIf verif = -2 Then
                    lbE_utls.Visible = True
                    lbE_utls.Text = "Saisissez un nom d'utilisateur"
                ElseIf verif = -1 Then
                    lbE_utls.Visible = True
                    lbE_utls.Text = "Caractère invalide saisie"
                Else
                    lbE_utls.Visible = True
                    lbE_utls.Text = "Le nom d'utilisateur est déjà utilisé"
                End If
            Case "2"
                verif = VerifierMotDePasse()

                If verif = 1 Then
                    lbE_mdp.Visible = False
                ElseIf verif = -1 Then
                    lbE_mdp.Visible = True
                    lbE_mdp.Text = "Saisissez un mot de passe"
                Else
                    lbE_mdp.Visible = True
                    lbE_mdp.Text = "Caractère invalide saisie"
                End If
            Case "3"
                verif = VerifierMotDePasse2()

                If verif = 1 Then
                    lbE_mdp2.Visible = False
                ElseIf verif = -1 Then
                    lbE_mdp2.Visible = True
                    lbE_mdp2.Text = "Confirmer le mot de passe"
                Else
                    lbE_mdp2.Visible = True
                    lbE_mdp2.Text = "Mots de passe non correspondant"
                End If
            Case "4"
                If VerifierTitre() Then
                    lbE_titre.Visible = False
                Else
                    lbE_titre.Visible = True
                End If
            Case "5"
                If VerifierNom() Then
                    lbE_nm.Visible = False
                Else
                    lbE_nm.Visible = True
                End If
            Case "6"
                If VerifierPrenom() Then
                    lblE_pnm.Visible = False
                Else
                    lblE_pnm.Visible = True
                End If
        End Select

        If VerifierUtls() = 1 Then
            If VerifierMotDePasse() = 1 Then
                If VerifierMotDePasse2() = 1 Then
                    If VerifierTitre() Then
                        If VerifierNom() Then
                            If VerifierPrenom() Then
                                btn_ajouter.Enabled = True
                                Return
                            End If
                        End If
                    End If
                End If
            End If
        End If

        btn_ajouter.Enabled = False
    End Sub

    'Vérification du nom d'utilisateur.'
    Private Function VerifierUtls() As Integer
        If txt_utls.Text.Trim <> "" Then
            If mod_regex.Utls(txt_utls.Text) Then
                RecupererUtls()
                Dim i As Integer = 0
                Dim utls_trouver As Boolean

                With dsUtls.Tables(0)
                    While i < .Rows.Count And utls_trouver = False
                        If (txt_utls.Text = .Rows(i).Item(0)) Then
                            utls_trouver = True
                        Else
                            i += 1
                        End If
                    End While
                End With

                If utls_trouver Then
                    Return 0
                Else Return 1
                End If

            Else
                Return -1
            End If
        End If
        Return -2
    End Function

    'Vérification nom.'
    Private Function VerifierNom() As Boolean
        If txt_nm.Text <> "" Then
            Return mod_regex.Nom(txt_nm.Text)
        Else
            Return True
        End If
    End Function

    'Vérification nom.'
    Private Function VerifierPrenom() As Boolean
        If txt_pnm.Text <> "" Then
            Return mod_regex.Nom(txt_pnm.Text)
        Else
            Return True
        End If
    End Function


    'Vérification du mot de passe.'
    Private Function VerifierMotDePasse() As Integer
        If txt_mdp.Text.Trim <> "" Then
            If mod_regex.Utls(txt_mdp.Text) Then
                Return 1
            Else
                Return 0
            End If
        End If
        Return -1
    End Function

    'Vérification du mot de passe 2.'
    Private Function VerifierMotDePasse2() As Integer
        If txt_mdp2.Text.Trim <> "" Then
            If txt_mdp2.Text = txt_mdp.Text Then
                Return 1
            Else
                Return 0
            End If
        End If
        Return -1
    End Function

    'Vérification du titre.'
    Private Function VerifierTitre() As Boolean
        Return cbo_titre.SelectedIndex <> -1
    End Function
#End Region
    '
    '
    '
    '
    '
#Region "autres"

    'Timer pour l'ajout réussie ou non.'
    Private Sub timer_succes_Tick(sender As Timer, e As EventArgs) Handles timer_succes.Tick
        animation.Operation(sender, lbl_ajoutSucces)
    End Sub

    'Transforme le titre long du cbo vers un titre court.'
    Private Function TitreCourt(titre As String)
        Select Case titre
            Case "Enseignant"
                Return "p"
            Case "Étudiant"
                Return "e"
            Case "Administrateur"
                Return "a"
            Case Else
                Return "e"
        End Select
    End Function

    'Efface le texte des controles.'
    Private Sub effacerTxt()
        txt_nm.Text = ""
        txt_pnm.Text = ""
        txt_utls.Text = ""
        txt_mdp.Text = ""
        txt_mdp2.Text = ""
        cbo_titre.SelectedIndex = -1

        lbE_mdp.Visible = False
        lbE_mdp2.Visible = False
        lbE_nm.Visible = False
        lbE_titre.Visible = False
        lbE_utls.Visible = False
    End Sub

    'Couleur du bouton créer.'
    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btn_ajouter.MouseEnter
        sender.BackColor = Color.White
        sender.ForeColor = Color.Black
    End Sub

    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btn_ajouter.MouseLeave
        sender.BackColor = Color.FromArgb(52, 73, 94)
        sender.ForeColor = SystemColors.Control
    End Sub

    'Lance l'ajout quand on appuis sur enter.'
    Private Sub txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_utls.KeyPress, txt_nm.KeyPress, txt_mdp.KeyPress, txt_mdp2.KeyPress, cbo_titre.KeyPress
        If e.KeyChar = Chr(13) Then
            If btn_ajouter.Enabled = True Then
                Ajout()
            End If
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
#End Region
End Class
