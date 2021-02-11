Imports System.Data.Sql
Imports MySql.Data.MySqlClient

Public Class frm_details_produit
    Dim bd As New Connexion
    Dim ds As New DataSet
    Dim da As New MySqlDataAdapter
    Dim code As String

    Dim leExerc As String
    Dim utls_conn As Utilisateur
    Dim inventaire As String

    Sub New(code_produit As String)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        code = code_produit
        pnl_defaut.Location = New Point(15, 6)

        Try
            Charger_DS()
            Remplir_Controles()
        Catch ex As MySqlException
        End Try
    End Sub

    Sub New(code_produit As String, ex As String, utls As Utilisateur, invent As String)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        code = code_produit
        leExerc = ex
        utls_conn = utls
        inventaire = invent
        pnl_inventaire.Visible = True

        Try
            Charger_DS_inventaire()
            Remplir_Controles()
            Remplir_Controles_inventaire()
        Catch exe As MySqlException
        End Try
    End Sub

    Sub Charger_DS()
        Dim requete As String = "Select nom_produit, code_produit, if(code_barre <> '', code_barre, 'N/A'), if(code_plu <> '', code_plu, 'N/A'), nom_format, nom_categorie, unite_mesure, 
                                if(description <> '', description, ''), if(p.remarque <> '', p.remarque, ''), nbr_unite_format, marque, 
                                if(allergene <> '', allergene, ''), perissable, bio
                                FROM tbl_produits p
                                INNER JOIN tbl_formats f ON p.no_format = f.no_format
                                INNER JOIN tbl_categories c ON p.no_categorie = c.no_categorie
                                INNER JOIN tbl_unites_mesure um ON p.no_mesure = um.no_mesure
                                WHERE code_produit = '" & code & "'"
        bd.miseAjourDS(ds, da, requete, "tbl_produits")
    End Sub

    Sub Charger_DS_inventaire()
        Dim requete As String = "Select nom_produit, p.code_produit, if(code_barre <> '', code_barre, 'N/A'), if(code_plu <> '', code_plu, 'N/A'), nom_format, nom_categorie, unite_mesure, 
                                if(description <> '', description, ''), if(p.remarque <> '', p.remarque, ''), nbr_unite_format, marque, 
                                if(allergene <> '', allergene, ''), perissable, bio, nom_emplacement, quantite
                                FROM tbl_produits p
                                INNER JOIN tbl_formats f ON p.no_format = f.no_format
                                INNER JOIN tbl_categories c ON p.no_categorie = c.no_categorie
                                INNER JOIN tbl_unites_mesure um ON p.no_mesure = um.no_mesure
                                INNER JOIN tbl_inventaire_detail id ON p.code_produit = id.code_produit
                                INNER JOIN tbl_emplacement_inventaire ei ON id.no_emplacement = ei.no_emplacement
                                WHERE p.code_produit = '" & code & "' and "

        If inventaire = "prof" Then
            requete &= "no_inventaire = (select no_inventaire from tbl_inventaire_prof where no_utilisateur = '" & utls_conn.No_id & "')"
        Else
            requete &= "no_inventaire = (select no_inventaire from tbl_exercices where no_exercice = " & leExerc & ")"
        End If

        bd.miseAjourDS(ds, da, requete, "tbl_produits")
    End Sub

    Sub Remplir_Controles()
        Dim tab_controles() As Control = {lbl_nom_produit, lbl_no_produit, lbl_code_barre, lbl_code_plu, lbl_format, lbl_categorie, lbl_unite_mesure,
                                          lbl_description, lbl_remarques, lbl_quantite, lbl_marque, lbl_allergenes}
        With ds.Tables(0)
            For i = 0 To 11
                tab_controles(i).Text = .Rows(0).Item(i)

            Next
            chk_perissable.Checked = .Rows(0).Item(12)
            chk_bio.Checked = .Rows(0).Item(13)
        End With
    End Sub

    Sub Remplir_Controles_inventaire()
        Dim tab_controles() As Control = {lbl_emplacement, lbl_quant, lbl_quantSelonFormat}
        Dim j As Integer

        With ds.Tables(0)
            For i = 14 To .Columns.Count - 1
                tab_controles(j).Text = .Rows(0).Item(i)
                j += 1
            Next
        End With

        lbl_quantSelonFormat.Text = CType(lbl_quant.Text, Decimal) * CType(lbl_quantite.Text, Integer)
        lbl_quantSelonFormat.Text &= " " & lbl_unite_mesure.Text
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click, btn_retour.Click
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

    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btn_retour.MouseEnter
        sender.BackColor = Color.White
        sender.ForeColor = Color.Black
    End Sub

    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btn_retour.MouseLeave
        If sender.Text = btn_retour.Text Then
            sender.BackColor = Color.FromArgb(72, 84, 96)
            sender.ForeColor = SystemColors.Control
        Else
            sender.BackColor = Color.FromArgb(52, 73, 94)
        sender.ForeColor = SystemColors.Control
        End If
    End Sub
End Class