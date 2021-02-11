Imports MySql.Data.MySqlClient
''' <summary>
''' Contrôle utilisateur permettant d'afficher les divers changements des taux de taxes.
''' fait par Sébastien Poulain
''' </summary>
''' <tag>2019</tag>
Public Class usr_historique_taxes
    Dim bd As New Connexion
    Dim ds As New DataSet
    Dim da As MySqlDataAdapter
    Private Sub usr_historique_taxes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Charger_DS()
        AjouterPourcentage()
    End Sub
    ''' <summary>
    ''' Méthode qui ajoute au datagridview les données provenant du dataset.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Public Sub RemplirGrid()
        dgv_historique_taxes.Rows.Clear()
        With ds.Tables(0)
            For i As Integer = 0 To .Rows.Count - 1
                dgv_historique_taxes.Rows.Add(.Rows(i).Item(0), .Rows(i).Item(1), .Rows(i).Item(2), .Rows(i).Item(3))
                For j As Integer = 0 To ds.Tables(0).Columns.Count - 1
                    dgv_historique_taxes.Rows(dgv_historique_taxes.Rows.Count - 1).Cells(j).Value = .Rows(i).Item(j)
                Next
            Next
        End With
    End Sub

    ''' <summary>
    ''' Méthode qui ajoute au dataset les données des taxes provenant de la base de données.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Public Sub Charger_DS()
        bd.miseAjourDS(ds, da, "select `id_taxes`,`date_taxe`,`type_taxe`,`pourcentage_taxe` from tbl_taxes", "tbl_taxes")
        RemplirGrid()
        ' Pour la colonne des dates, on affiche les données dans le format suivant.
        dgv_historique_taxes.Columns(1).DefaultCellStyle.Format = "dd-MM-yyyy"
    End Sub

    ''' <summary>
    ''' Méthode qui gère l'événement du clic sur les boutons btn_sauvegarder_taxes et btn_annuler, on change la couleur du texte et du boutton  lorsque la souris entre dans le bouton.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btn_sauvegarder_taxes.MouseEnter, btn_annuler.MouseEnter
        sender.BackColor = Color.White
        sender.ForeColor = Color.Black
    End Sub
    ''' <summary>
    ''' Méthode qui gère l'événement du clic sur les boutons btn_sauvegarder_taxes et btn_annuler, on change la couleur du texte et du boutton  lorsque la souris quitte la zone du bouton.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btn_sauvegarder_taxes.MouseLeave, btn_annuler.MouseLeave
        sender.BackColor = Color.FromArgb(52, 73, 94)
        sender.ForeColor = SystemColors.Control
    End Sub

    ''' <summary>
    ''' Méthode qui gère l'événement du clic sur le bouton btn_annuler, elle ferme le formulaire historique_taxes.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        Me.ParentForm.Close()
    End Sub

    ''' <summary>
    ''' Méthode pour ajouter le signe de % dans le datagridview.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Sub AjouterPourcentage()
        For i As Integer = 0 To dgv_historique_taxes.Rows.Count - 1
            For j As Integer = 3 To 3
                dgv_historique_taxes.Rows(i).Cells(j).Value += " %"
            Next
        Next
    End Sub
    ''' <summary>
    ''' Méthode qui gère l'événement du clic sur le bouton btn_sauvegarder_taxes, elle permet de sauvegarder le contenu du datagridview dans un fichier csv pour conserver les changements de taxes.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub btn_sauvegarder_taxes_Click(sender As Object, e As EventArgs) Handles btn_sauvegarder_taxes.Click
        Dim sfd As New SaveFileDialog()
        ' filtre le type de fichier pour csv.
        sfd.Filter = "CSV|*.csv"
        sfd.RestoreDirectory = True

        If sfd.ShowDialog() = DialogResult.OK Then

            Dim fichier As String = ""
            'On ajoute le titre des colonnes.
            For Each column As DataGridViewColumn In dgv_historique_taxes.Columns
                fichier = fichier & column.HeaderText & ";"
            Next

            fichier = fichier.TrimEnd(";")
            fichier = fichier & vbCr & vbLf
            ' On ajoute les données du datagridview dans fichier.
            For Each row As DataGridViewRow In dgv_historique_taxes.Rows
                For Each cell As DataGridViewCell In row.Cells
                    fichier = fichier & cell.Value & ";"
                Next
                fichier = fichier.TrimEnd(";")
                fichier = fichier & vbCr & vbLf
            Next
            ' On écrit dans le fichier csv le contenu de fichier
            System.IO.File.WriteAllText(sfd.FileName, fichier)

            MessageBox.Show("Exportation Réussie", "Exportation Excel", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.ParentForm.Close()
        End If
    End Sub
End Class
