Imports System.Data.Sql
Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class usr_inventaire_P
    Dim bd As New Connexion
    Dim ds As New DataSet
    Dim da As MySqlDataAdapter
    ' code_produit va être utilisé lorsqu'on demande plus de détails sur un produit
    ' (utilisé dans le formulaire frm_vue_produit)
    Public Shared code_produit As String

    Dim utls_conn As Utilisateur
    Dim leCours As String
    Dim leExerc As Integer
    Dim inventaire As String = "prof"
    Dim no_inventaire As Integer

    Dim animation As New cls_animation_operation
    Dim frmP As frmDietetique

    Public Sub New(utls As Utilisateur, cours As String, exerc As Integer, frm As frmDietetique)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        utls_conn = utls
        leCours = cours
        leExerc = exerc
        frmP = frm

        If leExerc = 0 Then
            btn_assigner.Enabled = False

            btn_switch.Text = "Sélectionner un exercice"
            btn_switch.Image = My.Resources.baseline_arrow_back_white_24dp
            btn_switch.ImageAlign = ContentAlignment.MiddleLeft
            btn_switch.TextAlign = ContentAlignment.MiddleRight
        End If

        nm_quant_inf.Increment = 0.25
        nm_quant_sup.Increment = 0.25
    End Sub

    Private Sub usr_produits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Maj()
        Remplir_Combobox(bd, "nom_categorie", "tbl_categories", cbo_rech_categorie)
        Remplir_Combobox(bd, "nom_emplacement", "tbl_emplacement_inventaire", cbo_emplacement)
    End Sub

    'Met à jour le DS.'
    Public Sub Maj()
        If inventaire = "prof" Then
            Charger_DS()
            Reinitialiser_Criteres()
        ElseIf leExerc <> 0 Then
            Charger_DS_Exercice()
            Reinitialiser_Criteres()
        End If

        If dgv_produits.RowCount = 0 Then
            btn_supprimer.Enabled = False
            btn_modifier.Enabled = False
        Else
            btn_supprimer.Enabled = True
            btn_modifier.Enabled = True
        End If
    End Sub

    'Active ou désactive le bouton modifier selon le nombre d'item sélectionné.'
    Private Sub dgv_produits_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_produits.SelectionChanged
        If dgv_produits.SelectedRows.Count = 1 Then
            btn_modifier.Enabled = True
        Else
            btn_modifier.Enabled = False
        End If
    End Sub

    'Lance la recherche.'
    Private Sub Rechercher()
        If inventaire = "prof" Then
            Trouver_Resultats()
        Else
            Trouver_Resultats_Exercice()
        End If
    End Sub

#Region "Boutons"
    'Bouton pour switcher d'inventaire.'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_switch.Click

        If inventaire = "prof" Then
            If leExerc <> 0 Then
                btn_switch.Text = "Mon inventaire"
                btn_switch.Size = New Size(155, 36)
                inventaire = "exercice"
                lbl_inventaire.Text = "Inventaire de l'exercice"
                btn_assigner.Enabled = False
            Else
                frmP.section_choisie = frmP.btnExercices.Text
                frmP.Adapter_Couleurs()
                frmP.Adapter_UserControl(frmP.btnExercices)
            End If

        ElseIf inventaire = "exercice" Then
            btn_switch.Text = "Inventaire de l'exercice"
            inventaire = "prof"
            lbl_inventaire.Text = "Mon inventaire"
            btn_switch.Size = New Size(210, 36)
            If leExerc <> 0 Then
                btn_assigner.Enabled = True
            End If
        End If
        Maj()
    End Sub

    'Bouton ajouter.'
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        Dim frmAjout As New frm_produit_inventaire(leExerc, utls_conn, inventaire, Me)
        frmAjout.ShowDialog()
    End Sub

    'Bouton modifier.'
    Private Sub btn_modifier_Click(sender As Object, e As EventArgs) Handles btn_modifier.Click
        With dgv_produits.CurrentRow
            Dim frmModif As New frm_modifier_inventaire(.Cells(0).Value, .Cells(1).Value, mod_gestion_BD.changeDecimal(.Cells(9).Value), .Cells(8).Value, inventaire, leExerc, utls_conn)
            frmModif.ShowDialog()

            If frmModif.prodModifie = True Then
                If frmModif.succesModif = True Then
                    animation.Lancement(timer_succes, lbl_ajoutSucces, "Modification réussie.", cls_animation_operation.Reussie)
                Else
                    animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de la modification.", cls_animation_operation.Echec)
                End If
            End If

            Maj()
        End With
    End Sub

    'Bouton supprimer.'
    Private Sub btn_supprimer_Clic(sender As Object, e As EventArgs) Handles btn_supprimer.Click
        Dim strRequete As String
        If MessageBox.Show("Êtes-vous certain de vouloir supprimer les produits sélectionnés?", "Suppression",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim succes As Boolean = True

            For i As Integer = 0 To dgv_produits.SelectedRows.Count - 1

                Try
                    strRequete = "DELETE FROM tbl_inventaire_detail where code_produit = '" & dgv_produits.SelectedRows(i).Cells(0).Value & "'
                                  and no_emplacement = (select no_emplacement from tbl_emplacement_inventaire where nom_emplacement = '" & mod_regex.ConvertirApostrophe(dgv_produits.SelectedRows(i).Cells(8).Value.ToString.Trim) & "')
                                  and "

                    If inventaire = "prof" Then
                        strRequete &= " no_inventaire = (select no_inventaire from tbl_inventaire_prof where no_utilisateur = '" & utls_conn.No_id & "');"
                    Else
                        strRequete &= " no_inventaire = (select no_inventaire from tbl_exercices where no_exercice = " & leExerc & ");"
                    End If

                    bd.InsDelUpd(strRequete)
                Catch ex As Exception
                    succes = False
                End Try

            Next

            If succes Then
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Suppression réussie.", cls_animation_operation.Reussie)
            Else
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de la suppression.", cls_animation_operation.Echec)
            End If

            Maj()
        End If
    End Sub


    Private Sub btn_assigner_Click(sender As Object, e As EventArgs) Handles btn_assigner.Click
        If MessageBox.Show("Voulez-vous transférer le contenu de votre inventaire dans celui de l'exercice?" & vbNewLine &
                           "L'inventaire de l'exercice sera écrasé.", "Transfert d'inventaire",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim strRequete As String
            Dim succes As Boolean = True

            Try
                strRequete = "DELETE FROM tbl_inventaire_detail where "
                strRequete &= " no_inventaire = (select no_inventaire from tbl_exercices where no_exercice = " & leExerc & ");"


                bd.InsDelUpd(strRequete)
            Catch ex As Exception
                succes = False
            End Try



            For Each rows As DataGridViewRow In dgv_produits.Rows

                Try
                    strRequete = "INSERT INTO tbl_inventaire_detail values
                            ((select no_inventaire from tbl_exercices where no_exercice = " & leExerc & "),
                             '" & rows.Cells(0).Value & "',
                              (select no_emplacement from tbl_emplacement_inventaire where nom_emplacement = '" & mod_regex.ConvertirApostrophe(rows.Cells(8).Value) & "'),
                             " & rows.Cells(9).Value.ToString.Replace(",", ".") & ");"
                    bd.InsDelUpd(strRequete)
                Catch ex As Exception
                    succes = False
                End Try
            Next

            If succes Then
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Transfert réussi.")
            Else
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors du transfert.")
            End If

            btn_switch.PerformClick()
        End If
    End Sub
#End Region
    '
    '
    '
    '
    '
#Region "Prof"
    Sub Charger_DS()
        bd.miseAjourDS(ds, da, "SELECT p.code_produit AS `No. Produit`, nom_produit AS `Nom`, marque AS `Marque`, nom_categorie AS `Categorie`,
                                nom_format AS `Format`, if(perissable, 'Oui', 'Non') AS `Perissable`, if(bio, 'Oui', 'Non') as `Bio`,
                                 if(allergene = '', 'Non', 'Oui') AS `Allergenes`,
                                ei.nom_emplacement as `Emplacement`, id.quantite as `Quantite`
                                FROM tbl_produits p
                                INNER JOIN tbl_formats f ON p.no_format = f.no_format
                                INNER JOIN tbl_categories c ON p.no_categorie = c.no_categorie
                                INNER JOIN tbl_inventaire_detail id ON p.code_produit = id.code_produit
                                INNER JOIN tbl_inventaire_prof e ON e.no_inventaire = id.no_inventaire
                                INNER JOIN tbl_emplacement_inventaire ei ON id.no_emplacement = ei.no_emplacement
                                WHERE e.no_utilisateur = '" & utls_conn.No_id & "'
                                ORDER BY p.code_produit", "tbl_produits")

        RemplirGrid()
    End Sub



    'S'active pour vérifier le nombre de résultats pour ensuite l'afficher dans le bouton 'Rechercher'
    'Pour afficher les résultats dans la datagridview, il faudra aller cliquer sur le bouton 'Rechercher'
    ' NOTE: Les fonctions utilisées dans Trouver_Resultats() viennent directement du MODULE mod_recherches.
    Sub Trouver_Resultats()

        Dim requete As String = "SELECT p.code_produit AS `No. Produit`, nom_produit AS `Nom`, marque AS `Marque`, nom_categorie AS `Categorie`,
                                nom_format AS `Format`, if(perissable, 'Oui', 'Non') AS `Perissable`, if(bio, 'Oui', 'Non') as `Bio`,
                                if(allergene = '', 'Non', 'Oui') AS `Allergenes`,
                                ei.nom_emplacement as `Emplacement`, id.quantite as `Quantite`
                                FROM tbl_produits p
                                INNER JOIN tbl_formats f ON p.no_format = f.no_format
                                INNER JOIN tbl_categories c ON p.no_categorie = c.no_categorie
                                INNER JOIN tbl_inventaire_detail id ON p.code_produit = id.code_produit
                                INNER JOIN tbl_inventaire_prof e ON e.no_inventaire = id.no_inventaire
                                INNER JOIN tbl_emplacement_inventaire ei ON id.no_emplacement = ei.no_emplacement
                                WHERE e.no_utilisateur = '" & utls_conn.No_id & "'" &
                             Rechercher_Selon_Contenu("nom_produit", cbo_nom_contient, ConvertirApostrophe(txt_rech_nom.Text.Trim)) &
                            Rechercher_Selon_Contenu("marque", cbo_marque_contient, ConvertirApostrophe(txt_rech_marque.Text.Trim)) &
                            Rechercher_Categories(ConvertirApostrophe(cbo_rech_categorie.Text.Trim)) &
                            Rechercher_Emplacement(ConvertirApostrophe(cbo_emplacement.Text.Trim)) &
                            Verifier_Limites(cbo_rech_quant, nm_quant_inf.Value, nm_quant_sup.Value, "quantite") &
                            Rechercher_Perissable(rdb_perissable_oui, rdb_perissable_non) &
                            Rechercher_Allergenes(ConvertirApostrophe(cbo_allergenes.Text), ConvertirApostrophe(txt_allergenes_keyword.Text.Trim)) &
                            Rechercher_Bio(rdb_bio_oui, rdb_bio_non) &
                            Verifier_Tri_Inventaire(ConvertirApostrophe(cbo_trier_par.Text), ConvertirApostrophe(cbo_ordre.Text.Trim))
        bd.miseAjourDS(ds, da, requete, "tbl_produits")

        btnRechercher.Text = "Rechercher (" & ds.Tables(0).Rows.Count & " résultat(s))"
    End Sub
#End Region
    '
    '
    '
    '
    '
#Region "exercice"
    Sub Charger_DS_Exercice()
        bd.miseAjourDS(ds, da, "SELECT p.code_produit AS `No. Produit`, nom_produit AS `Nom`, marque AS `Marque`, nom_categorie AS `Categorie`,
                                nom_format AS `Format`, if(perissable, 'Oui', 'Non') AS `Perissable`, if(bio, 'Oui', 'Non') as `Bio`,
                                if(allergene = '', 'Non', 'Oui') AS `Allergenes`,
                                ei.nom_emplacement as `Emplacement`, id.quantite as `Quantite`
                                FROM tbl_produits p
                                INNER JOIN tbl_formats f ON p.no_format = f.no_format
                                INNER JOIN tbl_categories c ON p.no_categorie = c.no_categorie
                                INNER JOIN tbl_inventaire_detail id ON p.code_produit = id.code_produit
                                INNER JOIN tbl_exercices ex ON ex.no_inventaire = id.no_inventaire
                                INNER JOIN tbl_emplacement_inventaire ei ON id.no_emplacement = ei.no_emplacement
                                WHERE ex.no_exercice = '" & leExerc & "'
                                ORDER BY p.code_produit", "tbl_produits")

        RemplirGrid()
    End Sub

    Sub Trouver_Resultats_Exercice()
        Dim requete As String = "SELECT p.code_produit AS `No. Produit`, nom_produit AS `Nom`, marque AS `Marque`, nom_categorie AS `Categorie`,
                                nom_format AS `Format`, if(perissable, 'Oui', 'Non') AS `Perissable`, if(bio, 'Oui', 'Non') as `Bio`,
                                if(allergene = '', 'Non', 'Oui') AS `Allergenes`,
                                ei.nom_emplacement as `Emplacement`, id.quantite as `Quantite`
                                FROM tbl_produits p
                                INNER JOIN tbl_formats f ON p.no_format = f.no_format
                                INNER JOIN tbl_categories c ON p.no_categorie = c.no_categorie
                                INNER JOIN tbl_inventaire_detail id ON p.code_produit = id.code_produit
                                INNER JOIN tbl_exercices ex ON ex.no_inventaire = id.no_inventaire
                                INNER JOIN tbl_emplacement_inventaire ei ON id.no_emplacement = ei.no_emplacement
                                WHERE ex.no_exercice = '" & leExerc & "'" &
                            Rechercher_Selon_Contenu("nom_produit", cbo_nom_contient, ConvertirApostrophe(txt_rech_nom.Text.Trim)) &
                            Rechercher_Selon_Contenu("marque", cbo_marque_contient, ConvertirApostrophe(txt_rech_marque.Text.Trim)) &
                            Rechercher_Categories(ConvertirApostrophe(cbo_rech_categorie.Text.Trim)) &
                            Rechercher_Emplacement(ConvertirApostrophe(cbo_emplacement.Text.Trim)) &
                            Verifier_Limites(cbo_rech_quant, nm_quant_inf.Value, nm_quant_sup.Value, "quantite") &
                            Rechercher_Perissable(rdb_perissable_oui, rdb_perissable_non) &
                            Rechercher_Allergenes(ConvertirApostrophe(cbo_allergenes.Text), ConvertirApostrophe(txt_allergenes_keyword.Text.Trim)) &
                            Rechercher_Bio(rdb_bio_oui, rdb_bio_non) &
                            Verifier_Tri_Inventaire(ConvertirApostrophe(cbo_trier_par.Text), ConvertirApostrophe(cbo_ordre.Text.Trim))

        bd.miseAjourDS(ds, da, requete, "tbl_produits")
        btnRechercher.Text = "Rechercher (" & ds.Tables(0).Rows.Count & " résultat(s))"
    End Sub
#End Region
    '
    '
    '
    '
    '
#Region "Rechercher et réinitialiser"
    Private Sub RemplirGrid()
        dgv_produits.Rows.Clear()


        With ds.Tables(0)
            For i As Integer = 0 To .Rows.Count - 1
                dgv_produits.Rows.Add(.Rows(i).Item(0))
                For j As Integer = 1 To ds.Tables(0).Columns.Count - 2
                    dgv_produits.Rows(dgv_produits.Rows.Count - 1).Cells(j).Value = .Rows(i).Item(j)
                Next
                dgv_produits.Rows(dgv_produits.Rows.Count - 1).Cells(ds.Tables(0).Columns.Count - 1).Value = .Rows(i).Item(ds.Tables(0).Columns.Count - 1).ToString.Replace(".", ",")
            Next
        End With

        dgv_produits.RowTemplate.Height = 30
    End Sub


    Private Sub btnRechercher_Click(sender As Object, e As EventArgs) Handles btnRechercher.Click
        If txt_description_keyword.TextLength <> 0 Then
            Enlever_Point_Virgule(txt_description_keyword.Text, txt_description_keyword.TextLength - 1)
        End If

        If txt_allergenes_keyword.TextLength <> 0 Then
            Enlever_Point_Virgule(txt_allergenes_keyword.Text, txt_allergenes_keyword.TextLength - 1)
        End If
        If inventaire = "exercice" Then
            Trouver_Resultats_Exercice()
        Else
            Trouver_Resultats()
        End If
        RemplirGrid()
    End Sub

    Private Sub btnReinitialiser_Click(sender As Object, e As EventArgs) Handles btnReinitialiser.Click
        Maj()
    End Sub

    'Réinitialisation du DataSet
    'C'est pour faire propre.
    'Va vider toutes les textbox de la section recherches.
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
        cbo_emplacement.SelectedIndex = 0
        cbo_rech_quant.SelectedIndex = 0
        nm_quant_inf.Value = 0
        nm_quant_sup.Value = 0
        cbo_allergenes.SelectedIndex = 4
        cbo_description.SelectedIndex = 3
        rdb_perissable_tous.Checked = True
        rdb_bio_tous.Checked = True
    End Sub
#End Region
    '
    '
    '
    '
    '
#Region "Activations multiples de Trouver_Resultats()"
    Private Sub pnl_recherches_MouseLeave(sender As Object, e As EventArgs) Handles Panel1.MouseEnter, txt_allergenes_keyword.LostFocus, txt_description_keyword.LostFocus,
                                                                                txt_rech_marque.LostFocus, txt_rech_nom.LostFocus, cbo_emplacement.SelectedIndexChanged,
                                                                                cbo_rech_categorie.SelectedIndexChanged
        Rechercher()
    End Sub

    Private Sub cbo_allergenes_SelectedIndexChanged(sender As ComboBox, e As EventArgs) Handles cbo_allergenes.SelectedIndexChanged
        If sender.SelectedIndex = 2 Or sender.SelectedIndex = 3 Then
            txt_allergenes_keyword.Enabled = True
        Else
            txt_allergenes_keyword.Enabled = False
            Rechercher()
        End If
    End Sub

    Private Sub cbo_description_SelectedIndexChanged(sender As ComboBox, e As EventArgs) Handles cbo_description.SelectedIndexChanged
        If sender.SelectedIndex = 2 Then
            txt_description_keyword.Enabled = True
        Else
            txt_description_keyword.Enabled = False
            Rechercher()
        End If
    End Sub
#End Region
    '
    '
    '
    '
    '
#Region "Les recherches par frais et quantité (show/hide les NumericUpDown)"
    Sub Cacher_Limites_Frais()
        Dim tab_controles() As Control = {lbl_fet, lbl_finf, lbl_fsup, nm_quant_sup}
        For i = 0 To tab_controles.Length - 1
            tab_controles(i).Visible = False
        Next
    End Sub

    Sub Montrer_Limites_Frais()
        Dim tab_controles() As Control = {lbl_fet, lbl_finf, lbl_fsup, nm_quant_sup}
        For i = 0 To tab_controles.Length - 1
            tab_controles(i).Visible = True
        Next
    End Sub

    Private Sub limites_SelectedIndexChanged(sender As ComboBox, e As EventArgs) Handles cbo_rech_quant.SelectedIndexChanged
        Select Case cbo_rech_quant.Text
            Case "Supérieur à", "Inférieur à"
                Cacher_Limites_Frais()
                nm_quant_inf.Enabled = True
            Case "Entre..."
                Montrer_Limites_Frais()
                nm_quant_inf.Enabled = True
            Case Else
                Cacher_Limites_Frais()
                nm_quant_inf.Enabled = False
        End Select
    End Sub
#End Region
    '
    '
    '
    '
    '
#Region "Autres"
    'Oh la récursive! On enlève les points virgules supplémentaires à la fin du mot clé.
    Sub Enlever_Point_Virgule(ByRef kw As String, ByVal i As Integer)
        Dim _char() As Char = kw
        If Not i < 0 Then
            If _char(i) = Chr(59) Then
                _char(i) = ""
                kw = New String(_char)
                Enlever_Point_Virgule(kw, i - 1)
            End If
        End If
    End Sub

    'Animation!.'
    Private Sub timer_succes_Tick(sender As Timer, e As EventArgs) Handles timer_succes.Tick
        animation.Operation(sender, lbl_ajoutSucces)
    End Sub

    'Étant donné que les TextBox sont du type Multi-Line, appuyer sur Enter faisait un saut de ligne. (On ne veut pas de saut de ligne.)
    'Appuyer sur Enter ne fera donc pas de saut de ligne (en bonus, ça va lancer une recherche)
    Private Sub txt_allergenes_keyword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_allergenes_keyword.KeyPress, txt_description_keyword.KeyPress,
                                                                                              txt_rech_marque.KeyPress, txt_rech_nom.KeyPress
        If e.KeyChar() = Chr(13) Then
            e.Handled = True

            If txt_description_keyword.TextLength <> 0 Then
                Enlever_Point_Virgule(txt_description_keyword.Text, txt_description_keyword.TextLength - 1)
            End If

            If txt_allergenes_keyword.TextLength <> 0 Then
                Enlever_Point_Virgule(txt_allergenes_keyword.Text, txt_allergenes_keyword.TextLength - 1)
            End If

            If inventaire = "exercice" Then
                Trouver_Resultats_Exercice()
            Else
                Trouver_Resultats()
            End If
            RemplirGrid()
        End If
    End Sub

    'Affiche les infos du produit.'
    Private Sub dgv_produits_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_produits.CellDoubleClick
        If e.RowIndex > -1 Then
            code_produit = dgv_produits.Rows(e.RowIndex).Cells(0).Value
            Dim frm_details As New frm_details_produit(dgv_produits.Rows(e.RowIndex).Cells(0).Value, leExerc, utls_conn, inventaire)
            frm_details.ShowDialog()
        End If
    End Sub

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

    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btn_ajouter.MouseEnter, btn_modifier.MouseEnter, btn_supprimer.MouseEnter, btn_switch.MouseEnter, btnRechercher.MouseEnter, btnReinitialiser.MouseEnter, btn_assigner.MouseEnter
        sender.BackColor = Color.White
        sender.ForeColor = Color.Black

        If sender.Text = btn_switch.Text Then
            If btn_switch.Text = "Inventaire de l'exercice" Or btn_switch.Text = "Mon inventaire" Then
                btn_switch.Image = My.Resources.baseline_sync_black_36dp
            Else
                btn_switch.Image = My.Resources.baseline_arrow_back_black_24dp
            End If
        End If
    End Sub
    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btn_ajouter.MouseLeave, btn_modifier.MouseLeave, btn_supprimer.MouseLeave, btn_switch.MouseLeave, btnRechercher.MouseLeave, btnReinitialiser.MouseLeave, btn_assigner.MouseLeave
        If sender.Text = btnReinitialiser.Text Then
            sender.BackColor = Color.FromArgb(72, 84, 96)
            sender.ForeColor = SystemColors.Control
        Else
            sender.BackColor = Color.FromArgb(52, 73, 94)
            sender.ForeColor = SystemColors.Control
        End If

        If sender.Text = btn_switch.Text Then
            If btn_switch.Text = "Inventaire de l'exercice" Or btn_switch.Text = "Mon inventaire" Then
                btn_switch.Image = My.Resources.baseline_sync_white_36dp
            Else
                btn_switch.Image = My.Resources.baseline_arrow_back_white_24dp
            End If
        End If
    End Sub

    Private Sub btn_MouseEnter(sender As Object, e As EventArgs) Handles btnReinitialiser.MouseEnter, btnRechercher.MouseEnter, btn_switch.MouseEnter, btn_supprimer.MouseEnter, btn_modifier.MouseEnter, btn_assigner.MouseEnter, btn_ajouter.MouseEnter

    End Sub

    Private Sub btn_MouseLeave(sender As Object, e As EventArgs) Handles btnReinitialiser.MouseLeave, btnRechercher.MouseLeave, btn_switch.MouseLeave, btn_supprimer.MouseLeave, btn_modifier.MouseLeave, btn_assigner.MouseLeave, btn_ajouter.MouseLeave

    End Sub


#End Region
End Class
