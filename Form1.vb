Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Const decSalesDiscount As Decimal = 0.25D
        Dim decSalesDiscount As Decimal
        Dim decSalespriorDiscount As Decimal
        Dim 

        Decimal.TryParse(InputBox("Please enter the sales discount"), decSalesDiscount)
        Decimal.TryParse(InputBox("Please enter your sales total"), decSalespriorDiscount)
        lblDiscountRate.Text = decSalesDiscount
        lblB4discount.Text = decSalespriorDiscount
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblDiscountRate.Click

    End Sub
End Class
