Imports MySql.Data.MySqlClient

Public Class usr_liste_utls
    'Attributs reliés à la gestion de la bd.'
    Dim strRequete As String
    Dim table As String
    Dim gestionBd As New Connexion
    Dim dataAdapter As New MySqlDataAdapter
    Dim dsUtls As DataSet
    Dim _usr_menuUtls As usr_gestion_MenuUtls
    Dim utls_conn As Utilisateur

    Dim animation As New cls_animation_operation
    Dim droit_limite As Boolean

    Public Sub New(usr_menuUtls As usr_gestion_MenuUtls, utls As Utilisateur)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        _usr_menuUtls = usr_menuUtls
        utls_conn = utls
    End Sub


    'User load.'
    Private Sub usr_liste_utls_Load(sender As Object, e As EventArgs) Handles Me.Load
        cbo_statut.SelectedIndex = 0
        cbo_type.SelectedIndex = 1
    End Sub

#Region "Droits"
    'Droit de l'admin.'
    Public Sub droit_admin()
        gb_statut.Visible = True
        btn_activer.Visible = True
        btn_desac.Visible = True

        cbo_titre.Items.Clear()
        cbo_titre.Items.Add("Tous")
        cbo_titre.Items.Add("Étudiant")
        cbo_titre.Items.Add("Enseignant")
        cbo_titre.Items.Add("Administrateur")
        cbo_titre.SelectedIndex = 0
        cbo_titre.Visible = True
        lbl_titre.Visible = True
        MAJ()
    End Sub

    'Droit du prof.'
    Public Sub droit_prof()

        cbo_titre.Items.Clear()
        cbo_titre.Items.Add("Tous")
        cbo_titre.SelectedIndex = 0
        droit_limite = True
        MAJ()
    End Sub

#End Region

    'Lance la maj au textchanged de la barre de recherche.'
    Private Sub txt_recherche_TextChanged(sender As Object, e As EventArgs) Handles txt_recherche.TextChanged, cbo_titre.SelectedIndexChanged, cbo_statut.SelectedIndexChanged
        MAJ()
    End Sub

    'Ouvre le user des régénérations de mot de passe.
    Private Sub btn_changerMdp_Click(sender As Object, e As EventArgs) Handles btn_changerMdp.Click
        If MessageBox.Show("Voulez-vous regénérer les mots de passe des utilisateurs sélectionnés?", "Régénérer des mots de passes",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim lst As List(Of Utilisateur) = RecupererSelectionner()

            If lst.Count > 0 Then
                Dim usr_vMdp As New usr_nouveau_mdp(lst)
                _usr_menuUtls.pnl_listeUtls.Controls.Add(usr_vMdp)
                usr_vMdp.Dock = DockStyle.Fill
                usr_vMdp.BringToFront()
            End If
        End If
    End Sub

#Region "Activer/désactiver/supprimer"

    'Gestion des boutons activer/désactiver/supprimer.'
    Private Sub gestionBtn()
        If grid_utls.Rows.Count > 0 Then
            Dim trouver As Boolean
            Dim i As Integer = 0

            While trouver = False And i < grid_utls.SelectedRows.Count
                If grid_utls.SelectedRows(i).Cells(0).Tag = 1 Then
                    trouver = True
                    btn_activer.Enabled = False
                    btn_desac.Enabled = True
                Else
                    i += 1
                End If
            End While

            If Not trouver Then
                btn_activer.Enabled = True
                btn_desac.Enabled = False
            End If
        Else
            btn_activer.Enabled = False
            btn_desac.Enabled = False
        End If
    End Sub



    'Activer.'
    Private Sub btn_activer_Click(sender As Object, e As EventArgs) Handles btn_activer.Click
        If MessageBox.Show("Voulez-vous réactiver les utilisateurs sélectionnés?",
                          "Activer des utilisateurs",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim echec As String = ""


            Cursor = Cursors.AppStarting
            For i As Integer = 0 To grid_utls.SelectedRows.Count - 1
                With grid_utls.SelectedRows(i)
                    strRequete = "UPDATE `tbl_utilisateurs` 
                                      SET `actif` = 1 
                                      WHERE `no_utilisateur` = '" & .Cells(0).Value & "';"

                    Try
                        gestionBd.InsDelUpd(strRequete)
                    Catch ex As Exception
                        echec &= " " & .Cells(0).Value
                    End Try
                End With
            Next
            Cursor = Cursors.Default


            If echec = "" Then
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Activation réussie.", cls_animation_operation.Reussie)
            Else
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de l'activation.", cls_animation_operation.Echec)
                Debug.WriteLine("Échec d'activation sur les utilisateurs:" & echec)
            End If



            MAJ()
        End If
    End Sub

    'Désactiver.'
    Private Sub btn_desac_Click(sender As Object, e As EventArgs) Handles btn_desac.Click
        If MessageBox.Show("Êtes-vous certain de vouloir désactiver les utilisateurs sélectionnés?",
                          "Désactiver des utilisateurs",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim echec As String = ""
            Dim noMsg As Boolean


            Cursor = Cursors.AppStarting
            For i As Integer = 0 To grid_utls.SelectedRows.Count - 1
                With grid_utls.SelectedRows(i)
                    If .Cells(0).Value <> utls_conn.No_id Then
                        strRequete = "UPDATE `tbl_utilisateurs` 
                                      SET `actif` = 0 
                                      WHERE `no_utilisateur` = '" & .Cells(0).Value & "';"

                        Try
                            gestionBd.InsDelUpd(strRequete)
                        Catch ex As Exception
                            echec &= " " & .Cells(0).Value
                        End Try
                    Else
                        If grid_utls.SelectedRows.Count = 1 Then
                            noMsg = True
                        End If
                    End If
                End With
            Next
            Cursor = Cursors.Default


            If echec = "" Then
                If Not noMsg Then
                    animation.Lancement(timer_succes, lbl_ajoutSucces, "Désactivation réussie.", cls_animation_operation.Reussie)
                Else
                    animation.Lancement(timer_succes, lbl_ajoutSucces, "Votre compte ne peut pas être désactivé.", cls_animation_operation.Echec)
                End If
            Else
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de la désactivation.", cls_animation_operation.Echec)
                Debug.WriteLine("Échec de désactivation sur les utilisateurs:" & echec)
            End If


            MAJ()
        End If
    End Sub

    'Supprime les utilisateurs sélectionnés.
    'Private Sub btn_supprimer_Click(sender As Object, e As EventArgs) Handles btn_supprimer.Click
    '    If MessageBox.Show("Êtes-vous certain de vouloir supprimer les utilisateurs sélectionnés? (Seul les inactifs seront supprimés)" & vbNewLine & vbNewLine & "La suppression est définitive.",
    '                       "Supprimer des utilisateurs",
    '                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

    '        Dim echec As String = ""
    '        Dim noMsg As Boolean

    '        Cursor = Cursors.AppStarting
    '        For i As Integer = 0 To grid_utls.SelectedRows.Count - 1
    '            With grid_utls.SelectedRows(i)

    '                If .Cells(0).Value <> utls_conn.No_id Then
    '                    strRequete = "DELETE FROM `tbl_utilisateurs` 
    '                                  WHERE `no_utilisateur` = '" & .Cells(0).Value & "'
    '                                  AND `actif` = 0;"

    '                    Try
    '                        gestionBd.InsDelUpd(strRequete)
    '                    Catch ex As Exception
    '                        echec &= " " & .Cells(0).Value
    '                        MsgBox(ex.Message)
    '                    End Try
    '                Else
    '                    If grid_utls.SelectedRows.Count = 1 Then
    '                        noMsg = True
    '                    End If
    '                End If
    '            End With
    '        Next
    '        Cursor = Cursors.Default

    '        If echec = "" Then
    '            If Not noMsg Then
    '                animation.Lancement(timer_succes, lbl_ajoutSucces, "Suppression réussie.", cls_animation_operation.Reussie)
    '            Else
    '                animation.Lancement(timer_succes, lbl_ajoutSucces, "Impossible de supprimer votre compte.", cls_animation_operation.Echec)
    '            End If
    '        Else
    '            animation.Lancement(timer_succes, lbl_ajoutSucces, "Échec de la suppression.", cls_animation_operation.Echec)
    '            MsgBox("Échec de suppression sur les utilisateurs:" & echec)
    '        End If
    '        _usr_menuUtls.majCours()

    '        MAJ()
    '    End If
    'End Sub
#End Region
    '
    '
    '
    '
    '
#Region "modifier Nom"
    'Détermine si on peut modifier un nom ou non.'
    Private Sub grid_utls_SelectionChanged(sender As Object, e As EventArgs) Handles grid_utls.SelectionChanged
        If grid_utls.SelectedRows.Count = 1 Then
            btn_modifierNm.Enabled = True
            btn_modifierPnm.Enabled = True
        Else
            btn_modifierNm.Enabled = False
            btn_modifierPnm.Enabled = False
        End If

        'Gestion des boutons activer/désactiver/supprimer.'
        gestionBtn()
    End Sub

    'Modification d'un nom.'
    Private Sub btn_modifierNm_Click(sender As Object, e As EventArgs) Handles btn_modifierNm.Click
        Dim frm_nm As New frm_modifierNom(grid_utls.CurrentRow.Cells(2).Value.ToString, "Modifier le nom d'un utilisateur", "Nouveau nom")

        frm_nm.ShowDialog()

        strRequete = "update `tbl_utilisateurs` set `nom_personne` = '" & mod_regex.ConvertirApostrophe(frm_nm.Nom) & "' WHERE `no_utilisateur` = '" & grid_utls.CurrentRow.Cells(0).Value & "';"

        Try
            gestionBd.InsDelUpd(strRequete)
        Catch ex As Exception
        End Try



        grid_utls.CurrentRow.Cells(2).Value = frm_nm.Nom


    End Sub

    'Modification d'un prénom.'
    Private Sub btn_modifierPnm_Click(sender As Object, e As EventArgs) Handles btn_modifierPnm.Click
        Dim frm_pnm As New frm_modifierNom(grid_utls.CurrentRow.Cells(1).Value.ToString, "Modifier le prénom d'un utilisateur", "Nouveau prénom")

        frm_pnm.ShowDialog()

        strRequete = "update `tbl_utilisateurs` set `prenom_personne` = '" & mod_regex.ConvertirApostrophe(frm_pnm.Nom) & "' WHERE `no_utilisateur` = '" & grid_utls.CurrentRow.Cells(0).Value & "';"

        Try
            gestionBd.InsDelUpd(strRequete)
        Catch ex As Exception
        End Try



        grid_utls.CurrentRow.Cells(1).Value = frm_pnm.Nom


    End Sub
#End Region
    '
    '
    '
    '
    '
#Region "Remplissage"
    'Met à jour le grid.'
    Public Sub MAJ()
        RecupererUtls()
        RemplirGrid()
        btn_selectionner.Text = "Sélectionner tout"
        gestionBtn()
    End Sub

    'Récupère tous les étudiants.'
    Private Sub RecupererUtls()
        strRequete = "SELECT `no_utilisateur`, `prenom_personne`, `nom_personne`, ELT(FIELD(`titre`, 'e', 'p', 'a'), 'Étudiant', 'Enseignant', 'Administrateur'),`actif`
                      FROM `tbl_utilisateurs`"

        table = "tbl_utilisateurs"

        'Recherches.'
        Select Case cbo_type.SelectedIndex
            Case 0
                strRequete &= " WHERE `no_utilisateur` like '" & mod_regex.ConvertirApostrophe(txt_recherche.Text.Trim) & "%'"
            Case 1
                strRequete &= " WHERE `prenom_personne` like '" & mod_regex.ConvertirApostrophe(txt_recherche.Text.Trim) & "%'"
            Case 2
                strRequete &= " WHERE `nom_personne` like '" & mod_regex.ConvertirApostrophe(txt_recherche.Text.Trim) & "%'"
            Case Else
                strRequete &= " WHERE `no_utilisateur` like '" & mod_regex.ConvertirApostrophe(txt_recherche.Text.Trim) & "%'"
        End Select

        If cbo_titre.SelectedItem <> "Tous" Then
            strRequete &= " And ELT(FIELD(`titre`, 'e', 'p', 'a'), 'Étudiant', 'Enseignant', 'Administrateur')  = '" & cbo_titre.SelectedItem & "'"
        ElseIf droit_limite Then
            strRequete &= " AND ELT(FIELD(`titre`, 'e', 'p', 'a'), 'Étudiant', 'Enseignant', 'Administrateur')  = 'Étudiant'"
        End If

        'Recherche par statut (admin).'
        If cbo_statut.SelectedIndex = 0 Then
            strRequete &= " AND `actif` = 1"
        ElseIf cbo_statut.SelectedIndex = 1 Then
            strRequete &= " AND `actif` = 0"
        End If

        strRequete &= " ORDER BY `actif` desc;"
        gestionBd.miseAjourDS(dsUtls, dataAdapter, strRequete, table)
    End Sub

    'Remplis le grid.'
    Private Sub RemplirGrid()
        grid_utls.Rows.Clear()

        If droit_limite Then
            grid_utls.Columns(3).Visible = False
        Else
            grid_utls.Columns(3).Visible = True
        End If

        With dsUtls.Tables(0)
            Cursor.Current = Cursors.AppStarting
            For i As Integer = 0 To .Rows.Count - 1
                grid_utls.Rows.Add(.Rows(i).Item(0))
                grid_utls.Rows(grid_utls.Rows.Count - 1).Cells(1).Value = .Rows(i).Item(1)
                grid_utls.Rows(grid_utls.Rows.Count - 1).Cells(2).Value = .Rows(i).Item(2)
                grid_utls.Rows(grid_utls.Rows.Count - 1).Cells(3).Value = .Rows(i).Item(3).ToString

                If .Rows(i).Item(4) = 0 Then
                    grid_utls.Rows(grid_utls.Rows.Count - 1).Cells(0).Tag = "0"
                    For j As Integer = 0 To 3
                        grid_utls.Rows(grid_utls.Rows.Count - 1).Cells(j).Style.ForeColor = Color.DimGray
                    Next
                Else
                    grid_utls.Rows(grid_utls.Rows.Count - 1).Cells(0).Tag = "1"
                End If
            Next
            Cursor.Current = Cursors.Default
        End With

        If dsUtls.Tables(0).Rows.Count > 0 Then
            btn_changerMdp.Enabled = True
        Else
            btn_changerMdp.Enabled = False
        End If
    End Sub

    'Récupère les utilisateurs sélectionnés (et les met dans une liste).'
    Private Function RecupererSelectionner() As List(Of Utilisateur)
        Dim utls_temp As Utilisateur
        Dim list_utls As New List(Of Utilisateur)

        For i As Integer = 0 To grid_utls.SelectedRows.Count - 1
            With grid_utls.SelectedRows(i)
                If .Cells(0).Value <> utls_conn.No_id Then
                    utls_temp = New Utilisateur(.Cells(0).Value, .Cells(1).Value, .Cells(2).Value, .Cells(3).Value)
                    list_utls.Add(utls_temp)
                Else
                    animation.Lancement(timer_succes, lbl_ajoutSucces, "Votre mot de passe ne peut pas être réinitialisé.", cls_animation_operation.Echec)
                End If
            End With
        Next
        Return list_utls
    End Function

#End Region
    '
    '
    '
    '
    '
#Region "Autres"
    'Bouton sélectionner tout.'
    Private Sub Button1_Click(sender As Button, e As EventArgs) Handles btn_selectionner.Click
        Dim selection As Boolean

        If sender.Text = "Sélectionner tout" Then
            sender.Text = "Déselectionner tout"
            selection = True
        Else
            sender.Text = "Sélectionner tout"
            selection = False
        End If

        With grid_utls
            For i As Integer = 0 To .Rows.Count - 1
                .Rows(i).Selected = selection
            Next
        End With
    End Sub



    'Timer pour la suppréssion réussie.'
    Private Sub timer_succes_Tick(sender As Object, e As EventArgs) Handles timer_succes.Tick
        animation.Operation(sender, lbl_ajoutSucces)
    End Sub

    'Change la couleur quand on passe la souris sur le grid_cours.'
    Private Sub grid_utls_CellMouseLeave(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_utls.CellMouseLeave
        If e.RowIndex > -1 Then
            grid_utls.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
            grid_utls.Rows(e.RowIndex).DefaultCellStyle.ForeColor = DefaultForeColor
        End If
    End Sub

    'Change la couleur quand on passe la souris sur le grid_cours.'
    Private Sub grid_utls_CellMouseEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_utls.CellMouseEnter
        If e.RowIndex > -1 Then
            grid_utls.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(236, 240, 241)
        End If
    End Sub

    'Couleur des boutons.'
    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btn_changerMdp.MouseEnter, btn_modifierNm.MouseEnter, btn_excel.MouseEnter, btn_selectionner.MouseEnter, btn_desac.MouseEnter, btn_activer.MouseEnter, btn_modifierPnm.MouseEnter

        sender.BackColor = Color.White
        sender.ForeColor = Color.Black
    End Sub

    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btn_changerMdp.MouseLeave, btn_modifierNm.MouseLeave, btn_excel.MouseLeave, btn_selectionner.MouseLeave, btn_desac.MouseLeave, btn_activer.MouseLeave, btn_modifierPnm.MouseLeave
        If sender.Text = btn_desac.Text Or sender.Text = btn_activer.Text Then
            sender.BackColor = Color.FromArgb(72, 84, 96)
            sender.ForeColor = SystemColors.Control
        ElseIf sender.Text = btn_excel.Text Then
            sender.BackColor = Color.FromArgb(63, 124, 63)
            sender.ForeColor = SystemColors.Control
        Else
            sender.BackColor = Color.FromArgb(52, 73, 94)
            sender.ForeColor = SystemColors.Control
        End If
    End Sub

    Private Sub btn_excel_Click(sender As Object, e As EventArgs) Handles btn_excel.Click
        Cursor.Current = Cursors.AppStarting
        mod_grid_Excel.LancerExcel(grid_utls)
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub btn_MouseEnter(sender As Object, e As EventArgs) Handles btn_modifierNm.MouseEnter, btn_excel.MouseEnter, btn_changerMdp.MouseEnter, btn_selectionner.MouseEnter, btn_desac.MouseEnter, btn_modifierPnm.MouseEnter, btn_activer.MouseEnter

    End Sub

    Private Sub btn_MouseLeave(sender As Object, e As EventArgs) Handles btn_modifierNm.MouseLeave, btn_excel.MouseLeave, btn_changerMdp.MouseLeave, btn_selectionner.MouseLeave, btn_desac.MouseLeave, btn_modifierPnm.MouseLeave, btn_activer.MouseLeave

    End Sub
#End Region
End Class
