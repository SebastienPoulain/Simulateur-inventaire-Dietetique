Imports MySql.Data.MySqlClient

Public Class usr_exercices
    'Attributs reliés à la gestion de la bd.'
    Dim strRequete As String
    Dim table As String
    Dim gestionBd As New Connexion
    Dim dataAdapter As New MySqlDataAdapter
    Dim dsExerc As DataSet
    Dim dsExerc2 As DataSet

    Dim lstEx As New List(Of usr_exerc_lst_P)
    Dim _utls_conn As Utilisateur
    Dim _no_cours As String
    Dim exerc_selectionnee As Integer = -1
    Public frmP As frmDietetique

    Property Selection As Integer
        Get
            Return exerc_selectionnee
        End Get
        Set(value As Integer)
            exerc_selectionnee = value
        End Set
    End Property


    Public Sub New(utls As Utilisateur, no_cours As String, frm As frmDietetique)
        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        _utls_conn = utls
        _no_cours = no_cours
        frmP = frm
        exerc_selectionnee = frmP.ExercSelectionne
        cbo_statut.SelectedIndex = 1
    End Sub
    ''' <summary>
    '''  Méthode load, changement de l'index du statut par défaut de 1 à 0 pour afficher tous.
    '''  fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>

    Private Sub usr_exercices_Load(sender As Object, e As EventArgs) Handles Me.Load
        recupererEx()
        creerLst()
        majExercice()
        cbo_statut.SelectedIndex = 0
    End Sub

    'Met à jour l'exercice sélectionné.'
    Public Sub majExercice()


        For Each ex In lstEx
            If ex.Numero <> exerc_selectionnee Then
                ex.changer_couleur_defaut()
            Else
                ex.changer_couleur_selection()
                frmP.ExercSelectionne = exerc_selectionnee
            End If
        Next
        frmP.Exercice_Selectionnee()
        Exercice_Encore_Actif()
    End Sub

    'Vérifie si l'exercice est encore actif.'
    Private Sub Exercice_Encore_Actif()
        strRequete = "select `actif`  
                      from `tbl_exercices` 
                      where `no_exercice` = " & frmP.ExercSelectionne
        table = "tbl_exercices"

        gestionBd.miseAjourDS(dsExerc2, dataAdapter, strRequete, table)
        If dsExerc2.Tables(0).Rows.Count > 0 Then
            If dsExerc2.Tables(0).Rows(0).Item(0) = 0 Then
                frmP.ExercSelectionne = 0
            End If
        End If
    End Sub

    'Créer un exercice.'
    Private Sub btn_creer_Click(sender As Object, e As EventArgs) Handles btn_creer.Click
        Dim frm_modif As New frm_modifier_exercice(_utls_conn, _no_cours)
        frm_modif.ShowDialog()

        If frm_modif.Modif Then
            recupererEx()
            creerLst()
            majExercice()
        End If
    End Sub

    'Recherche.'
    Private Sub cbo_statut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_statut.SelectedIndexChanged
        recupererEx()
        creerLst()
        majExercice()
        btn_creer.Focus()
    End Sub

    'Récupère les exercices.'
    Public Sub recupererEx()
        strRequete = "select `no_exercice`, `nom_travail`, `description`, `actif_prof`, `Date_remise`  
                      from `tbl_exercices` 
                      where `no_cours` = '" & _no_cours & "'"


        If cbo_statut.SelectedIndex = 1 Then
            strRequete &= "and `actif_prof` = 1 "
        ElseIf cbo_statut.SelectedIndex = 2 Then
            strRequete &= "and `actif_prof` = 0 "
        End If

        strRequete &= " and `actif` = 1 
                        ORDER by no_exercice desc;"

        table = "tbl_exercices"

        gestionBd.miseAjourDS(dsExerc, dataAdapter, strRequete, table)
    End Sub

    'Crée la liste.'
    Public Sub creerLst()
        Dim pos As Integer = 25
        pnl_principal_ex.Controls.Clear()

        Cursor = Cursors.AppStarting
        With dsExerc.Tables(0)

            Dim no As Integer = .Rows.Count
            For i As Integer = 0 To .Rows.Count - 1
                Dim usr_test As New usr_exerc_lst_P(.Rows(i).Item(0), .Rows(i).Item(1), .Rows(i).Item(2), .Rows(i).Item(3), no, .Rows(i).Item(4), Me)
                lstEx.Add(usr_test)

                pnl_principal_ex.Controls.Add(usr_test)
                usr_test.Location = New Point(17, pos)
                usr_test.BringToFront()
                pos += 100
                no -= 1
            Next
            Cursor = Cursors.Default
        End With
    End Sub

    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btn_creer.MouseEnter, btn_restaure.MouseEnter
        sender.BackColor = Color.White
        sender.ForeColor = Color.Black
    End Sub
    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btn_creer.MouseLeave, btn_restaure.MouseLeave
        sender.BackColor = Color.FromArgb(52, 73, 94)
        sender.ForeColor = SystemColors.Control
    End Sub

    Private Sub btn_MouseEnter(sender As Object, e As EventArgs) Handles btn_creer.MouseEnter

    End Sub

    Private Sub btn_MouseLeave(sender As Object, e As EventArgs) Handles btn_creer.MouseLeave

    End Sub

    Private Sub btn_restaure_Click(sender As Object, e As EventArgs) Handles btn_restaure.Click
        recupererEx()
        creerLst()
        majExercice()
    End Sub
End Class
