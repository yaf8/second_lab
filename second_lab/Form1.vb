Public Class Form1
    Private Sub a(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub b(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub c(sender As Object, e As EventArgs) Handles TimeToolStripMenuItem.Click
        Label1.Text = TimeString



    End Sub

    Private Sub d(sender As Object, e As EventArgs) Handles DateToolStripMenuItem.Click
        Label1.Text = DateString



    End Sub

    Private Sub Background(sender As Object, e As EventArgs) Handles BackgroundToolStripMenuItem.Click, BackgroundToolStripMenuItem1.Click

        ColorDialog1.ShowDialog()
        Label1.BackColor = ColorDialog1.Color

    End Sub



    Private Sub Foregr(sender As Object, e As EventArgs) Handles ForegroundToolStripMenuItem.Click, ForegroundToolStripMenuItem1.Click

        ColorDialog1.ShowDialog()
        Label1.ForeColor = ColorDialog1.Color

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form5.Show()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form6.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form7.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form8.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form10.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Form11.Show()
    End Sub
End Class
