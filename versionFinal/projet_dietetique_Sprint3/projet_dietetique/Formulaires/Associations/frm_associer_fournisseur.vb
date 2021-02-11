Imports System.Data.Sql
Imports MySql.Data.MySqlClient

' KEVEN ABEL
' Liaison entre un produit avec un ou plusieurs fournisseurs

Public Class frm_associer_fournisseur
    Dim id As String
    Dim ds_associes As New DataSet
    Dim ds_non_associes As New DataSet
    Dim da As New MySqlDataAdapter
    Dim bd As New Connexion
    Dim refus As Integer

    Sub New(_id As String)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        id = _id
        MAJ()
        Identifier_Produit()
    End Sub

    Sub MAJ()
        Cursor = Cursors.AppStarting
        Recuperer_Non_Associes()
        Recuperer_Associes()
        Remplir_Associes()
        Remplir_Non_Associes()
        Anti_Doublon_NA()
        DesactiverTransf()
        Cursor = Cursors.Default
    End Sub

    'dans le cas d'erreurs dans les prix, il faut laisser la rangée en rouge
    Private Sub dgv_associes_CellMouseLeave(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_associes.CellMouseLeave
        If e.RowIndex > -1 Then
            If Not dgv_associes.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red Then
                dgv_associes.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            End If
            dgv_associes.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White

        End If
    End Sub

    Private Sub dgv_associes_CellMouseEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_associes.CellMouseEnter
        If e.RowIndex > -1 Then
            dgv_associes.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(236, 240, 241)
            If Not dgv_associes.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red Then
                dgv_associes.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            End If
        End If
    End Sub

#Region "Manipulation de la fenêtre"
    ''' <description>
    ''' 
    ''' Région dédiée à la manipulation de la fenêtre via <composant name="pnlNavigation"/> qui remplace la bordure du formulaire originale.
    ''' 
    ''' <fonctionnalites>
    ''' Déplacement de la fenêtre lorsqu'on tient le bouton gauche de la souris sur le paneau
    ''' <bouton name="btn_minimize"/> sert à minimiser la fenêtre lorsque cliqué
    ''' <bouton name="btn_exit"/> sert à quitter l'application lorsque cliqué
    ''' </fonctionnalites>
    ''' 
    ''' </description>


    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles pnl_navigation.MouseDown, lbl_titre.MouseDown
        mod_mvtFenetre.mouseDown(e)
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles pnl_navigation.MouseMove, lbl_titre.MouseMove
        mod_mvtFenetre.mouseMove(e, Me)
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles pnl_navigation.MouseUp, lbl_titre.MouseUp
        mod_mvtFenetre.mouseUp(e)
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click, btn_annuler.Click
        If MessageBox.Show("Désirez-vous revenir au menu précédent?", "Annuler",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btn_associer.MouseEnter, btn_annuler.MouseEnter,
                                                                         btn_versDroit.MouseEnter, btn_versGauche.MouseEnter

        sender.ForeColor = Color.Black
        sender.BackColor = Color.White

    End Sub

    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btn_associer.MouseLeave, btn_annuler.MouseLeave,
                                                                         btn_versDroit.MouseLeave, btn_versGauche.MouseLeave
        If sender.Text = btn_annuler.Text Then
            sender.BackColor = Color.FromArgb(72, 84, 96)
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
#Region "Remplissage des DataGridViews, identification du produit & Anti-Doublon"
    'on identifie le produit dans la barre de navigation ainsi que dans les autres libellés associés
    Sub Identifier_Produit()
        Dim ds As New DataSet
        Dim requete As String = "SELECT nom_produit, marque FROM tbl_produits WHERE code_produit = '" & id & "'"
        bd.miseAjourDS(ds, da, requete, "tbl_produits")

        lbl_nom_asso.Text = ds.Tables(0).Rows(0).Item(0) & "   (" & ds.Tables(0).Rows(0).Item(1) & ")"
        lbl_nom_nav.Text = ds.Tables(0).Rows(0).Item(0) & "   (" & ds.Tables(0).Rows(0).Item(1) & ")"
    End Sub

    'on récupère tous les fournisseurs non-associés à ce produit
    Sub Recuperer_Non_Associes()
        Dim requete As String = "SELECT DISTINCT nom_fournisseur, nom_ville, adresse, code_postal
                                 FROM tbl_fournisseurs
                                 LEFT JOIN tbl_produit_fournisseur_prix on tbl_fournisseurs.no_fournisseur = tbl_produit_fournisseur_prix.no_fournisseur
                                 INNER JOIN tbl_ville on tbl_ville.no_ville = tbl_fournisseurs.ville
                                 WHERE tbl_fournisseurs.no_fournisseur NOT IN 
                                    (SELECT no_fournisseur FROM tbl_produit_fournisseur_prix
                                     WHERE code_produit = '" & id & "' AND actif = true)"

        bd.miseAjourDS(ds_non_associes, da, requete, "tbl_fournisseurs")
    End Sub

    'et on récupère tous ceux qui sont associés ainsi que le prix le plus récent (la date fonctionne selon la date ET l'heure)
    Sub Recuperer_Associes()
        Dim requete As String = "SELECT nom_fournisseur, nom_ville, adresse, code_postal, prix
                                 FROM tbl_produit_fournisseur_prix
                                 INNER JOIN tbl_fournisseurs on tbl_fournisseurs.no_fournisseur = tbl_produit_fournisseur_prix.no_fournisseur
                                 INNER JOIN tbl_produits on tbl_produits.code_produit = tbl_produit_fournisseur_prix.code_produit
                                 INNER JOIN tbl_ville on tbl_ville.no_ville = tbl_fournisseurs.ville
                                 WHERE tbl_produit_fournisseur_prix.code_produit = '" & id & "' AND date_prix = 
                                    (SELECT MAX(date_Prix) FROM tbl_produit_fournisseur_prix                                                   
                                    WHERE no_fournisseur = tbl_fournisseurs.no_fournisseur AND code_produit = tbl_produit_fournisseur_prix.code_produit
                                    AND code_produit = '" & id & "') AND tbl_produit_fournisseur_prix.actif = true"
        bd.miseAjourDS(ds_associes, da, requete, "tbl_produit_fournisseur_prix")
    End Sub

    'on remplit le datagridview des non-associés
    Sub Remplir_Non_Associes()
        dgv_non_associes.Rows.Clear()
        With ds_non_associes.Tables(0)
            For i As Integer = 0 To .Rows.Count - 1
                dgv_non_associes.Rows.Add(.Rows(i).Item(0))
                dgv_non_associes.Rows(dgv_non_associes.Rows.Count - 1).Cells(1).Value = .Rows(i).Item(1)
                dgv_non_associes.Rows(dgv_non_associes.Rows.Count - 1).Cells(2).Value = .Rows(i).Item(2)
                dgv_non_associes.Rows(dgv_non_associes.Rows.Count - 1).Cells(3).Value = .Rows(i).Item(3)
            Next
        End With
    End Sub

    '... et ceux des associés
    Sub Remplir_Associes()
        dgv_associes.Rows.Clear()
        With ds_associes.Tables(0)
            For i As Integer = 0 To .Rows.Count - 1
                dgv_associes.Rows.Add(.Rows(i).Item(0))
                dgv_associes.Rows(dgv_associes.Rows.Count - 1).Cells(1).Value = .Rows(i).Item(1)
                dgv_associes.Rows(dgv_associes.Rows.Count - 1).Cells(2).Value = .Rows(i).Item(2)
                dgv_associes.Rows(dgv_associes.Rows.Count - 1).Cells(3).Value = .Rows(i).Item(3)
                dgv_associes.Rows(dgv_associes.Rows.Count - 1).Cells(4).Value = .Rows(i).Item(4)
            Next
        End With
    End Sub

    'Procédure pour contrer le doublage des fournisseurs lorsqu'on fait une recherche et que l'on transfère un des items
    Sub Anti_Doublon_NA()
        Dim i As Integer
        Dim j As Integer

        For j = 0 To dgv_associes.Rows.Count - 1
            Dim trouve As Boolean = False
            i = 0

            While (i < dgv_non_associes.Rows.Count And trouve = False)
                If dgv_non_associes.Rows(i).Cells(0).Value = dgv_associes.Rows(j).Cells(0).Value And dgv_non_associes.Rows(i).Cells(1).Value = dgv_associes.Rows(j).Cells(1).Value And
                    dgv_non_associes.Rows(i).Cells(2).Value = dgv_associes.Rows(j).Cells(2).Value And dgv_non_associes.Rows(i).Cells(3).Value = dgv_associes.Rows(j).Cells(3).Value Then
                    dgv_non_associes.Rows.RemoveAt(i)
                    trouve = True
                Else
                    i += 1
                End If
            End While
        Next

    End Sub
#End Region
    '
    '
    '
    '
    '
#Region "Transfert des fournisseurs"
    'on gère l'activation des flèches (s'il y en a plus d'un bord, son bouton sera désactivé)
    Private Sub DesactiverTransf()
        If dgv_non_associes.Rows.Count = 0 Then
            btn_versDroit.Enabled = False
        Else
            btn_versDroit.Enabled = True
        End If

        If dgv_associes.Rows.Count = 0 Then
            btn_versGauche.Enabled = False
        Else
            btn_versGauche.Enabled = True
        End If
    End Sub

    Private Sub btn_versDroit_Click(sender As Object, e As EventArgs) Handles btn_versDroit.Click
        Dim liste_produits As List(Of String()) = Recuperer_Selection(dgv_non_associes)

        For i As Integer = 0 To liste_produits.Count - 1
            With liste_produits
                dgv_associes.Rows.Add(.Item(i)(0), .Item(i)(1), .Item(i)(2), .Item(i)(3), .Item(i)(4))
            End With
        Next

        DesactiverTransf()
    End Sub

    Private Sub btn_versGauche_Click(sender As Object, e As EventArgs) Handles btn_versGauche.Click
        Dim liste_produits As List(Of String()) = Recuperer_Selection(dgv_associes)

        For i As Integer = 0 To liste_produits.Count - 1
            With liste_produits
                dgv_non_associes.Rows.Add(.Item(i)(0), .Item(i)(1), .Item(i)(2), .Item(i)(3))
            End With
        Next

        DesactiverTransf()
    End Sub

    'on récupère les fournisseurs sélectionnés
    Function Recuperer_Selection(grid As DataGridView) As List(Of String())
        Dim fourn_temp As String()
        Dim fourn_refuse As String()
        Dim list_fourn As New List(Of String())
        Dim list_refus As New List(Of String())
        refus = 0

        For i As Integer = grid.SelectedRows.Count - 1 To 0 Step -1
            With grid.SelectedRows(i)
                Dim ds As New DataSet
                Dim requete_id As String = "SELECT no_fournisseur FROM tbl_fournisseurs
                                            INNER JOIN tbl_ville on tbl_ville.no_ville = tbl_fournisseurs.ville
                                            WHERE nom_fournisseur = '" & .Cells(0).Value & "' AND nom_ville = '" & .Cells(1).Value &
                                            "' AND adresse = '" & .Cells(2).Value & "' AND code_postal = '" & .Cells(3).Value & "'"
                bd.miseAjourDS(ds, da, requete_id, "tbl_fournisseurs")
                'on crée un fournisseur temporaire et on lui assigne son nom, sa ville, son adresse, son code postal, et on cherche son prix (s'il a déjà été associé)
                fourn_temp = { .Cells(0).Value, .Cells(1).Value, .Cells(2).Value, .Cells(3).Value, FormatCurrency(Trouver_Prix(ds.Tables(0).Rows(0).Item(0)), 2)}
                'partie utilisée lorsqu'on transfère des non-associés aux associés.
                If grid.Name = dgv_non_associes.Name Then
                    grid.Rows.RemoveAt(grid.SelectedRows(i).Index)
                    list_fourn.Add(fourn_temp)

                    'partie utilisée lorsqu'on désire transférer des associés aux non-associés
                    'on va vérifier si le transfert est bon, s'il ne l'est pas, on désactive le lien en question.
                ElseIf Transfert_Valide(fourn_temp, grid) Then
                    grid.Rows.RemoveAt(grid.SelectedRows(i).Index)
                    list_fourn.Add(fourn_temp)
                Else
                    'on enlève pareil l'item de la liste des associés pour montrer qu'il y a eu modification.
                    grid.Rows.RemoveAt(grid.SelectedRows(i).Index)
                    fourn_refuse = { .Cells(0).Value, .Cells(1).Value, .Cells(2).Value, .Cells(3).Value, 0}
                    list_refus.Add(fourn_refuse)
                    list_fourn.Add(fourn_temp)
                End If
            End With
        Next

        If refus > 0 Then
            'Le message de refus se fait ici, et il y aura désactivation du lien des fournisseurs avec le produit.
            MessageBox.Show(Message_Refus(list_refus), "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return list_fourn
    End Function

    Function Trouver_Prix(fournisseur As String) As Double
        Dim ds_prix As New DataSet

        'on va chercher le dernier prix entré pour le produit à insérer dans les associés (s'il avait déjà été associé à ce fournisseur)
        Dim requete As String = "SELECT prix
                                 FROM tbl_produit_fournisseur_prix
                                 INNER JOIN tbl_fournisseurs on tbl_fournisseurs.no_fournisseur = tbl_produit_fournisseur_prix.no_fournisseur
                                 WHERE  tbl_produit_fournisseur_prix.code_produit = '" & id & "' AND date_prix = 
                                    (SELECT MAX(date_Prix) FROM tbl_produit_fournisseur_prix                                                   
                                    WHERE code_produit = tbl_produit_fournisseur_prix.code_produit AND no_fournisseur = '" & fournisseur & "'
                                    AND code_produit = '" & id & "') AND tbl_produit_fournisseur_prix.actif = false"
        bd.miseAjourDS(ds_prix, da, requete, "tbl_produit_fournisseur_prix")
        's'il n'était pas déjà associé, on retourne un prix de 0
        If ds_prix.Tables(0).Rows.Count = 0 Then
            Return 0
        Else
            'sinon, on fait apparaître le dernier prix et on réactive le lien en question
            bd.InsDelUpd("UPDATE tbl_produit_fournisseur_prix SET actif = true WHERE no_fournisseur = '" & fournisseur & "' AND code_produit = '" & id & "'")
            Return ds_prix.Tables(0).Rows(0).Item(0)
        End If
    End Function

    'on vérifie si le fournisseur est déjà associé
    Function Transfert_Valide(fournisseur As String(), grid As DataGridView) As Boolean
        If Not Deja_Associe(fournisseur) Then
            Return True
        Else
            refus += 1
            Return False
        End If
    End Function

    's'il y a des fournisseurs déjà associés, on affiche un message...
    Function Message_Refus(list_refus As List(Of String())) As String
        Dim message As String = "Les fournisseurs suivants ne seront pas supprimés car ils sont déjà liés à ce produit: " & vbCrLf & vbCrLf
        For i = 0 To list_refus.Count - 1
            With list_refus
                message += "   - " & .Item(i)(0) & "   " & .Item(i)(1) & "   " & .Item(i)(2) & "   " & .Item(i)(3) & vbCrLf
            End With
        Next

        message += vbCrLf & "Cependant, ils seront désactivés de la liste. Sachez que vous pouvez les réactiver en tout temps."
        Desactiver_Lien(list_refus)
        Return message
    End Function

    '... et on désactive le lien entre fournisseur et produit
    Sub Desactiver_Lien(list_refus As List(Of String()))
        For i As Integer = 0 To list_refus.Count - 1
            With list_refus
                Dim requete_id As String = "SELECT no_fournisseur FROM tbl_fournisseurs
                                            INNER JOIN tbl_ville on tbl_ville.no_ville = tbl_fournisseurs.ville
                                            WHERE nom_fournisseur = '" & .Item(i)(0) & "' AND nom_ville = '" & .Item(i)(1) &
                                            "' AND adresse = '" & .Item(i)(2) & "' AND code_postal = '" & .Item(i)(3) & "'"
                bd.InsDelUpd("UPDATE tbl_produit_fournisseur_prix SET actif = 0 WHERE code_produit = '" & id & "' AND no_fournisseur = (" & requete_id & ")")
            End With
        Next
    End Sub

    'fonction permettant de savoir si le fournisseur est déjà associé au produit
    Function Deja_Associe(fournisseur As String()) As Boolean
        Dim ds_verif As New DataSet
        Dim requete As String = "SELECT count(*) FROM tbl_produit_fournisseur_prix
                                 INNER JOIN tbl_fournisseurs ON tbl_fournisseurs.no_fournisseur = tbl_produit_fournisseur_prix.no_fournisseur
                                 INNER JOIN tbl_ville on tbl_ville.no_ville = tbl_fournisseurs.ville
                                 WHERE code_produit = '" & id & "' AND nom_fournisseur = '" & fournisseur(0) & "' AND nom_ville = '" & fournisseur(1) &
                                            "' AND adresse = '" & fournisseur(2) & "' AND code_postal = '" & fournisseur(3) & "'"
        bd.miseAjourDS(ds_verif, da, requete, "tbl_produit_fournisseur_prix")

        If ds_verif.Tables(0).Rows(0).Item(0) > 0 Then
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
    '.
#Region "Vérifications et association"
    Function Prix_OK(prix As String) As Boolean
        If Est_Prix(prix) Then
            Return True
        Else
            refus += 1
            Return False
        End If
    End Function

    Function Liste_OK(grid As DataGridView) As Boolean
        refus = 0

        For i As Integer = 0 To grid.Rows.Count - 1
            With grid.Rows(i)
                's'il y a erreur, la rangée du dgv sera en rouge
                If Prix_OK(.Cells(4).Value) Then
                    .DefaultCellStyle.ForeColor = Color.Black
                    .DefaultCellStyle.SelectionForeColor = Color.Black
                Else
                    .DefaultCellStyle.ForeColor = Color.Red
                    .DefaultCellStyle.SelectionForeColor = Color.Red
                End If
            End With
        Next

        If refus = 0 Then
            Return True
        Else
            MessageBox.Show("La liste contient des erreurs. Seuls les chiffres et les points (ou les virgules) sont acceptés.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If
    End Function

    Sub Faire_Lien(grid As DataGridView)
        For i As Integer = 0 To grid.Rows.Count - 1
            With grid.Rows(i)
                Dim ds As New DataSet
                Dim requete_id As String = "SELECT no_fournisseur FROM tbl_fournisseurs
                                            INNER JOIN tbl_ville on tbl_ville.no_ville = tbl_fournisseurs.ville
                                            WHERE nom_fournisseur = '" & .Cells(0).Value & "' AND nom_ville = '" & .Cells(1).Value &
                                            "' AND adresse = '" & .Cells(2).Value & "' AND code_postal = '" & .Cells(3).Value & "'"
                bd.miseAjourDS(ds, da, requete_id, "tbl_fournisseurs")
                Dim prix As String = .Cells(4).Value
                If Est_Different(prix, ds.Tables(0).Rows(0).Item(0)) Then
                    bd.InsDelUpd("INSERT INTO tbl_produit_fournisseur_prix VALUES ('" & id & "', '" & ds.Tables(0).Rows(0).Item(0) & "', " &
                    Replace(Enlever_Signe_Monnaie(prix, prix.Length - 1), ",", ".") & ", '" & Date.Now & "', true)")
                End If
            End With
        Next

        If MessageBox.Show("Les fournisseurs sont maintenant liés à: " & vbCrLf & vbCrLf & lbl_nom_asso.Text & vbCrLf & vbCrLf & "Continuer avec d'autres fournisseurs?",
                           "Liaison de fournisseurs", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
            Close()
        Else
            MAJ()
        End If
    End Sub

    Function Est_Different(ByVal prix As String, ByVal fournisseur As String) As Boolean
        Dim ds_prix As New DataSet
        Dim requete As String = "SELECT prix
                                 FROM tbl_produit_fournisseur_prix
                                 INNER JOIN tbl_fournisseurs on tbl_fournisseurs.no_fournisseur = tbl_produit_fournisseur_prix.no_fournisseur
                                 WHERE  tbl_produit_fournisseur_prix.code_produit = '" & id & "' AND date_prix = 
                                    (SELECT MAX(date_Prix) FROM tbl_produit_fournisseur_prix                                                   
                                    WHERE code_produit = tbl_produit_fournisseur_prix.code_produit AND no_fournisseur = '" & fournisseur & "'
                                    AND code_produit = '" & id & "') AND tbl_produit_fournisseur_prix.actif = true"

        bd.miseAjourDS(ds_prix, da, requete, "tbl_produit_fournisseur_prix")

        's'il n'y a pas de prix à la base pour le fournisseur, on retourne true
        If ds_prix.Tables(0).Rows.Count = 0 Then
            Return True
            'si les prix sont différents, on retourne true
        ElseIf Enlever_Signe_Monnaie(prix, prix.Length - 1) <> Replace(ds_prix.Tables(0).Rows(0).Item(0), ".", ",") Then
            Return True
            'sinon, on retourne false et on ne touche pas à la ligne (on n'en insère pas une)
        Else
            Return False
        End If
    End Function

    Private Sub btn_associer_Click(sender As Object, e As EventArgs) Handles btn_associer.Click
        If Liste_OK(dgv_associes) Then
            Faire_Lien(dgv_associes)
        End If
    End Sub
#End Region
    '
    '
    '
    '
    '
#Region "Recherches"
    Private Sub txt_recherche_TextChanged(sender As Object, e As EventArgs) Handles txt_recherche.TextChanged
        Rechercher()
        Anti_Doublon_NA()
        DesactiverTransf()
    End Sub

    Sub Rechercher()
        Dim requete As String = "SELECT DISTINCT nom_fournisseur, nom_ville, adresse, code_postal
                                 FROM tbl_fournisseurs
                                 LEFT JOIN tbl_produit_fournisseur_prix on tbl_fournisseurs.no_fournisseur = tbl_produit_fournisseur_prix.no_fournisseur
                                 INNER JOIN tbl_ville on tbl_ville.no_ville = tbl_fournisseurs.ville
                                 WHERE tbl_fournisseurs.no_fournisseur NOT IN 
                                    (SELECT no_fournisseur FROM tbl_produit_fournisseur_prix
                                     WHERE code_produit = '" & id & "' AND actif = true)"

        'recherche avancée
        If rd_nom.Checked Then
            requete += " AND replace(tbl_fournisseurs.nom_fournisseur, ' ', '') LIKE '%" & ConvertirApostrophe(txt_recherche.Text.Trim.Replace(" ", "")) & "%'"
        ElseIf rd_ville.Checked Then
            requete += " AND replace(nom_ville, ' ', '') LIKE '%" & ConvertirApostrophe(txt_recherche.Text.Trim.Replace(" ", "")) & "%'"
        End If


        bd.miseAjourDS(ds_non_associes, da, requete, "tbl_fournisseurs")
        Remplir_Non_Associes()
    End Sub
#End Region
End Class