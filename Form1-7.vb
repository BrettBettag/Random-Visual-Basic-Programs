Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnGetPrice_Click(sender As Object, e As EventArgs) Handles btnGetPrice.Click
        Const decUltimate As Decimal = 775.99
        Const decProfessional As Decimal = 499.99
        Const decStudent As Decimal = 149.99
        Const decUltimateEditionDiscount As Decimal = 0.9
        Const decStudentEditionDiscount As Decimal = 0.8

        Dim dblPrice As Double

        'calculates the charges 
        If radUltimate.Checked Then
            If radUltimateEditionDiscount.Checked Then
                dblPrice = decUltimate * decUltimateEditionDiscount
            Else
                dblPrice = decUltimate
            End If
        ElseIf radStudent.Checked Then
            If radStudentEditionDiscount.Checked Then
                dblPrice = decStudent * decStudentEditionDiscount
            Else
                dblPrice = decStudent
            End If
        Else dblPrice = decProfessional
        End If

        lblPrice.Text = dblPrice.ToString("c2")


    End Sub
End Class
