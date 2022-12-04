Imports System.Security.Cryptography.Pkcs

Public Class Form6
    Dim max As Integer
    Dim min As Integer
    Dim avg As Integer

    Private Sub MinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinToolStripMenuItem.Click
        TextBox2.Text = min

    End Sub

    Private Sub AvgToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvgToolStripMenuItem.Click
        TextBox3.Text = avg
    End Sub


    Private Sub ReadageToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReadageToolStripMenuItem1.Click
        Dim age() As UShort
        Dim n, a, sum As Integer
        Dim t As String
        n = InputBox("enter number of student")
        ReDim age(n - 1)

        For i = 0 To n - 1

            age(i) = InputBox("enetr age")

            ListBox1.Items.Add(age(i) & vbCrLf)

            sum += age(i)
            max = age(i)
            min = age(i)

            For j = 0 To n - 1
                If age(j) > max Then
                    max = age(j)

                End If
                If age(j) < min Then


                    min = age(j)


                End If

            Next

        Next


        avg = sum / n



    End Sub

    Private Sub MaxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaxToolStripMenuItem.Click
        TextBox1.Text = max
    End Sub
End Class