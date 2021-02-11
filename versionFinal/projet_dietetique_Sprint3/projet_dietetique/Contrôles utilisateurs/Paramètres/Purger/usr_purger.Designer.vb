<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usr_purger
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
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_exercice = New System.Windows.Forms.Button()
        Me.btn_etu = New System.Windows.Forms.Button()
        Me.btn_ensei = New System.Windows.Forms.Button()
        Me.btn_cours = New System.Windows.Forms.Button()
        Me.btn_unite = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_admin = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_format = New System.Windows.Forms.Button()
        Me.btn_categorie = New System.Windows.Forms.Button()
        Me.btn_empl = New System.Windows.Forms.Button()
        Me.btn_ville = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_produit = New System.Windows.Forms.Button()
        Me.btn_fournisseur = New System.Windows.Forms.Button()
        Me.lbl_ajoutSucces = New System.Windows.Forms.Label()
        Me.timer_succes = New System.Windows.Forms.Timer(Me.components)
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Location = New System.Drawing.Point(0, 40)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1187, 28)
        Me.Panel5.TabIndex = 55
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(11, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Exercices et cours"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1187, 35)
        Me.Panel4.TabIndex = 54
        Me.Panel4.TabStop = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(11, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(312, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Supprimer dans la base de données"
        '
        'btn_exercice
        '
        Me.btn_exercice.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_exercice.FlatAppearance.BorderSize = 0
        Me.btn_exercice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_exercice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exercice.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exercice.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_exercice.Location = New System.Drawing.Point(16, 89)
        Me.btn_exercice.Name = "btn_exercice"
        Me.btn_exercice.Size = New System.Drawing.Size(204, 37)
        Me.btn_exercice.TabIndex = 65
        Me.btn_exercice.Text = "Supprimer les exercices"
        Me.btn_exercice.UseVisualStyleBackColor = False
        '
        'btn_etu
        '
        Me.btn_etu.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_etu.FlatAppearance.BorderSize = 0
        Me.btn_etu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_etu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_etu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_etu.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_etu.Location = New System.Drawing.Point(16, 213)
        Me.btn_etu.Name = "btn_etu"
        Me.btn_etu.Size = New System.Drawing.Size(204, 37)
        Me.btn_etu.TabIndex = 67
        Me.btn_etu.Text = "Supprimer les étudiants"
        Me.btn_etu.UseVisualStyleBackColor = False
        '
        'btn_ensei
        '
        Me.btn_ensei.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_ensei.FlatAppearance.BorderSize = 0
        Me.btn_ensei.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_ensei.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ensei.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ensei.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_ensei.Location = New System.Drawing.Point(226, 213)
        Me.btn_ensei.Name = "btn_ensei"
        Me.btn_ensei.Size = New System.Drawing.Size(204, 37)
        Me.btn_ensei.TabIndex = 68
        Me.btn_ensei.Text = "Supprimer les enseignants"
        Me.btn_ensei.UseVisualStyleBackColor = False
        '
        'btn_cours
        '
        Me.btn_cours.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_cours.FlatAppearance.BorderSize = 0
        Me.btn_cours.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_cours.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cours.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cours.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_cours.Location = New System.Drawing.Point(226, 89)
        Me.btn_cours.Name = "btn_cours"
        Me.btn_cours.Size = New System.Drawing.Size(204, 37)
        Me.btn_cours.TabIndex = 69
        Me.btn_cours.Text = "Supprimer les cours"
        Me.btn_cours.UseVisualStyleBackColor = False
        '
        'btn_unite
        '
        Me.btn_unite.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_unite.FlatAppearance.BorderSize = 0
        Me.btn_unite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_unite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_unite.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_unite.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_unite.Location = New System.Drawing.Point(226, 458)
        Me.btn_unite.Name = "btn_unite"
        Me.btn_unite.Size = New System.Drawing.Size(204, 37)
        Me.btn_unite.TabIndex = 70
        Me.btn_unite.Text = "Supprimer les unités de mesure"
        Me.btn_unite.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 163)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1187, 28)
        Me.Panel1.TabIndex = 66
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(11, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Utilisateurs"
        '
        'btn_admin
        '
        Me.btn_admin.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_admin.FlatAppearance.BorderSize = 0
        Me.btn_admin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_admin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_admin.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_admin.Location = New System.Drawing.Point(436, 213)
        Me.btn_admin.Name = "btn_admin"
        Me.btn_admin.Size = New System.Drawing.Size(204, 37)
        Me.btn_admin.TabIndex = 71
        Me.btn_admin.Text = "Supprimer les administrateurs"
        Me.btn_admin.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(0, 409)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1187, 28)
        Me.Panel2.TabIndex = 67
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(11, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Autres"
        '
        'btn_format
        '
        Me.btn_format.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_format.FlatAppearance.BorderSize = 0
        Me.btn_format.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_format.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_format.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_format.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_format.Location = New System.Drawing.Point(16, 458)
        Me.btn_format.Name = "btn_format"
        Me.btn_format.Size = New System.Drawing.Size(204, 37)
        Me.btn_format.TabIndex = 72
        Me.btn_format.Text = "Supprimer les formats"
        Me.btn_format.UseVisualStyleBackColor = False
        '
        'btn_categorie
        '
        Me.btn_categorie.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_categorie.FlatAppearance.BorderSize = 0
        Me.btn_categorie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_categorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_categorie.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_categorie.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_categorie.Location = New System.Drawing.Point(436, 458)
        Me.btn_categorie.Name = "btn_categorie"
        Me.btn_categorie.Size = New System.Drawing.Size(204, 37)
        Me.btn_categorie.TabIndex = 73
        Me.btn_categorie.Text = "Supprimer les catégories"
        Me.btn_categorie.UseVisualStyleBackColor = False
        '
        'btn_empl
        '
        Me.btn_empl.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_empl.FlatAppearance.BorderSize = 0
        Me.btn_empl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_empl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_empl.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_empl.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_empl.Location = New System.Drawing.Point(856, 458)
        Me.btn_empl.Name = "btn_empl"
        Me.btn_empl.Size = New System.Drawing.Size(204, 37)
        Me.btn_empl.TabIndex = 74
        Me.btn_empl.Text = "Supprimer les emplacements"
        Me.btn_empl.UseVisualStyleBackColor = False
        '
        'btn_ville
        '
        Me.btn_ville.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_ville.FlatAppearance.BorderSize = 0
        Me.btn_ville.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_ville.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ville.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ville.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_ville.Location = New System.Drawing.Point(646, 458)
        Me.btn_ville.Name = "btn_ville"
        Me.btn_ville.Size = New System.Drawing.Size(204, 37)
        Me.btn_ville.TabIndex = 75
        Me.btn_ville.Text = "Supprimer les villes"
        Me.btn_ville.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(0, 286)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1187, 28)
        Me.Panel3.TabIndex = 76
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(11, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(199, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Produits et fournisseurs"
        '
        'btn_produit
        '
        Me.btn_produit.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_produit.FlatAppearance.BorderSize = 0
        Me.btn_produit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_produit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_produit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_produit.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_produit.Location = New System.Drawing.Point(16, 335)
        Me.btn_produit.Name = "btn_produit"
        Me.btn_produit.Size = New System.Drawing.Size(204, 37)
        Me.btn_produit.TabIndex = 77
        Me.btn_produit.Text = "Supprimer les produits"
        Me.btn_produit.UseVisualStyleBackColor = False
        '
        'btn_fournisseur
        '
        Me.btn_fournisseur.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_fournisseur.FlatAppearance.BorderSize = 0
        Me.btn_fournisseur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_fournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_fournisseur.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fournisseur.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_fournisseur.Location = New System.Drawing.Point(226, 335)
        Me.btn_fournisseur.Name = "btn_fournisseur"
        Me.btn_fournisseur.Size = New System.Drawing.Size(204, 37)
        Me.btn_fournisseur.TabIndex = 78
        Me.btn_fournisseur.Text = "Supprimer les fournisseurs"
        Me.btn_fournisseur.UseVisualStyleBackColor = False
        '
        'lbl_ajoutSucces
        '
        Me.lbl_ajoutSucces.BackColor = System.Drawing.Color.Lime
        Me.lbl_ajoutSucces.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_ajoutSucces.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_ajoutSucces.Location = New System.Drawing.Point(0, 511)
        Me.lbl_ajoutSucces.Name = "lbl_ajoutSucces"
        Me.lbl_ajoutSucces.Size = New System.Drawing.Size(1187, 24)
        Me.lbl_ajoutSucces.TabIndex = 79
        Me.lbl_ajoutSucces.Text = "L'utilisateur a bien été ajouté."
        Me.lbl_ajoutSucces.Visible = False
        '
        'timer_succes
        '
        Me.timer_succes.Interval = 1
        '
        'usr_purger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lbl_ajoutSucces)
        Me.Controls.Add(Me.btn_fournisseur)
        Me.Controls.Add(Me.btn_ville)
        Me.Controls.Add(Me.btn_empl)
        Me.Controls.Add(Me.btn_categorie)
        Me.Controls.Add(Me.btn_format)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btn_produit)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btn_admin)
        Me.Controls.Add(Me.btn_unite)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_cours)
        Me.Controls.Add(Me.btn_ensei)
        Me.Controls.Add(Me.btn_etu)
        Me.Controls.Add(Me.btn_exercice)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "usr_purger"
        Me.Size = New System.Drawing.Size(1187, 835)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_exercice As Button
    Friend WithEvents btn_etu As Button
    Friend WithEvents btn_ensei As Button
    Friend WithEvents btn_cours As Button
    Friend WithEvents btn_unite As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_admin As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_format As Button
    Friend WithEvents btn_categorie As Button
    Friend WithEvents btn_empl As Button
    Friend WithEvents btn_ville As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_produit As Button
    Friend WithEvents btn_fournisseur As Button
    Friend WithEvents lbl_ajoutSucces As Label
    Friend WithEvents timer_succes As Timer
End Class
