<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usr_gestion_MenuFournisseurs
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
        Me.pnl_menuCours = New System.Windows.Forms.Panel()
        Me.pnl_listeFourn = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnl_menuCours.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_menuCours
        '
        Me.pnl_menuCours.Controls.Add(Me.pnl_listeFourn)
        Me.pnl_menuCours.Controls.Add(Me.Panel5)
        Me.pnl_menuCours.Controls.Add(Me.Panel4)
        Me.pnl_menuCours.Location = New System.Drawing.Point(0, 0)
        Me.pnl_menuCours.Name = "pnl_menuCours"
        Me.pnl_menuCours.Size = New System.Drawing.Size(1170, 1434)
        Me.pnl_menuCours.TabIndex = 14
        '
        'pnl_listeFourn
        '
        Me.pnl_listeFourn.Location = New System.Drawing.Point(0, 63)
        Me.pnl_listeFourn.Name = "pnl_listeFourn"
        Me.pnl_listeFourn.Size = New System.Drawing.Size(1170, 1370)
        Me.pnl_listeFourn.TabIndex = 1
        Me.pnl_listeFourn.TabStop = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Location = New System.Drawing.Point(0, 35)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1170, 28)
        Me.Panel5.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(11, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(232, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Rechercher des fournisseurs"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1170, 35)
        Me.Panel4.TabIndex = 45
        Me.Panel4.TabStop = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(11, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Fournisseurs"
        '
        'usr_gestion_MenuFournisseurs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.pnl_menuCours)
        Me.Name = "usr_gestion_MenuFournisseurs"
        Me.Size = New System.Drawing.Size(1153, 818)
        Me.pnl_menuCours.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_menuCours As Panel
    Friend WithEvents pnl_listeFourn As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
End Class
