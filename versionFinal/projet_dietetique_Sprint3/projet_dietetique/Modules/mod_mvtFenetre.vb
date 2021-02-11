Module mod_mvtFenetre
    Private mvt As Boolean
    Private sourisX, sourisY As Integer


    Public Sub mouseDown(p_souris As MouseEventArgs)
        If p_souris.Button = MouseButtons.Left Then
            mvt = True
            sourisX = p_souris.X
            sourisY = p_souris.Y
        End If
    End Sub

    Public Sub mouseUp(p_souris As MouseEventArgs)
        If p_souris.Button = MouseButtons.Left Then
            mvt = False
        End If
    End Sub

    Public Sub mouseMove(p_souris As MouseEventArgs, p_frm As Form)
        If mvt Then
            Dim temp As Point = New Point()

            temp.X = p_frm.Location.X + (p_souris.X - sourisX)
            temp.Y = p_frm.Location.Y + (p_souris.Y - sourisY)
            p_frm.Location = temp
            temp = Nothing
        End If
    End Sub
End Module
