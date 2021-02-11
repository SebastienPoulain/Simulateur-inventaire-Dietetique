Imports System.Data.Sql
Imports MySql.Data.MySqlClient

' KEVEN ABEL
' Liaison entre un fournisseur avec un ou plusieurs produits

Public Class frm_associer_produit
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
        Identifier_Fournisseur()
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
#Region "Remplissage des DataGridViews, identification du fournisseur & Anti-Doublon"
    Sub Identifier_Fournisseur()
        Dim ds As New DataSet
        Dim requete As String = "SELECT nom_fournisseur FROM tbl_fournisseurs WHERE no_fournisseur = '" & id & "'"
        bd.miseAjourDS(ds, da, requete, "tbl_fournisseurs")

        lbl_nom_asso.Text = ds.Tables(0).Rows(0).Item(0)
        lbl_nom_nav.Text = ds.Tables(0).Rows(0).Item(0)
    End Sub

    Sub Recuperer_Non_Associes()
        Dim requete As String = "SELECT DISTINCT tbl_produits.code_produit, tbl_produits.nom_produit, marque
                                 FROM tbl_produits
                                 LEFT JOIN tbl_produit_fournisseur_prix on tbl_produits.code_produit = tbl_produit_fournisseur_prix.code_produit
                                 WHERE tbl_produits.code_produit NOT IN 
                                    (SELECT code_produit FROM tbl_produit_fournisseur_prix
                                     WHERE no_fournisseur = '" & id & "' AND actif = true)"

        bd.miseAjourDS(ds_non_associes, da, requete, "tbl_produit_fournisseur_prix")
    End Sub

    Sub Recuperer_Associes()
        Dim requete As String = "SELECT tbl_produit_fournisseur_prix.code_produit, tbl_produits.nom_produit, marque, prix
                                 FROM tbl_produit_fournisseur_prix
                                 INNER JOIN tbl_produits on tbl_produits.code_produit = tbl_produit_fournisseur_prix.code_produit
                                 WHERE  tbl_produit_fournisseur_prix.no_fournisseur = '" & id & "' AND date_prix = 
                                    (SELECT MAX(date_Prix) FROM tbl_produit_fournisseur_prix                                                   
                                    WHERE no_fournisseur = tbl_produit_fournisseur_prix.no_fournisseur AND code_produit = tbl_produits.code_produit
                                    AND no_fournisseur = '" & id & "') AND tbl_produit_fournisseur_prix.actif = true"
        bd.miseAjourDS(ds_associes, da, requete, "tbl_produit_fournisseur_prix")
    End Sub

    Sub Remplir_Non_Associes()
        dgv_non_associes.Rows.Clear()
        With ds_non_associes.Tables(0)
            For i As Integer = 0 To .Rows.Count - 1
                dgv_non_associes.Rows.Add(.Rows(i).Item(0))
                dgv_non_associes.Rows(dgv_non_associes.Rows.Count - 1).Cells(1).Value = .Rows(i).Item(1)
                dgv_non_associes.Rows(dgv_non_associes.Rows.Count - 1).Cells(2).Value = .Rows(i).Item(2)
            Next
        End With
    End Sub

    Sub Remplir_Associes()
        dgv_associes.Rows.Clear()
        With ds_associes.Tables(0)
            For i As Integer = 0 To .Rows.Count - 1
                dgv_associes.Rows.Add(.Rows(i).Item(0))
                dgv_associes.Rows(dgv_associes.Rows.Count - 1).Cells(1).Value = .Rows(i).Item(1)
                dgv_associes.Rows(dgv_associes.Rows.Count - 1).Cells(2).Value = .Rows(i).Item(2)
                dgv_associes.Rows(dgv_associes.Rows.Count - 1).Cells(3).Value = .Rows(i).Item(3)
            Next
        End With
    End Sub

    'Procédure pour contrer le doublage des produits lorsqu'on fait une recherche et que l'on transfère un des items
    Sub Anti_Doublon_NA()
        Dim i As Integer
        Dim j As Integer

        For j = 0 To dgv_associes.Rows.Count - 1
            Dim trouve As Boolean = False
            i = 0

            While (i < dgv_non_associes.Rows.Count And trouve = False)
                If dgv_non_associes.Rows(i).Cells(0).Value = dgv_associes.Rows(j).Cells(0).Value Then
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
#Region "Transfert des produits"
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
                dgv_associes.Rows.Add(.Item(i)(0), .Item(i)(1), .Item(i)(2), .Item(i)(3))
            End With
        Next

        DesactiverTransf()
    End Sub

    Private Sub btn_versGauche_Click(sender As Object, e As EventArgs) Handles btn_versGauche.Click
        Dim liste_produits As List(Of String()) = Recuperer_Selection(dgv_associes)

        For i As Integer = 0 To liste_produits.Count - 1
            With liste_produits
                dgv_non_associes.Rows.Add(.Item(i)(0), .Item(i)(1), .Item(i)(2))
            End With
        Next

        DesactiverTransf()
    End Sub

    Function Recuperer_Selection(grid As DataGridView) As List(Of String())
        Dim prod_temp As String()
        Dim prod_refuse As String()
        Dim list_prods As New List(Of String())
        Dim list_refus As New List(Of String())
        refus = 0

        For i As Integer = grid.SelectedRows.Count - 1 To 0 Step -1
            With grid.SelectedRows(i)
                'on crée un produit temporaire et on lui assigne le code du produit, son nom, sa marque, et on cherche son prix (s'il a déjà été associé)
                prod_temp = { .Cells(0).Value, .Cells(1).Value, .Cells(2).Value, FormatCurrency(Trouver_Prix(.Cells(0).Value), 2)}
                'partie utilisée lorsqu'on transfère des non-associés aux associés.
                If grid.Name = dgv_non_associes.Name Then
                    grid.Rows.RemoveAt(grid.SelectedRows(i).Index)
                    list_prods.Add(prod_temp)

                    'partie utilisée lorsqu'on désire transférer des associés aux non-associés
                    'on va vérifier si le transfert est bon, s'il ne l'est pas, on désactive le lien en question.
                ElseIf Transfert_Valide(prod_temp, grid) Then
                    grid.Rows.RemoveAt(grid.SelectedRows(i).Index)
                    list_prods.Add(prod_temp)
                Else
                    'on enlève pareil l'item de la liste des associés pour montrer qu'il y a eu modification.
                    grid.Rows.RemoveAt(grid.SelectedRows(i).Index)
                    prod_refuse = { .Cells(0).Value, .Cells(1).Value, .Cells(2).Value, 0}
                    list_refus.Add(prod_refuse)
                    list_prods.Add(prod_temp)
                End If
            End With
        Next

        If refus > 0 Then
            'Le message de refus se fait ici, et il y aura désactivation du lien des produits.
            MessageBox.Show(Message_Refus(list_refus), "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return list_prods
    End Function

    Function Trouver_Prix(produit As String) As Double
        Dim ds_prix As New DataSet
        'on va chercher le dernier prix entré pour le produit à insérer dans les associés (s'il avait déjà été associé à ce fournisseur)
        Dim requete As String = "SELECT prix
                                 FROM tbl_produit_fournisseur_prix
                                 INNER JOIN tbl_produits on tbl_produits.code_produit = tbl_produit_fournisseur_prix.code_produit
                                 WHERE  tbl_produit_fournisseur_prix.no_fournisseur = '" & id & "' AND date_prix = 
                                    (SELECT MAX(date_Prix) FROM tbl_produit_fournisseur_prix                                                   
                                    WHERE no_fournisseur = tbl_produit_fournisseur_prix.no_fournisseur AND code_produit = '" & produit & "'
                                    AND no_fournisseur = '" & id & "') AND tbl_produit_fournisseur_prix.actif = false"
        bd.miseAjourDS(ds_prix, da, requete, "tbl_produit_fournisseur_prix")
        's'il n'était pas déjà associé, on retourne un prix de 0
        If ds_prix.Tables(0).Rows.Count = 0 Then
            Return 0
        Else
            'sinon, on fait apparaître le dernier prix et on réactive le lien en question
            bd.InsDelUpd("UPDATE tbl_produit_fournisseur_prix SET actif = true WHERE no_fournisseur = '" & id & "' AND code_produit = '" & produit & "'")
            Return ds_prix.Tables(0).Rows(0).Item(0)
        End If
    End Function

    Function Transfert_Valide(produit As String(), grid As DataGridView) As Boolean
        If Not Deja_Associe(produit) Then
            Return True
        Else
            refus += 1
            Return False
        End If
    End Function

    Function Message_Refus(list_refus As List(Of String())) As String
        Dim message As String = "Les produits suivants ne seront pas supprimés car ils sont déjà liés à ce fournisseur: " & vbCrLf & vbCrLf
        For i = 0 To list_refus.Count - 1
            With list_refus
                message += "   - " & .Item(i)(0) & "   " & .Item(i)(1) & "   " & .Item(i)(2) & vbCrLf
            End With
        Next

        message += vbCrLf & "Cependant, ils seront désactivés de la liste. Sachez que vous pouvez les réactiver en tout temps."
        Desactiver_Lien(list_refus)
        Return message
    End Function

    Sub Desactiver_Lien(list_refus As List(Of String()))
        For i As Integer = 0 To list_refus.Count - 1
            With list_refus
                bd.InsDelUpd("UPDATE tbl_produit_fournisseur_prix SET actif = 0 WHERE code_produit = '" & .Item(i)(0) & "' AND no_fournisseur = '" & id & "'")
            End With
        Next
    End Sub

    Function Deja_Associe(produit As String()) As Boolean
        Dim ds_verif As New DataSet
        Dim requete As String = "SELECT count(*) FROM tbl_produit_fournisseur_prix
                                 WHERE no_fournisseur = '" & id & "' AND code_produit = '" & produit(0) & "'"
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
    '
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
                If Prix_OK(.Cells(3).Value) Then
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
                Dim prix As String = .Cells(3).Value
                If Est_Different(prix, .Cells(0).Value) Then
                    bd.InsDelUpd("INSERT INTO tbl_produit_fournisseur_prix VALUES ('" & .Cells(0).Value & "', '" & id & "', " &
                    Replace(Enlever_Signe_Monnaie(prix, prix.Length - 1), ",", ".") & ", '" & Date.Now & "', true)")
                End If
            End With
        Next

        If MessageBox.Show("Les produits sont maintenant liés à: " & lbl_nom_asso.Text & "." & vbCrLf & vbCrLf & "Continuer avec d'autres produits?",
                           "Liaison de produits", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
            Close()
        Else
            MAJ()
        End If
    End Sub

    Function Est_Different(ByVal prix As String, ByVal produit As String) As Boolean
        Dim ds_prix As New DataSet
        Dim requete As String = "SELECT prix
                                 FROM tbl_produit_fournisseur_prix
                                 INNER JOIN tbl_produits on tbl_produits.code_produit = tbl_produit_fournisseur_prix.code_produit
                                 WHERE  tbl_produit_fournisseur_prix.no_fournisseur = '" & id & "' AND date_prix = 
                                    (SELECT MAX(date_Prix) FROM tbl_produit_fournisseur_prix                                                   
                                    WHERE no_fournisseur = tbl_produit_fournisseur_prix.no_fournisseur AND code_produit = '" & produit & "'
                                    AND no_fournisseur = '" & id & "') AND tbl_produit_fournisseur_prix.actif = true"

        bd.miseAjourDS(ds_prix, da, requete, "tbl_produit_fournisseur_prix")

        's'il n'y a pas de prix à la base pour le produit, on retourne true
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
        Dim requete As String = "SELECT DISTINCT tbl_produits.code_produit, tbl_produits.nom_produit, marque
                                 FROM tbl_produits
                                 LEFT JOIN tbl_produit_fournisseur_prix on tbl_produits.code_produit = tbl_produit_fournisseur_prix.code_produit
                                 WHERE tbl_produits.code_produit NOT IN 
                                    (SELECT code_produit FROM tbl_produit_fournisseur_prix
                                     WHERE no_fournisseur = '" & id & "' AND actif = true)"

        If rd_nom.Checked Then
            requete += " AND replace(tbl_produits.nom_produit, ' ', '') LIKE '%" & ConvertirApostrophe(txt_recherche.Text.Trim.Replace(" ", "")) & "%'"
        ElseIf rd_marque.Checked Then
            requete += " AND replace(marque, ' ', '') LIKE '%" & ConvertirApostrophe(txt_recherche.Text.Trim.Replace(" ", "")) & "%'"
        End If


        bd.miseAjourDS(ds_non_associes, da, requete, "tbl_produits")
        Remplir_Non_Associes()
    End Sub
#End Region

End Class