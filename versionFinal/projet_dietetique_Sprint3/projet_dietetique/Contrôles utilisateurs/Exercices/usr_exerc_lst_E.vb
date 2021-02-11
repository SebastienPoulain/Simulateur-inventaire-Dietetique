Imports MySql.Data.MySqlClient

Public Class usr_exerc_lst_E
    Dim no As Integer
    Dim _no_ex As Integer
    Dim activer As Boolean
    Dim nom As String
    Dim _uc As usr_exercices_E
    Dim dateR As Date

    ReadOnly Property Numero As Integer
        Get
            Return _no_ex
        End Get
    End Property


    Public Sub New(no_ex As Integer, nm_ex As String, desc As String, statut As Boolean, numero As Integer, dateR_ex As String, uc As usr_exercices_E)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        _no_ex = no_ex
        nom = nm_ex
        lbl_nom.Text = numero & "-" & nm_ex
        lbl_description.Text = desc
        activer = statut
        no = numero
        _uc = uc
        'date rajoutée par Albert, dans le constructeur aussi
        dateR = dateR_ex
        Lbl_Date_remise.Text = dateR
    End Sub

    'Bouton sélectionner.'
    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click

        If _no_ex <> _uc.frmP.ExercSelectionne And _uc.frmP.ExercSelectionne <> 0 Then
            If MessageBox.Show("Êtes-vous certain de vouloir changer d'exercice?" & vbNewLine & "Votre commande non confirmée ne sera pas enregistrée.", "Changer d'exercice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                _uc.frmP.RechargerExercice()
                _uc.Selection = _no_ex
                changer_couleur_selection()

                _uc.majExercice()
            End If
        Else
            _uc.frmP.RechargerExercice()
            _uc.Selection = _no_ex
            changer_couleur_selection()

            _uc.majExercice()
        End If
    End Sub

    'Couleur quand sélectionné.'
    Public Sub changer_couleur_selection()
        pnl_principal.BackColor = Color.FromArgb(52, 73, 94)
        lbl_nom.ForeColor = Color.White
        lbl_description.ForeColor = SystemColors.Control
        btn_select.Visible = False
    End Sub

    'Couleur par défaut.'
    Public Sub changer_couleur_defaut()
        pnl_principal.BackColor = Color.DarkSeaGreen
        lbl_nom.ForeColor = SystemColors.ActiveCaptionText
        lbl_description.ForeColor = Color.DimGray

        btn_select.Visible = True
    End Sub



    Private Sub btn_MouseEnter(sender As Button, e As EventArgs) Handles btn_select.MouseEnter
        sender.BackColor = Color.White
        sender.ForeColor = Color.Black
    End Sub
    Private Sub btn_MouseLeave(sender As Button, e As EventArgs) Handles btn_select.MouseLeave
        sender.BackColor = Color.FromArgb(52, 73, 94)
        sender.ForeColor = SystemColors.Control
    End Sub

    Private Sub btn_MouseEnter(sender As Object, e As EventArgs) Handles btn_select.MouseEnter

    End Sub

    Private Sub btn_MouseLeave(sender As Object, e As EventArgs) Handles btn_select.MouseLeave

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl_date_remise.Click

    End Sub
    'Travaux remis en retard par Albert
    Private Sub pnl_principal_Paint(sender As Object, e As PaintEventArgs) Handles pnl_principal.Paint
        If dateR <= System.DateTime.Now Then

            pnl_principal.BackColor = Color.Red
            lbl_nom.ForeColor = Color.White
            lbl_description.ForeColor = SystemColors.Control
            btn_select.Enabled = False

        ElseIf dateR.Year <= System.DateTime.Now.Year And dateR.Month < System.DateTime.Now.Month Then
            pnl_principal.BackColor = Color.Red
            lbl_nom.ForeColor = Color.White
            lbl_description.ForeColor = SystemColors.Control
        End If
    End Sub

    Private Sub lbl_description_Click(sender As Object, e As EventArgs) Handles lbl_description.Click

    End Sub
End Class
