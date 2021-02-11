Imports MySql.Data.MySqlClient

Public Class usr_profil
    'Attributs reliés à la gestion de la bd.'
    Dim strRequete As String
    Dim table As String
    Dim gestionBd As New Connexion
    Dim dataAdapter As New MySqlDataAdapter
    Dim dsCours As DataSet


    Dim utls_conn As Utilisateur

    Property UtlsConn As Utilisateur
        Get
            Return utls_conn
        End Get
        Set(value As Utilisateur)
            utls_conn = value
        End Set
    End Property

    Public Sub New(utls As Utilisateur)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        utls_conn = utls
        MAJ()
    End Sub

    Private Sub MAJ()
        RemplirInfo()
        RecupererCours()
    End Sub

#Region "Info Compte"

    'Remplis les labels du compte.'
    Private Sub RemplirInfo()
        lbl_identifiant.Text = utls_conn.No_id
        lbl_pnm.Text = utls_conn.Prenom_personne
        lbl_nom.Text = utls_conn.Nom_personne
        utls_conn.TitreLong = ConvertirTitre(utls_conn.Titre)
        lbl_titre.Text = utls_conn.TitreLong
    End Sub

    'Changer de nom.'
    Private Sub btn_nom_Click(sender As Object, e As EventArgs) Handles btn_nom.Click
        Dim frm_nm As New frm_modifierNom(lbl_nom.Text, "Modifier mon nom", "Nouveau nom")

        frm_nm.ShowDialog()

        strRequete = "update `tbl_utilisateurs` set `nom_personne` = '" & mod_regex.ConvertirApostrophe(frm_nm.Nom) & "' WHERE `no_utilisateur` = '" & utls_conn.No_id & "';"

        Try
            gestionBd.InsDelUpd(strRequete)

            utls_conn.Nom_personne = frm_nm.Nom

            lbl_nom.Text = utls_conn.Nom_personne
        Catch ex As Exception
        End Try
    End Sub

    'Changer de prénom.'
    Private Sub btn_prenom_Click(sender As Object, e As EventArgs) Handles btn_pnm.Click
        Dim frm_pnm As New frm_modifierNom(lbl_pnm.Text, "Modifier mon prénom", "Nouveau prénom")

        frm_pnm.ShowDialog()

        strRequete = "update `tbl_utilisateurs` set `prenom_personne` = '" & mod_regex.ConvertirApostrophe(frm_pnm.Nom) & "' WHERE `no_utilisateur` = '" & utls_conn.No_id & "';"

        Try
            gestionBd.InsDelUpd(strRequete)
            utls_conn.Prenom_personne = frm_pnm.Nom

            lbl_pnm.Text = utls_conn.Prenom_personne
        Catch ex As Exception
        End Try
    End Sub

    'Changement de mot de passe.'
    ''' <summary>
    ''' Méthode qui gère l'événement du clic sur le bouton btn_mdp, permet de changer de mot de passe, ajoute le nouveau mot de passe crypté dans la base de données.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>

    Private Sub btn_mdp_Click(sender As Object, e As EventArgs) Handles btn_mdp.Click
        Dim frm_mdp As New frm_changer_mdp(utls_conn.Mot_de_passe)

        frm_mdp.ShowDialog()

        If frm_mdp.MotDePasse <> utls_conn.Mot_de_passe Then
            strRequete = "update `tbl_utilisateurs` set `mot_de_passe` = '" & GetMd5Hash(frm_mdp.MotDePasse) & "' WHERE `no_utilisateur` = '" & utls_conn.No_id & "';"

            Try
                gestionBd.InsDelUpd(strRequete)
                utls_conn.Mot_de_passe = GetMd5Hash(frm_mdp.MotDePasse)
            Catch ex As Exception
            End Try
        End If
    End Sub


    'Convertit le titre court au titre au long.'
    Private Function ConvertirTitre(titre As String)
        Select Case titre
            Case "e"
                Return "Étudiant"
            Case "p"
                Return "Enseignant"
            Case "a"
                Return "Administrateur"
            Case Else
                Return "Étudiant"
        End Select
    End Function
#End Region


#Region "cours"

    Private Sub RecupererCours()
        If utls_conn.Titre = "e"c Then


            If grid_cours.ColumnCount < 3 Then
                grid_cours.Columns.Add("Column3", "Nom de professeur")
                grid_cours.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End If

            strRequete = "Select c.`no_cours`, `nom_cours`, 

                          (select concat(u.`prenom_personne`,concat(' ',u.`nom_personne`)) from tbl_utilisateurs u, tbl_cours_prof ip
                           where u.no_utilisateur=ip.no_utilisateur
                           and ip.no_cours = c.no_cours) as nom

                          from tbl_cours c, tbl_cours_utilisateur cu, tbl_utilisateurs u
                          where c.no_cours = cu.no_cours and cu.no_utilisateur = u.no_utilisateur
                          and u.no_utilisateur = '" & utls_conn.No_id & "';"

            table = "tbl_cours"


            gestionBd.miseAjourDS(dsCours, dataAdapter, strRequete, table)

            remplirCours()
            'ElseIf utls_conn.Titre = "p"c Then

            '    If grid_cours.ColumnCount = 3 Then
            '        grid_cours.Columns.RemoveAt(2)
            '    End If

            '    strRequete = "Select c.`no_cours`, `nom_cours`
            '                  from tbl_cours c, tbl_cours_prof ip
            '                  where ip.no_utilisateur='" & utls_conn.No_id & "'
            '                  and ip.no_cours = c.no_cours;"

            '    table = "tbl_cours"


            '    gestionBd.miseAjourDS(dsCours, dataAdapter, strRequete, table)


            '    remplirCours()
        Else
            pnl_cours.Visible = False

            Return
        End If
    End Sub

    Private Sub remplirCours()
        grid_cours.Rows.Clear()
        With dsCours.Tables(0)
            For i As Integer = 0 To .Rows.Count - 1
                grid_cours.Rows.Add(.Rows(i).Item(0))
                For j As Integer = 1 To grid_cours.ColumnCount - 1
                    grid_cours.Rows(grid_cours.Rows.Count - 1).Cells(j).Value = .Rows(i).Item(j)
                Next
            Next
        End With
    End Sub

#End Region


#Region "autres"

    'Couleur du bouton créer.'
    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btn_nom.MouseEnter, btn_mdp.MouseEnter, btn_pnm.MouseEnter
        sender.BackColor = Color.White
        sender.ForeColor = Color.Black
    End Sub

    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btn_nom.MouseLeave, btn_mdp.MouseLeave, btn_pnm.MouseLeave
        sender.BackColor = Color.FromArgb(52, 73, 94)
        sender.ForeColor = SystemColors.Control
    End Sub

    Private Sub btn_MouseEnter(sender As Object, e As EventArgs) Handles btn_nom.MouseEnter, btn_mdp.MouseEnter, btn_pnm.MouseEnter

    End Sub

    Private Sub btn_MouseLeave(sender As Object, e As EventArgs) Handles btn_nom.MouseLeave, btn_mdp.MouseLeave, btn_pnm.MouseLeave

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
#End Region
End Class
