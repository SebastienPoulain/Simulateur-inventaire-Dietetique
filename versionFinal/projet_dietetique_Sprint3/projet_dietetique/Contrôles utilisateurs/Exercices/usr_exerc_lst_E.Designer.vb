<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usr_exerc_lst_E
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
        Me.lbl_date_remise = New System.Windows.Forms.Label()
        Me.btn_select = New System.Windows.Forms.Button()
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
        Me.pnl_principal.Controls.Add(Me.lbl_date_remise)
        Me.pnl_principal.Controls.Add(Me.btn_select)
        Me.pnl_principal.Controls.Add(Me.lbl_nom)
        Me.pnl_principal.Controls.Add(Me.lbl_description)
        Me.pnl_principal.Location = New System.Drawing.Point(0, 0)
        Me.pnl_principal.Name = "pnl_principal"
        Me.pnl_principal.Size = New System.Drawing.Size(1400, 80)
        Me.pnl_principal.TabIndex = 18
        '
        'lbl_date_remise
        '
        Me.lbl_date_remise.AutoSize = True
        Me.lbl_date_remise.Location = New System.Drawing.Point(8, 62)
        Me.lbl_date_remise.Name = "lbl_date_remise"
        Me.lbl_date_remise.Size = New System.Drawing.Size(0, 13)
        Me.lbl_date_remise.TabIndex = 12
        '
        'btn_select
        '
        Me.btn_select.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_select.FlatAppearance.BorderSize = 0
        Me.btn_select.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_select.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btn_select.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_select.Location = New System.Drawing.Point(1205, 43)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Size = New System.Drawing.Size(190, 32)
        Me.btn_select.TabIndex = 1
        Me.btn_select.Text = "Sélectionner"
        Me.btn_select.UseVisualStyleBackColor = False
        '
        'usr_exerc_lst_E
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnl_principal)
        Me.Name = "usr_exerc_lst_E"
        Me.Size = New System.Drawing.Size(1400, 80)
        Me.pnl_principal.ResumeLayout(False)
        Me.pnl_principal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_nom As Label
    Friend WithEvents lbl_description As Label
    Friend WithEvents pnl_principal As Panel
    Friend WithEvents btn_select As Button
    Friend WithEvents lbl_date_remise As Label
End Class
