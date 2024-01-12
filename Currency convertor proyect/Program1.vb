Public Class Program1
    Private Sub USD_CheckedChanged(sender As Object, e As EventArgs) Handles USD.CheckedChanged
        Dim Amount As Decimal
        Dim USD As Decimal


        Amount = txtAmount.Text

        USD = Amount * 1.206
        Change.Text = USD
    End Sub

    Private Sub EURO_CheckedChanged(sender As Object, e As EventArgs) Handles EURO.CheckedChanged
        Dim Amount As Decimal
        Dim EURO As Decimal

        Amount = txtAmount.Text

        EURO = Amount * 1.16
        Change.Text = EURO

    End Sub

    Private Sub YEN_CheckedChanged(sender As Object, e As EventArgs) Handles YEN.CheckedChanged
        Dim Amount As Decimal
        Dim YEN As Decimal

        Amount = txtAmount.Text

        YEN = Amount * 184.97
        Change.Text = YEN

    End Sub

    Private Sub UAH_CheckedChanged(sender As Object, e As EventArgs) Handles UAH.CheckedChanged
        Dim Amount As Decimal
        Dim UAH As Decimal

        Amount = txtAmount.Text

        UAH = Amount * 45.5

        Change.Text = UAH

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetText()
        Change.ResetText()
        txtAmount.ResetText()

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        lstTransactions.Items.Add(Name, txtAmount,  )
    End Sub
End Class