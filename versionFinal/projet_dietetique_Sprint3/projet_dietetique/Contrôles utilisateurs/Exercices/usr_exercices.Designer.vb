<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usr_exercices
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnl_principal_ex = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbo_statut = New System.Windows.Forms.ComboBox()
        Me.btn_creer = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_restaure = New System.Windows.Forms.Button()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1421, 35)
        Me.Panel4.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(11, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Mes exercices"
        '
        'pnl_principal_ex
        '
        Me.pnl_principal_ex.AutoSize = True
        Me.pnl_principal_ex.BackColor = System.Drawing.SystemColors.Control
        Me.pnl_principal_ex.Location = New System.Drawing.Point(-3, 110)
        Me.pnl_principal_ex.Name = "pnl_principal_ex"
        Me.pnl_principal_ex.Size = New System.Drawing.Size(1424, 725)
        Me.pnl_principal_ex.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(1118, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 17)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Statut"
        '
        'cbo_statut
        '
        Me.cbo_statut.CausesValidation = False
        Me.cbo_statut.DisplayMember = "0"
        Me.cbo_statut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_statut.FormattingEnabled = True
        Me.cbo_statut.Items.AddRange(New Object() {"Tous", "Actif", "Inactif"})
        Me.cbo_statut.Location = New System.Drawing.Point(1165, 62)
        Me.cbo_statut.Name = "cbo_statut"
        Me.cbo_statut.Size = New System.Drawing.Size(134, 21)
        Me.cbo_statut.TabIndex = 2
        Me.cbo_statut.Tag = "2"
        '
        'btn_creer
        '
        Me.btn_creer.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_creer.FlatAppearance.BorderSize = 0
        Me.btn_creer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_creer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_creer.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btn_creer.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_creer.Location = New System.Drawing.Point(17, 54)
        Me.btn_creer.Name = "btn_creer"
        Me.btn_creer.Size = New System.Drawing.Size(190, 32)
        Me.btn_creer.TabIndex = 1
        Me.btn_creer.Text = "Créer un exercice"
        Me.btn_creer.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(17, 103)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1402, 1)
        Me.Panel1.TabIndex = 46
        '
        'btn_restaure
        '
        Me.btn_restaure.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_restaure.FlatAppearance.BorderSize = 0
        Me.btn_restaure.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_restaure.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_restaure.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btn_restaure.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_restaure.Location = New System.Drawing.Point(865, 55)
        Me.btn_restaure.Name = "btn_restaure"
        Me.btn_restaure.Size = New System.Drawing.Size(190, 32)
        Me.btn_restaure.TabIndex = 61
        Me.btn_restaure.Text = "Rafraîchir la page"
        Me.btn_restaure.UseVisualStyleBackColor = False
        '
        'usr_exercices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.btn_restaure)
        Me.Controls.Add(Me.pnl_principal_ex)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbo_statut)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.btn_creer)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "usr_exercices"
        Me.Size = New System.Drawing.Size(1438, 835)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents pnl_principal_ex As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_creer As Button
    Friend WithEvents cbo_statut As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_restaure As Button
End Class
