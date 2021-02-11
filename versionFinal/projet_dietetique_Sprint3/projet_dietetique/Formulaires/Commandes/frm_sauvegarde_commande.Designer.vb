<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_sauvegarde_commande
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
        Me.sfd_commande_pdf = New System.Windows.Forms.SaveFileDialog()
        Me.pn_sauvegarde_commande = New System.Windows.Forms.Panel()
        Me.lbl_titre = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_minimize = New System.Windows.Forms.Button()
        Me.pnl_navigation = New System.Windows.Forms.Panel()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.pnl_navigation.SuspendLayout()
        Me.SuspendLayout()
        '
        'sfd_commande_pdf
        '
        '
        'pn_sauvegarde_commande
        '
        Me.pn_sauvegarde_commande.AutoScroll = True
        Me.pn_sauvegarde_commande.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pn_sauvegarde_commande.Location = New System.Drawing.Point(0, 34)
        Me.pn_sauvegarde_commande.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pn_sauvegarde_commande.Name = "pn_sauvegarde_commande"
        Me.pn_sauvegarde_commande.Size = New System.Drawing.Size(946, 785)
        Me.pn_sauvegarde_commande.TabIndex = 103
        '
        'lbl_titre
        '
        Me.lbl_titre.AutoSize = True
        Me.lbl_titre.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titre.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_titre.Location = New System.Drawing.Point(16, 6)
        Me.lbl_titre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_titre.Name = "lbl_titre"
        Me.lbl_titre.Size = New System.Drawing.Size(183, 23)
        Me.lbl_titre.TabIndex = 2
        Me.lbl_titre.Text = "Détails de commandes"
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
        Me.btn_exit.Location = New System.Drawing.Point(877, 0)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(67, 34)
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
        Me.btn_minimize.Location = New System.Drawing.Point(811, 0)
        Me.btn_minimize.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(67, 34)
        Me.btn_minimize.TabIndex = 0
        Me.btn_minimize.TabStop = False
        Me.btn_minimize.UseVisualStyleBackColor = True
        '
        'pnl_navigation
        '
        Me.pnl_navigation.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.pnl_navigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_navigation.Controls.Add(Me.lbl_titre)
        Me.pnl_navigation.Controls.Add(Me.btn_exit)
        Me.pnl_navigation.Controls.Add(Me.btn_minimize)
        Me.pnl_navigation.Location = New System.Drawing.Point(0, 0)
        Me.pnl_navigation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnl_navigation.Name = "pnl_navigation"
        Me.pnl_navigation.Size = New System.Drawing.Size(946, 39)
        Me.pnl_navigation.TabIndex = 103
        '
        'frm_sauvegarde_commande
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 777)
        Me.Controls.Add(Me.pnl_navigation)
        Me.Controls.Add(Me.pn_sauvegarde_commande)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(0, 2)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_sauvegarde_commande"
        Me.Text = "frm_sauvegarde_commande"
        Me.pnl_navigation.ResumeLayout(False)
        Me.pnl_navigation.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents sfd_commande_pdf As SaveFileDialog
    Friend WithEvents pn_sauvegarde_commande As Panel
    Friend WithEvents lbl_titre As Label
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_minimize As Button
    Friend WithEvents pnl_navigation As Panel
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
