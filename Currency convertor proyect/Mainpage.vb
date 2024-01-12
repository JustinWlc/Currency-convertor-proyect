Public Class Mainpage
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Name = txtName.Text
        Selection.Show()
        Me.Hide()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub
End Class
