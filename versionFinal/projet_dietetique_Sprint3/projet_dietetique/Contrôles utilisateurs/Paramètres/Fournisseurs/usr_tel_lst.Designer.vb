<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usr_tel_lst
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
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.txt_poste = New System.Windows.Forms.TextBox()
        Me.cbo_type = New System.Windows.Forms.ComboBox()
        Me.btn_suppr = New System.Windows.Forms.Button()
        Me.btn_ajouter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(123, 2)
        Me.txt_numero.MaxLength = 14
        Me.txt_numero.Multiline = True
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(147, 23)
        Me.txt_numero.TabIndex = 207
        '
        'txt_poste
        '
        Me.txt_poste.Location = New System.Drawing.Point(276, 2)
        Me.txt_poste.MaxLength = 10
        Me.txt_poste.Multiline = True
        Me.txt_poste.Name = "txt_poste"
        Me.txt_poste.Size = New System.Drawing.Size(77, 23)
        Me.txt_poste.TabIndex = 208
        '
        'cbo_type
        '
        Me.cbo_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_type.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_type.FormattingEnabled = True
        Me.cbo_type.Items.AddRange(New Object() {"Bureau", "Cell.", "Domicile", "Autre (précisez)"})
        Me.cbo_type.Location = New System.Drawing.Point(4, 2)
        Me.cbo_type.Name = "cbo_type"
        Me.cbo_type.Size = New System.Drawing.Size(113, 23)
        Me.cbo_type.TabIndex = 209
        '
        'btn_suppr
        '
        Me.btn_suppr.BackColor = System.Drawing.Color.Transparent
        Me.btn_suppr.FlatAppearance.BorderSize = 0
        Me.btn_suppr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_suppr.ForeColor = System.Drawing.Color.Transparent
        Me.btn_suppr.Image = Global.projet_dietetique.My.Resources.Resources.rubbish_bin
        Me.btn_suppr.Location = New System.Drawing.Point(390, 1)
        Me.btn_suppr.Name = "btn_suppr"
        Me.btn_suppr.Size = New System.Drawing.Size(25, 25)
        Me.btn_suppr.TabIndex = 211
        Me.btn_suppr.UseVisualStyleBackColor = False
        Me.btn_suppr.Visible = False
        '
        'btn_ajouter
        '
        Me.btn_ajouter.BackColor = System.Drawing.Color.Transparent
        Me.btn_ajouter.FlatAppearance.BorderSize = 0
        Me.btn_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ajouter.ForeColor = System.Drawing.Color.Transparent
        Me.btn_ajouter.Image = Global.projet_dietetique.My.Resources.Resources.add1
        Me.btn_ajouter.Location = New System.Drawing.Point(355, 1)
        Me.btn_ajouter.Name = "btn_ajouter"
        Me.btn_ajouter.Size = New System.Drawing.Size(25, 25)
        Me.btn_ajouter.TabIndex = 210
        Me.btn_ajouter.UseVisualStyleBackColor = False
        '
        'usr_tel_lst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_suppr)
        Me.Controls.Add(Me.btn_ajouter)
        Me.Controls.Add(Me.cbo_type)
        Me.Controls.Add(Me.txt_poste)
        Me.Controls.Add(Me.txt_numero)
        Me.Name = "usr_tel_lst"
        Me.Size = New System.Drawing.Size(420, 28)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_numero As TextBox
    Friend WithEvents txt_poste As TextBox
    Friend WithEvents cbo_type As ComboBox
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents btn_suppr As Button
End Class
