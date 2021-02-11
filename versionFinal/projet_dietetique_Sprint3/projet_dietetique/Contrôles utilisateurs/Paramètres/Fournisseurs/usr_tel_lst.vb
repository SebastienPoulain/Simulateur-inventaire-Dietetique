' KEVEN ABEL & ZACHARY VEILLETTE

Public Class usr_tel_lst
    Public rangee As Integer
    Dim type As String
    Public numero As String
    Dim poste As String
    Dim usr_fournisseur As usr_gestion_fournisseurs

    Sub New(_rg As Integer, usrP As usr_gestion_fournisseurs)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        rangee = _rg
        usr_fournisseur = usrP
        usr_fournisseur.tel_list.Add(Me)
        Me.Name = "Tlphn" & usr_fournisseur.tel_list.Count - 1
    End Sub

    Sub New(_rg As Integer, _type As String, _num As String, _poste As String, usrP As usr_gestion_fournisseurs)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        rangee = _rg
        type = _type
        numero = _num
        poste = _poste
        usr_fournisseur = usrP

        usr_fournisseur.tel_list.Add(Me)
        Me.Name = "Tlphn" & usr_fournisseur.tel_list.Count - 1

        Afficher_Telephones()
    End Sub

    Sub Afficher_Telephones()
        cbo_type.Text = type
        txt_numero.Text = numero
        txt_poste.Text = poste
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As ComboBox, e As EventArgs) Handles cbo_type.SelectedIndexChanged
        If sender.Text = "Autre (précisez)" Then
            sender.DropDownStyle = ComboBoxStyle.DropDown
        Else
            sender.DropDownStyle = ComboBoxStyle.DropDownList
        End If
    End Sub
    'Bouton ajouter.'
    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        'Crée un autre user pour un nouveau téléphone.'
        Dim usr_tel As New usr_tel_lst(usr_fournisseur.tel_list.Count, usr_fournisseur)

        'Ajouter le user dans le panel.'
        usr_fournisseur.pnl_tel.Controls.Add(usr_tel)

        'Détermine sa position.'
        With usr_fournisseur.tel_list(usr_fournisseur.tel_list.Count - 2)
            usr_tel.Location = New Point(0, .Location.Y + 30)
        End With

        'Fait diparaître le bouton ajouter et fait apparaître le bouton ajouter.'
        btn_ajouter.Visible = False
        btn_suppr.Visible = True

        'Dessant le scroll à son maximum.'
        usr_fournisseur.pnl_tel.VerticalScroll.Value = usr_fournisseur.pnl_tel.VerticalScroll.Maximum
        usr_tel.BringToFront()

    End Sub

    'Bouton supprimer.'
    Private Sub btn_suppr_Click(sender As Object, e As EventArgs) Handles btn_suppr.Click
        usr_fournisseur.pnl_tel.Controls.Clear()

        'Supprime le téléphone de la liste.'
        usr_fournisseur.tel_list.RemoveAt(rangee)

        'Pour replacer la position des téléphones.'
        Dim position As New Point(0, 1)

        'Boucle sur l'ensemble des téléphones.'
        For i As Integer = 0 To usr_fournisseur.tel_list.Count - 1

            'Modifie la rangée avec le nouveau index.'
            usr_fournisseur.tel_list(i).rangee = i
            usr_fournisseur.tel_list(i).Name = "Tlphn" & i
            usr_fournisseur.pnl_tel.Controls.Add(usr_fournisseur.tel_list(i))

            'Modifie la position (commence à 0 et fait +30 à chaque fois).'
            usr_fournisseur.tel_list(i).Location = position
            position.Y += 30

        Next
        'usr_fournisseur.Dernier_Survivant()
        usr_fournisseur.pnl_ajout_mod.Focus()
    End Sub

    Private Sub txt_poste_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_poste.KeyPress
        If Not (48 <= Asc(e.KeyChar) And Asc(e.KeyChar) <= 59) And Not Asc(e.KeyChar) = 8 Then
            e.Handled = True
        End If
    End Sub

    Sub Gerer_Boutons()

    End Sub
End Class
