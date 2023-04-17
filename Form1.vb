Public Class Form1
    Private Sub BtnCompute_Click(sender As Object, e As EventArgs) Handles BtnCompute.Click
        If EmptyString(txtenglish.Text) Or EmptyString(txtfilipino.Text) Or EmptyString(txtmath.Text) Or EmptyString(txtscience.Text) Then
            MessageBox.Show(Me, "Please fill the empty grades", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not ValidGrade(Val(txtenglish.Text), "English", Me) Or
        Not ValidGrade(Val(txtmath.Text), "Math", Me) Or
        Not ValidGrade(Val(txtscience.Text), "Science", Me) Or
        Not ValidGrade(Val(txtfilipino.Text), "Filipino", Me) Then
            Exit Sub
        End If


        Dim grade As Decimal = AverageGrade({Val(txtenglish.Text), Val(txtfilipino.Text), Val(txtmath.Text), Val(txtscience.Text)})
        gradetext.Text = grade.ToString()

        RemarksCheck(grade, remarkstext)
        StatusCheck(grade, statustext)
    End Sub
End Class
