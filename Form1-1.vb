Public Class Form1
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Const dec12pack As Decimal = 14.99
        Const dec5pack As Decimal = 6.99
        Const dec2pack As Decimal = 2.5
        Dim int12pack As Integer
        Dim int5pack As Integer
        Dim int2pack As Integer
        Dim dec12packtotal As Decimal
        Dim dec5packtotal As Decimal
        Dim dec2packtotal As Decimal
        Dim intTotalitems As Integer
        Dim decTotalSales As Decimal



        Integer.TryParse(txt12pack.Text, int12pack)
        Integer.TryParse(txt5pack.Text, int5pack)
        Integer.TryParse(txt2pack.Text, int2pack)
        dec12packtotal = int12pack * dec12pack
        dec5packtotal = int5pack * dec5pack
        dec2packtotal = int2pack * dec2pack
        intTotalitems = int12pack + int2pack + int5pack
        lblTotalordered.Text = Convert.ToString(intTotalitems)
        decTotalSales = dec12packtotal + dec2packtotal + dec5packtotal
        lblTotalsales.Text = decTotalSales.ToString("C2")




    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblTotalsales.Text = String.Empty
        lblTotalordered.Text = String.Empty
        txt12pack.Text = String.Empty
        txt5pack.Text = String.Empty
        txt2pack.Text = String.Empty

    End Sub
End Class
