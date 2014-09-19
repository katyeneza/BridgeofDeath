Public Class Form1



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click
        Dim strSecretName As String = "Katreena"
        Dim strGuessName As String = Me.txtanswer.Text
        Dim strQuest As String = "seek the holy grail"
        Dim strQuestGuess As String = Me.txtAnswer2.Text
        Dim strColor As String = "Blue"
        Dim strColorGuess As String = Me.txtAnswer3.Text

        If strSecretName = strGuessName Then
            Me.Label2.Text = "You may move on."
        ElseIf strSecretName <> strGuessName Then
            Me.lbl6Answer.Text = "You will die."

        End If

        If strQuest = strQuestGuess Then
            Me.lbl4Answer.Text = "You may answer the last question."
        ElseIf strQuest <> strQuestGuess Then
            Me.lbl6Answer.Text = "You will die."
        End If

        If strColor = strColorGuess Then
            Me.Label5.Text = " You may cross the bridge."
        ElseIf strColor <> strColorGuess Then
            Me.lbl6Answer.Text = "You will die."
        End If

    End Sub


End Class

