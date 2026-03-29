Imports System.ComponentModel

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Animation_Warrior_Theme, AudioPlayMode.Background)
        picPlay.Parent = picBG
        picPlay.BackColor = Color.Transparent
        picTitle.Parent = picBG
        picTitle.BackColor = Color.Transparent

    End Sub
    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

    Private Sub picPlay_Click(sender As Object, e As EventArgs) Handles picPlay.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub picBG_Click(sender As Object, e As EventArgs) Handles picBG.Click

    End Sub
End Class
