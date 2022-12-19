Public Class Form9
    Private Sub SearchByIDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchByIDToolStripMenuItem.Click
        Dim id As String
        Dim j As Integer
        id = InputBox("Enter ID to SEARCH : ")


        For j = 0 To UBound(StudentRecord)
            If id = StudentRecord(j).IDNO Then
                DataGridView3.Rows.Add(StudentRecord(j).IDNO, StudentRecord(j).Fname, StudentRecord(j).Sex, StudentRecord(j).Dept)
            End If
        Next
    End Sub

    Private Sub SearchByFNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchByFNameToolStripMenuItem.Click
        Dim fName As String
        Dim j As Integer
        fName = InputBox("Enter First Name to SEARCH : ")

        For j = 0 To UBound(StudentRecord)
            If fName = StudentRecord(j).Fname Then
                DataGridView3.Rows.Add(StudentRecord(j).IDNO, StudentRecord(j).Fname, StudentRecord(j).Sex, StudentRecord(j).Dept)
            End If
        Next
    End Sub
End Class