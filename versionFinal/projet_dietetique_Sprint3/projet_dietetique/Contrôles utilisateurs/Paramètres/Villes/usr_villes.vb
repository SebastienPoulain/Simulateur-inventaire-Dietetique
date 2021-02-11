Imports System.Data.Sql
Imports MySql.Data.MySqlClient

' PIERRE-OLIVIER DUBOIS-NADEAU

Public Class usr_villes

    Dim dataTable = New DataTable
    Dim da_recherche As New MySqlDataAdapter
    Dim ds_recherche As DataSet
    Dim gestionBd As New Connexion
    Dim animation As New cls_animation_operation
    Dim str_requete_ville As String = ""

    Private Sub usr_gestion_villes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnReinitialiser.PerformClick()

    End Sub


    Public Sub rechercher_ville()



        str_requete_ville = "select nom_ville as 'nom de la ville', actif from tbl_ville
        " & verifier_activite_combobox(cbo_trier_activite) & Rechercher_Selon_Contenu("nom_ville", cbo_nom_contient, ConvertirApostrophe(txt_rech_nom.Text.Trim)) & " ORDER BY nom_ville " & Verifier_Ordre(ConvertirApostrophe(cbo_ordre.Text.Trim))


        gestionBd.miseAjourDS(ds_recherche, da_recherche, str_requete_ville, "tbl_ville")

        If ds_recherche.Tables(0).Rows.Count = 0 Then

            btn_modifier_ville.Enabled = False
            btn_desac_ville.Enabled = False
            btn_ajouter_ville.Enabled = True
            btn_annuler_ville.Enabled = False
            btn_activer_ville.Enabled = False

        Else

            btn_modifier_ville.Enabled = True
            btn_desac_ville.Enabled = True
            btn_ajouter_ville.Enabled = True

            btn_activer_ville.Enabled = True


        End If


        RemplirGrid()
    End Sub



    Public Sub remplir_controles()

        If dgv_formats.Rows.Count <> 0 Then
            txt_nom_ville.Text = dgv_formats.CurrentRow.Cells(0).Value

            btn_modifier_ville.Enabled = True


        Else

            btn_modifier_ville.Enabled = False

            reinitialiser_controle()
        End If
    End Sub



    Sub Initialiser_Controles()
        Dim tab_cbo() As ComboBox = {cbo_nom_contient, cbo_ordre, cbo_trier_activite}
        For i = 0 To tab_cbo.Count - 1
            tab_cbo(i).SelectedIndex = 0
        Next

        txt_rech_nom.Text = ""

    End Sub

    Private Sub btnReinitialiser_Click(sender As Object, e As EventArgs) Handles btnReinitialiser.Click

        Initialiser_Controles()
        MAJ()

    End Sub


    Public Sub MAJ()

        rechercher_ville()
        remplir_controles()
        gestionBtn()



    End Sub


    Private Sub btn_Click_ville(sender As Object, e As EventArgs) Handles btn_ajouter_ville.Click, btn_modifier_ville.Click, btn_annuler_ville.Click
        Dim btn As Button = sender

        Select Case btn.Text
            Case btn_ajouter_ville.Text
                ajouter_ville()
            Case btn_modifier_ville.Text
                Modifier_ville()

            Case btn_annuler_ville.Text
                Annuler_ville()

        End Select

    End Sub


    Public Sub ajouter_ville()



        If btn_ajouter_ville.Text = "Ajouter" Then
            'Active/désactive les boutons.'
            btn_ajouter_ville.Text = "Enregistrer"
            btn_modifier_ville.Enabled = False
            btn_annuler_ville.Enabled = True
            btn_activer_ville.Enabled = False
            btn_desac_ville.Enabled = False

            InverserControle()
            reinitialiser_controle()



        Else
            If verifier_label(lbE_nom_ville) Then
                If (verifier_nom_textbox_vide(txt_nom_ville, lbE_nom_ville, "Saisissez un nom de ville")) Then
                    If verifier_nom_ville_bd() Then

                        Dim succes As Boolean = True

                        ' Ajout du format.'
                        Try
                            str_requete_ville = "INSERT INTO tbl_ville(nom_ville, actif)VALUES( '" & StrConv(mod_regex.ConvertirApostrophe(txt_nom_ville.Text.Trim), VbStrConv.ProperCase) & "',1)"

                            gestionBd.InsDelUpd(str_requete_ville)
                        Catch e As Exception
                            succes = False
                        End Try

                        If succes Then
                            animation.Lancement(timer_succes, lbl_ajoutSucces, "La ville a été ajoutée.", cls_animation_operation.Reussie)
                        Else
                            animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de l'ajout de la ville.", cls_animation_operation.Echec)
                        End If


                        'Active/désactive les boutons.'
                        btn_ajouter_ville.Text = "Ajouter"
                        btn_modifier_ville.Enabled = True
                        btn_annuler_ville.Enabled = False
                        InverserControle()
                        gestionBtn()
                        MAJ()
                    End If
                End If

            End If

        End If
    End Sub

    Public Sub Modifier_ville()
        If btn_modifier_ville.Text = "Modifier" Then
            'Active/désactive les boutons.'ann
            btn_modifier_ville.Text = "Enregistrer"
            btn_ajouter_ville.Enabled = False
            btn_annuler_ville.Enabled = True
            btn_activer_ville.Enabled = False
            btn_desac_ville.Enabled = False

            InverserControle()


        Else
            If verifier_label(lbE_nom_ville) Then
                If (verifier_nom_textbox_vide(txt_nom_ville, lbE_nom_ville, "Saisissez un nom de ville")) Then

                    If verifier_nom_ville_bd() Then
                        Dim succes As Boolean = True

                        'Requetes vers la bd.'
                        Try
                            str_requete_ville = "UPDATE tbl_ville Set nom_ville = '" & StrConv(mod_regex.ConvertirApostrophe(txt_nom_ville.Text.Trim), VbStrConv.ProperCase) & "' 
where nom_ville = '" & StrConv(mod_regex.ConvertirApostrophe(dgv_formats.CurrentRow.Cells(0).Value.Trim), VbStrConv.ProperCase) & "'"

                            gestionBd.InsDelUpd(str_requete_ville)
                        Catch e As Exception
                            succes = False
                        End Try


                        If succes Then
                            animation.Lancement(timer_succes, lbl_ajoutSucces, "La ville a été modifiée.", cls_animation_operation.Reussie)
                        Else
                            animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de la modification de la ville.", cls_animation_operation.Echec)
                        End If



                    End If




                End If
                btn_modifier_ville.Text = "Modifier"
                btn_ajouter_ville.Enabled = True
                btn_annuler_ville.Enabled = False
                InverserControle()
                gestionBtn()
                MAJ()
            End If
        End If


    End Sub


    Public Sub Annuler_ville()
        lbE_nom_ville.Visible = False
        btn_ajouter_ville.Text = "Ajouter"
        btn_modifier_ville.Text = "Modifier"
        btn_ajouter_ville.Enabled = True
        btn_modifier_ville.Enabled = True
        btn_annuler_ville.Enabled = False
        btn_activer_ville.Enabled = True
        btn_modifier_ville.Enabled = True


        InverserControle()

        remplir_controles()
        gestionBtn()



    End Sub


    Public Function verifier_nom_textbox_vide(verif_textbox As TextBox, lb_erreur As Label, msg_erreur As String) As Boolean

        If verif_textbox.Text.Trim <> "" Then


            lb_erreur.Visible = False
            Return True
        Else
            lb_erreur.Text = msg_erreur
            lb_erreur.Visible = True
            Return False
        End If

    End Function


    Public Function verifier_nom_ville_bd() As Boolean

        str_requete_ville = "select nom_ville from tbl_ville where nom_ville = '" & StrConv(mod_regex.ConvertirApostrophe(txt_nom_ville.Text.Trim), VbStrConv.ProperCase) & "'"

        gestionBd.miseAjourDS(ds_recherche, da_recherche, str_requete_ville, "tbl_ville")

        If ds_recherche.Tables(0).Rows.Count = 0 Then
            lbE_nom_ville.Visible = False
            Return True
        Else
            lbE_nom_ville.Text = "Le nom de la ville existe déja"
            lbE_nom_ville.Visible = True
            Return False
        End If


    End Function

    Public Sub reinitialiser_controle()

        txt_nom_ville.Text = ""

    End Sub




    Private Sub gestionBtn()
        If dgv_formats.Rows.Count > 0 Then

            If dgv_formats.CurrentRow.Cells(0).Tag = 0 Then
                btn_activer_ville.Enabled = True
                btn_desac_ville.Enabled = False

            Else
                btn_activer_ville.Enabled = False
                btn_desac_ville.Enabled = True

            End If
        Else
            btn_activer_ville.Enabled = False
            btn_desac_ville.Enabled = False

        End If
    End Sub



    Private Sub RemplirGrid()
        dgv_formats.Rows.Clear()
        With ds_recherche.Tables(0)
            For i As Integer = 0 To .Rows.Count - 1
                dgv_formats.Rows.Add(.Rows(i).Item(0))




                If .Rows(i).Item(1) = 0 Then
                    dgv_formats.Rows(dgv_formats.Rows.Count - 1).Cells(0).Tag = "0"
                    For j As Integer = 0 To 0
                        dgv_formats.Rows(dgv_formats.Rows.Count - 1).Cells(j).Style.ForeColor = Color.DimGray
                    Next
                Else
                    dgv_formats.Rows(dgv_formats.Rows.Count - 1).Cells(0).Tag = "1"
                End If
            Next
        End With
    End Sub


    Private Sub InverserControle()
        txt_nom_ville.Enabled = Not txt_nom_ville.Enabled
        dgv_formats.Enabled = Not dgv_formats.Enabled
    End Sub

    'Activer.'
    Private Sub btn_activer_Click(sender As Object, e As EventArgs) Handles btn_activer_ville.Click
        If MessageBox.Show("Voulez-vous activer la ville sélectionnée?",
                          "Activer une ville",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then


            Cursor = Cursors.AppStarting
            For i As Integer = 0 To dgv_formats.SelectedRows.Count - 1
                With dgv_formats.SelectedRows(i)
                    str_requete_ville = "UPDATE `tbl_ville` 
                                      SET `actif` = 1
                                      WHERE `nom_ville` = '" & StrConv(mod_regex.ConvertirApostrophe(.Cells(0).Value.Trim), VbStrConv.ProperCase) & "';"



                    Try
                        gestionBd.InsDelUpd(str_requete_ville)
                        animation.Lancement(timer_succes, lbl_ajoutSucces, "Activation réussie.", cls_animation_operation.Reussie)
                    Catch ex As Exception
                        animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de l'activation.", cls_animation_operation.Echec)
                    End Try
                End With
            Next
            Cursor = Cursors.Default


            MAJ()
        End If
    End Sub

    'Désactiver.'
    Private Sub btn_desactiver_Click(sender As Object, e As EventArgs) Handles btn_desac_ville.Click
        If MessageBox.Show("Voulez-vous désactiver la ville sélectionnée?",
                          "Désactiver une ville",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then



            Cursor = Cursors.AppStarting
            For i As Integer = 0 To dgv_formats.SelectedRows.Count - 1
                With dgv_formats.SelectedRows(i)
                    str_requete_ville = "UPDATE `tbl_ville` 
                                      SET `actif` = 0
                                      WHERE `nom_ville` = '" & StrConv(mod_regex.ConvertirApostrophe(.Cells(0).Value.Trim), VbStrConv.ProperCase) & "';"

                    Try
                        gestionBd.InsDelUpd(str_requete_ville)
                        animation.Lancement(timer_succes, lbl_ajoutSucces, "Activation réussie.", cls_animation_operation.Reussie)
                    Catch ex As Exception
                        animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de l'activation.", cls_animation_operation.Echec)
                    End Try
                End With
            Next
            Cursor = Cursors.Default


            MAJ()
        End If
    End Sub

    Private Sub dgv_ville_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_formats.SelectionChanged

        gestionBtn()
    End Sub




    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btn_ajouter_ville.MouseEnter, btn_annuler_ville.MouseEnter, btn_modifier_ville.MouseEnter, btn_activer_ville.MouseEnter, btn_desac_ville.MouseEnter
        sender.BackColor = Color.White
        sender.ForeColor = Color.Black
    End Sub


    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btn_ajouter_ville.MouseLeave, btn_annuler_ville.MouseLeave, btn_modifier_ville.MouseLeave, btn_activer_ville.MouseLeave, btn_desac_ville.MouseLeave
        If sender.Text = btn_annuler_ville.Text Then
            sender.BackColor = Color.DimGray
            sender.ForeColor = SystemColors.Control

        Else
            sender.BackColor = Color.FromArgb(52, 73, 94)
            sender.ForeColor = SystemColors.Control
        End If
    End Sub


    'Change la couleur quand on passe la souris sur le grid_cours.'
    Private Sub dgv_ville_CellMouseLeave(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_formats.CellMouseLeave
        If e.RowIndex > -1 Then
            dgv_formats.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
            dgv_formats.Rows(e.RowIndex).DefaultCellStyle.ForeColor = DefaultForeColor
        End If
    End Sub

    'Change la couleur quand on passe la souris sur le grid_cours.'
    Private Sub dgv_ville_CellMouseEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_formats.CellMouseEnter
        If e.RowIndex > -1 Then
            dgv_formats.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(236, 240, 241)
        End If
    End Sub

    Private Sub format_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_ordre.SelectedIndexChanged, cbo_nom_contient.SelectedIndexChanged, cbo_trier_activite.SelectedIndexChanged, txt_rech_nom.TextChanged

        MAJ()

    End Sub

    Private Sub txt_mouse_leave(sender As Object, e As EventArgs) Handles txt_nom_ville.MouseLeave
    End Sub

    Private Sub timer_succes_Tick(sender As Timer, e As EventArgs) Handles timer_succes.Tick
        animation.Operation(sender, lbl_ajoutSucces)
    End Sub

    Private Sub dgv_ville_Click(sender As Object, e As EventArgs) Handles dgv_formats.Click
        remplir_controles()
    End Sub



    Private Sub txt_nom_ville_TextChanged(sender As Object, e As EventArgs) Handles txt_nom_ville.TextChanged

        message_erreur(sender)
    End Sub


    Public Sub message_erreur(sender As Object)

        If sender.text.trim <> "" Then
            If Nom(sender.text.trim) Then

                lbE_nom_ville.Visible = False
            Else


                lbE_nom_ville.Text = "Caractère invalide"
                lbE_nom_ville.Visible = True



            End If

        Else




            lbE_nom_ville.Visible = False
        End If




    End Sub

    Public Function verifier_label(nom_label As Label) As Boolean


        If nom_label.Visible = True Then
            Return False

        Else

            Return True

        End If

    End Function
End Class
