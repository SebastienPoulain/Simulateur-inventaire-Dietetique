<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usr_comparer_commande
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_travaux = New System.Windows.Forms.Button()
        Me.pn_vide2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnl_vide = New System.Windows.Forms.Panel()
        Me.lbl_vide = New System.Windows.Forms.Label()
        Me.btn_ouvrir_pdf = New System.Windows.Forms.Button()
        Me.btn_sauvegarder = New System.Windows.Forms.Button()
        Me.dgv_eleves = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pn_liste_etudiant = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pn_commande_eleve = New System.Windows.Forms.Panel()
        Me.lb_Commande_haut = New System.Windows.Forms.Label()
        Me.dgv_Commande_eleve = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pn_commande_prof = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_mode = New System.Windows.Forms.Label()
        Me.dgv_Commande_Prof = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantité = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unités = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.sfd_commande_pdf = New System.Windows.Forms.SaveFileDialog()
        Me.Panel1.SuspendLayout()
        Me.pn_vide2.SuspendLayout()
        Me.pnl_vide.SuspendLayout()
        CType(Me.dgv_eleves, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pn_liste_etudiant.SuspendLayout()
        Me.pn_commande_eleve.SuspendLayout()
        CType(Me.dgv_Commande_eleve, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pn_commande_prof.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgv_Commande_Prof, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_travaux)
        Me.Panel1.Controls.Add(Me.pn_vide2)
        Me.Panel1.Controls.Add(Me.pnl_vide)
        Me.Panel1.Controls.Add(Me.btn_ouvrir_pdf)
        Me.Panel1.Controls.Add(Me.btn_sauvegarder)
        Me.Panel1.Controls.Add(Me.dgv_eleves)
        Me.Panel1.Controls.Add(Me.pn_liste_etudiant)
        Me.Panel1.Controls.Add(Me.pn_commande_eleve)
        Me.Panel1.Controls.Add(Me.dgv_Commande_eleve)
        Me.Panel1.Controls.Add(Me.pn_commande_prof)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.dgv_Commande_Prof)
        Me.Panel1.Controls.Add(Me.btnRetour)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1438, 835)
        Me.Panel1.TabIndex = 0
        '
        'btn_travaux
        '
        Me.btn_travaux.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_travaux.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_travaux.FlatAppearance.BorderSize = 0
        Me.btn_travaux.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_travaux.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_travaux.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_travaux.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_travaux.Location = New System.Drawing.Point(978, 783)
        Me.btn_travaux.Name = "btn_travaux"
        Me.btn_travaux.Size = New System.Drawing.Size(142, 32)
        Me.btn_travaux.TabIndex = 164
        Me.btn_travaux.Text = "Sauvegarder les travaux"
        Me.btn_travaux.UseVisualStyleBackColor = False
        '
        'pn_vide2
        '
        Me.pn_vide2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pn_vide2.Controls.Add(Me.Label3)
        Me.pn_vide2.Location = New System.Drawing.Point(3, 116)
        Me.pn_vide2.Name = "pn_vide2"
        Me.pn_vide2.Size = New System.Drawing.Size(956, 300)
        Me.pn_vide2.TabIndex = 163
        Me.pn_vide2.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(250, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(374, 50)
        Me.Label3.TabIndex = 141
        Me.Label3.Text = "Le travail n'a pas été remis par l'étudiant"
        '
        'pnl_vide
        '
        Me.pnl_vide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_vide.Controls.Add(Me.lbl_vide)
        Me.pnl_vide.Location = New System.Drawing.Point(3, 479)
        Me.pnl_vide.Name = "pnl_vide"
        Me.pnl_vide.Size = New System.Drawing.Size(956, 326)
        Me.pnl_vide.TabIndex = 162
        '
        'lbl_vide
        '
        Me.lbl_vide.AutoSize = True
        Me.lbl_vide.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_vide.Location = New System.Drawing.Point(231, 135)
        Me.lbl_vide.Name = "lbl_vide"
        Me.lbl_vide.Size = New System.Drawing.Size(416, 50)
        Me.lbl_vide.TabIndex = 141
        Me.lbl_vide.Text = "Le corrigé n'est pas disponible pour le moment." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "           Veuillez contacter vo" &
    "tre professeur." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btn_ouvrir_pdf
        '
        Me.btn_ouvrir_pdf.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_ouvrir_pdf.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_ouvrir_pdf.Enabled = False
        Me.btn_ouvrir_pdf.FlatAppearance.BorderSize = 0
        Me.btn_ouvrir_pdf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_ouvrir_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ouvrir_pdf.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ouvrir_pdf.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_ouvrir_pdf.Location = New System.Drawing.Point(1274, 783)
        Me.btn_ouvrir_pdf.Name = "btn_ouvrir_pdf"
        Me.btn_ouvrir_pdf.Size = New System.Drawing.Size(142, 32)
        Me.btn_ouvrir_pdf.TabIndex = 161
        Me.btn_ouvrir_pdf.Text = "Ouvrir le fichier"
        Me.btn_ouvrir_pdf.UseVisualStyleBackColor = False
        '
        'btn_sauvegarder
        '
        Me.btn_sauvegarder.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_sauvegarder.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_sauvegarder.FlatAppearance.BorderSize = 0
        Me.btn_sauvegarder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_sauvegarder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sauvegarder.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sauvegarder.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_sauvegarder.Location = New System.Drawing.Point(1126, 783)
        Me.btn_sauvegarder.Name = "btn_sauvegarder"
        Me.btn_sauvegarder.Size = New System.Drawing.Size(142, 32)
        Me.btn_sauvegarder.TabIndex = 160
        Me.btn_sauvegarder.Text = "Sauvegarder"
        Me.btn_sauvegarder.UseVisualStyleBackColor = False
        '
        'dgv_eleves
        '
        Me.dgv_eleves.AllowUserToAddRows = False
        Me.dgv_eleves.AllowUserToDeleteRows = False
        Me.dgv_eleves.AllowUserToResizeColumns = False
        Me.dgv_eleves.AllowUserToResizeRows = False
        Me.dgv_eleves.BackgroundColor = System.Drawing.Color.White
        Me.dgv_eleves.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_eleves.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_eleves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_eleves.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.DataGridViewTextBoxColumn8})
        Me.dgv_eleves.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgv_eleves.Location = New System.Drawing.Point(965, 115)
        Me.dgv_eleves.MultiSelect = False
        Me.dgv_eleves.Name = "dgv_eleves"
        Me.dgv_eleves.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_eleves.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_eleves.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_eleves.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_eleves.RowTemplate.Height = 25
        Me.dgv_eleves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_eleves.Size = New System.Drawing.Size(470, 300)
        Me.dgv_eleves.TabIndex = 159
        Me.dgv_eleves.TabStop = False
        '
        'Column6
        '
        Me.Column6.HeaderText = "Identifiant"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 200
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Nom de l'élève"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 267
        '
        'pn_liste_etudiant
        '
        Me.pn_liste_etudiant.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.pn_liste_etudiant.Controls.Add(Me.Label2)
        Me.pn_liste_etudiant.Location = New System.Drawing.Point(965, 88)
        Me.pn_liste_etudiant.Name = "pn_liste_etudiant"
        Me.pn_liste_etudiant.Size = New System.Drawing.Size(470, 28)
        Me.pn_liste_etudiant.TabIndex = 157
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(11, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Liste des étudiants"
        '
        'pn_commande_eleve
        '
        Me.pn_commande_eleve.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.pn_commande_eleve.Controls.Add(Me.lb_Commande_haut)
        Me.pn_commande_eleve.Location = New System.Drawing.Point(3, 88)
        Me.pn_commande_eleve.Name = "pn_commande_eleve"
        Me.pn_commande_eleve.Size = New System.Drawing.Size(956, 28)
        Me.pn_commande_eleve.TabIndex = 156
        '
        'lb_Commande_haut
        '
        Me.lb_Commande_haut.AutoSize = True
        Me.lb_Commande_haut.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lb_Commande_haut.ForeColor = System.Drawing.SystemColors.Control
        Me.lb_Commande_haut.Location = New System.Drawing.Point(11, 0)
        Me.lb_Commande_haut.Name = "lb_Commande_haut"
        Me.lb_Commande_haut.Size = New System.Drawing.Size(183, 25)
        Me.lb_Commande_haut.TabIndex = 9
        Me.lb_Commande_haut.Text = "Commande de l'élève"
        '
        'dgv_Commande_eleve
        '
        Me.dgv_Commande_eleve.AllowUserToAddRows = False
        Me.dgv_Commande_eleve.AllowUserToDeleteRows = False
        Me.dgv_Commande_eleve.AllowUserToResizeColumns = False
        Me.dgv_Commande_eleve.AllowUserToResizeRows = False
        Me.dgv_Commande_eleve.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Commande_eleve.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Commande_eleve.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Commande_eleve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Commande_eleve.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.dgv_Commande_eleve.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgv_Commande_eleve.Location = New System.Drawing.Point(3, 116)
        Me.dgv_Commande_eleve.Name = "dgv_Commande_eleve"
        Me.dgv_Commande_eleve.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Commande_eleve.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_Commande_eleve.RowHeadersVisible = False
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_Commande_eleve.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_Commande_eleve.RowTemplate.Height = 25
        Me.dgv_Commande_eleve.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Commande_eleve.Size = New System.Drawing.Size(956, 300)
        Me.dgv_Commande_eleve.TabIndex = 155
        Me.dgv_Commande_eleve.TabStop = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.FillWeight = 125.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nom du produit"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fournisseurs"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn3.HeaderText = "Quantité"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 91
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.HeaderText = "Format"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.HeaderText = "Unités de mesures"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn6.HeaderText = "Prix unitaire"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 116
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 116
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn7.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 67
        '
        'pn_commande_prof
        '
        Me.pn_commande_prof.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.pn_commande_prof.Controls.Add(Me.Label4)
        Me.pn_commande_prof.Location = New System.Drawing.Point(3, 451)
        Me.pn_commande_prof.Name = "pn_commande_prof"
        Me.pn_commande_prof.Size = New System.Drawing.Size(956, 28)
        Me.pn_commande_prof.TabIndex = 154
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(11, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(229, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Commande de l'enseignant"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel5.Controls.Add(Me.lbl_mode)
        Me.Panel5.Location = New System.Drawing.Point(1, 1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1437, 35)
        Me.Panel5.TabIndex = 153
        '
        'lbl_mode
        '
        Me.lbl_mode.AutoSize = True
        Me.lbl_mode.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lbl_mode.ForeColor = System.Drawing.Color.White
        Me.lbl_mode.Location = New System.Drawing.Point(11, 3)
        Me.lbl_mode.Name = "lbl_mode"
        Me.lbl_mode.Size = New System.Drawing.Size(246, 25)
        Me.lbl_mode.TabIndex = 9
        Me.lbl_mode.Text = "Comparaison de commandes"
        '
        'dgv_Commande_Prof
        '
        Me.dgv_Commande_Prof.AllowUserToAddRows = False
        Me.dgv_Commande_Prof.AllowUserToDeleteRows = False
        Me.dgv_Commande_Prof.AllowUserToResizeColumns = False
        Me.dgv_Commande_Prof.AllowUserToResizeRows = False
        Me.dgv_Commande_Prof.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Commande_Prof.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Commande_Prof.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_Commande_Prof.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Commande_Prof.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column2, Me.Quantité, Me.Column1, Me.Unités, Me.Column3, Me.Column5})
        Me.dgv_Commande_Prof.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgv_Commande_Prof.Location = New System.Drawing.Point(3, 477)
        Me.dgv_Commande_Prof.Name = "dgv_Commande_Prof"
        Me.dgv_Commande_Prof.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Commande_Prof.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_Commande_Prof.RowHeadersVisible = False
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_Commande_Prof.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgv_Commande_Prof.RowTemplate.Height = 25
        Me.dgv_Commande_Prof.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Commande_Prof.Size = New System.Drawing.Size(956, 300)
        Me.dgv_Commande_Prof.TabIndex = 151
        Me.dgv_Commande_Prof.TabStop = False
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.FillWeight = 125.0!
        Me.Column4.HeaderText = "Nom du produit"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Fournisseurs"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Quantité
        '
        Me.Quantité.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Quantité.HeaderText = "Quantité"
        Me.Quantité.Name = "Quantité"
        Me.Quantité.ReadOnly = True
        Me.Quantité.Width = 91
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Format"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Unités
        '
        Me.Unités.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Unités.HeaderText = "Unités de mesures"
        Me.Unités.Name = "Unités"
        Me.Unités.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column3.HeaderText = "Prix unitaire"
        Me.Column3.MinimumWidth = 116
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 116
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column5.HeaderText = "Total"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 67
        '
        'btnRetour
        '
        Me.btnRetour.AutoSize = True
        Me.btnRetour.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnRetour.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnRetour.FlatAppearance.BorderSize = 0
        Me.btnRetour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRetour.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetour.ForeColor = System.Drawing.SystemColors.Control
        Me.btnRetour.Image = Global.projet_dietetique.My.Resources.Resources.baseline_arrow_back_white_24dp
        Me.btnRetour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRetour.Location = New System.Drawing.Point(1, 42)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(210, 38)
        Me.btnRetour.TabIndex = 100
        Me.btnRetour.Tag = "prof"
        Me.btnRetour.Text = "Retour à la commande"
        Me.btnRetour.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRetour.UseVisualStyleBackColor = False
        '
        'usr_comparer_commande
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "usr_comparer_commande"
        Me.Size = New System.Drawing.Size(1438, 835)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pn_vide2.ResumeLayout(False)
        Me.pnl_vide.ResumeLayout(False)
        Me.pnl_vide.PerformLayout()
        CType(Me.dgv_eleves, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pn_liste_etudiant.ResumeLayout(False)
        Me.pn_liste_etudiant.PerformLayout()
        Me.pn_commande_eleve.ResumeLayout(False)
        Me.pn_commande_eleve.PerformLayout()
        CType(Me.dgv_Commande_eleve, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pn_commande_prof.ResumeLayout(False)
        Me.pn_commande_prof.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.dgv_Commande_Prof, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRetour As Button
    Friend WithEvents dgv_Commande_Prof As DataGridView
    Friend WithEvents pn_commande_eleve As Panel
    Friend WithEvents lb_Commande_haut As Label
    Friend WithEvents dgv_Commande_eleve As DataGridView
    Friend WithEvents pn_commande_prof As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_mode As Label
    Friend WithEvents dgv_eleves As DataGridView
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents pn_liste_etudiant As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_sauvegarder As Button
    Friend WithEvents sfd_commande_pdf As SaveFileDialog
    Friend WithEvents btn_ouvrir_pdf As Button
    Friend WithEvents pnl_vide As Panel
    Friend WithEvents lbl_vide As Label
    Friend WithEvents pn_vide2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Quantité As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Unités As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents btn_travaux As Button
End Class
