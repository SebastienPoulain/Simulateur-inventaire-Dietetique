'Utilisation:
'
'Utilise un timer et un label que vous devez ajouté dans votre formulaire/usercontrol.
'
'
'Instancié un objet cls_animation_operation par la suite:
'
'Dim animation as new cls_animation_operation
'
'
'À l'endroit où l'animation doit commencer:
'
'                       TIMER          LABEL                MESSAGE                     TYPE(Par défaut réussie)
'animation.Lancement(timer_succes, lbl_ajoutSucces, "L'utilisateur a été créé.", cls_animation_operation.Reussie)
'
'
'Dans l'event TICK de votre timer:
'
'                    TIMER        LABEL
'animation.Operation(sender, lbl_ajoutSucces)
'

Class cls_animation_operation
    Shared type_reussie As String = "R"
    Shared type_echec As String = "E"

    Dim type_choisi As String

    Shared ReadOnly Property Reussie As String
        Get
            Return type_reussie
        End Get
    End Property

    Shared ReadOnly Property Echec As String
        Get
            Return type_echec
        End Get
    End Property

    'Lance l'animation avec le type réussie par défaut.'
    Public Sub Lancement(tmr As Timer, lbl As Label, text As String)
        tmr.Interval = 1
        lbl.Text = text

        lbl.BackColor = Color.FromArgb(0, 255, 0)
        lbl.Visible = True
        type_choisi = "R"

        tmr.Start()
    End Sub


    'Lance l'animation selon le type sélectionné.'
    Public Sub Lancement(tmr As Timer, lbl As Label, text As String, type As String)
        tmr.Interval = 1
        lbl.Text = text

        Select Case type
            Case "R"
                lbl.BackColor = Color.FromArgb(0, 255, 0)
                type_choisi = "R"
            Case "E"
                lbl.BackColor = Color.FromArgb(255, 0, 0)
                type_choisi = "E"
            Case Else
                lbl.BackColor = Color.FromArgb(0, 255, 0)
                type_choisi = "R"

        End Select
        lbl.Visible = True

        tmr.Start()
    End Sub

#Region "Event timer"

    'À placer dans l'event "Tick" (type par défaut).
    Public Sub Operation(tmr As Timer, lbl As Label)

        Select Case type_choisi
            Case "R"
                Operation_reussie(tmr, lbl)
            Case "E"
                Operation_echec(tmr, lbl)
            Case Else
                Operation_reussie(tmr, lbl)

        End Select
    End Sub
#End Region

#Region "Opérations"
    'Pour une opération réussie. (Vert pétant)'
    Private Sub Operation_reussie(tmr As Timer, lbl As Label)

        If tmr.Interval = 1 Then
            lbl.BackColor = Color.FromArgb(0, lbl.BackColor.G - 2, 0)

            If lbl.BackColor.G < 150 Then
                tmr.Stop()
                tmr.Interval = 5000
                tmr.Start()
            End If
        Else
            tmr.Stop()
            lbl.Visible = False
            lbl.BackColor = Color.FromArgb(0, 255, 0)
            tmr.Interval = 1
        End If
    End Sub

    'Pour une opération non réussie. (Rouge brisant)'
    Private Sub Operation_echec(tmr As Timer, lbl As Label)

        If tmr.Interval = 1 Then
            lbl.BackColor = Color.FromArgb(lbl.BackColor.R - 2, 0, 0)

            If lbl.BackColor.R < 150 Then
                tmr.Stop()
                tmr.Interval = 5000
                tmr.Start()
            End If
        Else
            tmr.Stop()
            lbl.Visible = False
            lbl.BackColor = Color.FromArgb(255, 0, 0)
            tmr.Interval = 1
        End If
    End Sub

#End Region
End Class
