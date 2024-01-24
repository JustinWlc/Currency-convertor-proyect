Public Class Program2
    Private Sub chcUSD1_CheckedChanged(sender As Object, e As EventArgs) Handles chcUSD1.CheckedChanged
        Dim Amount As Decimal
        Dim USD As Decimal

        Amount = txtAmount.Text

        USD = Amount * 0.79
        Change.Text = USD

        If chcUSD1.Checked Then
            Dim text2add As String

            text2add = "USD-- " & txtAmount.Text & " - GBP-- " & Change.Text
            lstTransactions.Items.Add(text2add)
        End If
    End Sub

    Private Sub chcEURO1_CheckedChanged(sender As Object, e As EventArgs) Handles chcEURO1.CheckedChanged
        Dim Amount As Decimal
        Dim EURO As Decimal

        Amount = txtAmount.Text

        EURO = Amount * 0.86
        Change.Text = EURO

        If chcEURO1.Checked Then
            Dim text2add As String

            text2add = "EURO-- " & txtAmount.Text & " - GBP-- " & Change.Text
            lstTransactions.Items.Add(text2add)
        End If
    End Sub

    Private Sub chcYEN1_CheckedChanged(sender As Object, e As EventArgs) Handles chcYEN1.CheckedChanged
        Dim Amount As Decimal
        Dim YEN As Decimal

        Amount = txtAmount.Text

        YEN = Amount * 0.0053
        Change.Text = YEN

        If chcYEN1.Checked Then
            Dim text2add As String

            text2add = "YEN-- " & txtAmount.Text & " - GBP-- " & Change.Text
            lstTransactions.Items.Add(text2add)
        End If
    End Sub

    Private Sub chcUAH1_CheckedChanged(sender As Object, e As EventArgs) Handles chcUAH1.CheckedChanged
        Dim Amount As Decimal
        Dim UAH As Decimal

        Amount = txtAmount.Text

        UAH = Amount * 0.021
        Change.Text = UAH

        If chcUAH1.Checked Then
            Dim text2add As String

            text2add = "UAH-- " & txtAmount.Text & " - GBP-- " & Change.Text
            lstTransactions.Items.Add(text2add)
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Selection.Show()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetText()
        Change.ResetText()
        txtAmount.ResetText()
    End Sub
End Class