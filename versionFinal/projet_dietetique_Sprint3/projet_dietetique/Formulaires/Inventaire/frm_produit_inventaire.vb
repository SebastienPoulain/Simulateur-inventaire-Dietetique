Imports System.Data.Sql
Imports MySql.Data.MySqlClient

Public Class frm_produit_inventaire
    Dim bd As New Connexion
    Dim ds As New DataSet
    Dim dsEmpl As New DataSet
    Dim da As MySqlDataAdapter

    Dim utls_conn As Utilisateur
    Dim exercice As Integer
    Dim inventaire As String
    Dim strRequete As String
    Dim usr_p As usr_inventaire_P

    Dim animation As New cls_animation_operation

    Public Sub New(ex As Integer, utls As Utilisateur, type As String, usr As usr_inventaire_P)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        utls_conn = utls
        exercice = ex
        inventaire = type
        usr_p = usr
    End Sub

    Private Sub usr_produits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_produits.RowTemplate.Height = 30
        maj()
        Remplir_Combobox(bd, "nom_categorie", "tbl_categories", cbo_rech_categorie)
    End Sub

    'Charge les emplacements disponibles pour le produit sélectionné.
    Private Sub dgv_produits_Click(sender As Object, e As EventArgs) Handles dgv_produits.CellClick
        RemplirCboEmplacement()
    End Sub

    Private Sub RemplirCboEmplacement()
        Dim requete As String = "select distinct nom_emplacement
                                FROM tbl_produits p, tbl_formats f, tbl_categories c, tbl_emplacement_inventaire ei
                                WHERE p.no_format = f.no_format and p.no_categorie = c.no_categorie 
                                and no_emplacement not in "

        If inventaire = "prof" Then
            requete &= " (select no_emplacement from tbl_inventaire_detail id2, tbl_inventaire_prof ip2 
                                 where id2.no_inventaire = ip2.no_inventaire and id2.code_produit = '" & dgv_produits.CurrentRow.Cells(0).Value & "' and ip2.no_utilisateur= '" & utls_conn.No_id & "')"
        Else
            requete &= " (select no_emplacement from tbl_inventaire_detail id2, tbl_exercices e2 
                                 where id2.no_inventaire = e2.no_inventaire and id2.code_produit = '" & dgv_produits.CurrentRow.Cells(0).Value & "' and e2.no_exercice = " & exercice & ")"
        End If

        bd.miseAjourDS(dsEmpl, da, requete, "tbl_produits")
        
        cbo_empl.Items.Clear()

        For i As Integer = 0 To dsEmpl.Tables(0).Rows.Count - 1
            cbo_empl.Items.Add(dsEmpl.Tables(0).Rows(i).Item(0))
        Next
    End Sub

    Private Sub Maj()
        If inventaire = "prof" Then
            Charger_DS()
            Reinitialiser_Criteres()
        Else
            Charger_DS_ex()
            Reinitialiser_Criteres()
        End If

        If dgv_produits.Rows.Count = 0 Then
            btn_ajouter.Enabled = False
        Else
            RemplirCboEmplacement()
        End If
    End Sub

    Private Sub Rechercher()
        If inventaire = "prof" Then
            Trouver_Resultats()
        Else
            Trouver_Resultats_ex()
        End If
    End Sub

    Private Sub dgv_produits_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_produits.CellClick
        effacerTxt()
    End Sub

    'Bouton ajouter.'
    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        If Verification() Then

            Try
                strRequete = "INSERT INTO `tbl_inventaire_detail`(`no_inventaire`, `code_produit`, `no_emplacement`, `quantite`) VALUES ("

                If inventaire = "prof" Then
                    strRequete &= "(select no_inventaire from tbl_inventaire_prof where no_utilisateur = '" & utls_conn.No_id & "')"
                Else
                    strRequete &= "(select no_inventaire from tbl_exercices where no_exercice = " & exercice & ")"
                End If

                strRequete &= ", '" & dgv_produits.CurrentRow.Cells(0).Value & "',
                          (select no_emplacement from tbl_emplacement_inventaire where nom_emplacement = '" & mod_regex.ConvertirApostrophe(cbo_empl.Text) & "'),
                          " & nm_quant.Value.ToString.Replace(",", ".") & ");"

                bd.InsDelUpd(strRequete)
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Ajout réussie.", cls_animation_operation.Reussie)
            Catch ex As Exception
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de l'ajout.", cls_animation_operation.Echec)
            End Try

        effacerTxt()
        maj()
        usr_p.Maj()
        End If
    End Sub

#Region "prof"
    Sub Charger_DS()
        bd.miseAjourDS(ds, da, "Select distinct code_produit As `No. Produit`, nom_produit As `Nom`, marque As `Marque`, nom_categorie As `Categorie`, nom_format As `Format`, 
                                if(perissable, 'Oui', 'Non') AS `Perissable`, if(bio, 'Oui', 'Non') as `Bio`, if(description = '', 'Non', 'Oui') AS `Description`, if(allergene = '', 'Non', 'Oui') AS `Allergenes`
                                FROM tbl_produits p, tbl_formats f, tbl_categories c, tbl_emplacement_inventaire ei
                                WHERE p.no_format = f.no_format and p.no_categorie = c.no_categorie 
                                and no_emplacement not in   
                                (select no_emplacement from tbl_inventaire_detail id2, tbl_inventaire_prof ip2 
                                 where id2.no_inventaire = ip2.no_inventaire and id2.code_produit = p.code_produit and ip2.no_utilisateur= '" & utls_conn.No_id & "') 


                                ORDER BY code_produit", "tbl_produits")
        RemplirGrid()
    End Sub


    'S'active pour vérifier le nombre de résultats pour ensuite l'afficher dans le bouton 'Rechercher'
    'Pour afficher les résultats dans la datagridview, il faudra aller cliquer sur le bouton 'Rechercher'
    ' NOTE: Les fonctions utilisées dans Trouver_Resultats() viennent directement du MODULE mod_recherches.
    Sub Trouver_Resultats()
        Dim requete As String = "SELECT distinct code_produit AS `No. Produit`, nom_produit AS `Nom`, marque AS `Marque`, 
                                nom_categorie AS `Categorie`, nom_format AS `Format`, if(perissable, 'Oui', 'Non') AS `Perissable`,
                                if(bio, 'Oui', 'Non') as `Bio`, if(description = '', 'Non', 'Oui') AS `Description`, if(allergene = '', 'Non', 'Oui') AS `Allergenes`

                                FROM tbl_produits p, tbl_formats f, tbl_categories c, tbl_emplacement_inventaire ei
                                WHERE p.no_format = f.no_format and p.no_categorie = c.no_categorie 
                                and no_emplacement not in   
                                (select no_emplacement from tbl_inventaire_detail id2, tbl_inventaire_prof ip2 
                                 where id2.no_inventaire = ip2.no_inventaire and id2.code_produit = p.code_produit and ip2.no_utilisateur= '" & utls_conn.No_id & "') 
                            " & Rechercher_Selon_Contenu("nom_produit", cbo_nom_contient, ConvertirApostrophe(txt_rech_nom.Text.Trim)) &
                            Rechercher_Selon_Contenu("marque", cbo_marque_contient, ConvertirApostrophe(txt_rech_marque.Text.Trim)) &
                            Rechercher_Categories(ConvertirApostrophe(cbo_rech_categorie.Text.Trim)) &
                            Rechercher_Perissable(rdb_perissable_oui, rdb_perissable_non) &
                            Rechercher_Allergenes(ConvertirApostrophe(cbo_allergenes.Text), ConvertirApostrophe(txt_allergenes_keyword.Text.Trim)) &
                            Rechercher_Description_inventaire(ConvertirApostrophe(cbo_description.Text), ConvertirApostrophe(txt_description_keyword.Text.Trim)) &
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
#Region "Exercice"
    Sub Charger_DS_ex()
        bd.miseAjourDS(ds, da, "SELECT distinct code_produit AS `No. Produit`, nom_produit AS `Nom`, marque AS `Marque`, nom_categorie AS `Categorie`, nom_format AS `Format`, 
                                if(perissable, 'Oui', 'Non') AS `Perissable`, if(bio, 'Oui', 'Non') as `Bio`, if(description = '', 'Non', 'Oui') AS `Description`, if(allergene = '', 'Non', 'Oui') AS `Allergenes`
                                FROM tbl_produits p, tbl_formats f, tbl_categories c, tbl_emplacement_inventaire ei
                                WHERE p.no_format = f.no_format and p.no_categorie = c.no_categorie 
                                and no_emplacement not in   
                                (select no_emplacement from tbl_inventaire_detail id2, tbl_exercices e2 
                                 where id2.no_inventaire = e2.no_inventaire and id2.code_produit = p.code_produit and e2.no_exercice = " & exercice & ") 


                                ORDER BY code_produit", "tbl_produits")
        RemplirGrid()
    End Sub


    'S'active pour vérifier le nombre de résultats pour ensuite l'afficher dans le bouton 'Rechercher'
    'Pour afficher les résultats dans la datagridview, il faudra aller cliquer sur le bouton 'Rechercher'
    ' NOTE: Les fonctions utilisées dans Trouver_Resultats() viennent directement du MODULE mod_recherches.
    Sub Trouver_Resultats_ex()
        Dim requete As String = "SELECT distinct code_produit AS `No. Produit`, nom_produit AS `Nom`, marque AS `Marque`, 
                                nom_categorie AS `Categorie`, nom_format AS `Format`, if(perissable, 'Oui', 'Non') AS `Perissable`,
                                if(bio, 'Oui', 'Non') as `Bio`, if(description = '', 'Non', 'Oui') AS `Description`, if(allergene = '', 'Non', 'Oui') AS `Allergenes`
                                FROM tbl_produits p, tbl_formats f, tbl_categories c, tbl_emplacement_inventaire ei
                                WHERE p.no_format = f.no_format and p.no_categorie = c.no_categorie 
                                and no_emplacement not in   
                                (select no_emplacement from tbl_inventaire_detail id2, tbl_exercices e2 
                                 where id2.no_inventaire = e2.no_inventaire and id2.code_produit = p.code_produit and e2.no_exercice = " & exercice & ") 
                            " & Rechercher_Selon_Contenu("nom_produit", cbo_nom_contient, ConvertirApostrophe(txt_rech_nom.Text.Trim)) &
                            Rechercher_Selon_Contenu("marque", cbo_marque_contient, ConvertirApostrophe(txt_rech_marque.Text.Trim)) &
                            Rechercher_Categories(ConvertirApostrophe(cbo_rech_categorie.Text.Trim)) &
                            Rechercher_Perissable(rdb_perissable_oui, rdb_perissable_non) &
                            Rechercher_Allergenes(ConvertirApostrophe(cbo_allergenes.Text), ConvertirApostrophe(txt_allergenes_keyword.Text.Trim)) &
                            Rechercher_Description_inventaire(ConvertirApostrophe(cbo_description.Text), ConvertirApostrophe(txt_description_keyword.Text.Trim)) &
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
#Region "Rechercher"
    Private Sub RemplirGrid()
        dgv_produits.Rows.Clear()


        With ds.Tables(0)
            For i As Integer = 0 To .Rows.Count - 1
                dgv_produits.Rows.Add(.Rows(i).Item(0))
                For j As Integer = 1 To ds.Tables(0).Columns.Count - 1
                    dgv_produits.Rows(dgv_produits.Rows.Count - 1).Cells(j).Value = .Rows(i).Item(j)
                Next
            Next
        End With

        dgv_produits.RowTemplate.Height = 30
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
        cbo_allergenes.SelectedIndex = 4
        cbo_description.SelectedIndex = 3
        rdb_perissable_tous.Checked = True
        rdb_bio_tous.Checked = True
    End Sub

    Private Sub btnRechercher_Click(sender As Object, e As EventArgs) Handles btnRechercher.Click
        RemplirGrid()
    End Sub

    Private Sub btnReinitialiser_Click(sender As Object, e As EventArgs) Handles btnReinitialiser.Click
        maj()
        Reinitialiser_Criteres()
    End Sub
#End Region
    '
    '
    '
    '
    '
#Region "Activations multiples de Trouver_Resultats()"
    Private Sub pnl_recherches_MouseLeave(sender As Object, e As EventArgs) Handles Panel1.MouseEnter, txt_allergenes_keyword.LostFocus, txt_description_keyword.LostFocus,
                                                                                txt_rech_marque.LostFocus, txt_rech_nom.LostFocus
        rechercher()
    End Sub

    Private Sub cbo_allergenes_SelectedIndexChanged(sender As ComboBox, e As EventArgs) Handles cbo_allergenes.SelectedIndexChanged
        If sender.SelectedIndex = 2 Or sender.SelectedIndex = 3 Then
            txt_allergenes_keyword.Enabled = True
        Else
            txt_allergenes_keyword.Enabled = False
            rechercher()
        End If
    End Sub

    Private Sub cbo_description_SelectedIndexChanged(sender As ComboBox, e As EventArgs) Handles cbo_description.SelectedIndexChanged
        If sender.SelectedIndex = 2 Then
            txt_description_keyword.Enabled = True
        Else
            txt_description_keyword.Enabled = False
            rechercher()
        End If
    End Sub
#End Region
    '
    '
    '
    '
    '
#Region "Autres"
    'Vérifie que tous les champs sont remplis.'
    Function Verification() As Boolean
        Dim succes As Boolean = True

        If nm_quant.Value = 0 Then
            succes = False
            lbE_quant.Visible = True
        Else
            lbE_quant.Visible = False
        End If

        If cbo_empl.SelectedIndex = -1 Then
            succes = False
            lblE_emplac.Visible = True
        Else
            lblE_emplac.Visible = False
        End If

        Return succes
    End Function

    'Reset les champs.'
    Private Sub effacerTxt()
        nm_quant.Value = 0
        cbo_empl.SelectedIndex = -1
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
            If inventaire = "prof" Then
                Trouver_Resultats()
            Else
                Trouver_Resultats_ex()
            End If
        End If
    End Sub

    'Ouvre les informations supplémentaires.'
    Private Sub dgv_produits_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_produits.CellDoubleClick
        If e.RowIndex > -1 Then
            Dim frm_details As New frm_details_produit(dgv_produits.Rows(e.RowIndex).Cells(0).Value)
            frm_details.ShowDialog()
        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click, btn_annuler.Click
        Me.Close()
    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles pnl_navigation.MouseDown, lbl_titre.MouseDown
        mod_mvtFenetre.mouseDown(e)
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles pnl_navigation.MouseMove, lbl_titre.MouseMove
        mod_mvtFenetre.mouseMove(e, Me)
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles pnl_navigation.MouseUp, lbl_titre.MouseUp
        mod_mvtFenetre.mouseUp(e)
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

    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btn_ajouter.MouseEnter, btn_annuler.MouseEnter, btnRechercher.MouseEnter, btnReinitialiser.MouseEnter
        sender.BackColor = Color.White
        sender.ForeColor = Color.Black
    End Sub

    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btn_ajouter.MouseLeave, btn_annuler.MouseLeave, btnRechercher.MouseLeave, btnReinitialiser.MouseLeave

        If sender.Text = btn_annuler.Text Or sender.Text = btnReinitialiser.Text Then
            sender.BackColor = Color.FromArgb(72, 84, 96)
            sender.ForeColor = SystemColors.Control
        Else
            sender.BackColor = Color.FromArgb(52, 73, 94)
            sender.ForeColor = SystemColors.Control
        End If
    End Sub
#End Region
End Class