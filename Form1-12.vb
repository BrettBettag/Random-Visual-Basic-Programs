Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Const dblGROWTH_RATE As Double = 0.03
        Dim dblSales As Double
        Dim dblIncrease As Double
        Dim intYears As Integer

        Double.TryParse(txtCurrent.Text, dblSales)
        Do While dblSales < 150000
            dblIncrease = dblSales * dblGROWTH_RATE
            dblSales = dblSales + dblIncrease
            intYears = intYears + 1
        Loop
        lblProjSales.Text = "Projected sales " &
            intYears.ToString & " years from now: " &
            dblSales.ToString("c0")
    End Sub
End Class
