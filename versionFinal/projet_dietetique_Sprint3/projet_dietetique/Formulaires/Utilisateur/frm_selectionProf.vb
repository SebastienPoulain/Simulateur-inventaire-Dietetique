Imports MySql.Data.MySqlClient

Public Class frm_selectionProf
    'Attributs reliés à la gestion de la bd.'
    Dim strRequete As String
    Dim table As String
    Dim gestionBd As New Connexion
    Dim dataAdapter As New MySqlDataAdapter
    Dim dsCours As DataSet
    Dim dsUtls As DataSet

    Dim prof As String
    Dim profs As String()

    Property Professeur As String
        Set(value As String)
            prof = value
        End Set
        Get
            Return prof
        End Get
    End Property

    Property Professeurs As String()
        Set(value As String())
            profs = value
        End Set
        Get
            Return profs
        End Get
    End Property


    Private Sub frm_selectionProf_Load(sender As Object, e As EventArgs) Handles Me.Load
        Cursor = Cursors.AppStarting
        RecupererProf()
        RemplirProf()
        Cursor = Cursors.Default
    End Sub

    Private Sub btn_selectProf_Click(sender As Object, e As EventArgs) Handles btn_selectProf.Click
        Dim liste As DataGridViewSelectedRowCollection = grid_prof.SelectedRows
        Dim a As Integer = 0
        For Each ligne As DataGridViewRow In liste


            a += 1
        Next

        ReDim profs(a)

        Dim i As Integer = 0

        For Each ligne As DataGridViewRow In liste

            profs(i) = ligne.Cells(0).Value
            i += 1
        Next

        Me.Close()
    End Sub

    Private Sub btn_annulerProf_Click(sender As Object, e As EventArgs) Handles btn_annulerProf.Click
        prof = ""
        Me.Close()
    End Sub

    Private Sub RecupererProf()
        strRequete = "Select `no_utilisateur`, concat(`prenom_personne`,concat(', ',`nom_personne`)) as nom from `tbl_utilisateurs` where `titre`= 'p';"
        table = "tbl_utilisateurs"
        gestionBd.miseAjourDS(dsUtls, dataAdapter, strRequete, table)
    End Sub


    Private Sub RemplirProf()
        grid_prof.Rows.Clear()
        With dsUtls.Tables(0)
            For i As Integer = 0 To .Rows.Count - 1
                grid_prof.Rows.Add(.Rows(i).Item(0))
                grid_prof.Rows(grid_prof.Rows.Count - 1).Cells(1).Value = .Rows(i).Item(1)
            Next
        End With
    End Sub

#Region "Autres"
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click, btn_annulerProf.Click
        Me.Close()
    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles pnl_navigation.MouseDown, lbl_titre.MouseDown
        mod_mvtFenetre.mouseDown(e)
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles pnl_navigation.MouseMove, lbl_titre.MouseMove
        mod_mvtFenetre.mouseMove(e, Me)
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles pnl_navigation.MouseUp, lbl_titre.MouseUp
        mod_mvtFenetre.mouseUp(e)
    End Sub

    'Couleur des boutons.'
    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btn_selectProf.MouseEnter, btn_annulerProf.MouseEnter
        sender.BackColor = Color.White
        sender.ForeColor = Color.Black
    End Sub

    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btn_selectProf.MouseLeave, btn_annulerProf.MouseLeave
        If sender.Text = btn_annulerProf.Text Then
            sender.BackColor = Color.DimGray
            sender.ForeColor = SystemColors.Control
        Else
            sender.BackColor = Color.FromArgb(52, 73, 94)
            sender.ForeColor = SystemColors.Control
        End If
    End Sub

    'Change la couleur quand on passe la souris sur le grid_cours.'
    Private Sub grid_cours_CellMouseLeave(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_prof.CellMouseLeave
        If e.RowIndex > -1 Then
            grid_prof.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
            grid_prof.Rows(e.RowIndex).DefaultCellStyle.ForeColor = DefaultForeColor
        End If
    End Sub

    'Change la couleur quand on passe la souris sur le grid_cours.'
    Private Sub grid_cours_CellMouseEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_prof.CellMouseEnter
        If e.RowIndex > -1 Then
            grid_prof.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(236, 240, 241)
        End If
    End Sub

    Private Sub grid_prof_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_prof.CellContentClick
        grid_prof.MultiSelect = True
    End Sub

#End Region
End Class