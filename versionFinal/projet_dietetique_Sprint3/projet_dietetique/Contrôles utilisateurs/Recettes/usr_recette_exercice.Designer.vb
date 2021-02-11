<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usr_recette_exercice
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
        Me.checkListR_E = New System.Windows.Forms.CheckedListBox()
        Me.PanelRecette = New System.Windows.Forms.Panel()
        Me.PanelExercice = New System.Windows.Forms.Panel()
        Me.btn_delier = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_confirm_lier = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'checkListR_E
        '
        Me.checkListR_E.FormattingEnabled = True
        Me.checkListR_E.Location = New System.Drawing.Point(709, 56)
        Me.checkListR_E.Name = "checkListR_E"
        Me.checkListR_E.Size = New System.Drawing.Size(238, 319)
        Me.checkListR_E.TabIndex = 115
        '
        'PanelRecette
        '
        Me.PanelRecette.AutoScroll = True
        Me.PanelRecette.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PanelRecette.Location = New System.Drawing.Point(351, 56)
        Me.PanelRecette.Name = "PanelRecette"
        Me.PanelRecette.Size = New System.Drawing.Size(235, 321)
        Me.PanelRecette.TabIndex = 114
        '
        'PanelExercice
        '
        Me.PanelExercice.AutoScroll = True
        Me.PanelExercice.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PanelExercice.Location = New System.Drawing.Point(55, 56)
        Me.PanelExercice.Name = "PanelExercice"
        Me.PanelExercice.Size = New System.Drawing.Size(235, 321)
        Me.PanelExercice.TabIndex = 113
        '
        'btn_delier
        '
        Me.btn_delier.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_delier.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_delier.FlatAppearance.BorderSize = 0
        Me.btn_delier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_delier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delier.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delier.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_delier.Location = New System.Drawing.Point(709, 393)
        Me.btn_delier.Name = "btn_delier"
        Me.btn_delier.Size = New System.Drawing.Size(179, 32)
        Me.btn_delier.TabIndex = 112
        Me.btn_delier.Text = "Délier l'exercice de la recette"
        Me.btn_delier.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(706, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "recette et exrcices"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(348, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Liste des recettes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "Liste des exercices" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btn_confirm_lier
        '
        Me.btn_confirm_lier.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_confirm_lier.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_confirm_lier.FlatAppearance.BorderSize = 0
        Me.btn_confirm_lier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_confirm_lier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_confirm_lier.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirm_lier.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_confirm_lier.Location = New System.Drawing.Point(265, 393)
        Me.btn_confirm_lier.Name = "btn_confirm_lier"
        Me.btn_confirm_lier.Size = New System.Drawing.Size(112, 32)
        Me.btn_confirm_lier.TabIndex = 108
        Me.btn_confirm_lier.Text = "confirmer"
        Me.btn_confirm_lier.UseVisualStyleBackColor = False
        '
        'usr_recette_exercice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.checkListR_E)
        Me.Controls.Add(Me.PanelRecette)
        Me.Controls.Add(Me.PanelExercice)
        Me.Controls.Add(Me.btn_delier)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_confirm_lier)
        Me.Name = "usr_recette_exercice"
        Me.Size = New System.Drawing.Size(999, 465)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents checkListR_E As CheckedListBox
    Friend WithEvents PanelRecette As Panel
    Friend WithEvents PanelExercice As Panel
    Friend WithEvents btn_delier As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_confirm_lier As Button
End Class
