<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usr_rech_gestion_produit
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbo_ordre = New System.Windows.Forms.ComboBox()
        Me.cbo_trier_par = New System.Windows.Forms.ComboBox()
        Me.lbl_mots_cles = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_allergenes_keyword = New System.Windows.Forms.TextBox()
        Me.cbo_allergenes = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rdb_perissable_tous = New System.Windows.Forms.RadioButton()
        Me.rdb_perissable_oui = New System.Windows.Forms.RadioButton()
        Me.rdb_perissable_non = New System.Windows.Forms.RadioButton()
        Me.cbo_rech_categorie = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_rech_marque = New System.Windows.Forms.TextBox()
        Me.cbo_marque_contient = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbo_nom_contient = New System.Windows.Forms.ComboBox()
        Me.txt_rech_nom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_description_keyword = New System.Windows.Forms.TextBox()
        Me.cbo_description = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnRechercher = New System.Windows.Forms.Button()
        Me.btnReinitialiser = New System.Windows.Forms.Button()
        Me.pnl_recherches = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.rdb_bio_tous = New System.Windows.Forms.RadioButton()
        Me.rdb_bio_oui = New System.Windows.Forms.RadioButton()
        Me.rdb_bio_non = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rdb_actifs_tous = New System.Windows.Forms.RadioButton()
        Me.rdb_actifs_non = New System.Windows.Forms.RadioButton()
        Me.rdb_actifs_oui = New System.Windows.Forms.RadioButton()
        Me.lbl_ajoutSucces = New System.Windows.Forms.Label()
        Me.btn_modifier = New System.Windows.Forms.Button()
        Me.btn_desactiver = New System.Windows.Forms.Button()
        Me.dgv_produits = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timer_succes = New System.Windows.Forms.Timer(Me.components)
        Me.btn_reactiver = New System.Windows.Forms.Button()
        Me.pnl_ajout_mod = New System.Windows.Forms.Panel()
        Me.chk_tvq = New System.Windows.Forms.CheckBox()
        Me.chk_tps = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.nm_quantite = New System.Windows.Forms.NumericUpDown()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lbl_mode = New System.Windows.Forms.Label()
        Me.txt_remarque = New System.Windows.Forms.RichTextBox()
        Me.btn_generer = New System.Windows.Forms.Button()
        Me.txt_no_produit = New System.Windows.Forms.TextBox()
        Me.lbl_erreur_bio = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.cbo_bio = New System.Windows.Forms.ComboBox()
        Me.txt_nom_produit = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_marque = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lbl_mesure = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lbl_erreur_perissable = New System.Windows.Forms.Label()
        Me.cbo_categories = New System.Windows.Forms.ComboBox()
        Me.cbo_perissable = New System.Windows.Forms.ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cbo_format = New System.Windows.Forms.ComboBox()
        Me.lbl_erreur_quantite = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lbl_erreur_mesure = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lbl_erreur_format = New System.Windows.Forms.Label()
        Me.lbl_erreur_marque = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lbl_erreur_nom_produit = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lbl_erreur_code_plu = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lbl_erreur_code_barre = New System.Windows.Forms.Label()
        Me.txt_description = New System.Windows.Forms.RichTextBox()
        Me.lbl_erreur_numero = New System.Windows.Forms.Label()
        Me.txt_allergenes = New System.Windows.Forms.RichTextBox()
        Me.btn_valider = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btn_mesure = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lbl_erreur_categorie = New System.Windows.Forms.Label()
        Me.txt_code_barre = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_code_plu = New System.Windows.Forms.TextBox()
        Me.cms_unites_mesure = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tmr_animation = New System.Windows.Forms.Timer(Me.components)
        Me.btn_ajouter = New System.Windows.Forms.Button()
        Me.btn_visualiser = New System.Windows.Forms.Button()
        Me.btn_excel = New System.Windows.Forms.Button()
        Me.btn_associer = New System.Windows.Forms.Button()
        Me.pnl_rien = New System.Windows.Forms.Panel()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_historique_taxes = New System.Windows.Forms.Button()
        Me.btn_Taux_taxes = New System.Windows.Forms.Button()
        Me.btn_Ajout_Allergene = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.pnl_recherches.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_produits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_ajout_mod.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.nm_quantite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.pnl_rien.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbo_ordre
        '
        Me.cbo_ordre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_ordre.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_ordre.FormattingEnabled = True
        Me.cbo_ordre.Items.AddRange(New Object() {"Ordre croissant", "Ordre décroissant"})
        Me.cbo_ordre.Location = New System.Drawing.Point(134, 15)
        Me.cbo_ordre.Name = "cbo_ordre"
        Me.cbo_ordre.Size = New System.Drawing.Size(211, 23)
        Me.cbo_ordre.TabIndex = 1
        '
        'cbo_trier_par
        '
        Me.cbo_trier_par.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_trier_par.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_trier_par.FormattingEnabled = True
        Me.cbo_trier_par.Items.AddRange(New Object() {"N° de produit (par défaut)", "Nom de produit", "Marque", "Catégorie", "Bio (Oui/Non)", "Périssable (Oui/Non)", "Description (Oui/Non)", "Allergènes (Oui/Non)"})
        Me.cbo_trier_par.Location = New System.Drawing.Point(357, 15)
        Me.cbo_trier_par.Name = "cbo_trier_par"
        Me.cbo_trier_par.Size = New System.Drawing.Size(212, 23)
        Me.cbo_trier_par.TabIndex = 2
        '
        'lbl_mots_cles
        '
        Me.lbl_mots_cles.AutoSize = True
        Me.lbl_mots_cles.Enabled = False
        Me.lbl_mots_cles.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mots_cles.ForeColor = System.Drawing.Color.Gray
        Me.lbl_mots_cles.Location = New System.Drawing.Point(693, 37)
        Me.lbl_mots_cles.Name = "lbl_mots_cles"
        Me.lbl_mots_cles.Size = New System.Drawing.Size(57, 15)
        Me.lbl_mots_cles.TabIndex = 101
        Me.lbl_mots_cles.Text = "Mots clés"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(70, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 17)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "Trier par"
        '
        'txt_allergenes_keyword
        '
        Me.txt_allergenes_keyword.Enabled = False
        Me.txt_allergenes_keyword.Location = New System.Drawing.Point(758, 35)
        Me.txt_allergenes_keyword.MaxLength = 200
        Me.txt_allergenes_keyword.Multiline = True
        Me.txt_allergenes_keyword.Name = "txt_allergenes_keyword"
        Me.txt_allergenes_keyword.Size = New System.Drawing.Size(211, 32)
        Me.txt_allergenes_keyword.TabIndex = 9
        '
        'cbo_allergenes
        '
        Me.cbo_allergenes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_allergenes.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_allergenes.FormattingEnabled = True
        Me.cbo_allergenes.Items.AddRange(New Object() {"Ne contient pas d'allergènes", "Contient des allergènes", "Ne contient pas... (mot(s) clé(s))", "Contient... (mot(s) clé(s))", "Ne s'applique pas"})
        Me.cbo_allergenes.Location = New System.Drawing.Point(758, 8)
        Me.cbo_allergenes.Name = "cbo_allergenes"
        Me.cbo_allergenes.Size = New System.Drawing.Size(211, 23)
        Me.cbo_allergenes.TabIndex = 8
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(683, 11)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 17)
        Me.Label20.TabIndex = 96
        Me.Label20.Text = "Allergènes"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(61, 127)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 17)
        Me.Label19.TabIndex = 95
        Me.Label19.Text = "Périssable"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rdb_perissable_tous)
        Me.Panel2.Controls.Add(Me.rdb_perissable_oui)
        Me.Panel2.Controls.Add(Me.rdb_perissable_non)
        Me.Panel2.Location = New System.Drawing.Point(134, 121)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(205, 27)
        Me.Panel2.TabIndex = 94
        '
        'rdb_perissable_tous
        '
        Me.rdb_perissable_tous.AutoSize = True
        Me.rdb_perissable_tous.Checked = True
        Me.rdb_perissable_tous.Location = New System.Drawing.Point(113, 7)
        Me.rdb_perissable_tous.Name = "rdb_perissable_tous"
        Me.rdb_perissable_tous.Size = New System.Drawing.Size(49, 17)
        Me.rdb_perissable_tous.TabIndex = 37
        Me.rdb_perissable_tous.TabStop = True
        Me.rdb_perissable_tous.Text = "Tous"
        Me.rdb_perissable_tous.UseVisualStyleBackColor = True
        '
        'rdb_perissable_oui
        '
        Me.rdb_perissable_oui.AutoSize = True
        Me.rdb_perissable_oui.Location = New System.Drawing.Point(6, 7)
        Me.rdb_perissable_oui.Name = "rdb_perissable_oui"
        Me.rdb_perissable_oui.Size = New System.Drawing.Size(41, 17)
        Me.rdb_perissable_oui.TabIndex = 35
        Me.rdb_perissable_oui.Text = "Oui"
        Me.rdb_perissable_oui.UseVisualStyleBackColor = True
        '
        'rdb_perissable_non
        '
        Me.rdb_perissable_non.AutoSize = True
        Me.rdb_perissable_non.Location = New System.Drawing.Point(59, 7)
        Me.rdb_perissable_non.Name = "rdb_perissable_non"
        Me.rdb_perissable_non.Size = New System.Drawing.Size(45, 17)
        Me.rdb_perissable_non.TabIndex = 34
        Me.rdb_perissable_non.Text = "Non"
        Me.rdb_perissable_non.UseVisualStyleBackColor = True
        '
        'cbo_rech_categorie
        '
        Me.cbo_rech_categorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_rech_categorie.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_rech_categorie.FormattingEnabled = True
        Me.cbo_rech_categorie.Items.AddRange(New Object() {"Tous"})
        Me.cbo_rech_categorie.Location = New System.Drawing.Point(134, 97)
        Me.cbo_rech_categorie.Name = "cbo_rech_categorie"
        Me.cbo_rech_categorie.Size = New System.Drawing.Size(211, 23)
        Me.cbo_rech_categorie.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(63, 97)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 17)
        Me.Label15.TabIndex = 92
        Me.Label15.Text = "Catégorie"
        '
        'txt_rech_marque
        '
        Me.txt_rech_marque.Location = New System.Drawing.Point(357, 71)
        Me.txt_rech_marque.MaxLength = 50
        Me.txt_rech_marque.Multiline = True
        Me.txt_rech_marque.Name = "txt_rech_marque"
        Me.txt_rech_marque.Size = New System.Drawing.Size(212, 23)
        Me.txt_rech_marque.TabIndex = 6
        '
        'cbo_marque_contient
        '
        Me.cbo_marque_contient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_marque_contient.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_marque_contient.FormattingEnabled = True
        Me.cbo_marque_contient.Items.AddRange(New Object() {"Contient", "Commence par", "Ne s'applique pas"})
        Me.cbo_marque_contient.Location = New System.Drawing.Point(134, 70)
        Me.cbo_marque_contient.Name = "cbo_marque_contient"
        Me.cbo_marque_contient.Size = New System.Drawing.Size(211, 23)
        Me.cbo_marque_contient.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(74, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Marque"
        '
        'cbo_nom_contient
        '
        Me.cbo_nom_contient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_nom_contient.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_nom_contient.FormattingEnabled = True
        Me.cbo_nom_contient.Items.AddRange(New Object() {"Contient", "Commence par", "Ne s'applique pas"})
        Me.cbo_nom_contient.Location = New System.Drawing.Point(134, 43)
        Me.cbo_nom_contient.Name = "cbo_nom_contient"
        Me.cbo_nom_contient.Size = New System.Drawing.Size(211, 23)
        Me.cbo_nom_contient.TabIndex = 3
        '
        'txt_rech_nom
        '
        Me.txt_rech_nom.Location = New System.Drawing.Point(357, 44)
        Me.txt_rech_nom.MaxLength = 50
        Me.txt_rech_nom.Multiline = True
        Me.txt_rech_nom.Name = "txt_rech_nom"
        Me.txt_rech_nom.Size = New System.Drawing.Size(212, 23)
        Me.txt_rech_nom.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(25, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 17)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Nom du produit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(691, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Mots clés"
        '
        'Label7
        '
        Me.Label7.Enabled = False
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(753, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(210, 29)
        Me.Label7.TabIndex = 107
        Me.Label7.Text = "S'il y a plusieurs mots clés, veuillez les séparer avec des points-virgules ( ; )" &
    ""
        '
        'txt_description_keyword
        '
        Me.txt_description_keyword.Enabled = False
        Me.txt_description_keyword.Location = New System.Drawing.Point(756, 113)
        Me.txt_description_keyword.MaxLength = 200
        Me.txt_description_keyword.Multiline = True
        Me.txt_description_keyword.Name = "txt_description_keyword"
        Me.txt_description_keyword.Size = New System.Drawing.Size(211, 32)
        Me.txt_description_keyword.TabIndex = 11
        '
        'cbo_description
        '
        Me.cbo_description.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_description.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_description.FormattingEnabled = True
        Me.cbo_description.Items.AddRange(New Object() {"Ne contient pas de description", "Contient une description (tous)", "Recherche par mot clé", "Ne s'applique pas"})
        Me.cbo_description.Location = New System.Drawing.Point(756, 86)
        Me.cbo_description.Name = "cbo_description"
        Me.cbo_description.Size = New System.Drawing.Size(211, 23)
        Me.cbo_description.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(676, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 17)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = "Description"
        '
        'btnRechercher
        '
        Me.btnRechercher.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnRechercher.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRechercher.FlatAppearance.BorderSize = 0
        Me.btnRechercher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRechercher.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRechercher.ForeColor = System.Drawing.SystemColors.Control
        Me.btnRechercher.Location = New System.Drawing.Point(849, 214)
        Me.btnRechercher.Name = "btnRechercher"
        Me.btnRechercher.Size = New System.Drawing.Size(154, 32)
        Me.btnRechercher.TabIndex = 12
        Me.btnRechercher.Text = "Rechercher"
        Me.btnRechercher.UseVisualStyleBackColor = False
        '
        'btnReinitialiser
        '
        Me.btnReinitialiser.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnReinitialiser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReinitialiser.FlatAppearance.BorderSize = 0
        Me.btnReinitialiser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnReinitialiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReinitialiser.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReinitialiser.ForeColor = System.Drawing.SystemColors.Control
        Me.btnReinitialiser.Location = New System.Drawing.Point(1009, 214)
        Me.btnReinitialiser.Name = "btnReinitialiser"
        Me.btnReinitialiser.Size = New System.Drawing.Size(154, 32)
        Me.btnReinitialiser.TabIndex = 110
        Me.btnReinitialiser.Text = "Réinitialiser"
        Me.btnReinitialiser.UseVisualStyleBackColor = False
        '
        'pnl_recherches
        '
        Me.pnl_recherches.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_recherches.Controls.Add(Me.Label5)
        Me.pnl_recherches.Controls.Add(Me.Panel4)
        Me.pnl_recherches.Controls.Add(Me.txt_allergenes_keyword)
        Me.pnl_recherches.Controls.Add(Me.Label20)
        Me.pnl_recherches.Controls.Add(Me.cbo_allergenes)
        Me.pnl_recherches.Controls.Add(Me.lbl_mots_cles)
        Me.pnl_recherches.Controls.Add(Me.cbo_ordre)
        Me.pnl_recherches.Controls.Add(Me.Label1)
        Me.pnl_recherches.Controls.Add(Me.cbo_trier_par)
        Me.pnl_recherches.Controls.Add(Me.Label8)
        Me.pnl_recherches.Controls.Add(Me.Label6)
        Me.pnl_recherches.Controls.Add(Me.Label7)
        Me.pnl_recherches.Controls.Add(Me.Label19)
        Me.pnl_recherches.Controls.Add(Me.cbo_description)
        Me.pnl_recherches.Controls.Add(Me.Panel2)
        Me.pnl_recherches.Controls.Add(Me.txt_description_keyword)
        Me.pnl_recherches.Controls.Add(Me.cbo_rech_categorie)
        Me.pnl_recherches.Controls.Add(Me.cbo_nom_contient)
        Me.pnl_recherches.Controls.Add(Me.Label15)
        Me.pnl_recherches.Controls.Add(Me.Label4)
        Me.pnl_recherches.Controls.Add(Me.txt_rech_marque)
        Me.pnl_recherches.Controls.Add(Me.txt_rech_nom)
        Me.pnl_recherches.Controls.Add(Me.cbo_marque_contient)
        Me.pnl_recherches.Controls.Add(Me.Label3)
        Me.pnl_recherches.Location = New System.Drawing.Point(3, 4)
        Me.pnl_recherches.Name = "pnl_recherches"
        Me.pnl_recherches.Size = New System.Drawing.Size(1164, 204)
        Me.pnl_recherches.TabIndex = 113
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(102, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 17)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Bio"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.rdb_bio_tous)
        Me.Panel4.Controls.Add(Me.rdb_bio_oui)
        Me.Panel4.Controls.Add(Me.rdb_bio_non)
        Me.Panel4.Location = New System.Drawing.Point(134, 148)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(205, 27)
        Me.Panel4.TabIndex = 109
        '
        'rdb_bio_tous
        '
        Me.rdb_bio_tous.AutoSize = True
        Me.rdb_bio_tous.Checked = True
        Me.rdb_bio_tous.Location = New System.Drawing.Point(113, 7)
        Me.rdb_bio_tous.Name = "rdb_bio_tous"
        Me.rdb_bio_tous.Size = New System.Drawing.Size(49, 17)
        Me.rdb_bio_tous.TabIndex = 37
        Me.rdb_bio_tous.TabStop = True
        Me.rdb_bio_tous.Text = "Tous"
        Me.rdb_bio_tous.UseVisualStyleBackColor = True
        '
        'rdb_bio_oui
        '
        Me.rdb_bio_oui.AutoSize = True
        Me.rdb_bio_oui.Location = New System.Drawing.Point(6, 7)
        Me.rdb_bio_oui.Name = "rdb_bio_oui"
        Me.rdb_bio_oui.Size = New System.Drawing.Size(41, 17)
        Me.rdb_bio_oui.TabIndex = 35
        Me.rdb_bio_oui.Text = "Oui"
        Me.rdb_bio_oui.UseVisualStyleBackColor = True
        '
        'rdb_bio_non
        '
        Me.rdb_bio_non.AutoSize = True
        Me.rdb_bio_non.Location = New System.Drawing.Point(59, 7)
        Me.rdb_bio_non.Name = "rdb_bio_non"
        Me.rdb_bio_non.Size = New System.Drawing.Size(45, 17)
        Me.rdb_bio_non.TabIndex = 34
        Me.rdb_bio_non.Text = "Non"
        Me.rdb_bio_non.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 256)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1181, 28)
        Me.Panel1.TabIndex = 114
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(11, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Liste des produits"
        '
        'rdb_actifs_tous
        '
        Me.rdb_actifs_tous.AutoSize = True
        Me.rdb_actifs_tous.Location = New System.Drawing.Point(340, 305)
        Me.rdb_actifs_tous.Name = "rdb_actifs_tous"
        Me.rdb_actifs_tous.Size = New System.Drawing.Size(122, 17)
        Me.rdb_actifs_tous.TabIndex = 121
        Me.rdb_actifs_tous.TabStop = True
        Me.rdb_actifs_tous.Text = "Voir tous les produits"
        Me.rdb_actifs_tous.UseVisualStyleBackColor = True
        '
        'rdb_actifs_non
        '
        Me.rdb_actifs_non.AutoSize = True
        Me.rdb_actifs_non.Location = New System.Drawing.Point(172, 305)
        Me.rdb_actifs_non.Name = "rdb_actifs_non"
        Me.rdb_actifs_non.Size = New System.Drawing.Size(135, 17)
        Me.rdb_actifs_non.TabIndex = 120
        Me.rdb_actifs_non.TabStop = True
        Me.rdb_actifs_non.Text = "Voir les produits inactifs"
        Me.rdb_actifs_non.UseVisualStyleBackColor = True
        '
        'rdb_actifs_oui
        '
        Me.rdb_actifs_oui.AutoSize = True
        Me.rdb_actifs_oui.Location = New System.Drawing.Point(14, 305)
        Me.rdb_actifs_oui.Name = "rdb_actifs_oui"
        Me.rdb_actifs_oui.Size = New System.Drawing.Size(127, 17)
        Me.rdb_actifs_oui.TabIndex = 119
        Me.rdb_actifs_oui.TabStop = True
        Me.rdb_actifs_oui.Text = "Voir les produits actifs"
        Me.rdb_actifs_oui.UseVisualStyleBackColor = True
        '
        'lbl_ajoutSucces
        '
        Me.lbl_ajoutSucces.BackColor = System.Drawing.Color.Lime
        Me.lbl_ajoutSucces.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_ajoutSucces.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_ajoutSucces.Location = New System.Drawing.Point(3, 720)
        Me.lbl_ajoutSucces.Name = "lbl_ajoutSucces"
        Me.lbl_ajoutSucces.Size = New System.Drawing.Size(1175, 24)
        Me.lbl_ajoutSucces.TabIndex = 118
        Me.lbl_ajoutSucces.Text = "Suppression réussie."
        Me.lbl_ajoutSucces.Visible = False
        '
        'btn_modifier
        '
        Me.btn_modifier.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_modifier.Enabled = False
        Me.btn_modifier.FlatAppearance.BorderSize = 0
        Me.btn_modifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_modifier.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modifier.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_modifier.Location = New System.Drawing.Point(197, 679)
        Me.btn_modifier.Name = "btn_modifier"
        Me.btn_modifier.Size = New System.Drawing.Size(184, 32)
        Me.btn_modifier.TabIndex = 117
        Me.btn_modifier.Text = "Modifier un produit"
        Me.btn_modifier.UseVisualStyleBackColor = False
        '
        'btn_desactiver
        '
        Me.btn_desactiver.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btn_desactiver.Enabled = False
        Me.btn_desactiver.FlatAppearance.BorderSize = 0
        Me.btn_desactiver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_desactiver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_desactiver.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_desactiver.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_desactiver.Location = New System.Drawing.Point(1069, 679)
        Me.btn_desactiver.Name = "btn_desactiver"
        Me.btn_desactiver.Size = New System.Drawing.Size(95, 32)
        Me.btn_desactiver.TabIndex = 116
        Me.btn_desactiver.Text = "Désactiver"
        Me.btn_desactiver.UseVisualStyleBackColor = False
        '
        'dgv_produits
        '
        Me.dgv_produits.AllowUserToAddRows = False
        Me.dgv_produits.AllowUserToDeleteRows = False
        Me.dgv_produits.AllowUserToResizeColumns = False
        Me.dgv_produits.AllowUserToResizeRows = False
        Me.dgv_produits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_produits.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_produits.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_produits.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_produits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_produits.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column11, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.dgv_produits.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgv_produits.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgv_produits.Location = New System.Drawing.Point(3, 338)
        Me.dgv_produits.Name = "dgv_produits"
        Me.dgv_produits.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_produits.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_produits.RowHeadersVisible = False
        Me.dgv_produits.RowHeadersWidth = 35
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_produits.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_produits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_produits.Size = New System.Drawing.Size(1164, 329)
        Me.dgv_produits.TabIndex = 115
        '
        'Column1
        '
        Me.Column1.HeaderText = "No. Produit"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nom"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Marque"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Catégorie"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Format"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.HeaderText = "Quantité"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Périssable"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Bio"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Description"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Allergènes"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "Actif"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'timer_succes
        '
        Me.timer_succes.Interval = 1
        '
        'btn_reactiver
        '
        Me.btn_reactiver.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_reactiver.Enabled = False
        Me.btn_reactiver.FlatAppearance.BorderSize = 0
        Me.btn_reactiver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_reactiver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_reactiver.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reactiver.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_reactiver.Location = New System.Drawing.Point(963, 679)
        Me.btn_reactiver.Name = "btn_reactiver"
        Me.btn_reactiver.Size = New System.Drawing.Size(95, 32)
        Me.btn_reactiver.TabIndex = 124
        Me.btn_reactiver.Text = "Activer"
        Me.btn_reactiver.UseVisualStyleBackColor = False
        '
        'pnl_ajout_mod
        '
        Me.pnl_ajout_mod.Controls.Add(Me.chk_tvq)
        Me.pnl_ajout_mod.Controls.Add(Me.chk_tps)
        Me.pnl_ajout_mod.Controls.Add(Me.Panel3)
        Me.pnl_ajout_mod.Controls.Add(Me.nm_quantite)
        Me.pnl_ajout_mod.Controls.Add(Me.btn_annuler)
        Me.pnl_ajout_mod.Controls.Add(Me.Panel6)
        Me.pnl_ajout_mod.Controls.Add(Me.txt_remarque)
        Me.pnl_ajout_mod.Controls.Add(Me.btn_generer)
        Me.pnl_ajout_mod.Controls.Add(Me.txt_no_produit)
        Me.pnl_ajout_mod.Controls.Add(Me.lbl_erreur_bio)
        Me.pnl_ajout_mod.Controls.Add(Me.Label32)
        Me.pnl_ajout_mod.Controls.Add(Me.cbo_bio)
        Me.pnl_ajout_mod.Controls.Add(Me.txt_nom_produit)
        Me.pnl_ajout_mod.Controls.Add(Me.Label10)
        Me.pnl_ajout_mod.Controls.Add(Me.Label31)
        Me.pnl_ajout_mod.Controls.Add(Me.Label18)
        Me.pnl_ajout_mod.Controls.Add(Me.txt_marque)
        Me.pnl_ajout_mod.Controls.Add(Me.Label17)
        Me.pnl_ajout_mod.Controls.Add(Me.Label30)
        Me.pnl_ajout_mod.Controls.Add(Me.lbl_mesure)
        Me.pnl_ajout_mod.Controls.Add(Me.Label29)
        Me.pnl_ajout_mod.Controls.Add(Me.lbl_erreur_perissable)
        Me.pnl_ajout_mod.Controls.Add(Me.cbo_categories)
        Me.pnl_ajout_mod.Controls.Add(Me.cbo_perissable)
        Me.pnl_ajout_mod.Controls.Add(Me.Label28)
        Me.pnl_ajout_mod.Controls.Add(Me.Label23)
        Me.pnl_ajout_mod.Controls.Add(Me.cbo_format)
        Me.pnl_ajout_mod.Controls.Add(Me.lbl_erreur_quantite)
        Me.pnl_ajout_mod.Controls.Add(Me.Label27)
        Me.pnl_ajout_mod.Controls.Add(Me.lbl_erreur_mesure)
        Me.pnl_ajout_mod.Controls.Add(Me.Label26)
        Me.pnl_ajout_mod.Controls.Add(Me.lbl_erreur_format)
        Me.pnl_ajout_mod.Controls.Add(Me.lbl_erreur_marque)
        Me.pnl_ajout_mod.Controls.Add(Me.Label25)
        Me.pnl_ajout_mod.Controls.Add(Me.lbl_erreur_nom_produit)
        Me.pnl_ajout_mod.Controls.Add(Me.Label24)
        Me.pnl_ajout_mod.Controls.Add(Me.lbl_erreur_code_plu)
        Me.pnl_ajout_mod.Controls.Add(Me.Label22)
        Me.pnl_ajout_mod.Controls.Add(Me.lbl_erreur_code_barre)
        Me.pnl_ajout_mod.Controls.Add(Me.txt_description)
        Me.pnl_ajout_mod.Controls.Add(Me.lbl_erreur_numero)
        Me.pnl_ajout_mod.Controls.Add(Me.txt_allergenes)
        Me.pnl_ajout_mod.Controls.Add(Me.btn_valider)
        Me.pnl_ajout_mod.Controls.Add(Me.Panel7)
        Me.pnl_ajout_mod.Controls.Add(Me.btn_mesure)
        Me.pnl_ajout_mod.Controls.Add(Me.Panel8)
        Me.pnl_ajout_mod.Controls.Add(Me.Panel10)
        Me.pnl_ajout_mod.Controls.Add(Me.lbl_erreur_categorie)
        Me.pnl_ajout_mod.Controls.Add(Me.txt_code_barre)
        Me.pnl_ajout_mod.Controls.Add(Me.Panel9)
        Me.pnl_ajout_mod.Controls.Add(Me.Label12)
        Me.pnl_ajout_mod.Controls.Add(Me.Label13)
        Me.pnl_ajout_mod.Controls.Add(Me.txt_code_plu)
        Me.pnl_ajout_mod.Location = New System.Drawing.Point(0, 747)
        Me.pnl_ajout_mod.Name = "pnl_ajout_mod"
        Me.pnl_ajout_mod.Size = New System.Drawing.Size(1170, 549)
        Me.pnl_ajout_mod.TabIndex = 126
        '
        'chk_tvq
        '
        Me.chk_tvq.AutoSize = True
        Me.chk_tvq.Enabled = False
        Me.chk_tvq.Location = New System.Drawing.Point(807, 287)
        Me.chk_tvq.Name = "chk_tvq"
        Me.chk_tvq.Size = New System.Drawing.Size(48, 17)
        Me.chk_tvq.TabIndex = 197
        Me.chk_tvq.Text = "TVQ"
        Me.chk_tvq.UseVisualStyleBackColor = True
        '
        'chk_tps
        '
        Me.chk_tps.AutoSize = True
        Me.chk_tps.Enabled = False
        Me.chk_tps.Location = New System.Drawing.Point(807, 264)
        Me.chk_tps.Name = "chk_tps"
        Me.chk_tps.Size = New System.Drawing.Size(47, 17)
        Me.chk_tps.TabIndex = 196
        Me.chk_tps.Text = "TPS"
        Me.chk_tps.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label34)
        Me.Panel3.Location = New System.Drawing.Point(792, 228)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(359, 28)
        Me.Panel3.TabIndex = 195
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.Location = New System.Drawing.Point(11, 3)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(46, 21)
        Me.Label34.TabIndex = 9
        Me.Label34.Text = "Taxes"
        '
        'nm_quantite
        '
        Me.nm_quantite.DecimalPlaces = 2
        Me.nm_quantite.Enabled = False
        Me.nm_quantite.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nm_quantite.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.nm_quantite.Location = New System.Drawing.Point(880, 175)
        Me.nm_quantite.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nm_quantite.Name = "nm_quantite"
        Me.nm_quantite.Size = New System.Drawing.Size(99, 23)
        Me.nm_quantite.TabIndex = 155
        '
        'btn_annuler
        '
        Me.btn_annuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_annuler.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_annuler.Enabled = False
        Me.btn_annuler.FlatAppearance.BorderSize = 0
        Me.btn_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_annuler.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annuler.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_annuler.Location = New System.Drawing.Point(825, 493)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(154, 32)
        Me.btn_annuler.TabIndex = 194
        Me.btn_annuler.Text = "Annuler"
        Me.btn_annuler.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel6.Controls.Add(Me.lbl_mode)
        Me.Panel6.Location = New System.Drawing.Point(1, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1170, 28)
        Me.Panel6.TabIndex = 193
        '
        'lbl_mode
        '
        Me.lbl_mode.AutoSize = True
        Me.lbl_mode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mode.ForeColor = System.Drawing.Color.White
        Me.lbl_mode.Location = New System.Drawing.Point(11, 3)
        Me.lbl_mode.Name = "lbl_mode"
        Me.lbl_mode.Size = New System.Drawing.Size(393, 21)
        Me.lbl_mode.TabIndex = 9
        Me.lbl_mode.Text = "Pour ajouter un produit, cliquez sur 'Ajouter un produit'"
        '
        'txt_remarque
        '
        Me.txt_remarque.Enabled = False
        Me.txt_remarque.Location = New System.Drawing.Point(464, 378)
        Me.txt_remarque.MaxLength = 200
        Me.txt_remarque.Name = "txt_remarque"
        Me.txt_remarque.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txt_remarque.Size = New System.Drawing.Size(254, 60)
        Me.txt_remarque.TabIndex = 157
        Me.txt_remarque.Text = ""
        '
        'btn_generer
        '
        Me.btn_generer.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_generer.Enabled = False
        Me.btn_generer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_generer.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_generer.Location = New System.Drawing.Point(215, 88)
        Me.btn_generer.Name = "btn_generer"
        Me.btn_generer.Size = New System.Drawing.Size(88, 25)
        Me.btn_generer.TabIndex = 192
        Me.btn_generer.Text = "Générer"
        Me.btn_generer.UseVisualStyleBackColor = False
        '
        'txt_no_produit
        '
        Me.txt_no_produit.Enabled = False
        Me.txt_no_produit.Location = New System.Drawing.Point(113, 91)
        Me.txt_no_produit.MaxLength = 10
        Me.txt_no_produit.Multiline = True
        Me.txt_no_produit.Name = "txt_no_produit"
        Me.txt_no_produit.Size = New System.Drawing.Size(96, 21)
        Me.txt_no_produit.TabIndex = 144
        '
        'lbl_erreur_bio
        '
        Me.lbl_erreur_bio.AutoSize = True
        Me.lbl_erreur_bio.ForeColor = System.Drawing.Color.Red
        Me.lbl_erreur_bio.Location = New System.Drawing.Point(468, 285)
        Me.lbl_erreur_bio.Name = "lbl_erreur_bio"
        Me.lbl_erreur_bio.Size = New System.Drawing.Size(88, 13)
        Me.lbl_erreur_bio.TabIndex = 191
        Me.lbl_erreur_bio.Text = "Message d'erreur"
        Me.lbl_erreur_bio.Visible = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(41, 94)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(66, 13)
        Me.Label32.TabIndex = 145
        Me.Label32.Text = "No. Produit"
        '
        'cbo_bio
        '
        Me.cbo_bio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_bio.Enabled = False
        Me.cbo_bio.FormattingEnabled = True
        Me.cbo_bio.Items.AddRange(New Object() {"Oui", "Non"})
        Me.cbo_bio.Location = New System.Drawing.Point(471, 261)
        Me.cbo_bio.Name = "cbo_bio"
        Me.cbo_bio.Size = New System.Drawing.Size(170, 21)
        Me.cbo_bio.TabIndex = 151
        '
        'txt_nom_produit
        '
        Me.txt_nom_produit.Enabled = False
        Me.txt_nom_produit.Location = New System.Drawing.Point(472, 89)
        Me.txt_nom_produit.MaxLength = 50
        Me.txt_nom_produit.Multiline = True
        Me.txt_nom_produit.Name = "txt_nom_produit"
        Me.txt_nom_produit.Size = New System.Drawing.Size(222, 21)
        Me.txt_nom_produit.TabIndex = 147
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(441, 264)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 13)
        Me.Label10.TabIndex = 189
        Me.Label10.Text = "Bio"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(376, 94)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(90, 13)
        Me.Label31.TabIndex = 147
        Me.Label31.Text = "Nom du produit"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(48, 150)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 13)
        Me.Label18.TabIndex = 188
        Me.Label18.Text = "(facultatif)"
        '
        'txt_marque
        '
        Me.txt_marque.Enabled = False
        Me.txt_marque.Location = New System.Drawing.Point(472, 134)
        Me.txt_marque.MaxLength = 50
        Me.txt_marque.Multiline = True
        Me.txt_marque.Name = "txt_marque"
        Me.txt_marque.Size = New System.Drawing.Size(222, 21)
        Me.txt_marque.TabIndex = 148
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(49, 189)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 13)
        Me.Label17.TabIndex = 187
        Me.Label17.Text = "(facultatif)"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(419, 137)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(47, 13)
        Me.Label30.TabIndex = 149
        Me.Label30.Text = "Marque"
        '
        'lbl_mesure
        '
        Me.lbl_mesure.AutoSize = True
        Me.lbl_mesure.Location = New System.Drawing.Point(881, 137)
        Me.lbl_mesure.Name = "lbl_mesure"
        Me.lbl_mesure.Size = New System.Drawing.Size(178, 13)
        Me.lbl_mesure.TabIndex = 186
        Me.lbl_mesure.Text = "--- choisissez une unité de mesure ---"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(409, 178)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(57, 13)
        Me.Label29.TabIndex = 150
        Me.Label29.Text = "Catégorie"
        '
        'lbl_erreur_perissable
        '
        Me.lbl_erreur_perissable.AutoSize = True
        Me.lbl_erreur_perissable.ForeColor = System.Drawing.Color.Red
        Me.lbl_erreur_perissable.Location = New System.Drawing.Point(469, 243)
        Me.lbl_erreur_perissable.Name = "lbl_erreur_perissable"
        Me.lbl_erreur_perissable.Size = New System.Drawing.Size(88, 13)
        Me.lbl_erreur_perissable.TabIndex = 185
        Me.lbl_erreur_perissable.Text = "Message d'erreur"
        Me.lbl_erreur_perissable.Visible = False
        '
        'cbo_categories
        '
        Me.cbo_categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_categories.Enabled = False
        Me.cbo_categories.FormattingEnabled = True
        Me.cbo_categories.Location = New System.Drawing.Point(472, 175)
        Me.cbo_categories.Name = "cbo_categories"
        Me.cbo_categories.Size = New System.Drawing.Size(222, 21)
        Me.cbo_categories.TabIndex = 149
        '
        'cbo_perissable
        '
        Me.cbo_perissable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_perissable.Enabled = False
        Me.cbo_perissable.FormattingEnabled = True
        Me.cbo_perissable.Items.AddRange(New Object() {"Oui", "Non"})
        Me.cbo_perissable.Location = New System.Drawing.Point(472, 219)
        Me.cbo_perissable.Name = "cbo_perissable"
        Me.cbo_perissable.Size = New System.Drawing.Size(170, 21)
        Me.cbo_perissable.TabIndex = 150
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(832, 94)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(43, 13)
        Me.Label28.TabIndex = 152
        Me.Label28.Text = "Format"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(409, 222)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(58, 13)
        Me.Label23.TabIndex = 183
        Me.Label23.Text = "Périssable"
        '
        'cbo_format
        '
        Me.cbo_format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_format.Enabled = False
        Me.cbo_format.FormattingEnabled = True
        Me.cbo_format.Location = New System.Drawing.Point(881, 91)
        Me.cbo_format.Name = "cbo_format"
        Me.cbo_format.Size = New System.Drawing.Size(141, 21)
        Me.cbo_format.TabIndex = 153
        '
        'lbl_erreur_quantite
        '
        Me.lbl_erreur_quantite.AutoSize = True
        Me.lbl_erreur_quantite.ForeColor = System.Drawing.Color.Red
        Me.lbl_erreur_quantite.Location = New System.Drawing.Point(878, 199)
        Me.lbl_erreur_quantite.Name = "lbl_erreur_quantite"
        Me.lbl_erreur_quantite.Size = New System.Drawing.Size(88, 13)
        Me.lbl_erreur_quantite.TabIndex = 182
        Me.lbl_erreur_quantite.Text = "Message d'erreur"
        Me.lbl_erreur_quantite.Visible = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(784, 137)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(91, 13)
        Me.Label27.TabIndex = 154
        Me.Label27.Text = "Unité de mesure"
        '
        'lbl_erreur_mesure
        '
        Me.lbl_erreur_mesure.AutoSize = True
        Me.lbl_erreur_mesure.ForeColor = System.Drawing.Color.Red
        Me.lbl_erreur_mesure.Location = New System.Drawing.Point(878, 154)
        Me.lbl_erreur_mesure.Name = "lbl_erreur_mesure"
        Me.lbl_erreur_mesure.Size = New System.Drawing.Size(88, 13)
        Me.lbl_erreur_mesure.TabIndex = 181
        Me.lbl_erreur_mesure.Text = "Message d'erreur"
        Me.lbl_erreur_mesure.Visible = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(822, 178)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(52, 13)
        Me.Label26.TabIndex = 155
        Me.Label26.Text = "Quantité"
        '
        'lbl_erreur_format
        '
        Me.lbl_erreur_format.AutoSize = True
        Me.lbl_erreur_format.ForeColor = System.Drawing.Color.Red
        Me.lbl_erreur_format.Location = New System.Drawing.Point(878, 114)
        Me.lbl_erreur_format.Name = "lbl_erreur_format"
        Me.lbl_erreur_format.Size = New System.Drawing.Size(88, 13)
        Me.lbl_erreur_format.TabIndex = 180
        Me.lbl_erreur_format.Text = "Message d'erreur"
        Me.lbl_erreur_format.Visible = False
        '
        'lbl_erreur_marque
        '
        Me.lbl_erreur_marque.AutoSize = True
        Me.lbl_erreur_marque.ForeColor = System.Drawing.Color.Red
        Me.lbl_erreur_marque.Location = New System.Drawing.Point(469, 158)
        Me.lbl_erreur_marque.Name = "lbl_erreur_marque"
        Me.lbl_erreur_marque.Size = New System.Drawing.Size(88, 13)
        Me.lbl_erreur_marque.TabIndex = 178
        Me.lbl_erreur_marque.Text = "Message d'erreur"
        Me.lbl_erreur_marque.Visible = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(41, 362)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(66, 13)
        Me.Label25.TabIndex = 157
        Me.Label25.Text = "Description"
        '
        'lbl_erreur_nom_produit
        '
        Me.lbl_erreur_nom_produit.AutoSize = True
        Me.lbl_erreur_nom_produit.ForeColor = System.Drawing.Color.Red
        Me.lbl_erreur_nom_produit.Location = New System.Drawing.Point(469, 113)
        Me.lbl_erreur_nom_produit.Name = "lbl_erreur_nom_produit"
        Me.lbl_erreur_nom_produit.Size = New System.Drawing.Size(88, 13)
        Me.lbl_erreur_nom_produit.TabIndex = 177
        Me.lbl_erreur_nom_produit.Text = "Message d'erreur"
        Me.lbl_erreur_nom_produit.Visible = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(461, 362)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(59, 13)
        Me.Label24.TabIndex = 158
        Me.Label24.Text = "Remarque"
        '
        'lbl_erreur_code_plu
        '
        Me.lbl_erreur_code_plu.AutoSize = True
        Me.lbl_erreur_code_plu.ForeColor = System.Drawing.Color.Red
        Me.lbl_erreur_code_plu.Location = New System.Drawing.Point(113, 199)
        Me.lbl_erreur_code_plu.Name = "lbl_erreur_code_plu"
        Me.lbl_erreur_code_plu.Size = New System.Drawing.Size(88, 13)
        Me.lbl_erreur_code_plu.TabIndex = 176
        Me.lbl_erreur_code_plu.Text = "Message d'erreur"
        Me.lbl_erreur_code_plu.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(876, 362)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(61, 13)
        Me.Label22.TabIndex = 159
        Me.Label22.Text = "Allergènes"
        '
        'lbl_erreur_code_barre
        '
        Me.lbl_erreur_code_barre.AutoSize = True
        Me.lbl_erreur_code_barre.ForeColor = System.Drawing.Color.Red
        Me.lbl_erreur_code_barre.Location = New System.Drawing.Point(113, 159)
        Me.lbl_erreur_code_barre.Name = "lbl_erreur_code_barre"
        Me.lbl_erreur_code_barre.Size = New System.Drawing.Size(88, 13)
        Me.lbl_erreur_code_barre.TabIndex = 175
        Me.lbl_erreur_code_barre.Text = "Message d'erreur"
        Me.lbl_erreur_code_barre.Visible = False
        '
        'txt_description
        '
        Me.txt_description.Enabled = False
        Me.txt_description.Location = New System.Drawing.Point(44, 378)
        Me.txt_description.MaxLength = 200
        Me.txt_description.Name = "txt_description"
        Me.txt_description.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txt_description.Size = New System.Drawing.Size(254, 60)
        Me.txt_description.TabIndex = 156
        Me.txt_description.Text = ""
        '
        'lbl_erreur_numero
        '
        Me.lbl_erreur_numero.AutoSize = True
        Me.lbl_erreur_numero.ForeColor = System.Drawing.Color.Red
        Me.lbl_erreur_numero.Location = New System.Drawing.Point(113, 114)
        Me.lbl_erreur_numero.Name = "lbl_erreur_numero"
        Me.lbl_erreur_numero.Size = New System.Drawing.Size(88, 13)
        Me.lbl_erreur_numero.TabIndex = 174
        Me.lbl_erreur_numero.Text = "Message d'erreur"
        Me.lbl_erreur_numero.Visible = False
        '
        'txt_allergenes
        '
        Me.txt_allergenes.Enabled = False
        Me.txt_allergenes.Location = New System.Drawing.Point(879, 378)
        Me.txt_allergenes.MaxLength = 200
        Me.txt_allergenes.Name = "txt_allergenes"
        Me.txt_allergenes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txt_allergenes.Size = New System.Drawing.Size(254, 60)
        Me.txt_allergenes.TabIndex = 158
        Me.txt_allergenes.Text = ""
        '
        'btn_valider
        '
        Me.btn_valider.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_valider.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_valider.Enabled = False
        Me.btn_valider.FlatAppearance.BorderSize = 0
        Me.btn_valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_valider.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_valider.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_valider.Location = New System.Drawing.Point(997, 493)
        Me.btn_valider.Name = "btn_valider"
        Me.btn_valider.Size = New System.Drawing.Size(154, 32)
        Me.btn_valider.TabIndex = 159
        Me.btn_valider.Text = "Ajouter"
        Me.btn_valider.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Label16)
        Me.Panel7.Location = New System.Drawing.Point(38, 319)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1113, 28)
        Me.Panel7.TabIndex = 172
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(11, 3)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(297, 21)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Informations complémentaires (facultatif)"
        '
        'btn_mesure
        '
        Me.btn_mesure.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_mesure.Enabled = False
        Me.btn_mesure.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mesure.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_mesure.Location = New System.Drawing.Point(1061, 130)
        Me.btn_mesure.Name = "btn_mesure"
        Me.btn_mesure.Size = New System.Drawing.Size(88, 25)
        Me.btn_mesure.TabIndex = 154
        Me.btn_mesure.Text = "Liste d'unités"
        Me.btn_mesure.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel8.Controls.Add(Me.Label9)
        Me.Panel8.Location = New System.Drawing.Point(792, 55)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(359, 28)
        Me.Panel8.TabIndex = 171
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(11, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 21)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Format"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel10.Controls.Add(Me.Label21)
        Me.Panel10.Location = New System.Drawing.Point(38, 55)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(265, 28)
        Me.Panel10.TabIndex = 165
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(11, 3)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(160, 21)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = "Codes d'identification"
        '
        'lbl_erreur_categorie
        '
        Me.lbl_erreur_categorie.AutoSize = True
        Me.lbl_erreur_categorie.ForeColor = System.Drawing.Color.Red
        Me.lbl_erreur_categorie.Location = New System.Drawing.Point(469, 199)
        Me.lbl_erreur_categorie.Name = "lbl_erreur_categorie"
        Me.lbl_erreur_categorie.Size = New System.Drawing.Size(88, 13)
        Me.lbl_erreur_categorie.TabIndex = 179
        Me.lbl_erreur_categorie.Text = "Message d'erreur"
        Me.lbl_erreur_categorie.Visible = False
        '
        'txt_code_barre
        '
        Me.txt_code_barre.Enabled = False
        Me.txt_code_barre.Location = New System.Drawing.Point(113, 134)
        Me.txt_code_barre.MaxLength = 15
        Me.txt_code_barre.Multiline = True
        Me.txt_code_barre.Name = "txt_code_barre"
        Me.txt_code_barre.Size = New System.Drawing.Size(96, 21)
        Me.txt_code_barre.TabIndex = 145
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Label14)
        Me.Panel9.Location = New System.Drawing.Point(379, 55)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(331, 28)
        Me.Panel9.TabIndex = 170
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(11, 3)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 21)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Identifiants"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(43, 137)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 167
        Me.Label12.Text = "Code barre"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(50, 178)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 169
        Me.Label13.Text = "Code PLU"
        '
        'txt_code_plu
        '
        Me.txt_code_plu.Enabled = False
        Me.txt_code_plu.Location = New System.Drawing.Point(113, 175)
        Me.txt_code_plu.MaxLength = 5
        Me.txt_code_plu.Multiline = True
        Me.txt_code_plu.Name = "txt_code_plu"
        Me.txt_code_plu.Size = New System.Drawing.Size(96, 21)
        Me.txt_code_plu.TabIndex = 146
        '
        'cms_unites_mesure
        '
        Me.cms_unites_mesure.Name = "cms_unites_mesure"
        Me.cms_unites_mesure.Size = New System.Drawing.Size(61, 4)
        '
        'btn_ajouter
        '
        Me.btn_ajouter.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_ajouter.Enabled = False
        Me.btn_ajouter.FlatAppearance.BorderSize = 0
        Me.btn_ajouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ajouter.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajouter.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_ajouter.Location = New System.Drawing.Point(3, 679)
        Me.btn_ajouter.Name = "btn_ajouter"
        Me.btn_ajouter.Size = New System.Drawing.Size(184, 32)
        Me.btn_ajouter.TabIndex = 122
        Me.btn_ajouter.Text = "Ajouter un produit"
        Me.btn_ajouter.UseVisualStyleBackColor = False
        '
        'btn_visualiser
        '
        Me.btn_visualiser.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_visualiser.Enabled = False
        Me.btn_visualiser.FlatAppearance.BorderSize = 0
        Me.btn_visualiser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_visualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_visualiser.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_visualiser.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_visualiser.Location = New System.Drawing.Point(394, 679)
        Me.btn_visualiser.Name = "btn_visualiser"
        Me.btn_visualiser.Size = New System.Drawing.Size(184, 32)
        Me.btn_visualiser.TabIndex = 127
        Me.btn_visualiser.Text = "Visualiser un produit"
        Me.btn_visualiser.UseVisualStyleBackColor = False
        '
        'btn_excel
        '
        Me.btn_excel.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btn_excel.FlatAppearance.BorderSize = 0
        Me.btn_excel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_excel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_excel.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_excel.Location = New System.Drawing.Point(595, 679)
        Me.btn_excel.Name = "btn_excel"
        Me.btn_excel.Size = New System.Drawing.Size(115, 32)
        Me.btn_excel.TabIndex = 123
        Me.btn_excel.Text = "Ouvrir avec Excel"
        Me.btn_excel.UseVisualStyleBackColor = False
        '
        'btn_associer
        '
        Me.btn_associer.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_associer.Enabled = False
        Me.btn_associer.FlatAppearance.BorderSize = 0
        Me.btn_associer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_associer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_associer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_associer.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_associer.Location = New System.Drawing.Point(726, 679)
        Me.btn_associer.Name = "btn_associer"
        Me.btn_associer.Size = New System.Drawing.Size(184, 32)
        Me.btn_associer.TabIndex = 128
        Me.btn_associer.Text = "Associer à un fournisseur"
        Me.btn_associer.UseVisualStyleBackColor = False
        '
        'pnl_rien
        '
        Me.pnl_rien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_rien.Controls.Add(Me.Label33)
        Me.pnl_rien.Controls.Add(Me.Label11)
        Me.pnl_rien.Location = New System.Drawing.Point(3, 338)
        Me.pnl_rien.Name = "pnl_rien"
        Me.pnl_rien.Size = New System.Drawing.Size(1164, 329)
        Me.pnl_rien.TabIndex = 129
        Me.pnl_rien.Visible = False
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(421, 151)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(319, 15)
        Me.Label33.TabIndex = 1
        Me.Label33.Text = "Dans le cas où il n'y a aucun produit, veuillez en ajouter un."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(260, 121)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(598, 15)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Désolé, il n'y a pas de produits disponibles pour le moment. Veuillez vérifier si" &
    " des produits sont actifs ou inactifs"
        '
        'btn_historique_taxes
        '
        Me.btn_historique_taxes.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_historique_taxes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_historique_taxes.FlatAppearance.BorderSize = 0
        Me.btn_historique_taxes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_historique_taxes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_historique_taxes.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_historique_taxes.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_historique_taxes.Location = New System.Drawing.Point(357, 214)
        Me.btn_historique_taxes.Name = "btn_historique_taxes"
        Me.btn_historique_taxes.Size = New System.Drawing.Size(154, 32)
        Me.btn_historique_taxes.TabIndex = 135
        Me.btn_historique_taxes.Text = "Historique des taxes"
        Me.btn_historique_taxes.UseVisualStyleBackColor = False
        '
        'btn_Taux_taxes
        '
        Me.btn_Taux_taxes.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_Taux_taxes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Taux_taxes.FlatAppearance.BorderSize = 0
        Me.btn_Taux_taxes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_Taux_taxes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Taux_taxes.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Taux_taxes.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_Taux_taxes.Location = New System.Drawing.Point(526, 214)
        Me.btn_Taux_taxes.Name = "btn_Taux_taxes"
        Me.btn_Taux_taxes.Size = New System.Drawing.Size(154, 32)
        Me.btn_Taux_taxes.TabIndex = 134
        Me.btn_Taux_taxes.Text = "Changer taux taxes"
        Me.btn_Taux_taxes.UseVisualStyleBackColor = False
        '
        'btn_Ajout_Allergene
        '
        Me.btn_Ajout_Allergene.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_Ajout_Allergene.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Ajout_Allergene.FlatAppearance.BorderSize = 0
        Me.btn_Ajout_Allergene.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_Ajout_Allergene.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Ajout_Allergene.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Ajout_Allergene.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_Ajout_Allergene.Location = New System.Drawing.Point(686, 214)
        Me.btn_Ajout_Allergene.Name = "btn_Ajout_Allergene"
        Me.btn_Ajout_Allergene.Size = New System.Drawing.Size(154, 32)
        Me.btn_Ajout_Allergene.TabIndex = 133
        Me.btn_Ajout_Allergene.Text = "Ajouter allergènes"
        Me.btn_Ajout_Allergene.UseVisualStyleBackColor = False
        '
        'usr_rech_gestion_produit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_historique_taxes)
        Me.Controls.Add(Me.btn_Taux_taxes)
        Me.Controls.Add(Me.btn_Ajout_Allergene)
        Me.Controls.Add(Me.pnl_rien)
        Me.Controls.Add(Me.btn_associer)
        Me.Controls.Add(Me.btn_visualiser)
        Me.Controls.Add(Me.pnl_ajout_mod)
        Me.Controls.Add(Me.btn_reactiver)
        Me.Controls.Add(Me.btn_excel)
        Me.Controls.Add(Me.btn_ajouter)
        Me.Controls.Add(Me.rdb_actifs_tous)
        Me.Controls.Add(Me.rdb_actifs_non)
        Me.Controls.Add(Me.rdb_actifs_oui)
        Me.Controls.Add(Me.lbl_ajoutSucces)
        Me.Controls.Add(Me.btn_modifier)
        Me.Controls.Add(Me.btn_desactiver)
        Me.Controls.Add(Me.dgv_produits)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnRechercher)
        Me.Controls.Add(Me.btnReinitialiser)
        Me.Controls.Add(Me.pnl_recherches)
        Me.Name = "usr_rech_gestion_produit"
        Me.Size = New System.Drawing.Size(1170, 1297)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnl_recherches.ResumeLayout(False)
        Me.pnl_recherches.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_produits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_ajout_mod.ResumeLayout(False)
        Me.pnl_ajout_mod.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.nm_quantite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.pnl_rien.ResumeLayout(False)
        Me.pnl_rien.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbo_ordre As ComboBox
    Friend WithEvents cbo_trier_par As ComboBox
    Friend WithEvents lbl_mots_cles As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_allergenes_keyword As TextBox
    Friend WithEvents cbo_allergenes As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents rdb_perissable_tous As RadioButton
    Friend WithEvents rdb_perissable_oui As RadioButton
    Friend WithEvents rdb_perissable_non As RadioButton
    Friend WithEvents cbo_rech_categorie As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_rech_marque As TextBox
    Friend WithEvents cbo_marque_contient As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbo_nom_contient As ComboBox
    Friend WithEvents txt_rech_nom As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_description_keyword As TextBox
    Friend WithEvents cbo_description As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnRechercher As Button
    Friend WithEvents btnReinitialiser As Button
    Friend WithEvents pnl_recherches As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents rdb_actifs_tous As RadioButton
    Friend WithEvents rdb_actifs_non As RadioButton
    Friend WithEvents rdb_actifs_oui As RadioButton
    Friend WithEvents lbl_ajoutSucces As Label
    Friend WithEvents btn_modifier As Button
    Friend WithEvents btn_desactiver As Button
    Friend WithEvents dgv_produits As DataGridView
    Friend WithEvents timer_succes As Timer
    Friend WithEvents btn_reactiver As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents rdb_bio_tous As RadioButton
    Friend WithEvents rdb_bio_oui As RadioButton
    Friend WithEvents rdb_bio_non As RadioButton
    Friend WithEvents pnl_ajout_mod As Panel
    Friend WithEvents txt_remarque As RichTextBox
    Friend WithEvents btn_generer As Button
    Friend WithEvents txt_no_produit As TextBox
    Friend WithEvents lbl_erreur_bio As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents cbo_bio As ComboBox
    Friend WithEvents txt_nom_produit As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_marque As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents lbl_mesure As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents lbl_erreur_perissable As Label
    Friend WithEvents cbo_categories As ComboBox
    Friend WithEvents cbo_perissable As ComboBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents cbo_format As ComboBox
    Friend WithEvents lbl_erreur_quantite As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents lbl_erreur_mesure As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents lbl_erreur_format As Label
    Friend WithEvents lbl_erreur_marque As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents lbl_erreur_nom_produit As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents lbl_erreur_code_plu As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lbl_erreur_code_barre As Label
    Friend WithEvents txt_description As RichTextBox
    Friend WithEvents lbl_erreur_numero As Label
    Friend WithEvents txt_allergenes As RichTextBox
    Friend WithEvents btn_valider As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents btn_mesure As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents lbl_erreur_categorie As Label
    Friend WithEvents txt_code_barre As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_code_plu As TextBox
    Friend WithEvents cms_unites_mesure As ContextMenuStrip
    Friend WithEvents tmr_animation As Timer
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lbl_mode As Label
    Friend WithEvents btn_visualiser As Button
    Friend WithEvents btn_excel As Button
    Friend WithEvents btn_annuler As Button
    Friend WithEvents btn_associer As Button
    Friend WithEvents nm_quantite As NumericUpDown
    Friend WithEvents pnl_rien As Panel
    Friend WithEvents Label33 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents chk_tvq As CheckBox
    Friend WithEvents chk_tps As CheckBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label34 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents btn_historique_taxes As Button
    Friend WithEvents btn_Taux_taxes As Button
    Friend WithEvents btn_Ajout_Allergene As Button
End Class
