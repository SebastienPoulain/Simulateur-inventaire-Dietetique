<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usr_exerc_lst_P
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
        Me.lbl_nom = New System.Windows.Forms.Label()
        Me.lbl_description = New System.Windows.Forms.Label()
        Me.pnl_principal = New System.Windows.Forms.Panel()
        Me.Bt_reactiver = New System.Windows.Forms.Button()
        Me.Lbl_Date_remise = New System.Windows.Forms.Label()
        Me.btn_select = New System.Windows.Forms.Button()
        Me.btn_modifier = New System.Windows.Forms.Button()
        Me.pnl_principal.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_nom
        '
        Me.lbl_nom.AutoSize = True
        Me.lbl_nom.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_nom.Location = New System.Drawing.Point(3, 1)
        Me.lbl_nom.Name = "lbl_nom"
        Me.lbl_nom.Size = New System.Drawing.Size(219, 25)
        Me.lbl_nom.TabIndex = 10
        Me.lbl_nom.Text = "Numéro et nom exercice"
        '
        'lbl_description
        '
        Me.lbl_description.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_description.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_description.Location = New System.Drawing.Point(8, 25)
        Me.lbl_description.Name = "lbl_description"
        Me.lbl_description.Size = New System.Drawing.Size(1035, 54)
        Me.lbl_description.TabIndex = 11
        Me.lbl_description.Text = "Description"
        '
        'pnl_principal
        '
        Me.pnl_principal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnl_principal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_principal.Controls.Add(Me.Bt_reactiver)
        Me.pnl_principal.Controls.Add(Me.Lbl_Date_remise)
        Me.pnl_principal.Controls.Add(Me.btn_select)
        Me.pnl_principal.Controls.Add(Me.btn_modifier)
        Me.pnl_principal.Controls.Add(Me.lbl_nom)
        Me.pnl_principal.Controls.Add(Me.lbl_description)
        Me.pnl_principal.Location = New System.Drawing.Point(0, 0)
        Me.pnl_principal.Name = "pnl_principal"
        Me.pnl_principal.Size = New System.Drawing.Size(1441, 664)
        Me.pnl_principal.TabIndex = 17
        '
        'Bt_reactiver
        '
        Me.Bt_reactiver.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Bt_reactiver.FlatAppearance.BorderSize = 0
        Me.Bt_reactiver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Bt_reactiver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_reactiver.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Bt_reactiver.ForeColor = System.Drawing.SystemColors.Control
        Me.Bt_reactiver.Location = New System.Drawing.Point(1104, 41)
        Me.Bt_reactiver.Name = "Bt_reactiver"
        Me.Bt_reactiver.Size = New System.Drawing.Size(190, 32)
        Me.Bt_reactiver.TabIndex = 14
        Me.Bt_reactiver.Text = "Réactiver"
        Me.Bt_reactiver.UseVisualStyleBackColor = False
        '
        'Lbl_Date_remise
        '
        Me.Lbl_Date_remise.AutoSize = True
        Me.Lbl_Date_remise.Location = New System.Drawing.Point(8, 55)
        Me.Lbl_Date_remise.Name = "Lbl_Date_remise"
        Me.Lbl_Date_remise.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Date_remise.TabIndex = 12
        Me.Lbl_Date_remise.Text = "Label1"
        '
        'btn_select
        '
        Me.btn_select.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_select.FlatAppearance.BorderSize = 0
        Me.btn_select.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_select.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btn_select.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_select.Location = New System.Drawing.Point(1104, 3)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Size = New System.Drawing.Size(190, 32)
        Me.btn_select.TabIndex = 1
        Me.btn_select.Text = "Sélectionner"
        Me.btn_select.UseVisualStyleBackColor = False
        '
        'btn_modifier
        '
        Me.btn_modifier.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_modifier.FlatAppearance.BorderSize = 0
        Me.btn_modifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_modifier.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modifier.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_modifier.Location = New System.Drawing.Point(1300, 3)
        Me.btn_modifier.Name = "btn_modifier"
        Me.btn_modifier.Size = New System.Drawing.Size(95, 32)
        Me.btn_modifier.TabIndex = 2
        Me.btn_modifier.Text = "Modifier"
        Me.btn_modifier.UseVisualStyleBackColor = False
        '
        'usr_exerc_lst_P
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.Controls.Add(Me.pnl_principal)
        Me.Name = "usr_exerc_lst_P"
        Me.Size = New System.Drawing.Size(1400, 80)
        Me.pnl_principal.ResumeLayout(False)
        Me.pnl_principal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_nom As Label
    Friend WithEvents lbl_description As Label
    Friend WithEvents pnl_principal As Panel
    Friend WithEvents btn_modifier As Button
    Friend WithEvents btn_select As Button
    Friend WithEvents Lbl_Date_remise As Label
    Friend WithEvents Bt_reactiver As Button
End Class
