Module Compute
    Function AverageGrade(gradelist() As Integer) As Decimal
        Dim n As Integer = 0
        For Index As Integer = 0 To gradelist.Length - 1
            n += gradelist(Index)
        Next
        Return n / gradelist.Length
    End Function
    Sub RemarksCheck(grade As Decimal, label As Label)
        If grade < 75 Then
            label.Text = "Try again next quarter"
        ElseIf grade >= 75 And grade <= 79 Then
            label.Text = "Study Well"
        ElseIf grade >= 80 And grade <= 85 Then
            label.Text = "Good"
        ElseIf grade >= 86 And grade <= 91 Then
            label.Text = "Very Good"
        ElseIf grade >= 92 And grade <= 97 Then
            label.Text = "Excellent"
        ElseIf grade >= 98 And grade <= 100 Then
            label.Text = "Achiever"
        End If
    End Sub
    Sub StatusCheck(grade As Decimal, label As Label)
        If grade < 75 Then
            label.Text = "Failed"
        ElseIf grade >= 75 And grade <= 100 Then
            label.Text = "Passed"
        End If
    End Sub
End Module