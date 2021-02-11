Imports System.IO
Imports MySql.Data.MySqlClient
''' <summary>
'''  <tag > 2019 </tag>
'''  toutes les méthodes qui géré l'onglet recette
''' </summary>
Public Class recette

    Dim fichier As String
    Dim gestionBdRecette As New Connexion
    Dim sfd As New SaveFileDialog
    Dim ofd As New OpenFileDialog
    Dim ofdI As New OpenFileDialog
    Dim dataAdapter As New MySqlDataAdapter
    Dim lstRecette As New List(Of recette)
    Dim lstRecetteRechercher As New List(Of recette)
    Dim DescriptionExercice As usr_recette_exercice()
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
    Dim Exercice As Integer = 0

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



    'permet d'afficher les recettes déja mis dans la BD dans la liste box
    Private Sub recupererRecette()
        strRequete = "select `no_recette`,`source_Img`,`source_doc` ,`nom_recette`   
                      from `tbl_recette`"

        table = "tbl_recette"

        gestionBdRecette.miseAjourDS(dsRecette, dataAdapter, strRequete, table)

    End Sub

    'remplis la listbox des recette enregistrer dnas la BD
    Private Sub creerLstNomRecette()

        Cursor = Cursors.AppStarting
        With dsRecette.Tables(0)
            Dim no As Integer = .Rows.Count
            For i As Integer = 0 To .Rows.Count - 1
                Dim usr_test As New recette(.Rows(i).Item(0), .Rows(i).Item(1), .Rows(i).Item(2), .Rows(i).Item(3))
                lstRecette.Add(usr_test)
                ListBox1.Items.Add(.Rows(i).Item(3))

            Next
            Cursor = Cursors.Default
        End With
    End Sub



    Private Sub Usr_recette_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.SelectedIndex = -1
        recupererRecette()
        creerLstNomRecette()
    End Sub


    ' le bouton fait sauvegarder l'image et la recette dans le fichier source et 
    ' met la recette dans la bd si elle ne l'est pas déjà et met en jour la listBox
    Private Sub btn_Enregistrer_Click(sender As Object, e As EventArgs) Handles btn_Enregistrer.Click

        ofd.Filter = " Fichier Word |*.docx| Fichier Exel|*.csv| Fichier Pdf|*.pdf|fichier texte |*.txt"

        'vas chercher le nom du fichier
        If ofd.ShowDialog = DialogResult.OK Then

            fichier = ofd.FileName

            str = fichier.Split(tab)

            nbrElementTab = str.Length

            nom_doc = str(nbrElementTab - 1)

            strRequete = "select count(`no_recette`)
                      from tbl_recette 
                      where `nom_recette` =  '" & nom_doc & "' "


            ctr = gestionBdRecette.Requete(strRequete)


            ' si le nom de la recette n'existe pas encore vas créer une nouvelle recette dans la bd et vas auvegarder le document
            If ctr = 0 Then

                My.Computer.FileSystem.CopyFile(fichier,
             "dossierRecette\" & nom_doc)

                Dim CheminRecette As String = Trim("dossierRecette\\" & nom_doc)
                Dim CheminImg As String = "aucun" 'pas encore mis

                strRequete = "INSERT INTO `tbl_recette` (`source_Img`,`source_doc`,`nom_recette`) VALUES('" & CheminImg & "','" & CheminRecette & "','" & nom_doc & "')"
                gestionBdRecette.InsDelUpd(strRequete)

                ListBox1.Items.Clear()
                lstRecetteRechercher.Clear()

                recupererRecette()
                creerLstNomRecette()

                MessageBox.Show("vous avez enregistrer une nouvelle recette")


                ' si la recette existe déja vas seulement mettre en jour le document
            Else

                MessageBox.Show("vous avez déja cette recette dans votre bibliotéque")

            End If
        Else
            MessageBox.Show("Importation annulé")
        End If

        ctr = 0
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
                    Dim usr_test As New recette(.Rows(i).Item(0), .Rows(i).Item(1), .Rows(i).Item(2), .Rows(i).Item(3))
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

                    MessageBox.Show("La recette a été enregistrée")
                End If

            Else

                MessageBox.Show("le fichier que vous voulez enregistrer n'existe pas")
            End If

        Else

            MessageBox.Show("vous devez d'abord selectionner une recette")

        End If

        lstRecetteRechercher.Clear()

    End Sub


    ''' <summary>
    ''' ajoute une image dans le pickture box
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_imp_image_Click(sender As Object, e As EventArgs) Handles btn_imp_image.Click

        Dim check As Boolean = True
        If PictureBox1.Image Is Nothing Then

            If Not ListBox1.SelectedItem = "" Then

                ofdI.Filter = "Fichiers JPG, JPEG|*.jpg|PNG, PNG|*.png"
                If ofdI.ShowDialog = DialogResult.OK Then

                    image_Select = ofdI.FileName

                    'vas chercher le nom de l'image
                    str = image_Select.Split(tab)

                    nbrElementTab = str.Length

                    nom_image = str(nbrElementTab - 1)

                    'vérifier si l'image existe déja
                    recupererRecette()

                    Cursor = Cursors.AppStarting
                    With dsRecette.Tables(0)
                        Dim no As Integer = .Rows.Count
                        For i As Integer = 0 To .Rows.Count - 1
                            Dim usr_test As New recette(.Rows(i).Item(0), .Rows(i).Item(1), .Rows(i).Item(2), .Rows(i).Item(3))


                            If "dossierRecette\" & nom_image = .Rows(i).Item(1) Then
                                check = False
                            End If

                        Next
                        Cursor = Cursors.Default
                    End With

                    If check Then
                        'inser le path de l'image dnas la pd
                        strRequete = "update tbl_recette set `source_Img` =" & "'dossierRecette\\" & nom_image & "'" &
                    "where nom_recette ='" & ListBox1.SelectedItem & "'"

                        gestionBdRecette.InsDelUpd(strRequete)

                        'change l'emplacement de l'image pour le mettre avec les fichier source

                        My.Computer.FileSystem.CopyFile(image_Select, "dossierRecette\" & nom_image)

                        PictureBox1.Image = Image.FromFile(image_Select)
                        image_Select = ""

                    Else
                        MessageBox.Show("vous avez déjà cette image avec ce nom. Changer le nom de l'image pour l'ajouter")
                    End If

                Else
                    MessageBox.Show("Importation annulé")
                End If
            Else

                MessageBox.Show("sélectionner une recette avant d'importer un image")

            End If

        Else
            MessageBox.Show("la recette a déjà une image de rattaché à elle")
        End If



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
                    Dim usr_test As New recette(.Rows(i).Item(0), .Rows(i).Item(1), .Rows(i).Item(2), .Rows(i).Item(3))
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
            image_Select = ""


        End If

        ' vas cherche la description de l'exercice et l'ajoute à la texte box

        If Not Utls.Titre = "a" Then
            strRequete = "select e.no_exercice, e.description, re.nom_recette from tbl_exercices e 
                           inner join tbl_exercice_recette er on er.no_exercice = e.no_exercice
                           inner join tbl_recette re on re.no_recette = er.no_recette 
                           Where re.`nom_recette` =  '" & ListBox1.SelectedItem & "' and e.`no_exercice` =" & Exercice


            table = "tbl_exercices"


            gestionBdRecette.miseAjourDS(dsRecette, dataAdapter, strRequete, table)

            Cursor = Cursors.AppStarting
            With dsRecette.Tables(0)

                For i As Integer = 0 To .Rows.Count - 1


                    TextBoxDescriptionRecette.Text += .Rows(i).Item(1) & ", "


                Next
                Cursor = Cursors.Default
            End With
        End If


    End Sub

    'supprimer une recette
    Private Sub btn_SuppRecette_Click(sender As Object, e As EventArgs) Handles btn_SuppRecette.Click
        Dim chemin_Doc_supp As String
        Dim chemin_Img_supp As String

        If Not ListBox1.SelectedItem = "" Then

            TextBoxDescriptionRecette.Text = ""

            'aller chercher les chemin du document et image dans la PD
            strRequete = "select `no_recette`,`source_Img`,`source_doc` ,`nom_recette`   
                      from tbl_recette 
                      where `nom_recette` =  '" & ListBox1.SelectedItem & "' "

            table = "tbl_recette"

            gestionBdRecette.miseAjourDS(dsRecette, dataAdapter, strRequete, table)

            Cursor = Cursors.AppStarting
            With dsRecette.Tables(0)
                Dim no As Integer = .Rows.Count
                For i As Integer = 0 To .Rows.Count - 1
                    Dim usr_test As New recette(.Rows(i).Item(0), .Rows(i).Item(1), .Rows(i).Item(2), .Rows(i).Item(3))
                    lstRecetteRechercher.Add(usr_test)
                Next
                Cursor = Cursors.Default
            End With

            chemin_Img_supp = lstRecetteRechercher.Item(0).source_img
            chemin_Doc_supp = lstRecetteRechercher.Item(0).source_doc


            'supprimer les fichier a leur emplacement
            lstRecetteRechercher.Clear()



            If (File.Exists(chemin_Doc_supp) And File.Exists(chemin_Img_supp)) Then

                If Not PictureBox1.Image Is Nothing Then
                    PictureBox1.Image.Dispose()
                End If

                If Not chemin_Img_supp = "aucun" Then
                    My.Computer.FileSystem.DeleteFile(chemin_Img_supp)
                End If

                My.Computer.FileSystem.DeleteFile(chemin_Doc_supp)

                strRequete = "DELETE FROM `tbl_recette` WHERE `nom_recette` ='" & ListBox1.SelectedItem & "'"
                gestionBdRecette.InsDelUpd(strRequete)

                strRequete = "DELETE FROM `tbl_exercice_recette` WHERE `nom_recette` ='" & ListBox1.SelectedItem & "'"
                gestionBdRecette.InsDelUpd(strRequete)



                ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)

                MessageBox.Show("vous venez de supprimer le recette, celle-ci n'est plus lier a aucune exercice")
                PictureBox1.Image = Nothing

            Else
                MessageBox.Show("erreur de supression, les dossiers sont introuvable")

            End If

        Else
                MessageBox.Show("sélectionner une recette avant du la supprimer")
        End If




    End Sub

    Private Sub btn_lier_re_ex_Click(sender As Object, e As EventArgs) Handles btn_lier_re_ex.Click
        Dim ex_re As New Frm_recette(Utls, _no_cours, Exercice)
        ex_re.ShowDialog()
    End Sub


    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btn_lier_re_ex.MouseEnter, btn_imp_image.MouseEnter, btn_Enregistrer.MouseEnter, btn_SuppRecette.MouseEnter, btn_ImporterRecette.MouseEnter
        sender.BackColor = Color.White
        sender.ForeColor = Color.Black
    End Sub

    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btn_lier_re_ex.MouseLeave, btn_imp_image.MouseLeave, btn_Enregistrer.MouseLeave, btn_SuppRecette.MouseLeave, btn_ImporterRecette.MouseLeave
        sender.BackColor = Color.FromArgb(52, 73, 94)
        sender.ForeColor = SystemColors.Control
    End Sub

    'permet d'ouvrire une recette
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
                    Dim usr_test As New recette(.Rows(i).Item(0), .Rows(i).Item(1), .Rows(i).Item(2), .Rows(i).Item(3))
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





    Private Sub btn_MouseEnter(sender As Object, e As EventArgs) Handles btn_SuppRecette.MouseEnter, btn_ImporterRecette.MouseEnter, btn_imp_image.MouseEnter, btn_Enregistrer.MouseEnter, btn_lier_re_ex.MouseEnter

    End Sub

    Private Sub btn_MouseLeave(sender As Object, e As EventArgs) Handles btn_SuppRecette.MouseLeave, btn_ImporterRecette.MouseLeave, btn_imp_image.MouseLeave, btn_Enregistrer.MouseLeave, btn_lier_re_ex.MouseLeave

    End Sub

    Private Sub ListBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub


End Class
