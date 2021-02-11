<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usr_connexionUtls
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usr_connexionUtls))
        Me.pnl_connexion = New System.Windows.Forms.Panel()
        Me.btnConnecter = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtMtp = New System.Windows.Forms.TextBox()
        Me.lbErreurID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lbErreurCours = New System.Windows.Forms.Label()
        Me.lbID = New System.Windows.Forms.Label()
        Me.lbErreurMotPasse = New System.Windows.Forms.Label()
        Me.lbMtp = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureCegep = New System.Windows.Forms.PictureBox()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.pnl_connexion.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureCegep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_connexion
        '
        Me.pnl_connexion.BackColor = System.Drawing.SystemColors.Control
        Me.pnl_connexion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_connexion.Controls.Add(Me.btnConnecter)
        Me.pnl_connexion.Controls.Add(Me.Panel3)
        Me.pnl_connexion.Controls.Add(Me.Panel2)
        Me.pnl_connexion.Controls.Add(Me.PictureCegep)
        Me.pnl_connexion.Controls.Add(Me.btnQuitter)
        Me.pnl_connexion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_connexion.Location = New System.Drawing.Point(0, 0)
        Me.pnl_connexion.Name = "pnl_connexion"
        Me.pnl_connexion.Size = New System.Drawing.Size(706, 256)
        Me.pnl_connexion.TabIndex = 49
        '
        'btnConnecter
        '
        Me.btnConnecter.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnConnecter.FlatAppearance.BorderSize = 0
        Me.btnConnecter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnConnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConnecter.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnecter.ForeColor = System.Drawing.SystemColors.Control
        Me.btnConnecter.Location = New System.Drawing.Point(460, 213)
        Me.btnConnecter.Name = "btnConnecter"
        Me.btnConnecter.Size = New System.Drawing.Size(109, 32)
        Me.btnConnecter.TabIndex = 60
        Me.btnConnecter.Text = "Connexion"
        Me.btnConnecter.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtMtp)
        Me.Panel3.Controls.Add(Me.lbErreurID)
        Me.Panel3.Controls.Add(Me.txtID)
        Me.Panel3.Controls.Add(Me.lbErreurCours)
        Me.Panel3.Controls.Add(Me.lbID)
        Me.Panel3.Controls.Add(Me.lbErreurMotPasse)
        Me.Panel3.Controls.Add(Me.lbMtp)
        Me.Panel3.Location = New System.Drawing.Point(337, 32)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(347, 160)
        Me.Panel3.TabIndex = 54
        '
        'txtMtp
        '
        Me.txtMtp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMtp.Location = New System.Drawing.Point(107, 60)
        Me.txtMtp.MaxLength = 35
        Me.txtMtp.Name = "txtMtp"
        Me.txtMtp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtMtp.Size = New System.Drawing.Size(150, 22)
        Me.txtMtp.TabIndex = 1
        '
        'lbErreurID
        '
        Me.lbErreurID.AutoSize = True
        Me.lbErreurID.ForeColor = System.Drawing.Color.Firebrick
        Me.lbErreurID.Location = New System.Drawing.Point(108, 42)
        Me.lbErreurID.Name = "lbErreurID"
        Me.lbErreurID.Size = New System.Drawing.Size(0, 13)
        Me.lbErreurID.TabIndex = 44
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(107, 20)
        Me.txtID.MaxLength = 20
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(150, 22)
        Me.txtID.TabIndex = 0
        '
        'lbErreurCours
        '
        Me.lbErreurCours.AutoSize = True
        Me.lbErreurCours.ForeColor = System.Drawing.Color.Firebrick
        Me.lbErreurCours.Location = New System.Drawing.Point(107, 136)
        Me.lbErreurCours.Name = "lbErreurCours"
        Me.lbErreurCours.Size = New System.Drawing.Size(0, 13)
        Me.lbErreurCours.TabIndex = 46
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbID.ForeColor = System.Drawing.Color.Black
        Me.lbID.Location = New System.Drawing.Point(30, 23)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(71, 19)
        Me.lbID.TabIndex = 37
        Me.lbID.Text = "Identifiant"
        '
        'lbErreurMotPasse
        '
        Me.lbErreurMotPasse.AutoSize = True
        Me.lbErreurMotPasse.ForeColor = System.Drawing.Color.Firebrick
        Me.lbErreurMotPasse.Location = New System.Drawing.Point(107, 83)
        Me.lbErreurMotPasse.Name = "lbErreurMotPasse"
        Me.lbErreurMotPasse.Size = New System.Drawing.Size(0, 13)
        Me.lbErreurMotPasse.TabIndex = 45
        '
        'lbMtp
        '
        Me.lbMtp.AutoSize = True
        Me.lbMtp.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbMtp.ForeColor = System.Drawing.Color.Black
        Me.lbMtp.Location = New System.Drawing.Point(9, 59)
        Me.lbMtp.Name = "lbMtp"
        Me.lbMtp.Size = New System.Drawing.Size(92, 19)
        Me.lbMtp.TabIndex = 38
        Me.lbMtp.Text = "Mot de passe"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(337, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(347, 26)
        Me.Panel2.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(3, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 21)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Connexion"
        '
        'PictureCegep
        '
        Me.PictureCegep.Image = CType(resources.GetObject("PictureCegep.Image"), System.Drawing.Image)
        Me.PictureCegep.Location = New System.Drawing.Point(11, 14)
        Me.PictureCegep.Name = "PictureCegep"
        Me.PictureCegep.Size = New System.Drawing.Size(286, 178)
        Me.PictureCegep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureCegep.TabIndex = 41
        Me.PictureCegep.TabStop = False
        '
        'btnQuitter
        '
        Me.btnQuitter.BackColor = System.Drawing.Color.DimGray
        Me.btnQuitter.FlatAppearance.BorderSize = 0
        Me.btnQuitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitter.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitter.ForeColor = System.Drawing.SystemColors.Control
        Me.btnQuitter.Location = New System.Drawing.Point(575, 213)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(109, 32)
        Me.btnQuitter.TabIndex = 4
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = False
        '
        'usr_connexionUtls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnl_connexion)
        Me.Name = "usr_connexionUtls"
        Me.Size = New System.Drawing.Size(706, 256)
        Me.pnl_connexion.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureCegep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_connexion As Panel
    Friend WithEvents btnConnecter As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtMtp As TextBox
    Friend WithEvents lbErreurID As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents lbErreurCours As Label
    Friend WithEvents lbID As Label
    Friend WithEvents lbErreurMotPasse As Label
    Friend WithEvents lbMtp As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureCegep As PictureBox
    Friend WithEvents btnQuitter As Button
End Class
