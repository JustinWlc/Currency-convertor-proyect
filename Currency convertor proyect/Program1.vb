Public Class Program1
    Private Sub chcUSD_CheckedChanged(sender As Object, e As EventArgs) Handles chcUSD.CheckedChanged
        Dim Amount As Decimal
        Dim USD As Decimal
        'here we are declaring our variables'


        Amount = txtAmount.Text
        'with this you will be able to wirte any number in the text box'

        USD = Amount * 1.206
        'this is the calculation that we need to exchange the currency GBP to USD'
        Change.Text = USD
        'this is going to show the result of the calculation'

        If chcUSD.Checked Then
            'this is a condition that if the check box is checked then is going to show'

            Dim text2add As String
            'here we are decalring the variable'

            text2add = "USD-- " & txtAmount.Text & " - GBP-- " & Change.Text
            'this is the text is going to show in the  list box'

            lstTransactions.Items.Add(text2add)
            'this save the exchanges in the list box'
        End If
    End Sub

    Private Sub chcEURO_CheckedChanged(sender As Object, e As EventArgs) Handles chcEURO.CheckedChanged
        Dim Amount As Decimal
        Dim EURO As Decimal
        'here we are declaring our variables'

        Amount = txtAmount.Text
        'with this you will be able to wirte any number in the text box'

        EURO = Amount * 1.16
        'this is the calculation that we need to exchange the currency GBP to EURO'

        Change.Text = EURO
        'this is going to show the result of the calculation'

        If chcEURO.Checked Then
            'this is a condition that if the check box is checked then is going to show '

            Dim text2add As String
            'here we are decalring the variable'

            text2add = "EURO-- " & txtAmount.Text & " - GBP-- " & Change.Text
            'this is the text is going to show in the  list box'

            lstTransactions.Items.Add(text2add)
            'this save the exchanges in the list box'
        End If
    End Sub

    Private Sub chcYEN_CheckedChanged(sender As Object, e As EventArgs) Handles chcYEN.CheckedChanged
        Dim Amount As Decimal
        Dim YEN As Decimal
        'here we are declaring our variables'

        Amount = txtAmount.Text
        'with this you will be able to wirte any number in the text box'

        YEN = Amount * 184.97
        'this is the calculation that we need to exchange the currency GBP to YEN'

        Change.Text = YEN
        'this is going to show the result of the calculation'
        If chcYEN.Checked Then
            'this is a condition that if the check box is checked then is going to show '

            Dim text2add As String
            'here we are decalring the variable'

            text2add = "YEN-- " & txtAmount.Text & " - GBP-- " & Change.Text
            'this is the text is going to show in the  list box'

            lstTransactions.Items.Add(text2add)
            'this save the exchanges in the list box'
        End If
    End Sub

    Private Sub chcUAH_CheckedChanged(sender As Object, e As EventArgs) Handles chcUAH.CheckedChanged
        Dim Amount As Decimal
        Dim UAH As Decimal
        'here we are declaring our variables'

        Amount = txtAmount.Text
        'with this you will be able to wirte any number in the text box'

        UAH = Amount * 45.5
        'this is the calculation that we need to exchange the currency GBP to UAH'

        Change.Text = UAH
        'this is going to show the result of the calculation'

        If chcUAH.Checked Then
            'this is a condition that if the check box is checked then is going to show '

            Dim text2add As String
            'here we are decalring the variable'

            text2add = "UAH-- " & txtAmount.Text & " - GBP-- " & Change.Text
            'this is the text is going to show in the  list box'

            lstTransactions.Items.Add(text2add)
            'this save the exchanges in the list box'
        End If

    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetText()
        Change.ResetText()
        txtAmount.ResetText()
        'this is going to reset your text'
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
        'this will close the application'
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Selection.Show()
        Me.Hide()
        'when the other forms show this one will be hide'
    End Sub
End Class