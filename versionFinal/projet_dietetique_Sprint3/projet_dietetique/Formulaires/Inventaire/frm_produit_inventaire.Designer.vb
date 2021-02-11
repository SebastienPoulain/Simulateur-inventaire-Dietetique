<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_produit_inventaire
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnl_navigation = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_titre = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_minimize = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_ajoutSucces = New System.Windows.Forms.Label()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.btn_ajouter = New System.Windows.Forms.Button()
        Me.lbl_pnl = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblE_emplac = New System.Windows.Forms.Label()
        Me.lbE_quant = New System.Windows.Forms.Label()
        Me.cbo_empl = New System.Windows.Forms.ComboBox()
        Me.nm_quant = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pnl_recherches = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbo_ordre = New System.Windows.Forms.ComboBox()
        Me.cbo_trier_par = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rdb_bio_tous = New System.Windows.Forms.RadioButton()
        Me.rdb_bio_oui = New System.Windows.Forms.RadioButton()
        Me.rdb_bio_non = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_description_keyword = New System.Windows.Forms.TextBox()
        Me.cbo_description = New System.Windows.Forms.ComboBox()
        Me.cbo_rech_categorie = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
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
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnl_6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgv_produits = New System.Windows.Forms.DataGridView()
        Me.btnRechercher = New System.Windows.Forms.Button()
        Me.btnReinitialiser = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.timer_succes = New System.Windows.Forms.Timer(Me.components)
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnl_navigation.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.nm_quant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_recherches.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.pnl_6.SuspendLayout()
        CType(Me.dgv_produits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_navigation
        '
        Me.pnl_navigation.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.pnl_navigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_navigation.Controls.Add(Me.Panel3)
        Me.pnl_navigation.Controls.Add(Me.lbl_titre)
        Me.pnl_navigation.Controls.Add(Me.btn_exit)
        Me.pnl_navigation.Controls.Add(Me.btn_minimize)
        Me.pnl_navigation.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_navigation.Location = New System.Drawing.Point(0, 0)
        Me.pnl_navigation.Name = "pnl_navigation"
        Me.pnl_navigation.Size = New System.Drawing.Size(1204, 30)
        Me.pnl_navigation.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(-1, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(738, 579)
        Me.Panel3.TabIndex = 3
        '
        'lbl_titre
        '
        Me.lbl_titre.AutoSize = True
        Me.lbl_titre.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titre.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_titre.Location = New System.Drawing.Point(12, 5)
        Me.lbl_titre.Name = "lbl_titre"
        Me.lbl_titre.Size = New System.Drawing.Size(156, 17)
        Me.lbl_titre.TabIndex = 2
        Me.lbl_titre.Text = "Ajouter dans l'inventaire"
        '
        'btn_exit
        '
        Me.btn_exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_exit.FlatAppearance.BorderSize = 0
        Me.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown
        Me.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.ForeColor = System.Drawing.Color.DimGray
        Me.btn_exit.Image = Global.projet_dietetique.My.Resources.Resources.ic_clear_white_24dp_1x
        Me.btn_exit.Location = New System.Drawing.Point(1152, 0)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(50, 28)
        Me.btn_exit.TabIndex = 1
        Me.btn_exit.TabStop = False
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_minimize
        '
        Me.btn_minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_minimize.FlatAppearance.BorderSize = 0
        Me.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimize.ForeColor = System.Drawing.Color.DimGray
        Me.btn_minimize.Image = Global.projet_dietetique.My.Resources.Resources.ic_remove_white_24dp_1x
        Me.btn_minimize.Location = New System.Drawing.Point(1102, 0)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(50, 28)
        Me.btn_minimize.TabIndex = 0
        Me.btn_minimize.TabStop = False
        Me.btn_minimize.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_ajoutSucces)
        Me.Panel1.Controls.Add(Me.btn_annuler)
        Me.Panel1.Controls.Add(Me.btn_ajouter)
        Me.Panel1.Controls.Add(Me.lbl_pnl)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.pnl_recherches)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.pnl_6)
        Me.Panel1.Controls.Add(Me.dgv_produits)
        Me.Panel1.Controls.Add(Me.btnRechercher)
        Me.Panel1.Controls.Add(Me.btnReinitialiser)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1203, 947)
        Me.Panel1.TabIndex = 54
        '
        'lbl_ajoutSucces
        '
        Me.lbl_ajoutSucces.BackColor = System.Drawing.Color.Lime
        Me.lbl_ajoutSucces.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_ajoutSucces.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_ajoutSucces.Location = New System.Drawing.Point(3, 782)
        Me.lbl_ajoutSucces.Name = "lbl_ajoutSucces"
        Me.lbl_ajoutSucces.Size = New System.Drawing.Size(1196, 24)
        Me.lbl_ajoutSucces.TabIndex = 246
        Me.lbl_ajoutSucces.Text = "L'utilisateur a bien été ajouté."
        Me.lbl_ajoutSucces.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_ajoutSucces.Visible = False
        '
        'btn_annuler
        '
        Me.btn_annuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btn_annuler.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_annuler.FlatAppearance.BorderSize = 0
        Me.btn_annuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_annuler.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annuler.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_annuler.Location = New System.Drawing.Point(1102, 747)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(95, 32)
        Me.btn_annuler.TabIndex = 245
        Me.btn_annuler.Text = "Retour"
        Me.btn_annuler.UseVisualStyleBackColor = False
        '
        'btn_ajouter
        '
        Me.btn_ajouter.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_ajouter.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_ajouter.FlatAppearance.BorderSize = 0
        Me.btn_ajouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ajouter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajouter.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_ajouter.Location = New System.Drawing.Point(942, 747)
        Me.btn_ajouter.Name = "btn_ajouter"
        Me.btn_ajouter.Size = New System.Drawing.Size(154, 32)
        Me.btn_ajouter.TabIndex = 244
        Me.btn_ajouter.Text = "Ajouter"
        Me.btn_ajouter.UseVisualStyleBackColor = False
        '
        'lbl_pnl
        '
        Me.lbl_pnl.AutoSize = True
        Me.lbl_pnl.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_pnl.ForeColor = System.Drawing.Color.Black
        Me.lbl_pnl.Location = New System.Drawing.Point(11, 637)
        Me.lbl_pnl.Name = "lbl_pnl"
        Me.lbl_pnl.Size = New System.Drawing.Size(105, 15)
        Me.lbl_pnl.TabIndex = 243
        Me.lbl_pnl.Text = "Ajouter un produit"
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.lblE_emplac)
        Me.Panel6.Controls.Add(Me.lbE_quant)
        Me.Panel6.Controls.Add(Me.cbo_empl)
        Me.Panel6.Controls.Add(Me.nm_quant)
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Location = New System.Drawing.Point(4, 645)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1195, 94)
        Me.Panel6.TabIndex = 243
        '
        'lblE_emplac
        '
        Me.lblE_emplac.AutoSize = True
        Me.lblE_emplac.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblE_emplac.ForeColor = System.Drawing.Color.Firebrick
        Me.lblE_emplac.Location = New System.Drawing.Point(166, 65)
        Me.lblE_emplac.Name = "lblE_emplac"
        Me.lblE_emplac.Size = New System.Drawing.Size(160, 13)
        Me.lblE_emplac.TabIndex = 245
        Me.lblE_emplac.Text = "Sélectionnez un emplacement"
        Me.lblE_emplac.Visible = False
        '
        'lbE_quant
        '
        Me.lbE_quant.AutoSize = True
        Me.lbE_quant.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lbE_quant.ForeColor = System.Drawing.Color.Firebrick
        Me.lbE_quant.Location = New System.Drawing.Point(10, 64)
        Me.lbE_quant.Name = "lbE_quant"
        Me.lbE_quant.Size = New System.Drawing.Size(121, 13)
        Me.lbE_quant.TabIndex = 244
        Me.lbE_quant.Text = "Saisissez une quantité"
        Me.lbE_quant.Visible = False
        '
        'cbo_empl
        '
        Me.cbo_empl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_empl.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_empl.FormattingEnabled = True
        Me.cbo_empl.Location = New System.Drawing.Point(169, 39)
        Me.cbo_empl.Name = "cbo_empl"
        Me.cbo_empl.Size = New System.Drawing.Size(159, 23)
        Me.cbo_empl.TabIndex = 243
        '
        'nm_quant
        '
        Me.nm_quant.DecimalPlaces = 2
        Me.nm_quant.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nm_quant.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.nm_quant.Location = New System.Drawing.Point(13, 38)
        Me.nm_quant.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nm_quant.Name = "nm_quant"
        Me.nm_quant.Size = New System.Drawing.Size(109, 23)
        Me.nm_quant.TabIndex = 241
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(9, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 19)
        Me.Label12.TabIndex = 242
        Me.Label12.Text = "Quantité"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(165, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 19)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Emplacement"
        '
        'pnl_recherches
        '
        Me.pnl_recherches.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_recherches.Controls.Add(Me.Label11)
        Me.pnl_recherches.Controls.Add(Me.cbo_ordre)
        Me.pnl_recherches.Controls.Add(Me.cbo_trier_par)
        Me.pnl_recherches.Controls.Add(Me.Label1)
        Me.pnl_recherches.Controls.Add(Me.Panel2)
        Me.pnl_recherches.Controls.Add(Me.Label7)
        Me.pnl_recherches.Controls.Add(Me.txt_description_keyword)
        Me.pnl_recherches.Controls.Add(Me.cbo_description)
        Me.pnl_recherches.Controls.Add(Me.cbo_rech_categorie)
        Me.pnl_recherches.Controls.Add(Me.Label15)
        Me.pnl_recherches.Controls.Add(Me.Label8)
        Me.pnl_recherches.Controls.Add(Me.Panel4)
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
        Me.pnl_recherches.Location = New System.Drawing.Point(3, 38)
        Me.pnl_recherches.Name = "pnl_recherches"
        Me.pnl_recherches.Size = New System.Drawing.Size(1196, 179)
        Me.pnl_recherches.TabIndex = 58
        Me.pnl_recherches.TabStop = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(80, 153)
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
        Me.cbo_ordre.Location = New System.Drawing.Point(115, 14)
        Me.cbo_ordre.Name = "cbo_ordre"
        Me.cbo_ordre.Size = New System.Drawing.Size(203, 23)
        Me.cbo_ordre.TabIndex = 1
        '
        'cbo_trier_par
        '
        Me.cbo_trier_par.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_trier_par.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_trier_par.FormattingEnabled = True
        Me.cbo_trier_par.Items.AddRange(New Object() {"N° de produit (par défaut)", "Nom de produit", "Marque", "Catégorie", "Périssable (Oui/Non)", "Bio (Oui/Non)", "Description (Oui/Non)", "Allergènes (Oui/Non)"})
        Me.cbo_trier_par.Location = New System.Drawing.Point(324, 14)
        Me.cbo_trier_par.Name = "cbo_trier_par"
        Me.cbo_trier_par.Size = New System.Drawing.Size(186, 23)
        Me.cbo_trier_par.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(875, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Mots clés"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rdb_bio_tous)
        Me.Panel2.Controls.Add(Me.rdb_bio_oui)
        Me.Panel2.Controls.Add(Me.rdb_bio_non)
        Me.Panel2.Location = New System.Drawing.Point(112, 147)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(205, 27)
        Me.Panel2.TabIndex = 111
        '
        'rdb_bio_tous
        '
        Me.rdb_bio_tous.AutoSize = True
        Me.rdb_bio_tous.Checked = True
        Me.rdb_bio_tous.Location = New System.Drawing.Point(113, 7)
        Me.rdb_bio_tous.Name = "rdb_bio_tous"
        Me.rdb_bio_tous.Size = New System.Drawing.Size(49, 17)
        Me.rdb_bio_tous.TabIndex = 13
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
        Me.rdb_bio_oui.TabIndex = 11
        Me.rdb_bio_oui.Text = "Oui"
        Me.rdb_bio_oui.UseVisualStyleBackColor = True
        '
        'rdb_bio_non
        '
        Me.rdb_bio_non.AutoSize = True
        Me.rdb_bio_non.Location = New System.Drawing.Point(59, 7)
        Me.rdb_bio_non.Name = "rdb_bio_non"
        Me.rdb_bio_non.Size = New System.Drawing.Size(45, 17)
        Me.rdb_bio_non.TabIndex = 12
        Me.rdb_bio_non.Text = "Non"
        Me.rdb_bio_non.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Enabled = False
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(941, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(210, 29)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "S'il y a plusieurs mots clés, veuillez les séparer avec des points-virgules ( ; )" &
    ""
        '
        'txt_description_keyword
        '
        Me.txt_description_keyword.Enabled = False
        Me.txt_description_keyword.Location = New System.Drawing.Point(945, 39)
        Me.txt_description_keyword.Multiline = True
        Me.txt_description_keyword.Name = "txt_description_keyword"
        Me.txt_description_keyword.Size = New System.Drawing.Size(203, 42)
        Me.txt_description_keyword.TabIndex = 17
        '
        'cbo_description
        '
        Me.cbo_description.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_description.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_description.FormattingEnabled = True
        Me.cbo_description.Items.AddRange(New Object() {"Ne contient pas de description", "Contient une description (tous)", "Recherche par mot clé", "Ne s'applique pas"})
        Me.cbo_description.Location = New System.Drawing.Point(945, 12)
        Me.cbo_description.Name = "cbo_description"
        Me.cbo_description.Size = New System.Drawing.Size(203, 23)
        Me.cbo_description.TabIndex = 16
        '
        'cbo_rech_categorie
        '
        Me.cbo_rech_categorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_rech_categorie.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_rech_categorie.FormattingEnabled = True
        Me.cbo_rech_categorie.Items.AddRange(New Object() {"Tous"})
        Me.cbo_rech_categorie.Location = New System.Drawing.Point(115, 98)
        Me.cbo_rech_categorie.Name = "cbo_rech_categorie"
        Me.cbo_rech_categorie.Size = New System.Drawing.Size(164, 23)
        Me.cbo_rech_categorie.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(44, 98)
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
        Me.Label8.Location = New System.Drawing.Point(865, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 17)
        Me.Label8.TabIndex = 79
        Me.Label8.Text = "Description"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.rdb_perissable_tous)
        Me.Panel4.Controls.Add(Me.rdb_perissable_oui)
        Me.Panel4.Controls.Add(Me.rdb_perissable_non)
        Me.Panel4.Location = New System.Drawing.Point(112, 122)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(205, 25)
        Me.Panel4.TabIndex = 71
        '
        'rdb_perissable_tous
        '
        Me.rdb_perissable_tous.AutoSize = True
        Me.rdb_perissable_tous.Checked = True
        Me.rdb_perissable_tous.Location = New System.Drawing.Point(113, 7)
        Me.rdb_perissable_tous.Name = "rdb_perissable_tous"
        Me.rdb_perissable_tous.Size = New System.Drawing.Size(68, 17)
        Me.rdb_perissable_tous.TabIndex = 10
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
        Me.rdb_perissable_oui.TabIndex = 8
        Me.rdb_perissable_oui.Text = "Oui"
        Me.rdb_perissable_oui.UseVisualStyleBackColor = True
        '
        'rdb_perissable_non
        '
        Me.rdb_perissable_non.AutoSize = True
        Me.rdb_perissable_non.Location = New System.Drawing.Point(59, 7)
        Me.rdb_perissable_non.Name = "rdb_perissable_non"
        Me.rdb_perissable_non.Size = New System.Drawing.Size(45, 17)
        Me.rdb_perissable_non.TabIndex = 9
        Me.rdb_perissable_non.Text = "Non"
        Me.rdb_perissable_non.UseVisualStyleBackColor = True
        '
        'lbl_mots_cles
        '
        Me.lbl_mots_cles.AutoSize = True
        Me.lbl_mots_cles.Enabled = False
        Me.lbl_mots_cles.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mots_cles.ForeColor = System.Drawing.Color.Gray
        Me.lbl_mots_cles.Location = New System.Drawing.Point(570, 41)
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
        Me.Label19.Location = New System.Drawing.Point(42, 127)
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
        Me.Label6.Location = New System.Drawing.Point(51, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 17)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "Trier par"
        '
        'lbl_allergenes_desc
        '
        Me.lbl_allergenes_desc.Enabled = False
        Me.lbl_allergenes_desc.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_allergenes_desc.ForeColor = System.Drawing.Color.Gray
        Me.lbl_allergenes_desc.Location = New System.Drawing.Point(636, 84)
        Me.lbl_allergenes_desc.Name = "lbl_allergenes_desc"
        Me.lbl_allergenes_desc.Size = New System.Drawing.Size(210, 29)
        Me.lbl_allergenes_desc.TabIndex = 76
        Me.lbl_allergenes_desc.Text = "S'il y a plusieurs allergènes, veuillez les séparer avec des points-virgules ( ; " &
    ")"
        '
        'txt_allergenes_keyword
        '
        Me.txt_allergenes_keyword.Enabled = False
        Me.txt_allergenes_keyword.Location = New System.Drawing.Point(635, 39)
        Me.txt_allergenes_keyword.Multiline = True
        Me.txt_allergenes_keyword.Name = "txt_allergenes_keyword"
        Me.txt_allergenes_keyword.Size = New System.Drawing.Size(203, 42)
        Me.txt_allergenes_keyword.TabIndex = 15
        '
        'cbo_allergenes
        '
        Me.cbo_allergenes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_allergenes.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_allergenes.FormattingEnabled = True
        Me.cbo_allergenes.Items.AddRange(New Object() {"Ne contient pas d'allergènes", "Contient des allergènes", "Ne contient pas... (mot(s) clé(s))", "Contient... (mot(s) clé(s))", "Ne s'applique pas"})
        Me.cbo_allergenes.Location = New System.Drawing.Point(635, 12)
        Me.cbo_allergenes.Name = "cbo_allergenes"
        Me.cbo_allergenes.Size = New System.Drawing.Size(203, 23)
        Me.cbo_allergenes.TabIndex = 14
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(560, 15)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 17)
        Me.Label20.TabIndex = 73
        Me.Label20.Text = "Allergènes"
        '
        'txt_rech_marque
        '
        Me.txt_rech_marque.Location = New System.Drawing.Point(324, 70)
        Me.txt_rech_marque.Multiline = True
        Me.txt_rech_marque.Name = "txt_rech_marque"
        Me.txt_rech_marque.Size = New System.Drawing.Size(186, 23)
        Me.txt_rech_marque.TabIndex = 6
        '
        'cbo_marque_contient
        '
        Me.cbo_marque_contient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_marque_contient.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_marque_contient.FormattingEnabled = True
        Me.cbo_marque_contient.Items.AddRange(New Object() {"Contient", "Commence par", "Ne s'applique pas"})
        Me.cbo_marque_contient.Location = New System.Drawing.Point(115, 69)
        Me.cbo_marque_contient.Name = "cbo_marque_contient"
        Me.cbo_marque_contient.Size = New System.Drawing.Size(203, 23)
        Me.cbo_marque_contient.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(55, 69)
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
        Me.cbo_nom_contient.Location = New System.Drawing.Point(115, 42)
        Me.cbo_nom_contient.Name = "cbo_nom_contient"
        Me.cbo_nom_contient.Size = New System.Drawing.Size(203, 23)
        Me.cbo_nom_contient.TabIndex = 3
        '
        'txt_rech_nom
        '
        Me.txt_rech_nom.Location = New System.Drawing.Point(324, 43)
        Me.txt_rech_nom.Multiline = True
        Me.txt_rech_nom.Name = "txt_rech_nom"
        Me.txt_rech_nom.Size = New System.Drawing.Size(186, 23)
        Me.txt_rech_nom.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 17)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Nom du produit"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Location = New System.Drawing.Point(-1, 265)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1204, 27)
        Me.Panel5.TabIndex = 57
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(731, 4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(443, 17)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "*   Double cliquez sur un produit pour obtenir des détails supplémentaires"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(11, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Liste de produits"
        '
        'pnl_6
        '
        Me.pnl_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.pnl_6.Controls.Add(Me.Label2)
        Me.pnl_6.Location = New System.Drawing.Point(-1, 5)
        Me.pnl_6.Name = "pnl_6"
        Me.pnl_6.Size = New System.Drawing.Size(1204, 27)
        Me.pnl_6.TabIndex = 56
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(8, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 21)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Rechercher un produit"
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_produits.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_produits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_produits.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.Column16, Me.Column17, Me.Column18, Me.Column19, Me.Column20})
        Me.dgv_produits.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgv_produits.Location = New System.Drawing.Point(4, 298)
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
        Me.dgv_produits.RowHeadersWidth = 35
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_produits.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_produits.RowTemplate.Height = 30
        Me.dgv_produits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_produits.Size = New System.Drawing.Size(1195, 338)
        Me.dgv_produits.TabIndex = 55
        Me.dgv_produits.TabStop = False
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
        Me.btnRechercher.Location = New System.Drawing.Point(942, 223)
        Me.btnRechercher.Name = "btnRechercher"
        Me.btnRechercher.Size = New System.Drawing.Size(154, 32)
        Me.btnRechercher.TabIndex = 18
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
        Me.btnReinitialiser.Location = New System.Drawing.Point(1102, 223)
        Me.btnReinitialiser.Name = "btnReinitialiser"
        Me.btnReinitialiser.Size = New System.Drawing.Size(95, 32)
        Me.btnReinitialiser.TabIndex = 19
        Me.btnReinitialiser.Text = "Réinitialiser"
        Me.btnReinitialiser.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Panel1)
        Me.Panel7.Location = New System.Drawing.Point(1, 30)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1202, 812)
        Me.Panel7.TabIndex = 59
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.Panel7)
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1204, 841)
        Me.Panel8.TabIndex = 59
        '
        'timer_succes
        '
        Me.timer_succes.Interval = 1
        '
        'Column12
        '
        Me.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column12.HeaderText = "No. Produit"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 99
        '
        'Column13
        '
        Me.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column13.HeaderText = "Nom"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Width = 62
        '
        'Column14
        '
        Me.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column14.HeaderText = "Marque"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Width = 79
        '
        'Column15
        '
        Me.Column15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column15.HeaderText = "Catégorie"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.Width = 92
        '
        'Column16
        '
        Me.Column16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column16.HeaderText = "Format"
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        Me.Column16.Width = 75
        '
        'Column17
        '
        Me.Column17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column17.HeaderText = "Périssable"
        Me.Column17.Name = "Column17"
        Me.Column17.ReadOnly = True
        '
        'Column18
        '
        Me.Column18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column18.HeaderText = "Bio"
        Me.Column18.Name = "Column18"
        Me.Column18.ReadOnly = True
        '
        'Column19
        '
        Me.Column19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column19.HeaderText = "Description"
        Me.Column19.Name = "Column19"
        Me.Column19.ReadOnly = True
        '
        'Column20
        '
        Me.Column20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column20.HeaderText = "Allergènes"
        Me.Column20.Name = "Column20"
        Me.Column20.ReadOnly = True
        '
        'frm_produit_inventaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1204, 841)
        Me.Controls.Add(Me.pnl_navigation)
        Me.Controls.Add(Me.Panel8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_produit_inventaire"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frm_produit_inventaire"
        Me.pnl_navigation.ResumeLayout(False)
        Me.pnl_navigation.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.nm_quant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_recherches.ResumeLayout(False)
        Me.pnl_recherches.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.pnl_6.ResumeLayout(False)
        Me.pnl_6.PerformLayout()
        CType(Me.dgv_produits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_navigation As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbl_titre As Label
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_minimize As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnl_recherches As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents cbo_ordre As ComboBox
    Friend WithEvents cbo_trier_par As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents rdb_bio_tous As RadioButton
    Friend WithEvents rdb_bio_oui As RadioButton
    Friend WithEvents rdb_bio_non As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_description_keyword As TextBox
    Friend WithEvents cbo_description As ComboBox
    Friend WithEvents cbo_rech_categorie As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents rdb_perissable_tous As RadioButton
    Friend WithEvents rdb_perissable_oui As RadioButton
    Friend WithEvents rdb_perissable_non As RadioButton
    Friend WithEvents lbl_mots_cles As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_allergenes_desc As Label
    Friend WithEvents txt_allergenes_keyword As TextBox
    Friend WithEvents cbo_allergenes As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txt_rech_marque As TextBox
    Friend WithEvents cbo_marque_contient As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbo_nom_contient As ComboBox
    Friend WithEvents txt_rech_nom As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents pnl_6 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dgv_produits As DataGridView
    Friend WithEvents btnRechercher As Button
    Friend WithEvents btnReinitialiser As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_pnl As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents nm_quant As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents cbo_empl As ComboBox
    Friend WithEvents lblE_emplac As Label
    Friend WithEvents lbE_quant As Label
    Friend WithEvents btn_annuler As Button
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents lbl_ajoutSucces As Label
    Friend WithEvents timer_succes As Timer
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents Column19 As DataGridViewTextBoxColumn
    Friend WithEvents Column20 As DataGridViewTextBoxColumn
End Class
