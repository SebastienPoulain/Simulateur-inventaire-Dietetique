Imports MySql.Data.MySqlClient

Public Class usr_connexionCours
    'Attributs reliés à la gestion de la bd.'
    Dim strRequete As String
    Dim table As String
    Dim gestionBd As New Connexion
    Dim dataAdapter As New MySqlDataAdapter
    Dim dsCours As DataSet

    Dim utls_conn As Utilisateur
    Dim frm_conn As frm_connexion

    Public Sub New(utls As Utilisateur, frm_con As frm_connexion)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        utls_conn = utls
        frm_conn = frm_con
        RecupererCours()
        SiAucunCours()
        Me.Focus()
    End Sub

    'Vérification si l'utilisateur a des cours.'
    Private Sub SiAucunCours()
        If grid_cours.RowCount = 0 Then
            pnl_aucun.Visible = True
        End If
    End Sub



    'Bouton poursuivre.'
    ''' <summary>
    '''  Méthode qui gère l'événement du double clic, elle fait afficher le formulaire principal lorsque l'on double clic sur un cours.
    '''  fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>

    Private Sub connexion(sender As Object, e As EventArgs) Handles grid_cours.DoubleClick
        Dim frm_principal As New frmDietetique(utls_conn, grid_cours.CurrentRow.Cells(0).Value.ToString)
        frm_principal.Show()
        frm_conn.Close()
    End Sub


    'Bouton retour.'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_retour.Click
        frm_conn.Reset()
    End Sub

#Region "cours"

    Private Sub RecupererCours()
        If utls_conn.Titre = "e"c Then


            If grid_cours.ColumnCount < 3 Then
                grid_cours.Columns.Add("Column3", "Nom de professeur")
                grid_cours.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End If

            strRequete = "Select c.`no_cours`, `nom_cours`, 

                          (select concat(u.`prenom_personne`,concat(', ',u.`nom_personne`)) from tbl_utilisateurs u, tbl_cours_prof ip
                           where u.no_utilisateur=ip.no_utilisateur
                           and ip.no_cours = c.no_cours) as nom

                          from tbl_cours c, tbl_cours_utilisateur cu, tbl_utilisateurs u
                          where c.no_cours = cu.no_cours and cu.no_utilisateur = u.no_utilisateur
                          and u.no_utilisateur = '" & utls_conn.No_id & "'
                          and c.actif = 1;"

            table = "tbl_cours"

            Try
                gestionBd.miseAjourDS(dsCours, dataAdapter, strRequete, table)
            Catch
            End Try

            remplirCours()
        ElseIf utls_conn.Titre = "p"c Then

            If grid_cours.ColumnCount = 3 Then
                grid_cours.Columns.RemoveAt(2)
            End If

            strRequete = "Select c.`no_cours`, `nom_cours`
                          from tbl_cours c, tbl_cours_prof ip
                          where ip.no_utilisateur='" & utls_conn.No_id & "'
                          and ip.no_cours = c.no_cours
                          and c.actif = 1;"

            table = "tbl_cours"

            Try
                gestionBd.miseAjourDS(dsCours, dataAdapter, strRequete, table)
            Catch
            End Try

            remplirCours()
        Else
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


    'Couleur des boutons.'
    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btn_retour.MouseEnter

        sender.BackColor = Color.White
        sender.ForeColor = Color.Black
    End Sub

    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btn_retour.MouseLeave

        sender.BackColor = Color.FromArgb(52, 73, 94)
        sender.ForeColor = SystemColors.Control
    End Sub

    Private Sub pnl_aucun_Paint(sender As Object, e As PaintEventArgs) Handles pnl_aucun.Paint

    End Sub

    Private Sub btn_poursuivre_Click(sender As Object, e As EventArgs)

    End Sub
End Class
