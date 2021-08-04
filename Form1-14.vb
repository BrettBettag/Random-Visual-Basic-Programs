Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate the average electric bill

        Const strPROMPT As String =
           "Enter electric bill. " &
           "Click Cancel or leave blank to end. "
        Const strTITLE As String = "Monthly Bill"
        Dim strMonthBill As String
        Dim dblMonthBill As Double
        Dim blnNumeric As Boolean
        Dim intMonths As Integer    ' counter
        Dim dblTotal As Double 'accumulator
        Dim dblAverage As Double

        ' clear lstMonthly and lblAverage
        lstMonthly.Items.Clear()
        lblAverage.Text = String.Empty

        ' get first amount
        strMonthBill = InputBox(strPROMPT, strTITLE, "0")

        ' repeat as long as the user enters an amount 
        Do While strMonthBill <> String.Empty
            blnNumeric = Double.TryParse(strMonthBill, dblMonthBill)
            If blnNumeric Then
                ' display the amount in the list box 
                lstMonthly.Items.Add(dblMonthBill.ToString("N2"))

                'update the counter and accumulator 
                intMonths += 1
                dblTotal += dblMonthBill
            Else
                MessageBox.Show("Please show a number.",
                                "Monthly Bill",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
            End If
            strMonthBill = InputBox(strPROMPT, strTITLE, "0")
        Loop

        ' verify that the counter is greater than 0
        If intMonths > 0 Then
            dblAverage = dblTotal / intMonths
            lblAverage.Text = dblAverage.ToString("c2")
        Else
            lblAverage.Text = "N/A"

        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
