Imports MySql.Data.MySqlClient

Public Class frm_modifier_inventaire
    Dim bd As New Connexion
    Dim ds As New DataSet
    Dim da As MySqlDataAdapter

    Dim _no_prod As String
    Dim _quant As Decimal
    Dim _empl As String
    Dim inventaire As String
    Dim strRequete As String
    Dim leExerc As String
    Dim utls_conn As Utilisateur

    Dim modifie As Boolean
    Dim succes As Boolean

    ReadOnly Property prodModifie As Boolean
        Get
            Return modifie
        End Get
    End Property

    ReadOnly Property succesModif As Boolean
        Get
            Return succes
        End Get
    End Property

    Public Sub New(no_prod As String, nom_prod As String, quant As Decimal, emplacement As String, invt As String, ex As String, utls As Utilisateur)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Remplir_Combobox(bd, "nom_emplacement", "tbl_emplacement_inventaire", cbo_empl)


        _no_prod = no_prod
        _quant = quant
        _empl = emplacement
        inventaire = invt
        leExerc = ex
        utls_conn = utls

        lbl_nom.Text = no_prod & ": " & nom_prod
        nm_quant.Value = quant
        cbo_empl.Text = emplacement
    End Sub

    Private Sub btn_modifier_Click(sender As Object, e As EventArgs) Handles btn_modifier.Click
        If nm_quant.Value <> _quant Or cbo_empl.Text <> _empl Then
            modifie = True
            If btn_modifier.Text = "Modifier" Then
                modifier()
            Else
                If Not supprimer() Then
                    modifie = False
                    Return
                End If
            End If
        Else
            modifie = False
            succes = False
        End If

        Me.Close()
    End Sub

    Private Sub modifier()
        succes = True

        'Si l'emplacement n'est pas le même que celui avant modification.'
        If _empl <> cbo_empl.Text Then

            'Récupère les emplacements déjà existant du produit.'
            Dim requete As String = "select distinct nom_emplacement
                                FROM tbl_produits p, tbl_formats f, tbl_categories c, tbl_emplacement_inventaire ei
                                WHERE p.no_format = f.no_format and p.no_categorie = c.no_categorie 
                                and no_emplacement in "

            If inventaire = "prof" Then
                requete &= " (select no_emplacement from tbl_inventaire_detail id2, tbl_inventaire_prof ip2 
                                 where id2.no_inventaire = ip2.no_inventaire and id2.code_produit = '" & _no_prod & "' and ip2.no_utilisateur= '" & utls_conn.No_id & "')"
            Else
                requete &= " (select no_emplacement from tbl_inventaire_detail id2, tbl_exercices e2 
                                 where id2.no_inventaire = e2.no_inventaire and id2.code_produit = '" & _no_prod & "' and e2.no_exercice = " & leExerc & ")"
            End If

            requete &= "order by nom_emplacement"

            bd.miseAjourDS(ds, da, requete, "tbl_produits")

            Dim i As Integer
            Dim trouve As Boolean = False

            'Vérifie si l'emplacement sélectionné existe.'
            While i < ds.Tables(0).Rows.Count And trouve = False
                If ds.Tables(0).Rows(i).Item(0) = cbo_empl.Text Then
                    'Supprime la ligne de l'ancien emplacement.'
                    Try
                        strRequete = "DELETE FROM tbl_inventaire_detail where code_produit = '" & _no_prod & "' and no_emplacement = (select no_emplacement from tbl_emplacement_inventaire where nom_emplacement = '" & mod_regex.ConvertirApostrophe(_empl) & "')
                                  and "

                        If inventaire = "prof" Then
                            strRequete &= " no_inventaire = (select no_inventaire from tbl_inventaire_prof where no_utilisateur = '" & utls_conn.No_id & "');"
                        Else
                            strRequete &= " no_inventaire = (select no_inventaire from tbl_exercices where no_exercice = " & leExerc & ");"
                        End If

                        bd.InsDelUpd(strRequete)
                    Catch ex As Exception
                        succes = False
                    End Try

                    'Rajoute la quantité saisie au nouvel emplacement.'
                    Try
                        strRequete = "UPDATE `tbl_inventaire_detail` SET
                            `quantite`= `quantite` + " & nm_quant.Value.ToString.Replace(",", ".") & "
                          WHERE code_produit = '" & _no_prod & "'
                            and no_emplacement = (select no_emplacement from tbl_emplacement_inventaire where nom_emplacement = '" & mod_regex.ConvertirApostrophe(cbo_empl.Text) & "')  
                            and no_inventaire = "

                        If inventaire = "prof" Then
                            strRequete &= "(Select no_inventaire from tbl_inventaire_prof where no_utilisateur = '" & utls_conn.No_id & "')"
                        Else
                            strRequete &= "(select no_inventaire from tbl_exercices where no_exercice = " & leExerc & ")"
                        End If

                        bd.InsDelUpd(strRequete)
                    Catch ex As Exception
                        succes = False
                    End Try

                End If

                i += 1
            End While

            If trouve = False Then
                ModificationNormale()
            End If

        Else
            ModificationNormale()

        End If
    End Sub

    'Modifie la quantité (sans changement d'emplacement).'
    Private Sub ModificationNormale()
        Try
            strRequete = "UPDATE `tbl_inventaire_detail` SET `no_emplacement`=
                            (select no_emplacement from tbl_emplacement_inventaire where nom_emplacement = '" & mod_regex.ConvertirApostrophe(cbo_empl.Text) & "'),
                            `quantite`= " & nm_quant.Value.ToString.Replace(",", ".") & "
                          WHERE code_produit = '" & _no_prod & "'
                          and no_emplacement = (select no_emplacement from tbl_emplacement_inventaire where nom_emplacement = '" & mod_regex.ConvertirApostrophe(_empl) & "')  
                          and no_inventaire = "

            If inventaire = "prof" Then
                strRequete &= "(Select no_inventaire from tbl_inventaire_prof where no_utilisateur = '" & utls_conn.No_id & "')"
            Else
                strRequete &= "(select no_inventaire from tbl_exercices where no_exercice = " & leExerc & ")"
            End If

            bd.InsDelUpd(strRequete)
        Catch ex As Exception
            succes = False
        End Try
    End Sub

    Private Function supprimer() As Boolean
        If MessageBox.Show("Êtes-vous certain de vouloir supprimer ce produit?", "Suppression",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            succes = True

            Try
                strRequete = "DELETE FROM tbl_inventaire_detail where code_produit = '" & _no_prod & "' and no_emplacement = (select no_emplacement from tbl_emplacement_inventaire where nom_emplacement = '" & mod_regex.ConvertirApostrophe(_empl) & "')
                                  and "

                If inventaire = "prof" Then
                    strRequete &= " no_inventaire = (select no_inventaire from tbl_inventaire_prof where no_utilisateur = '" & utls_conn.No_id & "');"
                Else
                    strRequete &= " no_inventaire = (select no_inventaire from tbl_exercices where no_exercice = " & leExerc & ");"
                End If

                bd.InsDelUpd(strRequete)
            Catch ex As Exception
                succes = False
            End Try
            Return True
        End If
        Return False
    End Function
#Region "Autres"
    'Modifie le texte du bouton dépendant de la quantité.'
    Private Sub nm_quant_ValueChanged(sender As Object, e As EventArgs) Handles nm_quant.ValueChanged, nm_quant.LostFocus
        If nm_quant.Value = 0 Then
            btn_modifier.Text = "Supprimer"
        Else
            btn_modifier.Text = "Modifier"
        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click, btn_annuler.Click
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

    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btn_modifier.MouseEnter, btn_annuler.MouseEnter
        sender.BackColor = Color.White
        sender.ForeColor = Color.Black
    End Sub

    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btn_modifier.MouseLeave, btn_annuler.MouseLeave

        If sender.Text = btn_annuler.Text Then
            sender.BackColor = Color.FromArgb(72, 84, 96)
            sender.ForeColor = SystemColors.Control
        Else
            sender.BackColor = Color.FromArgb(52, 73, 94)
            sender.ForeColor = SystemColors.Control
        End If
    End Sub
#End Region
End Class