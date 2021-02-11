Imports System.IO
Imports MySql.Data.MySqlClient
''' <summary>
''' <tag > 2019 </tag>
''' le usr_recette_exercie permet d'afficher les recettes et exercies puis de les associer ensemble Pour les admins et professeurs
''' </summary>
Public Class usr_recette_exercice

    Dim gestionBdRecetteExercice As New Connexion
    Dim strRequete As String
    Dim table As String
    Dim dataAdapter As New MySqlDataAdapter
    Dim dsRecette As DataSet
    Dim dsExerc As DataSet
    Dim dsRecetteExercice As DataSet
    Dim _utls_conn As Utilisateur
    Dim _no_cours As String
    Dim _exercice As String
    Dim exerciceCochees As New List(Of frm_modifier_exercice)
    Dim RecetteCochees As New List(Of recette)
    Dim Recette_exercice As String
    Dim tab_recette_exercice(longtab, 3) As String
    Dim longtab As Integer
    Dim ctr As Integer = 0
    Dim tab As Char() = {“,”}
    Dim recetteChoisie As String = ""
    Dim exerciceChoisie As String = ""
    Dim nomRecetteChoisie As String = ""
    Dim nomExerciceChoisie As String = ""
    Dim no_recette As Integer
    Dim no_ex As Integer
    Dim description As String
    Dim nom_recet As String

    Public Sub New(utls As Utilisateur, no_cours As String, exercice As String)
        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        _utls_conn = utls
        _no_cours = no_cours
        _exercice = exercice

    End Sub

    Public Sub New(_no_recette As Integer, _no_exercice As Integer, _nom_recette As String, _description As String)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        no_recette = _no_recette
        no_ex = _no_exercice
        nom_recet = _nom_recette
        description = _description

    End Sub



    ''' <summary>
    ''' appelle tous les élément utile pour l'affichage des interfaces
    ''' <tag > 2019 </tag>
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub usr_recette_exercice_Load(sender As Object, e As EventArgs) Handles MyBase.Paint
        recupererRecette()
        creerLstNomRecette()
        recupererEx()
        creerLstexercice()
        recupererRecetteExercice()
        creerlisteRecette_exercice_R_E()
    End Sub


    ''' <summary>
    ''' <tag > 2019 </tag>
    '''  permet de gerer le clic sur chacun des boutons qui seront générés
    ''' </summary>

    Private Sub evenenement_Cocher_R(sender As Object, e As EventArgs)
        Dim bouton As RadioButton = sender
        recetteChoisie = bouton.Name
        nomRecetteChoisie = bouton.Text

    End Sub


    ''' <summary>
    ''' <tag > 2019 </tag>
    ''' permet de gerer le clic sur chacun des boutons qui seront générés 
    ''' </summary>

    Private Sub evenenement_Cocher_E(sender As Object, e As EventArgs)
        Dim bouton As RadioButton = sender
        exerciceChoisie = bouton.Name
        nomExerciceChoisie = bouton.Text
    End Sub


    ''' <summary>
    ''' <tag > 2019 </tag>
    ''' récupére les exercices dans la Bd
    ''' </summary>

    Private Sub recupererEx()
        'si c'est l'administrateur il peu voir toute les exercice de tout les cour
        If _utls_conn.Titre = "a" Then

            strRequete = "select `no_exercice`, `nom_travail`, `description`, `actif`, `Date_remise`  
                      from `tbl_exercices` "

            'le prof à accée au exercice de sont cour
        Else
            strRequete = "select `no_exercice`, `no_cours`,`no_inventaire`,`nom_travail`, `description`,`actif`, `Date_remise`  
                      from `tbl_exercices` where `no_cours` = '" & _no_cours & "'"

            strRequete &= " and `actif` = 1 
                        ORDER by no_exercice desc;"
        End If

        table = "tbl_exercices"

        gestionBdRecetteExercice.miseAjourDS(dsExerc, dataAdapter, strRequete, table)
    End Sub


    ''' <summary>
    ''' <tag > 2019 </tag>
    ''' récupére les recette dans la Bd
    ''' </summary>
    Private Sub recupererRecette()
        strRequete = "select `no_recette`,`source_Img`,`source_doc` ,`nom_recette` 
                      from `tbl_recette`"

        table = "tbl_recette"

        gestionBdRecetteExercice.miseAjourDS(dsRecette, dataAdapter, strRequete, table)

    End Sub
    ''' <summary>
    ''' <tag > 2019 </tag>
    ''' vas chercher les recette et exercice dans la tbl_exercice_recette
    ''' </summary>

    Private Sub recupererRecetteExercice()
        strRequete = "select `no_recette`,`no_exercice`,`nom_recette`,`description`  
                      from `tbl_exercice_recette`"

        table = "tbl_exercice_recette"

        gestionBdRecetteExercice.miseAjourDS(dsRecetteExercice, dataAdapter, strRequete, table)


    End Sub

    ''' <summary>
    ''' <tag > 2019 </tag>
    ''' remplis la check list des recettes et exercice 
    ''' </summary>

    Private Sub creerlisteRecette_exercice_R_E()

        checkListR_E.Items.Clear()

        Cursor = Cursors.AppStarting
        With dsRecetteExercice.Tables(0)
            Dim no As Integer = .Rows.Count
            For i As Integer = 0 To .Rows.Count - 1
                Dim usr_E_R As New usr_recette_exercice(.Rows(i).Item(0), .Rows(i).Item(1), .Rows(i).Item(2), .Rows(i).Item(3))
                checkListR_E.Items.Add(.Rows(i).Item(0) & "," & .Rows(i).Item(1) & "," & .Rows(i).Item(2) & "," & .Rows(i).Item(3))
            Next
            Cursor = Cursors.Default
        End With

    End Sub

    ''' <summary>
    ''' <tag > 2019 </tag>
    '''  remplis la checklist des recettes enregistrer dans la BD
    ''' </summary>


    Private Sub creerLstNomRecette()
        RecetteCochees.Clear()
        Cursor = Cursors.AppStarting
        With dsRecette.Tables(0)
            Dim no As Integer = .Rows.Count
            For i As Integer = 0 To .Rows.Count - 1
                Dim usr_test As New recette(.Rows(i).Item(0), .Rows(i).Item(1), .Rows(i).Item(2), .Rows(i).Item(3))


                Dim bouton As New RadioButton
                bouton.Name = .Rows(i).Item(0)
                bouton.Text = .Rows(i).Item(3)
                bouton.Dock = DockStyle.Top

                AddHandler bouton.CheckedChanged, AddressOf evenenement_Cocher_R

                PanelRecette.Controls.Add(bouton)
            Next
            Cursor = Cursors.Default
        End With

    End Sub

    ''' <summary>
    ''' <tag > 2019 </tag>
    '''  remplis la checklist des exercice enregistrer danss la BD
    ''' </summary>

    Private Sub creerLstexercice()
        exerciceCochees.Clear()
        Cursor = Cursors.AppStarting
        With dsExerc.Tables(0)
            Dim no As Integer = .Rows.Count
            For i As Integer = 0 To .Rows.Count - 1

                Dim bouton As New RadioButton

                If _utls_conn.Titre = "a" Then

                    bouton.Name = .Rows(i).Item(0)
                    bouton.Text = .Rows(i).Item(1)
                    bouton.Dock = DockStyle.Top

                Else

                    bouton.Name = .Rows(i).Item(0)
                    bouton.Text = .Rows(i).Item(3)
                    bouton.Dock = DockStyle.Top

                End If

                AddHandler bouton.CheckedChanged, AddressOf evenenement_Cocher_E

                PanelExercice.Controls.Add(bouton)

            Next
            Cursor = Cursors.Default
        End With
    End Sub

    ''' <summary>
    ''' <tag > 2019 </tag>
    '''  lie la recette a l'exerice au cliquant sur le bouton
    ''' </summary>

    Private Sub btn_confirm_lier_Click(sender As Object, e As EventArgs) Handles btn_confirm_lier.Click
        insert_update_tab_Recette_Exercice()
    End Sub

    ''' <summary>
    ''' <tag > 2019 </tag>
    '''    vérifi si l'exercice et la recette sont déja lier, 
    '''    vas faire un insert ou vas faire un message d'erreur
    ''' </summary>

    Private Sub insert_update_tab_Recette_Exercice()

        If Not recetteChoisie = "" And Not exerciceChoisie = "" Then


            Dim verif As Boolean = True
            Dim numEx As Integer
            Dim numRe As Integer
            Dim iRecetteChoisie As Integer
            Dim iExerciceChoisie As Integer

            iRecetteChoisie = Integer.Parse(recetteChoisie)
            iExerciceChoisie = Integer.Parse(exerciceChoisie)

            Cursor = Cursors.AppStarting

            recupererRecetteExercice()

            With dsRecetteExercice.Tables(0)

                Dim no As Integer = .Rows.Count
                For i As Integer = 0 To .Rows.Count - 1
                    numRe = .Rows(i).Item(0)
                    numEx = .Rows(i).Item(1)

                    If iRecetteChoisie = numRe And iExerciceChoisie = numEx Then

                        verif = False

                    End If

                Next
                Cursor = Cursors.Default
            End With

            If verif Then

                strRequete = "INSERT INTO `tbl_exercice_recette` VALUES(" & iRecetteChoisie & "," & iExerciceChoisie & ",'" & nomRecetteChoisie & "','" & nomExerciceChoisie & "')"
                gestionBdRecetteExercice.InsDelUpd(strRequete)

                recupererRecetteExercice()
                creerlisteRecette_exercice_R_E()
                MessageBox.Show("vous avez bien ajouté la recette a l'exercice")

            Else

                MessageBox.Show("l'exercice et la recette sont déjà liée")
            End If

            verif = False

        Else

            MessageBox.Show("sélectionner un exercice et/ou une recette")
        End If


    End Sub


    ''' <summary>
    ''' <tag > 2019 </tag>
    '''    Permert de délier les recettes est exercices a partir d'une selection réalisé dans la checklist
    ''' </summary>

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_delier.Click
        Dim str As String()
        Dim s As String = ""
        Dim listRe_Ex As New ListBox
        Dim ctrNoE As Integer = 1
        Dim ctrNoR As Integer = 0
        Dim iNo_ex2 As Integer
        Dim iNo_re2 As Integer
        Dim sNo_ex2 As String
        Dim sNo_re2 As String

        If checkListR_E.CheckedItems.Count > 0 Then

            For i As Integer = 0 To checkListR_E.CheckedItems.Count - 1
                listRe_Ex.Items.Add(checkListR_E.CheckedItems(i))
            Next
            For i As Integer = 0 To listRe_Ex.Items.Count - 1
                If i <> listRe_Ex.Items.Count - 1 Then
                    s += listRe_Ex.Items(i) + ","

                Else
                    s += listRe_Ex.Items(i)

                End If
            Next
        Else
            s = ""
        End If

        str = s.Split(tab)

        If Not s = "" Then

            For i As Integer = 0 To str.LongLength / 4 - 1
                sNo_ex2 = str(ctrNoE)
                sNo_re2 = str(ctrNoR)
                iNo_ex2 = Integer.Parse(sNo_ex2)
                iNo_re2 = Integer.Parse(sNo_re2)
                strRequete = "DELETE FROM `tbl_exercice_recette` WHERE `no_recette` =" & iNo_re2 & " and no_exercice =" & iNo_ex2
                gestionBdRecetteExercice.InsDelUpd(strRequete)

                recupererRecetteExercice()
                creerlisteRecette_exercice_R_E()
                ctrNoE += 4
                ctrNoR += 4
            Next


            MessageBox.Show("l'opération de suppression a réussi")
        Else

            MessageBox.Show("veuillez sélectionner un élément de la liste")
        End If

    End Sub



    ''' <summary>
    ''' Méthode qui  change la couleur du texte et du fond du bouton quand la souris entre dans bouton.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>

    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btn_confirm_lier.MouseEnter, btn_delier.MouseEnter
        sender.BackColor = Color.White
        sender.ForeColor = Color.Black
    End Sub

    ''' <summary>
    ''' Méthode qui change la couleur du texte et du fond du bouton quand la souris quitte le bouton.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btn_confirm_lier.MouseLeave, btn_delier.MouseLeave
        sender.BackColor = Color.FromArgb(52, 73, 94)
        sender.ForeColor = SystemColors.Control

    End Sub
End Class






