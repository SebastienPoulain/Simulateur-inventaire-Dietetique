<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usr_associer_utls_cours
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
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_associer = New System.Windows.Forms.Label()
        Me.btn_retour = New System.Windows.Forms.Button()
        Me.grid_etu = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rd_nm = New System.Windows.Forms.RadioButton()
        Me.rd_utls = New System.Windows.Forms.RadioButton()
        Me.txt_recherche = New System.Windows.Forms.TextBox()
        Me.btn_versDroit = New System.Windows.Forms.Button()
        Me.btn_versGauche = New System.Windows.Forms.Button()
        Me.timer_animation = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_ajoutSucces = New System.Windows.Forms.Label()
        Me.btn_selection = New System.Windows.Forms.Button()
        Me.btn_selection2 = New System.Windows.Forms.Button()
        Me.grid_etu_cours = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5.SuspendLayout()
        CType(Me.grid_etu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grid_etu_cours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel5.Controls.Add(Me.lbl_associer)
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1584, 34)
        Me.Panel5.TabIndex = 51
        '
        'lbl_associer
        '
        Me.lbl_associer.AutoSize = True
        Me.lbl_associer.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lbl_associer.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_associer.Location = New System.Drawing.Point(15, 0)
        Me.lbl_associer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_associer.Name = "lbl_associer"
        Me.lbl_associer.Size = New System.Drawing.Size(320, 30)
        Me.lbl_associer.TabIndex = 9
        Me.lbl_associer.Text = "Associer des étudiants au cours "
        '
        'btn_retour
        '
        Me.btn_retour.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_retour.FlatAppearance.BorderSize = 0
        Me.btn_retour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_retour.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_retour.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_retour.Location = New System.Drawing.Point(1407, 702)
        Me.btn_retour.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_retour.Name = "btn_retour"
        Me.btn_retour.Size = New System.Drawing.Size(145, 39)
        Me.btn_retour.TabIndex = 52
        Me.btn_retour.Text = "Retour"
        Me.btn_retour.UseVisualStyleBackColor = False
        '
        'grid_etu
        '
        Me.grid_etu.AllowUserToAddRows = False
        Me.grid_etu.AllowUserToDeleteRows = False
        Me.grid_etu.AllowUserToResizeColumns = False
        Me.grid_etu.AllowUserToResizeRows = False
        Me.grid_etu.BackgroundColor = System.Drawing.Color.White
        Me.grid_etu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_etu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_etu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_etu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.Column4})
        Me.grid_etu.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grid_etu.Location = New System.Drawing.Point(17, 182)
        Me.grid_etu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_etu.Name = "grid_etu"
        Me.grid_etu.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_etu.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grid_etu.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.grid_etu.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.grid_etu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_etu.Size = New System.Drawing.Size(703, 426)
        Me.grid_etu.TabIndex = 53
        Me.grid_etu.TabStop = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Identifiant de l'étudiant"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 190
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Nom de l'étudiant"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(17, 143)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(703, 32)
        Me.Panel1.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(4, 2)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 28)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Liste d'étudiants"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(849, 143)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(703, 32)
        Me.Panel2.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(4, 2)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 28)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Étudiants du cours"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.txt_recherche)
        Me.Panel3.Location = New System.Drawing.Point(17, 59)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1534, 76)
        Me.Panel3.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(17, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Rechercher"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rd_nm)
        Me.GroupBox1.Controls.Add(Me.rd_utls)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(351, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(211, 63)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Avancé"
        '
        'rd_nm
        '
        Me.rd_nm.AutoSize = True
        Me.rd_nm.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_nm.Location = New System.Drawing.Point(13, 26)
        Me.rd_nm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rd_nm.Name = "rd_nm"
        Me.rd_nm.Size = New System.Drawing.Size(63, 24)
        Me.rd_nm.TabIndex = 1
        Me.rd_nm.Text = "Nom"
        Me.rd_nm.UseVisualStyleBackColor = True
        '
        'rd_utls
        '
        Me.rd_utls.AutoSize = True
        Me.rd_utls.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_utls.Location = New System.Drawing.Point(91, 26)
        Me.rd_utls.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rd_utls.Name = "rd_utls"
        Me.rd_utls.Size = New System.Drawing.Size(98, 24)
        Me.rd_utls.TabIndex = 0
        Me.rd_utls.Text = "Identifiant"
        Me.rd_utls.UseVisualStyleBackColor = True
        '
        'txt_recherche
        '
        Me.txt_recherche.Location = New System.Drawing.Point(23, 27)
        Me.txt_recherche.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_recherche.Name = "txt_recherche"
        Me.txt_recherche.Size = New System.Drawing.Size(293, 22)
        Me.txt_recherche.TabIndex = 1
        '
        'btn_versDroit
        '
        Me.btn_versDroit.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_versDroit.FlatAppearance.BorderSize = 0
        Me.btn_versDroit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_versDroit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_versDroit.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btn_versDroit.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_versDroit.Location = New System.Drawing.Point(728, 346)
        Me.btn_versDroit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_versDroit.Name = "btn_versDroit"
        Me.btn_versDroit.Size = New System.Drawing.Size(113, 39)
        Me.btn_versDroit.TabIndex = 57
        Me.btn_versDroit.Text = ">"
        Me.btn_versDroit.UseVisualStyleBackColor = False
        '
        'btn_versGauche
        '
        Me.btn_versGauche.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_versGauche.FlatAppearance.BorderSize = 0
        Me.btn_versGauche.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_versGauche.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_versGauche.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btn_versGauche.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_versGauche.Location = New System.Drawing.Point(728, 393)
        Me.btn_versGauche.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_versGauche.Name = "btn_versGauche"
        Me.btn_versGauche.Size = New System.Drawing.Size(113, 39)
        Me.btn_versGauche.TabIndex = 58
        Me.btn_versGauche.Text = "<"
        Me.btn_versGauche.UseVisualStyleBackColor = False
        '
        'timer_animation
        '
        Me.timer_animation.Interval = 1
        '
        'lbl_ajoutSucces
        '
        Me.lbl_ajoutSucces.BackColor = System.Drawing.Color.Lime
        Me.lbl_ajoutSucces.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_ajoutSucces.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_ajoutSucces.Location = New System.Drawing.Point(16, 654)
        Me.lbl_ajoutSucces.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_ajoutSucces.Name = "lbl_ajoutSucces"
        Me.lbl_ajoutSucces.Size = New System.Drawing.Size(1536, 30)
        Me.lbl_ajoutSucces.TabIndex = 60
        Me.lbl_ajoutSucces.Text = "Transfert réussie"
        Me.lbl_ajoutSucces.Visible = False
        '
        'btn_selection
        '
        Me.btn_selection.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_selection.FlatAppearance.BorderSize = 0
        Me.btn_selection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_selection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_selection.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_selection.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_selection.Location = New System.Drawing.Point(21, 615)
        Me.btn_selection.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_selection.Name = "btn_selection"
        Me.btn_selection.Size = New System.Drawing.Size(183, 34)
        Me.btn_selection.TabIndex = 63
        Me.btn_selection.Tag = "1"
        Me.btn_selection.Text = "Sélectionner tout"
        Me.btn_selection.UseVisualStyleBackColor = False
        '
        'btn_selection2
        '
        Me.btn_selection2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_selection2.FlatAppearance.BorderSize = 0
        Me.btn_selection2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_selection2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_selection2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_selection2.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_selection2.Location = New System.Drawing.Point(851, 615)
        Me.btn_selection2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_selection2.Name = "btn_selection2"
        Me.btn_selection2.Size = New System.Drawing.Size(183, 34)
        Me.btn_selection2.TabIndex = 64
        Me.btn_selection2.Tag = "2"
        Me.btn_selection2.Text = "Sélectionner tout"
        Me.btn_selection2.UseVisualStyleBackColor = False
        '
        'grid_etu_cours
        '
        Me.grid_etu_cours.AllowUserToAddRows = False
        Me.grid_etu_cours.AllowUserToDeleteRows = False
        Me.grid_etu_cours.AllowUserToResizeColumns = False
        Me.grid_etu_cours.AllowUserToResizeRows = False
        Me.grid_etu_cours.BackgroundColor = System.Drawing.Color.White
        Me.grid_etu_cours.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_etu_cours.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.grid_etu_cours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_etu_cours.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.grid_etu_cours.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grid_etu_cours.Location = New System.Drawing.Point(849, 182)
        Me.grid_etu_cours.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_etu_cours.Name = "grid_etu_cours"
        Me.grid_etu_cours.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_etu_cours.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grid_etu_cours.RowHeadersVisible = False
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.grid_etu_cours.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.grid_etu_cours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_etu_cours.Size = New System.Drawing.Size(703, 426)
        Me.grid_etu_cours.TabIndex = 65
        Me.grid_etu_cours.TabStop = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Identifiant de l'étudiant"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 190
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nom de l'étudiant"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'usr_associer_utls_cours
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grid_etu_cours)
        Me.Controls.Add(Me.btn_selection2)
        Me.Controls.Add(Me.btn_selection)
        Me.Controls.Add(Me.lbl_ajoutSucces)
        Me.Controls.Add(Me.btn_versGauche)
        Me.Controls.Add(Me.btn_versDroit)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grid_etu)
        Me.Controls.Add(Me.btn_retour)
        Me.Controls.Add(Me.Panel5)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "usr_associer_utls_cours"
        Me.Size = New System.Drawing.Size(1584, 978)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.grid_etu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grid_etu_cours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_associer As Label
    Friend WithEvents btn_retour As Button
    Friend WithEvents grid_etu As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rd_nm As RadioButton
    Friend WithEvents rd_utls As RadioButton
    Friend WithEvents txt_recherche As TextBox
    Friend WithEvents btn_versDroit As Button
    Friend WithEvents btn_versGauche As Button
    Friend WithEvents timer_animation As Timer
    Friend WithEvents lbl_ajoutSucces As Label
    Friend WithEvents btn_selection As Button
    Friend WithEvents btn_selection2 As Button
    Friend WithEvents grid_etu_cours As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
