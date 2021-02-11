<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usr_nouveau_mdp
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_retour = New System.Windows.Forms.Button()
        Me.btn_excel = New System.Windows.Forms.Button()
        Me.grid_utls = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grid_utls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_retour
        '
        Me.btn_retour.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_retour.FlatAppearance.BorderSize = 0
        Me.btn_retour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_retour.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_retour.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_retour.Location = New System.Drawing.Point(1058, 508)
        Me.btn_retour.Name = "btn_retour"
        Me.btn_retour.Size = New System.Drawing.Size(109, 32)
        Me.btn_retour.TabIndex = 48
        Me.btn_retour.Text = "Retour"
        Me.btn_retour.UseVisualStyleBackColor = False
        '
        'btn_excel
        '
        Me.btn_excel.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btn_excel.FlatAppearance.BorderSize = 0
        Me.btn_excel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_excel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_excel.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_excel.Location = New System.Drawing.Point(3, 456)
        Me.btn_excel.Name = "btn_excel"
        Me.btn_excel.Size = New System.Drawing.Size(184, 32)
        Me.btn_excel.TabIndex = 49
        Me.btn_excel.Text = "Ouvrir avec Excel"
        Me.btn_excel.UseVisualStyleBackColor = False
        '
        'grid_utls
        '
        Me.grid_utls.AllowUserToAddRows = False
        Me.grid_utls.AllowUserToDeleteRows = False
        Me.grid_utls.AllowUserToResizeColumns = False
        Me.grid_utls.AllowUserToResizeRows = False
        Me.grid_utls.BackgroundColor = System.Drawing.Color.White
        Me.grid_utls.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_utls.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_utls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_utls.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column4, Me.Column2, Me.Column3, Me.Column5})
        Me.grid_utls.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grid_utls.Location = New System.Drawing.Point(3, 3)
        Me.grid_utls.Name = "grid_utls"
        Me.grid_utls.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_utls.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grid_utls.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.grid_utls.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.grid_utls.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_utls.Size = New System.Drawing.Size(1164, 447)
        Me.grid_utls.TabIndex = 50
        Me.grid_utls.TabStop = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "Identifiant"
        Me.Column1.MaxInputLength = 35
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 180
        '
        'Column4
        '
        Me.Column4.HeaderText = "Prénom"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 300
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nom"
        Me.Column2.MaxInputLength = 50
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 300
        '
        'Column3
        '
        Me.Column3.HeaderText = "Titre"
        Me.Column3.MaxInputLength = 50
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 200
        '
        'Column5
        '
        Me.Column5.HeaderText = "Mot de passe"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 165
        '
        'usr_nouveau_mdp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grid_utls)
        Me.Controls.Add(Me.btn_excel)
        Me.Controls.Add(Me.btn_retour)
        Me.Name = "usr_nouveau_mdp"
        Me.Size = New System.Drawing.Size(1170, 550)
        CType(Me.grid_utls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_retour As Button
    Friend WithEvents btn_excel As Button
    Friend WithEvents grid_utls As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
