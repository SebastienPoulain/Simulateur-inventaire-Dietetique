Imports MySql.Data.MySqlClient

Public Class usr_exercices_E
    'Attributs reliés à la gestion de la bd.'
    Dim strRequete As String
    Dim table As String
    Dim gestionBd As New Connexion
    Dim dataAdapter As New MySqlDataAdapter
    Dim dsExerc As DataSet
    Dim dsUtls As DataSet
    Dim dsExerc2 As DataSet


    Dim _utls_conn As Utilisateur
    Dim _no_cours As String
    Dim exerc_selectionnee As Integer = -1
    Dim lstEx As New List(Of usr_exerc_lst_E)
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
    End Sub

    Private Sub usr_exercices_Load(sender As Object, e As EventArgs) Handles Me.Load
        recupererEx()
        creerLst()
        majExercice()
    End Sub

    'Met à jour l'exercice sélectionné.'
    Public Sub majExercice()



        For Each ex In lstEx
                If ex.Numero <> exerc_selectionnee Then
                    ex.changer_couleur_defaut()
                Else

                    strRequete = "select `actif_prof`  
                      from `tbl_exercices` 
                      where `no_exercice` = " & ex.Numero
                    table = "tbl_exercices"

                    gestionBd.miseAjourDS(dsExerc2, dataAdapter, strRequete, table)

                    If dsExerc2.Tables(0).Rows(0).Item(0) = True Then
                        ex.changer_couleur_selection()
                        frmP.ExercSelectionne = exerc_selectionnee
                    Else
                        ex.changer_couleur_defaut()
                    End If
                End If
            Next
            Exercice_Encore_Actif()
        frmP.Exercice_Selectionnee()

    End Sub

    'Vérifie si l'exercice est encore actif.'
    Private Sub Exercice_Encore_Actif()
        strRequete = "select `actif_prof`  
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




    'Récupère les exercices.'
    Private Sub recupererEx()
        strRequete = "select `no_exercice`, `nom_travail`, `description`,`actif_prof`, `Date_remise`  
                      from `tbl_exercices` 
                      where `no_cours` = '" & _no_cours & "'
                      order by no_exercice desc;"
        table = "tbl_exercices"

        gestionBd.miseAjourDS(dsExerc, dataAdapter, strRequete, table)
    End Sub

    'Crée la liste d'exercice.'
    Private Sub creerLst()
        Dim pos As Integer = 50

        With dsExerc.Tables(0)
            Dim no As Integer = .Rows.Count
            For i As Integer = 0 To .Rows.Count - 1
                If .Rows(i).Item(3) Then
                    Dim usr_test As New usr_exerc_lst_E(.Rows(i).Item(0), .Rows(i).Item(1), .Rows(i).Item(2), .Rows(i).Item(3), no, .Rows(i).Item(4), Me)
                    lstEx.Add(usr_test)

                    pnl_principal_ex.Controls.Add(usr_test)
                    usr_test.Location = New Point(17, pos)
                    usr_test.BringToFront()
                    pos += 100
                End If
                no -= 1
            Next

        End With
    End Sub

    Private Sub pnl_principal_ex_Paint(sender As Object, e As PaintEventArgs) Handles pnl_principal_ex.Paint

    End Sub
End Class
