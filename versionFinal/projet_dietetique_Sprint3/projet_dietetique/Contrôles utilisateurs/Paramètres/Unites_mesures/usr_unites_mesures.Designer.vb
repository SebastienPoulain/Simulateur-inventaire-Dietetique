<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usr_unites_mesures
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_mode = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cbo_unite_mesure = New System.Windows.Forms.ComboBox()
        Me.cbo_trier_activite = New System.Windows.Forms.ComboBox()
        Me.cbo_ordre = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbo_nom_contient = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_rech_nom = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReinitialiser = New System.Windows.Forms.Button()
        Me.dgv_unites_mesures = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnl_controlGrid = New System.Windows.Forms.Panel()
        Me.cbo_type_mesure = New System.Windows.Forms.ComboBox()
        Me.lbE_types_mesures = New System.Windows.Forms.Label()
        Me.lb_remarque = New System.Windows.Forms.Label()
        Me.txt_unite_mesure = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbE_unites_mesures = New System.Windows.Forms.Label()
        Me.btn_unite_mesure = New System.Windows.Forms.Button()
        Me.btn_desac_unite_mesure = New System.Windows.Forms.Button()
        Me.lbl_ajoutSucces = New System.Windows.Forms.Label()
        Me.btn_annuler_unite_mesure = New System.Windows.Forms.Button()
        Me.btn_modifier_unite_mesure = New System.Windows.Forms.Button()
        Me.btn_ajouter_unite_mesure = New System.Windows.Forms.Button()
        Me.timer_succes = New System.Windows.Forms.Timer(Me.components)
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_unites_mesures, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_controlGrid.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel5.Controls.Add(Me.lbl_mode)
        Me.Panel5.Location = New System.Drawing.Point(0, -1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1197, 35)
        Me.Panel5.TabIndex = 144
        '
        'lbl_mode
        '
        Me.lbl_mode.AutoSize = True
        Me.lbl_mode.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lbl_mode.ForeColor = System.Drawing.Color.White
        Me.lbl_mode.Location = New System.Drawing.Point(11, 3)
        Me.lbl_mode.Name = "lbl_mode"
        Me.lbl_mode.Size = New System.Drawing.Size(157, 25)
        Me.lbl_mode.TabIndex = 9
        Me.lbl_mode.Text = "Unités de mesures"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(0, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1197, 28)
        Me.Panel1.TabIndex = 145
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(11, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(254, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Recherche d'unités de mesures"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.cbo_unite_mesure)
        Me.Panel3.Controls.Add(Me.cbo_trier_activite)
        Me.Panel3.Controls.Add(Me.cbo_ordre)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.cbo_nom_contient)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txt_rech_nom)
        Me.Panel3.Location = New System.Drawing.Point(3, 84)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1164, 86)
        Me.Panel3.TabIndex = 146
        '
        'cbo_unite_mesure
        '
        Me.cbo_unite_mesure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_unite_mesure.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_unite_mesure.FormattingEnabled = True
        Me.cbo_unite_mesure.Items.AddRange(New Object() {"Unités de mesures", "Types de mesures"})
        Me.cbo_unite_mesure.Location = New System.Drawing.Point(575, 15)
        Me.cbo_unite_mesure.Name = "cbo_unite_mesure"
        Me.cbo_unite_mesure.Size = New System.Drawing.Size(212, 23)
        Me.cbo_unite_mesure.TabIndex = 3
        '
        'cbo_trier_activite
        '
        Me.cbo_trier_activite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_trier_activite.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_trier_activite.FormattingEnabled = True
        Me.cbo_trier_activite.Items.AddRange(New Object() {"Actif", "Inactif", "Tous"})
        Me.cbo_trier_activite.Location = New System.Drawing.Point(357, 15)
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
        Me.cbo_ordre.Location = New System.Drawing.Point(134, 15)
        Me.cbo_ordre.Name = "cbo_ordre"
        Me.cbo_ordre.Size = New System.Drawing.Size(211, 23)
        Me.cbo_ordre.TabIndex = 1
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
        'cbo_nom_contient
        '
        Me.cbo_nom_contient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_nom_contient.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_nom_contient.FormattingEnabled = True
        Me.cbo_nom_contient.Items.AddRange(New Object() {"Contient", "Commence par", "Ne s'applique pas"})
        Me.cbo_nom_contient.Location = New System.Drawing.Point(134, 43)
        Me.cbo_nom_contient.Name = "cbo_nom_contient"
        Me.cbo_nom_contient.Size = New System.Drawing.Size(211, 23)
        Me.cbo_nom_contient.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 17)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Unités de mesures"
        '
        'txt_rech_nom
        '
        Me.txt_rech_nom.Location = New System.Drawing.Point(357, 44)
        Me.txt_rech_nom.MaxLength = 30
        Me.txt_rech_nom.Name = "txt_rech_nom"
        Me.txt_rech_nom.Size = New System.Drawing.Size(212, 20)
        Me.txt_rech_nom.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 214)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1197, 28)
        Me.Panel2.TabIndex = 149
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(11, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Liste d'unités de mesures"
        '
        'btnReinitialiser
        '
        Me.btnReinitialiser.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnReinitialiser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReinitialiser.FlatAppearance.BorderSize = 0
        Me.btnReinitialiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReinitialiser.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReinitialiser.ForeColor = System.Drawing.SystemColors.Control
        Me.btnReinitialiser.Location = New System.Drawing.Point(1013, 176)
        Me.btnReinitialiser.Name = "btnReinitialiser"
        Me.btnReinitialiser.Size = New System.Drawing.Size(154, 32)
        Me.btnReinitialiser.TabIndex = 6
        Me.btnReinitialiser.Text = "Réinitialiser"
        Me.btnReinitialiser.UseVisualStyleBackColor = False
        '
        'dgv_unites_mesures
        '
        Me.dgv_unites_mesures.AllowUserToAddRows = False
        Me.dgv_unites_mesures.AllowUserToDeleteRows = False
        Me.dgv_unites_mesures.AllowUserToResizeColumns = False
        Me.dgv_unites_mesures.AllowUserToResizeRows = False
        Me.dgv_unites_mesures.BackgroundColor = System.Drawing.Color.White
        Me.dgv_unites_mesures.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_unites_mesures.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_unites_mesures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_unites_mesures.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column2})
        Me.dgv_unites_mesures.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgv_unites_mesures.Location = New System.Drawing.Point(2, 248)
        Me.dgv_unites_mesures.Name = "dgv_unites_mesures"
        Me.dgv_unites_mesures.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_unites_mesures.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_unites_mesures.RowHeadersVisible = False
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_unites_mesures.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_unites_mesures.RowTemplate.Height = 25
        Me.dgv_unites_mesures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_unites_mesures.Size = New System.Drawing.Size(1183, 396)
        Me.dgv_unites_mesures.TabIndex = 150
        Me.dgv_unites_mesures.TabStop = False
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Unités de mesures"
        Me.Column4.MaxInputLength = 30
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Types de mesures"
        Me.Column2.MaxInputLength = 20
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 600
        '
        'pnl_controlGrid
        '
        Me.pnl_controlGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_controlGrid.Controls.Add(Me.cbo_type_mesure)
        Me.pnl_controlGrid.Controls.Add(Me.lbE_types_mesures)
        Me.pnl_controlGrid.Controls.Add(Me.lb_remarque)
        Me.pnl_controlGrid.Controls.Add(Me.txt_unite_mesure)
        Me.pnl_controlGrid.Controls.Add(Me.Label8)
        Me.pnl_controlGrid.Controls.Add(Me.lbE_unites_mesures)
        Me.pnl_controlGrid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnl_controlGrid.Location = New System.Drawing.Point(0, 650)
        Me.pnl_controlGrid.Name = "pnl_controlGrid"
        Me.pnl_controlGrid.Size = New System.Drawing.Size(1185, 85)
        Me.pnl_controlGrid.TabIndex = 151
        '
        'cbo_type_mesure
        '
        Me.cbo_type_mesure.Enabled = False
        Me.cbo_type_mesure.FormattingEnabled = True
        Me.cbo_type_mesure.Location = New System.Drawing.Point(295, 34)
        Me.cbo_type_mesure.MaxLength = 20
        Me.cbo_type_mesure.Name = "cbo_type_mesure"
        Me.cbo_type_mesure.Size = New System.Drawing.Size(199, 21)
        Me.cbo_type_mesure.TabIndex = 8
        '
        'lbE_types_mesures
        '
        Me.lbE_types_mesures.AutoSize = True
        Me.lbE_types_mesures.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lbE_types_mesures.ForeColor = System.Drawing.Color.Firebrick
        Me.lbE_types_mesures.Location = New System.Drawing.Point(292, 59)
        Me.lbE_types_mesures.Name = "lbE_types_mesures"
        Me.lbE_types_mesures.Size = New System.Drawing.Size(232, 13)
        Me.lbE_types_mesures.TabIndex = 34
        Me.lbE_types_mesures.Text = "Saisissez ou sélectionner un type de mesure"
        Me.lbE_types_mesures.Visible = False
        '
        'lb_remarque
        '
        Me.lb_remarque.AutoSize = True
        Me.lb_remarque.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lb_remarque.ForeColor = System.Drawing.Color.Black
        Me.lb_remarque.Location = New System.Drawing.Point(291, 12)
        Me.lb_remarque.Name = "lb_remarque"
        Me.lb_remarque.Size = New System.Drawing.Size(117, 19)
        Me.lb_remarque.TabIndex = 32
        Me.lb_remarque.Text = "Types de mesures"
        '
        'txt_unite_mesure
        '
        Me.txt_unite_mesure.Enabled = False
        Me.txt_unite_mesure.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_unite_mesure.Location = New System.Drawing.Point(29, 34)
        Me.txt_unite_mesure.MaxLength = 30
        Me.txt_unite_mesure.Name = "txt_unite_mesure"
        Me.txt_unite_mesure.Size = New System.Drawing.Size(199, 22)
        Me.txt_unite_mesure.TabIndex = 7
        Me.txt_unite_mesure.Tag = "3"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(28, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 19)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Unité de mesure"
        '
        'lbE_unites_mesures
        '
        Me.lbE_unites_mesures.AutoSize = True
        Me.lbE_unites_mesures.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lbE_unites_mesures.ForeColor = System.Drawing.Color.Firebrick
        Me.lbE_unites_mesures.Location = New System.Drawing.Point(29, 56)
        Me.lbE_unites_mesures.Name = "lbE_unites_mesures"
        Me.lbE_unites_mesures.Size = New System.Drawing.Size(190, 13)
        Me.lbE_unites_mesures.TabIndex = 25
        Me.lbE_unites_mesures.Text = "Saisissez un nom d'unité de mesure"
        Me.lbE_unites_mesures.Visible = False
        '
        'btn_unite_mesure
        '
        Me.btn_unite_mesure.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btn_unite_mesure.Enabled = False
        Me.btn_unite_mesure.FlatAppearance.BorderSize = 0
        Me.btn_unite_mesure.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_unite_mesure.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_unite_mesure.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_unite_mesure.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_unite_mesure.Location = New System.Drawing.Point(989, 742)
        Me.btn_unite_mesure.Name = "btn_unite_mesure"
        Me.btn_unite_mesure.Size = New System.Drawing.Size(95, 32)
        Me.btn_unite_mesure.TabIndex = 12
        Me.btn_unite_mesure.Text = "Activer"
        Me.btn_unite_mesure.UseVisualStyleBackColor = False
        '
        'btn_desac_unite_mesure
        '
        Me.btn_desac_unite_mesure.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btn_desac_unite_mesure.Enabled = False
        Me.btn_desac_unite_mesure.FlatAppearance.BorderSize = 0
        Me.btn_desac_unite_mesure.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_desac_unite_mesure.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_desac_unite_mesure.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_desac_unite_mesure.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_desac_unite_mesure.Location = New System.Drawing.Point(1090, 742)
        Me.btn_desac_unite_mesure.Name = "btn_desac_unite_mesure"
        Me.btn_desac_unite_mesure.Size = New System.Drawing.Size(95, 32)
        Me.btn_desac_unite_mesure.TabIndex = 13
        Me.btn_desac_unite_mesure.Text = "Désactiver"
        Me.btn_desac_unite_mesure.UseVisualStyleBackColor = False
        '
        'lbl_ajoutSucces
        '
        Me.lbl_ajoutSucces.BackColor = System.Drawing.Color.Lime
        Me.lbl_ajoutSucces.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_ajoutSucces.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_ajoutSucces.Location = New System.Drawing.Point(-2, 777)
        Me.lbl_ajoutSucces.Name = "lbl_ajoutSucces"
        Me.lbl_ajoutSucces.Size = New System.Drawing.Size(1190, 24)
        Me.lbl_ajoutSucces.TabIndex = 157
        Me.lbl_ajoutSucces.Text = "L'unité de mesure a bien été ajouté"
        Me.lbl_ajoutSucces.Visible = False
        '
        'btn_annuler_unite_mesure
        '
        Me.btn_annuler_unite_mesure.BackColor = System.Drawing.Color.DimGray
        Me.btn_annuler_unite_mesure.Enabled = False
        Me.btn_annuler_unite_mesure.FlatAppearance.BorderSize = 0
        Me.btn_annuler_unite_mesure.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_annuler_unite_mesure.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_annuler_unite_mesure.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annuler_unite_mesure.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_annuler_unite_mesure.Location = New System.Drawing.Point(380, 741)
        Me.btn_annuler_unite_mesure.Name = "btn_annuler_unite_mesure"
        Me.btn_annuler_unite_mesure.Size = New System.Drawing.Size(184, 32)
        Me.btn_annuler_unite_mesure.TabIndex = 11
        Me.btn_annuler_unite_mesure.Text = "Annuler"
        Me.btn_annuler_unite_mesure.UseVisualStyleBackColor = False
        '
        'btn_modifier_unite_mesure
        '
        Me.btn_modifier_unite_mesure.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_modifier_unite_mesure.FlatAppearance.BorderSize = 0
        Me.btn_modifier_unite_mesure.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_modifier_unite_mesure.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_modifier_unite_mesure.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modifier_unite_mesure.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_modifier_unite_mesure.Location = New System.Drawing.Point(190, 741)
        Me.btn_modifier_unite_mesure.Name = "btn_modifier_unite_mesure"
        Me.btn_modifier_unite_mesure.Size = New System.Drawing.Size(184, 32)
        Me.btn_modifier_unite_mesure.TabIndex = 10
        Me.btn_modifier_unite_mesure.Text = "Modifier"
        Me.btn_modifier_unite_mesure.UseVisualStyleBackColor = False
        '
        'btn_ajouter_unite_mesure
        '
        Me.btn_ajouter_unite_mesure.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_ajouter_unite_mesure.FlatAppearance.BorderSize = 0
        Me.btn_ajouter_unite_mesure.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_ajouter_unite_mesure.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ajouter_unite_mesure.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajouter_unite_mesure.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_ajouter_unite_mesure.Location = New System.Drawing.Point(0, 741)
        Me.btn_ajouter_unite_mesure.Name = "btn_ajouter_unite_mesure"
        Me.btn_ajouter_unite_mesure.Size = New System.Drawing.Size(184, 32)
        Me.btn_ajouter_unite_mesure.TabIndex = 9
        Me.btn_ajouter_unite_mesure.Text = "Ajouter"
        Me.btn_ajouter_unite_mesure.UseVisualStyleBackColor = False
        '
        'timer_succes
        '
        Me.timer_succes.Interval = 1
        '
        'usr_unites_mesures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_unite_mesure)
        Me.Controls.Add(Me.btn_desac_unite_mesure)
        Me.Controls.Add(Me.lbl_ajoutSucces)
        Me.Controls.Add(Me.btn_annuler_unite_mesure)
        Me.Controls.Add(Me.btn_modifier_unite_mesure)
        Me.Controls.Add(Me.btn_ajouter_unite_mesure)
        Me.Controls.Add(Me.pnl_controlGrid)
        Me.Controls.Add(Me.dgv_unites_mesures)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnReinitialiser)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.Name = "usr_unites_mesures"
        Me.Size = New System.Drawing.Size(1188, 795)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgv_unites_mesures, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_controlGrid.ResumeLayout(False)
        Me.pnl_controlGrid.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_mode As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cbo_ordre As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbo_nom_contient As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_rech_nom As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReinitialiser As Button
    Friend WithEvents cbo_trier_activite As ComboBox
    Friend WithEvents dgv_unites_mesures As DataGridView
    Friend WithEvents pnl_controlGrid As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents lbE_unites_mesures As Label
    Friend WithEvents btn_unite_mesure As Button
    Friend WithEvents btn_desac_unite_mesure As Button
    Friend WithEvents lbl_ajoutSucces As Label
    Friend WithEvents btn_annuler_unite_mesure As Button
    Friend WithEvents btn_modifier_unite_mesure As Button
    Friend WithEvents btn_ajouter_unite_mesure As Button
    Friend WithEvents lb_remarque As Label
    Friend WithEvents timer_succes As Timer
    Friend WithEvents cbo_type_mesure As ComboBox
    Friend WithEvents lbE_types_mesures As Label
    Friend WithEvents txt_unite_mesure As TextBox
    Friend WithEvents cbo_unite_mesure As ComboBox
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
