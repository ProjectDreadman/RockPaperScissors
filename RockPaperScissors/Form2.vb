Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub picBtnEz_Click(sender As Object, e As EventArgs) Handles picBtnEz.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub picBtnHard_Click(sender As Object, e As EventArgs) Handles picBtnHard.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub picBtnInpossible_Click(sender As Object, e As EventArgs) Handles picBtnInpossible.Click
        Me.Hide()
        Form5.Show()

    End Sub
End Class