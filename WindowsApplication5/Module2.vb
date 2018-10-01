Module Calculate

    Public Function DoCalcs(list As List(Of String)) As List(Of String)
        For i = list.Count() - 1 To 0 Step -1

            ' Trigonometry
            If list.Contains("cos") Then
                Dim opPos As Integer
                opPos = list.IndexOf("cos")
                Dim numPosToDel As Integer = opPos + 1
                Dim ans As Double
                ans = Math.Cos(list(numPosToDel))

                list(opPos) = ans
                list.Remove(list(numPosToDel))

            ElseIf list.Contains("sin") Then
                Dim opPos As Integer
                opPos = list.IndexOf("sin")
                Dim numPosToDel As Integer = opPos + 1
                Dim ans As Double
                ans = Math.Sin(list(numPosToDel))
                list(opPos) = ans
                list.Remove(list(numPosToDel))

            ElseIf list.Contains("tan") Then
                Dim opPos As Integer
                opPos = list.IndexOf("tan")
                Dim numPosToDel As Integer = opPos + 1
                Dim ans As Double
                ans = Math.Tan(list(numPosToDel))
                list(opPos) = ans
                list.Remove(list(numPosToDel))
            End If

            ' Square root
            If list.Contains("sqrt") Then
                Dim opPos As Integer
                opPos = list.IndexOf("sqrt")
                Dim numPosToDel As Integer = opPos + 1
                Dim ans As Double
                ans = Math.Sqrt(list(numPosToDel))
                list(opPos) = ans
                list.Remove(list(numPosToDel))
            End If

            ' Logs
            If list.Contains("ln") Then
                Dim opPos As Integer
                opPos = list.IndexOf("ln")
                Dim numPosToDel As Integer = opPos + 1
                Dim ans As Double
                ans = Math.Log(list(numPosToDel))
                list(opPos) = ans
                list.Remove(list(numPosToDel))
            End If

            ' Log10
            If list.Contains("log") Then
                Dim opPos As Integer
                opPos = list.IndexOf("log")
                Dim numPosToDel As Integer = opPos + 1
                Dim ans As Double
                ans = Math.Log10(list(numPosToDel))
                list(opPos) = ans
                list.Remove(list(numPosToDel))
            End If

            ' Exponential
            If list.Contains("e") Then
                Dim opPos As Integer
                opPos = list.IndexOf("e")
                Dim numPosToDel As Integer = opPos + 1
                Dim ans As Double
                ans = Math.Exp(list(numPosToDel))
                list(opPos) = ans
                list.Remove(list(numPosToDel))
            End If

            ' Powers
            If list.Contains("^") Then
                Dim opPos As Integer
                opPos = list.IndexOf("^")
                Dim numPosToDel As Integer = opPos + 1
                Dim ans As Double
                ans = list(opPos - 1) ^ list(opPos + 1)
                list.RemoveAt(numPosToDel)
                list.RemoveAt(opPos)
                list(opPos - 1) = ans

                ' Division
            ElseIf list.Contains("/") Then
                Dim opPos As Integer
                opPos = list.IndexOf("/")
                Dim numPosToDel As Integer = opPos + 1
                Dim ans As Double
                ans = list(opPos - 1) / list(opPos + 1)
                list.RemoveAt(numPosToDel)
                list.RemoveAt(opPos)
                list(opPos - 1) = ans

                ' Multiplication "x"
            ElseIf list.Contains("x") Then
                Dim opPos As Integer
                opPos = list.IndexOf("x")
                Dim numPosToDel As Integer = opPos + 1
                Dim ans As Double
                ans = list(opPos - 1) * list(opPos + 1)
                list.RemoveAt(numPosToDel)
                list.RemoveAt(opPos)
                list(opPos - 1) = ans

                ' Multiplication "*"
            ElseIf list.Contains("*") Then
                Dim opPos As Integer
                opPos = list.IndexOf("*")
                Dim numPosToDel As Integer = opPos + 1
                Dim ans As Double
                ans = list(opPos - 1) * list(opPos + 1)
                list.RemoveAt(numPosToDel)
                list.RemoveAt(opPos)
                list(opPos - 1) = ans

                ' Addition
            ElseIf list.Contains("+") Then
                Dim opPos As Integer
                opPos = list.IndexOf("+")
                Dim numPosToDel As Integer = opPos + 1
                Dim ans As Double = list(opPos - 1)
                ans += list(opPos + 1)
                list.RemoveAt(numPosToDel)
                list.RemoveAt(opPos)
                list(opPos - 1) = ans

                ' Subtraction
            ElseIf list.Contains("-") Then
                Dim opPos As Integer
                opPos = list.IndexOf("-")
                Dim numPosToDel As Integer = opPos + 1
                Dim ans As Double = list(opPos - 1)
                ans -= list(opPos + 1)
                list.RemoveAt(numPosToDel)
                list.RemoveAt(opPos)
                list(opPos - 1) = ans
            End If
        Next
        Return list
    End Function


End Module
