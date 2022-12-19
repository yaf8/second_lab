Public Class Form10

    Dim stud(2) As student
    Dim i As Integer

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Dim s1 As student
        's1 = New student

        's1.Readdata("UU1", "Yafet", "Abebe")

    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        For i = 0 To 2
            stud(i) = New student

            stud(i).Readdata()

            DataGridView1.Rows.Add(stud(i).IDNO, stud(i).Fname, stud(i).Lname)

        Next
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class