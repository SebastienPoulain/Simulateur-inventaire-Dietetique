<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usr_produits
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnReinitialiser = New System.Windows.Forms.Button()
        Me.btnRechercher = New System.Windows.Forms.Button()
        Me.dgv_produits = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rdb_perissable_tous = New System.Windows.Forms.RadioButton()
        Me.rdb_perissable_oui = New System.Windows.Forms.RadioButton()
        Me.rdb_perissable_non = New System.Windows.Forms.RadioButton()
        Me.txt_srch_nom = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbl_srch_code_barre = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rdb_allergene_tous = New System.Windows.Forms.RadioButton()
        Me.rdb_allergene_oui = New System.Windows.Forms.RadioButton()
        Me.rdb_allergene_non = New System.Windows.Forms.RadioButton()
        Me.txt_srch_marque = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.rdb_nom_contient = New System.Windows.Forms.RadioButton()
        Me.rdb_nom_commence = New System.Windows.Forms.RadioButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cbo_srch_categorie = New System.Windows.Forms.ComboBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        CType(Me.dgv_produits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(11, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Recherches"
        '
        'btnReinitialiser
        '
        Me.btnReinitialiser.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnReinitialiser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReinitialiser.FlatAppearance.BorderSize = 0
        Me.btnReinitialiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReinitialiser.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReinitialiser.ForeColor = System.Drawing.SystemColors.Control
        Me.btnReinitialiser.Location = New System.Drawing.Point(307, 585)
        Me.btnReinitialiser.Name = "btnReinitialiser"
        Me.btnReinitialiser.Size = New System.Drawing.Size(95, 32)
        Me.btnReinitialiser.TabIndex = 17
        Me.btnReinitialiser.Text = "Réinitialiser"
        Me.btnReinitialiser.UseVisualStyleBackColor = False
        '
        'btnRechercher
        '
        Me.btnRechercher.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnRechercher.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRechercher.FlatAppearance.BorderSize = 0
        Me.btnRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRechercher.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRechercher.ForeColor = System.Drawing.SystemColors.Control
        Me.btnRechercher.Location = New System.Drawing.Point(192, 585)
        Me.btnRechercher.Name = "btnRechercher"
        Me.btnRechercher.Size = New System.Drawing.Size(95, 32)
        Me.btnRechercher.TabIndex = 17
        Me.btnRechercher.Text = "Rechercher"
        Me.btnRechercher.UseVisualStyleBackColor = False
        '
        'dgv_produits
        '
        Me.dgv_produits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_produits.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_produits.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_produits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_produits.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgv_produits.Location = New System.Drawing.Point(496, 81)
        Me.dgv_produits.MultiSelect = False
        Me.dgv_produits.Name = "dgv_produits"
        Me.dgv_produits.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_produits.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_produits.RowHeadersVisible = False
        Me.dgv_produits.RowHeadersWidth = 35
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_produits.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_produits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_produits.Size = New System.Drawing.Size(737, 488)
        Me.dgv_produits.TabIndex = 43
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(53, 40)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(349, 35)
        Me.Panel4.TabIndex = 44
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Location = New System.Drawing.Point(496, 40)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(737, 35)
        Me.Panel5.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(11, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Liste de produits"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(10, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Nom du produit"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rdb_perissable_tous)
        Me.Panel1.Controls.Add(Me.rdb_perissable_oui)
        Me.Panel1.Controls.Add(Me.rdb_perissable_non)
        Me.Panel1.Location = New System.Drawing.Point(13, 202)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(205, 31)
        Me.Panel1.TabIndex = 38
        '
        'rdb_perissable_tous
        '
        Me.rdb_perissable_tous.AutoSize = True
        Me.rdb_perissable_tous.Checked = True
        Me.rdb_perissable_tous.Location = New System.Drawing.Point(113, 9)
        Me.rdb_perissable_tous.Name = "rdb_perissable_tous"
        Me.rdb_perissable_tous.Size = New System.Drawing.Size(68, 17)
        Me.rdb_perissable_tous.TabIndex = 37
        Me.rdb_perissable_tous.TabStop = True
        Me.rdb_perissable_tous.Text = "Les deux"
        Me.rdb_perissable_tous.UseVisualStyleBackColor = True
        '
        'rdb_perissable_oui
        '
        Me.rdb_perissable_oui.AutoSize = True
        Me.rdb_perissable_oui.Location = New System.Drawing.Point(6, 9)
        Me.rdb_perissable_oui.Name = "rdb_perissable_oui"
        Me.rdb_perissable_oui.Size = New System.Drawing.Size(41, 17)
        Me.rdb_perissable_oui.TabIndex = 35
        Me.rdb_perissable_oui.Text = "Oui"
        Me.rdb_perissable_oui.UseVisualStyleBackColor = True
        '
        'rdb_perissable_non
        '
        Me.rdb_perissable_non.AutoSize = True
        Me.rdb_perissable_non.Location = New System.Drawing.Point(59, 9)
        Me.rdb_perissable_non.Name = "rdb_perissable_non"
        Me.rdb_perissable_non.Size = New System.Drawing.Size(45, 17)
        Me.rdb_perissable_non.TabIndex = 34
        Me.rdb_perissable_non.Text = "Non"
        Me.rdb_perissable_non.UseVisualStyleBackColor = True
        '
        'txt_srch_nom
        '
        Me.txt_srch_nom.Location = New System.Drawing.Point(119, 78)
        Me.txt_srch_nom.Name = "txt_srch_nom"
        Me.txt_srch_nom.Size = New System.Drawing.Size(212, 20)
        Me.txt_srch_nom.TabIndex = 16
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(10, 146)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 17)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Catégorie"
        '
        'lbl_srch_code_barre
        '
        Me.lbl_srch_code_barre.AutoSize = True
        Me.lbl_srch_code_barre.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_srch_code_barre.ForeColor = System.Drawing.Color.Black
        Me.lbl_srch_code_barre.Location = New System.Drawing.Point(116, 16)
        Me.lbl_srch_code_barre.Name = "lbl_srch_code_barre"
        Me.lbl_srch_code_barre.Size = New System.Drawing.Size(157, 17)
        Me.lbl_srch_code_barre.TabIndex = 12
        Me.lbl_srch_code_barre.Text = "--- scannez un produit ---"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rdb_allergene_tous)
        Me.Panel2.Controls.Add(Me.rdb_allergene_oui)
        Me.Panel2.Controls.Add(Me.rdb_allergene_non)
        Me.Panel2.Location = New System.Drawing.Point(13, 276)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(205, 32)
        Me.Panel2.TabIndex = 39
        '
        'rdb_allergene_tous
        '
        Me.rdb_allergene_tous.AutoSize = True
        Me.rdb_allergene_tous.Checked = True
        Me.rdb_allergene_tous.Location = New System.Drawing.Point(113, 8)
        Me.rdb_allergene_tous.Name = "rdb_allergene_tous"
        Me.rdb_allergene_tous.Size = New System.Drawing.Size(68, 17)
        Me.rdb_allergene_tous.TabIndex = 36
        Me.rdb_allergene_tous.TabStop = True
        Me.rdb_allergene_tous.Text = "Les deux"
        Me.rdb_allergene_tous.UseVisualStyleBackColor = True
        '
        'rdb_allergene_oui
        '
        Me.rdb_allergene_oui.AutoSize = True
        Me.rdb_allergene_oui.Location = New System.Drawing.Point(6, 8)
        Me.rdb_allergene_oui.Name = "rdb_allergene_oui"
        Me.rdb_allergene_oui.Size = New System.Drawing.Size(41, 17)
        Me.rdb_allergene_oui.TabIndex = 35
        Me.rdb_allergene_oui.Text = "Oui"
        Me.rdb_allergene_oui.UseVisualStyleBackColor = True
        '
        'rdb_allergene_non
        '
        Me.rdb_allergene_non.AutoSize = True
        Me.rdb_allergene_non.Location = New System.Drawing.Point(59, 8)
        Me.rdb_allergene_non.Name = "rdb_allergene_non"
        Me.rdb_allergene_non.Size = New System.Drawing.Size(45, 17)
        Me.rdb_allergene_non.TabIndex = 34
        Me.rdb_allergene_non.Text = "Non"
        Me.rdb_allergene_non.UseVisualStyleBackColor = True
        '
        'txt_srch_marque
        '
        Me.txt_srch_marque.Location = New System.Drawing.Point(119, 113)
        Me.txt_srch_marque.Name = "txt_srch_marque"
        Me.txt_srch_marque.Size = New System.Drawing.Size(140, 20)
        Me.txt_srch_marque.TabIndex = 19
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(12, 182)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 17)
        Me.Label19.TabIndex = 40
        Me.Label19.Text = "Périssable"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(10, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Marque"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(12, 256)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(145, 17)
        Me.Label20.TabIndex = 41
        Me.Label20.Text = "Contient des allergènes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Code barre"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.Controls.Add(Me.rdb_nom_contient)
        Me.Panel6.Controls.Add(Me.rdb_nom_commence)
        Me.Panel6.Location = New System.Drawing.Point(116, 47)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(183, 30)
        Me.Panel6.TabIndex = 43
        '
        'rdb_nom_contient
        '
        Me.rdb_nom_contient.AutoSize = True
        Me.rdb_nom_contient.Location = New System.Drawing.Point(107, 7)
        Me.rdb_nom_contient.Name = "rdb_nom_contient"
        Me.rdb_nom_contient.Size = New System.Drawing.Size(64, 17)
        Me.rdb_nom_contient.TabIndex = 37
        Me.rdb_nom_contient.Text = "Contient"
        Me.rdb_nom_contient.UseVisualStyleBackColor = True
        '
        'rdb_nom_commence
        '
        Me.rdb_nom_commence.AutoSize = True
        Me.rdb_nom_commence.Location = New System.Drawing.Point(6, 7)
        Me.rdb_nom_commence.Name = "rdb_nom_commence"
        Me.rdb_nom_commence.Size = New System.Drawing.Size(96, 17)
        Me.rdb_nom_commence.TabIndex = 38
        Me.rdb_nom_commence.Text = "Commence par"
        Me.rdb_nom_commence.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.cbo_srch_categorie)
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.txt_srch_marque)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.lbl_srch_code_barre)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.txt_srch_nom)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(53, 81)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(349, 488)
        Me.Panel3.TabIndex = 42
        '
        'cbo_srch_categorie
        '
        Me.cbo_srch_categorie.FormattingEnabled = True
        Me.cbo_srch_categorie.Location = New System.Drawing.Point(119, 146)
        Me.cbo_srch_categorie.Name = "cbo_srch_categorie"
        Me.cbo_srch_categorie.Size = New System.Drawing.Size(143, 21)
        Me.cbo_srch_categorie.TabIndex = 45
        '
        'Panel7
        '
        Me.Panel7.Location = New System.Drawing.Point(13, 314)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(318, 150)
        Me.Panel7.TabIndex = 44
        '
        'usr_produits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.dgv_produits)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnRechercher)
        Me.Controls.Add(Me.btnReinitialiser)
        Me.Name = "usr_produits"
        Me.Size = New System.Drawing.Size(1280, 655)
        CType(Me.dgv_produits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents btnRechercher As Button
    Friend WithEvents btnReinitialiser As Button
    Friend WithEvents dgv_produits As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rdb_perissable_oui As RadioButton
    Friend WithEvents rdb_perissable_non As RadioButton
    Friend WithEvents rdb_perissable_tous As RadioButton
    Friend WithEvents txt_srch_nom As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents lbl_srch_code_barre As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents rdb_allergene_tous As RadioButton
    Friend WithEvents rdb_allergene_non As RadioButton
    Friend WithEvents rdb_allergene_oui As RadioButton
    Friend WithEvents txt_srch_marque As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents rdb_nom_contient As RadioButton
    Friend WithEvents rdb_nom_commence As RadioButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents cbo_srch_categorie As ComboBox
End Class
