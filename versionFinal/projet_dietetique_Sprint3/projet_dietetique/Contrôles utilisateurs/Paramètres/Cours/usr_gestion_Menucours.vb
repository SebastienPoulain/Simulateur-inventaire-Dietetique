Public Class usr_gestion_Menucours
    Dim coursSelectionnee As String
    Dim usr_cours As New usr_gestion_cours(Me)
    Public utls_conn As Utilisateur



    Public Sub New(utls As Utilisateur)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        utls_conn = utls
    End Sub

    Private Sub usr_gestion_Menucours_Load(sender As Object, e As EventArgs) Handles Me.Load
        usr_cours = New usr_gestion_cours(Me)
        pnl_cours.Controls.Add(usr_cours)
        usr_cours.Dock = DockStyle.Fill
        usr_cours.BringToFront()

        pnl_menuCours.Focus()
    End Sub

    Public Sub maj()
        usr_cours.MAJ()
    End Sub
End Class
