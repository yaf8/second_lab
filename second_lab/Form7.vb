Public Class Form7

    Structure Student
        Dim IDNO As String
        Dim Fname As String
        Dim Age As Integer
    End Structure

    Dim StudentRecord(2) As Student

    Private Sub InputButton_Click(sender As Object, e As EventArgs) Handles InputButton.Click
        Dim I As Integer
        For I = 0 To UBound(StudentRecord)
            StudentRecord(I).IDNO = InputBox("Enter ID Number " & (I + 1) & " :  ")
            StudentRecord(I).Fname = InputBox("Enter First Name " & (I + 1) & " :  ")
            StudentRecord(I).Age = InputBox("Enter Age " & (I + 1) & " :  ")
        Next
    End Sub

    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        Dim I As Integer
        For I = 0 To UBound(StudentRecord)
            DataGridView1.Rows.Add(StudentRecord(I).IDNO, StudentRecord(I).Fname, StudentRecord(I).Age)
        Next
    End Sub
End Class