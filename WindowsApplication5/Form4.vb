Public Class Form4

    Private Sub btnPush_Click(sender As Object, e As EventArgs) Handles btnPush.Click
        Dim Calco As New List(Of List(Of String))
        Dim Inpt As String = txtTextBox.Text
        Dim c As String
        Dim var As String = ""
        Dim var2 As String = ""
        Dim Op As New List(Of String)

        ' Working through the string (left to right) and spearating into operators and numbers.
        For i As Integer = 0 To Inpt.Length - 1

            c = Inpt(i)

            ' When the character is a number.
            If IsNumeric(c) Then

                ' If it is the first character, simply add it to the var string.
                If i = 0 Then
                    var = c

                    'If an operator or open bracket comes next then add to Op list.
                    If Inpt(i + 1) = "^" Or Inpt(i + 1) = "x" Or Inpt(i + 1) = "/" Or Inpt(i + 1) = "+" Or Inpt(i + 1) = "-" Or Inpt(i + 1) = "(" Then
                        Op.Add(var)
                    End If

                    ' When it is the last character.
                ElseIf i = (Inpt.Length - 1) Then

                    ' If the previous character was a number then append it to the string, add the string to list.
                    If IsNumeric(Inpt(i - 1)) Then
                        var = var & c
                        Op.Add(var)

                    End If

                    ' If previous character was an operator, add to the string, add string to list.
                    If IsNumeric(Inpt(i - 1)) = False And Inpt(i - 1) = "." = False Then
                        var = c
                        Op.Add(var)
                    End If

                    ' If previous character was a decimal, add to string, add string to list.
                    If Inpt(i - 1) = "." Then
                        var = var + c
                        Op.Add(var)
                    End If

                    For n = Op.Count() - 1 To 0 Step -1
                        If Op.Contains("-") Then
                            Dim m As Integer = Op.IndexOf("-")
                            If IsNumeric(Op(m - 1)) = False Then
                                Op(m) = -Op(m + 1)
                                Op.RemoveAt(m + 1)
                            End If
                        End If
                    Next

                    ' Once complete formula is added to list, do the calculations and return the answer to text box 2.
                    DoCalcs(Op)
                    txtTextBox2.Text = Op(0)

                    ' When the character is not the first or last in the formula
                    ' If previous character was a decimal point, add to string.
                ElseIf Inpt(i - 1) = "." Then
                    var = var & c

                    ' If the next character is an operator or open bracket, add to list.
                    If Inpt(i + 1) = "^" Or Inpt(i + 1) = "x" Or Inpt(i + 1) = "/" Or Inpt(i + 1) = "+" Or Inpt(i + 1) = "-" Or Inpt(i + 1) = "(" Then
                        Op.Add(var)
                    End If

                    ' If the previous character is an operator, add to string.
                ElseIf IsNumeric(Inpt(i - 1)) = False And (Inpt(i - 1) = "c") = False Then
                    var = c

                    ' If the next character is an operator or open bracket, add to list
                    If Inpt(i + 1) = "^" Or Inpt(i + 1) = "x" Or Inpt(i + 1) = "/" Or Inpt(i + 1) = "+" Or Inpt(i + 1) = "-" Or Inpt(i + 1) = "(" Then
                        Op.Add(var)
                        If (i - 1) = 0 And Op(i - 1) = "-" Then
                            Op(i - 1) = -Op(i)
                            Op.RemoveAt(i)
                        End If
                    End If

                        ' If the previous character is a number, add to string.
                    ElseIf IsNumeric(Inpt(i - 1)) Then
                    var = var & c

                    ' If the next character is an operator or bracket add to list.
                    If Inpt(i + 1) = " ^ " Or Inpt(i + 1) = "x" Or Inpt(i + 1) = "/" Or Inpt(i + 1) = "+" Or Inpt(i + 1) = "-" Or Inpt(i + 1) = "(" Then
                        Op.Add(var)
                    End If

                    ' If the next character is an operator or open bracket, add to list.
                ElseIf Inpt.Length - 1 < i > 0 And Inpt(i + 1) = "^" Or Inpt(i + 1) = "x" Or Inpt(i + 1) = "/" Or Inpt(i + 1) = "+" Or Inpt(i + 1) = "-" Or Inpt(i + 1) = "(" Then
                    var = c
                    Op.Add(var)
                End If
            End If

            ' If character is a decimal, add it to the string.
            If c = "." Then
                var = var & c
            End If

            ' If character is a letter  - for trig and square root.
            If Char.IsLetter(c) And c = "x" = False Then
                If i = 0 Then
                    var = c

                    ' If the previous character is an operator, add to string.
                ElseIf IsNumeric(Inpt(i - 1)) = False And Char.IsLetter(Inpt(i - 1)) = False Then
                    var = c

                    'If previous character is a letter, add to string.
                ElseIf Char.IsLetter(Inpt(i - 1)) Then
                    var = var & c
                    ' If the next character is a number, add to string, add string to list.
                    If IsNumeric(Inpt(i + 1)) Then
                        Op.Add(var)
                        ' If the next character is a closed bracket, add to string, add string to list.
                    ElseIf Inpt(i + 1) = "(" Then
                        Op.Add(var)
                    End If
                End If
            End If

            If c = "x" Then
                Op.Add(c)
            End If

            ' If character is an operator, add to list.
            If IsNumeric(c) = False And (c = ".") = False And (c = "(") = False And Char.IsLetter(c) = False Then
                Op.Add(c)
            End If

            ' Performing the same function for the string within the brackets.
            If c = "(" Then
                Dim bracketList As New List(Of String)
                Dim d As String
                Dim cb As String = Inpt.IndexOf(")")

                Op.Add(c)

                For j As Integer = i + 1 To cb
                    d = Inpt(j)

                    ' When the matching closed brackets is reached, do the calculations
                    ' Place answer in master list at correct point
                    If Inpt(j) = (")") Then
                        For k = bracketList.Count() - 1 To 0 Step -1
                            If bracketList.Contains("-") Then
                                Dim l As Integer = bracketList.IndexOf("-")
                                If IsNumeric(bracketList(l - 1)) = False Then
                                    bracketList(l) = -bracketList(l + 1)
                                    bracketList.RemoveAt(l + 1)
                                End If
                            End If
                        Next

                        DoCalcs(bracketList)
                        Dim Q As String = bracketList(0)
                        Op(i - 1) = Q

                        For n = Op.Count() - 1 To 0 Step -1
                            If Op.Contains("-") Then
                                Dim m As Integer = Op.IndexOf("-")
                                If IsNumeric(Op(m - 1)) = False Then
                                    Op(m) = -Op(m + 1)
                                    Op.RemoveAt(m + 1)
                                End If
                            End If
                            i = cb
                        Next
                        ' Once complete formula is added to list, do the calculations and return the answer to text box 2.
                        If j = Inpt.Length - 1 Then
                            DoCalcs(Op)
                            txtTextBox2.Text = Op(0)
                        End If

                    End If

                    ' If character is the first in brackets add to variable string
                    If IsNumeric(j) And Inpt(j) = ")" = False Then
                        If j = i + 1 Then
                            var2 = d

                            ' If next character is an operator add string to list
                            If Inpt(j + 1) = "^" Or Inpt(j + 1) = "x" Or Inpt(j + 1) = "/" Or Inpt(j + 1) = "+" Or Inpt(j + 1) = "-" Then
                                bracketList.Add(var2)
                            End If

                            ' If character is the last within the brackets
                        ElseIf Inpt(j + 1) = (")") Then

                            ' If the previous character was a number add to string and add string to list
                            If IsNumeric(Inpt(j - 1)) Then
                                var2 = var2 & d
                                bracketList.Add(var2)
                            End If

                            ' If previous character was an operator add to list
                            If IsNumeric(Inpt(j - 1)) = False And Inpt(j - 1) = "." = False Then
                                var2 = d
                                bracketList.Add(var2)
                            End If

                            ' If previous character is a decimal point, add number to string then string to list
                            If Inpt(j - 1) = "." Then
                                var2 = var2 + d
                                bracketList.Add(var2)
                            End If

                            ' If the number is not the first or last character in the bracket
                            ' If previous character is a decimal place, add to string
                        ElseIf Inpt(j - 1) = "." Then
                            var2 = var2 & d

                            ' If the following character is an operator add to list
                            If Inpt(j + 1) = "^" Or Inpt(j + 1) = "x" Or Inpt(j + 1) = "/" Or Inpt(j + 1) = "+" Or Inpt(j + 1) = "-" Then
                                bracketList.Add(var2)
                                'If (j - 1) = i + 1 And bracketList(j - 1) = "-" Then
                                '    bracketList(j - 1) = -bracketList(j)
                                '    bracketList.RemoveAt(j)
                                'ElseIf bracketList(j - 1) = "-" And IsNumeric(bracketList(j - 2)) Then
                                '    bracketList(j - 1) = -bracketList(j)
                                '    bracketList.RemoveAt(j)
                                'End If
                            End If

                            ' If the previous character is an operator, add to string
                        ElseIf IsNumeric(Inpt(j - 1)) = False And (Inpt(j - 1) = ".") = False Then
                            var2 = d

                            ' If the next character is an operator, add to list
                            If Inpt(j + 1) = "^" Or Inpt(j + 1) = "x" Or Inpt(j + 1) = "/" Or Inpt(j + 1) = "+" Or Inpt(j + 1) = "-" Then
                                bracketList.Add(var2)
                                'If (j - 1) = i + 1 And bracketList(j - 1) = "-" Then
                                '    bracketList(j - 1) = -bracketList(j)
                                '    bracketList.RemoveAt(j)
                                'ElseIf bracketList(j - 1) = "-" And IsNumeric(bracketList(j - 2)) Then
                                '    bracketList(j - 1) = -bracketList(j)
                                '    bracketList.RemoveAt(j)
                                'End If
                            End If

                            ' If previous character is a number, then add to string
                        ElseIf IsNumeric(Inpt(j - 1)) Then
                            var2 = var2 & d

                            ' If next character is operator, add string to list
                            If Inpt(j + 1) = "^" Or Inpt(j + 1) = "x" Or Inpt(j + 1) = "/" Or Inpt(j + 1) = "+" Or Inpt(j + 1) = "-" And Char.IsLetter(d) = False Then
                                bracketList.Add(var2)

                                If bracketList.IndexOf("-") = 0 Then
                                    bracketList(0) = -bracketList(1)
                                    bracketList.RemoveAt(1)
                                    'ElseIf bracketList(j - 1) = "-" And IsNumeric(bracketList(j - 2)) Then
                                    '    bracketList(j - 1) = -bracketList(j)
                                    '    bracketList.RemoveAt(j)
                                End If
                            End If

                            ' If number is neither first or last in the string and followed by an operator add to string then list
                        ElseIf Inpt.IndexOf(")") - 1 < j > 0 And Inpt(j + 1) = "^" Or Inpt(j + 1) = "x" Or Inpt(j + 1) = "/" Or Inpt(j + 1) = "+" Or Inpt(j + 1) = "-" Then
                            var2 = d
                            bracketList.Add(var2)
                            'If (j - 1) = i + 1 And bracketList(j - 1) = "-" Then
                            '    bracketList(j - 1) = -bracketList(j)
                            '    bracketList.RemoveAt(j)
                            'ElseIf bracketList(j - 1) = "-" And IsNumeric(bracketList(j - 2)) Then
                            '    bracketList(j - 1) = -bracketList(j)
                            '    bracketList.RemoveAt(j)
                            'End If
                        End If

                        ' If character is a decimal place, add to string
                        If d = "." Then
                            var2 = var2 & d
                        End If

                        ' If character is a letter  - for trig and square root.
                        If Char.IsLetter(d) Then
                            If i = 0 Then
                                var2 = d

                                ' If the previous character is an operator, add to string.
                            ElseIf IsNumeric(Inpt(j - 1)) = False And Char.IsLetter(Inpt(j - 1)) = False Then
                                var2 = d

                                'If previous character is a letter, add to string.
                            ElseIf Char.IsLetter(Inpt(j - 1)) Then
                                var2 = var2 & d
                                ' If the next character is a number, add to string, add string to list.
                                If IsNumeric(Inpt(j + 1)) Then
                                    bracketList.Add(var2)
                                    ' If the next character is a closed bracket, add to string, add string to list.
                                ElseIf Inpt(j + 1) = "(" Then
                                    bracketList.Add(var2)
                                End If
                            End If
                        End If


                        If d = "x" Then
                            bracketList.Add(d)
                        End If


                        ' If character is operator, add to list
                        If IsNumeric(d) = False And (d = ".") = False And Char.IsLetter(d) = False Then
                            bracketList.Add(d)
                        End If
                    End If
                Next
            End If

        Next
    End Sub
End Class