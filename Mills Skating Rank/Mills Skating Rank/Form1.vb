Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For intScores As Integer = 0 To 10
        lstScoresBox.Items.Add(intScores.ToString)
    Next intScores
        lstScoresBox.SelectedIndex = 0
    End Sub

    Private Sub btnRecordScore_Click(sender As Object, e As EventArgs) Handles btnRecordScore.Click
    Dim intCurrentScore, intTotalScore As Integer
    Dim decAverageScore As Decimal
    Static intNumberOfScores As Integer

    intCurrentScore = lstScoresBox.SelectedIndex
    intTotalScore = intCurrentScore + lstScoresBox.SelectedIndex

    intNumberOfScores += 1
    decAverageScore = intTotalScore / intNumberOfScores

    lblTotalScore.Text = intTotalScore.ToString
    lblNumberOfScores.Text = intNumberOfScores.ToString("n0")
    lblAverageScores.Text = decAverageScore.ToString
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
