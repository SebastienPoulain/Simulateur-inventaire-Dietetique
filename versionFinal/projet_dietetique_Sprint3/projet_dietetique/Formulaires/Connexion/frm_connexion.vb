
Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class frm_connexion
    Dim bd As New Connexion

    Dim usr_connexion As usr_connexionUtls
    Dim user_connexion2 As usr_connexionCours
    Dim defaultLocation As Point
    Dim mouvementFenetre As Boolean

    'Load.'
    Private Sub frm_connexion_copie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not bd.test_connexion() Then
            MessageBox.Show("Impossible de se connecter à la base de données." & vbNewLine & "Contactez votre administrateur.",
                        "Connexion impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Application.Exit()
        End If

        defaultLocation = Me.Location
        Reset()
    End Sub

    'Reset la page complètement.'
    Public Sub Reset()
        retrecirFenetre()


        usr_connexion = New usr_connexionUtls(Me)
        pnl_connexion.Controls.Add(usr_connexion)
        usr_connexion.Dock = DockStyle.Fill
        usr_connexion.BringToFront()
    End Sub

    'Swith le user du début vers celui avec la liste de cours.'
    Public Sub ProchainUser(utls As Utilisateur)
        Dim user_connexion2 As New usr_connexionCours(utls, Me)
        pnl_connexion.Controls.Add(user_connexion2)

        aggrandirFenetre()

        user_connexion2.Dock = DockStyle.Fill
        user_connexion2.BringToFront()
    End Sub

    'Lance l'aggrandissement de la fenêtre.'
    Private Sub aggrandirFenetre()
        pnl_connexion.Visible = False
        mouvementFenetre = True
        tmr_fenetre.Start()
    End Sub

    'Lance le retrecissement.'
    Private Sub retrecirFenetre()
        pnl_connexion.Visible = False
        mouvementFenetre = False
        tmr_fenetre.Start()
    End Sub

    'Tick du timer.'
    Private Sub tmr_fenetre_Tick(sender As Object, e As EventArgs) Handles tmr_fenetre.Tick
        If mouvementFenetre Then
            Aggrandir()
        Else
            Retrecir()
        End If
    End Sub

    Private Sub Aggrandir()
        If Me.Size.Height < 380 Then
            Me.Location = New Point(Me.Location.X, Me.Location.Y - 10)
            Me.Size = New Size(Me.Size.Width, Me.Size.Height + 10)
        Else
            tmr_fenetre.Stop()
            pnl_connexion.Size = New Size(pnl_connexion.Size.Width, Me.Size.Height - 29)
            pnl_connexion.Visible = True
        End If
    End Sub

    Private Sub Retrecir()
        If Me.Size.Height > 285 Then
            Me.Location = New Point(Me.Location.X, Me.Location.Y + 10)
            Me.Size = New Size(Me.Size.Width, Me.Size.Height - 10)
        Else
            tmr_fenetre.Stop()
            pnl_connexion.Size = New Size(pnl_connexion.Size.Width, Me.Size.Height - 29)
            pnl_connexion.Visible = True
        End If
    End Sub


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
    ''' méthode qui gère l'événement du clic sur le bouton btn_exit.
    ''' Ajout d'un message de confirmation pour valider les intentions de l'utilisateur.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Dim result = MessageBox.Show("Êtes-vous certain de vouloir quitter l'application ? ", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pnl_connexion_Paint(sender As Object, e As PaintEventArgs) Handles pnl_connexion.Paint

    End Sub

#End Region

End Class