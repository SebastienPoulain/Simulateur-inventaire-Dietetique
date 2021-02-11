<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_details_produit
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.pnl_navigation = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_titre = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_minimize = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_description = New System.Windows.Forms.Label()
        Me.lbl_remarques = New System.Windows.Forms.Label()
        Me.lbl_allergenes = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lbl_nom_produit = New System.Windows.Forms.Label()
        Me.lbl_marque = New System.Windows.Forms.Label()
        Me.lbl_categorie = New System.Windows.Forms.Label()
        Me.lbl_format = New System.Windows.Forms.Label()
        Me.lbl_unite_mesure = New System.Windows.Forms.Label()
        Me.lbl_quantite = New System.Windows.Forms.Label()
        Me.lbl_no_produit = New System.Windows.Forms.Label()
        Me.lbl_code_barre = New System.Windows.Forms.Label()
        Me.lbl_code_plu = New System.Windows.Forms.Label()
        Me.btn_retour = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.chk_perissable = New System.Windows.Forms.CheckBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.pnl_defaut = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.chk_bio = New System.Windows.Forms.CheckBox()
        Me.pnl_inventaire = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbl_quantSelonFormat = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lbl_emplacement = New System.Windows.Forms.Label()
        Me.lbl_quant = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.pnl_navigation.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.pnl_defaut.SuspendLayout()
        Me.pnl_inventaire.SuspendLayout()
        Me.Panel6.SuspendLayout()
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
        Me.pnl_navigation.Name = "pnl_navigation"
        Me.pnl_navigation.Size = New System.Drawing.Size(923, 30)
        Me.pnl_navigation.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(-1, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(738, 579)
        Me.Panel3.TabIndex = 3
        '
        'lbl_titre
        '
        Me.lbl_titre.AutoSize = True
        Me.lbl_titre.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titre.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_titre.Location = New System.Drawing.Point(12, 5)
        Me.lbl_titre.Name = "lbl_titre"
        Me.lbl_titre.Size = New System.Drawing.Size(319, 17)
        Me.lbl_titre.TabIndex = 2
        Me.lbl_titre.Text = "Techniques de diététiques - Simulateur d'inventaire"
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
        Me.btn_exit.Location = New System.Drawing.Point(871, 0)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(50, 28)
        Me.btn_exit.TabIndex = 1
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_minimize
        '
        Me.btn_minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_minimize.FlatAppearance.BorderSize = 0
        Me.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimize.ForeColor = System.Drawing.Color.DimGray
        Me.btn_minimize.Image = Global.projet_dietetique.My.Resources.Resources.ic_remove_white_24dp_1x
        Me.btn_minimize.Location = New System.Drawing.Point(821, 0)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(50, 28)
        Me.btn_minimize.TabIndex = 0
        Me.btn_minimize.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(0, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(895, 27)
        Me.Panel4.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(12, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 21)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Fiche descriptive"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(48, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Code barre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(53, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "N° Produit:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(58, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 20)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Code PLU:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Location = New System.Drawing.Point(0, 125)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(895, 27)
        Me.Panel1.TabIndex = 48
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.Control
        Me.Label18.Location = New System.Drawing.Point(11, 2)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(198, 21)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "Caractéristiques du produit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(18, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 20)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Nom du produit:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(74, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 20)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Marque:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(60, 210)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 20)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Catégorie:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(431, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 20)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Quantité dans le format:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(480, 187)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 20)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Unité de mesure:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(541, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 20)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Format:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(46, 319)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 20)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "Description:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(48, 379)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 20)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "Remarques:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(52, 441)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 20)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "Allergènes:"
        '
        'lbl_description
        '
        Me.lbl_description.BackColor = System.Drawing.Color.Transparent
        Me.lbl_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_description.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_description.ForeColor = System.Drawing.Color.Black
        Me.lbl_description.Location = New System.Drawing.Point(158, 319)
        Me.lbl_description.Name = "lbl_description"
        Me.lbl_description.Size = New System.Drawing.Size(698, 56)
        Me.lbl_description.TabIndex = 58
        '
        'lbl_remarques
        '
        Me.lbl_remarques.BackColor = System.Drawing.Color.Transparent
        Me.lbl_remarques.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_remarques.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_remarques.ForeColor = System.Drawing.Color.Black
        Me.lbl_remarques.Location = New System.Drawing.Point(158, 382)
        Me.lbl_remarques.Name = "lbl_remarques"
        Me.lbl_remarques.Size = New System.Drawing.Size(698, 56)
        Me.lbl_remarques.TabIndex = 59
        '
        'lbl_allergenes
        '
        Me.lbl_allergenes.BackColor = System.Drawing.Color.Transparent
        Me.lbl_allergenes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_allergenes.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_allergenes.ForeColor = System.Drawing.Color.Black
        Me.lbl_allergenes.Location = New System.Drawing.Point(158, 446)
        Me.lbl_allergenes.Name = "lbl_allergenes"
        Me.lbl_allergenes.Size = New System.Drawing.Size(698, 56)
        Me.lbl_allergenes.TabIndex = 60
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Location = New System.Drawing.Point(0, 244)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(895, 27)
        Me.Panel2.TabIndex = 61
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.Control
        Me.Label17.Location = New System.Drawing.Point(11, 3)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 21)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Autres"
        '
        'lbl_nom_produit
        '
        Me.lbl_nom_produit.AutoSize = True
        Me.lbl_nom_produit.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nom_produit.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nom_produit.ForeColor = System.Drawing.Color.Black
        Me.lbl_nom_produit.Location = New System.Drawing.Point(154, 164)
        Me.lbl_nom_produit.Name = "lbl_nom_produit"
        Me.lbl_nom_produit.Size = New System.Drawing.Size(15, 20)
        Me.lbl_nom_produit.TabIndex = 62
        Me.lbl_nom_produit.Text = "-"
        '
        'lbl_marque
        '
        Me.lbl_marque.AutoSize = True
        Me.lbl_marque.BackColor = System.Drawing.Color.Transparent
        Me.lbl_marque.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_marque.ForeColor = System.Drawing.Color.Black
        Me.lbl_marque.Location = New System.Drawing.Point(154, 187)
        Me.lbl_marque.Name = "lbl_marque"
        Me.lbl_marque.Size = New System.Drawing.Size(15, 20)
        Me.lbl_marque.TabIndex = 63
        Me.lbl_marque.Text = "-"
        '
        'lbl_categorie
        '
        Me.lbl_categorie.AutoSize = True
        Me.lbl_categorie.BackColor = System.Drawing.Color.Transparent
        Me.lbl_categorie.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_categorie.ForeColor = System.Drawing.Color.Black
        Me.lbl_categorie.Location = New System.Drawing.Point(154, 210)
        Me.lbl_categorie.Name = "lbl_categorie"
        Me.lbl_categorie.Size = New System.Drawing.Size(15, 20)
        Me.lbl_categorie.TabIndex = 64
        Me.lbl_categorie.Text = "-"
        '
        'lbl_format
        '
        Me.lbl_format.AutoSize = True
        Me.lbl_format.BackColor = System.Drawing.Color.Transparent
        Me.lbl_format.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_format.ForeColor = System.Drawing.Color.Black
        Me.lbl_format.Location = New System.Drawing.Point(618, 164)
        Me.lbl_format.Name = "lbl_format"
        Me.lbl_format.Size = New System.Drawing.Size(15, 20)
        Me.lbl_format.TabIndex = 65
        Me.lbl_format.Text = "-"
        '
        'lbl_unite_mesure
        '
        Me.lbl_unite_mesure.AutoSize = True
        Me.lbl_unite_mesure.BackColor = System.Drawing.Color.Transparent
        Me.lbl_unite_mesure.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_unite_mesure.ForeColor = System.Drawing.Color.Black
        Me.lbl_unite_mesure.Location = New System.Drawing.Point(618, 187)
        Me.lbl_unite_mesure.Name = "lbl_unite_mesure"
        Me.lbl_unite_mesure.Size = New System.Drawing.Size(15, 20)
        Me.lbl_unite_mesure.TabIndex = 66
        Me.lbl_unite_mesure.Text = "-"
        '
        'lbl_quantite
        '
        Me.lbl_quantite.AutoSize = True
        Me.lbl_quantite.BackColor = System.Drawing.Color.Transparent
        Me.lbl_quantite.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quantite.ForeColor = System.Drawing.Color.Black
        Me.lbl_quantite.Location = New System.Drawing.Point(618, 210)
        Me.lbl_quantite.Name = "lbl_quantite"
        Me.lbl_quantite.Size = New System.Drawing.Size(15, 20)
        Me.lbl_quantite.TabIndex = 67
        Me.lbl_quantite.Text = "-"
        '
        'lbl_no_produit
        '
        Me.lbl_no_produit.AutoSize = True
        Me.lbl_no_produit.BackColor = System.Drawing.Color.Transparent
        Me.lbl_no_produit.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_no_produit.ForeColor = System.Drawing.Color.Black
        Me.lbl_no_produit.Location = New System.Drawing.Point(152, 46)
        Me.lbl_no_produit.Name = "lbl_no_produit"
        Me.lbl_no_produit.Size = New System.Drawing.Size(15, 20)
        Me.lbl_no_produit.TabIndex = 68
        Me.lbl_no_produit.Text = "-"
        '
        'lbl_code_barre
        '
        Me.lbl_code_barre.AutoSize = True
        Me.lbl_code_barre.BackColor = System.Drawing.Color.Transparent
        Me.lbl_code_barre.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_code_barre.ForeColor = System.Drawing.Color.Black
        Me.lbl_code_barre.Location = New System.Drawing.Point(152, 70)
        Me.lbl_code_barre.Name = "lbl_code_barre"
        Me.lbl_code_barre.Size = New System.Drawing.Size(15, 20)
        Me.lbl_code_barre.TabIndex = 69
        Me.lbl_code_barre.Text = "-"
        '
        'lbl_code_plu
        '
        Me.lbl_code_plu.AutoSize = True
        Me.lbl_code_plu.BackColor = System.Drawing.Color.Transparent
        Me.lbl_code_plu.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_code_plu.ForeColor = System.Drawing.Color.Black
        Me.lbl_code_plu.Location = New System.Drawing.Point(152, 95)
        Me.lbl_code_plu.Name = "lbl_code_plu"
        Me.lbl_code_plu.Size = New System.Drawing.Size(15, 20)
        Me.lbl_code_plu.TabIndex = 70
        Me.lbl_code_plu.Text = "-"
        '
        'btn_retour
        '
        Me.btn_retour.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btn_retour.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_retour.FlatAppearance.BorderSize = 0
        Me.btn_retour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_retour.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_retour.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_retour.Location = New System.Drawing.Point(780, 626)
        Me.btn_retour.Name = "btn_retour"
        Me.btn_retour.Size = New System.Drawing.Size(130, 32)
        Me.btn_retour.TabIndex = 71
        Me.btn_retour.Text = "Retour aux produits"
        Me.btn_retour.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(56, 283)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(78, 20)
        Me.Label19.TabIndex = 72
        Me.Label19.Text = "Périssable:"
        '
        'chk_perissable
        '
        Me.chk_perissable.AutoCheck = False
        Me.chk_perissable.AutoSize = True
        Me.chk_perissable.Location = New System.Drawing.Point(158, 286)
        Me.chk_perissable.Name = "chk_perissable"
        Me.chk_perissable.Size = New System.Drawing.Size(15, 14)
        Me.chk_perissable.TabIndex = 73
        Me.chk_perissable.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.pnl_defaut)
        Me.Panel5.Controls.Add(Me.pnl_inventaire)
        Me.Panel5.Controls.Add(Me.btn_retour)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 29)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(923, 671)
        Me.Panel5.TabIndex = 74
        '
        'pnl_defaut
        '
        Me.pnl_defaut.Controls.Add(Me.Panel4)
        Me.pnl_defaut.Controls.Add(Me.lbl_unite_mesure)
        Me.pnl_defaut.Controls.Add(Me.chk_perissable)
        Me.pnl_defaut.Controls.Add(Me.lbl_quantite)
        Me.pnl_defaut.Controls.Add(Me.lbl_code_plu)
        Me.pnl_defaut.Controls.Add(Me.lbl_format)
        Me.pnl_defaut.Controls.Add(Me.Label19)
        Me.pnl_defaut.Controls.Add(Me.Label6)
        Me.pnl_defaut.Controls.Add(Me.Label5)
        Me.pnl_defaut.Controls.Add(Me.Panel2)
        Me.pnl_defaut.Controls.Add(Me.Label7)
        Me.pnl_defaut.Controls.Add(Me.lbl_allergenes)
        Me.pnl_defaut.Controls.Add(Me.lbl_code_barre)
        Me.pnl_defaut.Controls.Add(Me.lbl_categorie)
        Me.pnl_defaut.Controls.Add(Me.Label8)
        Me.pnl_defaut.Controls.Add(Me.lbl_remarques)
        Me.pnl_defaut.Controls.Add(Me.Label9)
        Me.pnl_defaut.Controls.Add(Me.lbl_no_produit)
        Me.pnl_defaut.Controls.Add(Me.Label10)
        Me.pnl_defaut.Controls.Add(Me.lbl_description)
        Me.pnl_defaut.Controls.Add(Me.Label1)
        Me.pnl_defaut.Controls.Add(Me.lbl_marque)
        Me.pnl_defaut.Controls.Add(Me.Label3)
        Me.pnl_defaut.Controls.Add(Me.Label13)
        Me.pnl_defaut.Controls.Add(Me.Panel1)
        Me.pnl_defaut.Controls.Add(Me.lbl_nom_produit)
        Me.pnl_defaut.Controls.Add(Me.Label14)
        Me.pnl_defaut.Controls.Add(Me.Label12)
        Me.pnl_defaut.Controls.Add(Me.Label4)
        Me.pnl_defaut.Controls.Add(Me.chk_bio)
        Me.pnl_defaut.Controls.Add(Me.Label11)
        Me.pnl_defaut.Location = New System.Drawing.Point(15, 101)
        Me.pnl_defaut.Name = "pnl_defaut"
        Me.pnl_defaut.Size = New System.Drawing.Size(895, 506)
        Me.pnl_defaut.TabIndex = 10
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(208, 283)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 20)
        Me.Label14.TabIndex = 75
        Me.Label14.Text = "Bio:"
        '
        'chk_bio
        '
        Me.chk_bio.AutoCheck = False
        Me.chk_bio.AutoSize = True
        Me.chk_bio.Location = New System.Drawing.Point(264, 286)
        Me.chk_bio.Name = "chk_bio"
        Me.chk_bio.Size = New System.Drawing.Size(15, 14)
        Me.chk_bio.TabIndex = 76
        Me.chk_bio.UseVisualStyleBackColor = True
        '
        'pnl_inventaire
        '
        Me.pnl_inventaire.Controls.Add(Me.Panel6)
        Me.pnl_inventaire.Controls.Add(Me.lbl_quantSelonFormat)
        Me.pnl_inventaire.Controls.Add(Me.Label16)
        Me.pnl_inventaire.Controls.Add(Me.Label23)
        Me.pnl_inventaire.Controls.Add(Me.lbl_emplacement)
        Me.pnl_inventaire.Controls.Add(Me.lbl_quant)
        Me.pnl_inventaire.Controls.Add(Me.Label21)
        Me.pnl_inventaire.Location = New System.Drawing.Point(15, 6)
        Me.pnl_inventaire.Name = "pnl_inventaire"
        Me.pnl_inventaire.Size = New System.Drawing.Size(895, 89)
        Me.pnl_inventaire.TabIndex = 83
        Me.pnl_inventaire.Visible = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label15)
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(895, 27)
        Me.Panel6.TabIndex = 62
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.Control
        Me.Label15.Location = New System.Drawing.Point(12, 3)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 21)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Inventaire"
        '
        'lbl_quantSelonFormat
        '
        Me.lbl_quantSelonFormat.AutoSize = True
        Me.lbl_quantSelonFormat.BackColor = System.Drawing.Color.Transparent
        Me.lbl_quantSelonFormat.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quantSelonFormat.ForeColor = System.Drawing.Color.Black
        Me.lbl_quantSelonFormat.Location = New System.Drawing.Point(618, 39)
        Me.lbl_quantSelonFormat.Name = "lbl_quantSelonFormat"
        Me.lbl_quantSelonFormat.Size = New System.Drawing.Size(15, 20)
        Me.lbl_quantSelonFormat.TabIndex = 82
        Me.lbl_quantSelonFormat.Text = "-"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(34, 39)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(103, 20)
        Me.Label16.TabIndex = 77
        Me.Label16.Text = "Emplacement:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(427, 39)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(173, 20)
        Me.Label23.TabIndex = 81
        Me.Label23.Text = "Quantité selon le format:"
        '
        'lbl_emplacement
        '
        Me.lbl_emplacement.AutoSize = True
        Me.lbl_emplacement.BackColor = System.Drawing.Color.Transparent
        Me.lbl_emplacement.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_emplacement.ForeColor = System.Drawing.Color.Black
        Me.lbl_emplacement.Location = New System.Drawing.Point(154, 39)
        Me.lbl_emplacement.Name = "lbl_emplacement"
        Me.lbl_emplacement.Size = New System.Drawing.Size(15, 20)
        Me.lbl_emplacement.TabIndex = 78
        Me.lbl_emplacement.Text = "-"
        '
        'lbl_quant
        '
        Me.lbl_quant.AutoSize = True
        Me.lbl_quant.BackColor = System.Drawing.Color.Transparent
        Me.lbl_quant.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quant.ForeColor = System.Drawing.Color.Black
        Me.lbl_quant.Location = New System.Drawing.Point(154, 62)
        Me.lbl_quant.Name = "lbl_quant"
        Me.lbl_quant.Size = New System.Drawing.Size(15, 20)
        Me.lbl_quant.TabIndex = 80
        Me.lbl_quant.Text = "-"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(68, 62)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(69, 20)
        Me.Label21.TabIndex = 79
        Me.Label21.Text = "Quantité:"
        '
        'frm_details_produit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 700)
        Me.Controls.Add(Me.pnl_navigation)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_details_produit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_details_produit"
        Me.pnl_navigation.ResumeLayout(False)
        Me.pnl_navigation.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.pnl_defaut.ResumeLayout(False)
        Me.pnl_defaut.PerformLayout()
        Me.pnl_inventaire.ResumeLayout(False)
        Me.pnl_inventaire.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_navigation As Panel
    Friend WithEvents lbl_titre As Label
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_minimize As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lbl_description As Label
    Friend WithEvents lbl_remarques As Label
    Friend WithEvents lbl_allergenes As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents lbl_nom_produit As Label
    Friend WithEvents lbl_marque As Label
    Friend WithEvents lbl_categorie As Label
    Friend WithEvents lbl_format As Label
    Friend WithEvents lbl_unite_mesure As Label
    Friend WithEvents lbl_quantite As Label
    Friend WithEvents lbl_no_produit As Label
    Friend WithEvents lbl_code_barre As Label
    Friend WithEvents lbl_code_plu As Label
    Friend WithEvents btn_retour As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents chk_perissable As CheckBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents chk_bio As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents lbl_emplacement As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents pnl_defaut As Panel
    Friend WithEvents pnl_inventaire As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lbl_quantSelonFormat As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents lbl_quant As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label15 As Label
End Class
