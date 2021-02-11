Imports System.Data.Sql
Imports MySql.Data.MySqlClient

' PIERRE-OLIVIER DUBOIS-NADEAU

Public Class usr_unites_mesures

    Dim dataTable = New DataTable
    Dim da_recherche As New MySqlDataAdapter
    Dim ds_recherche As DataSet
    Dim gestionBd As New Connexion
    Dim animation As New cls_animation_operation
    Dim str_requete_unites As String = ""

    Private Sub usr_unites_mesures_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        remplir_cbo_type_mesure()
        btnReinitialiser.PerformClick()


    End Sub


    Public Sub remplir_controles()

        If dgv_unites_mesures.Rows.Count <> 0 Then
            txt_unite_mesure.Text = dgv_unites_mesures.CurrentRow.Cells(0).Value

            cbo_type_mesure.Text = dgv_unites_mesures.CurrentRow.Cells(1).Value
            btn_modifier_unite_mesure.Enabled = True
        Else
            btn_modifier_unite_mesure.Enabled = False
            reinitialiser_controle()
        End If
    End Sub


    Public Sub rechercher_unites_mesures()



        str_requete_unites = "select unite_mesure as 'unites de mesures', type_mesure as 'types de mesures', actif from tbl_unites_mesure
        " & verifier_activite_combobox(cbo_trier_activite) & Rechercher_Selon_Contenu("unite_mesure", cbo_nom_contient, ConvertirApostrophe(txt_rech_nom.Text.Trim)) & Verifier_Tri_unites_mesures(cbo_unite_mesure.Text, ConvertirApostrophe(cbo_ordre.Text.Trim))



        gestionBd.miseAjourDS(ds_recherche, da_recherche, str_requete_unites, "tbl_unites_mesure")

        If ds_recherche.Tables(0).Rows.Count = 0 Then

            btn_modifier_unite_mesure.Enabled = False
            btn_desac_unite_mesure.Enabled = False
            btn_ajouter_unite_mesure.Enabled = True
            btn_annuler_unite_mesure.Enabled = False
            btn_unite_mesure.Enabled = False

        Else

            btn_modifier_unite_mesure.Enabled = True
            btn_desac_unite_mesure.Enabled = True
            btn_ajouter_unite_mesure.Enabled = True

            btn_unite_mesure.Enabled = True


        End If


        RemplirGrid()
    End Sub




    Sub Initialiser_Controles()
        Dim tab_cbo() As ComboBox = {cbo_nom_contient, cbo_ordre, cbo_trier_activite, cbo_unite_mesure}
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

        rechercher_unites_mesures()
        gestionBtn()
        remplir_controles()



    End Sub


    Private Sub btn_Click_unites(sender As Object, e As EventArgs) Handles btn_ajouter_unite_mesure.Click, btn_modifier_unite_mesure.Click, btn_annuler_unite_mesure.Click
        Dim btn As Button = sender

        Select Case btn.Text
            Case btn_ajouter_unite_mesure.Text
                ajouter_unites_mesures()
            Case btn_modifier_unite_mesure.Text
                Modifier_unites_mesures()

            Case btn_annuler_unite_mesure.Text
                Annuler_unites_mesures()

        End Select

    End Sub


    Public Sub ajouter_unites_mesures()
        Dim verif_unite As Boolean = False



        If btn_ajouter_unite_mesure.Text = "Ajouter" Then
            'Active/désactive les boutons.'
            btn_ajouter_unite_mesure.Text = "Enregistrer"
            btn_modifier_unite_mesure.Enabled = False
            btn_annuler_unite_mesure.Enabled = True
            btn_unite_mesure.Enabled = False
            btn_desac_unite_mesure.Enabled = False


            InverserControle()
            reinitialiser_controle()


        Else
            If verifier_label(lbE_unites_mesures) Then
                If verifier_label(lbE_types_mesures) Then

                    If (verifier_nom_textbox_vide(txt_unite_mesure, lbE_unites_mesures, "Saisissez un nom d'unité de mesure.")) Then

                        verif_unite = True

                    End If
                    'Double verification  pour gèrer les deux messages d'erreurs en même temps.
                    If (verifier_nom_combobox_vide(cbo_type_mesure, lbE_types_mesures, "Saisissez ou sélectionnez un type de mesure.") And verif_unite = True) Then



                        If verifier_nom_unites_bd() Then

                            Dim succes As Boolean = True

                            ' Ajout d'unité de mesure.'
                            Try
                                str_requete_unites = "INSERT INTO tbl_unites_mesure(unite_mesure, type_mesure, actif)VALUES( '" & StrConv(mod_regex.ConvertirApostrophe(txt_unite_mesure.Text.Trim), VbStrConv.ProperCase) & "','" & StrConv(mod_regex.ConvertirApostrophe(cbo_type_mesure.Text.Trim), VbStrConv.ProperCase) & "',1)"

                                gestionBd.InsDelUpd(str_requete_unites)
                            Catch e As Exception
                                succes = False
                            End Try

                            If succes Then
                                animation.Lancement(timer_succes, lbl_ajoutSucces, "L'unité de mesure a été ajoutée.", cls_animation_operation.Reussie)
                            Else
                                animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de l'ajout de l'unité de mesure.", cls_animation_operation.Echec)
                            End If


                            'Active/désactive les boutons.'
                            btn_ajouter_unite_mesure.Text = "Ajouter"
                            btn_modifier_unite_mesure.Enabled = True
                            btn_annuler_unite_mesure.Enabled = False
                            InverserControle()
                            gestionBtn()
                            MAJ()
                            remplir_cbo_type_mesure()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub Modifier_unites_mesures()
        If btn_modifier_unite_mesure.Text = "Modifier" Then
            'Active/désactive les boutons.'ann
            btn_modifier_unite_mesure.Text = "Enregistrer"
            btn_ajouter_unite_mesure.Enabled = False
            btn_annuler_unite_mesure.Enabled = True
            btn_unite_mesure.Enabled = False
            btn_desac_unite_mesure.Enabled = False

            InverserControle()


        Else
            If verifier_label(lbE_unites_mesures) Then
                If verifier_label(lbE_types_mesures) Then
                    If (verifier_nom_textbox_vide(txt_unite_mesure, lbE_unites_mesures, "Saisissez un nom d'unité de mesure.")) Then

                    End If

                    If (verifier_nom_combobox_vide(cbo_unite_mesure, lbE_types_mesures, "Saisissez ou sélectionnez un type de mesure.")) Then

                        If verifier_nom_unites_bd() Then
                            Dim succes As Boolean = True

                            'Requetes vers la bd.'
                            Try
                                str_requete_unites = "UPDATE tbl_unites_mesure Set unite_mesure = '" & StrConv(mod_regex.ConvertirApostrophe(txt_unite_mesure.Text.Trim), VbStrConv.ProperCase) & "', type_mesure = '" & StrConv(mod_regex.ConvertirApostrophe(cbo_type_mesure.Text.Trim), VbStrConv.ProperCase) &
                                "' where unite_mesure = '" & StrConv(mod_regex.ConvertirApostrophe(dgv_unites_mesures.CurrentRow.Cells(0).Value.Trim), VbStrConv.ProperCase) & "' and type_mesure = '" & StrConv(mod_regex.ConvertirApostrophe(dgv_unites_mesures.CurrentRow.Cells(1).Value.Trim), VbStrConv.ProperCase) & "'"

                                gestionBd.InsDelUpd(str_requete_unites)
                            Catch e As Exception
                                succes = False
                            End Try


                            If succes Then
                                animation.Lancement(timer_succes, lbl_ajoutSucces, "L'unité de mesure a été modifiée.", cls_animation_operation.Reussie)
                            Else
                                animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de la modification de l'unité de mesure.", cls_animation_operation.Echec)
                            End If




                        Else

                            lbE_unites_mesures.Visible = False
                            Dim succes As Boolean = True

                            'Requetes vers la bd.'
                            Try
                                str_requete_unites = "UPDATE tbl_unites_mesure Set type_mesure = '" & StrConv(mod_regex.ConvertirApostrophe(cbo_type_mesure.Text.Trim), VbStrConv.ProperCase) &
                                "' where unite_mesure = '" & StrConv(mod_regex.ConvertirApostrophe(dgv_unites_mesures.CurrentRow.Cells(0).Value.Trim), VbStrConv.ProperCase) & "'"

                                gestionBd.InsDelUpd(str_requete_unites)
                            Catch e As Exception
                                succes = False
                            End Try


                            If succes Then
                                animation.Lancement(timer_succes, lbl_ajoutSucces, "L'unité de mesure a été modifiée.", cls_animation_operation.Reussie)
                            Else
                                animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de la modification de l'unité de mesure.", cls_animation_operation.Echec)
                            End If


                        End If




                    End If
                    btn_modifier_unite_mesure.Text = "Modifier"
                    btn_ajouter_unite_mesure.Enabled = True
                    btn_annuler_unite_mesure.Enabled = False
                    InverserControle()
                    gestionBtn()
                    MAJ()
                End If
            End If
        End If

    End Sub


    Public Sub Annuler_unites_mesures()
        lbE_unites_mesures.Visible = False
        btn_ajouter_unite_mesure.Text = "Ajouter"
        btn_modifier_unite_mesure.Text = "Modifier"
        btn_ajouter_unite_mesure.Enabled = True
        btn_modifier_unite_mesure.Enabled = True
        btn_annuler_unite_mesure.Enabled = False
        btn_unite_mesure.Enabled = True
        btn_modifier_unite_mesure.Enabled = True

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



    Public Function verifier_nom_combobox_vide(verif_combobox As ComboBox, lb_erreur As Label, msg_erreur As String) As Boolean

        If verif_combobox.Text.Trim <> "" Then

            lb_erreur.Visible = False
            Return True
        Else
            lb_erreur.Text = msg_erreur
            lb_erreur.Visible = True
            Return False
        End If

    End Function


    Public Function verifier_nom_unites_bd() As Boolean

        str_requete_unites = "select unite_mesure from tbl_unites_mesure where unite_mesure = '" & StrConv(mod_regex.ConvertirApostrophe(txt_unite_mesure.Text.Trim), VbStrConv.ProperCase) & "'"

        gestionBd.miseAjourDS(ds_recherche, da_recherche, str_requete_unites, "tbl_unites_mesure")

        If ds_recherche.Tables(0).Rows.Count = 0 Then
            lbE_unites_mesures.Visible = False
            Return True
        Else
            lbE_unites_mesures.Text = "Le nom de l'unité de mesure existe déja."
            lbE_unites_mesures.Visible = True
            Return False
        End If


    End Function

    Public Sub reinitialiser_controle()

        txt_unite_mesure.Text = ""
        cbo_type_mesure.Text = ""

    End Sub




    Private Sub gestionBtn()
        If dgv_unites_mesures.Rows.Count > 0 Then

            If dgv_unites_mesures.CurrentRow.Cells(0).Tag = 0 Then
                btn_unite_mesure.Enabled = True
                btn_desac_unite_mesure.Enabled = False

            Else
                btn_unite_mesure.Enabled = False
                btn_desac_unite_mesure.Enabled = True

            End If
        Else
            btn_unite_mesure.Enabled = False
            btn_desac_unite_mesure.Enabled = False

        End If
    End Sub



    Private Sub RemplirGrid()
        dgv_unites_mesures.Rows.Clear()
        With ds_recherche.Tables(0)
            For i As Integer = 0 To .Rows.Count - 1
                dgv_unites_mesures.Rows.Add(.Rows(i).Item(0))
                dgv_unites_mesures.Rows(dgv_unites_mesures.Rows.Count - 1).Cells(1).Value = .Rows(i).Item(1)



                If .Rows(i).Item(2) = 0 Then
                    dgv_unites_mesures.Rows(dgv_unites_mesures.Rows.Count - 1).Cells(0).Tag = "0"
                    For j As Integer = 0 To 1
                        dgv_unites_mesures.Rows(dgv_unites_mesures.Rows.Count - 1).Cells(j).Style.ForeColor = Color.DimGray
                    Next
                Else
                    dgv_unites_mesures.Rows(dgv_unites_mesures.Rows.Count - 1).Cells(0).Tag = "1"
                End If
            Next
        End With
    End Sub


    Private Sub InverserControle()

        txt_unite_mesure.Enabled = Not txt_unite_mesure.Enabled

        cbo_type_mesure.Enabled = Not cbo_type_mesure.Enabled

        dgv_unites_mesures.Enabled = Not dgv_unites_mesures.Enabled
    End Sub

    'Activer.'
    Private Sub btn_activer_Click(sender As Object, e As EventArgs) Handles btn_unite_mesure.Click
        If MessageBox.Show("Voulez-vous activer l'unité de mesure sélectionnée?",
                          "Activer une unité de mesure",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then


            Cursor = Cursors.AppStarting
            For i As Integer = 0 To dgv_unites_mesures.SelectedRows.Count - 1
                With dgv_unites_mesures.SelectedRows(i)
                    str_requete_unites = "UPDATE `tbl_unites_mesure` 
                                      SET `actif` = 1
                                      WHERE `unite_mesure` = '" & StrConv(mod_regex.ConvertirApostrophe(.Cells(0).Value.Trim), VbStrConv.ProperCase) & "';"

                    Try
                        gestionBd.InsDelUpd(str_requete_unites)
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
    Private Sub btn_desactiver_Click(sender As Object, e As EventArgs) Handles btn_desac_unite_mesure.Click
        If MessageBox.Show("Voulez-vous désactiver l'unité de mesure sélectionnée?",
                          "Désactiver une unité de mesure",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then



            Cursor = Cursors.AppStarting
            For i As Integer = 0 To dgv_unites_mesures.SelectedRows.Count - 1
                With dgv_unites_mesures.SelectedRows(i)
                    str_requete_unites = "UPDATE `tbl_unites_mesure` 
                                      SET `actif` = 0
                                      WHERE `unite_mesure` = '" & StrConv(mod_regex.ConvertirApostrophe(.Cells(0).Value.Trim), VbStrConv.ProperCase) & "';"

                    Try
                        gestionBd.InsDelUpd(str_requete_unites)
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

    Private Sub dgv_unites_mesures_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_unites_mesures.SelectionChanged


        gestionBtn()
    End Sub

    Private Sub dgv_unites_mesures_Click(sender As Object, e As EventArgs) Handles dgv_unites_mesures.Click
        remplir_controles()
    End Sub

    Public Sub remplir_cbo_type_mesure()

        str_requete_unites = "select type_mesure from tbl_unites_mesure"
        gestionBd.miseAjourDS(ds_recherche, da_recherche, str_requete_unites, "tbl_unites_mesure")


        For i = 0 To ds_recherche.Tables(0).Rows.Count - 1

            If Not cbo_type_mesure.Items.Contains(ds_recherche.Tables(0).Rows(i).Item(0)) Then

                cbo_type_mesure.Items.Add(ds_recherche.Tables(0).Rows(i).Item(0))

            End If

        Next


    End Sub





    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btn_ajouter_unite_mesure.MouseEnter, btn_annuler_unite_mesure.MouseEnter, btn_modifier_unite_mesure.MouseEnter, btn_unite_mesure.MouseEnter, btn_desac_unite_mesure.MouseEnter
        sender.BackColor = Color.White
        sender.ForeColor = Color.Black
    End Sub


    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btn_ajouter_unite_mesure.MouseLeave, btn_annuler_unite_mesure.MouseLeave, btn_modifier_unite_mesure.MouseLeave, btn_unite_mesure.MouseLeave, btn_desac_unite_mesure.MouseLeave
        If sender.Text = btn_annuler_unite_mesure.Text Then
            sender.BackColor = Color.DimGray
            sender.ForeColor = SystemColors.Control

        Else
            sender.BackColor = Color.FromArgb(52, 73, 94)
            sender.ForeColor = SystemColors.Control
        End If
    End Sub


    'Change la couleur quand on passe la souris sur le grid_cours.'
    Private Sub dgv_unites_mesures_CellMouseLeave(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_unites_mesures.CellMouseLeave
        If e.RowIndex > -1 Then
            dgv_unites_mesures.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
            dgv_unites_mesures.Rows(e.RowIndex).DefaultCellStyle.ForeColor = DefaultForeColor
        End If
    End Sub

    'Change la couleur quand on passe la souris sur le grid_cours.'
    Private Sub dgv_unites_mesures_CellMouseEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_unites_mesures.CellMouseEnter
        If e.RowIndex > -1 Then
            dgv_unites_mesures.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(236, 240, 241)
        End If
    End Sub

    Private Sub unites_mesure_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_ordre.SelectedIndexChanged, cbo_nom_contient.SelectedIndexChanged, cbo_trier_activite.SelectedIndexChanged, cbo_unite_mesure.SelectedIndexChanged, txt_rech_nom.TextChanged

        MAJ()

    End Sub


    Private Sub txt_unites_mesures_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_unite_mesure.KeyPress

        If IsNumeric(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True


        End If

    End Sub

    Private Sub timer_succes_Tick(sender As Timer, e As EventArgs) Handles timer_succes.Tick
        animation.Operation(sender, lbl_ajoutSucces)
    End Sub


    Private Sub nom_TextChanged(sender As Object, e As EventArgs) Handles txt_unite_mesure.TextChanged, cbo_type_mesure.TextChanged

        message_erreur(sender)
    End Sub


    Public Sub message_erreur(sender As Object)

        If sender.text.trim <> "" Then


            If Exercice(sender.text.trim) Then

                If sender.name = "txt_unite_mesure" Then
                    lbE_unites_mesures.Visible = False


                Else

                    lbE_types_mesures.Visible = False
                End If
            Else

                If sender.name = "txt_unite_mesure" Then
                    lbE_unites_mesures.Text = "Caractère invalide"
                    lbE_unites_mesures.Visible = True

                Else
                    lbE_types_mesures.Text = "Caractère invalide"
                    lbE_types_mesures.Visible = True


                End If



            End If

        Else



            If sender.name = "txt_unite_mesure" Then
                lbE_unites_mesures.Visible = False

            Else

                lbE_types_mesures.Visible = False

            End If
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
