Imports MySql.Data.MySqlClient

Public Class usr_exercices_A
    'Attributs reliés à la gestion de la bd.'
    Dim strRequete As String
    Dim table As String
    Dim gestionBd As New Connexion
    Dim dataAdapter As New MySqlDataAdapter
    Dim dsEx As DataSet

    Dim animation As New cls_animation_operation
    ''' <summary>
    ''' Méthode load , changement de l'index de la combo box type et statut pour 4 et 2 ce qui correspond à tous.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>

    Private Sub usr_exercices_A_Load(sender As Object, e As EventArgs) Handles Me.Load
        cbo_type.SelectedIndex = 4
        cbo_statut.SelectedIndex = 2
        maj()
        gestionBtn()
    End Sub

#Region "Activer/desac/suppr"
    Private Sub grid_ex_SelectionChanged(sender As Object, e As EventArgs) Handles grid_ex.SelectionChanged
        gestionBtn()
    End Sub

    'Gestion des boutons activer/désactiver/supprimer.'
    Private Sub gestionBtn()
        If grid_ex.Rows.Count > 0 Then
            Dim trouver As Boolean
            Dim i As Integer = 0

            While trouver = False And i < grid_ex.SelectedRows.Count
                If grid_ex.SelectedRows(i).Cells(0).Tag = 1 Then
                    trouver = True
                    btn_activer.Enabled = False
                    btn_desac.Enabled = True
                Else
                    i += 1
                End If
            End While

            If Not trouver Then
                btn_activer.Enabled = True
                btn_desac.Enabled = False
            End If
        Else
            btn_activer.Enabled = False
            btn_desac.Enabled = False
        End If
    End Sub

    'Activer.'
    Private Sub btn_activer_Click(sender As Object, e As EventArgs) Handles btn_activer.Click
        If MessageBox.Show("Voulez-vous réactiver les exercices sélectionnés?",
                          "Activer des exercices",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim echec As String = ""


            Cursor = Cursors.AppStarting
            For i As Integer = 0 To grid_ex.SelectedRows.Count - 1
                With grid_ex.SelectedRows(i)
                    strRequete = "UPDATE `tbl_exercices` 
                                  SET `actif`= 1
                                  WHERE `no_exercice` = " & .Cells(0).Value & ";"

                    Try
                        gestionBd.InsDelUpd(strRequete)
                    Catch ex As Exception
                        echec &= " " & .Cells(0).Value
                    End Try
                End With
            Next
            Cursor = Cursors.Default


            If echec = "" Then
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Activation réussie.", cls_animation_operation.Reussie)
            Else
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de l'activation.", cls_animation_operation.Echec)
                Debug.WriteLine("Échec de l'activation :" & echec)
            End If



            maj()
        End If
    End Sub


    'Désactiver.'
    Private Sub btn_desac_Click(sender As Object, e As EventArgs) Handles btn_desac.Click
        If MessageBox.Show("Êtes-vous certain de vouloir désactiver les exercices sélectionnés?",
                          "Désactiver des exercices",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim echec As String = ""


            Cursor = Cursors.AppStarting
            For i As Integer = 0 To grid_ex.SelectedRows.Count - 1
                With grid_ex.SelectedRows(i)
                    strRequete = "UPDATE `tbl_exercices` 
                                  SET `actif`= 0, `actif_prof` = 0
                                  WHERE `no_exercice` = " & .Cells(0).Value & ";"

                    Try
                        gestionBd.InsDelUpd(strRequete)
                    Catch ex As Exception
                        echec &= " " & .Cells(0).Value
                    End Try
                End With
            Next
            Cursor = Cursors.Default


            If echec = "" Then
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Désactivation réussie.", cls_animation_operation.Reussie)
            Else
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de la désactivation.", cls_animation_operation.Echec)
                Debug.WriteLine("Échec de la désactivation :" & echec)
            End If


            maj()
        End If
    End Sub

    ''Supprime les utilisateurs sélectionnés.
    'Private Sub btn_supprimer_Click(sender As Object, e As EventArgs) Handles btn_supprimer.Click
    '    If MessageBox.Show("Êtes-vous certain de vouloir supprimer les utilisateurs sélectionnés? (Seul les inactifs seront supprimés)" & vbNewLine & vbNewLine & "La suppression est définitive.",
    '                       "Supprimer des utilisateurs",
    '                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

    '        Dim echec As String = ""

    '        Cursor = Cursors.AppStarting
    '        For i As Integer = 0 To grid_ex.SelectedRows.Count - 1
    '            With grid_ex.SelectedRows(i)
    '                strRequete = "DELETE FROM `tbl_exercices` WHERE `no_exercice` = " & .Cells(0).Value & "
    '                              and `actif` = 0;"

    '                Try
    '                    gestionBd.InsDelUpd(strRequete)
    '                Catch ex As Exception
    '                    echec &= " " & .Cells(0).Value
    '                    MsgBox(ex.Message)
    '                End Try
    '            End With
    '        Next
    '        Cursor = Cursors.Default

    '        If echec = "" Then
    '            animation.Lancement(timer_succes, lbl_ajoutSucces, "Suppression réussie.", cls_animation_operation.Reussie)
    '        Else
    '            animation.Lancement(timer_succes, lbl_ajoutSucces, "Échec de la suppression.", cls_animation_operation.Echec)
    '            MsgBox("Échec de suppression :" & echec)
    '        End If

    '        maj()
    '    End If
    'End Sub
#End Region

#Region "Remplissage"

    'Maj.'
    Private Sub maj()
        RecupererEx()
        RemplirGrid()
    End Sub

    'Lance la recherche.'
    Private Sub recherche_TextChanged(sender As Object, e As EventArgs) Handles txt_recherche.TextChanged, cbo_statut.SelectedIndexChanged, cbo_type.SelectedIndexChanged
        maj()
    End Sub



    ''' <summary>
    ''' Méthode qui récupère tous les exercices et ajout du case 4 qui correspond à rechercher par tous.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>'
    Private Sub RecupererEx()
        strRequete = "SELECT distinct `no_exercice`,ex.`no_cours`, `nom_cours`,concat(u.`prenom_personne`,concat(' ',u.`nom_personne`)) as nom,`nom_travail`, ex.`actif` 
                      FROM `tbl_exercices` ex, `tbl_cours` c, tbl_cours_prof cp, tbl_utilisateurs u
                      WHERE ex.`no_cours`=c.`no_cours` and cp.`no_cours`=c.`no_cours` and cp.no_utilisateur=u.no_utilisateur"
        'Recherches.'
        If txt_recherche.Text.Trim <> "" Then
            Select Case cbo_type.SelectedIndex
                Case 0
                    strRequete &= " and (ex.`no_cours` like '" & mod_regex.ConvertirApostrophe(txt_recherche.Text.Trim) & "%'
                                or replace(ex.`no_cours`, '-', '') like '" & mod_regex.ConvertirApostrophe(txt_recherche.Text.Trim.Replace(" ", "")) & "%')"
                Case 1
                    strRequete &= " and replace(`nom_cours`, ' ', '') like '" & mod_regex.ConvertirApostrophe(txt_recherche.Text.Trim).replace(" ", "") & "%'"
                Case 2
                    strRequete &= " and (u.`prenom_personne` Like '" & mod_regex.ConvertirApostrophe(txt_recherche.Text) & "%' 
                                Or u.`nom_personne` Like '" & mod_regex.ConvertirApostrophe(txt_recherche.Text) & "%'
                                Or (replace(concat(u.`prenom_personne`,u.`nom_personne`), ' ', '') like '" & mod_regex.ConvertirApostrophe(txt_recherche.Text.Replace(" ", "").Replace(",", "")) & "%'))"
                Case 3
                    strRequete &= " And replace(`nom_travail`, ' ', '') Like '" & mod_regex.ConvertirApostrophe(txt_recherche.Text.Trim).replace(" ", "") & "%'"
                Case 4
                    strRequete &= " and ex.`no_cours` like '%" & mod_regex.ConvertirApostrophe(txt_recherche.Text.Trim) & "%' or ex.`no_cours`=c.`no_cours` and cp.`no_cours`=c.`no_cours` and cp.no_utilisateur=u.no_utilisateur and replace(`nom_cours`, ' ', '') like '%" & mod_regex.ConvertirApostrophe(txt_recherche.Text.Trim).replace(" ", "") & "%' or ex.`no_cours`=c.`no_cours` and cp.`no_cours`=c.`no_cours` and cp.no_utilisateur=u.no_utilisateur and replace(concat(u.`prenom_personne`,u.`nom_personne`), ' ', '') like '%" & mod_regex.ConvertirApostrophe(txt_recherche.Text.Replace(" ", "").Replace(",", "")) & "%' or ex.`no_cours`=c.`no_cours` and cp.`no_cours`=c.`no_cours` and cp.no_utilisateur=u.no_utilisateur and replace(`nom_travail`, ' ', '') Like '%" & mod_regex.ConvertirApostrophe(txt_recherche.Text.Trim).replace(" ", "") & "%'"

            End Select
        End If

        'Recherche par statut.'
        If cbo_statut.SelectedIndex = 0 Then
            strRequete &= " AND ex.`actif` = 1"
        ElseIf cbo_statut.SelectedIndex = 1 Then
            strRequete &= " AND ex.`actif` = 0"
        End If

        strRequete &= " Order by ex.`actif` desc;"


        table = "tbl_exercices"

        gestionBd.miseAjourDS(dsEx, dataAdapter, strRequete, table)
    End Sub

    Private Sub RemplirGrid()
        grid_ex.Rows.Clear()
        With dsEx.Tables(0)
            Cursor.Current = Cursors.AppStarting
            For i As Integer = 0 To .Rows.Count - 1
                grid_ex.Rows.Add(.Rows(i).Item(0))
                grid_ex.Rows(grid_ex.Rows.Count - 1).Cells(1).Value = .Rows(i).Item(1)
                grid_ex.Rows(grid_ex.Rows.Count - 1).Cells(2).Value = .Rows(i).Item(2)
                grid_ex.Rows(grid_ex.Rows.Count - 1).Cells(3).Value = .Rows(i).Item(3)
                grid_ex.Rows(grid_ex.Rows.Count - 1).Cells(4).Value = .Rows(i).Item(4)

                If .Rows(i).Item(5) = 0 Then
                    grid_ex.Rows(grid_ex.Rows.Count - 1).Cells(0).Tag = "0"
                    For j As Integer = 0 To 3
                        grid_ex.Rows(grid_ex.Rows.Count - 1).Cells(j).Style.ForeColor = Color.DimGray
                    Next
                Else
                    grid_ex.Rows(grid_ex.Rows.Count - 1).Cells(0).Tag = "1"
                End If
            Next
            Cursor.Current = Cursors.Default
        End With

        btn_selectionner.Text = "Sélectionner tout"
    End Sub

#End Region

#Region "Autres"
    'Bouton sélectionner tout.'
    Private Sub Button1_Click(sender As Button, e As EventArgs) Handles btn_selectionner.Click
        Dim selection As Boolean

        If sender.Text = "Sélectionner tout" Then
            sender.Text = "Déselectionner tout"
            selection = True
        Else
            sender.Text = "Sélectionner tout"
            selection = False
        End If

        With grid_ex
            For i As Integer = 0 To .Rows.Count - 1
                .Rows(i).Selected = selection
            Next
        End With
    End Sub

    'Timer pour les animations réussie.'
    Private Sub timer_succes_Tick(sender As Object, e As EventArgs) Handles timer_succes.Tick
        animation.Operation(sender, lbl_ajoutSucces)
    End Sub


    'Change la couleur quand on passe la souris sur le grid_cours.'
    Private Sub grid_utls_CellMouseLeave(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_ex.CellMouseLeave
        If e.RowIndex > -1 Then
            grid_ex.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
            grid_ex.Rows(e.RowIndex).DefaultCellStyle.ForeColor = DefaultForeColor
        End If
    End Sub

    'Change la couleur quand on passe la souris sur le grid_cours.'
    Private Sub grid_utls_CellMouseEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_ex.CellMouseEnter
        If e.RowIndex > -1 Then
            grid_ex.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(236, 240, 241)
        End If
    End Sub

    'Couleur des boutons.'
    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btn_selectionner.MouseEnter, btn_desac.MouseEnter, btn_activer.MouseEnter

        sender.BackColor = Color.White
        sender.ForeColor = Color.Black
    End Sub

    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btn_selectionner.MouseLeave, btn_desac.MouseLeave, btn_activer.MouseLeave
        If sender.Text = btn_desac.Text Or sender.Text = btn_activer.Text Then
            sender.BackColor = Color.FromArgb(72, 84, 96)
            sender.ForeColor = SystemColors.Control
        Else
            sender.BackColor = Color.FromArgb(52, 73, 94)
            sender.ForeColor = SystemColors.Control
        End If
    End Sub

    Private Sub grid_ex_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_ex.CellContentClick

    End Sub
#End Region
End Class
