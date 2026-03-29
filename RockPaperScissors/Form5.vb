Imports System.ComponentModel

Public Class Form5
    Private Sub btnShoot_Click(sender As Object, e As EventArgs) Handles btnShoot.Click
        Dim rnd As New Random
        Dim num As String
        Dim winChance As New Random
        Dim win As Integer
        Dim aiPick As String
        Dim playerPick As String
        Dim playerScore As Integer = 0
        Dim AiScore As Integer = 0

        num = rnd.Next(1, 4)
        If num = 1 Then
            aiPick = "Rock"
            picRPSai.BackgroundImage = My.Resources.rock_removebg_preview__1____Copy___Copy
        ElseIf num = 2 Then
            aiPick = "Paper"
            picRPSai.BackgroundImage = My.Resources.Paper_removebg_preview___Copy___Copy
        ElseIf num = 3 Then
            aiPick = "Scissors"
            picRPSai.BackgroundImage = My.Resources.sissors_removebg_preview___Copy___Copy
        End If

        If optRock.Checked Then
            playerPick = "Rock"
            picRPSyou.BackgroundImage = My.Resources.rock_removebg_preview__1____Copy
        ElseIf optScissors.Checked Then
            playerPick = "Scissors"
            picRPSyou.BackgroundImage = My.Resources.sissors_removebg_preview___Copy
        ElseIf optPaper.Checked Then
            playerPick = "Paper"
            picRPSyou.BackgroundImage = My.Resources.Paper_removebg_preview___Copy

        End If

        'Chance NOT DONE
        win = winChance.Next(1, 11)
        If playerPick = "Paper" Then

            If win = 1 Then
                aiPick = "Rock"
            ElseIf win = 2 Then
                aiPick = "Paper"
            ElseIf win = 3 Or 4 Or 5 Or 6 Or 7 Or 8 Or 9 Then
                aiPick = "Scissors"
            End If

        ElseIf playerPick = "Rock" Then

            If win = 1 Then
                aiPick = "Rock"
            ElseIf win = 2 Then
                aiPick = "Scissors"
            ElseIf win = 3 Or 4 Or 5 Or 6 Or 7 Or 8 Or 9 Then
                aiPick = "Paper"
            End If

        ElseIf playerPick = "Scissors" Then

            If win = 1 Then
                aiPick = "Paper"
            ElseIf win = 2 Then
                aiPick = "Scissors"
            ElseIf win = 3 Or 4 Or 5 Or 6 Then
                aiPick = "Rock"
            End If

        End If


        If playerPick = "Rock" And aiPick = "Paper" Then
            MsgBox("you losed")
            AiScore = AiScore + 1
        ElseIf playerPick = "Rock" And aiPick = "Rock" Then
            MsgBox("you tied")
        ElseIf playerPick = "Rock" And aiPick = "Scissors" Then
            MsgBox("you won")
            playerScore = playerScore + 1
        ElseIf playerPick = "Scissors" And aiPick = "Paper" Then
            MsgBox("you won")
            playerScore = playerScore + 1
        ElseIf playerPick = "Scissors" And aiPick = "Rock" Then
            MsgBox("you losed")
            AiScore = AiScore + 1
        ElseIf playerPick = "Scissors" And aiPick = "Scissors" Then
            MsgBox("you tied")
        ElseIf playerPick = "Paper" And aiPick = "Rock" Then
            MsgBox("you won")
            playerScore = playerScore + 1
        ElseIf playerPick = "Paper" And aiPick = "Paper" Then
            MsgBox("you tied")
        ElseIf playerPick = "Paper" And aiPick = "Scissors" Then
            MsgBox("you losed")
            AiScore = AiScore + 1
        End If


        If playerScore = 1 Then
            picPlayerScore.BackgroundImage = My.Resources.GD_1
        ElseIf playerScore = 2 Then
            picPlayerScore.BackgroundImage = My.Resources.GD_2
        ElseIf playerScore = 3 Then
            picPlayerScore.BackgroundImage = My.Resources.GD_3
        ElseIf playerScore = 4 Then
            picPlayerScore.BackgroundImage = My.Resources.Gd_4
        ElseIf playerScore = 5 Then
            picPlayerScore.BackgroundImage = My.Resources.GD_5
        ElseIf playerScore = 6 Then
            picPlayerScore.BackgroundImage = My.Resources.GD_6
        ElseIf playerScore = 7 Then
            picPlayerScore.BackgroundImage = My.Resources.GD_7
        ElseIf playerScore = 8 Then
            picPlayerScore.BackgroundImage = My.Resources.GD_8
        ElseIf playerScore = 9 Then
            picPlayerScore.BackgroundImage = My.Resources.GD_9
        ElseIf playerScore = 10 Then
            picPlayerScore.BackgroundImage = My.Resources.GD_10
            MsgBox("Game Over: PLayer Wins")
        End If

        If AiScore = 1 Then
            picAIScore.BackgroundImage = My.Resources.GD_1
        ElseIf AiScore = 2 Then
            picAIScore.BackgroundImage = My.Resources.GD_2
        ElseIf AiScore = 3 Then
            picAIScore.BackgroundImage = My.Resources.GD_3
        ElseIf AiScore = 4 Then
            picAIScore.BackgroundImage = My.Resources.Gd_4
        ElseIf AiScore = 5 Then
            picAIScore.BackgroundImage = My.Resources.GD_5
        ElseIf AiScore = 6 Then
            picAIScore.BackgroundImage = My.Resources.GD_6
        ElseIf AiScore = 7 Then
            picAIScore.BackgroundImage = My.Resources.GD_7
        ElseIf AiScore = 8 Then
            picAIScore.BackgroundImage = My.Resources.GD_8
        ElseIf AiScore = 9 Then
            picAIScore.BackgroundImage = My.Resources.GD_9
        ElseIf AiScore = 10 Then
            picAIScore.BackgroundImage = My.Resources.GD_10
            MsgBox("Game Over: Ai Wins")
        End If
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picAi.Parent = picBG
        picAi.BackColor = Color.Transparent
        picRPSai.Parent = picBG
        picRPSai.BackColor = Color.Transparent
        picRPSyou.Parent = picBG
        picRPSyou.BackColor = Color.Transparent
        picVS.Parent = picBG
        picVS.BackColor = Color.Transparent
        picYou.Parent = picBG
        picYou.BackColor = Color.Transparent
        picAIScore.Parent = picBG
        picAIScore.BackColor = Color.Transparent
        picPlayerScore.Parent = picBG
        picPlayerScore.BackColor = Color.Transparent
        picScoreDash.Parent = picBG
        picScoreDash.BackColor = Color.Transparent
    End Sub

    Private Sub Form5_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub
End Class