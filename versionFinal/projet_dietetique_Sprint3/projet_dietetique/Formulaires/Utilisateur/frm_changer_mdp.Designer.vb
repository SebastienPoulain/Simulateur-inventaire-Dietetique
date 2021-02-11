<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_changer_mdp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnl_navigation = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_titre = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblE_nouveau2 = New System.Windows.Forms.Label()
        Me.txt_nv2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblE_nouveau = New System.Windows.Forms.Label()
        Me.txt_nv = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_modifier = New System.Windows.Forms.Button()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.lblE_ancien = New System.Windows.Forms.Label()
        Me.txt_ancien = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_minimize = New System.Windows.Forms.Button()
        Me.pnl_navigation.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.pnl_navigation.Size = New System.Drawing.Size(387, 30)
        Me.pnl_navigation.TabIndex = 58
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
        Me.lbl_titre.Size = New System.Drawing.Size(176, 17)
        Me.lbl_titre.TabIndex = 2
        Me.lbl_titre.Text = "Modifier mon mot de passe"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblE_nouveau2)
        Me.Panel1.Controls.Add(Me.txt_nv2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.lblE_nouveau)
        Me.Panel1.Controls.Add(Me.txt_nv)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btn_modifier)
        Me.Panel1.Controls.Add(Me.btn_annuler)
        Me.Panel1.Controls.Add(Me.lblE_ancien)
        Me.Panel1.Controls.Add(Me.txt_ancien)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(387, 215)
        Me.Panel1.TabIndex = 59
        '
        'lblE_nouveau2
        '
        Me.lblE_nouveau2.AutoSize = True
        Me.lblE_nouveau2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblE_nouveau2.ForeColor = System.Drawing.Color.Firebrick
        Me.lblE_nouveau2.Location = New System.Drawing.Point(178, 121)
        Me.lblE_nouveau2.Name = "lblE_nouveau2"
        Me.lblE_nouveau2.Size = New System.Drawing.Size(179, 13)
        Me.lblE_nouveau2.TabIndex = 58
        Me.lblE_nouveau2.Text = "Mot de passe non correspondant"
        Me.lblE_nouveau2.Visible = False
        '
        'txt_nv2
        '
        Me.txt_nv2.Location = New System.Drawing.Point(178, 101)
        Me.txt_nv2.MaxLength = 35
        Me.txt_nv2.Name = "txt_nv2"
        Me.txt_nv2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_nv2.Size = New System.Drawing.Size(196, 20)
        Me.txt_nv2.TabIndex = 3
        Me.txt_nv2.Tag = "3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(5, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 17)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Confirmer le mot de passe:"
        '
        'lblE_nouveau
        '
        Me.lblE_nouveau.AutoSize = True
        Me.lblE_nouveau.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblE_nouveau.ForeColor = System.Drawing.Color.Firebrick
        Me.lblE_nouveau.Location = New System.Drawing.Point(177, 81)
        Me.lblE_nouveau.Name = "lblE_nouveau"
        Me.lblE_nouveau.Size = New System.Drawing.Size(98, 13)
        Me.lblE_nouveau.TabIndex = 55
        Me.lblE_nouveau.Text = "Caractère invalide"
        Me.lblE_nouveau.Visible = False
        '
        'txt_nv
        '
        Me.txt_nv.Location = New System.Drawing.Point(178, 60)
        Me.txt_nv.MaxLength = 35
        Me.txt_nv.Name = "txt_nv"
        Me.txt_nv.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_nv.Size = New System.Drawing.Size(196, 20)
        Me.txt_nv.TabIndex = 2
        Me.txt_nv.Tag = "2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(25, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 17)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Nouveau mot de passe:"
        '
        'btn_modifier
        '
        Me.btn_modifier.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_modifier.Enabled = False
        Me.btn_modifier.FlatAppearance.BorderSize = 0
        Me.btn_modifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_modifier.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modifier.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_modifier.Location = New System.Drawing.Point(178, 170)
        Me.btn_modifier.Name = "btn_modifier"
        Me.btn_modifier.Size = New System.Drawing.Size(95, 32)
        Me.btn_modifier.TabIndex = 4
        Me.btn_modifier.Text = "Modifier"
        Me.btn_modifier.UseVisualStyleBackColor = False
        '
        'btn_annuler
        '
        Me.btn_annuler.BackColor = System.Drawing.Color.DimGray
        Me.btn_annuler.FlatAppearance.BorderSize = 0
        Me.btn_annuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_annuler.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annuler.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_annuler.Location = New System.Drawing.Point(279, 170)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(95, 32)
        Me.btn_annuler.TabIndex = 5
        Me.btn_annuler.Text = "Annuler"
        Me.btn_annuler.UseVisualStyleBackColor = False
        '
        'lblE_ancien
        '
        Me.lblE_ancien.AutoSize = True
        Me.lblE_ancien.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblE_ancien.ForeColor = System.Drawing.Color.Firebrick
        Me.lblE_ancien.Location = New System.Drawing.Point(177, 38)
        Me.lblE_ancien.Name = "lblE_ancien"
        Me.lblE_ancien.Size = New System.Drawing.Size(98, 13)
        Me.lblE_ancien.TabIndex = 52
        Me.lblE_ancien.Text = "Caractère invalide"
        Me.lblE_ancien.Visible = False
        '
        'txt_ancien
        '
        Me.txt_ancien.Location = New System.Drawing.Point(178, 17)
        Me.txt_ancien.MaxLength = 35
        Me.txt_ancien.Name = "txt_ancien"
        Me.txt_ancien.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_ancien.Size = New System.Drawing.Size(196, 20)
        Me.txt_ancien.TabIndex = 1
        Me.txt_ancien.Tag = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(42, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 17)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Mot de passe actuel:"
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
        Me.btn_exit.Location = New System.Drawing.Point(335, 0)
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
        Me.btn_minimize.Location = New System.Drawing.Point(285, 0)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(50, 28)
        Me.btn_minimize.TabIndex = 0
        Me.btn_minimize.TabStop = False
        Me.btn_minimize.UseVisualStyleBackColor = True
        '
        'frm_changer_mdp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 244)
        Me.Controls.Add(Me.pnl_navigation)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_changer_mdp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frm_changer_mdp"
        Me.pnl_navigation.ResumeLayout(False)
        Me.pnl_navigation.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_navigation As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbl_titre As Label
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_minimize As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblE_nouveau2 As Label
    Friend WithEvents txt_nv2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblE_nouveau As Label
    Friend WithEvents txt_nv As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_modifier As Button
    Friend WithEvents btn_annuler As Button
    Friend WithEvents lblE_ancien As Label
    Friend WithEvents txt_ancien As TextBox
    Friend WithEvents Label3 As Label
End Class
