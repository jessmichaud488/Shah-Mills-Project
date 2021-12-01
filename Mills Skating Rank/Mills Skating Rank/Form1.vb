Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For scores As Integer = 0 To 10
            lstScoresBox.Items.Add(scores.ToString)
        Next scores
        lstScoresBox.SelectedIndex = 0
    End Sub

    Private Sub btnRecordScore_Click(sender As Object, e As EventArgs) Handles btnRecordScore.Click
        Dim currentScore, totalScore As Integer
        Dim averageScore As Decimal
        Static numberOfScores As Integer

        currentScore = lstScoresBox.SelectedIndex
        totalScore = currentScore + lstScoresBox.SelectedIndex

        numberOfScores += 1
        averageScore = totalScore / numberOfScores

        lblTotalScore.Text = totalScore.ToString
        lblNumberOfScores.Text = numberOfScores.ToString("n0")
        lblAverageScores.Text = averageScore.ToString
    End Sub

    Private Sub btnNextSkater_Click(sender As Object, e As EventArgs) Handles btnNextSkater.Click
        lblTotalScore.Text = String.Empty
        lblNumberOfScores.Text = String.Empty
        lblAverageScores.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
