Public Class Form4
    Dim pr As Double

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("prod 1")
        ListBox1.Items.Add("prod 2")
        ListBox1.Items.Add("prod 3")
        ListBox1.Items.Add("prod 4")
        ListBox1.Items.Add("prod 5")

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedIndex

            Case 0
                TextBox1.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()





                pr = 10
                TextBox2.Text = pr
            Case 1
                TextBox1.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
                pr = 20
                TextBox2.Text = pr
            Case 2
                TextBox1.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
                pr = 30
                TextBox2.Text = pr
            Case 3
                TextBox1.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
                pr = 40
                TextBox2.Text = pr
            Case 4
                TextBox1.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
                pr = 50
                TextBox2.Text = pr


        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim t As Double = TextBox1.Text

        Dim t4 As Double = t * pr
        TextBox3.Text = t4
        Dim t5 As Double = t4 * 0.15
        TextBox4.Text = t5
        Dim t1 As Double = TextBox3.Text
        Dim t2 As Double = TextBox4.Text

        Dim t6 As Double = t1 + t2

        TextBox5.Text = t6








    End Sub
End Class