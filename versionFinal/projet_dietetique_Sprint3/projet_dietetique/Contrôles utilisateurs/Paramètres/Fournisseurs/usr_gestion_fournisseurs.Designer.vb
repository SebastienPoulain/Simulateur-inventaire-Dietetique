<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usr_gestion_fournisseurs
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.rdb_actifs_tous = New System.Windows.Forms.RadioButton()
        Me.rdb_actifs_non = New System.Windows.Forms.RadioButton()
        Me.rdb_actifs_oui = New System.Windows.Forms.RadioButton()
        Me.dgv_fournisseurs = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRechercher = New System.Windows.Forms.Button()
        Me.btnReinitialiser = New System.Windows.Forms.Button()
        Me.pnl_recherches = New System.Windows.Forms.Panel()
        Me.txt_rech_telephone = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbl_fet = New System.Windows.Forms.Label()
        Me.lbl_qet = New System.Windows.Forms.Label()
        Me.lbl_qsup = New System.Windows.Forms.Label()
        Me.lbl_qinf = New System.Windows.Forms.Label()
        Me.lbl_fsup = New System.Windows.Forms.Label()
        Me.lbl_finf = New System.Windows.Forms.Label()
        Me.nm_commande_sup = New System.Windows.Forms.NumericUpDown()
        Me.nm_commande_inf = New System.Windows.Forms.NumericUpDown()
        Me.nm_frais_sup = New System.Windows.Forms.NumericUpDown()
        Me.nm_frais_inf = New System.Windows.Forms.NumericUpDown()
        Me.cbo_rech_quantite = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbo_rech_frais = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_rech_adresse = New System.Windows.Forms.TextBox()
        Me.cbo_adresse_contient = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_ordre = New System.Windows.Forms.ComboBox()
        Me.cbo_trier_par = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbo_nom_contient = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_rech_ville = New System.Windows.Forms.TextBox()
        Me.txt_rech_nom = New System.Windows.Forms.TextBox()
        Me.cbo_ville_contient = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_visualiser = New System.Windows.Forms.Button()
        Me.btn_reactiver = New System.Windows.Forms.Button()
        Me.btn_excel = New System.Windows.Forms.Button()
        Me.btn_ajouter = New System.Windows.Forms.Button()
        Me.btn_modifier = New System.Windows.Forms.Button()
        Me.btn_desactiver = New System.Windows.Forms.Button()
        Me.lbl_ajoutSucces = New System.Windows.Forms.Label()
        Me.btn_valider = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lbl_mode = New System.Windows.Forms.Label()
        Me.pnl_ajout_mod = New System.Windows.Forms.Panel()
        Me.lbl_erreur_titre = New System.Windows.Forms.Label()
        Me.txt_aj_titre = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.nm_aj_frais = New System.Windows.Forms.NumericUpDown()
        Me.lbl_erreur_siteWeb = New System.Windows.Forms.Label()
        Me.txt_aj_siteWeb = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.cbo_aj_villes = New System.Windows.Forms.ComboBox()
        Me.lbl_erreur_telephone = New System.Windows.Forms.Label()
        Me.pnl_tel = New System.Windows.Forms.Panel()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.lbl_erreur_courriel = New System.Windows.Forms.Label()
        Me.lbl_erreur_prenom = New System.Windows.Forms.Label()
        Me.lbl_erreur_nom_contact = New System.Windows.Forms.Label()
        Me.lbl_erreur_codepostal = New System.Windows.Forms.Label()
        Me.lbl_erreur_ville = New System.Windows.Forms.Label()
        Me.lbl_erreur_adresse = New System.Windows.Forms.Label()
        Me.lbl_erreur_nom_f = New System.Windows.Forms.Label()
        Me.txt_aj_remarque = New System.Windows.Forms.RichTextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.nm_aj_qte = New System.Windows.Forms.NumericUpDown()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_aj_cp = New System.Windows.Forms.TextBox()
        Me.txt_aj_adresse = New System.Windows.Forms.TextBox()
        Me.txt_aj_nom = New System.Windows.Forms.TextBox()
        Me.txt_aj_ctnom = New System.Windows.Forms.TextBox()
        Me.txt_aj_ctprenom = New System.Windows.Forms.TextBox()
        Me.txt_aj_ctcourriel = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgv_telephones = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_liste_tel = New System.Windows.Forms.Label()
        Me.lbl_nom_fourn = New System.Windows.Forms.Label()
        Me.timer_succes = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_vide = New System.Windows.Forms.Label()
        Me.pnl_vide = New System.Windows.Forms.Panel()
        Me.pnl_tel_vides = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_associer = New System.Windows.Forms.Button()
        CType(Me.dgv_fournisseurs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnl_recherches.SuspendLayout()
        CType(Me.nm_commande_sup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nm_commande_inf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nm_frais_sup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nm_frais_inf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.pnl_ajout_mod.SuspendLayout()
        CType(Me.nm_aj_frais, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nm_aj_qte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_telephones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_vide.SuspendLayout()
        Me.pnl_tel_vides.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdb_actifs_tous
        '
        Me.rdb_actifs_tous.AutoSize = True
        Me.rdb_actifs_tous.Location = New System.Drawing.Point(339, 305)
        Me.rdb_actifs_tous.Name = "rdb_actifs_tous"
        Me.rdb_actifs_tous.Size = New System.Drawing.Size(141, 17)
        Me.rdb_actifs_tous.TabIndex = 129
        Me.rdb_actifs_tous.Text = "Voir tous les fournisseurs"
        Me.rdb_actifs_tous.UseVisualStyleBackColor = True
        '
        'rdb_actifs_non
        '
        Me.rdb_actifs_non.AutoSize = True
        Me.rdb_actifs_non.Location = New System.Drawing.Point(171, 305)
        Me.rdb_actifs_non.Name = "rdb_actifs_non"
        Me.rdb_actifs_non.Size = New System.Drawing.Size(154, 17)
        Me.rdb_actifs_non.TabIndex = 128
        Me.rdb_actifs_non.Text = "Voir les fournisseurs inactifs"
        Me.rdb_actifs_non.UseVisualStyleBackColor = True
        '
        'rdb_actifs_oui
        '
        Me.rdb_actifs_oui.AutoSize = True
        Me.rdb_actifs_oui.Location = New System.Drawing.Point(13, 305)
        Me.rdb_actifs_oui.Name = "rdb_actifs_oui"
        Me.rdb_actifs_oui.Size = New System.Drawing.Size(146, 17)
        Me.rdb_actifs_oui.TabIndex = 127
        Me.rdb_actifs_oui.Text = "Voir les fournisseurs actifs"
        Me.rdb_actifs_oui.UseVisualStyleBackColor = True
        '
        'dgv_fournisseurs
        '
        Me.dgv_fournisseurs.AllowUserToAddRows = False
        Me.dgv_fournisseurs.AllowUserToDeleteRows = False
        Me.dgv_fournisseurs.AllowUserToResizeColumns = False
        Me.dgv_fournisseurs.AllowUserToResizeRows = False
        Me.dgv_fournisseurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_fournisseurs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_fournisseurs.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_fournisseurs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_fournisseurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_fournisseurs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.dgv_fournisseurs.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgv_fournisseurs.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgv_fournisseurs.Location = New System.Drawing.Point(2, 338)
        Me.dgv_fournisseurs.Name = "dgv_fournisseurs"
        Me.dgv_fournisseurs.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_fournisseurs.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_fournisseurs.RowHeadersVisible = False
        Me.dgv_fournisseurs.RowHeadersWidth = 35
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_fournisseurs.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_fournisseurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_fournisseurs.Size = New System.Drawing.Size(811, 329)
        Me.dgv_fournisseurs.TabIndex = 126
        '
        'Column4
        '
        Me.Column4.HeaderText = "Nom"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Adresse"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Ville"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Code postal"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Frais de livraison"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Commande minimale"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "Actif"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(-1, 256)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1181, 28)
        Me.Panel1.TabIndex = 125
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(11, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Liste des fournisseurs"
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
        Me.btnRechercher.Location = New System.Drawing.Point(850, 184)
        Me.btnRechercher.Name = "btnRechercher"
        Me.btnRechercher.Size = New System.Drawing.Size(154, 32)
        Me.btnRechercher.TabIndex = 122
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
        Me.btnReinitialiser.Location = New System.Drawing.Point(1010, 184)
        Me.btnReinitialiser.Name = "btnReinitialiser"
        Me.btnReinitialiser.Size = New System.Drawing.Size(154, 32)
        Me.btnReinitialiser.TabIndex = 123
        Me.btnReinitialiser.Text = "Réinitialiser"
        Me.btnReinitialiser.UseVisualStyleBackColor = False
        '
        'pnl_recherches
        '
        Me.pnl_recherches.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_recherches.Controls.Add(Me.txt_rech_telephone)
        Me.pnl_recherches.Controls.Add(Me.Label14)
        Me.pnl_recherches.Controls.Add(Me.lbl_fet)
        Me.pnl_recherches.Controls.Add(Me.lbl_qet)
        Me.pnl_recherches.Controls.Add(Me.lbl_qsup)
        Me.pnl_recherches.Controls.Add(Me.lbl_qinf)
        Me.pnl_recherches.Controls.Add(Me.lbl_fsup)
        Me.pnl_recherches.Controls.Add(Me.lbl_finf)
        Me.pnl_recherches.Controls.Add(Me.nm_commande_sup)
        Me.pnl_recherches.Controls.Add(Me.nm_commande_inf)
        Me.pnl_recherches.Controls.Add(Me.nm_frais_sup)
        Me.pnl_recherches.Controls.Add(Me.nm_frais_inf)
        Me.pnl_recherches.Controls.Add(Me.cbo_rech_quantite)
        Me.pnl_recherches.Controls.Add(Me.Label7)
        Me.pnl_recherches.Controls.Add(Me.cbo_rech_frais)
        Me.pnl_recherches.Controls.Add(Me.Label5)
        Me.pnl_recherches.Controls.Add(Me.txt_rech_adresse)
        Me.pnl_recherches.Controls.Add(Me.cbo_adresse_contient)
        Me.pnl_recherches.Controls.Add(Me.Label1)
        Me.pnl_recherches.Controls.Add(Me.cbo_ordre)
        Me.pnl_recherches.Controls.Add(Me.cbo_trier_par)
        Me.pnl_recherches.Controls.Add(Me.Label6)
        Me.pnl_recherches.Controls.Add(Me.cbo_nom_contient)
        Me.pnl_recherches.Controls.Add(Me.Label4)
        Me.pnl_recherches.Controls.Add(Me.txt_rech_ville)
        Me.pnl_recherches.Controls.Add(Me.txt_rech_nom)
        Me.pnl_recherches.Controls.Add(Me.cbo_ville_contient)
        Me.pnl_recherches.Controls.Add(Me.Label3)
        Me.pnl_recherches.Location = New System.Drawing.Point(2, 4)
        Me.pnl_recherches.Name = "pnl_recherches"
        Me.pnl_recherches.Size = New System.Drawing.Size(1164, 174)
        Me.pnl_recherches.TabIndex = 124
        '
        'txt_rech_telephone
        '
        Me.txt_rech_telephone.Location = New System.Drawing.Point(135, 129)
        Me.txt_rech_telephone.MaxLength = 14
        Me.txt_rech_telephone.Name = "txt_rech_telephone"
        Me.txt_rech_telephone.Size = New System.Drawing.Size(210, 20)
        Me.txt_rech_telephone.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(60, 131)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 17)
        Me.Label14.TabIndex = 121
        Me.Label14.Text = "Téléphone"
        '
        'lbl_fet
        '
        Me.lbl_fet.AutoSize = True
        Me.lbl_fet.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fet.ForeColor = System.Drawing.Color.Gray
        Me.lbl_fet.Location = New System.Drawing.Point(1024, 20)
        Me.lbl_fet.Name = "lbl_fet"
        Me.lbl_fet.Size = New System.Drawing.Size(17, 13)
        Me.lbl_fet.TabIndex = 120
        Me.lbl_fet.Text = "et"
        Me.lbl_fet.Visible = False
        '
        'lbl_qet
        '
        Me.lbl_qet.AutoSize = True
        Me.lbl_qet.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_qet.ForeColor = System.Drawing.Color.Gray
        Me.lbl_qet.Location = New System.Drawing.Point(1024, 62)
        Me.lbl_qet.Name = "lbl_qet"
        Me.lbl_qet.Size = New System.Drawing.Size(17, 13)
        Me.lbl_qet.TabIndex = 119
        Me.lbl_qet.Text = "et"
        Me.lbl_qet.Visible = False
        '
        'lbl_qsup
        '
        Me.lbl_qsup.AutoSize = True
        Me.lbl_qsup.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_qsup.ForeColor = System.Drawing.Color.Gray
        Me.lbl_qsup.Location = New System.Drawing.Point(1042, 80)
        Me.lbl_qsup.Name = "lbl_qsup"
        Me.lbl_qsup.Size = New System.Drawing.Size(52, 13)
        Me.lbl_qsup.TabIndex = 118
        Me.lbl_qsup.Text = "Lim. sup."
        Me.lbl_qsup.Visible = False
        '
        'lbl_qinf
        '
        Me.lbl_qinf.AutoSize = True
        Me.lbl_qinf.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_qinf.ForeColor = System.Drawing.Color.Gray
        Me.lbl_qinf.Location = New System.Drawing.Point(971, 80)
        Me.lbl_qinf.Name = "lbl_qinf"
        Me.lbl_qinf.Size = New System.Drawing.Size(47, 13)
        Me.lbl_qinf.TabIndex = 117
        Me.lbl_qinf.Text = "Lim. inf."
        Me.lbl_qinf.Visible = False
        '
        'lbl_fsup
        '
        Me.lbl_fsup.AutoSize = True
        Me.lbl_fsup.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fsup.ForeColor = System.Drawing.Color.Gray
        Me.lbl_fsup.Location = New System.Drawing.Point(1042, 38)
        Me.lbl_fsup.Name = "lbl_fsup"
        Me.lbl_fsup.Size = New System.Drawing.Size(52, 13)
        Me.lbl_fsup.TabIndex = 116
        Me.lbl_fsup.Text = "Lim. sup."
        Me.lbl_fsup.Visible = False
        '
        'lbl_finf
        '
        Me.lbl_finf.AutoSize = True
        Me.lbl_finf.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_finf.ForeColor = System.Drawing.Color.Gray
        Me.lbl_finf.Location = New System.Drawing.Point(971, 38)
        Me.lbl_finf.Name = "lbl_finf"
        Me.lbl_finf.Size = New System.Drawing.Size(47, 13)
        Me.lbl_finf.TabIndex = 115
        Me.lbl_finf.Text = "Lim. inf."
        Me.lbl_finf.Visible = False
        '
        'nm_commande_sup
        '
        Me.nm_commande_sup.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nm_commande_sup.Location = New System.Drawing.Point(1045, 57)
        Me.nm_commande_sup.Name = "nm_commande_sup"
        Me.nm_commande_sup.Size = New System.Drawing.Size(51, 23)
        Me.nm_commande_sup.TabIndex = 114
        Me.nm_commande_sup.Visible = False
        '
        'nm_commande_inf
        '
        Me.nm_commande_inf.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nm_commande_inf.Location = New System.Drawing.Point(970, 57)
        Me.nm_commande_inf.Name = "nm_commande_inf"
        Me.nm_commande_inf.Size = New System.Drawing.Size(51, 23)
        Me.nm_commande_inf.TabIndex = 113
        '
        'nm_frais_sup
        '
        Me.nm_frais_sup.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nm_frais_sup.Location = New System.Drawing.Point(1045, 15)
        Me.nm_frais_sup.Name = "nm_frais_sup"
        Me.nm_frais_sup.Size = New System.Drawing.Size(51, 23)
        Me.nm_frais_sup.TabIndex = 112
        Me.nm_frais_sup.Visible = False
        '
        'nm_frais_inf
        '
        Me.nm_frais_inf.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nm_frais_inf.Location = New System.Drawing.Point(970, 15)
        Me.nm_frais_inf.Name = "nm_frais_inf"
        Me.nm_frais_inf.Size = New System.Drawing.Size(51, 23)
        Me.nm_frais_inf.TabIndex = 111
        '
        'cbo_rech_quantite
        '
        Me.cbo_rech_quantite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_rech_quantite.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_rech_quantite.FormattingEnabled = True
        Me.cbo_rech_quantite.Items.AddRange(New Object() {"Ne s'applique pas", "Supérieur à", "Inférieur à", "Entre..."})
        Me.cbo_rech_quantite.Location = New System.Drawing.Point(836, 57)
        Me.cbo_rech_quantite.Name = "cbo_rech_quantite"
        Me.cbo_rech_quantite.Size = New System.Drawing.Size(119, 23)
        Me.cbo_rech_quantite.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(699, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 17)
        Me.Label7.TabIndex = 109
        Me.Label7.Text = "Commande minimale"
        '
        'cbo_rech_frais
        '
        Me.cbo_rech_frais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_rech_frais.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_rech_frais.FormattingEnabled = True
        Me.cbo_rech_frais.Items.AddRange(New Object() {"Ne s'applique pas", "Supérieur à", "Inférieur à", "Entre..."})
        Me.cbo_rech_frais.Location = New System.Drawing.Point(836, 15)
        Me.cbo_rech_frais.Name = "cbo_rech_frais"
        Me.cbo_rech_frais.Size = New System.Drawing.Size(119, 23)
        Me.cbo_rech_frais.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(724, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 17)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "Frais de livraison"
        '
        'txt_rech_adresse
        '
        Me.txt_rech_adresse.Location = New System.Drawing.Point(358, 101)
        Me.txt_rech_adresse.MaxLength = 100
        Me.txt_rech_adresse.Multiline = True
        Me.txt_rech_adresse.Name = "txt_rech_adresse"
        Me.txt_rech_adresse.Size = New System.Drawing.Size(212, 23)
        Me.txt_rech_adresse.TabIndex = 8
        '
        'cbo_adresse_contient
        '
        Me.cbo_adresse_contient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_adresse_contient.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_adresse_contient.FormattingEnabled = True
        Me.cbo_adresse_contient.Items.AddRange(New Object() {"Contient", "Commence par", "Ne s'applique pas"})
        Me.cbo_adresse_contient.Location = New System.Drawing.Point(135, 100)
        Me.cbo_adresse_contient.Name = "cbo_adresse_contient"
        Me.cbo_adresse_contient.Size = New System.Drawing.Size(211, 23)
        Me.cbo_adresse_contient.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(74, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Adresse"
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
        Me.cbo_trier_par.Items.AddRange(New Object() {"Nom de fournisseur (par défaut)", "Ville", "Adresse", "Frais de livraison", "Commande minimale"})
        Me.cbo_trier_par.Location = New System.Drawing.Point(357, 15)
        Me.cbo_trier_par.Name = "cbo_trier_par"
        Me.cbo_trier_par.Size = New System.Drawing.Size(212, 23)
        Me.cbo_trier_par.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(70, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 17)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "Trier par"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(4, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 17)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Nom du fournisseur"
        '
        'txt_rech_ville
        '
        Me.txt_rech_ville.Location = New System.Drawing.Point(358, 72)
        Me.txt_rech_ville.MaxLength = 50
        Me.txt_rech_ville.Multiline = True
        Me.txt_rech_ville.Name = "txt_rech_ville"
        Me.txt_rech_ville.Size = New System.Drawing.Size(212, 23)
        Me.txt_rech_ville.TabIndex = 6
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
        'cbo_ville_contient
        '
        Me.cbo_ville_contient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_ville_contient.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_ville_contient.FormattingEnabled = True
        Me.cbo_ville_contient.Items.AddRange(New Object() {"Contient", "Commence par", "Ne s'applique pas"})
        Me.cbo_ville_contient.Location = New System.Drawing.Point(135, 71)
        Me.cbo_ville_contient.Name = "cbo_ville_contient"
        Me.cbo_ville_contient.Size = New System.Drawing.Size(211, 23)
        Me.cbo_ville_contient.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(97, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 17)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Ville"
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
        Me.btn_visualiser.Location = New System.Drawing.Point(395, 673)
        Me.btn_visualiser.Name = "btn_visualiser"
        Me.btn_visualiser.Size = New System.Drawing.Size(184, 32)
        Me.btn_visualiser.TabIndex = 136
        Me.btn_visualiser.Text = "Visualiser un fournisseur"
        Me.btn_visualiser.UseVisualStyleBackColor = False
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
        Me.btn_reactiver.Location = New System.Drawing.Point(963, 673)
        Me.btn_reactiver.Name = "btn_reactiver"
        Me.btn_reactiver.Size = New System.Drawing.Size(95, 32)
        Me.btn_reactiver.TabIndex = 134
        Me.btn_reactiver.Text = "Activer"
        Me.btn_reactiver.UseVisualStyleBackColor = False
        '
        'btn_excel
        '
        Me.btn_excel.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btn_excel.FlatAppearance.BorderSize = 0
        Me.btn_excel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_excel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_excel.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_excel.Location = New System.Drawing.Point(596, 673)
        Me.btn_excel.Name = "btn_excel"
        Me.btn_excel.Size = New System.Drawing.Size(115, 32)
        Me.btn_excel.TabIndex = 133
        Me.btn_excel.Text = "Ouvrir avec Excel"
        Me.btn_excel.UseVisualStyleBackColor = False
        '
        'btn_ajouter
        '
        Me.btn_ajouter.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_ajouter.FlatAppearance.BorderSize = 0
        Me.btn_ajouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ajouter.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajouter.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_ajouter.Location = New System.Drawing.Point(4, 673)
        Me.btn_ajouter.Name = "btn_ajouter"
        Me.btn_ajouter.Size = New System.Drawing.Size(184, 32)
        Me.btn_ajouter.TabIndex = 132
        Me.btn_ajouter.Text = "Ajouter un fournisseur"
        Me.btn_ajouter.UseVisualStyleBackColor = False
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
        Me.btn_modifier.Location = New System.Drawing.Point(198, 673)
        Me.btn_modifier.Name = "btn_modifier"
        Me.btn_modifier.Size = New System.Drawing.Size(184, 32)
        Me.btn_modifier.TabIndex = 131
        Me.btn_modifier.Text = "Modifier un fournisseur"
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
        Me.btn_desactiver.Location = New System.Drawing.Point(1069, 673)
        Me.btn_desactiver.Name = "btn_desactiver"
        Me.btn_desactiver.Size = New System.Drawing.Size(95, 32)
        Me.btn_desactiver.TabIndex = 130
        Me.btn_desactiver.Text = "Désactiver"
        Me.btn_desactiver.UseVisualStyleBackColor = False
        '
        'lbl_ajoutSucces
        '
        Me.lbl_ajoutSucces.BackColor = System.Drawing.Color.Lime
        Me.lbl_ajoutSucces.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_ajoutSucces.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_ajoutSucces.Location = New System.Drawing.Point(-2, 712)
        Me.lbl_ajoutSucces.Name = "lbl_ajoutSucces"
        Me.lbl_ajoutSucces.Size = New System.Drawing.Size(1175, 24)
        Me.lbl_ajoutSucces.TabIndex = 137
        Me.lbl_ajoutSucces.Text = "Suppression réussie."
        Me.lbl_ajoutSucces.Visible = False
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
        Me.btn_valider.TabIndex = 221
        Me.btn_valider.Text = "Ajouter"
        Me.btn_valider.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel6.Controls.Add(Me.lbl_mode)
        Me.Panel6.Location = New System.Drawing.Point(0, 3)
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
        Me.lbl_mode.Size = New System.Drawing.Size(99, 21)
        Me.lbl_mode.TabIndex = 9
        Me.lbl_mode.Text = "Fournisseurs"
        '
        'pnl_ajout_mod
        '
        Me.pnl_ajout_mod.Controls.Add(Me.lbl_erreur_titre)
        Me.pnl_ajout_mod.Controls.Add(Me.txt_aj_titre)
        Me.pnl_ajout_mod.Controls.Add(Me.Label27)
        Me.pnl_ajout_mod.Controls.Add(Me.nm_aj_frais)
        Me.pnl_ajout_mod.Controls.Add(Me.lbl_erreur_siteWeb)
        Me.pnl_ajout_mod.Controls.Add(Me.txt_aj_siteWeb)
        Me.pnl_ajout_mod.Controls.Add(Me.Label26)
        Me.pnl_ajout_mod.Controls.Add(Me.cbo_aj_villes)
        Me.pnl_ajout_mod.Controls.Add(Me.lbl_erreur_telephone)
        Me.pnl_ajout_mod.Controls.Add(Me.pnl_tel)
        Me.pnl_ajout_mod.Controls.Add(Me.btn_annuler)
        Me.pnl_ajout_mod.Controls.Add(Me.lbl_erreur_courriel)
        Me.pnl_ajout_mod.Controls.Add(Me.lbl_erreur_prenom)
        Me.pnl_ajout_mod.Controls.Add(Me.lbl_erreur_nom_contact)
        Me.pnl_ajout_mod.Controls.Add(Me.lbl_erreur_codepostal)
        Me.pnl_ajout_mod.Controls.Add(Me.lbl_erreur_ville)
        Me.pnl_ajout_mod.Controls.Add(Me.lbl_erreur_adresse)
        Me.pnl_ajout_mod.Controls.Add(Me.lbl_erreur_nom_f)
        Me.pnl_ajout_mod.Controls.Add(Me.txt_aj_remarque)
        Me.pnl_ajout_mod.Controls.Add(Me.Label25)
        Me.pnl_ajout_mod.Controls.Add(Me.nm_aj_qte)
        Me.pnl_ajout_mod.Controls.Add(Me.Label24)
        Me.pnl_ajout_mod.Controls.Add(Me.Label21)
        Me.pnl_ajout_mod.Controls.Add(Me.Label22)
        Me.pnl_ajout_mod.Controls.Add(Me.Panel5)
        Me.pnl_ajout_mod.Controls.Add(Me.txt_aj_cp)
        Me.pnl_ajout_mod.Controls.Add(Me.txt_aj_adresse)
        Me.pnl_ajout_mod.Controls.Add(Me.txt_aj_nom)
        Me.pnl_ajout_mod.Controls.Add(Me.txt_aj_ctnom)
        Me.pnl_ajout_mod.Controls.Add(Me.txt_aj_ctprenom)
        Me.pnl_ajout_mod.Controls.Add(Me.txt_aj_ctcourriel)
        Me.pnl_ajout_mod.Controls.Add(Me.Label19)
        Me.pnl_ajout_mod.Controls.Add(Me.Label18)
        Me.pnl_ajout_mod.Controls.Add(Me.Label17)
        Me.pnl_ajout_mod.Controls.Add(Me.Label16)
        Me.pnl_ajout_mod.Controls.Add(Me.Panel4)
        Me.pnl_ajout_mod.Controls.Add(Me.Label13)
        Me.pnl_ajout_mod.Controls.Add(Me.Label12)
        Me.pnl_ajout_mod.Controls.Add(Me.Label11)
        Me.pnl_ajout_mod.Controls.Add(Me.Label9)
        Me.pnl_ajout_mod.Controls.Add(Me.Panel2)
        Me.pnl_ajout_mod.Controls.Add(Me.Panel6)
        Me.pnl_ajout_mod.Controls.Add(Me.btn_valider)
        Me.pnl_ajout_mod.Location = New System.Drawing.Point(0, 739)
        Me.pnl_ajout_mod.Name = "pnl_ajout_mod"
        Me.pnl_ajout_mod.Size = New System.Drawing.Size(1170, 549)
        Me.pnl_ajout_mod.TabIndex = 138
        '
        'lbl_erreur_titre
        '
        Me.lbl_erreur_titre.AutoSize = True
        Me.lbl_erreur_titre.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_erreur_titre.Location = New System.Drawing.Point(706, 200)
        Me.lbl_erreur_titre.Name = "lbl_erreur_titre"
        Me.lbl_erreur_titre.Size = New System.Drawing.Size(88, 13)
        Me.lbl_erreur_titre.TabIndex = 241
        Me.lbl_erreur_titre.Text = "Message d'erreur"
        Me.lbl_erreur_titre.Visible = False
        '
        'txt_aj_titre
        '
        Me.txt_aj_titre.Enabled = False
        Me.txt_aj_titre.Location = New System.Drawing.Point(708, 174)
        Me.txt_aj_titre.MaxLength = 50
        Me.txt_aj_titre.Name = "txt_aj_titre"
        Me.txt_aj_titre.Size = New System.Drawing.Size(277, 20)
        Me.txt_aj_titre.TabIndex = 218
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(665, 177)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(31, 15)
        Me.Label27.TabIndex = 239
        Me.Label27.Text = "Titre"
        '
        'nm_aj_frais
        '
        Me.nm_aj_frais.DecimalPlaces = 2
        Me.nm_aj_frais.Enabled = False
        Me.nm_aj_frais.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nm_aj_frais.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.nm_aj_frais.Location = New System.Drawing.Point(147, 356)
        Me.nm_aj_frais.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nm_aj_frais.Name = "nm_aj_frais"
        Me.nm_aj_frais.Size = New System.Drawing.Size(77, 23)
        Me.nm_aj_frais.TabIndex = 213
        '
        'lbl_erreur_siteWeb
        '
        Me.lbl_erreur_siteWeb.AutoSize = True
        Me.lbl_erreur_siteWeb.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_erreur_siteWeb.Location = New System.Drawing.Point(148, 296)
        Me.lbl_erreur_siteWeb.Name = "lbl_erreur_siteWeb"
        Me.lbl_erreur_siteWeb.Size = New System.Drawing.Size(88, 13)
        Me.lbl_erreur_siteWeb.TabIndex = 237
        Me.lbl_erreur_siteWeb.Text = "Message d'erreur"
        Me.lbl_erreur_siteWeb.Visible = False
        '
        'txt_aj_siteWeb
        '
        Me.txt_aj_siteWeb.Enabled = False
        Me.txt_aj_siteWeb.Location = New System.Drawing.Point(150, 270)
        Me.txt_aj_siteWeb.MaxLength = 50
        Me.txt_aj_siteWeb.Name = "txt_aj_siteWeb"
        Me.txt_aj_siteWeb.Size = New System.Drawing.Size(277, 20)
        Me.txt_aj_siteWeb.TabIndex = 212
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(90, 272)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(51, 15)
        Me.Label26.TabIndex = 235
        Me.Label26.Text = "Site web"
        '
        'cbo_aj_villes
        '
        Me.cbo_aj_villes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_aj_villes.Enabled = False
        Me.cbo_aj_villes.FormattingEnabled = True
        Me.cbo_aj_villes.Location = New System.Drawing.Point(147, 187)
        Me.cbo_aj_villes.Name = "cbo_aj_villes"
        Me.cbo_aj_villes.Size = New System.Drawing.Size(178, 21)
        Me.cbo_aj_villes.TabIndex = 210
        '
        'lbl_erreur_telephone
        '
        Me.lbl_erreur_telephone.AutoSize = True
        Me.lbl_erreur_telephone.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_erreur_telephone.Location = New System.Drawing.Point(705, 428)
        Me.lbl_erreur_telephone.Name = "lbl_erreur_telephone"
        Me.lbl_erreur_telephone.Size = New System.Drawing.Size(346, 26)
        Me.lbl_erreur_telephone.TabIndex = 233
        Me.lbl_erreur_telephone.Text = "Un des numéros n'est pas conforme et est donc invalide." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sachez que seuls des nom" &
    "bres sont acceptés dans le numéro de poste."
        Me.lbl_erreur_telephone.Visible = False
        '
        'pnl_tel
        '
        Me.pnl_tel.AutoScroll = True
        Me.pnl_tel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnl_tel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_tel.Enabled = False
        Me.pnl_tel.Location = New System.Drawing.Point(708, 264)
        Me.pnl_tel.Name = "pnl_tel"
        Me.pnl_tel.Size = New System.Drawing.Size(443, 160)
        Me.pnl_tel.TabIndex = 220
        '
        'btn_annuler
        '
        Me.btn_annuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btn_annuler.Enabled = False
        Me.btn_annuler.FlatAppearance.BorderSize = 0
        Me.btn_annuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_annuler.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annuler.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_annuler.Location = New System.Drawing.Point(830, 493)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(154, 32)
        Me.btn_annuler.TabIndex = 144
        Me.btn_annuler.Text = "Annuler"
        Me.btn_annuler.UseVisualStyleBackColor = False
        '
        'lbl_erreur_courriel
        '
        Me.lbl_erreur_courriel.AutoSize = True
        Me.lbl_erreur_courriel.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_erreur_courriel.Location = New System.Drawing.Point(705, 244)
        Me.lbl_erreur_courriel.Name = "lbl_erreur_courriel"
        Me.lbl_erreur_courriel.Size = New System.Drawing.Size(88, 13)
        Me.lbl_erreur_courriel.TabIndex = 230
        Me.lbl_erreur_courriel.Text = "Message d'erreur"
        Me.lbl_erreur_courriel.Visible = False
        '
        'lbl_erreur_prenom
        '
        Me.lbl_erreur_prenom.AutoSize = True
        Me.lbl_erreur_prenom.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_erreur_prenom.Location = New System.Drawing.Point(705, 157)
        Me.lbl_erreur_prenom.Name = "lbl_erreur_prenom"
        Me.lbl_erreur_prenom.Size = New System.Drawing.Size(88, 13)
        Me.lbl_erreur_prenom.TabIndex = 229
        Me.lbl_erreur_prenom.Text = "Message d'erreur"
        Me.lbl_erreur_prenom.Visible = False
        '
        'lbl_erreur_nom_contact
        '
        Me.lbl_erreur_nom_contact.AutoSize = True
        Me.lbl_erreur_nom_contact.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_erreur_nom_contact.Location = New System.Drawing.Point(705, 118)
        Me.lbl_erreur_nom_contact.Name = "lbl_erreur_nom_contact"
        Me.lbl_erreur_nom_contact.Size = New System.Drawing.Size(88, 13)
        Me.lbl_erreur_nom_contact.TabIndex = 228
        Me.lbl_erreur_nom_contact.Text = "Message d'erreur"
        Me.lbl_erreur_nom_contact.Visible = False
        '
        'lbl_erreur_codepostal
        '
        Me.lbl_erreur_codepostal.AutoSize = True
        Me.lbl_erreur_codepostal.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_erreur_codepostal.Location = New System.Drawing.Point(147, 254)
        Me.lbl_erreur_codepostal.Name = "lbl_erreur_codepostal"
        Me.lbl_erreur_codepostal.Size = New System.Drawing.Size(88, 13)
        Me.lbl_erreur_codepostal.TabIndex = 225
        Me.lbl_erreur_codepostal.Text = "Message d'erreur"
        Me.lbl_erreur_codepostal.Visible = False
        '
        'lbl_erreur_ville
        '
        Me.lbl_erreur_ville.AutoSize = True
        Me.lbl_erreur_ville.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_erreur_ville.Location = New System.Drawing.Point(147, 212)
        Me.lbl_erreur_ville.Name = "lbl_erreur_ville"
        Me.lbl_erreur_ville.Size = New System.Drawing.Size(88, 13)
        Me.lbl_erreur_ville.TabIndex = 224
        Me.lbl_erreur_ville.Text = "Message d'erreur"
        Me.lbl_erreur_ville.Visible = False
        '
        'lbl_erreur_adresse
        '
        Me.lbl_erreur_adresse.AutoSize = True
        Me.lbl_erreur_adresse.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_erreur_adresse.Location = New System.Drawing.Point(147, 169)
        Me.lbl_erreur_adresse.Name = "lbl_erreur_adresse"
        Me.lbl_erreur_adresse.Size = New System.Drawing.Size(88, 13)
        Me.lbl_erreur_adresse.TabIndex = 223
        Me.lbl_erreur_adresse.Text = "Message d'erreur"
        Me.lbl_erreur_adresse.Visible = False
        '
        'lbl_erreur_nom_f
        '
        Me.lbl_erreur_nom_f.AutoSize = True
        Me.lbl_erreur_nom_f.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_erreur_nom_f.Location = New System.Drawing.Point(147, 125)
        Me.lbl_erreur_nom_f.Name = "lbl_erreur_nom_f"
        Me.lbl_erreur_nom_f.Size = New System.Drawing.Size(88, 13)
        Me.lbl_erreur_nom_f.TabIndex = 222
        Me.lbl_erreur_nom_f.Text = "Message d'erreur"
        Me.lbl_erreur_nom_f.Visible = False
        '
        'txt_aj_remarque
        '
        Me.txt_aj_remarque.Enabled = False
        Me.txt_aj_remarque.Location = New System.Drawing.Point(147, 434)
        Me.txt_aj_remarque.MaxLength = 200
        Me.txt_aj_remarque.Name = "txt_aj_remarque"
        Me.txt_aj_remarque.Size = New System.Drawing.Size(333, 66)
        Me.txt_aj_remarque.TabIndex = 215
        Me.txt_aj_remarque.Text = ""
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(22, 436)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(119, 15)
        Me.Label25.TabIndex = 220
        Me.Label25.Text = "Remarque (facultatif)"
        '
        'nm_aj_qte
        '
        Me.nm_aj_qte.Enabled = False
        Me.nm_aj_qte.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nm_aj_qte.Location = New System.Drawing.Point(147, 394)
        Me.nm_aj_qte.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nm_aj_qte.Name = "nm_aj_qte"
        Me.nm_aj_qte.Size = New System.Drawing.Size(61, 23)
        Me.nm_aj_qte.TabIndex = 214
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(230, 356)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(15, 17)
        Me.Label24.TabIndex = 218
        Me.Label24.Text = "$"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(32, 398)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(109, 15)
        Me.Label21.TabIndex = 216
        Me.Label21.Text = "Quantité minimale " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(47, 358)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(94, 15)
        Me.Label22.TabIndex = 215
        Me.Label22.Text = "Frais de livraison"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label20)
        Me.Panel5.Location = New System.Drawing.Point(35, 316)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(445, 28)
        Me.Panel5.TabIndex = 214
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(11, 3)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(218, 21)
        Me.Label20.TabIndex = 9
        Me.Label20.Text = "Informations pour commande"
        '
        'txt_aj_cp
        '
        Me.txt_aj_cp.Enabled = False
        Me.txt_aj_cp.Location = New System.Drawing.Point(149, 228)
        Me.txt_aj_cp.MaxLength = 7
        Me.txt_aj_cp.Name = "txt_aj_cp"
        Me.txt_aj_cp.Size = New System.Drawing.Size(101, 20)
        Me.txt_aj_cp.TabIndex = 211
        '
        'txt_aj_adresse
        '
        Me.txt_aj_adresse.Enabled = False
        Me.txt_aj_adresse.Location = New System.Drawing.Point(149, 143)
        Me.txt_aj_adresse.MaxLength = 100
        Me.txt_aj_adresse.Name = "txt_aj_adresse"
        Me.txt_aj_adresse.Size = New System.Drawing.Size(277, 20)
        Me.txt_aj_adresse.TabIndex = 209
        '
        'txt_aj_nom
        '
        Me.txt_aj_nom.Enabled = False
        Me.txt_aj_nom.Location = New System.Drawing.Point(149, 99)
        Me.txt_aj_nom.MaxLength = 50
        Me.txt_aj_nom.Name = "txt_aj_nom"
        Me.txt_aj_nom.Size = New System.Drawing.Size(277, 20)
        Me.txt_aj_nom.TabIndex = 208
        '
        'txt_aj_ctnom
        '
        Me.txt_aj_ctnom.Enabled = False
        Me.txt_aj_ctnom.Location = New System.Drawing.Point(707, 95)
        Me.txt_aj_ctnom.MaxLength = 30
        Me.txt_aj_ctnom.Name = "txt_aj_ctnom"
        Me.txt_aj_ctnom.Size = New System.Drawing.Size(277, 20)
        Me.txt_aj_ctnom.TabIndex = 216
        '
        'txt_aj_ctprenom
        '
        Me.txt_aj_ctprenom.Enabled = False
        Me.txt_aj_ctprenom.Location = New System.Drawing.Point(707, 134)
        Me.txt_aj_ctprenom.MaxLength = 30
        Me.txt_aj_ctprenom.Name = "txt_aj_ctprenom"
        Me.txt_aj_ctprenom.Size = New System.Drawing.Size(277, 20)
        Me.txt_aj_ctprenom.TabIndex = 217
        '
        'txt_aj_ctcourriel
        '
        Me.txt_aj_ctcourriel.Enabled = False
        Me.txt_aj_ctcourriel.Location = New System.Drawing.Point(707, 218)
        Me.txt_aj_ctcourriel.MaxLength = 100
        Me.txt_aj_ctcourriel.Name = "txt_aj_ctcourriel"
        Me.txt_aj_ctcourriel.Size = New System.Drawing.Size(277, 20)
        Me.txt_aj_ctcourriel.TabIndex = 219
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(635, 264)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 15)
        Me.Label19.TabIndex = 203
        Me.Label19.Text = "Téléphone"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(649, 221)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 15)
        Me.Label18.TabIndex = 202
        Me.Label18.Text = "Courriel"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(649, 138)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 15)
        Me.Label17.TabIndex = 201
        Me.Label17.Text = "Prénom"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(665, 100)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(34, 15)
        Me.Label16.TabIndex = 200
        Me.Label16.Text = "Nom"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Location = New System.Drawing.Point(626, 55)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(525, 28)
        Me.Panel4.TabIndex = 199
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(11, 3)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(210, 21)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Personne ressource (contact)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(73, 230)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 15)
        Me.Label13.TabIndex = 198
        Me.Label13.Text = "Code postal"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(112, 190)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 15)
        Me.Label12.TabIndex = 197
        Me.Label12.Text = "Ville"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(93, 150)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 15)
        Me.Label11.TabIndex = 196
        Me.Label11.Text = "Adresse"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(107, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 15)
        Me.Label9.TabIndex = 195
        Me.Label9.Text = "Nom"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(35, 55)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(454, 28)
        Me.Panel2.TabIndex = 194
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(11, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(211, 21)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Identification et coordonnées"
        '
        'dgv_telephones
        '
        Me.dgv_telephones.AllowUserToAddRows = False
        Me.dgv_telephones.AllowUserToDeleteRows = False
        Me.dgv_telephones.AllowUserToResizeColumns = False
        Me.dgv_telephones.AllowUserToResizeRows = False
        Me.dgv_telephones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_telephones.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_telephones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_telephones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_telephones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgv_telephones.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgv_telephones.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgv_telephones.Location = New System.Drawing.Point(829, 338)
        Me.dgv_telephones.MultiSelect = False
        Me.dgv_telephones.Name = "dgv_telephones"
        Me.dgv_telephones.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_telephones.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_telephones.RowHeadersVisible = False
        Me.dgv_telephones.RowHeadersWidth = 35
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_telephones.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_telephones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_telephones.Size = New System.Drawing.Size(335, 329)
        Me.dgv_telephones.TabIndex = 139
        '
        'Column1
        '
        Me.Column1.HeaderText = "Type"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Téléphone"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Poste"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'lbl_liste_tel
        '
        Me.lbl_liste_tel.AutoSize = True
        Me.lbl_liste_tel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_liste_tel.ForeColor = System.Drawing.Color.Black
        Me.lbl_liste_tel.Location = New System.Drawing.Point(826, 322)
        Me.lbl_liste_tel.Name = "lbl_liste_tel"
        Me.lbl_liste_tel.Size = New System.Drawing.Size(148, 13)
        Me.lbl_liste_tel.TabIndex = 123
        Me.lbl_liste_tel.Text = "Téléphones du fournisseur:"
        '
        'lbl_nom_fourn
        '
        Me.lbl_nom_fourn.AutoSize = True
        Me.lbl_nom_fourn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nom_fourn.ForeColor = System.Drawing.Color.Black
        Me.lbl_nom_fourn.Location = New System.Drawing.Point(974, 321)
        Me.lbl_nom_fourn.Name = "lbl_nom_fourn"
        Me.lbl_nom_fourn.Size = New System.Drawing.Size(96, 15)
        Me.lbl_nom_fourn.TabIndex = 140
        Me.lbl_nom_fourn.Text = "-- fournisseur --"
        '
        'timer_succes
        '
        Me.timer_succes.Interval = 1
        '
        'lbl_vide
        '
        Me.lbl_vide.AutoSize = True
        Me.lbl_vide.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vide.Location = New System.Drawing.Point(60, 153)
        Me.lbl_vide.Name = "lbl_vide"
        Me.lbl_vide.Size = New System.Drawing.Size(678, 15)
        Me.lbl_vide.TabIndex = 141
        Me.lbl_vide.Text = "Désolé, il n'y a pas de fournisseurs dans cette section pour le moment. Veuillez " &
    "vérifier si des fournisseurs sont actifs ou inactifs."
        '
        'pnl_vide
        '
        Me.pnl_vide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_vide.Controls.Add(Me.lbl_vide)
        Me.pnl_vide.Location = New System.Drawing.Point(2, 338)
        Me.pnl_vide.Name = "pnl_vide"
        Me.pnl_vide.Size = New System.Drawing.Size(811, 329)
        Me.pnl_vide.TabIndex = 142
        Me.pnl_vide.Visible = False
        '
        'pnl_tel_vides
        '
        Me.pnl_tel_vides.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_tel_vides.Controls.Add(Me.Label10)
        Me.pnl_tel_vides.Location = New System.Drawing.Point(829, 338)
        Me.pnl_tel_vides.Name = "pnl_tel_vides"
        Me.pnl_tel_vides.Size = New System.Drawing.Size(335, 329)
        Me.pnl_tel_vides.TabIndex = 143
        Me.pnl_tel_vides.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(29, 153)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(282, 15)
        Me.Label10.TabIndex = 141
        Me.Label10.Text = "Il n'y a pas de numéros de téléphones de disponible."
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
        Me.btn_associer.Location = New System.Drawing.Point(730, 673)
        Me.btn_associer.Name = "btn_associer"
        Me.btn_associer.Size = New System.Drawing.Size(184, 32)
        Me.btn_associer.TabIndex = 144
        Me.btn_associer.Text = "Associer à un produit"
        Me.btn_associer.UseVisualStyleBackColor = False
        '
        'usr_gestion_fournisseurs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_associer)
        Me.Controls.Add(Me.pnl_tel_vides)
        Me.Controls.Add(Me.pnl_vide)
        Me.Controls.Add(Me.lbl_nom_fourn)
        Me.Controls.Add(Me.lbl_liste_tel)
        Me.Controls.Add(Me.dgv_telephones)
        Me.Controls.Add(Me.pnl_ajout_mod)
        Me.Controls.Add(Me.lbl_ajoutSucces)
        Me.Controls.Add(Me.btn_visualiser)
        Me.Controls.Add(Me.btn_reactiver)
        Me.Controls.Add(Me.btn_excel)
        Me.Controls.Add(Me.btn_ajouter)
        Me.Controls.Add(Me.btn_modifier)
        Me.Controls.Add(Me.btn_desactiver)
        Me.Controls.Add(Me.rdb_actifs_tous)
        Me.Controls.Add(Me.rdb_actifs_non)
        Me.Controls.Add(Me.rdb_actifs_oui)
        Me.Controls.Add(Me.dgv_fournisseurs)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnRechercher)
        Me.Controls.Add(Me.btnReinitialiser)
        Me.Controls.Add(Me.pnl_recherches)
        Me.Name = "usr_gestion_fournisseurs"
        Me.Size = New System.Drawing.Size(1170, 1285)
        CType(Me.dgv_fournisseurs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnl_recherches.ResumeLayout(False)
        Me.pnl_recherches.PerformLayout()
        CType(Me.nm_commande_sup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nm_commande_inf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nm_frais_sup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nm_frais_inf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.pnl_ajout_mod.ResumeLayout(False)
        Me.pnl_ajout_mod.PerformLayout()
        CType(Me.nm_aj_frais, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nm_aj_qte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgv_telephones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_vide.ResumeLayout(False)
        Me.pnl_vide.PerformLayout()
        Me.pnl_tel_vides.ResumeLayout(False)
        Me.pnl_tel_vides.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdb_actifs_tous As RadioButton
    Friend WithEvents rdb_actifs_non As RadioButton
    Friend WithEvents rdb_actifs_oui As RadioButton
    Friend WithEvents dgv_fournisseurs As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRechercher As Button
    Friend WithEvents btnReinitialiser As Button
    Friend WithEvents pnl_recherches As Panel
    Friend WithEvents cbo_ordre As ComboBox
    Friend WithEvents cbo_trier_par As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbo_nom_contient As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_rech_ville As TextBox
    Friend WithEvents txt_rech_nom As TextBox
    Friend WithEvents cbo_ville_contient As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_rech_adresse As TextBox
    Friend WithEvents cbo_adresse_contient As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbo_rech_quantite As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbo_rech_frais As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_fet As Label
    Friend WithEvents lbl_qet As Label
    Friend WithEvents lbl_qsup As Label
    Friend WithEvents lbl_qinf As Label
    Friend WithEvents lbl_fsup As Label
    Friend WithEvents lbl_finf As Label
    Friend WithEvents nm_commande_sup As NumericUpDown
    Friend WithEvents nm_commande_inf As NumericUpDown
    Friend WithEvents nm_frais_sup As NumericUpDown
    Friend WithEvents nm_frais_inf As NumericUpDown
    Friend WithEvents txt_rech_telephone As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btn_visualiser As Button
    Friend WithEvents btn_reactiver As Button
    Friend WithEvents btn_excel As Button
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents btn_modifier As Button
    Friend WithEvents btn_desactiver As Button
    Friend WithEvents lbl_ajoutSucces As Label
    Friend WithEvents btn_valider As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lbl_mode As Label
    Friend WithEvents pnl_ajout_mod As Panel
    Friend WithEvents dgv_telephones As DataGridView
    Friend WithEvents lbl_liste_tel As Label
    Friend WithEvents lbl_nom_fourn As Label
    Friend WithEvents timer_succes As Timer
    Friend WithEvents lbl_vide As Label
    Friend WithEvents pnl_vide As Panel
    Friend WithEvents pnl_tel_vides As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_aj_cp As TextBox
    Friend WithEvents txt_aj_adresse As TextBox
    Friend WithEvents txt_aj_nom As TextBox
    Friend WithEvents txt_aj_ctnom As TextBox
    Friend WithEvents txt_aj_ctprenom As TextBox
    Friend WithEvents txt_aj_ctcourriel As TextBox
    Friend WithEvents txt_aj_remarque As RichTextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents nm_aj_qte As NumericUpDown
    Friend WithEvents Label24 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents btn_annuler As Button
    Friend WithEvents lbl_erreur_courriel As Label
    Friend WithEvents lbl_erreur_prenom As Label
    Friend WithEvents lbl_erreur_nom_contact As Label
    Friend WithEvents lbl_erreur_codepostal As Label
    Friend WithEvents lbl_erreur_ville As Label
    Friend WithEvents lbl_erreur_adresse As Label
    Friend WithEvents lbl_erreur_nom_f As Label
    Friend WithEvents pnl_tel As Panel
    Friend WithEvents lbl_erreur_telephone As Label
    Friend WithEvents cbo_aj_villes As ComboBox
    Friend WithEvents lbl_erreur_siteWeb As Label
    Friend WithEvents txt_aj_siteWeb As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents nm_aj_frais As NumericUpDown
    Friend WithEvents btn_associer As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents lbl_erreur_titre As Label
    Friend WithEvents txt_aj_titre As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
End Class
