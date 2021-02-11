Module mod_mvt_gestion
    Public Sub changer_position(ByVal sender As Button, ByRef position As Integer, max As Integer, ByRef tabBtn As Button())
        Select Case sender.Text
            Case "<<"
                position = 0
                tabBtn(0).Enabled = False
                tabBtn(1).Enabled = False
                If max > 0 Then
                    tabBtn(2).Enabled = True
                    tabBtn(3).Enabled = True
                End If
            Case "<"
                If position > 0 Then
                    position -= 1
                    tabBtn(0).Enabled = True
                    tabBtn(1).Enabled = True
                    tabBtn(2).Enabled = True
                    tabBtn(3).Enabled = True
                    If position = 0 Then
                        tabBtn(0).Enabled = False
                        tabBtn(1).Enabled = False
                    End If
                End If
            Case ">"
                If position < max - 1 Then
                    position += 1
                    tabBtn(0).Enabled = True
                    tabBtn(1).Enabled = True
                    tabBtn(2).Enabled = True
                    tabBtn(3).Enabled = True
                    If position = max - 1 Then
                        tabBtn(2).Enabled = False
                        tabBtn(3).Enabled = False
                    End If
                End If

            Case ">>"
                position = max - 1
                tabBtn(2).Enabled = False
                tabBtn(3).Enabled = False
                If position <> 0 Then
                    tabBtn(0).Enabled = True
                    tabBtn(1).Enabled = True
                End If
        End Select
    End Sub
End Module
