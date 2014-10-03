Public Class Form1


    Private Sub btnAnswer2_Click(sender As Object, e As EventArgs) Handles btnAnswer2.Click
        Dim strSecretName As String = "Katreena"
        Dim strGuessName As String = Me.txtanswer.Text
        Dim strQuest As String = "seek the holy grail"
        Dim strQuestGuess As String = Me.txtAnswer2.Text
        Dim strColor As String = "Blue"
        Dim strColorGuess As String = Me.txtAnswer3.Text

        If strSecretName = strGuessName And strQuest = strQuestGuess And strColor = strColorGuess Then
            Me.lblAnswer7.Text = "You may cross the bridge."
        Else
            Me.lbl6Answer.Text = "You will die!!!."

        End If

        
    End Sub

End Class

