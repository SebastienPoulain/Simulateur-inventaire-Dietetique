Public Class usr_gestion_MenuUtls
    Dim utls_conn As Utilisateur
    Dim _usr_cours As usr_gestion_Menucours
    Dim usr_listeUtls As usr_liste_utls
    Dim usr_ajouterUtls As usr_ajouter_utls
    Dim usr_genUtls As usr_generer_utls

    Property UtlsConn As Utilisateur
        Get
            Return utls_conn
        End Get
        Set(value As Utilisateur)
            utls_conn = value
        End Set
    End Property

    Public Sub New(utls As Utilisateur, usr_menuCours As usr_gestion_Menucours)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        utls_conn = utls
        _usr_cours = usr_menuCours
    End Sub


    Private Sub usr_gestion_MenuUtls_Load(sender As Object, e As EventArgs) Handles Me.Load
        usr_listeUtls = New usr_liste_utls(Me, utls_conn)
        pnl_listeUtls.Controls.Add(usr_listeUtls)
        usr_listeUtls.Dock = DockStyle.Fill

        usr_ajouterUtls = New usr_ajouter_utls(usr_listeUtls)
        pnl_ajouterUtls.Controls.Add(usr_ajouterUtls)
        usr_ajouterUtls.Dock = DockStyle.Fill

        usr_genUtls = New usr_generer_utls(Me, usr_listeUtls)
        pnl_genererUtls.Controls.Add(usr_genUtls)
        usr_genUtls.Dock = DockStyle.Fill

        gestion_droit()

        usr_listeUtls.grid_utls.Focus()
    End Sub

    Private Sub gestion_droit()
        If UtlsConn.Titre = "a"c Then
            usr_listeUtls.droit_admin()
            usr_ajouterUtls.droit_admin()
            usr_genUtls.droit_admin()
        ElseIf UtlsConn.Titre = "p"c Then
            usr_listeUtls.droit_prof()
            usr_ajouterUtls.droit_prof()
            usr_genUtls.droit_prof()
            lbl_titre.Text = "Étudiants"
            lbl_liste.Text = "Liste des étudiants"
            lbl_créer.Text = "Créer un étudiant"
            lbl_gen.Text = "Générer des étudiants"
        End If
    End Sub

    Public Sub majCours()
        _usr_cours.maj()
    End Sub
End Class
