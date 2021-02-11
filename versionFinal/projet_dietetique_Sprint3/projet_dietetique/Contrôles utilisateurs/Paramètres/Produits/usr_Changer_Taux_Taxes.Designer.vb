<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usr_Changer_Taux_Taxes
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
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.btn_modifier = New System.Windows.Forms.Button()
        Me.NumericUpDownTVQ = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownTPS = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.NumericUpDownTVQ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownTPS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_annuler
        '
        Me.btn_annuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_annuler.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_annuler.FlatAppearance.BorderSize = 0
        Me.btn_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_annuler.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annuler.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_annuler.Location = New System.Drawing.Point(134, 197)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(154, 32)
        Me.btn_annuler.TabIndex = 202
        Me.btn_annuler.Text = "Annuler"
        Me.btn_annuler.UseVisualStyleBackColor = False
        '
        'btn_modifier
        '
        Me.btn_modifier.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_modifier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modifier.FlatAppearance.BorderSize = 0
        Me.btn_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_modifier.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modifier.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_modifier.Location = New System.Drawing.Point(306, 197)
        Me.btn_modifier.Name = "btn_modifier"
        Me.btn_modifier.Size = New System.Drawing.Size(154, 32)
        Me.btn_modifier.TabIndex = 201
        Me.btn_modifier.Text = "Modifier"
        Me.btn_modifier.UseVisualStyleBackColor = False
        '
        'NumericUpDownTVQ
        '
        Me.NumericUpDownTVQ.DecimalPlaces = 3
        Me.NumericUpDownTVQ.Location = New System.Drawing.Point(263, 107)
        Me.NumericUpDownTVQ.Name = "NumericUpDownTVQ"
        Me.NumericUpDownTVQ.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDownTVQ.TabIndex = 200
        '
        'NumericUpDownTPS
        '
        Me.NumericUpDownTPS.DecimalPlaces = 3
        Me.NumericUpDownTPS.Location = New System.Drawing.Point(263, 57)
        Me.NumericUpDownTPS.Name = "NumericUpDownTPS"
        Me.NumericUpDownTPS.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDownTPS.TabIndex = 199
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 198
        Me.Label2.Text = "TVQ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(200, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 197
        Me.Label1.Text = "TPS"
        '
        'usr_Changer_Taux_Taxes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_annuler)
        Me.Controls.Add(Me.btn_modifier)
        Me.Controls.Add(Me.NumericUpDownTVQ)
        Me.Controls.Add(Me.NumericUpDownTPS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "usr_Changer_Taux_Taxes"
        Me.Size = New System.Drawing.Size(594, 287)
        CType(Me.NumericUpDownTVQ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownTPS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_annuler As Button
    Friend WithEvents btn_modifier As Button
    Friend WithEvents NumericUpDownTVQ As NumericUpDown
    Friend WithEvents NumericUpDownTPS As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
