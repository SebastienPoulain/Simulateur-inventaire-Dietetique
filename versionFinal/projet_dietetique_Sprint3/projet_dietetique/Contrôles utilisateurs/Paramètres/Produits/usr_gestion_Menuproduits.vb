Public Class usr_gestion_Menuproduits
    Private Sub usr_gestion_Menuproduits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim usr_recherche As New usr_rech_gestion_produit(Me)
        pnl_recherches.Controls.Add(usr_recherche)
        usr_recherche.Dock = DockStyle.Fill
    End Sub
End Class
