Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim strCode As String

        strCode = txtCode.Text
        If strCode = "12" Then
            lblWarehouseLocation.Text = "Tennessee"
        ElseIf strCode = "36" Then
            lblWarehouseLocation.Text = "Kentucky"
        ElseIf strCode = "40" OrElse strCode = "43" Then
            lblWarehouseLocation.Text = "Louisiana"
        Else
            lblWarehouseLocation.Text = "Invalid Code"
        End If
    End Sub
End Class
