<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usr_ajouter_utls
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbE_nm = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_nm = New System.Windows.Forms.TextBox()
        Me.btn_ajouter = New System.Windows.Forms.Button()
        Me.lbE_titre = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbo_titre = New System.Windows.Forms.ComboBox()
        Me.lbE_mdp2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_mdp2 = New System.Windows.Forms.TextBox()
        Me.lbE_mdp = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_mdp = New System.Windows.Forms.TextBox()
        Me.lbE_utls = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_utls = New System.Windows.Forms.TextBox()
        Me.lbl_ajoutSucces = New System.Windows.Forms.Label()
        Me.timer_succes = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblE_pnm = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_pnm = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(5, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 15)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "*Facultatif"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(533, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(12, 15)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "*"
        '
        'lbE_nm
        '
        Me.lbE_nm.AutoSize = True
        Me.lbE_nm.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lbE_nm.ForeColor = System.Drawing.Color.Firebrick
        Me.lbE_nm.Location = New System.Drawing.Point(364, 48)
        Me.lbE_nm.Name = "lbE_nm"
        Me.lbE_nm.Size = New System.Drawing.Size(98, 13)
        Me.lbE_nm.TabIndex = 40
        Me.lbE_nm.Text = "Caractère invalide"
        Me.lbE_nm.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(361, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 15)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Nom"
        '
        'txt_nm
        '
        Me.txt_nm.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nm.Location = New System.Drawing.Point(364, 25)
        Me.txt_nm.MaxLength = 35
        Me.txt_nm.Name = "txt_nm"
        Me.txt_nm.Size = New System.Drawing.Size(168, 22)
        Me.txt_nm.TabIndex = 3
        Me.txt_nm.Tag = "5"
        '
        'btn_ajouter
        '
        Me.btn_ajouter.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_ajouter.Enabled = False
        Me.btn_ajouter.FlatAppearance.BorderSize = 0
        Me.btn_ajouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ajouter.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajouter.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_ajouter.Location = New System.Drawing.Point(1064, 46)
        Me.btn_ajouter.Name = "btn_ajouter"
        Me.btn_ajouter.Size = New System.Drawing.Size(95, 32)
        Me.btn_ajouter.TabIndex = 7
        Me.btn_ajouter.Text = "Créer"
        Me.btn_ajouter.UseVisualStyleBackColor = False
        '
        'lbE_titre
        '
        Me.lbE_titre.AutoSize = True
        Me.lbE_titre.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lbE_titre.ForeColor = System.Drawing.Color.Firebrick
        Me.lbE_titre.Location = New System.Drawing.Point(879, 48)
        Me.lbE_titre.Name = "lbE_titre"
        Me.lbE_titre.Size = New System.Drawing.Size(112, 13)
        Me.lbE_titre.TabIndex = 37
        Me.lbE_titre.Text = "Sélectionner un titre"
        Me.lbE_titre.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(875, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 15)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Titre"
        '
        'cbo_titre
        '
        Me.cbo_titre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_titre.FormattingEnabled = True
        Me.cbo_titre.Location = New System.Drawing.Point(878, 25)
        Me.cbo_titre.Name = "cbo_titre"
        Me.cbo_titre.Size = New System.Drawing.Size(153, 21)
        Me.cbo_titre.TabIndex = 6
        Me.cbo_titre.Tag = "4"
        '
        'lbE_mdp2
        '
        Me.lbE_mdp2.AutoSize = True
        Me.lbE_mdp2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lbE_mdp2.ForeColor = System.Drawing.Color.Firebrick
        Me.lbE_mdp2.Location = New System.Drawing.Point(709, 48)
        Me.lbE_mdp2.Name = "lbE_mdp2"
        Me.lbE_mdp2.Size = New System.Drawing.Size(141, 13)
        Me.lbE_mdp2.TabIndex = 34
        Me.lbE_mdp2.Text = "Confirmer le mot de passe"
        Me.lbE_mdp2.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(706, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 15)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Confirmer le mot de passe"
        '
        'txt_mdp2
        '
        Me.txt_mdp2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mdp2.Location = New System.Drawing.Point(709, 25)
        Me.txt_mdp2.MaxLength = 35
        Me.txt_mdp2.Name = "txt_mdp2"
        Me.txt_mdp2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_mdp2.Size = New System.Drawing.Size(143, 22)
        Me.txt_mdp2.TabIndex = 5
        Me.txt_mdp2.Tag = "3"
        '
        'lbE_mdp
        '
        Me.lbE_mdp.AutoSize = True
        Me.lbE_mdp.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lbE_mdp.ForeColor = System.Drawing.Color.Firebrick
        Me.lbE_mdp.Location = New System.Drawing.Point(554, 48)
        Me.lbE_mdp.Name = "lbE_mdp"
        Me.lbE_mdp.Size = New System.Drawing.Size(139, 13)
        Me.lbE_mdp.TabIndex = 31
        Me.lbE_mdp.Text = "Saisissez un mot de passe"
        Me.lbE_mdp.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(551, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 15)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Mot de passe"
        '
        'txt_mdp
        '
        Me.txt_mdp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mdp.Location = New System.Drawing.Point(554, 25)
        Me.txt_mdp.MaxLength = 35
        Me.txt_mdp.Name = "txt_mdp"
        Me.txt_mdp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_mdp.Size = New System.Drawing.Size(139, 22)
        Me.txt_mdp.TabIndex = 4
        Me.txt_mdp.Tag = "2"
        '
        'lbE_utls
        '
        Me.lbE_utls.AutoSize = True
        Me.lbE_utls.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lbE_utls.ForeColor = System.Drawing.Color.Firebrick
        Me.lbE_utls.Location = New System.Drawing.Point(8, 47)
        Me.lbE_utls.Name = "lbE_utls"
        Me.lbE_utls.Size = New System.Drawing.Size(159, 13)
        Me.lbE_utls.TabIndex = 28
        Me.lbE_utls.Text = "Saisissez un nom d'utilisateur"
        Me.lbE_utls.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(5, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 15)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Nom d'utilisateur"
        '
        'txt_utls
        '
        Me.txt_utls.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_utls.Location = New System.Drawing.Point(8, 24)
        Me.txt_utls.MaxLength = 20
        Me.txt_utls.Name = "txt_utls"
        Me.txt_utls.Size = New System.Drawing.Size(141, 22)
        Me.txt_utls.TabIndex = 1
        Me.txt_utls.Tag = "1"
        '
        'lbl_ajoutSucces
        '
        Me.lbl_ajoutSucces.BackColor = System.Drawing.Color.Lime
        Me.lbl_ajoutSucces.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_ajoutSucces.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_ajoutSucces.Location = New System.Drawing.Point(3, 98)
        Me.lbl_ajoutSucces.Name = "lbl_ajoutSucces"
        Me.lbl_ajoutSucces.Size = New System.Drawing.Size(1164, 24)
        Me.lbl_ajoutSucces.TabIndex = 43
        Me.lbl_ajoutSucces.Text = "L'utilisateur a bien été ajouté."
        Me.lbl_ajoutSucces.Visible = False
        '
        'timer_succes
        '
        Me.timer_succes.Interval = 1
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lblE_pnm)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txt_pnm)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txt_utls)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lbE_nm)
        Me.Panel1.Controls.Add(Me.lbE_utls)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_mdp)
        Me.Panel1.Controls.Add(Me.txt_nm)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btn_ajouter)
        Me.Panel1.Controls.Add(Me.lbE_mdp)
        Me.Panel1.Controls.Add(Me.lbE_titre)
        Me.Panel1.Controls.Add(Me.txt_mdp2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cbo_titre)
        Me.Panel1.Controls.Add(Me.lbE_mdp2)
        Me.Panel1.Location = New System.Drawing.Point(3, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1164, 84)
        Me.Panel1.TabIndex = 44
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(346, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(12, 15)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "*"
        '
        'lblE_pnm
        '
        Me.lblE_pnm.AutoSize = True
        Me.lblE_pnm.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblE_pnm.ForeColor = System.Drawing.Color.Firebrick
        Me.lblE_pnm.Location = New System.Drawing.Point(177, 47)
        Me.lblE_pnm.Name = "lblE_pnm"
        Me.lblE_pnm.Size = New System.Drawing.Size(98, 13)
        Me.lblE_pnm.TabIndex = 45
        Me.lblE_pnm.Text = "Caractère invalide"
        Me.lblE_pnm.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(174, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 15)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Prénom"
        '
        'txt_pnm
        '
        Me.txt_pnm.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pnm.Location = New System.Drawing.Point(177, 24)
        Me.txt_pnm.MaxLength = 35
        Me.txt_pnm.Name = "txt_pnm"
        Me.txt_pnm.Size = New System.Drawing.Size(168, 22)
        Me.txt_pnm.TabIndex = 2
        Me.txt_pnm.Tag = "6"
        '
        'usr_ajouter_utls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl_ajoutSucces)
        Me.Name = "usr_ajouter_utls"
        Me.Size = New System.Drawing.Size(1170, 130)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbE_titre As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbo_titre As ComboBox
    Friend WithEvents lbE_mdp2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_mdp2 As TextBox
    Friend WithEvents lbE_mdp As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_mdp As TextBox
    Friend WithEvents lbE_utls As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_utls As TextBox
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents txt_nm As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lbE_nm As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_ajoutSucces As Label
    Friend WithEvents timer_succes As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents lblE_pnm As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_pnm As TextBox
End Class
