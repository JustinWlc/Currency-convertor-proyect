Public Class Selection
    Private Sub btnProgram1_Click(sender As Object, e As EventArgs) Handles btnProgram1.Click
        Program1.Show()
        'this is going to show your prgram 1 form'
        Me.Hide()
        'when the other forms show this one will be hide'

    End Sub

    Private Sub btnProgram2_Click(sender As Object, e As EventArgs) Handles btnProgram2.Click
        Program2.Show()
        'this is going to show your prgram 2 form'
        Me.Hide()
        'when the other forms show this one will be hide'
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
        'this will close the application'
    End Sub
End Class