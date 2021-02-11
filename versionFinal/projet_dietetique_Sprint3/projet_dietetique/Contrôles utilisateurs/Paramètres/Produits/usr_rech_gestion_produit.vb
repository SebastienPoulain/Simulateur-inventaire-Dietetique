Imports System.Data.Sql
Imports MySql.Data.MySqlClient

Public Class usr_rech_gestion_produit
    Dim bd As New Connexion
    Dim ds, _ds, ds_taxes As New DataSet
    Dim da As MySqlDataAdapter
    Dim animation As New cls_animation_operation
    Dim requete As String
    Dim usr_menu As usr_gestion_Menuproduits
    Dim code As String
#Region "Éléments de recherche à sauvegarder"
    Dim nom_produit As String = ""
    Dim marque_produit As String = ""
    Dim categorie As String = ""
    Dim allergenes As String = ""
    Dim description As String = ""
    Dim perissable As String = ""
    Dim tri As String = ""
    Dim bio As String = ""
#End Region
    '
    '
    '
    '
    '
#Region "Éléments pour l'ajout ou la modification"
    Dim aj_code_produit, aj_nom_produit, aj_marque, aj_categorie,
        aj_code_barre, aj_code_plu, aj_format, aj_unite_mesure, aj_description,
        aj_remarque, aj_allergenes As String
    Dim aj_quantite As Double
    Dim aj_perissable, aj_bio As Boolean
#End Region
    '
    '
    '
    '
    '
#Region "Manipulation de DataGridView"
    Private Sub dgv_produits_CellMouseLeave(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_produits.CellMouseLeave
        If e.RowIndex > -1 Then
            dgv_produits.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
            dgv_produits.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
        End If
    End Sub

    Private Sub dgv_produits_CellMouseEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_produits.CellMouseEnter
        If e.RowIndex > -1 Then

            dgv_produits.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(236, 240, 241)
            dgv_produits.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black

        End If
    End Sub

    Sub Rafraichir_Boutons()
        Dim _ds As New DataSet

        bd.Requete("SELECT actif FROM tbl_produits WHERE code_produit = '" & code & "'", _ds, da, "tbl_produits")
        If _ds.Tables(0).Rows.Count = 0 Then
            pnl_rien.Show()
            btn_reactiver.Enabled = False
            btn_desactiver.Enabled = False
            btn_associer.Enabled = False
            btn_modifier.Enabled = False
            btn_visualiser.Enabled = False
            btn_excel.Enabled = False
        ElseIf _ds.Tables(0).Rows(0).Item(0) = False Then
            pnl_rien.Hide()
            btn_reactiver.Enabled = True
            btn_desactiver.Enabled = False
            btn_associer.Enabled = False
            btn_modifier.Enabled = True
            btn_visualiser.Enabled = True
            btn_excel.Enabled = True
        Else
            pnl_rien.Hide()
            btn_desactiver.Enabled = True
            btn_reactiver.Enabled = False
            btn_associer.Enabled = True
            btn_modifier.Enabled = True
            btn_visualiser.Enabled = True
            btn_excel.Enabled = True
        End If
        btn_ajouter.Enabled = True
    End Sub

    Private Sub dgv_produits_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_produits.CellClick
        If e.RowIndex > -1 Then
            code = dgv_produits.Rows(e.RowIndex).Cells(0).Value
            Rafraichir_Boutons()
            Recuperer_Produits(code)
            Remplir_Controles()
        End If
    End Sub

    Private Sub dgv_produits_MultiSelectChanged(sender As Object, e As EventArgs) Handles dgv_produits.SelectionChanged
        If dgv_produits.SelectedRows.Count > 1 Then
            If rdb_actifs_oui.Checked Then
                btn_desactiver.Enabled = True
                btn_reactiver.Enabled = False
            ElseIf rdb_actifs_non.Checked Then
                btn_reactiver.Enabled = True
                btn_desactiver.Enabled = False
            End If
            btn_associer.Enabled = False
            btn_modifier.Enabled = False
            btn_visualiser.Enabled = False
        End If
    End Sub

    Sub Rafraichir_MultiSelect()
        If rdb_actifs_oui.Checked Or rdb_actifs_non.Checked Then
            dgv_produits.MultiSelect = True
        Else
            dgv_produits.MultiSelect = False
        End If
    End Sub


#End Region
    '
    '
    '
    '
    '
#Region "Couleur des boutons"
    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btnRechercher.MouseEnter, btn_excel.MouseEnter, btn_ajouter.MouseEnter, btn_Taux_taxes.MouseEnter,
                                                                         btnReinitialiser.MouseEnter, btn_modifier.MouseEnter, btn_valider.MouseEnter,
                                                                         btn_desactiver.MouseEnter, btn_reactiver.MouseEnter, btn_annuler.MouseEnter,
                                                                         btn_visualiser.MouseEnter, btn_associer.MouseEnter, btn_Ajout_Allergene.MouseEnter, btn_historique_taxes.MouseEnter

        sender.BackColor = Color.White
        sender.ForeColor = Color.Black
    End Sub

    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btnRechercher.MouseLeave, btn_excel.MouseLeave, btn_ajouter.MouseLeave,
                                                                         btnReinitialiser.MouseLeave, btn_modifier.MouseLeave, btn_valider.MouseLeave, btn_Taux_taxes.MouseLeave,
                                                                         btn_desactiver.MouseLeave, btn_reactiver.MouseLeave, btn_annuler.MouseLeave, btn_Ajout_Allergene.MouseLeave,
                                                                         btn_visualiser.MouseLeave, btn_associer.MouseLeave, btn_historique_taxes.MouseLeave

        If sender.Text = btn_desactiver.Text Or sender.Text = btnReinitialiser.Text Or sender.Text = btn_annuler.Text Then
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
    '
    '
    '
    '
    '
    Sub New(usr_menuProd As usr_gestion_Menuproduits)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        usr_menu = usr_menuProd
    End Sub

    Private Sub usr_rech_gestion_produit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reinitialiser_Criteres()
        Remplir_Unites(_ds, da, bd, cms_unites_mesure)
        Remplir_Combobox(bd, "nom_categorie", "tbl_categories", cbo_categories)
        Remplir_Combobox(bd, "nom_format", "tbl_formats", cbo_format)
        Remplir_Combobox(bd, "nom_categorie", "tbl_categories", cbo_rech_categorie)
        btn_visualiser.Enabled = False
        btn_modifier.Enabled = False
        dgv_produits.RowTemplate.Height = 30
        dgv_produits.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgv_produits.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgv_produits.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgv_produits.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgv_produits.Columns(10).Visible = False
    End Sub

    'On fait appel à cette version de Charger_DS pour la datagridview
    Sub Recuperer_Produits()

        bd.miseAjourDS(ds, da, "SELECT code_produit AS `No. Produit`, nom_produit AS `Nom`, marque AS `Marque`, nom_categorie AS `Categorie`, nom_format AS `Format`, 
                                nbr_unite_format, unite_mesure, if(perissable, 'Oui', 'Non') AS `Perissable`, if(bio, 'Oui', 'Non') as `Bio`,
                                if(description = '', 'Non', 'Oui') AS `Description`, if(allergene = '', 'Non', 'Oui') AS `Allergenes`,
                                if(p.actif, 'Oui', 'Non') as `Actif`                              
                                FROM tbl_produits p
                                INNER JOIN tbl_formats f ON p.no_format = f.no_format
                                INNER JOIN tbl_categories c ON p.no_categorie = c.no_categorie
                                INNER JOIN tbl_unites_mesure on tbl_unites_mesure.no_mesure = p.no_mesure
                                ORDER BY code_produit", "tbl_produits")

        Remplir_Produits()
    End Sub

    'Il existe pour faire afficher les produits que l'on clique!
    Sub Recuperer_Produits(p_code As String)
        Dim requete As String = "Select nom_produit, code_produit, if(code_barre <> '', code_barre, ''), if(code_plu <> '', code_plu, ''), nom_format, nom_categorie, unite_mesure, 
                                if(description <> '', description, ''), if(p.remarque <> '', p.remarque, ''), nbr_unite_format, marque, 
                                if(allergene <> '', allergene, ''), if(perissable, 'Oui', 'Non'), if(bio, 'Oui', 'Non')                                
                                FROM tbl_produits p
                                INNER JOIN tbl_formats f ON p.no_format = f.no_format
                                INNER JOIN tbl_categories c ON p.no_categorie = c.no_categorie
                                INNER JOIN tbl_unites_mesure um ON p.no_mesure = um.no_mesure
                                WHERE code_produit = '" & p_code & "'"
        Dim requete_taxes As String = "SELECT DISTINCT type_taxe FROM tbl_taxes
                                       INNER JOIN tbl_produit_taxe ON tbl_taxes.id_taxes = tbl_produit_taxe.id_taxe
                                       WHERE code_produit = '" & p_code & "'"
        bd.miseAjourDS(_ds, da, requete, "tbl_produits")
        bd.miseAjourDS(ds_taxes, da, requete_taxes, "tbl_produit_taxe")
    End Sub

    'on remplit le datagrid de cette façon
    Sub Remplir_Produits()
        dgv_produits.Rows.Clear()
        With ds.Tables(0)
            For i As Integer = 0 To .Rows.Count - 1
                dgv_produits.Rows.Add(.Rows(i).Item(0))

                dgv_produits.Rows(dgv_produits.Rows.Count - 1).Cells(1).Value = .Rows(i).Item(1)
                dgv_produits.Rows(dgv_produits.Rows.Count - 1).Cells(2).Value = .Rows(i).Item(2)
                dgv_produits.Rows(dgv_produits.Rows.Count - 1).Cells(3).Value = .Rows(i).Item(3)
                dgv_produits.Rows(dgv_produits.Rows.Count - 1).Cells(4).Value = .Rows(i).Item(4)
                dgv_produits.Rows(dgv_produits.Rows.Count - 1).Cells(5).Value = .Rows(i).Item(5) & " " & .Rows(i).Item(6)
                dgv_produits.Rows(dgv_produits.Rows.Count - 1).Cells(6).Value = .Rows(i).Item(7)
                dgv_produits.Rows(dgv_produits.Rows.Count - 1).Cells(7).Value = .Rows(i).Item(8)
                dgv_produits.Rows(dgv_produits.Rows.Count - 1).Cells(8).Value = .Rows(i).Item(9)
                dgv_produits.Rows(dgv_produits.Rows.Count - 1).Cells(9).Value = .Rows(i).Item(10)


                'on met en gris lorsque c'est inactif, et en noir lorsque c'est actif
                If .Rows(i).Item(11) = "Non" Then
                    dgv_produits.Rows(dgv_produits.Rows.Count - 1).Cells(0).Tag = "0"
                    For j As Integer = 0 To 10
                        dgv_produits.Rows(dgv_produits.Rows.Count - 1).Cells(j).Style.ForeColor = Color.DimGray
                    Next
                Else
                    dgv_produits.Rows(dgv_produits.Rows.Count - 1).Cells(0).Tag = "1"
                End If
            Next
        End With
    End Sub

    'Combo avec Recuperer_Produits(p_code as String) pour remplir les belles, belles textbox en bas de la page.
    Sub Remplir_Controles()
        Dim tab_controles() As Control = {txt_nom_produit, txt_no_produit, txt_code_barre, txt_code_plu, cbo_format, cbo_categories, lbl_mesure, txt_description,
                                          txt_remarque, nm_quantite, txt_marque, txt_allergenes, cbo_perissable, cbo_bio}
        With _ds.Tables(0)
            For i = 0 To .Columns.Count - 1
                tab_controles(i).Text = .Rows(0).Item(i)
            Next
        End With


        With ds_taxes.Tables(0)
            If .Rows.Count > 0 Then

                If Taxe_Trouvee("TPS") Then
                    chk_tps.Checked = True
                Else
                    chk_tps.Checked = False
                End If


                If Taxe_Trouvee("TVQ") Then
                    chk_tvq.Checked = True
                Else
                    chk_tvq.Checked = False
                End If
            Else
                chk_tps.Checked = False
                chk_tvq.Checked = False
            End If
        End With
    End Sub

    Function Taxe_Trouvee(taxe As String) As Boolean
        For i As Integer = 0 To ds_taxes.Tables(0).Rows.Count - 1
            If ds_taxes.Tables(0).Rows(i).Item(0) = taxe Then
                Return True
            ElseIf i = ds_taxes.Tables(0).Rows.Count - 1 Then
                Return False
            End If
        Next

        Return ""
    End Function

    'Étant donné que les TextBox sont du type Multi-Line, appuyer sur Enter faisait un saut de ligne. (On ne veut pas de saut de ligne.)
    'Appuyer sur Enter ne fera donc pas de saut de ligne (en bonus, ça va lancer une recherche)
    Private Sub txt_allergenes_keyword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_allergenes_keyword.KeyPress, txt_description_keyword.KeyPress,
                                                                                                  txt_rech_marque.KeyPress, txt_rech_nom.KeyPress
        If e.KeyChar() = Chr(13) Then
            e.Handled = True
            Declarer_Requete()
        End If
    End Sub

    Sub Reinitialiser_Criteres()
        Dim tab_recherches() As Control = {txt_rech_nom, txt_rech_marque, cbo_rech_categorie, txt_description_keyword, txt_allergenes_keyword, cbo_allergenes,
                                           cbo_description, cbo_nom_contient, cbo_marque_contient}
        For i = 0 To tab_recherches.Count - 1
            tab_recherches(i).Text = String.Empty
        Next

        'Mettre une valeur par défaut pour certains combobox évitent de taper inutilement dans un TextBox (et donc faire une recherche qui ne retourne rien)
        'Comme ça, le ComboBox ne sera pas vide et retournera nécessairement une recherche si l'utilisateur inscrit quelque chose dans la TextBox pour le nom et la marque.
        cbo_ordre.SelectedIndex = 0
        cbo_trier_par.SelectedIndex = 0
        cbo_nom_contient.SelectedIndex = 0
        cbo_marque_contient.SelectedIndex = 0
        cbo_rech_categorie.SelectedIndex = 0
        cbo_allergenes.SelectedIndex = 4
        cbo_description.SelectedIndex = 3
        rdb_actifs_oui.Checked = True
        rdb_perissable_tous.Checked = True
        rdb_bio_tous.Checked = True
    End Sub

#Region "Requêtes Recherche"

    Sub Declarer_Requete()
        'Sauvegarde des éléments de la requête. Va servir lorsqu'on cherchera la liste des produits selon le niveau d'activité. (Voir méthode surchargée)
        'Fouille-moi pourquoi, le programme aime pas ça quand je met le bloc suivant dans une méthode séparée :I
        nom_produit = Rechercher_Selon_Contenu("nom_produit", cbo_nom_contient, ConvertirApostrophe(txt_rech_nom.Text))
        marque_produit = Rechercher_Selon_Contenu("marque", cbo_marque_contient, ConvertirApostrophe(txt_rech_marque.Text))
        categorie = Rechercher_Categories(ConvertirApostrophe(cbo_rech_categorie.Text))
        perissable = Rechercher_Perissable(rdb_perissable_oui, rdb_perissable_non)
        allergenes = Rechercher_Allergenes(cbo_allergenes.Text, ConvertirApostrophe(txt_allergenes_keyword.Text))
        description = Rechercher_Description(cbo_description.Text, ConvertirApostrophe(txt_description_keyword.Text))
        tri = Verifier_Tri(cbo_trier_par.Text, cbo_ordre.Text)
        bio = Rechercher_Bio(rdb_bio_oui, rdb_bio_non)

        requete = "SELECT code_produit AS `No. Produit`, nom_produit AS `Nom`, marque AS `Marque`, 
                    nom_categorie AS `Categorie`, nom_format AS `Format`, nbr_unite_format, unite_mesure, if(perissable, 'Oui', 'Non') AS `Perissable`,
                    if(bio, 'Oui', 'Non') as `Bio`, if(description = '', 'Non', 'Oui') AS `Description`, if(allergene = '', 'Non', 'Oui') AS `Allergenes`,
                    if(p.actif, 'Oui', 'Non') as `Actif`
                    FROM tbl_produits p
                    INNER JOIN tbl_formats f ON p.no_format = f.no_format
                    INNER JOIN tbl_categories c ON p.no_categorie = c.no_categorie
                    INNER JOIN tbl_unites_mesure on tbl_unites_mesure.no_mesure = p.no_mesure
                    WHERE " & Verifier_Activite(rdb_actifs_oui, rdb_actifs_non, "p") &
                    Rechercher_Selon_Contenu("nom_produit", cbo_nom_contient, ConvertirApostrophe(txt_rech_nom.Text)) &
                    Rechercher_Selon_Contenu("marque", cbo_marque_contient, ConvertirApostrophe(txt_rech_marque.Text)) &
                    Rechercher_Categories(ConvertirApostrophe(cbo_rech_categorie.Text)) &
                    Rechercher_Perissable(rdb_perissable_oui, rdb_perissable_non) &
                    Rechercher_Allergenes(cbo_allergenes.Text, ConvertirApostrophe(txt_allergenes_keyword.Text)) &
                    Rechercher_Description(cbo_description.Text, ConvertirApostrophe(txt_description_keyword.Text)) &
                    Rechercher_Bio(rdb_bio_oui, rdb_bio_non) &
                    Verifier_Tri(cbo_trier_par.Text, cbo_ordre.Text)

        bd.miseAjourDS(ds, da, requete, "tbl_produits")
        Remplir_Produits()

    End Sub

    Sub Declarer_Requete(ByVal radio_oui As RadioButton, ByVal radio_non As RadioButton)
        requete = "SELECT code_produit AS `No. Produit`, nom_produit AS `Nom`, marque AS `Marque`, 
                   nom_categorie AS `Categorie`, nom_format AS `Format`, nbr_unite_format, unite_mesure, if(perissable, 'Oui', 'Non') AS `Perissable`,
                   if(bio, 'Oui', 'Non') as `Bio`, if(description = '', 'Non', 'Oui') AS `Description`, 
                   if(allergene = '', 'Non', 'Oui') AS `Allergenes`, if(p.actif, 'Oui', 'Non') as `Actif`   
                   FROM tbl_produits p
                   INNER JOIN tbl_formats f ON p.no_format = f.no_format
                   INNER JOIN tbl_categories c ON p.no_categorie = c.no_categorie
                   INNER JOIN tbl_unites_mesure on tbl_unites_mesure.no_mesure = p.no_mesure
                   WHERE " & Verifier_Activite(rdb_actifs_oui, rdb_actifs_non, "p") &
                   nom_produit & marque_produit & categorie & perissable & allergenes & description & bio & tri

        bd.miseAjourDS(ds, da, requete, "tbl_produits")
        Remplir_Produits()

    End Sub

    Private Sub rdb_actifs_oui_CheckedChanged(sender As RadioButton, e As EventArgs) Handles rdb_actifs_oui.CheckedChanged, rdb_actifs_non.CheckedChanged, rdb_actifs_tous.CheckedChanged
        Declarer_Requete(rdb_actifs_oui, rdb_actifs_non)
        Rafraichir_MultiSelect()
        If ds.Tables(0).Rows.Count > 0 Then
            code = dgv_produits.Rows(0).Cells(0).Value
        End If

        Rafraichir_Boutons()
    End Sub

    'Oh la récursive! On enlève les points virgules supplémentaires à la fin du mot clé.
    Sub Enlever_Point_Virgule(ByRef kw As String, ByVal i As Integer)
        If Not i < 0 Then
            Dim _char() As Char = kw
            If _char(i) = Chr(59) Then
                _char(i) = ""
                kw = New String(_char)
                Enlever_Point_Virgule(kw, i - 1)
            End If
        End If
    End Sub

    Private Sub btnRechercher_Click(sender As Object, e As EventArgs) Handles btnRechercher.Click
        If txt_description_keyword.TextLength <> 0 Then
            Enlever_Point_Virgule(txt_description_keyword.Text, txt_description_keyword.TextLength - 1)
        End If

        If txt_allergenes_keyword.TextLength <> 0 Then
            Enlever_Point_Virgule(txt_allergenes_keyword.Text, txt_allergenes_keyword.TextLength - 1)
        End If
        Declarer_Requete()
    End Sub

    Private Sub btnReinitialiser_Click(sender As Object, e As EventArgs) Handles btnReinitialiser.Click
        Reinitialiser_Criteres()
        Declarer_Requete()
    End Sub

    Private Sub cbo_allergenes_SelectedIndexChanged(sender As ComboBox, e As EventArgs) Handles cbo_allergenes.SelectedIndexChanged
        If sender.SelectedIndex = 2 Or sender.SelectedIndex = 3 Then
            txt_allergenes_keyword.Enabled = True
        Else
            txt_allergenes_keyword.Enabled = False
        End If
    End Sub

    Private Sub cbo_description_SelectedIndexChanged(sender As ComboBox, e As EventArgs) Handles cbo_description.SelectedIndexChanged
        If sender.SelectedIndex = 2 Then
            txt_description_keyword.Enabled = True
        Else
            txt_description_keyword.Enabled = False
        End If
    End Sub
#End Region
    '
    '
    '
    '
    '
#Region "Activation/Désactivation"
    Private Sub btn_desactiver_Click(sender As Object, e As EventArgs) Handles btn_desactiver.Click
        If MessageBox.Show("Désirez-vous désactiver ce(s) produit(s)?" & vbCrLf & vbCrLf & "(Sachez que vous pouvez les réactiver plus tard)", "Désactivation de produits",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Desactiver_Produit()
        End If
    End Sub

    Private Sub btn_reactiver_Click(sender As Object, e As EventArgs) Handles btn_reactiver.Click
        If MessageBox.Show("Désirez-vous réactiver ce(s) produit(s)?" & vbCrLf & vbCrLf & "(Sachez que vous pouvez les désactiver plus tard)", "Réactivation de produits",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Activer_Produit()
        End If
    End Sub

    Sub Activer_Produit()
        Dim echec As String = ""
        Dim noMsg As Boolean
        Dim strRequete

        Cursor = Cursors.AppStarting
        For i As Integer = 0 To dgv_produits.SelectedRows.Count - 1
            With dgv_produits.SelectedRows(i)

                strRequete = "UPDATE tbl_produits SET actif = 1 WHERE code_produit = '" & .Cells(0).Value & "';"

                Try
                    bd.InsDelUpd(strRequete)
                Catch ex As Exception
                    echec &= " " & .Cells(0).Value
                End Try

                If dgv_produits.SelectedRows.Count = 1 Then
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
        Declarer_Requete(rdb_actifs_oui, rdb_actifs_non)
    End Sub

    Sub Desactiver_Produit()
        Dim echec As String = ""
        Dim noMsg As Boolean
        Dim strRequete

        Cursor = Cursors.AppStarting
        For i As Integer = 0 To dgv_produits.SelectedRows.Count - 1
            With dgv_produits.SelectedRows(i)

                strRequete = "UPDATE tbl_produits SET actif = 0 WHERE code_produit = '" & .Cells(0).Value & "';"

                Try
                    bd.InsDelUpd(strRequete)
                Catch ex As Exception
                    echec &= " " & .Cells(0).Value
                End Try

                If dgv_produits.SelectedRows.Count = 1 Then
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
        Declarer_Requete(rdb_actifs_oui, rdb_actifs_non)
    End Sub
#End Region
    '
    '
    '
    '
    '
#Region "Vérifications"
    Function Verifier_Numero(_numero As String) As Boolean
        If Est_Numero_Produit(_numero) Then
            lbl_erreur_numero.Hide()
            aj_code_produit = _numero
            Return True
        Else
            'S'il n'y a pas de code de produit, on en génère un.
            If _numero.Length = 0 Then
                aj_code_produit = Generer_Code()
                txt_no_produit.Text = aj_code_produit
                Return True
            End If

            lbl_erreur_numero.Show()
            If _numero.Length < 2 Or _numero.Length > 10 Then
                lbl_erreur_numero.Text = "Le numéro doit être entre 2 et 10 caractères."
            Else
                lbl_erreur_numero.Text = "Lettres et chiffres seulement"
            End If
            Return False
        End If
    End Function

    Function Verifier_Code_Barre(_code_barre As String) As Boolean
        If Est_Code_Barre(_code_barre) Or _code_barre = "" Then
            lbl_erreur_code_barre.Hide()
            aj_code_barre = _code_barre
            Return True
        Else
            lbl_erreur_code_barre.Show()

            If _code_barre.Length < 11 Or _code_barre.Length > 13 Then
                lbl_erreur_code_barre.Text = "Le code barre doit être entre 11 et 13 caractères."
            Else
                lbl_erreur_numero.Text = "Ne doit contenir que des chiffres."
            End If

            Return False
        End If
    End Function

    Function Verifier_Code_PLU(_code_plu As String) As Boolean
        If Est_Code_PLU(_code_plu) Or _code_plu = "" Then
            lbl_erreur_code_plu.Hide()
            aj_code_plu = corriger_null(_code_plu)
            Return True
        Else
            lbl_erreur_code_plu.Show()

            If _code_plu.Length < 4 Or _code_plu.Length > 5 Then
                lbl_erreur_code_plu.Text = "Le code PLU doit être de 4 ou 5 caractères."
            Else
                lbl_erreur_code_plu.Text = "Ne doit contenir que des chiffres."
            End If

            Return False
        End If
    End Function

    Function Verifier_Nom_Produit(nom As String) As Boolean
        If mod_regex.Exercice(nom) And nom <> "" Then
            lbl_erreur_nom_produit.Hide()
            aj_nom_produit = nom
            Return True
        Else
            lbl_erreur_nom_produit.Show()

            If nom = "" Then
                lbl_erreur_nom_produit.Text = "Veuillez entrer un nom de produit."
            Else
                lbl_erreur_nom_produit.Text = "Pas de caractères spéciaux (autre que le point)"
            End If

            Return False
        End If
    End Function

    Function Verifier_Marque(_marque As String) As Boolean
        If mod_regex.Exercice(_marque) And _marque <> "" Then
            lbl_erreur_marque.Hide()
            aj_marque = _marque
            Return True
        Else
            lbl_erreur_marque.Show()
            If aj_marque = "" Then
                lbl_erreur_marque.Text = "Veuillez entrer une marque."
            Else
                lbl_erreur_marque.Text = "Pas de caractères spéciaux (autre que le point)"
            End If

            Return False
        End If
    End Function

    Function Verifier_Categorie() As Boolean
        If cbo_categories.SelectedIndex > -1 Then
            lbl_erreur_categorie.Hide()
            aj_categorie = cbo_categories.Text
            Return True
        Else
            lbl_erreur_categorie.Show()
            lbl_erreur_categorie.Text = "Veuillez choisir une catégorie."
            Return False
        End If
    End Function



    Function Verifier_Perissable(choix As String) As Boolean
        If choix = "Oui" Or choix = "Non" Then
            lbl_erreur_perissable.Hide()

            If choix = "Oui" Then
                aj_perissable = True
            Else
                aj_perissable = False
            End If

            Return True
        Else
            lbl_erreur_perissable.Show()
            lbl_erreur_perissable.Text = "Veuillez choisir entre Oui et Non."
            Return False
        End If
    End Function

    Function Verifier_Format(choix As String) As Boolean
        If cbo_format.SelectedIndex > -1 Then
            lbl_erreur_format.Hide()
            aj_format = choix
            Return True
        Else
            lbl_erreur_format.Show()
            lbl_erreur_format.Text = "Veuillez choisir un format."
            Return False
        End If
    End Function

    Function Verifier_Mesure() As Boolean
        If lbl_mesure.Text <> "--- choisissez une unité de mesure ---" Then
            lbl_erreur_mesure.Hide()
            aj_unite_mesure = lbl_mesure.Text
            Return True
        Else
            lbl_erreur_mesure.Show()
            lbl_erreur_mesure.Text = "Veuillez choisir une mesure."
            Return False
        End If
    End Function

    Function Verifier_Quantite(_qte As String) As Boolean
        If Est_Nombre(_qte) Then
            lbl_erreur_quantite.Hide()
            aj_quantite = _qte
            Return True
        Else
            lbl_erreur_quantite.Show()
            lbl_erreur_quantite.Text = "Veuillez entrer une quantité"
            Return False
        End If
    End Function


    Function Verifier_Bio(choix As String) As Boolean
        If choix = "Oui" Or choix = "Non" Then
            lbl_erreur_bio.Hide()

            If choix = "Oui" Then
                aj_bio = True
            Else
                aj_bio = False
            End If

            Return True
        Else
            lbl_erreur_bio.Show()
            lbl_erreur_bio.Text = "Veuillez choisir entre Oui et Non."
            Return False
        End If
    End Function

    Function Verifier_Ensemble() As Boolean
        If Verifier_Numero(txt_no_produit.Text) And Verifier_Code_Barre(txt_code_barre.Text) And Verifier_Code_PLU(txt_code_plu.Text) And
           Verifier_Nom_Produit(txt_nom_produit.Text) And Verifier_Categorie() And Verifier_Marque(txt_marque.Text) And Verifier_Perissable(cbo_perissable.Text) And
           Verifier_Format(cbo_format.Text) And Verifier_Mesure() And Verifier_Quantite(nm_quantite.Value) And Verifier_Bio(cbo_bio.Text) Then

            aj_description = ConvertirApostrophe(corriger_null(txt_description.Text))
            aj_remarque = ConvertirApostrophe(corriger_null(txt_remarque.Text))
            aj_allergenes = ConvertirApostrophe((txt_allergenes.Text))
            If btn_valider.Text = "Ajouter" Then
                Ajouter_Produit()
            Else
                Modifier_Produit()
            End If

            Declarer_Requete(rdb_actifs_oui, rdb_actifs_non)
            Return True
        Else
            Return False
        End If
    End Function

    Function Existe_Deja(nom_produit As String, marque As String, quantite As Double) As Boolean
        Dim ds_produits As New DataSet
        requete = "SELECT count(*) FROM tbl_produits WHERE nom_produit = '" & ConvertirApostrophe(nom_produit) & "' AND marque = '" & ConvertirApostrophe(marque) & "' AND nbr_unite_format = " & Replace(quantite, ",", ".")
        bd.miseAjourDS(ds_produits, da, requete, "tbl_produits")

        If ds_produits.Tables(0).Rows(0).Item(0) > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region
    '
    '
    '
    '
    '
#Region "Ajouter un produit"
    Private Sub btn_generer_Click(sender As Object, e As EventArgs) Handles btn_generer.Click
        txt_no_produit.Text = Generer_Code()
    End Sub

    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        Changer_Enabled()
        pnl_ajout_mod.Focus()
        pnl_recherches.Enabled = False
        btn_ajouter.Enabled = False
        btn_modifier.Enabled = False
        btn_visualiser.Enabled = False
        btn_reactiver.Enabled = False
        btn_desactiver.Enabled = False
        btnRechercher.Enabled = False
        btnReinitialiser.Enabled = False

        Vider_Textboxes()

        MessageBox.Show("Vous allez maintenant procéder à l'ajout d'un produit." & vbCrLf & vbCrLf &
               "Sachez que vous n'aurez pas accès aux autres fonctionnalités de cette page tant que l'action ne sera pas annulée ou complétée." & vbCrLf & vbCrLf &
               "(Pour annuler, appuyez sur le bouton Annuler en bas de la page)", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Sub Vider_Textboxes()
        Dim tab_controles() As Control = {txt_no_produit, txt_code_barre, txt_code_plu, txt_nom_produit, txt_marque, nm_quantite,
                                          txt_description, txt_remarque, txt_allergenes}

        For i = 0 To tab_controles.Count - 1
            tab_controles(i).Text = String.Empty
        Next
        cbo_categories.SelectedIndex = -1
        cbo_format.SelectedIndex = -1
        lbl_mesure.Text = "--- choisissez une unité de mesure ---"
        cbo_perissable.SelectedIndex = -1
        cbo_bio.SelectedIndex = -1
        chk_tps.Checked = False
        chk_tvq.Checked = False
        btn_valider.Text = "Ajouter"
    End Sub

    Sub Remplir_Unites(ds As DataSet, da As MySqlDataAdapter, bd As Connexion, _cms As ContextMenuStrip)
        _cms.Items.Clear()
        Dim ds_type As New DataSet

        bd.Requete("SELECT DISTINCT type_mesure FROM tbl_unites_mesure WHERE actif = true", ds_type, da, "tbl_unites_mesure")
        bd.Requete("SELECT unite_mesure, type_mesure FROM tbl_unites_mesure WHERE actif = true", ds, da, "tbl_unites_mesure")
        With ds.Tables(0)
            For i = 0 To ds_type.Tables(0).Rows.Count - 1
                Dim item As New ToolStripMenuItem
                item.Text = ds_type.Tables(0).Rows(i).Item(0)

                For j = 0 To .Rows.Count - 1
                    Dim subitem As New ToolStripMenuItem
                    subitem.Text = .Rows(j).Item(0)

                    If item.Text = .Rows(j).Item(1) Then
                        AddHandler subitem.Click, AddressOf DropDownItemClicked
                        item.DropDownItems.Add(subitem)
                    End If
                Next

                If Not _cms.Items.Contains(item) Then
                    _cms.Items.Add(item)
                End If
            Next
        End With
    End Sub

    Public Sub DropDownItemClicked(sender As ToolStripItem, e As EventArgs)
        lbl_mesure.Text = sender.Text
    End Sub

    Private Sub btnMesure_Click(sender As Object, e As EventArgs) Handles btn_mesure.Click
        cms_unites_mesure.Show(btn_mesure, 0, btn_mesure.Height)
    End Sub

    Private Sub usr_ajouter_produit_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
        cms_unites_mesure.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_associer.Click
        Dim usr_asso As New frm_associer_fournisseur(code)
        usr_asso.ShowDialog()
    End Sub

    Function Trouver_Format() As String
        bd.miseAjourDS(ds, da, "SELECT no_format FROM tbl_formats WHERE nom_format = '" & ConvertirApostrophe(aj_format.Trim) & "'", "tbl_formats")
        Return ds.Tables(0).Rows(0).Item(0)
    End Function

    Private Sub btn_MouseEnter(sender As Object, e As EventArgs) Handles btnReinitialiser.MouseEnter, btnRechercher.MouseEnter, btn_visualiser.MouseEnter, btn_valider.MouseEnter, btn_reactiver.MouseEnter, btn_modifier.MouseEnter, btn_excel.MouseEnter, btn_desactiver.MouseEnter, btn_associer.MouseEnter, btn_annuler.MouseEnter, btn_ajouter.MouseEnter, btn_Ajout_Allergene.MouseEnter, btn_Taux_taxes.MouseEnter

    End Sub

    Private Sub btn_MouseLeave(sender As Object, e As EventArgs) Handles btnReinitialiser.MouseLeave, btnRechercher.MouseLeave, btn_visualiser.MouseLeave, btn_valider.MouseLeave, btn_reactiver.MouseLeave, btn_modifier.MouseLeave, btn_excel.MouseLeave, btn_desactiver.MouseLeave, btn_associer.MouseLeave, btn_annuler.MouseLeave, btn_ajouter.MouseLeave, btn_Ajout_Allergene.MouseLeave, btn_Taux_taxes.MouseLeave

    End Sub
    ''' <summary>
    ''' Méthode qui gère l'événement du clic sur le bouton btn_Ajout_Allergene, elle fait afficher le formulaire ajout_allergene.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_Ajout_Allergene.Click
        frm_ajout_allergene.ShowDialog()
    End Sub
    ''' <summary>
    ''' Méthode qui gère l'événement du clic sur le bouton btn_Taux_taxes, elle fait afficher le formulaire changer_taux_taxes.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub btn_Taux_taxes_Click(sender As Object, e As EventArgs) Handles btn_Taux_taxes.Click
        frm_changer_taux_taxes.ShowDialog()
    End Sub

    Private Sub pnl_recherches_Paint(sender As Object, e As PaintEventArgs) Handles pnl_recherches.Paint

    End Sub

    Private Sub pnl_rien_Paint(sender As Object, e As PaintEventArgs) Handles pnl_rien.Paint

    End Sub
    ''' <summary>
    ''' Méthode qui gère l'événement du clic sur le bouton btn_historique_taxes, elle fait afficher le formulaire historique_taxes.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub btn_historique_taxes_Click(sender As Object, e As EventArgs) Handles btn_historique_taxes.Click
        frm_historique_taxes.ShowDialog()
    End Sub

    Function Trouver_Categorie() As String
        bd.miseAjourDS(ds, da, "SELECT no_categorie FROM tbl_categories WHERE nom_categorie = '" & ConvertirApostrophe(aj_categorie.Trim) & "'", "tbl_categories")
        Return ds.Tables(0).Rows(0).Item(0)
    End Function

    Function Trouver_Mesure() As String
        bd.miseAjourDS(ds, da, "SELECT no_mesure FROM tbl_unites_mesure WHERE unite_mesure = '" & ConvertirApostrophe(aj_unite_mesure.Trim) & "'", "tbl_unites_mesure")
        Return ds.Tables(0).Rows(0).Item(0)
    End Function

    Private Sub btn_valider_Click(sender As Object, e As EventArgs) Handles btn_valider.Click
        Verifier_Ensemble()
    End Sub

    Sub Ajouter_Produit()
        Try
            If Existe_Deja(aj_nom_produit, aj_marque, aj_quantite) Then
                MessageBox.Show("Le produit que vous désirez ajouter existe déjà.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim requete As String = "INSERT INTO tbl_produits VALUES ('" & ConvertirApostrophe(aj_nom_produit.Trim) & "', '" & aj_code_produit.Trim & "', '" & aj_code_barre.Trim & "', '" & aj_code_plu.Trim & "', " &
                     Trouver_Format() & ", " & Trouver_Categorie() & ", " & Trouver_Mesure() & ", '" & aj_description.Trim & "', '" & aj_remarque.Trim & "', " & Replace(aj_quantite, ",", ".") &
                     ", '" & ConvertirApostrophe(aj_marque.Trim) & "', " & aj_perissable & ", true, '" & aj_allergenes.Trim & "', " & aj_bio & ")"
                bd.InsDelUpd(requete)
                Ajouter_Taxes()
                Vider_Textboxes()
                dgv_produits.Enabled = True
                Rafraichir_Boutons()
                Recuperer_Produits()
                pnl_rien.Hide()
                pnl_recherches.Enabled = True
                btnRechercher.Enabled = True
                btnReinitialiser.Enabled = True
                pnl_recherches.Focus()
                Changer_Enabled()
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Le produit a été créé.", cls_animation_operation.Reussie)
            End If

        Catch ex As Exception
            animation.Lancement(timer_succes, lbl_ajoutSucces, "Le produit n'a pas été créé.", cls_animation_operation.Echec)
        End Try
    End Sub

    Sub Ajouter_Taxes()
        Try
            If chk_tps.Checked Then
                Dim requete_tps As String = "(SELECT id_taxes FROM tbl_taxes t1 WHERE type_taxe = 'TPS' and date_taxe = 
                                             (SELECT max(date_taxe) FROM tbl_taxes t2
                                              WHERE t1.type_taxe = t2.type_taxe))"
                bd.InsDelUpd("INSERT INTO tbl_produit_taxe VALUES ('" & aj_code_produit & "', " & requete_tps & ")")
            End If

            If chk_tvq.Checked Then
                Dim requete_tvq As String = "(SELECT id_taxes FROM tbl_taxes t1 WHERE type_taxe = 'TVQ' and date_taxe = 
                                             (SELECT max(date_taxe) FROM tbl_taxes t2
                                              WHERE t1.type_taxe = t2.type_taxe))"
                bd.InsDelUpd("INSERT INTO tbl_produit_taxe VALUES ('" & aj_code_produit & "', " & requete_tvq & ")")
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
    '
    '
    '
    '
    '
#Region "Modifier un produit"
    'va servir à trouver l'identifiant d'un produit dans la base de données
    Function Trouver_ID_Produit(nom As String, marque As String, quantite As Double) As String
        Dim _ds As New DataSet
        Dim requete As String = "SELECT code_produit FROM tbl_produits WHERE nom_produit = '" & ConvertirApostrophe(nom.Trim) & "' AND marque = '" & ConvertirApostrophe(marque.Trim) & "' AND nbr_unite_format = " & Replace(quantite, ",", ".")

        bd.miseAjourDS(_ds, da, requete, "tbl_produits")
        If _ds.Tables(0).Rows.Count = 0 Then
            Return ""
        Else
            Return _ds.Tables(0).Rows(0).Item(0)
        End If

    End Function


    Private Sub btn_modifierProduit_Click(sender As Object, e As EventArgs) Handles btn_modifier.Click
        Changer_Enabled()
        pnl_recherches.Enabled = False
        btnRechercher.Enabled = False
        btnReinitialiser.Enabled = False
        dgv_produits.Enabled = False
        btn_ajouter.Enabled = False
        btn_modifier.Enabled = False
        btn_reactiver.Enabled = False
        btn_desactiver.Enabled = False
        btn_visualiser.Enabled = False
        txt_no_produit.Enabled = False
        btn_generer.Enabled = False
        pnl_ajout_mod.Focus()
        btn_valider.Text = "Enregistrer la modification"

        MessageBox.Show("Vous allez maintenant procéder à la modification d'un produit." & vbCrLf & vbCrLf &
                "Sachez que vous n'aurez pas accès aux autres fonctionnalités de cette page tant que l'action ne sera pas annulée ou complétée." & vbCrLf & vbCrLf &
                "(Pour annuler, appuyez sur le bouton Annuler en bas de la page)", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Sub Modifier_Produit()
        Try
            'si ce que l'utilisateur entre est une copie conforme d'un autre produit et que son identifiant est différent, on refuse la modification
            If Existe_Deja(aj_nom_produit, aj_marque, aj_quantite) And Trouver_ID_Produit(aj_nom_produit, aj_marque, aj_quantite) <> txt_no_produit.Text Then
                MessageBox.Show("Ce produit existe déjà dans la base de données.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                bd.InsDelUpd("UPDATE tbl_produits SET nom_produit = '" & ConvertirApostrophe(aj_nom_produit.Trim) & "', code_produit = '" & aj_code_produit.Trim & "', code_barre = '" & aj_code_barre.Trim &
                        "', code_plu = '" & aj_code_plu.Trim & "', no_format = " & Trouver_Format() & ", no_categorie = " & Trouver_Categorie() & ", no_mesure = " & Trouver_Mesure() &
                        ", description = '" & aj_description.Trim & "', remarque = '" & aj_remarque.Trim & "', nbr_unite_format = " & Replace(aj_quantite, ",", ".") & ", marque = '" & ConvertirApostrophe(aj_marque.Trim) &
                        "', perissable = " & aj_perissable & ", allergene = '" & aj_allergenes.Trim & "', bio = " & aj_bio & " WHERE code_produit = '" & code & "'")
                bd.InsDelUpd("DELETE FROM tbl_produit_taxe WHERE code_produit = '" & aj_code_produit & "'")
                Ajouter_Taxes()
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Le produit a été modifié.", cls_animation_operation.Reussie)
                btn_generer.Enabled = True
                txt_no_produit.Enabled = True
                Changer_Enabled()
                Vider_Textboxes()
                Recuperer_Produits()
                pnl_recherches.Enabled = True
                btnRechercher.Enabled = True
                btnReinitialiser.Enabled = True
                dgv_produits.Enabled = True
                pnl_recherches.Focus()
            End If
        Catch ex As Exception
            animation.Lancement(timer_succes, lbl_ajoutSucces, "Le produit n'a pas été modifié.", cls_animation_operation.Echec)
        End Try
    End Sub
#End Region
    '
    '
    '
    '
    '
    Private Sub timer_succes_Tick(sender As Object, e As EventArgs) Handles timer_succes.Tick
        animation.Operation(sender, lbl_ajoutSucces)
    End Sub

    Private Sub btn_excel_Click(sender As Object, e As EventArgs) Handles btn_excel.Click
        Cursor.Current = Cursors.AppStarting
        LancerExcel(dgv_produits)
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub btn_visualiser_Click(sender As Object, e As EventArgs) Handles btn_visualiser.Click
        usr_menu.VerticalScroll.Value = usr_menu.VerticalScroll.Maximum
    End Sub

    Sub Changer_Enabled()
        Dim tab_controles() As Control = {txt_no_produit, txt_nom_produit, txt_marque, txt_description, txt_code_plu, txt_code_barre, txt_allergenes, chk_tvq, chk_tps,
            nm_quantite, cbo_categories, cbo_bio, cbo_format, cbo_perissable, btn_mesure, btn_valider, btn_annuler, btn_generer, txt_remarque, rdb_actifs_non, rdb_actifs_oui, rdb_actifs_tous}
        For i As Integer = 0 To tab_controles.Count - 1
            If tab_controles(i).Enabled = False Then
                tab_controles(i).Enabled = True
            Else
                tab_controles(i).Enabled = False
            End If
        Next
    End Sub

    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        If Not txt_no_produit.Enabled Then
            txt_no_produit.Enabled = True
            btn_generer.Enabled = True
        End If
        Changer_Enabled()
        dgv_produits.Enabled = True
        Rafraichir_Boutons()
        pnl_recherches.Enabled = True
        btnRechercher.Enabled = True
        btnReinitialiser.Enabled = True
        btn_visualiser.Enabled = True
        Rafraichir_Boutons()
        pnl_recherches.Focus()
    End Sub

End Class

