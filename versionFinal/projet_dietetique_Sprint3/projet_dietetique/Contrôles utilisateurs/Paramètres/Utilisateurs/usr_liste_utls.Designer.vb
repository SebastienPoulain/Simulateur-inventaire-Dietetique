<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usr_liste_utls
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
        Me.grid_utls = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_recherche = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_titre = New System.Windows.Forms.Label()
        Me.cbo_titre = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbo_type = New System.Windows.Forms.ComboBox()
        Me.gb_statut = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbo_statut = New System.Windows.Forms.ComboBox()
        Me.btn_selectionner = New System.Windows.Forms.Button()
        Me.btn_changerMdp = New System.Windows.Forms.Button()
        Me.btn_modifierNm = New System.Windows.Forms.Button()
        Me.lbl_ajoutSucces = New System.Windows.Forms.Label()
        Me.timer_succes = New System.Windows.Forms.Timer(Me.components)
        Me.btn_excel = New System.Windows.Forms.Button()
        Me.btn_modifierPnm = New System.Windows.Forms.Button()
        Me.btn_desac = New System.Windows.Forms.Button()
        Me.btn_activer = New System.Windows.Forms.Button()
        CType(Me.grid_utls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.gb_statut.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid_utls
        '
        Me.grid_utls.AllowUserToAddRows = False
        Me.grid_utls.AllowUserToDeleteRows = False
        Me.grid_utls.AllowUserToResizeColumns = False
        Me.grid_utls.AllowUserToResizeRows = False
        Me.grid_utls.BackgroundColor = System.Drawing.Color.White
        Me.grid_utls.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_utls.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_utls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_utls.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column4, Me.Column2, Me.Column3})
        Me.grid_utls.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grid_utls.Location = New System.Drawing.Point(3, 75)
        Me.grid_utls.Name = "grid_utls"
        Me.grid_utls.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_utls.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grid_utls.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.grid_utls.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.grid_utls.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_utls.Size = New System.Drawing.Size(1164, 408)
        Me.grid_utls.TabIndex = 7
        Me.grid_utls.TabStop = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Identifiant"
        Me.Column1.MaxInputLength = 35
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Prénom"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 345
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nom"
        Me.Column2.MaxInputLength = 50
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 345
        '
        'Column3
        '
        Me.Column3.HeaderText = "Titre"
        Me.Column3.MaxInputLength = 50
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 250
        '
        'txt_recherche
        '
        Me.txt_recherche.Location = New System.Drawing.Point(17, 22)
        Me.txt_recherche.Name = "txt_recherche"
        Me.txt_recherche.Size = New System.Drawing.Size(310, 20)
        Me.txt_recherche.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(13, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Rechercher"
        '
        'lbl_titre
        '
        Me.lbl_titre.AutoSize = True
        Me.lbl_titre.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titre.ForeColor = System.Drawing.Color.Black
        Me.lbl_titre.Location = New System.Drawing.Point(511, 22)
        Me.lbl_titre.Name = "lbl_titre"
        Me.lbl_titre.Size = New System.Drawing.Size(34, 17)
        Me.lbl_titre.TabIndex = 46
        Me.lbl_titre.Text = "Titre"
        Me.lbl_titre.Visible = False
        '
        'cbo_titre
        '
        Me.cbo_titre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_titre.FormattingEnabled = True
        Me.cbo_titre.Location = New System.Drawing.Point(551, 22)
        Me.cbo_titre.Name = "cbo_titre"
        Me.cbo_titre.Size = New System.Drawing.Size(121, 21)
        Me.cbo_titre.TabIndex = 3
        Me.cbo_titre.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.cbo_type)
        Me.Panel3.Controls.Add(Me.lbl_titre)
        Me.Panel3.Controls.Add(Me.gb_statut)
        Me.Panel3.Controls.Add(Me.cbo_titre)
        Me.Panel3.Controls.Add(Me.btn_selectionner)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txt_recherche)
        Me.Panel3.Location = New System.Drawing.Point(3, 7)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1164, 62)
        Me.Panel3.TabIndex = 46
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(333, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 17)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Par"
        '
        'cbo_type
        '
        Me.cbo_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_type.FormattingEnabled = True
        Me.cbo_type.Items.AddRange(New Object() {"Identifiant", "Prénom", "Nom"})
        Me.cbo_type.Location = New System.Drawing.Point(366, 22)
        Me.cbo_type.Name = "cbo_type"
        Me.cbo_type.Size = New System.Drawing.Size(121, 21)
        Me.cbo_type.TabIndex = 2
        '
        'gb_statut
        '
        Me.gb_statut.Controls.Add(Me.Label3)
        Me.gb_statut.Controls.Add(Me.cbo_statut)
        Me.gb_statut.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_statut.Location = New System.Drawing.Point(700, 5)
        Me.gb_statut.Name = "gb_statut"
        Me.gb_statut.Size = New System.Drawing.Size(188, 51)
        Me.gb_statut.TabIndex = 47
        Me.gb_statut.TabStop = False
        Me.gb_statut.Text = "Admin"
        Me.gb_statut.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(9, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 17)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Statut"
        '
        'cbo_statut
        '
        Me.cbo_statut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_statut.FormattingEnabled = True
        Me.cbo_statut.Items.AddRange(New Object() {"Actif", "Inactif", "Tous"})
        Me.cbo_statut.Location = New System.Drawing.Point(56, 17)
        Me.cbo_statut.Name = "cbo_statut"
        Me.cbo_statut.Size = New System.Drawing.Size(121, 21)
        Me.cbo_statut.TabIndex = 4
        '
        'btn_selectionner
        '
        Me.btn_selectionner.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_selectionner.FlatAppearance.BorderSize = 0
        Me.btn_selectionner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_selectionner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_selectionner.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_selectionner.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_selectionner.Location = New System.Drawing.Point(1013, 17)
        Me.btn_selectionner.Name = "btn_selectionner"
        Me.btn_selectionner.Size = New System.Drawing.Size(137, 28)
        Me.btn_selectionner.TabIndex = 5
        Me.btn_selectionner.Text = "Sélectionner tout"
        Me.btn_selectionner.UseVisualStyleBackColor = False
        '
        'btn_changerMdp
        '
        Me.btn_changerMdp.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_changerMdp.Enabled = False
        Me.btn_changerMdp.FlatAppearance.BorderSize = 0
        Me.btn_changerMdp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_changerMdp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_changerMdp.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_changerMdp.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_changerMdp.Location = New System.Drawing.Point(3, 489)
        Me.btn_changerMdp.Name = "btn_changerMdp"
        Me.btn_changerMdp.Size = New System.Drawing.Size(184, 32)
        Me.btn_changerMdp.TabIndex = 6
        Me.btn_changerMdp.Text = "Réinitialiser des mots de passe"
        Me.btn_changerMdp.UseVisualStyleBackColor = False
        '
        'btn_modifierNm
        '
        Me.btn_modifierNm.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_modifierNm.Enabled = False
        Me.btn_modifierNm.FlatAppearance.BorderSize = 0
        Me.btn_modifierNm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_modifierNm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_modifierNm.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modifierNm.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_modifierNm.Location = New System.Drawing.Point(383, 489)
        Me.btn_modifierNm.Name = "btn_modifierNm"
        Me.btn_modifierNm.Size = New System.Drawing.Size(184, 32)
        Me.btn_modifierNm.TabIndex = 8
        Me.btn_modifierNm.Text = "Modifier un nom"
        Me.btn_modifierNm.UseVisualStyleBackColor = False
        '
        'lbl_ajoutSucces
        '
        Me.lbl_ajoutSucces.BackColor = System.Drawing.Color.Lime
        Me.lbl_ajoutSucces.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_ajoutSucces.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_ajoutSucces.Location = New System.Drawing.Point(3, 524)
        Me.lbl_ajoutSucces.Name = "lbl_ajoutSucces"
        Me.lbl_ajoutSucces.Size = New System.Drawing.Size(1164, 24)
        Me.lbl_ajoutSucces.TabIndex = 50
        Me.lbl_ajoutSucces.Text = "Suppression réussie."
        Me.lbl_ajoutSucces.Visible = False
        '
        'timer_succes
        '
        Me.timer_succes.Interval = 1
        '
        'btn_excel
        '
        Me.btn_excel.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btn_excel.FlatAppearance.BorderSize = 0
        Me.btn_excel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_excel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_excel.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_excel.Location = New System.Drawing.Point(573, 489)
        Me.btn_excel.Name = "btn_excel"
        Me.btn_excel.Size = New System.Drawing.Size(115, 32)
        Me.btn_excel.TabIndex = 9
        Me.btn_excel.Text = "Ouvrir avec Excel"
        Me.btn_excel.UseVisualStyleBackColor = False
        '
        'btn_modifierPnm
        '
        Me.btn_modifierPnm.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_modifierPnm.Enabled = False
        Me.btn_modifierPnm.FlatAppearance.BorderSize = 0
        Me.btn_modifierPnm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_modifierPnm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_modifierPnm.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modifierPnm.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_modifierPnm.Location = New System.Drawing.Point(193, 489)
        Me.btn_modifierPnm.Name = "btn_modifierPnm"
        Me.btn_modifierPnm.Size = New System.Drawing.Size(184, 32)
        Me.btn_modifierPnm.TabIndex = 7
        Me.btn_modifierPnm.Text = "Modifier un prénom"
        Me.btn_modifierPnm.UseVisualStyleBackColor = False
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
        Me.btn_desac.Location = New System.Drawing.Point(1072, 489)
        Me.btn_desac.Name = "btn_desac"
        Me.btn_desac.Size = New System.Drawing.Size(95, 32)
        Me.btn_desac.TabIndex = 11
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
        Me.btn_activer.Location = New System.Drawing.Point(971, 489)
        Me.btn_activer.Name = "btn_activer"
        Me.btn_activer.Size = New System.Drawing.Size(95, 32)
        Me.btn_activer.TabIndex = 10
        Me.btn_activer.Text = "Activer"
        Me.btn_activer.UseVisualStyleBackColor = False
        Me.btn_activer.Visible = False
        '
        'usr_liste_utls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_activer)
        Me.Controls.Add(Me.btn_desac)
        Me.Controls.Add(Me.btn_modifierPnm)
        Me.Controls.Add(Me.btn_excel)
        Me.Controls.Add(Me.lbl_ajoutSucces)
        Me.Controls.Add(Me.btn_modifierNm)
        Me.Controls.Add(Me.btn_changerMdp)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.grid_utls)
        Me.Name = "usr_liste_utls"
        Me.Size = New System.Drawing.Size(1170, 550)
        CType(Me.grid_utls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.gb_statut.ResumeLayout(False)
        Me.gb_statut.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grid_utls As DataGridView
    Friend WithEvents txt_recherche As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_changerMdp As Button
    Friend WithEvents lbl_titre As Label
    Friend WithEvents cbo_titre As ComboBox
    Friend WithEvents btn_modifierNm As Button
    Friend WithEvents lbl_ajoutSucces As Label
    Friend WithEvents timer_succes As Timer
    Friend WithEvents btn_excel As Button
    Friend WithEvents btn_selectionner As Button
    Friend WithEvents btn_modifierPnm As Button
    Friend WithEvents gb_statut As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbo_statut As ComboBox
    Friend WithEvents btn_desac As Button
    Friend WithEvents btn_activer As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cbo_type As ComboBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
