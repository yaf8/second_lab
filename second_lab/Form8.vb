Public Class Form8
    Dim N As Integer
    Structure Student
        Dim IDNO As String
        Dim Fname As String
        Dim Sex As String
        Dim Dept As String
    End Structure

    Dim StudentRecord() As Student
    Private Sub AddNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewToolStripMenuItem.Click
        N = InputBox("Enter Number of Students to ADD : ", "New number of Students")
        ReDim StudentRecord(N - 1)

        Dim I As Integer
        For I = 0 To UBound(StudentRecord)
            StudentRecord(I).IDNO = InputBox("Enter ID Number " & (I + 1) & " :  ")
            StudentRecord(I).Fname = InputBox("Enter First Name " & (I + 1) & " :  ")
            StudentRecord(I).Sex = InputBox("Enter Sex " & (I + 1) & " :  ")
            StudentRecord(I).Dept = InputBox("Enter Department " & (I + 1) & " :  ")
        Next

    End Sub

    Private Sub ViewAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAllToolStripMenuItem.Click
        Dim I As Integer
        For I = 0 To UBound(StudentRecord)
            DataGridView1.Rows.Add(StudentRecord(I).IDNO, StudentRecord(I).Fname, StudentRecord(I).Sex, StudentRecord.(I).Dept)
        Next
    End Sub
End Class