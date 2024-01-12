Public Class Selection
    Private Sub btnProgram1_Click(sender As Object, e As EventArgs) Handles btnProgram1.Click
        Program1.Show()
        Me.Hide()

    End Sub

    Private Sub btnProgram2_Click(sender As Object, e As EventArgs) Handles btnProgram2.Click
        Program2.Show()
        Me.Hide()

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub
End Class