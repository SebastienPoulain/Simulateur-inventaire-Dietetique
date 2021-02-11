
''' <summary>
''' formulaire qui appel le contrôle utilisateur usr_recette_exercice
''' </summary>
''' <tag>2019</tag>

Public Class Frm_recette
    Dim Utls As Utilisateur
    Dim _no_cours As String
    Dim Exercice As Integer

    Public Sub New(_utls As Utilisateur, cours As String, exerc As Integer)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Utls = _utls
        Exercice = exerc
        _no_cours = cours

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

        Dim usr_recet_exercic As New usr_recette_exercice(Utls, _no_cours, Exercice)
        Panel1.Controls.Add(usr_recet_exercic)
    End Sub

    Private Sub pnl_navigation_Paint(sender As Object, e As PaintEventArgs) Handles pnl_navigation.Paint

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub frm_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub lbl_titre_Click(sender As Object, e As EventArgs) Handles lbl_titre.Click

    End Sub

End Class