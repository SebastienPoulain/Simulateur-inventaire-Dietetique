<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDietetique
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.pnl_navigation = New System.Windows.Forms.Panel()
        Me.lbl_titre = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_minimize = New System.Windows.Forms.Button()
        Me.pnl_simulation_inventaire = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnGestion = New System.Windows.Forms.Button()
        Me.btnRecette = New System.Windows.Forms.Button()
        Me.btnCommandes = New System.Windows.Forms.Button()
        Me.btnInventaire = New System.Windows.Forms.Button()
        Me.btnProduits = New System.Windows.Forms.Button()
        Me.btnExercices = New System.Windows.Forms.Button()
        Me.pnl_navigation.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_navigation
        '
        Me.pnl_navigation.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.pnl_navigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_navigation.Controls.Add(Me.lbl_titre)
        Me.pnl_navigation.Controls.Add(Me.btn_exit)
        Me.pnl_navigation.Controls.Add(Me.btn_minimize)
        Me.pnl_navigation.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_navigation.Location = New System.Drawing.Point(0, 0)
        Me.pnl_navigation.Name = "pnl_navigation"
        Me.pnl_navigation.Size = New System.Drawing.Size(1440, 30)
        Me.pnl_navigation.TabIndex = 1
        '
        'lbl_titre
        '
        Me.lbl_titre.AutoSize = True
        Me.lbl_titre.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titre.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_titre.Location = New System.Drawing.Point(12, 5)
        Me.lbl_titre.Name = "lbl_titre"
        Me.lbl_titre.Size = New System.Drawing.Size(318, 17)
        Me.lbl_titre.TabIndex = 2
        Me.lbl_titre.Text = "Techniques de diététiques - Simulateur d'inventaire"
        '
        'btn_exit
        '
        Me.btn_exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_exit.FlatAppearance.BorderSize = 0
        Me.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown
        Me.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.ForeColor = System.Drawing.Color.DimGray
        Me.btn_exit.Image = Global.projet_dietetique.My.Resources.Resources.ic_clear_white_24dp_1x
        Me.btn_exit.Location = New System.Drawing.Point(1388, 0)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(50, 28)
        Me.btn_exit.TabIndex = 1
        Me.btn_exit.TabStop = False
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_minimize
        '
        Me.btn_minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_minimize.FlatAppearance.BorderSize = 0
        Me.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimize.ForeColor = System.Drawing.Color.DimGray
        Me.btn_minimize.Image = Global.projet_dietetique.My.Resources.Resources.ic_remove_white_24dp_1x
        Me.btn_minimize.Location = New System.Drawing.Point(1338, 0)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(50, 28)
        Me.btn_minimize.TabIndex = 0
        Me.btn_minimize.TabStop = False
        Me.btn_minimize.UseVisualStyleBackColor = True
        '
        'pnl_simulation_inventaire
        '
        Me.pnl_simulation_inventaire.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnl_simulation_inventaire.Location = New System.Drawing.Point(-1, 34)
        Me.pnl_simulation_inventaire.Name = "pnl_simulation_inventaire"
        Me.pnl_simulation_inventaire.Size = New System.Drawing.Size(1438, 835)
        Me.pnl_simulation_inventaire.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.pnl_simulation_inventaire)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1440, 870)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnGestion)
        Me.Panel2.Controls.Add(Me.btnRecette)
        Me.Panel2.Controls.Add(Me.btnCommandes)
        Me.Panel2.Controls.Add(Me.btnInventaire)
        Me.Panel2.Controls.Add(Me.btnProduits)
        Me.Panel2.Controls.Add(Me.btnExercices)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1438, 35)
        Me.Panel2.TabIndex = 16
        '
        'btnGestion
        '
        Me.btnGestion.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnGestion.FlatAppearance.BorderSize = 0
        Me.btnGestion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGestion.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGestion.ForeColor = System.Drawing.SystemColors.Control
        Me.btnGestion.Location = New System.Drawing.Point(1200, -1)
        Me.btnGestion.Name = "btnGestion"
        Me.btnGestion.Size = New System.Drawing.Size(239, 35)
        Me.btnGestion.TabIndex = 18
        Me.btnGestion.TabStop = False
        Me.btnGestion.Text = "Paramètres"
        Me.btnGestion.UseVisualStyleBackColor = False
        Me.btnGestion.Visible = False
        '
        'btnRecette
        '
        Me.btnRecette.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnRecette.FlatAppearance.BorderSize = 0
        Me.btnRecette.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnRecette.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecette.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecette.ForeColor = System.Drawing.SystemColors.Control
        Me.btnRecette.Location = New System.Drawing.Point(960, -1)
        Me.btnRecette.Name = "btnRecette"
        Me.btnRecette.Size = New System.Drawing.Size(239, 35)
        Me.btnRecette.TabIndex = 20
        Me.btnRecette.TabStop = False
        Me.btnRecette.Text = "Recettes"
        Me.btnRecette.UseVisualStyleBackColor = False
        '
        'btnCommandes
        '
        Me.btnCommandes.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnCommandes.FlatAppearance.BorderSize = 0
        Me.btnCommandes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnCommandes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCommandes.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommandes.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCommandes.Location = New System.Drawing.Point(720, -1)
        Me.btnCommandes.Name = "btnCommandes"
        Me.btnCommandes.Size = New System.Drawing.Size(239, 35)
        Me.btnCommandes.TabIndex = 17
        Me.btnCommandes.TabStop = False
        Me.btnCommandes.Text = "Commandes"
        Me.btnCommandes.UseVisualStyleBackColor = False
        '
        'btnInventaire
        '
        Me.btnInventaire.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnInventaire.FlatAppearance.BorderSize = 0
        Me.btnInventaire.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnInventaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventaire.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventaire.ForeColor = System.Drawing.SystemColors.Control
        Me.btnInventaire.Location = New System.Drawing.Point(480, -1)
        Me.btnInventaire.Name = "btnInventaire"
        Me.btnInventaire.Size = New System.Drawing.Size(239, 35)
        Me.btnInventaire.TabIndex = 16
        Me.btnInventaire.TabStop = False
        Me.btnInventaire.Text = "Inventaire"
        Me.btnInventaire.UseVisualStyleBackColor = False
        '
        'btnProduits
        '
        Me.btnProduits.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnProduits.FlatAppearance.BorderSize = 0
        Me.btnProduits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnProduits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduits.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduits.ForeColor = System.Drawing.SystemColors.Control
        Me.btnProduits.Location = New System.Drawing.Point(240, -1)
        Me.btnProduits.Name = "btnProduits"
        Me.btnProduits.Size = New System.Drawing.Size(239, 35)
        Me.btnProduits.TabIndex = 15
        Me.btnProduits.TabStop = False
        Me.btnProduits.Text = "Produits"
        Me.btnProduits.UseVisualStyleBackColor = False
        '
        'btnExercices
        '
        Me.btnExercices.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnExercices.FlatAppearance.BorderSize = 0
        Me.btnExercices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnExercices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExercices.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExercices.ForeColor = System.Drawing.SystemColors.Control
        Me.btnExercices.Location = New System.Drawing.Point(0, -1)
        Me.btnExercices.Name = "btnExercices"
        Me.btnExercices.Size = New System.Drawing.Size(239, 35)
        Me.btnExercices.TabIndex = 14
        Me.btnExercices.TabStop = False
        Me.btnExercices.Text = "Exercices"
        Me.btnExercices.UseVisualStyleBackColor = False
        '
        'frmDietetique
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1440, 900)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnl_navigation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDietetique"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDietetique"
        Me.pnl_navigation.ResumeLayout(False)
        Me.pnl_navigation.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_navigation As Panel
    Friend WithEvents lbl_titre As Label
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_minimize As Button
    Friend WithEvents pnl_simulation_inventaire As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnRecette As Button
    Friend WithEvents btnGestion As Button
    Friend WithEvents btnCommandes As Button
    Friend WithEvents btnInventaire As Button
    Friend WithEvents btnProduits As Button
    Friend WithEvents btnExercices As Button
End Class
