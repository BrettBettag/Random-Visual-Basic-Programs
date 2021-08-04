Public Class Form1
    Private strClerk As String
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Const decTAX_RATE As Decimal = 0.02D
        Const decITEM_PRICE As Decimal = 0.5D
        Dim intDonuts As Integer
        Dim intMuffins As Integer
        Dim intTotalItems As Integer
        Dim decSubtotal As Decimal
        Dim decSalesTax As Decimal
        Dim decTotalSales As Decimal

        Integer.TryParse(txtDoughnuts.Text, intDonuts)
        Integer.TryParse(txtMuffins.Text, intMuffins)
        intTotalItems = intDonuts + intMuffins
        decSubtotal = intTotalItems * decITEM_PRICE
        decSalesTax = intTotalItems * decTAX_RATE
        decTotalSales = decSubtotal + decSalesTax

        lblTotalItems.Text = Convert.ToString(intTotalItems)
        lblTotalSales.Text = decTotalSales.ToString("C2")
        lblMsg.Text = "The sales tax was " & decSalesTax.ToString("C2") & ControlChars.NewLine & strClerk
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Const strPROMPT As String = "Salesclerk's name : "
        Const strTITLE As String = "Name Entry"
        strClerk = InputBox(strPROMPT, strTITLE)
    End Sub
End Class
