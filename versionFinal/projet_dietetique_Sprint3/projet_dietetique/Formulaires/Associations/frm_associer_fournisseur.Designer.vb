<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_associer_fournisseur
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnl_navigation = New System.Windows.Forms.Panel()
        Me.lbl_nom_nav = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_titre = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_minimize = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rd_ville = New System.Windows.Forms.RadioButton()
        Me.rd_nom = New System.Windows.Forms.RadioButton()
        Me.txt_recherche = New System.Windows.Forms.TextBox()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.btn_associer = New System.Windows.Forms.Button()
        Me.btn_versGauche = New System.Windows.Forms.Button()
        Me.btn_versDroit = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl_nom_asso = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_associes = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cln_prix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_non_associes = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnl_navigation.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_associes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_non_associes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_navigation
        '
        Me.pnl_navigation.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.pnl_navigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_navigation.Controls.Add(Me.lbl_nom_nav)
        Me.pnl_navigation.Controls.Add(Me.Panel3)
        Me.pnl_navigation.Controls.Add(Me.lbl_titre)
        Me.pnl_navigation.Controls.Add(Me.btn_exit)
        Me.pnl_navigation.Controls.Add(Me.btn_minimize)
        Me.pnl_navigation.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_navigation.Location = New System.Drawing.Point(0, 0)
        Me.pnl_navigation.Name = "pnl_navigation"
        Me.pnl_navigation.Size = New System.Drawing.Size(1400, 30)
        Me.pnl_navigation.TabIndex = 60
        '
        'lbl_nom_nav
        '
        Me.lbl_nom_nav.AutoSize = True
        Me.lbl_nom_nav.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nom_nav.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_nom_nav.Location = New System.Drawing.Point(284, 5)
        Me.lbl_nom_nav.Name = "lbl_nom_nav"
        Me.lbl_nom_nav.Size = New System.Drawing.Size(82, 17)
        Me.lbl_nom_nav.TabIndex = 4
        Me.lbl_nom_nav.Text = "-- produit --"
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
        Me.lbl_titre.Size = New System.Drawing.Size(269, 17)
        Me.lbl_titre.TabIndex = 2
        Me.lbl_titre.Text = "Associer un ou des fournisseurs au produit"
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
        Me.btn_exit.Location = New System.Drawing.Point(1348, 0)
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
        Me.btn_minimize.Location = New System.Drawing.Point(1298, 0)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(50, 28)
        Me.btn_minimize.TabIndex = 0
        Me.btn_minimize.TabStop = False
        Me.btn_minimize.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.GroupBox1)
        Me.Panel5.Controls.Add(Me.txt_recherche)
        Me.Panel5.Location = New System.Drawing.Point(16, 52)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(581, 62)
        Me.Panel5.TabIndex = 161
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(13, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Rechercher"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rd_ville)
        Me.GroupBox1.Controls.Add(Me.rd_nom)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(263, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(169, 51)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Avancé"
        '
        'rd_ville
        '
        Me.rd_ville.AutoSize = True
        Me.rd_ville.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_ville.Location = New System.Drawing.Point(83, 21)
        Me.rd_ville.Name = "rd_ville"
        Me.rd_ville.Size = New System.Drawing.Size(47, 19)
        Me.rd_ville.TabIndex = 2
        Me.rd_ville.Text = "Ville"
        Me.rd_ville.UseVisualStyleBackColor = True
        '
        'rd_nom
        '
        Me.rd_nom.AutoSize = True
        Me.rd_nom.Checked = True
        Me.rd_nom.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_nom.Location = New System.Drawing.Point(16, 21)
        Me.rd_nom.Name = "rd_nom"
        Me.rd_nom.Size = New System.Drawing.Size(52, 19)
        Me.rd_nom.TabIndex = 0
        Me.rd_nom.TabStop = True
        Me.rd_nom.Text = "Nom"
        Me.rd_nom.UseVisualStyleBackColor = True
        '
        'txt_recherche
        '
        Me.txt_recherche.Location = New System.Drawing.Point(17, 22)
        Me.txt_recherche.Name = "txt_recherche"
        Me.txt_recherche.Size = New System.Drawing.Size(221, 20)
        Me.txt_recherche.TabIndex = 1
        '
        'btn_annuler
        '
        Me.btn_annuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_annuler.FlatAppearance.BorderSize = 0
        Me.btn_annuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_annuler.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annuler.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_annuler.Location = New System.Drawing.Point(1173, 652)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(85, 32)
        Me.btn_annuler.TabIndex = 170
        Me.btn_annuler.Text = "Annuler"
        Me.btn_annuler.UseVisualStyleBackColor = False
        '
        'btn_associer
        '
        Me.btn_associer.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_associer.FlatAppearance.BorderSize = 0
        Me.btn_associer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_associer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_associer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_associer.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_associer.Location = New System.Drawing.Point(1274, 652)
        Me.btn_associer.Name = "btn_associer"
        Me.btn_associer.Size = New System.Drawing.Size(85, 32)
        Me.btn_associer.TabIndex = 169
        Me.btn_associer.Text = "Associer"
        Me.btn_associer.UseVisualStyleBackColor = False
        '
        'btn_versGauche
        '
        Me.btn_versGauche.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_versGauche.FlatAppearance.BorderSize = 0
        Me.btn_versGauche.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_versGauche.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_versGauche.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btn_versGauche.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_versGauche.Location = New System.Drawing.Point(619, 400)
        Me.btn_versGauche.Name = "btn_versGauche"
        Me.btn_versGauche.Size = New System.Drawing.Size(85, 32)
        Me.btn_versGauche.TabIndex = 168
        Me.btn_versGauche.Text = "<"
        Me.btn_versGauche.UseVisualStyleBackColor = False
        '
        'btn_versDroit
        '
        Me.btn_versDroit.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_versDroit.FlatAppearance.BorderSize = 0
        Me.btn_versDroit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_versDroit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_versDroit.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btn_versDroit.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_versDroit.Location = New System.Drawing.Point(619, 362)
        Me.btn_versDroit.Name = "btn_versDroit"
        Me.btn_versDroit.Size = New System.Drawing.Size(85, 32)
        Me.btn_versDroit.TabIndex = 167
        Me.btn_versDroit.Text = ">"
        Me.btn_versDroit.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel4.Controls.Add(Me.lbl_nom_asso)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(717, 120)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(642, 26)
        Me.Panel4.TabIndex = 166
        '
        'lbl_nom_asso
        '
        Me.lbl_nom_asso.AutoSize = True
        Me.lbl_nom_asso.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nom_asso.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_nom_asso.Location = New System.Drawing.Point(245, 2)
        Me.lbl_nom_asso.Name = "lbl_nom_asso"
        Me.lbl_nom_asso.Size = New System.Drawing.Size(97, 21)
        Me.lbl_nom_asso.TabIndex = 158
        Me.lbl_nom_asso.Text = "-- produit --"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(3, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(236, 21)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Liste des fournisseurs associés à:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(16, 120)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(582, 26)
        Me.Panel2.TabIndex = 165
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(3, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 21)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Liste des fournisseurs non-associés"
        '
        'dgv_associes
        '
        Me.dgv_associes.AllowUserToAddRows = False
        Me.dgv_associes.AllowUserToDeleteRows = False
        Me.dgv_associes.AllowUserToResizeColumns = False
        Me.dgv_associes.AllowUserToResizeRows = False
        Me.dgv_associes.BackgroundColor = System.Drawing.Color.White
        Me.dgv_associes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_associes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_associes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_associes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.Column4, Me.Column1, Me.Column5, Me.cln_prix})
        Me.dgv_associes.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgv_associes.Location = New System.Drawing.Point(717, 152)
        Me.dgv_associes.Name = "dgv_associes"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_associes.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgv_associes.RowHeadersVisible = False
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_associes.RowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgv_associes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_associes.Size = New System.Drawing.Size(642, 485)
        Me.dgv_associes.TabIndex = 163
        Me.dgv_associes.TabStop = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nom"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Ville"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Adresse"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 180
        '
        'Column5
        '
        Me.Column5.HeaderText = "Code postal"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 95
        '
        'cln_prix
        '
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.Format = "C2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.cln_prix.DefaultCellStyle = DataGridViewCellStyle9
        Me.cln_prix.HeaderText = "Prix"
        Me.cln_prix.Name = "cln_prix"
        Me.cln_prix.Width = 70
        '
        'dgv_non_associes
        '
        Me.dgv_non_associes.AllowUserToAddRows = False
        Me.dgv_non_associes.AllowUserToDeleteRows = False
        Me.dgv_non_associes.AllowUserToResizeColumns = False
        Me.dgv_non_associes.AllowUserToResizeRows = False
        Me.dgv_non_associes.BackgroundColor = System.Drawing.Color.White
        Me.dgv_non_associes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_non_associes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgv_non_associes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_non_associes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.Column2, Me.Column3})
        Me.dgv_non_associes.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgv_non_associes.Location = New System.Drawing.Point(16, 152)
        Me.dgv_non_associes.Name = "dgv_non_associes"
        Me.dgv_non_associes.ReadOnly = True
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_non_associes.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgv_non_associes.RowHeadersVisible = False
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_non_associes.RowsDefaultCellStyle = DataGridViewCellStyle14
        Me.dgv_non_associes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_non_associes.Size = New System.Drawing.Size(581, 485)
        Me.dgv_non_associes.TabIndex = 171
        Me.dgv_non_associes.TabStop = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.HeaderText = "Nom"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Ville"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Adresse"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "Code postal"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 95
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1400, 720)
        Me.Panel1.TabIndex = 172
        '
        'frm_associer_fournisseur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1400, 720)
        Me.Controls.Add(Me.dgv_non_associes)
        Me.Controls.Add(Me.btn_annuler)
        Me.Controls.Add(Me.btn_associer)
        Me.Controls.Add(Me.btn_versGauche)
        Me.Controls.Add(Me.btn_versDroit)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgv_associes)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.pnl_navigation)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_associer_fournisseur"
        Me.Text = "frm_associer_fournisseur"
        Me.pnl_navigation.ResumeLayout(False)
        Me.pnl_navigation.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgv_associes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_non_associes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_navigation As Panel
    Friend WithEvents lbl_nom_nav As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbl_titre As Label
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_minimize As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rd_ville As RadioButton
    Friend WithEvents rd_nom As RadioButton
    Friend WithEvents txt_recherche As TextBox
    Friend WithEvents btn_annuler As Button
    Friend WithEvents btn_associer As Button
    Friend WithEvents btn_versGauche As Button
    Friend WithEvents btn_versDroit As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbl_nom_asso As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_associes As DataGridView
    Friend WithEvents dgv_non_associes As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents cln_prix As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
End Class
