<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmModifierCommande
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtFormat = New System.Windows.Forms.TextBox()
        Me.txtNomProduit = New System.Windows.Forms.TextBox()
        Me.pnl_navigation = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_titre = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_minimize = New System.Windows.Forms.Button()
        Me.btnEnregistrer = New System.Windows.Forms.Button()
        Me.txtUniteMesureModifier = New System.Windows.Forms.TextBox()
        Me.txtQuantite = New System.Windows.Forms.TextBox()
        Me.btnAnnulerCommande = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.pnl_navigation.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtFormat)
        Me.Panel1.Controls.Add(Me.txtNomProduit)
        Me.Panel1.Controls.Add(Me.pnl_navigation)
        Me.Panel1.Controls.Add(Me.btnEnregistrer)
        Me.Panel1.Controls.Add(Me.txtUniteMesureModifier)
        Me.Panel1.Controls.Add(Me.txtQuantite)
        Me.Panel1.Controls.Add(Me.btnAnnulerCommande)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(445, 310)
        Me.Panel1.TabIndex = 102
        '
        'txtFormat
        '
        Me.txtFormat.Enabled = False
        Me.txtFormat.Location = New System.Drawing.Point(120, 147)
        Me.txtFormat.MaxLength = 30
        Me.txtFormat.Name = "txtFormat"
        Me.txtFormat.Size = New System.Drawing.Size(150, 20)
        Me.txtFormat.TabIndex = 103
        '
        'txtNomProduit
        '
        Me.txtNomProduit.Enabled = False
        Me.txtNomProduit.Location = New System.Drawing.Point(120, 64)
        Me.txtNomProduit.MaxLength = 50
        Me.txtNomProduit.Name = "txtNomProduit"
        Me.txtNomProduit.Size = New System.Drawing.Size(212, 20)
        Me.txtNomProduit.TabIndex = 65
        '
        'pnl_navigation
        '
        Me.pnl_navigation.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.pnl_navigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_navigation.Controls.Add(Me.Panel3)
        Me.pnl_navigation.Controls.Add(Me.lbl_titre)
        Me.pnl_navigation.Controls.Add(Me.btn_exit)
        Me.pnl_navigation.Controls.Add(Me.btn_minimize)
        Me.pnl_navigation.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_navigation.Location = New System.Drawing.Point(0, 0)
        Me.pnl_navigation.Name = "pnl_navigation"
        Me.pnl_navigation.Size = New System.Drawing.Size(443, 30)
        Me.pnl_navigation.TabIndex = 102
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(-1, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(738, 579)
        Me.Panel3.TabIndex = 3
        '
        'lbl_titre
        '
        Me.lbl_titre.AutoSize = True
        Me.lbl_titre.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titre.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_titre.Location = New System.Drawing.Point(12, 5)
        Me.lbl_titre.Name = "lbl_titre"
        Me.lbl_titre.Size = New System.Drawing.Size(127, 17)
        Me.lbl_titre.TabIndex = 2
        Me.lbl_titre.Text = "Modifier un produit"
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
        Me.btn_exit.Location = New System.Drawing.Point(391, 0)
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
        Me.btn_minimize.Location = New System.Drawing.Point(341, 0)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(50, 28)
        Me.btn_minimize.TabIndex = 0
        Me.btn_minimize.TabStop = False
        Me.btn_minimize.UseVisualStyleBackColor = True
        '
        'btnEnregistrer
        '
        Me.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnEnregistrer.FlatAppearance.BorderSize = 0
        Me.btnEnregistrer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnregistrer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnregistrer.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEnregistrer.Location = New System.Drawing.Point(89, 234)
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.btnEnregistrer.Size = New System.Drawing.Size(121, 32)
        Me.btnEnregistrer.TabIndex = 82
        Me.btnEnregistrer.Text = "Enregistrer"
        Me.btnEnregistrer.UseVisualStyleBackColor = False
        '
        'txtUniteMesureModifier
        '
        Me.txtUniteMesureModifier.Enabled = False
        Me.txtUniteMesureModifier.Location = New System.Drawing.Point(120, 188)
        Me.txtUniteMesureModifier.MaxLength = 30
        Me.txtUniteMesureModifier.Name = "txtUniteMesureModifier"
        Me.txtUniteMesureModifier.Size = New System.Drawing.Size(112, 20)
        Me.txtUniteMesureModifier.TabIndex = 101
        '
        'txtQuantite
        '
        Me.txtQuantite.Location = New System.Drawing.Point(120, 105)
        Me.txtQuantite.MaxLength = 7
        Me.txtQuantite.Name = "txtQuantite"
        Me.txtQuantite.Size = New System.Drawing.Size(67, 20)
        Me.txtQuantite.TabIndex = 78
        '
        'btnAnnulerCommande
        '
        Me.btnAnnulerCommande.BackColor = System.Drawing.Color.DimGray
        Me.btnAnnulerCommande.FlatAppearance.BorderSize = 0
        Me.btnAnnulerCommande.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnAnnulerCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnulerCommande.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnulerCommande.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAnnulerCommande.Location = New System.Drawing.Point(233, 234)
        Me.btnAnnulerCommande.Name = "btnAnnulerCommande"
        Me.btnAnnulerCommande.Size = New System.Drawing.Size(121, 32)
        Me.btnAnnulerCommande.TabIndex = 83
        Me.btnAnnulerCommande.Text = "Annuler"
        Me.btnAnnulerCommande.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(117, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 15)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "Quantite"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(117, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 15)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Nom du produit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(117, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 15)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Unité de mesure"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(117, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Format"
        '
        'frmModifierCommande
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(445, 310)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmModifierCommande"
        Me.Text = "frmModifierCommande"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnl_navigation.ResumeLayout(False)
        Me.pnl_navigation.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnEnregistrer As Button
    Friend WithEvents txtUniteMesureModifier As TextBox
    Friend WithEvents txtQuantite As TextBox
    Friend WithEvents btnAnnulerCommande As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pnl_navigation As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbl_titre As Label
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_minimize As Button
    Friend WithEvents txtNomProduit As TextBox
    Friend WithEvents txtFormat As TextBox
End Class
