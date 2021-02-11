Public Class frm_changer_mdp
    Dim _mdp As String

    Property MotDePasse As String
        Set(value As String)
            _mdp = value
        End Set
        Get
            Return _mdp
        End Get
    End Property


    Public Sub New(mdp As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _mdp = mdp
    End Sub

    'Bouton modifier.'
    Private Sub btn_modifier_Click(sender As Object, e As EventArgs) Handles btn_modifier.Click
        If GetMd5Hash(txt_ancien.Text) = _mdp Then
            MotDePasse = txt_nv.Text.Trim
            Me.Close()
            MessageBox.Show("Votre mot de passe a été modifié.",
                                    "Mot de passe modifié", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Le mot de passe actuel ne correspond pas.",
                                    "Modifier votre mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            EffacerTxt()
        End If
    End Sub

#Region "Verifications"

    'TextChanged.'
    Private Sub txt_nom_TextChanged(sender As TextBox, e As EventArgs) Handles txt_ancien.TextChanged, txt_nv.TextChanged, txt_nv2.TextChanged
        Verification(sender)
    End Sub

    'Lost Focus.'
    Private Sub txt_nom_LostFocus(sender As TextBox, e As EventArgs) Handles txt_ancien.LostFocus, txt_nv.LostFocus, txt_nv2.LostFocus
        Verification(sender)
    End Sub

    'Si on appuis sur Enter.'
    Private Sub txt_nom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ancien.KeyPress, txt_nv.KeyPress, txt_nv2.KeyPress
        If e.KeyChar = Chr(13) Then
            If btn_modifier.Enabled = True Then
                btn_modifier.PerformClick()
            End If
        End If
    End Sub

    'L'ensemble des vérifications.'
    Private Sub Verification(ctrl As TextBox)
        Dim verif As Integer

        Select Case ctrl.Tag
            Case "1"
                verif = VerifierAncien()

                If verif = 1 Then
                    lblE_ancien.Visible = False
                ElseIf verif = -1 Then
                    lblE_ancien.Visible = True
                    lblE_ancien.Text = "Saisissez votre ancien mot de passe"
                Else
                    lblE_ancien.Visible = True
                    lblE_ancien.Text = "Caractère invalide"
                End If
            Case "2"
                verif = VerifierNv()

                If verif = 1 Then
                    lblE_nouveau.Visible = False
                ElseIf verif = -1 Then
                    lblE_nouveau.Visible = True
                    lblE_nouveau.Text = "Saisissez un nouveau mot de passe"
                Else
                    lblE_nouveau.Visible = True
                    lblE_nouveau.Text = "Caractère invalide"
                End If
            Case "3"
                If VerifierNv2() Then
                    lblE_nouveau2.Visible = False
                Else
                    lblE_nouveau2.Visible = True
                End If
        End Select


        If VerifierAncien() = 1 Then
            If VerifierNv() = 1 Then
                If VerifierNv2() Then
                    btn_modifier.Enabled = True
                    Return
                End If
            End If
        End If

        btn_modifier.Enabled = False

    End Sub

    'Vérifie l'ancien mot de passe.'
    Private Function VerifierAncien() As Integer
        If txt_ancien.Text.Trim <> "" Then
            If mod_regex.Utls(txt_ancien.Text) Then
                Return 1
            Else
                Return 0
            End If
        Else
            Return -1
        End If
    End Function

    'Vérifie le nouveau mot de passe.'
    Private Function VerifierNv() As Integer
        If txt_nv.Text.Trim <> "" Then
            If mod_regex.Utls(txt_nv.Text) Then
                Return 1
            Else
                Return 0
            End If
        Else
            Return -1
        End If
    End Function

    'Vérifie la confirmation.'
    Private Function VerifierNv2() As Boolean
        Return txt_nv2.Text = txt_nv.Text
    End Function
#End Region


#Region "Autres"
    Private Sub EffacerTxt()
        txt_ancien.Text = ""
        txt_nv.Text = ""
        txt_nv2.Text = ""
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
#End Region
End Class