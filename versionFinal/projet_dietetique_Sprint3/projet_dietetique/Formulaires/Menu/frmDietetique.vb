Imports System.Data.Sql
Imports MySql.Data.MySqlClient

''' <summary>
''' Formulaire principal où vont apparaître les contrôles utilisateurs dans un panel de taille 1280 par 655.
''' Cliquer sur un des boutons de la barre de menu va faire apparaître le contrôle utilisateur associé au texte à l'intérieur.
''' </summary>

Public Class frmDietetique

    ''' <summary> 
    ''' La section choisie va principalement affecter les procédures liées à la barre de menu et à sa navigation.
    ''' <seealso cref="boutons_Click"/><seealso cref="boutons_MouseHover"/><seealso cref="boutons_MouseLeave"/><seealso cref="adapter_couleurs()"/>
    ''' </summary>
    Public section_choisie As String = "Exercices"
    Dim utls As Utilisateur
    Dim cours As String
    Dim exerc As Integer
    Dim usr_comm As usr_commandes
    Dim usr_gestion As usr_gestion_admin
    Dim usr_prod As usr_produits
    Dim usr_ex_e As usr_exercices_E
    Dim usr_ex_p As usr_exercices
    Dim usr_ex_a As usr_exercices_A
    Dim usr_inv_e As usr_inventaire_e
    Dim usr_inv_p As usr_inventaire_P

    ''' <summary>
    ''' création des usr Recette et Recette Exercice
    ''' <tag> 2019 > </tag>
    ''' </summary>
    ''' 
    Dim usr_exerc_lst_e As usr_exerc_lst_E
    Dim usr_recette_ex As usr_recette_exercice
    Dim usr_recette_etu As usr_recette_etu
    Dim usr_recette As recette



    Property ExercSelectionne()
        Get
            Return exerc
        End Get
        Set(value)
            exerc = value
        End Set
    End Property

    Public Sub Exercice_Selectionnee()
        If exerc <> 0 Then
            btnCommandes.Enabled = True
            btnInventaire.Enabled = True
        Else
            btnCommandes.Enabled = False
            If utls.Titre <> "p"c Then
                btnInventaire.Enabled = False
            End If
        End If


    End Sub

    Public Sub RechargerExercice()
        pnl_simulation_inventaire.Controls.Remove(usr_inv_e)
        pnl_simulation_inventaire.Controls.Remove(usr_inv_p)
        pnl_simulation_inventaire.Controls.Remove(usr_prod)
        pnl_simulation_inventaire.Controls.Remove(usr_comm)
    End Sub





    Private Sub frmDietetique_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Adapter_UserControl(btnExercices)
        Adapter_Couleurs()
    End Sub

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        utls = New Utilisateur("keven", "kev", "kev", "kev", "a"c)
        cours = "120-104-RI-01"
        Verifier_Titre(utls.Titre)
    End Sub

    Public Sub New(_utls As Utilisateur)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        utls = _utls
        Verifier_Titre(utls.Titre)
    End Sub

    Public Sub New(_utls As Utilisateur, _cours As String)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        utls = _utls
        cours = _cours

        Verifier_Titre(utls.Titre)
    End Sub

    ''' <summary>
    ''' Procédure pour vérifier le titre de l'utilisateur.
    ''' Le titre passé en paramètre va faire la distinction entre un utilisateur étudiant (e), enseignant (p), ou administrateur (a).
    ''' Les droits vont différer selon le titre.
    ''' </summary>
    Private Sub Verifier_Titre(titre As Char)
        Select Case titre
            Case "e"c
                btnGestion.Visible = True
                btnGestion.Tag = "e"
            Case "p"c
                btnGestion.Visible = True
                btnGestion.Tag = "p"
            Case "a"c
                btnGestion.Visible = True
                btnInventaire.Enabled = False
                btnCommandes.Enabled = False
                btnGestion.Tag = "a"
        End Select
    End Sub

#Region "Manipulation du menu"
    ''' <description>
    ''' Cette région est dédiée à la manipulation du menu en raison d'un besoin de faciliter l'identification de où l'utilisateur se situe dans le logiciel.
    ''' 
    ''' <fonctionnalites>
    ''' Changement de couleurs des boutons lorsqu'on passe le curseur de la souris dessus.
    ''' Vérification du bouton cliqué (style onglet) par <variable name="section_choisie"/>.
    ''' </fonctionnalites>
    ''' </description>

    Private Sub Boutons_Click(sender As Button, e As EventArgs) Handles btnExercices.Click, btnProduits.Click, btnInventaire.Click,
                                                                        btnCommandes.Click, btnGestion.Click, btnRecette.Click
        Dim btn As Button = sender

        If btn.Text = section_choisie Then
            Return
        End If

        ' If btn.Text <> btnRecette.Text Then
        section_choisie = btn.Text
            Adapter_Couleurs()
            Adapter_UserControl(btn)
        'Else
        '    frm_connexion.Show()
        '    Me.Close()
        'End If

    End Sub

    Private Sub Boutons_MouseHover(sender As Button, e As EventArgs) Handles btnExercices.MouseEnter, btnProduits.MouseEnter, btnRecette.MouseEnter,
                                                                             btnInventaire.MouseEnter, btnCommandes.MouseEnter, btnGestion.MouseEnter
        sender.BackColor = SystemColors.Control
        sender.ForeColor = Color.Black
    End Sub

    Private Sub Boutons_MouseLeave(sender As Button, e As EventArgs) Handles btnExercices.MouseLeave, btnProduits.MouseLeave, btnRecette.MouseLeave,
                                                                             btnInventaire.MouseLeave, btnCommandes.MouseLeave, btnGestion.MouseLeave
        Adapter_Couleurs()
        sender.ForeColor = SystemColors.Control
        If sender.Text = section_choisie Then
            sender.ForeColor = Color.Black
        End If
    End Sub

    ''' <summary>
    ''' Adapte la couleur des boutons du menu selon celui qui est sélectionné.
    ''' </summary>
    Sub Adapter_Couleurs()
        Dim tab_boutons() As Button = {btnExercices, btnProduits, btnInventaire, btnCommandes, btnGestion, btnRecette}

        For i = 0 To tab_boutons.Count - 1
            If tab_boutons(i).Text <> section_choisie Then
                tab_boutons(i).BackColor = Color.FromArgb(44, 62, 80)
                tab_boutons(i).ForeColor = SystemColors.Control
            Else
                tab_boutons(i).BackColor = SystemColors.Control
                tab_boutons(i).ForeColor = Color.Black
            End If
        Next

    End Sub

    ''' <summary>
    ''' Détermine quel controle utilisateur est présenté.
    ''' </summary>
    ''' <param name="btn">Bouton de la section sélectionnée.</param>
    ''' 
    Sub Adapter_UserControl(btn As Button)

        Select Case btn.Text

            'les parametres qui gére les usr_control des recette
            '<tag 2019 > </tag>

            Case btnRecette.Text

                Select Case utls.Titre

                    Case "a"c

                        usr_recette = New recette(utls, cours, exerc)
                        usr_recette_ex = New usr_recette_exercice(utls, cours, exerc)
                        pnl_simulation_inventaire.Controls.Add(usr_recette)
                        usr_recette.Dock = DockStyle.Fill
                        usr_recette.BringToFront()

                    Case "p"c

                        usr_recette = New recette(utls, cours, exerc)
                        usr_recette_ex = New usr_recette_exercice(utls, cours, exerc)
                        pnl_simulation_inventaire.Controls.Add(usr_recette)
                        usr_recette.Dock = DockStyle.Fill
                        usr_recette.BringToFront()

                    Case "e"c
                        If Not pnl_simulation_inventaire.Controls.Contains(usr_recette_etu) Then
                            usr_recette_etu = New usr_recette_etu(utls, cours, exerc)
                            pnl_simulation_inventaire.Controls.Add(usr_recette_etu)
                            usr_recette_etu.Dock = DockStyle.Fill
                            usr_recette_etu.BringToFront()
                        Else
                            usr_recette_etu = New usr_recette_etu(utls, cours, exerc)
                            pnl_simulation_inventaire.Controls.Add(usr_recette_etu)
                            usr_recette_etu.Dock = DockStyle.Fill
                            usr_recette_etu.BringToFront()
                        End If
                    Case Else
                End Select




            Case btnCommandes.Text

                If Not pnl_simulation_inventaire.Controls.Contains(usr_comm) Then
                            usr_comm = New usr_commandes(utls, cours, exerc)
                            pnl_simulation_inventaire.Controls.Add(usr_comm)
                            usr_comm.Dock = DockStyle.Fill
                            usr_comm.BringToFront()
                        Else

                    usr_comm.BringToFront()
                End If


            Case btnGestion.Text
                If Not pnl_simulation_inventaire.Controls.Contains(usr_gestion) Then
                    usr_gestion = New usr_gestion_admin(utls)
                    pnl_simulation_inventaire.Controls.Add(usr_gestion)
                    usr_gestion.Dock = DockStyle.Fill
                    usr_gestion.BringToFront()
                Else
                    pnl_simulation_inventaire.Controls.Remove(usr_gestion)
                    usr_gestion = New usr_gestion_admin(utls)
                    pnl_simulation_inventaire.Controls.Add(usr_gestion)
                    usr_gestion.Dock = DockStyle.Fill
                    usr_gestion.BringToFront()
                End If

            Case btnProduits.Text
                Select Case utls.Titre

                    Case "e"c

                        If Not pnl_simulation_inventaire.Controls.Contains(usr_prod) Then
                            usr_prod = New usr_produits
                            usr_prod.btnAjouter.Visible = False
                            usr_prod.btnAjouter.Enabled = False
                            pnl_simulation_inventaire.Controls.Add(usr_prod)
                            usr_prod.Dock = DockStyle.Fill
                            usr_prod.BringToFront()
                        Else
                            usr_prod.BringToFront()
                        End If

                    Case Else

                        If Not pnl_simulation_inventaire.Controls.Contains(usr_prod) Then
                            usr_prod = New usr_produits
                            pnl_simulation_inventaire.Controls.Add(usr_prod)
                            usr_prod.Dock = DockStyle.Fill
                            usr_prod.BringToFront()
                        Else
                            usr_prod.BringToFront()
                        End If

                End Select



            Case btnExercices.Text
                Select Case utls.Titre
                    Case "e"c
                        If Not pnl_simulation_inventaire.Controls.Contains(usr_ex_e) Then
                            usr_ex_e = New usr_exercices_E(utls, cours, Me)
                            pnl_simulation_inventaire.Controls.Add(usr_ex_e)
                            usr_ex_e.Dock = DockStyle.Fill
                            usr_ex_e.BringToFront()
                        Else
                            pnl_simulation_inventaire.Controls.Remove(usr_ex_e)
                            usr_ex_e = New usr_exercices_E(utls, cours, Me)
                            pnl_simulation_inventaire.Controls.Add(usr_ex_e)
                            usr_ex_e.Dock = DockStyle.Fill
                            usr_ex_e.BringToFront()
                        End If
                    Case "p"c
                        If Not pnl_simulation_inventaire.Controls.Contains(usr_ex_p) Then
                            usr_ex_p = New usr_exercices(utls, cours, Me)
                            pnl_simulation_inventaire.Controls.Add(usr_ex_p)
                            usr_ex_p.Dock = DockStyle.Fill
                            usr_ex_p.BringToFront()
                        Else
                            pnl_simulation_inventaire.Controls.Remove(usr_ex_p)
                            usr_ex_p = New usr_exercices(utls, cours, Me)
                            pnl_simulation_inventaire.Controls.Add(usr_ex_p)
                            usr_ex_p.Dock = DockStyle.Fill
                            usr_ex_p.BringToFront()
                        End If

                    Case "a"c
                        If Not pnl_simulation_inventaire.Controls.Contains(usr_ex_a) Then
                            usr_ex_a = New usr_exercices_A
                            pnl_simulation_inventaire.Controls.Add(usr_ex_a)
                            usr_ex_a.Dock = DockStyle.Fill
                            usr_ex_a.BringToFront()
                        Else
                            pnl_simulation_inventaire.Controls.Remove(usr_ex_a)
                            usr_ex_a = New usr_exercices_A
                            pnl_simulation_inventaire.Controls.Add(usr_ex_a)
                            usr_ex_a.Dock = DockStyle.Fill
                            usr_ex_a.BringToFront()
                        End If

                    Case Else

                End Select

            Case btnInventaire.Text
                Select Case utls.Titre
                    Case "e"c
                        If Not pnl_simulation_inventaire.Controls.Contains(usr_inv_e) Then
                            usr_inv_e = New usr_inventaire_e(utls, cours, exerc, Me)
                            pnl_simulation_inventaire.Controls.Add(usr_inv_e)
                            usr_inv_e.Dock = DockStyle.Fill
                            usr_inv_e.BringToFront()
                        Else
                            usr_inv_e.BringToFront()
                        End If
                    Case "p"c
                        If Not pnl_simulation_inventaire.Controls.Contains(usr_inv_p) Then
                            usr_inv_p = New usr_inventaire_P(utls, cours, exerc, Me)
                            pnl_simulation_inventaire.Controls.Add(usr_inv_p)
                            usr_inv_p.Dock = DockStyle.Fill
                            usr_inv_p.BringToFront()
                        Else
                            usr_inv_p.BringToFront()
                        End If

                    Case Else
                        If Not pnl_simulation_inventaire.Controls.Contains(usr_inv_e) Then
                            usr_inv_e = New usr_inventaire_e(utls, cours, exerc, Me)
                            pnl_simulation_inventaire.Controls.Add(usr_inv_e)
                            usr_inv_e.Dock = DockStyle.Fill
                            usr_inv_e.BringToFront()
                        Else
                            usr_inv_e.BringToFront()
                        End If
                End Select

        End Select
    End Sub
#End Region

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
    ''' <summary>
    ''' méthode qui gère l'événement du clique du bouton btn_exit.
    ''' Ajout du message de confirmation pour savoir si l'utilisateur veut vraiment quitter l'application
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Dim result = MessageBox.Show("Êtes-vous certain de vouloir quitter l'application ?                    (tous les éléments non sauvegardés seront perdus)", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pnl_navigation_Paint(sender As Object, e As PaintEventArgs) Handles pnl_navigation.Paint

    End Sub

    Private Sub Boutons_Click(sender As Object, e As EventArgs) Handles btnProduits.Click, btnInventaire.Click, btnGestion.Click, btnExercices.Click, btnRecette.Click, btnCommandes.Click

    End Sub

    Private Sub pnl_simulation_inventaire_Paint(sender As Object, e As PaintEventArgs) Handles pnl_simulation_inventaire.Paint

    End Sub
#End Region
End Class