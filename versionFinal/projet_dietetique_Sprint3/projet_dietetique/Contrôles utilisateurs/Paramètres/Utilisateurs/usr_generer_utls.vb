Imports MySql.Data.MySqlClient

Public Class usr_generer_utls
    'Attributs reliés à la gestion de la bd.'
    Dim strRequete As String
    Dim table As String
    Dim gestionBd As New Connexion
    Dim dataAdapter As New MySqlDataAdapter
    Dim dsUtls As DataSet
    Dim gen As New Random
    Dim _listeUtls As usr_liste_utls
    Dim _usr_menu As usr_gestion_MenuUtls

    Dim animation As New cls_animation_operation

    'Récupère le userControl de la liste d'utilisateur, pour pouvoir la mettre à jour.'
    Public Sub New(usr_menuUtls As usr_gestion_MenuUtls, listUtls As usr_liste_utls)
        InitializeComponent()
        _listeUtls = listUtls
        _usr_menu = usr_menuUtls
    End Sub

    'Ajoute les droit de l'admin.'
    Public Sub droit_admin()
        cbo_titre.Items.Clear()

        cbo_titre.Items.Add("Enseignants")
        cbo_titre.Items.Add("Étudiants")
    End Sub

    'Ajoute les droit du prof.'
    Public Sub droit_prof()
        cbo_titre.Items.Clear()
        cbo_titre.Items.Add("Étudiants")
    End Sub





    'Récupère tous les étudiants.'
    Private Sub RecupererUtls()
        strRequete = "SELECT `no_utilisateur`, `nom_personne`, `titre` FROM `tbl_utilisateurs`;"
        table = "tbl_utilisateurs"
        gestionBd.miseAjourDS(dsUtls, dataAdapter, strRequete, table)
    End Sub

    'Génère les utilisateurs.'
    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        Ajout()
    End Sub


    ''' <summary>
    ''' Méthode qui  génère les utilisateurs, les mots de passe sont encryptés. (ligne 75)
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub Ajout()
        Dim DebutNb As Integer = TrouverIncrement()
        Dim echec As String = ""
        Dim listUtls As New List(Of Utilisateur)
        Dim mdp As String
        Dim succes As Boolean = True

        Cursor = Cursors.AppStarting
        For i As Integer = DebutNb To DebutNb + nud_nbUtls.Value - 1
            mdp = mod_function_utls.GenererMdp

            listUtls.Add(New Utilisateur(txt_utls.Text & i.ToString.PadLeft(4, "0"), txt_utls.Text & i.ToString.PadLeft(4, "0"), txt_utls.Text & i.ToString.PadLeft(4, "0"), mdp, TitreCourt(cbo_titre.SelectedItem), cbo_titre.SelectedItem))

            strRequete = "INSERT INTO `tbl_utilisateurs`(`no_utilisateur`, `prenom_personne`, `nom_personne`, `mot_de_passe`,`titre`) VALUES 
                    ('" & txt_utls.Text.Trim.ToLower & i.ToString.PadLeft(4, "0") &   'Nm utls'
                    "','" & txt_utls.Text & i.ToString.PadLeft(4, "0") & 'Prenom'
                    "','" & txt_utls.Text & i.ToString.PadLeft(4, "0") & 'Nom'
                    "','" & GetMd5Hash(mod_function_utls.GenererMdp) &               'MDP'
                    "','" & TitreCourt(cbo_titre.SelectedItem) & "');"   'Titre'

            Try
                gestionBd.InsDelUpd(strRequete)
            Catch ex As Exception
                echec &= txt_utls.Text & i.ToString.PadLeft(4, "0")
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de la création des utilisateurs.", cls_animation_operation.Echec)
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
                             VALUES ('" & txt_utls.Text & i.ToString.PadLeft(4, "0") &
                                 "','" & no_inventaire & "');"
                    gestionBd.InsDelUpd(strRequete)
                Catch e As Exception
                    succes = False
                End Try

            End If




        Next

        Cursor = Cursors.Default

        If echec = "" Or succes = False Then
            animation.Lancement(timer_succes, lbl_ajoutSucces, "Les utilisateurs ont été créés.", cls_animation_operation.Reussie)
            _listeUtls.MAJ()
            AfficherUtls(listUtls)
        Else
            animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de la création des utilisateurs.", cls_animation_operation.Echec)
            Debug.WriteLine("Erreur sur : " & echec)
        End If

        EffacerTxt()
    End Sub

    Private Sub AfficherUtls(list As List(Of Utilisateur))
        Dim usr_vMdp As New usr_nouveau_mdp(list)
        _usr_menu.pnl_listeUtls.Controls.Add(usr_vMdp)
        usr_vMdp.Dock = DockStyle.Fill
        usr_vMdp.BringToFront()

        _usr_menu.VerticalScroll.Value = _usr_menu.VerticalScroll.Minimum
        _listeUtls.Focus()
    End Sub



    'Cherche si le nom commun existe déjà dans la liste des utilisateurs et si oui détermine à quel incrément il est rendu.'
    Private Function TrouverIncrement() As Integer
        RecupererUtls()

        Dim i As Integer = 0
        Dim nm_existe As Boolean = False
        Dim incrementationNom As Integer = 1

        'Recherche si le début d'utilisateur existe déjà (Et possède des chiffres).'
        With dsUtls.Tables(0)
            While i < .Rows.Count And nm_existe = False
                If mod_regex.RgxVariable(.Rows(i).Item(0), "^(" & txt_utls.Text & ")[0-9]+$") Then
                    nm_existe = True
                Else
                    i += 1
                End If
            End While
        End With


        If nm_existe Then
            'Trouve le dernier incrément.'
            Try
                incrementationNom = gestionBd.Requete("SELECT substr(max(`no_utilisateur`)," & txt_utls.Text.Length + 1 & ", 4) FROM `tbl_utilisateurs` WHERE `no_utilisateur` REGEXP '^(" & txt_utls.Text & ")[0-9]+$'")
            Catch ex As Exception

            End Try

            incrementationNom += 1
        End If

        Return incrementationNom
    End Function

#Region "Verification"
    'Cas où les vérifications doivent se produire.'
    Private Sub cours_TextChanged(sender As Object, e As EventArgs) Handles txt_utls.TextChanged, cbo_titre.SelectedIndexChanged
        TourVerification(sender)
    End Sub

    'Cas où les vérifications doivent se produire.'
    Private Sub cours_LostFocus(sender As Object, e As EventArgs) Handles txt_utls.LostFocus, cbo_titre.LostFocus
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
                ElseIf verif = -1 Then
                    lbE_utls.Visible = True
                    lbE_utls.Text = "Saisissez un nom d'utilisateur"
                Else
                    lbE_utls.Visible = True
                    lbE_utls.Text = "Caractère invalide saisie"
                End If
            Case "2"
                If VerifierTitre() Then
                    lbE_titre.Visible = False
                Else
                    lbE_titre.Visible = True
                End If
        End Select

        If VerifierUtls() = 1 Then
            If VerifierTitre() Then
                btn_ajouter.Enabled = True
                Return
            End If
        End If

        btn_ajouter.Enabled = False
    End Sub

    'Vérification du nom d'utilisateur.'
    Private Function VerifierUtls() As Integer
        If txt_utls.Text.Trim <> "" Then
            If mod_regex.Utls_2(txt_utls.Text) Then
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

#Region "Autres"
    'Transforme le titre long du cbo vers un titre court.'
    Private Function TitreCourt(titre As String)
        Select Case titre
            Case "Enseignants"
                Return "p"
            Case "Étudiants"
                Return "e"
            Case "Administrateurs"
                Return "a"
            Case Else
                Return "e"
        End Select
    End Function

    'Timer pour l'ajout réussie.'
    Private Sub timer_succes_Tick(sender As Object, e As EventArgs) Handles timer_succes.Tick
        animation.Operation(sender, lbl_ajoutSucces)
    End Sub



    Private Sub EffacerTxt()
        txt_utls.Text = ""
        cbo_titre.SelectedIndex = -1
        nud_nbUtls.Value = 1

        lbE_titre.Visible = False
        lbE_utls.Visible = False
    End Sub

    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btn_ajouter.MouseEnter
        sender.BackColor = Color.White
        sender.ForeColor = Color.Black
    End Sub

    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btn_ajouter.MouseLeave
        sender.BackColor = Color.FromArgb(52, 73, 94)
        sender.ForeColor = SystemColors.Control
    End Sub

    'Lance l'ajout si on appuie sur enter.'
    Private Sub txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_utls.KeyPress, cbo_titre.KeyPress, nud_nbUtls.KeyPress
        If e.KeyChar = Chr(13) Then
            If btn_ajouter.Enabled = True Then
                Ajout()
            End If
        End If
    End Sub

    Private Sub btn_MouseEnter(sender As Object, e As EventArgs) Handles btn_ajouter.MouseEnter

    End Sub

    Private Sub btn_MouseLeave(sender As Object, e As EventArgs) Handles btn_ajouter.MouseLeave

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

#End Region

End Class
