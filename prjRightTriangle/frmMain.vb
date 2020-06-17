Public Class frmMain
    Private decA, decB, decC As Decimal
    Private intDecimals As Integer
    Private Const intPRECISION As Integer = 3

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        intDecimals = intPRECISION
        btnClear.PerformClick()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        decA = 0
        decB = 0
        FormatInputs()
        FormatOutputs()
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        'get input
        GetInputs()
        'compute
        ComputeArea()
        'display output
        FormatOutputs()
    End Sub

    Private Sub ComputeArea()
        decC = (decA ^ 2 + decB ^ 2) ^ (1 / 2)
    End Sub

    Private Sub GetInputs()
        Integer.TryParse(txtDecimals.Text, intDecimals)
        Decimal.TryParse(txtA.Text, decA)
        Decimal.TryParse(txtB.Text, decB)
        ProcessPrecision(intDecimals)
        ProcessAB(decA)
        ProcessAB(decB)
        FormatInputs()
    End Sub

    Private Sub ProcessAB(ByRef side As Decimal)
        If side < 0 Then
            MsgBox("Sides A and B cannot be less than 0.")
            side = 0
        End If
    End Sub

    Private Sub ProcessPrecision(ByRef numDecimals As Integer)
        If numDecimals < 0 Then
            MsgBox("Number of decimal places cannot be less than 0.")
            numDecimals = intPRECISION
        End If
    End Sub

    Private Sub textBox_LoseFocus(sender As Object, e As EventArgs) Handles txtDecimals.Leave, txtB.Leave, txtA.Leave
        GetInputs()
        FormatOutputs()
    End Sub

    Private Sub press_Enter(sender As Object, e As KeyPressEventArgs) Handles txtDecimals.KeyPress, txtB.KeyPress, txtA.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnCompute.PerformClick()
        End If
    End Sub

    Private Sub input_Changed(sender As Object, e As EventArgs) Handles txtB.TextChanged, txtA.TextChanged
        decC = 0
        FormatOutputs()
    End Sub

    Private Sub FormatInputs()
        txtDecimals.Text = intDecimals.ToString()
        txtA.Text = decA.ToString("N" & intDecimals)
        txtB.Text = decB.ToString("N" & intDecimals)
    End Sub

    Private Sub FormatOutputs()
        txtC.Text = decC.ToString("N" & intDecimals)
    End Sub
End Class
