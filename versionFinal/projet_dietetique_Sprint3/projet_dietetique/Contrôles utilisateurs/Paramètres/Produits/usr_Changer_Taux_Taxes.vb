''' <summary>
''' Contrôle utilisateur permettant de changer le taux des taxes.
''' fait par Sébastien Poulain
''' </summary>
''' <tag>2019</tag>
Public Class usr_Changer_Taux_Taxes
    Dim bd As New Connexion
    Dim requeteTPS, requeteTVQ, tps, tvq, tpsDebut, tvqDebut As String
    Private Sub usr_Changer_Taux_Taxes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' On prend dans la base de données la valeur la plus récente pour la taxe tps et tvq et on le met comme valeur par défaut pour les deux numericupdown.
        requeteTPS = "select `pourcentage_taxe` from `tbl_taxes` where `type_taxe` = 'TPS' and `date_taxe` = (select max(`date_taxe`) from tbl_taxes where type_taxe = 'TPS' group by `type_taxe`) and `id_taxes` = (select max(`id_taxes`) from tbl_taxes where type_taxe = 'TPS' group by `type_taxe`)"
        requeteTVQ = "select `pourcentage_taxe` from `tbl_taxes` where `type_taxe` = 'TVQ'and `date_taxe` = (select max(`date_taxe`) from tbl_taxes where type_taxe = 'TVQ' group by `type_taxe`) and `id_taxes` = (select max(`id_taxes`) from tbl_taxes where type_taxe = 'TVQ' group by `type_taxe`)"
        NumericUpDownTPS.Value = bd.Requete2(requeteTPS)
        NumericUpDownTVQ.Value = bd.Requete2(requeteTVQ)
        tpsDebut = NumericUpDownTPS.Value
        tvqDebut = NumericUpDownTVQ.Value
    End Sub
    ''' <summary>
    ''' Méthode qui gère l'événement du clic sur le bouton btn_annuler, elle ferme le formulaire changer_taux_taxes.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        Me.ParentForm.Close()
    End Sub

    ''' <summary>
    ''' Méthode qui gère l'événement du clic sur les boutons btn_modifier et btn_annuler, on change la couleur du texte et du boutton  lorsque la souris entre dans le bouton.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btn_modifier.MouseEnter, btn_annuler.MouseEnter
        sender.BackColor = Color.White
        sender.ForeColor = Color.Black
    End Sub
    ''' <summary>
    ''' Méthode qui gère l'événement du clic sur les boutons btn_modifier et btn_annuler, on change la couleur du texte et du boutton  lorsque la souris quitte la zone du bouton.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btn_modifier.MouseLeave, btn_annuler.MouseLeave
        sender.BackColor = Color.FromArgb(52, 73, 94)
        sender.ForeColor = SystemColors.Control
    End Sub
    ''' <summary>
    ''' Méthode qui gère l'événement du clic sur le bouton btn_modifier, elle vérifie si les taux sont valides et modifie ceux-ci.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub btn_modifier_Click(sender As Object, e As EventArgs) Handles btn_modifier.Click

        Dim taxeTVQ = "TVQ", taxeTPS As String = "TPS"
        Dim dateDuJour As Date = System.DateTime.Today

        ' Si on ne change pas les taux qui sont par défaut, on ne peut pas modifier les taux, car ce sont les mêmes taux.
        If tpsDebut = NumericUpDownTPS.Value And tvqDebut = NumericUpDownTVQ.Value Then
            MessageBox.Show("Vous ne pouvez pas modifier les taux, car les taux sont inchangés.", "Erreur taux inchangés", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf NumericUpDownTPS.Value = 0 Or NumericUpDownTVQ.Value = 0 Then
            MessageBox.Show("Vous ne pouvez pas avoir un taux à inférieur ou égal à 0.", "Erreur taux zero", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not Taux_Taxes_Ok(NumericUpDownTPS.Value) Or Not Taux_Taxes_Ok(NumericUpDownTVQ.Value) Then
            MessageBox.Show("Nombre non valide, doit être un nombre entre 0 et 100 avec maximum 3 décimales", "Erreur nombre", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf NumericUpDownTPS.Value = 100 Or NumericUpDownTVQ.Value = 100 Then
            MessageBox.Show("Vous ne pouvez pas avoir un taux supérieur ou égal à 100.", "Erreur taux supérieur à 100", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim result = MessageBox.Show("Êtes-vous certain de vouloir modifier les taux des taxes", "Confirmation changement TPS et TVQ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            'On ajoute le changement dans la base de données si il confirme qu'il veut faire la modification.
            If result = DialogResult.Yes Then
                tps = NumericUpDownTPS.Value
                tvq = NumericUpDownTVQ.Value

                requeteTPS = "INSERT INTO tbl_taxes (`date_taxe`,`type_taxe`,`pourcentage_taxe`) VALUES ('" & dateDuJour & "','" & taxeTPS & "','" & tps & "')"
                requeteTVQ = "INSERT INTO tbl_taxes (`date_taxe`,`type_taxe`,`pourcentage_taxe`) VALUES ('" & dateDuJour & "','" & taxeTVQ & "','" & tvq & "')"
                bd.InsDelUpd(requeteTPS)
                bd.InsDelUpd(requeteTVQ)
                MessageBox.Show("Taux de TPS et TVQ modifiés", "Taux changés", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.ParentForm.Close()
            Else
                ' On remet la valeur par défaut si il ne veut pas effectuer de modification.
                NumericUpDownTPS.Value = tpsDebut
                NumericUpDownTVQ.Value = tvqDebut
            End If
        End If
    End Sub
End Class
