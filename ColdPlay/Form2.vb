Public Class Form2
    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        If ValidateInput() Then
            Dim name As String = txtName.Text.ToUpper
            Dim quantity As Integer = Integer.Parse(txtQuantity.Text.ToString)
            Dim zone As String = coTicketZone.Text
            Dim zonePrice As Decimal
            Dim totalPrice As Decimal
            Dim discountPrice As Decimal
            Dim discountApplicable As String
            If zone = "ZONE A" Then
                zonePrice = 200
            ElseIf zone = "ZONE B" Then
                zonePrice = 150
            ElseIf zone = "ZONE C" Then
                zonePrice = 100

            End If

            totalPrice = zonePrice * quantity

            If quantity > 3 Then
                discountPrice = totalPrice - (totalPrice * 0.1)
                discountApplicable = "Yes"
            Else
                discountPrice = totalPrice
                discountApplicable = "No"
            End If

            dispName.Text = name
            dispZone.Text = zone
            dispQuantity.Text = quantity.ToString
            dispUnitPrice.Text = "RM " + zonePrice.ToString
            dispDiscount.Text = discountApplicable
            dispTotalPrice.Text = "RM " + discountPrice.ToString("0.00")
            dispPrice.Text = "RM " + totalPrice.ToString("0.00")
        End If
    End Sub

    Private Function ValidateInput()
        Return IsPresent(txtName.Text, "Name") AndAlso
            ValidQuantity(txtQuantity.Text, "Quantity") AndAlso
            IsPresent(coTicketZone.Text, "Ticket Zone")
    End Function

    Private Function IsPresent(ByVal textbox As String, ByVal name As String)
        If textbox = "" Then
            MessageBox.Show("Please enter " + name, "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        Else
            Return True
        End If
    End Function

    Private Function ValidQuantity(ByVal textbox As String, ByVal name As String)
        Try
            Dim number As Integer = Integer.Parse(textbox.ToString)

            If number < 1 Then
                MessageBox.Show("Please enter " + name + " more than 0", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show("Please enter " + name + " in Integer format", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Function
End Class