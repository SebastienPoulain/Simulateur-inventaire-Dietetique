<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usr_exercices_E
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
        Me.pnl_principal_ex = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnl_principal_ex.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_principal_ex
        '
        Me.pnl_principal_ex.AutoSize = True
        Me.pnl_principal_ex.BackColor = System.Drawing.SystemColors.Control
        Me.pnl_principal_ex.Controls.Add(Me.Panel4)
        Me.pnl_principal_ex.Location = New System.Drawing.Point(0, 0)
        Me.pnl_principal_ex.Name = "pnl_principal_ex"
        Me.pnl_principal_ex.Size = New System.Drawing.Size(1420, 835)
        Me.pnl_principal_ex.TabIndex = 47
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(0, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1417, 35)
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
        'usr_exercices_E
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.pnl_principal_ex)
        Me.Name = "usr_exercices_E"
        Me.Size = New System.Drawing.Size(1438, 835)
        Me.pnl_principal_ex.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnl_principal_ex As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
End Class
