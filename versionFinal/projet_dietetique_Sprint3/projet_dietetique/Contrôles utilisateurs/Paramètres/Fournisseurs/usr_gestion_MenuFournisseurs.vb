Public Class usr_gestion_MenuFournisseurs
    Private Sub usr_gestion_MenuFournisseurs_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim usr_liste As New usr_gestion_fournisseurs
        pnl_listeFourn.Controls.Add(usr_liste)
        usr_liste.Dock = DockStyle.Fill
        usr_liste.BringToFront()
    End Sub
End Class
