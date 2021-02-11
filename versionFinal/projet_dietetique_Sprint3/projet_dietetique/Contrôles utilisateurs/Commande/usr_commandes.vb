Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports MySql.Data.MySqlClient

' PIERRE-OLIVIER DUBOIS-NADEAU

Public Class usr_commandes

    Public Shared strRequete As String
    Dim table As String
    Dim gestionBd As New Connexion
    Dim dataTable = New DataTable
    Dim dataAdapter As New MySqlDataAdapter
    Dim dataSet As DataSet
    Dim datasetTaxes As DataSet
    Dim dataRecherche As New DataSet
    Dim ctrFormat As Integer = 0
    Dim ctrEmplacement As Integer = 0
    Dim critere As String = ""
    Dim code_produit As String = ""
    Dim prix_unitaire As Double = 0
    Dim _frm_modifier_commande As New frmModifierCommande(Me, 0, lsv_controle)
    Dim usr_comparer_comm As New usr_comparer_commande(Me, utls, cours_exercice, exercice)
    Shared indice_commande As Integer = 0
    Dim tvq As Double = 0
    Dim tps As Double = 0
    Dim liste_fournisseur() As String
    Dim nombre_commande As String = 0
    Dim utls As Utilisateur
    Dim randomValue As Integer
    Dim str_requete_recherche As String = ""
    Dim lst As New List(Of String)
    Dim MySource As New AutoCompleteStringCollection()
    Dim commande_detaillee As frm_sauvegarde_commande
    Dim liste_Sauvegarde As New ListView
    Dim lsv_controle As New ListView
    Dim nbr_commande_exercice As Integer = 0
    Dim exercice As Integer = 0
    Dim cours_exercice As String = ""
    Dim nom_fournisseur As String = ""
    Dim nbr_recepetion_exercice As Integer = 0
    Dim no_recepetion As Integer = 0
    Dim nouvelle_commande As Boolean = True
    Dim nouvelle_reception As Boolean = True
    Dim btn_nouvelle_reception As Boolean = True
    Dim btn_nouvelle_commande As Boolean = True
    Dim str_requete As String = ""
    Dim no_commande_courante As String = ""
    Dim str_fournisseur As String = ""
    Dim mode_attente_reception As Boolean = False
    Dim compter_commande_prof As Integer = 0
    Dim str_requete_remplir As String = ""
    Dim number As Integer


    Public Sub New(_utls As Utilisateur, cours As String, exerc As Integer)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        utls = _utls
        exercice = exerc
        cours_exercice = cours

    End Sub

    Private Sub usr_commande_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If utls.Titre = "p" Then
            btnEffectuer.Text = "faire le corrigé"
            btnComparer.Text = "Exercices remis"

        ElseIf utls.Titre = "e" Then

            btnComparer.Text = "corrigé exercice"

        End If


        'Initialiser le controle qui est le même pour la réception que pour la commande.
        lsv_controle = lsvCommande

        'Charger le dataset.
        Charger_DS()

        txtUniteMesure.Enabled = False

        btnReinitialiser.PerformClick()

        'On compte le nombre de réception et le nombre d'exercice.
        compter_commande_exercice()
        compter_recepetion_exercice()

        'Si le nombre de commande relié a l'exercice pour cet utilisateur est plus grand ou = a 1.
        If nbr_commande_exercice >= 1 Then

            remplir_commande()
            nouvelle_commande = False
            btnNouvelleCommande.Enabled = True
            btn_nouvelle_commande = False
            btnEffectuer.Enabled = True
        Else
            btnEffectuer.Enabled = False
        End If

        'Si c'est un prof'
        If utls.Titre = "p" Then
            If nbr_recepetion_exercice = 1 Then
                mode_attente_reception = True
                nouvelle_commande = False
                remplir_reception_modifier()
                btn_nouvelle_reception = False
            End If
        End If

        'Si c'est un `éleve.
        If utls.Titre = "e" Then


            btnAssigner.Visible = False
            gestion_btn_eleves()

        Else
            gestion_btn_prof()
        End If

    End Sub

    'Gestion des boutons pour un élève.
    Public Sub gestion_btn_eleves()

        compter_commande_exercice()
        compter_recepetion_exercice()
        compter_commande_prof = compter_commande_professeur()


        btnAssigner.Visible = False
        If compter_commande_prof >= 1 Then
            btnComparer.Enabled = True
        Else
            btnComparer.Enabled = False
        End If

        If nbr_commande_exercice >= 1 Then
            desactiver_commande()
            remplir_commande()
            btnComparer.Enabled = True

            btnComparer.Enabled = True
            btnNouvelleCommande.Enabled = False

        Else

            btnComparer.Enabled = False
            activer_commande()

        End If


        If nbr_recepetion_exercice = 1 And nbr_commande_exercice >= 1 Then

            btn_switch.Enabled = True
            btn_switch.Image = My.Resources.Resources.baseline_sync_white_36dp

        Else
            btn_switch.Enabled = False
            btn_switch.Image = My.Resources.Resources.baseline_sync_black_36dp

        End If

    End Sub

    'Gestion des boutons pour un professeur.

    Public Sub gestion_btn_prof()

        compter_commande_exercice()
        compter_recepetion_exercice()
        compter_commande_prof = compter_commande_professeur()

        btnComparer.Left = 833

        If btnNouvelleCommande.Text = "Nouvelle commande" Then

            If nouvelle_commande = True Then
                activer_commande()

                btnComparer.Enabled = True
                btnAssigner.Enabled = False
                btnEffectuer.Enabled = False


                If btn_nouvelle_commande = True Then

                    btnNouvelleCommande.Enabled = False

                Else
                    btnNouvelleCommande.Enabled = True

                End If

            Else

                If nbr_commande_exercice >= 1 Then
                    desactiver_commande()
                    btnAssigner.Enabled = True
                    btnComparer.Enabled = True
                    btnEffectuer.Enabled = True

                Else

                    activer_commande()
                    btnAssigner.Enabled = False
                    btnComparer.Enabled = True
                    btnEffectuer.Enabled = False

                End If

            End If

        Else
            activer_commande()
            btnComparer.Enabled = False
            btnAssigner.Enabled = False

            If btn_nouvelle_reception = True Then

                btnNouvelleCommande.Enabled = False

            Else

                btnNouvelleCommande.Enabled = True

            End If

        End If

        If mode_attente_reception = True Then

            btn_switch.Enabled = True
            btn_switch.Image = My.Resources.Resources.baseline_sync_white_36dp


        Else
            btn_switch.Enabled = False
            btn_switch.Image = My.Resources.Resources.baseline_sync_black_36dp


        End If

    End Sub

    'Compter le nombre de commande de l'exercice du professeur.
    Public Function compter_commande_professeur()
        Dim str_requete_compter As String = ""

        str_requete_compter = "select count(*) from tbl_commandes_prof cp, tbl_exercices e, tbl_utilisateurs u, tbl_commandes c
                                where c.no_commande = cp.no_commande
                                and cp.no_exercice = e.no_exercice
                                and cp.no_utilisateur = u.no_utilisateur
                                and e.no_exercice =" & exercice

        gestionBd.miseAjourDS(dataSet, dataAdapter, str_requete_compter, "tbl_commandes_prof")
        Return dataSet.Tables(0).Rows(0).Item(0)

    End Function
    'Compter le nombre de réception rataché à l'exercice.
    Public Sub compter_recepetion_exercice()

        Dim str_requete_compter As String = ""

        str_requete_compter = "select count(*) from tbl_reception_exercices re, tbl_exercices e
                               where re.no_exercice = e.no_exercice and re.actif = true and e.no_exercice = " & exercice

        gestionBd.miseAjourDS(dataSet, dataAdapter, str_requete_compter, "tbl_reception_exercices")
        nbr_recepetion_exercice = dataSet.Tables(0).Rows(0).Item(0)

    End Sub

    'Compter le nombre de commande relié à l'exercice.
    Public Sub compter_commande_exercice()

        Dim str_requete_compter As String = ""

        str_requete_compter = "select count(*) from tbl_commandes c, tbl_utilisateurs u, tbl_exercices e
                                where c.no_utilisateur = u.no_utilisateur and c.no_exercice = e.no_exercice
                                and c.no_utilisateur = '" & utls.No_id & "' And c.no_exercice = " & exercice & " and c.actif = true"

        gestionBd.miseAjourDS(dataSet, dataAdapter, str_requete_compter, "tbl_commandes")
        nbr_commande_exercice = dataSet.Tables(0).Rows(0).Item(0)

    End Sub

    'Remplir la commande si l'exercice existe déja.
    Public Sub remplir_commande()


        lsv_controle = lsvCommande
        lsv_controle.Items.Clear()
        Dim str_requete_remplir As String = ""
        Dim prix_unitaire As Double = 0
        Dim quantite As Double = 0
        Dim prix_total As Double = 0
        str_requete_remplir = "select distinct p.nom_produit, f.nom_fournisseur,cd.quantite,ft.nom_format , um.unite_mesure,cd.prix_unitaire
                                from tbl_commandes c, tbl_exercices e, tbl_fournisseurs f, tbl_utilisateurs u, tbl_commandes_detaillees cd, tbl_produits p,
                                tbl_unites_mesure um, tbl_formats ft, tbl_categories cg, tbl_produit_fournisseur_prix pr
                                where c.no_exercice = e.no_exercice 
                                and c.no_utilisateur = u.no_utilisateur 
                                and f.no_fournisseur = c.no_fournisseur
                                and cd.no_commande = c.no_commande 
                                and cd.no_produit = p.code_produit
                                and um.no_mesure = p.no_mesure 
                                and ft.no_format = p.no_format
                                and p.no_categorie = cg.no_categorie
                                and pr.code_produit = p.code_produit 
                                and pr.no_fournisseur = f.no_fournisseur
                                and c.no_fournisseur = f.no_fournisseur
                                and c.actif = true
                                and e.no_exercice = " & exercice & " and u.no_utilisateur ='" & utls.No_id & "'"

        gestionBd.miseAjourDS(dataSet, dataAdapter, str_requete_remplir, "tbl_commandes")

        For i = 0 To dataSet.Tables(0).Rows.Count - 1

            lsv_controle.Items.Add(dataSet.Tables(0).Rows(i).Item(0))
            lsv_controle.Items(lsv_controle.Items.Count - 1).SubItems.Add(dataSet.Tables(0).Rows(i).Item(1))
            lsv_controle.Items(lsv_controle.Items.Count - 1).SubItems.Add(dataSet.Tables(0).Rows(i).Item(2))
            lsv_controle.Items(lsv_controle.Items.Count - 1).SubItems.Add(dataSet.Tables(0).Rows(i).Item(3))
            lsv_controle.Items(lsv_controle.Items.Count - 1).SubItems.Add(dataSet.Tables(0).Rows(i).Item(4))
            lsv_controle.Items(lsv_controle.Items.Count - 1).SubItems.Add(dataSet.Tables(0).Rows(i).Item(5))
            quantite = lsv_controle.Items(i).SubItems(2).Text
            prix_total = quantite * prix_unitaire
            prix_unitaire = replace_signe_dollars(lsv_controle.Items(i).SubItems(5).Text, "virgule")
            lsv_controle.Items(lsv_controle.Items.Count - 1).SubItems.Add(FormatCurrency(prix_total))

        Next

        'Calculer les taxes'
        calculer()

    End Sub

    'Trouver le dataset pour la réception.

    Public Sub trouver_ds_reception()

        str_requete = " Select  f.nom_fournisseur
                        From tbl_fournisseurs f , tbl_commandes c, tbl_exercices e, tbl_utilisateurs u
                        Where f.no_fournisseur = c.no_fournisseur
                        And c.no_utilisateur = u.no_utilisateur
                        And e.no_exercice = c.no_exercice
                        and c.actif = true
                        and e.no_exercice = " & exercice & " and u.no_utilisateur ='" & utls.No_id & "'"

        gestionBd.miseAjourDS(dataSet, dataAdapter, str_requete, "tbl_commandes")

        For i = 0 To dataSet.Tables(0).Rows.Count - 1

            If i = 0 Then
                str_fournisseur = " and f.nom_fournisseur ='" & dataSet.Tables(0).Rows(i).Item(0) & "'"
            Else
                str_fournisseur = str_fournisseur & " or no_fournisseur = f.no_fournisseur and code_produit = p.code_produit AND f.nom_fournisseur = '" & dataSet.Tables(0).Rows(i).Item(0) & "'"

            End If
        Next

    End Sub

    'Charger le dataset de la réception avec les paramètres de recherche. (Doit utiliser trouver_ds_reception avant pour initialiser str_fournisseur).
    Public Sub charger_ds_reception(str_fournisseur As String)


        dgvCommande.DataSource = Nothing

        str_requete = "Select p.code_produit as `code de produit`, p.nom_produit as Produits , f.nom_fournisseur as Fournisseurs ,fm.nom_format as Format , um.unite_mesure as `Unites de mesures`,concat(pr.prix, '$') as `Prix unitaire`
                        From tbl_fournisseurs f, tbl_produits p, tbl_unites_mesure um , tbl_formats fm, tbl_produit_fournisseur_prix  pr
                        Where p.code_produit = pr.code_produit And pr.no_fournisseur = f.no_fournisseur and f.actif = true And fm.no_format = p.no_format
                        And um.no_mesure = p.no_mesure and p.actif = true
                        and pr.`date_prix` = (select max(date_Prix) from tbl_produit_fournisseur_prix where no_fournisseur = f.no_fournisseur and code_produit = p.code_produit " & str_fournisseur & ")
                        group by p.code_produit, p.nom_produit, f.nom_fournisseur,fm.nom_format , um.unite_mesure,pr.prix"

        gestionBd.miseAjourDS(dataRecherche, dataAdapter, str_requete, "tbl_produits")

        RemplirGrid()



    End Sub

    'Remplir la réception lors d'une modification.
    Public Sub remplir_reception_modifier()

        nouvelle_reception = False

        lsv_controle = lsvReception
        lsv_controle.Items.Clear()
        no_recepetion = trouver_no_recepetion()
        ds_charger_reception()

        Dim prix_unitaire As Double = 0
        Dim quantite As Double = 0
        Dim prix_total As Double = 0

        For i = 0 To dataSet.Tables(0).Rows.Count - 1

            lsv_controle.Items.Add(dataSet.Tables(0).Rows(i).Item(0))
            lsv_controle.Items(lsv_controle.Items.Count - 1).SubItems.Add(dataSet.Tables(0).Rows(i).Item(1))
            lsv_controle.Items(lsv_controle.Items.Count - 1).SubItems.Add(dataSet.Tables(0).Rows(i).Item(2))
            lsv_controle.Items(lsv_controle.Items.Count - 1).SubItems.Add(dataSet.Tables(0).Rows(i).Item(3))
            lsv_controle.Items(lsv_controle.Items.Count - 1).SubItems.Add(dataSet.Tables(0).Rows(i).Item(4))
            lsv_controle.Items(lsv_controle.Items.Count - 1).SubItems.Add(FormatCurrency(dataSet.Tables(0).Rows(i).Item(5)))
            quantite = lsv_controle.Items(i).SubItems(2).Text
            prix_unitaire = lsv_controle.Items(i).SubItems(5).Text
            prix_total = quantite * prix_unitaire
            lsv_controle.Items(lsv_controle.Items.Count - 1).SubItems.Add(FormatCurrency(prix_total))

        Next

        'Calculer les taxes.
        calculer()

        'Activer les boutons relié à la commande.
        activer_commande()
    End Sub

    'Charger le dataset de la réception.
    Public Sub ds_charger_reception()

        str_requete_remplir = "Select distinct p.nom_produit, f.nom_fournisseur,rd.quantite,ft.nom_format , um.unite_mesure,rd.prix_unitaire
                                from tbl_reception_details rd, tbl_commandes c, tbl_produits p,
                                tbl_unites_mesure um, tbl_formats ft, tbl_categories cg, tbl_produit_fournisseur_prix pr, tbl_fournisseurs F
                                where rd.no_commande = c.no_commande
                                and RD.code_produit = P.code_produit
                                AND P.no_format = FT.no_format
                                and p.no_categorie = cg.no_categorie
                                and p.no_mesure = um.no_mesure
                                and pr.code_produit = p.code_produit 
                                and pr.no_fournisseur = f.no_fournisseur
                                and c.no_fournisseur = f.no_fournisseur
                                and rd.no_reception = " & no_recepetion

        gestionBd.miseAjourDS(dataSet, dataAdapter, str_requete_remplir, "tbl_reception_details")
    End Sub

    'Trouver le numéro de réception.
    Public Function trouver_no_recepetion()

        Dim str_requete As String = ""

        str_requete = "Select no_reception from tbl_reception_exercices where no_exercice = " & exercice & ""

        gestionBd.miseAjourDS(dataSet, dataAdapter, str_requete, "tbl_reception_exercices")

        Return dataSet.Tables(0).Rows(0).Item(0)
    End Function


    'Désactiver les boutons pour commander.
    Public Sub desactiver_commande()

        btnAjouter.Enabled = False
        btnModifier.Enabled = False
        btnSupprimer.Enabled = False

    End Sub

    'Activer les boutons pour commander.
    Public Sub activer_commande()

        btnAjouter.Enabled = True
        btnModifier.Enabled = True
        btnSupprimer.Enabled = True

    End Sub


    Private Sub dgvcommande_CellMouseLeave(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
        If e.RowIndex > -1 Then
            dgvCommande.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
            dgvCommande.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
        End If
    End Sub

    Private Sub dgvcommande_CellMouseEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
        If e.RowIndex > -1 Then

            dgvCommande.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(236, 240, 241)
            dgvCommande.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black

        End If

    End Sub

    'Réinitialisation du DataSet
    'C'est pour faire propre.
    'Va vider toutes les textbox de la section recherches.
    Sub Reinitialiser_Textboxes()

        Dim tab_recherches() As Control = {txt_rech_nom, txt_rech_Fournisseur,
                                            cbo_nom_contient, cbo_Fournisseur_contient}
        For i = 0 To tab_recherches.Count - 1
            tab_recherches(i).Text = String.Empty
        Next

        cbo_trier_par.SelectedIndex = 0


    End Sub

    'Permet de trouver les résultats lorsqu'il quitte le panel de recherche.

    'Private Sub pnl_recherches_MouseLeave(sender As Object, e As EventArgs) Handles txt_rech_Fournisseur.LostFocus, txt_rech_nom.LostFocus, pnl_recherches.LostFocus

    '    Trouver_Resultats()

    'End Sub

    'Charger le dataset.
    Sub Charger_DS()


        str_requete_recherche = "Select p.code_produit as `code de produit`, p.nom_produit as Produits , f.nom_fournisseur as Fournisseurs ,fm.nom_format as Format , um.unite_mesure as `Unites de mesures`,pr.prix as `Prix unitaire`
                                From tbl_fournisseurs f, tbl_produits p, tbl_unites_mesure um , tbl_formats fm, tbl_produit_fournisseur_prix  pr
                                Where p.code_produit = pr.code_produit And pr.no_fournisseur = f.no_fournisseur and f.actif = true And fm.no_format = p.no_format
                                And um.no_mesure = p.no_mesure and p.actif = true
                                and pr.`date_prix` = (select max(date_Prix) from tbl_produit_fournisseur_prix where no_fournisseur = f.no_fournisseur and code_produit = p.code_produit)
                                group by p.code_produit, p.nom_produit, f.nom_fournisseur,fm.nom_format , um.unite_mesure,pr.prix"


        gestionBd.miseAjourDS(dataRecherche, dataAdapter, str_requete_recherche, "tbl_produits")

        RemplirGrid()


    End Sub

    'Remplir le datagridView'

    Private Sub RemplirGrid()
        dgvCommande.Rows.Clear()
        With dataRecherche.Tables(0)
            For i As Integer = 0 To .Rows.Count - 1
                dgvCommande.Rows.Add(.Rows(i).Item(0))
                dgvCommande.Rows(dgvCommande.Rows.Count - 1).Cells(1).Value = .Rows(i).Item(1)
                dgvCommande.Rows(dgvCommande.Rows.Count - 1).Cells(2).Value = .Rows(i).Item(2)
                dgvCommande.Rows(dgvCommande.Rows.Count - 1).Cells(3).Value = .Rows(i).Item(3)
                dgvCommande.Rows(dgvCommande.Rows.Count - 1).Cells(4).Value = .Rows(i).Item(4)
                dgvCommande.Rows(dgvCommande.Rows.Count - 1).Cells(5).Value = .Rows(i).Item(5)
            Next
        End With

        remplir_info()
    End Sub

    'Remplir la liste d'informations sélectionné.
    ''' <summary>
    ''' Méthode qui rempli les informations du produit sélectionné , changement du format du prix unitaire 
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Public Sub remplir_info()

        If dataRecherche.Tables(0).Rows.Count <> 0 Then
            txtNomProduit.Text = dgvCommande.CurrentRow.Cells(1).Value
            txtNomFournisseur.Text = dgvCommande.CurrentRow.Cells(2).Value
            txtFormat.Text = dgvCommande.CurrentRow.Cells(3).Value
            txtUniteMesure.Text = dgvCommande.CurrentRow.Cells(4).Value
            txtPrixUnitaire.Text = dgvCommande.CurrentRow.Cells(5).Value
            txtPrixUnitaire.Text = txtPrixUnitaire.Text.Replace(".", ",")
            If Not InStr(1, txtPrixUnitaire.Text, ",") > 0 Then
                txtPrixUnitaire.Text += ",00"
                txtPrixUnitaire.Text += " $"
            Else
                txtPrixUnitaire.Text += " $"
            End If
        End If
    End Sub

    'Bouton rechercher qui trouve les résultats et remplis le datagridview.
    Private Sub btnRechercher_Click(sender As Object, e As EventArgs) Handles btnRechercher.Click
        Trouver_Resultats()
        RemplirGrid()
        'dgvCommande.AutoResizeColumnHeadersHeight()
    End Sub


    'Bouton rénitialiser qui rénitialise tout.
    Private Sub btnReinitialiser_Click(sender As Object, e As EventArgs) Handles btnReinitialiser.Click



        If btn_switch.Text = "Réception de commande" Then
            str_fournisseur = ""
            Charger_DS()
        Else
            trouver_ds_reception()
            charger_ds_reception(str_fournisseur)
        End If


        cbo_ordre.SelectedIndex = 0
        cbo_trier_par.SelectedIndex = 0
        cbo_nom_contient.SelectedIndex = 0
        cbo_Fournisseur_contient.SelectedIndex = 0
        cbo_rech_Tvq.SelectedIndex = 0
        Reinitialiser_Textboxes()

    End Sub

    'S'active pour vérifier le nombre de résultats pour ensuite l'afficher dans le bouton 'Rechercher'
    'Pour afficher les résultats dans la datagridview, il faudra aller cliquer sur le bouton 'Rechercher'
    Sub Trouver_Resultats()

        Dim requete As String = ""
        If btn_switch.Text = "Réception de commande" Then
            str_fournisseur = ""
        Else
            trouver_ds_reception()
        End If


        If cbo_rech_Tvq.Text = "Taxable" Then
            requete = "Select p.code_produit as `code de produit`, p.nom_produit as Produits , f.nom_fournisseur as Fournisseurs ,fm.nom_format as Format , um.unite_mesure as `Unites de mesures`,concat(pr.prix, '$') as `Prix unitaire`
                                From tbl_fournisseurs f, tbl_produits p, tbl_unites_mesure um , tbl_formats fm, tbl_produit_fournisseur_prix  pr, tbl_taxes t, tbl_produit_taxe pt
                                Where p.code_produit = pr.code_produit And pr.no_fournisseur = f.no_fournisseur And fm.no_format = p.no_format
                                And um.no_mesure = p.no_mesure  And p.actif = true" & Rechercher_Nom_Fournisseur("nom_produit", cbo_nom_contient, txt_rech_nom) &
                                    Rechercher_Nom_Fournisseur("nom_fournisseur", cbo_Fournisseur_contient, txt_rech_Fournisseur) & "
                                And pr.`date_prix` = (select max(date_Prix) from tbl_produit_fournisseur_prix where no_fournisseur = f.no_fournisseur and code_produit = p.code_produit " & str_fournisseur & Rechercher_Categories() & ")
            group by p.code_produit,p.nom_produit, f.nom_fournisseur,fm.nom_format , um.unite_mesure,pr.prix" &
                                    Verifier_Tri(cbo_trier_par.Text)



        Else

            requete = "Select p.code_produit as `code de produit`, p.nom_produit as Produits , f.nom_fournisseur as Fournisseurs ,fm.nom_format as Format , um.unite_mesure as `Unites de mesures`,concat(pr.prix, '$') as `Prix unitaire`
                                From tbl_fournisseurs f, tbl_produits p, tbl_unites_mesure um , tbl_formats fm, tbl_produit_fournisseur_prix  pr
                                Where p.code_produit = pr.code_produit And pr.no_fournisseur = f.no_fournisseur and f.actif = true And fm.no_format = p.no_format
                                And um.no_mesure = p.no_mesure  And p.actif = true" & Rechercher_Nom_Fournisseur("nom_produit", cbo_nom_contient, txt_rech_nom) &
                                    Rechercher_Nom_Fournisseur("nom_fournisseur", cbo_Fournisseur_contient, txt_rech_Fournisseur) & "
                                And pr.`date_prix` = (select max(date_Prix) from tbl_produit_fournisseur_prix where no_fournisseur = f.no_fournisseur and code_produit = p.code_produit " & str_fournisseur & ")
                                group by  p.code_produit,p.nom_produit, f.nom_fournisseur,fm.nom_format , um.unite_mesure,pr.prix" &
                                    Verifier_Tri(cbo_trier_par.Text)

        End If

        gestionBd.miseAjourDS(dataRecherche, dataAdapter, requete, "tbl_produits")

        RemplirGrid()

    End Sub


    'Vérifier le tri qu'il à choisi.
    Function Verifier_Tri(choix As String) As String
        Select Case choix
            Case "N° de produit (par défaut)"
                Return " ORDER BY p.code_produit " & Verifier_Ordre(cbo_ordre.Text)
            Case "Nom de produit"
                Return " ORDER BY p.nom_produit " & Verifier_Ordre(cbo_ordre.Text)
            Case "Marque"
                Return " ORDER BY p.marque " & Verifier_Ordre(cbo_ordre.Text)
            Case "Catégorie"
                Return " ORDER BY c.nom_categorie " & Verifier_Ordre(cbo_ordre.Text)
            Case Else
                Return " ORDER BY p.code_produit " & Verifier_Ordre(cbo_ordre.Text)
        End Select
    End Function

    'Vérifier l'odre dans lequel il veut que ça se trie.

    Function Verifier_Ordre(choix As String) As String
        If choix = "Ordre croissant" Then
            Return "ASC"
        Else
            Return "DESC"
        End If
    End Function


    'Faire Rechercher_Nom() et Rechercher_Marque() semblait redondant, alors ils ont été fusionnés pour devenir la fonction ci-dessous
    'La colonne va dicter avec quelle colonne on va travailler pour la requête, tandis que le ComboBox indique par quoi on désire chercher.
    Function Rechercher_Nom_Fournisseur(colonne As String, ByVal choix As ComboBox, ByVal rech As TextBox) As String
        Select Case choix.Text
            Case "Contient"
                If rech.Text <> "" Then
                    Return " And " & colonne & " Like '%" & StrConv(mod_regex.ConvertirApostrophe(rech.Text.Trim), VbStrConv.ProperCase) & "%'"

                Else
                    Return ""
                End If
            Case "Commence par"
                If rech.Text <> "" Then
                    Return " AND " & colonne & " LIKE '" & StrConv(mod_regex.ConvertirApostrophe(rech.Text.Trim), VbStrConv.ProperCase) & "%'"
                Else
                    Return ""
                End If
            Case Else
                Return ""
        End Select
    End Function

    'Rechercher par catégories.
    Function Rechercher_Categories() As String
        If cbo_rech_Tvq.Text = "Taxable" Then
            Return " AND t.id_taxes = pt.id_taxe AND pt.code_produit = p.code_produit"
        Else
            Return ""
        End If
    End Function


    'La méthode qui permet d'ajouter une commande'
    Public Function ajouterCommande() As Boolean

        Dim quantite_total As Double = 0
        Dim quantite As Double = 0
        Dim prix_total_ajout As Double = 0
        Dim prix_total_commande As Double = 0

        Dim ctrExiste As Integer = 0

        If lsv_controle.Items.Count >= 1 Then
            ' On compte le nombre d'élément dans la panier'
            For ctrposition = 0 To lsv_controle.Items.Count - 1


                'Si le produit sélectionner dans la combobox est déja dans la panier, alors on augmente la quantité
                If txtNomProduit.Text = lsv_controle.Items(ctrposition).Text And dgvCommande.CurrentRow.Cells(2).Value = lsv_controle.Items(ctrposition).SubItems(1).Text And txtFormat.Text.Trim =
                    lsv_controle.Items(ctrposition).SubItems(3).Text And txtUniteMesure.Text = lsv_controle.Items(ctrposition).SubItems(4).Text Then

                    prix_total_ajout = CDbl(txtQuantite.Text) * replace_signe_dollars(dgvCommande.CurrentRow.Cells(5).Value, "virgule")
                    prix_total_commande = replace_signe_dollars(lsv_controle.Items(ctrposition).SubItems(2).Text, "virgule") * replace_signe_dollars(lsv_controle.Items(ctrposition).SubItems(5).Text, "virgule")
                    prix_total_commande += prix_total_ajout
                    quantite_total = CDbl(txtQuantite.Text) + replace_signe_dollars(lsv_controle.Items(ctrposition).SubItems(2).Text, "virgule")

                    If calculer_prix_total_commande(prix_total_ajout) Then

                        lsv_controle.Items(ctrposition).SubItems(2).Text = quantite_total
                        lsv_controle.Items(ctrposition).SubItems(6).Text = FormatCurrency(prix_total_commande)

                        ctrExiste += 1
                    Else
                        Return False
                    End If
                End If
            Next


            'Si le produit n'existe pas, on en ajoute un nouveau'
            If ctrExiste = 0 Then

                prix_total_ajout = CDbl(txtQuantite.Text) * replace_signe_dollars(dgvCommande.CurrentRow.Cells(5).Value, "virgule")

                If calculer_prix_total_commande(prix_total_ajout) Then

                    prix_unitaire = replace_signe_dollars(dgvCommande.CurrentRow.Cells(5).Value, "virgule")
                    lsv_controle.Items.Add(txtNomProduit.Text)
                    lsv_controle.Items(lsv_controle.Items.Count - 1).SubItems.Add(dgvCommande.CurrentRow.Cells(2).Value)
                    lsv_controle.Items(lsv_controle.Items.Count - 1).SubItems.Add(txtQuantite.Text)
                    lsv_controle.Items(lsv_controle.Items.Count - 1).SubItems.Add(txtFormat.Text.Trim)
                    lsv_controle.Items(lsv_controle.Items.Count - 1).SubItems.Add(txtUniteMesure.Text)
                    lsv_controle.Items(lsv_controle.Items.Count - 1).SubItems.Add(FormatCurrency(dgvCommande.CurrentRow.Cells(5).Value))
                    prix_total_commande = prix_unitaire * txtQuantite.Text
                    lsv_controle.Items(lsv_controle.Items.Count - 1).SubItems.Add(FormatCurrency(prix_total_commande))

                Else
                    Return False
                End If

            End If

        End If
        'Si la commande est vide, on ajoute le premier produit à la commande'
        If lsv_controle.Items.Count = 0 Then
            prix_total_ajout = CDbl(txtQuantite.Text) * replace_signe_dollars(dgvCommande.CurrentRow.Cells(5).Value, "virgule")

            If calculer_prix_total_commande(prix_total_ajout) Then
                prix_unitaire = replace_signe_dollars(dgvCommande.CurrentRow.Cells(5).Value, "virgule")
                lsv_controle.Items.Add(txtNomProduit.Text)
                lsv_controle.Items(lsv_controle.Items.Count - 1).SubItems.Add(dgvCommande.CurrentRow.Cells(2).Value)
                lsv_controle.Items(lsv_controle.Items.Count - 1).SubItems.Add(txtQuantite.Text)
                lsv_controle.Items(lsv_controle.Items.Count - 1).SubItems.Add(txtFormat.Text.Trim)
                lsv_controle.Items(lsv_controle.Items.Count - 1).SubItems.Add(txtUniteMesure.Text)
                lsv_controle.Items(lsv_controle.Items.Count - 1).SubItems.Add(FormatCurrency(dgvCommande.CurrentRow.Cells(5).Value))

                prix_total_commande = prix_unitaire * txtQuantite.Text
                lsv_controle.Items(lsv_controle.Items.Count - 1).SubItems.Add(FormatCurrency(prix_total_commande))

            Else
                Return False
            End If

        End If

        'Appel la méthode pour calculer le prix total et les taxes'
        calculer()
        Return True

    End Function

    'Méthode qui vérifie le prix total d'une commande avant taxe.

    Public Function calculer_prix_total_commande(prix_total_produit As Double) As Boolean
        Dim prix_total As Double = 0

        For i = 0 To lsv_controle.Items.Count - 1
            prix_total += lsv_controle.Items(i).SubItems(6).Text
        Next

        prix_total += prix_total_produit

        If prix_total > 9999 Then

            MessageBox.Show("Le prix maximum pour une commande est de 9999$, taxes non incluses.", "Commande", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            Return True
        End If

    End Function



    'méthode pour calculer le prix total avec les taxes.
    Public Sub calculer()

        tps = 0
        tvq = 0

        Dim prix_tps As Double = 0
        Dim prix_tvq As Double = 0
        Dim total_tps As Double = 0
        Dim total_tvq As Double = 0
        Dim tps_tvq As Double = 0
        Dim prix_produit As Double = 0

        Dim prix_taxes As Double = 0

        Dim str_taxes As String = ""

        str_taxes = "Select pt.code_produit, t.type_taxe, p.nom_produit, f.nom_format
                    from tbl_produit_taxe pt , tbl_taxes t, tbl_produits p, tbl_formats f
                    where p.code_produit = pt.code_produit and t.id_taxes = pt.id_taxe and f.no_format = p.no_format"

        table = "tbl_produit_taxe"

        gestionBd.miseAjourDS(datasetTaxes, dataAdapter, str_taxes, table)


        Dim prixUnitaire As Double = 0
        Dim prix_total As Double = 0

        'boucle qui compte le nombre d'item dans la commande'
        For i = 0 To lsv_controle.Items.Count - 1
            prix_produit = 0
            'Le prix est égal a la quantite* le prix'
            prixUnitaire = lsv_controle.Items(i).SubItems(2).Text * replace_signe_dollars(lsv_controle.Items(i).SubItems(5).Text, "virgule")
            prix_produit = lsv_controle.Items(i).SubItems(2).Text * replace_signe_dollars(lsv_controle.Items(i).SubItems(5).Text, "virgule")

            prix_total += prixUnitaire

            'prix_taxes = (tps + tvq)
            'prix_taxes = (prixTotal * prix_taxes) / 100
            tps = 0
            tvq = 0

            tps_tvq = 0
            For i2 = 0 To datasetTaxes.Tables(0).Rows.Count - 1

                If datasetTaxes.Tables(0).Rows(i2).Item(1) = "TPS" And datasetTaxes.Tables(0).Rows(i2).Item(2) = lsv_controle.Items(i).Text And datasetTaxes.Tables(0).Rows(i2).Item(3) = lsv_controle.Items(i).SubItems(3).Text Then
                    tps = Val(gestionBd.Requete("select `pourcentage_taxe` from `tbl_taxes` where `type_taxe` = 'TPS' and `date_taxe` = (select max(`date_taxe`) from tbl_taxes where type_taxe = 'TPS' group by `type_taxe`) and `id_taxes` = (select max(`id_taxes`) from tbl_taxes where type_taxe = 'TPS' group by `type_taxe`)"))
                End If

                If datasetTaxes.Tables(0).Rows(i2).Item(1) = "TVQ" And datasetTaxes.Tables(0).Rows(i2).Item(2) = lsv_controle.Items(i).Text And datasetTaxes.Tables(0).Rows(i2).Item(3) = lsv_controle.Items(i).SubItems(3).Text Then
                    tvq = Val(gestionBd.Requete("select `pourcentage_taxe` from `tbl_taxes` where `type_taxe` = 'TVQ'and `date_taxe` = (select max(`date_taxe`) from tbl_taxes where type_taxe = 'TVQ' group by `type_taxe`) and `id_taxes` = (select max(`id_taxes`) from tbl_taxes where type_taxe = 'TVQ' group by `type_taxe`)"))
                End If
            Next

            If tps <> 0 Then
                prix_tps = (prix_produit * tps) / 100
                total_tps += prix_tps
                prix_tps = 0

            End If

            If tvq <> 0 Then

                prix_tvq = (prix_produit * tvq) / 100

                total_tvq += prix_tvq
                prix_tvq = 0
            End If
        Next

        'On affiche le prixTotal dans le label'
        lbTps.Text = FormatCurrency(total_tps)
        lbTvq.Text = FormatCurrency(total_tvq)
        lbSousTotal.Text = FormatCurrency(prix_total)
        prix_total += CDbl(lbTvq.Text) + CDbl(lbTps.Text)

        lbtotal.Text = FormatCurrency(prix_total)
    End Sub

    'Fonction qui permet de trouver le prix relié a l'item qu'il veut ajouter'
    Public Function trouver_prix(f_prix_produit As Double)

        strRequete = "Select pr.prix, p.nom_produit
                                from tbl_produit_fournisseur_prix  pr, tbl_produits p, tbl_fournisseurs f
                                where p.code_produit = pr.code_produit and f.no_fournisseur = pr.no_fournisseur and p.nom_produit ='" & txtNomProduit.Text & "'
                                and pr.`date_prix` = (select max(date_Prix) from tbl_produit_fournisseur_prix where no_fournisseur = f.no_fournisseur and code_produit = p.code_produit)
                                group by  pr.prix, p.nom_produit"


        table = "tbl_produit_fournisseur_prix "

        gestionBd.miseAjourDS(dataSet, dataAdapter, strRequete, table)


        f_prix_produit = dataSet.Tables(0).Rows(0).Item(0)
        Return f_prix_produit

    End Function

    'Fonction qui vérifie si tout les champs sont remplis'

    Public Function verificationChampNull(v_nulle As Boolean) As Boolean
        v_nulle = False
        If Not txtNomProduit.Text.Trim = "" Then
            If Not txtUniteMesure.Text.Trim = "" Then

                If Not txtFormat.Text.Trim = "" Then

                    If Not txtQuantite.Text.Trim = "" Then
                        v_nulle = True



                    End If
                End If

            End If
        End If

        Return v_nulle
    End Function
    'Bouton anuller qui rénitialise la commande
    Private Sub btnAnnulerCommande_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Êtes-vous certain de vouloir annuler votre commande? Cette opération est définitive.", "Annulation d'une commande", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            lsv_controle.Items.Clear()
            lbtotal.Text = 0

        End If
    End Sub

    'La méthode appelé lorsqu'une touche est inscrite dans le textbox'
    Private Sub txtRecherche_TextChanged(sender As Object, e As EventArgs)
        'recherchedataset()
    End Sub


    'Méthode qui détecte lorsque l'utilisateur clique sur une cellule et qui rempli automatiquement pour lui les champs appropriés.
    Private Sub dgvCommande_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvCommande.CellMouseClick
        txtQuantite.Text = 1
        remplir_info()
    End Sub



    'Bouton qui supprime un item lorsqu'il est sélectionner et que l'utilisateur clique sur le bouton supprimé'


    Private Sub txtQuantite_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantite.KeyPress
        If Not IsNumeric(e.KeyChar) AndAlso e.KeyChar <> ","c AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub


    'Bouton pour modifier la commande.
    Public Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click

        Dim nom_produit As String = ""
        Dim quantite As Double = 0
        Dim format As String = ""
        Dim unite_mesure As String = ""
        indice_commande = 0

        'Si le panier est vide.
        If lsv_controle.Items.Count = 0 Then
            MessageBox.Show("Votre panier est vide." & vbNewLine & "Vous ne pouvez pas modifier ce produit.", "Commande", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Sinon s'il n'a pas sélectionné de produit dans sa commande.
        ElseIf lsv_controle.SelectedIndices.Count = 0 Then
            MessageBox.Show("Sélectionnez un produit dans votre commande.", "Commande", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            nom_produit = lsv_controle.SelectedItems(0).Text
            quantite = lsv_controle.SelectedItems(0).SubItems(2).Text
            format = lsv_controle.SelectedItems(0).SubItems(3).Text
            unite_mesure = lsv_controle.SelectedItems(0).SubItems(4).Text
            indice_commande = lsv_controle.SelectedIndices(0)

            'Ouvrir le formulaire pour modifier la commande.
            _frm_modifier_commande = New frmModifierCommande(Me, indice_commande, lsv_controle)

            _frm_modifier_commande.ShowDialog()

        End If

    End Sub


    'Bouton pour ajouter.
    Private Sub btnAjouter_Click_1(sender As Object, e As EventArgs) Handles btnAjouter.Click
        Dim nulle As Boolean = True
        'Vérification si tout les champs sont rempli'
        If verificationChampNull(nulle) = True Then

            'Si les champs sont rempli, la commande s'ajoute au panier'
            If btnNouvelleCommande.Text = "Nouvelle commande" Then
                nouvelle_commande = True
            Else

                nouvelle_reception = True
            End If


            If (ajouterCommande()) Then
                btnNouvelleCommande.Enabled = True
                btnEffectuer.Enabled = True
                strRequete = " Select  c.nom_categorie
                            From tbl_produits p, tbl_formats f, tbl_categories c, tbl_unites_mesure um
                            Where p.no_format = f.no_format And c.no_categorie = p.no_categorie And um.no_mesure = p.no_mesure"
                table = "tbl_produits"
                gestionBd.miseAjourDS(dataSet, dataAdapter, strRequete, table)
                lsv_controle.Items(lsv_controle.Items.Count - 1).SubItems.Add(dataSet.Tables(0).Rows(0).Item(0))
                '    lsv_controle.AutoResizeColumn(1,
                'ColumnHeaderAutoResizeStyle.HeaderSize)
                If btnNouvelleCommande.Text = "Nouvelle commande" Then

                    btn_nouvelle_commande = False
                Else
                    btn_nouvelle_reception = False

                End If

            End If

        Else
            MessageBox.Show("Veuillez compléter tous les champs.", "Commande", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    'Bouton supprimé.
    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        If lsv_controle.Items.Count = 0 Then
            MessageBox.Show("Votre panier est vide, vous ne pouvez pas supprimer de produits.", "Commande", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf lsv_controle.SelectedIndices.Count = 0 Then
            MessageBox.Show("Sélectionnez un produit dans votre panier.", "Commande", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            'Si un produit est supprimer, on recalcule le prix.'
            lsv_controle.Items.RemoveAt(lsv_controle.SelectedIndices(0))
            calculer()
        End If


        If lsv_controle.Items.Count = 0 Then

            btnEffectuer.Enabled = False

        End If

    End Sub

    'boutton éffectuer qui permet de passer une commande'
    Private Sub btnEffectuer_Click_1(sender As Object, e As EventArgs) Handles btnEffectuer.Click

        Dim generator As New Random
        randomValue = 0

        'On crée un objet de type commande_detaillee.
        commande_detaillee = New frm_sauvegarde_commande(utls, cours_exercice, exercice, Me)


        Dim id_fournisseur As String = ""

        'On trouve les noms des fournisseurs dans la commande. (utilise une liste.)
        trouver_nom_fournisseur()

        nombre_commande = 0

        'On trouve les id de ses fournisseurs.
        For i = 0 To liste_fournisseur.Count - 1
            id_fournisseur = trouver_id_fournisseur(liste_fournisseur(i))
            detailCommande(liste_fournisseur(i))
        Next
        'On génère les boutons dynamiquement qui seront statique dans detail_commande.
        commande_detaillee.panel_bouton_fin()
        If btnNouvelleCommande.Text = "Nouvelle commande" Then
            If nouvelle_commande = False Then
                If nbr_commande_exercice >= 1 Then

                Else
                    commande_detaillee.boutton_commander()
                End If
            Else
                commande_detaillee.boutton_commander()
            End If

        Else

            Dim commande As New Button
            Dim panel_fin As New Panel
            commande_detaillee.boutton_commander()
            commande = commande_detaillee.get_bouton_commander()
            commande.Text = "Confirmer"
            commande_detaillee.set_bouton_commander(commande)
        End If
        'Suite de la génération des boutons dynamique et statique.
        commande_detaillee.boutton_sauvegarder()
        commande_detaillee.boutton_ouvrir_pdf()
        commande_detaillee.boutton_annuler()

        commande_detaillee.calculer()

        commande_detaillee.ShowDialog()

    End Sub

    'Détail de la commmande.
    Public Sub detailCommande(nom_fournisseur As String)

        initialisation_frm_sauvegarde_commande(nom_fournisseur)

        For i = 0 To lsv_controle.Items.Count - 1
            If lsv_controle.Items(i).SubItems(1).Text = nom_fournisseur Then

                liste_Sauvegarde = commande_detaillee.get_liste()
                liste_Sauvegarde.Items.Add(lsv_controle.Items(i).Text)
                liste_Sauvegarde.Items(liste_Sauvegarde.Items.Count - 1).SubItems.Add(lsv_controle.Items(i).SubItems(1).Text)
                liste_Sauvegarde.Items(liste_Sauvegarde.Items.Count - 1).SubItems.Add(lsv_controle.Items(i).SubItems(2).Text)
                liste_Sauvegarde.Items(liste_Sauvegarde.Items.Count - 1).SubItems.Add(lsv_controle.Items(i).SubItems(3).Text)
                liste_Sauvegarde.Items(liste_Sauvegarde.Items.Count - 1).SubItems.Add(lsv_controle.Items(i).SubItems(4).Text)
                liste_Sauvegarde.Items(liste_Sauvegarde.Items.Count - 1).SubItems.Add(FormatCurrency(replace_signe_dollars(lsv_controle.Items(i).SubItems(5).Text, "virgule")))
                liste_Sauvegarde.Items(liste_Sauvegarde.Items.Count - 1).SubItems.Add(FormatCurrency(replace_signe_dollars(lsv_controle.Items(i).SubItems(6).Text, "virgule")))


                liste_Sauvegarde.AllowColumnReorder = False
                liste_Sauvegarde.LabelEdit = 1
                commande_detaillee.set_liste(liste_Sauvegarde)
            End If
        Next

    End Sub

    'Lorsqu'une nouvelle commande est crée, le boolean est à false.
    Public Sub initialiser_nouvelle_commande()
        nouvelle_commande = False
    End Sub




    'Initialisation des composants dynamique dans le formulaire frm_sauvegarde_commande

    Public Sub initialisation_frm_sauvegarde_commande(nom_fournisseur As String)

        'Initialisation des labels pour le formulaire frm_sauvegarde_commande.'
        Dim lb_nom_fournisseur As New Label()
        Dim lb_fournisseur As New Label()
        Dim lb_adresse_fournisseur As New Label
        Dim lb_ville_fournisseur As New Label
        Dim lb_code_postal_fournisseur As New Label
        Dim lb_date_commande As New Label
        Dim lb_numero_commande As New Label
        Dim no_commande As String = ""
        Dim remarque As String = ""

        'Initialisation des composants
        commande_detaillee.panel_entre()
        commande_detaillee.panel_dynamique()

        commande_detaillee.list_view_dynamique()

        commande_detaillee.fournisseur()
        commande_detaillee.date_commande()
        commande_detaillee.numero_commande()
        commande_detaillee.numero_commande()
        commande_detaillee.champ_numero_commande()
        If btnNouvelleCommande.Text = "Nouvelle commande" Then
            commande_detaillee.textbox_remarque()
            commande_detaillee.label_remarque()
        Else
            Dim titre As New Label
            titre = commande_detaillee.get_titre()
            titre.Text = "Réception de commande"
            commande_detaillee.set_titre(titre)
        End If

        compter_commande_exercice()

        If btnNouvelleCommande.Text = "Nouvelle commande" Or btnNouvelleCommande.Text = "Nouvelle réception" Then



            If nbr_commande_exercice >= 1 Then



                Dim txt_commande As New TextBox
                Dim date_commande As New Label
                Dim date_de_commande As New Date
                txt_commande = commande_detaillee.get_txt_numero_commande
                date_commande = commande_detaillee.get_date_commande()
                txt_commande.Enabled = False
                no_commande = trouver_no_commande(nom_fournisseur)
                date_de_commande = trouver_date_commande(no_commande)


                txt_commande.Text = no_commande
                date_commande.Text = "Date de commande : " & date_de_commande
                commande_detaillee.set_date_commande(date_commande)
                commande_detaillee.set_textbox_numero_commande(txt_commande)

            Else

                commande_detaillee.boutton_numero_aleatoire()

            End If

            commande_detaillee.label_erreur()
            commande_detaillee.panel_prix()
            commande_detaillee.tps()
            commande_detaillee.tvq()
            commande_detaillee.sous_total()

            commande_detaillee.total()
        Else


        End If



        If Not IsDBNull(nom_fournisseur) Then

            commande_detaillee.nom_fournisseur()
            lb_nom_fournisseur = commande_detaillee.get_nom_fournisseur
            lb_nom_fournisseur.Text = nom_fournisseur
            commande_detaillee.set_nom_fournisseur(lb_nom_fournisseur)


        End If
        'Charger le dataset contenant les informations a propos du fournisseur'
        info_fournisseur(nom_fournisseur)
        If dataSet.Tables(0).Rows(0).Item(3) <> "" Then

            commande_detaillee.adresse_fournisseur()
            lb_adresse_fournisseur = commande_detaillee.get_adresse_fournisseur
            lb_adresse_fournisseur.Text = dataSet.Tables(0).Rows(0).Item(3)
            commande_detaillee.set__adresse_fournisseur(lb_adresse_fournisseur)
        End If


        If Not IsDBNull(dataSet.Tables(0).Rows(0).Item(1)) Then

            commande_detaillee.ville_fournisseur()
            lb_ville_fournisseur = commande_detaillee.get_ville_fournisseur
            lb_ville_fournisseur.Text = dataSet.Tables(0).Rows(0).Item(1)
            commande_detaillee.set_ville_fournisseur(lb_ville_fournisseur)
        End If

        If Not IsDBNull(dataSet.Tables(0).Rows(0).Item(2)) Then

            commande_detaillee.code_postal_fournisseur()
            lb_code_postal_fournisseur = commande_detaillee.get_code_postal_fournisseur
            lb_code_postal_fournisseur.Text = dataSet.Tables(0).Rows(0).Item(2)
            commande_detaillee.set_code_postal_fournisseur(lb_code_postal_fournisseur)
        End If



        If btnNouvelleCommande.Text = "Nouvelle commande" And nbr_commande_exercice >= 1 Then

            'Ajout de remarque
            Dim txt_remarque As New TextBox
            txt_remarque = commande_detaillee.get_remarque
            txt_remarque.Enabled = False
            remarque = trouver_remarque(no_commande)
            txt_remarque.Text = remarque
            commande_detaillee.set_remarque(txt_remarque)


        End If



    End Sub

    'Function qui permet de trouver la dâte d'une commande.

    Public Function trouver_date_commande(no_commande)

        Dim str_requete As String = ""

        str_requete = "Select date_commande from tbl_commandes where actif = true and
        no_commande = " & no_commande & ""

        gestionBd.miseAjourDS(dataSet, dataAdapter, str_requete, "tbl_commandes")

        Return dataSet.Tables(0).Rows(0).Item(0)

    End Function


    'Fonction qui permet de trouver le numéro de commande en ayant le nom du fournisseur.'

    Public Function trouver_no_commande(nom_fournisseur As String) As String

        Dim str_requete As String = ""
        str_requete = "Select no_commande from  tbl_fournisseurs f, tbl_commandes c, tbl_exercices e, tbl_utilisateurs u
                where c.no_fournisseur = f.no_fournisseur and e.no_exercice = c.no_exercice and u.no_utilisateur = c.no_utilisateur and c.actif = true
                and f.nom_fournisseur = '" & nom_fournisseur & "'and e.no_exercice = " & exercice & " and u.no_utilisateur ='" & utls.No_id & "'"

        gestionBd.miseAjourDS(dataSet, dataAdapter, str_requete, "tbl_commandes")

        Return dataSet.Tables(0).Rows(0).Item(0)


    End Function

    'Function qui permet de trouver la remarque avec un numéro de commande.'
    Public Function trouver_remarque(no_commande As Integer) As String
        Dim str_requete As String = ""
        str_requete = "Select remarque from  tbl_commandes where  no_commande =" & no_commande & ""

        gestionBd.miseAjourDS(dataSet, dataAdapter, str_requete, "tbl_commandes")

        Return dataSet.Tables(0).Rows(0).Item(0)


    End Function

    'Recherche des informations sur le fournisseur'
    Public Sub info_fournisseur(nom_fournisseur As String)

        Dim str_info_fournisseur As String = ""
        Dim tbl_info_fournisseur As String = ""

        str_info_fournisseur = "Select f.nom_fournisseur, v.nom_ville, f.code_postal,adresse, f.lien_internet
from tbl_fournisseurs f , tbl_ville v where f.ville = v.no_ville and  f.nom_fournisseur = '" & nom_fournisseur & "'"

        tbl_info_fournisseur = "tbl_fournisseurs"

        gestionBd.miseAjourDS(dataSet, dataAdapter, str_info_fournisseur, tbl_info_fournisseur)


    End Sub

    'Function qui permet de générer une liste des noms des fournisseurs qui sont dans la commande.

    Public Sub trouver_nom_fournisseur()

        Erase liste_fournisseur
        Dim ctr_fournisseur As Integer = 0
        Dim ctr_fournisseur_total As Integer = 0

        ReDim liste_fournisseur(lsv_controle.Items.Count - 1)

        For i = 0 To lsv_controle.Items.Count - 1

            If liste_fournisseur.Contains(lsv_controle.Items(i).SubItems(1).Text) Then

            Else
                liste_fournisseur(ctr_fournisseur) = lsv_controle.Items(i).SubItems(1).Text
                ctr_fournisseur += 1
            End If

        Next

        ReDim Preserve liste_fournisseur(ctr_fournisseur - 1)

    End Sub


    'Fonction qui permet de trouver l'id d'un fournisseur.
    Public Function trouver_id_fournisseur(nom_fournisseur As String) As String

        strRequete = "select nom_fournisseur, no_fournisseur from tbl_fournisseurs where nom_fournisseur = '" & nom_fournisseur & "'"

        table = "tbl_fournisseurs"
        gestionBd.miseAjourDS(dataSet, dataAdapter, strRequete, table)


        Return dataSet.Tables(0).Rows(0).Item(1)

    End Function

    'Bouton nouvelle commande '
    Private Sub btnNouvelleCommande_Click(sender As Object, e As EventArgs) Handles btnNouvelleCommande.Click

        nouvelle_commande = True

        Dim passe As Boolean = False

        compter_recepetion_exercice()

        If btnNouvelleCommande.Text = "Nouvelle commande" And nbr_recepetion_exercice = 1 Then

            If MessageBox.Show("Êtes-vous certain de vouloir effectuer une nouvelle commande? Votre ancienne commande ainsi que votre réception seront supprimées.", "Nouvelle commande", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                btn_nouvelle_commande = True
                passe = True
                mode_attente_reception = False
                desactiver_table_commande()
                desactiver_table_repcetion()
                lsv_controle = lsvReception
                lsv_controle.Items.Clear()
                lsv_controle = lsvCommande
                lsv_controle.Items.Clear()
                mode_attente_reception = False
            End If

        ElseIf btnNouvelleCommande.Text = "Nouvelle commande" Then
            lsv_controle = lsvCommande
            If MessageBox.Show("Êtes-vous certain de vouloir effectuer une nouvelle commande? Votre ancienne commande sera supprimée.", "Nouvelle commande", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                btn_nouvelle_commande = True
                passe = True
                mode_attente_reception = True
                mode_attente_reception = True
                desactiver_table_commande()
                lsv_controle.Items.Clear()
                mode_attente_reception = False

            End If

        Else
            lsv_controle = lsvReception
            If MessageBox.Show("Êtes-vous certain de vouloir effectuer une nouvelle réception? Votre ancienne réception sera supprimée.", "Nouvelle réception", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                nouvelle_reception = True
                btn_nouvelle_reception = True
                passe = True
                desactiver_table_repcetion()
                lsv_controle.Items.Clear()
                mode_attente_reception = True
            End If
        End If


        If passe = True Then

            btnNouvelleCommande.Enabled = False
            btnReinitialiser.PerformClick()


            If utls.Titre = "p" Then
                gestion_btn_prof()

            End If
            txtQuantite.Text = ""
            lbtotal.Text = 0
            lbTps.Text = 0
            lbTvq.Text = 0
            lbSousTotal.Text = 0
            txtUniteMesure.Enabled = False
            'cboFormat.Enabled = False

            btnEffectuer.Enabled = False
            If utls.Titre = "p" Then
                activer_commande()
            End If
        End If


    End Sub

    'Désactiver une commande de la bd'
    Public Sub desactiver_table_commande()
        Dim str_requete_desactiver_commande As String = ""
        str_requete_desactiver_commande = "update tbl_commandes set actif = 0 where no_exercice= " & exercice & ""

        gestionBd.miseAjourDS(dataSet, dataAdapter, str_requete_desactiver_commande, "tbl_commandes")
    End Sub

    'Desactiver une réception de la bd.
    Public Sub desactiver_table_repcetion()
        Dim str_requete_desactiver_exercice As String = ""
        str_requete_desactiver_exercice = "update tbl_reception_exercices set actif = 0 where no_exercice= " & exercice & ""

        gestionBd.miseAjourDS(dataSet, dataAdapter, str_requete_desactiver_exercice, "tbl_reception_exercices")
    End Sub

    'Bouton qui permet de passer d'une commande a une réception de commande.
    Private Sub btn_switch_Click(sender As Object, e As EventArgs) Handles btn_switch.Click

        If btn_switch.Text = "Commande" Then

            If utls.Titre = "p" Then
                lsv_controle = lsvCommande
                Charger_DS()
                btn_switch.Text = "Réception de commande"
                lb_listview.Text = "Commande"
                btnEffectuer.Text = "Détails de la commande"
                btnNouvelleCommande.Text = "Nouvelle commande"

                lsvReception.Visible = False
                lsvCommande.Visible = True

            End If

        Else
            If utls.Titre = "p" Then
                trouver_ds_reception()
                charger_ds_reception(str_fournisseur)

                btn_switch.Text = "Commande"

                lb_listview.Text = "Réception de commande"
                btnEffectuer.Text = "Détails de la réception"
                btnNouvelleCommande.Text = "Nouvelle réception"

                lsvCommande.Visible = False
                lsvReception.Visible = True

                lsv_controle = lsvReception

            End If
        End If

        If utls.Titre = "p" Then

            gestion_btn_prof()

            txtQuantite.Text = ""
            lbtotal.Text = 0
            lbTps.Text = 0
            lbTvq.Text = 0
            calculer()


            If lsv_controle.Items.Count = 0 Then

                btnEffectuer.Enabled = False

            Else
                btnEffectuer.Enabled = True

            End If



        End If


        If utls.Titre = "e" Then
            usr_comparer_comm = New usr_comparer_commande(Me, utls, cours_exercice, exercice)
            Dim lb_nom_commande As New Label
            Dim lb_nom_titre As New Label
            lb_nom_commande = usr_comparer_comm.get_commande_haut
            lb_nom_titre = usr_comparer_comm.get_commande_titre
            lb_nom_commande.Text = "Réception de commande"
            lb_nom_titre.Text = "Comparaison de la réception et de la commande"
            usr_comparer_comm.set_commande_haut(lb_nom_commande)
            usr_comparer_comm.set_commande_titre(lb_nom_titre)
            Panel1.Controls.Add(usr_comparer_comm)
            usr_comparer_comm.Dock = DockStyle.Fill
            usr_comparer_comm.BringToFront()



        End If



    End Sub

    'Copier la réception de commande(Utile l'ors de l'assignation de commande à la réception.'
    Public Sub copy_reception()


        lsv_controle = lsvReception
        For i = 0 To lsv_controle.Items.Count - 1

            lsvReception.Items.Add(lsv_controle.Items(i).Text)
            lsvReception.Items(lsvReception.Items.Count - 1).SubItems.Add(lsv_controle.Items(i).SubItems(1).Text)
            lsvReception.Items(lsvReception.Items.Count - 1).SubItems.Add(lsv_controle.Items(i).SubItems(2).Text)
            lsvReception.Items(lsvReception.Items.Count - 1).SubItems.Add(lsv_controle.Items(i).SubItems(3).Text)
            lsvReception.Items(lsvReception.Items.Count - 1).SubItems.Add(lsv_controle.Items(i).SubItems(4).Text)
            lsvReception.Items(lsvReception.Items.Count - 1).SubItems.Add(FormatCurrency(lsv_controle.Items(i).SubItems(5).Text))
            lsvReception.Items(lsvReception.Items.Count - 1).SubItems.Add(FormatCurrency(lsv_controle.Items(i).SubItems(6).Text))
        Next


    End Sub


    'Procedure qui assigne une commande à la réception.

    Public Sub assigner_commande()

        Dim str_requete_insert As String = ""

        str_requete_insert = "insert into tbl_reception_exercices(no_exercice,date_reception,remarque,actif) values(" & exercice & ",sysdate(),null,1)"

        gestionBd.InsDelUpd(str_requete_insert)

        no_recepetion = trouver_no_recepetion()

    End Sub


    'Bouton Comparer la commande'.
    Public Sub btnComparer_click(sender As Object, e As EventArgs) Handles btnComparer.Click


        usr_comparer_comm = New usr_comparer_commande(Me, utls, cours_exercice, exercice)
        If utls.Titre = "p" Then
            Panel1.Controls.Add(usr_comparer_comm)
            usr_comparer_comm.Dock = DockStyle.Fill
            usr_comparer_comm.BringToFront()
        Else
            Panel1.Controls.Add(usr_comparer_comm)
            usr_comparer_comm.Dock = DockStyle.Fill
            usr_comparer_comm.BringToFront()
            usr_comparer_comm.btn_travaux.Enabled = False
            usr_comparer_comm.btn_travaux.Visible = False

        End If

    End Sub

    'Bouton assigner à la réception'

    Private Sub btnAssigner_Click(sender As Object, e As EventArgs) Handles btnAssigner.Click


        compter_recepetion_exercice()
        Dim passe As Boolean = False
        If nbr_recepetion_exercice = 1 Then

            If (MessageBox.Show("Une réception de commande existe déja." & vbCrLf & "Êtes-vous certain de vouloir la remplacer par cette commande? Cette opération est définitive.", "Confirmation de réception de commande", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                passe = True
                nouvelle_reception = False
                btn_nouvelle_commande = False

            End If
        End If
        If nbr_recepetion_exercice = 0 Then
            If (MessageBox.Show("Êtes-vous certain de vouloir assigner cette commande à la réception de commande? Cette opération est définitive.", "Confirmation de réception de commande", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                passe = True
                nouvelle_commande = False
                btn_nouvelle_reception = False
            End If

        End If


        If passe = True Then
            mode_attente_reception = True

            supprimer_reception()
            assigner_commande()


            assigner_detail_commande()
            remplir_reception_modifier()

            'copy_reception()

            btn_switch.Enabled = True

            btn_switch.Image = My.Resources.Resources.baseline_sync_white_36dp

            btnAssigner.Enabled = False

            gestion_btn_prof()
            MessageBox.Show("Votre commande à été assignée à la réception de commande.", "Commande", MessageBoxButtons.OK, MessageBoxIcon.Information)


        End If

    End Sub

    'Bouton qui supprime une réception'
    Public Sub supprimer_reception()

        Dim str_requete_delete_reception As String = ""
        str_requete_delete_reception = "delete from tbl_reception_exercices where no_exercice = " & exercice

        gestionBd.miseAjourDS(dataSet, dataAdapter, str_requete_delete_reception, "tbl_reception_exercices")


    End Sub

    'Entré les détails de la réception  dans la bd'.
    Public Sub assigner_detail_commande()

        Dim code_produit As String = ""
        Dim no_format As Integer = 0
        Dim no_categorie As Integer = 0
        Dim no_mesure As Integer = 0
        Dim numero_commande As String = 0
        Dim quantite As String = 0
        Dim str_requete_insert_reception As String = ""
        Dim prix_unitaire As Double = 0



        For i = 0 To lsvCommande.Items.Count - 1



            no_format = trouver_no_format(lsvCommande.Items(i).SubItems(3).Text)
            no_mesure = trouver_no_mesure(lsvCommande.Items(i).SubItems(4).Text)
            numero_commande = trouver_no_commande(lsvCommande.Items(i).SubItems(1).Text)
            code_produit = trouver_id_produit(lsvCommande.Items(i).SubItems(0).Text, no_format, no_mesure)
            quantite = lsvCommande.Items(i).SubItems(2).Text
            prix_unitaire = (replace_signe_dollars(lsvCommande.Items(i).SubItems(5).Text, "virgule"))

            str_requete_insert_reception = "insert into tbl_reception_details(no_reception,code_produit,no_commande,quantite,prix_unitaire) values(" & no_recepetion & ",'" + code_produit + "','" + numero_commande + "'," & quantite & ",'" & replace_signe_dollars(prix_unitaire, "point") & "')"

            gestionBd.InsDelUpd(str_requete_insert_reception)

        Next




    End Sub

    'Modifier la réception'.
    Public Sub modifier_reception_details()

        Dim code_produit As String = ""
        Dim no_format As Integer = 0
        Dim no_categorie As Integer = 0
        Dim no_mesure As Integer = 0
        Dim numero_commande As String = 0
        Dim quantite As String = 0
        Dim str_requete_insert_reception As String = ""



        For i = 0 To lsvReception.Items.Count - 1



            no_format = trouver_no_format(lsvReception.Items(i).SubItems(3).Text)
            no_mesure = trouver_no_mesure(lsvReception.Items(i).SubItems(4).Text)
            numero_commande = trouver_no_commande(lsvReception.Items(i).SubItems(1).Text)
            code_produit = trouver_id_produit(lsvReception.Items(i).SubItems(0).Text, no_format, no_mesure)
            quantite = lsvReception.Items(i).SubItems(2).Text

            prix_unitaire = replace_signe_dollars(lsv_controle.Items(i).SubItems(5).Text, "virgule")



            str_requete_insert_reception = "insert into tbl_reception_details(no_reception,code_produit,no_commande,quantite,prix_unitaire) values(" & no_recepetion & ",'" + code_produit + "','" + numero_commande + "'," & quantite & ",'" & replace_signe_dollars(prix_unitaire, "point") & "')"


            gestionBd.InsDelUpd(str_requete_insert_reception)

        Next




    End Sub
    'Function qui permet de trouver l'id d'un produit.'
    Public Function trouver_id_produit(nom_produit As String, no_format As Integer, no_mesure As Integer) As String



        str_requete = "select p.nom_produit,p.code_produit from tbl_produits p,tbl_formats f,tbl_unites_mesure um 
where p.no_format = f.no_format and p.no_mesure = um.no_mesure
and p.nom_produit  = '" & StrConv(ConvertirApostrophe(nom_produit.Trim), VbStrConv.ProperCase) & "'and f.no_format = '" & no_format & "'and um.no_mesure = '" & no_mesure & "'"
        table = "tbl_produits"
        gestionBd.miseAjourDS(dataSet, dataAdapter, str_requete, table)

        Return dataSet.Tables(0).Rows(0).Item(1)



    End Function

    'Function qui permet de trouver le numéro de format avec le nom de format.
    Public Function trouver_no_format(nom_format As String) As Integer
        str_requete = "select nom_format,no_format from tbl_formats where nom_format = '" & StrConv(ConvertirApostrophe(nom_format.Trim), VbStrConv.ProperCase) & "'"

        table = "tbl_formats"
        gestionBd.miseAjourDS(dataSet, dataAdapter, str_requete, table)


        Return dataSet.Tables(0).Rows(0).Item(1)

    End Function

    'Function qui permet de trouver le numéro de mesure avec le nom de mesure.

    Public Function trouver_no_mesure(nom_mesure As String) As Integer

        str_requete = "select no_mesure,unite_mesure from tbl_unites_mesure where unite_mesure = '" & StrConv(ConvertirApostrophe(nom_mesure.Trim), VbStrConv.ProperCase) & "'"

        table = "tbl_unites_mesure"
        gestionBd.miseAjourDS(dataSet, dataAdapter, str_requete, table)

        Return dataSet.Tables(0).Rows(0).Item(0)
    End Function


    'Permet d'éviter que les colonnes de la listview soit modifiable.
    Private Sub ListView1_ColumnWidthChanging(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnWidthChangingEventArgs) Handles lsvCommande.ColumnWidthChanging, lsvReception.ColumnWidthChanging

        Dim index_colonne As Integer = 0
        index_colonne = e.ColumnIndex
        If e.NewWidth <> lsv_controle.Columns(index_colonne).Width Then
            e.Cancel = True
            e.NewWidth = lsv_controle.Columns(index_colonne).Width
        End If
    End Sub

    'Affiche les infos du produit.'
    Private Sub dgv_produits_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCommande.CellDoubleClick
        If e.RowIndex > -1 Then
            code_produit = dgvCommande.Rows(e.RowIndex).Cells(0).Value
            Dim frm_details As New frm_details_produit(dgvCommande.Rows(e.RowIndex).Cells(0).Value)
            frm_details.ShowDialog()
        End If
    End Sub

    Private Sub dgv_produits_CellMouseLeave(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCommande.CellMouseLeave
        If e.RowIndex > -1 Then
            dgvCommande.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
            dgvCommande.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
        End If
    End Sub

    Private Sub dgv_produits_CellMouseEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCommande.CellMouseEnter
        If e.RowIndex > -1 Then

            dgvCommande.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(236, 240, 241)
            dgvCommande.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black

        End If
    End Sub

    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btnAjouter.MouseEnter, btnAssigner.MouseEnter, btnComparer.MouseEnter, btnEffectuer.MouseEnter, btnModifier.MouseEnter, btnNouvelleCommande.MouseEnter, btnRechercher.MouseEnter, btnReinitialiser.MouseEnter, btnSupprimer.MouseEnter, btn_switch.MouseEnter
        sender.BackColor = Color.White
        sender.ForeColor = Color.Black

        If sender.Text = btn_switch.Text Then
            btn_switch.Image = My.Resources.baseline_sync_black_36dp
        End If
    End Sub
    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btnAjouter.MouseLeave, btnAssigner.MouseLeave, btnComparer.MouseLeave, btnEffectuer.MouseLeave, btnModifier.MouseLeave, btnNouvelleCommande.MouseLeave, btnRechercher.MouseLeave, btnReinitialiser.MouseLeave, btnSupprimer.MouseLeave, btn_switch.MouseLeave
        If sender.Text = btnReinitialiser.Text Then
            sender.BackColor = Color.FromArgb(72, 84, 96)
            sender.ForeColor = SystemColors.Control
        ElseIf sender.Text = btnNouvelleCommande.Text Then
            sender.BackColor = Color.DimGray
            sender.ForeColor = SystemColors.Control
        Else
            sender.BackColor = Color.FromArgb(52, 73, 94)
            sender.ForeColor = SystemColors.Control
        End If

        If sender.Text = btn_switch.Text Then
            btn_switch.Image = My.Resources.baseline_sync_white_36dp
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub dgvCommande_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCommande.CellContentClick

    End Sub

    Private Sub txtPrixUnitaire_TextChanged(sender As Object, e As EventArgs) Handles txtPrixUnitaire.TextChanged

    End Sub

End Class