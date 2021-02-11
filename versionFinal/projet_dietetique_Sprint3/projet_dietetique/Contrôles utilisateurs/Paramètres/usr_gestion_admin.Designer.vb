<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usr_gestion_admin
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
        Me.pnl_menu_vertical = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btn_utilisateur = New System.Windows.Forms.Button()
        Me.btn_cours = New System.Windows.Forms.Button()
        Me.btn_produits = New System.Windows.Forms.Button()
        Me.btn_fournisseurs = New System.Windows.Forms.Button()
        Me.btn_formats = New System.Windows.Forms.Button()
        Me.btn_unites_mesures = New System.Windows.Forms.Button()
        Me.btn_categories = New System.Windows.Forms.Button()
        Me.btn_villes = New System.Windows.Forms.Button()
        Me.btn_emplacements = New System.Windows.Forms.Button()
        Me.btn_profil = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_purge = New System.Windows.Forms.Button()
        Me.pnl_gestion = New System.Windows.Forms.Panel()
        Me.btn_deconnexion = New System.Windows.Forms.Button()
        Me.pnl_menu_vertical.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_menu_vertical
        '
        Me.pnl_menu_vertical.BackColor = System.Drawing.Color.White
        Me.pnl_menu_vertical.Controls.Add(Me.FlowLayoutPanel1)
        Me.pnl_menu_vertical.Controls.Add(Me.btn_profil)
        Me.pnl_menu_vertical.Controls.Add(Me.Panel4)
        Me.pnl_menu_vertical.Controls.Add(Me.btn_purge)
        Me.pnl_menu_vertical.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_menu_vertical.Location = New System.Drawing.Point(0, 0)
        Me.pnl_menu_vertical.Name = "pnl_menu_vertical"
        Me.pnl_menu_vertical.Size = New System.Drawing.Size(250, 835)
        Me.pnl_menu_vertical.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_utilisateur)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_cours)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_produits)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_fournisseurs)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_formats)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_unites_mesures)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_categories)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_villes)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_emplacements)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_deconnexion)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(-3, 110)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(253, 561)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btn_utilisateur
        '
        Me.btn_utilisateur.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_utilisateur.FlatAppearance.BorderSize = 0
        Me.btn_utilisateur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_utilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_utilisateur.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_utilisateur.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_utilisateur.Location = New System.Drawing.Point(3, 3)
        Me.btn_utilisateur.Name = "btn_utilisateur"
        Me.btn_utilisateur.Size = New System.Drawing.Size(250, 50)
        Me.btn_utilisateur.TabIndex = 16
        Me.btn_utilisateur.TabStop = False
        Me.btn_utilisateur.Text = "Utilisateurs"
        Me.btn_utilisateur.UseVisualStyleBackColor = False
        Me.btn_utilisateur.Visible = False
        '
        'btn_cours
        '
        Me.btn_cours.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_cours.FlatAppearance.BorderSize = 0
        Me.btn_cours.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_cours.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cours.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_cours.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_cours.Location = New System.Drawing.Point(3, 59)
        Me.btn_cours.Name = "btn_cours"
        Me.btn_cours.Size = New System.Drawing.Size(250, 50)
        Me.btn_cours.TabIndex = 15
        Me.btn_cours.TabStop = False
        Me.btn_cours.Text = "Cours et groupes"
        Me.btn_cours.UseVisualStyleBackColor = False
        Me.btn_cours.Visible = False
        '
        'btn_produits
        '
        Me.btn_produits.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_produits.FlatAppearance.BorderSize = 0
        Me.btn_produits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_produits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_produits.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_produits.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_produits.Location = New System.Drawing.Point(3, 115)
        Me.btn_produits.Name = "btn_produits"
        Me.btn_produits.Size = New System.Drawing.Size(250, 50)
        Me.btn_produits.TabIndex = 46
        Me.btn_produits.TabStop = False
        Me.btn_produits.Text = "Produits"
        Me.btn_produits.UseVisualStyleBackColor = False
        Me.btn_produits.Visible = False
        '
        'btn_fournisseurs
        '
        Me.btn_fournisseurs.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_fournisseurs.FlatAppearance.BorderSize = 0
        Me.btn_fournisseurs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_fournisseurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_fournisseurs.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_fournisseurs.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_fournisseurs.Location = New System.Drawing.Point(3, 171)
        Me.btn_fournisseurs.Name = "btn_fournisseurs"
        Me.btn_fournisseurs.Size = New System.Drawing.Size(250, 50)
        Me.btn_fournisseurs.TabIndex = 47
        Me.btn_fournisseurs.TabStop = False
        Me.btn_fournisseurs.Text = "Fournisseurs"
        Me.btn_fournisseurs.UseVisualStyleBackColor = False
        Me.btn_fournisseurs.Visible = False
        '
        'btn_formats
        '
        Me.btn_formats.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_formats.FlatAppearance.BorderSize = 0
        Me.btn_formats.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_formats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_formats.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_formats.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_formats.Location = New System.Drawing.Point(3, 227)
        Me.btn_formats.Name = "btn_formats"
        Me.btn_formats.Size = New System.Drawing.Size(250, 50)
        Me.btn_formats.TabIndex = 48
        Me.btn_formats.TabStop = False
        Me.btn_formats.Text = "Formats"
        Me.btn_formats.UseVisualStyleBackColor = False
        Me.btn_formats.Visible = False
        '
        'btn_unites_mesures
        '
        Me.btn_unites_mesures.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_unites_mesures.FlatAppearance.BorderSize = 0
        Me.btn_unites_mesures.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_unites_mesures.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_unites_mesures.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_unites_mesures.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_unites_mesures.Location = New System.Drawing.Point(3, 283)
        Me.btn_unites_mesures.Name = "btn_unites_mesures"
        Me.btn_unites_mesures.Size = New System.Drawing.Size(250, 50)
        Me.btn_unites_mesures.TabIndex = 49
        Me.btn_unites_mesures.TabStop = False
        Me.btn_unites_mesures.Text = "Unités de mesures"
        Me.btn_unites_mesures.UseVisualStyleBackColor = False
        Me.btn_unites_mesures.Visible = False
        '
        'btn_categories
        '
        Me.btn_categories.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_categories.FlatAppearance.BorderSize = 0
        Me.btn_categories.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_categories.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_categories.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_categories.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_categories.Location = New System.Drawing.Point(3, 339)
        Me.btn_categories.Name = "btn_categories"
        Me.btn_categories.Size = New System.Drawing.Size(250, 50)
        Me.btn_categories.TabIndex = 50
        Me.btn_categories.TabStop = False
        Me.btn_categories.Text = "Catégories"
        Me.btn_categories.UseVisualStyleBackColor = False
        Me.btn_categories.Visible = False
        '
        'btn_villes
        '
        Me.btn_villes.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_villes.FlatAppearance.BorderSize = 0
        Me.btn_villes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_villes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_villes.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_villes.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_villes.Location = New System.Drawing.Point(3, 395)
        Me.btn_villes.Name = "btn_villes"
        Me.btn_villes.Size = New System.Drawing.Size(250, 50)
        Me.btn_villes.TabIndex = 51
        Me.btn_villes.TabStop = False
        Me.btn_villes.Text = "Villes"
        Me.btn_villes.UseVisualStyleBackColor = False
        Me.btn_villes.Visible = False
        '
        'btn_emplacements
        '
        Me.btn_emplacements.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_emplacements.FlatAppearance.BorderSize = 0
        Me.btn_emplacements.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_emplacements.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_emplacements.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_emplacements.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_emplacements.Location = New System.Drawing.Point(3, 451)
        Me.btn_emplacements.Name = "btn_emplacements"
        Me.btn_emplacements.Size = New System.Drawing.Size(250, 50)
        Me.btn_emplacements.TabIndex = 52
        Me.btn_emplacements.TabStop = False
        Me.btn_emplacements.Text = "Emplacements"
        Me.btn_emplacements.UseVisualStyleBackColor = False
        Me.btn_emplacements.Visible = False
        '
        'btn_profil
        '
        Me.btn_profil.BackColor = System.Drawing.SystemColors.Control
        Me.btn_profil.FlatAppearance.BorderSize = 0
        Me.btn_profil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_profil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_profil.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_profil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_profil.Location = New System.Drawing.Point(0, 40)
        Me.btn_profil.Name = "btn_profil"
        Me.btn_profil.Size = New System.Drawing.Size(250, 50)
        Me.btn_profil.TabIndex = 47
        Me.btn_profil.TabStop = False
        Me.btn_profil.Text = "Mon profil"
        Me.btn_profil.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(250, 35)
        Me.Panel4.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(73, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 28)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Paramètres"
        '
        'btn_purge
        '
        Me.btn_purge.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_purge.FlatAppearance.BorderSize = 0
        Me.btn_purge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_purge.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_purge.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_purge.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_purge.Location = New System.Drawing.Point(0, 749)
        Me.btn_purge.Name = "btn_purge"
        Me.btn_purge.Size = New System.Drawing.Size(250, 50)
        Me.btn_purge.TabIndex = 53
        Me.btn_purge.TabStop = False
        Me.btn_purge.Text = "Supprimer dans la base de données"
        Me.btn_purge.UseVisualStyleBackColor = False
        Me.btn_purge.Visible = False
        '
        'pnl_gestion
        '
        Me.pnl_gestion.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnl_gestion.Location = New System.Drawing.Point(251, 0)
        Me.pnl_gestion.Name = "pnl_gestion"
        Me.pnl_gestion.Size = New System.Drawing.Size(1187, 835)
        Me.pnl_gestion.TabIndex = 18
        '
        'btn_deconnexion
        '
        Me.btn_deconnexion.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_deconnexion.FlatAppearance.BorderSize = 0
        Me.btn_deconnexion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_deconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deconnexion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_deconnexion.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_deconnexion.Location = New System.Drawing.Point(3, 507)
        Me.btn_deconnexion.Name = "btn_deconnexion"
        Me.btn_deconnexion.Size = New System.Drawing.Size(250, 50)
        Me.btn_deconnexion.TabIndex = 53
        Me.btn_deconnexion.TabStop = False
        Me.btn_deconnexion.Text = "Déconnexion"
        Me.btn_deconnexion.UseVisualStyleBackColor = False
        '
        'usr_gestion_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnl_gestion)
        Me.Controls.Add(Me.pnl_menu_vertical)
        Me.Name = "usr_gestion_admin"
        Me.Size = New System.Drawing.Size(1438, 835)
        Me.pnl_menu_vertical.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_menu_vertical As Panel
    Friend WithEvents btn_utilisateur As Button
    Friend WithEvents btn_cours As Button
    Friend WithEvents pnl_gestion As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_produits As Button
    Friend WithEvents btn_profil As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btn_fournisseurs As Button
    Friend WithEvents btn_formats As Button
    Friend WithEvents btn_unites_mesures As Button
    Friend WithEvents btn_categories As Button
    Friend WithEvents btn_villes As Button
    Friend WithEvents btn_emplacements As Button
    Friend WithEvents btn_purge As Button
    Friend WithEvents btn_deconnexion As Button
End Class
