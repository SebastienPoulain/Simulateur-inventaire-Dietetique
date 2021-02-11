<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usr_connexionCours
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grid_cours = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_retour = New System.Windows.Forms.Button()
        Me.pnl_aucun = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.grid_cours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_aucun.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(706, 26)
        Me.Panel2.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(3, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 21)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Choisir un cours"
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
        Me.grid_cours.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.grid_cours.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grid_cours.Location = New System.Drawing.Point(7, 35)
        Me.grid_cours.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
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
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.grid_cours.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.grid_cours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_cours.Size = New System.Drawing.Size(693, 265)
        Me.grid_cours.TabIndex = 0
        Me.grid_cours.TabStop = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "No. de cours"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 130
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
        'btn_retour
        '
        Me.btn_retour.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_retour.FlatAppearance.BorderSize = 0
        Me.btn_retour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_retour.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_retour.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_retour.Location = New System.Drawing.Point(584, 309)
        Me.btn_retour.Name = "btn_retour"
        Me.btn_retour.Size = New System.Drawing.Size(109, 32)
        Me.btn_retour.TabIndex = 1
        Me.btn_retour.Text = "Retour"
        Me.btn_retour.UseVisualStyleBackColor = False
        '
        'pnl_aucun
        '
        Me.pnl_aucun.BackColor = System.Drawing.Color.Gainsboro
        Me.pnl_aucun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_aucun.Controls.Add(Me.Label3)
        Me.pnl_aucun.Controls.Add(Me.Label2)
        Me.pnl_aucun.Location = New System.Drawing.Point(7, 60)
        Me.pnl_aucun.Name = "pnl_aucun"
        Me.pnl_aucun.Size = New System.Drawing.Size(693, 240)
        Me.pnl_aucun.TabIndex = 57
        Me.pnl_aucun.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(236, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(227, 21)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Contactez votre administrateur."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(187, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(332, 28)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Aucun cours n'est lié à votre compte."
        '
        'usr_connexionCours
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnl_aucun)
        Me.Controls.Add(Me.btn_retour)
        Me.Controls.Add(Me.grid_cours)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "usr_connexionCours"
        Me.Size = New System.Drawing.Size(706, 355)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.grid_cours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_aucun.ResumeLayout(False)
        Me.pnl_aucun.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents grid_cours As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents btn_retour As Button
    Friend WithEvents pnl_aucun As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
