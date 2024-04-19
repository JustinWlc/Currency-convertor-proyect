Public Class Mainpage
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Name = txtName.Text
        'with this you will be able to wirte any text in the text box'

        Selection.Show()
        'this is going to show the selection form'

        Me.Hide()
        'when the other forms show this one will be hide'
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click

        Application.Exit()
        'this will close the application'
    End Sub

    Private Sub Mainpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
