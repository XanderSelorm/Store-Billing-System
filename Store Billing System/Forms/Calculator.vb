Public Class Calculator

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        txtInputOutput.Text = txtInputOutput.Text + btnZero.Text()

    End Sub


    '//////////////////////////////NUMBERS/////////////////////////////////////////

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        txtInputOutput.Text = txtInputOutput.Text + btnOne.Text()
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        txtInputOutput.Text = txtInputOutput.Text + btnTwo.Text()
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        txtInputOutput.Text = txtInputOutput.Text + btnThree.Text()
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        txtInputOutput.Text = txtInputOutput.Text + btnFour.Text()
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        txtInputOutput.Text = txtInputOutput.Text + btnFive.Text()
    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        txtInputOutput.Text = txtInputOutput.Text + btnSix.Text()
    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        txtInputOutput.Text = txtInputOutput.Text + btnSeven.Text()
    End Sub

    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        txtInputOutput.Text = txtInputOutput.Text + btnEight.Text()
    End Sub

    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        txtInputOutput.Text = txtInputOutput.Text + btnNine.Text()
    End Sub

    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        txtInputOutput.Text = txtInputOutput.Text + btnDot.Text()
    End Sub


    '/////////////////////////OPERATIONS//////////////////////////

    Dim input1 As Double
    Dim input2 As Double
    Dim total As Double
    Dim operand As Char

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'input1 = Double.Parse(txtOutput.Text())
        input1 = CDbl(txtInputOutput.Text())
        operand = "+"
        txtInputOutput.Text = ""
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        input2 = CDbl(txtInputOutput.Text)
        Select Case operand
            Case "+"
                total = input1 + input2
            Case "-"
                total = input1 - input2
            Case "/"
                total = input1 / input2
            Case "*"
                total = input1 * input2
            Case "%"
                total = input1 Mod input2
            Case "Pwr"
                total = input1 ^ (input2)
        End Select

        'txtOutput.Text() = total.ToString()
        txtInputOutput.Text() = CStr(total)

    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        input1 = Double.Parse(txtInputOutput.Text())
        operand = "-"
        txtInputOutput.Text = ""
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        input1 = Double.Parse(txtInputOutput.Text())
        operand = "*"
        txtInputOutput.Text = ""
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        input1 = Double.Parse(txtInputOutput.Text())
        operand = "/"
        txtInputOutput.Text = ""
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        input1 = Double.Parse(txtInputOutput.Text())
        operand = "%"
        txtInputOutput.Text = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInputOutput.Text = Nothing

    End Sub

    Private Sub txtInputOutput_KeyUp(sender As Object, e As KeyEventArgs) Handles txtInputOutput.KeyUp

    End Sub

    Private Sub txtInputOutput_TextChanged(sender As Object, e As EventArgs) Handles txtInputOutput.TextChanged

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class
