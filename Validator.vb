Module Validator
    Function EmptyString(n As String) As Boolean
        If (n = "") Then
            Return True
        Else
            Return False
        End If
    End Function
    Function ValidGrade(grade As Integer, subject As String, Form As Form) As Boolean
        If grade < 70 Then
            MessageBox.Show(Form, "The minimun grade for" + " " + subject + " " + "is 70.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf grade > 100 Then
            MessageBox.Show(Form, "The maximum grade for" + " " + subject + " " + "is 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function
End Module
