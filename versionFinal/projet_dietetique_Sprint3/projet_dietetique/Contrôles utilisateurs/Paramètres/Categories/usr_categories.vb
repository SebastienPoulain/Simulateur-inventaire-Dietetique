Imports System.Data.Sql
Imports MySql.Data.MySqlClient

' PIERRE-OLIVIER DUBOIS-NADEAU

Public Class usr_categories

    Dim dataTable = New DataTable
    Dim da_recherche As New MySqlDataAdapter
    Dim ds_recherche As DataSet
    Dim gestionBd As New Connexion
    Dim animation As New cls_animation_operation
    Dim str_requete_categorie As String = ""

    Private Sub usr_gestion_categories_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        btnReinitialiser.PerformClick()

    End Sub


    Public Sub rechercher_categories()



        str_requete_categorie = "select nom_categorie as 'nom de la catégorie', remarque, actif from tbl_categories
        " & verifier_activite_combobox(cbo_trier_activite) & Rechercher_Selon_Contenu("nom_categorie", cbo_nom_contient, ConvertirApostrophe(txt_rech_nom.Text.Trim)) & " ORDER BY nom_categorie " & Verifier_Ordre(ConvertirApostrophe(cbo_ordre.Text.Trim))


        gestionBd.miseAjourDS(ds_recherche, da_recherche, str_requete_categorie, "tbl_categories")

        If ds_recherche.Tables(0).Rows.Count = 0 Then

            btn_modifier_categories.Enabled = False
            btn_desac_categories.Enabled = False
            btn_ajouter_categories.Enabled = True
            btn_annuler_categories.Enabled = False
            btn_activer_categories.Enabled = False

        Else

            btn_modifier_categories.Enabled = True
            btn_desac_categories.Enabled = True
            btn_ajouter_categories.Enabled = True

            btn_activer_categories.Enabled = True


        End If


        RemplirGrid()
    End Sub



    Public Sub remplir_controles()

        If dgv_categories.Rows.Count <> 0 Then
            txt_nom_categories.Text = dgv_categories.CurrentRow.Cells(0).Value

            txt_remarque_categories.Text = dgv_categories.CurrentRow.Cells(1).Value
            btn_modifier_categories.Enabled = True


        Else

            btn_modifier_categories.Enabled = False

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

        rechercher_categories()
        remplir_controles()
        gestionBtn()



    End Sub


    Private Sub btn_Click_format(sender As Object, e As EventArgs) Handles btn_ajouter_categories.Click, btn_modifier_categories.Click, btn_annuler_categories.Click
        Dim btn As Button = sender

        Select Case btn.Text
            Case btn_ajouter_categories.Text
                ajouter_categories()
            Case btn_modifier_categories.Text
                Modifier_categorie()

            Case btn_annuler_categories.Text
                Annuler_categorie()

        End Select

    End Sub


    Public Sub ajouter_categories()



        If btn_ajouter_categories.Text = "Ajouter" Then
            'Active/désactive les boutons.'
            btn_ajouter_categories.Text = "Enregistrer"
            btn_modifier_categories.Enabled = False
            btn_annuler_categories.Enabled = True
            btn_activer_categories.Enabled = False
            btn_desac_categories.Enabled = False

            InverserControle()
            reinitialiser_controle()



        Else
            If verifier_label(lbE_nom_categories) Then
                If (verifier_nom_textbox_vide(txt_nom_categories, lbE_nom_categories, "Saisissez un nom de catégorie")) Then


                    If verifier_nom_categorie_bd() Then


                        Dim succes As Boolean = True

                        ' Ajout du format.'
                        Try
                            str_requete_categorie = "INSERT INTO tbl_categories(nom_categorie, remarque, actif)VALUES( '" & StrConv(mod_regex.ConvertirApostrophe(txt_nom_categories.Text.Trim), VbStrConv.ProperCase) & "','" & StrConv(mod_regex.ConvertirApostrophe(txt_remarque_categories.Text.Trim), VbStrConv.ProperCase) & "',1)"

                            gestionBd.InsDelUpd(str_requete_categorie)
                        Catch e As Exception
                            succes = False
                        End Try

                        If succes Then
                            animation.Lancement(timer_succes, lbl_ajoutSucces, "La catégorie a été ajoutée.", cls_animation_operation.Reussie)
                        Else
                            animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de l'ajout de la catégorie.", cls_animation_operation.Echec)
                        End If


                        'Active/désactive les boutons.'
                        btn_ajouter_categories.Text = "Ajouter"
                        btn_modifier_categories.Enabled = True
                        btn_annuler_categories.Enabled = False
                        InverserControle()
                        gestionBtn()
                        MAJ()
                    End If
                End If
            End If

        End If
    End Sub

    Public Sub Modifier_categorie()
        If btn_modifier_categories.Text = "Modifier" Then
            'Active/désactive les boutons.'ann
            btn_modifier_categories.Text = "Enregistrer"
            btn_ajouter_categories.Enabled = False
            btn_annuler_categories.Enabled = True
            btn_activer_categories.Enabled = False
            btn_desac_categories.Enabled = False

            InverserControle()


        Else
            If verifier_label(lbE_nom_categories) Then
                If (verifier_nom_textbox_vide(txt_nom_categories, lbE_nom_categories, "Saisissez un nom de catégorie")) Then

                    If verifier_nom_categorie_bd() Then
                        Dim succes As Boolean = True

                        'Requetes vers la bd.'
                        Try
                            str_requete_categorie = "UPDATE tbl_categories Set nom_categorie = '" & StrConv(mod_regex.ConvertirApostrophe(txt_nom_categories.Text.Trim), VbStrConv.ProperCase) & "', remarque = '" & StrConv(mod_regex.ConvertirApostrophe(txt_remarque_categories.Text.Trim), VbStrConv.ProperCase) &
                        "' where nom_categorie = '" & StrConv(mod_regex.ConvertirApostrophe(dgv_categories.CurrentRow.Cells(0).Value.Trim), VbStrConv.ProperCase) & "' and remarque = '" & StrConv(mod_regex.ConvertirApostrophe(dgv_categories.CurrentRow.Cells(1).Value.Trim), VbStrConv.ProperCase) & "'"

                            gestionBd.InsDelUpd(str_requete_categorie)
                        Catch e As Exception
                            succes = False
                        End Try


                        If succes Then
                            animation.Lancement(timer_succes, lbl_ajoutSucces, "La catégorie a été modifiée.", cls_animation_operation.Reussie)
                        Else
                            animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de la modification de la catégorie.", cls_animation_operation.Echec)
                        End If




                    Else

                        lbE_nom_categories.Visible = False
                        Dim succes As Boolean = True

                        'Requetes vers la bd.'
                        Try
                            str_requete_categorie = "UPDATE tbl_categories Set remarque = '" & StrConv(mod_regex.ConvertirApostrophe(txt_remarque_categories.Text.Trim), VbStrConv.ProperCase) &
                        "' where nom_categorie = '" & StrConv(mod_regex.ConvertirApostrophe(dgv_categories.CurrentRow.Cells(0).Value.Trim), VbStrConv.ProperCase) & "'"

                            gestionBd.InsDelUpd(str_requete_categorie)
                        Catch e As Exception
                            succes = False
                        End Try


                        If succes Then
                            animation.Lancement(timer_succes, lbl_ajoutSucces, "La catégorie a été modifiée.", cls_animation_operation.Reussie)
                        Else
                            animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de la modification de la catégorie.", cls_animation_operation.Echec)
                        End If


                    End If




                End If
                btn_modifier_categories.Text = "Modifier"
                btn_ajouter_categories.Enabled = True
                btn_annuler_categories.Enabled = False
                InverserControle()
                gestionBtn()
                MAJ()
            End If
        End If

    End Sub


    Public Sub Annuler_categorie()
        lbE_nom_categories.Visible = False
        btn_ajouter_categories.Text = "Ajouter"
        btn_modifier_categories.Text = "Modifier"
        btn_ajouter_categories.Enabled = True
        btn_modifier_categories.Enabled = True
        btn_annuler_categories.Enabled = False
        btn_activer_categories.Enabled = True
        btn_modifier_categories.Enabled = True


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


    Public Function verifier_nom_categorie_bd() As Boolean

        str_requete_categorie = "select nom_categorie from tbl_categories where nom_categorie = '" & StrConv(mod_regex.ConvertirApostrophe(txt_nom_categories.Text.Trim), VbStrConv.ProperCase) & "'"

        gestionBd.miseAjourDS(ds_recherche, da_recherche, str_requete_categorie, "tbl_categories")

        If ds_recherche.Tables(0).Rows.Count = 0 Then
            lbE_nom_categories.Visible = False
            Return True
        Else
            lbE_nom_categories.Text = "Le nom de la categorie existe déja"
            lbE_nom_categories.Visible = True
            Return False
        End If


    End Function

    Public Sub reinitialiser_controle()

        txt_nom_categories.Text = ""
        txt_remarque_categories.Text = ""

    End Sub




    Private Sub gestionBtn()
        If dgv_categories.Rows.Count > 0 Then

            If dgv_categories.CurrentRow.Cells(0).Tag = 0 Then
                btn_activer_categories.Enabled = True
                btn_desac_categories.Enabled = False

            Else
                btn_activer_categories.Enabled = False
                btn_desac_categories.Enabled = True

            End If
        Else
            btn_activer_categories.Enabled = False
            btn_desac_categories.Enabled = False

        End If
    End Sub



    Private Sub RemplirGrid()
        dgv_categories.Rows.Clear()
        With ds_recherche.Tables(0)
            For i As Integer = 0 To .Rows.Count - 1
                dgv_categories.Rows.Add(.Rows(i).Item(0))
                dgv_categories.Rows(dgv_categories.Rows.Count - 1).Cells(1).Value = .Rows(i).Item(1)



                If .Rows(i).Item(2) = 0 Then
                    dgv_categories.Rows(dgv_categories.Rows.Count - 1).Cells(0).Tag = "0"
                    For j As Integer = 0 To 1
                        dgv_categories.Rows(dgv_categories.Rows.Count - 1).Cells(j).Style.ForeColor = Color.DimGray
                    Next
                Else
                    dgv_categories.Rows(dgv_categories.Rows.Count - 1).Cells(0).Tag = "1"
                End If
            Next
        End With




        dgv_categories.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells


        If dgv_categories.Columns(1).Width < 589 Then

            dgv_categories.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgv_categories.Columns(1).Width = 589
        End If
    End Sub


    Private Sub InverserControle()
        txt_nom_categories.Enabled = Not txt_nom_categories.Enabled
        txt_remarque_categories.Enabled = Not txt_remarque_categories.Enabled
        dgv_categories.Enabled = Not dgv_categories.Enabled
    End Sub

    'Activer.'
    Private Sub btn_activer_Click(sender As Object, e As EventArgs) Handles btn_activer_categories.Click
        If MessageBox.Show("Voulez-vous activer la catégorie sélectionnée?",
                          "Activer une catégorie",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then


            Cursor = Cursors.AppStarting
            For i As Integer = 0 To dgv_categories.SelectedRows.Count - 1
                With dgv_categories.SelectedRows(i)
                    str_requete_categorie = "UPDATE `tbl_categories` 
                                      SET `actif` = 1
                                      WHERE `nom_categorie` = '" & StrConv(mod_regex.ConvertirApostrophe(.Cells(0).Value.Trim), VbStrConv.ProperCase) & "';"


                    Try
                        gestionBd.InsDelUpd(str_requete_categorie)
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
    Private Sub btn_desactiver_Click(sender As Object, e As EventArgs) Handles btn_desac_categories.Click
        If MessageBox.Show("Voulez-vous désactiver la catégorie sélectionnée?",
                          "Désactiver une catégorie",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then


            Cursor = Cursors.AppStarting
            For i As Integer = 0 To dgv_categories.SelectedRows.Count - 1
                With dgv_categories.SelectedRows(i)
                    str_requete_categorie = "UPDATE `tbl_categories` 
                                      SET `actif` = 0
                                      WHERE `nom_categorie` = '" & StrConv(mod_regex.ConvertirApostrophe(.Cells(0).Value.Trim), VbStrConv.ProperCase) & "';"

                    Try
                        gestionBd.InsDelUpd(str_requete_categorie)
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

    Private Sub dgv_categories_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_categories.SelectionChanged

        gestionBtn()
    End Sub




    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btn_ajouter_categories.MouseEnter, btn_annuler_categories.MouseEnter, btn_modifier_categories.MouseEnter, btn_activer_categories.MouseEnter, btn_desac_categories.MouseEnter
        sender.BackColor = Color.White
        sender.ForeColor = Color.Black
    End Sub


    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btn_ajouter_categories.MouseLeave, btn_annuler_categories.MouseLeave, btn_modifier_categories.MouseLeave, btn_activer_categories.MouseLeave, btn_desac_categories.MouseLeave
        If sender.Text = btn_annuler_categories.Text Then
            sender.BackColor = Color.DimGray
            sender.ForeColor = SystemColors.Control

        Else
            sender.BackColor = Color.FromArgb(52, 73, 94)
            sender.ForeColor = SystemColors.Control
        End If
    End Sub


    'Change la couleur quand on passe la souris sur le grid_cours.'
    Private Sub dgv_categories_CellMouseLeave(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_categories.CellMouseLeave
        If e.RowIndex > -1 Then
            dgv_categories.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
            dgv_categories.Rows(e.RowIndex).DefaultCellStyle.ForeColor = DefaultForeColor
        End If
    End Sub

    'Change la couleur quand on passe la souris sur le grid_cours.'
    Private Sub dgv_categories_CellMouseEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_categories.CellMouseEnter
        If e.RowIndex > -1 Then
            dgv_categories.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(236, 240, 241)
        End If
    End Sub

    Private Sub format_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_ordre.SelectedIndexChanged, cbo_nom_contient.SelectedIndexChanged, cbo_trier_activite.SelectedIndexChanged, txt_rech_nom.TextChanged

        MAJ()

    End Sub


    Private Sub txt_nom_categories_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nom_categories.KeyPress

        If IsNumeric(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True


        End If

    End Sub

    Private Sub timer_succes_Tick(sender As Timer, e As EventArgs) Handles timer_succes.Tick
        animation.Operation(sender, lbl_ajoutSucces)
    End Sub

    Private Sub dgv_formats_Click(sender As Object, e As EventArgs) Handles dgv_categories.Click
        remplir_controles()
    End Sub


    Private Sub txt_nom_categories_TextChanged(sender As Object, e As EventArgs) Handles txt_nom_categories.TextChanged

        message_erreur(sender)
    End Sub


    Public Sub message_erreur(sender As Object)

        If sender.text.trim <> "" Then
            If Exercice(sender.text.trim) Then

                lbE_nom_categories.Visible = False
            Else


                lbE_nom_categories.Text = "Caractère invalide"
                lbE_nom_categories.Visible = True



            End If

        Else




            lbE_nom_categories.Visible = False
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
