<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class recette
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
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_inventaire = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_SuppRecette = New System.Windows.Forms.Button()
        Me.btn_ImporterRecette = New System.Windows.Forms.Button()
        Me.btn_imp_image = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btn_Enregistrer = New System.Windows.Forms.Button()
        Me.PaneldecoRecette = New System.Windows.Forms.Panel()
        Me.btn_lier_re_ex = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBoxDescriptionRecette = New System.Windows.Forms.TextBox()
        Me.NoteRecette = New System.Windows.Forms.Label()
        Me.Panel5.SuspendLayout()
        Me.PaneldecoRecette.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel5.Controls.Add(Me.lbl_inventaire)
        Me.Panel5.Location = New System.Drawing.Point(15, 47)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1378, 35)
        Me.Panel5.TabIndex = 106
        '
        'lbl_inventaire
        '
        Me.lbl_inventaire.AutoSize = True
        Me.lbl_inventaire.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inventaire.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_inventaire.Location = New System.Drawing.Point(3, 2)
        Me.lbl_inventaire.Name = "lbl_inventaire"
        Me.lbl_inventaire.Size = New System.Drawing.Size(73, 25)
        Me.lbl_inventaire.TabIndex = 9
        Me.lbl_inventaire.Text = "Recette"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(217, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 19)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Liste des recettes disponibles"
        '
        'btn_SuppRecette
        '
        Me.btn_SuppRecette.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_SuppRecette.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_SuppRecette.FlatAppearance.BorderSize = 0
        Me.btn_SuppRecette.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_SuppRecette.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_SuppRecette.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SuppRecette.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_SuppRecette.Location = New System.Drawing.Point(36, 175)
        Me.btn_SuppRecette.Name = "btn_SuppRecette"
        Me.btn_SuppRecette.Size = New System.Drawing.Size(157, 32)
        Me.btn_SuppRecette.TabIndex = 97
        Me.btn_SuppRecette.Text = "Supprimer"
        Me.btn_SuppRecette.UseVisualStyleBackColor = False
        '
        'btn_ImporterRecette
        '
        Me.btn_ImporterRecette.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_ImporterRecette.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_ImporterRecette.FlatAppearance.BorderSize = 0
        Me.btn_ImporterRecette.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_ImporterRecette.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ImporterRecette.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ImporterRecette.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_ImporterRecette.Location = New System.Drawing.Point(36, 115)
        Me.btn_ImporterRecette.Name = "btn_ImporterRecette"
        Me.btn_ImporterRecette.Size = New System.Drawing.Size(157, 32)
        Me.btn_ImporterRecette.TabIndex = 90
        Me.btn_ImporterRecette.Text = "Enregistrer recette"
        Me.btn_ImporterRecette.UseVisualStyleBackColor = False
        '
        'btn_imp_image
        '
        Me.btn_imp_image.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_imp_image.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_imp_image.FlatAppearance.BorderSize = 0
        Me.btn_imp_image.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_imp_image.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_imp_image.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_imp_image.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_imp_image.Location = New System.Drawing.Point(690, 468)
        Me.btn_imp_image.Name = "btn_imp_image"
        Me.btn_imp_image.Size = New System.Drawing.Size(157, 32)
        Me.btn_imp_image.TabIndex = 107
        Me.btn_imp_image.Text = "Importer une image"
        Me.btn_imp_image.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Location = New System.Drawing.Point(221, 55)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(308, 604)
        Me.ListBox1.TabIndex = 92
        '
        'btn_Enregistrer
        '
        Me.btn_Enregistrer.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_Enregistrer.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_Enregistrer.FlatAppearance.BorderSize = 0
        Me.btn_Enregistrer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_Enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Enregistrer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Enregistrer.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_Enregistrer.Location = New System.Drawing.Point(36, 55)
        Me.btn_Enregistrer.Name = "btn_Enregistrer"
        Me.btn_Enregistrer.Size = New System.Drawing.Size(157, 32)
        Me.btn_Enregistrer.TabIndex = 93
        Me.btn_Enregistrer.Text = "Ajouter Recette"
        Me.btn_Enregistrer.UseVisualStyleBackColor = False
        '
        'PaneldecoRecette
        '
        Me.PaneldecoRecette.BackColor = System.Drawing.Color.LightSlateGray
        Me.PaneldecoRecette.Controls.Add(Me.btn_lier_re_ex)
        Me.PaneldecoRecette.Controls.Add(Me.Label1)
        Me.PaneldecoRecette.Controls.Add(Me.btn_SuppRecette)
        Me.PaneldecoRecette.Controls.Add(Me.ListBox1)
        Me.PaneldecoRecette.Controls.Add(Me.btn_ImporterRecette)
        Me.PaneldecoRecette.Controls.Add(Me.btn_Enregistrer)
        Me.PaneldecoRecette.Location = New System.Drawing.Point(15, 77)
        Me.PaneldecoRecette.Name = "PaneldecoRecette"
        Me.PaneldecoRecette.Size = New System.Drawing.Size(650, 684)
        Me.PaneldecoRecette.TabIndex = 108
        '
        'btn_lier_re_ex
        '
        Me.btn_lier_re_ex.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_lier_re_ex.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_lier_re_ex.FlatAppearance.BorderSize = 0
        Me.btn_lier_re_ex.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_lier_re_ex.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_lier_re_ex.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_lier_re_ex.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_lier_re_ex.Location = New System.Drawing.Point(36, 234)
        Me.btn_lier_re_ex.Name = "btn_lier_re_ex"
        Me.btn_lier_re_ex.Size = New System.Drawing.Size(157, 32)
        Me.btn_lier_re_ex.TabIndex = 98
        Me.btn_lier_re_ex.Text = "Ajouter à un exercice"
        Me.btn_lier_re_ex.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(690, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(664, 374)
        Me.GroupBox1.TabIndex = 109
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Image"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox1.Location = New System.Drawing.Point(36, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(579, 336)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 80
        Me.PictureBox1.TabStop = False
        '
        'TextBoxDescriptionRecette
        '
        Me.TextBoxDescriptionRecette.Location = New System.Drawing.Point(690, 525)
        Me.TextBoxDescriptionRecette.Multiline = True
        Me.TextBoxDescriptionRecette.Name = "TextBoxDescriptionRecette"
        Me.TextBoxDescriptionRecette.ReadOnly = True
        Me.TextBoxDescriptionRecette.Size = New System.Drawing.Size(664, 236)
        Me.TextBoxDescriptionRecette.TabIndex = 111
        '
        'NoteRecette
        '
        Me.NoteRecette.AutoSize = True
        Me.NoteRecette.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NoteRecette.Location = New System.Drawing.Point(695, 503)
        Me.NoteRecette.Name = "NoteRecette"
        Me.NoteRecette.Size = New System.Drawing.Size(86, 19)
        Me.NoteRecette.TabIndex = 110
        Me.NoteRecette.Text = "Description"
        '
        'recette
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.btn_imp_image)
        Me.Controls.Add(Me.PaneldecoRecette)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBoxDescriptionRecette)
        Me.Controls.Add(Me.NoteRecette)
        Me.Name = "recette"
        Me.Size = New System.Drawing.Size(1408, 808)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.PaneldecoRecette.ResumeLayout(False)
        Me.PaneldecoRecette.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_inventaire As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_SuppRecette As Button
    Friend WithEvents btn_ImporterRecette As Button
    Friend WithEvents btn_imp_image As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btn_Enregistrer As Button
    Friend WithEvents PaneldecoRecette As Panel
    Friend WithEvents btn_lier_re_ex As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBoxDescriptionRecette As TextBox
    Friend WithEvents NoteRecette As Label
End Class
