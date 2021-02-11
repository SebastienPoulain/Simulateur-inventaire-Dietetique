Imports MySql.Data.MySqlClient

Public Class usr_purger
    'Attributs reliés à la gestion de la bd.'
    Dim strRequete As String
    Dim table As String
    Dim gestionBd As New Connexion
    Dim dataAdapter As New MySqlDataAdapter
    Dim ds As DataSet
    Dim bouton() As Button
    Dim utls As Utilisateur

    Dim animation = New cls_animation_operation

    Public Sub New(utls_conn As Utilisateur)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        utls = utls_conn
    End Sub

    Private Sub usr_purger_Load(sender As Object, e As EventArgs) Handles Me.Load
        bouton = {btn_cours, btn_etu, btn_ensei, btn_admin, btn_produit, btn_fournisseur, btn_unite, btn_format, btn_categorie, btn_empl, btn_ville}
        PossibleDeSupprimer()
    End Sub

#Region "Fonctions déterminant ce qui doit supprimer avant les autres."

    'Procédure déterminant ce qui doit supprimer avant les autres.'
    Private Sub PossibleDeSupprimer()
        If CompteExercice() Then
            If CompteCours() Then
                If CompteProduit() Then
                    DesactiverBouton(-1)
                Else
                    DesactiverBouton(6)
                End If
            Else
                DesactiverBouton(2)
            End If
        Else
            DesactiverBouton(0)
        End If
    End Sub

    'Vérifie si tous les exercices sont supprimés.'
    Private Function CompteExercice()
        Try
            strRequete = "select count(*) from tbl_exercices"
            If gestionBd.Requete(strRequete) = 0 Then
                Return True
            Else
                Return False
            End If
        Catch e As Exception
            Return False
        End Try
    End Function

    'Vérifie si tous les cours sont supprimés.'
    Private Function CompteCours()
        Try
            strRequete = "select count(*) from tbl_cours"
            If gestionBd.Requete(strRequete) = 0 Then
                Return True
            Else
                Return False
            End If
        Catch e As Exception
            Return False
        End Try
    End Function

    'Vérifie si tous les produits sont supprimés.'
    Private Function CompteProduit()
        Try
            strRequete = "select count(*) from tbl_produits"
            If gestionBd.Requete(strRequete) = 0 Then
                Return True
            Else
                Return False
            End If
        Catch e As Exception
            Return False
        End Try
    End Function

    'Désactive les boutons des éléments ne pouvant pas être supprimés avant d'autres.'
    Private Sub DesactiverBouton(i As Integer)
        If i <> -1 Then
            For j = 0 To bouton.Length - 1
                If j >= i Then
                    bouton(j).Enabled = False
                Else
                    bouton(j).Enabled = True
                End If
            Next
        Else
            For j = 0 To bouton.Length - 1
                bouton(j).Enabled = True
            Next
        End If
    End Sub

#End Region

    'Supprimer les exercices.'
    Private Sub btn_exercice_Click(sender As Object, e As EventArgs) Handles btn_exercice.Click
        If MessageBox.Show("Êtes-vous certain de vouloir supprimer tous les exercices?" & vbNewLine & "Cette opération est définitive.",
                          "Supprimer les exercices",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                strRequete = "delete from tbl_inventaire where no_inventaire in (select no_inventaire from tbl_exercices);"

                gestionBd.InsDelUpd(strRequete)
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Suppression réussie.", cls_animation_operation.Reussie)
            Catch ex As Exception
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de la suppression.", cls_animation_operation.Echec)
            End Try
            PossibleDeSupprimer()
        End If
    End Sub

    'Supprimer les cours.'
    Private Sub btn_cours_Click(sender As Object, e As EventArgs) Handles btn_cours.Click
        If MessageBox.Show("Êtes-vous certain de vouloir supprimer tous les cours?" & vbNewLine & "Cette opération est définitive.",
                          "Supprimer les cours",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                strRequete = "delete from tbl_cours;"

                gestionBd.InsDelUpd(strRequete)
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Suppression réussie.", cls_animation_operation.Reussie)
            Catch ex As Exception
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de la suppression.", cls_animation_operation.Echec)
            End Try
            PossibleDeSupprimer()
        End If
    End Sub

    'Supprimer les étudiants.'
    Private Sub btn_etu_Click(sender As Object, e As EventArgs) Handles btn_etu.Click
        If MessageBox.Show("Êtes-vous certain de vouloir supprimer tous les étudiants?" & vbNewLine & "Cette opération est définitive.",
                          "Supprimer les étudiants",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                strRequete = "delete from tbl_utilisateurs where titre = 'e';"

                gestionBd.InsDelUpd(strRequete)
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Suppression réussie.", cls_animation_operation.Reussie)
            Catch ex As Exception
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de la suppression.", cls_animation_operation.Echec)
            End Try
            PossibleDeSupprimer()
        End If
    End Sub

    'Supprimer les enseignants.'
    Private Sub btn_ensei_Click(sender As Object, e As EventArgs) Handles btn_ensei.Click
        If MessageBox.Show("Êtes-vous certain de vouloir supprimer tous les enseignants?" & vbNewLine & "Cette opération est définitive.",
                          "Supprimer les enseignants",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                strRequete = "delete from tbl_inventaire where no_inventaire in (select no_inventaire from tbl_inventaire_prof);"

                gestionBd.InsDelUpd(strRequete)

                strRequete = "delete from tbl_utilisateurs where titre = 'p'"

                gestionBd.InsDelUpd(strRequete)
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Suppression réussie.", cls_animation_operation.Reussie)
            Catch ex As Exception
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de la suppression.", cls_animation_operation.Echec)
            End Try
            PossibleDeSupprimer()
        End If
    End Sub

    'Supprimer les administrateurs.'
    Private Sub btn_admin_Click(sender As Object, e As EventArgs) Handles btn_admin.Click
        If MessageBox.Show("Êtes-vous certain de vouloir supprimer tous les administrateurs?" & vbNewLine & "Cette opération est définitive." & vbNewLine & vbNewLine & "Votre compte ne sera pas supprimé.",
                          "Supprimer les administrateurs",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                strRequete = "delete from tbl_utilisateurs where titre = 'a' and no_utilisateur not in ('" & utls.No_id & "');"

                gestionBd.InsDelUpd(strRequete)
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Suppression réussie.", cls_animation_operation.Reussie)
            Catch ex As Exception
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de la suppression.", cls_animation_operation.Echec)
            End Try
            PossibleDeSupprimer()
        End If
    End Sub

    'Supprimer les fournisseurs.'
    Private Sub btn_fournisseur_Click(sender As Object, e As EventArgs) Handles btn_fournisseur.Click
        If MessageBox.Show("Êtes-vous certain de vouloir supprimer tous les fournisseurs?" & vbNewLine & "Cette opération est définitive.",
                          "Supprimer les fournisseurs",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                strRequete = "delete from tbl_fournisseurs"

                gestionBd.InsDelUpd(strRequete)
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Suppression réussie.", cls_animation_operation.Reussie)
            Catch ex As Exception
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de la suppression.", cls_animation_operation.Echec)
            End Try
            PossibleDeSupprimer()
        End If
    End Sub

    'Supprimer les produits.'
    Private Sub btn_produit_Click(sender As Object, e As EventArgs) Handles btn_produit.Click
        If MessageBox.Show("Êtes-vous certain de vouloir supprimer tous les produits?" & vbNewLine & "Cette opération est définitive.",
                          "Supprimer les produits",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                strRequete = "delete from tbl_produits"

                gestionBd.InsDelUpd(strRequete)
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Suppression réussie.", cls_animation_operation.Reussie)
            Catch ex As Exception
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de la suppression.", cls_animation_operation.Echec)
            End Try
            PossibleDeSupprimer()
        End If
    End Sub

    'Supprimer les unités de mesure.'
    Private Sub btn_unite_Click(sender As Object, e As EventArgs) Handles btn_unite.Click
        If MessageBox.Show("Êtes-vous certain de vouloir supprimer toutes les unités de mesure?" & vbNewLine & "Cette opération est définitive.",
                          "Supprimer les unités de mesure",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                strRequete = "delete from tbl_unites_mesure"

                gestionBd.InsDelUpd(strRequete)
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Suppression réussie.", cls_animation_operation.Reussie)
            Catch ex As Exception
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de la suppression.", cls_animation_operation.Echec)
            End Try
            PossibleDeSupprimer()
        End If
    End Sub

    'Supprimer les formats.'
    Private Sub btn_format_Click(sender As Object, e As EventArgs) Handles btn_format.Click
        If MessageBox.Show("Êtes-vous certain de vouloir supprimer tous les formats?" & vbNewLine & "Cette opération est définitive.",
                          "Supprimer les formats",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                strRequete = "delete from tbl_formats"

                gestionBd.InsDelUpd(strRequete)
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Suppression réussie.", cls_animation_operation.Reussie)
            Catch ex As Exception
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de la suppression.", cls_animation_operation.Echec)
            End Try
            PossibleDeSupprimer()
        End If
    End Sub

    'Supprimer les catégories.'
    Private Sub btn_categ_Click(sender As Object, e As EventArgs) Handles btn_categorie.Click
        If MessageBox.Show("Êtes-vous certain de vouloir supprimer toutes les catégories?" & vbNewLine & "Cette opération est définitive.",
                          "Supprimer les catégories",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                strRequete = "delete from tbl_categories"

                gestionBd.InsDelUpd(strRequete)
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Suppression réussie.", cls_animation_operation.Reussie)
            Catch ex As Exception
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de la suppression.", cls_animation_operation.Echec)
            End Try
            PossibleDeSupprimer()
        End If
    End Sub

    'Supprimer les emplacements.'
    Private Sub btn_empl_Click(sender As Object, e As EventArgs) Handles btn_empl.Click
        If MessageBox.Show("Êtes-vous certain de vouloir supprimer tous les emplacements?" & vbNewLine & "Cette opération est définitive.",
                          "Supprimer les emplacements",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                strRequete = "delete from tbl_emplacement_inventaire"

                gestionBd.InsDelUpd(strRequete)
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Suppression réussie.", cls_animation_operation.Reussie)
            Catch ex As Exception
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de la suppression.", cls_animation_operation.Echec)
            End Try
            PossibleDeSupprimer()
        End If
    End Sub

    'Supprimer les villes.'
    Private Sub btn_ville_Click(sender As Object, e As EventArgs) Handles btn_ville.Click
        If MessageBox.Show("Êtes-vous certain de vouloir supprimer toutes les villes?" & vbNewLine & "Cette opération est définitive.",
                          "Supprimer les villes",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                strRequete = "delete from tbl_ville"

                gestionBd.InsDelUpd(strRequete)
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Suppression réussie.", cls_animation_operation.Reussie)
            Catch ex As Exception
                animation.Lancement(timer_succes, lbl_ajoutSucces, "Erreur lors de la suppression.", cls_animation_operation.Echec)
            End Try
            PossibleDeSupprimer()
        End If
    End Sub

    'Animation!.'
    Private Sub timer_succes_Tick(sender As Timer, e As EventArgs) Handles timer_succes.Tick
        animation.Operation(sender, lbl_ajoutSucces)
    End Sub

    'Couleur du bouton créer.'
    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btn_admin.MouseEnter, btn_categorie.MouseEnter, btn_cours.MouseEnter, btn_empl.MouseEnter, btn_ensei.MouseEnter, btn_etu.MouseEnter, btn_exercice.MouseEnter, btn_format.MouseEnter, btn_fournisseur.MouseEnter, btn_produit.MouseEnter, btn_unite.MouseEnter, btn_ville.MouseEnter
        sender.BackColor = Color.White
        sender.ForeColor = Color.Black
    End Sub

    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btn_admin.MouseLeave, btn_categorie.MouseLeave, btn_cours.MouseLeave, btn_empl.MouseLeave, btn_ensei.MouseLeave, btn_etu.MouseLeave, btn_exercice.MouseLeave, btn_format.MouseLeave, btn_fournisseur.MouseLeave, btn_produit.MouseLeave, btn_unite.MouseLeave, btn_ville.MouseLeave
        sender.BackColor = Color.FromArgb(52, 73, 94)
        sender.ForeColor = SystemColors.Control
    End Sub
End Class
