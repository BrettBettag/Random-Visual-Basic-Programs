Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblDate.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Const decDVD_Price As Decimal = 9.99D
        Const decBluray_Price As Decimal = 11.99D
        Const decSales_Tax As Decimal = 0.065D

        Dim intDVD As Integer
        Dim intBluray As Integer
        Dim intBonusCash As Integer

        Dim decSubtotal As Decimal
        Dim decSalesTax As Decimal
        Dim decTotaldue As Decimal

        Integer.TryParse(txtDVD.Text, intDVD)
        Integer.TryParse(txtBluRay.Text, intBluray)
        decSubtotal = decDVD_Price * intDVD + decBluray_Price * intBluray
        decSalesTax = decSales_Tax * decSubtotal
        decTotaldue = decSubtotal + decSalesTax

        lblSubtotal.Text = decSubtotal.ToString("C2")
        lblSalestax.Text = decSalesTax.ToString("C2")
        lblTotaldue.Text = decTotaldue.ToString("C2")

        If decSubtotal > 50 Then
            intBonusCash = (decSubtotal / 50) * 10
            lblMessage.Text = "You have earned $" & Val(intBonusCash) & " in Dahlia Cash."
        End If
    End Sub

    Private Sub lblSubtotal_Click(sender As Object, e As EventArgs) Handles lblSubtotal.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
