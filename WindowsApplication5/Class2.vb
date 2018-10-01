Public Class Form3Calc

    Public Function Addition(firstNum As Double, secondNum As Double) As Double
        Return firstNum + secondNum
    End Function

    Public Function Subtraction(firstNum As Double, secondNum As Double) As Double
        Return firstNum - secondNum
    End Function

    Public Function Multiplication(firstNum As Double, secondNum As Double) As Double
        Return firstNum * secondNum
    End Function

    Public Function Divison(firstNum As Double, secondNum As Double) As Double
        Return firstNum / secondNum
    End Function

    Public Function Sqrt(firstNum)
        Return Math.Sqrt(firstNum)
    End Function

    Public Function Squared(firstNum)
        Return firstNum * firstNum
    End Function

    Public Function ToThePowerOf(firstNum As Double, secondNum As Double) As Double
        Return firstNum ^ secondNum
    End Function


End Class
