<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usr_gestion_cours
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grid_cours = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_supprimer = New System.Windows.Forms.Button()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.txt_noCours = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_ajouter = New System.Windows.Forms.Button()
        Me.txt_nmCours = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nud_groupe = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbE_noCours = New System.Windows.Forms.Label()
        Me.btn_modifier = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbE_nomCours = New System.Windows.Forms.Label()
        CType(Me.grid_cours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_groupe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid_cours
        '
        Me.grid_cours.AllowUserToAddRows = False
        Me.grid_cours.AllowUserToDeleteRows = False
        Me.grid_cours.AllowUserToResizeColumns = False
        Me.grid_cours.AllowUserToResizeRows = False
        Me.grid_cours.BackgroundColor = System.Drawing.SystemColors.Control
        Me.grid_cours.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.grid_cours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_cours.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.grid_cours.Location = New System.Drawing.Point(18, 27)
        Me.grid_cours.MultiSelect = False
        Me.grid_cours.Name = "grid_cours"
        Me.grid_cours.ReadOnly = True
        Me.grid_cours.RowHeadersVisible = False
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGreen
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grid_cours.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_cours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_cours.Size = New System.Drawing.Size(372, 184)
        Me.grid_cours.TabIndex = 6
        '
        'Column1
        '
        Me.Column1.HeaderText = "No. de cours"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nom de cours"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 250
        '
        'btn_supprimer
        '
        Me.btn_supprimer.BackColor = System.Drawing.Color.Silver
        Me.btn_supprimer.FlatAppearance.BorderSize = 0
        Me.btn_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_supprimer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_supprimer.Location = New System.Drawing.Point(212, 152)
        Me.btn_supprimer.Name = "btn_supprimer"
        Me.btn_supprimer.Size = New System.Drawing.Size(95, 32)
        Me.btn_supprimer.TabIndex = 17
        Me.btn_supprimer.Text = "Supprimer"
        Me.btn_supprimer.UseVisualStyleBackColor = False
        '
        'btn_annuler
        '
        Me.btn_annuler.BackColor = System.Drawing.Color.LightBlue
        Me.btn_annuler.Enabled = False
        Me.btn_annuler.FlatAppearance.BorderSize = 0
        Me.btn_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_annuler.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annuler.Location = New System.Drawing.Point(313, 152)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(95, 32)
        Me.btn_annuler.TabIndex = 16
        Me.btn_annuler.Text = "Annuler"
        Me.btn_annuler.UseVisualStyleBackColor = False
        '
        'txt_noCours
        '
        Me.txt_noCours.Enabled = False
        Me.txt_noCours.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_noCours.Location = New System.Drawing.Point(11, 38)
        Me.txt_noCours.MaxLength = 10
        Me.txt_noCours.Name = "txt_noCours"
        Me.txt_noCours.Size = New System.Drawing.Size(100, 22)
        Me.txt_noCours.TabIndex = 14
        Me.txt_noCours.Tag = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "No. de cours"
        '
        'btn_ajouter
        '
        Me.btn_ajouter.BackColor = System.Drawing.Color.LightGreen
        Me.btn_ajouter.FlatAppearance.BorderSize = 0
        Me.btn_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ajouter.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajouter.Location = New System.Drawing.Point(10, 152)
        Me.btn_ajouter.Name = "btn_ajouter"
        Me.btn_ajouter.Size = New System.Drawing.Size(95, 32)
        Me.btn_ajouter.TabIndex = 15
        Me.btn_ajouter.Text = "Ajouter"
        Me.btn_ajouter.UseVisualStyleBackColor = False
        '
        'txt_nmCours
        '
        Me.txt_nmCours.Enabled = False
        Me.txt_nmCours.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nmCours.Location = New System.Drawing.Point(11, 101)
        Me.txt_nmCours.MaxLength = 50
        Me.txt_nmCours.Name = "txt_nmCours"
        Me.txt_nmCours.Size = New System.Drawing.Size(199, 22)
        Me.txt_nmCours.TabIndex = 19
        Me.txt_nmCours.Tag = "3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Nom du cours"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(112, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(12, 15)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "-"
        '
        'nud_groupe
        '
        Me.nud_groupe.Enabled = False
        Me.nud_groupe.Location = New System.Drawing.Point(130, 38)
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
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(127, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 15)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "No. de groupe"
        '
        'lbE_noCours
        '
        Me.lbE_noCours.AutoSize = True
        Me.lbE_noCours.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lbE_noCours.ForeColor = System.Drawing.Color.DarkGray
        Me.lbE_noCours.Location = New System.Drawing.Point(11, 60)
        Me.lbE_noCours.Name = "lbE_noCours"
        Me.lbE_noCours.Size = New System.Drawing.Size(61, 13)
        Me.lbE_noCours.TabIndex = 23
        Me.lbE_noCours.Text = "101-1Z4-RI"
        '
        'btn_modifier
        '
        Me.btn_modifier.BackColor = System.Drawing.Color.LightGreen
        Me.btn_modifier.FlatAppearance.BorderSize = 0
        Me.btn_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_modifier.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modifier.Location = New System.Drawing.Point(111, 152)
        Me.btn_modifier.Name = "btn_modifier"
        Me.btn_modifier.Size = New System.Drawing.Size(95, 32)
        Me.btn_modifier.TabIndex = 24
        Me.btn_modifier.Text = "Modifier"
        Me.btn_modifier.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbE_nomCours)
        Me.GroupBox1.Controls.Add(Me.btn_supprimer)
        Me.GroupBox1.Controls.Add(Me.btn_modifier)
        Me.GroupBox1.Controls.Add(Me.btn_ajouter)
        Me.GroupBox1.Controls.Add(Me.lbE_noCours)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_noCours)
        Me.GroupBox1.Controls.Add(Me.nud_groupe)
        Me.GroupBox1.Controls.Add(Me.btn_annuler)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_nmCours)
        Me.GroupBox1.Location = New System.Drawing.Point(396, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(498, 190)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cours"
        '
        'lbE_nomCours
        '
        Me.lbE_nomCours.AutoSize = True
        Me.lbE_nomCours.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lbE_nomCours.ForeColor = System.Drawing.Color.Firebrick
        Me.lbE_nomCours.Location = New System.Drawing.Point(11, 126)
        Me.lbE_nomCours.Name = "lbE_nomCours"
        Me.lbE_nomCours.Size = New System.Drawing.Size(141, 13)
        Me.lbE_nomCours.TabIndex = 25
        Me.lbE_nomCours.Text = "Saisissez un nom de cours"
        Me.lbE_nomCours.Visible = False
        '
        'usr_gestion_cours
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grid_cours)
        Me.Name = "usr_gestion_cours"
        Me.Size = New System.Drawing.Size(935, 425)
        CType(Me.grid_cours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_groupe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grid_cours As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents btn_supprimer As Button
    Friend WithEvents btn_annuler As Button
    Friend WithEvents txt_noCours As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents txt_nmCours As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents nud_groupe As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents lbE_noCours As Label
    Friend WithEvents btn_modifier As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbE_nomCours As Label
End Class
