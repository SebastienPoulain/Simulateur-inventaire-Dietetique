<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_selectionProf
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnl_navigation = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_titre = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_minimize = New System.Windows.Forms.Button()
        Me.pnl_listeProf = New System.Windows.Forms.Panel()
        Me.btn_annulerProf = New System.Windows.Forms.Button()
        Me.grid_prof = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_selectProf = New System.Windows.Forms.Button()
        Me.pnl_navigation.SuspendLayout()
        Me.pnl_listeProf.SuspendLayout()
        CType(Me.grid_prof, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_navigation
        '
        Me.pnl_navigation.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.pnl_navigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_navigation.Controls.Add(Me.Panel3)
        Me.pnl_navigation.Controls.Add(Me.lbl_titre)
        Me.pnl_navigation.Controls.Add(Me.btn_exit)
        Me.pnl_navigation.Controls.Add(Me.btn_minimize)
        Me.pnl_navigation.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_navigation.Location = New System.Drawing.Point(0, 0)
        Me.pnl_navigation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnl_navigation.Name = "pnl_navigation"
        Me.pnl_navigation.Size = New System.Drawing.Size(752, 36)
        Me.pnl_navigation.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(-1, 37)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(984, 713)
        Me.Panel3.TabIndex = 3
        '
        'lbl_titre
        '
        Me.lbl_titre.AutoSize = True
        Me.lbl_titre.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titre.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_titre.Location = New System.Drawing.Point(16, 6)
        Me.lbl_titre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_titre.Name = "lbl_titre"
        Me.lbl_titre.Size = New System.Drawing.Size(218, 23)
        Me.lbl_titre.TabIndex = 2
        Me.lbl_titre.Text = "Sélectionner un enseignant"
        '
        'btn_exit
        '
        Me.btn_exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_exit.FlatAppearance.BorderSize = 0
        Me.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown
        Me.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.ForeColor = System.Drawing.Color.DimGray
        Me.btn_exit.Image = Global.projet_dietetique.My.Resources.Resources.ic_clear_white_24dp_1x
        Me.btn_exit.Location = New System.Drawing.Point(684, 0)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(67, 34)
        Me.btn_exit.TabIndex = 1
        Me.btn_exit.TabStop = False
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_minimize
        '
        Me.btn_minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_minimize.FlatAppearance.BorderSize = 0
        Me.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimize.ForeColor = System.Drawing.Color.DimGray
        Me.btn_minimize.Image = Global.projet_dietetique.My.Resources.Resources.ic_remove_white_24dp_1x
        Me.btn_minimize.Location = New System.Drawing.Point(617, 0)
        Me.btn_minimize.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(67, 34)
        Me.btn_minimize.TabIndex = 0
        Me.btn_minimize.TabStop = False
        Me.btn_minimize.UseVisualStyleBackColor = True
        '
        'pnl_listeProf
        '
        Me.pnl_listeProf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_listeProf.Controls.Add(Me.btn_annulerProf)
        Me.pnl_listeProf.Controls.Add(Me.grid_prof)
        Me.pnl_listeProf.Controls.Add(Me.btn_selectProf)
        Me.pnl_listeProf.Location = New System.Drawing.Point(0, 36)
        Me.pnl_listeProf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnl_listeProf.Name = "pnl_listeProf"
        Me.pnl_listeProf.Size = New System.Drawing.Size(751, 418)
        Me.pnl_listeProf.TabIndex = 30
        '
        'btn_annulerProf
        '
        Me.btn_annulerProf.BackColor = System.Drawing.Color.DimGray
        Me.btn_annulerProf.FlatAppearance.BorderSize = 0
        Me.btn_annulerProf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_annulerProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_annulerProf.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annulerProf.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_annulerProf.Location = New System.Drawing.Point(608, 363)
        Me.btn_annulerProf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_annulerProf.Name = "btn_annulerProf"
        Me.btn_annulerProf.Size = New System.Drawing.Size(127, 39)
        Me.btn_annulerProf.TabIndex = 29
        Me.btn_annulerProf.Text = "Annuler"
        Me.btn_annulerProf.UseVisualStyleBackColor = False
        '
        'grid_prof
        '
        Me.grid_prof.AllowUserToAddRows = False
        Me.grid_prof.AllowUserToDeleteRows = False
        Me.grid_prof.AllowUserToResizeColumns = False
        Me.grid_prof.AllowUserToResizeRows = False
        Me.grid_prof.BackgroundColor = System.Drawing.Color.White
        Me.grid_prof.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_prof.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_prof.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_prof.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.Column4})
        Me.grid_prof.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grid_prof.Location = New System.Drawing.Point(5, 5)
        Me.grid_prof.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_prof.MultiSelect = False
        Me.grid_prof.Name = "grid_prof"
        Me.grid_prof.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_prof.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grid_prof.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.grid_prof.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.grid_prof.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_prof.Size = New System.Drawing.Size(740, 326)
        Me.grid_prof.TabIndex = 30
        Me.grid_prof.TabStop = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Identifiant de l'enseignant"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 220
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Nom de l'enseignant"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'btn_selectProf
        '
        Me.btn_selectProf.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_selectProf.FlatAppearance.BorderSize = 0
        Me.btn_selectProf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_selectProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_selectProf.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_selectProf.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_selectProf.Location = New System.Drawing.Point(473, 363)
        Me.btn_selectProf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_selectProf.Name = "btn_selectProf"
        Me.btn_selectProf.Size = New System.Drawing.Size(127, 39)
        Me.btn_selectProf.TabIndex = 15
        Me.btn_selectProf.Text = "Sélectionner"
        Me.btn_selectProf.UseVisualStyleBackColor = False
        '
        'frm_selectionProf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 454)
        Me.Controls.Add(Me.pnl_listeProf)
        Me.Controls.Add(Me.pnl_navigation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_selectionProf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frm_selectionProf"
        Me.pnl_navigation.ResumeLayout(False)
        Me.pnl_navigation.PerformLayout()
        Me.pnl_listeProf.ResumeLayout(False)
        CType(Me.grid_prof, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_navigation As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbl_titre As Label
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_minimize As Button
    Friend WithEvents pnl_listeProf As Panel
    Friend WithEvents btn_annulerProf As Button
    Friend WithEvents grid_prof As DataGridView
    Friend WithEvents btn_selectProf As Button
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
