<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usr_exercices_A
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnl_principal_ex = New System.Windows.Forms.Panel()
        Me.lbl_ajoutSucces = New System.Windows.Forms.Label()
        Me.btn_activer = New System.Windows.Forms.Button()
        Me.btn_desac = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbo_type = New System.Windows.Forms.ComboBox()
        Me.cbo_statut = New System.Windows.Forms.ComboBox()
        Me.btn_selectionner = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_recherche = New System.Windows.Forms.TextBox()
        Me.grid_ex = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timer_succes = New System.Windows.Forms.Timer(Me.components)
        Me.Panel4.SuspendLayout()
        Me.pnl_principal_ex.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.grid_ex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(0, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1438, 35)
        Me.Panel4.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(11, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Gestion des exercices"
        '
        'pnl_principal_ex
        '
        Me.pnl_principal_ex.BackColor = System.Drawing.SystemColors.Control
        Me.pnl_principal_ex.Controls.Add(Me.lbl_ajoutSucces)
        Me.pnl_principal_ex.Controls.Add(Me.btn_activer)
        Me.pnl_principal_ex.Controls.Add(Me.btn_desac)
        Me.pnl_principal_ex.Controls.Add(Me.Panel3)
        Me.pnl_principal_ex.Controls.Add(Me.grid_ex)
        Me.pnl_principal_ex.Controls.Add(Me.Panel4)
        Me.pnl_principal_ex.Location = New System.Drawing.Point(0, 0)
        Me.pnl_principal_ex.Name = "pnl_principal_ex"
        Me.pnl_principal_ex.Size = New System.Drawing.Size(1438, 835)
        Me.pnl_principal_ex.TabIndex = 48
        '
        'lbl_ajoutSucces
        '
        Me.lbl_ajoutSucces.BackColor = System.Drawing.Color.Lime
        Me.lbl_ajoutSucces.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_ajoutSucces.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_ajoutSucces.Location = New System.Drawing.Point(12, 707)
        Me.lbl_ajoutSucces.Name = "lbl_ajoutSucces"
        Me.lbl_ajoutSucces.Size = New System.Drawing.Size(1407, 24)
        Me.lbl_ajoutSucces.TabIndex = 58
        Me.lbl_ajoutSucces.Text = "Suppression réussie."
        Me.lbl_ajoutSucces.Visible = False
        '
        'btn_activer
        '
        Me.btn_activer.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btn_activer.FlatAppearance.BorderSize = 0
        Me.btn_activer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_activer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_activer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_activer.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_activer.Location = New System.Drawing.Point(1223, 672)
        Me.btn_activer.Name = "btn_activer"
        Me.btn_activer.Size = New System.Drawing.Size(95, 32)
        Me.btn_activer.TabIndex = 4
        Me.btn_activer.Text = "Activer"
        Me.btn_activer.UseVisualStyleBackColor = False
        '
        'btn_desac
        '
        Me.btn_desac.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btn_desac.FlatAppearance.BorderSize = 0
        Me.btn_desac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_desac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_desac.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_desac.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_desac.Location = New System.Drawing.Point(1324, 672)
        Me.btn_desac.Name = "btn_desac"
        Me.btn_desac.Size = New System.Drawing.Size(95, 32)
        Me.btn_desac.TabIndex = 5
        Me.btn_desac.Text = "Désactiver"
        Me.btn_desac.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.cbo_type)
        Me.Panel3.Controls.Add(Me.cbo_statut)
        Me.Panel3.Controls.Add(Me.btn_selectionner)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.txt_recherche)
        Me.Panel3.Location = New System.Drawing.Point(16, 44)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1403, 62)
        Me.Panel3.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(507, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 17)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Statut"
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
        Me.cbo_type.Items.AddRange(New Object() {"No. de cours", "Nom de cours", "Nom de l'enseignant", "Nom de l'exercice", "Tous"})
        Me.cbo_type.Location = New System.Drawing.Point(366, 22)
        Me.cbo_type.Name = "cbo_type"
        Me.cbo_type.Size = New System.Drawing.Size(121, 21)
        Me.cbo_type.TabIndex = 2
        '
        'cbo_statut
        '
        Me.cbo_statut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_statut.FormattingEnabled = True
        Me.cbo_statut.Items.AddRange(New Object() {"Actif", "Inactif", "Tous"})
        Me.cbo_statut.Location = New System.Drawing.Point(554, 21)
        Me.cbo_statut.Name = "cbo_statut"
        Me.cbo_statut.Size = New System.Drawing.Size(121, 21)
        Me.cbo_statut.TabIndex = 3
        '
        'btn_selectionner
        '
        Me.btn_selectionner.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_selectionner.FlatAppearance.BorderSize = 0
        Me.btn_selectionner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_selectionner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_selectionner.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_selectionner.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_selectionner.Location = New System.Drawing.Point(1250, 16)
        Me.btn_selectionner.Name = "btn_selectionner"
        Me.btn_selectionner.Size = New System.Drawing.Size(137, 28)
        Me.btn_selectionner.TabIndex = 52
        Me.btn_selectionner.TabStop = False
        Me.btn_selectionner.Text = "Sélectionner tout"
        Me.btn_selectionner.UseVisualStyleBackColor = False
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
        'txt_recherche
        '
        Me.txt_recherche.Location = New System.Drawing.Point(17, 22)
        Me.txt_recherche.Name = "txt_recherche"
        Me.txt_recherche.Size = New System.Drawing.Size(310, 20)
        Me.txt_recherche.TabIndex = 1
        '
        'grid_ex
        '
        Me.grid_ex.AllowUserToAddRows = False
        Me.grid_ex.AllowUserToDeleteRows = False
        Me.grid_ex.AllowUserToResizeColumns = False
        Me.grid_ex.AllowUserToResizeRows = False
        Me.grid_ex.BackgroundColor = System.Drawing.Color.White
        Me.grid_ex.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_ex.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_ex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_ex.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column2, Me.Column3, Me.Column1, Me.Column4})
        Me.grid_ex.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grid_ex.Location = New System.Drawing.Point(16, 112)
        Me.grid_ex.Name = "grid_ex"
        Me.grid_ex.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_ex.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grid_ex.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.grid_ex.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.grid_ex.RowTemplate.Height = 25
        Me.grid_ex.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_ex.Size = New System.Drawing.Size(1403, 554)
        Me.grid_ex.TabIndex = 47
        Me.grid_ex.TabStop = False
        '
        'Column5
        '
        Me.Column5.FillWeight = 1.0!
        Me.Column5.HeaderText = "no_exercice"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        Me.Column5.Width = 5
        '
        'Column2
        '
        Me.Column2.HeaderText = "No. Cours"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 120
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Nom de cours"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column1.HeaderText = "Nom de l'enseignant"
        Me.Column1.MinimumWidth = 180
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 180
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Nom de l'exercice"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'timer_succes
        '
        Me.timer_succes.Interval = 1
        '
        'usr_exercices_A
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnl_principal_ex)
        Me.Name = "usr_exercices_A"
        Me.Size = New System.Drawing.Size(1438, 835)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.pnl_principal_ex.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.grid_ex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents pnl_principal_ex As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents cbo_type As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbo_statut As ComboBox
    Friend WithEvents btn_selectionner As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_recherche As TextBox
    Friend WithEvents grid_ex As DataGridView
    Friend WithEvents btn_activer As Button
    Friend WithEvents btn_desac As Button
    Friend WithEvents lbl_ajoutSucces As Label
    Friend WithEvents timer_succes As Timer
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
