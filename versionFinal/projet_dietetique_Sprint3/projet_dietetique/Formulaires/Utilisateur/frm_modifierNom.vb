Public Class frm_modifierNom
    Dim _nom As String

    Property Nom As String
        Set(value As String)
            _nom = value
        End Set
        Get
            Return _nom
        End Get
    End Property

    Public Sub New(nm As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Nom = nm
        txt_nom.Text = nm
        Verification(txt_nom)
    End Sub

    Public Sub New(nm As String, msgTop As String, labelTxtBox As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Nom = nm
        txt_nom.Text = nm
        Verification(txt_nom)
        lbl_titre.Text = msgTop
        lbl_txt.Text = labelTxtBox
    End Sub

    'Bouton modifier.'
    Private Sub btn_modifier_Click(sender As Object, e As EventArgs) Handles btn_modifier.Click
        Nom = StrConv(txt_nom.Text.Trim, VbStrConv.ProperCase)
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

    'Si on appuis sur Enter.'
    Private Sub txt_nom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nom.KeyPress
        If e.KeyChar = Chr(13) Then
            If btn_modifier.Enabled = True Then
                btn_modifier.PerformClick()
            End If
        End If
    End Sub

    'L'ensemble des vérifications.'
    Private Sub Verification(ctrl As TextBox)
        If VerifierNom() Then
            lbE_nm.Visible = False
            btn_modifier.Enabled = True
        Else
            lbE_nm.Visible = True
            btn_modifier.Enabled = False
        End If
    End Sub

    'Vérifie le nom.'
    Private Function VerifierNom() As Boolean
        If txt_nom.Text.Trim = "" Then
            Return True
        ElseIf mod_regex.Nom(txt_nom.Text) Then
            Return True
        Else Return False

        End If
    End Function
#End Region



#Region "Autres"
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