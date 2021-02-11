<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usr_inventaire_P
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnl_recherches = New System.Windows.Forms.Panel()
        Me.lbl_fet = New System.Windows.Forms.Label()
        Me.lbl_fsup = New System.Windows.Forms.Label()
        Me.lbl_finf = New System.Windows.Forms.Label()
        Me.nm_quant_sup = New System.Windows.Forms.NumericUpDown()
        Me.nm_quant_inf = New System.Windows.Forms.NumericUpDown()
        Me.cbo_rech_quant = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbo_emplacement = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbo_ordre = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.rdb_bio_tous = New System.Windows.Forms.RadioButton()
        Me.rdb_bio_oui = New System.Windows.Forms.RadioButton()
        Me.rdb_bio_non = New System.Windows.Forms.RadioButton()
        Me.cbo_trier_par = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_description_keyword = New System.Windows.Forms.TextBox()
        Me.cbo_description = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_mots_cles = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_allergenes_desc = New System.Windows.Forms.Label()
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgv_produits = New System.Windows.Forms.DataGridView()
        Me.btn_assigner = New System.Windows.Forms.Button()
        Me.lbl_ajoutSucces = New System.Windows.Forms.Label()
        Me.btn_supprimer = New System.Windows.Forms.Button()
        Me.btn_switch = New System.Windows.Forms.Button()
        Me.btn_modifier = New System.Windows.Forms.Button()
        Me.btn_ajouter = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_inventaire = New System.Windows.Forms.Label()
        Me.btnRechercher = New System.Windows.Forms.Button()
        Me.btnReinitialiser = New System.Windows.Forms.Button()
        Me.timer_succes = New System.Windows.Forms.Timer(Me.components)
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnl_recherches.SuspendLayout()
        CType(Me.nm_quant_sup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nm_quant_inf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_produits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_recherches
        '
        Me.pnl_recherches.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_recherches.Controls.Add(Me.lbl_fet)
        Me.pnl_recherches.Controls.Add(Me.lbl_fsup)
        Me.pnl_recherches.Controls.Add(Me.lbl_finf)
        Me.pnl_recherches.Controls.Add(Me.nm_quant_sup)
        Me.pnl_recherches.Controls.Add(Me.nm_quant_inf)
        Me.pnl_recherches.Controls.Add(Me.cbo_rech_quant)
        Me.pnl_recherches.Controls.Add(Me.Label10)
        Me.pnl_recherches.Controls.Add(Me.cbo_emplacement)
        Me.pnl_recherches.Controls.Add(Me.Label9)
        Me.pnl_recherches.Controls.Add(Me.Label11)
        Me.pnl_recherches.Controls.Add(Me.cbo_ordre)
        Me.pnl_recherches.Controls.Add(Me.Panel3)
        Me.pnl_recherches.Controls.Add(Me.cbo_trier_par)
        Me.pnl_recherches.Controls.Add(Me.Label1)
        Me.pnl_recherches.Controls.Add(Me.Label7)
        Me.pnl_recherches.Controls.Add(Me.txt_description_keyword)
        Me.pnl_recherches.Controls.Add(Me.cbo_description)
        Me.pnl_recherches.Controls.Add(Me.Label8)
        Me.pnl_recherches.Controls.Add(Me.lbl_mots_cles)
        Me.pnl_recherches.Controls.Add(Me.Label6)
        Me.pnl_recherches.Controls.Add(Me.lbl_allergenes_desc)
        Me.pnl_recherches.Controls.Add(Me.txt_allergenes_keyword)
        Me.pnl_recherches.Controls.Add(Me.cbo_allergenes)
        Me.pnl_recherches.Controls.Add(Me.Label20)
        Me.pnl_recherches.Controls.Add(Me.Label19)
        Me.pnl_recherches.Controls.Add(Me.Panel2)
        Me.pnl_recherches.Controls.Add(Me.cbo_rech_categorie)
        Me.pnl_recherches.Controls.Add(Me.Label15)
        Me.pnl_recherches.Controls.Add(Me.txt_rech_marque)
        Me.pnl_recherches.Controls.Add(Me.cbo_marque_contient)
        Me.pnl_recherches.Controls.Add(Me.Label3)
        Me.pnl_recherches.Controls.Add(Me.cbo_nom_contient)
        Me.pnl_recherches.Controls.Add(Me.txt_rech_nom)
        Me.pnl_recherches.Controls.Add(Me.Label4)
        Me.pnl_recherches.Location = New System.Drawing.Point(26, 108)
        Me.pnl_recherches.Name = "pnl_recherches"
        Me.pnl_recherches.Size = New System.Drawing.Size(1378, 137)
        Me.pnl_recherches.TabIndex = 49
        '
        'lbl_fet
        '
        Me.lbl_fet.AutoSize = True
        Me.lbl_fet.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fet.ForeColor = System.Drawing.Color.Gray
        Me.lbl_fet.Location = New System.Drawing.Point(340, 95)
        Me.lbl_fet.Name = "lbl_fet"
        Me.lbl_fet.Size = New System.Drawing.Size(17, 13)
        Me.lbl_fet.TabIndex = 127
        Me.lbl_fet.Text = "et"
        Me.lbl_fet.Visible = False
        '
        'lbl_fsup
        '
        Me.lbl_fsup.AutoSize = True
        Me.lbl_fsup.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fsup.ForeColor = System.Drawing.Color.Gray
        Me.lbl_fsup.Location = New System.Drawing.Point(358, 116)
        Me.lbl_fsup.Name = "lbl_fsup"
        Me.lbl_fsup.Size = New System.Drawing.Size(52, 13)
        Me.lbl_fsup.TabIndex = 126
        Me.lbl_fsup.Text = "Lim. sup."
        Me.lbl_fsup.Visible = False
        '
        'lbl_finf
        '
        Me.lbl_finf.AutoSize = True
        Me.lbl_finf.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_finf.ForeColor = System.Drawing.Color.Gray
        Me.lbl_finf.Location = New System.Drawing.Point(283, 116)
        Me.lbl_finf.Name = "lbl_finf"
        Me.lbl_finf.Size = New System.Drawing.Size(47, 13)
        Me.lbl_finf.TabIndex = 125
        Me.lbl_finf.Text = "Lim. inf."
        Me.lbl_finf.Visible = False
        '
        'nm_quant_sup
        '
        Me.nm_quant_sup.DecimalPlaces = 2
        Me.nm_quant_sup.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nm_quant_sup.Location = New System.Drawing.Point(361, 90)
        Me.nm_quant_sup.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nm_quant_sup.Name = "nm_quant_sup"
        Me.nm_quant_sup.Size = New System.Drawing.Size(51, 23)
        Me.nm_quant_sup.TabIndex = 9
        Me.nm_quant_sup.Visible = False
        '
        'nm_quant_inf
        '
        Me.nm_quant_inf.DecimalPlaces = 2
        Me.nm_quant_inf.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nm_quant_inf.Location = New System.Drawing.Point(286, 90)
        Me.nm_quant_inf.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nm_quant_inf.Name = "nm_quant_inf"
        Me.nm_quant_inf.Size = New System.Drawing.Size(51, 23)
        Me.nm_quant_inf.TabIndex = 8
        '
        'cbo_rech_quant
        '
        Me.cbo_rech_quant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_rech_quant.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_rech_quant.FormattingEnabled = True
        Me.cbo_rech_quant.Items.AddRange(New Object() {"Ne s'applique pas", "Supérieur à", "Inférieur à", "Entre..."})
        Me.cbo_rech_quant.Location = New System.Drawing.Point(112, 90)
        Me.cbo_rech_quant.Name = "cbo_rech_quant"
        Me.cbo_rech_quant.Size = New System.Drawing.Size(165, 23)
        Me.cbo_rech_quant.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(49, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 17)
        Me.Label10.TabIndex = 121
        Me.Label10.Text = "Quantité"
        '
        'cbo_emplacement
        '
        Me.cbo_emplacement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_emplacement.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_emplacement.FormattingEnabled = True
        Me.cbo_emplacement.Items.AddRange(New Object() {"Tous"})
        Me.cbo_emplacement.Location = New System.Drawing.Point(614, 32)
        Me.cbo_emplacement.Name = "cbo_emplacement"
        Me.cbo_emplacement.Size = New System.Drawing.Size(164, 23)
        Me.cbo_emplacement.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(522, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 17)
        Me.Label9.TabIndex = 113
        Me.Label9.Text = "Emplacement"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(583, 88)
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
        Me.cbo_ordre.Location = New System.Drawing.Point(112, 6)
        Me.cbo_ordre.Name = "cbo_ordre"
        Me.cbo_ordre.Size = New System.Drawing.Size(164, 23)
        Me.cbo_ordre.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.rdb_bio_tous)
        Me.Panel3.Controls.Add(Me.rdb_bio_oui)
        Me.Panel3.Controls.Add(Me.rdb_bio_non)
        Me.Panel3.Location = New System.Drawing.Point(611, 82)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(205, 27)
        Me.Panel3.TabIndex = 111
        '
        'rdb_bio_tous
        '
        Me.rdb_bio_tous.AutoSize = True
        Me.rdb_bio_tous.Checked = True
        Me.rdb_bio_tous.Location = New System.Drawing.Point(113, 7)
        Me.rdb_bio_tous.Name = "rdb_bio_tous"
        Me.rdb_bio_tous.Size = New System.Drawing.Size(49, 17)
        Me.rdb_bio_tous.TabIndex = 17
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
        Me.rdb_bio_oui.TabIndex = 15
        Me.rdb_bio_oui.Text = "Oui"
        Me.rdb_bio_oui.UseVisualStyleBackColor = True
        '
        'rdb_bio_non
        '
        Me.rdb_bio_non.AutoSize = True
        Me.rdb_bio_non.Location = New System.Drawing.Point(59, 7)
        Me.rdb_bio_non.Name = "rdb_bio_non"
        Me.rdb_bio_non.Size = New System.Drawing.Size(45, 17)
        Me.rdb_bio_non.TabIndex = 16
        Me.rdb_bio_non.Text = "Non"
        Me.rdb_bio_non.UseVisualStyleBackColor = True
        '
        'cbo_trier_par
        '
        Me.cbo_trier_par.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_trier_par.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_trier_par.FormattingEnabled = True
        Me.cbo_trier_par.Items.AddRange(New Object() {"N° de produit (par défaut)", "Nom de produit", "Marque", "Catégorie", "Emplacement", "Quantité", "Périssable (Oui/Non)", "Bio (Oui/Non)", "Description (Oui/Non)", "Allergènes (Oui/Non)"})
        Me.cbo_trier_par.Location = New System.Drawing.Point(286, 6)
        Me.cbo_trier_par.Name = "cbo_trier_par"
        Me.cbo_trier_par.Size = New System.Drawing.Size(212, 23)
        Me.cbo_trier_par.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(1094, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Mots clés"
        '
        'Label7
        '
        Me.Label7.Enabled = False
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(1160, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(210, 29)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "S'il y a plusieurs mots clés, veuillez les séparer avec des points-virgules ( ; )" &
    ""
        '
        'txt_description_keyword
        '
        Me.txt_description_keyword.Enabled = False
        Me.txt_description_keyword.Location = New System.Drawing.Point(1164, 29)
        Me.txt_description_keyword.Multiline = True
        Me.txt_description_keyword.Name = "txt_description_keyword"
        Me.txt_description_keyword.Size = New System.Drawing.Size(203, 42)
        Me.txt_description_keyword.TabIndex = 21
        '
        'cbo_description
        '
        Me.cbo_description.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_description.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_description.FormattingEnabled = True
        Me.cbo_description.Items.AddRange(New Object() {"Ne contient pas de description", "Contient une description (tous)", "Recherche par mot clé", "Ne s'applique pas"})
        Me.cbo_description.Location = New System.Drawing.Point(1164, 2)
        Me.cbo_description.Name = "cbo_description"
        Me.cbo_description.Size = New System.Drawing.Size(203, 23)
        Me.cbo_description.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(1084, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 17)
        Me.Label8.TabIndex = 79
        Me.Label8.Text = "Description"
        '
        'lbl_mots_cles
        '
        Me.lbl_mots_cles.AutoSize = True
        Me.lbl_mots_cles.Enabled = False
        Me.lbl_mots_cles.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mots_cles.ForeColor = System.Drawing.Color.Gray
        Me.lbl_mots_cles.Location = New System.Drawing.Point(810, 33)
        Me.lbl_mots_cles.Name = "lbl_mots_cles"
        Me.lbl_mots_cles.Size = New System.Drawing.Size(57, 15)
        Me.lbl_mots_cles.TabIndex = 78
        Me.lbl_mots_cles.Text = "Mots clés"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(48, 5)
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
        Me.lbl_allergenes_desc.Location = New System.Drawing.Point(876, 76)
        Me.lbl_allergenes_desc.Name = "lbl_allergenes_desc"
        Me.lbl_allergenes_desc.Size = New System.Drawing.Size(210, 29)
        Me.lbl_allergenes_desc.TabIndex = 76
        Me.lbl_allergenes_desc.Text = "S'il y a plusieurs allergènes, veuillez les séparer avec des points-virgules ( ; " &
    ")"
        '
        'txt_allergenes_keyword
        '
        Me.txt_allergenes_keyword.Enabled = False
        Me.txt_allergenes_keyword.Location = New System.Drawing.Point(875, 31)
        Me.txt_allergenes_keyword.Multiline = True
        Me.txt_allergenes_keyword.Name = "txt_allergenes_keyword"
        Me.txt_allergenes_keyword.Size = New System.Drawing.Size(203, 42)
        Me.txt_allergenes_keyword.TabIndex = 19
        '
        'cbo_allergenes
        '
        Me.cbo_allergenes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_allergenes.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_allergenes.FormattingEnabled = True
        Me.cbo_allergenes.Items.AddRange(New Object() {"Ne contient pas d'allergènes", "Contient des allergènes", "Ne contient pas... (mot(s) clé(s))", "Contient... (mot(s) clé(s))", "Ne s'applique pas"})
        Me.cbo_allergenes.Location = New System.Drawing.Point(875, 4)
        Me.cbo_allergenes.Name = "cbo_allergenes"
        Me.cbo_allergenes.Size = New System.Drawing.Size(203, 23)
        Me.cbo_allergenes.TabIndex = 18
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(800, 7)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 17)
        Me.Label20.TabIndex = 73
        Me.Label20.Text = "Allergènes"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(541, 62)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 17)
        Me.Label19.TabIndex = 72
        Me.Label19.Text = "Périssable"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rdb_perissable_tous)
        Me.Panel2.Controls.Add(Me.rdb_perissable_oui)
        Me.Panel2.Controls.Add(Me.rdb_perissable_non)
        Me.Panel2.Location = New System.Drawing.Point(611, 57)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(205, 25)
        Me.Panel2.TabIndex = 71
        '
        'rdb_perissable_tous
        '
        Me.rdb_perissable_tous.AutoSize = True
        Me.rdb_perissable_tous.Checked = True
        Me.rdb_perissable_tous.Location = New System.Drawing.Point(113, 7)
        Me.rdb_perissable_tous.Name = "rdb_perissable_tous"
        Me.rdb_perissable_tous.Size = New System.Drawing.Size(68, 17)
        Me.rdb_perissable_tous.TabIndex = 14
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
        Me.rdb_perissable_oui.TabIndex = 12
        Me.rdb_perissable_oui.Text = "Oui"
        Me.rdb_perissable_oui.UseVisualStyleBackColor = True
        '
        'rdb_perissable_non
        '
        Me.rdb_perissable_non.AutoSize = True
        Me.rdb_perissable_non.Location = New System.Drawing.Point(59, 7)
        Me.rdb_perissable_non.Name = "rdb_perissable_non"
        Me.rdb_perissable_non.Size = New System.Drawing.Size(45, 17)
        Me.rdb_perissable_non.TabIndex = 13
        Me.rdb_perissable_non.Text = "Non"
        Me.rdb_perissable_non.UseVisualStyleBackColor = True
        '
        'cbo_rech_categorie
        '
        Me.cbo_rech_categorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_rech_categorie.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_rech_categorie.FormattingEnabled = True
        Me.cbo_rech_categorie.Items.AddRange(New Object() {"Tous"})
        Me.cbo_rech_categorie.Location = New System.Drawing.Point(614, 5)
        Me.cbo_rech_categorie.Name = "cbo_rech_categorie"
        Me.cbo_rech_categorie.Size = New System.Drawing.Size(164, 23)
        Me.cbo_rech_categorie.TabIndex = 10
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(543, 7)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 17)
        Me.Label15.TabIndex = 69
        Me.Label15.Text = "Catégorie"
        '
        'txt_rech_marque
        '
        Me.txt_rech_marque.Location = New System.Drawing.Point(286, 62)
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
        Me.cbo_marque_contient.Location = New System.Drawing.Point(112, 61)
        Me.cbo_marque_contient.Name = "cbo_marque_contient"
        Me.cbo_marque_contient.Size = New System.Drawing.Size(164, 23)
        Me.cbo_marque_contient.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(52, 61)
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
        Me.cbo_nom_contient.Location = New System.Drawing.Point(112, 34)
        Me.cbo_nom_contient.Name = "cbo_nom_contient"
        Me.cbo_nom_contient.Size = New System.Drawing.Size(164, 23)
        Me.cbo_nom_contient.TabIndex = 3
        '
        'txt_rech_nom
        '
        Me.txt_rech_nom.Location = New System.Drawing.Point(286, 35)
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
        Me.Label4.Location = New System.Drawing.Point(3, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 17)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Nom du produit"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgv_produits)
        Me.Panel1.Controls.Add(Me.btn_assigner)
        Me.Panel1.Controls.Add(Me.lbl_ajoutSucces)
        Me.Panel1.Controls.Add(Me.btn_supprimer)
        Me.Panel1.Controls.Add(Me.btn_switch)
        Me.Panel1.Controls.Add(Me.btn_modifier)
        Me.Panel1.Controls.Add(Me.btn_ajouter)
        Me.Panel1.Controls.Add(Me.pnl_recherches)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.btnRechercher)
        Me.Panel1.Controls.Add(Me.btnReinitialiser)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1420, 835)
        Me.Panel1.TabIndex = 50
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
        Me.dgv_produits.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column9, Me.Column10, Me.Column11})
        Me.dgv_produits.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgv_produits.Location = New System.Drawing.Point(26, 338)
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
        Me.dgv_produits.Size = New System.Drawing.Size(1378, 426)
        Me.dgv_produits.TabIndex = 1
        Me.dgv_produits.TabStop = False
        '
        'btn_assigner
        '
        Me.btn_assigner.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_assigner.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_assigner.FlatAppearance.BorderSize = 0
        Me.btn_assigner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_assigner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_assigner.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_assigner.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_assigner.Location = New System.Drawing.Point(586, 770)
        Me.btn_assigner.Name = "btn_assigner"
        Me.btn_assigner.Size = New System.Drawing.Size(308, 32)
        Me.btn_assigner.TabIndex = 55
        Me.btn_assigner.Text = "Transférer mon inventaire dans celui de l'exercice"
        Me.btn_assigner.UseVisualStyleBackColor = False
        '
        'lbl_ajoutSucces
        '
        Me.lbl_ajoutSucces.BackColor = System.Drawing.Color.Lime
        Me.lbl_ajoutSucces.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_ajoutSucces.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_ajoutSucces.Location = New System.Drawing.Point(26, 807)
        Me.lbl_ajoutSucces.Name = "lbl_ajoutSucces"
        Me.lbl_ajoutSucces.Size = New System.Drawing.Size(1378, 24)
        Me.lbl_ajoutSucces.TabIndex = 54
        Me.lbl_ajoutSucces.Text = "L'utilisateur a bien été ajouté."
        Me.lbl_ajoutSucces.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_ajoutSucces.Visible = False
        '
        'btn_supprimer
        '
        Me.btn_supprimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_supprimer.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_supprimer.FlatAppearance.BorderSize = 0
        Me.btn_supprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_supprimer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_supprimer.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_supprimer.Location = New System.Drawing.Point(346, 770)
        Me.btn_supprimer.Name = "btn_supprimer"
        Me.btn_supprimer.Size = New System.Drawing.Size(154, 32)
        Me.btn_supprimer.TabIndex = 53
        Me.btn_supprimer.Text = "Supprimer"
        Me.btn_supprimer.UseVisualStyleBackColor = False
        '
        'btn_switch
        '
        Me.btn_switch.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_switch.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_switch.FlatAppearance.BorderSize = 0
        Me.btn_switch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_switch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_switch.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_switch.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_switch.Image = Global.projet_dietetique.My.Resources.Resources.baseline_sync_white_36dp
        Me.btn_switch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_switch.Location = New System.Drawing.Point(26, 22)
        Me.btn_switch.Name = "btn_switch"
        Me.btn_switch.Size = New System.Drawing.Size(210, 36)
        Me.btn_switch.TabIndex = 50
        Me.btn_switch.Tag = "prof"
        Me.btn_switch.Text = "Inventaire de l'exercice"
        Me.btn_switch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_switch.UseVisualStyleBackColor = False
        '
        'btn_modifier
        '
        Me.btn_modifier.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_modifier.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_modifier.FlatAppearance.BorderSize = 0
        Me.btn_modifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_modifier.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modifier.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_modifier.Location = New System.Drawing.Point(186, 770)
        Me.btn_modifier.Name = "btn_modifier"
        Me.btn_modifier.Size = New System.Drawing.Size(154, 32)
        Me.btn_modifier.TabIndex = 52
        Me.btn_modifier.Text = "Modifier"
        Me.btn_modifier.UseVisualStyleBackColor = False
        '
        'btn_ajouter
        '
        Me.btn_ajouter.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_ajouter.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_ajouter.FlatAppearance.BorderSize = 0
        Me.btn_ajouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ajouter.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajouter.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_ajouter.Location = New System.Drawing.Point(26, 770)
        Me.btn_ajouter.Name = "btn_ajouter"
        Me.btn_ajouter.Size = New System.Drawing.Size(154, 32)
        Me.btn_ajouter.TabIndex = 51
        Me.btn_ajouter.Text = "Ajouter"
        Me.btn_ajouter.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(26, 67)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1378, 35)
        Me.Panel4.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(11, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Rechercher dans l'inventaire"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.lbl_inventaire)
        Me.Panel5.Location = New System.Drawing.Point(26, 297)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1378, 35)
        Me.Panel5.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(932, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(443, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "*   Double cliquez sur un produit pour obtenir des détails supplémentaires"
        '
        'lbl_inventaire
        '
        Me.lbl_inventaire.AutoSize = True
        Me.lbl_inventaire.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inventaire.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_inventaire.Location = New System.Drawing.Point(11, 5)
        Me.lbl_inventaire.Name = "lbl_inventaire"
        Me.lbl_inventaire.Size = New System.Drawing.Size(140, 25)
        Me.lbl_inventaire.TabIndex = 9
        Me.lbl_inventaire.Text = "Mon inventaire"
        '
        'btnRechercher
        '
        Me.btnRechercher.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnRechercher.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnRechercher.FlatAppearance.BorderSize = 0
        Me.btnRechercher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRechercher.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRechercher.ForeColor = System.Drawing.SystemColors.Control
        Me.btnRechercher.Location = New System.Drawing.Point(1124, 251)
        Me.btnRechercher.Name = "btnRechercher"
        Me.btnRechercher.Size = New System.Drawing.Size(154, 32)
        Me.btnRechercher.TabIndex = 22
        Me.btnRechercher.Text = "Rechercher"
        Me.btnRechercher.UseVisualStyleBackColor = False
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
        Me.btnReinitialiser.Location = New System.Drawing.Point(1292, 251)
        Me.btnReinitialiser.Name = "btnReinitialiser"
        Me.btnReinitialiser.Size = New System.Drawing.Size(95, 32)
        Me.btnReinitialiser.TabIndex = 23
        Me.btnReinitialiser.Text = "Réinitialiser"
        Me.btnReinitialiser.UseVisualStyleBackColor = False
        '
        'timer_succes
        '
        Me.timer_succes.Interval = 1
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
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column10.HeaderText = "Emplacement"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 116
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column11.HeaderText = "Quantité"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 87
        '
        'usr_inventaire_P
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.Panel1)
        Me.Name = "usr_inventaire_P"
        Me.Size = New System.Drawing.Size(1438, 835)
        Me.pnl_recherches.ResumeLayout(False)
        Me.pnl_recherches.PerformLayout()
        CType(Me.nm_quant_sup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nm_quant_inf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgv_produits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_recherches As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents cbo_ordre As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents rdb_bio_tous As RadioButton
    Friend WithEvents rdb_bio_oui As RadioButton
    Friend WithEvents rdb_bio_non As RadioButton
    Friend WithEvents cbo_trier_par As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_description_keyword As TextBox
    Friend WithEvents cbo_description As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_mots_cles As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_allergenes_desc As Label
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnRechercher As Button
    Friend WithEvents btnReinitialiser As Button
    Friend WithEvents btn_switch As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents cbo_emplacement As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_fet As Label
    Friend WithEvents lbl_fsup As Label
    Friend WithEvents lbl_finf As Label
    Friend WithEvents nm_quant_sup As NumericUpDown
    Friend WithEvents nm_quant_inf As NumericUpDown
    Friend WithEvents cbo_rech_quant As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_supprimer As Button
    Friend WithEvents btn_modifier As Button
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents lbl_inventaire As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_ajoutSucces As Label
    Friend WithEvents timer_succes As Timer
    Friend WithEvents btn_assigner As Button
    Friend WithEvents dgv_produits As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
End Class
