<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usr_ajout_produit
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.listeAllergene = New System.Windows.Forms.CheckedListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chk_tvq = New System.Windows.Forms.CheckBox()
        Me.chk_tps = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.nm_quantite = New System.Windows.Forms.NumericUpDown()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.txt_remarque = New System.Windows.Forms.RichTextBox()
        Me.lbl_erreur_bio = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.cbo_bio = New System.Windows.Forms.ComboBox()
        Me.txt_nom_produit = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txt_marque = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lbl_mesure = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lbl_erreur_perissable = New System.Windows.Forms.Label()
        Me.cbo_categories = New System.Windows.Forms.ComboBox()
        Me.cms_unites_mesure = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbo_perissable = New System.Windows.Forms.ComboBox()
        Me.pnl_ajout_mod = New System.Windows.Forms.Panel()
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
        Me.txt_description = New System.Windows.Forms.RichTextBox()
        Me.lbl_erreur_numero = New System.Windows.Forms.Label()
        Me.btn_valider = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btn_mesure = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lbl_erreur_categorie = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.nm_quantite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_ajout_mod.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'listeAllergene
        '
        Me.listeAllergene.FormattingEnabled = True
        Me.listeAllergene.Location = New System.Drawing.Point(767, 57)
        Me.listeAllergene.Name = "listeAllergene"
        Me.listeAllergene.Size = New System.Drawing.Size(359, 244)
        Me.listeAllergene.TabIndex = 199
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(767, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(359, 28)
        Me.Panel1.TabIndex = 172
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(11, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 21)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Allergènes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(135, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 198
        Me.Label1.Text = "Label1"
        '
        'chk_tvq
        '
        Me.chk_tvq.AutoSize = True
        Me.chk_tvq.Location = New System.Drawing.Point(378, 259)
        Me.chk_tvq.Name = "chk_tvq"
        Me.chk_tvq.Size = New System.Drawing.Size(48, 17)
        Me.chk_tvq.TabIndex = 197
        Me.chk_tvq.Text = "TVQ"
        Me.chk_tvq.UseVisualStyleBackColor = True
        '
        'chk_tps
        '
        Me.chk_tps.AutoSize = True
        Me.chk_tps.Location = New System.Drawing.Point(378, 236)
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
        Me.Panel3.Location = New System.Drawing.Point(363, 200)
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
        Me.nm_quantite.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nm_quantite.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.nm_quantite.Location = New System.Drawing.Point(451, 141)
        Me.nm_quantite.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nm_quantite.Name = "nm_quantite"
        Me.nm_quantite.Size = New System.Drawing.Size(99, 23)
        Me.nm_quantite.TabIndex = 155
        '
        'btn_annuler
        '
        Me.btn_annuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_annuler.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_annuler.FlatAppearance.BorderSize = 0
        Me.btn_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_annuler.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annuler.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_annuler.Location = New System.Drawing.Point(809, 451)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(154, 32)
        Me.btn_annuler.TabIndex = 194
        Me.btn_annuler.Text = "Annuler"
        Me.btn_annuler.UseVisualStyleBackColor = False
        '
        'txt_remarque
        '
        Me.txt_remarque.Location = New System.Drawing.Point(343, 383)
        Me.txt_remarque.MaxLength = 200
        Me.txt_remarque.Name = "txt_remarque"
        Me.txt_remarque.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txt_remarque.Size = New System.Drawing.Size(254, 60)
        Me.txt_remarque.TabIndex = 157
        Me.txt_remarque.Text = ""
        '
        'lbl_erreur_bio
        '
        Me.lbl_erreur_bio.AutoSize = True
        Me.lbl_erreur_bio.ForeColor = System.Drawing.Color.Red
        Me.lbl_erreur_bio.Location = New System.Drawing.Point(105, 286)
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
        Me.Label32.Location = New System.Drawing.Point(36, 54)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(66, 13)
        Me.Label32.TabIndex = 145
        Me.Label32.Text = "No. Produit"
        '
        'cbo_bio
        '
        Me.cbo_bio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_bio.FormattingEnabled = True
        Me.cbo_bio.Items.AddRange(New Object() {"Oui", "Non"})
        Me.cbo_bio.Location = New System.Drawing.Point(108, 262)
        Me.cbo_bio.Name = "cbo_bio"
        Me.cbo_bio.Size = New System.Drawing.Size(170, 21)
        Me.cbo_bio.TabIndex = 151
        '
        'txt_nom_produit
        '
        Me.txt_nom_produit.Location = New System.Drawing.Point(109, 90)
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
        Me.Label10.Location = New System.Drawing.Point(78, 265)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 13)
        Me.Label10.TabIndex = 189
        Me.Label10.Text = "Bio"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(13, 95)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(90, 13)
        Me.Label31.TabIndex = 147
        Me.Label31.Text = "Nom du produit"
        '
        'txt_marque
        '
        Me.txt_marque.Location = New System.Drawing.Point(109, 135)
        Me.txt_marque.MaxLength = 50
        Me.txt_marque.Multiline = True
        Me.txt_marque.Name = "txt_marque"
        Me.txt_marque.Size = New System.Drawing.Size(222, 21)
        Me.txt_marque.TabIndex = 148
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(56, 138)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(47, 13)
        Me.Label30.TabIndex = 149
        Me.Label30.Text = "Marque"
        '
        'lbl_mesure
        '
        Me.lbl_mesure.AutoSize = True
        Me.lbl_mesure.Location = New System.Drawing.Point(452, 103)
        Me.lbl_mesure.Name = "lbl_mesure"
        Me.lbl_mesure.Size = New System.Drawing.Size(178, 13)
        Me.lbl_mesure.TabIndex = 186
        Me.lbl_mesure.Text = "--- choisissez une unité de mesure ---"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(46, 179)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(57, 13)
        Me.Label29.TabIndex = 150
        Me.Label29.Text = "Catégorie"
        '
        'lbl_erreur_perissable
        '
        Me.lbl_erreur_perissable.AutoSize = True
        Me.lbl_erreur_perissable.ForeColor = System.Drawing.Color.Red
        Me.lbl_erreur_perissable.Location = New System.Drawing.Point(106, 244)
        Me.lbl_erreur_perissable.Name = "lbl_erreur_perissable"
        Me.lbl_erreur_perissable.Size = New System.Drawing.Size(88, 13)
        Me.lbl_erreur_perissable.TabIndex = 185
        Me.lbl_erreur_perissable.Text = "Message d'erreur"
        Me.lbl_erreur_perissable.Visible = False
        '
        'cbo_categories
        '
        Me.cbo_categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_categories.FormattingEnabled = True
        Me.cbo_categories.Location = New System.Drawing.Point(109, 176)
        Me.cbo_categories.Name = "cbo_categories"
        Me.cbo_categories.Size = New System.Drawing.Size(222, 21)
        Me.cbo_categories.TabIndex = 149
        '
        'cms_unites_mesure
        '
        Me.cms_unites_mesure.Name = "cms_unites_mesure"
        Me.cms_unites_mesure.Size = New System.Drawing.Size(61, 4)
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
        'cbo_perissable
        '
        Me.cbo_perissable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_perissable.FormattingEnabled = True
        Me.cbo_perissable.Items.AddRange(New Object() {"Oui", "Non"})
        Me.cbo_perissable.Location = New System.Drawing.Point(109, 220)
        Me.cbo_perissable.Name = "cbo_perissable"
        Me.cbo_perissable.Size = New System.Drawing.Size(170, 21)
        Me.cbo_perissable.TabIndex = 150
        '
        'pnl_ajout_mod
        '
        Me.pnl_ajout_mod.AutoScroll = True
        Me.pnl_ajout_mod.Controls.Add(Me.listeAllergene)
        Me.pnl_ajout_mod.Controls.Add(Me.Panel1)
        Me.pnl_ajout_mod.Controls.Add(Me.Label1)
        Me.pnl_ajout_mod.Controls.Add(Me.chk_tvq)
        Me.pnl_ajout_mod.Controls.Add(Me.chk_tps)
        Me.pnl_ajout_mod.Controls.Add(Me.Panel3)
        Me.pnl_ajout_mod.Controls.Add(Me.nm_quantite)
        Me.pnl_ajout_mod.Controls.Add(Me.btn_annuler)
        Me.pnl_ajout_mod.Controls.Add(Me.txt_remarque)
        Me.pnl_ajout_mod.Controls.Add(Me.lbl_erreur_bio)
        Me.pnl_ajout_mod.Controls.Add(Me.Label32)
        Me.pnl_ajout_mod.Controls.Add(Me.cbo_bio)
        Me.pnl_ajout_mod.Controls.Add(Me.txt_nom_produit)
        Me.pnl_ajout_mod.Controls.Add(Me.Label10)
        Me.pnl_ajout_mod.Controls.Add(Me.Label31)
        Me.pnl_ajout_mod.Controls.Add(Me.txt_marque)
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
        Me.pnl_ajout_mod.Controls.Add(Me.txt_description)
        Me.pnl_ajout_mod.Controls.Add(Me.lbl_erreur_numero)
        Me.pnl_ajout_mod.Controls.Add(Me.btn_valider)
        Me.pnl_ajout_mod.Controls.Add(Me.Panel7)
        Me.pnl_ajout_mod.Controls.Add(Me.btn_mesure)
        Me.pnl_ajout_mod.Controls.Add(Me.Panel8)
        Me.pnl_ajout_mod.Controls.Add(Me.lbl_erreur_categorie)
        Me.pnl_ajout_mod.Controls.Add(Me.Panel9)
        Me.pnl_ajout_mod.Location = New System.Drawing.Point(8, 8)
        Me.pnl_ajout_mod.Name = "pnl_ajout_mod"
        Me.pnl_ajout_mod.Size = New System.Drawing.Size(1170, 549)
        Me.pnl_ajout_mod.TabIndex = 128
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(400, 61)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(43, 13)
        Me.Label28.TabIndex = 152
        Me.Label28.Text = "Format"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(46, 223)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(58, 13)
        Me.Label23.TabIndex = 183
        Me.Label23.Text = "Périssable"
        '
        'cbo_format
        '
        Me.cbo_format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_format.FormattingEnabled = True
        Me.cbo_format.Location = New System.Drawing.Point(450, 57)
        Me.cbo_format.Name = "cbo_format"
        Me.cbo_format.Size = New System.Drawing.Size(141, 21)
        Me.cbo_format.TabIndex = 153
        '
        'lbl_erreur_quantite
        '
        Me.lbl_erreur_quantite.AutoSize = True
        Me.lbl_erreur_quantite.ForeColor = System.Drawing.Color.Red
        Me.lbl_erreur_quantite.Location = New System.Drawing.Point(449, 165)
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
        Me.Label27.Location = New System.Drawing.Point(355, 103)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(91, 13)
        Me.Label27.TabIndex = 154
        Me.Label27.Text = "Unité de mesure"
        '
        'lbl_erreur_mesure
        '
        Me.lbl_erreur_mesure.AutoSize = True
        Me.lbl_erreur_mesure.ForeColor = System.Drawing.Color.Red
        Me.lbl_erreur_mesure.Location = New System.Drawing.Point(449, 120)
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
        Me.Label26.Location = New System.Drawing.Point(393, 144)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(52, 13)
        Me.Label26.TabIndex = 155
        Me.Label26.Text = "Quantité"
        '
        'lbl_erreur_format
        '
        Me.lbl_erreur_format.AutoSize = True
        Me.lbl_erreur_format.ForeColor = System.Drawing.Color.Red
        Me.lbl_erreur_format.Location = New System.Drawing.Point(447, 80)
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
        Me.lbl_erreur_marque.Location = New System.Drawing.Point(106, 159)
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
        Me.Label25.Location = New System.Drawing.Point(38, 367)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(66, 13)
        Me.Label25.TabIndex = 157
        Me.Label25.Text = "Description"
        '
        'lbl_erreur_nom_produit
        '
        Me.lbl_erreur_nom_produit.AutoSize = True
        Me.lbl_erreur_nom_produit.ForeColor = System.Drawing.Color.Red
        Me.lbl_erreur_nom_produit.Location = New System.Drawing.Point(106, 114)
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
        Me.Label24.Location = New System.Drawing.Point(340, 367)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(59, 13)
        Me.Label24.TabIndex = 158
        Me.Label24.Text = "Remarque"
        '
        'txt_description
        '
        Me.txt_description.Location = New System.Drawing.Point(41, 383)
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
        Me.lbl_erreur_numero.Location = New System.Drawing.Point(108, 73)
        Me.lbl_erreur_numero.Name = "lbl_erreur_numero"
        Me.lbl_erreur_numero.Size = New System.Drawing.Size(88, 13)
        Me.lbl_erreur_numero.TabIndex = 174
        Me.lbl_erreur_numero.Text = "Message d'erreur"
        Me.lbl_erreur_numero.Visible = False
        '
        'btn_valider
        '
        Me.btn_valider.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_valider.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_valider.FlatAppearance.BorderSize = 0
        Me.btn_valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_valider.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_valider.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_valider.Location = New System.Drawing.Point(981, 451)
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
        Me.Panel7.Location = New System.Drawing.Point(38, 311)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1113, 28)
        Me.Panel7.TabIndex = 172
        '
        'btn_mesure
        '
        Me.btn_mesure.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_mesure.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mesure.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_mesure.Location = New System.Drawing.Point(632, 96)
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
        Me.Panel8.Location = New System.Drawing.Point(363, 21)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(359, 28)
        Me.Panel8.TabIndex = 171
        '
        'lbl_erreur_categorie
        '
        Me.lbl_erreur_categorie.AutoSize = True
        Me.lbl_erreur_categorie.ForeColor = System.Drawing.Color.Red
        Me.lbl_erreur_categorie.Location = New System.Drawing.Point(106, 200)
        Me.lbl_erreur_categorie.Name = "lbl_erreur_categorie"
        Me.lbl_erreur_categorie.Size = New System.Drawing.Size(88, 13)
        Me.lbl_erreur_categorie.TabIndex = 179
        Me.lbl_erreur_categorie.Text = "Message d'erreur"
        Me.lbl_erreur_categorie.Visible = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Label14)
        Me.Panel9.Location = New System.Drawing.Point(16, 21)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(331, 28)
        Me.Panel9.TabIndex = 170
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(10, 3)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 21)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Identifiants"
        '
        'usr_ajout_produit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnl_ajout_mod)
        Me.Name = "usr_ajout_produit"
        Me.Size = New System.Drawing.Size(1170, 549)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.nm_quantite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_ajout_mod.ResumeLayout(False)
        Me.pnl_ajout_mod.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents listeAllergene As CheckedListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents chk_tvq As CheckBox
    Friend WithEvents chk_tps As CheckBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label34 As Label
    Friend WithEvents nm_quantite As NumericUpDown
    Friend WithEvents btn_annuler As Button
    Friend WithEvents txt_remarque As RichTextBox
    Friend WithEvents lbl_erreur_bio As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents cbo_bio As ComboBox
    Friend WithEvents txt_nom_produit As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents txt_marque As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents lbl_mesure As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents lbl_erreur_perissable As Label
    Friend WithEvents cbo_categories As ComboBox
    Friend WithEvents cms_unites_mesure As ContextMenuStrip
    Friend WithEvents Label16 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbo_perissable As ComboBox
    Friend WithEvents pnl_ajout_mod As Panel
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
    Friend WithEvents txt_description As RichTextBox
    Friend WithEvents lbl_erreur_numero As Label
    Friend WithEvents btn_valider As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btn_mesure As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lbl_erreur_categorie As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label14 As Label
End Class
