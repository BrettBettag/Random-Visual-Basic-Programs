Public Class Form1
    Private Sub CancelKeys(sender As Object, e As KeyPressEventArgs
                           ) Handles txtRooms.KeyPress, txtNights.KeyPress,
                           txtAdults.KeyPress, txtChildren.KeyPress
        ' allows the text box to accept only numbers and the Backspace
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Const intMAX_PER_ROOM As Integer = 6
        Const dblDAILY_ROOM_CHANGE As Double = 225.5
        Const dblTAX_RATE As Double = 0.1625
        Const dblDAILY_RESORT_FEE As Double = 12.5
        Const strMSG As String = "You have exceeded the maximum guests per room."
        Dim intRoomsReserved As Integer
        Dim intNights As Integer
        Dim intAdults As Integer
        Dim intChildren As Integer
        Dim intNumGuests As Integer
        Dim dblRoomsRequired As Double
        Dim dblTotalRoomChg As Double
        Dim dblTax As Double
        Dim dblTotalResortFee As Double
        Dim dblTotalDue As Double

        ' store input in variables
        Integer.TryParse(txtRooms.Text, intRoomsReserved)
        Integer.TryParse(txtNights.Text, intNights)
        Integer.TryParse(txtAdults.Text, intAdults)
        Integer.TryParse(txtChildren.Text, intRoomsReserved)

        ' calculate total number of guests
        intNumGuests = intAdults + intChildren
        ' calculate number of rooms required
        dblRoomsRequired = intNumGuests / intMAX_PER_ROOM

        ' determine whether number of reserved rooms is
        ' adequate and then either display a message or
        ' calculate and display the changes
        If intRoomsReserved < dblRoomsRequired Then
            MessageBox.Show(strMSG, "Treeline Resort",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        Else
            ' calculate charges

            dblTotalRoomChg = intRoomsReserved *
                intNights * dblDAILY_ROOM_CHANGE
            dblTax = dblTotalRoomChg * dblTotalDue * dblTAX_RATE
            dblTotalResortFee = intRoomsReserved *
                intNights * dblDAILY_RESORT_FEE
            dblTotalDue = dblTotalRoomChg +
                dblTax + dblTotalResortFee

            ' display charges
            lblTotalRoomChg.Text = dblTotalRoomChg.ToString("n2")
            lbl3.Text = dblTax.ToString("n2")
            lblResortFee.Text = dblTotalResortFee.ToString("n2")
            lblTotalDue.Text = dblTotalDue.ToString("c2")
        End If
    End Sub
End Class
