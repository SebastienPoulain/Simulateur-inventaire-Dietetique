
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports MySql.Data.MySqlClient
Imports itextsharp.text.pdf
Imports itextsharp.text
Imports System.IO
' PIERRE-OLIVIER DUBOIS-NADEAU

Public Class frm_sauvegarde_commande
    Dim nom_cours As String = ""
    Dim nom_exercice As String = ""
    Dim ctr_item As Integer = 0
    Dim panel As New Panel
    Dim pn_panel_prix As New Panel
    Dim listview As New ListView
    Dim label1 As New Label
    Dim lb_nom_fournisseur As New Label
    Dim lb_adresse_fournisseur As New Label
    Dim lb_ville As New Label
    Dim lb_code_postal As New Label
    Dim lb_adresse_cegep As New Label
    Dim lb_ville_cegep As New Label
    Dim lb_tel_cegep As New Label
    Dim lb_internet_cegep As New Label
    Dim lb_expediteur As New Label
    Dim lb_nom_expediteur As New Label
    Dim lb_remarque As New Label
    Dim lb_fournisseur As New Label
    Dim lb_date_commande As New Label
    Dim lb_numero_commande As New Label
    Dim ctrPosition As Integer = 0
    Dim ctr_position_fournisseur = 0
    Dim PictureCegep As New PictureBox
    Dim lb_total As New Label
    Dim lb_tps As New Label
    Dim lb_sous_total As New Label
    Dim pn_entre As New Panel
    Dim lb_tvq As New Label
    Dim txt_numero_commande As New TextBox
    Dim txt_champ_remarque As New TextBox
    Dim btn_numero_aleatoire As New Button
    Dim randomValue As Integer = 0
    Dim str_requete As String = ""
    Dim table As String = ""
    Dim gestionBd As New Connexion
    Dim dataset As New DataSet
    Dim dataAdapter As New MySqlDataAdapter
    Dim utls As Utilisateur
    Dim btnSauvegarder As New Button
    Dim btn_commander As New Button
    Dim btn_annuler As New Button
    Dim btn_ouvrir_pdf As New Button
    Dim pn_bouton_fin As Panel
    Dim pn_remarque As Panel
    Dim lb_erreur As New Label
    Dim ctr_passe As Integer = 0
    Dim nouvelle_liste_txt(ctr_item) As String
    Dim liste_numero_commande() As String
    Dim date_ajourdhui As String = ""
    Dim exercice As Integer = 0
    Dim cours_exercice As String = ""
    Dim lb_deux_point As New Label
    Dim usrcommande As usr_commandes
    Dim no_recepetion As Integer = 0
    Dim ctr_top_prix As Integer = 0



    Public Sub New(_utls As Utilisateur, cours As String, exerc As Integer, _usrcommande As usr_commandes)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        utls = _utls
        exercice = exerc
        cours_exercice = cours
        usrcommande = _usrcommande


    End Sub

    'Lors du chargement, redimentionner la liste de numéro de commande pour éviter de prendre de l'espace mémoire pour rien.

    Private Sub frm_sauvegarde_commande_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim Preserve liste_numero_commande(ctr_item)

    End Sub





    Public Function get_liste()
        Return listview

    End Function



    Public Sub set_liste(nom_liste As ListView)

        listview = nom_liste
        Me.listview.AutoResizeColumns(1)

    End Sub

    Public Function get_panel_fin()


        Return pn_bouton_fin

    End Function

    Public Sub set_panel_fin(nom_panel As Panel)

        pn_bouton_fin = nom_panel


    End Sub

    Public Function get_nom_fournisseur()


        Return lb_nom_fournisseur

    End Function




    Public Sub set_nom_fournisseur(nom_fournisseur As Label)
        If nom_fournisseur Is DBNull.Value Then

        Else


            lb_nom_fournisseur = nom_fournisseur


        End If

    End Sub


    Public Function get_fournisseur()


        Return lb_fournisseur

    End Function


    Public Sub set_fournisseur(fournisseur As Label)


        lb_fournisseur = fournisseur



    End Sub

    Public Function get_hauteur()


        Return ctrPosition

    End Function


    Public Sub set_hauteur(position As Integer)


        ctrPosition = position



    End Sub



    Public Function get_titre()


        Return lbl_titre

    End Function


    Public Sub set_titre(titre As Label)


        lbl_titre = titre


    End Sub

    Public Function get_adresse_fournisseur()


        Return lb_adresse_fournisseur

    End Function


    Public Sub set__adresse_fournisseur(adresse_fournisseur As Label)


        lb_adresse_fournisseur = adresse_fournisseur


    End Sub



    Public Function get_ville_fournisseur()


        Return lb_ville

    End Function


    Public Sub set_ville_fournisseur(ville_fournisseur As Label)


        lb_ville = ville_fournisseur



    End Sub



    Public Function get_code_postal_fournisseur()


        Return lb_code_postal

    End Function


    Public Sub set_code_postal_fournisseur(code_postal_fournisseur As Label)




        lb_code_postal = code_postal_fournisseur


    End Sub


    Public Function get_remarque()

        Return txt_champ_remarque

    End Function


    Public Sub set_remarque(remarque As TextBox)

        txt_champ_remarque = remarque

    End Sub


    Public Function get_date_commande()

        Return lb_date_commande

    End Function


    Public Sub set_date_commande(date_commande As Label)

        lb_date_commande = date_commande

    End Sub


    Public Function get_numero_commande()

        Return lb_numero_commande

    End Function


    Public Sub set_numero_commande(numero_commande As Label)

        lb_numero_commande = numero_commande

    End Sub



    Public Function get_total()

        Return lb_total

    End Function


    Public Sub set_total(total As Label)

        lb_total = total

    End Sub


    Public Function get_tps()

        Return lb_tps

    End Function


    Public Sub set_tps(tps As Label)

        lb_tps = tps

    End Sub


    Public Function get_tvq()

        Return lb_tvq

    End Function


    Public Sub set_tvq(tvq As Label)

        lb_tvq = tvq

    End Sub


    Public Sub set_textbox_numero_commande(numero_commande As TextBox)

        txt_numero_commande = numero_commande

    End Sub



    Public Function get_txt_numero_commande()

        Return txt_numero_commande

    End Function




    Public Sub set_bouton_generer(bouton_generer As Button)

        btn_numero_aleatoire = bouton_generer

    End Sub



    Public Function get_bouton_generer()

        Return btn_numero_aleatoire

    End Function

    Public Sub set_bouton_commander(bouton_commander As Button)

        btn_commander = bouton_commander

    End Sub



    Public Function get_bouton_commander()

        Return btn_commander

    End Function


    'Get / Set'


    'Création du panel dynamique.
    Public Sub panel_dynamique()
        ctr_item += 1
        ctr_position_fournisseur = 0
        panel = New Panel
        'panel.BackColor = Color.FromArgb(44, 62, 80)
        panel.Top = ctrPosition


        panel.Left = 0
        panel.Name = ctr_item
        panel.Size = New Size(710, 240)
        panel.Visible = True
        pn_sauvegarde_commande.Controls.Add(panel)
        ctrPosition += panel.Height


    End Sub


    'Création du panel apres le panel dynamique.(Celui de couleur bleu foncé).
    Public Sub panel_entre()

        pn_entre = New Panel


        pn_entre.BackColor = Color.FromArgb(44, 62, 80)



        pn_entre.Top = ctrPosition



        pn_entre.Left = 0

        pn_entre.Size = New Size(710, 30)
        pn_entre.Visible = True
        pn_sauvegarde_commande.Controls.Add(pn_entre)
        ctrPosition += pn_entre.Height



    End Sub


    'Création du label fournisseur.
    Public Sub fournisseur()
        ctr_position_fournisseur = 10
        lb_fournisseur = New Label
        Me.lb_fournisseur.Font = New System.Drawing.Font("Segoe UI", 14.25, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_fournisseur.ForeColor = Color.Black
        Me.lb_fournisseur.Top = ctr_position_fournisseur
        Me.lb_fournisseur.Text = "Fournisseur"
        Me.lb_fournisseur.AutoSize = True
        panel.Controls.Add(lb_fournisseur)
        Me.lb_fournisseur.Left = 10

    End Sub

    'n'est pas utile pour le moment mais peut-être utile plus tard.
    Public Sub expediteur()

        lb_expediteur = New Label
        Me.lb_expediteur.Font = New System.Drawing.Font("Segoe UI", 14.25, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_expediteur.ForeColor = Color.Black
        Me.lb_expediteur.Top = 10
        Me.lb_expediteur.Text = "Expéditeur"
        Me.lb_expediteur.AutoSize = True
        panel.Controls.Add(lb_expediteur)
        Me.lb_expediteur.Left = 10



    End Sub

    'n'est pas utile pour le moment mais peut-être utile plus tard.
    Public Sub nom_expediteur()

        lb_nom_expediteur = New Label
        Me.lb_nom_expediteur.Font = New System.Drawing.Font("Segoe UI", 14.25, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_nom_expediteur.ForeColor = Color.Black
        Me.lb_nom_expediteur.Top = 25
        Me.lb_nom_expediteur.Text = "Cégep de Trois-Rivières"
        Me.lb_nom_expediteur.AutoSize = True
        panel.Controls.Add(lb_nom_expediteur)
        Me.lb_nom_expediteur.Left = 10


    End Sub

    'Label fournisseur crée.
    Public Sub nom_fournisseur()

        ctr_position_fournisseur += 15
        lb_nom_fournisseur = New Label
        Me.lb_nom_fournisseur.ForeColor = Color.Black
        'Me.lb_nom_fournisseur.Font = New System.Drawing.Font("Segoe UI", 9, 75, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_nom_fournisseur.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.lb_nom_fournisseur.Top = ctr_position_fournisseur
        Me.lb_nom_fournisseur.Text = ""
        Me.lb_nom_fournisseur.Name = "fournisseur" & ctr_item
        Me.lb_nom_fournisseur.AutoSize = True
        panel.Controls.Add(lb_nom_fournisseur)
        Me.lb_nom_fournisseur.Left = 10

    End Sub


    'Label adresse du fournisseur créer.
    Public Sub adresse_fournisseur()
        ctr_position_fournisseur += 15
        lb_adresse_fournisseur = New Label
        Me.lb_adresse_fournisseur.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_adresse_fournisseur.ForeColor = Color.Black
        Me.lb_adresse_fournisseur.Top = ctr_position_fournisseur
        Me.lb_adresse_fournisseur.Text = ""
        Me.lb_adresse_fournisseur.Name = "adresse_fournisseur" & ctr_item
        Me.lb_adresse_fournisseur.AutoSize = True
        panel.Controls.Add(lb_adresse_fournisseur)
        Me.lb_adresse_fournisseur.Left = 10


    End Sub

    'n'est pas utile pour le moment mais peut-être utile plus tard.
    Public Sub adresse_cegep()

        lb_adresse_cegep = New Label
        Me.lb_adresse_cegep.Font = New System.Drawing.Font("Segoe UI", 14.25, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_adresse_cegep.ForeColor = Color.Black
        Me.lb_adresse_cegep.Top = 40
        Me.lb_adresse_cegep.Text = "355, De Courval"
        Me.lb_adresse_cegep.AutoSize = True
        panel.Controls.Add(lb_adresse_cegep)
        Me.lb_adresse_cegep.Left = 10

    End Sub


    'n'est pas utile pour le moment mais peut-être utile plus tard.
    Public Sub ville_cegep()
        lb_ville_cegep = New Label
        Me.lb_ville_cegep.Font = New System.Drawing.Font("Segoe UI", 14.25, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ville_cegep.ForeColor = Color.Black
        Me.lb_ville_cegep.Top = 55

        Me.lb_ville_cegep.Text = "TROIS-RIVIÈRES(QUÉBEC) G8Z 3S8"
        Me.lb_ville_cegep.AutoSize = True
        panel.Controls.Add(lb_ville_cegep)

        Me.lb_ville_cegep.Left = 10


    End Sub

    'Label du fournisseur.

    Public Sub ville_fournisseur()
        ctr_position_fournisseur += 15
        lb_ville = New Label
        Me.lb_ville.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ville.ForeColor = Color.Black
        Me.lb_ville.Top = ctr_position_fournisseur
        Me.lb_ville.Text = ""
        Me.lb_ville.Name = "ville" & ctr_item
        Me.lb_ville.AutoSize = True
        panel.Controls.Add(lb_ville)
        Me.lb_ville.Left = 10

    End Sub

    'Label du code_postal.
    Public Sub code_postal_fournisseur()
        ctr_position_fournisseur += 15
        lb_code_postal = New Label
        Me.lb_code_postal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_code_postal.ForeColor = Color.Black
        Me.lb_code_postal.Top = ctr_position_fournisseur
        Me.lb_code_postal.Text = ""
        Me.lb_code_postal.Name = "code_postal" & ctr_item
        Me.lb_code_postal.AutoSize = True
        panel.Controls.Add(lb_code_postal)
        Me.lb_code_postal.Left = 10


    End Sub

    'n'est pas utile pour le moment mais peut-être utile plus tard.
    Public Sub internet_cegep()
        lb_internet_cegep = New Label
        Me.lb_internet_cegep.Font = New System.Drawing.Font("Segoe UI", 14.25, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_internet_cegep.ForeColor = Color.Black
        Me.lb_internet_cegep.Top = 85
        Me.lb_internet_cegep.Text = "www.cegeptr.qc.ca"
        Me.lb_internet_cegep.AutoSize = True
        panel.Controls.Add(lb_internet_cegep)
        Me.lb_internet_cegep.Left = 10

    End Sub

    'n'est pas utile pour le moment mais peut-être utile plus tard.
    Public Sub tel_cegep()
        lb_tel_cegep = New Label
        Me.lb_tel_cegep.Font = New System.Drawing.Font("Segoe UI", 14.25, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_tel_cegep.ForeColor = Color.Black
        Me.lb_tel_cegep.Top = 70
        Me.lb_tel_cegep.Text = "TÉL : 819 376-1721"
        Me.lb_tel_cegep.AutoSize = True
        panel.Controls.Add(lb_tel_cegep)
        Me.lb_tel_cegep.Left = 10

    End Sub
    'Label commande et met la date du jour automatiquement.
    Public Sub date_commande()

        lb_date_commande = New Label

        Me.lb_date_commande.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_date_commande.ForeColor = Color.Black
        Me.lb_date_commande.Top = 125

        Me.lb_date_commande.Text = "Date de commande : " & Date.Today
        date_ajourdhui = "Date de commande : " & Date.Today
        Me.lb_date_commande.AutoSize = True
        panel.Controls.Add(lb_date_commande)
        Me.lb_date_commande.Left = 10

    End Sub

    'Label numéro de commande'
    Public Sub numero_commande()


        lb_numero_commande = New Label

        Me.lb_numero_commande.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.lb_numero_commande.Font = New System.Drawing.Font("Segoe UI", 14.25, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_numero_commande.ForeColor = Color.Black
        Me.lb_numero_commande.Top = 145
        Me.lb_numero_commande.Text = "Numéro de commande :"
        Me.lb_numero_commande.AutoSize = True
        panel.Controls.Add(lb_numero_commande)
        Me.lb_numero_commande.Left = 10

    End Sub

    'Label pour écrire le numéro de commande'
    Public Sub champ_numero_commande()

        txt_numero_commande = New TextBox

        Me.txt_numero_commande.Font = New System.Drawing.Font("Microsoft Sans Serif; ", 8.25)
        Me.txt_numero_commande.ForeColor = Color.Black
        Me.txt_numero_commande.Size = New Size(100, 20)
        Me.txt_numero_commande.Top = 145
        Me.txt_numero_commande.Text = ""
        Me.txt_numero_commande.MaxLength = 6
        Me.txt_numero_commande.Name = ctr_item&
        panel.Controls.Add(txt_numero_commande)
        Me.txt_numero_commande.Left = panel.Width - 690 + lb_numero_commande.Width
        AddHandler txt_numero_commande.KeyPress, AddressOf evenement_textbox_keypress

        AddHandler txt_numero_commande.TextChanged, AddressOf evenement_textbox_change


    End Sub

    'Création  du bouton qui permet de générer un numéro aléatoire.
    Public Sub boutton_numero_aleatoire()

        btn_numero_aleatoire = New Button
        Me.btn_numero_aleatoire.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_numero_aleatoire.FlatAppearance.BorderSize = 0
        Me.btn_numero_aleatoire.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_numero_aleatoire.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_numero_aleatoire.Size = New System.Drawing.Size(125, 32)
        Me.btn_numero_aleatoire.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_numero_aleatoire.Top = 170
        Me.btn_numero_aleatoire.Text = "Générer un numéro"
        Me.btn_numero_aleatoire.Name = "generer" & ctr_item
        panel.Controls.Add(btn_numero_aleatoire)
        Me.btn_numero_aleatoire.Left = panel.Width - 690 + lb_numero_commande.Width
        AddHandler btn_numero_aleatoire.Click, AddressOf evenement_textbox_change


    End Sub

    'Création du textbox remarque'
    Public Sub textbox_remarque()

        txt_champ_remarque = New TextBox

        Me.txt_champ_remarque.Font = New System.Drawing.Font("Microsoft Sans Serif; ", 8.25)
        Me.txt_champ_remarque.ForeColor = Color.Black
        Me.txt_champ_remarque.Size = New Size(300, 125)
        Me.txt_champ_remarque.Top = 65
        Me.txt_champ_remarque.Text = ""
        Me.txt_champ_remarque.Multiline = True
        Me.txt_champ_remarque.MaxLength = 255
        Me.txt_champ_remarque.Name = "txt_champ_remarque"
        panel.Controls.Add(txt_champ_remarque)
        Me.txt_champ_remarque.Left = 395


    End Sub

    'Création du label remarque'
    Public Sub label_remarque()

        lb_remarque = New Label
        Me.lb_remarque.Font = New System.Drawing.Font("Segoe UI", 14.25, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_remarque.ForeColor = Color.Black
        Me.lb_remarque.Top = 45
        Me.lb_remarque.Text = "Remarque"
        Me.lb_remarque.Name = "remarque" & ctr_item
        panel.Controls.Add(lb_remarque)
        Me.lb_remarque.Left = 390

    End Sub

    'Création du label erreur'

    Public Sub label_erreur()

        lb_erreur = New Label
        Me.lb_erreur.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_erreur.ForeColor = Color.Black
        Me.lb_erreur.Top = 200
        Me.lb_erreur.Text = "Numéro existant"
        Me.lb_erreur.Visible = False
        Me.lb_erreur.AutoSize = True
        Me.lb_erreur.ForeColor = Color.Red
        Me.lb_erreur.Name = "erreur" & ctr_item
        panel.Controls.Add(lb_erreur)
        Me.lb_erreur.Left = 18 + lb_numero_commande.Width

    End Sub

    'Création du bouton sauvegarder'
    Public Sub boutton_sauvegarder()

        btnSauvegarder = New Button
        Me.btnSauvegarder.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnSauvegarder.FlatAppearance.BorderSize = 0
        Me.btnSauvegarder.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSauvegarder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSauvegarder.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSauvegarder.UseVisualStyleBackColor = False
        Me.btnSauvegarder.Size = New System.Drawing.Size(142, 32)
        Me.btnSauvegarder.Top = 20
        Me.btnSauvegarder.Text = "Sauvegarder"
        Me.btnSauvegarder.Name = ctr_item
        pn_bouton_fin.Controls.Add(btnSauvegarder)
        btnSauvegarder.AutoSize = True
        Me.btnSauvegarder.Left = btn_commander.Width + 95
        AddHandler btnSauvegarder.Click, New System.EventHandler(AddressOf evenement_sauvegarder)

    End Sub


    'Création du bouton pour ouvrir le pdf.'
    Public Sub boutton_ouvrir_pdf()
        ReDim nouvelle_liste_txt(ctr_item + 1)
        btn_ouvrir_pdf = New Button
        Me.btn_ouvrir_pdf.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_ouvrir_pdf.FlatAppearance.BorderSize = 0
        Me.btn_ouvrir_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ouvrir_pdf.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_ouvrir_pdf.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ouvrir_pdf.Size = New System.Drawing.Size(142, 32)
        Me.btn_ouvrir_pdf.Top = 20
        Me.btn_ouvrir_pdf.Text = "Ouvrir le fichier"
        Me.btn_ouvrir_pdf.Name = ctr_item
        pn_bouton_fin.Controls.Add(btn_ouvrir_pdf)
        Me.btn_ouvrir_pdf.Enabled = False
        Me.btn_ouvrir_pdf.UseVisualStyleBackColor = False
        btn_ouvrir_pdf.AutoSize = True
        Me.btn_ouvrir_pdf.Left = btnSauvegarder.Width + btn_commander.Width + 115
        AddHandler btn_ouvrir_pdf.Click, New System.EventHandler(AddressOf evenement_ouvrir_pdf)

    End Sub


    'Création du bouton pour commander'
    Public Sub boutton_commander()
        btn_commander = New Button
        Me.btn_commander.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_commander.FlatAppearance.BorderSize = 0
        Me.btn_commander.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_commander.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_commander.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_commander.Size = New System.Drawing.Size(142, 32)
        Me.btn_commander.Top = 20
        Me.btn_commander.UseVisualStyleBackColor = False
        Me.btn_commander.Text = "Commander"
        Me.btn_commander.Name = ctr_item
        pn_bouton_fin.Controls.Add(btn_commander)
        btn_commander.AutoSize = True
        Me.btn_commander.Left = 70
        AddHandler btn_commander.Click, New System.EventHandler(AddressOf evenement_commander)

    End Sub

    'Création du bouton pour annuler'
    Public Sub boutton_annuler()
        btn_annuler = New Button
        Me.btn_annuler.FlatAppearance.BorderSize = 0
        Me.btn_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_annuler.BackColor = System.Drawing.Color.DimGray
        Me.btn_annuler.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annuler.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_annuler.Size = New System.Drawing.Size(126, 32)
        Me.btn_annuler.Top = 20
        Me.btn_annuler.Text = "Annuler"
        Me.btn_annuler.Name = ctr_item
        Me.btn_annuler.UseVisualStyleBackColor = False
        pn_bouton_fin.Controls.Add(btn_annuler)
        btn_annuler.AutoSize = True
        Me.btn_annuler.Left = btnSauvegarder.Width + btn_commander.Width + btn_ouvrir_pdf.Width + 135
        AddHandler btn_annuler.Click, New System.EventHandler(AddressOf evenement_annuler)

    End Sub

    'Création de la function pour vérifier le numéro de commande'
    Public Function verification_numero_commande()

        Dim txt_vide As Boolean = False
        Dim erreur_txt As Boolean = False

        For Each pn_commande In pn_sauvegarde_commande.Controls

            If TypeOf pn_commande Is Panel Then

                For Each num_commande In pn_commande.Controls

                    If TypeOf num_commande Is TextBox Then

                        If num_commande.name <> "txt_champ_remarque" Then

                            If num_commande.Text = "" Then

                                txt_vide = True
                            End If

                        End If
                    End If

                    If TypeOf num_commande Is Label Then
                        For i = 1 To ctr_item
                            If num_commande.visible = True And num_commande.name = "erreur" & ctr_item Then

                                erreur_txt = True

                            End If

                        Next
                    End If
                Next
            End If

        Next

        If txt_vide = True Then


            MessageBox.Show("Veuillez remplir tout les champs de numéro de commande.", "Détails de Commande", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False

        ElseIf erreur_txt = True Then

            MessageBox.Show("Un de vos numéro de commande existe déja, veuillez entré un numéro inexistant ou en générer un automatiquement.", "Détails de Commande", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False

        Else

            Return True

        End If

    End Function

    'Lorsqu'il clique sur le bouton commander'
    Public Sub evenement_commander(sender As Object, e As EventArgs)



        If btn_commander.Text = "Commander" Then

            If MessageBox.Show("Êtes-vous certain de vouloir effectuer cette commande? Cette opération est définitive.", "Confirmation de commande", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                If verification_numero_commande() Then


                    sender.enabled = False
                    desactiver_bouton_textbox()
                    usrcommande.initialiser_nouvelle_commande()


                    If utls.Titre = "e" Then
                        commande()
                        usrcommande.btnNouvelleCommande.Enabled = False
                        usrcommande.btnAjouter.Enabled = False
                        usrcommande.btnModifier.Enabled = False
                        usrcommande.btnSupprimer.Enabled = False
                        usrcommande.Visible = True
                        usrcommande.compter_recepetion_exercice()
                        usrcommande.gestion_btn_eleves()



                    Else
                        commande()
                        usrcommande.btnAjouter.Enabled = False
                        usrcommande.btnModifier.Enabled = False
                        usrcommande.btnSupprimer.Enabled = False
                        usrcommande.btnNouvelleCommande.Enabled = True
                        usrcommande.gestion_btn_prof()
                        usrcommande.btnNouvelleCommande.Enabled = True
                    End If



                End If

            End If

        Else
            If MessageBox.Show("Une réception de commande existe déja, êtes-vous certain de vouloir la remplacer? Cette opération est définitive.", "Confirmation de réception de commande.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                usrcommande.supprimer_reception()
                usrcommande.assigner_commande()
                usrcommande.modifier_reception_details()

                MessageBox.Show("Votre réception de commande a été modifiée.", "Réception de commande", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If
    End Sub

    'Evenement pour ouvrir le fichier pdf'
    Public Sub evenement_ouvrir_pdf(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim proc As New Diagnostics.Process
        proc.StartInfo.UseShellExecute = True
        ' Définition du fichier à ouvrir 
        proc.StartInfo.FileName = sfd_commande_pdf.FileName
        proc.Start()

    End Sub

    ''' <summary>
    ''' Évenement pour sauvegarder le fichier pdf'
    ''' Ajouter nom cours,nom exercice et la date dans le pdf lignes de code : 1192-1209
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Public Sub evenement_sauvegarder(sender As Object, e As EventArgs)


        If verification_numero_commande() Then

            Dim nom_fournisseur As String = ""
            Dim adresse As String = ""
            Dim ville As String = ""
            Dim code_postal As String = ""
            Dim tvq As String = ""
            Dim tps As String = ""
            Dim total As String = ""
            Dim sous_total As String = ""
            Dim position As Integer = 1
            Dim ctr_remarque As Integer = 1
            Dim numero_commande As Integer = 0
            Dim remarque_commande As String = ""
            Dim pdfDoc As New Document()
            Dim ctr_passe_remarque As Integer = 0
            Dim table As New PdfPTable(7)


            sfd_commande_pdf.AddExtension = True
            sfd_commande_pdf.DefaultExt = ".pdf"


            If (sfd_commande_pdf.ShowDialog = DialogResult.OK) Then

                If sfd_commande_pdf.FileName <> Nothing Then

                    If File.Exists(sfd_commande_pdf.FileName) Then


                        Try
                            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(sfd_commande_pdf.FileName, FileMode.Create))
                            btn_ouvrir_pdf.Enabled = True
                            btn_annuler.Text = "Quitter"


                            MessageBox.Show("Votre commande à bien été enregistrer vers " & sfd_commande_pdf.FileName & ".", "Sauvegarde de commande.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Catch


                            MessageBox.Show("Votre fichier ne peut-être enregistrer ,car il est déja ouvert, veuillez le fermer.", "Sauvegarde de commande.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End Try

                    Else



                        Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(sfd_commande_pdf.FileName, FileMode.Create))
                        btn_annuler.Text = "Quitter"
                        btn_ouvrir_pdf.Enabled = True
                        MessageBox.Show("Votre commande à bien été enregistrer vers " & sfd_commande_pdf.FileName & ".", "Sauvegarde de commande.", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If


                    'Si le pdf n'existe pas, on l'ouvre.
                    For i = 1 To ctr_item

                        If i = 1 Then

                            pdfDoc.Open()
                        End If

                        'Création du cellule pour la table'
                        Dim cellule As New PdfPCell(New Phrase("Commande"))
                        cellule.Colspan = 7
                        cellule.HorizontalAlignment = 1
                        table.SpacingBefore = 40

                        table.AddCell(cellule)
                        table.AddCell("Produits")
                        table.AddCell("Fournisseurs")
                        table.AddCell("Quantité")
                        table.AddCell("Format")
                        table.AddCell("Unité de mesure")
                        table.AddCell("Prix unitaire")
                        table.AddCell("Total")
                        'Ceci permet d'initaliser la grandeur des colonnes du tableu'
                        Dim intTblWidth() As Integer = {30, 25, 17, 15, 20, 20, 20}
                        table.SetWidths(intTblWidth)
                        'Ceci permet de choisir le % de place que le tableau prendra sur la page'
                        table.WidthPercentage = 100

                        'Initalisation des strings utiliser'
                        nom_fournisseur = ""
                        adresse = ""
                        ville = ""
                        code_postal = ""
                        tvq = ""
                        tps = ""
                        sous_total = ""
                        total = ""


                        'Remplir nos string'
                        For Each pn_commande In pn_sauvegarde_commande.Controls

                            If TypeOf pn_commande Is Panel Then

                                For Each pn_objet In pn_commande.Controls




                                    If TypeOf pn_objet Is Label Then



                                        If pn_objet.name = "fournisseur" & position Then

                                            nom_fournisseur = pn_objet.text



                                        ElseIf pn_objet.name = "adresse_fournisseur" & position Then

                                            adresse = pn_objet.text



                                        ElseIf pn_objet.name = "ville" & position Then

                                            ville = pn_objet.text

                                        ElseIf pn_objet.name = "code_postal" & position Then

                                            adresse = pn_objet.text

                                        ElseIf pn_objet.name = "tps" & position Then

                                            tps = pn_objet.text

                                        ElseIf pn_objet.name = "tvq" & position Then

                                            tvq = pn_objet.text

                                        ElseIf pn_objet.name = "total" & position Then
                                            total = pn_objet.text



                                        ElseIf pn_objet.name = "Sous-total" & position Then
                                            sous_total = pn_objet.text



                                        ElseIf pn_objet.name = "total" & position & ":" Then

                                            total = total & "         " & pn_objet.text


                                        ElseIf pn_objet.name = "Sous-total" & position & ":" Then

                                            sous_total = sous_total & " " & pn_objet.text



                                        ElseIf pn_objet.name = "tvq" & position & ":" Then

                                            tvq = tvq & "          " & pn_objet.text



                                        ElseIf pn_objet.name = "tps" & position & ":" Then

                                            tps = tps & "          " & pn_objet.text


                                        End If


                                    End If

                                Next

                                'Remplir la table'
                            ElseIf TypeOf pn_commande Is ListView Then

                                If pn_commande.name = position Then

                                    For i2 = 0 To pn_commande.items.count - 1


                                        table.AddCell(pn_commande.items(i2).text)
                                        table.AddCell(pn_commande.items(i2).subitems(1).text)
                                        table.AddCell(pn_commande.items(i2).subitems(2).text)
                                        table.AddCell(pn_commande.items(i2).subitems(3).text)
                                        table.AddCell(pn_commande.items(i2).subitems(4).text)
                                        table.AddCell(pn_commande.items(i2).subitems(5).text)
                                        table.AddCell(pn_commande.items(i2).subitems(6).text)


                                    Next

                                End If

                            End If

                        Next


                        ctr_remarque = 0
                        'Remplir le champ remarque'
                        For Each pn_commande In pn_sauvegarde_commande.Controls

                            If TypeOf pn_commande Is Panel Then

                                For Each txt_num_commande In pn_commande.Controls

                                    If TypeOf txt_num_commande Is TextBox Then

                                        If txt_num_commande.name <> "txt_champ_remarque" Then
                                            If txt_num_commande.Name = position Then
                                                numero_commande = txt_num_commande.Text

                                            End If
                                        Else
                                            ctr_remarque += 1
                                            If ctr_remarque = position Then

                                                remarque_commande = txt_num_commande.text

                                            End If

                                        End If
                                    End If
                                Next
                            End If

                        Next


                        'C'est ici qu'on entre tous les informations dans le pdf.
                        position += 1
                        Dim ctr_line As Integer = 0
                        Dim position_ecrire As Double = 0
                        Dim pg As New Paragraph

                        Dim remarque_separer As String = ""





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
                        pg.Add(vbCrLf)
                        pg.FirstLineIndent = 30
                        pdfDoc.Add(pg)
                        pg.Clear()

                        pg.Add("Fournisseur")
                        pg.FirstLineIndent = 30
                        pdfDoc.Add(pg)
                        pg.Clear()
                        'pg = New Paragraph
                        If nom_fournisseur <> "" Then

                            pg.Add(nom_fournisseur)
                            pg.FirstLineIndent = 30
                            pdfDoc.Add(pg)
                            pg.Clear()
                        End If

                        If adresse <> "" Then

                            pg.Add(adresse)
                            pg.FirstLineIndent = 30
                            pdfDoc.Add(pg)
                            pg.Clear()
                        End If

                        If ville <> "" Then

                            pg.Add(ville)
                            pg.FirstLineIndent = 30
                            pdfDoc.Add(pg)
                            pg.Clear()

                        End If


                        If code_postal <> "" Then

                            pg.Add(code_postal)
                            pg.FirstLineIndent = 30
                            pdfDoc.Add(pg)
                            pg.Clear()

                        End If




                        pg.Clear()
                        pg.SetLeading(0, 2)
                        pg.Add(date_ajourdhui)
                        pg.FirstLineIndent = 30
                        pdfDoc.Add(pg)
                        pg.Clear()


                        pg.SetLeading(0, 1)
                        pg.Add("Numéro de commande : " & numero_commande)
                        pg.FirstLineIndent = 30
                        pdfDoc.Add(pg)
                        pg.Clear()


                        pdfDoc.Add(table)


                        pg.SetLeading(0, 2)
                        pg.Add(tps)
                        pg.FirstLineIndent = 395
                        pdfDoc.Add(pg)
                        pg.Clear()



                        pg.SetLeading(0, 1)
                        pg.Add(tvq)
                        pg.FirstLineIndent = 395
                        pdfDoc.Add(pg)
                        pg.Clear()


                        pg.SetLeading(0, 1)
                        pg.Add(sous_total)
                        pg.FirstLineIndent = 395
                        pdfDoc.Add(pg)
                        pg.Clear()




                        pg.SetLeading(0, 1)
                        pg.Add(total)
                        pg.FirstLineIndent = 395
                        pdfDoc.Add(pg)
                        pg.Clear()


                        'pg.SetLeading(0, 1)
                        ctr_passe_remarque = 0
                        Dim bfTimes As BaseFont
                        Dim times As Font

                        Dim pgGras As New Paragraph
                        bfTimes = BaseFont.CreateFont(BaseFont.TIMES_BOLD, BaseFont.CP1252, False)
                        times = New Font(bfTimes)
                        times.Size = 14


                        For Each lettre In (remarque_commande)
                            If ctr_passe_remarque = 0 Then
                                ctr_passe_remarque += 1
                                pgGras = New Paragraph("Remarque", times)
                                pgGras.FirstLineIndent = 5
                                'pg.Add("Remarque")
                                pdfDoc.Add(pgGras)

                                pgGras.Clear()
                            End If
                            If ctr_line = 60 Then

                                pg.Add(remarque_separer)
                                pg.FirstLineIndent = 5

                                pdfDoc.Add(pg)
                                pg.Clear()
                                remarque_separer = ""
                                ctr_line = 0


                            End If
                            ctr_line += 1

                            remarque_separer = remarque_separer & lettre
                        Next

                        If ctr_line > 1 Then

                            pg.Add(remarque_separer)
                            pg.FirstLineIndent = 5
                            pdfDoc.Add(pg)
                            pg.Clear()
                            remarque_separer = ""
                            ctr_line = 0

                        End If

                        table.DeleteBodyRows()
                        pg.Clear()
                        pdfDoc.NewPage()

                        'On ferme le fichier pdf'.
                        If i = ctr_item Then
                            pdfDoc.Close()
                        End If
                    Next

                End If

            End If
        End If
    End Sub


    'Ajouter la commande à la base de donnée'
    Public Sub commande()
        Dim id_fournisseur As String = 0
        Dim numero_commande As String = 0
        Dim nbr_commande_exercice As Integer = 0
        Dim montant_total As Double = 0
        Dim montant_replacer As String = ""
        Dim remarque_commande As String = ""
        Dim ctr_remarque As Integer = 0


        For i = 1 To ctr_item



            For Each lsv_commande In pn_sauvegarde_commande.Controls

                If TypeOf lsv_commande Is ListView Then

                    If lsv_commande.name = i Then

                        id_fournisseur = trouver_id_fournisseur(lsv_commande.Items(0).SubItems(1).Text)
                    End If

                End If


            Next
            ctr_remarque = 0



            For Each pn_commande In pn_sauvegarde_commande.Controls

                If TypeOf pn_commande Is Panel Then

                    For Each txt_num_commande In pn_commande.Controls

                        If TypeOf txt_num_commande Is TextBox Then

                            If txt_num_commande.name <> "txt_champ_remarque" Then
                                If txt_num_commande.Name = i Then
                                    numero_commande = txt_num_commande.Text

                                End If
                            Else
                                ctr_remarque += 1
                                If ctr_remarque = i Then

                                    remarque_commande = txt_num_commande.text

                                End If

                            End If

                        End If


                        If TypeOf txt_num_commande Is Label Then
                            If txt_num_commande.Name = "total" & i & ":" Then

                                Dim str_requete_substr As String = ""
                                Dim str_requete_replace As String = ""


                                str_requete_replace = "select replace ('" & txt_num_commande.text & "' , ',' , '.')"

                                gestionBd.miseAjourDS(dataset, dataAdapter, str_requete_replace, table)



                                str_requete_replace = "select replace ('" & dataset.Tables(0).Rows(0).Item(0) & "' , ':' , '')"
                                gestionBd.miseAjourDS(dataset, dataAdapter, str_requete_replace, table)



                                str_requete_substr = "Select substr('" & dataset.Tables(0).Rows(0).Item(0) & "',1,length('" & dataset.Tables(0).Rows(0).Item(0) & "')-2)"
                                gestionBd.miseAjourDS(dataset, dataAdapter, str_requete_substr, table)



                                montant_replacer = Replace(dataset.Tables(0).Rows(0).Item(0), Chr(160), "")

                            End If

                        End If

                    Next
                End If

            Next





            Dim str_requete_insert As String = ""


            str_requete_insert = "INSERT INTO tbl_commandes VALUES ('" + numero_commande + "','" + utls.No_id + "','" + id_fournisseur + "'," & exercice & ",'" &
                montant_replacer & "', sysdate(),'" & StrConv(ConvertirApostrophe(remarque_commande), VbStrConv.ProperCase) & "',1)"

            gestionBd.InsDelUpd(str_requete_insert)


            If utls.Titre = "p" Then
                str_requete_insert = "INSERT INTO tbl_commandes_prof VALUES ('" + utls.No_id + "','" + numero_commande + "'," & exercice & ")"
                gestionBd.InsDelUpd(str_requete_insert)
            End If

            str_requete_insert = "INSERT INTO tbl_commandes_exercices VALUES (" & exercice & ",'" + numero_commande & "','" + utls.No_id & "')"


            gestionBd.InsDelUpd(str_requete_insert)

        Next

        commande_detaillee()
        btn_commander.Enabled = False


    End Sub

    'Function qui permet de trouver l'id du fournisseur avec le nom du fournisseur.'

    Public Function trouver_id_fournisseur(nom_fournisseur As String) As String


        str_requete = "select nom_fournisseur, no_fournisseur from tbl_fournisseurs where nom_fournisseur = '" & nom_fournisseur & "'"

        table = "tbl_fournisseurs"
        gestionBd.miseAjourDS(dataset, dataAdapter, str_requete, table)


        Return dataset.Tables(0).Rows(0).Item(1)

    End Function


    'Insérér les détails de la commande dans la bd.'
    Public Sub commande_detaillee()


        Dim code_produit As String = ""
        Dim no_format As Integer = 0
        Dim no_categorie As Integer = 0
        Dim no_mesure As Integer = 0
        Dim numero_commande As String = 0
        Dim quantite As String = 0
        Dim dateR As Date = System.DateTime.Now

        For i = 1 To ctr_item

            For Each lsv_commande In pn_sauvegarde_commande.Controls

                If TypeOf lsv_commande Is ListView Then

                    If lsv_commande.name = i Then


                        For Each pn_commande In pn_sauvegarde_commande.Controls

                            If TypeOf pn_commande Is Panel Then

                                For Each txt_num_commande In pn_commande.Controls

                                    If TypeOf txt_num_commande Is TextBox Then

                                        If txt_num_commande.name <> "txt_champ_remarque" Then
                                            If txt_num_commande.Name = i Then
                                                numero_commande = txt_num_commande.Text

                                                For i2 = 0 To lsv_commande.items.count - 1

                                                    no_format = trouver_no_format(lsv_commande.Items(i2).SubItems(3).Text)
                                                    no_mesure = trouver_no_mesure(lsv_commande.Items(i2).SubItems(4).Text)
                                                    code_produit = trouver_id_produit(lsv_commande.Items(i2).SubItems(0).Text, no_format, no_mesure)
                                                    quantite = lsv_commande.Items(i2).SubItems(2).Text

                                                    Dim str_requete_insert_detail As String = ""

                                                    Dim str_requete_replace As String = ""
                                                    Dim str_requete_substr As String = ""
                                                    Dim prix_unitaire As String = ""
                                                    prix_unitaire = lsv_commande.Items(i2).SubItems(5).Text


                                                    str_requete_replace = "select replace ('" & prix_unitaire & "' , ',' , '.')"

                                                    gestionBd.miseAjourDS(dataset, dataAdapter, str_requete_replace, table)

                                                    str_requete_substr = "Select substr('" & dataset.Tables(0).Rows(0).Item(0) & "',1,length('" & dataset.Tables(0).Rows(0).Item(0) & "')-2)"
                                                    gestionBd.miseAjourDS(dataset, dataAdapter, str_requete_substr, table)


                                                    str_requete_insert_detail = "Insert into tbl_commandes_detaillees values('" + code_produit + "','" + numero_commande + "','" + quantite + "','" + dataset.Tables(0).Rows(0).Item(0) + "')"

                                                    gestionBd.InsDelUpd(str_requete_insert_detail)

                                                Next

                                            End If
                                        End If

                                    End If
                                Next
                            End If

                        Next


                    End If

                End If
            Next


        Next

        If utls.Titre = "e" Then
            MessageBox.Show("L'exercice a été remis avec succès.", "Commande", MessageBoxButtons.OK, MessageBoxIcon.Information)



        ElseIf utls.Titre = "p" Then

            MessageBox.Show("Votre commande a été assignée à l'exercice.", "Commande", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    'L'événement l'orsqu'il clique sur le bouton annuler.
    Public Sub evenement_annuler()

        Me.Close()
    End Sub

    'Function qui permet de trouver le numéro de format avec le nom de format'.
    Public Function trouver_no_format(nom_format As String) As Integer
        str_requete = "select nom_format,no_format from tbl_formats where nom_format = '" & StrConv(ConvertirApostrophe(nom_format.Trim), VbStrConv.ProperCase) & "'"

        table = "tbl_formats"
        gestionBd.miseAjourDS(dataset, dataAdapter, str_requete, table)


        Return dataset.Tables(0).Rows(0).Item(1)

    End Function

    'Function qui permet de trouver le numéro de mesure avec le nom de mesure.
    Public Function trouver_no_mesure(nom_mesure As String) As Integer

        str_requete = "select no_mesure,unite_mesure from tbl_unites_mesure where unite_mesure = '" & nom_mesure & "'"

        table = "tbl_unties_mesure"
        gestionBd.miseAjourDS(dataset, dataAdapter, str_requete, table)


        Return dataset.Tables(0).Rows(0).Item(0)


    End Function

    'Function qui permet de trouver l'id du produit.
    Public Function trouver_id_produit(nom_produit As String, no_format As Integer, no_mesure As Integer) As String

        str_requete = "select p.nom_produit,p.code_produit from tbl_produits p,tbl_formats f,tbl_unites_mesure um 
where p.no_format = f.no_format and p.no_mesure = um.no_mesure
and p.nom_produit  = '" & StrConv(ConvertirApostrophe(nom_produit.Trim), VbStrConv.ProperCase) & "'and f.no_format = '" & StrConv(ConvertirApostrophe(no_format), VbStrConv.ProperCase) & "'and um.no_mesure = '" & StrConv(ConvertirApostrophe(no_mesure), VbStrConv.ProperCase) & "'"
        table = "tbl_produits"
        gestionBd.miseAjourDS(dataset, dataAdapter, str_requete, table)

        Return dataset.Tables(0).Rows(0).Item(1)



    End Function

    'Création du listview.'
    Public Sub list_view_dynamique()

        Me.listview = New ListView
        Me.listview.Top = ctrPosition
        Me.listview.Columns.Add("Produits")
        Me.listview.Columns.Add("Fournisseurs")
        Me.listview.Columns.Add("Quantité")
        Me.listview.Columns.Add("Format")
        Me.listview.Columns.Add("Unité de mesure")
        Me.listview.Columns.Add("Prix unitaire")
        Me.listview.Columns.Add("Total")
        Me.listview.AllowColumnReorder = False
        Me.listview.LabelEdit = 1
        Me.listview.Size = New Size(580, 145)
        Me.listview.Columns(2).TextAlign = HorizontalAlignment.Right
        Me.listview.Columns(5).TextAlign = HorizontalAlignment.Right
        Me.listview.Columns(6).TextAlign = HorizontalAlignment.Right
        Me.listview.Name = ctr_item
        Me.listview.Left = 10
        Me.listview.GridLines = True
        Me.listview.View = System.Windows.Forms.View.Details
        Me.listview.HideSelection = False
        Me.listview.AutoArrange = True
        AddHandler listview.ColumnWidthChanging, AddressOf ListView1_ColumnWidthChanging
        pn_sauvegarde_commande.Controls.Add(listview)

        ctrPosition += listview.Height

    End Sub

    'Pour éviter que les colonnes de la listview soit modifier.
    Private Sub ListView1_ColumnWidthChanging(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnWidthChangingEventArgs)

        Dim index_colonne As Integer = 0
        index_colonne = e.ColumnIndex

        If e.NewWidth <> sender.Columns(index_colonne).Width Then
            e.Cancel = True
            e.NewWidth = sender.Columns(index_colonne).Width
        End If
    End Sub

    'Création du panel ou est-ce qu'on gère les prix'.
    Public Sub panel_prix()

        pn_panel_prix = New Panel

        pn_panel_prix.Top = ctrPosition
        pn_panel_prix.Name = "pn_prix"
        pn_panel_prix.Left = 0
        pn_panel_prix.Size = New Size(714, 125)
        pn_panel_prix.Visible = True

        pn_sauvegarde_commande.Controls.Add(pn_panel_prix)
        ctrPosition += pn_panel_prix.Height

    End Sub

    'Création du panel ou l'on met les boutons à la fin'.
    Public Sub panel_bouton_fin()

        pn_bouton_fin = New Panel
        pn_bouton_fin.Top = ctrPosition
        pn_bouton_fin.Left = 0
        pn_bouton_fin.Size = New Size(714, 100)
        pn_bouton_fin.Visible = True
        pn_sauvegarde_commande.Controls.Add(pn_bouton_fin)
        ctrPosition += pn_bouton_fin.Height

    End Sub


    'Création du label TVQ'

    Public Sub tvq()

        lb_tvq = New Label
        Me.lb_tvq.Font = New System.Drawing.Font("Segoe UI", 14.25, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_tvq.ForeColor = Color.Black
        Me.lb_tvq.Top = 35
        Me.lb_tvq.Text = "TVQ"
        Me.lb_tvq.AutoSize = True
        Me.lb_tvq.Name = "tvq" & ctr_item
        pn_panel_prix.Controls.Add(lb_tvq)
        Me.lb_tvq.Left = 10
        label_deux_points(Me.lb_tvq.Top, Me.lb_tvq.Width + 52, Me.lb_tvq.Name)

    End Sub


    'Création du label TPS'

    Public Sub tps()

        lb_tps = New Label
        Me.lb_tps.Font = New System.Drawing.Font("Segoe UI", 14.25, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_tps.ForeColor = Color.Black
        Me.lb_tps.Top = 10
        Me.lb_tps.Text = "TPS"
        Me.lb_tps.AutoSize = True
        Me.lb_tps.Name = "tps" & ctr_item
        pn_panel_prix.Controls.Add(lb_tps)
        Me.lb_tps.Left = 10
        label_deux_points(Me.lb_tps.Top, Me.lb_tps.Width + 57, Me.lb_tps.Name)

    End Sub


    'Création du label :'
    Public Sub label_deux_points(top As String, left As String, name As String)

        lb_deux_point = New Label

        Me.lb_deux_point.Font = New System.Drawing.Font("Segoe UI", 14.25, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_deux_point.ForeColor = Color.Black
        Me.lb_deux_point.Top = top
        Me.lb_deux_point.Text = ": "
        Me.lb_deux_point.Name = name & ":"
        Me.lb_deux_point.AutoSize = True
        pn_panel_prix.Controls.Add(lb_deux_point)
        Me.lb_deux_point.Left = left



    End Sub



    'Création du label Sous-total'
    Public Sub sous_total()

        lb_sous_total = New Label


        Me.lb_sous_total.Font = New System.Drawing.Font("Segoe UI", 14.25, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_sous_total.ForeColor = Color.Black
        Me.lb_sous_total.Top = 60
        Me.lb_sous_total.Text = "Sous-total"
        Me.lb_sous_total.AutoSize = True
        Me.lb_sous_total.Name = "Sous-total" & ctr_item
        pn_panel_prix.Controls.Add(lb_sous_total)
        Me.lb_sous_total.Left = 10
        label_deux_points(Me.lb_sous_total.Top, 89, Me.lb_sous_total.Name)

    End Sub


    'Création du label Total'
    Public Sub total()

        lb_total = New Label


        Me.lb_total.Font = New System.Drawing.Font("Segoe UI", 14.25, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_total.ForeColor = Color.Black
        Me.lb_total.Top = 84
        Me.lb_total.Text = "Total"
        Me.lb_total.AutoSize = True
        Me.lb_total.Name = "total" & ctr_item
        pn_panel_prix.Controls.Add(lb_total)
        Me.lb_total.Left = 10


        label_deux_points(Me.lb_total.Top, Me.lb_total.Width + 41, Me.lb_total.Name)

    End Sub

    'Procedure pour calculer le prix total'
    Public Sub calculer()

        Dim str_taxes As String = ""
        Dim datasetTaxes As New DataSet

        str_taxes = "Select pt.code_produit, t.type_taxe, p.nom_produit, f.nom_format
from tbl_produit_taxe pt , tbl_taxes t, tbl_produits p, tbl_formats f
where p.code_produit = pt.code_produit and t.id_taxes = pt.id_taxe and f.no_format = p.no_format"


        table = "tbl_produit_taxe"

        gestionBd.miseAjourDS(datasetTaxes, dataAdapter, str_taxes, table)

        For Each lsv_commande In pn_sauvegarde_commande.Controls

            If TypeOf lsv_commande Is ListView Then



                Dim prixUnitaire As Double = 0
                Dim prix_total As Double = 0
                Dim tvq As Double = 0
                Dim tps As Double = 0
                Dim prix_tps As Double = 0
                Dim prix_tvq As Double = 0
                Dim total_tps As Double = 0
                Dim total_tvq As Double = 0
                Dim tps_tvq As Double = 0
                Dim prix_produit As Double = 0
                Dim sous_total As Double = 0

                Dim prix_taxes As Double = 0

                'boucle qui compte le nombre d'item dans la commande'
                For i = 0 To lsv_commande.Items.Count - 1
                    prix_produit = 0
                    prixUnitaire = lsv_commande.Items(i).SubItems(2).Text * lsv_commande.Items(i).SubItems(5).Text
                    prix_produit = lsv_commande.Items(i).SubItems(2).Text * lsv_commande.Items(i).SubItems(5).Text
                    prix_total += prixUnitaire


                    For i2 = 0 To datasetTaxes.Tables(0).Rows.Count - 1


                        If datasetTaxes.Tables(0).Rows(i2).Item(1) = "TPS" And datasetTaxes.Tables(0).Rows(i2).Item(2) = lsv_commande.Items(i).Text And datasetTaxes.Tables(0).Rows(i2).Item(3) = lsv_commande.Items(i).SubItems(3).Text Then

                            tps = Val(gestionBd.Requete("select `pourcentage_taxe` from `tbl_taxes` where `type_taxe` = 'TPS' and `date_taxe` = (select max(`date_taxe`) from tbl_taxes where type_taxe = 'TPS' group by `type_taxe`) and `id_taxes` = (select max(`id_taxes`) from tbl_taxes where type_taxe = 'TPS' group by `type_taxe`)"))
                        End If

                        If datasetTaxes.Tables(0).Rows(i2).Item(1) = "TVQ" And datasetTaxes.Tables(0).Rows(i2).Item(2) = lsv_commande.Items(i).Text And datasetTaxes.Tables(0).Rows(i2).Item(3) = lsv_commande.Items(i).SubItems(3).Text Then


                            tvq = Val(gestionBd.Requete("select `pourcentage_taxe` from `tbl_taxes` where `type_taxe` = 'TVQ'and `date_taxe` = (select max(`date_taxe`) from tbl_taxes where type_taxe = 'TVQ' group by `type_taxe`) and `id_taxes` = (select max(`id_taxes`) from tbl_taxes where type_taxe = 'TVQ' group by `type_taxe`)"))

                        End If

                    Next

                    If tps <> 0 Then

                        prix_tps = (prix_produit * tps) / 100
                        total_tps += prix_tps
                        prix_tps = 0

                    End If

                    If tvq <> 0 Then

                        prix_tvq = (prix_produit * tvq) / 100

                        total_tvq += prix_tvq
                        prix_tvq = 0

                    End If
                Next
                sous_total = prix_total

                prix_total += total_tps + total_tvq

                For Each pn_prix In pn_sauvegarde_commande.Controls

                    If TypeOf pn_prix Is Panel Then

                        For Each lb_prix In pn_prix.Controls

                            If TypeOf lb_prix Is Label Then



                                If lb_prix.name = "total" & lsv_commande.name & ":" Then



                                    lb_prix.text = lb_prix.text & FormatCurrency(prix_total)

                                ElseIf lb_prix.name = "tps" & lsv_commande.name & ":" Then

                                    lb_prix.text = lb_prix.text & FormatCurrency(total_tps)

                                ElseIf lb_prix.name = "tvq" & lsv_commande.name & ":" Then

                                    lb_prix.text = lb_prix.text & FormatCurrency(total_tvq)

                                ElseIf lb_prix.name = "Sous-total" & lsv_commande.name & ":" Then

                                    lb_prix.text = lb_prix.text & FormatCurrency(sous_total)

                                Else

                                End If

                            End If

                        Next

                    End If


                Next

            End If
        Next

    End Sub


    'Procedure pour s'assurer des modifications faites dans le textbox numéro de commande'.
    Public Sub modification_textbox()

        Dim i2 As Integer = 0
        For Each pn_commande In pn_sauvegarde_commande.Controls

            If TypeOf pn_commande Is Panel Then


                For Each txt In pn_commande.Controls
                    If txt.name <> "txt_champ_remarque" Then
                        If TypeOf txt Is TextBox Then

                            i2 += 1

                            txt.text = nouvelle_liste_txt(i2)


                        End If
                    End If
                Next
            End If


        Next


    End Sub

    'Événement qui vérifie les doublons lors d'une entré dans le textbox, incluant le bouton générer.
    Public Sub evenement_textbox_change(sender As Object, e As EventArgs)

        If txt_numero_commande.Enabled = True Then
            Dim generator As New Random

            Dim i As Integer = 0
            Dim i2 As Integer = 0
            Dim ctr_passe As Integer = 0
            Dim liste_doublon(ctr_item) As String
            Dim liste_non_doublon(ctr_item) As String
            Dim trouver As Boolean = False


            ReDim nouvelle_liste_txt(ctr_item)

            Dim verif_doublon As Boolean = True

            'Vérifie le numéro entré dans le textbox.'
            For Each pn_commande In pn_sauvegarde_commande.Controls

                If TypeOf pn_commande Is Panel Then


                    For Each txt In pn_commande.Controls

                        If TypeOf txt Is TextBox Then

                            If txt.name <> "txt_champ_remarque" Then
                                i2 += 1
                                If sender.name = "generer" & i2 Then


                                    txt.text = generator.Next(1, 999999)


                                    randomValue = txt.text

                                    nouvelle_liste_txt(i2) = randomValue

                                Else

                                    nouvelle_liste_txt(i2) = txt.text


                                End If

                            End If

                        End If


                    Next

                End If

            Next



            'Vérifie si un nombre existe dans un autre textbox ou dans la base de donnée.'
            For i = 1 To nouvelle_liste_txt.Count - 1
                ctr_passe = 0
                For i2 = 1 To nouvelle_liste_txt.Count - 1



                    If nouvelle_liste_txt(i) <> "" Then

                        If sender.name = "generer" & i2 Then


                            For i3 = 1 To nouvelle_liste_txt.Count - 1

                                If i3 <> i2 And nouvelle_liste_txt(i3) <> "" Then
                                    While nouvelle_liste_txt(i3) = randomValue Or verification_numero_commande_bd(randomValue) = True

                                        trouver = True

                                        randomValue = generator.Next(1, 999999)

                                        nouvelle_liste_txt(i2) = randomValue
                                    End While

                                End If

                                If i3 = i2 And ctr_item = 1 And nouvelle_liste_txt(i3) <> "" Then
                                    While verification_numero_commande_bd(randomValue) = True

                                        trouver = True

                                        randomValue = generator.Next(1, 999999)

                                        nouvelle_liste_txt(i2) = randomValue
                                    End While

                                End If


                                If trouver = True Then

                                    i3 = 1
                                    trouver = False
                                End If
                            Next


                        End If
                    End If


                Next


                For i2 = 1 To nouvelle_liste_txt.Count - 1


                    If i <> i2 Or i = i2 And i = ctr_item Then

                        If i <> i2 Then
                            If nouvelle_liste_txt(i) <> "" And nouvelle_liste_txt(i) = nouvelle_liste_txt(i2) Then

                                liste_doublon(i) = i
                                ctr_passe += 1

                            End If
                        End If
                        If nouvelle_liste_txt(i) <> "" Then


                            If verification_numero_commande_bd(nouvelle_liste_txt(i)) = True Then
                                ctr_passe += 1
                                liste_doublon(i) = i
                            End If

                        End If

                    End If





                Next

                If ctr_passe = 0 Then

                    liste_non_doublon(i) = i

                End If
            Next


            'affiche le label true ou false selon sa liste(doublon ou non doublon).'

            For Each pn_commande In pn_sauvegarde_commande.Controls

                If TypeOf pn_commande Is Panel Then

                    For Each lb In pn_commande.Controls

                        If TypeOf lb Is Label Then

                            For i = 1 To liste_doublon.Count - 1

                                If lb.name = "erreur" & liste_doublon(i) Then

                                    lb.visible = True

                                ElseIf lb.name = "erreur" & liste_non_doublon(i) Then

                                    lb.visible = False

                                End If


                            Next

                        End If
                    Next

                End If

            Next


            modification_textbox()

        End If

    End Sub


    Public Sub evenement_textbox_keypress(sender As Object, e As KeyPressEventArgs)


        If Not IsNumeric(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True

        End If

    End Sub

    'Désactiver le bouton générer lorsque la commande est effectué.
    Public Sub desactiver_bouton_textbox()

        Dim nbr_btn As Integer = 0
        For Each pn_commande In pn_sauvegarde_commande.Controls

            If TypeOf pn_commande Is Panel Then

                For Each btn_txt_commande In pn_commande.Controls

                    If TypeOf btn_txt_commande Is Button Then

                        If btn_txt_commande.name = "generer" & nbr_btn Then

                            btn_txt_commande.enabled = False
                            nbr_btn += 1
                        End If
                    ElseIf TypeOf btn_txt_commande Is TextBox Then

                        btn_txt_commande.enabled = False
                    End If

                Next

            End If

        Next

    End Sub


    'Function pour vérifier le numéro de commande'.
    Public Function verification_numero_commande_bd(no_commande As Integer) As Boolean


        str_requete = "Select u.no_utilisateur, f.no_fournisseur, c.no_commande from tbl_commandes c, tbl_utilisateurs u, tbl_fournisseurs f
        where u.no_utilisateur = c.no_utilisateur and f.no_fournisseur = c.no_fournisseur and u.no_utilisateur = '" & utls.No_id & "' and c.no_commande ='" & no_commande & "'"

        table = "tbl_commandes"
        gestionBd.miseAjourDS(dataset, dataAdapter, str_requete, table)


        If dataset.Tables(0).Rows.Count = 1 Then

            Return True

        Else

            Return False

        End If


    End Function

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, pnl_navigation.MouseDown, lbl_titre.MouseDown
        mod_mvtFenetre.mouseDown(e)
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, pnl_navigation.MouseMove, lbl_titre.MouseMove
        mod_mvtFenetre.mouseMove(e, Me)
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp, pnl_navigation.MouseUp, lbl_titre.MouseUp
        mod_mvtFenetre.mouseUp(e)
    End Sub

    Private Sub btn_exit_Click_1(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_minimize_Click_1(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pnl_navigation_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub pn_sauvegarde_commande_Paint(sender As Object, e As PaintEventArgs) Handles pn_sauvegarde_commande.Paint

    End Sub

    Private Sub sfd_commande_pdf_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles sfd_commande_pdf.FileOk

    End Sub
End Class