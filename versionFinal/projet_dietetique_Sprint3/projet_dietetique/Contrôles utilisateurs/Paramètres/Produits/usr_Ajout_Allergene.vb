Imports MySql.Data.MySqlClient
''' <summary>
''' Contrôle utilisateur qui permet l'ajout d'un nouvel allergène.
''' fait par Sébastien Poulain
''' </summary>
''' <tag>2019</tag>
Public Class usr_ajout_allergene
    Dim bd As New Connexion
    Dim requete As String
    Dim animation As New cls_animation_operation
    Dim requeteAllergene As String

    ''' <summary>
    ''' Méthode qui gère l'événement du clic sur le bouton btn_annuler, elle ferme le formulaire ajoutProduit.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        ' On ferme le formulaire
        Me.ParentForm.Close()
    End Sub

    ''' <summary>
    ''' Méthode qui gère l'événement du clic sur le bouton btn_ajouter_allergene,  elle fait les vérifications et ajoute l'allergène dans la base de données.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_ajouter_allergene.Click

        If Trim(txt_allergene.Text) <> "" And Est_Allergene(Trim(txt_allergene.Text)) And Not AllergeneExiste(Trim(txt_allergene.Text)) Then

            ' On insert l'allergène dans la base de données,car le texte n'est pas vide et il correspond au régex définissant un allergene
            requete = "INSERT INTO tbl_allergenes (`nom_allergene`) VALUES ('" & UppercaseFirstLetter(Trim(txt_allergene.Text)) & "')"

            bd.InsDelUpd(requete)

            animation.Lancement(timer_succes, lbl_succes, UppercaseFirstLetter(Trim(txt_allergene.Text)) & " a bien été ajouté à la liste des allergènes.", cls_animation_operation.Reussie)

            Vider_Textbox()

            ' On demande si on veut ajouter un autre allergène
            Dim result = MessageBox.Show("Voulez-vous ajouter un autre allergène ?", "Ajout d'un autre allergène", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.No Then
                Me.ParentForm.Close()
            Else
                Focus_Textbox()
                Vider_Textbox()
            End If
        ElseIf Trim(txt_allergene.Text) = "" Then
            Position_Label_Erreur()
            ' On affiche pendant 5 secondes le message d'erreur à l'aide d'un timer
            animation.Lancement(timer_allergene, lbl_erreur_allergene, "Vous devez entrer un nom d'allergène.", cls_animation_operation.Echec)
            Focus_Textbox()
        ElseIf AllergeneExiste(UppercaseFirstLetter(Trim(txt_allergene.Text))) Then
            Position_Label_Erreur()
            Vider_Textbox()
            animation.Lancement(timer_allergene, lbl_erreur_allergene, "L'allergène existe déjà.", cls_animation_operation.Echec)
            Focus_Textbox()
        ElseIf Not Est_Allergene(Trim(txt_allergene.Text)) Then
            Position_Label_Erreur()
            Vider_Textbox()
            animation.Lancement(timer_allergene, lbl_erreur_allergene, "Le nom de l'allergène  doit contenir que des lettres ", cls_animation_operation.Echec)
            Focus_Textbox()
        End If
    End Sub

    Private Sub usr_ajout_allergene_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Focus_Textbox()
    End Sub
    ''' <summary>
    ''' Méthode qui gère l'événement du clic sur les boutons btn_ajouter_allergene et btn_annuler, on change la couleur du texte et du boutton  lorsque la souris entre dans le bouton.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btn_ajouter_allergene.MouseEnter, btn_annuler.MouseEnter
        sender.BackColor = Color.White
        sender.ForeColor = Color.Black
    End Sub
    ''' <summary>
    ''' Méthode qui gère l'événement du clic sur les boutons btn_ajouter_allergene et btn_annuler, on change la couleur du texte et du boutton  lorsque la souris quitte la zone du bouton.
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btn_ajouter_allergene.MouseLeave, btn_annuler.MouseLeave
        sender.BackColor = Color.FromArgb(52, 73, 94)
        sender.ForeColor = SystemColors.Control
    End Sub

    ''' <summary>
    ''' Méthode qui gère l'événement du tick pour le timer timer_allergene
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub timer_Allergene_Tick(sender As Object, e As EventArgs) Handles timer_allergene.Tick
        animation.Operation(sender, lbl_erreur_allergene)
    End Sub
    ''' <summary>
    ''' Méthode qui gère l'événement du tick pour le timer timer_succes
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Private Sub timer_Allergene2_Tick(sender As Object, e As EventArgs) Handles timer_succes.Tick
        animation.Operation(sender, lbl_succes)
    End Sub

    ''' <summary>
    ''' Méthode qui change la position du label en fonction du type d'erreur
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Sub Position_Label_Erreur()
        If txt_allergene.Text = "" Then
            lbl_erreur_allergene.Location = New Point(265, 162)
        ElseIf AllergeneExiste(txt_allergene.Text) Then
            lbl_erreur_allergene.Location = New Point(290, 162)
        Else
            lbl_erreur_allergene.Location = New Point(150, 162)
        End If
    End Sub
    ''' <summary>
    ''' Méthode qui vide la textbox txt_allergene
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Sub Vider_Textbox()
        txt_allergene.Clear()
    End Sub

    ''' <summary>
    ''' Méthode met le focus sur la textbox txt_allergene
    ''' fait par Sébastien Poulain
    ''' </summary>
    ''' <tag>2019</tag>
    Sub Focus_Textbox()
        Me.Show()
        txt_allergene.Select()
    End Sub
    ''' <summary>
    ''' Fonction qui vérifie si l'allergène existe déjà dans la base de données.
    ''' </summary>
    ''' <param name="allergene"></param>
    ''' <returns></returns>
    ''' retourne true si l'allergène existe déjà dans la bd et false sinon.
    ''' <tag>2019</tag>
    Private Function AllergeneExiste(allergene As String) As Boolean

        Dim existe As Boolean = False

        requeteAllergene = "SELECT COUNT(*) FROM `tbl_allergenes` WHERE `nom_allergene` = @allergene"

        Using xConn As New MySqlConnection("Server=localhost; DataBase=simulateur_inventaire; Uid=root; Pwd=")
            Using xComm As New MySqlCommand()
                With xComm
                    .Connection = xConn
                    .CommandText = requeteAllergene
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@allergene", txt_allergene.Text)
                End With
                Try
                    xConn.Open()
                    If CInt(xComm.ExecuteScalar()) > 0 Then
                        existe = True
                    End If
                Catch ex As MySqlException
                    MsgBox(ex.Message)
                    existe = False
                Finally
                    xConn.Close()
                End Try
            End Using
        End Using
        Return existe
    End Function
End Class
