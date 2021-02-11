Imports System.Data.Sql
Imports MySql.Data.MySqlClient

' KEVEN ABEL

Public Class usr_emplacements
    Dim ds As New DataSet
    Dim da As New MySqlDataAdapter
    Dim bd As New Connexion
    Dim nom As String
    Dim animation As New cls_animation_operation

    Private Sub usr_emplacements_Load(sender As Object, e As EventArgs) Handles Me.Load
        Initialiser()
    End Sub

    Sub Initialiser()
        txt_rech_nom.Text = String.Empty
        cbo_nom_contient.SelectedIndex = 0
        cbo_ordre.SelectedIndex = 0
        cbo_trier_activite.SelectedIndex = 0
        MAJ()
    End Sub

    Sub MAJ()
        Rechercher()
        Remplir_Emplacements()
    End Sub

#Region "Couleur des boutons"
    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btn_ajouter.MouseEnter, btnReinitialiser.MouseEnter, btn_modifier.MouseEnter, btn_annuler.MouseEnter,
                                                                         btn_desactiver.MouseEnter, btn_activer.MouseEnter


        sender.BackColor = Color.White
        sender.ForeColor = Color.Black
    End Sub

    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btn_ajouter.MouseLeave, btnReinitialiser.MouseLeave, btn_modifier.MouseLeave, btn_annuler.MouseLeave,
                                                                         btn_desactiver.MouseLeave, btn_activer.MouseLeave

        If sender.Text = btn_desactiver.Text Or sender.Text = btnReinitialiser.Text Or sender.Text = btn_annuler.Text Then
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
#Region "Gestion de la DataGridView"
    Private Sub dgv_emplacements_CellMouseLeave(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_emplacements.CellMouseLeave
        If e.RowIndex > -1 Then
            dgv_emplacements.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
            dgv_emplacements.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
        End If
    End Sub

    Private Sub dgv_emplacements_CellMouseEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_emplacements.CellMouseEnter
        If e.RowIndex > -1 Then

            dgv_emplacements.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(236, 240, 241)
            dgv_emplacements.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black

        End If
    End Sub

    'pour mieux gérer l'activation des boutons
    Sub Verification_Lignes()
        If dgv_emplacements.Rows.Count > 0 Then
            dgv_emplacements_CellClick(dgv_emplacements, New DataGridViewCellEventArgs(0, 0))
        Else
            txt_nom_emplacement.Text = ""
            txt_remarque.Text = ""
            btn_activer.Enabled = False
            btn_desactiver.Enabled = False
        End If
    End Sub

    'après avoir recherché, on remplit la DataGridView avec les informations pertinentes
    Sub Remplir_Emplacements()
        dgv_emplacements.Rows.Clear()

        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            With ds.Tables(0).Rows(i)
                dgv_emplacements.Rows.Add(.Item(0))
                dgv_emplacements.Rows(dgv_emplacements.Rows.Count - 1).Cells(1).Value = .Item(1)

                'les items inactifs seront en gris
                If .Item(2) = 0 Then
                    dgv_emplacements.Rows(dgv_emplacements.Rows.Count - 1).Cells(0).Tag = "0"
                    For j As Integer = 0 To 1
                        dgv_emplacements.Rows(dgv_emplacements.Rows.Count - 1).Cells(j).Style.ForeColor = Color.DimGray
                    Next
                Else
                    dgv_emplacements.Rows(dgv_emplacements.Rows.Count - 1).Cells(0).Tag = "1"
                End If
            End With
        Next

        dgv_emplacements.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        If dgv_emplacements.Columns(1).Width < 589 Then

            dgv_emplacements.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgv_emplacements.Columns(1).Width = 589
        End If
    End Sub

    'on rafraîchit les boutons dépendamment du statut d'activité de l'item
    Sub Rafraichir_Boutons()
        Dim _ds As New DataSet

        bd.Requete("SELECT actif FROM tbl_emplacement_inventaire WHERE nom_emplacement = '" & ConvertirApostrophe(nom.Trim) & "'", _ds, da, "tbl_emplacement_inventaire")
        If _ds.Tables(0).Rows.Count = 0 Then
            btn_activer.Enabled = False
            btn_desactiver.Enabled = False
        ElseIf _ds.Tables(0).Rows(0).Item(0) = False Then
            btn_activer.Enabled = True
            btn_desactiver.Enabled = False
        Else
            btn_desactiver.Enabled = True
            btn_activer.Enabled = False
        End If

        btn_ajouter.Enabled = True
        btn_modifier.Enabled = True

    End Sub

    Private Sub dgv_emplacements_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_emplacements.SelectionChanged
        If dgv_emplacements.SelectedRows.Count > 1 Then
            If cbo_trier_activite.Text = "Actif" Then
                btn_desactiver.Enabled = True
                btn_activer.Enabled = False
            ElseIf cbo_trier_activite.Text = "Inactif" Then
                btn_activer.Enabled = True
                btn_desactiver.Enabled = False
            End If

            btn_modifier.Enabled = False
        End If
    End Sub

    Private Sub dgv_emplacements_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_emplacements.CellClick
        If e.RowIndex > -1 Then
            nom = dgv_emplacements.Rows(e.RowIndex).Cells(0).Value
            Visualiser(nom)
            Rafraichir_Boutons()
        End If
    End Sub
#End Region
    '
    '
    '
    '
    '
#Region "Activer & Désactiver"
    Private Sub btn_activer_Click(sender As Object, e As EventArgs) Handles btn_activer.Click
        If MessageBox.Show("Voulez-vous activer l'emplacement sélectionné?",
                          "Activer un emplacement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Activer()
            MAJ()
        End If
    End Sub

    Private Sub btn_desactiver_Click(sender As Object, e As EventArgs) Handles btn_desactiver.Click
        If MessageBox.Show("Voulez-vous désactiver l'emplacement sélectionné?" & vbCrLf & vbCrLf & "Sachez que vous pouvez le réactiver n'importe quand.",
                          "Désactiver un emplacement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Desactiver()
            MAJ()
        End If
    End Sub

    Sub Activer()
        Cursor = Cursors.AppStarting
        For i As Integer = 0 To dgv_emplacements.SelectedRows.Count - 1
            With dgv_emplacements.SelectedRows(i)
                Dim requete = "UPDATE tbl_emplacement_inventaire SET actif = true
                               WHERE nom_emplacement = '" & ConvertirApostrophe(.Cells(0).Value.Trim) & "'"

                Try
                    bd.InsDelUpd(requete)
                    animation.Lancement(timer_succes, lbl_ajoutSucces, "Activation réussie.", cls_animation_operation.Reussie)
                Catch ex As Exception
                    animation.Lancement(timer_succes, lbl_ajoutSucces, "Échec de l'activation.", cls_animation_operation.Echec)
                End Try
            End With
        Next
        Cursor = Cursors.Default
    End Sub

    Sub Desactiver()
        Cursor = Cursors.AppStarting
        For i As Integer = 0 To dgv_emplacements.SelectedRows.Count - 1
            With dgv_emplacements.SelectedRows(i)
                Dim requete = "UPDATE tbl_emplacement_inventaire SET actif = false
                               WHERE nom_emplacement = '" & ConvertirApostrophe(.Cells(0).Value.Trim) & "'"

                Try
                    bd.InsDelUpd(requete)
                    animation.Lancement(timer_succes, lbl_ajoutSucces, "Désactivation réussie.", cls_animation_operation.Reussie)
                Catch ex As Exception
                    animation.Lancement(timer_succes, lbl_ajoutSucces, "Échec de la désactivation.", cls_animation_operation.Echec)
                End Try
            End With
        Next
        Cursor = Cursors.Default
    End Sub
#End Region
    '
    '
    '
    '
    '
#Region "Validations"
    Function Nom_OK(nom As String) As Boolean
        If mod_regex.Exercice(nom) Then
            lbl_erreur_nom.Hide()
            Return True
        Else
            lbl_erreur_nom.Show()
            Return False
        End If
    End Function

    Function Trouver_ID_Emplacement(nom As String) As String
        Dim ds_id As New DataSet
        bd.miseAjourDS(ds_id, da, "SELECT no_emplacement FROM tbl_emplacement_inventaire WHERE nom_emplacement = '" & ConvertirApostrophe(nom) & "'", "tbl_emplacement_inventaire")

        If ds_id.Tables(0).Rows.Count > 0 Then
            Return ds_id.Tables(0).Rows(0).Item(0)
        Else
            Return ""
        End If
    End Function

    Function Existe_Deja(nom As String) As Boolean
        Dim _ds As New DataSet
        bd.miseAjourDS(_ds, da, "SELECT COUNT(*) FROM tbl_emplacement_inventaire WHERE nom_emplacement = '" & ConvertirApostrophe(nom) & "'", "tbl_emplacement_inventaire")

        If _ds.Tables(0).Rows(0).Item(0) > 0 Then
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
#Region "Ajouter un emplacement"
    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        If sender.text = "Ajouter" Then
            Changer_Enabled()
            btn_modifier.Enabled = False
            btnReinitialiser.Enabled = False
            btn_activer.Enabled = False
            btn_desactiver.Enabled = False
            txt_nom_emplacement.Text = ""
            txt_remarque.Text = ""
            txt_nom_emplacement.Focus()
            btn_ajouter.Text = "Enregistrer"
        ElseIf Nom_OK(txt_nom_emplacement.Text) Then
            Ajouter()
        End If

    End Sub

    Sub Ajouter()
        Try
            If Existe_Deja(txt_nom_emplacement.Text) Then
                MessageBox.Show("Un emplacement de ce nom existe déjà.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                bd.InsDelUpd("INSERT INTO tbl_emplacement_inventaire VALUES (null, '" & ConvertirApostrophe(StrConv(txt_nom_emplacement.Text.Trim, VbStrConv.ProperCase)) & "', '" & ConvertirApostrophe(txt_remarque.Text.Trim) & "', true)")
                animation.Lancement(timer_succes, lbl_ajoutSucces, "L'emplacement a été ajouté à la base de données.", cls_animation_operation.Reussie)
                MAJ()
                Changer_Enabled()
                btn_modifier.Enabled = True
                btnReinitialiser.Enabled = True
                btn_ajouter.Text = "Ajouter"
            End If
        Catch ex As Exception
            animation.Lancement(timer_succes, lbl_ajoutSucces, "L'emplacement n'a pas pu être ajouté.", cls_animation_operation.Echec)
        End Try
    End Sub
#End Region
    '
    '
    '
    '
    '
#Region "Modifier un emplacement"
    Private Sub btn_modifier_Click(sender As Object, e As EventArgs) Handles btn_modifier.Click
        If sender.text = "Modifier" Then
            Changer_Enabled()
            btn_ajouter.Enabled = False
            btnReinitialiser.Enabled = False
            btn_activer.Enabled = False
            btn_desactiver.Enabled = False
            txt_nom_emplacement.Focus()
            btn_modifier.Text = "Enregistrer"

        ElseIf Nom_OK(txt_nom_emplacement.Text) Then
            Modifier()
        End If
    End Sub

    Sub Modifier()
        Try
            Dim id_temp As String = Trouver_ID_Emplacement(nom)

            If Existe_Deja(txt_nom_emplacement.Text) And Trouver_ID_Emplacement(txt_nom_emplacement.Text) <> id_temp Then
                MessageBox.Show("Un emplacement de ce nom existe déjà.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                bd.InsDelUpd("UPDATE tbl_emplacement_inventaire SET nom_emplacement = '" & ConvertirApostrophe(txt_nom_emplacement.Text.Trim) & "', remarque = '" & ConvertirApostrophe(txt_remarque.Text.Trim) &
                             "' WHERE no_emplacement = '" & id_temp & "'")
                animation.Lancement(timer_succes, lbl_ajoutSucces, "L'emplacement a été modifié.", cls_animation_operation.Reussie)
                MAJ()
                Changer_Enabled()
                btn_ajouter.Enabled = True
                btnReinitialiser.Enabled = True
                btn_modifier.Text = "Modifier"
            End If
        Catch ex As Exception
            animation.Lancement(timer_succes, lbl_ajoutSucces, "L'emplacement n'a pas été modifié.", cls_animation_operation.Echec)
        End Try

    End Sub
#End Region
    '
    '
    '
    '
    '
#Region "Recherches"
    Function Filtrer_Actifs(etat As String) As String
        If etat = "Actif" Then
            Return " WHERE actif = true"
        ElseIf etat = "Inactif" Then
            Return " WHERE actif = false"
        Else
            Return " WHERE actif IN (true, false)"
        End If
    End Function

    Sub Rechercher()
        Dim requete As String = "SELECT nom_emplacement, remarque, actif FROM tbl_emplacement_inventaire" & Filtrer_Actifs(cbo_trier_activite.Text) &
                                 Rechercher_Selon_Contenu("nom_emplacement", cbo_nom_contient, ConvertirApostrophe(txt_rech_nom.Text)) &
                                 Verifier_Tri("nom_emplacement", cbo_ordre.Text)
        bd.miseAjourDS(ds, da, requete, "tbl_emplacement_inventaire")
        Remplir_Emplacements()
        Verification_Lignes()
    End Sub

    Private Sub txt_rech_nom_TextChanged(sender As Object, e As EventArgs) Handles txt_rech_nom.TextChanged
        Rechercher()
    End Sub

    Private Sub txt_rech_nom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_rech_nom.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnReinitialiser_Click(sender As Object, e As EventArgs) Handles btnReinitialiser.Click
        Initialiser()
    End Sub

    Private Sub cbo_ordre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_ordre.SelectedIndexChanged, cbo_nom_contient.SelectedIndexChanged, cbo_trier_activite.SelectedIndexChanged
        Rechercher()
    End Sub
#End Region
    '
    '
    '
    '
    '
#Region "Autres"
    Private Sub timer_succes_Tick(sender As Timer, e As EventArgs) Handles timer_succes.Tick
        animation.Operation(sender, lbl_ajoutSucces)
    End Sub

    Sub Changer_Enabled()
        dgv_emplacements.Enabled = Not dgv_emplacements.Enabled
        pnl_recherches.Enabled = Not pnl_recherches.Enabled
        pnl_controlGrid.Enabled = Not pnl_controlGrid.Enabled
        btnReinitialiser.Enabled = Not btnReinitialiser.Enabled
        btn_annuler.Enabled = Not btn_annuler.Enabled
    End Sub

    Sub Visualiser(nom As String)
        Dim _ds As New DataSet
        bd.Requete("SELECT nom_emplacement, remarque FROM tbl_emplacement_inventaire WHERE nom_emplacement = '" & ConvertirApostrophe(nom.Trim) & "'", _ds, da, "tbl_emplacement_inventaire")
        txt_nom_emplacement.Text = _ds.Tables(0).Rows(0).Item(0)
        txt_remarque.Text = _ds.Tables(0).Rows(0).Item(1)
    End Sub

    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        If MessageBox.Show("Désirez-vous annuler cette opération?", "Annuler", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Changer_Enabled()
            btn_ajouter.Text = "Ajouter"
            btn_modifier.Text = "Modifier"
            btnReinitialiser.Enabled = True
            btn_modifier.Enabled = True
            btn_ajouter.Enabled = True
            MAJ()
        End If
    End Sub
#End Region

End Class
