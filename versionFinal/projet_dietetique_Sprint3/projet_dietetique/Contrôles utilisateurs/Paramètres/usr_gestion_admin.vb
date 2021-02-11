Imports System.ComponentModel

Public Class usr_gestion_admin
    Dim section_choisie As String = "Mon profil"
    Dim usrComm As usr_gestion_Menucours
    Dim utls_conn As Utilisateur
    Dim usrUtls As usr_gestion_MenuUtls
    Dim usrProd As usr_gestion_Menuproduits
    Dim usrProfil As usr_profil
    Dim usrFourn As usr_gestion_MenuFournisseurs
    Dim usrformat As usr_formats
    Dim usrunite As usr_unites_mesures
    Dim usrCategories As usr_categories
    Dim usrvilles As usr_villes
    Dim usrEmp As usr_emplacements
    Dim usrPurge As usr_purger

    Public Sub New(utls As Utilisateur)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        utls_conn = utls


        droit_utls()
    End Sub

    Private Sub droit_utls()
        Select Case utls_conn.Titre
            Case "a"c
                ChargerUsrA()
            Case "p"c
                ChargerUsrP()
            Case Else
        End Select

        Adapter_Couleurs()
        Adapter_UserControl(btn_profil)
    End Sub


    Private Sub ChargerUsrP()
        btn_profil.Visible = True
        btn_utilisateur.Visible = True
        btn_cours.Visible = True
        btn_utilisateur.Text = "Étudiants"
    End Sub


    Private Sub ChargerUsrA()
        btn_cours.Visible = True
        btn_produits.Visible = True
        btn_utilisateur.Visible = True
        btn_fournisseurs.Visible = True
        btn_categories.Visible = True
        btn_formats.Visible = True
        btn_unites_mesures.Visible = True
        btn_villes.Visible = True
        btn_emplacements.Visible = True
        btn_purge.Visible = True
    End Sub






    'Dessine la ligne du menu vertical.'
    Private Sub usr_gestion_admin_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        e.Graphics.DrawLine(New Pen(Color.FromArgb(30, 39, 46)), pnl_menu_vertical.Size.Width, 0, pnl_menu_vertical.Size.Width, pnl_menu_vertical.Size.Height)
    End Sub

#Region "Manipulation du menu"
    ''' <description>
    ''' Cette région est dédiée à la manipulation du menu en raison d'un besoin de faciliter l'identification de où l'utilisateur se situe dans le logiciel.
    ''' 
    ''' <fonctionnalites>
    ''' Changement de couleurs des boutons lorsqu'on passe le curseur de la souris dessus.
    ''' Vérification du bouton cliqué (style onglet) par <variable name="section_choisie"/>.
    ''' </fonctionnalites>
    ''' 
    ''' </description>

    Private Sub Boutons_Click(sender As Button, e As EventArgs) Handles btn_cours.Click, btn_utilisateur.Click, btn_produits.Click,
                                                                        btn_profil.Click, btn_fournisseurs.Click, btn_formats.Click, btn_unites_mesures.Click,
                                                                        btn_categories.Click, btn_villes.Click, btn_emplacements.Click, btn_purge.Click
        Dim btn As Button = sender

        If btn.Text = section_choisie Then
            Return
        End If

        If btn.Text = btn_purge.Text Then
            If MessageBox.Show("Cette section permet de supprimer définitivement des données." & vbNewLine & vbNewLine &
                               "Voulez-vous continuer?", "Changement de section", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                Return
            End If
        End If

        section_choisie = btn.Text

        Adapter_Couleurs()
        Adapter_UserControl(btn)
    End Sub

    Private Sub Boutons_MouseHover(sender As Button, e As EventArgs) Handles btn_cours.MouseEnter, btn_utilisateur.MouseEnter, btn_produits.MouseEnter,
                                                                             btn_profil.MouseEnter, btn_formats.MouseEnter, btn_fournisseurs.MouseEnter,
                                                                             btn_unites_mesures.MouseEnter, btn_categories.MouseEnter, btn_villes.MouseEnter, btn_emplacements.MouseEnter, btn_purge.MouseEnter, btn_deconnexion.MouseEnter
        Dim btn As Button = sender

        btn.BackColor = Color.White
        btn.ForeColor = Color.Black
    End Sub

    Private Sub Boutons_MouseLeave(sender As Button, e As EventArgs) Handles btn_cours.MouseLeave, btn_utilisateur.MouseLeave, btn_produits.MouseLeave,
                                                                             btn_profil.MouseLeave, btn_formats.MouseLeave, btn_fournisseurs.MouseLeave,
                                                                             btn_unites_mesures.MouseLeave, btn_categories.MouseLeave, btn_villes.MouseLeave, btn_emplacements.MouseLeave, btn_purge.MouseLeave, btn_deconnexion.MouseLeave
        Adapter_Couleurs()
    End Sub

    Sub Adapter_Couleurs()
        Dim tab_boutons() As Button = {btn_cours, btn_utilisateur, btn_produits, btn_profil, btn_fournisseurs, btn_formats, btn_unites_mesures, btn_categories, btn_villes, btn_emplacements, btn_purge, btn_deconnexion}

        For i = 0 To tab_boutons.Count - 1
            If tab_boutons(i).Text <> section_choisie Then
                tab_boutons(i).BackColor = Color.FromArgb(52, 73, 94)
                tab_boutons(i).ForeColor = Color.White
            Else
                tab_boutons(i).BackColor = SystemColors.Control
                tab_boutons(i).ForeColor = Color.Black
            End If
        Next
    End Sub

    Sub Adapter_UserControl(btn As Button)
        pnl_gestion.Controls.Clear()

        Select Case btn.Text
            Case btn_profil.Text
                usrProfil = New usr_profil(utls_conn)
                pnl_gestion.Controls.Add(usrProfil)
                usrProfil.Dock = DockStyle.Fill
                usrProfil.BringToFront()
                usrProfil.Focus()
            Case btn_cours.Text
                usrComm = New usr_gestion_Menucours(utls_conn)
                pnl_gestion.Controls.Add(usrComm)
                usrComm.Dock = DockStyle.Fill
                usrComm.BringToFront()
                usrComm.Focus()
            Case btn_utilisateur.Text
                usrUtls = New usr_gestion_MenuUtls(utls_conn, usrComm)
                pnl_gestion.Controls.Add(usrUtls)
                usrUtls.Dock = DockStyle.Fill
                usrUtls.BringToFront()
                usrUtls.Focus()
            Case btn_produits.Text
                usrProd = New usr_gestion_Menuproduits
                pnl_gestion.Controls.Add(usrProd)
                usrProd.Dock = DockStyle.Fill
                usrProd.BringToFront()
                usrProd.Focus()
            Case btn_fournisseurs.Text
                usrFourn = New usr_gestion_MenuFournisseurs
                pnl_gestion.Controls.Add(usrFourn)
                usrFourn.Dock = DockStyle.Fill
                usrFourn.BringToFront()
                usrFourn.Focus()
            Case btn_formats.Text
                usrformat = New usr_formats
                pnl_gestion.Controls.Add(usrformat)
                usrformat.Dock = DockStyle.Fill
                usrformat.BringToFront()
                usrformat.Focus()
            Case btn_unites_mesures.Text
                usrunite = New usr_unites_mesures
                pnl_gestion.Controls.Add(usrunite)
                usrunite.Dock = DockStyle.Fill
                usrunite.BringToFront()
                usrunite.Focus()
            Case btn_categories.Text
                usrCategories = New usr_categories
                pnl_gestion.Controls.Add(usrCategories)
                usrCategories.Dock = DockStyle.Fill
                usrCategories.BringToFront()
                usrCategories.Focus()
            Case btn_villes.Text
                usrvilles = New usr_villes
                pnl_gestion.Controls.Add(usrvilles)
                usrvilles.Dock = DockStyle.Fill
                usrvilles.BringToFront()
                usrvilles.Focus()
            Case btn_emplacements.Text
                usrEmp = New usr_emplacements
                pnl_gestion.Controls.Add(usrEmp)
                usrEmp.Dock = DockStyle.Fill
                usrEmp.BringToFront()
                usrEmp.Focus()
            Case btn_purge.Text
                usrPurge = New usr_purger(utls_conn)
                pnl_gestion.Controls.Add(usrPurge)
                usrPurge.Dock = DockStyle.Fill
                usrPurge.BringToFront()
                usrPurge.Focus()
        End Select
    End Sub

    Private Sub Boutons_MouseHover(sender As Object, e As EventArgs) Handles btn_villes.MouseEnter, btn_utilisateur.MouseEnter, btn_unites_mesures.MouseEnter, btn_profil.MouseEnter, btn_produits.MouseEnter, btn_fournisseurs.MouseEnter, btn_formats.MouseEnter, btn_emplacements.MouseEnter, btn_cours.MouseEnter, btn_categories.MouseEnter, btn_purge.MouseEnter, btn_deconnexion.MouseEnter

    End Sub

    Private Sub Boutons_MouseLeave(sender As Object, e As EventArgs) Handles btn_villes.MouseLeave, btn_utilisateur.MouseLeave, btn_unites_mesures.MouseLeave, btn_profil.MouseLeave, btn_produits.MouseLeave, btn_fournisseurs.MouseLeave, btn_formats.MouseLeave, btn_emplacements.MouseLeave, btn_cours.MouseLeave, btn_categories.MouseLeave, btn_purge.MouseLeave, btn_deconnexion.MouseLeave

    End Sub

    Private Sub Boutons_Click(sender As Object, e As EventArgs) Handles btn_villes.Click, btn_utilisateur.Click, btn_unites_mesures.Click, btn_purge.Click, btn_profil.Click, btn_produits.Click, btn_fournisseurs.Click, btn_formats.Click, btn_emplacements.Click, btn_cours.Click, btn_categories.Click

    End Sub
    ''' <summary>
    ''' Méthode qui gère l'événement du clic sur le bouton btn_deconnexion, ajout d'un message de confirmation lors de la déconnexion.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub btn_deconnexion_Click(sender As Object, e As EventArgs) Handles btn_deconnexion.Click

        Dim result = MessageBox.Show("Êtes-vous certain de vouloir vous déconnecter ?                    (tous les éléments non sauvegardés seront perdus)", "Déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            frm_connexion.Show()
            Me.ParentForm.Close()
        End If
    End Sub
#End Region
End Class
