Imports MySql.Data.MySqlClient

Public Class usr_associer_utls_cours
    'Attributs reliés à la gestion de la bd.'
    Dim strRequete As String
    Dim table As String
    Dim gestionBd As New Connexion
    Dim dataAdapter As New MySqlDataAdapter
    Dim dsUtls As DataSet
    Dim dsEtuCours As DataSet

    Dim noCours As String
    Dim animation As New cls_animation_operation

    Dim changement As Boolean


    Public Sub New(cours As String)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        noCours = cours
        rd_nm.Checked = True
    End Sub

    'User load.'
    Private Sub usr_gestion_cours_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbl_associer.Text = "Associer des étudiants au cours " & noCours
        MAJ()
    End Sub

    'MAJ'
    Private Sub MAJ()
        Cursor = Cursors.AppStarting
        RecupererEtu()
        RecupererEtuCours()
        RemplirEtu()
        RemplirEtuCours()

        DesactiverTransf()
        Cursor = Cursors.Default
    End Sub

    'Bouton vers la droite (envoie les éléments sélectionnés vers la droite).'
    Private Sub btn_versDroit_Click(sender As Object, e As EventArgs) Handles btn_versDroit.Click
        Dim listEtu As List(Of Utilisateur) = RecupererSelectionner(grid_etu)
        Dim succes As Boolean = True

        Cursor = Cursors.AppStarting
        For i As Integer = 0 To listEtu.Count - 1
            grid_etu_cours.Rows.Add(listEtu.Item(i).No_id, listEtu.Item(i).Nom_personne)

            strRequete = "INSERT INTO `tbl_cours_utilisateur`VALUES ('" & listEtu.Item(i).No_id & "','" & noCours & "');"

            Try
                gestionBd.InsDelUpd(strRequete)
            Catch ex As Exception
                succes = False
                animation.Lancement(timer_animation, lbl_ajoutSucces, "Erreur lors du Transfert.", cls_animation_operation.Echec)
            End Try
        Next
        Cursor = Cursors.Default

        If succes Then
            animation.Lancement(timer_animation, lbl_ajoutSucces, "Transfert réussi.")
        Else
            animation.Lancement(timer_animation, lbl_ajoutSucces, "Erreur lors du Transfert.", cls_animation_operation.Echec)
        End If

        DesactiverTransf()
    End Sub

    'Bouton vers la gauche (envoie les éléments sélectionnés vers la gauche).'
    Private Sub btn_versGauche_Click(sender As Object, e As EventArgs) Handles btn_versGauche.Click
        Dim listEtu As List(Of Utilisateur) = RecupererSelectionner(grid_etu_cours)
        Dim succes As Boolean = True

        Cursor = Cursors.AppStarting
        For i As Integer = 0 To listEtu.Count - 1
            grid_etu.Rows.Add(listEtu.Item(i).No_id, listEtu.Item(i).Nom_personne)

            strRequete = "DELETE FROM `tbl_cours_utilisateur` 
                          WHERE `no_cours` = '" & noCours & "'
                          and `no_utilisateur` = '" & listEtu.Item(i).No_id & "';"

            Try
                gestionBd.InsDelUpd(strRequete)

            Catch ex As Exception
                succes = False
                animation.Lancement(timer_animation, lbl_ajoutSucces, "Erreur lors du Transfert.", cls_animation_operation.Echec)
            End Try
        Next
        Cursor = Cursors.Default
        If succes Then
            animation.Lancement(timer_animation, lbl_ajoutSucces, "Transfert réussi.")
        Else
            animation.Lancement(timer_animation, lbl_ajoutSucces, "Erreur lors du Transfert.", cls_animation_operation.Echec)
        End If


        DesactiverTransf()
    End Sub

    'Récupère les utilisateurs sélectionnés (et les met dans une liste).'
    Private Function RecupererSelectionner(grid As DataGridView) As List(Of Utilisateur)
        Dim utls_temp As Utilisateur
        Dim list_utls As New List(Of Utilisateur)

        For i As Integer = grid.SelectedRows.Count - 1 To 0 Step -1
            With grid.SelectedRows(i)
                utls_temp = New Utilisateur(.Cells(0).Value, .Cells(1).Value)
                list_utls.Add(utls_temp)
                grid.Rows.RemoveAt(grid.SelectedRows(i).Index)
            End With
        Next


        Return list_utls
    End Function



#Region "Remplissage de contrôles"
    'Récupère tous les étudiants de la bd.'
    Private Sub RecupererEtu()
        strRequete = "Select `no_utilisateur`, concat(`prenom_personne`,concat(', ',`nom_personne`)) as nom FROM `tbl_utilisateurs` u
                      where `titre` = 'e'
                      and `no_utilisateur` not in (select `no_utilisateur` from `tbl_cours_utilisateur` where `no_cours` like '" & noCours.Substring(0, 10) & "%') and u.`actif` = 1"

        If rd_utls.Checked Then
            strRequete &= " and `no_utilisateur` like '" & mod_regex.ConvertirApostrophe(txt_recherche.Text.Trim) & "%';"
        ElseIf rd_nm.Checked Then
            strRequete &= " and (u.`prenom_personne` Like '" & mod_regex.ConvertirApostrophe(txt_recherche.Text.Trim) & "%' 
                                Or u.`nom_personne` Like '" & mod_regex.ConvertirApostrophe(txt_recherche.Text.Trim) & "%'
                                Or (replace(concat(u.`prenom_personne`,u.`nom_personne`), ' ', '') like '" & mod_regex.ConvertirApostrophe(txt_recherche.Text.Trim.Replace(" ", "").Replace(",", "")) & "%'))"
        End If

        table = "tbl_utilisateurs"
        gestionBd.miseAjourDS(dsUtls, dataAdapter, strRequete, table)
    End Sub


    'Récupère tous les étudiants d'un certain cours.'
    Private Sub RecupererEtuCours()
        strRequete = "Select u.`no_utilisateur`, concat(u.`prenom_personne`,concat(', ',u.`nom_personne`)) FROM `tbl_utilisateurs` u, `tbl_cours_utilisateur` c
                      where u.`no_utilisateur` = c.`no_utilisateur`
                      and `no_cours` = '" & noCours & "'
                      and `titre` = 'e'
                      and u.`actif` = 1"

        If rd_utls.Checked Then
            strRequete &= " and u.`no_utilisateur` like '" & mod_regex.ConvertirApostrophe(txt_recherche.Text.Trim) & "%'"
        ElseIf rd_nm.Checked Then
            strRequete &= " and (`prenom_personne` like '" & mod_regex.ConvertirApostrophe(txt_recherche.Text.Trim) & "%' 
                                    or `nom_personne` like '" & mod_regex.ConvertirApostrophe(txt_recherche.Text.Trim) & "%'
                                    or (replace(concat(`prenom_personne`,concat(',',`nom_personne`)), ' ', '') like '" & mod_regex.ConvertirApostrophe(txt_recherche.Text.Replace(" ", "")) & "%'))"
        End If

        table = "tbl_utilisateurs"
        gestionBd.miseAjourDS(dsEtuCours, dataAdapter, strRequete, table)
    End Sub

    'Remplis les datagrids.'
    Private Sub RemplirEtu()
        grid_etu.Rows.Clear()
        With dsUtls.Tables(0)
            For i As Integer = 0 To .Rows.Count - 1
                grid_etu.Rows.Add(.Rows(i).Item(0))
                grid_etu.Rows(grid_etu.Rows.Count - 1).Cells(1).Value = .Rows(i).Item(1)
            Next
        End With
    End Sub

    Private Sub RemplirEtuCours()
        grid_etu_cours.Rows.Clear()
        With dsEtuCours.Tables(0)
            For i As Integer = 0 To .Rows.Count - 1
                grid_etu_cours.Rows.Add(.Rows(i).Item(0))
                grid_etu_cours.Rows(grid_etu_cours.Rows.Count - 1).Cells(1).Value = .Rows(i).Item(1)
            Next
        End With
    End Sub

#End Region

#Region "Recherche"
    'Lance la maj au textchanged de la barre de recherche.'
    Private Sub txt_recherche_TextChanged(sender As Object, e As EventArgs) Handles txt_recherche.TextChanged, rd_nm.CheckedChanged, rd_utls.CheckedChanged
        MAJ()
    End Sub
#End Region

#Region "autres"

    'Bouton sélectionner tout.'
    Private Sub Button1_Click(sender As Button, e As EventArgs) Handles btn_selection.Click, btn_selection2.Click
        Dim selection As Boolean
        If sender.Text = "Sélectionner tout" Then
            sender.Text = "Déselectionner tout"
            selection = True
        Else
            sender.Text = "Sélectionner tout"
            selection = False
        End If

        If sender.Tag = 1 Then
            With grid_etu
                For i As Integer = 0 To .Rows.Count - 1
                    .Rows(i).Selected = selection
                Next
            End With
        Else
            With grid_etu_cours
                For i As Integer = 0 To .Rows.Count - 1
                    .Rows(i).Selected = selection
                Next
            End With
        End If

    End Sub


    'Animation!'
    Private Sub timer_animation_Tick(sender As Object, e As EventArgs) Handles timer_animation.Tick
        animation.Operation(timer_animation, lbl_ajoutSucces)
    End Sub

    'Désactive les Boutons de transfer si besoin.'
    Private Sub DesactiverTransf()
        If grid_etu.Rows.Count = 0 Then
            btn_versDroit.Enabled = False
        Else
            btn_versDroit.Enabled = True
        End If

        If grid_etu_cours.Rows.Count = 0 Then
            btn_versGauche.Enabled = False
        Else
            btn_versGauche.Enabled = True
        End If
    End Sub

    'Change la couleur quand on passe la souris sur le grid_cours.'
    Private Sub grid_utls_CellMouseLeave(sender As DataGridView, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_etu.CellMouseLeave, grid_etu_cours.CellMouseLeave
        If sender.Name = grid_etu.Name Then
            If e.RowIndex > -1 Then
                grid_etu.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
            End If
        Else
            If e.RowIndex > -1 Then
                grid_etu_cours.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
            End If
        End If
    End Sub

    'Change la couleur quand on passe la souris sur le grid_cours.'
    Private Sub grid_utls_CellMouseEnter(sender As DataGridView, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_etu.CellMouseEnter, grid_etu_cours.CellMouseEnter
        If sender.Name = grid_etu.Name Then
            If e.RowIndex > -1 Then
                grid_etu.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(236, 240, 241)
            End If
        Else
            If e.RowIndex > -1 Then
                grid_etu_cours.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(236, 240, 241)
            End If
        End If
    End Sub

    'Couleur des boutons.'
    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btn_retour.MouseEnter, btn_versDroit.MouseEnter, btn_versGauche.MouseEnter, btn_selection.MouseEnter, btn_selection2.MouseEnter

        sender.BackColor = Color.White
        sender.ForeColor = Color.Black
    End Sub

    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btn_retour.MouseLeave, btn_versDroit.MouseLeave, btn_versGauche.MouseLeave, btn_selection.MouseLeave, btn_selection2.MouseLeave

        sender.BackColor = Color.FromArgb(52, 73, 94)
        sender.ForeColor = SystemColors.Control
    End Sub

    'Bouton retour.'
    Private Sub btn_retour_Click(sender As Object, e As EventArgs) Handles btn_retour.Click
        Me.Hide()
    End Sub

    Private Sub grid_utls_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles grid_etu.CellMouseEnter, grid_etu_cours.CellMouseEnter

    End Sub

    Private Sub grid_utls_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles grid_etu.CellMouseLeave, grid_etu_cours.CellMouseLeave

    End Sub

    Private Sub btn_MouseEnter(sender As Object, e As EventArgs) Handles btn_versGauche.MouseEnter, btn_versDroit.MouseEnter, btn_retour.MouseEnter, btn_selection2.MouseEnter, btn_selection.MouseEnter

    End Sub

    Private Sub btn_MouseLeave(sender As Object, e As EventArgs) Handles btn_versGauche.MouseLeave, btn_versDroit.MouseLeave, btn_retour.MouseLeave, btn_selection2.MouseLeave, btn_selection.MouseLeave

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_selection2.Click, btn_selection.Click

    End Sub

    Private Sub grid_etu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_etu.CellContentClick

    End Sub

#End Region

End Class
