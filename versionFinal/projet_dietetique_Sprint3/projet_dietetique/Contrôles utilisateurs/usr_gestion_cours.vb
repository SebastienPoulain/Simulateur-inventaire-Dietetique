Imports MySql.Data.MySqlClient

Public Class usr_gestion_cours
    'Attributs reliés à la gestion de la bd.'
    Dim strRequete As String
    Dim table As String
    Dim gestionBd As New Connexion
    Dim dataAdapter As New MySqlDataAdapter
    Dim dsCours As DataSet

    'Attribut relié à la modification.'
    Dim noCoursTemp As String

    'Attibut relié aux diverses vérifications.'
    Dim verif_enCours As Boolean
    Dim type_verif As String

    'tu peux tu marches pls.'

    'User load.'
    Private Sub usr_gestion_cours_Load(sender As Object, e As EventArgs) Handles Me.Load
        RecupererCours()
        RemplirGrid()
        RemplirControle()
    End Sub

    'Récupère tous les cours de la bd.'
    Private Sub RecupererCours()
        strRequete = "Select `no_cours`, `nom_cours`  from `tbl_cours`;"
        table = "tbl_cours"
        gestionBd.miseAjourDS(dsCours, dataAdapter, strRequete, table)
    End Sub

    'Met à jour les cours du grid.'
    Private Sub MAJ()
        RecupererCours()
        RemplirGrid()
        RemplirControle()
    End Sub
    '
    '
    'Tout ce qui est bonton ajouter, modifier...'
    '
    '
#Region "Boutons de modification"
    'Gestion des boutons ajout, modifier, supprimer et annuler.'
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click, btn_modifier.Click, btn_supprimer.Click, btn_annuler.Click
        Dim btn As Button = sender

        Select Case btn.Text
            Case btn_ajouter.Text
                AjouterCours()
            Case btn_modifier.Text
                ModifierCours()
            Case btn_supprimer.Text
                SupprimerCours()
            Case btn_annuler.Text
                Annuler()
            Case Else
                MsgBox("Something went wrong.")
        End Select

    End Sub

    'Gère l'ajout d'un cours.'
    Private Sub AjouterCours()
        If btn_ajouter.Text = "Ajouter" Then
            'Active/désactive les boutons.'
            btn_ajouter.Text = "Enregistrer"
            btn_modifier.Enabled = False
            btn_supprimer.Enabled = False
            btn_annuler.Enabled = True
            InverserControle()

            'Active les vérifications.'
            type_verif = "ajout"
            verif_enCours = True
            TourVerification(txt_nmCours)
        Else
            'Requete vers la bd.'
            Try
                strRequete = "INSERT INTO `tbl_cours`(`no_cours`, `nom_cours`) VALUES ('" & RecupererNoCoursComposee() &
                         "','" & txt_nmCours.Text & "');"
                gestionBd.InsDelUpd(strRequete)
            Catch e As Exception
                MsgBox("Échec de l'ajout.")
            End Try
            'Désactive les vérifications.'
            type_verif = ""
            verif_enCours = False

            'Active/désactive les boutons.'
            btn_ajouter.Text = "Ajouter"
            btn_modifier.Enabled = True
            btn_supprimer.Enabled = True
            btn_annuler.Enabled = False
            InverserControle()
            MAJ()
        End If
    End Sub

    'Gère la modification d'un cours.'
    Private Sub ModifierCours()
        If btn_modifier.Text = "Modifier" Then
            'Récupère le no de cours pour l'utiliser comme clé lors de l'update.'
            noCoursTemp = RecupererNoCoursComposee()

            'Active/désactive les boutons.'
            btn_modifier.Text = "Enregistrer"
            btn_ajouter.Enabled = False
            btn_supprimer.Enabled = False
            btn_annuler.Enabled = True
            InverserControle()
            grid_cours.Enabled = False

            'Active les vérifications.'
            type_verif = "modif"
            verif_enCours = True
        Else
            'Requete vers la bd.'
            Try
                strRequete = "UPDATE `tbl_cours` SET `no_cours`='" & RecupererNoCoursComposee() &
                         "',`nom_cours`='" & txt_nmCours.Text & "' WHERE `no_cours`= '" & noCoursTemp & "';"
                gestionBd.InsDelUpd(strRequete)
            Catch e As Exception
                MsgBox("Échec de la modification.")
            End Try
            'Désactive les vérifications.'
            type_verif = ""
            verif_enCours = False

            'Active/désactive les boutons.'
            btn_modifier.Text = "Modifier"
            btn_ajouter.Enabled = True
            btn_supprimer.Enabled = True
            btn_annuler.Enabled = False
            grid_cours.Enabled = True
            InverserControle()
            MAJ()
        End If
    End Sub

    'Gère la suppression d'un cours.'
    Private Sub SupprimerCours()
        If MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce groupe?", "Suppression de groupe",
                           MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

            'Requete vers la bd.'
            Try
                strRequete = "DELETE FROM `tbl_cours` WHERE `no_cours` = '" & RecupererNoCoursComposee() & "';"
                gestionBd.InsDelUpd(strRequete)
            Catch e As Exception
                MsgBox("Échec de la supression.")
            End Try
            MAJ()
        End If
    End Sub

    'Gère l'annulation.'
    Private Sub Annuler()
        'Désactive les vérifications.'
        type_verif = ""
        verif_enCours = False
        lbE_noCours.ForeColor = Color.DarkGray
        lbE_nomCours.Visible = False

        btn_ajouter.Text = "Ajouter"
        btn_modifier.Text = "Modifier"
        btn_ajouter.Enabled = True
        btn_modifier.Enabled = True
        btn_supprimer.Enabled = True
        btn_annuler.Enabled = False
        grid_cours.Enabled = True
        InverserControle()
        MAJ()
    End Sub
#End Region
    '
    '
    'Tout ce qui est remplir le grid_cours ou les contrôles à droite.'
    '
    '
#Region "Remplissage de contrôles"
    'Remplis le grid_cours avec les cours.'
    Private Sub RemplirGrid()
        grid_cours.Rows.Clear()
        With dsCours.Tables(0)
            For i As Integer = 0 To .Rows.Count - 1
                grid_cours.Rows.Add(.Rows(i).Item(0))
                grid_cours.Rows(grid_cours.Rows.Count - 1).Cells(1).Value = .Rows(i).Item(1)
            Next
        End With
    End Sub

    'Quand l'utilisateur clique sur le grid_cours, modifie les infos dans les contrôles.'
    Private Sub grid_cours_Click(sender As Object, e As EventArgs) Handles grid_cours.Click
        RemplirControle()
    End Sub

    'Remplis les contrôles.'
    Private Sub RemplirControle()
        If grid_cours.Rows.Count <> 0 Then
            With grid_cours
                txt_noCours.Text = .Rows(.CurrentRow.Index).Cells(0).Value.ToString.Substring(0, 10)
                nud_groupe.Value = .Rows(.CurrentRow.Index).Cells(0).Value.ToString.Substring(11, 2)
                txt_nmCours.Text = .Rows(.CurrentRow.Index).Cells(1).Value
            End With

            btn_modifier.Enabled = True
            btn_supprimer.Enabled = True
        Else
            btn_modifier.Enabled = False
            btn_supprimer.Enabled = False
            effacerControl()
        End If
    End Sub
#End Region
    '
    '
    'Tout ce qui est vérification.'
    '
    '
#Region "Verification"
    'Cas où les vérifications doivent se produire.'
    Private Sub cours_TextChanged(sender As Object, e As EventArgs) Handles txt_noCours.TextChanged, nud_groupe.ValueChanged, txt_nmCours.TextChanged
        'Permet de faire les vérifications que si on ajoute ou modifie.'
        If verif_enCours Then
            TourVerification(sender)
        End If
    End Sub

    'Cas où les vérifications doivent se produire.'
    Private Sub cours_LostFocus(sender As Object, e As EventArgs) Handles txt_noCours.LostFocus, nud_groupe.LostFocus, txt_nmCours.LostFocus
        'Permet de faire les vérifications que si on ajoute ou modifie.'
        If verif_enCours Then
            TourVerification(sender)
        End If
    End Sub

    'Tour complet des vérifications.'
    Private Sub TourVerification(ctrl As Control)

        Select Case ctrl.Tag
            Case "1"
                If VerifierNoCours() Then
                    lbE_noCours.ForeColor = Color.DarkGray
                Else
                    lbE_noCours.ForeColor = Color.Firebrick
                End If
            Case "3"
                Dim verif As Integer = VerifierNomCours()

                If verif = 1 Then
                    lbE_nomCours.Visible = False
                ElseIf verif = -1 Then
                    lbE_nomCours.Text = "Saisissez un nom de cours"
                    lbE_nomCours.Visible = True
                Else
                    lbE_nomCours.Text = "Un caractère saisie est invalide"
                    lbE_nomCours.Visible = True
                End If
        End Select

        If VerifierNoCours() Then
            If VerifierNomCours() = 1 Then
                If VerifierGroupe() Then
                    Select Case type_verif
                        Case "ajout"
                            btn_ajouter.Enabled = True
                        Case "modif"
                            btn_modifier.Enabled = True
                        Case Else
                            btn_ajouter.Enabled = False
                            btn_modifier.Enabled = False
                    End Select
                    Return
                End If
            End If
        End If

        btn_ajouter.Enabled = False
        btn_modifier.Enabled = False
    End Sub

    'Vérification du no de cours.'
    Private Function VerifierNoCours() As Boolean
        Return mod_regex.NoCours(txt_noCours.Text)
    End Function

    'Vérification du groupe.'
    Private Function VerifierGroupe() As Boolean
        If VerifierNoCours() Then
            RecupererCours()

            If type_verif = "modif" And noCoursTemp = RecupererNoCoursComposee() Then
                Return True
            Else
                Dim i As Integer = 0
                Dim groupe_trouver As Boolean = False
                With dsCours.Tables(0)
                    While i < .Rows.Count And groupe_trouver = False
                        If (RecupererNoCoursComposee() = .Rows(i).Item(0)) Then
                            groupe_trouver = True
                        Else
                            i += 1
                        End If
                    End While

                    If groupe_trouver Then
                        Return False
                    Else Return True
                    End If
                End With
            End If
        End If
        Return False
    End Function

    'Vérification du nom de cours (1 = bon, 0 = caractère invalide et -1 = aucune saisie).'
    Private Function VerifierNomCours() As Integer
        If txt_nmCours.Text.Trim <> "" Then
            If mod_regex.Nom(txt_nmCours.Text) Then
                Return 1
            Else
                Return 0
            End If
        End If
            Return -1
    End Function


#End Region
    '
    '
    '
    '
    '
#Region "Autres"

    'inverse l'enable des contrôles.'
    Private Sub InverserControle()
        txt_nmCours.Enabled = Not txt_nmCours.Enabled
        txt_noCours.Enabled = Not txt_noCours.Enabled
        nud_groupe.Enabled = Not nud_groupe.Enabled
    End Sub

    'Retourne la composition du cours et du groupe.'
    Private Function RecupererNoCoursComposee()
        Return txt_noCours.Text.ToUpper & "-" & nud_groupe.Value.ToString.PadLeft(2, "0")
    End Function

    'Change la couleur quand on passe la souris sur le grid_cours.'
    Private Sub grid_cours_CellMouseLeave(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_cours.CellMouseLeave
        If e.RowIndex > -1 Then
            grid_cours.Rows(e.RowIndex).DefaultCellStyle.BackColor = DefaultBackColor
        End If
    End Sub

    'Change la couleur quand on passe la souris sur le grid_cours.'
    Private Sub grid_cours_CellMouseEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_cours.CellMouseEnter
        If e.RowIndex > -1 Then
            grid_cours.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGreen
        End If
    End Sub

    'Efface tous les contrôles.'
    Private Sub effacerControl()
        txt_nmCours.Text = ""
        txt_noCours.Text = ""
        nud_groupe.Value = nud_groupe.Minimum
    End Sub
#End Region
End Class
