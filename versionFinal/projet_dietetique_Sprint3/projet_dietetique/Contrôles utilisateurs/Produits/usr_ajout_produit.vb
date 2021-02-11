Imports MySql.Data.MySqlClient
''' <summary>
''' contrôle utilisateur permettant d'ajouter un produit.
''' fait par Sébastien Poulain
''' </summary>
''' <tag>2019</tag>
Public Class usr_ajout_produit
    Dim strRequete As String
    Dim table As String
    Dim gestionBd As New Connexion
    Dim dataAdapter As New MySqlDataAdapter
    Dim dsAllergene As DataSet
    Dim noAllergene As Integer
    Dim nomAllergene As String
    Dim liste As New List(Of usr_ajout_produit)
    Dim bd As New Connexion
    Dim ds, _ds, ds_taxes As New DataSet
    Dim da As New MySqlDataAdapter
    Dim animation As New cls_animation_operation
    Dim requete As String
    Dim usr_menu As usr_gestion_Menuproduits
    Dim code As String
    Dim nom_produit As String = ""
    Dim marque_produit As String = ""
    Dim categorie As String = ""
    Dim allergenes As String = ""
    Dim description As String = ""
    Dim perissable As String = ""
    Dim tri As String = ""
    Dim bio As String = ""
    Dim aj_code_produit, aj_nom_produit, aj_marque, aj_categorie, aj_code_barre, aj_code_plu, aj_format, aj_unite_mesure, aj_description, aj_remarque, aj_allergenes As String
    Dim aj_quantite As Double
    Dim aj_perissable, aj_bio As Boolean
    Dim AllergenesProduit As String
    Dim AllergenesCochees As New ListBox


    Private Sub usr_ajout_produit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Generer_Code()
        txt_nom_produit.TabIndex = 0
        recupererAllergene()
        creerLstAllergene()
        Remplir_Unites(_ds, da, bd, cms_unites_mesure)
        Remplir_Combobox(bd, "nom_categorie", "tbl_categories", cbo_categories)
        Remplir_Combobox(bd, "nom_format", "tbl_formats", cbo_format)
    End Sub
    ''' <summary>
    ''' Méthode qui gère l'événement du clic sur le bouton btn_annuler, vide la liste d'allergènes et ferme le formulaire d'ajout d'allergènes.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        Dim result = MessageBox.Show("                       Êtes-vous certain de vouloir annuler ?                                              (le produit ne sera pas créé)", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            clearList()
            Me.ParentForm.Close() 'ferme la fenetre parent
        End If
    End Sub
    ''' <summary>
    ''' Méthode qui récupère les produits et les taxes, ils vont dans des datasets.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
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

    ''' <summary>
    ''' Méthode qui remplit les contrôles à partir du dataset des produits et des taxes.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Sub Remplir_Controles()
        Dim tab_controles() As Control = {txt_nom_produit, cbo_format, cbo_categories, lbl_mesure, txt_description,
                                          txt_remarque, nm_quantite, txt_marque, cbo_perissable, cbo_bio}
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
    ''' <summary>
    ''' Fonction qui recherche les produits qui ont des taxes.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
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
    ''' <summary>
    ''' Fonction qui vérifie que le nom de produit respecte les critères définis dans le regex.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
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

    ''' <summary>
    ''' Fonction qui vérifie que la marque de produit respecte les critères définis dans le regex.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
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
    ''' <summary>
    ''' Fonction qui vérifie qu'une catégorie est sélectionnée lors de l'ajout d'un produit.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
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
    ''' <summary>
    ''' Fonction qui vérifie qu'une valeur est sélectionnée dans le champs perissable lors de l'ajout d'un produit.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
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

    ''' <summary>
    ''' Fonction qui vérifie qu'un format est sélectionnée lors de l'ajout d'un produit.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
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
    ''' <summary>
    ''' Fonction qui vérifie qu'une unité de mesure est sélectionner lors de l'ajout d'un produit.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
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
    ''' <summary>
    ''' Fonction qui vérifie que la quantité respecte les critères définis dans le regex.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
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

    ''' <summary>
    ''' Fonction qui vérifie qu'un élément du champs Bio est sélectionner lors de l'ajout d'un produit.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
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
    ''' <summary>
    ''' Fonction qui vérifie si tous les champs ont passés les vérifications avant d'ajouter le produit.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Function Verifier_Ensemble() As Boolean
        If Existe_Deja(UppercaseFirstLetter(txt_nom_produit.Text), UppercaseFirstLetter(txt_marque.Text), nm_quantite.Value) Then
            MessageBox.Show("Le produit que vous désirez ajouter existe déjà.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            clearList()
            recupererAllergene()
            creerLstAllergene()
            Return False
        End If
        If Verifier_Nom_Produit(txt_nom_produit.Text) And Verifier_Categorie() And Verifier_Marque(txt_marque.Text) And Verifier_Perissable(cbo_perissable.Text) And
           Verifier_Format(cbo_format.Text) And Verifier_Mesure() And Verifier_Quantite(nm_quantite.Value) And Verifier_Bio(cbo_bio.Text) Then

            aj_description = ConvertirApostrophe(corriger_null(txt_description.Text))
            aj_remarque = ConvertirApostrophe(corriger_null(txt_remarque.Text))
            MessageBox.Show(txt_nom_produit.Text & " a été ajouté dans la liste des produits.", "Produit ajouté", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Ajouter_Produit()
                Return True
            Else
            MessageBox.Show("impossible d'ajouter le produit, veuillez-vous référer aux messages d'erreurs.", "Erreur ajout produit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            clearList()
            recupererAllergene()
            creerLstAllergene()
            Return False
        End If
    End Function
    ''' <summary>
    ''' Fonction qui vérifie si le produit existe déjà dans la base de données.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Function Existe_Deja(nom_produit As String, marque As String, quantite As Double) As Boolean
        Dim ds_produits As New DataSet
        requete = "SELECT count(*) FROM tbl_produits WHERE nom_produit = '" & ConvertirApostrophe(UppercaseFirstLetter(nom_produit)) & "' AND marque = '" & ConvertirApostrophe(UppercaseFirstLetter(marque)) & "' AND nbr_unite_format = " & Replace(quantite, ",", ".")
        bd.miseAjourDS(ds_produits, da, requete, "tbl_produits")

        If ds_produits.Tables(0).Rows(0).Item(0) > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    ''' <summary>
    ''' Méthode permettant de changer de ligne,car textbox multilignes.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub txt_espace_keyword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_description.KeyPress, txt_remarque.KeyPress

        If e.KeyChar() = Chr(13) Then
            e.Handled = True
        End If
    End Sub
    ''' <summary>
    ''' Constructeur par défaut.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

    End Sub
    ''' <summary>
    '''  Constructeur paramétré.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Public Sub New(_no_allergene As Integer, _nom_allergene As String)


        ' Cet appel est requis par le concepteur.
        InitializeComponent()


        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        noAllergene = _no_allergene
        nomAllergene = _nom_allergene
    End Sub

    ''' <summary>
    ''' Méthode qui vide les textboxes.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Sub Vider_Textboxes()
        Dim tab_controles() As Control = {txt_nom_produit, txt_marque, nm_quantite,
                                          txt_description, txt_remarque}

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

    ''' <summary>
    ''' Méthode qui remplit les unites à l'aide du dataset de produits.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
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
    ''' <summary>
    ''' Méthode qui affiche le nom de la mesure choisit en fonction du choix effectué dans le toolstripitem.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Public Sub DropDownItemClicked(sender As ToolStripItem, e As EventArgs)
        lbl_mesure.Text = sender.Text
    End Sub
    ''' <summary>
    ''' Méthode qui affiche les différents mesures.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub btnMesure_Click(sender As Object, e As EventArgs) Handles btn_mesure.Click
        cms_unites_mesure.Show(btn_mesure, 0, btn_mesure.Height)
    End Sub

    ''' <summary>
    ''' Méthode qui  cache les unités de mesure en utilisant la molette de la souris.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub usr_ajouter_produit_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
        cms_unites_mesure.Hide()
    End Sub
    ' On récupère le format et le place dans le dataset.
    ''' <summary>
    ''' Fonction qui  récupère le format et le place dans le dataset.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Function Trouver_Format() As String
        bd.miseAjourDS(ds, da, "SELECT no_format FROM tbl_formats WHERE nom_format = '" & ConvertirApostrophe(aj_format.Trim) & "'", "tbl_formats")
        Return ds.Tables(0).Rows(0).Item(0)
    End Function

    ''' <summary>
    ''' Fonction qui  récupère la catégorie et la place dans le dataset.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Function Trouver_Categorie() As String
        bd.miseAjourDS(ds, da, "SELECT no_categorie FROM tbl_categories WHERE nom_categorie = '" & ConvertirApostrophe(aj_categorie.Trim) & "'", "tbl_categories")
        Return ds.Tables(0).Rows(0).Item(0)
    End Function

    ''' <summary>
    ''' Fonction qui  récupère la mesure et la place dans le dataset.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Function Trouver_Mesure() As String
        bd.miseAjourDS(ds, da, "SELECT no_mesure FROM tbl_unites_mesure WHERE unite_mesure = '" & ConvertirApostrophe(aj_unite_mesure.Trim) & "'", "tbl_unites_mesure")
        Return ds.Tables(0).Rows(0).Item(0)
    End Function



    ''' <summary>
    ''' Méthode qui  permet d'aller les allergènes de la base de données pour les mettre dans un dataset.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub recupererAllergene()
        strRequete = "select *  from tbl_allergenes"

        table = "tbl_allergenes"

        gestionBd.miseAjourDS(dsAllergene, dataAdapter, strRequete, table)


    End Sub
    ''' <summary>
    ''' Méthode qui  rempli la listbox des allergènes enregistrés dnas la BD
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub creerLstAllergene()


        Cursor = Cursors.AppStarting
        With dsAllergene.Tables(0)
            Dim no As Integer = .Rows.Count
            For i As Integer = 0 To .Rows.Count - 1
                Dim usr_test As New usr_ajout_produit(.Rows(i).Item(0), .Rows(i).Item(1))
                liste.Add(usr_test)
                listeAllergene.Items.Add(.Rows(i).Item(1))
            Next
            Cursor = Cursors.Default
        End With
    End Sub
    ''' <summary>
    ''' Méthode qui  efface les éléments de la checkedboxlist des allergènes.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Public Sub clearList()
        listeAllergene.Items.Clear()
    End Sub

    ''' <summary>
    ''' Méthode qui  change la couleur du texte et du fond du bouton quand la souris entre dans bouton.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btn_valider.MouseEnter, btn_annuler.MouseEnter
        sender.BackColor = Color.White
        sender.ForeColor = Color.Black
    End Sub
    ''' <summary>
    ''' Méthode qui change la couleur du texte et du fond du bouton quand la souris quitte le bouton.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btn_valider.MouseLeave, btn_annuler.MouseLeave
        sender.BackColor = Color.FromArgb(52, 73, 94)
        sender.ForeColor = SystemColors.Control
    End Sub
    ''' <summary>
    ''' Méthode qui vérifie les éléments avant d'ajouter le produit, si les vérifications ont passées alors on vide la liste d'allergènes et ferme le formulaire.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub btn_valider_Click(sender As Object, e As EventArgs) Handles btn_valider.Click
        If Verifier_Ensemble() Then
            clearList()
            Me.ParentForm.Close()
        End If
    End Sub

    ''' <summary>
    ''' Méthode qui ajoute le produit à la base de données.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Sub Ajouter_Produit()

        aj_code_barre = ""
        aj_code_plu = ""
        aj_allergenes = ""
        Dim requete As String = "INSERT INTO tbl_produits VALUES ('" & UppercaseFirstLetter(ConvertirApostrophe(txt_nom_produit.Text.Trim)) & "', '" & Label1.Text.Trim & "', '" & aj_code_barre.Trim & "', '" & aj_code_plu.Trim & "', " &
                 Trouver_Format() & ", " & Trouver_Categorie() & ", " & Trouver_Mesure() & ", '" & UppercaseFirstLetter(aj_description.Trim) & "', '" & UppercaseFirstLetter(aj_remarque.Trim) & "', " & Replace(aj_quantite, ",", ".") &
                 ", '" & UppercaseFirstLetter(ConvertirApostrophe(aj_marque.Trim)) & "', " & aj_perissable & ", true, '" & Ajouter_Allergene() & "', " & aj_bio & ")"
        bd.InsDelUpd(requete)
        Ajouter_Taxes()
        Vider_Textboxes()

    End Sub
    ''' <summary>
    ''' Méthode qui ajoute les taxes avec le produit dans la bd si les champs de taxes sont cochés.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
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


    ''' <summary>
    ''' Fonction permettant d'ajouter les allergènes cochés dans la base de données.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <returns></returns>
    ''' retourne une chaine de caractères avec tous les allergènes cochés.
    Function Ajouter_Allergene() As String

        If listeAllergene.CheckedItems.Count > 0 Then
            For i As Integer = 0 To listeAllergene.CheckedItems.Count - 1
                AllergenesCochees.Items.Add(listeAllergene.CheckedItems(i))
            Next
            For i As Integer = 0 To AllergenesCochees.Items.Count - 1
                If i <> AllergenesCochees.Items.Count - 1 Then
                    AllergenesProduit += AllergenesCochees.Items(i) + ","
                Else
                    AllergenesProduit += AllergenesCochees.Items(i)
                End If
            Next
        Else
            AllergenesProduit = ""
        End If
        Return AllergenesProduit
    End Function
End Class

