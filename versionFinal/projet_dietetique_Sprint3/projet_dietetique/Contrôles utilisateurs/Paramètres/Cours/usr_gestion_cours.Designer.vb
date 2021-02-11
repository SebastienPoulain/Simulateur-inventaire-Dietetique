<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usr_gestion_cours
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
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.txt_noCours = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_ajouter = New System.Windows.Forms.Button()
        Me.txt_nmCours = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nud_groupe = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbE_noCours = New System.Windows.Forms.Label()
        Me.btn_modifier = New System.Windows.Forms.Button()
        Me.lbE_nomCours = New System.Windows.Forms.Label()
        Me.grid_cours = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_selectionner = New System.Windows.Forms.Button()
        Me.pnl_controlGrid = New System.Windows.Forms.Panel()
        Me.LBProf = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbE_selectionProf = New System.Windows.Forms.Label()
        Me.btn_assigner = New System.Windows.Forms.Button()
        Me.lbl_ajoutSucces = New System.Windows.Forms.Label()
        Me.timer_succes = New System.Windows.Forms.Timer(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_top = New System.Windows.Forms.Label()
        Me.btn_desac = New System.Windows.Forms.Button()
        Me.btn_activer = New System.Windows.Forms.Button()
        Me.pnl_recherche = New System.Windows.Forms.Panel()
        Me.Btn_listeEtu = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.gb_statut = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbo_statut = New System.Windows.Forms.ComboBox()
        Me.cbo_type = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_recherche = New System.Windows.Forms.TextBox()
        Me.Btn_supprimerCours = New System.Windows.Forms.Button()
        Me.Sfd_liste_etu = New System.Windows.Forms.SaveFileDialog()
        CType(Me.nud_groupe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_cours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_controlGrid.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.pnl_recherche.SuspendLayout()
        Me.gb_statut.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btn_annuler.Location = New System.Drawing.Point(383, 596)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(184, 32)
        Me.btn_annuler.TabIndex = 16
        Me.btn_annuler.Text = "Annuler"
        Me.btn_annuler.UseVisualStyleBackColor = False
        Me.btn_annuler.Visible = False
        '
        'txt_noCours
        '
        Me.txt_noCours.Enabled = False
        Me.txt_noCours.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_noCours.Location = New System.Drawing.Point(30, 31)
        Me.txt_noCours.MaxLength = 10
        Me.txt_noCours.Name = "txt_noCours"
        Me.txt_noCours.Size = New System.Drawing.Size(100, 22)
        Me.txt_noCours.TabIndex = 14
        Me.txt_noCours.Tag = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(25, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 19)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "No. de cours"
        '
        'btn_ajouter
        '
        Me.btn_ajouter.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_ajouter.FlatAppearance.BorderSize = 0
        Me.btn_ajouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ajouter.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajouter.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_ajouter.Location = New System.Drawing.Point(3, 596)
        Me.btn_ajouter.Name = "btn_ajouter"
        Me.btn_ajouter.Size = New System.Drawing.Size(184, 32)
        Me.btn_ajouter.TabIndex = 15
        Me.btn_ajouter.Text = "Ajouter un cours"
        Me.btn_ajouter.UseVisualStyleBackColor = False
        Me.btn_ajouter.Visible = False
        '
        'txt_nmCours
        '
        Me.txt_nmCours.Enabled = False
        Me.txt_nmCours.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nmCours.Location = New System.Drawing.Point(312, 31)
        Me.txt_nmCours.MaxLength = 50
        Me.txt_nmCours.Name = "txt_nmCours"
        Me.txt_nmCours.Size = New System.Drawing.Size(199, 22)
        Me.txt_nmCours.TabIndex = 19
        Me.txt_nmCours.Tag = "3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(311, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Nom du cours"
        '
        'nud_groupe
        '
        Me.nud_groupe.Enabled = False
        Me.nud_groupe.Location = New System.Drawing.Point(155, 32)
        Me.nud_groupe.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nud_groupe.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud_groupe.Name = "nud_groupe"
        Me.nud_groupe.Size = New System.Drawing.Size(37, 20)
        Me.nud_groupe.TabIndex = 21
        Me.nud_groupe.Tag = "2"
        Me.nud_groupe.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(151, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 19)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "No. de groupe"
        '
        'lbE_noCours
        '
        Me.lbE_noCours.AutoSize = True
        Me.lbE_noCours.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lbE_noCours.ForeColor = System.Drawing.Color.DarkGray
        Me.lbE_noCours.Location = New System.Drawing.Point(31, 53)
        Me.lbE_noCours.Name = "lbE_noCours"
        Me.lbE_noCours.Size = New System.Drawing.Size(61, 13)
        Me.lbE_noCours.TabIndex = 23
        Me.lbE_noCours.Text = "101-1Z4-RI"
        '
        'btn_modifier
        '
        Me.btn_modifier.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_modifier.FlatAppearance.BorderSize = 0
        Me.btn_modifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_modifier.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modifier.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_modifier.Location = New System.Drawing.Point(193, 596)
        Me.btn_modifier.Name = "btn_modifier"
        Me.btn_modifier.Size = New System.Drawing.Size(184, 32)
        Me.btn_modifier.TabIndex = 24
        Me.btn_modifier.Text = "Modifier un cours"
        Me.btn_modifier.UseVisualStyleBackColor = False
        Me.btn_modifier.Visible = False
        '
        'lbE_nomCours
        '
        Me.lbE_nomCours.AutoSize = True
        Me.lbE_nomCours.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lbE_nomCours.ForeColor = System.Drawing.Color.Firebrick
        Me.lbE_nomCours.Location = New System.Drawing.Point(312, 53)
        Me.lbE_nomCours.Name = "lbE_nomCours"
        Me.lbE_nomCours.Size = New System.Drawing.Size(141, 13)
        Me.lbE_nomCours.TabIndex = 25
        Me.lbE_nomCours.Text = "Saisissez un nom de cours"
        Me.lbE_nomCours.Visible = False
        '
        'grid_cours
        '
        Me.grid_cours.AllowUserToAddRows = False
        Me.grid_cours.AllowUserToDeleteRows = False
        Me.grid_cours.AllowUserToResizeColumns = False
        Me.grid_cours.AllowUserToResizeRows = False
        Me.grid_cours.BackgroundColor = System.Drawing.Color.White
        Me.grid_cours.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_cours.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_cours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_cours.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.grid_cours.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grid_cours.Location = New System.Drawing.Point(3, 103)
        Me.grid_cours.MultiSelect = False
        Me.grid_cours.Name = "grid_cours"
        Me.grid_cours.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_cours.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grid_cours.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.grid_cours.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.grid_cours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_cours.Size = New System.Drawing.Size(1180, 396)
        Me.grid_cours.TabIndex = 26
        Me.grid_cours.TabStop = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "No. de cours"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 120
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nom de cours"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 370
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nom de l'enseignant"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 470
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Identifiant de l'enseignant"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(572, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 19)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Enseignant"
        '
        'btn_selectionner
        '
        Me.btn_selectionner.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btn_selectionner.Enabled = False
        Me.btn_selectionner.FlatAppearance.BorderSize = 0
        Me.btn_selectionner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_selectionner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_selectionner.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_selectionner.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_selectionner.Location = New System.Drawing.Point(723, 29)
        Me.btn_selectionner.Name = "btn_selectionner"
        Me.btn_selectionner.Size = New System.Drawing.Size(97, 25)
        Me.btn_selectionner.TabIndex = 28
        Me.btn_selectionner.Text = "Sélectionner"
        Me.btn_selectionner.UseVisualStyleBackColor = False
        Me.btn_selectionner.Visible = False
        '
        'pnl_controlGrid
        '
        Me.pnl_controlGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_controlGrid.Controls.Add(Me.LBProf)
        Me.pnl_controlGrid.Controls.Add(Me.Label3)
        Me.pnl_controlGrid.Controls.Add(Me.lbE_selectionProf)
        Me.pnl_controlGrid.Controls.Add(Me.btn_selectionner)
        Me.pnl_controlGrid.Controls.Add(Me.Label1)
        Me.pnl_controlGrid.Controls.Add(Me.txt_nmCours)
        Me.pnl_controlGrid.Controls.Add(Me.Label5)
        Me.pnl_controlGrid.Controls.Add(Me.Label2)
        Me.pnl_controlGrid.Controls.Add(Me.lbE_nomCours)
        Me.pnl_controlGrid.Controls.Add(Me.nud_groupe)
        Me.pnl_controlGrid.Controls.Add(Me.txt_noCours)
        Me.pnl_controlGrid.Controls.Add(Me.lbE_noCours)
        Me.pnl_controlGrid.Controls.Add(Me.Label4)
        Me.pnl_controlGrid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnl_controlGrid.Location = New System.Drawing.Point(3, 505)
        Me.pnl_controlGrid.Name = "pnl_controlGrid"
        Me.pnl_controlGrid.Size = New System.Drawing.Size(1180, 85)
        Me.pnl_controlGrid.TabIndex = 27
        '
        'LBProf
        '
        Me.LBProf.FormattingEnabled = True
        Me.LBProf.Location = New System.Drawing.Point(565, 29)
        Me.LBProf.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LBProf.Name = "LBProf"
        Me.LBProf.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.LBProf.Size = New System.Drawing.Size(112, 30)
        Me.LBProf.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(134, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 19)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "-"
        '
        'lbE_selectionProf
        '
        Me.lbE_selectionProf.AutoSize = True
        Me.lbE_selectionProf.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lbE_selectionProf.ForeColor = System.Drawing.Color.DarkGray
        Me.lbE_selectionProf.Location = New System.Drawing.Point(575, 53)
        Me.lbE_selectionProf.Name = "lbE_selectionProf"
        Me.lbE_selectionProf.Size = New System.Drawing.Size(149, 13)
        Me.lbE_selectionProf.TabIndex = 29
        Me.lbE_selectionProf.Text = "Sélectionner un enseignant"
        Me.lbE_selectionProf.Visible = False
        '
        'btn_assigner
        '
        Me.btn_assigner.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_assigner.FlatAppearance.BorderSize = 0
        Me.btn_assigner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_assigner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_assigner.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_assigner.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_assigner.Location = New System.Drawing.Point(633, 596)
        Me.btn_assigner.Name = "btn_assigner"
        Me.btn_assigner.Size = New System.Drawing.Size(184, 32)
        Me.btn_assigner.TabIndex = 28
        Me.btn_assigner.Text = "Assigner des étudiants"
        Me.btn_assigner.UseVisualStyleBackColor = False
        '
        'lbl_ajoutSucces
        '
        Me.lbl_ajoutSucces.BackColor = System.Drawing.Color.Lime
        Me.lbl_ajoutSucces.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_ajoutSucces.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_ajoutSucces.Location = New System.Drawing.Point(1, 632)
        Me.lbl_ajoutSucces.Name = "lbl_ajoutSucces"
        Me.lbl_ajoutSucces.Size = New System.Drawing.Size(1182, 24)
        Me.lbl_ajoutSucces.TabIndex = 44
        Me.lbl_ajoutSucces.Text = "L'utilisateur a bien été ajouté."
        Me.lbl_ajoutSucces.Visible = False
        '
        'timer_succes
        '
        Me.timer_succes.Interval = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel5.Controls.Add(Me.lbl_top)
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1188, 28)
        Me.Panel5.TabIndex = 52
        '
        'lbl_top
        '
        Me.lbl_top.AutoSize = True
        Me.lbl_top.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lbl_top.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_top.Location = New System.Drawing.Point(11, 0)
        Me.lbl_top.Name = "lbl_top"
        Me.lbl_top.Size = New System.Drawing.Size(322, 25)
        Me.lbl_top.TabIndex = 9
        Me.lbl_top.Text = "Créer, modifier ou supprimer des cours"
        '
        'btn_desac
        '
        Me.btn_desac.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btn_desac.Enabled = False
        Me.btn_desac.FlatAppearance.BorderSize = 0
        Me.btn_desac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_desac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_desac.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_desac.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_desac.Location = New System.Drawing.Point(1088, 596)
        Me.btn_desac.Name = "btn_desac"
        Me.btn_desac.Size = New System.Drawing.Size(95, 32)
        Me.btn_desac.TabIndex = 53
        Me.btn_desac.Text = "Désactiver"
        Me.btn_desac.UseVisualStyleBackColor = False
        Me.btn_desac.Visible = False
        '
        'btn_activer
        '
        Me.btn_activer.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btn_activer.Enabled = False
        Me.btn_activer.FlatAppearance.BorderSize = 0
        Me.btn_activer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_activer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_activer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_activer.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_activer.Location = New System.Drawing.Point(987, 596)
        Me.btn_activer.Name = "btn_activer"
        Me.btn_activer.Size = New System.Drawing.Size(95, 32)
        Me.btn_activer.TabIndex = 54
        Me.btn_activer.Text = "Activer"
        Me.btn_activer.UseVisualStyleBackColor = False
        Me.btn_activer.Visible = False
        '
        'pnl_recherche
        '
        Me.pnl_recherche.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnl_recherche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_recherche.Controls.Add(Me.Btn_listeEtu)
        Me.pnl_recherche.Controls.Add(Me.Label9)
        Me.pnl_recherche.Controls.Add(Me.gb_statut)
        Me.pnl_recherche.Controls.Add(Me.cbo_type)
        Me.pnl_recherche.Controls.Add(Me.Label8)
        Me.pnl_recherche.Controls.Add(Me.txt_recherche)
        Me.pnl_recherche.Location = New System.Drawing.Point(3, 35)
        Me.pnl_recherche.Name = "pnl_recherche"
        Me.pnl_recherche.Size = New System.Drawing.Size(1180, 62)
        Me.pnl_recherche.TabIndex = 55
        '
        'Btn_listeEtu
        '
        Me.Btn_listeEtu.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Btn_listeEtu.FlatAppearance.BorderSize = 0
        Me.Btn_listeEtu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Btn_listeEtu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_listeEtu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_listeEtu.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_listeEtu.Location = New System.Drawing.Point(829, 15)
        Me.Btn_listeEtu.Name = "Btn_listeEtu"
        Me.Btn_listeEtu.Size = New System.Drawing.Size(184, 32)
        Me.Btn_listeEtu.TabIndex = 57
        Me.Btn_listeEtu.Text = "Liste des étudiants"
        Me.Btn_listeEtu.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(334, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 17)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Par"
        '
        'gb_statut
        '
        Me.gb_statut.Controls.Add(Me.Label7)
        Me.gb_statut.Controls.Add(Me.cbo_statut)
        Me.gb_statut.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_statut.Location = New System.Drawing.Point(529, 3)
        Me.gb_statut.Name = "gb_statut"
        Me.gb_statut.Size = New System.Drawing.Size(188, 51)
        Me.gb_statut.TabIndex = 47
        Me.gb_statut.TabStop = False
        Me.gb_statut.Text = "Admin"
        Me.gb_statut.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(9, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 17)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Statut"
        '
        'cbo_statut
        '
        Me.cbo_statut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_statut.FormattingEnabled = True
        Me.cbo_statut.Items.AddRange(New Object() {"Actif", "Inactif", "Tous"})
        Me.cbo_statut.Location = New System.Drawing.Point(56, 17)
        Me.cbo_statut.Name = "cbo_statut"
        Me.cbo_statut.Size = New System.Drawing.Size(121, 21)
        Me.cbo_statut.TabIndex = 2
        '
        'cbo_type
        '
        Me.cbo_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_type.FormattingEnabled = True
        Me.cbo_type.Items.AddRange(New Object() {"No. de cours", "Nom de cours", "Nom de professeur", "Identifiant de professeur"})
        Me.cbo_type.Location = New System.Drawing.Point(367, 19)
        Me.cbo_type.Name = "cbo_type"
        Me.cbo_type.Size = New System.Drawing.Size(144, 21)
        Me.cbo_type.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(13, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Rechercher"
        '
        'txt_recherche
        '
        Me.txt_recherche.Location = New System.Drawing.Point(17, 22)
        Me.txt_recherche.Name = "txt_recherche"
        Me.txt_recherche.Size = New System.Drawing.Size(310, 20)
        Me.txt_recherche.TabIndex = 1
        '
        'Btn_supprimerCours
        '
        Me.Btn_supprimerCours.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Btn_supprimerCours.FlatAppearance.BorderSize = 0
        Me.Btn_supprimerCours.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Btn_supprimerCours.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_supprimerCours.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_supprimerCours.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_supprimerCours.Location = New System.Drawing.Point(832, 596)
        Me.Btn_supprimerCours.Name = "Btn_supprimerCours"
        Me.Btn_supprimerCours.Size = New System.Drawing.Size(148, 32)
        Me.Btn_supprimerCours.TabIndex = 56
        Me.Btn_supprimerCours.Text = "Supprimer un cours"
        Me.Btn_supprimerCours.UseVisualStyleBackColor = False
        '
        'usr_gestion_cours
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.Btn_supprimerCours)
        Me.Controls.Add(Me.btn_assigner)
        Me.Controls.Add(Me.pnl_recherche)
        Me.Controls.Add(Me.btn_activer)
        Me.Controls.Add(Me.btn_desac)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.lbl_ajoutSucces)
        Me.Controls.Add(Me.pnl_controlGrid)
        Me.Controls.Add(Me.grid_cours)
        Me.Controls.Add(Me.btn_annuler)
        Me.Controls.Add(Me.btn_modifier)
        Me.Controls.Add(Me.btn_ajouter)
        Me.Name = "usr_gestion_cours"
        Me.Size = New System.Drawing.Size(1188, 795)
        CType(Me.nud_groupe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_cours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_controlGrid.ResumeLayout(False)
        Me.pnl_controlGrid.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.pnl_recherche.ResumeLayout(False)
        Me.pnl_recherche.PerformLayout()
        Me.gb_statut.ResumeLayout(False)
        Me.gb_statut.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_annuler As Button
    Friend WithEvents txt_noCours As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents txt_nmCours As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents nud_groupe As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents lbE_noCours As Label
    Friend WithEvents btn_modifier As Button
    Friend WithEvents lbE_nomCours As Label
    Friend WithEvents grid_cours As DataGridView
    Friend WithEvents btn_selectionner As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents pnl_controlGrid As Panel
    Friend WithEvents lbE_selectionProf As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_assigner As Button
    Friend WithEvents lbl_ajoutSucces As Label
    Friend WithEvents timer_succes As Timer
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_top As Label
    Friend WithEvents btn_desac As Button
    Friend WithEvents btn_activer As Button
    Friend WithEvents pnl_recherche As Panel
    Friend WithEvents gb_statut As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbo_statut As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbo_type As ComboBox
    Friend WithEvents txt_recherche As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents LBProf As ListBox
    Friend WithEvents Btn_supprimerCours As Button
    Friend WithEvents Btn_listeEtu As Button
    Friend WithEvents Sfd_liste_etu As SaveFileDialog
End Class
