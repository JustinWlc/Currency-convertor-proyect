Public Class Program1
    Private Sub chcUSD_CheckedChanged(sender As Object, e As EventArgs) Handles chcUSD.CheckedChanged
        Dim Amount As Decimal
        Dim USD As Decimal


        Amount = txtAmount.Text

        USD = Amount * 1.206
        Change.Text = USD

        If chcUSD.Checked Then
            Dim text2add As String

            text2add = "USD-- " & txtAmount.Text & " - GBP-- " & Change.Text
            lstTransactions.Items.Add(text2add)
        End If
    End Sub

    Private Sub chcEURO_CheckedChanged(sender As Object, e As EventArgs) Handles chcEURO.CheckedChanged
        Dim Amount As Decimal
        Dim EURO As Decimal

        Amount = txtAmount.Text

        EURO = Amount * 1.16
        Change.Text = EURO

        If chcEURO.Checked Then
            Dim text2add As String

            text2add = "EURO-- " & txtAmount.Text & " - GBP-- " & Change.Text
            lstTransactions.Items.Add(text2add)
        End If
    End Sub

    Private Sub chcYEN_CheckedChanged(sender As Object, e As EventArgs) Handles chcYEN.CheckedChanged
        Dim Amount As Decimal
        Dim YEN As Decimal

        Amount = txtAmount.Text

        YEN = Amount * 184.97
        Change.Text = YEN

        If chcYEN.Checked Then
            Dim text2add As String

            text2add = "YEN-- " & txtAmount.Text & " - GBP-- " & Change.Text
            lstTransactions.Items.Add(text2add)
        End If
    End Sub

    Private Sub chcUAH_CheckedChanged(sender As Object, e As EventArgs) Handles chcUAH.CheckedChanged
        Dim Amount As Decimal
        Dim UAH As Decimal

        Amount = txtAmount.Text

        UAH = Amount * 45.5

        Change.Text = UAH
        If chcUAH.Checked Then
            Dim text2add As String

            text2add = "UAH-- " & txtAmount.Text & " - GBP-- " & Change.Text
            lstTransactions.Items.Add(text2add)
        End If

    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetText()
        Change.ResetText()
        txtAmount.ResetText()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Selection.Show()
    End Sub
End Class