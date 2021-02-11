Public Class frmModifierCommande

    Dim commande_modifier As usr_commandes
    Dim indice_commande As Integer = 0
    Public Shared lstModifier As New List(Of String)
    Dim MySource As New AutoCompleteStringCollection()
    Dim lsv_controle As ListView

    ' PIERRE-OLIVIER DUBOIS-NADEAU

    Public Sub New(ByRef _commande_modifier As usr_commandes, ByVal i As Integer, _lsv_controle As ListView)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        commande_modifier = _commande_modifier
        indice_commande = i
        lsv_controle = _lsv_controle

    End Sub

    'Remplir les informations dans les textbox.
    Private Sub frmModifierCommande_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNomProduit.Text = lsv_controle.SelectedItems(0).SubItems(0).Text

        txtQuantite.Text = lsv_controle.SelectedItems(0).SubItems(2).Text
        txtFormat.Text = lsv_controle.SelectedItems(0).SubItems(3).Text

        txtUniteMesureModifier.Text = lsv_controle.SelectedItems(0).SubItems(4).Text
    End Sub

    'Bouton annuler'
    Private Sub btnAnnulerCommande_Click(sender As Object, e As EventArgs) Handles btnAnnulerCommande.Click
        Me.Close()

    End Sub

    'bouton enregistrer'.
    Private Sub btnEnregistrer_Click(sender As Object, e As EventArgs) Handles btnEnregistrer.Click

        Dim prix_total_commande As Double = 0

        If txtQuantite.Text.Trim = "" Or txtQuantite.Text = 0 Then

            MessageBox.Show("Veuillez entrer une quantité supérieure ou égale à 1.", "Modification de commande", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            For ctrposition = 0 To lsv_controle.Items.Count - 1

                If txtNomProduit.Text = lsv_controle.Items(ctrposition).Text And lsv_controle.Items(indice_commande).SubItems(1).Text = lsv_controle.Items(ctrposition).SubItems(1).Text And txtFormat.Text =
                       lsv_controle.Items(ctrposition).SubItems(3).Text And txtUniteMesureModifier.Text = lsv_controle.Items(ctrposition).SubItems(4).Text Then

                    prix_total_commande = CDbl(txtQuantite.Text) * replace_signe_dollars(lsv_controle.Items(ctrposition).SubItems(5).Text, "virgule")

                    'Vérifie que le prix total ne dépasse pas 9999 taxes non incluse'.
                    If commande_modifier.calculer_prix_total_commande(prix_total_commande) Then
                        lsv_controle.Items(ctrposition).SubItems(2).Text = txtQuantite.Text
                        lsv_controle.Items(ctrposition).SubItems(6).Text = FormatCurrency(prix_total_commande)
                        commande_modifier.calculer()
                        MessageBox.Show("La modification s'est effecutée correctement.", "Modification de commande", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    Else

                    End If
                End If
            Next
        End If
    End Sub


    Private Sub txtQuantite_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantite.KeyPress
        If Not IsNumeric(e.KeyChar) AndAlso e.KeyChar <> ","c AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub


    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, lbl_titre.MouseDown, pnl_navigation.MouseDown
        mod_mvtFenetre.mouseDown(e)
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, lbl_titre.MouseMove, pnl_navigation.MouseMove
        mod_mvtFenetre.mouseMove(e, Me)
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp, lbl_titre.MouseUp, pnl_navigation.MouseUp
        mod_mvtFenetre.mouseUp(e)
    End Sub

    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btnAnnulerCommande.MouseEnter, btnEnregistrer.MouseEnter
        sender.BackColor = Color.White
        sender.ForeColor = Color.Black
    End Sub
    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btnAnnulerCommande.MouseLeave, btnEnregistrer.MouseLeave
        If sender.Text = btnAnnulerCommande.Text Then
            sender.BackColor = Color.DimGray
            sender.ForeColor = SystemColors.Control
        Else
            sender.BackColor = Color.FromArgb(52, 73, 94)
            sender.ForeColor = SystemColors.Control
        End If
    End Sub

End Class