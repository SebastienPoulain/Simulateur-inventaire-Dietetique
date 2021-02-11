''' <summary>
'''  formulaire affichant le contenu du contrôle utilisateur usr_Changer_Taux_Taxes.
'''   fait par Sébastien Poulain
''' </summary>
''' <tag>2019</tag>
Public Class frm_changer_taux_taxes
    Dim ChangerTaxes As New usr_Changer_Taux_Taxes
    Private Sub frm_changer_taux_taxes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Controls.Add(ChangerTaxes)
        Me.CenterToScreen()
    End Sub
    ''' <summary>
    '''  méthode qui fait en sorte que l'on quitte le formulaire si on clique sur le bouton btn_exit.
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub
    ''' <summary>
    '''  méthode qui fait en sorte que l'on réduit le formulaire si on clique sur le bouton btn_minimize.
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    ''' <summary>
    '''   méthode qui gère l'enfoncement de la souris.
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles pnl_navigation.MouseDown, lbl_titre.MouseDown
        mod_mvtFenetre.mouseDown(e)
    End Sub
    ''' <summary>
    '''  méthode qui gère le déplacement de la fenêtre lorsque la souris est enfoncée.
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles pnl_navigation.MouseMove, lbl_titre.MouseMove
        mod_mvtFenetre.mouseMove(e, Me)
    End Sub
    ''' <summary>
    '''   méthode qui gère le relâchement de la souris.
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles pnl_navigation.MouseUp, lbl_titre.MouseUp
        mod_mvtFenetre.mouseUp(e)
    End Sub
End Class