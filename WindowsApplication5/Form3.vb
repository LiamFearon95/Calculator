Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim eqn As String = txtDispl.Text

        ' Creating a list of the operators
        Dim opsList2 As New List(Of String)(eqn.Split(CChar(("0")), CChar(("1")), CChar(("2")), CChar(("3")), CChar(("4")), CChar(("5")), CChar(("6")), CChar(("7")), CChar(("8")), CChar(("9"))))
        ' Creating a list of the numbers.
        Dim numsList2 As New List(Of String)(eqn.Split(CChar(("/")), CChar(("x")), CChar(("+")), CChar(("-")), CChar(("^")), ("o"), ("i"), ("a"), ("("), (")")))

        ' Removing blank spaces in the operators list.
        For i = opsList2.Count() - 1 To 0 Step -1
            If opsList2.Contains("") Then
                opsList2.Remove("")
            End If
        Next

        ' Removing blank spaces in the numbers list.
        For i = numsList2.Count() - 1 To 0 Step -1
            If numsList2.Contains("") Then
                numsList2.Remove("")
            End If
        Next

        ' Calculations
        For i = opsList2.Count - 1 To 0 Step -1
            If opsList2.Count >= numsList2.Count And eqn.StartsWith("-") Then
                opsList2.RemoveAt(0)
                numsList2(0) = -numsList2(0)

                If opsList2.Contains("x-") Then
                    Dim negPos = opsList2.IndexOf("x-")
                    opsList2(negPos) = "x"
                    numsList2(negPos + 1) = -numsList2(negPos + 1)

                    ' Multiplication
                    If opsList2.Contains("x") Then
                        Dim opPos2 As Integer
                        opPos2 = opsList2.IndexOf("x")
                        Dim numPosToDel2 As Integer = opPos2 + 1
                        Dim ans2 As Double
                        ans2 = numsList2(opPos2) * numsList2(opPos2 + 1)
                        opsList2.Remove(opsList2(opPos2))
                        numsList2.RemoveAt(numPosToDel2)
                        numsList2(opPos2) = ans2
                        txtDispl2.Text = ans2
                    End If
                End If
            End If
        Next
    End Sub
End Class