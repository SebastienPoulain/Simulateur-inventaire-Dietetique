<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usr_recette_etu
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
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_inventaire = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.PaneldecoRecette = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBoxDescriptionRecette = New System.Windows.Forms.TextBox()
        Me.NoteRecette = New System.Windows.Forms.Label()
        Me.btn_ImporterRecette = New System.Windows.Forms.Button()
        Me.Panel5.SuspendLayout()
        Me.PaneldecoRecette.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel5.Controls.Add(Me.lbl_inventaire)
        Me.Panel5.Location = New System.Drawing.Point(15, 47)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1378, 35)
        Me.Panel5.TabIndex = 106
        '
        'lbl_inventaire
        '
        Me.lbl_inventaire.AutoSize = True
        Me.lbl_inventaire.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inventaire.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_inventaire.Location = New System.Drawing.Point(3, 2)
        Me.lbl_inventaire.Name = "lbl_inventaire"
        Me.lbl_inventaire.Size = New System.Drawing.Size(73, 25)
        Me.lbl_inventaire.TabIndex = 9
        Me.lbl_inventaire.Text = "Recette"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(217, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 19)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Liste des recette disponible"
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Location = New System.Drawing.Point(221, 55)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(308, 604)
        Me.ListBox1.TabIndex = 92
        '
        'PaneldecoRecette
        '
        Me.PaneldecoRecette.BackColor = System.Drawing.Color.LightSlateGray
        Me.PaneldecoRecette.Controls.Add(Me.Label1)
        Me.PaneldecoRecette.Controls.Add(Me.ListBox1)
        Me.PaneldecoRecette.Controls.Add(Me.btn_ImporterRecette)
        Me.PaneldecoRecette.Location = New System.Drawing.Point(15, 77)
        Me.PaneldecoRecette.Name = "PaneldecoRecette"
        Me.PaneldecoRecette.Size = New System.Drawing.Size(650, 684)
        Me.PaneldecoRecette.TabIndex = 108
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(690, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(664, 374)
        Me.GroupBox1.TabIndex = 109
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Image"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox1.Location = New System.Drawing.Point(36, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(579, 336)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 80
        Me.PictureBox1.TabStop = False
        '
        'TextBoxDescriptionRecette
        '
        Me.TextBoxDescriptionRecette.Location = New System.Drawing.Point(690, 525)
        Me.TextBoxDescriptionRecette.Multiline = True
        Me.TextBoxDescriptionRecette.Name = "TextBoxDescriptionRecette"
        Me.TextBoxDescriptionRecette.ReadOnly = True
        Me.TextBoxDescriptionRecette.Size = New System.Drawing.Size(664, 236)
        Me.TextBoxDescriptionRecette.TabIndex = 111
        '
        'NoteRecette
        '
        Me.NoteRecette.AutoSize = True
        Me.NoteRecette.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NoteRecette.Location = New System.Drawing.Point(695, 503)
        Me.NoteRecette.Name = "NoteRecette"
        Me.NoteRecette.Size = New System.Drawing.Size(86, 19)
        Me.NoteRecette.TabIndex = 110
        Me.NoteRecette.Text = "Description"
        '
        'btn_ImporterRecette
        '
        Me.btn_ImporterRecette.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_ImporterRecette.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_ImporterRecette.FlatAppearance.BorderSize = 0
        Me.btn_ImporterRecette.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_ImporterRecette.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ImporterRecette.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ImporterRecette.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_ImporterRecette.Location = New System.Drawing.Point(44, 55)
        Me.btn_ImporterRecette.Name = "btn_ImporterRecette"
        Me.btn_ImporterRecette.Size = New System.Drawing.Size(157, 32)
        Me.btn_ImporterRecette.TabIndex = 90
        Me.btn_ImporterRecette.Text = "Enregistrer recette"
        Me.btn_ImporterRecette.UseVisualStyleBackColor = False
        '
        'usr_recette_etu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.PaneldecoRecette)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBoxDescriptionRecette)
        Me.Controls.Add(Me.NoteRecette)
        Me.Name = "usr_recette_etu"
        Me.Size = New System.Drawing.Size(1408, 808)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.PaneldecoRecette.ResumeLayout(False)
        Me.PaneldecoRecette.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_inventaire As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents PaneldecoRecette As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBoxDescriptionRecette As TextBox
    Friend WithEvents NoteRecette As Label
    Friend WithEvents btn_ImporterRecette As Button
End Class
