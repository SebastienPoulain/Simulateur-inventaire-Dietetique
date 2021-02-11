<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usr_generer_utls
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lbE_utls = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_utls = New System.Windows.Forms.TextBox()
        Me.lbE_titre = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbo_titre = New System.Windows.Forms.ComboBox()
        Me.nud_nbUtls = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_ajouter = New System.Windows.Forms.Button()
        Me.lbl_ajoutSucces = New System.Windows.Forms.Label()
        Me.timer_succes = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.nud_nbUtls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbE_utls
        '
        Me.lbE_utls.AutoSize = True
        Me.lbE_utls.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lbE_utls.ForeColor = System.Drawing.Color.Firebrick
        Me.lbE_utls.Location = New System.Drawing.Point(6, 52)
        Me.lbE_utls.Name = "lbE_utls"
        Me.lbE_utls.Size = New System.Drawing.Size(159, 13)
        Me.lbE_utls.TabIndex = 31
        Me.lbE_utls.Text = "Saisissez un nom d'utilisateur"
        Me.lbE_utls.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 15)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Nom d'utilisateur commun"
        '
        'txt_utls
        '
        Me.txt_utls.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_utls.Location = New System.Drawing.Point(6, 29)
        Me.txt_utls.MaxLength = 16
        Me.txt_utls.Name = "txt_utls"
        Me.txt_utls.Size = New System.Drawing.Size(141, 22)
        Me.txt_utls.TabIndex = 16
        Me.txt_utls.Tag = "1"
        '
        'lbE_titre
        '
        Me.lbE_titre.AutoSize = True
        Me.lbE_titre.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lbE_titre.ForeColor = System.Drawing.Color.Firebrick
        Me.lbE_titre.Location = New System.Drawing.Point(179, 52)
        Me.lbE_titre.Name = "lbE_titre"
        Me.lbE_titre.Size = New System.Drawing.Size(112, 13)
        Me.lbE_titre.TabIndex = 40
        Me.lbE_titre.Text = "Sélectionner un titre"
        Me.lbE_titre.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(175, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 15)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Titre"
        '
        'cbo_titre
        '
        Me.cbo_titre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_titre.FormattingEnabled = True
        Me.cbo_titre.Location = New System.Drawing.Point(178, 29)
        Me.cbo_titre.Name = "cbo_titre"
        Me.cbo_titre.Size = New System.Drawing.Size(153, 21)
        Me.cbo_titre.TabIndex = 38
        Me.cbo_titre.Tag = "2"
        '
        'nud_nbUtls
        '
        Me.nud_nbUtls.Location = New System.Drawing.Point(369, 31)
        Me.nud_nbUtls.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nud_nbUtls.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud_nbUtls.Name = "nud_nbUtls"
        Me.nud_nbUtls.Size = New System.Drawing.Size(86, 20)
        Me.nud_nbUtls.TabIndex = 41
        Me.nud_nbUtls.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(366, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 15)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Nombre d'utilisateur"
        '
        'btn_ajouter
        '
        Me.btn_ajouter.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_ajouter.Enabled = False
        Me.btn_ajouter.FlatAppearance.BorderSize = 0
        Me.btn_ajouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ajouter.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajouter.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_ajouter.Location = New System.Drawing.Point(1064, 47)
        Me.btn_ajouter.Name = "btn_ajouter"
        Me.btn_ajouter.Size = New System.Drawing.Size(95, 32)
        Me.btn_ajouter.TabIndex = 43
        Me.btn_ajouter.Text = "Générer"
        Me.btn_ajouter.UseVisualStyleBackColor = False
        '
        'lbl_ajoutSucces
        '
        Me.lbl_ajoutSucces.BackColor = System.Drawing.Color.Lime
        Me.lbl_ajoutSucces.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_ajoutSucces.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_ajoutSucces.Location = New System.Drawing.Point(3, 99)
        Me.lbl_ajoutSucces.Name = "lbl_ajoutSucces"
        Me.lbl_ajoutSucces.Size = New System.Drawing.Size(1164, 24)
        Me.lbl_ajoutSucces.TabIndex = 44
        Me.lbl_ajoutSucces.Text = "La génération a été réalisée avec succès!"
        Me.lbl_ajoutSucces.Visible = False
        '
        'timer_succes
        '
        Me.timer_succes.Interval = 1
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_ajouter)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cbo_titre)
        Me.Panel1.Controls.Add(Me.txt_utls)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.nud_nbUtls)
        Me.Panel1.Controls.Add(Me.lbE_utls)
        Me.Panel1.Controls.Add(Me.lbE_titre)
        Me.Panel1.Location = New System.Drawing.Point(3, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1164, 84)
        Me.Panel1.TabIndex = 45
        '
        'usr_generer_utls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl_ajoutSucces)
        Me.Name = "usr_generer_utls"
        Me.Size = New System.Drawing.Size(1170, 130)
        CType(Me.nud_nbUtls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbE_utls As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_utls As TextBox
    Friend WithEvents lbE_titre As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbo_titre As ComboBox
    Friend WithEvents nud_nbUtls As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents lbl_ajoutSucces As Label
    Friend WithEvents timer_succes As Timer
    Friend WithEvents Panel1 As Panel
End Class
