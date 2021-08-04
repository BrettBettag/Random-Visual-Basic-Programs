Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Const prompt As String = "Please enter the price of the candy as a number" &
            ControlChars.NewLine & "Click Cancel or leave blank to end."
        Dim dblPrice As Double
        Dim inputPrice As String
        Dim dblTotal As Double
        Dim taxdue As Double

        inputPrice = InputBox(prompt)
        Do While inputPrice <> String.Empty
            Decimal.TryParse(inputPrice, dblPrice)
            PricesListBox.Items.Add(PricesListBox.ToString("N2"))
            inputPrice = InputBox(prompt)
            dblTotal = dblTotal + dblPrice
        Loop
        taxdue = 0.05 * dblTotal
        dblTotal += taxdue
        Label3.Text = dblTotal.ToString("C2")

    End Sub

    Private Sub lstPrices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PricesListBox.SelectedIndexChanged

    End Sub
End Class
