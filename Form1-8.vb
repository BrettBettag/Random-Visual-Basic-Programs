Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'calculates the commission

        Dim Sales As Double
        Dim Commission As Double
        Dim Additional As Double
        Dim TotalDue As Double

        Double.TryParse(txtSales.Text, Sales)

        Select Case Sales
            Case Is < 6000
                Commission = 0.1 * Sales
            Case Is < 30000
                Commission = 600 + 0.13 * (Sales - 6000)
            Case Else
                Commission = 3720 + 0.14 * (Sales - 30000)

        End Select
        If chkOver10Years.Checked Then
            Additional += 500
        End If

        If chkTraveling.Checked Then
            Additional += 700
        End If

        TotalDue = Commission + Additional

        lblCommission.Text = Commission.ToString("c2")
        lblAdditional.Text = Additional.ToString("c2")
        lblTotalDue.Text = TotalDue.ToString("c2")

    End Sub
End Class
