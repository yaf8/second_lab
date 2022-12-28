Public Class Form11
    Private Sub AddNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewToolStripMenuItem.Click
        AddNewStaff.Show()
    End Sub

    Private Sub ViewProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewProfileToolStripMenuItem.Click
        AllStaffProfile.Show()
    End Sub

    Private Sub AddNewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddNewToolStripMenuItem1.Click
        AddNewDepartment.Show()
    End Sub

    Private Sub ViewProfileToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewProfileToolStripMenuItem1.Click
        DepartmentDetails.Show()
    End Sub

    Private Sub ViewMemberStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewMemberStaffToolStripMenuItem.Click
        DepartmentMemberStaff.Show()
    End Sub
End Class