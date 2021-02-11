Imports MySql.Data.MySqlClient

Public Class usr_nouveau_mdp
    Dim strRequete As String
    Dim table As String
    Dim gestionBd As New Connexion
    Dim dataAdapter As New MySqlDataAdapter
    Dim dsUtls As DataSet
    Dim _list_utls As List(Of Utilisateur)

    Public Sub New(list_utls As List(Of Utilisateur))

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        _list_utls = list_utls

        GenererNvMdp()
    End Sub

    ''' <summary>
    ''' Méthode qui génère un nouveau mot de passe pour chacun des utilisateurs, et l'update dans la bd, le mot de passe est crypté avant l'insertiton dans la bd.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub GenererNvMdp()
        Cursor.Current = Cursors.AppStarting
        grid_utls.Rows.Clear()

        For i As Integer = 0 To _list_utls.Count - 1
            _list_utls(i).Mot_de_passe = mod_function_utls.GenererMdp


            strRequete = "UPDATE `tbl_utilisateurs` SET `mot_de_passe` = '" & GetMd5Hash(_list_utls(i).Mot_de_passe) &
            "' WHERE `no_utilisateur` = '" & _list_utls(i).No_id & "';"

            Try
                gestionBd.InsDelUpd(strRequete)
            Catch ex As Exception
            End Try
        Next
        RemplirGrid()

        Cursor.Current = Cursors.Default
    End Sub


    'Remplis le grid avec les utilisateurs de la liste.'
    Private Sub RemplirGrid()
        grid_utls.Rows.Clear()
        Cursor.Current = Cursors.AppStarting
        For i As Integer = _list_utls.Count - 1 To 0 Step -1
            grid_utls.Rows.Add(_list_utls(i).No_id)
            grid_utls.Rows(grid_utls.Rows.Count - 1).Cells(1).Value = _list_utls(i).Prenom_personne
            grid_utls.Rows(grid_utls.Rows.Count - 1).Cells(2).Value = _list_utls(i).Nom_personne
            grid_utls.Rows(grid_utls.Rows.Count - 1).Cells(3).Value = _list_utls(i).TitreLong
            grid_utls.Rows(grid_utls.Rows.Count - 1).Cells(4).Value = _list_utls(i).Mot_de_passe
        Next
        Cursor.Current = Cursors.Default
    End Sub

    'Bouton retour.'
    Private Sub btn_retour_Click(sender As Object, e As EventArgs) Handles btn_retour.Click
        Me.Hide()
    End Sub

    'Ouverture avec Excel.'
    Private Sub btn_excel_Click(sender As Object, e As EventArgs) Handles btn_excel.Click
        Cursor.Current = Cursors.AppStarting
        mod_grid_Excel.LancerExcel(grid_utls)
        Cursor.Current = Cursors.Default
    End Sub

#Region "Autres"
    'Change la couleur quand on passe la souris sur le grid_cours.'
    Private Sub grid_utls_CellMouseLeave(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
        If e.RowIndex > -1 Then
            grid_utls.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
            grid_utls.Rows(e.RowIndex).DefaultCellStyle.ForeColor = DefaultForeColor
        End If
    End Sub

    'Change la couleur quand on passe la souris sur le grid_cours.'
    Private Sub grid_utls_CellMouseEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
        If e.RowIndex > -1 Then
            grid_utls.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(236, 240, 241)
        End If
    End Sub

    'Couleur des boutons.'
    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btn_excel.MouseEnter, btn_retour.MouseEnter
        sender.BackColor = Color.White
        sender.ForeColor = Color.Black
    End Sub

    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btn_excel.MouseLeave, btn_retour.MouseLeave
        If sender.Text = btn_excel.Text Then
            sender.BackColor = Color.FromArgb(63, 124, 63)
            sender.ForeColor = SystemColors.Control
        Else
            sender.BackColor = Color.FromArgb(52, 73, 94)
            sender.ForeColor = SystemColors.Control
        End If
    End Sub

    Private Sub grid_utls_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_utls.CellContentClick

    End Sub

#End Region
End Class
