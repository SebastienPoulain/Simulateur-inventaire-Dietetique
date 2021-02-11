Imports System.Data.Sql
Imports System.Globalization
Imports MySql.Data.MySqlClient
Public Class usr_inventaire_e
    Dim bd As New Connexion
    Dim ds As New DataSet
    Dim da As MySqlDataAdapter
    ' code_produit va être utilisé lorsqu'on demande plus de détails sur un produit
    ' (utilisé dans le formulaire frm_vue_produit)
    Public Shared code_produit As String

    Dim utls_conn As Utilisateur
    Dim leCours As String
    Dim leExerc As Integer
    Dim inventaire = "exercice"

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
        Charger_DS_Exercice()
        Reinitialiser_Criteres()
    End Sub

    'Lance la recherche.'
    Private Sub Rechercher()
        Trouver_Resultats_Exercice()
    End Sub
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
        Trouver_Resultats_Exercice()

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

            Trouver_Resultats_Exercice()
            RemplirGrid()
        End If
    End Sub

    'Affiche les infos du produit.'
    Private Sub dgv_produits_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_produits.CellClick
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

    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btnRechercher.MouseEnter, btnReinitialiser.MouseEnter
        sender.BackColor = Color.White
        sender.ForeColor = Color.Black
    End Sub
    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btnRechercher.MouseLeave, btnReinitialiser.MouseLeave
        If sender.Text = btnReinitialiser.Text Then
            sender.BackColor = Color.FromArgb(72, 84, 96)
            sender.ForeColor = SystemColors.Control
        Else
            sender.BackColor = Color.FromArgb(52, 73, 94)
            sender.ForeColor = SystemColors.Control
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

#End Region
End Class
