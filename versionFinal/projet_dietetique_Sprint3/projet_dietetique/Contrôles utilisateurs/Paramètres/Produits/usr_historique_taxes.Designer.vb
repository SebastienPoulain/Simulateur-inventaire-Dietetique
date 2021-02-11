<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usr_historique_taxes
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_sauvegarder_taxes = New System.Windows.Forms.Button()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.dgv_historique_taxes = New System.Windows.Forms.DataGridView()
        Me.id_taxes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_taxe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type_taxe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pourcentage_taxe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_titre = New System.Windows.Forms.Label()
        CType(Me.dgv_historique_taxes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_sauvegarder_taxes
        '
        Me.btn_sauvegarder_taxes.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_sauvegarder_taxes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sauvegarder_taxes.FlatAppearance.BorderSize = 0
        Me.btn_sauvegarder_taxes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sauvegarder_taxes.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sauvegarder_taxes.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_sauvegarder_taxes.Location = New System.Drawing.Point(518, 407)
        Me.btn_sauvegarder_taxes.Name = "btn_sauvegarder_taxes"
        Me.btn_sauvegarder_taxes.Size = New System.Drawing.Size(154, 32)
        Me.btn_sauvegarder_taxes.TabIndex = 212
        Me.btn_sauvegarder_taxes.Text = "Sauvegarder Excel"
        Me.btn_sauvegarder_taxes.UseVisualStyleBackColor = False
        '
        'btn_annuler
        '
        Me.btn_annuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_annuler.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_annuler.FlatAppearance.BorderSize = 0
        Me.btn_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_annuler.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annuler.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_annuler.Location = New System.Drawing.Point(317, 407)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(154, 32)
        Me.btn_annuler.TabIndex = 211
        Me.btn_annuler.Text = "Annuler"
        Me.btn_annuler.UseVisualStyleBackColor = False
        '
        'dgv_historique_taxes
        '
        Me.dgv_historique_taxes.AllowUserToAddRows = False
        Me.dgv_historique_taxes.AllowUserToDeleteRows = False
        Me.dgv_historique_taxes.AllowUserToResizeColumns = False
        Me.dgv_historique_taxes.AllowUserToResizeRows = False
        Me.dgv_historique_taxes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_historique_taxes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_historique_taxes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_historique_taxes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_historique_taxes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_taxes, Me.date_taxe, Me.type_taxe, Me.pourcentage_taxe})
        Me.dgv_historique_taxes.Location = New System.Drawing.Point(286, 68)
        Me.dgv_historique_taxes.Name = "dgv_historique_taxes"
        Me.dgv_historique_taxes.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_historique_taxes.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_historique_taxes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgv_historique_taxes.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_historique_taxes.Size = New System.Drawing.Size(443, 291)
        Me.dgv_historique_taxes.TabIndex = 209
        '
        'id_taxes
        '
        Me.id_taxes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.id_taxes.HeaderText = "ID"
        Me.id_taxes.Name = "id_taxes"
        Me.id_taxes.ReadOnly = True
        '
        'date_taxe
        '
        Me.date_taxe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.date_taxe.HeaderText = "Date"
        Me.date_taxe.Name = "date_taxe"
        Me.date_taxe.ReadOnly = True
        '
        'type_taxe
        '
        Me.type_taxe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.type_taxe.HeaderText = "Type"
        Me.type_taxe.Name = "type_taxe"
        Me.type_taxe.ReadOnly = True
        '
        'pourcentage_taxe
        '
        Me.pourcentage_taxe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "N3"
        DataGridViewCellStyle2.NullValue = "99,999 %"
        Me.pourcentage_taxe.DefaultCellStyle = DataGridViewCellStyle2
        Me.pourcentage_taxe.HeaderText = "Pourcentage"
        Me.pourcentage_taxe.Name = "pourcentage_taxe"
        Me.pourcentage_taxe.ReadOnly = True
        '
        'lbl_titre
        '
        Me.lbl_titre.AutoSize = True
        Me.lbl_titre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titre.Location = New System.Drawing.Point(433, 36)
        Me.lbl_titre.Name = "lbl_titre"
        Me.lbl_titre.Size = New System.Drawing.Size(168, 13)
        Me.lbl_titre.TabIndex = 210
        Me.lbl_titre.Text = "Historique des taux de taxes"
        '
        'usr_historique_taxes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_sauvegarder_taxes)
        Me.Controls.Add(Me.btn_annuler)
        Me.Controls.Add(Me.dgv_historique_taxes)
        Me.Controls.Add(Me.lbl_titre)
        Me.Name = "usr_historique_taxes"
        Me.Size = New System.Drawing.Size(1015, 474)
        CType(Me.dgv_historique_taxes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_sauvegarder_taxes As Button
    Friend WithEvents btn_annuler As Button
    Friend WithEvents dgv_historique_taxes As DataGridView
    Friend WithEvents id_taxes As DataGridViewTextBoxColumn
    Friend WithEvents date_taxe As DataGridViewTextBoxColumn
    Friend WithEvents type_taxe As DataGridViewTextBoxColumn
    Friend WithEvents pourcentage_taxe As DataGridViewTextBoxColumn
    Friend WithEvents lbl_titre As Label
End Class
