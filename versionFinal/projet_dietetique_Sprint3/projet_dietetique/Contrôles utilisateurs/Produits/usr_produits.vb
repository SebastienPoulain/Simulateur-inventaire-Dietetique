Imports System.Data.Sql
Imports MySql.Data.MySqlClient

''' <description>
''' Keven Abel.
''' 
''' Le contrôle utilisateur 'usr_produits'.
''' C'est sur cette interface que l'on peut naviguer à travers la table des produits selon leur activité (un produit inactif n'apparaîtra pas).
''' On peut rechercher un produit selon certains critères afin de faciliter une navigation plus précise.
''' 
''' </description>

Public Class usr_produits
    Dim bd As New Connexion
    Dim ds As New DataSet
    Dim da As MySqlDataAdapter
    Dim formAjout As New frm_ajout_produit
    Dim usrAjout As New usr_ajout_produit

    Public Sub usr_produits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Charger_DS()
        Remplir_Combobox(bd, "nom_categorie", "tbl_categories", cbo_rech_categorie)
        Reinitialiser_Criteres()
        formAjout.StartPosition = FormStartPosition.CenterScreen
        Charger_DS()
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

    Private Sub dgv_produits_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_produits.CellClick
        If e.RowIndex > -1 Then
            Dim frm_details As New frm_details_produit(dgv_produits.Rows(e.RowIndex).Cells(0).Value)
            frm_details.ShowDialog()
        End If
    End Sub

    Public Sub Charger_DS()
        bd.miseAjourDS(ds, da, "SELECT code_produit AS `No. Produit`, nom_produit AS `Nom`, marque AS `Marque`, nom_categorie AS `Categorie`, nom_format AS `Format`, 
                                if(perissable, 'Oui', 'Non') AS `Perissable`, if(bio, 'Oui', 'Non') as `Bio`, if(allergene = '', 'Non', 'Oui') AS `Allergenes`
                                FROM tbl_produits p
                                INNER JOIN tbl_formats f ON p.no_format = f.no_format
                                INNER JOIN tbl_categories c ON p.no_categorie = c.no_categorie
                                WHERE p.actif = true
                                ORDER BY code_produit", "tbl_produits")
        RemplirGrid()
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

    'S'active pour vérifier le nombre de résultats pour ensuite l'afficher dans le bouton 'Rechercher'
    'Pour afficher les résultats dans la datagridview, il faudra aller cliquer sur le bouton 'Rechercher'
    ' NOTE: Les fonctions utilisées dans Trouver_Resultats() viennent directement du MODULE mod_recherches.
    Sub Trouver_Resultats()
        Dim requete As String = "SELECT code_produit AS `No. Produit`, nom_produit AS `Nom`, marque AS `Marque`, 
                                nom_categorie AS `Categorie`, nom_format AS `Format`, if(perissable, 'Oui', 'Non') AS `Perissable`,
                                if(bio, 'Oui', 'Non') as `Bio`, if(allergene = '', 'Non', 'Oui') AS `Allergenes`
                                FROM tbl_produits p
                                INNER JOIN tbl_formats f ON p.no_format = f.no_format
                                INNER JOIN tbl_categories c ON p.no_categorie = c.no_categorie
                                WHERE p.actif = true" &
                                Rechercher_Selon_Contenu("nom_produit", cbo_nom_contient, ConvertirApostrophe(txt_rech_nom.Text.Trim)) &
                                Rechercher_Selon_Contenu("marque", cbo_marque_contient, ConvertirApostrophe(txt_rech_marque.Text.Trim)) &
                                Rechercher_Categories(ConvertirApostrophe(cbo_rech_categorie.Text)) &
                                Rechercher_Perissable(rdb_perissable_oui, rdb_perissable_non) &
                                Rechercher_Allergenes(cbo_allergenes.Text, ConvertirApostrophe(txt_allergenes_keyword.Text.Trim)) &
                                Rechercher_Description(cbo_description.Text, ConvertirApostrophe(txt_description_keyword.Text.Trim)) &
                                Rechercher_Bio(rdb_bio_oui, rdb_bio_non) &
                                Verifier_Tri(cbo_trier_par.Text, cbo_ordre.Text)

        bd.miseAjourDS(ds, da, requete, "tbl_produits")

        btnRechercher.Text = "Rechercher (" & ds.Tables(0).Rows.Count & " résultat(s))"
    End Sub

    Private Sub btnRechercher_Click(sender As Object, e As EventArgs) Handles btnRechercher.Click
        If txt_description_keyword.TextLength <> 0 Then
            Enlever_Point_Virgule(txt_description_keyword.Text, txt_description_keyword.TextLength - 1)
        End If

        If txt_allergenes_keyword.TextLength <> 0 Then
            Enlever_Point_Virgule(txt_allergenes_keyword.Text, txt_allergenes_keyword.TextLength - 1)
        End If

        RemplirGrid()
    End Sub

    Private Sub btnReinitialiser_Click(sender As Object, e As EventArgs) Handles btnReinitialiser.Click
        Charger_DS()
        Reinitialiser_Criteres()
    End Sub

    Public Sub RemplirGrid()
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



#Region "Activations multiples de Trouver_Resultats()"
    Private Sub pnl_recherches_MouseLeave(sender As Object, e As EventArgs) Handles Panel1.MouseEnter, txt_allergenes_keyword.LostFocus, txt_description_keyword.LostFocus,
                                                                                    txt_rech_marque.LostFocus, txt_rech_nom.LostFocus
        Trouver_Resultats()
    End Sub

    Private Sub cbo_allergenes_SelectedIndexChanged(sender As ComboBox, e As EventArgs) Handles cbo_allergenes.SelectedIndexChanged
        If sender.SelectedIndex = 2 Or sender.SelectedIndex = 3 Then
            txt_allergenes_keyword.Enabled = True
        Else
            txt_allergenes_keyword.Enabled = False
            Trouver_Resultats()
        End If
    End Sub

    Private Sub cbo_description_SelectedIndexChanged(sender As ComboBox, e As EventArgs) Handles cbo_description.SelectedIndexChanged
        If sender.SelectedIndex = 2 Then
            txt_description_keyword.Enabled = True
        Else
            txt_description_keyword.Enabled = False
            Trouver_Resultats()
        End If
    End Sub
#End Region


#Region "autres"
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

            Trouver_Resultats()
            RemplirGrid()
        End If
    End Sub

    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btnRechercher.MouseEnter, btnReinitialiser.MouseEnter, btnAjouter.MouseEnter
        sender.BackColor = Color.White
        sender.ForeColor = Color.Black
    End Sub

    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btnRechercher.MouseLeave, btnReinitialiser.MouseLeave, btnAjouter.MouseLeave

        If sender.Text = btnReinitialiser.Text Then
            sender.BackColor = Color.FromArgb(72, 84, 96)
            sender.ForeColor = SystemColors.Control
        Else
            sender.BackColor = Color.FromArgb(52, 73, 94)
            sender.ForeColor = SystemColors.Control
        End If
    End Sub

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

    Private Sub btn_MouseEnter(sender As Object, e As EventArgs) Handles btnReinitialiser.MouseEnter, btnRechercher.MouseEnter, btnAjouter.MouseEnter

    End Sub

    Private Sub btn_MouseLeave(sender As Object, e As EventArgs) Handles btnReinitialiser.MouseLeave, btnRechercher.MouseLeave, btnAjouter.MouseLeave

    End Sub
    ''' <summary>
    ''' Méthode qui gère l'événement du clic sur le bouton btnAjouter, cela fait apparaître le formulaire formAjout
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        formAjout.ShowDialog()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub dgv_produits_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_produits.CellContentClick

    End Sub


#End Region
End Class

