<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usr_gestion_MenuUtls
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
        Me.pnl_menuCours = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_créer = New System.Windows.Forms.Label()
        Me.pnl_genererUtls = New System.Windows.Forms.Panel()
        Me.pnl_listeUtls = New System.Windows.Forms.Panel()
        Me.pnl_ajouterUtls = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_liste = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_gen = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl_titre = New System.Windows.Forms.Label()
        Me.pnl_menuCours.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_menuCours
        '
        Me.pnl_menuCours.Controls.Add(Me.Panel1)
        Me.pnl_menuCours.Controls.Add(Me.pnl_genererUtls)
        Me.pnl_menuCours.Controls.Add(Me.pnl_listeUtls)
        Me.pnl_menuCours.Controls.Add(Me.pnl_ajouterUtls)
        Me.pnl_menuCours.Controls.Add(Me.Panel5)
        Me.pnl_menuCours.Controls.Add(Me.Panel2)
        Me.pnl_menuCours.Controls.Add(Me.Panel4)
        Me.pnl_menuCours.Location = New System.Drawing.Point(0, 0)
        Me.pnl_menuCours.Name = "pnl_menuCours"
        Me.pnl_menuCours.Size = New System.Drawing.Size(1170, 1001)
        Me.pnl_menuCours.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_créer)
        Me.Panel1.Location = New System.Drawing.Point(0, 641)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1170, 28)
        Me.Panel1.TabIndex = 1
        '
        'lbl_créer
        '
        Me.lbl_créer.AutoSize = True
        Me.lbl_créer.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lbl_créer.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_créer.Location = New System.Drawing.Point(11, 0)
        Me.lbl_créer.Name = "lbl_créer"
        Me.lbl_créer.Size = New System.Drawing.Size(159, 25)
        Me.lbl_créer.TabIndex = 9
        Me.lbl_créer.Text = "Créer un utilisateur"
        '
        'pnl_genererUtls
        '
        Me.pnl_genererUtls.Location = New System.Drawing.Point(0, 833)
        Me.pnl_genererUtls.Name = "pnl_genererUtls"
        Me.pnl_genererUtls.Size = New System.Drawing.Size(1170, 130)
        Me.pnl_genererUtls.TabIndex = 11
        '
        'pnl_listeUtls
        '
        Me.pnl_listeUtls.Location = New System.Drawing.Point(0, 68)
        Me.pnl_listeUtls.Name = "pnl_listeUtls"
        Me.pnl_listeUtls.Size = New System.Drawing.Size(1170, 550)
        Me.pnl_listeUtls.TabIndex = 1
        Me.pnl_listeUtls.TabStop = True
        '
        'pnl_ajouterUtls
        '
        Me.pnl_ajouterUtls.Location = New System.Drawing.Point(0, 669)
        Me.pnl_ajouterUtls.Name = "pnl_ajouterUtls"
        Me.pnl_ajouterUtls.Size = New System.Drawing.Size(1170, 130)
        Me.pnl_ajouterUtls.TabIndex = 10
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel5.Controls.Add(Me.lbl_liste)
        Me.Panel5.Location = New System.Drawing.Point(0, 40)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1170, 28)
        Me.Panel5.TabIndex = 49
        '
        'lbl_liste
        '
        Me.lbl_liste.AutoSize = True
        Me.lbl_liste.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lbl_liste.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_liste.Location = New System.Drawing.Point(11, 0)
        Me.lbl_liste.Name = "lbl_liste"
        Me.lbl_liste.Size = New System.Drawing.Size(169, 25)
        Me.lbl_liste.TabIndex = 9
        Me.lbl_liste.Text = "Liste des utilisateurs"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lbl_gen)
        Me.Panel2.Location = New System.Drawing.Point(0, 805)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1170, 28)
        Me.Panel2.TabIndex = 47
        '
        'lbl_gen
        '
        Me.lbl_gen.AutoSize = True
        Me.lbl_gen.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lbl_gen.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_gen.Location = New System.Drawing.Point(11, 0)
        Me.lbl_gen.Name = "lbl_gen"
        Me.lbl_gen.Size = New System.Drawing.Size(195, 25)
        Me.lbl_gen.TabIndex = 9
        Me.lbl_gen.Text = "Générer des utilisateurs"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel4.Controls.Add(Me.lbl_titre)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1170, 35)
        Me.Panel4.TabIndex = 45
        Me.Panel4.TabStop = True
        '
        'lbl_titre
        '
        Me.lbl_titre.AutoSize = True
        Me.lbl_titre.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titre.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_titre.Location = New System.Drawing.Point(11, 5)
        Me.lbl_titre.Name = "lbl_titre"
        Me.lbl_titre.Size = New System.Drawing.Size(106, 25)
        Me.lbl_titre.TabIndex = 9
        Me.lbl_titre.Text = "Utilisateurs"
        '
        'usr_gestion_MenuUtls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.pnl_menuCours)
        Me.Name = "usr_gestion_MenuUtls"
        Me.Size = New System.Drawing.Size(1154, 818)
        Me.pnl_menuCours.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_menuCours As Panel
    Friend WithEvents pnl_ajouterUtls As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbl_titre As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_créer As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_gen As Label
    Friend WithEvents pnl_genererUtls As Panel
    Friend WithEvents pnl_listeUtls As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_liste As Label
End Class
