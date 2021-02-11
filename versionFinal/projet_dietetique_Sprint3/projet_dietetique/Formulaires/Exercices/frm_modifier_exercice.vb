Imports MySql.Data.MySqlClient

Public Class frm_modifier_exercice
    'Attributs reliés à la gestion de la bd.'
    Dim strRequete As String
    Dim table As String
    Dim gestionBd As New Connexion
    Dim dataAdapter As New MySqlDataAdapter
    Dim dsExerc As DataSet
    Dim dsUtls As DataSet
    Dim uc As usr_exercices
    Dim frmDiet As New frmDietetique
    Dim no As Integer
    Dim _utls As Utilisateur
    Dim _cours As String
    Dim modification As Boolean


    ReadOnly Property Modif As Boolean
        Get
            Return modification
        End Get
    End Property



    Public Sub New(utls As Utilisateur, cours As String)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        lbl_titre.Text = "Ajouter un exercice"
        btn_modifier.Text = "Ajouter"
        _utls = utls
        _cours = cours
    End Sub




    Public Sub New(no_ex As Integer, nom As String, desc As String, statut As Boolean, type As Boolean, dateR As Date)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

        txt_nom.Text = nom
        txt_desc.Text = desc


        If statut Then
            ckb_actif.Checked = True
        End If
        no = no_ex
    End Sub
    'Bouton modifier.'
    Private Sub btn_modifier_Click(sender As Object, e As EventArgs) Handles btn_modifier.Click



        Dim d As New Date(DateRemise.Value.Year, DateRemise.Value.Month, DateRemise.Value.Day, DateTimePicker1.Value.Hour, DateTimePicker1.Value.Minute, 0)



        If btn_modifier.Text = "Modifier" Then
            strRequete = "UPDATE `tbl_exercices` 
                          SET `nom_travail`='" & StrConv(mod_regex.ConvertirApostrophe(txt_nom.Text.Trim), VbStrConv.ProperCase) & "',`description`='" & Upper_Premier_Char(mod_regex.ConvertirApostrophe(txt_desc.Text.Trim)) & "',
                          `actif`= 1, `actif_prof`= " & ckb_actif.CheckState & ",`Date_remise`='" & d & " '
                          WHERE `no_exercice` = '" & no & "'"

            Try
                gestionBd.InsDelUpd(strRequete)

            Catch ex As Exception
            End Try
        Else
            'Crée un inventaire.'
            Try
                strRequete = "INSERT INTO `tbl_inventaire` VALUES();"
                gestionBd.InsDelUpd(strRequete)
            Catch ex As Exception
            End Try

            Dim no_inventaire As Integer

            'Récupère son numéro.'
            Try
                strRequete = "select max(no_inventaire) from tbl_inventaire;"
                no_inventaire = gestionBd.Requete(strRequete)
            Catch ex As Exception
            End Try


            strRequete = "INSERT INTO `tbl_exercices`(`no_cours`, `no_inventaire`, `nom_travail`, `description`, `actif`, `actif_prof`,`Date_remise`) 
                          VALUES ('" & _cours & "',
                           " & no_inventaire & ",
                          '" & StrConv(mod_regex.ConvertirApostrophe(txt_nom.Text.Trim), VbStrConv.ProperCase) & "','" & Upper_Premier_Char(mod_regex.ConvertirApostrophe(txt_desc.Text.Trim)) & "',1,
                           " & ckb_actif.CheckState & " ,'" & d & "');"

            Try
                gestionBd.InsDelUpd(strRequete)

            Catch ex As Exception
            End Try
        End If

        modification = True

        Me.Close()
    End Sub



#Region "Verifications"

    'TextChanged.'
    Private Sub txt_nom_TextChanged(sender As TextBox, e As EventArgs) Handles txt_nom.TextChanged
        Verification(sender)
    End Sub

    'Lost Focus.'
    Private Sub txt_nom_LostFocus(sender As TextBox, e As EventArgs) Handles txt_nom.LostFocus
        Verification(sender)
    End Sub

    'L'ensemble des vérifications.'
    Private Sub Verification(ctrl As TextBox)
        Select Case ctrl.Tag
            Case "1"
                If VerifierNom() = 1 Then
                    lblE_ancien.Visible = False
                ElseIf VerifierNom() = 0 Then
                    lblE_ancien.Visible = True
                    lblE_ancien.Text = "Caractère invalide saisie"
                Else
                    lblE_ancien.Visible = True
                    lblE_ancien.Text = "Saisissez un nom"
                End If
        End Select


        If VerifierNom() Then
            btn_modifier.Enabled = True
            Return
        End If

        btn_modifier.Enabled = False

    End Sub

    'Vérifie l'ancien mot de passe.'
    Private Function VerifierNom() As Integer
        If txt_nom.Text.Trim <> "" Then
            If Exercice(txt_nom.Text.Trim) Then

                Return 1
            Else
                Return 0
            End If

        End If

        Return -1
    End Function
#End Region










#Region "Autres"

    'Si on appuis sur Enter.'
    Private Sub txt_nom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nom.KeyPress
        If e.KeyChar = Chr(13) Then
            If btn_modifier.Enabled = True Then
                btn_modifier.PerformClick()
            End If
        End If
    End Sub


    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click, btn_annuler.Click
        Me.Close()
    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles pnl_navigation.MouseDown, lbl_titre.MouseDown
        mod_mvtFenetre.mouseDown(e)
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles pnl_navigation.MouseMove, lbl_titre.MouseMove
        mod_mvtFenetre.mouseMove(e, Me)
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles pnl_navigation.MouseUp, lbl_titre.MouseUp
        mod_mvtFenetre.mouseUp(e)
    End Sub

    'Couleur des boutons.'
    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btn_modifier.MouseEnter, btn_annuler.MouseEnter
        sender.BackColor = Color.White
        sender.ForeColor = Color.Black
    End Sub

    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btn_modifier.MouseLeave, btn_annuler.MouseLeave
        If sender.Text = btn_annuler.Text Then
            sender.BackColor = Color.DimGray
            sender.ForeColor = SystemColors.Control
        Else
            sender.BackColor = Color.FromArgb(52, 73, 94)
            sender.ForeColor = SystemColors.Control
        End If
    End Sub



    Private Sub DateRemise_ValueChanged(sender As Object, e As EventArgs) Handles DateRemise.ValueChanged
        DateRemise.MinDate = System.DateTime.Now
    End Sub

    Private Sub ckb_actif_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_actif.CheckedChanged

    End Sub

    Private Sub frm_modifier_exercice_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub



#End Region

End Class