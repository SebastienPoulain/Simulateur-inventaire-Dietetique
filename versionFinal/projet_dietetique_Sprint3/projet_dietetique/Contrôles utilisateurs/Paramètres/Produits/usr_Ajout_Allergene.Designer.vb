<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usr_ajout_allergene
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
        Me.pnl_navigation = New System.Windows.Forms.Panel()
        Me.lbl_titre = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_minimize = New System.Windows.Forms.Button()
        Me.lbl_erreur_allergene = New System.Windows.Forms.Label()
        Me.btn_ajouter_allergene = New System.Windows.Forms.Button()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.lbl_allergene = New System.Windows.Forms.Label()
        Me.txt_allergene = New System.Windows.Forms.TextBox()
        Me.timer_allergene = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_succes = New System.Windows.Forms.Label()
        Me.timer_succes = New System.Windows.Forms.Timer(Me.components)
        Me.pnl_navigation.SuspendLayout()
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
        Me.pnl_navigation.Size = New System.Drawing.Size(701, 30)
        Me.pnl_navigation.TabIndex = 198
        '
        'lbl_titre
        '
        Me.lbl_titre.AutoSize = True
        Me.lbl_titre.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lbl_titre.ForeColor = System.Drawing.Color.White
        Me.lbl_titre.Location = New System.Drawing.Point(12, 1)
        Me.lbl_titre.Name = "lbl_titre"
        Me.lbl_titre.Size = New System.Drawing.Size(139, 25)
        Me.lbl_titre.TabIndex = 2
        Me.lbl_titre.Text = "Ajout allergènes"
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
        Me.btn_exit.Location = New System.Drawing.Point(649, 0)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(50, 28)
        Me.btn_exit.TabIndex = 1
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_minimize
        '
        Me.btn_minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_minimize.FlatAppearance.BorderSize = 0
        Me.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimize.ForeColor = System.Drawing.Color.DimGray
        Me.btn_minimize.Image = Global.projet_dietetique.My.Resources.Resources.ic_remove_white_24dp_1x
        Me.btn_minimize.Location = New System.Drawing.Point(599, 0)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(50, 28)
        Me.btn_minimize.TabIndex = 0
        Me.btn_minimize.UseVisualStyleBackColor = True
        '
        'lbl_erreur_allergene
        '
        Me.lbl_erreur_allergene.AutoSize = True
        Me.lbl_erreur_allergene.ForeColor = System.Drawing.Color.White
        Me.lbl_erreur_allergene.Location = New System.Drawing.Point(239, 164)
        Me.lbl_erreur_allergene.Name = "lbl_erreur_allergene"
        Me.lbl_erreur_allergene.Size = New System.Drawing.Size(0, 13)
        Me.lbl_erreur_allergene.TabIndex = 203
        '
        'btn_ajouter_allergene
        '
        Me.btn_ajouter_allergene.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_ajouter_allergene.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ajouter_allergene.FlatAppearance.BorderSize = 0
        Me.btn_ajouter_allergene.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ajouter_allergene.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajouter_allergene.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_ajouter_allergene.Location = New System.Drawing.Point(365, 251)
        Me.btn_ajouter_allergene.Name = "btn_ajouter_allergene"
        Me.btn_ajouter_allergene.Size = New System.Drawing.Size(154, 32)
        Me.btn_ajouter_allergene.TabIndex = 202
        Me.btn_ajouter_allergene.Text = "Ajouter"
        Me.btn_ajouter_allergene.UseVisualStyleBackColor = False
        '
        'btn_annuler
        '
        Me.btn_annuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_annuler.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_annuler.FlatAppearance.BorderSize = 0
        Me.btn_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_annuler.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annuler.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_annuler.Location = New System.Drawing.Point(164, 251)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(154, 32)
        Me.btn_annuler.TabIndex = 201
        Me.btn_annuler.Text = "Annuler"
        Me.btn_annuler.UseVisualStyleBackColor = False
        '
        'lbl_allergene
        '
        Me.lbl_allergene.AutoSize = True
        Me.lbl_allergene.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.lbl_allergene.ForeColor = System.Drawing.Color.Black
        Me.lbl_allergene.Location = New System.Drawing.Point(90, 127)
        Me.lbl_allergene.Name = "lbl_allergene"
        Me.lbl_allergene.Size = New System.Drawing.Size(120, 17)
        Me.lbl_allergene.TabIndex = 200
        Me.lbl_allergene.Text = "Nom de l'allergène"
        '
        'txt_allergene
        '
        Me.txt_allergene.Location = New System.Drawing.Point(224, 127)
        Me.txt_allergene.Name = "txt_allergene"
        Me.txt_allergene.Size = New System.Drawing.Size(275, 20)
        Me.txt_allergene.TabIndex = 199
        '
        'timer_allergene
        '
        '
        'lbl_succes
        '
        Me.lbl_succes.AutoSize = True
        Me.lbl_succes.Location = New System.Drawing.Point(267, 92)
        Me.lbl_succes.Name = "lbl_succes"
        Me.lbl_succes.Size = New System.Drawing.Size(0, 13)
        Me.lbl_succes.TabIndex = 204
        '
        'usr_ajout_allergene
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lbl_succes)
        Me.Controls.Add(Me.pnl_navigation)
        Me.Controls.Add(Me.lbl_erreur_allergene)
        Me.Controls.Add(Me.btn_ajouter_allergene)
        Me.Controls.Add(Me.btn_annuler)
        Me.Controls.Add(Me.lbl_allergene)
        Me.Controls.Add(Me.txt_allergene)
        Me.Name = "usr_ajout_allergene"
        Me.Size = New System.Drawing.Size(701, 330)
        Me.pnl_navigation.ResumeLayout(False)
        Me.pnl_navigation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnl_navigation As Panel
    Friend WithEvents lbl_titre As Label
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_minimize As Button
    Friend WithEvents lbl_erreur_allergene As Label
    Friend WithEvents btn_ajouter_allergene As Button
    Friend WithEvents btn_annuler As Button
    Friend WithEvents lbl_allergene As Label
    Friend WithEvents txt_allergene As TextBox
    Friend WithEvents timer_allergene As Timer
    Friend WithEvents lbl_succes As Label
    Friend WithEvents timer_succes As Timer
End Class
