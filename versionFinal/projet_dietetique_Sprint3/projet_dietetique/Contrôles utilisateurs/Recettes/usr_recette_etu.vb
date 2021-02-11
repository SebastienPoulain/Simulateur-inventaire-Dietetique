Imports System.IO
Imports MySql.Data.MySqlClient
''' <summary>
''' <tag > 2019 </tag>
''' le usr_recette_exercie permet d'afficher les recettes et exercies puis de les associer ensemble pour les étudiants
''' </summary>
Public Class usr_recette_etu

    Dim fichier As String
    Dim gestionBdRecette As New Connexion
    Dim sfd As New SaveFileDialog
    Dim ofd As New OpenFileDialog
    Dim ofdI As New OpenFileDialog
    Dim dataAdapter As New MySqlDataAdapter
    Dim lstRecette As New List(Of usr_recette_etu)
    Dim lstRecetteRechercher As New List(Of usr_recette_etu)
    Dim dsRecette As DataSet
    Dim _utls As Utilisateur
    Dim strRequete As String
    Dim table As String
    Dim NouvelleEmplacement As String
    Dim image_Select As String
    Dim nom_doc As String
    Dim nom_image As String
    Dim str As String()
    Dim tab As Char() = {“\”}
    Dim ctr As Integer = 0
    Dim nbrElementTab = 0

    Dim no_recette As Integer
    Dim source_img As String
    Dim source_doc As String
    Dim nom_recette As String

    Dim Utls As Utilisateur
    Dim _no_cours As String
    Dim Exercice As Integer

    Public Sub New(_no_recette As Integer, _source_img As String, _source_doc As String, _nom_recette As String)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        no_recette = _no_recette
        source_img = _source_img
        source_doc = _source_doc
        nom_recette = _nom_recette
    End Sub

    Public Sub New(_utls As Utilisateur, cours As String, exerc As Integer)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Utls = _utls
        Exercice = exerc
        _no_cours = cours

    End Sub

    'fonctionne PAS TBK
    'permet d'afficher les recettes déja mis dans la BD dans la liste box
    Private Sub recupererRecette()
        strRequete = "select ex.`no_recette`,`source_Img`,`source_doc` ,ex. `nom_recette`,`no_exercice` 
                      from tbl_exercice_recette ex 
                      inner join tbl_recette r on r.no_recette = ex.no_recette 
                      where `no_exercice` = " & Exercice

        table = "tbl_recette"

        gestionBdRecette.miseAjourDS(dsRecette, dataAdapter, strRequete, table)

    End Sub

    'remplis la listbox des recette enregistrer dnas la BD vérifi si il y a des exercise relier a la recette

    Private Sub creerLstNomRecette()

        If Not Exercice = 0 Then

            Cursor = Cursors.AppStarting
            With dsRecette.Tables(0)
                Dim no As Integer = .Rows.Count
                For i As Integer = 0 To .Rows.Count - 1
                    Dim usr_test As New usr_recette_etu(.Rows(i).Item(0), .Rows(i).Item(1), .Rows(i).Item(2), .Rows(i).Item(3))
                    lstRecette.Add(usr_test)
                    ListBox1.Items.Add(.Rows(i).Item(3))

                Next
                Cursor = Cursors.Default
            End With
        End If
    End Sub



    Private Sub Usr_recette_Load(sender As Object, e As EventArgs) Handles MyBase.Paint
        ListBox1.Items.Clear()
        recupererRecette()
        creerLstNomRecette()
        PictureBox1.Image = Nothing

    End Sub


    'Prend la recette mise dans les fichier source du projet et l'envois à l'endroit indiqué dans l'ordinateur
    Private Sub ImporterRecette_Click(sender As Object, e As EventArgs) Handles btn_ImporterRecette.Click

        Dim chemin_doc As String

        If Not ListBox1.SelectedItem = "" Then
            strRequete = "select `no_recette`,`source_Img`,`source_doc` ,`nom_recette`   
                      from tbl_recette 
                      where `nom_recette` =  '" & ListBox1.SelectedItem & "' "

            table = "tbl_recette"

            gestionBdRecette.miseAjourDS(dsRecette, dataAdapter, strRequete, table)

            Cursor = Cursors.AppStarting
            With dsRecette.Tables(0)
                Dim no As Integer = .Rows.Count
                For i As Integer = 0 To .Rows.Count - 1
                    Dim usr_test As New usr_recette_etu(.Rows(i).Item(0), .Rows(i).Item(1), .Rows(i).Item(2), .Rows(i).Item(3))
                    lstRecetteRechercher.Add(usr_test)
                Next
                Cursor = Cursors.Default
            End With

            chemin_doc = lstRecetteRechercher.Item(0).source_doc

            If File.Exists(chemin_doc) Then

                sfd.Filter = " Fichier Word |*.docx| Fichier Excel|*.csv| Fichier Pdf|*.pdf"

                If sfd.ShowDialog = DialogResult.OK Then

                    NouvelleEmplacement = sfd.FileName


                    My.Computer.FileSystem.CopyFile(chemin_doc, NouvelleEmplacement)

                End If

            Else

                MessageBox.Show("le fichier que vous voulez enregistrer n'existe pas")
            End If
        Else

            MessageBox.Show("vous devez d'abord selectionner une recette")

        End If





        lstRecetteRechercher.Clear()

    End Sub


    'affiche l'image lier à la recette selectionné
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.MouseClick

        TextBoxDescriptionRecette.Text = ""

        If Not ListBox1.SelectedIndex = -1 Then

            lstRecetteRechercher.Clear()

            strRequete = "select `no_recette`,`source_Img`,`source_doc` ,`nom_recette`   
                      from tbl_recette 
                      where `nom_recette` =  '" & ListBox1.SelectedItem & "' "

            table = "tbl_recette"


            gestionBdRecette.miseAjourDS(dsRecette, dataAdapter, strRequete, table)

            Cursor = Cursors.AppStarting
            With dsRecette.Tables(0)
                Dim no As Integer = .Rows.Count
                For i As Integer = 0 To .Rows.Count - 1
                    Dim usr_test As New usr_recette_etu(.Rows(i).Item(0), .Rows(i).Item(1), .Rows(i).Item(2), .Rows(i).Item(3))
                    lstRecetteRechercher.Add(usr_test)
                Next
                Cursor = Cursors.Default
            End With

            image_Select = lstRecetteRechercher.Item(0).source_img

            If Not image_Select = "aucun" Then

                If Not (File.Exists(image_Select)) Then
                    MessageBox.Show("l'image n'est pas accessible, celui-ci a été supprimé des fichers sources")
                    PictureBox1.Image = Nothing
                    'modifier
                Else

                    Using monstream As New IO.FileStream(image_Select, IO.FileMode.Open)

                        PictureBox1.Image = Image.FromStream(monstream)
                    End Using

                End If

            Else
                PictureBox1.Image = Nothing
            End If

            lstRecetteRechercher.Clear()
        End If

        'vas cherche la description de l'exercice et l'ajoute à la texte box

        strRequete = "select e.no_exercice, e.description, re.nom_recette from tbl_exercices e 
                           inner join tbl_exercice_recette er on er.no_exercice = e.no_exercice
                           inner join tbl_recette re on re.no_recette = er.no_recette 
                           Where re.`nom_recette` =  '" & ListBox1.SelectedItem & "' and e.`no_exercice` =" & Exercice

        table = "tbl_exercices"

        gestionBdRecette.miseAjourDS(dsRecette, dataAdapter, strRequete, table)

        Cursor = Cursors.AppStarting
        With dsRecette.Tables(0)

            For i As Integer = 0 To .Rows.Count - 1

                TextBoxDescriptionRecette.Text = .Rows(i).Item(1)

            Next
            Cursor = Cursors.Default
        End With

    End Sub

    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btn_ImporterRecette.MouseEnter
        sender.BackColor = Color.White
        sender.ForeColor = Color.Black
    End Sub

    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btn_ImporterRecette.MouseLeave
        sender.BackColor = Color.FromArgb(52, 73, 94)
        sender.ForeColor = SystemColors.Control
    End Sub

    Private Sub PaneldecoRecette_Paint(sender As Object, e As PaintEventArgs) Handles PaneldecoRecette.Paint

    End Sub

    Private Sub ListBox1_SelectedIndexChanged2(sender As Object, e As MouseEventArgs) Handles ListBox1.DoubleClick

        Dim chemin_doc As String

        If Not ListBox1.SelectedItem = "" Then

            strRequete = "select `no_recette`,`source_Img`,`source_doc` ,`nom_recette`   
                      from tbl_recette 
                      where `nom_recette` =  '" & ListBox1.SelectedItem & "' "


            table = "tbl_recette"

            gestionBdRecette.miseAjourDS(dsRecette, dataAdapter, strRequete, table)


            Cursor = Cursors.AppStarting
            With dsRecette.Tables(0)
                Dim no As Integer = .Rows.Count
                For i As Integer = 0 To .Rows.Count - 1
                    Dim usr_test As New usr_recette_etu(.Rows(i).Item(0), .Rows(i).Item(1), .Rows(i).Item(2), .Rows(i).Item(3))
                    lstRecetteRechercher.Add(usr_test)
                Next
                Cursor = Cursors.Default
            End With
            chemin_doc = lstRecetteRechercher.Item(0).source_doc

            If (File.Exists(chemin_doc)) Then

                Process.Start(chemin_doc)

                lstRecetteRechercher.Clear()
            Else
                MessageBox.Show("le recette ne peut pas s'ouvrir, car le fichier est introuvable")
            End If

        Else

            MessageBox.Show("vous devez d'abord selectionner une recette")

        End If

    End Sub

End Class




