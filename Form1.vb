Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim poundsOrdered, coffeeCost, shippingCost, totalDue As Double
        Const unitPrice As Double = 10.5
        Const shippingRate As Double = 1.05
        Const fixedCost As Double = 2.5
        poundsOrdered = CDbl(txtPounds.Text)
        coffeeCost = poundsOrdered * unitPrice
        ShippingCost = (poundsOrdered * shippingRate) + fixedCost
        totalDue = coffeeCost + shippingCost
        lblCost.Text = String.Format("{0:C}", coffeeCost)
        lblShip.Text = String.Format("{0:C}", shippingCost)
        lblTotal.Text = String.Format("{0:C}", totalDue)
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtPounds.Text = ""
        lblCost.Text = ""
        lblShip.Text = ""
        lblTotal.Text = ""
    End Sub
End Class
