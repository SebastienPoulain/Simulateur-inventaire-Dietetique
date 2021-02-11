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


    Private Sub usr_produits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Charger_DS()
        dgv_produits.RowTemplate.Height = 30
        dgv_produits.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgv_produits.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
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


    'Fonction servant à tricher les emplacements vides de la base de données afin d'empêcher l'application de planter.
    'Ça évite un try/catch qui aurait détecté une exception à chaque fois que l'on passe d'un produit à l'autre (car la description et la remarque sont non-nécessaires)



    Sub Charger_DS()
        bd.miseAjourDS(ds, da, "SELECT code_produit AS `No. Produit`, nom_produit AS `Nom`, marque AS `Marque`, nom_categorie AS `Categorie`, nom_format AS `Format`,
                                if(description = '', 'Non', 'Oui') AS `Description`, if(allergene = '', 'Non', 'Oui') AS `Allergenes`
                                FROM tbl_produits p
                                INNER JOIN tbl_formats f ON p.no_format = f.no_format
                                INNER JOIN tbl_categories c ON p.no_categorie = c.no_categorie
                                WHERE actif = true
                                ORDER BY code_produit", "tbl_produits")

        dgv_produits.DataSource = ds.Tables(0)
    End Sub



    'Réinitialisation du DataSet
    'C'est pour faire propre. Étant donné que la base de données revient à la position initiale (0), on désactive les boutons btn_premier et btn_precedent
    'pour réactiver btn_suivant et btn_dernier. Va aussi vider toutes les textbox de la section recherches.
    Sub Reinitialiser_Positions()

        Dim tab_recherches() As Control = {txt_srch_nom, txt_srch_marque, cbo_srch_categorie}
        For i = 0 To tab_recherches.Count - 1
            tab_recherches(i).Text = String.Empty
        Next

    End Sub

    Function Verifier_Nom_Produit() As String
        If txt_srch_nom.Text <> "" Then
            Return " AND nom_produit LIKE '" & txt_srch_nom.Text & "%'"
        Else
            Return ""
        End If
    End Function

    Function Verifier_Marque() As String
        If txt_srch_marque.Text <> "" Then
            Return " AND marque LIKE '" & txt_srch_marque.Text & "%'"
        Else
            Return ""
        End If
    End Function

    Function Verifier_Categorie() As String
        If cbo_srch_categorie.Text <> "" Then
            Return " AND nom_categorie LIKE '" & cbo_srch_categorie.Text & "%'"
        Else
            Return ""
        End If
    End Function

    Function Verifier_Perissable() As String
        If rdb_perissable_oui.Checked = True Then
            Return " AND perissable = true"
        ElseIf rdb_perissable_non.Checked = True Then
            Return " AND perissable = false"
        Else
            Return ""
        End If
    End Function

    Function Verifier_Allergenes() As String
        If rdb_allergene_oui.Checked = True Then
            Return " AND allergene <> ''"
        ElseIf rdb_allergene_non.Checked = True Then
            Return " AND allergene = ''"
        Else
            Return ""
        End If
    End Function

    Sub Lancer_Recherche()
        bd.miseAjourDS(ds, da, "Select nom_produit, code_produit, code_barre, code_plu, nom_format, nom_categorie, unite_mesure, description, 
                                p.remarque, nbr_unite_format, marque, perissable, allergene 
                                FROM tbl_produits p
                                INNER JOIN tbl_formats f ON p.no_format = f.no_format
                                INNER JOIN tbl_categories c ON p.no_categorie = c.no_categorie
                                INNER JOIN tbl_unites_mesure um ON p.no_mesure = um.no_mesure
                                WHERE actif = true" & Verifier_Nom_Produit() & Verifier_Marque() & Verifier_Categorie() & Verifier_Perissable() & Verifier_Allergenes() &
                                " ORDER BY code_produit", "tbl_produits")
        If ds.Tables(0).Rows.Count > 0 Then
            Reinitialiser_Positions()
            'Remplir_Controles()
        Else
            MsgBox("Nous n'avons pas trouvé ce que vous recherchez.")
            Charger_DS()
            Reinitialiser_Positions()
        End If

    End Sub

    Private Sub btnRechercher_Click(sender As Object, e As EventArgs) Handles btnRechercher.Click
        Lancer_Recherche()
    End Sub

    Private Sub btnReinitialiser_Click(sender As Object, e As EventArgs) Handles btnReinitialiser.Click
        Charger_DS()
        rdb_allergene_tous.Checked = True
        rdb_perissable_tous.Checked = True
        Reinitialiser_Positions()
    End Sub

    Private Sub usr_produits_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        e.Graphics.DrawLine(New Pen(Color.LightGray), New Point(450, 100), New Point(450, 550))
    End Sub


End Class
