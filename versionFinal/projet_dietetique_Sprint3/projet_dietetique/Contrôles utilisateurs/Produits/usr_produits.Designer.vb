<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usr_produits
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnReinitialiser = New System.Windows.Forms.Button()
        Me.btnRechercher = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnl_recherches = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbo_ordre = New System.Windows.Forms.ComboBox()
        Me.cbo_trier_par = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.rdb_bio_tous = New System.Windows.Forms.RadioButton()
        Me.rdb_bio_oui = New System.Windows.Forms.RadioButton()
        Me.rdb_bio_non = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_description_keyword = New System.Windows.Forms.TextBox()
        Me.cbo_description = New System.Windows.Forms.ComboBox()
        Me.cbo_rech_categorie = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rdb_perissable_tous = New System.Windows.Forms.RadioButton()
        Me.rdb_perissable_oui = New System.Windows.Forms.RadioButton()
        Me.rdb_perissable_non = New System.Windows.Forms.RadioButton()
        Me.lbl_mots_cles = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_allergenes_desc = New System.Windows.Forms.Label()
        Me.txt_allergenes_keyword = New System.Windows.Forms.TextBox()
        Me.cbo_allergenes = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_rech_marque = New System.Windows.Forms.TextBox()
        Me.cbo_marque_contient = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbo_nom_contient = New System.Windows.Forms.ComboBox()
        Me.txt_rech_nom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.dgv_produits = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.pnl_recherches.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_produits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(11, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Rechercher un produit"
        '
        'btnReinitialiser
        '
        Me.btnReinitialiser.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnReinitialiser.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnReinitialiser.FlatAppearance.BorderSize = 0
        Me.btnReinitialiser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnReinitialiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReinitialiser.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReinitialiser.ForeColor = System.Drawing.SystemColors.Control
        Me.btnReinitialiser.Location = New System.Drawing.Point(1292, 193)
        Me.btnReinitialiser.Name = "btnReinitialiser"
        Me.btnReinitialiser.Size = New System.Drawing.Size(95, 32)
        Me.btnReinitialiser.TabIndex = 17
        Me.btnReinitialiser.Text = "Réinitialiser"
        Me.btnReinitialiser.UseVisualStyleBackColor = False
        '
        'btnRechercher
        '
        Me.btnRechercher.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnRechercher.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnRechercher.FlatAppearance.BorderSize = 0
        Me.btnRechercher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRechercher.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRechercher.ForeColor = System.Drawing.SystemColors.Control
        Me.btnRechercher.Location = New System.Drawing.Point(1126, 193)
        Me.btnRechercher.Name = "btnRechercher"
        Me.btnRechercher.Size = New System.Drawing.Size(154, 32)
        Me.btnRechercher.TabIndex = 17
        Me.btnRechercher.Text = "Rechercher"
        Me.btnRechercher.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(30, 25)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1380, 35)
        Me.Panel4.TabIndex = 44
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Location = New System.Drawing.Point(30, 249)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1380, 35)
        Me.Panel5.TabIndex = 45
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(970, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(399, 17)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "*   Cliquez sur un produit pour obtenir des détails supplémentaires"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(11, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Liste de produits"
        '
        'pnl_recherches
        '
        Me.pnl_recherches.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_recherches.Controls.Add(Me.Label11)
        Me.pnl_recherches.Controls.Add(Me.cbo_ordre)
        Me.pnl_recherches.Controls.Add(Me.cbo_trier_par)
        Me.pnl_recherches.Controls.Add(Me.Label1)
        Me.pnl_recherches.Controls.Add(Me.Panel3)
        Me.pnl_recherches.Controls.Add(Me.Label7)
        Me.pnl_recherches.Controls.Add(Me.txt_description_keyword)
        Me.pnl_recherches.Controls.Add(Me.cbo_description)
        Me.pnl_recherches.Controls.Add(Me.cbo_rech_categorie)
        Me.pnl_recherches.Controls.Add(Me.Label15)
        Me.pnl_recherches.Controls.Add(Me.Label8)
        Me.pnl_recherches.Controls.Add(Me.Panel2)
        Me.pnl_recherches.Controls.Add(Me.lbl_mots_cles)
        Me.pnl_recherches.Controls.Add(Me.Label19)
        Me.pnl_recherches.Controls.Add(Me.Label6)
        Me.pnl_recherches.Controls.Add(Me.lbl_allergenes_desc)
        Me.pnl_recherches.Controls.Add(Me.txt_allergenes_keyword)
        Me.pnl_recherches.Controls.Add(Me.cbo_allergenes)
        Me.pnl_recherches.Controls.Add(Me.Label20)
        Me.pnl_recherches.Controls.Add(Me.txt_rech_marque)
        Me.pnl_recherches.Controls.Add(Me.cbo_marque_contient)
        Me.pnl_recherches.Controls.Add(Me.Label3)
        Me.pnl_recherches.Controls.Add(Me.cbo_nom_contient)
        Me.pnl_recherches.Controls.Add(Me.txt_rech_nom)
        Me.pnl_recherches.Controls.Add(Me.Label4)
        Me.pnl_recherches.Location = New System.Drawing.Point(30, 67)
        Me.pnl_recherches.Name = "pnl_recherches"
        Me.pnl_recherches.Size = New System.Drawing.Size(1380, 120)
        Me.pnl_recherches.TabIndex = 46
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(559, 66)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 17)
        Me.Label11.TabIndex = 112
        Me.Label11.Text = "Bio"
        '
        'cbo_ordre
        '
        Me.cbo_ordre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_ordre.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_ordre.FormattingEnabled = True
        Me.cbo_ordre.Items.AddRange(New Object() {"Ordre croissant", "Ordre décroissant"})
        Me.cbo_ordre.Location = New System.Drawing.Point(115, 11)
        Me.cbo_ordre.Name = "cbo_ordre"
        Me.cbo_ordre.Size = New System.Drawing.Size(164, 23)
        Me.cbo_ordre.TabIndex = 85
        '
        'cbo_trier_par
        '
        Me.cbo_trier_par.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_trier_par.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_trier_par.FormattingEnabled = True
        Me.cbo_trier_par.Items.AddRange(New Object() {"N° de produit (par défaut)", "Nom de produit", "Marque", "Catégorie", "Bio (Oui/Non)", "Périssable (Oui/Non)", "Description (Oui/Non)", "Allergènes (Oui/Non)"})
        Me.cbo_trier_par.Location = New System.Drawing.Point(289, 11)
        Me.cbo_trier_par.Name = "cbo_trier_par"
        Me.cbo_trier_par.Size = New System.Drawing.Size(212, 23)
        Me.cbo_trier_par.TabIndex = 84
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(1092, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Mots clés"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.rdb_bio_tous)
        Me.Panel3.Controls.Add(Me.rdb_bio_oui)
        Me.Panel3.Controls.Add(Me.rdb_bio_non)
        Me.Panel3.Location = New System.Drawing.Point(591, 60)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(193, 27)
        Me.Panel3.TabIndex = 111
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
        'Label7
        '
        Me.Label7.Enabled = False
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(1158, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(210, 29)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "S'il y a plusieurs mots clés, veuillez les séparer avec des points-virgules ( ; )" &
    ""
        '
        'txt_description_keyword
        '
        Me.txt_description_keyword.Enabled = False
        Me.txt_description_keyword.Location = New System.Drawing.Point(1162, 35)
        Me.txt_description_keyword.MaxLength = 200
        Me.txt_description_keyword.Multiline = True
        Me.txt_description_keyword.Name = "txt_description_keyword"
        Me.txt_description_keyword.Size = New System.Drawing.Size(203, 42)
        Me.txt_description_keyword.TabIndex = 81
        '
        'cbo_description
        '
        Me.cbo_description.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_description.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_description.FormattingEnabled = True
        Me.cbo_description.Items.AddRange(New Object() {"Ne contient pas de description", "Contient une description (tous)", "Recherche par mot clé", "Ne s'applique pas"})
        Me.cbo_description.Location = New System.Drawing.Point(1162, 8)
        Me.cbo_description.Name = "cbo_description"
        Me.cbo_description.Size = New System.Drawing.Size(203, 23)
        Me.cbo_description.TabIndex = 80
        '
        'cbo_rech_categorie
        '
        Me.cbo_rech_categorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_rech_categorie.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_rech_categorie.FormattingEnabled = True
        Me.cbo_rech_categorie.Items.AddRange(New Object() {"Tous"})
        Me.cbo_rech_categorie.Location = New System.Drawing.Point(594, 11)
        Me.cbo_rech_categorie.Name = "cbo_rech_categorie"
        Me.cbo_rech_categorie.Size = New System.Drawing.Size(164, 23)
        Me.cbo_rech_categorie.TabIndex = 70
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(523, 11)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 17)
        Me.Label15.TabIndex = 69
        Me.Label15.Text = "Catégorie"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(1082, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 17)
        Me.Label8.TabIndex = 79
        Me.Label8.Text = "Description"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rdb_perissable_tous)
        Me.Panel2.Controls.Add(Me.rdb_perissable_oui)
        Me.Panel2.Controls.Add(Me.rdb_perissable_non)
        Me.Panel2.Location = New System.Drawing.Point(591, 35)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(193, 25)
        Me.Panel2.TabIndex = 71
        '
        'rdb_perissable_tous
        '
        Me.rdb_perissable_tous.AutoSize = True
        Me.rdb_perissable_tous.Checked = True
        Me.rdb_perissable_tous.Location = New System.Drawing.Point(113, 7)
        Me.rdb_perissable_tous.Name = "rdb_perissable_tous"
        Me.rdb_perissable_tous.Size = New System.Drawing.Size(68, 17)
        Me.rdb_perissable_tous.TabIndex = 37
        Me.rdb_perissable_tous.TabStop = True
        Me.rdb_perissable_tous.Text = "Les deux"
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
        'lbl_mots_cles
        '
        Me.lbl_mots_cles.AutoSize = True
        Me.lbl_mots_cles.Enabled = False
        Me.lbl_mots_cles.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mots_cles.ForeColor = System.Drawing.Color.Gray
        Me.lbl_mots_cles.Location = New System.Drawing.Point(790, 39)
        Me.lbl_mots_cles.Name = "lbl_mots_cles"
        Me.lbl_mots_cles.Size = New System.Drawing.Size(57, 15)
        Me.lbl_mots_cles.TabIndex = 78
        Me.lbl_mots_cles.Text = "Mots clés"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(521, 40)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 17)
        Me.Label19.TabIndex = 72
        Me.Label19.Text = "Périssable"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(51, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 17)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "Trier par"
        '
        'lbl_allergenes_desc
        '
        Me.lbl_allergenes_desc.Enabled = False
        Me.lbl_allergenes_desc.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_allergenes_desc.ForeColor = System.Drawing.Color.Gray
        Me.lbl_allergenes_desc.Location = New System.Drawing.Point(856, 82)
        Me.lbl_allergenes_desc.Name = "lbl_allergenes_desc"
        Me.lbl_allergenes_desc.Size = New System.Drawing.Size(210, 29)
        Me.lbl_allergenes_desc.TabIndex = 76
        Me.lbl_allergenes_desc.Text = "S'il y a plusieurs allergènes, veuillez les séparer avec des points-virgules ( ; " &
    ")"
        '
        'txt_allergenes_keyword
        '
        Me.txt_allergenes_keyword.Enabled = False
        Me.txt_allergenes_keyword.Location = New System.Drawing.Point(855, 37)
        Me.txt_allergenes_keyword.MaxLength = 200
        Me.txt_allergenes_keyword.Multiline = True
        Me.txt_allergenes_keyword.Name = "txt_allergenes_keyword"
        Me.txt_allergenes_keyword.Size = New System.Drawing.Size(203, 42)
        Me.txt_allergenes_keyword.TabIndex = 75
        '
        'cbo_allergenes
        '
        Me.cbo_allergenes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_allergenes.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_allergenes.FormattingEnabled = True
        Me.cbo_allergenes.Items.AddRange(New Object() {"Ne contient pas d'allergènes", "Contient des allergènes", "Ne contient pas... (mot(s) clé(s))", "Contient... (mot(s) clé(s))", "Ne s'applique pas"})
        Me.cbo_allergenes.Location = New System.Drawing.Point(855, 10)
        Me.cbo_allergenes.Name = "cbo_allergenes"
        Me.cbo_allergenes.Size = New System.Drawing.Size(203, 23)
        Me.cbo_allergenes.TabIndex = 74
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(780, 13)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 17)
        Me.Label20.TabIndex = 73
        Me.Label20.Text = "Allergènes"
        '
        'txt_rech_marque
        '
        Me.txt_rech_marque.Location = New System.Drawing.Point(289, 67)
        Me.txt_rech_marque.MaxLength = 50
        Me.txt_rech_marque.Multiline = True
        Me.txt_rech_marque.Name = "txt_rech_marque"
        Me.txt_rech_marque.Size = New System.Drawing.Size(212, 23)
        Me.txt_rech_marque.TabIndex = 68
        '
        'cbo_marque_contient
        '
        Me.cbo_marque_contient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_marque_contient.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_marque_contient.FormattingEnabled = True
        Me.cbo_marque_contient.Items.AddRange(New Object() {"Contient", "Commence par", "Ne s'applique pas"})
        Me.cbo_marque_contient.Location = New System.Drawing.Point(115, 66)
        Me.cbo_marque_contient.Name = "cbo_marque_contient"
        Me.cbo_marque_contient.Size = New System.Drawing.Size(164, 23)
        Me.cbo_marque_contient.TabIndex = 67
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(55, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Marque"
        '
        'cbo_nom_contient
        '
        Me.cbo_nom_contient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_nom_contient.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_nom_contient.FormattingEnabled = True
        Me.cbo_nom_contient.Items.AddRange(New Object() {"Contient", "Commence par", "Ne s'applique pas"})
        Me.cbo_nom_contient.Location = New System.Drawing.Point(115, 39)
        Me.cbo_nom_contient.Name = "cbo_nom_contient"
        Me.cbo_nom_contient.Size = New System.Drawing.Size(164, 23)
        Me.cbo_nom_contient.TabIndex = 65
        '
        'txt_rech_nom
        '
        Me.txt_rech_nom.Location = New System.Drawing.Point(289, 40)
        Me.txt_rech_nom.MaxLength = 50
        Me.txt_rech_nom.Multiline = True
        Me.txt_rech_nom.Name = "txt_rech_nom"
        Me.txt_rech_nom.Size = New System.Drawing.Size(212, 23)
        Me.txt_rech_nom.TabIndex = 64
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 17)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Nom du produit"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnAjouter)
        Me.Panel1.Controls.Add(Me.dgv_produits)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.btnRechercher)
        Me.Panel1.Controls.Add(Me.btnReinitialiser)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1438, 835)
        Me.Panel1.TabIndex = 47
        '
        'btnAjouter
        '
        Me.btnAjouter.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnAjouter.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAjouter.FlatAppearance.BorderSize = 0
        Me.btnAjouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjouter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjouter.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAjouter.Location = New System.Drawing.Point(966, 193)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(154, 32)
        Me.btnAjouter.TabIndex = 48
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = False
        '
        'dgv_produits
        '
        Me.dgv_produits.AllowUserToAddRows = False
        Me.dgv_produits.AllowUserToDeleteRows = False
        Me.dgv_produits.AllowUserToResizeColumns = False
        Me.dgv_produits.AllowUserToResizeRows = False
        Me.dgv_produits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_produits.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_produits.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_produits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_produits.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column9})
        Me.dgv_produits.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgv_produits.Location = New System.Drawing.Point(30, 290)
        Me.dgv_produits.MultiSelect = False
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
        Me.dgv_produits.RowHeadersWidth = 30
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_produits.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_produits.RowTemplate.Height = 30
        Me.dgv_produits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_produits.Size = New System.Drawing.Size(1378, 533)
        Me.dgv_produits.TabIndex = 46
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column1.HeaderText = "No. Produit"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 105
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Nom"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column3.HeaderText = "Marque"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 80
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Catégorie"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column5.HeaderText = "Format"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 77
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column6.HeaderText = "Périssable"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 95
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column7.HeaderText = "Bio"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 53
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column9.HeaderText = "Allergènes"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 98
        '
        'usr_produits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.pnl_recherches)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "usr_produits"
        Me.Size = New System.Drawing.Size(1438, 835)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.pnl_recherches.ResumeLayout(False)
        Me.pnl_recherches.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgv_produits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents btnRechercher As Button
    Friend WithEvents btnReinitialiser As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents pnl_recherches As Panel
    Friend WithEvents cbo_nom_contient As ComboBox
    Friend WithEvents txt_rech_nom As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_rech_marque As TextBox
    Friend WithEvents cbo_marque_contient As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbo_rech_categorie As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents rdb_perissable_tous As RadioButton
    Friend WithEvents rdb_perissable_oui As RadioButton
    Friend WithEvents rdb_perissable_non As RadioButton
    Friend WithEvents lbl_mots_cles As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_allergenes_desc As Label
    Friend WithEvents txt_allergenes_keyword As TextBox
    Friend WithEvents cbo_allergenes As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbo_trier_par As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_description_keyword As TextBox
    Friend WithEvents cbo_description As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbo_ordre As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents rdb_bio_tous As RadioButton
    Friend WithEvents rdb_bio_oui As RadioButton
    Friend WithEvents rdb_bio_non As RadioButton
    Friend WithEvents dgv_produits As DataGridView
    Friend WithEvents btnAjouter As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
End Class
