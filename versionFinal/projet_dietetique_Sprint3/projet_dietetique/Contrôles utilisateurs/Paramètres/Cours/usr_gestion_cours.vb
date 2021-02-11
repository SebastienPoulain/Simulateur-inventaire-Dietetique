Imports System.IO
Imports MySql.Data.MySqlClient


Public Class usr_gestion_cours
    'Attributs reliés à la gestion de la bd.'
    Dim strRequete As String
    Dim table As String
    Dim gestionBd As New Connexion
    Dim dataAdapter As New MySqlDataAdapter
    Dim dsCours As DataSet
    Dim dsUtls As DataSet
    Dim index As Integer

    'Attribut relié à la modification.'
    Dim noCoursTemp, NoProfTemp As String

    'Attibut relié aux diverses vérifications.'
    Dim verif_enCours As Boolean
    Dim type_verif As String

    Dim _usr_menu As usr_gestion_Menucours
    Dim animation As New cls_animation_operation

    Dim droit_limite As Boolean
    Private con As MySqlConnection

    Public Sub New(usr_menu As usr_gestion_Menucours)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        _usr_menu = usr_menu
    End Sub

    'User load.'
    Private Sub usr_gestion_cours_Load(sender As Object, e As EventArgs) Handles Me.Load
        cbo_type.SelectedIndex = 1
        cbo_statut.SelectedIndex = 0

        Select Case _usr_menu.utls_conn.Titre
            Case "a"c
                droit_admin()
            Case "p"c
                droit_prof()
                Btn_supprimerCours.Visible = False
                Btn_supprimerCours.Enabled = False
                btn_assigner.Visible = False
                btn_assigner.Enabled = False
            Case Else
                droit_prof()
        End Select
    End Sub

    Private Sub lancement_recherche(sender As Object, e As EventArgs) Handles txt_recherche.TextChanged, cbo_type.SelectedIndexChanged, cbo_statut.SelectedIndexChanged
        MAJ()
    End Sub

#Region "Droits"
    'Droit de l'admin.'
    Public Sub droit_admin()
        gb_statut.Visible = True
        btn_activer.Visible = True
        btn_desac.Visible = True
        btn_selectionner.Visible = True
        btn_ajouter.Visible = True
        btn_modifier.Visible = True
        btn_annuler.Visible = True

        cbo_type.Items.Clear()
        cbo_type.Items.Add("No. de cours")
        cbo_type.Items.Add("Nom de cours")
        cbo_type.Items.Add("Nom de l'enseignant")
        cbo_type.Items.Add("Identifiant")
        cbo_type.SelectedIndex = 0

        MAJ()
    End Sub

    'Droit du prof.'
    Public Sub droit_prof()
        droit_limite = True
        lbl_top.Text = "Assigner des étudiants à mes cours"
        btn_assigner.Location = New Point(3, btn_assigner.Location.Y)

        cbo_type.Items.Clear()
        cbo_type.Items.Add("No. de cours")
        cbo_type.Items.Add("Nom de cours")
        cbo_type.SelectedIndex = 0
        MAJ()
    End Sub

#End Region

    'Récupère tous les cours de la bd.'
    Private Sub RecupererCours()
        strRequete = "Select distinct c.`no_cours`, `nom_cours`, group_concat( distinct u.`prenom_personne`,concat(' ',u.`nom_personne`)) as nom, group_concat(distinct u.`no_utilisateur`), c.`actif` from `tbl_cours` c
                      inner join `tbl_cours_prof` p on c.no_cours=p.no_cours
                      inner join `tbl_utilisateurs` u on p.no_utilisateur=u.no_utilisateur "
        table = "tbl_cours"

        If droit_limite Then
            strRequete &= " WHERE p.`no_utilisateur` = '" & _usr_menu.utls_conn.No_id & "'"
        End If


        'Recherche par type.'
        If txt_recherche.Text <> "" Then

            If droit_limite Then
                strRequete &= " AND "
            Else
                strRequete &= " WHERE "
            End If

            Select Case cbo_type.SelectedIndex
                Case 0
                    strRequete &= " (c.`no_cours` Like '" & mod_regex.ConvertirApostrophe(txt_recherche.Text.Trim) & "%'
                                Or replace(c.`no_cours`, '-', '') like '" & mod_regex.ConvertirApostrophe(txt_recherche.Text.Trim.Replace(" ", "")) & "%')"
                Case 1
                    strRequete &= " replace(c.`nom_cours`, ' ', '') like '" & mod_regex.ConvertirApostrophe(txt_recherche.Text.Trim).replace(" ", "") & "%'"
                Case 2
                    strRequete &= " (u.`prenom_personne` Like '" & mod_regex.ConvertirApostrophe(txt_recherche.Text.Trim) & "%' 
                                Or u.`nom_personne` Like '" & mod_regex.ConvertirApostrophe(txt_recherche.Text.Trim) & "%'
                                Or (replace(group_concat(u.`prenom_personne`,u.`nom_personne`), ' ', '') like '" & mod_regex.ConvertirApostrophe(txt_recherche.Text.Trim.Replace(" ", "").Replace(",", "")) & "%'))"
                Case 3
                    strRequete &= " u.`no_utilisateur` like '" & mod_regex.ConvertirApostrophe(txt_recherche.Text.Trim) & "%'"
            End Select
        End If

        'Recherche par statut (admin).'
        If cbo_statut.SelectedIndex = 0 Then
            strRequete &= " AND c.`actif` = 1"
        ElseIf cbo_statut.SelectedIndex = 1 Then
            strRequete &= " AND c.`actif` = 0"
        End If

        strRequete &= " group by  c.`no_cours`; "

        gestionBd.miseAjourDS(dsCours, dataAdapter, strRequete, table)
    End Sub

    'Met à jour les cours du grid.'
    Public Sub MAJ()
        RecupererCours()
        RemplirGrid()
        RemplirControle()
        gestionBtn()
    End Sub
    '
    '
    'Tout ce qui est bonton ajouter, modifier...'
    '
    '
#Region "Boutons de modification"
    'Gestion des boutons ajout, modifier, supprimer et annuler.'
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click, btn_modifier.Click, btn_annuler.Click, Btn_supprimerCours.Click
        Dim btn As Button = sender

        Select Case btn.Text
            Case btn_ajouter.Text
                AjouterCours()
            Case btn_modifier.Text
                ModifierCours()
            Case btn_annuler.Text
                Annuler()
            Case Btn_supprimerCours.Text
                Supprimer()
        End Select

    End Sub

    'Gère l'ajout d'un cours.'
    Private Sub AjouterCours()
        If btn_ajouter.Text = "Ajouter un cours" Then
            'Active/désactive les boutons.'
            btn_ajouter.Text = "Enregistrer"
            LBProf.Items.Clear()
            btn_modifier.Enabled = False
            btn_annuler.Enabled = True
            btn_selectionner.Enabled = True
            btn_activer.Enabled = False
            btn_desac.Enabled = False
            grid_cours.Enabled = False
            pnl_recherche.Enabled = False
            InverserControle()

            'Active les vérifications.'
            type_verif = "ajout"
            verif_enCours = True
            TourVerification(txt_nmCours)
        Else
            Dim succes As Boolean = True

            'Création du cours.'
            Try
                strRequete = "INSERT INTO `tbl_cours`(`no_cours`, `nom_cours`) VALUES ('" & RecupererNoCoursComposee() &
                         "','" & mod_regex.ConvertirApostrophe(txt_nmCours.Text) & "');"
                gestionBd.InsDelUpd(strRequete)
            Catch e As Exception
                succes = False
            End Try
            Dim frm_prof As New frm_selectionProf
            Try
                For i As Integer = 0 To (LBProf.Items.Count - 1)

                    strRequete = "INSERT INTO `tbl_cours_prof`(`no_cours`, `no_utilisateur`)
                             VALUES ('" & RecupererNoCoursComposee() &
                             "','" & LBProf.Items(i) & "');"
                    gestionBd.InsDelUpd(strRequete)

                Next



            Catch e As Exception
                succes = False
            End Try

            If succes Then
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Le cours a été ajouté.", cls_animation_operation.Reussie)
            Else
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de l'ajout du cours.", cls_animation_operation.Echec)
            End If



            'Désactive les vérifications.'
            type_verif = ""
            verif_enCours = False

            'Active/désactive les boutons.'
            btn_ajouter.Text = "Ajouter un cours"
            LBProf.Items.Clear()
            btn_modifier.Enabled = True
            btn_annuler.Enabled = False
            btn_selectionner.Enabled = False
            grid_cours.Enabled = True
            pnl_recherche.Enabled = True
            InverserControle()
            gestionBtn()
            MAJ()
        End If
    End Sub

    'Gère la modification d'un cours.'
    Private Sub ModifierCours()
        If btn_modifier.Text = "Modifier un cours" Then
            'Récupère le no de cours pour l'utiliser comme clé lors de l'update.'
            noCoursTemp = RecupererNoCoursComposee()
            With grid_cours
                NoProfTemp = .Rows(.CurrentRow.Index).Cells(3).Value.ToString
            End With

            'Active/désactive les boutons.'
            btn_modifier.Text = "Enregistrer"
            LBProf.Items.Clear()
            btn_ajouter.Enabled = False
            btn_annuler.Enabled = True
            btn_selectionner.Enabled = True
            InverserControle()
            grid_cours.Enabled = False
            pnl_recherche.Enabled = False
            btn_activer.Enabled = False
            btn_desac.Enabled = False

            'Active les vérifications.'
            type_verif = "modif"
            verif_enCours = True
            TourVerification(LBProf)
        Else
            Dim succes As Boolean = True

            'Requetes vers la bd.'
            Try
                strRequete = "UPDATE `tbl_cours` Set `no_cours`='" & RecupererNoCoursComposee() &
                         "',`nom_cours`='" & mod_regex.ConvertirApostrophe(txt_nmCours.Text) & "' WHERE `no_cours`= '" & noCoursTemp & "';"
                gestionBd.InsDelUpd(strRequete)
            Catch e As Exception
                succes = False
            End Try

            'S'il y avait un ancien prof ou non.'
            If NoProfTemp <> "" Then
                'Mise à jour de la liaison avec le prof.'
                Dim frm_prof As New frm_selectionProf

                Try

                    strRequete = "DELETE FROM `tbl_cours_prof`" & " WHERE `no_cours`=  '" & noCoursTemp & "' " & "; "
                    gestionBd.InsDelUpd(strRequete)


                    For i As Integer = 0 To (LBProf.Items.Count - 1)



                        strRequete = "INSERT INTO `tbl_cours_prof`(`no_cours`, `no_utilisateur`) VALUES ('" & RecupererNoCoursComposee() &
                                 "','" & LBProf.Items(i) & "'); "
                        gestionBd.InsDelUpd(strRequete)
                    Next



                Catch e As Exception
                    succes = False
                End Try
            Else
                'Création de la liaison avec le prof.'
                Dim frm_prof As New frm_selectionProf


                gestionBd.InsDelUpd(strRequete)
                Try

                    For i As Integer = 0 To (LBProf.Items.Count - 1)



                        strRequete = "INSERT INTO `tbl_cours_prof`(`no_cours`, `no_utilisateur`) VALUES ('" & RecupererNoCoursComposee() &
                                 "','" & LBProf.Items(i) & "'); "
                        gestionBd.InsDelUpd(strRequete)
                    Next





                Catch e As Exception
                    succes = False
                End Try
            End If

            If succes Then
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Le cours a été modifié.", cls_animation_operation.Reussie)
                LBProf.Items.Clear()
            Else
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de la modification du cours.", cls_animation_operation.Echec)
            End If


            'Désactive les vérifications.'
            type_verif = ""
            verif_enCours = False

            'Active/désactive les boutons.'
            btn_modifier.Text = "Modifier un cours"
            btn_ajouter.Enabled = True
            btn_annuler.Enabled = False
            btn_selectionner.Enabled = False
            pnl_recherche.Enabled = True
            grid_cours.Enabled = True
            InverserControle()
            gestionBtn()
            MAJ()
        End If
    End Sub

    'Gère l'annulation.'
    Private Sub Annuler()
        'Désactive les vérifications.'
        type_verif = ""
        verif_enCours = False
        lbE_noCours.ForeColor = Color.DarkGray
        lbE_nomCours.Visible = False
        lbE_selectionProf.Visible = False

        btn_ajouter.Text = "Ajouter un cours"
        btn_modifier.Text = "Modifier un cours"
        btn_ajouter.Enabled = True
        btn_modifier.Enabled = True
        btn_annuler.Enabled = False
        grid_cours.Enabled = True
        btn_selectionner.Enabled = False
        InverserControle()
        pnl_recherche.Enabled = True

        gestionBtn()
        MAJ()
    End Sub
    'Gère la suppression.'
    Private Sub Supprimer()
        'Désactive les vérifications.'
        noCoursTemp = RecupererNoCoursComposee()
        If noCoursTemp = "-01" Then
            MessageBox.Show("aucun cours à supprimer")
        Else
            Dim result As Integer = MessageBox.Show("voulez-vous vraiment supprimer ce cours ?", "Suppression du cours", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
                MessageBox.Show("Opération annulé")
            ElseIf result = DialogResult.No Then
                MessageBox.Show("Cours non supprimé")
            ElseIf result = DialogResult.Yes Then
                MessageBox.Show("Cours supprimé!!")

                'Désactive les vérifications.'

                type_verif = ""
                verif_enCours = False
                lbE_noCours.ForeColor = Color.DarkGray
                lbE_nomCours.Visible = False
                lbE_selectionProf.Visible = False
                Dim succes As Boolean

                Try


                    strRequete = "DELETE FROM `tbl_cours_prof`" & " WHERE `no_cours`=  '" & noCoursTemp & "' " & "; "
                    gestionBd.InsDelUpd(strRequete)
                    strRequete = "DELETE FROM `tbl_cours`" & " WHERE `no_cours`=  '" & noCoursTemp & "' " & "; "
                    gestionBd.InsDelUpd(strRequete)
                    succes = True
                Catch e As Exception

                End Try



                If succes Then
                    animation.Lancement(timer_succes, lbl_ajoutSucces, "Le cours a été supprimé.", cls_animation_operation.Reussie)
                Else
                    animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de la suppression du cours.", cls_animation_operation.Echec)
                End If


                gestionBtn()
                MAJ()
            End If

        End If
    End Sub
#End Region
    '
    '
    '
    '
    '
#Region "Activer/Désactiver/Supprimer"

    'Vérifie les boutons activer/désactiver quand on sélectionne une autre ligne dans le datagrid.'
    Private Sub grid_cours_SelectionChanged(sender As Object, e As EventArgs) Handles grid_cours.SelectionChanged
        index = grid_cours.CurrentRow.Index
        gestionBtn()
    End Sub


    'Gestion des boutons activer/désactiver/supprimer.'
    Private Sub gestionBtn()
        If grid_cours.Rows.Count > 0 Then

            If grid_cours.CurrentRow.Cells(0).Tag = 0 Then
                btn_activer.Enabled = True
                btn_desac.Enabled = False
            Else
                btn_activer.Enabled = False
                btn_desac.Enabled = True
            End If
        Else
            btn_activer.Enabled = False
            btn_desac.Enabled = False
        End If
    End Sub


    'Activer.'
    Private Sub btn_activer_Click(sender As Object, e As EventArgs) Handles btn_activer.Click
        If MessageBox.Show("Voulez-vous activer le cours sélectionné?",
                          "Activer un cours",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then


            Cursor = Cursors.AppStarting
            With grid_cours.CurrentRow
                strRequete = "UPDATE `tbl_cours` 
                                      SET `actif` = 1
                                      WHERE `no_cours` = '" & RecupererNoCoursComposee() & "';"

                Try
                    gestionBd.InsDelUpd(strRequete)
                    animation.Lancement(timer_succes, lbl_ajoutSucces, "Activation réussie.", cls_animation_operation.Reussie)
                Catch ex As Exception
                    animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de l'activation.", cls_animation_operation.Echec)
                End Try
            End With
            Cursor = Cursors.Default


            MAJ()
        End If
    End Sub

    'Désactiver.'
    Private Sub btn_desactiver_Click(sender As Object, e As EventArgs) Handles btn_desac.Click
        If MessageBox.Show("Voulez-vous désactiver le cours sélectionné?",
                          "Désactiver un cours",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then


            Cursor = Cursors.AppStarting
            With grid_cours.CurrentRow
                strRequete = "UPDATE `tbl_cours` 
                                      SET `actif` = 0
                                      WHERE `no_cours` = '" & RecupererNoCoursComposee() & "';"

                Try
                    gestionBd.InsDelUpd(strRequete)
                    animation.Lancement(timer_succes, lbl_ajoutSucces, "Désactivation réussie.", cls_animation_operation.Reussie)
                Catch ex As Exception
                    animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de la désactivation.", cls_animation_operation.Echec)
                End Try
            End With
            Cursor = Cursors.Default


            MAJ()
        End If
    End Sub


    'Gère la suppression d'un cours.'
    'Private Sub SupprimerCours()
    '    If MessageBox.Show("Êtes-vous certain de vouloir supprimer ce cours?", "Supprimer un cour",
    '                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

    '        'Requetes vers la bd.'
    '        Try
    '            strRequete = "DELETE FROM `tbl_cours` WHERE `no_cours` = '" & RecupererNoCoursComposee() & "'
    '                          and `actif` = 0;"
    '            gestionBd.InsDelUpd(strRequete)
    '            animation.Lancement(timer_succes, lbl_ajoutSucces, "Suppression de cours effectuée.", cls_animation_operation.Reussie)
    '        Catch e As Exception
    '            MsgBox(e.Message)
    '            animation.Lancement(timer_succes, lbl_ajoutSucces, "Échec lors de la suppression de cours.", cls_animation_operation.Echec)
    '        End Try

    '        MAJ()
    '    End If
    'End Sub
#End Region
    '
    '
    'Tout ce qui est remplir le grid_cours ou les contrôles à droite.'
    '
    '
#Region "Remplissage de contrôles"
    'Remplis le grid_cours avec les cours.'
    Private Sub RemplirGrid()
        grid_cours.Rows.Clear()

        'Selon prof ou admin.'
        If droit_limite Then
            'Enlève des colonnes.'
            If grid_cours.ColumnCount > 2 Then
                grid_cours.Columns.RemoveAt(3)
                grid_cours.Columns.RemoveAt(2)

                grid_cours.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End If

            'Ajout des cours.'
            With dsCours.Tables(0)
                For i As Integer = 0 To .Rows.Count - 1
                    grid_cours.Rows.Add(.Rows(i).Item(0))
                    grid_cours.Rows(grid_cours.Rows.Count - 1).Cells(1).Value = .Rows(i).Item(1)
                Next
            End With
        Else
            'Ajoute des colonnes.'
            If grid_cours.ColumnCount < 3 Then
                grid_cours.Columns.Add("C2", "Nom de l'enseignant")
                grid_cours.Columns(2).Width = 470
                grid_cours.Columns.Add("C3", "Identifiant de l'enseignant")
                grid_cours.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

                grid_cours.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnsMode.None
            End If

            'Ajout des cours.'
            With dsCours.Tables(0)
                For i As Integer = 0 To .Rows.Count - 1
                    grid_cours.Rows.Add(.Rows(i).Item(0))
                    grid_cours.Rows(grid_cours.Rows.Count - 1).Cells(1).Value = .Rows(i).Item(1)
                    grid_cours.Rows(grid_cours.Rows.Count - 1).Cells(2).Value = .Rows(i).Item(2)
                    grid_cours.Rows(grid_cours.Rows.Count - 1).Cells(3).Value = .Rows(i).Item(3)

                    If .Rows(i).Item(4) = 0 Then
                        grid_cours.Rows(grid_cours.Rows.Count - 1).Cells(0).Tag = "0"
                        For j As Integer = 0 To 3
                            grid_cours.Rows(grid_cours.Rows.Count - 1).Cells(j).Style.ForeColor = Color.DimGray
                        Next
                    Else
                        grid_cours.Rows(grid_cours.Rows.Count - 1).Cells(0).Tag = "1"
                    End If
                Next
            End With
        End If
    End Sub

    'Quand l'utilisateur clique sur le grid_cours, modifie les infos dans les contrôles.'
    Private Sub grid_cours_Click(sender As Object, e As EventArgs) Handles grid_cours.Click
        RemplirControle()
    End Sub

    'Remplis les contrôles.'
    Private Sub RemplirControle()
        If grid_cours.Rows.Count <> 0 Then
            'Selon prof ou admin.'
            If droit_limite Then
                With grid_cours
                    txt_noCours.Text = .Rows(.CurrentRow.Index).Cells(0).Value.ToString.Substring(0, 10)
                    nud_groupe.Value = .Rows(.CurrentRow.Index).Cells(0).Value.ToString.Substring(11, 2)
                    txt_nmCours.Text = .Rows(.CurrentRow.Index).Cells(1).Value
                    LBProf.Text = _usr_menu.utls_conn.No_id
                End With

                btn_assigner.Enabled = True
            Else
                With grid_cours
                    txt_noCours.Text = .Rows(.CurrentRow.Index).Cells(0).Value.ToString.Substring(0, 10)
                    nud_groupe.Value = .Rows(.CurrentRow.Index).Cells(0).Value.ToString.Substring(11, 2)
                    txt_nmCours.Text = .Rows(.CurrentRow.Index).Cells(1).Value
                    LBProf.Text = .Rows(.CurrentRow.Index).Cells(3).Value.ToString
                End With

                btn_modifier.Enabled = True
                btn_assigner.Enabled = True
            End If

        Else
            btn_modifier.Enabled = False
            btn_assigner.Enabled = False
            effacerControl()
        End If
    End Sub
#End Region
    '
    '
    '
    '
    '
#Region "Sélection Prof"
    'Bouton Sélectionner (affiche le panel de sélection).'
    Private Sub btn_selectionner_Click(sender As Object, e As EventArgs) Handles btn_selectionner.Click
        Dim frm_prof As New frm_selectionProf
        LBProf.Items.Clear()
        frm_prof.ShowDialog()

        Dim a As Integer = 0
        If Not frm_prof.Professeurs Is Nothing Then


            For i As Integer = 0 To (frm_prof.Professeurs.Length - 2)
                LBProf.Items.Add(frm_prof.Professeurs(i))


            Next
        End If
        If btn_ajouter.Text = "Enregistrer" Then
            btn_modifier.Enabled = False
            btn_ajouter.Enabled = True
        Else
            btn_modifier.Enabled = True
        End If

    End Sub


#End Region
    '
    '
    '
    '
    '
#Region "Assigner des étudiants"

    Private Sub btn_assigner_Click(sender As Object, e As EventArgs) Handles btn_assigner.Click
        Dim usr_associer As New usr_associer_utls_cours(RecupererNoCoursComposee)
        _usr_menu.pnl_cours.Controls.Add(usr_associer)
        usr_associer.Dock = DockStyle.Fill
        usr_associer.BringToFront()
    End Sub
#End Region
    '
    '
    'Tout ce qui est vérification.'
    '
    '
#Region "Verification"
    'Cas où les vérifications doivent se produire.'
    Private Sub cours_TextChanged(sender As Object, e As EventArgs) Handles txt_noCours.TextChanged, nud_groupe.ValueChanged, txt_nmCours.TextChanged
        'Permet de faire les vérifications que si on ajoute ou modifie.'
        If verif_enCours Then
            TourVerification(sender)
        End If
    End Sub

    'Cas où les vérifications doivent se produire.'
    Private Sub cours_LostFocus(sender As Object, e As EventArgs) Handles txt_noCours.LostFocus, nud_groupe.LostFocus, txt_nmCours.LostFocus
        'Permet de faire les vérifications que si on ajoute ou modifie.'
        If verif_enCours Then
            TourVerification(sender)
        End If
    End Sub

    'Tour complet des vérifications.'
    Private Sub TourVerification(ctrl As Control)

        Select Case ctrl.Tag
            Case "1"
                If VerifierNoCours() Then
                    lbE_noCours.ForeColor = Color.DarkGray
                Else
                    lbE_noCours.ForeColor = Color.Firebrick
                End If
            Case "3"
                Dim verif As Integer = VerifierNomCours()

                If verif = 1 Then
                    lbE_nomCours.Visible = False
                ElseIf verif = -1 Then
                    lbE_nomCours.Text = "Saisissez un nom de cours"
                    lbE_nomCours.Visible = True
                Else
                    lbE_nomCours.Text = "Un caractère saisie est invalide"
                    lbE_nomCours.Visible = True
                End If
            Case "4"
                If VerifierProf() Then
                    lbE_selectionProf.Visible = False
                Else
                    lbE_selectionProf.Visible = True
                End If

        End Select

        If VerifierNoCours() Then
            If VerifierNomCours() = 1 Then
                If VerifierGroupe() Then
                    If VerifierProf() Then
                        Select Case type_verif
                            Case "ajout"
                                btn_ajouter.Enabled = True
                            Case "modif"
                                btn_modifier.Enabled = True
                            Case Else
                                btn_ajouter.Enabled = False
                                btn_modifier.Enabled = False
                        End Select
                        Return
                    End If
                End If
            End If
        End If

        btn_ajouter.Enabled = False
        btn_modifier.Enabled = False
    End Sub

    'Vérification du no de cours.'
    Private Function VerifierNoCours() As Boolean
        Return mod_regex.NoCours(txt_noCours.Text)
    End Function

    'Vérification du groupe.'
    Private Function VerifierGroupe() As Boolean
        If VerifierNoCours() Then
            RecupererCours()

            If type_verif = "modif" And noCoursTemp = RecupererNoCoursComposee() Then
                Return True
            Else
                Dim i As Integer = 0
                Dim groupe_trouver As Boolean = False
                With dsCours.Tables(0)
                    While i < .Rows.Count And groupe_trouver = False
                        If (RecupererNoCoursComposee() = .Rows(i).Item(0)) Then
                            groupe_trouver = True
                        Else
                            i += 1
                        End If
                    End While

                    If groupe_trouver Then
                        Return False
                    Else Return True
                    End If
                End With
            End If
        End If
        Return False
    End Function

    'Vérification du nom de cours (1 = bon, 0 = caractère invalide et -1 = aucune saisie).'
    Private Function VerifierNomCours() As Integer
        If txt_nmCours.Text.Trim <> "" Then
            If mod_regex.Nom(txt_nmCours.Text) Then
                Return 1
            Else
                Return 0
            End If
        End If
        Return -1
    End Function

    'Vérification de la sélection de prof.'
    Private Function VerifierProf() As Boolean
        If LBProf.SelectedIndex >= 0 Then
            Return True
        Else Return False
        End If
    End Function


#End Region
    '
    '
    '
    '
    '
#Region "Autres"
    'Animation!.'
    Private Sub timer_succes_Tick(sender As Timer, e As EventArgs) Handles timer_succes.Tick
        animation.Operation(sender, lbl_ajoutSucces)
    End Sub

    'inverse l'enable des contrôles.'
    Private Sub InverserControle()
        txt_nmCours.Enabled = Not txt_nmCours.Enabled
        txt_noCours.Enabled = Not txt_noCours.Enabled
        nud_groupe.Enabled = Not nud_groupe.Enabled

        btn_assigner.Enabled = Not btn_assigner.Enabled
    End Sub

    'Retourne la composition du cours et du groupe.'
    Private Function RecupererNoCoursComposee()
        Return txt_noCours.Text.ToUpper & "-" & nud_groupe.Value.ToString.PadLeft(2, "0")
    End Function

    'Change la couleur quand on passe la souris sur le grid_cours.'
    Private Sub grid_cours_CellMouseLeave(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_cours.CellMouseLeave
        If e.RowIndex > -1 Then
            grid_cours.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
            grid_cours.Rows(e.RowIndex).DefaultCellStyle.ForeColor = DefaultForeColor
        End If
    End Sub

    'Change la couleur quand on passe la souris sur le grid_cours.'
    Private Sub grid_cours_CellMouseEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_cours.CellMouseEnter
        If e.RowIndex > -1 Then
            grid_cours.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(236, 240, 241)
        End If
    End Sub

    'Efface tous les contrôles.'
    Private Sub effacerControl()
        txt_nmCours.Text = ""
        txt_noCours.Text = ""
        nud_groupe.Value = nud_groupe.Minimum
        LBProf.Text = ""
    End Sub

    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btn_ajouter.MouseEnter, btn_annuler.MouseEnter, btn_modifier.MouseEnter, btn_selectionner.MouseEnter, btn_assigner.MouseEnter, btn_activer.MouseEnter, btn_desac.MouseEnter, Btn_supprimerCours.MouseEnter, Btn_listeEtu.MouseEnter
        sender.BackColor = Color.White
        sender.ForeColor = Color.Black
    End Sub

    Private Sub btn_MouseEnter(sender As Object, e As EventArgs) Handles btn_selectionner.MouseEnter, btn_modifier.MouseEnter, btn_assigner.MouseEnter, btn_annuler.MouseEnter, btn_ajouter.MouseEnter, btn_desac.MouseEnter, btn_activer.MouseEnter

    End Sub

    Private Sub btn_MouseLeave(sender As Object, e As EventArgs) Handles btn_selectionner.MouseLeave, btn_modifier.MouseLeave, btn_assigner.MouseLeave, btn_annuler.MouseLeave, btn_ajouter.MouseLeave, btn_desac.MouseLeave, btn_activer.MouseLeave

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub



    Private Sub BtSupprimercours_Click(sender As Object, e As EventArgs) Handles Btn_supprimerCours.Click




    End Sub

    Private Sub BtListeEtu_Click(sender As Object, e As EventArgs) Handles Btn_listeEtu.Click

        Dim commande As New MySqlCommand
        Dim ds As DataSet
        Dim da As MySqlDataAdapter
        Dim conn As New MySqlConnection("Server=localhost; DataBase=simulateur_inventaire; Uid=root; Pwd=")
        Dim sfd As New SaveFileDialog
        Dim liste As String = ""
        Dim fichier As String
        Dim no_cours As String


        no_cours = grid_cours.CurrentRow.Cells(0).Value




        sfd.Filter = "  Fichier Excel|*.csv"

            If sfd.ShowDialog = DialogResult.OK Then
                fichier = sfd.FileName
                Dim sw As New StreamWriter(fichier, True, System.Text.Encoding.UTF8)


            commande.CommandText = strRequete


            Sfd_liste_etu.AddExtension = True
                Sfd_liste_etu.DefaultExt = ".csv"
                strRequete = "Select distinct c.`no_cours`, c.`nom_cours`, concat( u.`prenom_personne`,concat(' ',u.`nom_personne`)) as nom,  u.`no_utilisateur`, c.`actif` from `tbl_cours` c
                      inner join `tbl_cours_utilisateur` cu on c.no_cours=cu.no_cours
                      inner join `tbl_utilisateurs` u on cu.no_utilisateur=u.no_utilisateur where cu.`no_cours`= '" & no_cours & "' " & "; "

                da = New MySqlDataAdapter(strRequete, conn)

                sw.WriteLine("Liste des etudiants inscrits à ce cours ")
                ds = New DataSet("simulateur_inventaire")

                da.Fill(ds, "liste etudiants")
                Dim dt As DataTable = ds.Tables("liste etudiants")

                For i As Integer = 0 To ds.Tables("liste etudiants").Rows.Count - 1
                    sw.WriteLine(ds.Tables("liste etudiants").Rows(i).Item(2))
                Next


                sw.Close()


                table = "tbl_cours"

            MessageBox.Show("liste sauvegardée")

        Else
                MessageBox.Show("annulée")
            End If






    End Sub

    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btn_ajouter.MouseLeave, btn_annuler.MouseLeave, btn_modifier.MouseLeave, btn_selectionner.MouseLeave, btn_assigner.MouseLeave, btn_activer.MouseLeave, btn_desac.MouseLeave, Btn_supprimerCours.MouseLeave, Btn_listeEtu.MouseLeave
        If sender.Text = btn_annuler.Text Then
            sender.BackColor = Color.DimGray
            sender.ForeColor = SystemColors.Control
        ElseIf sender.Text = btn_selectionner.Text Or sender.Text = btn_desac.Text Or sender.Text = btn_activer.Text Then
            sender.BackColor = Color.FromArgb(72, 84, 96)
            sender.ForeColor = SystemColors.Control
        Else
            sender.BackColor = Color.FromArgb(52, 73, 94)
            sender.ForeColor = SystemColors.Control
        End If
    End Sub
#End Region

End Class
