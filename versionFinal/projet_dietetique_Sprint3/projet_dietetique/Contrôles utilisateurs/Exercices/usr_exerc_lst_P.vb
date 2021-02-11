Imports MySql.Data.MySqlClient
Imports projet_dietetique
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Imaging


Public Class usr_exerc_lst_P
    'Attributs reliés à la gestion de la bd.'
    Dim strRequete As String
    Dim table As String
    Dim gestionBd As New Connexion
    Dim dataAdapter As New MySqlDataAdapter
    Dim dsExerc As New DataSet
    Dim usr_commande As usr_commandes
    Dim no As Integer
    Dim _no_ex As Integer
    Dim activer As Boolean
    Dim nom As String
    Dim dateR As Date
    Dim _uc As usr_exercices
    Dim utls As Utilisateur
    Dim exercice As Integer = 0
    Dim cours_exercice As String = ""
    Dim _uc1 As New usr_comparer_commande(Me.usr_commande, utls, cours_exercice, exercice)
    Dim menu As frmDietetique
    Dim _utls_conn As Utilisateur
    Dim _no_cours As String




    ReadOnly Property Numero As Integer
        Get
            Return _no_ex
        End Get
    End Property
    Public Sub New(_usr_commande As usr_commandes, _utls As Utilisateur, cours As String, exerc As Integer)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

        usr_commande = _usr_commande
        utls = _utls
        exercice = exerc
        cours_exercice = cours
    End Sub

    Public Sub New(no_ex As Integer, nm_ex As String, desc As String, statut As Boolean, numero As Integer, dateR_ex As String, uc As usr_exercices)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        _no_ex = no_ex
        nom = nm_ex

        lbl_nom.Text = numero & "-" & nm_ex
        lbl_description.Text = desc

        activer = statut
        no = numero
        _uc = uc
        'date rajoutée par Albert, dans le constructeur aussi
        dateR = dateR_ex
        Lbl_Date_remise.Text = dateR
        '  actif()
    End Sub

    'Modifier l'exercice.'
    Private Sub btn_modifier_Click(sender As Object, e As EventArgs) Handles btn_modifier.Click
        Dim frm_modif As New frm_modifier_exercice(_no_ex, nom, lbl_description.Text, activer, False, dateR)
        frm_modif.ShowDialog()
        maj()
    End Sub

    'Bouton sélectionner.'
    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click

        If _no_ex <> _uc.frmP.ExercSelectionne And _uc.frmP.ExercSelectionne <> 0 Then
            If MessageBox.Show("Êtes-vous certain de vouloir changer d'exercice?" & vbNewLine & "Les commandes et les réceptions non confirmées ne seront pas enregistrées.", "Changer d'exercice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                _uc.frmP.RechargerExercice()
                _uc.Selection = _no_ex
                changer_couleur_selection()

                _uc.majExercice()
            End If
        Else
            _uc.frmP.RechargerExercice()
            _uc.Selection = _no_ex
            changer_couleur_selection()

            _uc.majExercice()
        End If
    End Sub

    'Couleur quand sélectionné.'
    Public Sub changer_couleur_selection()

        pnl_principal.BackColor = Color.FromArgb(52, 73, 94)
        lbl_nom.ForeColor = Color.White
        lbl_description.ForeColor = SystemColors.Control
        btn_modifier.BackColor = Color.DimGray
        btn_select.Visible = False
        Bt_reactiver.BackColor = Color.White
        Bt_reactiver.ForeColor = Color.Black
    End Sub

    'Couleur par défaut.'
    Public Sub changer_couleur_defaut()
        If activer Then
            pnl_principal.BackColor = SystemColors.Control
            lbl_nom.ForeColor = SystemColors.ActiveCaptionText
            lbl_description.ForeColor = Color.DimGray
            Bt_reactiver.BackColor = Color.FromArgb(52, 73, 94)
        Else
            pnl_principal.BackColor = Color.Gainsboro
            lbl_nom.ForeColor = Color.DimGray
            lbl_description.ForeColor = Color.DimGray
            Bt_reactiver.BackColor = Color.FromArgb(52, 73, 94)
        End If
        btn_modifier.BackColor = Color.FromArgb(52, 73, 94)

        btn_select.Visible = True
    End Sub



    'Private Sub btn_activer_desac_Click(sender As Object, e As EventArgs) Handles btn_activer_desac.Click
    '    If btn_activer_desac.Text = "Activer" Then

    '        strRequete = "UPDATE `tbl_exercices` 
    '                 SET `actif_prof`= " & 1 & "
    '                 WHERE `no_exercice` = '" & _no_ex & "'"

    '        Try
    '            gestionBd.InsDelUpd(strRequete)

    '        Catch ex As Exception
    '            MessageBox.Show("Une erreur s'est produite.", "Erreur activation/désactivation", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try

    '        btn_activer_desac.BackColor = Color.FromArgb(72, 84, 96)
    '        maj()





    '    Else

    '        strRequete = "UPDATE `tbl_exercices` 
    '                 SET `actif_prof`= " & 0 & "
    '                 WHERE `no_exercice` = '" & _no_ex & "'"

    '        Try
    '            gestionBd.InsDelUpd(strRequete)

    '        Catch ex As Exception
    '            MessageBox.Show("Une erreur s'est produite.", "Erreur activation/désactivation", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try

    '        btn_activer_desac.BackColor = Color.FromArgb(52, 73, 50)
    '        maj()
    '    End If
    'End Sub

    'Met à jour les infos de l'exercice.'
    Private Sub maj()
        recupererEx()
        With dsExerc.Tables(0).Rows(0)
            nom = .Item(1)
            lbl_nom.Text = no & "-" & .Item(1)
            lbl_description.Text = .Item(2)
            Lbl_Date_remise.Text = .Item(4)




            If .Item(3) = True Then
                If _no_ex <> _uc.Selection Then
                    pnl_principal.BackColor = Color.WhiteSmoke
                    lbl_nom.ForeColor = SystemColors.ActiveCaptionText
                End If
                'btn_activer_desac.Text = "Désactiver"
                'verifier_couleur(btn_activer_desac)
                activer = True
            Else
                If _no_ex <> _uc.Selection Then
                    pnl_principal.BackColor = Color.Gainsboro
                    lbl_nom.ForeColor = Color.DimGray
                End If
                'btn_activer_desac.Text = "Activer"
                'verifier_couleur(btn_activer_desac)
                activer = False
            End If
        End With
    End Sub

    Private Sub recupererEx()
        strRequete = "select `no_exercice`, `nom_travail`, `description`,`actif_prof`,`Date_remise`  
                      from `tbl_exercices` 
                      where `no_exercice` = '" & _no_ex & "' and `actif` = 1;"
        table = "tbl_exercices"

        gestionBd.miseAjourDS(dsExerc, dataAdapter, strRequete, table)
    End Sub



    'Private Sub actif()
    '    If activer Then
    '        btn_activer_desac.Text = "Désactiver"
    '    Else
    '        btn_activer_desac.Text = "Activer"
    '        btn_activer_desac.BackColor = Color.FromArgb(52, 73, 50)
    '        btn_activer_desac.ForeColor = SystemColors.Control
    '        lbl_nom.ForeColor = Color.DimGray
    '        pnl_principal.BackColor = Color.Gainsboro
    '    End If
    'End Sub




    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btn_modifier.MouseEnter, btn_select.MouseEnter, Bt_reactiver.MouseEnter

        sender.BackColor = Color.White
        sender.ForeColor = Color.Black

    End Sub
    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles  btn_modifier.MouseLeave, btn_select.MouseLeave, Bt_reactiver.MouseLeave
        verifier_couleur(sender)
    End Sub

    Private Sub verifier_couleur(btn As Button)
        Select Case btn.Text
            Case btn_modifier.Text
                If _uc.Selection = _no_ex Then
                    btn.BackColor = Color.DimGray
                    btn.ForeColor = SystemColors.Control
                Else
                    btn.BackColor = Color.FromArgb(52, 73, 94)
                    btn.ForeColor = SystemColors.Control
                End If
            Case Bt_reactiver.Text
                If _uc.Selection = _no_ex Then
                    Bt_reactiver.BackColor = Color.White
                    Bt_reactiver.ForeColor = Color.Black
                Else
                    Bt_reactiver.BackColor = Color.FromArgb(52, 73, 94)
                    Bt_reactiver.ForeColor = SystemColors.Control
                End If

            Case Else
                btn.BackColor = Color.FromArgb(52, 73, 94)
                btn.ForeColor = SystemColors.Control
        End Select
    End Sub

    Private Sub btn_MouseEnter(sender As Object, e As EventArgs) Handles btn_modifier.MouseEnter, btn_select.MouseEnter, Bt_reactiver.MouseEnter

    End Sub

    Private Sub btn_MouseLeave(sender As Object, e As EventArgs) Handles btn_modifier.MouseLeave, btn_select.MouseLeave, Bt_reactiver.MouseLeave

    End Sub



    Private Sub pnl_principal_Paint(sender As Object, e As PaintEventArgs) Handles pnl_principal.Paint
        If dateR <= System.DateTime.Now Then
            strRequete = "UPDATE `tbl_exercices` 
                     SET `actif_prof`= " & 0 & "
                     WHERE `no_exercice` = '" & _no_ex & "'"

            Try
                gestionBd.InsDelUpd(strRequete)

            Catch ex As Exception
                MessageBox.Show("Une erreur s'est produite.", "Erreur activation/désactivation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            '   btn_activer_desac.Enabled = False
            btn_modifier.Enabled = False
            Bt_reactiver.Enabled = True

            maj()

        ElseIf dateR.Year <= System.DateTime.Now.Year And dateR.Month < System.DateTime.Now.Month Then
            strRequete = "UPDATE `tbl_exercices` 
                     SET `actif_prof`= " & 0 & "
                     WHERE `no_exercice` = '" & _no_ex & "'"

            Try
                gestionBd.InsDelUpd(strRequete)

            Catch ex As Exception
                MessageBox.Show("Une erreur s'est produite.", "Erreur activation/désactivation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try



            '  btn_activer_desac.Enabled = False
            btn_modifier.Enabled = False
            Bt_reactiver.Enabled = True

        Else
            strRequete = "UPDATE `tbl_exercices` 
                     SET `actif_prof`= " & 1 & "
                     WHERE `no_exercice` = '" & _no_ex & "'"

            Try
                gestionBd.InsDelUpd(strRequete)

            Catch ex As Exception
                MessageBox.Show("Une erreur s'est produite.", "Erreur activation/désactivation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            Bt_reactiver.Enabled = False
            ' btn_activer_desac.Enabled = True
            btn_modifier.Enabled = True

            maj()

        End If

    End Sub

    Private Sub Bt_reactiver_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Bt_reactiver_Click_1(sender As Object, e As EventArgs) Handles Bt_reactiver.Click

        ' btn_activer_desac.Enabled = True
        btn_modifier.Enabled = True
        Dim frm_modif As New frm_modifier_exercice(_no_ex, nom, lbl_description.Text, activer, False, dateR)
        frm_modif.ShowDialog()
        maj()

    End Sub


End Class
