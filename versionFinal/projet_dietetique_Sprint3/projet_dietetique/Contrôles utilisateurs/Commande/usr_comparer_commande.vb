Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports MySql.Data.MySqlClient
Imports itextsharp.text.pdf
Imports itextsharp.text
Imports System.IO.Compression
Imports System.IO
Imports projet_dietetique

' PIERRE-OLIVIER DUBOIS-NADEAU

Public Class usr_comparer_commande

    Dim usr_commande As usr_commandes
    Dim gestionBd As New Connexion
    Dim dataTable = New DataTable
    Dim dataAdapter As New MySqlDataAdapter
    Dim dataSet As DataSet
    Dim utls As Utilisateur
    Dim exercice As Integer = 0
    Dim cours_exercice As String = ""
    Dim str_requete As String = ""
    Dim nom_cours As String = ""
    Dim nom_exercice As String = ""
    Dim nom_etudiant As String = ""
    Dim index As Integer
    Dim sfd As New SaveFileDialog
    Dim NouvelEmplacement As String
    Dim chemin_doc As String
    Dim verifCouleur As Integer


    Public Sub New(_usr_commande As usr_commandes, _utls As Utilisateur, cours As String, exerc As Integer)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

        usr_commande = _usr_commande
        utls = _utls
        exercice = exerc
        cours_exercice = cours
    End Sub

    Public Sub set_commande_titre(nom_titre As Label)
        lbl_mode = nom_titre
    End Sub


    Public Function get_commande_titre()
        Return lbl_mode
    End Function


    Public Sub set_commande_haut(nom_commande As Label)
        lb_Commande_haut = nom_commande
    End Sub


    Public Function get_commande_haut()
        Return lb_Commande_haut
    End Function


    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Me.Visible = False
        Me.SendToBack()
    End Sub

    Private Sub usr_comparer_commande_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        If utls.Titre = "p" Then

            charger_liste_etu()
            charger_ds(utls.No_id)
            remplir_commande_prof()

            If Not dgv_eleves.Rows.Count = 0 Then

                charger_ds(dgv_eleves.Rows(0).Cells(0).Value)


                If dataSet.Tables(0).Rows.Count = 0 Then
                    pnl_vide.Visible = False
                Else
                    pnl_vide.Visible = True
                    RemplirGrid(dgv_Commande_eleve)

                End If
                verifier_remise()
            End If


        ElseIf utls.Titre = "e" Then

                dgv_Commande_eleve.Left = 3
                dgv_Commande_eleve.Top = 114
                dgv_Commande_eleve.Width = 1429

                pn_commande_eleve.Left = 3
                pn_commande_eleve.Top = 86
                pn_commande_eleve.Width = 1429

                dgv_Commande_Prof.Top = 468
                dgv_Commande_Prof.Left = 3
                dgv_Commande_Prof.Width = 1429

                pn_commande_prof.Top = 440
                pn_commande_prof.Left = 3
                pn_commande_prof.Width = 1429
                dgv_eleves.Visible = False
                pn_liste_etudiant.Visible = False
                pnl_vide.Top = 440
                pnl_vide.Left = 3
                pnl_vide.Width = 1429
                lbl_vide.Top = 131
                lbl_vide.Left = 450


            If lb_Commande_haut.Text = "Commande de l'élève" Then
                    remplir_commande_eleve()
                    remplir_commande_prof()
                Else
                    remplir_reception()
                End If
            End If

            charger_liste_etu()
            couleur_remise_commande()

    End Sub

    'Procedure pour remplir la réception de commande'
    Public Sub remplir_reception()
        Dim no_reception As Integer = 0
        no_reception = usr_commande.trouver_no_recepetion
        ds_charger_reception(no_reception)
        RemplirGrid(dgv_Commande_eleve)
    End Sub



    'Procédure pour charger le dataset de la réception avec le numéro de réception'
    Public Sub ds_charger_reception(no_reception As Integer)

        Dim str_requete_remplir As String = ""
        str_requete_remplir = "Select distinct p.nom_produit, f.nom_fournisseur,rd.quantite,ft.nom_format , um.unite_mesure,rd.prix_unitaire
                                from tbl_reception_details rd, tbl_commandes c, tbl_produits p,
                                tbl_unites_mesure um, tbl_formats ft, tbl_categories cg, tbl_produit_fournisseur_prix pr, tbl_fournisseurs F
                                where c.actif = true and rd.no_commande = c.no_commande
                                and RD.code_produit = P.code_produit
                                AND P.no_format = FT.no_format
                                and p.no_categorie = cg.no_categorie
                                and p.no_mesure = um.no_mesure
                                and pr.code_produit = p.code_produit 
                                and pr.no_fournisseur = f.no_fournisseur
                                and c.no_fournisseur = f.no_fournisseur
                                and rd.no_reception = " & no_reception

        gestionBd.miseAjourDS(dataSet, dataAdapter, str_requete_remplir, "tbl_reception_details")
    End Sub

    'Procédure pour remplir la commande du prof'
    Public Sub remplir_commande_prof()
        Dim nom_prof As String = ""
        nom_prof = trouver_professeur()
        charger_ds(nom_prof)
        If dataSet.Tables(0).Rows.Count = 0 Then
            pnl_vide.Visible = True

        Else
            pnl_vide.Visible = False
            RemplirGrid(dgv_Commande_Prof)
        End If



    End Sub

    'Procedure pour remplir la commande de l'élève.
    Public Sub remplir_commande_eleve()

        charger_ds(utls.No_id)

        If dataSet.Tables(0).Rows.Count = 0 Then
            pn_vide2.Visible = True
        Else
            pn_vide2.Visible = False
            RemplirGrid(dgv_Commande_eleve)
        End If

    End Sub

    'Procédure qui charge le dataset de l'étudiant ou le prof'
    Public Sub charger_ds(etu As String)

        str_requete = "Select distinct p.nom_produit, f.nom_fournisseur, cd.quantite ,fm.nom_format , um.unite_mesure, concat(pr.prix, '$')
                        From tbl_commandes c , tbl_commandes_detaillees cd, tbl_commandes_exercices e, tbl_commandes_exercices ce, 
                             tbl_produits p, tbl_utilisateurs u , tbl_formats fm, tbl_unites_mesure um, tbl_fournisseurs f, 
                             tbl_produit_fournisseur_prix pr
                        Where e.no_exercice = ce.no_exercice
                        And c.actif = true
                        And e.no_commande =  c.no_commande
                        And e.no_utilisateur = u.no_utilisateur
                        And ce.no_commande = c.no_commande 
                        And cd.no_commande = c.no_commande
                        And cd.no_produit = p.code_produit
                        And fm.no_format = p.no_format
                        And um.no_mesure = p.no_mesure
                        And pr.no_fournisseur = f.no_fournisseur
                        and pr.code_produit =  p.code_produit
                        And pr.prix = cd.prix_unitaire
                        and c.no_fournisseur = f.no_fournisseur
                        And u.no_utilisateur = '" & etu & "'  and e.no_exercice ='" & exercice & "'"

        gestionBd.miseAjourDS(dataSet, dataAdapter, str_requete, "tbl_commandes")
    End Sub


    'Procédure qui charge la liste d'étudiant.
    Public Sub charger_liste_etu()
        str_requete = " Select  u.no_utilisateur, concat(u.prenom_personne,', ',u.nom_personne )
                        From tbl_utilisateurs u, tbl_cours c, tbl_cours_utilisateur cu
                        Where c.no_cours = cu.no_cours
                        And u.no_utilisateur = cu.no_utilisateur
                        And c.no_cours  ='" & cours_exercice & "'"

        gestionBd.miseAjourDS(dataSet, dataAdapter, str_requete, "tbl_utilisateurs")
        remplir_grid_eleves()
    End Sub

    ''' <summary>
    '''  <tag > 2019 </tag>
    '''  rempli le dataset des utilisateur qui on remi des commandes
    '''   guillaume ricard 
    ''' </summary>

    Public Function charger_liste_etu_remi(p_utilisateur As String) As Integer
        str_requete = " Select count(*) from tbl_commandes 
            where no_utilisateur ='" & p_utilisateur & "' and no_exercice =" & exercice

        verifCouleur = gestionBd.Requete(str_requete)

        Return verifCouleur
    End Function

    ''' <summary>
    '''  <tag > 2019 </tag>
    '''  met la bonne couleur a l'utilisateur qui on remi recette
    '''  guillaume ricard 
    ''' </summary>

    Public Sub couleur_remise_commande()

        dgv_eleves.Rows.Clear()
        With dataSet.Tables(0)
            For i As Integer = 0 To .Rows.Count - 1
                dgv_eleves.Rows.Add(.Rows(i).Item(0))
                dgv_eleves.Rows(dgv_eleves.Rows.Count - 1).Cells(1).Value = .Rows(i).Item(1)

                If Not charger_liste_etu_remi(dgv_eleves.Rows(dgv_eleves.Rows.Count - 1).Cells(0).Value) = 0 Then
                    dgv_eleves.Rows(i).DefaultCellStyle.BackColor() = Color.Yellow
                End If


            Next
        End With

    End Sub



    'Procédure qui remplis le datagrid avec la liste des étudiants.'
    Public Sub remplir_grid_eleves()

        dgv_eleves.Rows.Clear()
        With dataSet.Tables(0)
            For i As Integer = 0 To .Rows.Count - 1
                dgv_eleves.Rows.Add(.Rows(i).Item(0))
                dgv_eleves.Rows(dgv_eleves.Rows.Count - 1).Cells(1).Value = .Rows(i).Item(1)

            Next
        End With

          dgv_eleves.DefaultCellStyle.BackColor() = Color.Red

        If dgv_eleves.Rows.Count = 0 Then
            pn_vide2.Visible = True

        Else
            pn_vide2.Visible = False


        End If

    End Sub

    'Procédure pour remplir le datagrid'
    Public Sub RemplirGrid(dgv_controle As DataGridView)

        Dim prix_unitaire As Double = 0
        Dim quantite As Double = 0
        Dim montant_total As Double = 0
        dgv_controle.Rows.Clear()
        With dataSet.Tables(0)
            For i As Integer = 0 To .Rows.Count - 1
                dgv_controle.Rows.Add(.Rows(i).Item(0))
                dgv_controle.Rows(dgv_controle.Rows.Count - 1).Cells(1).Value = .Rows(i).Item(1)
                dgv_controle.Rows(dgv_controle.Rows.Count - 1).Cells(2).Value = .Rows(i).Item(2)
                dgv_controle.Rows(dgv_controle.Rows.Count - 1).Cells(3).Value = .Rows(i).Item(3)
                dgv_controle.Rows(dgv_controle.Rows.Count - 1).Cells(4).Value = .Rows(i).Item(4)
                dgv_controle.Rows(dgv_controle.Rows.Count - 1).Cells(5).Value = .Rows(i).Item(5)
                quantite = .Rows(i).Item(2)
                prix_unitaire = replace_signe_dollars(.Rows(i).Item(5), "virgule")
                montant_total = quantite * prix_unitaire
                dgv_controle.Rows(dgv_controle.Rows.Count - 1).Cells(6).Value = FormatCurrency(montant_total)

                dgv_controle.Rows(dgv_controle.Rows.Count - 1).Cells(5).Value = FormatCurrency(prix_unitaire)

                If replace_signe_dollars(.Rows(i).Item(5), "virgule") = 0 Then
                    dgv_controle.Rows(dgv_controle.Rows.Count - 1).Cells(0).Tag = "0"
                    For j As Integer = 0 To 4
                        dgv_controle.Rows(dgv_controle.Rows.Count - 1).Cells(j).Style.ForeColor = Color.DimGray
                    Next
                Else
                    dgv_controle.Rows(dgv_controle.Rows.Count - 1).Cells(0).Tag = "1"
                End If
            Next
        End With


    End Sub

    'function pour trouver le no du professeur.
    Public Function trouver_professeur() As String
        str_requete = "Select no_utilisateur from tbl_cours_prof where no_cours ='" & cours_exercice & "'"

        gestionBd.miseAjourDS(dataSet, dataAdapter, str_requete, "tbl_cours_prof")

        Return dataSet.Tables(0).Rows(0).Item(0)
    End Function

    Private Sub dgv_eleves_CellMouse_click(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_eleves.CellMouseClick
        verifier_remise()
    End Sub

    'Procédure pour vérifier si l'élève à remis le travail.
    Public Sub verifier_remise()


        Dim identifiant As String = ""

        identifiant = dgv_eleves.CurrentRow.Cells(0).Value

        charger_ds(identifiant)
        If dataSet.Tables(0).Rows.Count = 0 Then

            pn_vide2.Visible = True

        Else

            pn_vide2.Visible = False
            RemplirGrid(dgv_Commande_eleve)

        End If
    End Sub


    ''' <summary>
    ''' Méthode qui permet de sauvegarder le travail de l'élève sélectionné en pdf. Modification de l'entête, ajout du nom de cours,nom de l'exercice,date du jour, nom de l'étudiant.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub btn_sauvegarder_Click(sender As Object, e As EventArgs) Handles btn_sauvegarder.Click

        Dim pdfDoc As New Document()

        sfd_commande_pdf.AddExtension = True
        sfd_commande_pdf.DefaultExt = ".pdf"
        sfd_commande_pdf.Filter = " Fichier Pdf |*.pdf"
        sfd_commande_pdf.ShowDialog()

        If sfd_commande_pdf.FileName <> Nothing Then
            If File.Exists(sfd_commande_pdf.FileName) Then

                Try
                    Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(sfd_commande_pdf.FileName, FileMode.Create))
                    btn_ouvrir_pdf.Enabled = True

                    MessageBox.Show("Votre commande a été enregistrée vers " & sfd_commande_pdf.FileName & ".", "Sauvegarde de commande", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch
                    MessageBox.Show("Votre fichier ne peut être enregistré car il est déja ouvert. Veuillez le fermer.", "Sauvegarde de commande", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try

            Else

                Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(sfd_commande_pdf.FileName, FileMode.Create))
                btn_ouvrir_pdf.Enabled = True
                MessageBox.Show("Votre commande a été enregistrée vers " & sfd_commande_pdf.FileName & ".", "Sauvegarde de commande", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

            pdfDoc.Open()

            Dim pg As New Paragraph

            pg.SetLeading(0, 2)



            If utls.Titre = "p"c Then
                index = dgv_eleves.SelectedRows(0).Index
                nom_etudiant = dgv_eleves.Rows(index).Cells(1).Value
                nom_cours = gestionBd.Requete2("select nom_cours from tbl_cours where no_cours = '" & cours_exercice & "'")
                nom_exercice = gestionBd.Requete2("select nom_travail from tbl_exercices where no_exercice = '" & exercice & "'")


                pg.Add(" Nom du cours : " & nom_cours)

                pg.Alignment = 1
                pdfDoc.Add(pg)

                pg.Clear()

                pg.Add(" Nom de l'exercice : " & nom_exercice)

                pg.Alignment = 1
                pdfDoc.Add(pg)

                pg.Clear()
                pg.Add("Nom de l''étudiant : " & nom_etudiant)

                pg.Alignment = 1
                pdfDoc.Add(pg)

                pg.Clear()
                pg.Add(" Date : " & Date.Today)

                pg.Alignment = 1
                pdfDoc.Add(pg)

                pg.Clear()

            Else

                nom_cours = gestionBd.Requete2("select nom_cours from tbl_cours where no_cours = '" & cours_exercice & "'")
                nom_exercice = gestionBd.Requete2("select nom_travail from tbl_exercices where no_exercice = '" & exercice & "'")

                pg.Add(" Nom du cours : " & nom_cours)

                pg.Alignment = 1
                pdfDoc.Add(pg)

                pg.Clear()

                pg.Add(" Nom de l'exercice : " & nom_exercice)

                pg.Alignment = 1
                pdfDoc.Add(pg)

                pg.Clear()

                pg.Add(" Date : " & Date.Today)

                pg.Alignment = 1
                pdfDoc.Add(pg)

                pg.Clear()

            End If


            Dim table As New PdfPTable(7)

            Dim cellule As New PdfPCell(New Phrase(lb_Commande_haut.Text))
            cellule.Colspan = 7
            cellule.HorizontalAlignment = 1
            table.SpacingBefore = 40
            table.AddCell(cellule)
            table.AddCell("Nom du produit")
            table.AddCell("Fournisseurs")
            table.AddCell("Quantité")
            table.AddCell("Format")
            table.AddCell("Unité de mesure")
            table.AddCell("Prix unitaire")
            table.AddCell("Total")
            table.WidthPercentage = 100

            charger_ds(dgv_eleves.Rows(index).Cells(0).Value)
            RemplirGrid(dgv_Commande_eleve)

            For i = 0 To dgv_Commande_eleve.Rows.Count - 1

                table.AddCell(dgv_Commande_eleve.Rows(i).Cells(0).Value)
                table.AddCell(dgv_Commande_eleve.Rows(i).Cells(1).Value)
                table.AddCell(dgv_Commande_eleve.Rows(i).Cells(2).Value)
                table.AddCell(dgv_Commande_eleve.Rows(i).Cells(3).Value)
                table.AddCell(dgv_Commande_eleve.Rows(i).Cells(4).Value)
                table.AddCell(dgv_Commande_eleve.Rows(i).Cells(5).Value)
                table.AddCell(dgv_Commande_eleve.Rows(i).Cells(6).Value)

            Next

            pdfDoc.Add(table)

            table = New PdfPTable(7)
            cellule = New PdfPCell(New Phrase("Commande du professeur"))
            cellule.Colspan = 7
            cellule.HorizontalAlignment = 1
            table.SpacingBefore = 40
            table.AddCell(cellule)
            table.AddCell("Nom du produit")
            table.AddCell("Fournisseurs")
            table.AddCell("Quantité")
            table.AddCell("Format")
            table.AddCell("Unité de mesure")
            table.AddCell("Prix unitaire")
            table.AddCell("Total")
            table.WidthPercentage = 100

            For i = 0 To dgv_Commande_Prof.Rows.Count - 1

                table.AddCell(dgv_Commande_Prof.Rows(i).Cells(0).Value)
                table.AddCell(dgv_Commande_Prof.Rows(i).Cells(1).Value)
                table.AddCell(dgv_Commande_Prof.Rows(i).Cells(2).Value)
                table.AddCell(dgv_Commande_Prof.Rows(i).Cells(3).Value)
                table.AddCell(dgv_Commande_Prof.Rows(i).Cells(4).Value)
                table.AddCell(dgv_Commande_Prof.Rows(i).Cells(5).Value)
                table.AddCell(dgv_Commande_Prof.Rows(i).Cells(6).Value)

            Next

            pdfDoc.Add(table)

            pdfDoc.Close()
        End If

    End Sub
    'procédure pour ouvrir le fichier pdf.
    Private Sub btn_ouvrir_pdf_Click(sender As Object, e As EventArgs) Handles btn_ouvrir_pdf.Click

        Dim proc As New Diagnostics.Process
        proc.StartInfo.UseShellExecute = True
        ' Définition du fichier à ouvrir 
        proc.StartInfo.FileName = sfd_commande_pdf.FileName
        proc.Start()
    End Sub

    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btnRetour.MouseEnter, btn_ouvrir_pdf.MouseEnter, btn_sauvegarder.MouseEnter, btn_travaux.MouseEnter
        sender.BackColor = Color.White
        sender.ForeColor = Color.Black

        If sender.Text = btnRetour.Text Then
            btnRetour.Image = My.Resources.baseline_arrow_back_black_24dp
        End If
    End Sub
    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btnRetour.MouseLeave, btn_ouvrir_pdf.MouseLeave, btn_sauvegarder.MouseLeave, btn_travaux.MouseLeave
        sender.BackColor = Color.FromArgb(52, 73, 94)
        sender.ForeColor = SystemColors.Control

        If sender.Text = btnRetour.Text Then
            btnRetour.Image = My.Resources.baseline_arrow_back_white_24dp
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub pnl_vide_Paint(sender As Object, e As PaintEventArgs) Handles pnl_vide.Paint
        If utls.Titre = "p" Then
            pnl_vide.Visible = False

        End If
    End Sub

    Private Sub lbl_vide_Click(sender As Object, e As EventArgs) Handles lbl_vide.Click

    End Sub

    Private Sub pn_vide2_Paint(sender As Object, e As PaintEventArgs) Handles pn_vide2.Paint

    End Sub

    Private Sub btn_MouseEnter(sender As Object, e As EventArgs) Handles btnRetour.MouseEnter, btn_sauvegarder.MouseEnter, btn_ouvrir_pdf.MouseEnter, btn_travaux.MouseEnter

    End Sub

    Private Sub btn_MouseLeave(sender As Object, e As EventArgs) Handles btnRetour.MouseLeave, btn_sauvegarder.MouseLeave, btn_ouvrir_pdf.MouseLeave, btn_travaux.MouseLeave

    End Sub

    ''' <summary>
    ''' Méthode qui gère l'événement du clic sur le bouton btn_travaux. Lorsque l'on fait un clic sur ce bouton, cela nous permet de télécharger tous les travaux de tous les élèves pour l'exercice sélectionné.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_travaux.Click

        For j As Integer = 0 To dgv_eleves.Rows.Count - 1

            index = j
            nom_etudiant = dgv_eleves.Rows(j).Cells(1).Value

            Dim pdfDoc As New Document()

            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream("Pdf\" & nom_etudiant & ".pdf", FileMode.Create))

            pdfDoc.Open()

            Dim pg As New Paragraph

            pg.SetLeading(0, 2)



            If utls.Titre = "p"c Then

                nom_cours = gestionBd.Requete2("select nom_cours from tbl_cours where no_cours = '" & cours_exercice & "'")
                nom_exercice = gestionBd.Requete2("select nom_travail from tbl_exercices where no_exercice = '" & exercice & "'")

                pg.Add(" Nom du cours : " & nom_cours)

                pg.Alignment = 1
                pdfDoc.Add(pg)

                pg.Clear()

                pg.Add(" Nom de l'exercice : " & nom_exercice)

                pg.Alignment = 1
                pdfDoc.Add(pg)

                pg.Clear()
                pg.Add("Nom de l''étudiant : " & nom_etudiant)

                pg.Alignment = 1
                pdfDoc.Add(pg)

                pg.Clear()
                pg.Add(" Date : " & Date.Today)

                pg.Alignment = 1
                pdfDoc.Add(pg)

                pg.Clear()

            Else

                nom_cours = gestionBd.Requete2("select nom_cours from tbl_cours where no_cours = '" & cours_exercice & "'")
                nom_exercice = gestionBd.Requete2("select nom_travail from tbl_exercices where no_exercice = '" & exercice & "'")

                pg.Add(" Nom du cours : " & nom_cours)

                pg.Alignment = 1
                pdfDoc.Add(pg)

                pg.Clear()

                pg.Add(" Nom de l'exercice : " & nom_exercice)

                pg.Alignment = 1
                pdfDoc.Add(pg)

                pg.Clear()

                pg.Add(" Date : " & Date.Today)

                pg.Alignment = 1
                pdfDoc.Add(pg)

                pg.Clear()

            End If


            Dim table As New PdfPTable(7)

            Dim cellule As New PdfPCell(New Phrase(lb_Commande_haut.Text))
            cellule.Colspan = 7
            cellule.HorizontalAlignment = 1
            table.SpacingBefore = 40
            table.AddCell(cellule)
            table.AddCell("Nom du produit")
            table.AddCell("Fournisseurs")
            table.AddCell("Quantité")
            table.AddCell("Format")
            table.AddCell("Unité de mesure")
            table.AddCell("Prix unitaire")
            table.AddCell("Total")
            table.WidthPercentage = 100

            charger_ds(dgv_eleves.Rows(index).Cells(0).Value)
            RemplirGrid(dgv_Commande_eleve)

            For i = 0 To dgv_Commande_eleve.Rows.Count - 1

                table.AddCell(dgv_Commande_eleve.Rows(i).Cells(0).Value)
                table.AddCell(dgv_Commande_eleve.Rows(i).Cells(1).Value)
                table.AddCell(dgv_Commande_eleve.Rows(i).Cells(2).Value)
                table.AddCell(dgv_Commande_eleve.Rows(i).Cells(3).Value)
                table.AddCell(dgv_Commande_eleve.Rows(i).Cells(4).Value)
                table.AddCell(dgv_Commande_eleve.Rows(i).Cells(5).Value)
                table.AddCell(dgv_Commande_eleve.Rows(i).Cells(6).Value)

            Next

            pdfDoc.Add(table)

            table = New PdfPTable(7)
            cellule = New PdfPCell(New Phrase("Commande du professeur"))
            cellule.Colspan = 7
            cellule.HorizontalAlignment = 1
            table.SpacingBefore = 40
            table.AddCell(cellule)
            table.AddCell("Nom du produit")
            table.AddCell("Fournisseurs")
            table.AddCell("Quantité")
            table.AddCell("Format")
            table.AddCell("Unité de mesure")
            table.AddCell("Prix unitaire")
            table.AddCell("Total")
            table.WidthPercentage = 100

            For i = 0 To dgv_Commande_Prof.Rows.Count - 1

                table.AddCell(dgv_Commande_Prof.Rows(i).Cells(0).Value)
                table.AddCell(dgv_Commande_Prof.Rows(i).Cells(1).Value)
                table.AddCell(dgv_Commande_Prof.Rows(i).Cells(2).Value)
                table.AddCell(dgv_Commande_Prof.Rows(i).Cells(3).Value)
                table.AddCell(dgv_Commande_Prof.Rows(i).Cells(4).Value)
                table.AddCell(dgv_Commande_Prof.Rows(i).Cells(5).Value)
                table.AddCell(dgv_Commande_Prof.Rows(i).Cells(6).Value)

            Next

            pdfDoc.Add(table)

            pdfDoc.Close()


        Next

        ZipFile.CreateFromDirectory("Pdf", nom_cours & " " & nom_exercice & ".zip", CompressionLevel.Optimal, False)

        chemin_doc = nom_cours & " " & nom_exercice & ".zip"

        sfd.Filter = " Fichier Zip |*.zip"

        If sfd.ShowDialog = DialogResult.OK Then

            NouvelEmplacement = sfd.FileName
            If Not File.Exists(NouvelEmplacement) Then
                My.Computer.FileSystem.CopyFile(chemin_doc, NouvelEmplacement)
                MessageBox.Show(" Le fichier zip contenant les travaux a été sauvegardé vers " & NouvelEmplacement & ".", "Sauvegarder les travaux", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show(" Le fichier zip existe déjà, veuillez choisir un nom de fichier différent.", "Fichier déjà existant", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
            Directory.Delete("Pdf", True)
            File.Delete(chemin_doc)
        Directory.CreateDirectory("Pdf")
    End Sub

End Class
