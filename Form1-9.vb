Public Class Form1
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles radDiamond.CheckedChanged

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Const decBasic As Decimal = 39.99
        Const decSilver As Decimal = 45.99
        Const decGold As Decimal = 74.99
        Const decDiamond As Decimal = 99.99
        Const decCinnematic As Decimal = 10.5
        Const decHBI As Decimal = 10.5
        Const decShowtimer As Decimal = 11.5
        Const decLocal As Decimal = 5.0

        Dim decPrice As Decimal

        'calculates the charges
        If radBasic.Checked Then
            decPrice = decBasic
        ElseIf radSilver.Checked Then
            decPrice = decSilver
        ElseIf radGold.Checked Then
            decPrice = decGold
        ElseIf radDiamond.Checked Then
            decPrice = decDiamond
        End If
        If chkCinnematic.Checked Then
            decPrice = decPrice + decCinnematic
        End If
        If chkHBI.Checked Then
            decPrice = decPrice + decHBI
        End If
        If chkLocal.Checked Then
            decPrice = decPrice + decLocal
        End If
        If chkShowtime.Checked Then
            decPrice = decPrice + decShowtimer

        End If

        lblPrice.Text = decPrice.ToString("c2")

    End Sub
End Class
