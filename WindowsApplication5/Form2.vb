Public Class frmCalculatorV4

    Dim Value1, Value2 As Double

    Private _calculatorV4 As Calculator

    Private Sub frmCalculatorV4_Load(sender As Object, e As System.EventArgs)) Handles Me.Load
        _calculator = NewCalculator
    End Sub

    Private Sub btnNumberAny_Click(sender As System.Object, e As System.EventArgs) Handles btnNumber0.Click, btnNumber1.Click, btnNumber2.Click, btnNumber3.Click, btnNumber4.Click, btnNumber5.Click, btnNumber6.Click, btnNumber7.Click, btnNumber8.Click, btnNumber9.Click

        Dim stringToAddToDisp As String
        stringToAddToDisp = CType(sender, Button).Text

End Class