Imports System.Data.Sql
Imports MySql.Data.MySqlClient

' KEVEN ABEL

Public Class usr_gestion_fournisseurs
    Dim bd As New Connexion
    Dim ds As New DataSet
    Dim ds_tel As New DataSet
    Dim da As MySqlDataAdapter
    Dim requete As String = ""
    Dim id As String
    'pour ignorer les entrées de téléphones non-remplies
    Dim entrees_ignorees As Integer = 0
    Dim animation As New cls_animation_operation
    Public tel_list As New List(Of usr_tel_lst)
    Dim derniereLocation As New Point

#Region "Éléments à sauvegarder"
    Dim nom_fournisseur As String = ""
    Dim adresse As String = ""
    Dim ville As String = ""
    Dim telephone As String = ""
    Dim frais_livraison As String = ""
    Dim qte_min As String = ""
    Dim tri As String = ""
    Dim actif As Boolean
#End Region


    Private Sub usr_gestion_fournisseurs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialiser_Controles()
        dgv_fournisseurs.RowTemplate.Height = 30
        If ds.Tables(0).Rows.Count <> 0 Then
            dgv_fournisseurs.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            dgv_fournisseurs.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            dgv_fournisseurs.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            dgv_fournisseurs.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            dgv_fournisseurs.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            dgv_fournisseurs.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgv_fournisseurs.Columns(6).Visible = False
        End If
    End Sub

#Region "Manipulation de Datagridview"
    Private Sub dgv_fournisseurs_CellMouseLeave(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_fournisseurs.CellMouseLeave
        If e.RowIndex > -1 Then
            dgv_fournisseurs.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
            dgv_fournisseurs.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
        End If
    End Sub

    Private Sub dgv_fournisseurs_CellMouseEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_fournisseurs.CellMouseEnter
        If e.RowIndex > -1 Then

            dgv_fournisseurs.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(236, 240, 241)
            dgv_fournisseurs.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black

        End If
    End Sub

    Sub Rafraichir_Boutons()
        Dim _ds As New DataSet

        bd.Requete("SELECT tbl_fournisseurs.actif FROM tbl_fournisseurs WHERE no_fournisseur = '" & id & "'", _ds, da, "tbl_fournisseurs")
        If _ds.Tables(0).Rows(0).Item(0) = False Then
            btn_reactiver.Enabled = True
            btn_desactiver.Enabled = False
            btn_associer.Enabled = False
        Else
            btn_desactiver.Enabled = True
            btn_reactiver.Enabled = False
            btn_associer.Enabled = True
        End If
        btn_ajouter.Enabled = True
        btn_modifier.Enabled = True
        btn_visualiser.Enabled = True
    End Sub

    Private Sub dgv_fournisseurs_MultiSelectChanged(sender As Object, e As EventArgs) Handles dgv_fournisseurs.SelectionChanged
        If dgv_fournisseurs.SelectedRows.Count > 1 Then
            If rdb_actifs_oui.Checked Then
                btn_desactiver.Enabled = True
                btn_reactiver.Enabled = False
                btn_associer.Enabled = True
            ElseIf rdb_actifs_non.Checked Then
                btn_reactiver.Enabled = True
                btn_desactiver.Enabled = False
                btn_associer.Enabled = False
            End If
            btn_associer.Enabled = False
            btn_modifier.Enabled = False
            btn_visualiser.Enabled = False
        End If
    End Sub

    Sub Rafraichir_MultiSelect()
        If rdb_actifs_oui.Checked Or rdb_actifs_non.Checked Then
            dgv_fournisseurs.MultiSelect = True
        Else
            dgv_fournisseurs.MultiSelect = False
        End If
    End Sub
#End Region
    '
    '
    '
    '
    '
#Region "Couleur des boutons"
    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btnRechercher.MouseEnter, btn_excel.MouseEnter, btn_ajouter.MouseEnter,
                                                                         btnReinitialiser.MouseEnter, btn_modifier.MouseEnter, btn_annuler.MouseEnter,
                                                                         btn_desactiver.MouseEnter, btn_reactiver.MouseEnter, btn_visualiser.MouseEnter, btn_valider.MouseEnter,
                                                                         btn_associer.MouseEnter

        sender.BackColor = Color.White
        sender.ForeColor = Color.Black
    End Sub

    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btnRechercher.MouseLeave, btn_excel.MouseLeave, btn_ajouter.MouseLeave,
                                                                         btnReinitialiser.MouseLeave, btn_modifier.MouseLeave, btn_annuler.MouseLeave,
                                                                         btn_desactiver.MouseLeave, btn_reactiver.MouseLeave, btn_visualiser.MouseLeave, btn_valider.MouseLeave,
                                                                         btn_associer.MouseLeave
        If sender.Text = btn_desactiver.Text Or sender.Text = btn_annuler.Text Or sender.Text = btnReinitialiser.Text Then
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


#End Region

    'Initialisation des contrôles
    Sub Initialiser_Controles()
        Dim tab_cbo() As ComboBox = {cbo_nom_contient, cbo_adresse_contient, cbo_ordre, cbo_trier_par, cbo_ville_contient, cbo_rech_frais, cbo_rech_quantite}
        Remplir_Combobox_Villes(bd, "nom_ville", "tbl_ville", cbo_aj_villes)
        For i = 0 To tab_cbo.Count - 1
            tab_cbo(i).SelectedIndex = 0
        Next
        rdb_actifs_oui.Checked = True
    End Sub

    'Va remplir les textbox en bas en concordant avec les informations du fournisseur voulu (que l'on clique dessus, genre.)
    Sub Remplir_Visualisation()
        Dim _ds As New DataSet
        Dim requete = "SELECT nom_fournisseur, adresse, nom_ville, code_postal, lien_internet, nom_contact, prenom_contact, titre_contact, adresse_couriel_contact, frais_livraison, remarque, qte_min_commande
                       FROM tbl_fournisseurs
                       INNER JOIN tbl_ville ON tbl_ville.no_ville = tbl_fournisseurs.ville
                       WHERE no_fournisseur = '" & id & "'"
        Dim tab_controles() As Control = {txt_aj_nom, txt_aj_adresse, cbo_aj_villes, txt_aj_cp, txt_aj_siteWeb, txt_aj_ctnom, txt_aj_ctprenom, txt_aj_titre, txt_aj_ctcourriel,
                                          nm_aj_frais, txt_aj_remarque}
        bd.miseAjourDS(_ds, da, requete, "tbl_fournisseurs")
        For i As Integer = 0 To tab_controles.Count - 1
            tab_controles(i).Text = _ds.Tables(0).Rows(0).Item(i)
        Next
        nm_aj_qte.Value = _ds.Tables(0).Rows(0).Item(11)

    End Sub

    ''' <summary>
    ''' Fonction servant à trouver le numéro d'identification d'un fournisseur via 4 critères.
    ''' </summary>
    ''' <param name="nom_fournisseur">Le nom du fournisseur (la case 0 du dgv)</param>
    ''' <param name="adresse">L'adresse du fournisseur (la case 1 du dgv)</param>
    ''' <param name="ville">La ville du fournisseur ((la case 2 du dgv)</param>
    ''' <param name="code_postal">Le code postal du fournisseur (la case 3 du dgv)</param>
    ''' <returns></returns>
    Function Trouver_ID_Fournisseur(nom_fournisseur As String, adresse As String, ville As String, code_postal As String) As String
        Dim ds_ID As New DataSet
        Dim requete As String = "SELECT no_fournisseur FROM tbl_fournisseurs
                                 WHERE nom_fournisseur = '" & ConvertirApostrophe(nom_fournisseur) & "' AND adresse = '" & ConvertirApostrophe(adresse) &
                                 "' AND ville = (SELECT no_ville FROM tbl_ville WHERE nom_ville = '" & ConvertirApostrophe(ville) & "') AND code_postal = '" & code_postal & "'"
        bd.miseAjourDS(ds_ID, da, requete, "tbl_fournisseurs")

        If ds_ID.Tables(0).Rows.Count > 0 Then
            Return ds_ID.Tables(0).Rows(0).Item(0)
        Else
            Return ""
        End If

    End Function

    'on remplit la datagridview des fournisseurs de cette façon
    Sub Remplir_Fournisseurs()
        dgv_fournisseurs.Rows.Clear()
        With ds.Tables(0)
            For i As Integer = 0 To .Rows.Count - 1
                dgv_fournisseurs.Rows.Add(.Rows(i).Item(0))

                dgv_fournisseurs.Rows(dgv_fournisseurs.Rows.Count - 1).Cells(1).Value = .Rows(i).Item(1)
                dgv_fournisseurs.Rows(dgv_fournisseurs.Rows.Count - 1).Cells(2).Value = .Rows(i).Item(2)
                dgv_fournisseurs.Rows(dgv_fournisseurs.Rows.Count - 1).Cells(3).Value = .Rows(i).Item(3)
                dgv_fournisseurs.Rows(dgv_fournisseurs.Rows.Count - 1).Cells(4).Value = .Rows(i).Item(4)
                dgv_fournisseurs.Rows(dgv_fournisseurs.Rows.Count - 1).Cells(5).Value = .Rows(i).Item(5)

                'on met en gris les fournisseurs inactifs
                If .Rows(i).Item(6) = "Non" Then
                    dgv_fournisseurs.Rows(dgv_fournisseurs.Rows.Count - 1).Cells(0).Tag = "0"
                    For j As Integer = 0 To .Columns.Count - 1
                        dgv_fournisseurs.Rows(dgv_fournisseurs.Rows.Count - 1).Cells(j).Style.ForeColor = Color.DimGray
                    Next
                Else
                    dgv_fournisseurs.Rows(dgv_fournisseurs.Rows.Count - 1).Cells(0).Tag = "1"
                End If
            Next
        End With
    End Sub

    ''' <summary>
    ''' Va permettre de vérifier si le nombre de lignes retournées par la requête est 0, ou si c'est plus que 0.
    ''' Dans le cas où c'est 0, on affiche un panel indiquant qu'il n'y aura pas de fournisseurs disponibles.
    ''' Dans le cas contraire, on enlève le panel, on met à jour le datagridview et on affiche les numéros de téléphone.
    ''' </summary>
    Sub Verification_Lignes()
        If ds.Tables(0).Rows.Count <> 0 Then
            'dgv_fournisseurs.DataSource = ds.Tables(0)
            Remplir_Fournisseurs()

            'On va chercher le id du fournisseur de la première ligne
            With ds.Tables(0).Rows(0)
                id = Trouver_ID_Fournisseur(.Item(0), .Item(1), .Item(2), .Item(3))
                'On va regarder s'il y a des numéros de téléphone (dans le cas où on réussirait à bypasser la création)
                Afficher_Telephones(id, .Item(0))
                Remplir_Visualisation()
            End With

            Rafraichir_Boutons()
            pnl_vide.Visible = False
            btn_excel.Enabled = True
        Else
            pnl_vide.Visible = True
            pnl_tel_vides.Visible = True
            lbl_nom_fourn.Text = "N/A"
            btn_modifier.Enabled = False
            btn_visualiser.Enabled = False
            btn_reactiver.Enabled = False
            btn_desactiver.Enabled = False
            btn_excel.Enabled = False
        End If
    End Sub

    'Rechercher un fournisseur lorsqu'on clique sur le bouton Rechercher.
    Sub Rechercher_Fournisseur()
        nom_fournisseur = Rechercher_Selon_Contenu("nom_fournisseur", cbo_nom_contient, ConvertirApostrophe(txt_rech_nom.Text))
        ville = Rechercher_Selon_Contenu("lower(nom_ville)", cbo_ville_contient, ConvertirApostrophe(txt_rech_ville.Text.ToLower))
        adresse = Rechercher_Selon_Contenu("adresse", cbo_adresse_contient, ConvertirApostrophe(txt_rech_adresse.Text))
        telephone = Rechercher_Telephone(ConvertirApostrophe(txt_rech_telephone.Text))
        frais_livraison = Verifier_Limites(cbo_rech_frais, nm_frais_inf.Value, nm_frais_sup.Value, "frais_livraison")
        qte_min = Verifier_Limites(cbo_rech_quantite, nm_commande_inf.Value, nm_commande_sup.Value, "qte_min_commande")
        tri = Verifier_Tri_Fournisseurs(cbo_trier_par.Text, cbo_ordre.Text)

        requete = "SELECT nom_fournisseur as `Nom`, adresse as `Adresse`, nom_ville as `Ville`, code_postal as `Code postal`,                   
                   CONCAT(FORMAT(frais_livraison, 2), ' $') as `Frais de livraison`, 
                   CONCAT(qte_min_commande, if(qte_min_commande = 0, '', if(qte_min_commande > 1, ' produits', ' produit'))) as `Commande minimale`, 
                   if(tbl_fournisseurs.actif, 'Oui', 'Non') as `Actif`
                   FROM tbl_fournisseurs   
                   LEFT JOIN tbl_telephones on tbl_fournisseurs.no_fournisseur = tbl_telephones.no_fournisseur
                   INNER JOIN tbl_ville on tbl_fournisseurs.ville = tbl_ville.no_ville
                   WHERE " & Verifier_Activite(rdb_actifs_oui, rdb_actifs_non, "tbl_fournisseurs") &
                   Rechercher_Selon_Contenu("nom_fournisseur", cbo_nom_contient, ConvertirApostrophe(txt_rech_nom.Text)) &
                   Rechercher_Selon_Contenu("lower(nom_ville)", cbo_ville_contient, ConvertirApostrophe(txt_rech_ville.Text.ToLower)) &
                   Rechercher_Selon_Contenu("adresse", cbo_adresse_contient, ConvertirApostrophe(txt_rech_adresse.Text)) &
                   Rechercher_Telephone(ConvertirApostrophe(txt_rech_telephone.Text)) &
                   Verifier_Limites(cbo_rech_frais, nm_frais_inf.Value, nm_frais_sup.Value, "frais_livraison") &
                   Verifier_Limites(cbo_rech_quantite, nm_commande_inf.Value, nm_commande_sup.Value, "qte_min_commande") &
                   " GROUP BY tbl_fournisseurs.no_fournisseur" & Verifier_Tri_Fournisseurs(cbo_trier_par.Text, cbo_ordre.Text)

        bd.miseAjourDS(ds, da, requete, "tbl_fournisseurs")
        Verification_Lignes()
    End Sub

    'Rechercher un fournisseur selon son activité. C'est la première requête qui va se faire chez les fournisseurs (car elle s'active lorsqu'un bouton radio est changé)
    Sub Rechercher_Fournisseur(radio_oui As RadioButton, radio_non As RadioButton)
        requete = "SELECT nom_fournisseur as `Nom`, adresse as `Adresse`, nom_ville as `Ville`, code_postal as `Code postal`,                    
                   CONCAT(FORMAT(frais_livraison, 2), ' $') as `Frais de livraison`, 
                   CONCAT(qte_min_commande, if(qte_min_commande = 0, '', if(qte_min_commande > 1, ' produits', ' produit'))) as `Commande minimale`, 
                   if(tbl_fournisseurs.actif, 'Oui', 'Non') as `Actif`
                   FROM tbl_fournisseurs
                   LEFT JOIN tbl_telephones on tbl_fournisseurs.no_fournisseur = tbl_telephones.no_fournisseur
                   INNER JOIN tbl_ville on tbl_fournisseurs.ville = tbl_ville.no_ville
                   WHERE " & Verifier_Activite(rdb_actifs_oui, rdb_actifs_non, "tbl_fournisseurs") & nom_fournisseur & ville & adresse & telephone & frais_livraison & qte_min &
                   " GROUP BY tbl_fournisseurs.no_fournisseur" & tri
        bd.miseAjourDS(ds, da, requete, "tbl_fournisseurs")

        Verification_Lignes()
    End Sub

    Private Sub btnRechercher_Click(sender As Object, e As EventArgs) Handles btnRechercher.Click
        Rechercher_Fournisseur()
    End Sub

    Private Sub rdb_actifs_oui_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_actifs_oui.CheckedChanged, rdb_actifs_non.CheckedChanged, rdb_actifs_tous.CheckedChanged
        Rechercher_Fournisseur(rdb_actifs_oui, rdb_actifs_non)
    End Sub
    '
    '
    '
    '
    '
#Region "Les recherches par frais et quantité (show/hide les NumericUpDown)"
    Sub Cacher_Limites_Frais()
        Dim tab_controles() As Control = {lbl_fet, lbl_finf, lbl_fsup, nm_frais_sup}
        For i = 0 To tab_controles.Length - 1
            tab_controles(i).Visible = False
        Next
    End Sub

    Sub Montrer_Limites_Frais()
        Dim tab_controles() As Control = {lbl_fet, lbl_finf, lbl_fsup, nm_frais_sup}
        For i = 0 To tab_controles.Length - 1
            tab_controles(i).Visible = True
        Next
    End Sub

    Sub Cacher_Limites_Quantite()
        Dim tab_controles() As Control = {lbl_qet, lbl_qinf, lbl_qsup, nm_commande_sup}
        For i = 0 To tab_controles.Length - 1
            tab_controles(i).Visible = False
        Next
    End Sub

    Sub Montrer_Limites_Quantite()
        Dim tab_controles() As Control = {lbl_qet, lbl_qinf, lbl_qsup, nm_commande_sup}
        For i = 0 To tab_controles.Length - 1
            tab_controles(i).Visible = True
        Next
    End Sub

    Private Sub limites_SelectedIndexChanged(sender As ComboBox, e As EventArgs) Handles cbo_rech_frais.SelectedIndexChanged, cbo_rech_quantite.SelectedIndexChanged
        If sender.Name = cbo_rech_frais.Name Then
            Select Case cbo_rech_frais.Text
                Case "Supérieur à", "Inférieur à"
                    Cacher_Limites_Frais()
                    nm_frais_inf.Enabled = True
                Case "Entre..."
                    Montrer_Limites_Frais()
                    nm_frais_inf.Enabled = True
                Case Else
                    Cacher_Limites_Frais()
                    nm_frais_inf.Enabled = False
            End Select
        Else
            Select Case cbo_rech_quantite.Text
                Case "Supérieur à", "Inférieur à"
                    Cacher_Limites_Quantite()
                    nm_commande_inf.Enabled = True
                Case "Entre..."
                    Montrer_Limites_Quantite()
                    nm_commande_inf.Enabled = True
                Case Else
                    Cacher_Limites_Quantite()
                    nm_commande_inf.Enabled = False
            End Select
        End If
    End Sub
#End Region
    '
    '
    '
    '
    '
    ''' <summary>
    ''' Méthode servant à afficher les numéros de téléphones des fournisseurs dans la DataGridView dgv_telephones.
    ''' </summary>
    ''' <param name="id_fournisseur"> Le numéro de fournisseur, que l'on obtient via Trouver_ID_Fournisseur </param>
    ''' <param name="nom_fournisseur"> Le nom du fournisseur, que l'on obtient avec la DataGridView dgv_fournisseurs</param>
    Sub Afficher_Telephones(ByVal id_fournisseur As String, ByVal nom_fournisseur As String)
        bd.miseAjourDS(ds_tel, da, "SELECT Type, Telephone, Poste FROM tbl_telephones WHERE no_fournisseur = '" & id_fournisseur & "'", "tbl_telephones")
        If ds_tel.Tables(0).Rows.Count > 0 Then
            Remplir_Telephones()
            pnl_tel_vides.Visible = False
        Else
            pnl_tel_vides.Visible = True
        End If

        lbl_nom_fourn.Text = nom_fournisseur
    End Sub

    Sub Remplir_Telephones()
        dgv_telephones.Rows.Clear()
        With ds_tel.Tables(0)
            For i As Integer = 0 To .Rows.Count - 1
                dgv_telephones.Rows.Add(.Rows(i).Item(0))
                dgv_telephones.Rows(dgv_telephones.Rows.Count - 1).Cells(1).Value = .Rows(i).Item(1)
                dgv_telephones.Rows(dgv_telephones.Rows.Count - 1).Cells(2).Value = .Rows(i).Item(2)
            Next
        End With
    End Sub

    'Lorsqu'on clique sur une des cases du dgv_fournisseurs, va aller chercher les numéros de téléphones du fournisseur en question.
    'Va aussi rafraîchir les boutons dépendant de son état d'actif (ou d'inactivité)
    Private Sub dgv_fournisseurs_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_fournisseurs.CellClick
        If e.RowIndex > -1 Then
            With dgv_fournisseurs.Rows(e.RowIndex)
                id = Trouver_ID_Fournisseur(.Cells(0).Value, .Cells(1).Value, .Cells(2).Value, .Cells(3).Value)
                Afficher_Telephones(id, .Cells(0).Value)
            End With

            Rafraichir_Boutons()
            pnl_tel.Controls.Clear()
            tel_list.Clear()
            Ajouter_Numero(False)
            Remplir_Visualisation()
        End If

    End Sub
    '
    '
    '
    '
    '
#Region "Activation/Désactivation"
    Private Sub btn_desactiver_Click(sender As Object, e As EventArgs) Handles btn_desactiver.Click
        If MessageBox.Show("Désirez-vous désactiver ce(s) fournisseur(s)?" & vbCrLf & vbCrLf & "(Sachez que vous pouvez les réactiver plus tard)", "Désactivation de fournisseurs",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Desactiver_Fournisseur()
        End If
    End Sub

    Private Sub btn_reactiver_Click(sender As Object, e As EventArgs) Handles btn_reactiver.Click
        If MessageBox.Show("Désirez-vous réactiver ce(s) fournisseurs(s)?" & vbCrLf & vbCrLf & "(Sachez que vous pouvez les désactiver plus tard)", "Réactivation de fournisseurs",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Activer_Fournisseur()
        End If
    End Sub


    Sub Activer_Fournisseur()
        Dim echec As String = ""
        Dim noMsg As Boolean
        Dim strRequete

        Cursor = Cursors.AppStarting
        For i As Integer = 0 To dgv_fournisseurs.SelectedRows.Count - 1
            With dgv_fournisseurs.SelectedRows(i)

                strRequete = "UPDATE tbl_fournisseurs SET actif = 1 WHERE no_fournisseur = '" & Trouver_ID_Fournisseur(.Cells(0).Value, .Cells(1).Value, .Cells(2).Value, .Cells(3).Value) & "';"

                Try
                    bd.InsDelUpd(strRequete)
                Catch ex As Exception
                    echec &= " " & .Cells(0).Value

                End Try

                If dgv_fournisseurs.SelectedRows.Count = 1 Then
                    noMsg = True
                End If

            End With
        Next
        Cursor = Cursors.Default

        If echec = "" Then
            animation.Lancement(timer_succes, lbl_ajoutSucces, "Réactivation réussie.", cls_animation_operation.Reussie)
        Else
            animation.Lancement(timer_succes, lbl_ajoutSucces, "Échec de la réactivation.", cls_animation_operation.Echec)
        End If
        Rechercher_Fournisseur(rdb_actifs_oui, rdb_actifs_non)
    End Sub

    Sub Desactiver_Fournisseur()
        Dim echec As String = ""
        Dim noMsg As Boolean
        Dim strRequete

        Cursor = Cursors.AppStarting
        For i As Integer = 0 To dgv_fournisseurs.SelectedRows.Count - 1
            With dgv_fournisseurs.SelectedRows(i)

                strRequete = "UPDATE tbl_fournisseurs SET actif = 0 WHERE no_fournisseur = '" & Trouver_ID_Fournisseur(.Cells(0).Value, .Cells(1).Value, .Cells(2).Value, .Cells(3).Value) & "';"

                Try
                    bd.InsDelUpd(strRequete)
                Catch ex As Exception
                    echec &= " " & .Cells(0).Value
                End Try

                If dgv_fournisseurs.SelectedRows.Count = 1 Then
                    noMsg = True
                End If

            End With
        Next
        Cursor = Cursors.Default

        If echec = "" Then
            animation.Lancement(timer_succes, lbl_ajoutSucces, "Désactivation réussie.", cls_animation_operation.Reussie)
        Else
            animation.Lancement(timer_succes, lbl_ajoutSucces, "Échec de la désactivation.", cls_animation_operation.Echec)
        End If
        Rechercher_Fournisseur(rdb_actifs_oui, rdb_actifs_non)
    End Sub



#End Region
    '
    '
    '
    '
    '
#Region "Vérifications"
    Function Valider_Nom_Fournisseur(ByRef nom_f As String) As Boolean
        If Est_Nom(nom_f.Trim) Then
            nom_f = Upper_Premier_Char(nom_f)
            lbl_erreur_nom_f.Hide()
            Return True
        Else
            lbl_erreur_nom_f.Show()
            Ecrire_Erreur(nom_f, lbl_erreur_nom_f, "Veuillez entrer un nom de fournisseur", "Nom de fournisseur invalide (pas de nombres)")
            Return False
        End If
    End Function

    Function Valider_Adresse(ByVal _adresse As String) As Boolean
        If Est_Adresse(_adresse.Trim) Then
            lbl_erreur_adresse.Hide()
            Return True
        Else
            lbl_erreur_adresse.Show()
            Ecrire_Erreur(_adresse, lbl_erreur_adresse, "Veuillez entrer une adresse", "Adresse invalide")
            Return False
        End If
    End Function

    Function Valider_Ville(ByVal ville As String) As Boolean
        If Est_Ville(ville.Trim) And ville <> "" Then
            lbl_erreur_ville.Hide()
            Return True
        Else
            lbl_erreur_ville.Show()
            Ecrire_Erreur(ville, lbl_erreur_ville, "Veuillez choisir une ville", "Ville invalide")
            Return False
        End If
    End Function

    Function Valider_CodePostal(ByRef _cp As String) As Boolean
        If Est_CodePostal(_cp.Trim) Then
            lbl_erreur_codepostal.Hide()
            _cp = Ajuster_CodePostal(_cp)
            Return True
        Else
            lbl_erreur_codepostal.Show()
            Ecrire_Erreur(_cp, lbl_erreur_codepostal, "Veuillez entrer un code postal", "Code postal invalide")
            Return False
        End If
    End Function

    Function Valider_Nom_Contact(ByRef nom_c As String) As Boolean
        If Est_Nom(nom_c.Trim) Then
            nom_c = Upper_Premier_Char(nom_c)
            lbl_erreur_nom_contact.Hide()
            Return True
        Else
            lbl_erreur_nom_contact.Show()
            Ecrire_Erreur(nom_c, lbl_erreur_nom_contact, "Veuillez entrer un nom pour le contact", "Nom de contact invalide (ne pas entrer de nombres)")
            Return False
        End If
    End Function

    Function Valider_Prenom_Contact(ByRef prenom_c As String) As Boolean
        If Est_Nom(prenom_c.Trim) Then
            prenom_c = Upper_Premier_Char(prenom_c)
            lbl_erreur_prenom.Hide()
            Return True
        Else
            lbl_erreur_prenom.Show()
            Ecrire_Erreur(prenom_c, lbl_erreur_prenom, "Veuillez entrer un prénom pour le contact", "Prénom de contact invalide (ne pas entrer de nombres)")
            Return False
        End If
    End Function

    Function Valider_Titre(ByRef titre_c As String) As Boolean
        If Est_Nom(titre_c.Trim) Then
            titre_c = Upper_Premier_Char(titre_c)
            lbl_erreur_titre.Hide()
            Return True
        Else
            lbl_erreur_titre.Show()
            Ecrire_Erreur(titre_c, lbl_erreur_titre, "Veuillez entrer le titre du contact", "Ne pas entrer de nombres.")
            Return False
        End If
    End Function

    Function Valider_Courriel(ByVal courriel As String) As Boolean
        If Est_Courriel(courriel.Trim) Or courriel = "" Then
            lbl_erreur_courriel.Hide()
            Return True
        Else
            lbl_erreur_courriel.Show()
            lbl_erreur_courriel.Text = "Adresse courriel invalide"
            Return False
        End If
    End Function

    Function Valider_Site_Web(ByVal site As String) As Boolean
        If Est_Site_Web(site.Trim) Or site = "" Then
            lbl_erreur_siteWeb.Hide()
            Return True
        Else
            lbl_erreur_siteWeb.Show()
            lbl_erreur_siteWeb.Text = "Site web invalide."
            Return False
        End If
    End Function

    Function Valider_Telephone(ByRef telephone As String) As Boolean
        Alterer_Telephone(telephone)

        If Est_Telephone(telephone) Then
            Return True
        Else
            Return False
        End If
    End Function

    'pour valider la liste, on passe à travers la liste et on vérifie si c'est un téléphone valide
    'si tous les téléphones de la liste sont valides, alors on retournera TRUE
    Function Valider_Liste_Telephones(ByVal liste As List(Of usr_tel_lst)) As Boolean
        Dim nb_erreurs As Integer = 0


        For i As Integer = 0 To liste.Count - 1
            If liste(i).cbo_type.Text <> "" And Valider_Telephone(liste(i).txt_numero.Text) And (Est_Nombre(liste(i).txt_poste.Text) Or liste(i).txt_poste.Text = "") Then
                'rien
            ElseIf liste(i).txt_numero.Text = "" Then
                entrees_ignorees += 1
            Else
                nb_erreurs += 1
            End If
        Next

        If nb_erreurs > 0 Then
            lbl_erreur_telephone.Show()
            Return False
        Else
            lbl_erreur_telephone.Hide()
            Return True
        End If
    End Function

    'On valide le tout avec cette fonction, pour ensuite Ajouter ou Modifier.
    Function Valider_Ensemble() As Boolean

        If Valider_Nom_Fournisseur(txt_aj_nom.Text) And Valider_Adresse(txt_aj_adresse.Text) And Valider_Ville(cbo_aj_villes.Text) And
            Valider_CodePostal(txt_aj_cp.Text) And Valider_Nom_Contact(txt_aj_ctnom.Text) And Valider_Prenom_Contact(txt_aj_ctprenom.Text) And
            Valider_Courriel(txt_aj_ctcourriel.Text) And Valider_Liste_Telephones(tel_list) And Valider_Site_Web(txt_aj_siteWeb.Text) And Valider_Titre(txt_aj_titre.Text) Then

            If btn_valider.Text = "Ajouter" Then
                Ajouter_Fournisseur()
            Else
                Modifier_Fournisseur()
            End If

            entrees_ignorees = 0
            VerticalScroll.Value = VerticalScroll.Minimum
            Return True
        Else
            Return False
        End If

    End Function

    ''' <summary>
    ''' Fonction permettant de contrôler les doublons! Si les 4 critères concordent, le fournisseur existe déjà et on doit donc empêcher l'ajout.
    ''' </summary>
    ''' <param name="nom_fournisseur">Le nom du fournisseur (la case 0 du dgv)</param>
    ''' <param name="adresse">L'adresse du fournisseur (la case 1 du dgv)</param>
    ''' <param name="ville">La ville du fournisseur ((la case 2 du dgv)</param>
    ''' <param name="code_postal">Le code postal du fournisseur (la case 3 du dgv)</param>
    ''' <returns></returns>
    Function Existe_Deja(nom_fournisseur As String, adresse As String, ville As String, code_postal As String) As Boolean
        Dim _ds As New DataSet
        Dim requete As String = "SELECT COUNT(*) FROM tbl_fournisseurs
                                 WHERE nom_fournisseur = '" & ConvertirApostrophe(nom_fournisseur.Trim) & "' AND adresse = '" & ConvertirApostrophe(adresse.Trim) &
                                 "' AND ville = (SELECT no_ville FROM tbl_ville WHERE nom_ville = '" & ConvertirApostrophe(ville) & "') AND code_postal = '" & code_postal.Trim & "'"
        bd.miseAjourDS(_ds, da, requete, "tbl_fournisseurs")

        'Si le nombre de lignes retournées est > 0 alors... il existe déjà.
        If _ds.Tables(0).Rows(0).Item(0) > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btn_valider_Click(sender As Object, e As EventArgs) Handles btn_valider.Click
        Valider_Ensemble()
    End Sub
#End Region
    '
    '
    '
    '
    '
#Region "Ajouter un fournisseur"
    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        pnl_ajout_mod.Focus()
        pnl_recherches.Enabled = False
        Changer_Enabled()
        btn_valider.Text = "Ajouter"
        Vider_Ajouts()
        tel_list.Clear()
        pnl_tel.Controls.Clear()
        dgv_fournisseurs.Enabled = False
        btn_ajouter.Enabled = False
        btn_modifier.Enabled = False
        btn_visualiser.Enabled = False
        btn_reactiver.Enabled = False
        btn_desactiver.Enabled = False
        btn_associer.Enabled = False
        btnRechercher.Enabled = False
        btnReinitialiser.Enabled = False

        Dim usr_tel As New usr_tel_lst(0, Me)
        pnl_tel.Controls.Add(usr_tel)
        usr_tel.Location = New Point(0, 1)

        MessageBox.Show("Vous allez maintenant procéder à l'ajout d'un fournisseur." & vbCrLf & vbCrLf &
               "Sachez que vous n'aurez pas accès aux autres fonctionnalités de cette page tant que l'action ne sera pas annulée ou complétée." & vbCrLf & vbCrLf &
               "(Pour annuler, appuyez sur le bouton Annuler en bas de la page)", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Sub Vider_Ajouts()
        Dim tab_controles() As Control = {txt_aj_adresse, txt_aj_cp, txt_aj_ctcourriel, txt_aj_ctnom, txt_aj_ctprenom, txt_aj_titre, txt_aj_nom, txt_aj_remarque,
                                          txt_aj_siteWeb}
        For i As Integer = 0 To tab_controles.Count - 1
            tab_controles(i).Text = String.Empty
        Next
        nm_aj_frais.Text = 0
        nm_aj_qte.Value = 0
        cbo_aj_villes.SelectedIndex = 0
        pnl_tel.Controls.Clear()
        tel_list.Clear()
    End Sub

    Sub Ajouter_Fournisseur()
        Try
            Dim id_fournisseur As String = Generer_Code()

            If Existe_Deja(txt_aj_nom.Text, txt_aj_adresse.Text, cbo_aj_villes.Text, txt_aj_cp.Text) Then
                MessageBox.Show("Erreur, ce fournisseur existe déjà à cet endroit!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                bd.InsDelUpd("INSERT INTO tbl_fournisseurs VALUES ('" & id_fournisseur & "', '" & ConvertirApostrophe(txt_aj_nom.Text.Trim) &
                         "', (SELECT no_ville FROM tbl_ville WHERE nom_ville = '" & ConvertirApostrophe(cbo_aj_villes.Text) & "'), '" &
                         txt_aj_cp.Text.ToUpper & "', '" & ConvertirApostrophe(txt_aj_adresse.Text.Trim) & "', '" & ConvertirApostrophe(txt_aj_ctnom.Text.Trim) & "', '" &
                         ConvertirApostrophe(txt_aj_ctprenom.Text.Trim) & "', '" & ConvertirApostrophe(txt_aj_titre.Text.Trim) & "', '" & txt_aj_ctcourriel.Text.Trim & "', '" & txt_aj_siteWeb.Text.Trim & "', " & nm_aj_frais.Value.ToString.Replace(",", ".") & ", " &
                         nm_aj_qte.Value & ", '" & corriger_null(ConvertirApostrophe(txt_aj_remarque.Text.Trim)) & "', true)")

                Changer_Enabled()
                dgv_fournisseurs.Enabled = True
                pnl_recherches.Enabled = True

                Ajouter_Telephones(id_fournisseur)
                Vider_Ajouts()
                Rafraichir_Boutons()
                VerticalScroll.Value = VerticalScroll.Minimum
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Le fournisseur a été ajouté.", cls_animation_operation.Reussie)
            End If

        Catch ex As Exception
            animation.Lancement(timer_succes, lbl_ajoutSucces, "Le fournisseur n'a pas pu être ajouté.", cls_animation_operation.Echec)
        End Try
        Rechercher_Fournisseur(rdb_actifs_oui, rdb_actifs_non)
    End Sub

    'on ajoute les numéros de téléphone dans la table des téléphones à partir de la liste
    Sub Ajouter_Telephones(id_fournisseur As String)
        For i As Integer = 0 To tel_list.Count - 1 - entrees_ignorees
            Try

                bd.InsDelUpd("INSERT INTO tbl_telephones VALUES (null, '" & id_fournisseur & "', '" & tel_list(i).cbo_type.Text & "', '" &
                             tel_list(i).txt_numero.Text & "', '" & tel_list(i).txt_poste.Text & "', '')")

            Catch ex As Exception

            End Try
        Next
        tel_list.Clear()
    End Sub


#End Region
    '
    '
    '
    '
    '
#Region "Modifier un fournisseur"

    Private Sub btn_modifier_Click(sender As Object, e As EventArgs) Handles btn_modifier.Click
        pnl_ajout_mod.Focus()
        pnl_recherches.Enabled = False
        Changer_Enabled()
        btn_valider.Text = "Enregistrer"
        dgv_fournisseurs.Enabled = False
        btn_ajouter.Enabled = False
        btn_modifier.Enabled = False
        btn_visualiser.Enabled = False
        btn_reactiver.Enabled = False
        btn_associer.Enabled = False
        btn_desactiver.Enabled = False
        btnRechercher.Enabled = False
        btnReinitialiser.Enabled = False

        pnl_tel.Controls.Clear()
        tel_list.Clear()

        'Ajoute les numéros de téléphone dans la liste.'
        Ajouter_Numero(True)

        'Détermine si la position du "nouveau" numéro est au début ou à la suite.'
        Dim laLocation As New Point

        If tel_list.Count > 0 Then
            laLocation = New Point(0, tel_list(0).Location.Y + 30)
        Else
            laLocation = New Point(0, 1)
        End If

        'Crée le "nouveau" numéro.'
        Dim usr_tel As New usr_tel_lst(tel_list.Count, Me)
        usr_tel.Location = laLocation
        pnl_tel.Controls.Add(usr_tel)

        tel_list(tel_list.Count - 1).Name = "Tlphn" & tel_list.Count - 1
        tel_list(tel_list.Count - 1).rangee = tel_list.Count - 1


        MessageBox.Show("Vous allez maintenant procéder à la modification d'un fournisseur." & vbCrLf & vbCrLf &
               "Sachez que vous n'aurez pas accès aux autres fonctionnalités de cette page tant que l'action ne sera pas annulée ou complétée." & vbCrLf & vbCrLf &
               "(Pour annuler, appuyez sur le bouton Annuler en bas de la page)", "Modification d'un fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Sub Modifier_Fournisseur()
        Try
            'On sauvegarde l'ID du fournisseur que l'on modifie
            Dim id_temp As String = id

            If Existe_Deja(txt_aj_nom.Text, txt_aj_adresse.Text, cbo_aj_villes.Text, txt_aj_cp.Text) And Trouver_ID_Fournisseur(txt_aj_nom.Text, txt_aj_adresse.Text, cbo_aj_villes.Text, txt_aj_cp.Text) <> id_temp Then
                MessageBox.Show("Un fournisseur existe déjà à cet endroit, veuillez modifier les coordonnées.", "Erreur")
            Else

                bd.InsDelUpd("UPDATE tbl_fournisseurs SET 
                            nom_fournisseur = '" & ConvertirApostrophe(txt_aj_nom.Text.Trim) & "', ville = (SELECT no_ville FROM tbl_ville WHERE nom_ville = '" & ConvertirApostrophe(cbo_aj_villes.Text) & "'),
                            code_postal = '" & txt_aj_cp.Text.ToUpper & "', adresse = '" & ConvertirApostrophe(txt_aj_adresse.Text.Trim) & "', nom_contact = '" & ConvertirApostrophe(txt_aj_ctnom.Text.Trim) & "', 
                            prenom_contact = '" & ConvertirApostrophe(txt_aj_ctprenom.Text.Trim) & "', adresse_couriel_contact = '" & txt_aj_ctcourriel.Text.Trim & "', lien_internet = '" & txt_aj_siteWeb.Text.Trim & "', 
                            frais_livraison = '" & nm_aj_frais.Value.ToString.Replace(",", ".") & "', qte_min_commande = " & nm_aj_qte.Value & ", remarque = '" & ConvertirApostrophe(txt_aj_remarque.Text.Trim) & "',
                            titre_contact = '" & ConvertirApostrophe(txt_aj_titre.Text.Trim) & "' WHERE no_fournisseur = '" & id_temp & "'")

                Modifier_Telephones()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Sub Modifier_Telephones()
        Try
            'On supprime tous les numéros de téléphones actifs de ce fournisseur...
            bd.InsDelUpd("DELETE FROM tbl_telephones WHERE no_fournisseur = '" & id & "'")
            'Pour les réajouter par la suite.
            Ajouter_Telephones(id)

            Changer_Enabled()
            dgv_fournisseurs.Enabled = True
            pnl_recherches.Enabled = True
            btnRechercher.Enabled = True
            btnReinitialiser.Enabled = True
            Vider_Ajouts()
            Rafraichir_Boutons()
            VerticalScroll.Value = VerticalScroll.Minimum
            animation.Lancement(timer_succes, lbl_ajoutSucces, "Le fournisseur a été modifié.", cls_animation_operation.Reussie)
            Rechercher_Fournisseur(rdb_actifs_oui, rdb_actifs_non)
        Catch ex As Exception

            animation.Lancement(timer_succes, lbl_ajoutSucces, "Le fournisseur n'a pas pu être modifié.", cls_animation_operation.Echec)
        End Try
    End Sub
#End Region

    Private Sub timer_succes_Tick(sender As Object, e As EventArgs) Handles timer_succes.Tick
        animation.Operation(sender, lbl_ajoutSucces)
    End Sub

    Sub Changer_Enabled()
        Dim tab_controles() As Control = {txt_aj_adresse, txt_aj_cp, txt_aj_ctcourriel, txt_aj_ctnom, txt_aj_ctprenom, txt_aj_titre, txt_aj_nom, txt_aj_remarque,
                                          txt_aj_siteWeb, cbo_aj_villes, btn_valider, pnl_tel, btn_annuler, nm_aj_frais, nm_aj_qte, rdb_actifs_non, rdb_actifs_oui, rdb_actifs_tous}
        For i As Integer = 0 To tab_controles.Count - 1
            If tab_controles(i).Enabled = False Then
                tab_controles(i).Enabled = True
            Else
                tab_controles(i).Enabled = False
            End If
        Next

    End Sub

    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        If MessageBox.Show("Désirez-vous annuler l'action en cours?", "Annulation",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Changer_Enabled()
            dgv_fournisseurs.Enabled = True
            Rafraichir_Boutons()
            pnl_recherches.Enabled = True
            btnRechercher.Enabled = True
            btnReinitialiser.Enabled = True
            pnl_recherches.Focus()
        End If
    End Sub

    Private Sub btn_visualiser_Click(sender As Object, e As EventArgs) Handles btn_visualiser.Click
        pnl_ajout_mod.Focus()
    End Sub


    ' ON NE TOUCHE PAS. C'EST PARFAIT COMME TEL. SVP.
    ' - Keven Abel (en collaboration avec Zac Veillette)
    Sub Ajouter_Numero(visible As Boolean)
        Dim position As Integer = 1

        For i As Integer = 0 To ds_tel.Tables(0).Rows.Count - 1
            With ds_tel.Tables(0).Rows(i)

                Dim usr_tel As New usr_tel_lst(i, .Item(0), .Item(1), .Item(2), Me)
                usr_tel.btn_ajouter.Visible = False
                usr_tel.btn_suppr.Visible = visible

                pnl_tel.Controls.Add(usr_tel)

                usr_tel.Location = New Point(0, position)

                position += 30
                usr_tel.BringToFront()

            End With
        Next

        tel_list.Clear()

        If pnl_tel.Controls.Count > 0 Then

            For i As Integer = 0 To pnl_tel.Controls.Count - 1
                tel_list.Add(pnl_tel.Controls(i))
                tel_list(i).Name = "Tlphn" & i
                tel_list(i).rangee = i
            Next
        End If
    End Sub

    Private Sub btnReinitialiser_Click(sender As Object, e As EventArgs) Handles btnReinitialiser.Click
        Dim tab_recherches() As Control = {txt_rech_nom, txt_rech_telephone, txt_rech_ville, txt_rech_adresse}
        Dim tab_limites() As NumericUpDown = {nm_commande_inf, nm_commande_sup, nm_frais_inf, nm_frais_sup}
        Dim tab_cbo() As ComboBox = {cbo_rech_frais, cbo_rech_quantite, cbo_nom_contient, cbo_adresse_contient, cbo_ville_contient, cbo_trier_par, cbo_ordre}

        For i As Integer = 0 To tab_recherches.Count - 1
            tab_recherches(i).Text = ""
        Next

        For i As Integer = 0 To tab_limites.Count - 1
            tab_limites(i).Value = 0
        Next

        For i As Integer = 0 To tab_cbo.Count - 1
            tab_cbo(i).SelectedIndex = 0
        Next

        rdb_actifs_oui.Checked = True
        Rechercher_Fournisseur()
    End Sub

    Private Sub btn_associer_Click(sender As Object, e As EventArgs) Handles btn_associer.Click
        Dim frm_association As New frm_associer_produit(id)
        frm_association.ShowDialog()
    End Sub
End Class
