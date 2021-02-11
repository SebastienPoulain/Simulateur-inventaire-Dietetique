<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usr_emplacements
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_mode = New System.Windows.Forms.Label()
        Me.btnReinitialiser = New System.Windows.Forms.Button()
        Me.pnl_recherches = New System.Windows.Forms.Panel()
        Me.cbo_trier_activite = New System.Windows.Forms.ComboBox()
        Me.cbo_ordre = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbo_nom_contient = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_rech_nom = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgv_emplacements = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_activer = New System.Windows.Forms.Button()
        Me.btn_desactiver = New System.Windows.Forms.Button()
        Me.lbl_ajoutSucces = New System.Windows.Forms.Label()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.btn_modifier = New System.Windows.Forms.Button()
        Me.btn_ajouter = New System.Windows.Forms.Button()
        Me.pnl_controlGrid = New System.Windows.Forms.Panel()
        Me.txt_remarque = New System.Windows.Forms.TextBox()
        Me.lb_categories = New System.Windows.Forms.Label()
        Me.txt_nom_emplacement = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_erreur_nom = New System.Windows.Forms.Label()
        Me.timer_succes = New System.Windows.Forms.Timer(Me.components)
        Me.Panel5.SuspendLayout()
        Me.pnl_recherches.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_emplacements, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.pnl_controlGrid.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel5.Controls.Add(Me.lbl_mode)
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1188, 35)
        Me.Panel5.TabIndex = 145
        '
        'lbl_mode
        '
        Me.lbl_mode.AutoSize = True
        Me.lbl_mode.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lbl_mode.ForeColor = System.Drawing.Color.White
        Me.lbl_mode.Location = New System.Drawing.Point(11, 3)
        Me.lbl_mode.Name = "lbl_mode"
        Me.lbl_mode.Size = New System.Drawing.Size(127, 25)
        Me.lbl_mode.TabIndex = 9
        Me.lbl_mode.Text = "Emplacements"
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
        Me.btnReinitialiser.Location = New System.Drawing.Point(1013, 177)
        Me.btnReinitialiser.Name = "btnReinitialiser"
        Me.btnReinitialiser.Size = New System.Drawing.Size(154, 32)
        Me.btnReinitialiser.TabIndex = 147
        Me.btnReinitialiser.Text = "Réinitialiser"
        Me.btnReinitialiser.UseVisualStyleBackColor = False
        '
        'pnl_recherches
        '
        Me.pnl_recherches.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_recherches.Controls.Add(Me.cbo_trier_activite)
        Me.pnl_recherches.Controls.Add(Me.cbo_ordre)
        Me.pnl_recherches.Controls.Add(Me.Label6)
        Me.pnl_recherches.Controls.Add(Me.cbo_nom_contient)
        Me.pnl_recherches.Controls.Add(Me.Label2)
        Me.pnl_recherches.Controls.Add(Me.txt_rech_nom)
        Me.pnl_recherches.Location = New System.Drawing.Point(3, 85)
        Me.pnl_recherches.Name = "pnl_recherches"
        Me.pnl_recherches.Size = New System.Drawing.Size(1164, 86)
        Me.pnl_recherches.TabIndex = 149
        '
        'cbo_trier_activite
        '
        Me.cbo_trier_activite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_trier_activite.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_trier_activite.FormattingEnabled = True
        Me.cbo_trier_activite.Items.AddRange(New Object() {"Actif", "Inactif", "Tous"})
        Me.cbo_trier_activite.Location = New System.Drawing.Point(370, 15)
        Me.cbo_trier_activite.Name = "cbo_trier_activite"
        Me.cbo_trier_activite.Size = New System.Drawing.Size(212, 23)
        Me.cbo_trier_activite.TabIndex = 2
        '
        'cbo_ordre
        '
        Me.cbo_ordre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_ordre.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_ordre.FormattingEnabled = True
        Me.cbo_ordre.Items.AddRange(New Object() {"Ordre croissant", "Ordre décroissant"})
        Me.cbo_ordre.Location = New System.Drawing.Point(147, 15)
        Me.cbo_ordre.Name = "cbo_ordre"
        Me.cbo_ordre.Size = New System.Drawing.Size(211, 23)
        Me.cbo_ordre.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(83, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 17)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "Trier par"
        '
        'cbo_nom_contient
        '
        Me.cbo_nom_contient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_nom_contient.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_nom_contient.FormattingEnabled = True
        Me.cbo_nom_contient.Items.AddRange(New Object() {"Contient", "Commence par", "Ne s'applique pas"})
        Me.cbo_nom_contient.Location = New System.Drawing.Point(147, 43)
        Me.cbo_nom_contient.Name = "cbo_nom_contient"
        Me.cbo_nom_contient.Size = New System.Drawing.Size(211, 23)
        Me.cbo_nom_contient.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(11, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 17)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Nom d'emplacement"
        '
        'txt_rech_nom
        '
        Me.txt_rech_nom.Location = New System.Drawing.Point(370, 43)
        Me.txt_rech_nom.MaxLength = 30
        Me.txt_rech_nom.Multiline = True
        Me.txt_rech_nom.Name = "txt_rech_nom"
        Me.txt_rech_nom.Size = New System.Drawing.Size(212, 23)
        Me.txt_rech_nom.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(0, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1188, 28)
        Me.Panel1.TabIndex = 148
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(11, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(226, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Recherche d'emplacements"
        '
        'dgv_emplacements
        '
        Me.dgv_emplacements.AllowUserToAddRows = False
        Me.dgv_emplacements.AllowUserToDeleteRows = False
        Me.dgv_emplacements.AllowUserToResizeColumns = False
        Me.dgv_emplacements.AllowUserToResizeRows = False
        Me.dgv_emplacements.BackgroundColor = System.Drawing.Color.White
        Me.dgv_emplacements.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_emplacements.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_emplacements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_emplacements.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column2})
        Me.dgv_emplacements.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgv_emplacements.Location = New System.Drawing.Point(3, 251)
        Me.dgv_emplacements.Name = "dgv_emplacements"
        Me.dgv_emplacements.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_emplacements.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_emplacements.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_emplacements.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_emplacements.RowTemplate.Height = 25
        Me.dgv_emplacements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_emplacements.Size = New System.Drawing.Size(1182, 396)
        Me.dgv_emplacements.TabIndex = 152
        Me.dgv_emplacements.TabStop = False
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column4.HeaderText = "Nom"
        Me.Column4.MaxInputLength = 30
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 590
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Remarque"
        Me.Column2.MaxInputLength = 255
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 217)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1188, 28)
        Me.Panel2.TabIndex = 151
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(11, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Liste des emplacements"
        '
        'btn_activer
        '
        Me.btn_activer.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_activer.Enabled = False
        Me.btn_activer.FlatAppearance.BorderSize = 0
        Me.btn_activer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_activer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_activer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_activer.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_activer.Location = New System.Drawing.Point(990, 739)
        Me.btn_activer.Name = "btn_activer"
        Me.btn_activer.Size = New System.Drawing.Size(95, 32)
        Me.btn_activer.TabIndex = 161
        Me.btn_activer.Text = "Activer"
        Me.btn_activer.UseVisualStyleBackColor = False
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
        Me.btn_desactiver.Location = New System.Drawing.Point(1091, 739)
        Me.btn_desactiver.Name = "btn_desactiver"
        Me.btn_desactiver.Size = New System.Drawing.Size(95, 32)
        Me.btn_desactiver.TabIndex = 162
        Me.btn_desactiver.Text = "Désactiver"
        Me.btn_desactiver.UseVisualStyleBackColor = False
        '
        'lbl_ajoutSucces
        '
        Me.lbl_ajoutSucces.BackColor = System.Drawing.Color.Lime
        Me.lbl_ajoutSucces.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_ajoutSucces.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_ajoutSucces.Location = New System.Drawing.Point(-1, 775)
        Me.lbl_ajoutSucces.Name = "lbl_ajoutSucces"
        Me.lbl_ajoutSucces.Size = New System.Drawing.Size(1190, 24)
        Me.lbl_ajoutSucces.TabIndex = 164
        Me.lbl_ajoutSucces.Text = "L'emplacement a bien été ajouté."
        Me.lbl_ajoutSucces.Visible = False
        '
        'btn_annuler
        '
        Me.btn_annuler.BackColor = System.Drawing.Color.DimGray
        Me.btn_annuler.Enabled = False
        Me.btn_annuler.FlatAppearance.BorderSize = 0
        Me.btn_annuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_annuler.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annuler.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_annuler.Location = New System.Drawing.Point(381, 739)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(184, 32)
        Me.btn_annuler.TabIndex = 160
        Me.btn_annuler.Text = "Annuler"
        Me.btn_annuler.UseVisualStyleBackColor = False
        '
        'btn_modifier
        '
        Me.btn_modifier.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_modifier.FlatAppearance.BorderSize = 0
        Me.btn_modifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_modifier.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modifier.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_modifier.Location = New System.Drawing.Point(191, 739)
        Me.btn_modifier.Name = "btn_modifier"
        Me.btn_modifier.Size = New System.Drawing.Size(184, 32)
        Me.btn_modifier.TabIndex = 159
        Me.btn_modifier.Text = "Modifier"
        Me.btn_modifier.UseVisualStyleBackColor = False
        '
        'btn_ajouter
        '
        Me.btn_ajouter.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_ajouter.FlatAppearance.BorderSize = 0
        Me.btn_ajouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ajouter.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajouter.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_ajouter.Location = New System.Drawing.Point(1, 739)
        Me.btn_ajouter.Name = "btn_ajouter"
        Me.btn_ajouter.Size = New System.Drawing.Size(184, 32)
        Me.btn_ajouter.TabIndex = 158
        Me.btn_ajouter.Text = "Ajouter"
        Me.btn_ajouter.UseVisualStyleBackColor = False
        '
        'pnl_controlGrid
        '
        Me.pnl_controlGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_controlGrid.Controls.Add(Me.txt_remarque)
        Me.pnl_controlGrid.Controls.Add(Me.lb_categories)
        Me.pnl_controlGrid.Controls.Add(Me.txt_nom_emplacement)
        Me.pnl_controlGrid.Controls.Add(Me.Label8)
        Me.pnl_controlGrid.Controls.Add(Me.lbl_erreur_nom)
        Me.pnl_controlGrid.Enabled = False
        Me.pnl_controlGrid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnl_controlGrid.Location = New System.Drawing.Point(1, 648)
        Me.pnl_controlGrid.Name = "pnl_controlGrid"
        Me.pnl_controlGrid.Size = New System.Drawing.Size(1185, 85)
        Me.pnl_controlGrid.TabIndex = 163
        '
        'txt_remarque
        '
        Me.txt_remarque.Location = New System.Drawing.Point(295, 21)
        Me.txt_remarque.MaxLength = 255
        Me.txt_remarque.Multiline = True
        Me.txt_remarque.Name = "txt_remarque"
        Me.txt_remarque.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_remarque.Size = New System.Drawing.Size(277, 46)
        Me.txt_remarque.TabIndex = 7
        '
        'lb_categories
        '
        Me.lb_categories.AutoSize = True
        Me.lb_categories.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lb_categories.ForeColor = System.Drawing.Color.Black
        Me.lb_categories.Location = New System.Drawing.Point(291, -1)
        Me.lb_categories.Name = "lb_categories"
        Me.lb_categories.Size = New System.Drawing.Size(71, 19)
        Me.lb_categories.TabIndex = 32
        Me.lb_categories.Text = "Remarque"
        '
        'txt_nom_emplacement
        '
        Me.txt_nom_emplacement.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nom_emplacement.Location = New System.Drawing.Point(29, 34)
        Me.txt_nom_emplacement.MaxLength = 30
        Me.txt_nom_emplacement.Name = "txt_nom_emplacement"
        Me.txt_nom_emplacement.Size = New System.Drawing.Size(199, 22)
        Me.txt_nom_emplacement.TabIndex = 6
        Me.txt_nom_emplacement.Tag = "3"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(28, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 19)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Nom de l'emplacement"
        '
        'lbl_erreur_nom
        '
        Me.lbl_erreur_nom.AutoSize = True
        Me.lbl_erreur_nom.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lbl_erreur_nom.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_erreur_nom.Location = New System.Drawing.Point(29, 56)
        Me.lbl_erreur_nom.Name = "lbl_erreur_nom"
        Me.lbl_erreur_nom.Size = New System.Drawing.Size(94, 13)
        Me.lbl_erreur_nom.TabIndex = 25
        Me.lbl_erreur_nom.Text = "Saisissez un nom"
        Me.lbl_erreur_nom.Visible = False
        '
        'timer_succes
        '
        Me.timer_succes.Interval = 1
        '
        'usr_emplacements
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_activer)
        Me.Controls.Add(Me.btn_desactiver)
        Me.Controls.Add(Me.lbl_ajoutSucces)
        Me.Controls.Add(Me.btn_annuler)
        Me.Controls.Add(Me.btn_modifier)
        Me.Controls.Add(Me.btn_ajouter)
        Me.Controls.Add(Me.pnl_controlGrid)
        Me.Controls.Add(Me.dgv_emplacements)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnReinitialiser)
        Me.Controls.Add(Me.pnl_recherches)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.Name = "usr_emplacements"
        Me.Size = New System.Drawing.Size(1188, 795)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.pnl_recherches.ResumeLayout(False)
        Me.pnl_recherches.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_emplacements, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnl_controlGrid.ResumeLayout(False)
        Me.pnl_controlGrid.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_mode As Label
    Friend WithEvents btnReinitialiser As Button
    Friend WithEvents pnl_recherches As Panel
    Friend WithEvents cbo_trier_activite As ComboBox
    Friend WithEvents cbo_ordre As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbo_nom_contient As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_rech_nom As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents dgv_emplacements As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents btn_activer As Button
    Friend WithEvents btn_desactiver As Button
    Friend WithEvents lbl_ajoutSucces As Label
    Friend WithEvents btn_annuler As Button
    Friend WithEvents btn_modifier As Button
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents pnl_controlGrid As Panel
    Friend WithEvents txt_remarque As TextBox
    Friend WithEvents lb_categories As Label
    Friend WithEvents txt_nom_emplacement As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_erreur_nom As Label
    Friend WithEvents timer_succes As Timer
End Class
