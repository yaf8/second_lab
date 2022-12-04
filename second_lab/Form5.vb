



Public Class Form5
    Dim temp(6), sum As Double
    Dim t As String

    Dim avg As Single
    Dim i, j As Integer
    Dim max As Double
    Dim min As Double



    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked = True) Then
            TextBox3.Text = max
        End If
        If (CheckBox2.Checked = False) Then
            TextBox3.Clear()
        End If


    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If (CheckBox3.Checked = True) Then
            TextBox4.Text = min
        End If
        If (CheckBox3.Checked = False) Then
            TextBox4.Clear()
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Dim tem(6) As Double

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load






        For i = 0 To 6



            temp(i) = InputBox("enter day " & i + 1 & " tempature")
            t += "day " & i + 1 & " temprature " & temp(i) & vbCrLf
            sum += temp(i)

            max = temp(i)
            min = temp(i)

            For j = 0 To 6

                If temp(j) > max Then


                    max = temp(j)


                End If
                If temp(j) < min Then


                    min = temp(j)


                End If



            Next





        Next





        avg = sum / 7
        TextBox1.Text = t & " sum  " & sum


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked = True
            ) Then
            TextBox2.Text = avg
        End If
        If (CheckBox1.Checked = False) Then
            TextBox2.Clear()
        End If

    End Sub
End Class