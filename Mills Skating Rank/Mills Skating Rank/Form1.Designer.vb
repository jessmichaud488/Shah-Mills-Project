<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstScoresBox = New System.Windows.Forms.ListBox()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.btnRecordScore = New System.Windows.Forms.Button()
        Me.btnNextSkater = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpScores = New System.Windows.Forms.GroupBox()
        Me.lblAverageScores = New System.Windows.Forms.Label()
        Me.lblNumberOfScores = New System.Windows.Forms.Label()
        Me.lblTotalScore = New System.Windows.Forms.Label()
        Me.lblAvgScoreTxt = New System.Windows.Forms.Label()
        Me.lblNumScoresTxt = New System.Windows.Forms.Label()
        Me.lblTotalScoreTxt = New System.Windows.Forms.Label()
        Me.grpScores.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstScoresBox
        '
        Me.lstScoresBox.FormattingEnabled = True
        Me.lstScoresBox.Location = New System.Drawing.Point(26, 87)
        Me.lstScoresBox.Name = "lstScoresBox"
        Me.lstScoresBox.Size = New System.Drawing.Size(47, 238)
        Me.lstScoresBox.TabIndex = 1
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(26, 62)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(38, 13)
        Me.lblScore.TabIndex = 1
        Me.lblScore.Text = "&Score:"
        '
        'btnRecordScore
        '
        Me.btnRecordScore.Location = New System.Drawing.Point(98, 62)
        Me.btnRecordScore.Name = "btnRecordScore"
        Me.btnRecordScore.Size = New System.Drawing.Size(94, 23)
        Me.btnRecordScore.TabIndex = 2
        Me.btnRecordScore.Text = "&Record Score"
        Me.btnRecordScore.UseVisualStyleBackColor = True
        '
        'btnNextSkater
        '
        Me.btnNextSkater.Location = New System.Drawing.Point(212, 62)
        Me.btnNextSkater.Name = "btnNextSkater"
        Me.btnNextSkater.Size = New System.Drawing.Size(94, 23)
        Me.btnNextSkater.TabIndex = 3
        Me.btnNextSkater.Text = "&Next Skater"
        Me.btnNextSkater.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(326, 62)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpScores
        '
        Me.grpScores.Controls.Add(Me.lblAverageScores)
        Me.grpScores.Controls.Add(Me.lblNumberOfScores)
        Me.grpScores.Controls.Add(Me.lblTotalScore)
        Me.grpScores.Controls.Add(Me.lblAvgScoreTxt)
        Me.grpScores.Controls.Add(Me.lblNumScoresTxt)
        Me.grpScores.Controls.Add(Me.lblTotalScoreTxt)
        Me.grpScores.Location = New System.Drawing.Point(98, 136)
        Me.grpScores.Name = "grpScores"
        Me.grpScores.Size = New System.Drawing.Size(162, 187)
        Me.grpScores.TabIndex = 5
        Me.grpScores.TabStop = False
        '
        'lblAverageScores
        '
        Me.lblAverageScores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAverageScores.Location = New System.Drawing.Point(3, 151)
        Me.lblAverageScores.Name = "lblAverageScores"
        Me.lblAverageScores.Size = New System.Drawing.Size(100, 23)
        Me.lblAverageScores.TabIndex = 5
        '
        'lblNumberOfScores
        '
        Me.lblNumberOfScores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumberOfScores.Location = New System.Drawing.Point(3, 95)
        Me.lblNumberOfScores.Name = "lblNumberOfScores"
        Me.lblNumberOfScores.Size = New System.Drawing.Size(100, 23)
        Me.lblNumberOfScores.TabIndex = 3
        '
        'lblTotalScore
        '
        Me.lblTotalScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalScore.Location = New System.Drawing.Point(3, 39)
        Me.lblTotalScore.Name = "lblTotalScore"
        Me.lblTotalScore.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalScore.TabIndex = 1
        '
        'lblAvgScoreTxt
        '
        Me.lblAvgScoreTxt.AutoSize = True
        Me.lblAvgScoreTxt.Location = New System.Drawing.Point(3, 128)
        Me.lblAvgScoreTxt.Name = "lblAvgScoreTxt"
        Me.lblAvgScoreTxt.Size = New System.Drawing.Size(81, 13)
        Me.lblAvgScoreTxt.TabIndex = 4
        Me.lblAvgScoreTxt.Text = "Average Score:"
        '
        'lblNumScoresTxt
        '
        Me.lblNumScoresTxt.AutoSize = True
        Me.lblNumScoresTxt.Location = New System.Drawing.Point(3, 72)
        Me.lblNumScoresTxt.Name = "lblNumScoresTxt"
        Me.lblNumScoresTxt.Size = New System.Drawing.Size(95, 13)
        Me.lblNumScoresTxt.TabIndex = 2
        Me.lblNumScoresTxt.Text = "Number of Scores:"
        '
        'lblTotalScoreTxt
        '
        Me.lblTotalScoreTxt.AutoSize = True
        Me.lblTotalScoreTxt.Location = New System.Drawing.Point(3, 16)
        Me.lblTotalScoreTxt.Name = "lblTotalScoreTxt"
        Me.lblTotalScoreTxt.Size = New System.Drawing.Size(68, 13)
        Me.lblTotalScoreTxt.TabIndex = 0
        Me.lblTotalScoreTxt.Text = "Total Score: "
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grpScores)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNextSkater)
        Me.Controls.Add(Me.btnRecordScore)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lstScoresBox)
        Me.Name = "frmMain"
        Me.Text = "Mills Skating Rink"
        Me.grpScores.ResumeLayout(False)
        Me.grpScores.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstScoresBox As ListBox
    Friend WithEvents lblScore As Label
    Friend WithEvents btnRecordScore As Button
    Friend WithEvents btnNextSkater As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents grpScores As GroupBox
    Friend WithEvents lblAverageScores As Label
    Friend WithEvents lblNumberOfScores As Label
    Friend WithEvents lblTotalScore As Label
    Friend WithEvents lblAvgScoreTxt As Label
    Friend WithEvents lblNumScoresTxt As Label
    Friend WithEvents lblTotalScoreTxt As Label
End Class
