Module Module1
    ' Call this routine to perform the actual mathematic expression parsing
    Public Function Parse(input As String)
        Dim t As Int32 = 0
        Dim oe(0) As Int32
        Dim strings As List(Of String) = New List(Of String)
        ' Iterate through the characters of input string starting at the position of final character
        For index = input.Length() - 1 To 0 Step -1
            ' For each character perform a check if its value is '('
            If input(index) = "(" Or index = 0 Then
                Dim sb As String = ""
                Dim n As Int32 = 0
                ' Perform a check if this is the first character in string
                If index = 0 Then
                    ' If so assign n variable to the value of variable index
                    n = index
                    ' Otherwise assign n variable to the value of variable index + 1
                Else n = index + 1
                End If

                Dim exists As Boolean = False
                Do
                    exists = False
                    Dim bracket As Boolean = False
                    ' Perform the iterations stepping forward into each succeeding character
                    ' starting at the position n = index + 1 until we've found a character equal to ')'
                    While n < input.Length() And bracket = False
                        ' Check if the current character is not ')'.
                        If input(n) <> ")" Then
                            ' If so, append it to the temporary string buffer
                            sb += input(n)
                            ' Otherwise break the loop execution
                        Else bracket = True
                        End If
                        ' Increment the n loop counter variable by 1
                        n = n + 1
                    End While
                    If exists <> True Then
                        Dim r As Int32 = 0
                        ' Iterate through the array of positions
                        While r < oe.Count() And exists = False
                            ' For each element perform a check if its value
                            ' is equal to the position of the current ')' character
                            If oe(r) = n Then
                                ' If so, append the character ')' to the temporary string buffer and break
                                ' the loop execution assigning the variable exists to the value 'true'
                                exists = True
                                sb += ") "
                                n = n + 1
                            End If
                            r = r + 1
                        End While
                    End If

                    ' Repeat the following loop execution until we've found the character ')' at
                    ' the New position which is not in the array of positions
                Loop While exists = True

                ' If the current character's ')' position has not been previous found,
                ' add the value of position to the array
                If exists = False Then
                    Array.Resize(oe, oe.Length + 1)
                    oe(t) = n
                    t = t + 1
                End If

                ' Add the currently obtained string containing a specific part of the expression to the array
                strings.Add(sb)

            End If
        Next

        ' Iterate through the array of the expression parts
        For index = 0 To strings.Count() - 1 Step 1
            ' Compute the result for the current part of the expression
            Dim Result As String = Compute(strings.Item(index)).ToString()
            ' Iterate through all succeeding parts of the expression
            For n = index To strings.Count() - 1 Step 1
                ' For each part substitute the substring containing the current part of the expression
                ' with its numerical value without parentheses.
                strings(n) = strings.ElementAt(n).Replace("(" + strings.Item(index) + ")", Result)
            Next
        Next
        ' Compute the numerical value of the last part (e.g. the numerical resulting value of the entire expression)
        ' and return this value at the end of the following routine execution.
        Return Compute(strings.Item(strings.Count() - 1))
    End Function

    Public Function Compute(expr As String)
        Dim Result As Int32 = 0
        Dim val As String = ""
        Dim op() As String = {"+", "-", "*", "/"}
        Dim strings As List(Of String) = New List(Of String)
        ' Iterate through each character and for each character
        ' perform a check if it has a numberical value
        For index = 0 To expr.Length() - 1 Step 1
            If IsNumeric(expr(index)) Then
                val = Nothing
                Dim done As Boolean = False
                ' If so, perform iterations stepping forward into each character
                ' until we've found a character which value is not numerical
                While index < expr.Length() And done = False
                    ' For each character perform a similar check if it's numerical value
                    If IsNumeric(expr(index)) Then
                        ' If so, append it to the resulting string.
                        val += expr(index)
                        ' Increment the value of loop counter variable index by 1
                        index = index + 1
                        ' Otherwise break the loop execution
                    Else done = True
                    End If
                End While
                ' Append the numberical value extracted to the array of strings
                strings.Add(val)
                ' Perform a check if the current character equals to '+'
            ElseIf expr(index) = op(0) Then
                ' If so, add the string containg the following character only to the the array of strings
                strings.Add(op(0))
                ' Perform a check if the current character equals to '-'
            ElseIf expr(index) = op(1) Then
                ' If so, add the string containg the following character only to the the array of strings
                strings.Add(op(1))
                ' Perform a check if the current character equals to '*'
            ElseIf expr(index) = op(2) Then
                ' If so, add the string containg the following character only to the the array of strings
                strings.Add(op(2))
                ' Perform a check if the current character equals to '/'
            ElseIf expr(index) = op(3) Then
                ' If so, add the string containg the following character only to the the array of strings
                strings.Add(op(3))
            End If
        Next

        Dim n As Int32 = 0
        ' Execute the following loop until the string no longer contains '*' and '/' characters
        While strings.Contains("*") Or strings.Contains("/")
            Dim found As Boolean = False
            ' Iterate through the array of strings
            While n < strings.Count() And found = False
                ' For each string perform a check if the following string contains only one character - '*'
                If strings(n) = op(2) Then
                    ' If so, retrieve the first op1 and second op2 operands which are the previous and
                    ' next elements of the following array of strings respectively
                    Dim op1 As Int32 = Integer.Parse(strings(n - 1))
                    Dim op2 As Int32 = Integer.Parse(strings(n + 1))
                    ' Perform multiplication and accumulate the result in Res variable
                    Dim Res = op1 * op2
                    ' Remove the previous element from the array of strings
                    strings.RemoveAt(n - 1)
                    ' Assign the resulting value from Res variable to the position n - 1 in the array of strings
                    strings(n - 1) = Res
                    ' Remove the current element from the array of strings
                    strings.RemoveAt(n)
                    ' Assign the Result variable the resulting value so far
                    Result = Res
                    ' If the operator '*' found break the loop execution
                    found = True
                    n = 0
                End If

                ' For each string perform a check if the following string contains only one character - '/'
                If strings(n) = op(3) Then
                    ' If so, retrieve the first op1 and second op2 operands which are the previous and
                    ' next elements of the following array of strings respectively
                    Dim op1 As Int32 = Integer.Parse(strings(n - 1))
                    Dim op2 As Int32 = Integer.Parse(strings(n + 1))
                    ' Perform division and accumulate the result in Res variable
                    Dim Res = CInt(op1 / op2)
                    ' Remove the previous element from the array of strings
                    strings.RemoveAt(n - 1)
                    ' Assign the resulting value from Res variable to the position n - 1 in the array of strings
                    strings(n - 1) = Res
                    ' Remove the current element from the array of strings
                    strings.RemoveAt(n)
                    ' Assign the Result variable the resulting value so far
                    Result = Res
                    ' If the operator '/' found break the loop execution
                    found = True
                    n = 0
                End If
                n = n + 1
            End While
        End While

        n = 0
        ' Execute the following loop until the string no longer contains '+' and '-' characters
        While strings.Contains("+") Or strings.Contains("-")
            Dim found As Boolean = False
            ' Iterate through the array of strings
            While n < strings.Count() And found = False
                ' For each string perform a check if the following string contains only one character - '+'
                If strings(n) = op(0) Then
                    ' If so, retrieve the first op1 and second op2 operands which are the previous and
                    ' next elements of the following array of strings respectively
                    Dim op1 As Int32 = Integer.Parse(strings(n - 1))
                    Dim op2 As Int32 = Integer.Parse(strings(n + 1))
                    ' Perform addition and accumulate the result in Res variable
                    Dim Res = op1 + op2
                    ' Remove the previous element from the array of strings
                    strings.RemoveAt(n - 1)
                    ' Assign the resulting value from Res variable to the position n - 1 in the array of strings
                    strings(n - 1) = Res
                    ' Remove the current element from the array of strings
                    strings.RemoveAt(n)
                    ' Assign the Result variable the resulting value so far
                    Result = Res
                    ' If the operator '+' found break the loop execution
                    found = True
                    n = 0
                End If

                ' For each string perform a check if the following string contains only one character - '-'
                If strings(n) = op(1) Then
                    ' If so, retrieve the first op1 and second op2 operands which are the previous and
                    ' next elements of the following array of strings respectively
                    Dim op1 As Int32 = Integer.Parse(strings(n - 1))
                    Dim op2 As Int32 = Integer.Parse(strings(n + 1))
                    ' Perform subtraction and accumulate the result in Res variable
                    Dim Res = op1 - op2
                    ' Remove the previous element from the array of strings
                    strings.RemoveAt(n - 1)
                    ' Assign the resulting value from Res variable to the position n - 1 in the array of strings
                    strings(n - 1) = Res
                    ' Remove the current element from the array of strings
                    strings.RemoveAt(n)
                    ' Assign the Result variable the resulting value so far
                    Result = Res
                    ' If the operator '-' found break the loop execution
                    found = True
                    n = 0
                End If
                n = n + 1
            End While
        End While
        Return Result
    End Function
End Module
