<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usr_profil
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_pnm = New System.Windows.Forms.Button()
        Me.lbl_pnm = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_nom = New System.Windows.Forms.Button()
        Me.btn_mdp = New System.Windows.Forms.Button()
        Me.lbl_nom = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_titre = New System.Windows.Forms.Label()
        Me.lbl_identifiant = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grid_cours = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnl_cours = New System.Windows.Forms.Panel()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.grid_cours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_cours.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1584, 43)
        Me.Panel4.TabIndex = 52
        Me.Panel4.TabStop = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(15, 6)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 32)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Mon profil"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Location = New System.Drawing.Point(0, 49)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1584, 34)
        Me.Panel5.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(15, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(246, 30)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Informations du compte"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_pnm)
        Me.Panel1.Controls.Add(Me.lbl_pnm)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btn_nom)
        Me.Panel1.Controls.Add(Me.btn_mdp)
        Me.Panel1.Controls.Add(Me.lbl_nom)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lbl_titre)
        Me.Panel1.Controls.Add(Me.lbl_identifiant)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(4, 91)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1575, 322)
        Me.Panel1.TabIndex = 54
        '
        'btn_pnm
        '
        Me.btn_pnm.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_pnm.FlatAppearance.BorderSize = 0
        Me.btn_pnm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_pnm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pnm.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pnm.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_pnm.Location = New System.Drawing.Point(729, 102)
        Me.btn_pnm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_pnm.Name = "btn_pnm"
        Me.btn_pnm.Size = New System.Drawing.Size(227, 33)
        Me.btn_pnm.TabIndex = 67
        Me.btn_pnm.Text = "Modifier mon prénom"
        Me.btn_pnm.UseVisualStyleBackColor = False
        '
        'lbl_pnm
        '
        Me.lbl_pnm.AutoSize = True
        Me.lbl_pnm.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_pnm.ForeColor = System.Drawing.Color.Black
        Me.lbl_pnm.Location = New System.Drawing.Point(197, 111)
        Me.lbl_pnm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_pnm.Name = "lbl_pnm"
        Me.lbl_pnm.Size = New System.Drawing.Size(102, 25)
        Me.lbl_pnm.TabIndex = 66
        Me.lbl_pnm.Text = "Identifiant"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(105, 111)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 25)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Prénom:"
        '
        'btn_nom
        '
        Me.btn_nom.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_nom.FlatAppearance.BorderSize = 0
        Me.btn_nom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_nom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nom.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nom.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_nom.Location = New System.Drawing.Point(729, 53)
        Me.btn_nom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_nom.Name = "btn_nom"
        Me.btn_nom.Size = New System.Drawing.Size(227, 33)
        Me.btn_nom.TabIndex = 64
        Me.btn_nom.Text = "Modifier mon nom"
        Me.btn_nom.UseVisualStyleBackColor = False
        '
        'btn_mdp
        '
        Me.btn_mdp.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_mdp.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_mdp.FlatAppearance.BorderSize = 0
        Me.btn_mdp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_mdp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mdp.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mdp.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_mdp.Location = New System.Drawing.Point(197, 201)
        Me.btn_mdp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_mdp.Name = "btn_mdp"
        Me.btn_mdp.Size = New System.Drawing.Size(227, 36)
        Me.btn_mdp.TabIndex = 63
        Me.btn_mdp.Text = "Modifier mon mot de passe"
        Me.btn_mdp.UseVisualStyleBackColor = False
        '
        'lbl_nom
        '
        Me.lbl_nom.AutoSize = True
        Me.lbl_nom.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_nom.ForeColor = System.Drawing.Color.Black
        Me.lbl_nom.Location = New System.Drawing.Point(197, 62)
        Me.lbl_nom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nom.Name = "lbl_nom"
        Me.lbl_nom.Size = New System.Drawing.Size(102, 25)
        Me.lbl_nom.TabIndex = 58
        Me.lbl_nom.Text = "Identifiant"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(129, 62)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 25)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Nom:"
        '
        'lbl_titre
        '
        Me.lbl_titre.AutoSize = True
        Me.lbl_titre.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_titre.ForeColor = System.Drawing.Color.Black
        Me.lbl_titre.Location = New System.Drawing.Point(200, 257)
        Me.lbl_titre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_titre.Name = "lbl_titre"
        Me.lbl_titre.Size = New System.Drawing.Size(102, 25)
        Me.lbl_titre.TabIndex = 61
        Me.lbl_titre.Text = "Identifiant"
        '
        'lbl_identifiant
        '
        Me.lbl_identifiant.AutoSize = True
        Me.lbl_identifiant.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_identifiant.ForeColor = System.Drawing.Color.Black
        Me.lbl_identifiant.Location = New System.Drawing.Point(197, 15)
        Me.lbl_identifiant.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_identifiant.Name = "lbl_identifiant"
        Me.lbl_identifiant.Size = New System.Drawing.Size(102, 25)
        Me.lbl_identifiant.TabIndex = 56
        Me.lbl_identifiant.Text = "Identifiant"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(83, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 25)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Identifiant:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(31, 257)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(149, 25)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "Type de compte:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(55, 204)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 25)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Mot de passe:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(0, 1)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1584, 34)
        Me.Panel2.TabIndex = 54
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(15, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 30)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Mes cours"
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_cours.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_cours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_cours.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.grid_cours.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grid_cours.Location = New System.Drawing.Point(4, 43)
        Me.grid_cours.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.grid_cours.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.grid_cours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_cours.Size = New System.Drawing.Size(1576, 481)
        Me.grid_cours.TabIndex = 55
        Me.grid_cours.TabStop = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "No. de cours"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 250
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Nom de cours"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Nom de professeur"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'pnl_cours
        '
        Me.pnl_cours.Controls.Add(Me.grid_cours)
        Me.pnl_cours.Controls.Add(Me.Panel2)
        Me.pnl_cours.Location = New System.Drawing.Point(0, 421)
        Me.pnl_cours.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnl_cours.Name = "pnl_cours"
        Me.pnl_cours.Size = New System.Drawing.Size(1584, 593)
        Me.pnl_cours.TabIndex = 56
        '
        'usr_profil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnl_cours)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "usr_profil"
        Me.Size = New System.Drawing.Size(1584, 1028)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.grid_cours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_cours.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_identifiant As Label
    Friend WithEvents lbl_titre As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_nom As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_nom As Button
    Friend WithEvents btn_mdp As Button
    Friend WithEvents btn_pnm As Button
    Friend WithEvents lbl_pnm As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents grid_cours As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents pnl_cours As Panel
End Class
