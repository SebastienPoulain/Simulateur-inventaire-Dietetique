Imports MySql.Data.MySqlClient

Public Class usr_connexionUtls
    Dim strRequete As String
    Dim table As String
    Dim gestionBd As New Connexion
    Dim dataTable = New DataTable
    Dim dataAdapter As New MySqlDataAdapter
    Dim dataSet As DataSet
    Dim utls As Utilisateur
    Dim frm_con As frm_connexion


    Public Shared ctr_connecter As Integer = 0

    Public Sub New(_frm_con As frm_connexion)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        frm_con = _frm_con
    End Sub

    Private Sub user_connexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        effacerInfoConnexion()
    End Sub

    Private Sub btnConnecter_Click(sender As Object, e As EventArgs) Handles btnConnecter.Click
        connexion()
    End Sub


    Public Function verificationChampNull(v_nulle As Boolean) As Boolean

        If Not txtID.Text.Trim = "" Then

            lbErreurID.Text = ""
        Else
            lbErreurID.Text = "Saisissez un identifiant"
            v_nulle = False
        End If

        If Not txtMtp.Text.Trim = "" Then

            lbErreurMotPasse.Text = ""
        Else

            lbErreurMotPasse.Text = "Saisissez un mot de passe"
            v_nulle = False
        End If

        Return v_nulle

    End Function


    Private Sub txtMtp_LostFocus(sender As Object, e As EventArgs) Handles txtMtp.LostFocus, txtID.LostFocus

        If ctr_connecter >= 1 Then


            If sender.name = "txtMtp" And txtMtp.Text <> Nothing And lbErreurMotPasse.Text = "Saisissez un mot de passe" Then

                lbErreurMotPasse.Text = Nothing



            ElseIf sender.name = "txtMtp" And txtMtp.Text = Nothing Then
                lbErreurMotPasse.Text = "Saisissez un mot de passe"




            End If



            If sender.name = "txtID" And txtID.Text <> Nothing And lbErreurID.Text = "Saisissez un identifiant" Then

                lbErreurID.Text = Nothing

            ElseIf sender.name = "txtID" And txtID.Text = Nothing Then
                lbErreurID.Text = "Saisissez un identifiant"

            End If


        End If


    End Sub


    Public Sub effacerInfoConnexion()
        txtID.Text = ""
        txtMtp.Text = ""
        txtID.Focus()
    End Sub

    Private Sub ConnexionAvecEnter(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress, txtMtp.KeyPress
        If e.KeyChar = Chr(13) Then
            connexion()
        End If
    End Sub
    ''' <summary>
    ''' Méthode qui vérifie si l'utilisateur et le mot de passe sont dans le dataset, il compare le mot de passe crypté de la bd à la valeur crypter du mot de passe écrit dans le textbox txtMtp.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub connexion()
        ctr_connecter += 1
        Dim ctr_id_mtp As Integer = 0
        Dim nulle As Boolean = True


        If verificationChampNull(nulle) = True Then
            'Récupère tous les utilisateurs de la bd.'
            strRequete = "Select no_utilisateur, prenom_personne, nom_personne, mot_de_passe, titre, actif from tbl_utilisateurs"
            table = "tbl_utilisateurs"
            gestionBd.miseAjourDS(dataSet, dataAdapter, strRequete, table)

            Dim i As Integer = 0
            Dim utls_trouver As Integer = 0

            'Recherche l'utilisateur et son mot de passe dans le dataset.'

            With dataSet.Tables(0)
                While i < .Rows.Count And utls_trouver = False
                    If (txtID.Text = .Rows(i).Item(0) And GetMd5Hash(txtMtp.Text) = .Rows(i).Item(3)) Then
                        If .Rows(i).Item(5) = True Then
                            utls_trouver = 1
                        Else
                            utls_trouver = -1
                        End If
                    Else
                        i += 1
                    End If
                End While

                'Si un utilisateur est trouvé dans le dataset.'
                If utls_trouver = 1 Then
                    'Attribut l'utilisateur a la property du userControl (qui pourra être utilisé dans le form principal.'
                    utls = New Utilisateur(.Rows(i).Item(0), .Rows(i).Item(1), .Rows(i).Item(2), .Rows(i).Item(3), .Rows(i).Item(4))
                    If utls.Titre = "a" Then
                        Dim frm_principal As New frmDietetique(utls)
                        frm_principal.Show()
                        frm_con.Close()
                    Else
                        frm_con.ProchainUser(utls)
                        Me.Hide()
                    End If


                ElseIf utls_trouver = 0 Then
                    MessageBox.Show("Votre identifiant ou votre mot de passe est invalide.",
                                    "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    effacerInfoConnexion()
                Else
                    MessageBox.Show("Votre compte est inactif." & vbNewLine & "Contactez vote administrateur.",
                                    "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    effacerInfoConnexion()
                End If
            End With
        End If
    End Sub




    'Couleur des boutons.'
    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btnConnecter.MouseEnter, btnQuitter.MouseEnter

        sender.BackColor = Color.White
        sender.ForeColor = Color.Black
    End Sub

    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btnConnecter.MouseLeave, btnQuitter.MouseLeave
        If sender.Text = btnQuitter.Text Then
            sender.BackColor = Color.DimGray
            sender.ForeColor = SystemColors.Control
        Else
            sender.BackColor = Color.FromArgb(52, 73, 94)
            sender.ForeColor = SystemColors.Control
        End If
    End Sub
    ''' <summary>
    ''' Méthode qui gère l'événement du clic sur le bouton btnQuitter, un message de confirmation pour savoir si on veut vraiment quitter
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Dim result = MessageBox.Show("Êtes-vous certain de vouloir quitter l'application ? ", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btn_MouseEnter(sender As Object, e As EventArgs) Handles btnQuitter.MouseEnter, btnConnecter.MouseEnter

    End Sub

    Private Sub btn_MouseLeave(sender As Object, e As EventArgs) Handles btnQuitter.MouseLeave, btnConnecter.MouseLeave

    End Sub

    Private Sub pnl_connexion_Paint(sender As Object, e As PaintEventArgs) Handles pnl_connexion.Paint

    End Sub
End Class
